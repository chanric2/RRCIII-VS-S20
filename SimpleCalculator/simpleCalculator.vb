'Richard Chandler III
'RCET0265
'Spring 2020
'Simple Calculator
'https://github.com/rosstimo/RRCIII-VS-S20

Option Strict On
Option Explicit On

'new comment bla bla
'test

Module simpleCalculator

    Sub Main()

        Dim firstNumber As Integer
        Dim firstOperation As Integer
        Dim secondNumber As Integer
        'Dim thirdNumber As Integer
        'Dim secondOperation As Integer
        'Dim fourthNumber As Integer

        'prompt user for first number, first operation, and second number for the first equation
        Console.WriteLine("Select an integer. Press ENTER when done.")
        firstNumber = CInt(Console.ReadLine())
        Console.WriteLine("Select a math operation by typing the number associated to it; 1.Add, 2.Subtract, 3.Multiply, 4.Divide. Press ENTER when done.")
        firstOperation = CInt(Console.ReadLine())
        Console.WriteLine("Select an integer. Press ENTER when done.")
        secondNumber = CInt(Console.ReadLine())

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

        Console.ReadLine()

    End Sub

End Module
