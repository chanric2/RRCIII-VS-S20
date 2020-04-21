'Richard Chandler III
'RCET0265
'Spring 2020
'Car Rental
'https://github.com/chanric2/RRCIII-VS-S20

Option Explicit On
Option Strict On
Option Compare Binary
Public Class RentalForm
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        If ValidText() = True Then
            'calculate information
            MsgBox("Pass Vaild") 'this will be taken out once all vaildations can be confirmed
        End If
    End Sub
    Function ValidText() As Boolean
        'Start by creating new validation on calulate
        FailMessage("", False, True)
        'Check empty text and if values are in tolerance.
        'True if all text fields are filled, false a text field is invalid.
        Dim valid As Boolean
        Try
            If NameTextBox.Text <> "" And AddressTextBox.Text <> "" And
                CityTextBox.Text <> "" And StateTextBox.Text <> "" And
                ZipCodeTextBox.Text <> "" And BeginOdometerTextBox.Text <> "" And
                EndOdometerTextBox.Text <> "" And DaysTextBox.Text <> "" And
                CInt(BeginOdometerTextBox.Text) < CInt(EndOdometerTextBox.Text) And
                (CInt(DaysTextBox.Text) > 0 And CInt(DaysTextBox.Text) < 45) Then
                valid = True
            ElseIf NameTextBox.Text = "" Or AddressTextBox.Text = "" Or
                CityTextBox.Text = "" Or StateTextBox.Text = "" Or
                ZipCodeTextBox.Text = "" Or BeginOdometerTextBox.Text = "" Or
                EndOdometerTextBox.Text = "" Or DaysTextBox.Text = "" Or
                CInt(BeginOdometerTextBox.Text) > CInt(EndOdometerTextBox.Text) Or
                (CInt(DaysTextBox.Text) < 0 Or CInt(DaysTextBox.Text) > 45) Then
                valid = False
            End If
        Catch ex As Exception
            valid = False
        End Try

        'if empty sends message and sets cursor to the box.
        Try
            If (CInt(DaysTextBox.Text) < 0 Or CInt(DaysTextBox.Text) > 45) Then
                valid = False
                DaysTextBox.Focus()
                FailMessage("Number of days must be between 0 and 45.", True, False)
            End If
        Catch ex As Exception
            valid = False
            DaysTextBox.Focus()
            FailMessage("Number of days must be a whole number.", True, False)
        End Try
        Try
            If CInt(BeginOdometerTextBox.Text) > CInt(EndOdometerTextBox.Text) Then
                valid = False
                BeginOdometerTextBox.Focus()
                FailMessage("Verify beginning odometer reading is lower than the ending reading.", True, False)
            End If
        Catch ex As Exception
            valid = False
            BeginOdometerTextBox.Focus()
            FailMessage("Odometer readings must be a whole number.", True, False)
        End Try
        If ZipCodeTextBox.Text = "" Then
            ZipCodeTextBox.Focus()
            FailMessage("Zip Code is blank.", True, False)
        End If
        If StateTextBox.Text = "" Then
            StateTextBox.Focus()
            FailMessage("State is blank.", True, False)
        End If
        If CityTextBox.Text = "" Then
            CityTextBox.Focus()
            FailMessage("City is blank.", True, False)
        End If
        If AddressTextBox.Text = "" Then
            AddressTextBox.Focus()
            FailMessage("Address is blank.", True, False)
        End If
        If NameTextBox.Text = "" Then
            NameTextBox.Focus()
            FailMessage("Name is blank.", True, False)
        End If

        'If an error occurs then display a single message pop up with all accumulated data
        If valid = False Then
            MsgBox(FailMessage("", False, False))
        End If

        Return valid
    End Function

    Function FailMessage(errMessage As String, addMessage As Boolean, clearMessage As Boolean) As String
        Static alertMessage As String

        If clearMessage = False Then
            If addMessage = True Then
                alertMessage &= errMessage & vbNewLine
            End If
        Else
            alertMessage = ""
        End If

        Return alertMessage
    End Function
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim response = MsgBox("Click YES to Quit." & vbNewLine & "Click NO to Continue.", MsgBoxStyle.YesNo _
                              Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation,
                              "Are You Sure You Want To QUIT?")
        If response = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
