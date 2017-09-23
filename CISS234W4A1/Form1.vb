Public Class Form1
    Private decCost As Decimal          'Holds value for Wholesale cost.
    Private decMarkup As Decimal        'Holds value for markup percent. 

    'Defines Function that returns false if user input does not pass validation.
    Private Function ValidateInputFields() As Boolean
        'Validates if wholesale price is numeric and positve.
        'Promps message box and clear if bool is false.
        If Not Decimal.TryParse(txtCost.Text, decCost) Then
            MessageBox.Show("Wholesale price must be numeric.")
            txtCost.Clear()
            txtCost.Focus()
            Return False
        End If
        If (txtCost.Text < 0) Then
            MessageBox.Show("Wholesale price can't be negative.")
            txtCost.Clear()
            txtCost.Focus()
            Return False
        End If
        'Validates if markup price is numeric and positve.
        'Promps message box and clear if bool is false.
        If Not Decimal.TryParse(txtMarkup.Text, decMarkup) Then
            MessageBox.Show("Markup percentage must be numeric.")
            txtMarkup.Clear()
            txtMarkup.Focus()
            Return False
        End If
        If (txtMarkup.Text < 0) Then
            MessageBox.Show("Markup price can't be negative.")
            txtMarkup.Clear()
            txtMarkup.Focus()
            Return False
        End If
        'The funtion will return true if all of the validations pass.
        Return True
    End Function

    'Defines Function that calculates the retail price from user input and returns value.
    Function CalculateRetail(ByVal decCost As Decimal, ByVal decMarkup As Decimal) As Decimal
        Dim decPriceValue As Decimal       'Holds return value of retail price calculation.
        decPriceValue = decCost + (decCost * (decMarkup / 100))
        Return decPriceValue
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGetRetail.Click
        Dim decPriceValue As Decimal       'Returned Value of retail price calculation.
        txtRetailPrice.Text = String.Empty  'Clears any data on the screen.

        'If bool value is returned true the funtion runs and displays data in currency format. 
        If ValidateInputFields() Then
            decPriceValue = CalculateRetail(decCost, decMarkup)
            txtRetailPrice.Text = decPriceValue.ToString("c")
            txtCost.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the program.
        Me.Close()
    End Sub
End Class
