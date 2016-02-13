<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindandReplace
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.findButton = New System.Windows.Forms.Button()
        Me.replaceButton = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.TextBoxReplace = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Find what:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Replace with:"
        '
        'findButton
        '
        Me.findButton.Location = New System.Drawing.Point(12, 117)
        Me.findButton.Name = "findButton"
        Me.findButton.Size = New System.Drawing.Size(132, 34)
        Me.findButton.TabIndex = 2
        Me.findButton.Text = "Find"
        Me.findButton.UseVisualStyleBackColor = True
        '
        'replaceButton
        '
        Me.replaceButton.Location = New System.Drawing.Point(193, 117)
        Me.replaceButton.Name = "replaceButton"
        Me.replaceButton.Size = New System.Drawing.Size(132, 34)
        Me.replaceButton.TabIndex = 3
        Me.replaceButton.Text = "Replace"
        Me.replaceButton.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxSearch.Location = New System.Drawing.Point(100, 10)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(241, 20)
        Me.TextBoxSearch.TabIndex = 4
        '
        'TextBoxReplace
        '
        Me.TextBoxReplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxReplace.Location = New System.Drawing.Point(100, 56)
        Me.TextBoxReplace.Name = "TextBoxReplace"
        Me.TextBoxReplace.Size = New System.Drawing.Size(240, 20)
        Me.TextBoxReplace.TabIndex = 5
        '
        'frmFindandReplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 179)
        Me.Controls.Add(Me.TextBoxReplace)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.replaceButton)
        Me.Controls.Add(Me.findButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmFindandReplace"
        Me.Text = "Find and Replace"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents findButton As System.Windows.Forms.Button
    Friend WithEvents replaceButton As System.Windows.Forms.Button
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxReplace As System.Windows.Forms.TextBox
End Class
