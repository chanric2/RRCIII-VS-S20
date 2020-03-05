'Richard Chandler III
'RCET0265
'Spring 2020
'Math Contest
'https://github.com/rosstimo/RRCIII-VS-S20
Public Class MathContest
    Private Sub ChildSelectTextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged, AgeTextBox.TextChanged, GradeTextBox.TextChanged
        If NameTextBox.Text = "Richard" Then
            If AgeTextBox.Text = "7" Then
                If GradeTextBox.Text = "1" Then
                    MsgBox("Welcome Richard")
                    StudentTextBox.Enabled = True
                    SubmitButton.Enabled = True
                    SummaryButton.Enabled = True
                    AddRadioButton.Enabled = True
                    SubRadioButton.Enabled = True
                    MultiRadioButton.Enabled = True
                    DivRadioButton.Enabled = True
                End If
                'Else
                'Dim tempNumber As Integer
                'Try
                '    tempNumber = CInt(AgeTextBox.Text)
                '    If tempNumber > 11 And tempNumber < 7 Then
                '        MsgBox("you are not eligable")
                '    Else
                '        MsgBox("Welcome")
                '    End If
                'Catch ex As Exception
                '    MsgBox("not valid")
                '    AgeTextBox.Text = ""
                'End Try
            End If
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""
        AddRadioButton.Checked = False
        SubRadioButton.Checked = False
        MultiRadioButton.Checked = False
        DivRadioButton.Checked = False
        AddRadioButton.Enabled = False
        SubRadioButton.Enabled = False
        MultiRadioButton.Enabled = False
        DivRadioButton.Enabled = False
        StudentTextBox.Enabled = False
        SubmitButton.Enabled = False
        SummaryButton.Enabled = False
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
