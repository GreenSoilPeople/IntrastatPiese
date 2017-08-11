Imports System.ComponentModel
Imports System.IO
Imports FileHelpers

Public Class frmMain

    Private dfErr As DataFilter
    Private intra As IntraFile

    Private Sub frmMain_Load() Handles MyBase.Load
        Try

            Dim ci As New Globalization.CultureInfo("ro-RO")
            'ci.DateTimeFormat.ShortDatePattern = "yyyymmdd"
            Threading.Thread.CurrentThread.CurrentCulture = ci

            'ts_btnConfig.Image = il32.Images.Item("Advanced Options.ico")
            'ts_btnHelp.Image = il32.Images.Item("help.ico")
            hpIntrastat.HelpNamespace = Application.StartupPath & "\help\Intrastat Piese.chm"


        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub bwImport_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles bwImport.DoWork
        Try

            intra = New IntraFile

            intra.ImportFile(e.Argument)

            e.Result = intra
        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub bwImport_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles bwImport.RunWorkerCompleted
        Try
            'btnImport.Enabled = True
            'btnExport.Enabled = True
            'btnErrCN8.Enabled = True
            'btnCorrect.Enabled = True
            'btnGenExp.Enabled = True

            intra = e.Result
            dgvData.DataSource = intra.Data
            pbImport.Visible = False
            dgvData.Columns.Item("id").Visible = False
            ss_lblImport.Text = "Ready"
            TabControl1.SelectedTab = TabControl1.Controls.Item(0)

        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub bwExport_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles bwExport.DoWork
        Try

            intra.ExportFile(e.Argument)


        Catch ex As Exception
            MsgBox(ex.Source & ": " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    'Private Sub btnBrowse_Click() Handles btnBrowseImp.Click
    '    If dlgImport IsNot Nothing Then
    '        If dlgImport.ShowDialog = DialogResult.Cancel Then Exit Sub
    '        txtPathImp.Text = dlgImport.FileName
    '    End If
    'End Sub

    'Private Sub btnImport_Click(sender As Object, e As EventArgs)

    '    Try
    '        If txtPathImp.Text = Nothing Then
    '            MsgBox("Trebuie sa selectati calea catre fisierul de import!", MsgBoxStyle.Information)
    '        Else

    '            ss_lblImport.Text = "Importing data..."
    '            pbImport.Visible = True


    '            btnImport.Enabled = False
    '            btnExport.Enabled = False
    '            btnErrCN8.Enabled = False
    '            btnCorrect.Enabled = False

    '            bwImport.RunWorkerAsync()
    '        End If
    '    Catch ex As Exception

    '    End Try

    'End Sub

    'Private Sub btnExport_Click() Handles btnExport.Click

    '    bwExport.RunWorkerAsync(txtPathExp.Text)

    'End Sub

    'Private Sub btnErrCN8_Click() Handles btnErrCN8.Click
    '    Try

    '        'TODO: use App Settings

    '        Dim nom As String = My.Settings.asNomPath

    '        bsErr.DataSource = intra.GenerateErrors(nom)

    '        bsErr.Filter = ""


    '        For Each col As DataColumn In intra.ErrorData.Columns
    '            cmbFields.Items.Add(col.ColumnName)
    '        Next

    '        dgvErr.DataSource = bsErr
    '        'dgvErr.Columns.Item(0).Visible = False

    '        dfErr = New DataFilter(intra.ErrorData)

    '        'dgvErr.DataSource = dfErr

    '        TabControl1.SelectedTab = TabControl1.Controls.Item(1)
    '    Catch ex As Exception
    '        MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
    '    End Try
    'End Sub



    'Private Sub btnGenExp_Click() Handles btnGenExp.Click
    '    Try
    '        If bwImport.IsBusy Then
    '            MsgBox("Trebuie sa asteptati pana cand aplicatia finalizeaza procesul" & vbNewLine & "de import al datelor pentru a putea folosi aceasta optiune!", MsgBoxStyle.Exclamation)
    '            Exit Sub
    '        End If
    '        dgvExport.DataSource = intra.GenerateExport
    '        TabControl1.SelectedTab = TabControl1.Controls.Item(2)

    '    Catch ex As Exception
    '        MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
    '    End Try
    'End Sub

    'Private Sub btnBrowseExp_Click() Handles btnBrowseExp.Click
    '    If dlgExport IsNot Nothing Then
    '        If dlgExport.ShowDialog = DialogResult.Cancel Then Exit Sub
    '        txtPathExp.Text = dlgExport.FileName
    '    End If
    'End Sub

    'Private Sub btnCorrect_Click() Handles btnCorrect.Click
    '    Try

    '        dgvErr.EndEdit()

    '        intra.SaveChanges()

    '        MsgBox("Modificarile au fost salvate!")
    '    Catch ex As Exception
    '        MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
    '        Exit Try
    '    End Try
    'End Sub

    Private Sub bwExport_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwExport.RunWorkerCompleted
        Try
            'btnImport.Enabled = True
            'btnExport.Enabled = True
            'btnErrCN8.Enabled = True
            'btnCorrect.Enabled = True
            'btnGenExp.Enabled = True

            MsgBox("Datele au fost exportate cu succes")

        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnAddFilter_Click() Handles btnAddFilter.Click
        Try

            'dfErr.Filters.AddFilter(cmbFields.Text, cmbOp.Text, txtVal.Text)

            Dim flt As String
            flt = "[" & cmbFields.Text & "] " & cmbOp.Text & " "

            Select Case intra.ErrorData.Columns.Item(cmbFields.Text).DataType.Name
                Case "String", "DateTime"
                    flt += "'" & txtVal.Text & "'"
                Case Else
                    flt += txtVal.Text
            End Select

            lstFilters.Items.Add(flt)
        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnRemoveFilter_Click() Handles btnRemoveFilter.Click
        For Each itm As Integer In lstFilters.SelectedIndices
            lstFilters.Items.RemoveAt(itm)
        Next
    End Sub

    Private Sub btnSelect_Click() Handles btnSelect.Click
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

    Private Sub PasteToolStripMenuItem_Click() Handles PasteToolStripMenuItem.Click
        Dim sel_idx As New List(Of Integer)
        Dim col As String = dgvErr.Columns.Item(dgvErr.SelectedCells.Item(0).ColumnIndex).Name
        For Each cel As DataGridViewCell In dgvErr.SelectedCells
            sel_idx.Add(dgvErr.Rows.Item(cel.RowIndex).Cells.Item(0).Value)
        Next
        For i As Integer = 0 To sel_idx.Count - 1
            intra.ErrorData.Rows.Find(sel_idx(i)).Item(col) = Clipboard.GetText
        Next

    End Sub

    Private Sub DeleteToolStripMenuItem_Click() Handles DeleteToolStripMenuItem.Click
        Dim sel_idx As New List(Of Integer)
        Dim col As String = dgvErr.Columns.Item(dgvErr.SelectedCells.Item(0).ColumnIndex).Name
        For Each cel As DataGridViewCell In dgvErr.SelectedCells
            sel_idx.Add(dgvErr.Rows.Item(cel.RowIndex).Cells.Item(0).Value)
        Next
        For i As Integer = 0 To sel_idx.Count - 1
            intra.ErrorData.Rows.Find(sel_idx(i)).Item(col) = Nothing
        Next
    End Sub

    Private Sub cmbFields_TextChanged() Handles cmbFields.TextChanged
        cmbOp.Items.Clear()
        cmbOp.Text = Nothing
        Select Case intra.ErrorData.Columns.Item(cmbFields.Text).DataType.Name
            Case "Int32", "Double", "DateTime", "Date"
                cmbOp.Items.AddRange(New String() {"=", "<", "<=", ">", ">=", "<>"})
            Case "String"
                cmbOp.Items.AddRange(New String() {"=", "like", "not like"})
        End Select
    End Sub

    Private Sub ts_btnHelp_Click() Handles ts_btnHelp.Click
        Help.ShowHelp(Me, hpIntrastat.HelpNamespace)
    End Sub

    Private Sub frmMain_ResizeBegin() Handles Me.ResizeBegin
        SuspendLayout()
    End Sub

    Private Sub frmMain_ResizeEnd() Handles Me.ResizeEnd
        ResumeLayout(True)
    End Sub

    Private Sub dgvErr_CellClick() Handles dgvErr.CellClick
        dgvErr.BeginEdit(False)
    End Sub

    Private Sub dgvData_DataBindingComplete() Handles dgvData.DataBindingComplete
        dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub

    Private Sub dgvErr_DataBindingComplete() Handles dgvErr.DataBindingComplete
        dgvErr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub

    Private Sub tsbtnImport_Click(sender As Object, e As EventArgs) Handles tsbtnImport.Click

        Try

            Dim dlg As New OpenFileDialog With {
                .Filter = "TXT file|*.txt|CSV File|*.csv|All Files|*.*"
            }


            If dlg.ShowDialog = DialogResult.Cancel Then Exit Sub



            ss_lblImport.Text = "Importing data..."
            pbImport.Visible = True


            'btnImport.Enabled = False
            'btnExport.Enabled = False
            'btnErrCN8.Enabled = False
            'btnCorrect.Enabled = False

            bwImport.RunWorkerAsync(dlg.FileName)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsbtnErori_Click(sender As Object, e As EventArgs) Handles tsbtnErori.Click
        Try

            'TODO: use App Settings

            Dim nom As String = My.Settings.asNomPath

            bsErr.DataSource = intra.GenerateErrors(nom)

            bsErr.Filter = ""


            For Each col As DataColumn In intra.ErrorData.Columns
                cmbFields.Items.Add(col.ColumnName)
            Next

            dgvErr.DataSource = bsErr
            'dgvErr.Columns.Item(0).Visible = False

            dfErr = New DataFilter(intra.ErrorData)

            'dgvErr.DataSource = dfErr

            TabControl1.SelectedTab = TabControl1.Controls.Item(1)
        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub tsbtnSave_Click(sender As Object, e As EventArgs) Handles tsbtnSave.Click
        Try

            dgvErr.EndEdit()

            intra.SaveChanges()

            MsgBox("Modificarile au fost salvate!")
        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
            Exit Try
        End Try
    End Sub

    Private Sub tsbtnExport_Click(sender As Object, e As EventArgs) Handles tsbtnExport.Click

        Dim dlg As New SaveFileDialog With {
            .Filter = "Text files(.txt)|*.txt|CSV files(.csv)|*.csv|All files|*.*"
        }

        If dlg.ShowDialog = DialogResult.Cancel Then Exit Sub

        bwExport.RunWorkerAsync(dlg.FileName)

    End Sub

    Private Sub tsbtnGenExp_Click(sender As Object, e As EventArgs) Handles tsbtnGenExp.Click
        Try
            If bwImport.IsBusy Then
                MsgBox("Trebuie sa asteptati pana cand aplicatia finalizeaza procesul" & vbNewLine & "de import al datelor pentru a putea folosi aceasta optiune!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            dgvExport.DataSource = intra.GenerateExport
            TabControl1.SelectedTab = TabControl1.Controls.Item(2)

        Catch ex As Exception
            MsgBox(ex.Source & ":" & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub tsbtnConfig_Click(sender As Object, e As EventArgs) Handles tsbtnConfig.Click
        frmOptions.Show()
    End Sub
End Class
