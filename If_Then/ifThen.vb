'Richard Chandler III
'RCET0265
'Spring 2020
'If_Then
'https://github.com/chanric2/RRCIII-VS-S20

Module IfThen

    Sub Main()

        Dim firstNumber As Integer
        Dim secondNumber As Integer

        'This section of code below is to allow the user to type in the integer instead of set values
        Console.WriteLine("Select first number")
        firstNumber = Console.ReadLine()

        Console.WriteLine("Select second number")
        secondNumber = Console.ReadLine()

        'This selction of code below is to compare the values. Based on the first TRUE condition the code will end.
        If firstNumber > secondNumber Then
            Console.WriteLine("First number is bigger than the second.")
        ElseIf firstNumber < secondNumber Then
            Console.WriteLine("Second number is bigger than the first.")
        ElseIf firstNumber <= secondNumber Then
            Console.WriteLine("First number is less than or equal to the second.")
        ElseIf firstNumber >= secondNumber Then
            Console.WriteLine("First number is greater than or equal to the second.")
        ElseIf firstNumber <> secondNumber Then
            Console.WriteLine("not equal")
        Else
            Console.WriteLine("The numbers are equal.")
        End If
        Console.ReadLine()

    End Sub

End Module
