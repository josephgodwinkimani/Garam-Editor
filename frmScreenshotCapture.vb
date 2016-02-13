Imports System.IO
Imports Microsoft

Public Class frmScreenshotCapture

    Dim OriginalHeight As Int32
    Dim originalWidth As Int32
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        PictureBox1.Image = screenshot
        Me.ToolStripStatus2.Text = "Capture Taken"
        Me.ListEvents.Items.Add("Action:Capture Taken")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim savefiledialog1 As New SaveFileDialog
        savefiledialog1.Title = "Save File"
        savefiledialog1.FileName = "*.png"
        savefiledialog1.Filter = "PNG |*.png"
        If savefiledialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image.Save(savefiledialog1.FileName, System.Drawing.Imaging.ImageFormat.Png)
        End If
        Me.ToolStripStatus2.Text = "Saved Capture"
        Me.ListEvents.Items.Add("Action: Saved Capture")
    End Sub




    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatus2.Click
        Me.ToolStripStatus2.Name = ""
        Me.ToolStripStatus2.Text = "Screenshot Capture started. No action yet."
        Me.ToolStripStatus2.ToolTipText = "Last Activity"
        Me.ToolStripStatus2.Width = 100
    End Sub

    Private Sub frmScreenshotCapture_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        PictureBox1.Image = screenshot
        Me.ToolStripStatus2.Text = "Capture Taken Using Enter (Keystroke)"
        Me.ListEvents.Items.Add("Action: Capture Taken Using Enter (Keystroke)")
    End Sub

    Private Sub frmScreenshotCapture_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True
        'Panel Settings
        Panel1.AutoScroll = True
        'Picture Box Settings
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        Me.ToolStripStatus2.Text = "Ready..."
        Me.ListEvents.Items.Add("Screenshot Capture initiated successfully...")
        Me.ToolStripStatus3.ToolTipText = "Started: " & System.DateTime.Now.ToShortTimeString()
        Me.ToolStripStatus3.Text = System.DateTime.Today.ToLongDateString()
        Dim xf As DialogResult
        xf = MessageBox.Show("Capture your Desktop. Default resolution is set to your Computer Display Resolution. Click OK to continue. ", "Welcome to Screenshot Capture", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If xf = DialogResult.Cancel Then
            Me.Close()
        End If


    End Sub

    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged

        Dim OriginalHeight As Int32
        Dim originalWidth As Int32
        OriginalHeight = Me.PictureBox1.Height
        originalWidth = Me.PictureBox1.Width

        Dim NewWidth As Integer = originalWidth + TrackBar1.Value * 20
        Dim s As New Size(NewWidth, NewWidth * OriginalHeight / originalWidth)
        PictureBox1.Size = s
        PictureBox1.Refresh()
        ToolStripStatus1.Text = TrackBar1.Value
        Dim betafix As DialogResult
        betafix = MessageBox.Show("Picture-box can be re-sized only before loading the image, there after it is read only and has no effect !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        If betafix = DialogResult.Cancel Then
            Me.Close()
        End If
        PictureBox1.Image = Nothing
        PictureBox1.BackColor = Color.Empty
        PictureBox1.Invalidate()
        Me.ToolStripStatus2.Text = "Zoom In & Out"
        Me.ListEvents.Items.Add("Action: Zoom In & Out")
    End Sub







    'Pan Image

    Private m_PanStartPoint As New Point

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs)
        m_PanStartPoint = New Point(e.X, e.Y)
        Me.ToolStripStatus2.Text = "Pan on Mouse Down"
        Me.ListEvents.Items.Add("Action: Pan on Mouse Down")
    End Sub



    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs)
        'Verify Left Button is pressed while the mouse is moving
        If e.Button = Windows.Forms.MouseButtons.Left Then

            'Here we get the change in coordinates.
            Dim DeltaX As Integer = (m_PanStartPoint.X - e.X)
            Dim DeltaY As Integer = (m_PanStartPoint.Y - e.Y)

            'Then we set the new autoscroll position.
            'ALWAYS pass positive integers to the panels autoScrollPosition method
            Panel1.AutoScrollPosition = _
            New Drawing.Point((DeltaX - Panel1.AutoScrollPosition.X), _
                            (DeltaY - Panel1.AutoScrollPosition.Y))
        End If
        Me.ToolStripStatus2.Text = "Pan on Mouse Move"
        Me.ListEvents.Items.Add("Action: Pan on Mouse Move")
    End Sub

    'This prints to the default printer and the image is printed in the top left corner at its native size

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(PictureBox1.Image, e.MarginBounds.Left, e.MarginBounds.Top)
    End Sub
    'Prints the document
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            PrintDocument1.Print()
            Me.ToolStripStatus2.Text = "Printing..."
            Me.ListEvents.Items.Add("Printing Picture...")
        Catch ex As Exception
            MessageBox.Show("No Capture or Image in PictureBox Area. Please Try Again!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ListEvents.Items.Add("Fatal Error: Cannot Print. No Capture or Image in PictureBox Area!")
            Me.ToolStripStatus2.Text = "No Capture or Image in PictureBox Area"

        Finally


        End Try
    End Sub
    'RotateFlip Image using buttons
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Calls RotateFlip method of class Image
        Try
            PictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
            PictureBox1.Invalidate()
            Dim tmp As Integer
            tmp = PictureBox1.Width
            PictureBox1.Width = PictureBox1.Height
            PictureBox1.Height = tmp
            Me.ToolStripStatus2.Text = "Picture Rotated Left"
            Me.ListEvents.Items.Add("Action: Picture Rotated Left")
        Catch ex As Exception
            MessageBox.Show("No Capture or Image in PictureBox Area. Please Try Again!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ListEvents.Items.Add("Fatal Error:Cannot RotateFlip Left. No Capture or Image in PictureBox Area!")
            Me.ToolStripStatus2.Text = "No Capture or Image in PictureBox Area"
            
        Finally


        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            'Calls RotateFlip method of class Image
            PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            'Forces to repaint image
            PictureBox1.Invalidate()
            'Swaps width * Height
            Dim tmp As Integer
            tmp = PictureBox1.Width
            PictureBox1.Width = PictureBox1.Height
            PictureBox1.Height = tmp
            Me.ToolStripStatus2.Text = "Picture Rotated Right"
            Me.ListEvents.Items.Add("Action: Picture Rotated Right")
        Catch ex As Exception
            MessageBox.Show("No Capture or Image in PictureBox Area. Please Try Again!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ToolStripStatus2.Text = "No Capture or Image in PictureBox Area"
            Me.ListEvents.Items.Add("Fatal Error:Cannot RotateFlip Right. No Capture or Image in PictureBox Area!")

        Finally


        End Try
    End Sub
    'Flip tool do not need to change dimensions of Image
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
            PictureBox1.Invalidate()
            Me.ToolStripStatus2.Text = "Picture Flipped Horizontally"
            Me.ListEvents.Items.Add("Action: Picture Flipped Horizontally")
        Catch ex As Exception
            MessageBox.Show("No Capture or Image in PictureBox Area. Please Try Again!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ToolStripStatus2.Text = "No Capture or Image in PictureBox Area"
            Me.ListEvents.Items.Add("Fatal Error:Cannot RotateFlip Horizontally. No Capture or Image in PictureBox Area!")

        Finally


        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
            PictureBox1.Invalidate()
            Me.ToolStripStatus2.Text = "Picture Flipped Vertically"
            Me.ListEvents.Items.Add("Action: Picture Flipped Vertically")
        Catch ex As Exception
            MessageBox.Show("No Capture or Image in PictureBox Area. Please Try Again!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ToolStripStatus2.Text = "No Capture or Image in PictureBox Area"
            Me.ListEvents.Items.Add("Fatal Error:Cannot RotateFlip Vertically. No Capture or Image in PictureBox Area!")

        Finally


        End Try
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PictureBox1.Image = Nothing
        PictureBox1.BackColor = Color.Empty
        PictureBox1.Invalidate()
        Me.ToolStripStatus2.Text = "Picture Area reset"
        Me.ListEvents.Items.Add("Caution: Reset Picture Area!")
    End Sub







    
    
End Class