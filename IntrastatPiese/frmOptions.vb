Public Class frmOptions

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If dlgMDB IsNot Nothing Then
            If dlgMDB.ShowDialog = DialogResult.Cancel Then Exit Sub
            txtDBPath.Text = dlgMDB.FileName
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtDBPath.Text = Nothing Or txtDBPath.Text = "" Then
            MsgBox("Campurile marcate cu rosu trebuiesc completate!", MsgBoxStyle.Exclamation)
        Else
            My.Settings.Save()
            If My.Settings.asRestart = True Then
                My.Settings.asRestart = False
                My.Settings.Save()
                Application.Restart()
            End If
            Me.Close()
        End If
        
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If My.Settings.asRestart = True Then
            Application.Exit()
        Else
            My.Settings.Reload()
            Me.Close()
        End If
    End Sub

    Private Sub txtDBPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDBPath.TextChanged
        If txtDBPath.Text = Nothing Then
            txtDBPath.BackColor = Color.Red
        Else
            txtDBPath.BackColor = Color.White
        End If
    End Sub

    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If txtDBPath.Text = Nothing Then txtDBPath.BackColor = Color.Red
    End Sub

    Private Sub txtDeci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDeci.TextChanged
        For Each c As Char In txtDeci.Text
            If Not Char.IsDigit(c) Then
                txtDeci.Text = Replace(txtDeci.Text, c, Nothing)
                MsgBox("Campul accepta doar valori numerice!", MsgBoxStyle.Information)
            End If

        Next
    End Sub
End Class