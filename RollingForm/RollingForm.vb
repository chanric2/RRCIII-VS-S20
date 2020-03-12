'Richard Chandler III
'RCET0265
'Spring 2020
'Rolling Form
'https://github.com/chanric2/RRCIII-VS-S20

Public Class RollingForm
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        Dim diceOne As Integer
        Dim diceTwo As Integer
        Dim sumDice As Integer
        Dim array(1, 12) As Integer
        Dim header As String
        Dim count As String

        For roll = 1 To 1000
            diceOne = Int((6 * Rnd()) + 1)
            diceTwo = Int((6 * Rnd()) + 1)
            sumDice = diceOne + diceTwo
            If sumDice = 2 Then
                array(1, 2) += 1
            ElseIf sumDice = 3 Then
                array(1, 3) += 1
            ElseIf sumDice = 4 Then
                array(1, 4) += 1
            ElseIf sumDice = 5 Then
                array(1, 5) += 1
            ElseIf sumDice = 6 Then
                array(1, 6) += 1
            ElseIf sumDice = 7 Then
                array(1, 7) += 1
            ElseIf sumDice = 8 Then
                array(1, 8) += 1
            ElseIf sumDice = 9 Then
                array(1, 9) += 1
            ElseIf sumDice = 10 Then
                array(1, 10) += 1
            ElseIf sumDice = 11 Then
                array(1, 11) += 1
            ElseIf sumDice = 12 Then
                array(1, 12) += 1
            End If
        Next
        header = "2   |  3   |  4   |  5   |   6   |  7   |   8   |  9   | 10 | 11 | 12 |"
        count = array(1, 2) & " |  " & array(1, 3) & " |  " & array(1, 4) & " |" & array(1, 5) & " | " & array(1, 6) & " |" & array(1, 7) & " | " & array(1, 8) & " |" & array(1, 9) & " | " & array(1, 10) & " | " & array(1, 11) & " | " & array(1, 12) & " |"
        ResListBox.Items.Add(header)
        ResListBox.Items.Add(count)
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ResListBox.Items.Clear()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
