'Richard Chandler III
'RCET0265
'Spring 2020
'Simple Calculator
'https://github.com/rosstimo/RRCIII-VS-S20

Option Strict On
Option Explicit On

Module Module1

    Sub Main()

        Dim firstNumber As Integer
        Dim userOperation As Integer
        Dim secondNumber As Integer

        'prompt user for number, operation, and final number
        Console.WriteLine("Select an integer, 0-9. Press ENTER when done.")
        firstNumber = CInt(Console.ReadLine())
        Console.WriteLine("Select a math operation by typing the number associated to it; 1.Add, 2.Subtract, 3.Multiply, 4.Divide. Press ENTER when done.")
        userOperation = CInt(Console.ReadLine())
        Console.WriteLine("Select an integer, 0-9. Press ENTER when done.")
        secondNumber = CInt(Console.ReadLine())

        'select operator from user value
        If userOperation = 1 Then
            Console.WriteLine(firstNumber & "+" & secondNumber & "=" & firstNumber + secondNumber)

        ElseIf userOperation = 2 Then
            Console.WriteLine(firstNumber & "-" & secondNumber & "=" & firstNumber - secondNumber)

        ElseIf userOperation = 3 Then
            Console.WriteLine(firstNumber & "X" & secondNumber & "=" & firstNumber * secondNumber)

        ElseIf userOperation = 4 Then
            Console.WriteLine(firstNumber & "/" & secondNumber & "=" & firstNumber / secondNumber)

        ElseIf userOperation <> 1 Or userOperation <> 2 Or userOperation <> 3 Or userOperation <> 4 Then
            Console.WriteLine("Integer OR Operation was INVALID. Please Try Again.")

        End If

        Console.ReadLine()

    End Sub

End Module
