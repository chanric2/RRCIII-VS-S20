'Richard Chandler III
'RCET0265
'Spring 2020
'Accumulate Message Function
'https://github.com/rosstimo/RRCIII-VS-S20
Module AccumulateMessageFunction

    Sub Main()
        UserMessages(True, "", False)
    End Sub

    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String
        Dim formattedMessages As String
        addMessage = True
        message = "Hello"
        clearMessage = False

        'if add message is true then
        'write out message to user
        'else
        'clear message is true
        Console.WriteLine("Enter name")
        Console.WriteLine("Enter age")
        Console.ReadLine()


        Return formattedMessages
    End Function

End Module
