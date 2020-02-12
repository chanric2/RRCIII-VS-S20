Public Class MathForm
    Private Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click
        IsEmpty()
    End Sub


    Sub IsEmpty()
        Dim userMessage As String
        If TextBox1.Text = "" Then
            userMessage = "Please Enter Text in Box 1" 'MsgBox("Please Enter Text in Box 1")
            ''if user leaves blank this will select the textbox to immedately start to retry
            TextBox1.Select()
        End If

        If TextBox2.Text = "" Then
            userMessage = "Please Enter Text in Box 2" 'MsgBox("Please Enter Text in Box 2")
            TextBox2.Select()
        End If
        'MsgBox(userMessage)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
