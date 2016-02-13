Imports System.IO
Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim intchar As Integer
    Dim intword() As Integer
    Dim strFile As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents st1 As System.Windows.Forms.StatusBar
    Friend WithEvents stchar As System.Windows.Forms.StatusBarPanel
    Friend WithEvents stwrod As System.Windows.Forms.StatusBarPanel
    Friend WithEvents stdate As System.Windows.Forms.StatusBarPanel
    Friend WithEvents sttime As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.MenuItem31 = New System.Windows.Forms.MenuItem
        Me.MenuItem32 = New System.Windows.Forms.MenuItem
        Me.MenuItem33 = New System.Windows.Forms.MenuItem
        Me.MenuItem40 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem34 = New System.Windows.Forms.MenuItem
        Me.MenuItem35 = New System.Windows.Forms.MenuItem
        Me.MenuItem36 = New System.Windows.Forms.MenuItem
        Me.MenuItem37 = New System.Windows.Forms.MenuItem
        Me.MenuItem38 = New System.Windows.Forms.MenuItem
        Me.MenuItem39 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.st1 = New System.Windows.Forms.StatusBar
        Me.stchar = New System.Windows.Forms.StatusBarPanel
        Me.stwrod = New System.Windows.Forms.StatusBarPanel
        Me.stdate = New System.Windows.Forms.StatusBarPanel
        Me.sttime = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        CType(Me.stchar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stwrod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sttime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.AutoSize = False
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(600, 244)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem3, Me.MenuItem22, Me.MenuItem4, Me.MenuItem5})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem6, Me.MenuItem17, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9})
        Me.MenuItem1.Text = "&File"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.MenuItem2.Text = " &New          "
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 2
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.MenuItem17.Text = "&Open"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 3
        Me.MenuItem7.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.MenuItem7.Text = "&Save"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 4
        Me.MenuItem8.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 5
        Me.MenuItem9.Text = "&Exit"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem19, Me.MenuItem21, Me.MenuItem18, Me.MenuItem20})
        Me.MenuItem3.Text = "&Edit"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 0
        Me.MenuItem10.Text = "C&lear"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 1
        Me.MenuItem19.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 2
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.CtrlC
        Me.MenuItem21.Text = "&Copy          "
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 3
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        Me.MenuItem18.Text = "Cu&t"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 4
        Me.MenuItem20.Shortcut = System.Windows.Forms.Shortcut.CtrlV
        Me.MenuItem20.Text = "&Paste"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 2
        Me.MenuItem22.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem23, Me.MenuItem24, Me.MenuItem25, Me.MenuItem26, Me.MenuItem27, Me.MenuItem28, Me.MenuItem29})
        Me.MenuItem22.Text = "&Formate"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 0
        Me.MenuItem23.Text = "&Font Size      "
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 1
        Me.MenuItem24.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem30, Me.MenuItem31, Me.MenuItem32, Me.MenuItem33, Me.MenuItem40})
        Me.MenuItem24.Text = "Font &Color"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 0
        Me.MenuItem30.Text = "&Red            "
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 1
        Me.MenuItem31.Text = "&Blue"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 2
        Me.MenuItem32.Text = "&Green"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 3
        Me.MenuItem33.Text = "&Yellow"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 4
        Me.MenuItem40.Text = "&Wite"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 2
        Me.MenuItem25.Text = "-"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 3
        Me.MenuItem26.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem34, Me.MenuItem35, Me.MenuItem36, Me.MenuItem37, Me.MenuItem38, Me.MenuItem39})
        Me.MenuItem26.Text = "&Background Color"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 0
        Me.MenuItem34.Text = "&Blue                 "
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 1
        Me.MenuItem35.Text = "B&lack"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 2
        Me.MenuItem36.Text = "&Red"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 3
        Me.MenuItem37.Text = "&Green"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 4
        Me.MenuItem38.Text = "&Yellow"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 5
        Me.MenuItem39.Text = "&Brown"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 4
        Me.MenuItem27.Text = "-"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 5
        Me.MenuItem28.Text = "&Upper Case"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 6
        Me.MenuItem29.Text = "&Lower Case"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem11, Me.MenuItem12, Me.MenuItem13})
        Me.MenuItem4.Text = "&Windows"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 0
        Me.MenuItem11.Text = "&Vertical          "
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 1
        Me.MenuItem12.Text = "&Horizental"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 2
        Me.MenuItem13.Text = "&Cascade"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem14, Me.MenuItem15, Me.MenuItem16})
        Me.MenuItem5.Text = "&About"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 0
        Me.MenuItem14.Text = "Software          "
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 1
        Me.MenuItem15.Text = "-"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 2
        Me.MenuItem16.Text = "Author"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'st1
        '
        Me.st1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.st1.Location = New System.Drawing.Point(0, 251)
        Me.st1.Name = "st1"
        Me.st1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.stchar, Me.stwrod, Me.stdate, Me.sttime, Me.StatusBarPanel1})
        Me.st1.ShowPanels = True
        Me.st1.Size = New System.Drawing.Size(600, 22)
        Me.st1.TabIndex = 1
        Me.st1.Text = "Status:"
        '
        'stchar
        '
        Me.stchar.Text = "StatusBarPanel1"
        Me.stchar.ToolTipText = "Total Chatecter in Text"
        '
        'stwrod
        '
        Me.stwrod.Text = "StatusBarPanel2"
        Me.stwrod.ToolTipText = "Total words in Text"
        '
        'stdate
        '
        Me.stdate.Text = "StatusBarPanel3"
        Me.stdate.ToolTipText = "Current Date :"
        '
        'sttime
        '
        Me.sttime.Text = "StatusBarPanel4"
        Me.sttime.ToolTipText = "Current Time :"
        Me.sttime.Width = 140
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Text = "University of Peshawar."
        Me.StatusBarPanel1.Width = 170
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(600, 273)
        Me.Controls.Add(Me.st1)
        Me.Controls.Add(Me.TextBox1)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "Notepad"
        CType(Me.stchar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stwrod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sttime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Timer1.Enabled = True
        Me.st1.Panels(0).Text = "Charecter :"
        Me.st1.Panels(1).Text = "Words."
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.st1.Panels(0).Text = Me.countC(Me.TextBox1.Text) & "  Charecters."
        Me.st1.Panels(1).Text = Me.countW(Me.TextBox1.Text) & "  words."

    End Sub



    Public Function countC(ByVal text As String) As Integer
        intchar = text.Length
        Return intchar
    End Function
    Public Function countW(ByVal text As String) As Integer
        If Me.TextBox1.Text = "" Then Return 0
        Dim chtword() As String = text.Split("".ToCharArray)
        Return chtword.Length
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.st1.Panels(2).Text = Now.ToString("hh:mm:ss" & " tt")
        Me.st1.Panels(3).Text = Now.Day & " - " & Now.ToString("MMMM") & " - " & Now.Year
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Dim result As DialogResult
        result = MsgBox("Are you sure to Quit application !", MsgBoxStyle.Information, "Exit Message")
        If result.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Me.TextBox1.Text = ""
    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        Me.TextBox1.ForeColor = System.Drawing.Color.Red
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        Me.TextBox1.ForeColor = System.Drawing.Color.Blue
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        Me.TextBox1.ForeColor = System.Drawing.Color.Green
    End Sub

    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        Me.TextBox1.ForeColor = System.Drawing.Color.Yellow
    End Sub
    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
        Me.TextBox1.ForeColor = System.Drawing.Color.White
    End Sub

    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        Me.TextBox1.BackColor = System.Drawing.Color.Blue
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        Me.TextBox1.BackColor = System.Drawing.Color.Black
    End Sub

    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        Me.TextBox1.BackColor = System.Drawing.Color.Red
    End Sub

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        Me.TextBox1.BackColor = System.Drawing.Color.Green
    End Sub

    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        Me.TextBox1.BackColor = System.Drawing.Color.Yellow
    End Sub

    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click
        Me.TextBox1.BackColor = System.Drawing.Color.Brown
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        Me.TextBox1.Text = Me.TextBox1.Text.ToUpper()
    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        Me.TextBox1.Text = Me.TextBox1.Text.ToLower
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click

        Me.FontDialog1.ShowColor = True
        If Me.FontDialog1.ShowDialog = DialogResult.OK Then
            Me.TextBox1.Font = Me.FontDialog1.Font
            Me.TextBox1.ForeColor = Me.FontDialog1.Color
        End If

    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click

        With Me.OpenFileDialog1
            .Filter = "Text files(*.txt)|*.txt|All Files(*.*)|*.*"
            .FilterIndex = 1
            .InitialDirectory = "C:|"
            .Title = "Open File Demo"
        End With
        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            strFile = Me.OpenFileDialog1.FileName
            Dim objreader As StreamReader = New StreamReader(strFile)
            Me.TextBox1.Text = objreader.ReadToEnd
            objreader.Close()
            objreader = Nothing
        End If
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Dim strfile As String
        With Me.SaveFileDialog1
            .DefaultExt = "txt"
            .FileName = strFile
            .Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*"
            .OverwritePrompt = True
            .Title = "Save File Demo"
            '
            If Me.SaveFileDialog1.ShowDialog = DialogResult.OK Then
                strFile = Me.SaveFileDialog1.FileName
                Dim objwriter As StreamWriter = New StreamWriter(strFile)
                objwriter.Write(Me.TextBox1.Text)
                objwriter.Close()
                objwriter = Nothing
            End If
        End With
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        If Me.TextBox1.Text = "" Then
            Me.TextBox1.Text = ""
        Else
            Dim strff As String
            Dim rt As DialogResult
            rt = MessageBox.Show("Save before Exit !", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If rt = DialogResult.OK Then
                If Me.SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                    strff = Me.SaveFileDialog1.FileName
                    Dim str As StreamWriter = New StreamWriter(strff)
                    str.Write(Me.TextBox1.Text)
                    str.Close()
                    str = Nothing
                End If

            End If


        End If
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Dim sh As New frmfontdialog
        sh.ShowDialog()
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        Dim sh As New frmfontdialog
        sh.ShowDialog()
    End Sub
End Class
