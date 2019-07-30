<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseItemForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.itemTextBox = New System.Windows.Forms.TextBox()
        Me.itemPriceTextBox = New System.Windows.Forms.TextBox()
        Me.increaseQuantityButton = New System.Windows.Forms.Button()
        Me.calculateTotalButton = New System.Windows.Forms.Button()
        Me.clearPurchaseButton = New System.Windows.Forms.Button()
        Me.quantity3DLabel = New System.Windows.Forms.Label()
        Me.totalCost3DLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Location = New System.Drawing.Point(32, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Item Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Quantity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total Cost:"
        '
        'itemTextBox
        '
        Me.itemTextBox.Location = New System.Drawing.Point(106, 32)
        Me.itemTextBox.Name = "itemTextBox"
        Me.itemTextBox.Size = New System.Drawing.Size(100, 20)
        Me.itemTextBox.TabIndex = 1
        '
        'itemPriceTextBox
        '
        Me.itemPriceTextBox.Location = New System.Drawing.Point(106, 63)
        Me.itemPriceTextBox.Name = "itemPriceTextBox"
        Me.itemPriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.itemPriceTextBox.TabIndex = 3
        '
        'increaseQuantityButton
        '
        Me.increaseQuantityButton.Location = New System.Drawing.Point(106, 161)
        Me.increaseQuantityButton.Name = "increaseQuantityButton"
        Me.increaseQuantityButton.Size = New System.Drawing.Size(100, 24)
        Me.increaseQuantityButton.TabIndex = 8
        Me.increaseQuantityButton.Text = "Increase Quantity"
        Me.increaseQuantityButton.UseVisualStyleBackColor = True
        '
        'calculateTotalButton
        '
        Me.calculateTotalButton.Enabled = False
        Me.calculateTotalButton.Location = New System.Drawing.Point(106, 191)
        Me.calculateTotalButton.Name = "calculateTotalButton"
        Me.calculateTotalButton.Size = New System.Drawing.Size(100, 24)
        Me.calculateTotalButton.TabIndex = 9
        Me.calculateTotalButton.Text = "Calculate Total"
        Me.calculateTotalButton.UseVisualStyleBackColor = True
        '
        'clearPurchaseButton
        '
        Me.clearPurchaseButton.Location = New System.Drawing.Point(106, 221)
        Me.clearPurchaseButton.Name = "clearPurchaseButton"
        Me.clearPurchaseButton.Size = New System.Drawing.Size(100, 24)
        Me.clearPurchaseButton.TabIndex = 10
        Me.clearPurchaseButton.Text = "Clear Purchase"
        Me.clearPurchaseButton.UseVisualStyleBackColor = True
        '
        'quantity3DLabel
        '
        Me.quantity3DLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.quantity3DLabel.Location = New System.Drawing.Point(106, 90)
        Me.quantity3DLabel.Name = "quantity3DLabel"
        Me.quantity3DLabel.Size = New System.Drawing.Size(100, 23)
        Me.quantity3DLabel.TabIndex = 5
        '
        'totalCost3DLabel
        '
        Me.totalCost3DLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalCost3DLabel.Location = New System.Drawing.Point(106, 117)
        Me.totalCost3DLabel.Name = "totalCost3DLabel"
        Me.totalCost3DLabel.Size = New System.Drawing.Size(100, 23)
        Me.totalCost3DLabel.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(221, 267)
        Me.Controls.Add(Me.totalCost3DLabel)
        Me.Controls.Add(Me.quantity3DLabel)
        Me.Controls.Add(Me.clearPurchaseButton)
        Me.Controls.Add(Me.calculateTotalButton)
        Me.Controls.Add(Me.increaseQuantityButton)
        Me.Controls.Add(Me.itemPriceTextBox)
        Me.Controls.Add(Me.itemTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Purchase Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents itemTextBox As TextBox
    Friend WithEvents itemPriceTextBox As TextBox
    Friend WithEvents increaseQuantityButton As Button
    Friend WithEvents calculateTotalButton As Button
    Friend WithEvents clearPurchaseButton As Button
    Friend WithEvents quantity3DLabel As Label
    Friend WithEvents totalCost3DLabel As Label
End Class
