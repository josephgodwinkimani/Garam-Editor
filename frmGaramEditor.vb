Imports System.IO
Imports System.Net.Mail
Imports System.Text



Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form starts here

    Dim intchar As Integer
    Dim intword() As Integer
    Dim I As Integer = 1
    Dim strFile As String
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents st1 As System.Windows.Forms.StatusBar
    Friend WithEvents stchar As System.Windows.Forms.StatusBarPanel
    Friend WithEvents stwrod As System.Windows.Forms.StatusBarPanel
    Friend WithEvents stdate As System.Windows.Forms.StatusBarPanel
    Friend WithEvents sttime As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem58 As System.Windows.Forms.MenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents MenuItem59 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents EventsList As System.Windows.Forms.ListBox
    Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem66 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem67 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem


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
    Friend WithEvents txtClientArea As System.Windows.Forms.TextBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
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
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtClientArea = New System.Windows.Forms.TextBox()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem41 = New System.Windows.Forms.MenuItem()
        Me.MenuItem42 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem43 = New System.Windows.Forms.MenuItem()
        Me.MenuItem63 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem44 = New System.Windows.Forms.MenuItem()
        Me.MenuItem45 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem46 = New System.Windows.Forms.MenuItem()
        Me.MenuItem47 = New System.Windows.Forms.MenuItem()
        Me.MenuItem48 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem58 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem54 = New System.Windows.Forms.MenuItem()
        Me.MenuItem53 = New System.Windows.Forms.MenuItem()
        Me.MenuItem55 = New System.Windows.Forms.MenuItem()
        Me.MenuItem56 = New System.Windows.Forms.MenuItem()
        Me.MenuItem57 = New System.Windows.Forms.MenuItem()
        Me.MenuItem52 = New System.Windows.Forms.MenuItem()
        Me.MenuItem59 = New System.Windows.Forms.MenuItem()
        Me.MenuItem62 = New System.Windows.Forms.MenuItem()
        Me.MenuItem64 = New System.Windows.Forms.MenuItem()
        Me.MenuItem65 = New System.Windows.Forms.MenuItem()
        Me.MenuItem49 = New System.Windows.Forms.MenuItem()
        Me.MenuItem67 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem66 = New System.Windows.Forms.MenuItem()
        Me.MenuItem60 = New System.Windows.Forms.MenuItem()
        Me.MenuItem61 = New System.Windows.Forms.MenuItem()
        Me.MenuItem51 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem50 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.st1 = New System.Windows.Forms.StatusBar()
        Me.stchar = New System.Windows.Forms.StatusBarPanel()
        Me.stwrod = New System.Windows.Forms.StatusBarPanel()
        Me.stdate = New System.Windows.Forms.StatusBarPanel()
        Me.sttime = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.EventsList = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.stchar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stwrod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sttime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtClientArea
        '
        Me.txtClientArea.AllowDrop = True
        Me.txtClientArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClientArea.AutoCompleteCustomSource.AddRange(New String() {"<% %>", "<html></html>", "<p></p>", "<h></h>", "<h1></h1>", "<h2></h2>", "<h3></h3>", "<?php--Text Here?>", "<!DOCTYPE html>", "/* Text Here */", "$rubyglobal_variable", "@@rubyclass_variable", "", "", ""})
        Me.txtClientArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtClientArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources
        Me.txtClientArea.BackColor = System.Drawing.SystemColors.WindowText
        Me.txtClientArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClientArea.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientArea.ForeColor = System.Drawing.Color.White
        Me.HelpProvider1.SetHelpKeyword(Me.txtClientArea, "")
        Me.txtClientArea.Location = New System.Drawing.Point(0, 45)
        Me.txtClientArea.Multiline = True
        Me.txtClientArea.Name = "txtClientArea"
        Me.txtClientArea.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.HelpProvider1.SetShowHelp(Me.txtClientArea, True)
        Me.txtClientArea.Size = New System.Drawing.Size(1237, 436)
        Me.txtClientArea.TabIndex = 0
        Me.txtClientArea.WordWrap = False
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem3, Me.MenuItem4, Me.MenuItem46, Me.MenuItem22, Me.MenuItem52, Me.MenuItem59, Me.MenuItem62, Me.MenuItem64, Me.MenuItem49, Me.MenuItem5})
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
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem41, Me.MenuItem42, Me.MenuItem10, Me.MenuItem19, Me.MenuItem21, Me.MenuItem18, Me.MenuItem20, Me.MenuItem43, Me.MenuItem63})
        Me.MenuItem3.Text = "&Edit"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 0
        Me.MenuItem41.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem41.Text = "&Undo         "
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 1
        Me.MenuItem42.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 2
        Me.MenuItem10.Text = "&Delete"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 3
        Me.MenuItem19.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 4
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        Me.MenuItem21.Text = "&Cut         "
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 5
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.CtrlC
        Me.MenuItem18.Text = "Co&py"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 6
        Me.MenuItem20.Shortcut = System.Windows.Forms.Shortcut.CtrlV
        Me.MenuItem20.Text = "&Paste"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 7
        Me.MenuItem43.Text = "-"
        '
        'MenuItem63
        '
        Me.MenuItem63.Index = 8
        Me.MenuItem63.Shortcut = System.Windows.Forms.Shortcut.CtrlA
        Me.MenuItem63.Text = "Select &All"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem44, Me.MenuItem45, Me.MenuItem11, Me.MenuItem12, Me.MenuItem13})
        Me.MenuItem4.Text = "&Views"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 0
        Me.MenuItem44.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftX
        Me.MenuItem44.Text = "&Reset All"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 1
        Me.MenuItem45.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 2
        Me.MenuItem11.Text = "&Vertical          "
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 3
        Me.MenuItem12.Text = "&Horizontal"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 4
        Me.MenuItem13.Text = "&Cascade"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 3
        Me.MenuItem46.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem47, Me.MenuItem48})
        Me.MenuItem46.Text = "&Search"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 0
        Me.MenuItem47.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem47.Text = "Find..."
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 1
        Me.MenuItem48.Shortcut = System.Windows.Forms.Shortcut.CtrlH
        Me.MenuItem48.Text = "Replace..."
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 4
        Me.MenuItem22.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem23, Me.MenuItem24, Me.MenuItem25, Me.MenuItem26, Me.MenuItem58, Me.MenuItem27, Me.MenuItem28, Me.MenuItem29, Me.MenuItem54, Me.MenuItem53})
        Me.MenuItem22.Text = "&Format"
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
        Me.MenuItem40.Text = "&White"
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
        'MenuItem58
        '
        Me.MenuItem58.Index = 4
        Me.MenuItem58.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftC
        Me.MenuItem58.Text = "Foreground Color"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 5
        Me.MenuItem27.Text = "-"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 6
        Me.MenuItem28.Text = "&Upper Case"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 7
        Me.MenuItem29.Text = "&Lower Case"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 8
        Me.MenuItem54.Text = "-"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 9
        Me.MenuItem53.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem55, Me.MenuItem56, Me.MenuItem57})
        Me.MenuItem53.Text = "Alignment"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 0
        Me.MenuItem55.Text = "AlignLeft"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 1
        Me.MenuItem56.Text = "AlignCenter"
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 2
        Me.MenuItem57.Text = "AlignRight"
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 5
        Me.MenuItem52.Shortcut = System.Windows.Forms.Shortcut.CtrlF12
        Me.MenuItem52.Text = "&Capture"
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 6
        Me.MenuItem59.Text = "E&xplore"
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 7
        Me.MenuItem62.Text = "&Optimize"
        '
        'MenuItem64
        '
        Me.MenuItem64.Index = 8
        Me.MenuItem64.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem65})
        Me.MenuItem64.Text = "&Work Area"
        '
        'MenuItem65
        '
        Me.MenuItem65.Index = 0
        Me.MenuItem65.Text = "New Work Area"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 9
        Me.MenuItem49.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem67, Me.MenuItem15, Me.MenuItem66, Me.MenuItem60, Me.MenuItem61, Me.MenuItem51, Me.MenuItem16, Me.MenuItem50})
        Me.MenuItem49.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.MenuItem49.Text = "&Help "
        '
        'MenuItem67
        '
        Me.MenuItem67.Index = 0
        Me.MenuItem67.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.MenuItem67.Tag = ""
        Me.MenuItem67.Text = "&Help"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 1
        Me.MenuItem15.Text = "-"
        '
        'MenuItem66
        '
        Me.MenuItem66.Index = 2
        Me.MenuItem66.Text = "Error Log"
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = 3
        Me.MenuItem60.Text = "Create Dump"
        '
        'MenuItem61
        '
        Me.MenuItem61.Index = 4
        Me.MenuItem61.Text = "Locate Dump"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 5
        Me.MenuItem51.Text = "Send us Email"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 6
        Me.MenuItem16.Text = "-"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 7
        Me.MenuItem50.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftA
        Me.MenuItem50.Text = "Go to Homepage"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 10
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem14})
        Me.MenuItem5.Text = "&About"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 0
        Me.MenuItem14.Text = "What is this Software?          "
        '
        'Timer1
        '
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\_projects\_mysysgitVS\Garam.chm"
        '
        'st1
        '
        Me.st1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.st1.Location = New System.Drawing.Point(0, 678)
        Me.st1.Name = "st1"
        Me.st1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.stchar, Me.stwrod, Me.stdate, Me.sttime, Me.StatusBarPanel1})
        Me.st1.ShowPanels = True
        Me.st1.Size = New System.Drawing.Size(1237, 22)
        Me.st1.TabIndex = 2
        Me.st1.Text = "Status:"
        '
        'stchar
        '
        Me.stchar.Name = "stchar"
        Me.stchar.Text = "StatusBarPanel1"
        Me.stchar.ToolTipText = "Total Characters in Text"
        '
        'stwrod
        '
        Me.stwrod.Name = "stwrod"
        Me.stwrod.Text = "StatusBarPanel2"
        Me.stwrod.ToolTipText = "Total words in Text"
        '
        'stdate
        '
        Me.stdate.Name = "stdate"
        Me.stdate.Text = "StatusBarPanel3"
        Me.stdate.ToolTipText = "Current Date :"
        '
        'sttime
        '
        Me.sttime.Name = "sttime"
        Me.sttime.Text = "StatusBarPanel4"
        Me.sttime.ToolTipText = "Current Time :"
        Me.sttime.Width = 140
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = "Application started. No action yet."
        Me.StatusBarPanel1.ToolTipText = "Last Activity"
        Me.StatusBarPanel1.Width = 400
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox1.Location = New System.Drawing.Point(767, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(295, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(1068, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 21)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Search the Web"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Visible = True
        '
        'EventsList
        '
        Me.EventsList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EventsList.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.EventsList.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventsList.ItemHeight = 14
        Me.EventsList.Location = New System.Drawing.Point(0, 490)
        Me.EventsList.Name = "EventsList"
        Me.EventsList.ScrollAlwaysVisible = True
        Me.EventsList.Size = New System.Drawing.Size(1237, 172)
        Me.EventsList.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.DropDownHeight = 200
        Me.ComboBox1.DropDownWidth = 300
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Items.AddRange(New Object() {"$!@.&`+'~=/,\<;0*$"":", "$1, $2...", "$DEBUG ", "$FILENAME ", "$LOAD_PATH ", "$stdin ", "$VERBOSE", "_tmp = expr0  if expr1 === _tmp || expr2 === _tmp stmt1 elsif expr3 === _tmp || e" & _
                "xpr4 === _tmp stmt2 else stmt3 end", "<% if false %><%end%>", "<%= link_to 'Edit', edit_article_path(@article) %> | <%= link_to 'Back', articles" & _
                "_path %>", "def expr `.' identifier [`(' [arg [`=' default]]...[`,' `*' arg ]`)']---expr... e" & _
                "nd", "def method_name [`(' [arg ['=' default]]...[`,' `*' arg ]`)']---expr...   end", "expr `&&' expr           expr `and' expr", "expr `..' expr                expr `...' expr", "expr `||' expr                expr or expr", "expr unless ---expr", "if expr [then]--- expr...  [elsif expr [then]---expr...]...[else---expr...]  end", "module identifier---expr..     end", "print <<""EOF""; ---mytext---EOF", "print <<""foo"", <<""bar""---metext---bar", "unless expr [then]--- expr...[else---expr...]   end"})
        Me.ComboBox1.Location = New System.Drawing.Point(215, 3)
        Me.ComboBox1.MaxDropDownItems = 100
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 8
        Me.ComboBox1.Text = "Ruby"
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox3.DropDownHeight = 200
        Me.ComboBox3.DropDownWidth = 400
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.IntegralHeight = False
        Me.ComboBox3.ItemHeight = 13
        Me.ComboBox3.Items.AddRange(New Object() {"'1' == 1 //true (same value)", "'1' === 1 // false  (not the same type)", "--variable   //Prefix Decrement", "// Form :  Single If if (condition) { // code that runs if the condition is true " & _
                "} ", "// This is a single line comment.", "{ ""property 1"": value1,  property2: value2,  number: value3}", "++variable   //Prefix Increment", "array[index]", "array[index][index]....", "console.log(""This code will be run"")//console.log(""Because this line is in a comm" & _
                "ent, this code will not be run."")", "console.time(timerName);", "console.timeEnd(timerName);", "do {   // Your code here  } while (condition);", "for ([var i = startValue];[i < endValue]; [i+=stepValue]) { // Your code here }", "function name(argument1 , argument2 .... argumentN){ statement1; statement2; stat" & _
                "ementN;}", "functionName(argument1, argument2, ..., argumentN);", "if ( true && false )alert(""Not executed!"");", "if (condition) { // statement1: code that runs if condition is true } else { // s" & _
                "tatement2: code that runs if condition is false }", "if (condition1) {  statement1;  } else if (condition2) {  statement2;  } else {  " & _
                "statement3;}", "if( !false )alert(""Executed!"");", "if( false || true )alert(""Executed!"");", "isNaN([value])", "Math.ceil(expression)", "Math.floor(expression) ", "Math.PI", "Math.sqrt(expression)", "name1[string]     name2.identifier", "number1 % number2", "string.charAt(index) // index is an integer between 0 and 1 less than the length " & _
                "of the string.", "string.indexOf(searchValue[, fromIndex]) //fromIndex is optional.It specifies fro" & _
                "m which index should the search start.Its default value is 0.", "string.substring(indexA[, indexB])  //indexA : An integer between 0 and the lengt" & _
                "h of the string // indexB : (optional) An integer between 0 and the length of th" & _
                "e string.", "switch (expression) { case label1: statements1 [break;] case label2:  statements2" & _
                " [break;]... statementsN  [break;] default:    statements_def    [break;]}", "true == 1 // true (because 1 stands for true ,though it's not the same type)", "true === 1 // false (not the same type)", "var arrayName = [element0, element1, ..., elementN]", "var multidimensionalArray = [[1,2,3],[4,5,6],[7,8,9]] // two dimensions, 3x3", "variable--   //Postfix Decrement", "variable++  //Postfix Increment", "while (condition) { // Your code here}", "x !== y // returns true if two things are not equal", "x < y // returns true if x is less than y", "x <= y // returns true if x is less than or equal to y", "x === y // returns true if two things are equal", "x > y // returns true if x is greater than y", "x >= y // returns true if x is greater than or equal to y"})
        Me.ComboBox3.Location = New System.Drawing.Point(109, 3)
        Me.ComboBox3.MaxDropDownItems = 100
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox3.Sorted = True
        Me.ComboBox3.TabIndex = 12
        Me.ComboBox3.Text = "JavaScript"
        '
        'ComboBox4
        '
        Me.ComboBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox4.DropDownHeight = 200
        Me.ComboBox4.DropDownWidth = 200
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.IntegralHeight = False
        Me.ComboBox4.ItemHeight = 13
        Me.ComboBox4.Items.AddRange(New Object() {"# This is also a single-line comment", "$color = ""mycolor"";", "$email = test_input($_POST[""email""]);     if (!filter_var($email, FILTER_VALIDATE" & _
                "_EMAIL)) { $emailErr = ""Invalid email format""; }", "$name = test_input($_POST[""name""]);    if (!preg_match(""/^[a-zA-Z ]*$/"",$name)) {" & _
                " $nameErr = ""Only letters and white space allowed""; }", "$website = test_input($_POST[""website""]);   if (!preg_match(""/\b(?:(?:https?|ftp)" & _
                ":\/\/|www\.)[-a-z0-9+&@#\/%?=~_|!:,.;]*[-a-z0-9+&@#\/%=~_|]/i"",$website))   $web" & _
                "siteErr = ""Invalid URL""; }", "$x - $y", "$x != $y", "$x % $y", "$x * $y", "$x ** $y", "$x / $y", "$x + $y", "$x == $y" & Global.Microsoft.VisualBasic.ChrW(9), "$x === $y", "/* This is a multiline comment*/", "// This is a single-line comment", "++$x", "<?php  // PHP code goes here  ?>", "do { code to be executed;     } while (condition is true);", "echo (""Hello world!""); ", "echo str_replace(""world"", ""Dolly"", ""Hello world!"");", "echo strlen(""Hello world!""); ", "echo strpos(""Hello world!"", ""world"");", "echo strrev(""Hello world!""); ", "switch (n) {  case label1:  code to be executed if n=label1; break;}", "while (condition is true) { code to be executed;}"})
        Me.ComboBox4.Location = New System.Drawing.Point(321, 3)
        Me.ComboBox4.MaxDropDownItems = 100
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox4.Sorted = True
        Me.ComboBox4.TabIndex = 11
        Me.ComboBox4.Text = "PHP5"
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.AutoCompleteCustomSource.AddRange(New String() {".dl-horizontal", ".initialism", ".lead", ".list-inline", ".mark", ".small", "@font-face", "@media", "<!--mycomment-->", "<!DOCTYPE> ", "<abbr></abbr>", "<address></address>", "<applet></applet>", "<article></article>", "<aside></aside>", "<blockquote></blockquote>", "<br>", "<button></button>", "<canvas></canvas>", "<caption></caption>", "<cite></cite>", "<colgroup></colgroup>", "<dd></dd>", "<details></details>", "<dialog></dialog>", "<dir></dir>", "<dl></dl>", "<dt></dt>", "<embed></embed>", "<fieldset></fieldset>", "<figcaption></figcaption>", "<footer></footer>", "<frame></frame>", "<frameset><frameset>", "<h></h>", "<h1></h1>", "<h2></h2>", "<h3></h3>", "<h4></h4>", "<h5></h5>", "<h6></h6>", "<header></header>", "<html lang=""en""></html>", "<html xmlns=""http://www.w3.org/1999/xhtml"" lang=""en"" xml:lang=""en""></html>", "<kbd></kbd>", "<keygen><keygen>", "<li></li>", "<main></main>", "<meta></meta>", "<object></object>", "<ol></ol>", "<p></p>", "<param></param>", "<section><section>", "<summary></summary>", "<table></table>", "<td></td>", "<textarea></textarea>", "<th></th>", "<thead></thead>", "<tr></tr>", "<ul></ul>", "<video></video>"})
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboBox2.DropDownHeight = 200
        Me.ComboBox2.DropDownWidth = 100
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.IntegralHeight = False
        Me.ComboBox2.ItemHeight = 13
        Me.ComboBox2.Items.AddRange(New Object() {".dl-horizontal", ".initialism", ".lead", ".list-inline", ".mark", ".small", "@font-face", "@media", "<!--mycomment-->", "<!DOCTYPE> ", "<abbr></abbr>", "<address></address>", "<applet></applet>", "<article></article>", "<aside></aside>", "<blockquote></blockquote>", "<br>", "<button></button>", "<canvas></canvas>", "<caption></caption>", "<cite></cite>", "<colgroup></colgroup>", "<dd></dd>", "<details></details>", "<dialog></dialog>", "<dir></dir>", "<dl></dl>", "<dt></dt>", "<embed></embed>", "<fieldset></fieldset>", "<figcaption></figcaption>", "<footer></footer>", "<frame></frame>", "<frameset><frameset>", "<h></h>", "<h1></h1>", "<h2></h2>", "<h3></h3>", "<h4></h4>", "<h5></h5>", "<h6></h6>", "<header></header>", "<html lang=""en""></html>", "<html xmlns=""http://www.w3.org/1999/xhtml"" lang=""en"" xml:lang=""en""></html>", "<kbd></kbd>", "<keygen><keygen>", "<li></li>", "<main></main>", "<meta></meta>", "<object></object>", "<ol></ol>", "<p></p>", "<param></param>", "<section><section>", "<summary></summary>", "<table></table>", "<td></td>", "<textarea></textarea>", "<th></th>", "<thead></thead>", "<tr></tr>", "<ul></ul>", "<video></video>"})
        Me.ComboBox2.Location = New System.Drawing.Point(427, 3)
        Me.ComboBox2.MaxDropDownItems = 100
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox2.Sorted = True
        Me.ComboBox2.TabIndex = 9
        Me.ComboBox2.Text = "HTML5/CSS3"
        '
        'ComboBox5
        '
        Me.ComboBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox5.DropDownHeight = 200
        Me.ComboBox5.DropDownWidth = 400
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.IntegralHeight = False
        Me.ComboBox5.ItemHeight = 13
        Me.ComboBox5.Items.AddRange(New Object() {"'''' Surround in-line unescaped scalar ('' escaped ')", "'""' Surround in-line escaped scalar (see escape codes below)", "---    Document header(Document indicators_)", "-    Nested series entry indicator", "-   Strip chomp modifier ('|-' or '>-')", "    '!!omap': [ one: 1, two: 2 ]", "    '!!set' : { cherries, plums, apples }", " !    Non-specific tag (by default, ""!!map""/""!!seq""/""!!str"")", " #    Throwaway comment indicator", " # Modifiers can be combined ('|2-', '>+1')", " ?   Key indicator", "!!foo   Secondary (by convention, means ""tag:yaml.org,2002:foo"")", "!!map               { Hash table, dictionary, mapping }", "!!seq                              { List, array, tuple, vector, sequence }", "!!str        Unicode string", "!<foo>  Verbatim tag (always means ""foo"")", "!foo   Primary (by convention, means a local ""!foo"" tag)", "!h!foo   Requires ""%TAG !h! <prefix>"" (and then means ""<prefix>foo"")", "%      Directive indicator(Document indicators_)", "&  Anchor property", "*    Alias indicator", ",    Separate in-line branch entries", "...     Document terminator(Document indicators_)", ":    Value indicator", "[]  Surround in-line series branch", "`@    Both reserved for future use", "{}  Surround in-line keyed branch", "|    Block scalar indicator", "+  Keep chomp modifier ('|+' or '>+')", "<<   Merge keys from another mapping", "=      Default ""value"" mapping key", ">  Folded scalar indicator", "1-9  Explicit indentation modifier ('|1' or '>2')", "none    Unspecified tag (automatically resolved by application)"})
        Me.ComboBox5.Location = New System.Drawing.Point(3, 3)
        Me.ComboBox5.MaxDropDownItems = 100
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox5.Sorted = True
        Me.ComboBox5.TabIndex = 13
        Me.ComboBox5.Text = "YAML"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox6)
        Me.Panel1.Controls.Add(Me.ComboBox5)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox4)
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Location = New System.Drawing.Point(10, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(751, 29)
        Me.Panel1.TabIndex = 14
        '
        'ComboBox6
        '
        Me.ComboBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox6.DropDownHeight = 400
        Me.ComboBox6.DropDownWidth = 400
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.IntegralHeight = False
        Me.ComboBox6.ItemHeight = 13
        Me.ComboBox6.Items.AddRange(New Object() {"CoffeeScript (JavaScript)", "is  " & Global.Microsoft.VisualBasic.ChrW(9) & "(===)", "isnt" & Global.Microsoft.VisualBasic.ChrW(9) & "(!==)", "not" & Global.Microsoft.VisualBasic.ChrW(9) & "(!)", "and" & Global.Microsoft.VisualBasic.ChrW(9) & "(&&)", "or" & Global.Microsoft.VisualBasic.ChrW(9) & "(||)", "true, yes, on" & Global.Microsoft.VisualBasic.ChrW(9) & "(true)", "false, no, off" & Global.Microsoft.VisualBasic.ChrW(9) & "(false)", "@, this" & Global.Microsoft.VisualBasic.ChrW(9) & "(this)", "of" & Global.Microsoft.VisualBasic.ChrW(9) & "(in)", "in" & Global.Microsoft.VisualBasic.ChrW(9) & "(no JS equivalent)", "a ** b" & Global.Microsoft.VisualBasic.ChrW(9) & "(Math.pow(a, b))", "a // b" & Global.Microsoft.VisualBasic.ChrW(9) & "(Math.floor(a / b))", "a %% b" & Global.Microsoft.VisualBasic.ChrW(9) & "((a % b + b) % b))"})
        Me.ComboBox6.Location = New System.Drawing.Point(533, 3)
        Me.ComboBox6.MaxDropDownItems = 100
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox6.TabIndex = 14
        Me.ComboBox6.Text = "CoffeeScript" & Global.Microsoft.VisualBasic.ChrW(9) & "JavaScript"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1237, 700)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.EventsList)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.st1)
        Me.Controls.Add(Me.txtClientArea)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.MinimumSize = New System.Drawing.Size(608, 322)
        Me.Name = "Form1"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Garam Editor"
        CType(Me.stchar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stwrod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sttime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Timer1.Enabled = True 'Timer1 for splashScreen started...
        Me.st1.Panels(0).Text = "Characters:" 'TextBox Characters in...
        Me.st1.Panels(1).Text = "Words:"
        Me.EventsList.Items.Add("Application initialized successfully")
        Me.EventsList.Items.Add("Ready to be Optimized...")
        Me.EventsList.Items.Add("====================== Welcome to Garam Editor =======================")
        Me.EventsList.Items.Add("Customize me: Use Format in Main Menu bar to set preferences")

    End Sub
    Function HasConnectivity() As Boolean
        Dim hostInfo As System.Net.IPHostEntry
        Try 'to look for the log-on server
            Dim sServer As String = Environment.GetEnvironmentVariable("logonserver")
            hostInfo = System.Net.Dns.GetHostEntry(sServer.Remove(0, 2))
            Return True
            MsgBox("True")
        Catch 'there is no network connection
            Return False
        End Try
    End Function


    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClientArea.TextChanged
        Me.st1.Panels(0).Text = Me.countC(Me.txtClientArea.Text) & "  Characters."
        Me.st1.Panels(1).Text = Me.countW(Me.txtClientArea.Text) & "  words."

    End Sub
    Public Function countC(ByVal text As String) As Integer
        intchar = text.Length
        Return intchar
    End Function
    Public Function countW(ByVal text As String) As Integer
        If Me.txtClientArea.Text = "" Then Return 0
        Dim chtword() As String = text.Split("".ToCharArray)
        Return chtword.Length
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'System Clock 
        Me.st1.Panels(2).Text = Now.ToString("HH:mm:ss" & " tt")
        Me.st1.Panels(3).Text = Now.Day & " - " & Now.ToString("MMMM") & " - " & Now.Year
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        'Close me
        Dim result As DialogResult
        result = MsgBox("Are you sure to Quit application !", MsgBoxStyle.Information, "Exit Message")
        If Windows.Forms.DialogResult.Yes Then
            Me.Close()
            'Application closed...
        End If
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Dim objdel As TextBox = Me.ActiveControl
        objdel.Clear()
        Me.StatusBarPanel1.Text = "Last Action: Delete"
        Me.EventsList.Items.Add("Action: Delete | Text deleted!")
    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        Me.txtClientArea.ForeColor = System.Drawing.Color.Red
        Me.StatusBarPanel1.Text = "Fore color is set to Red"
        Dim colorfix As DialogResult
        colorfix = MessageBox.Show("Did you find your color?", "Format Tip", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If colorfix = DialogResult.No Then
            colorfix = MessageBox.Show("Go to Format option in main Menu and Choose Foreground Color OR? Press on your keyboard 'Ctrl + Shift + C' ", "Format Tip", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        Me.txtClientArea.ForeColor = System.Drawing.Color.Blue
        Me.StatusBarPanel1.Text = "Fore color is set to Blue"
        Me.EventsList.Items.Add("Preferences: Back color is set to Blue")
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        Me.txtClientArea.ForeColor = System.Drawing.Color.Green
        Me.StatusBarPanel1.Text = "Fore color is set to Green"
        Me.EventsList.Items.Add("Preferences: Back color is set to Green")
    End Sub

    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        Me.txtClientArea.ForeColor = System.Drawing.Color.Yellow
        Me.StatusBarPanel1.Text = "Fore color is set to Yellow"
        Me.EventsList.Items.Add("Preferences: Back color is set to Yellow")
    End Sub
    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
        Me.txtClientArea.ForeColor = System.Drawing.Color.White
        Me.StatusBarPanel1.Text = "Fore color is set to White"
        Me.EventsList.Items.Add("Preferences: Back color is set to White")
    End Sub

    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        Me.txtClientArea.BackColor = System.Drawing.Color.Blue
        Me.StatusBarPanel1.Text = "Back color is set to Blue"
        Me.EventsList.Items.Add("Preferences: Back color is set to Blue")
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        Me.txtClientArea.BackColor = System.Drawing.Color.Black
        Me.StatusBarPanel1.Text = "Back color is set to Black"
        Me.EventsList.Items.Add("Preferences: Back color is set to Black")
    End Sub

    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        Me.txtClientArea.BackColor = System.Drawing.Color.Red
        Me.StatusBarPanel1.Text = "Back color is set to Red"
        Me.EventsList.Items.Add("Preferences: Back color is set to Red")
    End Sub

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        Me.txtClientArea.BackColor = System.Drawing.Color.Green
        Me.StatusBarPanel1.Text = "Back color is set to Green"
        Me.EventsList.Items.Add("Preferences: Back color is set to Green")
    End Sub

    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        Me.txtClientArea.BackColor = System.Drawing.Color.Yellow
        Me.StatusBarPanel1.Text = "Back color is set to Yellow"
        Me.EventsList.Items.Add("Preferences: Back color is set to Yellow")
    End Sub

    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click
        Me.txtClientArea.BackColor = System.Drawing.Color.Brown
        Me.StatusBarPanel1.Text = "Back color is set to Brown"
        Me.EventsList.Items.Add("Preferences: Back color is set to Brown")

    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        Me.txtClientArea.Text = Me.txtClientArea.Text.ToUpper()
        Me.StatusBarPanel1.Text = "Last Action: Upper case"
        Me.EventsList.Items.Add("Action: Lower case | All characters will appear in Uppercase")
    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        Me.txtClientArea.Text = Me.txtClientArea.Text.ToLower
        Me.StatusBarPanel1.Text = "Last Action: Lower case"
        Me.EventsList.Items.Add("Action: Lower case | All characters will appear in Lowercase")
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click

        Me.FontDialog1.ShowColor = True
        If Me.FontDialog1.ShowDialog = DialogResult.OK Then
            Me.txtClientArea.Font = Me.FontDialog1.Font
            Me.txtClientArea.ForeColor = Me.FontDialog1.Color
            Me.EventsList.Items.Add("Preferences: Font Dialog initialized | Text font color set")
        End If

    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click

        With Me.OpenFileDialog1
            .Filter = "Text files(*.txt)|*.txt|All Files(*.*)|*.*"
            .FilterIndex = 1
            .InitialDirectory = "C:|"
            .Title = "Open File"
        End With
        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            strFile = Me.OpenFileDialog1.FileName
            Dim objreader As StreamReader = New StreamReader(strFile)
            Me.txtClientArea.Text = objreader.ReadToEnd
            objreader.Close()
            objreader = Nothing
            Me.StatusBarPanel1.Text = "File opened."
            Me.EventsList.Items.Add("Action: File opened | OpenFile Dialog initialized...")
        End If
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Dim strfile As String = "mygaramproject"
        With Me.SaveFileDialog1
            .DefaultExt = "text"
            .FileName = strfile
            .Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*"
            .OverwritePrompt = True
            .Title = "Save File"
            '
            If Me.SaveFileDialog1.ShowDialog = DialogResult.OK Then
                strfile = Me.SaveFileDialog1.FileName
                Dim objwriter As StreamWriter = New StreamWriter(strfile)
                objwriter.Write(Me.txtClientArea.Text)
                objwriter.Close()
                objwriter = Nothing
                Me.StatusBarPanel1.Text = "File is Saved!"
                Me.EventsList.Items.Add("Action: File is Saved! | SaveFile Dialog initialized...")



            End If
        End With
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        If Me.txtClientArea.Text = "" Then
            Me.txtClientArea.Text = ""
        Else
            Dim strff As String
            Dim rt As DialogResult
            rt = MessageBox.Show("Please Save before Exit !", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If rt = DialogResult.OK Then
                If Me.SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                    strff = Me.SaveFileDialog1.FileName
                    Dim str As StreamWriter = New StreamWriter(strff)
                    str.Write(Me.txtClientArea.Text)
                    str.Close()
                    str = Nothing
                    Me.StatusBarPanel1.Text = "Save your work before Exit!"
                    Me.EventsList.Items.Add("Action: Save your work before Exit! | SaveFile Dialog initialized...")
                End If
            End If
        End If
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Dim sh As New frmauthor
        sh.ShowDialog()
        Me.StatusBarPanel1.Text = "Discover what is this Software"
        Me.EventsList.Items.Add("Action: Discover what is this Software | About this Software splashscreen initialized...")
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sh As New frmauthor
        sh.ShowDialog()
        Me.StatusBarPanel1.Text = "Show Author"
        Me.EventsList.Items.Add("Action: Show Author | Author splashscreen initialized...")
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        Dim objCut As TextBox = Me.ActiveControl
        objCut.Cut()
        Me.StatusBarPanel1.Text = "Last Action: Cut"
        Me.EventsList.Items.Add("Action: Cut | Text erased")
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        Dim objcop As TextBox = Me.ActiveControl
        objcop.Copy()
        Me.StatusBarPanel1.Text = "Last Action: Copy"
        Me.EventsList.Items.Add("Action: Copy | Text copied")
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        Dim objpas As TextBox = Me.ActiveControl
        objpas.Paste()
        Me.StatusBarPanel1.Text = "Last Action: Paste"
        Me.EventsList.Items.Add("Action: Paste | Copied Text pasted")
    End Sub

    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        Dim objundo As TextBox = Me.ActiveControl
        objundo.Undo()
        Me.StatusBarPanel1.Text = "Last Action: Undo"
        Me.EventsList.Items.Add("Caution: Undo Last action!")
    End Sub

    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click
        Me.txtClientArea.Clear()
        Me.StatusBarPanel1.Text = "Last Action: Reset All"
        Me.EventsList.Items.Add("Caution: Reset All | Working area cleared")
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Dim res As DialogResult
        res = MessageBox.Show("The application will now Exit! Click to confirm.", "Permission", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If res = DialogResult.Yes Then
            'e.Cancel = False
            If Me.txtClientArea.Text <> "" Then
                MsgBox("Please SAVE your work before Exit !", MsgBoxStyle.Critical, "Warning !")
                Call Me.MenuItem7_Click(Nothing, Nothing)
            Else
                e.Cancel = False
            End If
        Else
            e.Cancel = True
        End If
    End Sub


    Private Sub MenuItem47_Click(sender As Object, e As EventArgs) Handles MenuItem47.Click
        'See the Find and Repl
        frmFindandReplace.Visible = True
        frmFindandReplace.TextBoxSearch.Focus()
        Me.StatusBarPanel1.Text = "Finding..."
        Me.EventsList.Items.Add("Action: Find|Find and Replace DialogBox initialized... ")


    End Sub
    Private Sub MenuItem48_Click(sender As Object, e As EventArgs) Handles MenuItem48.Click
        frmFindandReplace.Visible = True
        frmFindandReplace.TextBoxReplace.Focus()
        Me.StatusBarPanel1.Text = "Replacing..."
        Me.EventsList.Items.Add("Action: Replace|Find and Replace DialogBox initialized... ")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("iexplore", "http://www.google.com/search?hl=en&q=" + TextBox1.Text + "&aq=f&oq=")
        Me.StatusBarPanel1.Text = "Searching the Web..."
        Me.EventsList.Items.Add("Action: Web Browser initialized. Searching the Web...")
    End Sub


    Private Sub MenuItem50_Click(sender As Object, e As EventArgs) Handles MenuItem50.Click
        Dim webAddress As String = "http://www.github.io/garameditor"
        Process.Start(webAddress)
        Me.StatusBarPanel1.Text = "Go to Homepage..."
        Me.EventsList.Items.Add("Action: Web Browser initialized. Homepage opened...")
    End Sub

    Private Sub MenuItem51_Click(sender As Object, e As EventArgs) Handles MenuItem51.Click
        'Dim Mail As New MailMessage

        ' Try
        'Mail.Subject = "I need Help!"
        'Mail.To.Add("youremail@gmail.com")
        'Mail.From = New MailAddress("youremail@gmail.com")
        'Mail.Body = "The problem I have encountered..."
        ' Dim SMTP As New SmtpClient("smtp.gmail.com")
        'SMTP.UseDefaultCredentials = False
        'SMTP.EnableSsl = True
        'SMTP.Credentials = New System.Net.NetworkCredential("gmailID", "password")
        'SMTP.Port = "465"
        ' SMTP.Send(Mail)
        'Catch exc As Exception
        'Return
        'MsgBox("Initializing Email failed!", MsgBoxStyle.Critical, "Critical Error")
        'End Try
        'Try
        'Dim SMTP As New SmtpClient("smtp.gmail.com")
        'SMTP.Send(Mail)
        ' MsgBox("Your Email has been sent successfully - Thank You")
        ' Catch exc As Exception
        'Return
        'MsgBox("Send failure: " & exc.ToString())
        'End Try

        'Apparently the above code does not work...
        Dim webAddress As String = "https://mail.google.com/mail/u/0/#inbox?compose=new"
        Process.Start(webAddress)
        Me.StatusBarPanel1.Text = "Email your problems..."
        Me.EventsList.Items.Add("Action: Send Email intialized...")
    End Sub

    Private Sub MenuItem52_Click(sender As Object, e As EventArgs) Handles MenuItem52.Click
        frmScreenshotCapture.Visible = True
        Me.StatusBarPanel1.Text = "Capturing Screenshot..."
        Me.EventsList.Items.Add("Action: Capturing Screenshot...")

    End Sub

    Private Sub MenuItem56_Click(sender As Object, e As EventArgs) Handles MenuItem56.Click
        txtClientArea.TextAlign = HorizontalAlignment.Center
        Me.StatusBarPanel1.Text = "Text Align center"
        Me.EventsList.Items.Add("Action: Text Align center")
    End Sub


    Private Sub MenuItem55_Click(sender As Object, e As EventArgs) Handles MenuItem55.Click
        txtClientArea.TextAlign = HorizontalAlignment.Left
        Me.StatusBarPanel1.Text = "Text Align Left"
        Me.EventsList.Items.Add("Action: Text Align Left")
    End Sub

    Private Sub MenuItem57_Click(sender As Object, e As EventArgs) Handles MenuItem57.Click
        txtClientArea.TextAlign = HorizontalAlignment.Right
        Me.StatusBarPanel1.Text = "Text Align Right"
        Me.EventsList.Items.Add("Action: Text Align Right")
    End Sub

    Private Sub MenuItem58_Click(sender As Object, e As EventArgs) Handles MenuItem58.Click
        ColorDialog1.ShowDialog()
        txtClientArea.ForeColor = ColorDialog1.Color
        Me.StatusBarPanel1.Text = "Preferences: Setting ForeColor..."
        Me.EventsList.Items.Add("Action: Setting Forecolor...")
    End Sub


    Private Sub MenuItem59_Click(sender As Object, e As EventArgs) Handles MenuItem59.Click
        ExplorerMyFiles.Visible = True
        Me.StatusBarPanel1.Text = "Project Explorer initialized..."
        Me.EventsList.Items.Add("Action: Project Explorer initialized...")


    End Sub

    Private Sub MenuItem60_Click(sender As Object, e As EventArgs) Handles MenuItem60.Click


        Try
            MsgBox("Create Dump File by choosing Processes Tab and Right Click 'GaramEditor.exe' and click on 'Create Dump File'", MessageBoxButtons.OK, "Instructions")

            Process.Start("taskmgr")
            Me.StatusBarPanel1.Text = "Creating Dump File..."
            Me.EventsList.Items.Add("Caution: Found Error | Action: Creating Dump File...")
        Catch exc As Exception
            MsgBox("No Dump File created. Try Again!")
            Me.StatusBarPanel1.Text = "No Dump File created"
            Me.EventsList.Items.Add("Error: No Dump File created. Try Again!")
        Finally

        End Try


    End Sub

    Private Sub MenuItem61_Click(sender As Object, e As EventArgs) Handles MenuItem61.Click
        Try
            Dim process As New Process()
            process.StartInfo.FileName = "cmd.exe "
            process.StartInfo.Verb = "runas"
            process.StartInfo.UseShellExecute = True
            process.Start()
            MsgBox("Run 'echo %LocalAppData%' then 'cd' to the result. Run 'dir /s /b /o:gn' and find specific crash dump for this application", MessageBoxButtons.OKCancel, "Instructions")
            Me.StatusBarPanel1.Text = "CMD initialized..."
            Me.EventsList.Items.Add("======================CMD initialized=======================")
        Catch exc As Exception
            MsgBox("Locating Crash Dump process canceled!", MsgBoxStyle.Exclamation, "Garam Editor")
        Finally
            Me.StatusBarPanel1.Text = "Locate Dump aborted!"
            Me.EventsList.Items.Add("Error: Locate Dump aborted!")
        End Try

    End Sub

    Private Sub MenuItem63_Click(sender As Object, e As EventArgs) Handles MenuItem63.Click
        txtClientArea.SelectAll()
        Me.StatusBarPanel1.Text = "Select All"
        Me.EventsList.Items.Add("Action: Select All | All Text selected")
    End Sub

    Private Sub MenuItem62_Click(sender As Object, e As EventArgs) Handles MenuItem62.Click
        Try
            MsgBox("In Processes List and look for 'GaramEditor.exe'. Right Click 'GaramEditor.exe' and from dropdown list select 'Set Priority'. Finally change priority to RealTime!  ", MessageBoxButtons.OK, "Optimize Garam Editor")

            Process.Start("taskmgr")
            Me.StatusBarPanel1.Text = "Optimizing..."
            Me.EventsList.Items.Add("======================Optimization initialized=======================")
        Catch exc As Exception
            MsgBox("No Optimization executed!", MsgBoxStyle.Exclamation, "Garam Editor")
            Me.StatusBarPanel1.Text = "No Optimization executed"
            Me.EventsList.Items.Add("Warning: Optimization canceled | Action: Nothing!")
        Finally

        End Try
    End Sub

    Private Sub MenuItem65_Click(sender As Object, e As EventArgs) Handles MenuItem65.Click
        'Garam workpad intialized
        frmRichAlternative.Visible = True
        Me.StatusBarPanel1.Text = "New Working Area initialized..."
        Me.EventsList.Items.Add("Action: New Working Area initialized...")

    End Sub

    Private Sub MenuItem67_Click(sender As Object, e As EventArgs) Handles MenuItem67.Click
        'Help button 
        MsgBox("For Help press keystroke F1! Make sure you are connected to the Internet.", MessageBoxButtons.OKCancel, "Help me?")
        Me.EventsList.Items.Add("===>  :(  You need Help...")
        Try
            If MsgBoxResult.Ok Then
                If My.Computer.Network.IsAvailable Then
                    MsgBox("Computer is connected.", MsgBoxStyle.Information)
                    Me.EventsList.Items.Add("Confirmation: Computer is connected to the Internet...")
                Else
                    MsgBox("Sorry your Computer is NOT connected.", MsgBoxStyle.MsgBoxHelp)
                    Me.EventsList.Items.Add("Caution: Computer NOT connected to the Internet!")
                End If
            Else
            End If
        Catch exc As Exception
        Finally
            System.Windows.Forms.Help.ShowHelp(Me, HelpProvider1.HelpNamespace, HelpNavigator.Topic, Me.HelpProvider1.GetHelpKeyword(Me))
            Me.StatusBarPanel1.Text = "Help F1"
        End Try
    End Sub

    Private Sub ComboBox2_Leave(sender As Object, e As EventArgs) Handles ComboBox2.Leave
        ComboBox2.Text = "HTML5/CSS3"
        'Upon leaving HTML5/CSS3 syntax List , selection to reset to original text
    End Sub

    Private Sub ComboBox2_LocationChanged(sender As Object, e As EventArgs) Handles ComboBox2.LocationChanged
        ComboBox2.Text = "HTML5/CSS3"
        'Mouse click change of location resets HTML5/CSS3 syntax list selection to original text
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        txtClientArea.Text = ComboBox2.SelectedItem
        'For any selected item in HTML5/CSS3 syntax list to print in Main TextBox

    End Sub

    Private Sub ComboBox4_Leave(sender As Object, e As EventArgs) Handles ComboBox4.Leave
        ComboBox4.Text = "PHP5"
        'Upon leaving PHP5 syntax List , selection to reset to original text
    End Sub

    Private Sub ComboBox4_LocationChanged(sender As Object, e As EventArgs) Handles ComboBox4.LocationChanged
        ComboBox4.Text = "PHP5"
        'Mouse click change of location resets PHP5 syntax list selection to original text
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        txtClientArea.Text = ComboBox4.SelectedItem
        'For any selected item in PHP5 syntax list to print in Main TextBox
    End Sub

    Private Sub ComboBox1_Leave(sender As Object, e As EventArgs) Handles ComboBox1.Leave
        ComboBox1.Text = "Ruby"
        'Upon leaving Ruby syntax List , selection to reset to original text
    End Sub

    Private Sub ComboBox1_LocationChanged(sender As Object, e As EventArgs) Handles ComboBox1.LocationChanged
        ComboBox1.Text = "Ruby"
        'Mouse click change of location resets Ruby syntax list selection to original text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        txtClientArea.Text = ComboBox1.SelectedItem
        'For any selected item in Ruby syntax list to print in Main TextBox
    End Sub

    Private Sub ComboBox3_Leave(sender As Object, e As EventArgs) Handles ComboBox3.Leave
        ComboBox3.Text = "JavaScript"
        'Upon leaving JavaScript syntax List , selection to reset to original text
    End Sub

    Private Sub ComboBox3_LocationChanged(sender As Object, e As EventArgs) Handles ComboBox3.LocationChanged
        ComboBox3.Text = "JavaScript"
        'Mouse click change of location resets JavaScript syntax list selection to original text
    End Sub


    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        txtClientArea.Text = ComboBox3.SelectedItem()
        'For any selected item in JavaScript syntax list to print in Main TextBox
    End Sub

    Private Sub ComboBox5_Leave(sender As Object, e As EventArgs) Handles ComboBox5.Leave
        ComboBox5.Text = "YAML"
        'Upon leaving YAML syntax List , selection to reset to original text
    End Sub

    Private Sub ComboBox5_LocationChanged(sender As Object, e As EventArgs) Handles ComboBox5.LocationChanged

        ComboBox5.Text = "YAML"
        'Mouse click change of location resets YAML syntax list selection to original text
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        txtClientArea.Text = ComboBox5.SelectedItem()
        'For any selected item in YAML syntax list to print in Main TextBox
    End Sub

    Private Sub ComboBox6_Leave(sender As Object, e As EventArgs) Handles ComboBox6.Leave
        ComboBox6.Text = "CoffeeScript"
        'Upon leaving CoffeeScript syntax List , selection to reset to original text
    End Sub

    Private Sub ComboBox6_LocationChanged(sender As Object, e As EventArgs) Handles ComboBox6.LocationChanged
        ComboBox6.Text = "CoffeeScript"
        'Mouse click change of location resets CoffeeScript syntax list selection to original text
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        txtClientArea.Text = ComboBox6.SelectedItem()
        'For any selected item in CoffeeScript syntax list to print in Main TextBox
    End Sub

    Private Sub MenuItem66_Click(sender As Object, e As EventArgs) Handles MenuItem66.Click
        frmEventsLog.Visible = True
      
    End Sub

End Class
