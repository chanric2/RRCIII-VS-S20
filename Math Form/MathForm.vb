Public Class MathForm
    Private Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click
        ' IsEmpty()
        Console.WriteLine(ValidateString(""))
    End Sub


    Sub IsEmpty()
        'check each text field for empty string and alert and sends user to exact textbox
        Dim userMessage As String

        ''A way to check the condition of the textbox
        'Select Case ""
        '    Case TextBox3.Text
        '        userMessage &= "Please Enter Text in Box 3" & vbNewLine
        '    Case TextBox2.Text
        '        userMessage &= "Please Enter Text in Box 2" & vbNewLine
        '    Case TextBox1.Text
        '        userMessage &= "Please Enter Text in Box 1" & vbNewLine
        '    Case Else

        'End Select

        If TextBox3.Text = "" Then
            userMessage &= "Please Enter Text in Box 3" & vbNewLine
            TextBox3.Select()
        End If

        If TextBox2.Text = "" Then
            userMessage &= "Please Enter Text in Box 2" & vbNewLine
            TextBox2.Select()
        End If

        If TextBox1.Text = "" Then
            userMessage &= "Please Enter Text in Box 1" & vbNewLine
            TextBox1.Select()
        End If

        If userMessage <> "" Then
            MsgBox(userMessage)
        End If

    End Sub

    Function ValidateString(stringToTest As String) As String
        Dim statusMeassage As String
        If stringToTest = "" Then
            statusMeassage = "Empty"
            TextBox1.Select()
        End If
        Return statusMeassage
    End Function

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
