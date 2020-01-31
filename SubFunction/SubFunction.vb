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
        Dim name As String
        number = 7
        name = "Daisy"
        Console.WriteLine("This is the Main.")
        Console.WriteLine(number)


        Console.ReadLine()
        MySub(number)
        Console.WriteLine("in sub main")
        Console.WriteLine(number)
        Console.ReadLine()
        MyFunc(number)
        Console.WriteLine("in Main")
        Console.WriteLine(number)
        Console.ReadLine()
        Console.WriteLine(MyFunc(number))
        Console.ReadLine()
        'Rename(name)
        Console.WriteLine("your name was " & name & " your new name is " & Rename(name))
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

    Function Rename(name As String) As String
        Console.WriteLine(name)
        Console.ReadLine()

        name = "Richard"
        Return name
    End Function
End Module
