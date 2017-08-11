Imports FileHelpers

Public Class TrimConvertor
    Inherits ConverterBase

    Public Overrides Function StringToField(from As String) As Object

        Return Left(from, 10)

    End Function
End Class
