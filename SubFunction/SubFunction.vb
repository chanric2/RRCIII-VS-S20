'Richard Chandler III
'RCET0265
'Spring 2020
'SubFunction
'https://github.com/rosstimo/RRCIII-VS-S20

Option Strict On
Option Explicit On
Option Compare Binary

Module SubFunction

    Sub Main()
        Dim number As Integer
        number = 7

        Console.WriteLine("This is the Main.")
        Console.WriteLine(number)


        Console.ReadLine()
        MySub(number)
        Console.WriteLine("in sub")
        Console.WriteLine(number)
        Console.ReadLine()
        MyFunc(number)
        Console.WriteLine("in Main")
        Console.WriteLine(number)
        Console.WriteLine(MyFunc(number))
        Console.ReadLine()
    End Sub

    Sub MySub(number As Integer)
        'Dim number As Integer
        'number = 4
        number = number + 2
        number -= 1
        Console.WriteLine("This is the MySub.")
        Console.WriteLine(number)


        Console.ReadLine()

    End Sub

    Function MyFunc(number As Integer) As Integer
        'Dim number As Integer
        number -= 2

        Console.WriteLine("This is the Function.")
        Console.WriteLine(number)


        Console.ReadLine()

        Return number
    End Function

End Module
