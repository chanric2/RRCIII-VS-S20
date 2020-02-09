'Richard Chandler III
'RCET0265
'Spring 2020
'Better Calculator
'https://github.com/rosstimo/RRCIII-VS-S20

'Option Strict On
'Option Explicit On
Option Compare Text

Module BetterCalculator

    Sub Main()
        Dim numberOne As String
        Dim numberTwo As String
        Dim firstOperation As Integer
        Dim userQuit As String
        Dim userReprompt As Boolean
        Dim quit As Boolean

        userReprompt = True
        quit = False
        userQuit = "q"

        Console.WriteLine("Please enter two numbers. Enter 'Q' at any time to quit")

        Do While quit = False
            'choose first number
            Console.WriteLine("Choose a number:")
            Do While userReprompt = True
                Try
                    If numberOne = userQuit Then
                        quit = True
                    End If
                    numberOne = Console.ReadLine()
                    numberOne = CInt(numberOne)
                    Console.WriteLine("You entered " & Chr(34) & numberOne & Chr(34))
                    userReprompt = False
                Catch ex As Exception
                    userReprompt = True
                    '' Console.Clear()
                    Console.WriteLine("You entered " & Chr(34) & numberOne & Chr(34) & ", please enter a whole number.")
                End Try
            Loop

            quit = False
            userReprompt = True

            'choose second number
            Console.WriteLine("Choose a number:")
            Do While userReprompt = True
                Try
                    numberTwo = Console.ReadLine()
                    numberTwo = CInt(numberTwo)
                    Console.WriteLine("You entered " & Chr(34) & numberTwo & Chr(34))
                    userReprompt = False
                Catch ex As Exception
                    userReprompt = True
                    ''  Console.Clear()
                    Console.WriteLine("You entered " & Chr(34) & numberTwo & Chr(34) & ", please enter a whole number.")
                End Try
            Loop

            quit = False
            userReprompt = True

            Do While userReprompt = True
                'choose operation
                Console.WriteLine("Choose one of the following options: 1.Add, 2.Subtract, 3.Multiply, 4.Divide")
                Try
                    firstOperation = Console.ReadLine()
                    userReprompt = False
                Catch
                    userReprompt = True
                End Try

                'performs the first operation choosen by user with the integers choosen by users and displays the answer
                If firstOperation = 1 Then
                    Console.WriteLine(numberOne & " + " & numberTwo & " = " & CInt(numberOne) + CInt(numberTwo))

                ElseIf firstOperation = 2 Then
                    Console.WriteLine(numberOne & " - " & numberTwo & " = " & numberOne - numberTwo)

                ElseIf firstOperation = 3 Then
                    Console.WriteLine(numberOne & " * " & numberTwo & " = " & numberOne * numberTwo)

                ElseIf firstOperation = 4 Then
                    Console.WriteLine(numberOne & " / " & numberTwo & " = " & numberOne / numberTwo)

                ElseIf firstOperation <> 1 Or firstOperation <> 2 Or firstOperation <> 3 Or firstOperation <> 4 Then
                    Console.WriteLine("You entered " & Chr(34) & firstOperation & Chr(34))
                    userReprompt = True
                End If
            Loop
        Loop
        'Console.Clear()
        'Console.WriteLine("You entered """"Q""""")
        Console.WriteLine("Have a nice day! :)")
        Console.ReadLine()
    End Sub

End Module
