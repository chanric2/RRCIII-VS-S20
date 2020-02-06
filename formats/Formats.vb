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
        Dim value As Integer
        Console.WriteLine("Enter withdrawl amount, NO CHANGE")
        value = CInt(Console.ReadLine())
        value.ToString("C")
        Console.WriteLine(value)
        Console.WriteLine(value.ToString("C"))

        'Hexadecimal value
        Console.WriteLine(value.ToString("X"))

        Console.ReadLine()
    End Sub

End Module
