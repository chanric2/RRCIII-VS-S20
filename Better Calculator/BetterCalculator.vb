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
        Dim userReprompt As Boolean

        userReprompt = True

        Console.WriteLine("Please enter two numbers. Enter 'Q' at any time to quit")

        'choose first number
        Console.WriteLine("Choose a number:")
        Do While userReprompt = True
            Try
                numberOne = Console.ReadLine()
                numberOne = CInt(numberOne)
                userReprompt = False
            Catch ex As Exception
                userReprompt = True
                Console.Clear()
                Console.WriteLine("You entered " & Chr(34) & numberOne & Chr(34) & ", please enter a whole number.")
            End Try
        Loop

        userReprompt = True

        'choose second number
        Console.WriteLine("Choose a number:")
        Do While userReprompt = True
            Try
                numberTwo = Console.ReadLine()
                numberTwo = CInt(numberTwo)
                userReprompt = False
            Catch ex As Exception
                userReprompt = False
                Console.Clear()
                Console.WriteLine("You entered " & Chr(34) & numberTwo & Chr(34) & ", please enter a whole number.")
            End Try
        Loop










        Console.ReadLine()
    End Sub

End Module
