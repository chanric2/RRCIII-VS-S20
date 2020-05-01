'Richard Chandler III
'RCET0265
'Spring 2020
'Car Rental
'https://github.com/chanric2/RRCIII-VS-S20

Option Explicit On
Option Strict On
Option Compare Binary
Public Class RentalForm
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click, CalculateToolStripMenuItem.Click
        Dim dailyCharge As Decimal
        Dim youOwe As Decimal
        Dim mi As Decimal
        Dim ki As Double
        If ValidText() = True Then
            'calculate information and activate summary
            SummaryButton.Enabled = True
            'Pricing for daily charges $15.00 per day rented ad display
            dailyCharge = 15 * CDec(DaysTextBox.Text)
            DayChargeTextBox.Text = dailyCharge.ToString("C")
            'Converion of kilometers and miles and calculated miles driven by odometer readings and stores the data for summary and display
            If KilometersradioButton.Checked = True Then
                ki = CDec(EndOdometerTextBox.Text) - CDec(BeginOdometerTextBox.Text)
                mi = CDec(ki * 0.62)
            ElseIf MilesradioButton.Checked = True Then
                mi = CDec(EndOdometerTextBox.Text) - CDec(BeginOdometerTextBox.Text)
            End If
            MilesDriven(mi)
            DistanceTextBox.Text = CStr(mi) & " mi"
            'Pricing for miles driven and display
            MileChargeTextBox.Text = MileageCharge(mi).ToString("C")
            'Pricing for discounts available and display
            DiscountTextBox.Text = Discount().ToString("C")
            'Price of finalized total from the other output displays and stores the data for summary and display
            youOwe = CDec(MileChargeTextBox.Text) + CDec(DayChargeTextBox.Text) - CDec(DiscountTextBox.Text)
            FinalPrice(youOwe)
            TotalTextBox.Text = youOwe.ToString("C")
            'Stores the data for summary
            CustomerNumber(1)
        End If
    End Sub

    Function ValidText() As Boolean
        'Start by creating new validation on calculate
        FailMessage("", False, True)
        'Checks empty text and if values are in tolerances.
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

        'if empty sends message and sets cursor to the appropiate box.
        Try
            If (CInt(DaysTextBox.Text) < 0 Or CInt(DaysTextBox.Text) > 45) Then
                valid = False
                DaysTextBox.Focus()
                DaysTextBox.Text = ""
                FailMessage("Number of days must be between 0 and 45.", True, False)
            End If
        Catch ex As Exception
            valid = False
            DaysTextBox.Focus()
            DaysTextBox.Text = ""
            FailMessage("Number of days must be a whole number.", True, False)
        End Try
        Try
            If CInt(BeginOdometerTextBox.Text) > CInt(EndOdometerTextBox.Text) Then
                valid = False
                BeginOdometerTextBox.Focus()
                BeginOdometerTextBox.Text = ""
                EndOdometerTextBox.Text = ""
                FailMessage("Verify beginning odometer reading is lower than the 
                    ending reading.", True, False)
            End If
        Catch ex As Exception
            valid = False
            BeginOdometerTextBox.Focus()
            BeginOdometerTextBox.Text = ""
            EndOdometerTextBox.Text = ""
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

    Function MileageCharge(miles As Decimal) As Decimal
        Dim charge As Decimal
        'determines if miles driven are:
        'below 200 = free
        'between 201 and 500 = $0.12 per mile
        'above 500 = $0.10 per mile
        'sets price accordingly

        If miles <= 200 Then
            charge = miles * 0
        ElseIf miles > 500 Then
            charge = (36 + (miles - 500) * 0.1D)
        Else
            charge = (miles - 200) * 0.12D
        End If

        Return charge
    End Function

    Function Discount() As Decimal
        Dim dicount As Decimal = 0D

        If AAAcheckbox.Checked = True Then
            '5% AAA discount
            dicount += (CDec(DayChargeTextBox.Text) + CDec(MileChargeTextBox.Text)) * 0.05D
        End If

        If Seniorcheckbox.Checked = True Then
            '3% Senior citizen discount
            dicount += (CDec(DayChargeTextBox.Text) + CDec(MileChargeTextBox.Text)) * 0.03D
        End If

        Return dicount
    End Function

    Private Sub Summary(sender As Object, e As EventArgs) Handles SummaryButton.Click, SummaryToolStripMenuItem.Click
        'total number of customers
        SummaryMessage("Total Customers:" & CustomerNumber(0).ToString.PadLeft(48), True, False)
        'total miles of all customers
        SummaryMessage("Total Miles Driven:" & (MilesDriven(0) & " mi").ToString.PadLeft(40), True, False)
        'total Price of all customers
        SummaryMessage("Total Charges:" & FinalPrice(0).ToString("C").PadLeft(40), True, False)

        MsgBox(SummaryMessage("", False, False), MsgBoxStyle.Information Or
               MsgBoxStyle.MsgBoxRight, "Summary: All Rentals From Store 2319")

    End Sub

    Function CustomerNumber(currentCustomer As Decimal) As Decimal
        Static customerCount As Decimal
        customerCount += currentCustomer
        Return customerCount
    End Function

    Function MilesDriven(currentMiles As Decimal) As Decimal
        Static mileCount As Decimal
        mileCount += currentMiles
        Return mileCount
    End Function

    Function FinalPrice(currentPrice As Decimal) As Decimal
        Static priceCount As Decimal
        priceCount += currentPrice
        Return priceCount
    End Function

    Function SummaryMessage(sumMessage As String, addMessage As Boolean, clearMessage As Boolean) As String
        Static returnedMessage As String

        If clearMessage = False Then
            If addMessage = True Then
                returnedMessage &= sumMessage & vbNewLine
            End If
        Else
            returnedMessage = ""
        End If

        Return returnedMessage
    End Function

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, SummaryButton.Click, ClearToolStripMenuItem.Click
        NameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipCodeTextBox.Text = ""
        BeginOdometerTextBox.Text = ""
        EndOdometerTextBox.Text = ""
        DaysTextBox.Text = ""
        BeginOdometerTextBox.Text = ""
        EndOdometerTextBox.Text = ""
        DistanceTextBox.Text = ""
        MileChargeTextBox.Text = ""
        DayChargeTextBox.Text = ""
        DiscountTextBox.Text = ""
        TotalTextBox.Text = ""
        SummaryButton.Enabled = False
        AAAcheckbox.Checked = False
        Seniorcheckbox.Checked = False
        MilesradioButton.Checked = True
        SummaryMessage("", False, True)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Dim response = MsgBox("Click YES to Quit." & vbNewLine & "Click NO to Continue.",
                              MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
                              MsgBoxStyle.Exclamation, "Are You Sure You Want To QUIT?")
        If response = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Made by Richard Chandler III" & vbNewLine & "Spring 2020" &
               vbNewLine & "RCET 0265" &
               vbNewLine & "In association with ISU Robotics",
               MsgBoxStyle.Question, "About Store 2319")
    End Sub
End Class
