Public Class MathForm
    Private Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click
        Console.WriteLine(sender.ToString)
        Console.WriteLine(e.ToString)

        '  Console.WriteLine(userMessage(TextBox1.Text, "please enter text in box 1", False))

        'Dim usermessage As String

        '' IsEmpty()
        'If IsStringEmpty(TextBox3.Text) = True Then
        '    usermessage &= "Please Enter Text in Box 3" & vbNewLine
        '    TextBox3.Select()
        'End If

        'If IsStringEmpty(TextBox2.Text) = True Then
        '    usermessage &= "Please Enter Text in Box 2" & vbNewLine
        '    TextBox2.Select()
        'End If

        'If IsStringEmpty(TextBox1.Text) = True Then
        '    usermessage &= "Please Enter Text in Box 1" & vbNewLine
        '    TextBox1.Select()
        'End If
        ''usermessage &= ValidateString(TextBox3.Text) & vbNewLine
        ''usermessage &= ValidateString(TextBox2.Text) & vbNewLine
        ''usermessage &= ValidateString(TextBox1.Text) & vbNewLine
        'If usermessage <> "" Then
        '    MsgBox(usermessage)
        'End If
        ''Console.WriteLine(ValidateString(""))
    End Sub

    Function userMessage(stringToTest As String, uniqueMessage As String, clearUserMessage As Boolean) As String
        Static runningMessage As String = ""
        If clearUserMessage = False Then
            runningMessage &= uniqueMessage & vbNewLine
        Else
            runningMessage = ""
        End If
        Return runningMessage
    End Function

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

    Function IsStringEmpty(stringToTest As String) As Boolean
        Dim status As Boolean

        If stringToTest = "" Then
            status = True
        Else
            status = False
        End If

        Return status
    End Function

    Function RunningTotal(currentValue As Integer, clearTotal As Boolean) As Integer
        'accumulate running total of argument with clear total option
        Static total As Integer
        If clearTotal = False Then
            total += currentValue
        Else
            total = 0
        End If
        Return total
    End Function

    Private Sub TotalButton_Click(sender As Object, e As EventArgs) Handles TotalButton.Click
        Dim tempnumber As Integer
        Const VALUE As Integer = 5
        tempnumber = RunningTotal(VALUE, False)
        Console.WriteLine(tempnumber)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        RunningTotal(0, True)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
