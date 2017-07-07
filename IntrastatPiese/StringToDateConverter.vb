Imports FileHelpers
Imports System.Text.RegularExpressions
Public Class StringToDateConverter
    Inherits ConverterBase

    Public Overrides Function StringToField(from As String) As Object

        Dim dt As DateTime = from

        'Dim dtfi As Globalization.DateTimeFormatInfo = Globalization.CultureInfo.CreateSpecificCulture("").DateTimeFormat
        'dtfi.ShortDatePattern = "YYYYmmdd"

        'dt.GetDateTimeFormats(dtfi)

        'dt.Date.ToBinary()


        Return dt.Date

    End Function
End Class
