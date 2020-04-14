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
        'check empty text and if values are in tolerance.
        Dim valid As Boolean
        Try
            If NameTextBox.Text <> "" And AddressTextBox.Text <> "" And
                CityTextBox.Text <> "" And StateTextBox.Text <> "" And
                ZipCodeTextBox.Text <> "" And BeginOdometerTextBox.Text <> "" And
                EndOdometerTextBox.Text <> "" And DaysTextBox.Text <> "" And
                CInt(BeginOdometerTextBox.Text) < CInt(EndOdometerTextBox.Text) And
                (CInt(DaysTextBox.Text) > 0 Or CInt(DaysTextBox.Text) < 45) Then
                'true "if all text fields are filled"
                valid = True
            ElseIf NameTextBox.Text = "" And AddressTextBox.Text = "" And
                CityTextBox.Text = "" And StateTextBox.Text = "" And
                ZipCodeTextBox.Text = "" And BeginOdometerTextBox.Text = "" And
                EndOdometerTextBox.Text = "" And DaysTextBox.Text = "" And
                CInt(BeginOdometerTextBox.Text) > CInt(EndOdometerTextBox.Text) And
                (CInt(DaysTextBox.Text) < 0 Or CInt(DaysTextBox.Text) > 45) Then
                valid = False
            End If

        Catch ex As Exception
            'false "A text field is Invalid"
            valid = False
        End Try
        'if empty sends message and sets cursor to the box.
        If NameTextBox.Text = "" Then
            NameTextBox.Focus()
            MsgBox(FailMessage("Name is blank. Please Fill Out Form Completely.", True, False))
        End If
        If AddressTextBox.Text = "" Then
            AddressTextBox.Focus()
            MsgBox(FailMessage("Address is blank. Please Fill Out Form Completely.", True, False))
        End If
        If CityTextBox.Text = "" Then
            CityTextBox.Focus()
            MsgBox(FailMessage("City is blank. Please Fill Out Form Completely.", True, False))
        End If
        If StateTextBox.Text = "" Then
            StateTextBox.Focus()
            MsgBox(FailMessage("State is blank. Please Fill Out Form Completely.", True, False))
        End If
        If ZipCodeTextBox.Text = "" Then
            ZipCodeTextBox.Focus()
            MsgBox(FailMessage("Zip Code is blank. Please Fill Out Form Completely.", True, False))
        End If
        If BeginOdometerTextBox.Text = "" Then
            BeginOdometerTextBox.Focus()
            MsgBox(FailMessage("Beginning Odometer Number is blank. Please Fill Out Form Completely.",
                               True, False))
        End If
        If EndOdometerTextBox.Text = "" Then
            EndOdometerTextBox.Focus()
            MsgBox(FailMessage("End Odometer Number is blank. Please Fill Out Form Completely.", True, False))
        End If
        If DaysTextBox.Text = "" Then
            DaysTextBox.Focus()
            MsgBox(FailMessage("Numbers of days is blank. Please Fill Out Form Completely.", True, False))
        End If

        Return valid
    End Function

    Function FailMessage(errMessage As String, addMessage As Boolean, clearMessage As Boolean) As String
        Dim alertMessage As String
        alertMessage = ""
        If clearMessage = False Then
            If addMessage = True Then
                alertMessage &= errMessage & vbNewLine
            End If
        Else
            alertMessage &= ""
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
