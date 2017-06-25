<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.dlgImport = New System.Windows.Forms.OpenFileDialog()
        Me.bwImport = New System.ComponentModel.BackgroundWorker()
        Me.ssIntrastat = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ss_lblImport = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbImport = New System.Windows.Forms.ToolStripProgressBar()
        Me.bwExport = New System.ComponentModel.BackgroundWorker()
        Me.dlgExport = New System.Windows.Forms.SaveFileDialog()
        Me.il20 = New System.Windows.Forms.ImageList(Me.components)
        Me.il32 = New System.Windows.Forms.ImageList(Me.components)
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.ts_btnConfig = New System.Windows.Forms.ToolStripButton()
        Me.ts_btnHelp = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.txtPathImp = New System.Windows.Forms.TextBox()
        Me.btnBrowseImp = New System.Windows.Forms.Button()
        Me.btnCorrect = New System.Windows.Forms.Button()
        Me.btnGenExp = New System.Windows.Forms.Button()
        Me.btnErrCN8 = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPathExp = New System.Windows.Forms.TextBox()
        Me.btnBrowseExp = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvErr = New System.Windows.Forms.DataGridView()
        Me.cmsDgv = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRemoveFilter = New System.Windows.Forms.Button()
        Me.btnAddFilter = New System.Windows.Forms.Button()
        Me.lstFilters = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbOp = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbFields = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvExport = New System.Windows.Forms.DataGridView()
        Me.hpIntrastat = New System.Windows.Forms.HelpProvider()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bsErr = New System.Windows.Forms.BindingSource(Me.components)
        Me.ssIntrastat.SuspendLayout()
        Me.tsMain.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvErr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsDgv.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsErr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dlgImport
        '
        Me.dlgImport.Filter = "Text files(.txt)|*.txt|All files|*.*"
        Me.dlgImport.Title = "Import"
        '
        'bwImport
        '
        Me.bwImport.WorkerReportsProgress = True
        Me.bwImport.WorkerSupportsCancellation = True
        '
        'ssIntrastat
        '
        Me.ssIntrastat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ss_lblImport, Me.pbImport})
        Me.ssIntrastat.Location = New System.Drawing.Point(0, 699)
        Me.ssIntrastat.Name = "ssIntrastat"
        Me.ssIntrastat.Size = New System.Drawing.Size(806, 22)
        Me.ssIntrastat.TabIndex = 7
        Me.ssIntrastat.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(47, 17)
        Me.ToolStripStatusLabel1.Text = "Status -"
        '
        'ss_lblImport
        '
        Me.ss_lblImport.Name = "ss_lblImport"
        Me.ss_lblImport.Size = New System.Drawing.Size(39, 17)
        Me.ss_lblImport.Text = "Ready"
        '
        'pbImport
        '
        Me.pbImport.Name = "pbImport"
        Me.pbImport.Size = New System.Drawing.Size(200, 16)
        Me.pbImport.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pbImport.Visible = False
        '
        'bwExport
        '
        Me.bwExport.WorkerReportsProgress = True
        Me.bwExport.WorkerSupportsCancellation = True
        '
        'dlgExport
        '
        Me.dlgExport.Filter = "Text files(.txt)|*.txt|CSV files(.csv)|*.csv|All files|*.*"
        '
        'il20
        '
        Me.il20.ImageStream = CType(resources.GetObject("il20.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il20.TransparentColor = System.Drawing.Color.Transparent
        Me.il20.Images.SetKeyName(0, "Browse 3.ico")
        Me.il20.Images.SetKeyName(1, "Table 1.ico")
        '
        'il32
        '
        Me.il32.ImageStream = CType(resources.GetObject("il32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il32.TransparentColor = System.Drawing.Color.Transparent
        Me.il32.Images.SetKeyName(0, "Table 1.ico")
        Me.il32.Images.SetKeyName(1, "Stop 2.ico")
        Me.il32.Images.SetKeyName(2, "General Options.ico")
        Me.il32.Images.SetKeyName(3, "Advanced Options.ico")
        Me.il32.Images.SetKeyName(4, "help.ico")
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(802, 721)
        '
        'tsMain
        '
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_btnConfig, Me.ts_btnHelp})
        Me.tsMain.Location = New System.Drawing.Point(0, 0)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(806, 36)
        Me.tsMain.TabIndex = 21
        '
        'ts_btnConfig
        '
        Me.ts_btnConfig.AutoSize = False
        Me.ts_btnConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_btnConfig.Image = CType(resources.GetObject("ts_btnConfig.Image"), System.Drawing.Image)
        Me.ts_btnConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ts_btnConfig.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_btnConfig.Margin = New System.Windows.Forms.Padding(0)
        Me.ts_btnConfig.Name = "ts_btnConfig"
        Me.ts_btnConfig.Size = New System.Drawing.Size(36, 36)
        Me.ts_btnConfig.Text = "Options"
        '
        'ts_btnHelp
        '
        Me.ts_btnHelp.AutoSize = False
        Me.ts_btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ts_btnHelp.Image = CType(resources.GetObject("ts_btnHelp.Image"), System.Drawing.Image)
        Me.ts_btnHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ts_btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_btnHelp.Margin = New System.Windows.Forms.Padding(0)
        Me.ts_btnHelp.Name = "ts_btnHelp"
        Me.ts_btnHelp.Size = New System.Drawing.Size(36, 36)
        Me.ts_btnHelp.Text = "Help"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnImport)
        Me.GroupBox1.Controls.Add(Me.txtPathImp)
        Me.GroupBox1.Controls.Add(Me.btnBrowseImp)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 54)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Import"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Path"
        '
        'btnImport
        '
        Me.btnImport.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnImport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.Location = New System.Drawing.Point(323, 17)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(58, 23)
        Me.btnImport.TabIndex = 2
        Me.btnImport.Text = "Import"
        Me.ToolTip1.SetToolTip(Me.btnImport, "Importa datele din fisierul selectat")
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'txtPathImp
        '
        Me.txtPathImp.Location = New System.Drawing.Point(48, 19)
        Me.txtPathImp.Name = "txtPathImp"
        Me.txtPathImp.Size = New System.Drawing.Size(243, 21)
        Me.txtPathImp.TabIndex = 0
        '
        'btnBrowseImp
        '
        Me.btnBrowseImp.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnBrowseImp.FlatAppearance.BorderSize = 0
        Me.btnBrowseImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseImp.ImageKey = "Browse 3.ico"
        Me.btnBrowseImp.ImageList = Me.il20
        Me.btnBrowseImp.Location = New System.Drawing.Point(297, 17)
        Me.btnBrowseImp.Name = "btnBrowseImp"
        Me.btnBrowseImp.Size = New System.Drawing.Size(20, 20)
        Me.btnBrowseImp.TabIndex = 1
        Me.btnBrowseImp.UseVisualStyleBackColor = True
        '
        'btnCorrect
        '
        Me.btnCorrect.AutoSize = True
        Me.btnCorrect.Location = New System.Drawing.Point(522, 99)
        Me.btnCorrect.Name = "btnCorrect"
        Me.btnCorrect.Size = New System.Drawing.Size(133, 23)
        Me.btnCorrect.TabIndex = 19
        Me.btnCorrect.Text = "Salveaza modificari"
        Me.ToolTip1.SetToolTip(Me.btnCorrect, "Salveaza modificarile")
        Me.btnCorrect.UseVisualStyleBackColor = True
        '
        'btnGenExp
        '
        Me.btnGenExp.AutoSize = True
        Me.btnGenExp.Location = New System.Drawing.Point(661, 99)
        Me.btnGenExp.Name = "btnGenExp"
        Me.btnGenExp.Size = New System.Drawing.Size(133, 23)
        Me.btnGenExp.TabIndex = 18
        Me.btnGenExp.Text = "Genereaza export"
        Me.ToolTip1.SetToolTip(Me.btnGenExp, "Genereaza datele pentru export")
        Me.btnGenExp.UseVisualStyleBackColor = True
        '
        'btnErrCN8
        '
        Me.hpIntrastat.SetHelpString(Me.btnErrCN8, "")
        Me.btnErrCN8.Location = New System.Drawing.Point(383, 99)
        Me.btnErrCN8.Name = "btnErrCN8"
        Me.hpIntrastat.SetShowHelp(Me.btnErrCN8, True)
        Me.btnErrCN8.Size = New System.Drawing.Size(133, 23)
        Me.btnErrCN8.TabIndex = 17
        Me.btnErrCN8.Text = "Afiseaza erori"
        Me.ToolTip1.SetToolTip(Me.btnErrCN8, "Afiseaza campurile eronate")
        Me.btnErrCN8.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnExport.Location = New System.Drawing.Point(324, 17)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(58, 23)
        Me.btnExport.TabIndex = 16
        Me.btnExport.Text = "Export"
        Me.ToolTip1.SetToolTip(Me.btnExport, "Salveaza datele in fisierul selectat")
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtPathExp)
        Me.GroupBox2.Controls.Add(Me.btnBrowseExp)
        Me.GroupBox2.Controls.Add(Me.btnExport)
        Me.GroupBox2.Location = New System.Drawing.Point(406, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 54)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Export"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Path"
        '
        'txtPathExp
        '
        Me.txtPathExp.Location = New System.Drawing.Point(48, 19)
        Me.txtPathExp.Name = "txtPathExp"
        Me.txtPathExp.Size = New System.Drawing.Size(243, 21)
        Me.txtPathExp.TabIndex = 0
        '
        'btnBrowseExp
        '
        Me.btnBrowseExp.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnBrowseExp.FlatAppearance.BorderSize = 0
        Me.btnBrowseExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseExp.ImageKey = "Browse 3.ico"
        Me.btnBrowseExp.ImageList = Me.il20
        Me.btnBrowseExp.Location = New System.Drawing.Point(297, 17)
        Me.btnBrowseExp.Name = "btnBrowseExp"
        Me.btnBrowseExp.Size = New System.Drawing.Size(20, 20)
        Me.btnBrowseExp.TabIndex = 1
        Me.btnBrowseExp.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(440, 45)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 23
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvErr)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Size = New System.Drawing.Size(792, 522)
        Me.SplitContainer1.SplitterDistance = 403
        Me.SplitContainer1.TabIndex = 24
        '
        'dgvErr
        '
        Me.dgvErr.AllowUserToAddRows = False
        Me.dgvErr.AllowUserToDeleteRows = False
        Me.dgvErr.AllowUserToResizeRows = False
        Me.dgvErr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvErr.ContextMenuStrip = Me.cmsDgv
        Me.dgvErr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvErr.Location = New System.Drawing.Point(0, 0)
        Me.dgvErr.Name = "dgvErr"
        Me.dgvErr.Size = New System.Drawing.Size(792, 403)
        Me.dgvErr.TabIndex = 2
        '
        'cmsDgv
        '
        Me.cmsDgv.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.cmsDgv.Name = "cmsDgv"
        Me.cmsDgv.ShowImageMargin = False
        Me.cmsDgv.Size = New System.Drawing.Size(119, 48)
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.btnRemoveFilter)
        Me.GroupBox3.Controls.Add(Me.btnSelect)
        Me.GroupBox3.Controls.Add(Me.btnAddFilter)
        Me.GroupBox3.Controls.Add(Me.lstFilters)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtVal)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cmbOp)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cmbFields)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(792, 115)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtre"
        '
        'btnRemoveFilter
        '
        Me.btnRemoveFilter.Location = New System.Drawing.Point(234, 81)
        Me.btnRemoveFilter.Name = "btnRemoveFilter"
        Me.btnRemoveFilter.Size = New System.Drawing.Size(23, 23)
        Me.btnRemoveFilter.TabIndex = 33
        Me.btnRemoveFilter.Text = "-"
        Me.btnRemoveFilter.UseVisualStyleBackColor = True
        '
        'btnAddFilter
        '
        Me.btnAddFilter.Location = New System.Drawing.Point(234, 9)
        Me.btnAddFilter.Name = "btnAddFilter"
        Me.btnAddFilter.Size = New System.Drawing.Size(23, 23)
        Me.btnAddFilter.TabIndex = 32
        Me.btnAddFilter.Text = "+"
        Me.btnAddFilter.UseVisualStyleBackColor = True
        '
        'lstFilters
        '
        Me.lstFilters.FormattingEnabled = True
        Me.lstFilters.Location = New System.Drawing.Point(263, 9)
        Me.lstFilters.Name = "lstFilters"
        Me.lstFilters.Size = New System.Drawing.Size(171, 95)
        Me.lstFilters.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Valoare"
        '
        'txtVal
        '
        Me.txtVal.Location = New System.Drawing.Point(70, 74)
        Me.txtVal.Name = "txtVal"
        Me.txtVal.Size = New System.Drawing.Size(121, 21)
        Me.txtVal.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Operator"
        '
        'cmbOp
        '
        Me.cmbOp.FormattingEnabled = True
        Me.cmbOp.Location = New System.Drawing.Point(70, 47)
        Me.cmbOp.Name = "cmbOp"
        Me.cmbOp.Size = New System.Drawing.Size(121, 21)
        Me.cmbOp.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Camp"
        '
        'cmbFields
        '
        Me.cmbFields.FormattingEnabled = True
        Me.cmbFields.Location = New System.Drawing.Point(70, 20)
        Me.cmbFields.Name = "cmbFields"
        Me.cmbFields.Size = New System.Drawing.Size(121, 21)
        Me.cmbFields.TabIndex = 25
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.ImageList = Me.il32
        Me.TabControl1.Location = New System.Drawing.Point(0, 128)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(806, 571)
        Me.TabControl1.TabIndex = 25
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvData)
        Me.TabPage1.ImageKey = "Table 1.ico"
        Me.TabPage1.Location = New System.Drawing.Point(4, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(798, 528)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.AllowUserToResizeRows = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvData.Location = New System.Drawing.Point(3, 3)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.Size = New System.Drawing.Size(792, 522)
        Me.dgvData.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.ImageKey = "Stop 2.ico"
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(798, 528)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Erori CN8"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvExport)
        Me.TabPage3.ImageKey = "Table 1.ico"
        Me.TabPage3.Location = New System.Drawing.Point(4, 39)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(798, 528)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Export"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvExport
        '
        Me.dgvExport.AllowUserToAddRows = False
        Me.dgvExport.AllowUserToDeleteRows = False
        Me.dgvExport.AllowUserToResizeRows = False
        Me.dgvExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvExport.Location = New System.Drawing.Point(3, 3)
        Me.dgvExport.Name = "dgvExport"
        Me.dgvExport.ReadOnly = True
        Me.dgvExport.Size = New System.Drawing.Size(792, 522)
        Me.dgvExport.TabIndex = 2
        '
        'hpIntrastat
        '
        Me.hpIntrastat.HelpNamespace = "D:\intrastat\readme\Intrastat Piese.chm"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(309, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 721)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.ssIntrastat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCorrect)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnGenExp)
        Me.Controls.Add(Me.btnErrCN8)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.hpIntrastat.SetShowHelp(Me, True)
        Me.Text = "Intrastat Piese"
        Me.ssIntrastat.ResumeLayout(False)
        Me.ssIntrastat.PerformLayout()
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvErr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsDgv.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsErr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dlgImport As System.Windows.Forms.OpenFileDialog
    Friend WithEvents bwImport As System.ComponentModel.BackgroundWorker
    Friend WithEvents ssIntrastat As System.Windows.Forms.StatusStrip
    Friend WithEvents pbImport As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ss_lblImport As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bwExport As System.ComponentModel.BackgroundWorker
    Friend WithEvents dlgExport As System.Windows.Forms.SaveFileDialog
    Friend WithEvents il20 As System.Windows.Forms.ImageList
    Friend WithEvents il32 As System.Windows.Forms.ImageList
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents ts_btnConfig As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents txtPathImp As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseImp As System.Windows.Forms.Button
    Friend WithEvents btnCorrect As System.Windows.Forms.Button
    Friend WithEvents btnGenExp As System.Windows.Forms.Button
    Friend WithEvents btnErrCN8 As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPathExp As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseExp As System.Windows.Forms.Button
    Friend WithEvents bsErr As System.Windows.Forms.BindingSource
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvErr As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgvExport As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbFields As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstFilters As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtVal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbOp As System.Windows.Forms.ComboBox
    Friend WithEvents btnRemoveFilter As System.Windows.Forms.Button
    Friend WithEvents btnAddFilter As System.Windows.Forms.Button
    Friend WithEvents cmsDgv As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_btnHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents hpIntrastat As System.Windows.Forms.HelpProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As Button
End Class
