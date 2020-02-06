'Richard Chandler III
'RCET0265
'Spring 2020
'Formats
'https://github.com/rosstimo/RRCIII-VS-S20

Option Strict On
Option Explicit On
Option Compare Binary

Module Formats

    Sub Main()

        'currency value
        'Dim value As Decimal
        'Console.WriteLine("Enter withdrawl amount, NO CHANGE")
        'value = CDec(Console.ReadLine())
        'value.ToString("C")
        'Console.WriteLine(value)
        'Console.WriteLine(value.ToString("C"))

        'Hexadecimal value
        ' Console.WriteLine(value.ToString("X"))

        '  TooManySpaces()
        TimesTable()
        Console.ReadLine()
    End Sub

    Sub TooManySpaces()

        Dim message As String
        message = "                                          Richard                           "
        Console.WriteLine(Len(message))
        message = Trim(message)
        Console.WriteLine(Len(message))

    End Sub

    Sub TimesTable()

        Dim result As Integer

        For i = 1 To 12

            For j = 1 To 12
                result = i * j
                Console.Write(result.ToString("C").PadLeft(8) & "|")
            Next
            Console.WriteLine()
        Next

    End Sub

End Module
