Public Class DataFilter
    Property Filters As Filters
    Property Data As DataTable

    Public Sub New(ByRef dt As DataTable)
        Data = dt
    End Sub

    Public Function GetFilteredData() As BindingSource
        Dim bs As New BindingSource
        bs.DataSource = Data

        Dim flt As String = ""

        For Each f As Filter In Filters.ToList
            flt += $"{f.Filed} {f.Op} {f.Value}"
        Next

        MsgBox(flt)

        bs.Filter = flt

        Return bs
    End Function

    Public Function AddFilter(filed As String, op As String, value As String) As String
        Filters.AddFilter(filed, op, value, Data.Columns.Item(filed).DataType)
    End Function

End Class


Public MustInherit Class Filter
    Public MustOverride Property Filed As String
    Public MustOverride Property Op As String
    Public MustOverride Property Value As String
    Public MustOverride ReadOnly Property Type As Type
End Class

Class StringFilter
    Inherits Filter

    Private _field As String
    Private _value As String
    Private _op As String

    Public Overrides Property Value As String
        Get
            Return $"'{_value}'"
        End Get
        Set(value As String)
            _value = value
        End Set
    End Property

    Public Overrides ReadOnly Property Type As Type
        Get
            Return GetType(String)
        End Get
    End Property

    Public Overrides Property Filed As String
        Get
            Return $"[{_field}]"
        End Get
        Set(value As String)
            _field = value
        End Set
    End Property

    Public Overrides Property Op As String
        Get
            Return _op
        End Get
        Set(value As String)
            _op = value
        End Set
    End Property
End Class

Class IntegerFilter
    Inherits Filter


    Public Overrides ReadOnly Property Type As Type
        Get
            Return GetType(Integer)
        End Get
    End Property

    Public Overrides Property Filed As String
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Overrides Property Op As String
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Overrides Property Value As String
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property
End Class

Public Class Filters

    Private _filters As List(Of Filter)

    Public Sub AddFilter(filed As String, op As String, value As String, type As Type)
        Select Case type
            Case GetType(String)
                _filters.Add(New StringFilter With {.Value = value})
            Case GetType(Integer)
                _filters.Add(New IntegerFilter With {.Value = value})

        End Select
    End Sub

    Public Sub RemoveFilter(value As String)
        _filters.Remove(_filters.Find(Function(f) f.Value = value))
    End Sub

    Public Function ToList() As List(Of Filter)
        Return _filters.ToList
    End Function
End Class