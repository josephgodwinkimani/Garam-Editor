Imports System.Windows.Forms

Public Class frmRichAlternative

    Dim I As Integer = 1
    Dim frozenIndex As Integer = -1
    Public Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Long) As Integer
  
    Private Sub frmRichAlternative_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myTabPage0 As New TabPage()
        myTabPage0.Text = "WorkPad " & (TabControl1.TabPages.Count + 0)
        TabControl1.TabPages.Add(myTabPage0)
        Dim txtBox As New RichTextBox
        myTabPage0.Controls.Add(txtBox)
        txtBox.Size = New Size(891, 341)
        txtBox.Multiline = True
        txtBox.ScrollBars = RichTextBoxScrollBars.ForcedBoth
        txtBox.BackColor = Color.White
        txtBox.Text = "Type Here"
        txtBox.WordWrap = True
        Button6.Enabled = False
        Button7.Enabled = False
    End Sub
    Private Sub CheckLockKeys()
        If My.Computer.Keyboard.CapsLock = 1 Then
            ToolStripStatusLabel2.Enabled = True
            ToolStripStatusLabel2.Text = "CAPS ON"
        Else
            ToolStripStatusLabel2.Enabled = False
            ToolStripStatusLabel2.Text = "CAPS OFF"
        End If
        If My.Computer.Keyboard.NumLock = 1 Then
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


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myTabPage0 As New TabPage()
        myTabPage0.Text = "WorkPad " & (TabControl1.TabPages.Count + 0)
        TabControl1.TabPages.Add(myTabPage0)
        Dim txtBox As New RichTextBox
        myTabPage0.Controls.Add(txtBox)
        txtBox.Size = New Size(891, 341)
        txtBox.Multiline = True
        txtBox.ScrollBars = RichTextBoxScrollBars.ForcedBoth
        txtBox.BackColor = Color.White
        txtBox.Text = "Type Here"
        txtBox.WordWrap = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TabControl1.TabCount = 2 Then
            MsgBox("Error You Can't Remove The Last Page", MsgBoxStyle.Critical)
            'Now you can change the message to whatever you like
            'This code will not allow us to remove the last tabpage which automatically loads
            'If it did an error would occur.
        Else

            TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
            'This bottom code is telling it to remove the selected tab and countdown minus (-) 1 (one)
            TabControl1.SelectTab(TabControl1.TabPages.Count - 1)
            I = I - 1
        End If

    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        TabControl1.SelectedIndex = If(frozenIndex <> -1, frozenIndex, TabControl1.SelectedIndex)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If ToolStripButton1.Checked Then
            frozenIndex = TabControl1.SelectedIndex()
            Button3.Enabled = False
        Else
            frozenIndex = -1
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        Dim AllText As String = "", LineOfText As String = ""
        'This bottom code is telling it to search each and ever file type
        OpenFileDialog1.Filter = "All Files|*.*"
        'This bottom code basically shows the opendialog box
        OpenFileDialog1.ShowDialog()
        Try
            FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
            Do Until EOF(1)
                LineOfText = LineInput(1)
                AllText = AllText & LineOfText & vbCrLf
            Loop
            CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Text = AllText
        Catch

        Finally
            FileClose(1)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim SaveFileDialog1 As New SaveFileDialog
        'The bottom code is shows which file types we can save it as you can add
        'More file types by using the same method
        'You can add html and other types if you like
        SaveFileDialog1.Filter = "Rich Text Files|*.rtf|Text Files|*.txt"
        'This tells it to show the dialog basically remember when you got
        'Something called “show Dialog” You can’t go back to the main programme without ‘closing
        'The first dialog showing
        SaveFileDialog1.ShowDialog()
        FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
        PrintLine(1, CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Text)
        FileClose(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Undo()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Redo()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).SelectAll()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Cut()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Copy()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Paste()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        'This will empty the selected Tab text
        CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Text = ""
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If TabControl1.TabCount = 0 Then

        End If

        Dim FS As New FontDialog
        FS.ShowDialog()
        CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Font = FS.Font
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If TabControl1.TabCount = 0 Then


        End If
        Dim FC As New ColorDialog
        FC.ShowDialog()
        CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).ForeColor = FC.Color

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmFindandReplace.Visible = True
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmFindandReplace.Visible = True
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim txtBox As New RichTextBox
        txtBox.ReadOnly = True
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim txtBox As New RichTextBox
        txtBox.WordWrap = True
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        ToolStripStatusLabel1.Name = ""
        ToolStripStatusLabel1.Text = "Project Explorer started. No action yet."
        ToolStripStatusLabel1.ToolTipText = "Last Activity"
    End Sub


End Class