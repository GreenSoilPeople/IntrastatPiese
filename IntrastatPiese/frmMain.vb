Imports System.Data.OleDb
Imports System.IO
Public Class frmMain
    Dim sConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Settings.asDBPath
    Dim ds As New DataSet()
    Dim da As New OleDbDataAdapter("select * from Ro_intrastat_2006_02", sConn)
    Dim cb As New OleDbCommandBuilder(da)
    Dim da_errcn8 As New OleDbDataAdapter("SELECT Ro_intrastat_2006_02.* FROM Ro_intrastat_2006_02 LEFT JOIN intra_codes ON Ro_intrastat_2006_02.cn8=intra_codes.code WHERE intra_codes.code Is Null;", sConn)
    Dim ds_errcn8 As New DataSet
    Dim cb_errcn8 As New OleDbCommandBuilder(da_errcn8)
    Dim dt_errcn8 As New DataTable
    Dim ds_export As New DataSet
    Dim da_export As New OleDbDataAdapter("SELECT 429 AS supplier_id, " & IIf(Now.Month = 1, Now.Year - 1 & "12", Now.Year & IIf(Now.Month < 10, "0" & Now.Month - 1, Now.Month - 1)) & "01 as [data intrare], system AS application_of_origin, '' AS product_description, cn8, [tara sursa], [tara exp], [tara dest],sum( [total valoare]),sum( [total statistic]),sum( greut), unitgroup_code, sum(cant), delivery_type, transport_type, transaction_type FROM Ro_intrastat_2006_02 where delivery_type is not null and transport_type is not null and transaction_type is not null and cn8 is not null group by system, cn8, unitgroup_code, delivery_type, transport_type, transaction_type, [tara sursa], [tara exp], [tara dest] UNION SELECT 429 AS supplier_id, format([data intr], 'yyyyMMdd') AS invoice_date, system AS application_of_origin,'FF ' + [factura]  AS product_description, cn8, [tara sursa], [tara exp], [tara dest], [total valoare], [total statistic], greut, unitgroup_code, cant, delivery_type, transport_type, transaction_type FROM Ro_intrastat_2006_02 where delivery_type is null or transport_type is null or transaction_type is null or cn8 is null;", sConn)
    Dim cb_export As New OleDbCommandBuilder(da_export)

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ts_btnConfig.Image = il32.Images.Item("Advanced Options.ico")
            ts_btnHelp.Image = il32.Images.Item("help.ico")
            hpIntrastat.HelpNamespace = Application.StartupPath & "\help\Intrastat Piese.chm"

            If My.Settings.asDBPath = Nothing Or My.Settings.asDBPath = "" Then
                frmOptions.Show()
                My.Settings.asRestart = True
                My.Settings.Save()
                Me.Dispose(True)
            Else
                da.Fill(ds, "Ro_intrastat_2006_02")
                ds.Tables(0).PrimaryKey = New DataColumn() {ds.Tables(0).Columns.Item(0)}
                dgvData.DataSource = ds.Tables(0)
                dgvData.Columns.Item(0).Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub bwImport_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwImport.DoWork
        Try
            Dim sConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Settings.asDBPath
            'Dim da_del As New OleDbDataAdapter("delete * from Ro_intrastat_2006_02", sConn)
            'Dim cb_del As New OleDbCommandBuilder(da_del)
            'Dim ds_del As New DataSet

            'da_del.Fill(ds_del, "Ro_intrastat_2006_02")
            'cb_del.QuotePrefix = "["
            'cb_del.QuoteSuffix = "]"
            'ds_del.AcceptChanges()

            Dim da_del = New OleDbDataAdapter("select * from Ro_intrastat_2006_02", sConn)
            Dim cb_del As New OleDbCommandBuilder(da_del)
            Dim ds_del As New DataSet
            da_del.Fill(ds_del, "Ro_intrastat_2006_02")
            cb_del.DataAdapter = da_del
            cb_del.QuotePrefix = "["
            cb_del.QuoteSuffix = "]"

            Dim dt1 As New DataTable

            For Each col As DataGridViewColumn In dgvData.Columns
                dt1.Columns.Add(col.Name)
                dt1.Columns(dt1.Columns.Count - 1).DataType = col.ValueType
            Next


            Dim lst(18) As Object
            Dim txtsplit() As String
            Dim id As Integer = 1
            For Each line As String In File.ReadAllLines(e.Argument, System.Text.Encoding.Default)
                bwImport.ReportProgress(0)
                line = line.Replace(ControlChars.Quote, "")
                line = id & ";" & line
                txtsplit = line.Split(";")
                For i = 0 To 18
                    Select Case i
                        Case 1, 14
                            If txtsplit(i) IsNot Nothing Then lst(i) = CType(txtsplit(i), Integer)
                        Case 10
                            If txtsplit(i) = "H" Then lst(i) = 1
                            If txtsplit(i) = "P" Then lst(i) = 9
                        Case 11 To 13
                            If txtsplit(i) IsNot "" Then
                                Select Case System.Globalization.CultureInfo.InstalledUICulture.NumberFormat.NumberDecimalSeparator
                                    Case ","
                                        txtsplit(i) = Replace(txtsplit(i), ".", ",")
                                    Case "."
                                        txtsplit(i) = Replace(txtsplit(i), ",", ".")
                                End Select
                                lst(i) = CType(txtsplit(i), Decimal)
                            End If
                        Case 15
                            lst(15) = 796
                        Case 16
                            If txtsplit(1) = 3 Or txtsplit(1) = 90 Or txtsplit(1) = 92 Then
                                lst(16) = "EXW"
                            End If
                        Case 17
                            If txtsplit(1) = 3 Or txtsplit(1) = 90 Or txtsplit(1) = 92 Then
                                lst(17) = 3
                            End If
                        Case 18
                            lst(18) = 11
                        Case Else
                            lst(i) = txtsplit(i)
                    End Select
                Next
                dt1.Rows.Add(lst)
                id += 1
            Next
            cb_del.DataAdapter = da_del
            cb_del.QuotePrefix = "["
            cb_del.QuoteSuffix = "]"
            da_del.Update(dt1)
            dt1.AcceptChanges()

        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub bwImport_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwImport.RunWorkerCompleted
        Try
            btnImport.Enabled = True
            btnExport.Enabled = True
            btnErrCN8.Enabled = True
            btnCorrect.Enabled = True
            btnGenExp.Enabled = True

            da.Fill(ds, "Ro_intrastat_2006_02")
            ds.Tables(0).PrimaryKey = New DataColumn() {ds.Tables(0).Columns.Item(0)}
            dgvData.DataSource = ds.Tables(0)
            pbImport.Visible = False
            ss_lblImport.Text = "Ready"
        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub bwExport_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwExport.DoWork
        Try
            Dim fs As New FileStream(e.Argument, FileMode.Create, FileAccess.Write)
            Dim sw As New StreamWriter(fs, System.Text.Encoding.Default)
            Dim exp As String
            For Each dr As DataRow In ds_export.Tables(0).Rows
                If bwExport.CancellationPending Then
                    e.Cancel = True
                    sw.Close()
                    fs.Close()
                    Exit Sub
                End If
                exp = Nothing
                For i As Integer = 0 To ds_export.Tables(0).Columns.Count - 1
                    Select Case i
                        Case 0
                            exp = dr.Item(0)
                        Case 8 To 10
                            dr.Item(i) = Math.Round(dr.Item(i), My.Settings.asDeci)
                            dr.Item(i) = Replace(dr.Item(i), ",", ".")
                            exp += vbTab & dr.Item(i)
                        Case Else
                            exp += vbTab & dr.Item(i)
                    End Select

                Next
                sw.WriteLine(exp)
                bwExport.ReportProgress(0.0)
            Next
            sw.Close()
            fs.Close()
            If My.Settings.asExpDel = True Then
                Dim sConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Settings.asDBPath
                Dim da_del As New OleDbDataAdapter("delete * from Ro_intrastat_2006_02", sConn)
                Dim cb_del As New OleDbCommandBuilder(da_del)
                Dim ds_del As New DataSet
                da_del.Fill(ds_del, "Ro_intrastat_2006_02")
                cb_del.QuotePrefix = "["
                cb_del.QuoteSuffix = "]"
                ds_del.AcceptChanges()

            End If
            MsgBox("Datele au fost exportate cu succes")
        Catch ex As Exception
            MsgBox(ex.Source & ": " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseImp.Click
        If dlgImport IsNot Nothing Then
            If dlgImport.ShowDialog = DialogResult.Cancel Then Exit Sub
            txtPathImp.Text = dlgImport.FileName
        End If
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Try
            If txtPathImp.Text = Nothing Then
                MsgBox("Trebuie sa selectati calea catre fisierul de import!", MsgBoxStyle.Information)
            Else
                ss_lblImport.Text = "Importing data..."
                pbImport.Visible = True


                btnImport.Enabled = False
                btnExport.Enabled = False
                btnErrCN8.Enabled = False
                btnCorrect.Enabled = False
                btnGenExp.Enabled = False

                Dim da_del As New OleDbDataAdapter("delete * from Ro_intrastat_2006_02", sConn)
                Dim cb_del As New OleDbCommandBuilder(da_del)
                Dim ds_del As New DataSet

                da_del.Fill(ds_del, "Ro_intrastat_2006_02")
                cb_del.QuotePrefix = "["
                cb_del.QuoteSuffix = "]"
                ds_del.AcceptChanges()
                ds.Tables(0).Clear()
                bwImport.RunWorkerAsync(txtPathImp.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If bwImport.IsBusy Then
            MsgBox("Trebuie sa asteptati pana cand aplicatia finalizeaza procesul" & vbNewLine & "de import al datelor pentru a putea folosi aceasta optiune!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If txtPathExp.Text = Nothing Then
            MsgBox("Trebuie sa selectati calea catre fisierul de export!", MsgBoxStyle.Information)
        ElseIf ds_export.Tables.Count = 0 Then
            MsgBox("Nu au fost gasite date pentru export!" & vbNewLine & "Trebuie sa generati date de export.", MsgBoxStyle.Information)
        Else
            bwExport.RunWorkerAsync(txtPathExp.Text)

            btnImport.Enabled = False
            btnExport.Enabled = False
            btnErrCN8.Enabled = False
            btnCorrect.Enabled = False
            btnGenExp.Enabled = False
        End If
    End Sub

    Private Sub btnErrCN8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnErrCN8.Click
        Try
            If ds_errcn8.Tables.Count > 0 Then
                ds_errcn8.Tables(0).Clear()
                bsErr.DataSource = Nothing
            End If

            da_errcn8.Fill(ds_errcn8, "Errors_cn8")
            ds_errcn8.Tables(0).PrimaryKey = New DataColumn() {ds_errcn8.Tables(0).Columns.Item(0)}
            bsErr.DataSource = ds_errcn8.Tables(0)
            dgvErr.DataSource = bsErr
            bsErr.Filter = ""
            dgvErr.Columns.Item(0).Visible = False
            For Each col As DataColumn In ds_errcn8.Tables(0).Columns
                cmbFields.Items.Add(col.ColumnName)
            Next

            TabControl1.SelectedTab = TabControl1.Controls.Item(1)
        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ts_btnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_btnConfig.Click
        frmOptions.Show()
    End Sub

    Private Sub btnGenExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenExp.Click
        Try
            If bwImport.IsBusy Then
                MsgBox("Trebuie sa asteptati pana cand aplicatia finalizeaza procesul" & vbNewLine & "de import al datelor pentru a putea folosi aceasta optiune!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If ds_export.Tables.Count > 0 Then ds_export.Tables(0).Clear()
            da_export.Fill(ds_export, "Export")
            dgvExport.DataSource = ds_export.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnBrowseExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseExp.Click
        If dlgExport IsNot Nothing Then
            If dlgExport.ShowDialog = DialogResult.Cancel Then Exit Sub
            txtPathExp.Text = dlgExport.FileName
        End If
    End Sub

    Private Sub btnCorrect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorrect.Click
        Try
            If ds_errcn8.Tables.Count = 0 Or ds_errcn8.Tables(0).GetChanges.Rows.Count = 0 Then Exit Try
            dgvErr.EndEdit()
            For Each dr As DataRow In ds_errcn8.Tables(0).GetChanges.Rows
                ds.Tables(0).Rows.Find(dr.Item(0)).ItemArray = dr.ItemArray
            Next
            If cb.QuotePrefix = Nothing Then cb.QuotePrefix = "["
            If cb.QuoteSuffix = Nothing Then cb.QuoteSuffix = "]"
            Me.BindingContext(ds.Tables(0)).EndCurrentEdit()
            da.Update(ds.Tables(0))
            ds.AcceptChanges()
            MsgBox("Modificarile au fost salvate!")
        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
            Exit Try
        End Try
    End Sub

    Private Sub bwExport_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwExport.RunWorkerCompleted
        Try
            btnImport.Enabled = True
            btnExport.Enabled = True
            btnErrCN8.Enabled = True
            btnCorrect.Enabled = True
            btnGenExp.Enabled = True

            ds.Tables(0).Clear()
            da.Fill(ds, "Ro_intrastat_2006_02")
            ds.Tables(0).PrimaryKey = New DataColumn() {ds.Tables(0).Columns.Item(0)}
            dgvData.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnAddFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFilter.Click
        Try
            Dim flt As String
            flt = "[" & cmbFields.Text & "] " & cmbOp.Text & " "

            Select Case ds_errcn8.Tables(0).Columns.Item(cmbFields.Text).DataType.Name
                Case "String", "DateTime"
                    If cmbOp.Text = "like" Then
                        flt += "'%" & txtVal.Text & "%'"
                    Else
                        flt += "'" & txtVal.Text & "'"
                    End If

                Case Else
                    flt += txtVal.Text
            End Select

            lstFilters.Items.Add(flt)
        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnRemoveFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFilter.Click
        For Each itm As Integer In lstFilters.SelectedIndices
            lstFilters.Items.RemoveAt(itm)
        Next
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Try
            If lstFilters.Items.Count = 0 Then
                bsErr.RemoveFilter()
            End If
            Dim fil As String = Nothing
            For i As Integer = 0 To lstFilters.Items.Count - 1
                If i = 0 Then
                    fil = lstFilters.Items(0)
                Else
                    fil += " and " & lstFilters.Items(i)
                End If
            Next
            bsErr.Filter = fil
            dgvErr.DataSource = bsErr
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Dim sel_idx As New List(Of Integer)
        Dim col As String = dgvErr.Columns.Item(dgvErr.SelectedCells.Item(0).ColumnIndex).Name
        For Each cel As DataGridViewCell In dgvErr.SelectedCells
            sel_idx.Add(dgvErr.Rows.Item(cel.RowIndex).Cells.Item(0).Value)
        Next
        For i As Integer = 0 To sel_idx.Count - 1
            ds_errcn8.Tables(0).Rows.Find(sel_idx(i)).Item(col) = Clipboard.GetText
        Next
  
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim sel_idx As New List(Of Integer)
        Dim col As String = dgvErr.Columns.Item(dgvErr.SelectedCells.Item(0).ColumnIndex).Name
        For Each cel As DataGridViewCell In dgvErr.SelectedCells
            sel_idx.Add(dgvErr.Rows.Item(cel.RowIndex).Cells.Item(0).Value)
        Next
        For i As Integer = 0 To sel_idx.Count - 1
            ds_errcn8.Tables(0).Rows.Find(sel_idx(i)).Item(col) = Nothing
        Next
    End Sub

    Private Sub cmbFields_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFields.TextChanged
        'MsgBox(ds_errcn8.Tables(0).Columns.Item(cmbFields.Text).DataType.Name)
        cmbOp.Items.Clear()
        cmbOp.Text = Nothing
        Select Case ds_errcn8.Tables(0).Columns.Item(cmbFields.Text).DataType.Name
            Case "Int32", "Double", "DateTime"
                cmbOp.Items.AddRange(New String() {"=", "<", "<=", ">", ">=", "<>"})
            Case "String"
                cmbOp.Items.AddRange(New String() {"=", "like", "not like"})
        End Select
    End Sub

    Private Sub ts_btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_btnHelp.Click
        Help.ShowHelp(Me, hpIntrastat.HelpNamespace)
    End Sub
End Class
