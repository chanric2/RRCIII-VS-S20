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
        Console.WriteLine("Select an integer. Press ENTER when done.")
        firstNumber = CInt(Console.ReadLine())
        Console.WriteLine("Select a math operation by typing the number associated to it; 1.Add, 2.Subtract, 3.Multiply, 4.Divide. Press ENTER when done.")
        userOperation = CInt(Console.ReadLine())
        Console.WriteLine("Select an integer. Press ENTER when done.")
        secondNumber = CInt(Console.ReadLine())

        'clear the user selected information from console before running the math and displaying the answer
        Console.Clear()

        'performs the operation choosen by user with the integers choosen by users and displays the answer
        If userOperation = 1 Then
            Console.WriteLine(firstNumber & " + " & secondNumber & " = " & firstNumber + secondNumber)

        ElseIf userOperation = 2 Then
            Console.WriteLine(firstNumber & " - " & secondNumber & " = " & firstNumber - secondNumber)

        ElseIf userOperation = 3 Then
            Console.WriteLine(firstNumber & " * " & secondNumber & " = " & firstNumber * secondNumber)

        ElseIf userOperation = 4 Then
            Console.WriteLine(firstNumber & " / " & secondNumber & " = " & firstNumber / secondNumber)

        ElseIf userOperation <> 1 Or userOperation <> 2 Or userOperation <> 3 Or userOperation <> 4 Then
            Console.WriteLine("Operation was INVALID. Please Try Again.")

        End If

        Console.ReadLine()

    End Sub

End Module
