'Richard Chandler III
'RCET0265
'Spring 2020
'Math Contest
'https://github.com/chanric2/RRCIII-VS-S20
Option Strict On
Public Class MathContest
    Private Sub MathContest_Load(sender As Object, e As EventArgs) Handles Me.Load
        MsgBox("Student's name is Richard." & vbNewLine _
               & "Age is from 7 to 11 years old." & vbNewLine _
               & "Grade is from 1st to 4th.")
    End Sub
    Private Sub ChildSelectTextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged, AgeNumericUpDown.ValueChanged, GradeNumericUpDown.ValueChanged
        If NameTextBox.Text = "Richard" Then
            If AgeNumericUpDown.Value >= 7 And AgeNumericUpDown.Value <= 11 Then
                If GradeNumericUpDown.Value >= 1 And GradeNumericUpDown.Value <= 4 Then
                    'MsgBox("Welcome Richard")
                    StudentTextBox.Enabled = True
                    SubmitButton.Enabled = True
                    SummaryButton.Enabled = True
                    AddRadioButton.Enabled = True
                    SubRadioButton.Enabled = True
                    MultiRadioButton.Enabled = True
                    DivRadioButton.Enabled = True
                End If
            End If
        End If
    End Sub
    Private Sub RadioButtonChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged, SubRadioButton.CheckedChanged, MultiRadioButton.CheckedChanged, DivRadioButton.CheckedChanged
        If AddRadioButton.Checked Or SubRadioButton.Checked Or MultiRadioButton.Checked Or DivRadioButton.Checked Then
            Dim numberOne As Integer
            Dim numberTwo As Integer
            Randomize()
            numberOne = CInt((8 * Rnd()) + 1)
            numberTwo = CInt((8 * Rnd()) + 1)
            FirstNumberTextBox.Text = CStr(numberOne)
            SecondNumberTextBox.Text = CStr(numberTwo)
        End If
    End Sub
    Private Sub StudentTextBox_TextChanged(sender As Object, e As EventArgs) Handles StudentTextBox.TextChanged
        Dim answer As Integer
        'V Has issues with conversions and will check as the user writes, meaning if an answer is more then one value it will activate bad early.
        'will crash the code due to conversion types try to erase the entered number or decimal
        answer = CInt(StudentTextBox.Text)
        If AddRadioButton.Checked And answer = CInt(FirstNumberTextBox.Text) + CInt(SecondNumberTextBox.Text) Then
            MsgBox("Added")
        ElseIf SubRadioButton.Checked And answer = CInt(FirstNumberTextBox.Text) - CInt(SecondNumberTextBox.Text) Then
            MsgBox("Subtracted")
        ElseIf MultiRadioButton.Checked And answer = CInt(FirstNumberTextBox.Text) * CInt(SecondNumberTextBox.Text) Then
            MsgBox("Multiplied")
        ElseIf DivRadioButton.Checked And answer = CInt(FirstNumberTextBox.Text) / CInt(SecondNumberTextBox.Text) Then
            MsgBox("Divided")
        End If
    End Sub
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Text = ""
        'FirstNumberTextBox.Text = ""
        'SecondNumberTextBox.Text = ""
        'StudentTextBox.Text = CStr(0)
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
