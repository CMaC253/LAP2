'MIS 322
'Colin McDonald
'LAP 2
'4/23/2019

Option Explicit On
Option Strict On

Public Class PurchaseItemForm

    Private quantityCount As Integer
    Private Sub increaseQuantityButton_Click(sender As Object,
                e As EventArgs) _
                Handles increaseQuantityButton.Click

        'If... then trap to keep quantity within 10
        If quantityCount >= 10 Then
            MessageBox.Show("I pity the foo, who try to go past 10", "Too much qty SUCKA!")
            Exit Sub
        End If
        'Increase quantity by 1
        quantityCount += 1
        'Display new quantity in label
        quantity3DLabel.Text = quantityCount.ToString("N0")
        'Clear cost from total cost label
        totalCost3DLabel.Text = ""
        'enable calculate total button
        calculateTotalButton.Enabled = True

    End Sub '---------------------------------------------------------------------------------------------------

    Private Sub calculateTotalButton_Click(sender As Object,
                e As EventArgs) _
                Handles calculateTotalButton.Click

        Dim itemPrice, totalCost As Double

        'Check for empty text boxes
        If itemTextBox.Text = "" _
        Or itemPriceTextBox.Text = "" Then
            MessageBox.Show("Make sure both text boxes are filled",
                            "Text Box Error")
            Exit Sub
        End If

        'Check for invalid numbers 
        Try
            itemPrice = Convert.ToDouble(itemPriceTextBox.Text)
        Catch fe As FormatException
            MessageBox.Show("Price is incorrectly formatted",
                            "Invalid Number Error")
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("Unexpected Error: " & ex.Message,
                            "Unexpected Error")
            Exit Sub
        End Try

        'Check for negative numbers
        If itemPrice < 0 Then
            MessageBox.Show("Please enter a positive number",
                            "Negative Number Error")
            Exit Sub
        End If

        'calculate total cost 
        totalCost = quantityCount * itemPrice

        'convert totalCost to string and set it to the 3D Label
        totalCost3DLabel.Text = totalCost.ToString("C2")

        'Put focus on item and select its contents
        itemTextBox.Focus()
        itemTextBox.SelectAll()

    End Sub '---------------------------------------------------------------------------------------------------

    Private Sub clearPurchaseButton_Click(sender As Object,
                e As EventArgs) _
                Handles clearPurchaseButton.Click

        'Erase values in two 3d Labels
        quantity3DLabel.Text = ""
        totalCost3DLabel.Text = ""
        'Clear text boxes
        itemTextBox.Clear()
        itemPriceTextBox.Clear()
        'Disable calculate total button
        calculateTotalButton.Enabled = False
        'Zero out quantity
        quantityCount = 0
        'Focus on item textbox
        itemTextBox.Focus()

    End Sub '---------------------------------------------------------------------------------------------------

End Class
