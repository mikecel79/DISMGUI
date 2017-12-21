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
        Me.txtWIM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMount = New System.Windows.Forms.TextBox()
        Me.dlgOpenFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpenWIM = New System.Windows.Forms.Button()
        Me.btnOpenMount = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDISMLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetWIMInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CleanupWIMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CleanupImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnMount = New System.Windows.Forms.Button()
        Me.cmbIndex = New System.Windows.Forms.ComboBox()
        Me.btnDismount = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnOpenFolder = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackgroundWorkerMount = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorkerDisMount = New System.ComponentModel.BackgroundWorker()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnDisplayWIMInfo = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnGetAllDriverInfo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDelDriver = New System.Windows.Forms.Button()
        Me.txtDelDriverLocation = New System.Windows.Forms.TextBox()
        Me.chkForceUnsigned = New System.Windows.Forms.CheckBox()
        Me.btnOpnDriverFolder = New System.Windows.Forms.Button()
        Me.txtDriverLocation = New System.Windows.Forms.TextBox()
        Me.btnGetDrivers = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkRecurse = New System.Windows.Forms.CheckBox()
        Me.btnAddDriver = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnRemovePackagePath = New System.Windows.Forms.Button()
        Me.btnRemovePackageName = New System.Windows.Forms.Button()
        Me.txtPackagePath = New System.Windows.Forms.TextBox()
        Me.txtPackageName = New System.Windows.Forms.TextBox()
        Me.btnGetPackages = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAddPackages = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkIgnoreCheck = New System.Windows.Forms.CheckBox()
        Me.txtPackageFile = New System.Windows.Forms.TextBox()
        Me.btnOpenPackageFile = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnDisableFeature = New System.Windows.Forms.Button()
        Me.chkEnablePkgPath = New System.Windows.Forms.CheckBox()
        Me.chkEnablePkgName = New System.Windows.Forms.CheckBox()
        Me.btnEnableFeature = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFeatPackagePath = New System.Windows.Forms.TextBox()
        Me.txtFeatPackageName = New System.Windows.Forms.TextBox()
        Me.txtFeatureName = New System.Windows.Forms.TextBox()
        Me.btnGetFeatures = New System.Windows.Forms.Button()
        Me.BackgroundWorkerDISMCommand = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtWIM
        '
        Me.txtWIM.Location = New System.Drawing.Point(5, 25)
        Me.txtWIM.Name = "txtWIM"
        Me.txtWIM.Size = New System.Drawing.Size(339, 20)
        Me.txtWIM.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WIM File"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mount Location"
        '
        'txtMount
        '
        Me.txtMount.Location = New System.Drawing.Point(6, 108)
        Me.txtMount.Name = "txtMount"
        Me.txtMount.Size = New System.Drawing.Size(339, 20)
        Me.txtMount.TabIndex = 3
        '
        'dlgOpenFolder
        '
        Me.dlgOpenFolder.SelectedPath = "c:\"
        '
        'btnOpenWIM
        '
        Me.btnOpenWIM.Location = New System.Drawing.Point(361, 21)
        Me.btnOpenWIM.Name = "btnOpenWIM"
        Me.btnOpenWIM.Size = New System.Drawing.Size(106, 23)
        Me.btnOpenWIM.TabIndex = 4
        Me.btnOpenWIM.Text = "Choose WIM"
        Me.btnOpenWIM.UseVisualStyleBackColor = True
        '
        'btnOpenMount
        '
        Me.btnOpenMount.Location = New System.Drawing.Point(362, 104)
        Me.btnOpenMount.Name = "btnOpenMount"
        Me.btnOpenMount.Size = New System.Drawing.Size(106, 23)
        Me.btnOpenMount.TabIndex = 5
        Me.btnOpenMount.Text = "Choose Folder"
        Me.btnOpenMount.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(686, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenDISMLogToolStripMenuItem, Me.GetWIMInfoToolStripMenuItem, Me.CleanupWIMToolStripMenuItem, Me.CleanupImageToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'OpenDISMLogToolStripMenuItem
        '
        Me.OpenDISMLogToolStripMenuItem.Name = "OpenDISMLogToolStripMenuItem"
        Me.OpenDISMLogToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.OpenDISMLogToolStripMenuItem.Text = "Open DISM Log"
        '
        'GetWIMInfoToolStripMenuItem
        '
        Me.GetWIMInfoToolStripMenuItem.Name = "GetWIMInfoToolStripMenuItem"
        Me.GetWIMInfoToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.GetWIMInfoToolStripMenuItem.Text = "Get Mounted WIM Info"
        '
        'CleanupWIMToolStripMenuItem
        '
        Me.CleanupWIMToolStripMenuItem.Name = "CleanupWIMToolStripMenuItem"
        Me.CleanupWIMToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.CleanupWIMToolStripMenuItem.Text = "Cleanup WIM"
        '
        'CleanupImageToolStripMenuItem
        '
        Me.CleanupImageToolStripMenuItem.Name = "CleanupImageToolStripMenuItem"
        Me.CleanupImageToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.CleanupImageToolStripMenuItem.Text = "Cleanup Image"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'btnMount
        '
        Me.btnMount.Location = New System.Drawing.Point(523, 21)
        Me.btnMount.Name = "btnMount"
        Me.btnMount.Size = New System.Drawing.Size(127, 64)
        Me.btnMount.TabIndex = 7
        Me.btnMount.Text = "Mount WIM"
        Me.btnMount.UseVisualStyleBackColor = True
        '
        'cmbIndex
        '
        Me.cmbIndex.FormattingEnabled = True
        Me.cmbIndex.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbIndex.Location = New System.Drawing.Point(478, 25)
        Me.cmbIndex.Name = "cmbIndex"
        Me.cmbIndex.Size = New System.Drawing.Size(30, 21)
        Me.cmbIndex.TabIndex = 8
        '
        'btnDismount
        '
        Me.btnDismount.Enabled = False
        Me.btnDismount.Location = New System.Drawing.Point(523, 91)
        Me.btnDismount.Name = "btnDismount"
        Me.btnDismount.Size = New System.Drawing.Size(127, 64)
        Me.btnDismount.TabIndex = 10
        Me.btnDismount.Text = "Dismount WIM"
        Me.btnDismount.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(11, 436)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOutput.Size = New System.Drawing.Size(656, 246)
        Me.txtOutput.TabIndex = 13
        Me.txtOutput.WordWrap = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 420)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "DISM Output"
        '
        'btnOpenFolder
        '
        Me.btnOpenFolder.Location = New System.Drawing.Point(523, 161)
        Me.btnOpenFolder.Name = "btnOpenFolder"
        Me.btnOpenFolder.Size = New System.Drawing.Size(127, 64)
        Me.btnOpenFolder.TabIndex = 15
        Me.btnOpenFolder.Text = "Open Mounted Folder"
        Me.btnOpenFolder.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(595, 687)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(475, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Index"
        '
        'BackgroundWorkerMount
        '
        Me.BackgroundWorkerMount.WorkerReportsProgress = True
        Me.BackgroundWorkerMount.WorkerSupportsCancellation = True
        '
        'BackgroundWorkerDisMount
        '
        Me.BackgroundWorkerDisMount.WorkerReportsProgress = True
        Me.BackgroundWorkerDisMount.WorkerSupportsCancellation = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(11, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(663, 390)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnDisplayWIMInfo)
        Me.TabPage1.Controls.Add(Me.btnOpenWIM)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtWIM)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnOpenFolder)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtMount)
        Me.TabPage1.Controls.Add(Me.btnOpenMount)
        Me.TabPage1.Controls.Add(Me.btnDismount)
        Me.TabPage1.Controls.Add(Me.btnMount)
        Me.TabPage1.Controls.Add(Me.cmbIndex)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(655, 364)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Mount Control"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnDisplayWIMInfo
        '
        Me.btnDisplayWIMInfo.Location = New System.Drawing.Point(4, 52)
        Me.btnDisplayWIMInfo.Name = "btnDisplayWIMInfo"
        Me.btnDisplayWIMInfo.Size = New System.Drawing.Size(124, 23)
        Me.btnDisplayWIMInfo.TabIndex = 18
        Me.btnDisplayWIMInfo.Text = "Display WIM Info"
        Me.btnDisplayWIMInfo.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnGetAllDriverInfo)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.chkForceUnsigned)
        Me.TabPage2.Controls.Add(Me.btnOpnDriverFolder)
        Me.TabPage2.Controls.Add(Me.txtDriverLocation)
        Me.TabPage2.Controls.Add(Me.btnGetDrivers)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(655, 364)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Driver Management"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnGetAllDriverInfo
        '
        Me.btnGetAllDriverInfo.Location = New System.Drawing.Point(525, 76)
        Me.btnGetAllDriverInfo.Name = "btnGetAllDriverInfo"
        Me.btnGetAllDriverInfo.Size = New System.Drawing.Size(127, 64)
        Me.btnGetAllDriverInfo.TabIndex = 14
        Me.btnGetAllDriverInfo.Text = "Get All Driver information from WIM"
        Me.btnGetAllDriverInfo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnDelDriver)
        Me.GroupBox2.Controls.Add(Me.txtDelDriverLocation)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 197)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(461, 65)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Delete Drivers"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Driver Name"
        '
        'btnDelDriver
        '
        Me.btnDelDriver.Location = New System.Drawing.Point(316, 35)
        Me.btnDelDriver.Name = "btnDelDriver"
        Me.btnDelDriver.Size = New System.Drawing.Size(124, 23)
        Me.btnDelDriver.TabIndex = 1
        Me.btnDelDriver.Text = "Delete Driver"
        Me.btnDelDriver.UseVisualStyleBackColor = True
        '
        'txtDelDriverLocation
        '
        Me.txtDelDriverLocation.Location = New System.Drawing.Point(4, 39)
        Me.txtDelDriverLocation.Name = "txtDelDriverLocation"
        Me.txtDelDriverLocation.Size = New System.Drawing.Size(305, 20)
        Me.txtDelDriverLocation.TabIndex = 0
        '
        'chkForceUnsigned
        '
        Me.chkForceUnsigned.AutoSize = True
        Me.chkForceUnsigned.Location = New System.Drawing.Point(10, 68)
        Me.chkForceUnsigned.Name = "chkForceUnsigned"
        Me.chkForceUnsigned.Size = New System.Drawing.Size(101, 17)
        Me.chkForceUnsigned.TabIndex = 10
        Me.chkForceUnsigned.Text = "Force Unsigned"
        Me.chkForceUnsigned.UseVisualStyleBackColor = True
        '
        'btnOpnDriverFolder
        '
        Me.btnOpnDriverFolder.Location = New System.Drawing.Point(324, 34)
        Me.btnOpnDriverFolder.Name = "btnOpnDriverFolder"
        Me.btnOpnDriverFolder.Size = New System.Drawing.Size(125, 23)
        Me.btnOpnDriverFolder.TabIndex = 3
        Me.btnOpnDriverFolder.Text = "Choose Driver Folder"
        Me.btnOpnDriverFolder.UseVisualStyleBackColor = True
        '
        'txtDriverLocation
        '
        Me.txtDriverLocation.Location = New System.Drawing.Point(11, 34)
        Me.txtDriverLocation.Name = "txtDriverLocation"
        Me.txtDriverLocation.Size = New System.Drawing.Size(307, 20)
        Me.txtDriverLocation.TabIndex = 2
        '
        'btnGetDrivers
        '
        Me.btnGetDrivers.Location = New System.Drawing.Point(525, 6)
        Me.btnGetDrivers.Name = "btnGetDrivers"
        Me.btnGetDrivers.Size = New System.Drawing.Size(127, 64)
        Me.btnGetDrivers.TabIndex = 1
        Me.btnGetDrivers.Text = "Get 3rd Party Driver information from WIM"
        Me.btnGetDrivers.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Drivers Folder Location"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkRecurse)
        Me.GroupBox1.Controls.Add(Me.btnAddDriver)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(461, 185)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Drivers"
        '
        'chkRecurse
        '
        Me.chkRecurse.AutoSize = True
        Me.chkRecurse.Checked = True
        Me.chkRecurse.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRecurse.Location = New System.Drawing.Point(112, 62)
        Me.chkRecurse.Name = "chkRecurse"
        Me.chkRecurse.Size = New System.Drawing.Size(66, 17)
        Me.chkRecurse.TabIndex = 9
        Me.chkRecurse.Text = "Recurse"
        Me.chkRecurse.UseVisualStyleBackColor = True
        '
        'btnAddDriver
        '
        Me.btnAddDriver.Location = New System.Drawing.Point(4, 85)
        Me.btnAddDriver.Name = "btnAddDriver"
        Me.btnAddDriver.Size = New System.Drawing.Size(127, 64)
        Me.btnAddDriver.TabIndex = 8
        Me.btnAddDriver.Text = "Add Drivers"
        Me.btnAddDriver.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.btnGetPackages)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(655, 364)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Package Management"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.btnRemovePackagePath)
        Me.GroupBox4.Controls.Add(Me.btnRemovePackageName)
        Me.GroupBox4.Controls.Add(Me.txtPackagePath)
        Me.GroupBox4.Controls.Add(Me.txtPackageName)
        Me.GroupBox4.Location = New System.Drawing.Point(4, 158)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(515, 159)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Remove Packages"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Package Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Package Path"
        '
        'btnRemovePackagePath
        '
        Me.btnRemovePackagePath.Location = New System.Drawing.Point(317, 88)
        Me.btnRemovePackagePath.Name = "btnRemovePackagePath"
        Me.btnRemovePackagePath.Size = New System.Drawing.Size(131, 23)
        Me.btnRemovePackagePath.TabIndex = 3
        Me.btnRemovePackagePath.Text = "Remove Package"
        Me.btnRemovePackagePath.UseVisualStyleBackColor = True
        '
        'btnRemovePackageName
        '
        Me.btnRemovePackageName.Location = New System.Drawing.Point(317, 43)
        Me.btnRemovePackageName.Name = "btnRemovePackageName"
        Me.btnRemovePackageName.Size = New System.Drawing.Size(131, 23)
        Me.btnRemovePackageName.TabIndex = 2
        Me.btnRemovePackageName.Text = "Remove Package"
        Me.btnRemovePackageName.UseVisualStyleBackColor = True
        '
        'txtPackagePath
        '
        Me.txtPackagePath.Location = New System.Drawing.Point(3, 88)
        Me.txtPackagePath.Name = "txtPackagePath"
        Me.txtPackagePath.Size = New System.Drawing.Size(307, 20)
        Me.txtPackagePath.TabIndex = 1
        '
        'txtPackageName
        '
        Me.txtPackageName.Location = New System.Drawing.Point(3, 43)
        Me.txtPackageName.Name = "txtPackageName"
        Me.txtPackageName.Size = New System.Drawing.Size(307, 20)
        Me.txtPackageName.TabIndex = 0
        '
        'btnGetPackages
        '
        Me.btnGetPackages.Location = New System.Drawing.Point(525, 3)
        Me.btnGetPackages.Name = "btnGetPackages"
        Me.btnGetPackages.Size = New System.Drawing.Size(127, 64)
        Me.btnGetPackages.TabIndex = 9
        Me.btnGetPackages.Text = "Get Packges from WIM"
        Me.btnGetPackages.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAddPackages)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.chkIgnoreCheck)
        Me.GroupBox3.Controls.Add(Me.txtPackageFile)
        Me.GroupBox3.Controls.Add(Me.btnOpenPackageFile)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(516, 148)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Add Packages"
        '
        'btnAddPackages
        '
        Me.btnAddPackages.Location = New System.Drawing.Point(6, 78)
        Me.btnAddPackages.Name = "btnAddPackages"
        Me.btnAddPackages.Size = New System.Drawing.Size(127, 64)
        Me.btnAddPackages.TabIndex = 14
        Me.btnAddPackages.Text = "Add Packages"
        Me.btnAddPackages.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Package Folder"
        '
        'chkIgnoreCheck
        '
        Me.chkIgnoreCheck.AutoSize = True
        Me.chkIgnoreCheck.Location = New System.Drawing.Point(9, 55)
        Me.chkIgnoreCheck.Name = "chkIgnoreCheck"
        Me.chkIgnoreCheck.Size = New System.Drawing.Size(90, 17)
        Me.chkIgnoreCheck.TabIndex = 13
        Me.chkIgnoreCheck.Text = "Ignore Check"
        Me.chkIgnoreCheck.UseVisualStyleBackColor = True
        '
        'txtPackageFile
        '
        Me.txtPackageFile.Location = New System.Drawing.Point(6, 29)
        Me.txtPackageFile.Name = "txtPackageFile"
        Me.txtPackageFile.Size = New System.Drawing.Size(307, 20)
        Me.txtPackageFile.TabIndex = 10
        '
        'btnOpenPackageFile
        '
        Me.btnOpenPackageFile.Location = New System.Drawing.Point(320, 25)
        Me.btnOpenPackageFile.Name = "btnOpenPackageFile"
        Me.btnOpenPackageFile.Size = New System.Drawing.Size(131, 23)
        Me.btnOpenPackageFile.TabIndex = 12
        Me.btnOpenPackageFile.Text = "Choose Package Folder"
        Me.btnOpenPackageFile.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnDisableFeature)
        Me.TabPage4.Controls.Add(Me.chkEnablePkgPath)
        Me.TabPage4.Controls.Add(Me.chkEnablePkgName)
        Me.TabPage4.Controls.Add(Me.btnEnableFeature)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.txtFeatPackagePath)
        Me.TabPage4.Controls.Add(Me.txtFeatPackageName)
        Me.TabPage4.Controls.Add(Me.txtFeatureName)
        Me.TabPage4.Controls.Add(Me.btnGetFeatures)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(655, 364)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Feature Management"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnDisableFeature
        '
        Me.btnDisableFeature.Location = New System.Drawing.Point(525, 143)
        Me.btnDisableFeature.Name = "btnDisableFeature"
        Me.btnDisableFeature.Size = New System.Drawing.Size(127, 64)
        Me.btnDisableFeature.TabIndex = 22
        Me.btnDisableFeature.Text = "Disable Feature"
        Me.btnDisableFeature.UseVisualStyleBackColor = True
        '
        'chkEnablePkgPath
        '
        Me.chkEnablePkgPath.AutoSize = True
        Me.chkEnablePkgPath.Location = New System.Drawing.Point(5, 117)
        Me.chkEnablePkgPath.Name = "chkEnablePkgPath"
        Me.chkEnablePkgPath.Size = New System.Drawing.Size(15, 14)
        Me.chkEnablePkgPath.TabIndex = 21
        Me.chkEnablePkgPath.UseVisualStyleBackColor = True
        '
        'chkEnablePkgName
        '
        Me.chkEnablePkgName.AutoSize = True
        Me.chkEnablePkgName.Location = New System.Drawing.Point(5, 70)
        Me.chkEnablePkgName.Name = "chkEnablePkgName"
        Me.chkEnablePkgName.Size = New System.Drawing.Size(15, 14)
        Me.chkEnablePkgName.TabIndex = 20
        Me.chkEnablePkgName.UseVisualStyleBackColor = True
        '
        'btnEnableFeature
        '
        Me.btnEnableFeature.Location = New System.Drawing.Point(525, 73)
        Me.btnEnableFeature.Name = "btnEnableFeature"
        Me.btnEnableFeature.Size = New System.Drawing.Size(127, 64)
        Me.btnEnableFeature.TabIndex = 19
        Me.btnEnableFeature.Text = "Enable Feature"
        Me.btnEnableFeature.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(27, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Package Path"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Package Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Feature Name"
        '
        'txtFeatPackagePath
        '
        Me.txtFeatPackagePath.Enabled = False
        Me.txtFeatPackagePath.Location = New System.Drawing.Point(26, 111)
        Me.txtFeatPackagePath.Name = "txtFeatPackagePath"
        Me.txtFeatPackagePath.Size = New System.Drawing.Size(424, 20)
        Me.txtFeatPackagePath.TabIndex = 15
        '
        'txtFeatPackageName
        '
        Me.txtFeatPackageName.Enabled = False
        Me.txtFeatPackageName.Location = New System.Drawing.Point(26, 64)
        Me.txtFeatPackageName.Name = "txtFeatPackageName"
        Me.txtFeatPackageName.Size = New System.Drawing.Size(424, 20)
        Me.txtFeatPackageName.TabIndex = 12
        '
        'txtFeatureName
        '
        Me.txtFeatureName.Location = New System.Drawing.Point(26, 19)
        Me.txtFeatureName.Name = "txtFeatureName"
        Me.txtFeatureName.Size = New System.Drawing.Size(424, 20)
        Me.txtFeatureName.TabIndex = 11
        '
        'btnGetFeatures
        '
        Me.btnGetFeatures.Location = New System.Drawing.Point(525, 3)
        Me.btnGetFeatures.Name = "btnGetFeatures"
        Me.btnGetFeatures.Size = New System.Drawing.Size(127, 64)
        Me.btnGetFeatures.TabIndex = 10
        Me.btnGetFeatures.Text = "Get Features from WIM"
        Me.btnGetFeatures.UseVisualStyleBackColor = True
        '
        'BackgroundWorkerDISMCommand
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 722)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "DISM GUI"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtWIM As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMount As System.Windows.Forms.TextBox
    Friend WithEvents dlgOpenFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnOpenWIM As System.Windows.Forms.Button
    Friend WithEvents btnOpenMount As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnMount As System.Windows.Forms.Button
    Friend WithEvents cmbIndex As System.Windows.Forms.ComboBox
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDismount As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnOpenFolder As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OpenDISMLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorkerMount As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorkerDisMount As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnGetDrivers As System.Windows.Forms.Button
    Friend WithEvents txtDriverLocation As System.Windows.Forms.TextBox
    Friend WithEvents btnOpnDriverFolder As System.Windows.Forms.Button
    Friend WithEvents chkForceUnsigned As System.Windows.Forms.CheckBox
    Friend WithEvents btnAddDriver As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorkerDISMCommand As System.ComponentModel.BackgroundWorker
    Friend WithEvents CleanupWIMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetWIMInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDisplayWIMInfo As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnGetPackages As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPackageFile As System.Windows.Forms.TextBox
    Friend WithEvents btnOpenPackageFile As System.Windows.Forms.Button
    Friend WithEvents btnAddPackages As System.Windows.Forms.Button
    Friend WithEvents chkIgnoreCheck As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGetAllDriverInfo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelDriver As System.Windows.Forms.Button
    Friend WithEvents txtDelDriverLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnRemovePackagePath As System.Windows.Forms.Button
    Friend WithEvents btnRemovePackageName As System.Windows.Forms.Button
    Friend WithEvents txtPackagePath As System.Windows.Forms.TextBox
    Friend WithEvents txtPackageName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkRecurse As System.Windows.Forms.CheckBox
    Friend WithEvents btnGetFeatures As System.Windows.Forms.Button
    Friend WithEvents btnEnableFeature As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFeatPackagePath As System.Windows.Forms.TextBox
    Friend WithEvents txtFeatPackageName As System.Windows.Forms.TextBox
    Friend WithEvents txtFeatureName As System.Windows.Forms.TextBox
    Friend WithEvents chkEnablePkgPath As System.Windows.Forms.CheckBox
    Friend WithEvents chkEnablePkgName As System.Windows.Forms.CheckBox
    Friend WithEvents btnDisableFeature As System.Windows.Forms.Button
    Friend WithEvents CleanupImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
