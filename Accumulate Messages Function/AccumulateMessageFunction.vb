Module AccumulateMessageFunction

    Sub Main()
        UserMessages(True, "hi", False)
    End Sub

    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String
        Dim formattedMessages As String
        addMessage = True
        message = "Hello"
        clearMessage = False

        Return formattedMessages
    End Function

End Module
