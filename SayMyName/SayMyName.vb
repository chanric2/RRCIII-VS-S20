'Richard Chandler III
'RCET0265
'Spring 2020
'Say My Name
'https://github.com/chanric2/TJR-VS-S20

Module SayMyName

    Sub Main()

        Dim userMessage As String

        userMessage = "Name"

        Console.WriteLine("Please Enter Your Name. Press Enter When Done")
        userMessage = Console.ReadLine()

        Console.WriteLine("Hello " & Chr(34) & userMessage & Chr(34) & " You May Now Use This Device!")
        Console.ReadLine()

    End Sub

End Module
