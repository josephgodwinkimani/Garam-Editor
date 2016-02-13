<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScreenshotCapture
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScreenshotCapture))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatus1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatus3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatus2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.ListEvents = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Goldenrod
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(52, 27)
        Me.Button1.Name = "Button1"
        Me.HelpProvider1.SetShowHelp(Me.Button1, True)
        Me.Button1.Size = New System.Drawing.Size(74, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(713, 27)
        Me.Button2.Name = "Button2"
        Me.HelpProvider1.SetShowHelp(Me.Button2, True)
        Me.Button2.Size = New System.Drawing.Size(189, 44)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Save Screenshot"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatus1, Me.ToolStripStatus3, Me.ToolStripStatus2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 717)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.HelpProvider1.SetShowHelp(Me.StatusStrip1, True)
        Me.StatusStrip1.Size = New System.Drawing.Size(1246, 24)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatus1
        '
        Me.ToolStripStatus1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatus1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.ToolStripStatus1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatus1.Name = "ToolStripStatus1"
        Me.ToolStripStatus1.Size = New System.Drawing.Size(26, 19)
        Me.ToolStripStatus1.Text = "Nil"
        '
        'ToolStripStatus3
        '
        Me.ToolStripStatus3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatus3.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.ToolStripStatus3.Name = "ToolStripStatus3"
        Me.ToolStripStatus3.Size = New System.Drawing.Size(38, 19)
        Me.ToolStripStatus3.Text = "Time"
        Me.ToolStripStatus3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripStatus3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ToolStripStatus2
        '
        Me.ToolStripStatus2.AutoSize = False
        Me.ToolStripStatus2.Name = "ToolStripStatus2"
        Me.ToolStripStatus2.Size = New System.Drawing.Size(121, 19)
        Me.ToolStripStatus2.Text = "Ready..."
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.TrackBar1.Cursor = System.Windows.Forms.Cursors.VSplit
        Me.TrackBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TrackBar1.Location = New System.Drawing.Point(150, 27)
        Me.TrackBar1.Name = "TrackBar1"
        Me.HelpProvider1.SetShowHelp(Me.TrackBar1, True)
        Me.TrackBar1.Size = New System.Drawing.Size(542, 45)
        Me.TrackBar1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(21, 96)
        Me.Panel1.Name = "Panel1"
        Me.HelpProvider1.SetShowHelp(Me.Panel1, True)
        Me.Panel1.Size = New System.Drawing.Size(800, 600)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.HelpProvider1.SetShowHelp(Me.PictureBox1, True)
        Me.PictureBox1.Size = New System.Drawing.Size(800, 600)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PrintDocument1
        '
        '
        'Button3
        '
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(20, 36)
        Me.Button3.Name = "Button3"
        Me.HelpProvider1.SetShowHelp(Me.Button3, True)
        Me.Button3.Size = New System.Drawing.Size(94, 45)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Print Image"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Location = New System.Drawing.Point(836, 96)
        Me.Panel2.Name = "Panel2"
        Me.HelpProvider1.SetShowHelp(Me.Panel2, True)
        Me.Panel2.Size = New System.Drawing.Size(132, 317)
        Me.Panel2.TabIndex = 7
        '
        'Button7
        '
        Me.Button7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button7.Location = New System.Drawing.Point(21, 246)
        Me.Button7.Name = "Button7"
        Me.HelpProvider1.SetShowHelp(Me.Button7, True)
        Me.Button7.Size = New System.Drawing.Size(94, 45)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "Flip Vertically"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button6.Location = New System.Drawing.Point(21, 164)
        Me.Button6.Name = "Button6"
        Me.HelpProvider1.SetShowHelp(Me.Button6, True)
        Me.Button6.Size = New System.Drawing.Size(94, 45)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Flip Horizontally"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button5.Location = New System.Drawing.Point(21, 89)
        Me.Button5.Name = "Button5"
        Me.HelpProvider1.SetShowHelp(Me.Button5, True)
        Me.Button5.Size = New System.Drawing.Size(94, 45)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Rotate Right"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button4.Location = New System.Drawing.Point(21, 20)
        Me.Button4.Name = "Button4"
        Me.HelpProvider1.SetShowHelp(Me.Button4, True)
        Me.Button4.Size = New System.Drawing.Size(94, 45)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Rotate Left"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.Button8)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Location = New System.Drawing.Point(837, 434)
        Me.Panel3.Name = "Panel3"
        Me.HelpProvider1.SetShowHelp(Me.Panel3, True)
        Me.Panel3.Size = New System.Drawing.Size(131, 262)
        Me.Panel3.TabIndex = 8
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.ForeColor = System.Drawing.Color.Red
        Me.Button8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button8.Location = New System.Drawing.Point(20, 151)
        Me.Button8.Name = "Button8"
        Me.HelpProvider1.SetShowHelp(Me.Button8, True)
        Me.Button8.Size = New System.Drawing.Size(94, 45)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Reset "
        Me.Button8.UseVisualStyleBackColor = False
        '
        'ListEvents
        '
        Me.ListEvents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListEvents.FormattingEnabled = True
        Me.ListEvents.HorizontalScrollbar = True
        Me.ListEvents.Location = New System.Drawing.Point(989, 95)
        Me.ListEvents.Name = "ListEvents"
        Me.ListEvents.ScrollAlwaysVisible = True
        Me.HelpProvider1.SetShowHelp(Me.ListEvents, True)
        Me.ListEvents.Size = New System.Drawing.Size(245, 602)
        Me.ListEvents.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Coral
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(986, 70)
        Me.Label1.Name = "Label1"
        Me.HelpProvider1.SetShowHelp(Me.Label1, True)
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "EventLog View:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmScreenshotCapture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1246, 741)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListEvents)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpKeyword(Me, "Screenshot")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Name = "frmScreenshotCapture"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Screenshot Capture"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatus1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatus2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatus3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents ListEvents As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
