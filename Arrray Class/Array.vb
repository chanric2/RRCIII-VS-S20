'Richard Chandler III
'RCET0265
'Spring 2020
'Array
'https://github.com/rosstimo/RRCIII-VS-S20
Module Array

    Sub Main()
        '4 x 4 Array
        'Dim myArray(3, 3) As Integer
        'myArray(1, 1) = 5

        'single dim array 0-3
        Dim myArray(3) As Integer
        myArray = {1, 2, 3, 4}
        'sets 0 index to integer 5
        myArray(0) = 5
        'save Data(preserve) in array And change size to 0-15 (redim)
        ReDim Preserve myArray(15)
        Console.ReadLine()
    End Sub

End Module
