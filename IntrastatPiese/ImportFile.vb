Imports FileHelpers

<DelimitedRecord(";")>
Public Class ImportFile
    Public Supplier As Integer

    '<FieldConverter(ConverterKind.Date, "DD.MM.YYYY")>
    Public DateIn As DateTime

    Public Invoice As String

    Public System As String

    Public PartNumber As String

    Public CN8 As String

    Public OrgCountry As String

    Public ExpCountry As String

    Public DestCountry As String

    Public InvoiceType As String

    <FieldConverter(ConverterKind.Double, ",")>
    Public TotalValue As Double

    <FieldConverter(ConverterKind.Double, ",")>
    Public TotalStatisticalValue As Double

    Public Weight As Integer

    Public Quantity As Integer


End Class
