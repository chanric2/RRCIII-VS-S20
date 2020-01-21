'Richard Chandler III
'RCET0265
'Spring 2020
'More Operators
Option Strict On
Option Explicit On

Module MoreOperators

    Sub Main()
        'prompt user for message
        'display given message

        Dim userMessage As String

        userMessage = "Hello"

        Console.WriteLine("Please Enter A Message. Press Enter When Done")
        userMessage = Console.ReadLine()

        Console.WriteLine("You Entered " & Chr(34) & userMessage & Chr(34) & " You May Now Use This Device!")
        Console.ReadLine()

    End Sub

End Module
