Public Class frmfontdialog
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmfontdialog))
        Me.btnok = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(456, 24)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(80, 32)
        Me.btnok.TabIndex = 6
        Me.btnok.Text = "Ok"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(272, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = " Microsoft Visual Studio 2003   Using Dot  .net Fram Work"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(192, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Copy Right :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(272, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 32)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "This product is copy righted to end user"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 32)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Warning :"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(88, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(352, 48)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Misuse of the software will result in malfunctioning of the Software. so therefor" & _
        " the Company has the authority of disclaimer of it. All Rights Reserved :"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(192, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 32)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Envoirment  :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnok)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 197)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 72)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 192)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(192, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Author :"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(272, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Zaheer Ullah Khan "
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(272, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(224, 32)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "MSc Computer Science , University of Peshawar Peshawar"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Location = New System.Drawing.Point(280, 144)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(144, 16)
        Me.LinkLabel1.TabIndex = 18
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "zaheer_ullah34@yahoo.com"
        '
        'frmfontdialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(552, 269)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmfontdialog"
        Me.Text = "About PeshSoft notepad"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.yahoo.com")
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Me.Close()
    End Sub
End Class
