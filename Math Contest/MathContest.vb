'Richard Chandler III
'RCET0265
'Spring 2020
'Math Contest
'https://github.com/chanric2/RRCIII-VS-S20
Option Strict On
Public Class MathContest
    ReadOnly summaryArray(1) As Integer
    Dim score As Double
    Dim rightAnswer As Double
    Private Sub MathContest_Load(sender As Object, e As EventArgs) Handles Me.Load
        MsgBox("Student's name is Richard." & vbNewLine _
               & "Age is from 7 to 11 years old." & vbNewLine _
               & "Grade is from 1st to 4th.")
    End Sub
    Private Sub ChildSelectTextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged, AgeNumericUpDown.ValueChanged, GradeNumericUpDown.ValueChanged
        If NameTextBox.Text = "Richard" Then
            If AgeNumericUpDown.Value >= 7 And AgeNumericUpDown.Value <= 11 Then
                If GradeNumericUpDown.Value >= 1 And GradeNumericUpDown.Value <= 4 Then
                    NameTextBox.Enabled = False
                    AgeNumericUpDown.Enabled = False
                    GradeNumericUpDown.Enabled = False
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
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim answer As String
        Try
            answer = StudentTextBox.Text
            If AddRadioButton.Checked And CInt(answer) = CInt(FirstNumberTextBox.Text) + CInt(SecondNumberTextBox.Text) Then
                ValidateAnswer(correct:=True, incorrect:=False)
            ElseIf SubRadioButton.Checked And CInt(answer) = CInt(FirstNumberTextBox.Text) - CInt(SecondNumberTextBox.Text) Then
                ValidateAnswer(correct:=True, incorrect:=False)
            ElseIf MultiRadioButton.Checked And CInt(answer) = CInt(FirstNumberTextBox.Text) * CInt(SecondNumberTextBox.Text) Then
                ValidateAnswer(correct:=True, incorrect:=False)
            ElseIf DivRadioButton.Checked And CInt(answer) = CInt(FirstNumberTextBox.Text) / CInt(SecondNumberTextBox.Text) Then
                ValidateAnswer(correct:=True, incorrect:=False)
            Else
                'the first incorrect answer msgbox gives 0 then afterwards proceeds to return the correct value
                ValidateAnswer(correct:=False, incorrect:=True)
                If AddRadioButton.Checked And CInt(answer) <> CInt(FirstNumberTextBox.Text) + CInt(SecondNumberTextBox.Text) Then
                    rightAnswer = CDbl(FirstNumberTextBox.Text) + CDbl(SecondNumberTextBox.Text)
                ElseIf SubRadioButton.Checked And CInt(answer) <> CInt(FirstNumberTextBox.Text) - CInt(SecondNumberTextBox.Text) Then
                    rightAnswer = CDbl(FirstNumberTextBox.Text) - CDbl(SecondNumberTextBox.Text)
                ElseIf MultiRadioButton.Checked And CInt(answer) <> CInt(FirstNumberTextBox.Text) * CInt(SecondNumberTextBox.Text) Then
                    rightAnswer = CDbl(FirstNumberTextBox.Text) * CDbl(SecondNumberTextBox.Text)
                ElseIf DivRadioButton.Checked And CInt(answer) <> CInt(FirstNumberTextBox.Text) / CInt(SecondNumberTextBox.Text) Then
                    rightAnswer = CDbl(FirstNumberTextBox.Text) / CDbl(SecondNumberTextBox.Text)
                End If
            End If
        Catch
            MsgBox("Can Not Submit That Answer. Please Retry.")
        End Try
    End Sub
    Private Sub ValidateAnswer(correct As Boolean, incorrect As Boolean)
        If correct = True Then
            MsgBox("CORRECT! Good Job, Keep going!")
            summaryArray(0) += 1
        ElseIf incorrect = True Then
            MsgBox("INCORRECT! Good Try, Keep going!" & vbNewLine _
                   & "The Correct Answer is: " & CStr(rightAnswer))
            summaryArray(1) += 1
        End If
        score = (summaryArray(0) / (summaryArray(0) + summaryArray(1)) * 100)
    End Sub
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        MsgBox("Correct Answers Given: " & summaryArray(0) & " Incorrect Answers Given: " & summaryArray(1) & vbNewLine _
               & "Richard's Score " & CStr(score) & "%")
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        StudentTextBox.Text = ""
        summaryArray(1) = 0
        AddRadioButton.Checked = False
        SubRadioButton.Checked = False
        MultiRadioButton.Checked = False
        DivRadioButton.Checked = False
        AddRadioButton.Enabled = False
        SubRadioButton.Enabled = False
        MultiRadioButton.Enabled = False
        DivRadioButton.Enabled = False
        NameTextBox.Enabled = True
        AgeNumericUpDown.Enabled = True
        GradeNumericUpDown.Enabled = True
        StudentTextBox.Enabled = False
        SubmitButton.Enabled = False
        SummaryButton.Enabled = False
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
