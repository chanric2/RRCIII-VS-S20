'Richard Chandler III
'RCET0265
'Spring 2020
'Better Calculator
'https://github.com/rosstimo/RRCIII-VS-S20

'Option Strict On
'Option Explicit On
'Option Compare Binary

Module BetterCalculator

    Sub Main()
        Dim numberOne As String
        Dim numberTwo As String

        Console.WriteLine("Please enter two numbers. Enter 'Q' at any time to quit")

        Console.WriteLine("Choose a number:")
        Try
            numberOne = CInt(Console.ReadLine())
        Catch ex As Exception
            Console.WriteLine("You entered " & Chr(34) & numberOne & Chr(34) & ", please enter a whole number.")
        End Try






        Console.WriteLine("Choose a number:")
        numberTwo = CInt(Console.ReadLine())








        Console.WriteLine(numberOne & numberTwo)
        Console.ReadLine()
    End Sub

End Module
