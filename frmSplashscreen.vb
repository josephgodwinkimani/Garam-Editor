Public Class frmSplashscreen

    Private Sub frmSplashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Update()
        Me.ValidateChildren()
        Timer1.Start()

        Timer1.Interval = 5000

    End Sub

   
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim x As Integer
        x += 1

        If x = 10 Then 'SinkPad action made after 10seconds'

            Me.Show()

            Me.Hide()

        End If

    End Sub
End Class