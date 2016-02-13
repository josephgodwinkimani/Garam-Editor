Public Class frmFindandReplace
    Dim txtClientArea As TextBox

    Private Sub frmFindandReplace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        TextBoxSearch.Focus()

    End Sub

    Private Sub replaceButton_Click(sender As Object, e As EventArgs) Handles replaceButton.Click
        Try
            Dim replacetext As String = txtClientArea.Text
            If txtClientArea.SelectedText.Length <= 0 Then


                Dim s As String = txtClientArea.SelectedText
                Dim nextPos As Integer

                nextPos = txtClientArea.Text.IndexOf(txtClientArea.SelectedText)

                While ((nextPos < txtClientArea.Text.Length) And (nextPos >= 0))

                    txtClientArea.SelectionStart = nextPos
                    txtClientArea.SelectionLength = s.Length
                    txtClientArea.Text = txtClientArea.Text.Replace(s, replacetext)
                    nextPos = txtClientArea.Text.IndexOf(s, nextPos + 1)

                End While

            End If
        Catch ex As Exception
            MessageBox.Show(String.Concat("An error occurred: ", ex.Message))
        End Try
    End Sub



    Private Sub findButton_Click(sender As Object, e As EventArgs) Handles findButton.Click

        Dim searchString As String
        Dim findPos As Integer

        Try
            searchString = TextBoxSearch.Text
            findPos = InStr(searchString, txtClientArea.Text)

            If findPos > 0 Then txtClientArea.Focus()
            txtClientArea.SelectionStart = findPos - 1
            txtClientArea.SelectionLength = searchString.Length
            txtClientArea.ScrollToCaret()

        Catch ex As Exception
            MessageBox.Show(String.Concat("An error occurred: ", ex.Message))
        End Try



    End Sub

End Class