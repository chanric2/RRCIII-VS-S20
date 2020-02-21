'Richard Chandler III
'RCET0265
'Spring 2020
'list example
'https://github.com/rosstimo/RRCIII-VS-S20

Option Strict On
Option Explicit On
Option Compare Text

Module listExample

    Sub Main()
        Dim names As New List(Of String)
        Dim newName As String
        Dim searchString As String
        names.Add("Richard")
        names.Add("Pan0ph0bia")
        names.Add("Tessa")

        Console.WriteLine("Please enter a new name!")
        newName = Console.ReadLine()
        names.Add(newName)
        If Console.ReadLine() = 'name from list'
            Then
            Console.WriteLine(newName & ", is already on file")
        Else

        End If
        Console.Clear()

        Console.WriteLine("Search a name...")
        searchString = Console.ReadLine()
        If names.Contains(searchString) = True Then
            Console.WriteLine("Yes, " & searchString & " is at index " & names.IndexOf(searchString))
        Else
            Console.WriteLine("No, " & searchString & " is not found.")
        End If

        For Each name In names
            Console.WriteLine(name)
        Next

        Console.ReadLine()
    End Sub

End Module
