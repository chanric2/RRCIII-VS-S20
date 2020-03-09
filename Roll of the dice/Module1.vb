Module Module1

    Sub Main()

        Dim diceOne As Integer
        Randomize()
        diceOne = CInt((5 * Rnd()) + 1)
        Dim diceTwo As Integer
        Randomize()
        diceTwo = CInt((5 * Rnd()) + 1)

        Dim results(1000) As Integer
        For Each roll As Integer In results
            roll = diceOne + diceTwo
            Console.WriteLine(roll)
        Next

        Console.ReadLine()
    End Sub

End Module
