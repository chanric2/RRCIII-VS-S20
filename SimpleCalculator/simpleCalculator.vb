'Richard Chandler III
'RCET0265
'Spring 2020
'Simple Calculator
'https://github.com/rosstimo/RRCIII-VS-S20

Option Strict On
Option Explicit On
Option Compare Text

Module simpleCalculator

    Sub Main()

        Dim firstNumber As Integer
        Dim firstOperation As Integer
        Dim secondNumber As Integer
        'Dim thirdNumber As Integer
        'Dim secondOperation As Integer
        'Dim fourthNumber As Integer
        Dim userQuit As Boolean
        Dim userReprompt As Boolean

        userReprompt = True
        userQuit = False

        'For Loop of entire code
        Do While userQuit = False
            'prompt user for first number, first operation, and second number for the first equation
            Console.WriteLine("Select an integer. Press ENTER when done.")
            Do While userReprompt = True
                Try
                    firstNumber = CInt(Console.ReadLine())
                    userReprompt = False
                Catch
                    userReprompt = True
                    Console.Clear()
                    Console.WriteLine("keep only integers. Input another Integer.")
                End Try
            Loop
            Console.WriteLine("Select a math operation by typing the number associated to it; 1.Add, 2.Subtract, 3.Multiply, 4.Divide. Press ENTER when done.")
                Try
                    firstOperation = CInt(Console.ReadLine())
                Catch
                    Console.Clear()
                    Console.WriteLine("keep only integers")

                End Try

                Console.WriteLine("Select an integer. Press ENTER when done.")
                Try
                    secondNumber = CInt(Console.ReadLine())
                Catch
                    Console.Clear()
                    Console.WriteLine("keep only integers")

                End Try

                'prompt user for third number, second operation, and fourth number for the second equation
                'Console.WriteLine("Select an integer. Press ENTER when done.")
                'thirdNumber = CInt(Console.ReadLine())
                'Console.WriteLine("Select a math operation by typing the number associated to it; 1.Add, 2.Subtract, 3.Multiply, 4.Divide. Press ENTER when done.")
                'secondOperation = CInt(Console.ReadLine())
                'Console.WriteLine("Select an integer. Press ENTER when done.")
                'fourthNumber = CInt(Console.ReadLine())

                'clear the user selected information from console before running the math and displaying the answer
                Console.Clear()

                'performs the first operation choosen by user with the integers choosen by users and displays the answer
                If firstOperation = 1 Then
                    Console.WriteLine(firstNumber & " + " & secondNumber & " = " & firstNumber + secondNumber)

                    'ElseIf firstOperation = 2 Then
                    'Console.WriteLine(firstNumber & " - " & secondNumber & " = " & firstNumber - secondNumber)

                ElseIf firstOperation = 3 Then
                    Console.WriteLine(firstNumber & " * " & secondNumber & " = " & firstNumber * secondNumber)

                    'ElseIf firstOperation = 4 Then
                    'Console.WriteLine(firstNumber & " / " & secondNumber & " = " & firstNumber / secondNumber)

                ElseIf firstOperation <> 1 Or firstOperation <> 2 Or firstOperation <> 3 Or firstOperation <> 4 Then
                    Console.WriteLine("Operation was INVALID. Please Try Again.")

                End If

                'performs the second operation choosen by user with the integers choosen by users and displays the answer
                'If secondOperation = 1 Then
                'Console.WriteLine(firstNumber & " + " & secondNumber & " = " & firstNumber + secondNumber)

                'ElseIf secondOperation = 2 Then
                'Console.WriteLine(firstNumber & " - " & secondNumber & " = " & firstNumber - secondNumber)

                'ElseIf secondOperation = 3 Then
                'Console.WriteLine(firstNumber & " * " & secondNumber & " = " & firstNumber * secondNumber)

                'ElseIf firstOperation = 4 Then
                'Console.WriteLine(firstNumber & " / " & secondNumber & " = " & firstNumber / secondNumber)

                'ElseIf secondOperation <> 1 Or secondOperation <> 2 Or secondOperation <> 3 Or secondOperation <> 4 Then
                'Console.WriteLine("Operation was INVALID. Please Try Again.")

                'End If
                Console.WriteLine("Press ENTER To Run Again. Press Q Then ENTER To Quit.")
                If Console.ReadLine() = "q" Then
                    userQuit = True
                    Console.Clear()
                Else
                    userQuit = False
                    Console.Clear()
                End If
            Loop
    End Sub

End Module
