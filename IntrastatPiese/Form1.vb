Imports System.Data.OleDb
Imports FileHelpers

Public Class Form1
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Public da As OleDbDataAdapter

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        provider = "Provider=Microsoft.jet.oledb.4.0;Data Source ="

        dataFile = "D:\wrk\cristina\isp.mdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myConnection.Open()

        Dim str As String
        str = "SELECT * FROM intra_codes"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        da = New OleDbDataAdapter(str, myConnection.ConnectionString)

        Dim dt As New DataTable

        da.Fill(dt)

        DataGridView1.DataSource = dt

        myConnection.Close()


        Dim engine As New FileHelperEngine(Of ImportFile)

        Dim import = engine.ReadFile("D:\wrk\sql_28_120816_095822_8700.txt")

    End Sub
End Class