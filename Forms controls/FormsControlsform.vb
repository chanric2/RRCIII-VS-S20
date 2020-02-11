Public Class FormsControlsform
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim displayText As String

        displayText = NameTextBox1.Text & vbNewLine & AddressTextBox2.Text & vbNewLine & StateTextBox3.Text

        DisplayLabel.Text = displayText

    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        RadioButton4.Checked = True
        If CheckBox1.Checked = True Then
            DisplayLabel.Text = NameTextBox1.Text
        End If
    End Sub

    Private Sub FormsControlsform_Load(sender As Object, e As EventArgs) Handles Me.Load
        RadioButton4.Checked = True
    End Sub
End Class
