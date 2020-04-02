'Richard Chandler III
'RCET0265
'Spring 2020
'Car Rental
'https://github.com/chanric2/RRCIII-VS-S20

Option Explicit On
Option Strict On
Option Compare Binary
Public Class RentalForm
    Private Sub RentalForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ResetAll()
        SummaryButton.Enabled = False
    End Sub

    Sub ResetAll()
        'Clear User input
        NameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipCodeTextBox.Text = ""
        BeginOdometerTextBox.Text = ""
        EndOdometerTextBox.Text = ""
        DaysTextBox.Text = ""
        MilesradioButton.Select()
        AAAcheckbox.Checked = False
        Seniorcheckbox.Checked = False
        'Clear Output

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ResetAll()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        'place sub calls
        Discount(500)
        MilageCharge(220)
        verifyOdometer()
        MsgBox(UserMessages(False, "", False))
    End Sub

    Function Discount(totalCharges As Decimal) As Decimal
        Const AAARATE = 0.05D
        Const SENIORRATE = 0.03D
        Dim totalDiscount As Decimal = 0

        If AAAcheckbox.Checked = True Then
            totalDiscount += totalCharges * AAARATE
        End If

        If Seniorcheckbox.Checked = True Then
            totalDiscount += totalCharges * SENIORRATE
        End If

        Return totalDiscount
    End Function

    Sub verifyOdometer()
        Dim userMessage As String

        Try
            If CDec(BeginOdometerTextBox.Text) > CDec(EndOdometerTextBox.Text) Then
                userMessage = "Invalid Beginning Odometer Number"
            End If
        Catch ex As Exception
            userMessage = "Odometer entry must be numbers"
        End Try
        UserMessages(True, userMessage, False)
    End Sub

    Function MilageCharge(ByRef miles As Decimal) As Decimal
        Dim mileCharge As Decimal

        Const RATE_REGULAR = 0.12D
        Const RATE_LOW = 0.1D
        Const RATE_FREE = 0D

        Select Case miles
            Case <= 200
                mileCharge = miles * RATE_FREE
            Case > 500
                mileCharge = miles * RATE_LOW
            Case Else
                mileCharge = miles * RATE_REGULAR
        End Select

        Return mileCharge
    End Function

    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String
        Static formattedMessages As String

        If clearMessage = True Then
            formattedMessages = ""
        ElseIf addMessage = True Then
            formattedMessages &= message & vbNewLine
        End If

        Return formattedMessages

    End Function

End Class
