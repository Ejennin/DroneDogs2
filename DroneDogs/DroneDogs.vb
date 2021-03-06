Public Class DroneDogsOrder

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalcOrder.Click

        'Declare constants
        Const DBL_SALES_TAX_RATE As Double = 0.07
        Const DBL_PRICE_HOT_DOG As Double = 1.99
        'Declare variables 
        Dim intNumBeefDogs As Integer
        Dim intNumPorkDogs As Integer
        Dim intNumTurkeyDogs As Integer
        Dim intNumTotalDogs As Integer
        Dim dblSubtotal As Double
        Dim dblSalesTax As Double
        Dim dblTotalCost As Double

        'Extract user typed quantities from text boxes and convert to integers
        intNumBeefDogs = Convert.ToInt32(txtBeefDogs.Text)
        intNumPorkDogs = Convert.ToInt32(txtPorkDogs.Text)
        intNumTurkeyDogs = Convert.ToInt32(txtTurkeyDogs.Text)

        'Calculate total number of hot dogs ordered
        intNumTotalDogs = intNumBeefDogs + intNumPorkDogs + intNumTurkeyDogs
        'Calculate subtotal, sales tax, and total amounts
        dblSubtotal = intNumTotalDogs * DBL_PRICE_HOT_DOG
        dblSalesTax = dblSubtotal * DBL_SALES_TAX_RATE
        dblTotalCost = dblSubtotal + dblSalesTax
        'Convert numbers back to text and display in text boxes
        txtTotalCost.Text = dblTotalCost.ToString("c2")
        txtSalesTax.Text = dblSalesTax.ToString("c2")
        txtSubtotal.Text = dblSubtotal.ToString("c2")

    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'Display message box thanking the user
        MessageBox.Show("Thank you for ordering from DroneDogs! Have great day! Eric Jennings")
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Close form
        Me.Close()

    End Sub


End Class
