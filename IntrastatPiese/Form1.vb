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

        dataFile = "D:\wrk\cristina\isp.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myConnection.Open()

        Dim str As String
        'str = "SELECT * FROM intra_codes"
        str = "SELECT cn as code from NC82017 where cn <> null and len(cn) = 8"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        da = New OleDbDataAdapter(str, myConnection.ConnectionString)

        Dim dt As New DataTable

        da.Fill(dt)

        DataGridView1.DataSource = dt

        myConnection.Close()

        Dim engine As New FileHelperEngine(Of ImportFile)

        'Dim import = engine.ReadFile("D:\wrk\sql_28_120816_095822_8700.txt")

        Dim dt2 As New DataTable

        dt2 = engine.ReadFileAsDT("D:\wrk\Import dec 2016 corectat.txt")


        DataGridView2.DataSource = dt2

        Dim dtErr = (From cn8 In dt2.AsEnumerable
                     Group Join cn In dt.AsEnumerable
                      On cn8("CN8") Equals cn("code") Into j = Group
                     From c In j.DefaultIfEmpty
                     Where c Is Nothing
                     Select cn8).CopyToDataTable

        Console.WriteLine(dtErr.Rows.Count)
        DataGridView3.DataSource = dtErr

    End Sub

End Class