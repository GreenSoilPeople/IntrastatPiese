Imports System.ComponentModel
Imports System.Globalization
Imports FileHelpers

Public Class IntraFile
    Property Path As String
    Property Data As DataTable
    Property ExportData As DataTable
    Property ErrorData As DataTable

    ''' <summary>
    ''' Read data from a CSV file into a DataTable
    ''' </summary>
    ''' <param name="path">Path to the CSV file</param>
    ''' <returns>DataTable</returns>
    Public Function ImportFile(path As String) As DataTable
        Me.Path = path
        Data = New FileHelperEngine(Of ImportFile)().ReadFileAsDT(path)
        Data = ProccessImport(Data)
        Return Data
    End Function

    ''' <summary>
    ''' Write DataTable to CSV file
    ''' </summary>
    ''' <param name="path">Path to VSC file</param>
    Public Sub ExportFile(path As String)
        CsvEngine.DataTableToCsv(ExportData, path, ControlChars.Tab)
    End Sub

    ''' <summary>
    ''' Save changes made to Data
    ''' </summary>
    Public Sub SaveChanges()
        For Each dr As DataRow In ErrorData.GetChanges.Rows
            For i As Integer = 0 To dr.ItemArray.Count - 1
                If dr(i) Is DBNull.Value Then dr(i) = ""
            Next
            Data.Rows.Find(dr.Item(0)).ItemArray = dr.ItemArray

        Next

        Data.AcceptChanges()

    End Sub

    ''' <summary>
    ''' Return DataTable containing validation errors by comparing Data to nomenclature
    ''' </summary>
    ''' <param name="nomenclatorPath">Nomenclature file path</param>
    ''' <returns>DataTable</returns>
    Public Function GenerateErrors(nomenclatorPath As String) As DataTable
        Dim dtNom As New DataTable

        dtNom = New FileHelperEngine(Of Nomenclator)().ReadFileAsDT(nomenclatorPath)

        Dim err = (From cn8 In Data.AsEnumerable
                   Group Join cn In dtNom.AsEnumerable
                    On cn8("CN8") Equals cn("CN") Into j = Group
                   From c In j.DefaultIfEmpty
                   Where c Is Nothing Or String.IsNullOrEmpty(cn8("CN8")) Or cn8("OrgCountry") = "" Or cn8("ExpCountry") = "" Or cn8("DestCountry") = ""
                   Select cn8)

        If err.Count = 0 Then
            Return Nothing
        End If

        ErrorData = err.CopyToDataTable

        ErrorData.PrimaryKey = {ErrorData.Columns.Item("ID")}
        Return ErrorData
    End Function

    ''' <summary>
    ''' Proccesses data for export
    ''' </summary>
    ''' <returns>DataTable</returns>
    Public Function GenerateExport() As DataTable

        Dim dt As DataTable = Data
        'dt.Columns("DateIn").DataType = GetType(String)

        Dim export = (
                From exp In dt.AsEnumerable.ToList
                Where
                    exp("DeliveryType") IsNot Nothing And
                    exp("TransportType") IsNot Nothing And
                    exp("TransactionType") IsNot Nothing And
                    exp("CN8") IsNot Nothing
                Group exp By
                    system = exp.Field(Of String)("System"),
                    cn8 = exp.Field(Of String)("CN8"),
                    Unitgroup_code = exp.Field(Of String)("UnitGroupCode"),
                    Delivery_type = exp.Field(Of String)("DeliveryType"),
                    Transport_type = exp.Field(Of String)("TransportType"),
                    Transaction_type = exp.Field(Of String)("TransactionType"),
                    TaraSursa = exp.Field(Of String)("OrgCountry"),
                    TaraExp = exp.Field(Of String)("ExpCountry"),
                    TaraDest = exp.Field(Of String)("DestCountry")
                    Into g = Group
                Select
                    supplier_id = 429,
                    DataIntr = DateTime.ParseExact(g.First()("DateIn"), "dd.MM.yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture),
                    application_of_origin = system,
                    product_description = "",
                    cn8,
                    TaraSursa,
                    TaraExp,
                    TaraDest,
                    TotalValue = Math.Round(g.Sum(Function(p) CType(p("TotalValue"), Double)), 2),
                    TotalStatisticalValue = Math.Round(g.Sum(Function(p) CType(p("TotalStatisticalValue"), Double)), 2),
                    Weight = Math.Round(g.Sum(Function(p) CType(p("Weight"), Double)), 2),
                    Unitgroup_code,
                    Quantity = g.Sum(Function(p) p("Quantity")),
                    Delivery_type,
                    Transport_type,
                    Transaction_type Order By cn8
            ).Union(
                From exp As DataRow In dt.AsEnumerable.AsParallel
                Where
                      exp.Field(Of String)("DeliveryType") Is Nothing Or
                      exp.Field(Of String)("TransportType") Is Nothing Or
                      exp.Field(Of String)("TransactionType") Is Nothing Or
                      exp.Field(Of String)("CN8") Is Nothing
                Select
                      supplier_id = 429,
                      DataIntr = DateTime.ParseExact(exp.Field(Of String)("DateIn"), "dd.MM.yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture),
                      application_of_origin = exp.Field(Of String)("System"),
                      product_description = ("FF " & exp.Field(Of String)("Invoice")),
                      Cn8 = exp.Field(Of String)("CN8"),
                      TaraSursa = exp.Field(Of String)("OrgCountry"),
                      TaraExp = exp.Field(Of String)("ExpCountry"),
                      TaraDest = exp.Field(Of String)("DestCountry"),
                      TotalValue = exp.Field(Of Double)("TotalValue"),
                      TotalStatisticalValue = exp.Field(Of Double)("TotalStatisticalValue"),
                      Weight = exp.Field(Of Double)("Weight"),
                      Unitgroup_code = exp.Field(Of String)("UnitGroupCode"),
                      Quantity = exp.Field(Of Integer)("Quantity"),
                      Delivery_type = exp.Field(Of String)("DeliveryType"),
                      Transport_type = exp.Field(Of String)("TransportType"),
                      Transaction_type = exp.Field(Of String)("TransactionType")
                )


        ExportData = PropertiesToDataTable(export)

        Return ExportData


    End Function

    ''' <summary>
    ''' Converts IEnumerable to DataTable
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="source"></param>
    ''' <returns>DataTable</returns>
    Public Shared Function PropertiesToDataTable(Of T)(ByVal source As IEnumerable(Of T)) As DataTable
        Dim dt As DataTable = New DataTable
        Dim props = TypeDescriptor.GetProperties(GetType(T))
        For Each prop As PropertyDescriptor In props
            Dim dc As DataColumn = dt.Columns.Add(prop.Name, prop.PropertyType)
            dc.Caption = prop.DisplayName
            dc.ReadOnly = prop.IsReadOnly
        Next
        For Each item As T In source
            Dim dr As DataRow = dt.NewRow
            For Each prop As PropertyDescriptor In props
                dr(prop.Name) = prop.GetValue(item)
            Next
            dt.Rows.Add(dr)
        Next
        Return dt
    End Function

    ''' <summary>
    ''' Populate DataTable with required columns
    ''' </summary>
    ''' <param name="dtSource">Source DataTable</param>
    ''' <returns>DataTable</returns>
    Private Function ProccessImport(dtSource As DataTable) As DataTable

        Dim dt As New DataTable

        dt.Columns.AddRange({
                        New DataColumn With {.ColumnName = "ID", .DataType = GetType(Integer), .AutoIncrement = True, .AutoIncrementSeed = 1, .AutoIncrementStep = 1},
                        New DataColumn With {.ColumnName = "Supplier", .DataType = GetType(Integer)},
                        New DataColumn With {.ColumnName = "DateIn", .DataType = GetType(String)},
                        New DataColumn With {.ColumnName = "Invoice", .DataType = GetType(String)},
                        New DataColumn With {.ColumnName = "System", .DataType = GetType(String)},
                        New DataColumn With {.ColumnName = "PartNumber", .DataType = GetType(String)},
                        New DataColumn With {.ColumnName = "CN8", .DataType = GetType(String)},
                        New DataColumn With {.ColumnName = "OrgCountry", .DataType = GetType(String)},
                        New DataColumn With {.ColumnName = "ExpCountry", .DataType = GetType(String)},
                        New DataColumn With {.ColumnName = "DestCountry", .DataType = GetType(String)},
                        New DataColumn With {.ColumnName = "InvoiceType", .DataType = GetType(String)},
                        New DataColumn With {.ColumnName = "TotalValue", .DataType = GetType(Double)},
                        New DataColumn With {.ColumnName = "TotalStatisticalValue", .DataType = GetType(Double)},
                        New DataColumn With {.ColumnName = "Weight", .DataType = GetType(Double)},
                        New DataColumn With {.ColumnName = "Quantity", .DataType = GetType(Integer)},
                        New DataColumn With {.ColumnName = "UnitGroupCode", .DataType = GetType(String)},
                        New DataColumn With {.ColumnName = "DeliveryType", .DataType = GetType(String)},
                        New DataColumn With {.ColumnName = "TransportType", .DataType = GetType(String)},
                        New DataColumn With {.ColumnName = "TransactionType", .DataType = GetType(String)}
                        })

        dt.PrimaryKey = {dt.Columns.Item("ID")}

        dt.Merge(dtSource)

        TransformValues(dt)

        dt.AcceptChanges()

        Return dt
    End Function

    Private Sub TransformValues(dt As DataTable)
        For Each dr As DataRow In dt.Rows
            If dr("InvoiceType") = "H" Then dr("InvoiceType") = "1"
            If dr("InvoiceType") = "P" Then dr("InvoiceType") = "9"
            If dr("Supplier") = 3 Or dr("Supplier") = 90 Or dr("Supplier") = 92 Then
                dr("DeliveryType") = "EXW"
                dr("TransportType") = "3"
            End If
            dr("UnitGroupCode") = "796"
            dr("TransactionType") = "11"
        Next
    End Sub
End Class