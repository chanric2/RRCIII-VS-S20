'Richard Chandler III
'RCET0265
'Spring 2020
'Address Label Program
'https://github.com/rosstimo/RRCIII-VS-S20
Public Class AddressLabelForm
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        DisplayLabel.Text &= FirstNameTextBox.Text & " " & LastNameTextBox.Text & vbNewLine & StreetAddressTextBox.Text & vbNewLine & CityTextBox.Text & ", " & StateTextBox.Text & " " & ZipTextBox.Text
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayLabel.Text = ""
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
