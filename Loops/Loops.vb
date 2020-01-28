'Richard Chandler III
'RCET0265
'Spring 2020
'loops
'https://github.com/rosstimo/RRCIII-VS-S20

Option Explicit On
Option Strict On

Module Loops

    Sub Main()

        Dim firstnumber As Integer
        Dim secondnumber As Integer
        Dim resultant As Integer

        firstnumber = 5
        secondnumber = 7

        resultant = firstnumber + secondnumber

        'i is the loopcount
        'loopcounter is loopcount
        'loopcounter is loopcount
        'i AS Integer is loopcount
        For i = 0 To 250 Step 2
            resultant = resultant + 1
            Console.WriteLine("i " & i)
        Next

        Console.Write("result " & resultant)

        Console.ReadLine()

    End Sub

End Module
