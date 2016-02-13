<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventsLog
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClearLogs = New System.Windows.Forms.Button()
        Me.btnReadLog = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.LogList = New System.Windows.Forms.RichTextBox()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.LogList)
        Me.SplitContainer1.Size = New System.Drawing.Size(613, 222)
        Me.SplitContainer1.SplitterDistance = 204
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClearLogs)
        Me.GroupBox1.Controls.Add(Me.btnReadLog)
        Me.GroupBox1.Controls.Add(Me.StatusStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 192)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "My Controls"
        '
        'btnClearLogs
        '
        Me.btnClearLogs.Location = New System.Drawing.Point(20, 109)
        Me.btnClearLogs.Name = "btnClearLogs"
        Me.btnClearLogs.Size = New System.Drawing.Size(126, 25)
        Me.btnClearLogs.TabIndex = 4
        Me.btnClearLogs.Text = "Clear Logs"
        Me.btnClearLogs.UseVisualStyleBackColor = True
        '
        'btnReadLog
        '
        Me.btnReadLog.Location = New System.Drawing.Point(20, 47)
        Me.btnReadLog.Name = "btnReadLog"
        Me.btnReadLog.Size = New System.Drawing.Size(126, 25)
        Me.btnReadLog.TabIndex = 1
        Me.btnReadLog.Text = "Read Log"
        Me.btnReadLog.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 167)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(175, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(120, 16)
        '
        'LogList
        '
        Me.LogList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogList.Dock = System.Windows.Forms.DockStyle.Right
        Me.LogList.Location = New System.Drawing.Point(3, 0)
        Me.LogList.Name = "LogList"
        Me.LogList.ReadOnly = True
        Me.LogList.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.LogList.Size = New System.Drawing.Size(402, 222)
        Me.LogList.TabIndex = 0
        Me.LogList.Text = ""
        '
        'frmEventsLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(613, 222)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmEventsLog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Events Log"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClearLogs As System.Windows.Forms.Button
    Friend WithEvents btnReadLog As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents LogList As System.Windows.Forms.RichTextBox
End Class
