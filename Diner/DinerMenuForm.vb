'Richard Chandler III
'RCET0265
'Spring 2020
'Diner Menu Program
'https://github.com/rosstimo/RRCIII-VS-S20

Public Class DinerMenuForm

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        'type soupmessage
        Dim soupMessage As String
        soupMessage &= "~Soup of the Day~" & vbNewLine & "Goa'uld Soup. Freshly perserved by Bra'tac and closely monitored by Teal'c, to ensure safety and proper care."
        DisplaySpecialLabel.Text = soupMessage
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        'type saladmessage
        Dim saladMessage As String
        saladMessage &= "~Tok'ra Salad~" & vbNewLine & "Starts with fresh leaf lettuce. Hides a flavorful roma tomato and sliced cucumber layer underneath the surface. All Ingredients grown by Selmak."
        DisplaySpecialLabel.Text = saladMessage
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        'type fishmessage
        Dim fishMessage As String
        fishMessage &= "Tau'ri fish" & vbNewLine & "Fresh Wyoming trout, caught by Jack O'Neill. "
        DisplaySpecialLabel.Text = fishMessage
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
''look at options by selecting the menu item, initially
'within each selection, view option to order
'once ordered confirmed, write price to messagebox(reciept)
'display reciept to pay or continue to dessert
'if pay, end, display please come again
'if dessert open new form for desserts
'look at options by selecting the dessert item, initially
'within each selection, view option to order
'once ordered confirmed, write price to messagebox(reciept)
'display reciept to pay
'if pay, end, display please come again and thank you
