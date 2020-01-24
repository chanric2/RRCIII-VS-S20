'Richard Chandler III
'RCET0265
'Spring 2020
'Say User Message
'https://github.com/chanric2/RRCIII-VS-S20

Module SayUserMessage

    Sub Main()

        Dim username As String

        Console.WriteLine("Hello, To Get Started Please Enter Your Name. Then Hit Enter.")
        username = Console.ReadLine()

        If username = "Emily" Then
            Console.WriteLine("Welcome Emily To Our Facility!")
        ElseIf username = "Joe" Then
            Console.WriteLine("Welcome Joe To Our Location!")
        ElseIf username <> "Emily" Then
            Console.WriteLine("You Do Not Have Access, Please Leave Now Or We Will Call The Police.")
        ElseIf username <> "Joe" Then
            Console.WriteLine("You Do Not Have Access, Please Leave Now Or We Will Call The Police.")
        End If

        Console.ReadLine()

    End Sub

End Module
