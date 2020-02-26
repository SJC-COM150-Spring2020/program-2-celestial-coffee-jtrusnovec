Public Class CelestialCoffee
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clears all values for the user
        txtFirstName.Clear()
        txtLastName.Clear()
        txtAddress.Clear()
        txtState.Clear()
        txtZip.Clear()
        txtRegular.Clear()
        txtDecaf.Clear()
        lstTotal.Items.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'exits the program for the user
        Application.Exit()

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'show a thank you message to the user
        MessageBox.Show("Thank You, " & txtFirstName.Text & "!")

        'declare pounds of regular coffee as double since user could want quarter or half pounds
        Dim regular As Double

        'declare pounds of decaf coffee as double since user could want quarter or half pounds
        Dim decaf As Double

        'declare TAX as a constant and double
        Const TAX As Double = 0.08645

        'declare finaltotal as double since tax can produce a decimal value
        Dim finaltotal As Double

        'declare coffeetotal as double since user could want quarter or half pounds
        Dim coffeetotal As Double

        'cast value in textbox of regular coffee pounds to string
        regular = CStr(txtRegular.Text)

        'cast value in textbox of decaf coffee pounds to string
        decaf = CStr(txtDecaf.Text)

        'calculate the total pounds of coffee the user orders
        coffeetotal = regular + decaf

        'calculate the users total using new york sales tax and all coffee at 2 dollars a pound
        finaltotal = (coffeetotal * 2) + ((coffeetotal * 2) * TAX)

        'display the results in a listbox
        lstTotal.Items.Add(txtFirstName.Text & " " & txtLastName.Text & ", your final total for " & coffeetotal & " pound(s) of coffee is " & FormatCurrency(finaltotal, 2) & ".")
        lstTotal.Items.Add("Your order will be delivered to " & txtAddress.Text & ", " & txtState.Text & " " & txtZip.Text & ".")


    End Sub
End Class
