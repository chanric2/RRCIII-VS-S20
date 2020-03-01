'Richard Chandler III
'RCET0265
'Spring 2020
'Accumulate Message Function
'https://github.com/rosstimo/RRCIII-VS-S20
Module AccumulateMessageFunction

    Sub Main()
        UserMessages(False, "hard coded message", False)
        UserMessages(True, "hard coded message1", True)
        UserMessages(True, "hard coded message2", False)
        MsgBox(UserMessages(True, "", False))
    End Sub

    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String
        Static formattedMessages As String = ""
        If clearMessage = False Then

            If addMessage = True Then
                formattedMessages &= message & vbNewLine
            End If
        Else
            formattedMessages &= ""
        End If

        Return formattedMessages
    End Function

End Module
