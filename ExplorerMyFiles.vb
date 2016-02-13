
Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.IO
Imports System
Imports System.ServiceProcess

Public Class ExplorerMyFiles


    Private Sub ExplorerMyFiles_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Set up the UI
        LoadTree()
        Dim localServices As ServiceController() = ServiceController.GetServices()
        Dim service As ServiceController
        Try
            For Each service In localServices

            Next

            ListBox2.Items.Add(service.DisplayName)
            MsgBox("Note: Multiple verification for all Dialog Boxes is enabled by default!", MsgBoxStyle.Information, "Welcome to Project Explorer")

            Dim filInfo As FileInfo
            For Each fil As String In Directory.GetFiles("c:\")
                filInfo = New FileInfo(fil)

                ListBox1.Items.Add(filInfo.Name)
            Next

            Dim DirInfo As DirectoryInfo
            For Each dir As String In Directory.GetDirectories("c:\")
                DirInfo = New DirectoryInfo(dir)
                ListBox1.Items.Add("[DIR] " & DirInfo.Name)
            Next
            ToolStripStatus.Text = "Ready..."
            ToolStripStatusLabel1.Text = "All services listed..."
        Catch exc As IOException

        End Try


    End Sub


    Private Sub CheckLockKeys()
        If My.Computer.Keyboard.CapsLock Then
            ToolStripStatusLabel2.Enabled = True
        Else
            ToolStripStatusLabel2.Enabled = False
        End If
        If My.Computer.Keyboard.NumLock Then
            ToolStripStatusLabel3.Enabled = True
        Else
            ToolStripStatusLabel3.Enabled = False
        End If
    End Sub

    Public Sub MDIParent_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.CapsLock Or e.KeyCode = Keys.NumLock Then
            CheckLockKeys()
        End If
    End Sub



    Private Sub LoadTree()
        ' TODO: Add code to add items to the treeview

        Dim tvRoot As TreeNode
        Dim tvNode1 As TreeNode
        Dim tvNode2 As TreeNode
        Dim tvNode3 As TreeNode
        Dim tvNode4 As TreeNode
        Dim tvNode5 As TreeNode
        Dim tvNode6 As TreeNode
        Dim tvNode7 As TreeNode
        Dim tvNode8 As TreeNode

        tvRoot = Me.TreeView.Nodes.Add("Libraries")
        tvNode1 = tvRoot.Nodes.Add(My.Computer.FileSystem.SpecialDirectories.MyDocuments)
        tvNode2 = tvRoot.Nodes.Add(My.Computer.FileSystem.SpecialDirectories.MyPictures)

        tvRoot = Me.TreeView.Nodes.Add("Other")
        tvNode3 = tvRoot.Nodes.Add(My.Computer.FileSystem.SpecialDirectories.Desktop)
        tvNode4 = tvRoot.Nodes.Add(My.Computer.FileSystem.SpecialDirectories.Programs)
        tvNode5 = tvRoot.Nodes.Add(My.Computer.FileSystem.SpecialDirectories.ProgramFiles)
        tvNode6 = tvRoot.Nodes.Add(My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData)
        tvNode7 = tvRoot.Nodes.Add(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData)
        tvNode8 = tvRoot.Nodes.Add(My.Computer.FileSystem.SpecialDirectories.Temp)



    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Close this form
        Me.Close()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBarToolStripMenuItem.Click
        'Toggle the visibility of the toolstrip and also the checked state of the associated menu item
        ToolBarToolStripMenuItem.Checked = Not ToolBarToolStripMenuItem.Checked
        ToolStrip.Visible = ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.Click
        'Toggle the visibility of the statusstrip and also the checked state of the associated menu item
        StatusBarToolStripMenuItem.Checked = Not StatusBarToolStripMenuItem.Checked
        StatusStrip.Visible = StatusBarToolStripMenuItem.Checked
    End Sub

    'Change whether or not the folders pane is visible
    Private Sub ToggleFoldersVisible()
        'First toggle the checked state of the associated menu item
        FoldersToolStripMenuItem.Checked = Not FoldersToolStripMenuItem.Checked

        'Change the Folders toolbar button to be in sync
        FoldersToolStripButton.Checked = FoldersToolStripMenuItem.Checked

        ' Collapse the Panel containing the TreeView.
        Me.SplitContainer.Panel1Collapsed = Not FoldersToolStripMenuItem.Checked
    End Sub

    Private Sub FoldersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoldersToolStripMenuItem.Click
        ToggleFoldersVisible()
        ToolStripStatus.Text = "Folder view changed"
    End Sub

    Private Sub FoldersToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoldersToolStripButton.Click
        ToggleFoldersVisible()
        ToolStripStatus.Text = "Folder view toggled"
    End Sub


    Private Sub OpenToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*"
        OpenFileDialog.Multiselect = False
        OpenFileDialog.ShowDialog(Me)

        Dim FileName As String = OpenFileDialog.FileName
        Dim oReader As StreamReader

        ' TODO: Add code to open the file
        If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            oReader = New StreamReader(OpenFileDialog.FileName, True)
            TextBox1.Text = oReader.ReadToEnd
            MsgBox("Your file appeared in Project Explorer wordpad. Use its capabilties it supports data binding.  :)", MsgBoxStyle.Information, "Explorer Notification")
            ToolStripStatus.Text = "File Opened"
        ElseIf OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            MessageBox.Show("No file was loaded. Please Try again!", "Permission", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            ToolStripStatus.Text = "No File has been loaded"
        End If

    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        ListBox1.Items.Clear()
        ToolStripStatus.Text = "File List Cleared"

    End Sub





    Private Sub TreeView_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView.NodeMouseDoubleClick
        Try
            ' Look for a file extension, and open the file.
            If e.Node.Text.Contains("C:\") Then
                System.Diagnostics.Process.Start(e.Node.Text)
            End If
            ' If the file is not found, handle the exception and inform the user.
        Catch
            MessageBox.Show("File not found! Ask us for help.", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
        ToolStripStatus.Text = "Error on File search in C:\"

    End Sub

    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles ComboBox1.DropDown

        Dim foundFile As String
        If ComboBox1.SelectedItem = "My Documents" Then

            For Each foundFile In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.SpecialDirectories.MyDocuments)
                ListBox1.Items.Add(foundFile)
            Next
            ToolStripStatus.Text = "Listed all files in My Documents"
        ElseIf ComboBox1.SelectedItem = "My Programs" Then

            For Each foundFile In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.SpecialDirectories.Programs)
                ListBox1.Items.Add(foundFile)
            Next
            ToolStripStatus.Text = "Listed all files in My Programs directory"
        End If

        If ComboBox1.SelectedItem = "My Pictures" Then
            For Each foundFile In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.SpecialDirectories.MyPictures)
                ListBox1.Items.Add(foundFile)
                ToolStripStatus.Text = "Listed all files in My Pictures directory"

            Next
        End If
        If ComboBox1.SelectedItem = "My Program Files" Then
            For Each foundFile In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.SpecialDirectories.ProgramFiles)
                ListBox1.Items.Add(foundFile)
                ToolStripStatus.Text = "Listed all My Program Files"

            Next
        End If
        If ComboBox1.SelectedItem = "Local Drives" Then

            Process.Start("CMD", "/K wmic logicaldisk get deviceid, volumename, description")
            ToolStripStatus.Text = "Intialized Command Prompt with list of Local Drives"


        End If
        If ComboBox1.SelectedItem = "Current Directory" Then
            For Each foundFile In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CurrentDirectory)

            Next
            ListBox1.Items.Add(foundFile)
            ToolStripStatus.Text = "Listed all files in Current Directory"

        End If
    End Sub




    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TextBox1.Cut()
        ToolStripStatus.Text = "Action: Cut(Ctrl + X)"
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        TextBox1.Undo()
        ToolStripStatus.Text = "Action: Undo(Ctrl + Z)"
    End Sub


    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        frmFindandReplace.Visible = True
        frmFindandReplace.TextBoxSearch.Focus()
        ToolStripStatus.Text = "Action: Find"

    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceToolStripMenuItem.Click
        frmFindandReplace.Visible = True
        frmFindandReplace.TextBoxReplace.Focus()
        ToolStripStatus.Text = "Action: Replace"
    End Sub


    Private Sub ToolStripStatus_Click(sender As Object, e As EventArgs) Handles ToolStripStatus.Click
        ToolStripStatus.Name = ""
        ToolStripStatus.Text = "Project Explorer started. No action yet."
        ToolStripStatus.ToolTipText = "Last Activity"
        ToolStripStatus.Width = 100
    End Sub

    Private Sub FindNode(tn As TreeNode)
        Throw New NotImplementedException
    End Sub


    Private Sub ListBox2_Enter(sender As Object, e As EventArgs) Handles ListBox2.Enter
        Dim localServices As ServiceController() = ServiceController.GetServices()
        Dim service As ServiceController
        service = localServices(ListBox2.SelectedItem)

        ToolStripTextBox1.Text = service.DisplayName
        ToolStripTextBox2.Text = service.ServiceName
        ToolStripStatusLabel1.Text = service.Status.ToString()
        ToolStripStatus.Text = "All services are loaded..."
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ToolStripStatus.Text = "File in C:\ highlighted"
    End Sub



End Class
