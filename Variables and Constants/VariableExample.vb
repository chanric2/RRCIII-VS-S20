'Richard Chandler III
'RCET2065
'Spring 2020
'Variables and Constants

'modules should be PascalCase
'PascalCase- multiple words where all words are capitalized
'example "VariableAndConstants

Option Strict On

Module VariableExample

    'Methods (sub nad function) should be in PascalCase
    Sub Main()
        'variables should always be camelCase
        'camel cased- multiple words very first word lower cased then words after first letter upper cased
        'example "variableAndConstants
        Dim fruitName As String
        Dim quantityApples As Integer
        Dim quantityBananas As Integer

        fruitName = "apples" '& " and" & " bananas"
        'Console.WriteLine(fruitName)

        quantityApples = 4
        'quantityBananas = 5

        Console.WriteLine("You have " & quantityApples & " " & fruitName & "!")
        Console.Read()

    End Sub

End Module
