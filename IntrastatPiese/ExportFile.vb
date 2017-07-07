Imports FileHelpers

<DelimitedRecord(";")>
Public Class ExportFile

    Public ID As Integer

    Public Supplier As Integer

    '<FieldConverter(ConverterKind.Date, "DD.MM.YYYY")>
    <FieldQuoted>
    Public DateIn As String

    <FieldQuoted>
    Public Invoice As String

    <FieldQuoted>
    Public System As String

    <FieldQuoted>
    Public PartNumber As String

    <FieldQuoted>
    Public CN8 As String

    <FieldQuoted>
    Public OrgCountry As String

    <FieldQuoted>
    Public ExpCountry As String

    <FieldQuoted>
    Public DestCountry As String

    <FieldQuoted>
    Public InvoiceType As String

    <FieldConverter(ConverterKind.Double, ",")>
    Public TotalValue As Double

    <FieldConverter(ConverterKind.Double, ",")>
    Public TotalStatisticalValue As Double

    <FieldConverter(ConverterKind.Double, ",")>
    Public Weight As Double

    Public Quantity As Integer

    Public UnitGroupCode As String

    Public DeliveryType As String

    Public TransportType As String

    Public TransactionType As String

End Class
