'Richard Chandler III
'RCET0265
'Spring 2020
'List Form
'https://github.com/rosstimo/RRCIII-VS-S20

Option Strict On
Option Compare Text
Option Explicit On
Public Class ListForm
    Private Sub ListBox1_Load(sender As Object, e As EventArgs) Handles Me.Load
        FirstTextBox.Text = ""
        LastTextBox.Text = ""
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
        Dim index As Integer

        Me.Text = NameListBox.SelectedIndex.ToString
        index = InStr(NameListBox.SelectedItem.ToString, " ")
        FirstTextBox.Text = Trim(Strings.Left(NameListBox.SelectedItem.ToString, index))
        LastTextBox.Text = Trim(Strings.Mid(NameListBox.SelectedItem.ToString, index, Len((NameListBox.SelectedItem.ToString))))

    End Sub
End Class
