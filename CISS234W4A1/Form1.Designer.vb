<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnGetRetail = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblWholesaleCost = New System.Windows.Forms.Label()
        Me.lblMarkup = New System.Windows.Forms.Label()
        Me.lblRetailPrice = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtMarkup = New System.Windows.Forms.TextBox()
        Me.txtRetailPrice = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGetRetail
        '
        Me.btnGetRetail.Location = New System.Drawing.Point(59, 200)
        Me.btnGetRetail.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGetRetail.Name = "btnGetRetail"
        Me.btnGetRetail.Size = New System.Drawing.Size(148, 48)
        Me.btnGetRetail.TabIndex = 3
        Me.btnGetRetail.Text = "Get Retail"
        Me.btnGetRetail.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(213, 200)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(148, 48)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblWholesaleCost
        '
        Me.lblWholesaleCost.AutoSize = True
        Me.lblWholesaleCost.Location = New System.Drawing.Point(55, 36)
        Me.lblWholesaleCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWholesaleCost.Name = "lblWholesaleCost"
        Me.lblWholesaleCost.Size = New System.Drawing.Size(150, 19)
        Me.lblWholesaleCost.TabIndex = 2
        Me.lblWholesaleCost.Text = "Wholesale Cost of item"
        '
        'lblMarkup
        '
        Me.lblMarkup.AutoSize = True
        Me.lblMarkup.Location = New System.Drawing.Point(130, 81)
        Me.lblMarkup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMarkup.Name = "lblMarkup"
        Me.lblMarkup.Size = New System.Drawing.Size(75, 19)
        Me.lblMarkup.TabIndex = 3
        Me.lblMarkup.Text = "Markup %"
        '
        'lblRetailPrice
        '
        Me.lblRetailPrice.AutoSize = True
        Me.lblRetailPrice.Location = New System.Drawing.Point(127, 129)
        Me.lblRetailPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRetailPrice.Name = "lblRetailPrice"
        Me.lblRetailPrice.Size = New System.Drawing.Size(78, 19)
        Me.lblRetailPrice.TabIndex = 4
        Me.lblRetailPrice.Text = "Retail Price"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(249, 29)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(112, 26)
        Me.txtCost.TabIndex = 1
        '
        'txtMarkup
        '
        Me.txtMarkup.Location = New System.Drawing.Point(249, 81)
        Me.txtMarkup.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMarkup.Name = "txtMarkup"
        Me.txtMarkup.Size = New System.Drawing.Size(112, 26)
        Me.txtMarkup.TabIndex = 2
        '
        'txtRetailPrice
        '
        Me.txtRetailPrice.Enabled = False
        Me.txtRetailPrice.Location = New System.Drawing.Point(249, 129)
        Me.txtRetailPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRetailPrice.Name = "txtRetailPrice"
        Me.txtRetailPrice.Size = New System.Drawing.Size(112, 26)
        Me.txtRetailPrice.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 268)
        Me.Controls.Add(Me.txtRetailPrice)
        Me.Controls.Add(Me.txtMarkup)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.lblRetailPrice)
        Me.Controls.Add(Me.lblMarkup)
        Me.Controls.Add(Me.lblWholesaleCost)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGetRetail)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Retail Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGetRetail As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblWholesaleCost As Label
    Friend WithEvents lblMarkup As Label
    Friend WithEvents lblRetailPrice As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtMarkup As TextBox
    Friend WithEvents txtRetailPrice As TextBox
End Class
