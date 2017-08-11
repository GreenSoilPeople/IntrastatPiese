<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.tsbtnImport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnErori = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnGenExp = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnExport = New System.Windows.Forms.ToolStripButton()
        Me.ts_btnHelp = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnConfig = New System.Windows.Forms.ToolStripButton()
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
        Me.bsErr = New System.Windows.Forms.BindingSource(Me.components)
        Me.ssIntrastat.SuspendLayout()
        Me.tsMain.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ssIntrastat.Location = New System.Drawing.Point(0, 772)
        Me.ssIntrastat.Name = "ssIntrastat"
        Me.ssIntrastat.Size = New System.Drawing.Size(946, 22)
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
        Me.il20.Images.SetKeyName(2, "open-folder-outline.png")
        '
        'il32
        '
        Me.il32.ImageStream = CType(resources.GetObject("il32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il32.TransparentColor = System.Drawing.Color.Transparent
        Me.il32.Images.SetKeyName(0, "Table 1.ico")
        Me.il32.Images.SetKeyName(1, "Stop 2.ico")
        Me.il32.Images.SetKeyName(2, "General Options.ico")
        Me.il32.Images.SetKeyName(3, "help.ico")
        Me.il32.Images.SetKeyName(4, "table-grid.png")
        Me.il32.Images.SetKeyName(5, "bug.png")
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
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnImport, Me.ToolStripSeparator1, Me.tsbtnErori, Me.tsbtnSave, Me.ToolStripSeparator2, Me.tsbtnGenExp, Me.tsbtnExport, Me.ts_btnHelp, Me.tsbtnConfig})
        Me.tsMain.Location = New System.Drawing.Point(0, 0)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Padding = New System.Windows.Forms.Padding(5, 5, 1, 0)
        Me.tsMain.Size = New System.Drawing.Size(946, 63)
        Me.tsMain.TabIndex = 21
        '
        'tsbtnImport
        '
        Me.tsbtnImport.Image = CType(resources.GetObject("tsbtnImport.Image"), System.Drawing.Image)
        Me.tsbtnImport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tsbtnImport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnImport.Name = "tsbtnImport"
        Me.tsbtnImport.Size = New System.Drawing.Size(47, 55)
        Me.tsbtnImport.Text = "Import"
        Me.tsbtnImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbtnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 58)
        '
        'tsbtnErori
        '
        Me.tsbtnErori.Image = CType(resources.GetObject("tsbtnErori.Image"), System.Drawing.Image)
        Me.tsbtnErori.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnErori.Margin = New System.Windows.Forms.Padding(5, 2, 5, 0)
        Me.tsbtnErori.Name = "tsbtnErori"
        Me.tsbtnErori.Size = New System.Drawing.Size(81, 56)
        Me.tsbtnErori.Text = "Afiseaza Erori"
        Me.tsbtnErori.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbtnErori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbtnSave
        '
        Me.tsbtnSave.Image = CType(resources.GetObject("tsbtnSave.Image"), System.Drawing.Image)
        Me.tsbtnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSave.Margin = New System.Windows.Forms.Padding(5, 2, 5, 0)
        Me.tsbtnSave.Name = "tsbtnSave"
        Me.tsbtnSave.Size = New System.Drawing.Size(55, 56)
        Me.tsbtnSave.Text = "Salveaza"
        Me.tsbtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 58)
        '
        'tsbtnGenExp
        '
        Me.tsbtnGenExp.Image = CType(resources.GetObject("tsbtnGenExp.Image"), System.Drawing.Image)
        Me.tsbtnGenExp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tsbtnGenExp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnGenExp.Name = "tsbtnGenExp"
        Me.tsbtnGenExp.Size = New System.Drawing.Size(101, 55)
        Me.tsbtnGenExp.Text = "Genereaza Export"
        Me.tsbtnGenExp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbtnGenExp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbtnExport
        '
        Me.tsbtnExport.Image = CType(resources.GetObject("tsbtnExport.Image"), System.Drawing.Image)
        Me.tsbtnExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tsbtnExport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExport.Name = "tsbtnExport"
        Me.tsbtnExport.Size = New System.Drawing.Size(44, 55)
        Me.tsbtnExport.Text = "Export"
        Me.tsbtnExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbtnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_btnHelp
        '
        Me.ts_btnHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ts_btnHelp.Image = CType(resources.GetObject("ts_btnHelp.Image"), System.Drawing.Image)
        Me.ts_btnHelp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ts_btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_btnHelp.Margin = New System.Windows.Forms.Padding(5, 2, 5, 0)
        Me.ts_btnHelp.Name = "ts_btnHelp"
        Me.ts_btnHelp.Size = New System.Drawing.Size(40, 56)
        Me.ts_btnHelp.Text = "Help"
        Me.ts_btnHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ts_btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbtnConfig
        '
        Me.tsbtnConfig.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbtnConfig.Image = Global.IntrastatPiese.My.Resources.Resources.settings
        Me.tsbtnConfig.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tsbtnConfig.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnConfig.Name = "tsbtnConfig"
        Me.tsbtnConfig.Size = New System.Drawing.Size(40, 55)
        Me.tsbtnConfig.Text = "Setari"
        Me.tsbtnConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbtnConfig.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.tsbtnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.SplitContainer1.Size = New System.Drawing.Size(932, 644)
        Me.SplitContainer1.SplitterDistance = 496
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
        Me.dgvErr.Size = New System.Drawing.Size(932, 496)
        Me.dgvErr.TabIndex = 2
        Me.dgvErr.VirtualMode = True
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
        Me.GroupBox3.Size = New System.Drawing.Size(932, 144)
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
        Me.lstFilters.ItemHeight = 15
        Me.lstFilters.Location = New System.Drawing.Point(263, 9)
        Me.lstFilters.Name = "lstFilters"
        Me.lstFilters.Size = New System.Drawing.Size(171, 94)
        Me.lstFilters.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Valoare"
        '
        'txtVal
        '
        Me.txtVal.Location = New System.Drawing.Point(70, 74)
        Me.txtVal.Name = "txtVal"
        Me.txtVal.Size = New System.Drawing.Size(121, 23)
        Me.txtVal.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Operator"
        '
        'cmbOp
        '
        Me.cmbOp.FormattingEnabled = True
        Me.cmbOp.Location = New System.Drawing.Point(70, 47)
        Me.cmbOp.Name = "cmbOp"
        Me.cmbOp.Size = New System.Drawing.Size(121, 23)
        Me.cmbOp.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Camp"
        '
        'cmbFields
        '
        Me.cmbFields.FormattingEnabled = True
        Me.cmbFields.Location = New System.Drawing.Point(70, 20)
        Me.cmbFields.Name = "cmbFields"
        Me.cmbFields.Size = New System.Drawing.Size(121, 23)
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
        Me.TabControl1.HotTrack = True
        Me.TabControl1.ImageList = Me.il32
        Me.TabControl1.Location = New System.Drawing.Point(0, 79)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(946, 693)
        Me.TabControl1.TabIndex = 25
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvData)
        Me.TabPage1.ImageKey = "table-grid.png"
        Me.TabPage1.Location = New System.Drawing.Point(4, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(938, 650)
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
        Me.dgvData.Size = New System.Drawing.Size(932, 644)
        Me.dgvData.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.ImageKey = "bug.png"
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(938, 650)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Erori CN8"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvExport)
        Me.TabPage3.ImageKey = "table-grid.png"
        Me.TabPage3.Location = New System.Drawing.Point(4, 39)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(938, 650)
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
        Me.dgvExport.Size = New System.Drawing.Size(932, 644)
        Me.dgvExport.TabIndex = 2
        '
        'hpIntrastat
        '
        Me.hpIntrastat.HelpNamespace = "D:\intrastat\readme\Intrastat Piese.chm"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(946, 794)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.ssIntrastat)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Name = "frmMain"
        Me.hpIntrastat.SetShowHelp(Me, True)
        Me.Text = "Intrastat Piese"
        Me.ssIntrastat.ResumeLayout(False)
        Me.ssIntrastat.PerformLayout()
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
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
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbtnErori As ToolStripButton
    Friend WithEvents tsbtnSave As ToolStripButton
    Friend WithEvents tsbtnExport As ToolStripButton
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents tsbtnImport As ToolStripButton
    Friend WithEvents tsbtnGenExp As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbtnConfig As ToolStripButton
End Class
