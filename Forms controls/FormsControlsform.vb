Public Class FormsControlsform
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim displayText As String

        displayText = NameTextBox1.Text & AddressTextBox2.Text & StateTextBox3.Text
        DisplayLabel.Text = displayText

    End Sub
End Class
