Module Module1

    Sub Main()

        Dim diceOne As Integer
        Dim diceTwo As Integer
        Dim sumDice As Integer
        Dim diceArray(12, 1) As Integer

        For roll = 1 To 1000
            diceOne = Int((6 * Rnd()) + 1)
            diceTwo = Int((6 * Rnd()) + 1)
            sumDice = diceOne + diceTwo

            If sumDice = 2 Then
                diceArray(2, 1) += 1
            ElseIf sumDice = 3 Then
                diceArray(3, 1) += 1
            ElseIf sumDice = 4 Then
                diceArray(4, 1) += 1
            ElseIf sumDice = 5 Then
                diceArray(5, 1) += 1
            ElseIf sumDice = 6 Then
                diceArray(6, 1) += 1
            ElseIf sumDice = 7 Then
                diceArray(7, 1) += 1
            ElseIf sumDice = 8 Then
                diceArray(8, 1) += 1
            ElseIf sumDice = 9 Then
                diceArray(9, 1) += 1
            ElseIf sumDice = 10 Then
                diceArray(10, 1) += 1
            ElseIf sumDice = 12 Then
                diceArray(11, 1) += 1
            ElseIf sumDice = 11 Then
                diceArray(12, 1) += 1
            End If
        Next

        diceArray(2, 0) = "2"
        diceArray(3, 0) = "3"
        diceArray(4, 0) = "4"
        diceArray(5, 0) = "5"
        diceArray(6, 0) = "6"
        diceArray(7, 0) = "7"
        diceArray(8, 0) = "8"
        diceArray(9, 0) = "9"
        diceArray(10, 0) = "10"
        diceArray(11, 0) = "11"
        diceArray(12, 0) = "12"

        Console.WriteLine("Dice Possibilities " & " Times Dice Rolled")
        Console.WriteLine(diceArray(2, 0) & "                     " & diceArray(2, 1))
        Console.WriteLine(diceArray(3, 0) & "                     " & diceArray(3, 1))
        Console.WriteLine(diceArray(4, 0) & "                     " & diceArray(4, 1))
        Console.WriteLine(diceArray(5, 0) & "                     " & diceArray(5, 1))
        Console.WriteLine(diceArray(6, 0) & "                     " & diceArray(6, 1))
        Console.WriteLine(diceArray(7, 0) & "                     " & diceArray(7, 1))
        Console.WriteLine(diceArray(8, 0) & "                     " & diceArray(8, 1))
        Console.WriteLine(diceArray(9, 0) & "                     " & diceArray(9, 1))
        Console.WriteLine(diceArray(10, 0) & "                    " & diceArray(10, 1))
        Console.WriteLine(diceArray(11, 0) & "                    " & diceArray(11, 1))
        Console.WriteLine(diceArray(12, 0) & "                    " & diceArray(12, 1))
        Console.ReadLine()
    End Sub

End Module
