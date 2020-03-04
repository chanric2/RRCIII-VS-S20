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
        'MathTest()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click, AddToolStripMenuItem.Click
        NameListBox.Items.Add(FirstTextBox.Text & " " & LastTextBox.Text)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click
        NameListBox.Items.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NameListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameListBox.SelectedIndexChanged
        Dim index As Integer

        Me.Text = NameListBox.SelectedIndex.ToString
        index = InStr(NameListBox.SelectedItem.ToString, " ")
        FirstTextBox.Text = Trim(Strings.Left(NameListBox.SelectedItem.ToString, index))
        LastTextBox.Text = Trim(Strings.Mid(NameListBox.SelectedItem.ToString, index, Len((NameListBox.SelectedItem.ToString))))

    End Sub

    'Private Sub MathTest()
    '    Dim number As Double

    '    number = 10 * Math.Sin(Math.PI)
    '    Console.WriteLine(Math.PI)
    'End Sub

End Class
