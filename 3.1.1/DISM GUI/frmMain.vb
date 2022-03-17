Imports Microsoft.Win32
Public Class frmMain
    Public Property RedirectStandardOutput As Boolean
    Dim strFolderName As String
    Dim WIMMounted As Boolean = False
    Dim strMountedImageLocation As String
    Dim strIndex As String
    Dim strWIM As String
    Dim strOutput As String
    Dim strDISMExitCode As String
    Dim blnDISMCommit As Boolean
    Dim strDriverLocation As String
    Dim blnForceUnsigned As Boolean
    Dim strDISMArguments As String
    Dim strPackageLocation As String
    Dim strLocation As String
    Dim blnIgnoreCheck As Boolean
    Dim strDelDriverLocation As String
    Dim strPackageName As String
    Dim strPackagePath As String
    Dim strFeatureName As String
    Dim OnlineMode As Boolean = False






    Private Sub btnOpenWIM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenWIM.Click
        dlgOpenFile.InitialDirectory = "c:\"
        dlgOpenFile.Title = "Choose WIM file to Open"
        dlgOpenFile.Filter = ("WIM Files(*.wim)|*.wim|All Files (*.*)|*.*")
        Dim DidWork As Integer = dlgOpenFile.ShowDialog

        If DidWork = DialogResult.Cancel Then
            'Do Nothing
        Else
            Dim strFileName As String = dlgOpenFile.FileName
            txtWIM.Text = strFileName
        End If

    End Sub

    Private Sub btnOpenMount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenMount.Click
        dlgOpenFolder.ShowNewFolderButton = False
        dlgOpenFolder.RootFolder = Environment.SpecialFolder.MyComputer
        dlgOpenFolder.ShowDialog()
        Dim strFolderName As String = dlgOpenFolder.SelectedPath
        Dim dirs As String() = System.IO.Directory.GetDirectories(strFolderName)
        Dim files As String() = System.IO.Directory.GetFiles(strFolderName)
        If dirs.Length = 0 AndAlso files.Length = 0 Then
            txtMount.Text = strFolderName
        Else
            If MessageBox.Show("You must choose an empty folder to mount the WIM") = DialogResult.OK Then
            Else
                'Do Nothing
            End If
        End If
    End Sub

   

    Private Sub btnMount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMount.Click
        txtOutput.Text = ""
        If txtWIM.Text = "" Or txtMount.Text = "" Or cmbIndex.Text = "" Then
            MsgBox("You must select a WIM and folder first")
        Else
            txtMount.Text = Replace(txtMount.Text, """", "")
            strFolderName = txtMount.Text
            strIndex = cmbIndex.Text
            txtWIM.Text = Replace(txtWIM.Text, """", "")
            strWIM = txtWIM.Text
            BackgroundWorkerMount.RunWorkerAsync()
            frmProgress.ShowDialog()
            txtOutput.Text = strOutput
        End If



    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()

    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If WIMMounted = True Then
                If MessageBox.Show("You currently have a WIM Mounted.  Do you want to dismount before exiting?", "WIM Mounted", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    'DismountWIM()
                    BackgroundWorkerDisMount.RunWorkerAsync()
                    frmProgress.ShowDialog()


                Else
                    e.Cancel = False
                End If
            Else
                'Do Nothing - Exit form
            End If
        Else
            e.Cancel = True
        End If

       
    End Sub


    Private Sub btnDismount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDismount.Click
        strFolderName = txtMount.Text
        strIndex = cmbIndex.Text
        strWIM = txtWIM.Text
        txtOutput.Text = ""
        BackgroundWorkerDisMount.RunWorkerAsync()
        frmProgress.ShowDialog()
        txtOutput.Text = strOutput


    End Sub

   
    Private Sub btnOpenFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFolder.Click
        Dim OpenFolder As New Process
        Process.Start("explorer.exe", txtMount.Text)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    
    Private Sub OpenDISMLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenDISMLogToolStripMenuItem.Click
        Dim strWinDir As String = System.Environment.GetEnvironmentVariable("windir")
        Dim OpenDISMLog As New Process
        Process.Start("Notepad.exe", strWinDir & "\Logs\DISM\dism.log")
    End Sub

    Private Sub btnGetDrivers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetDrivers.Click
        If WIMMounted = False Then
            MessageBox.Show("No WIM is mounted.  You must mount a WIM before running this command.")
        Else
            strDISMArguments = "/image:""" & strMountedImageLocation & """" & " /Get-Drivers"
            BackgroundWorkerDISMCommand.RunWorkerAsync(strDISMArguments)
            'BackgroundGetDrivers.RunWorkerAsync()
            frmProgress.ShowDialog()
            txtOutput.Text = strOutput
        End If

    End Sub

    Private Sub BackgroundWorkerMount_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerMount.DoWork
        strDISMExitCode = ""
        'Mount WIM file
        Dim DISM As New Process()
        DISM.StartInfo.RedirectStandardOutput = True
        DISM.StartInfo.RedirectStandardError = True
        DISM.StartInfo.UseShellExecute = False
        DISM.StartInfo.CreateNoWindow = True
        DISM.StartInfo.FileName = "dism.exe"
        DISM.StartInfo.Arguments = "/Mount-WIM /WimFile:""" & strWIM & """" & " /index:" & strIndex & " /MountDir:" & """" & strFolderName & """"
        strOutput = "Command line that ran is dism.exe " & DISM.StartInfo.Arguments
        DISM.Start()
        strOutput = strOutput & vbCr & vbCr & DISM.StandardOutput.ReadToEnd()
        DISM.WaitForExit()
        'txtOutput.Text = output
        strDISMExitCode = DISM.ExitCode.ToString()
    End Sub

    Private Sub BackgroundWorkerMount_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerMount.RunWorkerCompleted
        'Check to see if WIM mounted correctly
        If strDISMExitCode = "0" Then
            btnMount.Enabled = False
            btnDismount.Enabled = True
            WIMMounted = True
            If strMountedImageLocation = "" Then
                strMountedImageLocation = strFolderName
            Else
                'Do Nothing
            End If
            frmProgress.Close()
        Else
            frmProgress.Close()
        End If
    End Sub

    Private Sub BackgroundWorkerDisMount_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerDisMount.DoWork
        strDISMExitCode = ""

        If MessageBox.Show("Do you want to commit changes?", "WIM Mounted", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            blnDISMCommit = True
        Else
            blnDISMCommit = False
        End If


        Dim DISM As New Process()
        DISM.StartInfo.RedirectStandardOutput = True
        DISM.StartInfo.RedirectStandardError = True
        DISM.StartInfo.UseShellExecute = False
        DISM.StartInfo.CreateNoWindow = True
        DISM.StartInfo.FileName = "dism.exe"

        If blnDISMCommit = True Then
            DISM.StartInfo.Arguments = "/Unmount-wim /mountdir:""" & strFolderName & """ /commit"
            strOutput = "Command line that ran is dism.exe " & DISM.StartInfo.Arguments
            DISM.Start()
        Else
            DISM.StartInfo.Arguments = "/Unmount-wim /mountdir:""" & strFolderName & """ /discard"
            strOutput = "Command line that ran is dism.exe " & DISM.StartInfo.Arguments
            DISM.Start()
        End If

        strOutput = strOutput & vbCr & vbCr & DISM.StandardOutput.ReadToEnd()
        DISM.WaitForExit()
        strDISMExitCode = DISM.ExitCode.ToString()
    End Sub

    Private Sub BackgroundWorkerDisMount_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerDisMount.RunWorkerCompleted
        'Verify DIM was dismounted
        If strDISMExitCode = "0" Then
            btnMount.Enabled = True
            btnDismount.Enabled = False
            WIMMounted = False
            strMountedImageLocation = ""
            frmProgress.Close()
        Else
            frmProgress.Close()
        End If
    End Sub

    Private Sub btnOpnDriverFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpnDriverFolder.Click
        txtDriverLocation.Text = OpenFolder().ToString()
    End Sub

    Private Sub btnAddDriver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddDriver.Click
        If WIMMounted = False Then
            MessageBox.Show("No WIM is mounted.  You must mount a WIM before running this command.")
        Else
            If txtDriverLocation.Text = "" Then
                MessageBox.Show("You must specify a folder where your drivers are located.")
            Else
                strDriverLocation = txtDriverLocation.Text
                If chkForceUnsigned.Checked = True Then
                    'blnForceUnsigned = True
                    strDISMArguments = "/image:""" & strMountedImageLocation & """" & " /Add-Driver /driver:""" & strDriverLocation & """" & " /ForceUnsigned "
                Else
                    'blnForceUnsigned = False
                    strDISMArguments = "/image:""" & strMountedImageLocation & """" & " /Add-Driver /driver:""" & strDriverLocation & """" & " "
                End If
                If chkRecurse.Checked = True Then
                    strDISMArguments = strDISMArguments & "/recurse"
                Else
                    'Do Nothing
                End If
                BackgroundWorkerDISMCommand.RunWorkerAsync(strDISMArguments)
                frmProgress.ShowDialog()
            End If
        End If
        txtOutput.Text = strOutput
    End Sub

    Private Sub GetWIMInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetWIMInfoToolStripMenuItem.Click
        strDISMArguments = "/Get-MountedWIMInfo"
        BackgroundWorkerDISMCommand.RunWorkerAsync(strDISMArguments)
        frmProgress.ShowDialog()
        txtOutput.Text = strOutput
    End Sub

    Private Sub BackgroundWorkerDISMCommand_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerDISMCommand.DoWork
        Dim strInput As String = e.Argument.ToString()
        strDISMExitCode = ""
        Dim DISM As New Process()
        DISM.StartInfo.RedirectStandardOutput = True
        DISM.StartInfo.RedirectStandardError = True
        DISM.StartInfo.UseShellExecute = False
        DISM.StartInfo.CreateNoWindow = True
        DISM.StartInfo.FileName = "dism.exe"
        DISM.StartInfo.Arguments = strInput
        strOutput = "Command line that ran is dism.exe " & DISM.StartInfo.Arguments
        DISM.Start()
        strOutput = strOutput & vbCr & vbCr & DISM.StandardOutput.ReadToEnd()
        DISM.WaitForExit()
        strDISMExitCode = DISM.ExitCode.ToString()
    End Sub

    Private Sub BackgroundWorkerDISMCommand_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerDISMCommand.RunWorkerCompleted
        strDISMArguments = ""
        frmProgress.Close()
    End Sub

    Private Sub CleanupWIMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CleanupWIMToolStripMenuItem.Click
        strDISMArguments = "/Cleanup-WIM"
        BackgroundWorkerDISMCommand.RunWorkerAsync(strDISMArguments)
        frmProgress.ShowDialog()
        txtOutput.Text = strOutput
    End Sub

    
    Private Sub btnDisplayWIMInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayWIMInfo.Click

        If txtWIM.Text = "" Then
            MsgBox("You must select a WIM file first")
        Else

            strWIM = txtWIM.Text
            strDISMArguments = "/Get-WimInfo /wimFile:""" & strWIM & """"
            BackgroundWorkerDISMCommand.RunWorkerAsync(strDISMArguments)
            frmProgress.ShowDialog()
            txtOutput.Text = strOutput
        End If
    End Sub


    Private Sub btnGetPackages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetPackages.Click
        If WIMMounted = False Then
            MessageBox.Show("No WIM is mounted.  You must mount a WIM before running this command.")
        Else
            strDISMArguments = "/image:""" & strMountedImageLocation & """" & " /Get-Packages"
            BackgroundWorkerDISMCommand.RunWorkerAsync(strDISMArguments)
            frmProgress.ShowDialog()
            txtOutput.Text = strOutput
        End If
    End Sub


    Private Sub btnOpenPackageFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenPackageFile.Click
        txtPackageFile.Text = OpenFolder().ToString()
    End Sub

    Private Sub btnAddPackages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPackages.Click
        If WIMMounted = False Then
            MessageBox.Show("No WIM is mounted.  You must mount a WIM before running this command.")
        Else
            If txtPackageFile.Text = "" Then
                MessageBox.Show("You must specify a folder where your package(s) are located.")
            Else
                strPackageLocation = txtPackageFile.Text
                If chkIgnoreCheck.Checked = True Then
                    blnIgnoreCheck = True
                    strDISMArguments = "/image:""" & strMountedImageLocation & """" & " /Add-Package /PackagePath:""" & strPackageLocation & """" & " /ignorecheck"
                Else
                    blnIgnoreCheck = False
                    strDISMArguments = "/image:""" & strMountedImageLocation & """" & " /Add-Package /PackagePath:""" & strPackageLocation & """"
                End If
                BackgroundWorkerDISMCommand.RunWorkerAsync(strDISMArguments)
                frmProgress.ShowDialog()
            End If
        End If
        txtOutput.Text = strOutput
    End Sub

    Private Function OpenFolder() As Object
        dlgOpenFolder.ShowNewFolderButton = False
        dlgOpenFolder.RootFolder = Environment.SpecialFolder.MyComputer
        Dim DidWork As Integer = dlgOpenFolder.ShowDialog
        If DidWork = DialogResult.Cancel Then
            strLocation = ""
            Return strLocation
        Else
            strLocation = dlgOpenFolder.SelectedPath
            Return strLocation
        End If
    End Function



    Private Sub btnGetAllDriverInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetAllDriverInfo.Click
        If WIMMounted = False Then
            MessageBox.Show("No WIM is mounted.  You must mount a WIM before running this command.")
        Else
            strDelDriverLocation = txtDelDriverLocation.Text
            strDISMArguments = "/image:""" & strMountedImageLocation & """" & " /Get-Drivers /All"
            BackgroundWorkerDISMCommand.RunWorkerAsync(strDISMArguments)
            'BackgroundGetDrivers.RunWorkerAsync()
            frmProgress.ShowDialog()
            txtOutput.Text = strOutput
        End If
    End Sub

    Private Sub btnDelDriver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelDriver.Click
        If WIMMounted = False Then
            MessageBox.Show("No WIM is mounted.  You must mount a WIM before running this command.")
        Else
            If txtDelDriverLocation.Text = "" Then
                MessageBox.Show("You must enter in a driver name before continuing.  The Driver name must end with inf")
            Else
                strDelDriverLocation = txtDelDriverLocation.Text
                strDISMArguments = "/image:""" & strMountedImageLocation & """" & " /Remove-Driver /driver:""" & strDelDriverLocation & """"
                BackgroundWorkerDISMCommand.RunWorkerAsync(strDISMArguments)
                frmProgress.ShowDialog()
                txtOutput.Text = strOutput
            End If
            'Do Nothing
        End If
    End Sub

    Private Sub btnRemovePackageName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemovePackageName.Click
        If WIMMounted = False Then
            MessageBox.Show("No WIM is mounted.  You must mount a WIM before running this command.")
        Else
            If txtPackageName.Text = "" Then
                MessageBox.Show("You must enter in a package name before continuing.")
            Else
                strPackageName = txtPackageName.Text
                strDISMArguments = "/image:""" & strMountedImageLocation & """" & " /Remove-Package /PackageName:" & strPackageName
                BackgroundWorkerDISMCommand.RunWorkerAsync(strDISMArguments)
                frmProgress.ShowDialog()
                txtOutput.Text = strOutput
            End If
            'Do Nothing
        End If
    End Sub

    Private Sub btnRemovePackagePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemovePackagePath.Click
        If WIMMounted = False Then
            MessageBox.Show("No WIM is mounted.  You must mount a WIM before running this command.")
        Else
            If txtPackagePath.Text = "" Or Microsoft.VisualBasic.Left(txtPackagePath.Text, 3) <> "cab" Then
                MessageBox.Show("You must enter in a package path before continuing.  The package path must point to a valid cab file.")
            Else
                strPackagePath = txtPackagePath.Text
                strDISMArguments = "/image:""" & strMountedImageLocation & """" & " /Remove-Package /PackagePath:""" & strPackagePath & """"
                BackgroundWorkerDISMCommand.RunWorkerAsync(strDISMArguments)
                frmProgress.ShowDialog()
                txtOutput.Text = strOutput
            End If
            'Do Nothing
        End If
    End Sub

    Private Sub btnGetFeatures_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetFeatures.Click
        If WIMMounted = False Then
            MessageBox.Show("No WIM is mounted.  You must mount a WIM before running this command.")
        Else
            strDISMArguments = "/image:""" & strMountedImageLocation & """" & " /Get-Features"
            BackgroundWorkerDISMCommand.RunWorkerAsync(strDISMArguments)
            frmProgress.ShowDialog()
            txtOutput.Text = strOutput
        End If
    End Sub

    Private Sub chkEnablePkgName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnablePkgName.CheckedChanged
        If chkEnablePkgName.Checked = True Then
            txtFeatPackageName.Enabled = True
        ElseIf chkEnablePkgName.Checked = False Then
            txtFeatPackageName.Enabled = False
        End If

    End Sub

    Private Sub chkEnablePkgPath_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnablePkgPath.CheckedChanged
        If chkEnablePkgPath.Checked = True Then
            txtFeatPackagePath.Enabled = True
        ElseIf chkEnablePkgPath.Checked = False Then
            txtFeatPackagePath.Enabled = False
        End If
    End Sub

    Private Sub btnEnableFeature_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnableFeature.Click
        If WIMMounted = False Then
            MessageBox.Show("No WIM is mounted.  You must mount a WIM before running this command.")
            Exit Sub
        Else
            'Do Nothing
        End If

        If txtFeatureName.Text = "" Then
            MessageBox.Show("Feature Name is required to continue.")
            Exit Sub
        Else
            'Do Nothing
        End If

        If chkEnablePkgName.Checked = True And txtFeatPackageName.Text = "" Then
            MessageBox.Show("If you enable the Package Name field you must specify a Package Name")
            Exit Sub
        Else
            'Do Nothing
        End If

        If chkEnablePkgPath.Checked = True And txtFeatPackagePath.Text = "" Then
            MessageBox.Show("If you enable the Package Path field you must specify a Package Path")
            Exit Sub
        Else
            'Do Nothing
        End If

        strFeatureName = txtFeatureName.Text
        strDISMArguments = "/image:""" & strMountedImageLocation & """" & " /Enable-Feature /FeatureName:""" & strFeatureName & """" & " "

        If chkEnablePkgName.Checked = True Then
            strDISMArguments = strDISMArguments & "/PackageName:" & txtFeatPackageName.Text & " "
        Else
            'Do Nothing
        End If

        If chkEnablePkgPath.Checked = True Then
            strDISMArguments = strDISMArguments & "/PackagePath:" & txtFeatPackagePath.Text & " "
        Else
            'Do Nothing
        End If


        BackgroundWorkerDISMCommand.RunWorkerAsync(strDISMArguments)
        frmProgress.ShowDialog()


        txtOutput.Text = strOutput
    End Sub

    Private Sub btnDisableFeature_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisableFeature.Click
        If WIMMounted = False Then
            MessageBox.Show("No WIM is mounted.  You must mount a WIM before running this command.")
            Exit Sub
        Else
            'do nothing
        End If

        If txtFeatureName.Text = "" Then
            MessageBox.Show("Feature Name is required to continue.")
            Exit Sub
        Else
            'do nothing
        End If

        If chkEnablePkgName.Checked = True And txtFeatPackageName.Text = "" Then
            MessageBox.Show("If you enable the Package Name field you must specify a Package Name")
            Exit Sub
        Else
            'Do Nothing
        End If

        If chkEnablePkgPath.Checked = True Then
            MessageBox.Show("The PackagePath option cannot be used with disabling a feature.  Anything entered into that box will be ignored.")
        Else
            'Do Nothing
        End If

        strFeatureName = txtFeatureName.Text
        strDISMArguments = "/image:""" & strMountedImageLocation & """" & " /Disable-Feature /FeatureName:""" & strFeatureName & """" & " "

        If chkEnablePkgName.Checked = True Then
            strDISMArguments = strDISMArguments & "/PackageName:" & txtFeatPackageName.Text & " "
        Else
            'Do Nothing
        End If

        BackgroundWorkerDISMCommand.RunWorkerAsync(strDISMArguments)
        frmProgress.ShowDialog()
        txtOutput.Text = strOutput
    End Sub

    Private Sub CleanupImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CleanupImageToolStripMenuItem.Click
        strDISMArguments = "/image:""" & strMountedImageLocation & """" & " /Cleanup-Image /RevertPendingActions"
        BackgroundWorkerDISMCommand.RunWorkerAsync(strDISMArguments)
        frmProgress.ShowDialog()
        txtOutput.Text = strOutput
    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmbIndex.Text = "1"
    End Sub

End Class
