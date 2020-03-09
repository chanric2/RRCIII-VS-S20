Module Module1

    Sub Main()

        Dim diceOne As Integer
        Randomize()
        diceOne = CInt((5 * Rnd()) + 1)
        Dim diceTwo As Integer
        Randomize()
        diceTwo = CInt((5 * Rnd()) + 1)

        Dim results(10) As Integer
        For Each roll As Integer In results
            If diceOne + diceTwo = 2 Then
                results(1) += 1
            End If
            If diceOne + diceTwo = 3 Then
                results(2) += 1
            End If
            If diceOne + diceTwo = 4 Then
                results(3) += 1
            End If
            If diceOne + diceTwo = 5 Then
                results(4) += 1
            End If
            If diceOne + diceTwo = 6 Then
                results(5) += 1
            End If
            If diceOne + diceTwo = 7 Then
                results(6) += 1
            End If
            If diceOne + diceTwo = 8 Then
                results(7) += 1
            End If
            If diceOne + diceTwo = 9 Then
                results(8) += 1
            End If
            If diceOne + diceTwo = 10 Then
                results(9) += 1
            End If
            If diceOne + diceTwo = 11 Then
                results(10) += 1
            End If
            If diceOne + diceTwo = 12 Then
                results(11) += 1
            End If
            Console.WriteLine(roll)
        Next
        Console.ReadLine()
    End Sub

End Module
