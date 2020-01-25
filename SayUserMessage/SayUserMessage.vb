'Richard Chandler III
'RCET0265
'Spring 2020
'Say User Message
'https://github.com/chanric2/RRCIII-VS-S20

'option compare binary is default and compare all characters in ASCII if they do not match it fails
'option compare text will set the ASCII J = j Character by character so case wont matter
Option Compare Text

Module SayUserMessage

    Sub Main()

        Dim username As String

        Console.WriteLine("Hello, To Get Started Please Enter Your Username. Then Hit Enter.")
        username = Console.ReadLine()

        If username = "Emily" Or username = "Joe" Then
            Console.WriteLine("Welcome " & username & " To Our Facility!")
        ElseIf username <> "Emily" Or username <> "Joe" Then
            Console.WriteLine("You Do Not Have Access, Please Leave Now Or We Will Call The Police.")
        End If

        Console.ReadLine()

    End Sub

End Module
