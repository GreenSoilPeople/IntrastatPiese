<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.il20 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.dlgMDB = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDeci = New System.Windows.Forms.TextBox
        Me.chkExpDel = New System.Windows.Forms.CheckBox
        Me.txtDBPath = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtDBPath)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 43)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MDB"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageKey = "Browse 3.ico"
        Me.Button1.ImageList = Me.il20
        Me.Button1.Location = New System.Drawing.Point(334, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 22)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'il20
        '
        Me.il20.ImageStream = CType(resources.GetObject("il20.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il20.TransparentColor = System.Drawing.Color.Transparent
        Me.il20.Images.SetKeyName(0, "Browse 3.ico")
        Me.il20.Images.SetKeyName(1, "Table 1.ico")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Database path"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 163)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Ok"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(299, 163)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dlgMDB
        '
        Me.dlgMDB.Filter = "MDB Files(.mdb)|*.mdb|All files|*.*"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDeci)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.chkExpDel)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 73)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Export"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Numarul de zecimale pentru valorile numerice neintregi -"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDeci
        '
        Me.txtDeci.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.IntrastatPiese.My.MySettings.Default, "asDeci", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtDeci.Location = New System.Drawing.Point(334, 42)
        Me.txtDeci.Name = "txtDeci"
        Me.txtDeci.Size = New System.Drawing.Size(22, 21)
        Me.txtDeci.TabIndex = 5
        Me.txtDeci.Text = Global.IntrastatPiese.My.MySettings.Default.asDeci
        '
        'chkExpDel
        '
        Me.chkExpDel.AutoSize = True
        Me.chkExpDel.Checked = Global.IntrastatPiese.My.MySettings.Default.asExpDel
        Me.chkExpDel.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.IntrastatPiese.My.MySettings.Default, "asExpDel", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkExpDel.Location = New System.Drawing.Point(6, 20)
        Me.chkExpDel.Name = "chkExpDel"
        Me.chkExpDel.Size = New System.Drawing.Size(243, 17)
        Me.chkExpDel.TabIndex = 3
        Me.chkExpDel.Text = "Goleste tablela principala dupa export"
        Me.chkExpDel.UseVisualStyleBackColor = True
        '
        'txtDBPath
        '
        Me.txtDBPath.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.IntrastatPiese.My.MySettings.Default, "asDBPath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtDBPath.Location = New System.Drawing.Point(99, 14)
        Me.txtDBPath.Name = "txtDBPath"
        Me.txtDBPath.Size = New System.Drawing.Size(229, 21)
        Me.txtDBPath.TabIndex = 1
        Me.txtDBPath.Text = Global.IntrastatPiese.My.MySettings.Default.asDBPath
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 198)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmOptions"
        Me.Text = "Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDBPath As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents il20 As System.Windows.Forms.ImageList
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents dlgMDB As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkExpDel As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDeci As System.Windows.Forms.TextBox
End Class
