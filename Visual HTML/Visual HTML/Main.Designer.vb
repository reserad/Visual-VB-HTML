<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.webPreview = New System.Windows.Forms.WebBrowser()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnHLarge = New System.Windows.Forms.Button()
        Me.btnHMedium = New System.Windows.Forms.Button()
        Me.btnHSmall = New System.Windows.Forms.Button()
        Me.gbHeaders = New System.Windows.Forms.GroupBox()
        Me.btnUndo = New System.Windows.Forms.PictureBox()
        Me.btnRedo = New System.Windows.Forms.PictureBox()
        Me.gbInput = New System.Windows.Forms.GroupBox()
        Me.btnInputCheck = New System.Windows.Forms.Button()
        Me.btnInputText = New System.Windows.Forms.Button()
        Me.btnInputRadio = New System.Windows.Forms.Button()
        Me.btnInputButton = New System.Windows.Forms.Button()
        Me.LBViewFile = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCSS = New System.Windows.Forms.Button()
        Me.gbAttach = New System.Windows.Forms.GroupBox()
        Me.btnScript = New System.Windows.Forms.Button()
        Me.gbJavascript = New System.Windows.Forms.GroupBox()
        Me.btnOpenJavascript = New System.Windows.Forms.Button()
        Me.gbCSS = New System.Windows.Forms.GroupBox()
        Me.btnCreateCSS = New System.Windows.Forms.Button()
        Me.btnHideLbl = New System.Windows.Forms.Button()
        Me.btnDeleteRow = New System.Windows.Forms.Button()
        Me.gbTableWidthandHeight = New System.Windows.Forms.GroupBox()
        Me.lblTableHeight = New System.Windows.Forms.Label()
        Me.lblTableWidth = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCreateTable = New System.Windows.Forms.Button()
        Me.TbTableHeight = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbTableWidth = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CounterC = New System.Windows.Forms.NumericUpDown()
        Me.CounterR = New System.Windows.Forms.NumericUpDown()
        Me.PicCenter = New System.Windows.Forms.PictureBox()
        Me.gbTextManip = New System.Windows.Forms.GroupBox()
        Me.cbFontSize = New System.Windows.Forms.ComboBox()
        Me.btnUnderline = New System.Windows.Forms.PictureBox()
        Me.btnItalics = New System.Windows.Forms.PictureBox()
        Me.btnBold = New System.Windows.Forms.PictureBox()
        Me.CbFonts = New System.Windows.Forms.ComboBox()
        Me.lblViewFile = New System.Windows.Forms.RichTextBox()
        Me.gbHeaders.SuspendLayout()
        CType(Me.btnUndo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRedo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInput.SuspendLayout()
        Me.gbAttach.SuspendLayout()
        Me.gbJavascript.SuspendLayout()
        Me.gbCSS.SuspendLayout()
        Me.gbTableWidthandHeight.SuspendLayout()
        CType(Me.TbTableHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbTableWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CounterC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CounterR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCenter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTextManip.SuspendLayout()
        CType(Me.btnUnderline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnItalics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(22, 18)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(102, 23)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Load Existing File"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(149, 18)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(102, 23)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "New File"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'webPreview
        '
        Me.webPreview.Location = New System.Drawing.Point(852, 62)
        Me.webPreview.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webPreview.Name = "webPreview"
        Me.webPreview.Size = New System.Drawing.Size(400, 475)
        Me.webPreview.TabIndex = 3
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(277, 18)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(102, 23)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Save && Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnHLarge
        '
        Me.btnHLarge.Location = New System.Drawing.Point(6, 19)
        Me.btnHLarge.Name = "btnHLarge"
        Me.btnHLarge.Size = New System.Drawing.Size(48, 23)
        Me.btnHLarge.TabIndex = 6
        Me.btnHLarge.Text = "Large"
        Me.btnHLarge.UseVisualStyleBackColor = True
        '
        'btnHMedium
        '
        Me.btnHMedium.Location = New System.Drawing.Point(60, 19)
        Me.btnHMedium.Name = "btnHMedium"
        Me.btnHMedium.Size = New System.Drawing.Size(53, 23)
        Me.btnHMedium.TabIndex = 7
        Me.btnHMedium.Text = "Medium"
        Me.btnHMedium.UseVisualStyleBackColor = True
        '
        'btnHSmall
        '
        Me.btnHSmall.Location = New System.Drawing.Point(119, 19)
        Me.btnHSmall.Name = "btnHSmall"
        Me.btnHSmall.Size = New System.Drawing.Size(50, 23)
        Me.btnHSmall.TabIndex = 8
        Me.btnHSmall.Text = "Small"
        Me.btnHSmall.UseVisualStyleBackColor = True
        '
        'gbHeaders
        '
        Me.gbHeaders.Controls.Add(Me.btnHLarge)
        Me.gbHeaders.Controls.Add(Me.btnHSmall)
        Me.gbHeaders.Controls.Add(Me.btnHMedium)
        Me.gbHeaders.Location = New System.Drawing.Point(22, 574)
        Me.gbHeaders.Name = "gbHeaders"
        Me.gbHeaders.Size = New System.Drawing.Size(179, 51)
        Me.gbHeaders.TabIndex = 9
        Me.gbHeaders.TabStop = False
        Me.gbHeaders.Text = "Headers"
        '
        'btnUndo
        '
        Me.btnUndo.Image = CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image)
        Me.btnUndo.Location = New System.Drawing.Point(401, 9)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(42, 42)
        Me.btnUndo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnUndo.TabIndex = 10
        Me.btnUndo.TabStop = False
        '
        'btnRedo
        '
        Me.btnRedo.BackColor = System.Drawing.SystemColors.Control
        Me.btnRedo.Image = CType(resources.GetObject("btnRedo.Image"), System.Drawing.Image)
        Me.btnRedo.Location = New System.Drawing.Point(461, 9)
        Me.btnRedo.Name = "btnRedo"
        Me.btnRedo.Size = New System.Drawing.Size(42, 42)
        Me.btnRedo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnRedo.TabIndex = 11
        Me.btnRedo.TabStop = False
        '
        'gbInput
        '
        Me.gbInput.Controls.Add(Me.btnInputCheck)
        Me.gbInput.Controls.Add(Me.btnInputText)
        Me.gbInput.Controls.Add(Me.btnInputRadio)
        Me.gbInput.Controls.Add(Me.btnInputButton)
        Me.gbInput.Location = New System.Drawing.Point(22, 641)
        Me.gbInput.Name = "gbInput"
        Me.gbInput.Size = New System.Drawing.Size(233, 51)
        Me.gbInput.TabIndex = 12
        Me.gbInput.TabStop = False
        Me.gbInput.Text = "Input"
        '
        'btnInputCheck
        '
        Me.btnInputCheck.Location = New System.Drawing.Point(175, 19)
        Me.btnInputCheck.Name = "btnInputCheck"
        Me.btnInputCheck.Size = New System.Drawing.Size(50, 23)
        Me.btnInputCheck.TabIndex = 9
        Me.btnInputCheck.Text = "Check"
        Me.btnInputCheck.UseVisualStyleBackColor = True
        '
        'btnInputText
        '
        Me.btnInputText.Location = New System.Drawing.Point(6, 19)
        Me.btnInputText.Name = "btnInputText"
        Me.btnInputText.Size = New System.Drawing.Size(48, 23)
        Me.btnInputText.TabIndex = 6
        Me.btnInputText.Text = "Text"
        Me.btnInputText.UseVisualStyleBackColor = True
        '
        'btnInputRadio
        '
        Me.btnInputRadio.Location = New System.Drawing.Point(119, 19)
        Me.btnInputRadio.Name = "btnInputRadio"
        Me.btnInputRadio.Size = New System.Drawing.Size(50, 23)
        Me.btnInputRadio.TabIndex = 8
        Me.btnInputRadio.Text = "Radio"
        Me.btnInputRadio.UseVisualStyleBackColor = True
        '
        'btnInputButton
        '
        Me.btnInputButton.Location = New System.Drawing.Point(60, 19)
        Me.btnInputButton.Name = "btnInputButton"
        Me.btnInputButton.Size = New System.Drawing.Size(53, 23)
        Me.btnInputButton.TabIndex = 7
        Me.btnInputButton.Text = "Button"
        Me.btnInputButton.UseVisualStyleBackColor = True
        '
        'LBViewFile
        '
        Me.LBViewFile.FormattingEnabled = True
        Me.LBViewFile.HorizontalScrollbar = True
        Me.LBViewFile.Location = New System.Drawing.Point(437, 62)
        Me.LBViewFile.Name = "LBViewFile"
        Me.LBViewFile.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LBViewFile.Size = New System.Drawing.Size(400, 472)
        Me.LBViewFile.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 540)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Manual Editing:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(434, 540)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Select a row to insert objects directly underneath it:"
        '
        'btnCSS
        '
        Me.btnCSS.Location = New System.Drawing.Point(10, 18)
        Me.btnCSS.Name = "btnCSS"
        Me.btnCSS.Size = New System.Drawing.Size(75, 23)
        Me.btnCSS.TabIndex = 16
        Me.btnCSS.Text = "Style Sheet"
        Me.btnCSS.UseVisualStyleBackColor = True
        '
        'gbAttach
        '
        Me.gbAttach.Controls.Add(Me.btnScript)
        Me.gbAttach.Controls.Add(Me.btnCSS)
        Me.gbAttach.Location = New System.Drawing.Point(277, 584)
        Me.gbAttach.Name = "gbAttach"
        Me.gbAttach.Size = New System.Drawing.Size(188, 51)
        Me.gbAttach.TabIndex = 17
        Me.gbAttach.TabStop = False
        Me.gbAttach.Text = "Attach"
        '
        'btnScript
        '
        Me.btnScript.Location = New System.Drawing.Point(102, 18)
        Me.btnScript.Name = "btnScript"
        Me.btnScript.Size = New System.Drawing.Size(75, 23)
        Me.btnScript.TabIndex = 17
        Me.btnScript.Text = "Script"
        Me.btnScript.UseVisualStyleBackColor = True
        '
        'gbJavascript
        '
        Me.gbJavascript.Controls.Add(Me.btnOpenJavascript)
        Me.gbJavascript.Location = New System.Drawing.Point(274, 641)
        Me.gbJavascript.Name = "gbJavascript"
        Me.gbJavascript.Size = New System.Drawing.Size(98, 51)
        Me.gbJavascript.TabIndex = 18
        Me.gbJavascript.TabStop = False
        Me.gbJavascript.Text = "Javascript"
        '
        'btnOpenJavascript
        '
        Me.btnOpenJavascript.Location = New System.Drawing.Point(13, 19)
        Me.btnOpenJavascript.Name = "btnOpenJavascript"
        Me.btnOpenJavascript.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenJavascript.TabIndex = 0
        Me.btnOpenJavascript.Text = "Create"
        Me.btnOpenJavascript.UseVisualStyleBackColor = True
        '
        'gbCSS
        '
        Me.gbCSS.Controls.Add(Me.btnCreateCSS)
        Me.gbCSS.Location = New System.Drawing.Point(378, 641)
        Me.gbCSS.Name = "gbCSS"
        Me.gbCSS.Size = New System.Drawing.Size(98, 51)
        Me.gbCSS.TabIndex = 19
        Me.gbCSS.TabStop = False
        Me.gbCSS.Text = "Style Sheet"
        '
        'btnCreateCSS
        '
        Me.btnCreateCSS.Location = New System.Drawing.Point(13, 19)
        Me.btnCreateCSS.Name = "btnCreateCSS"
        Me.btnCreateCSS.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateCSS.TabIndex = 0
        Me.btnCreateCSS.Text = "Create"
        Me.btnCreateCSS.UseVisualStyleBackColor = True
        '
        'btnHideLbl
        '
        Me.btnHideLbl.Location = New System.Drawing.Point(951, 543)
        Me.btnHideLbl.Name = "btnHideLbl"
        Me.btnHideLbl.Size = New System.Drawing.Size(200, 23)
        Me.btnHideLbl.TabIndex = 21
        Me.btnHideLbl.Text = "Show only web preview"
        Me.btnHideLbl.UseVisualStyleBackColor = True
        '
        'btnDeleteRow
        '
        Me.btnDeleteRow.Location = New System.Drawing.Point(762, 543)
        Me.btnDeleteRow.Name = "btnDeleteRow"
        Me.btnDeleteRow.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteRow.TabIndex = 0
        Me.btnDeleteRow.Text = "Delete Row"
        Me.btnDeleteRow.UseVisualStyleBackColor = True
        '
        'gbTableWidthandHeight
        '
        Me.gbTableWidthandHeight.Controls.Add(Me.lblTableHeight)
        Me.gbTableWidthandHeight.Controls.Add(Me.lblTableWidth)
        Me.gbTableWidthandHeight.Controls.Add(Me.Label6)
        Me.gbTableWidthandHeight.Controls.Add(Me.Label5)
        Me.gbTableWidthandHeight.Controls.Add(Me.btnCreateTable)
        Me.gbTableWidthandHeight.Controls.Add(Me.TbTableHeight)
        Me.gbTableWidthandHeight.Controls.Add(Me.Label4)
        Me.gbTableWidthandHeight.Controls.Add(Me.TbTableWidth)
        Me.gbTableWidthandHeight.Controls.Add(Me.Label3)
        Me.gbTableWidthandHeight.Controls.Add(Me.CounterC)
        Me.gbTableWidthandHeight.Controls.Add(Me.CounterR)
        Me.gbTableWidthandHeight.Location = New System.Drawing.Point(27, 703)
        Me.gbTableWidthandHeight.Name = "gbTableWidthandHeight"
        Me.gbTableWidthandHeight.Size = New System.Drawing.Size(368, 154)
        Me.gbTableWidthandHeight.TabIndex = 22
        Me.gbTableWidthandHeight.TabStop = False
        Me.gbTableWidthandHeight.Text = "Table Specifications"
        '
        'lblTableHeight
        '
        Me.lblTableHeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTableHeight.Location = New System.Drawing.Point(129, 117)
        Me.lblTableHeight.Name = "lblTableHeight"
        Me.lblTableHeight.Size = New System.Drawing.Size(40, 23)
        Me.lblTableHeight.TabIndex = 31
        '
        'lblTableWidth
        '
        Me.lblTableWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTableWidth.Location = New System.Drawing.Point(104, 73)
        Me.lblTableWidth.Name = "lblTableWidth"
        Me.lblTableWidth.Size = New System.Drawing.Size(40, 23)
        Me.lblTableWidth.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(86, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 34)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Table Height:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Table Width:"
        '
        'btnCreateTable
        '
        Me.btnCreateTable.Location = New System.Drawing.Point(240, 113)
        Me.btnCreateTable.Name = "btnCreateTable"
        Me.btnCreateTable.Size = New System.Drawing.Size(89, 23)
        Me.btnCreateTable.TabIndex = 29
        Me.btnCreateTable.Text = "Create Table"
        Me.btnCreateTable.UseVisualStyleBackColor = True
        '
        'TbTableHeight
        '
        Me.TbTableHeight.Location = New System.Drawing.Point(175, 13)
        Me.TbTableHeight.Maximum = 1000
        Me.TbTableHeight.Name = "TbTableHeight"
        Me.TbTableHeight.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TbTableHeight.Size = New System.Drawing.Size(45, 139)
        Me.TbTableHeight.TabIndex = 1
        Me.TbTableHeight.TickFrequency = 100
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(226, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Table Columns:"
        '
        'TbTableWidth
        '
        Me.TbTableWidth.Location = New System.Drawing.Point(23, 39)
        Me.TbTableWidth.Maximum = 1000
        Me.TbTableWidth.Name = "TbTableWidth"
        Me.TbTableWidth.Size = New System.Drawing.Size(139, 45)
        Me.TbTableWidth.TabIndex = 0
        Me.TbTableWidth.TickFrequency = 100
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(226, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Table Rows:"
        '
        'CounterC
        '
        Me.CounterC.Location = New System.Drawing.Point(310, 72)
        Me.CounterC.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.CounterC.Name = "CounterC"
        Me.CounterC.Size = New System.Drawing.Size(37, 20)
        Me.CounterC.TabIndex = 26
        Me.CounterC.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CounterR
        '
        Me.CounterR.Location = New System.Drawing.Point(310, 37)
        Me.CounterR.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.CounterR.Name = "CounterR"
        Me.CounterR.Size = New System.Drawing.Size(37, 20)
        Me.CounterR.TabIndex = 25
        Me.CounterR.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'PicCenter
        '
        Me.PicCenter.Image = CType(resources.GetObject("PicCenter.Image"), System.Drawing.Image)
        Me.PicCenter.Location = New System.Drawing.Point(15, 28)
        Me.PicCenter.Name = "PicCenter"
        Me.PicCenter.Size = New System.Drawing.Size(20, 23)
        Me.PicCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicCenter.TabIndex = 23
        Me.PicCenter.TabStop = False
        '
        'gbTextManip
        '
        Me.gbTextManip.Controls.Add(Me.cbFontSize)
        Me.gbTextManip.Controls.Add(Me.btnUnderline)
        Me.gbTextManip.Controls.Add(Me.btnItalics)
        Me.gbTextManip.Controls.Add(Me.btnBold)
        Me.gbTextManip.Controls.Add(Me.PicCenter)
        Me.gbTextManip.Controls.Add(Me.CbFonts)
        Me.gbTextManip.Location = New System.Drawing.Point(516, 584)
        Me.gbTextManip.Name = "gbTextManip"
        Me.gbTextManip.Size = New System.Drawing.Size(417, 71)
        Me.gbTextManip.TabIndex = 25
        Me.gbTextManip.TabStop = False
        Me.gbTextManip.Text = "Text Manipulation"
        '
        'cbFontSize
        '
        Me.cbFontSize.FormattingEnabled = True
        Me.cbFontSize.Items.AddRange(New Object() {"12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72"})
        Me.cbFontSize.Location = New System.Drawing.Point(264, 30)
        Me.cbFontSize.Name = "cbFontSize"
        Me.cbFontSize.Size = New System.Drawing.Size(57, 21)
        Me.cbFontSize.TabIndex = 30
        Me.cbFontSize.Text = "Size..."
        '
        'btnUnderline
        '
        Me.btnUnderline.Image = CType(resources.GetObject("btnUnderline.Image"), System.Drawing.Image)
        Me.btnUnderline.Location = New System.Drawing.Point(93, 28)
        Me.btnUnderline.Name = "btnUnderline"
        Me.btnUnderline.Size = New System.Drawing.Size(20, 23)
        Me.btnUnderline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnUnderline.TabIndex = 29
        Me.btnUnderline.TabStop = False
        '
        'btnItalics
        '
        Me.btnItalics.Image = CType(resources.GetObject("btnItalics.Image"), System.Drawing.Image)
        Me.btnItalics.Location = New System.Drawing.Point(67, 28)
        Me.btnItalics.Name = "btnItalics"
        Me.btnItalics.Size = New System.Drawing.Size(20, 23)
        Me.btnItalics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnItalics.TabIndex = 28
        Me.btnItalics.TabStop = False
        '
        'btnBold
        '
        Me.btnBold.Image = CType(resources.GetObject("btnBold.Image"), System.Drawing.Image)
        Me.btnBold.Location = New System.Drawing.Point(41, 28)
        Me.btnBold.Name = "btnBold"
        Me.btnBold.Size = New System.Drawing.Size(20, 23)
        Me.btnBold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnBold.TabIndex = 27
        Me.btnBold.TabStop = False
        '
        'CbFonts
        '
        Me.CbFonts.FormattingEnabled = True
        Me.CbFonts.Location = New System.Drawing.Point(130, 30)
        Me.CbFonts.Name = "CbFonts"
        Me.CbFonts.Size = New System.Drawing.Size(126, 21)
        Me.CbFonts.TabIndex = 26
        Me.CbFonts.Text = "Font..."
        '
        'lblViewFile
        '
        Me.lblViewFile.Location = New System.Drawing.Point(12, 62)
        Me.lblViewFile.Name = "lblViewFile"
        Me.lblViewFile.Size = New System.Drawing.Size(400, 475)
        Me.lblViewFile.TabIndex = 26
        Me.lblViewFile.Text = ""
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1264, 862)
        Me.Controls.Add(Me.lblViewFile)
        Me.Controls.Add(Me.gbTableWidthandHeight)
        Me.Controls.Add(Me.btnDeleteRow)
        Me.Controls.Add(Me.gbTextManip)
        Me.Controls.Add(Me.btnHideLbl)
        Me.Controls.Add(Me.gbCSS)
        Me.Controls.Add(Me.gbJavascript)
        Me.Controls.Add(Me.gbAttach)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBViewFile)
        Me.Controls.Add(Me.gbInput)
        Me.Controls.Add(Me.btnRedo)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.gbHeaders)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.webPreview)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnLoad)
        Me.Name = "Main"
        Me.Text = "Visual HTML"
        Me.gbHeaders.ResumeLayout(False)
        CType(Me.btnUndo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRedo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInput.ResumeLayout(False)
        Me.gbAttach.ResumeLayout(False)
        Me.gbJavascript.ResumeLayout(False)
        Me.gbCSS.ResumeLayout(False)
        Me.gbTableWidthandHeight.ResumeLayout(False)
        Me.gbTableWidthandHeight.PerformLayout()
        CType(Me.TbTableHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbTableWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CounterC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CounterR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCenter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTextManip.ResumeLayout(False)
        Me.gbTextManip.PerformLayout()
        CType(Me.btnUnderline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnItalics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents webPreview As System.Windows.Forms.WebBrowser
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnHLarge As System.Windows.Forms.Button
    Friend WithEvents btnHMedium As System.Windows.Forms.Button
    Friend WithEvents btnHSmall As System.Windows.Forms.Button
    Friend WithEvents gbHeaders As System.Windows.Forms.GroupBox
    Friend WithEvents btnUndo As System.Windows.Forms.PictureBox
    Friend WithEvents btnRedo As System.Windows.Forms.PictureBox
    Friend WithEvents gbInput As System.Windows.Forms.GroupBox
    Friend WithEvents btnInputCheck As System.Windows.Forms.Button
    Friend WithEvents btnInputText As System.Windows.Forms.Button
    Friend WithEvents btnInputRadio As System.Windows.Forms.Button
    Friend WithEvents btnInputButton As System.Windows.Forms.Button
    Friend WithEvents LBViewFile As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCSS As System.Windows.Forms.Button
    Friend WithEvents gbAttach As System.Windows.Forms.GroupBox
    Friend WithEvents btnScript As System.Windows.Forms.Button
    Friend WithEvents gbJavascript As System.Windows.Forms.GroupBox
    Friend WithEvents btnOpenJavascript As System.Windows.Forms.Button
    Friend WithEvents gbCSS As System.Windows.Forms.GroupBox
    Friend WithEvents btnCreateCSS As System.Windows.Forms.Button
    Friend WithEvents btnHideLbl As System.Windows.Forms.Button
    Friend WithEvents btnDeleteRow As System.Windows.Forms.Button
    Friend WithEvents gbTableWidthandHeight As System.Windows.Forms.GroupBox
    Friend WithEvents TbTableHeight As System.Windows.Forms.TrackBar
    Friend WithEvents TbTableWidth As System.Windows.Forms.TrackBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CounterC As System.Windows.Forms.NumericUpDown
    Friend WithEvents CounterR As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCreateTable As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTableHeight As System.Windows.Forms.Label
    Friend WithEvents lblTableWidth As System.Windows.Forms.Label
    Friend WithEvents PicCenter As System.Windows.Forms.PictureBox
    Friend WithEvents gbTextManip As System.Windows.Forms.GroupBox
    Friend WithEvents CbFonts As System.Windows.Forms.ComboBox
    Friend WithEvents btnUnderline As System.Windows.Forms.PictureBox
    Friend WithEvents btnItalics As System.Windows.Forms.PictureBox
    Friend WithEvents btnBold As System.Windows.Forms.PictureBox
    Friend WithEvents cbFontSize As System.Windows.Forms.ComboBox
    Friend WithEvents lblViewFile As System.Windows.Forms.RichTextBox

End Class
