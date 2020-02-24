Public Class ListForm
    Private Sub ListBox1_Load(sender As Object, e As EventArgs) Handles Me.Load
        FirstTextBox.Text = "First Name"
        LastTextBox.Text = "Last Name"
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        NameListBox.Items.Add(FirstTextBox.Text & " " & LastTextBox.Text)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameListBox.Items.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub NameListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameListBox.SelectedIndexChanged
        Me.Text = NameListBox.SelectedIndex.ToString
        'TODO add selected to first name and last name text box
    End Sub
End Class
