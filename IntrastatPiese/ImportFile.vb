﻿Imports FileHelpers

<DelimitedRecord(";")>
Public Class ImportFile
    Public Supplier As Integer

    '<FieldConverter(ConverterKind.Date, "DD.MM.YYYY")>
    <FieldConverter(GetType(StringToDateConverter))>
    <FieldQuoted>
    Public DateIn As Date

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
    Public Weight As Double 'Integer

    Public Quantity As Integer


End Class