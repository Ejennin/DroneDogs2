<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DroneDogsOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DroneDogsOrder))
        Me.lblDroneDogHeader = New System.Windows.Forms.Label()
        Me.lblBeefDogs = New System.Windows.Forms.Label()
        Me.lblPorkDogs = New System.Windows.Forms.Label()
        Me.lblTurkeyDogs = New System.Windows.Forms.Label()
        Me.txtBeefDogs = New System.Windows.Forms.TextBox()
        Me.txtPorkDogs = New System.Windows.Forms.TextBox()
        Me.txtTurkeyDogs = New System.Windows.Forms.TextBox()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtSalesTax = New System.Windows.Forms.TextBox()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnCalcOrder = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDroneDogHeader
        '
        Me.lblDroneDogHeader.AutoSize = True
        Me.lblDroneDogHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDroneDogHeader.ForeColor = System.Drawing.Color.Maroon
        Me.lblDroneDogHeader.Location = New System.Drawing.Point(128, 46)
        Me.lblDroneDogHeader.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDroneDogHeader.Name = "lblDroneDogHeader"
        Me.lblDroneDogHeader.Size = New System.Drawing.Size(375, 37)
        Me.lblDroneDogHeader.TabIndex = 0
        Me.lblDroneDogHeader.Text = "DroneDogs Order Form"
        '
        'lblBeefDogs
        '
        Me.lblBeefDogs.AutoSize = True
        Me.lblBeefDogs.Location = New System.Drawing.Point(76, 115)
        Me.lblBeefDogs.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblBeefDogs.Name = "lblBeefDogs"
        Me.lblBeefDogs.Size = New System.Drawing.Size(124, 25)
        Me.lblBeefDogs.TabIndex = 1
        Me.lblBeefDogs.Text = "# BeefDogs"
        '
        'lblPorkDogs
        '
        Me.lblPorkDogs.AutoSize = True
        Me.lblPorkDogs.Location = New System.Drawing.Point(76, 167)
        Me.lblPorkDogs.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPorkDogs.Name = "lblPorkDogs"
        Me.lblPorkDogs.Size = New System.Drawing.Size(130, 25)
        Me.lblPorkDogs.TabIndex = 2
        Me.lblPorkDogs.Text = "# PorkDogs:"
        '
        'lblTurkeyDogs
        '
        Me.lblTurkeyDogs.AutoSize = True
        Me.lblTurkeyDogs.Location = New System.Drawing.Point(76, 217)
        Me.lblTurkeyDogs.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTurkeyDogs.Name = "lblTurkeyDogs"
        Me.lblTurkeyDogs.Size = New System.Drawing.Size(152, 25)
        Me.lblTurkeyDogs.TabIndex = 3
        Me.lblTurkeyDogs.Text = "# TurkeyDogs:"
        '
        'txtBeefDogs
        '
        Me.txtBeefDogs.Location = New System.Drawing.Point(244, 115)
        Me.txtBeefDogs.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtBeefDogs.Name = "txtBeefDogs"
        Me.txtBeefDogs.Size = New System.Drawing.Size(76, 31)
        Me.txtBeefDogs.TabIndex = 4
        '
        'txtPorkDogs
        '
        Me.txtPorkDogs.Location = New System.Drawing.Point(244, 167)
        Me.txtPorkDogs.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtPorkDogs.Name = "txtPorkDogs"
        Me.txtPorkDogs.Size = New System.Drawing.Size(76, 31)
        Me.txtPorkDogs.TabIndex = 5
        '
        'txtTurkeyDogs
        '
        Me.txtTurkeyDogs.Location = New System.Drawing.Point(244, 217)
        Me.txtTurkeyDogs.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtTurkeyDogs.Name = "txtTurkeyDogs"
        Me.txtTurkeyDogs.Size = New System.Drawing.Size(76, 31)
        Me.txtTurkeyDogs.TabIndex = 6
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Location = New System.Drawing.Point(82, 444)
        Me.lblSalesTax.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(114, 25)
        Me.lblSalesTax.TabIndex = 8
        Me.lblSalesTax.Text = "Sales Tax:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(82, 496)
        Me.lblTotalCost.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(116, 25)
        Me.lblTotalCost.TabIndex = 9
        Me.lblTotalCost.Text = "Total Cost:"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(244, 394)
        Me.txtSubtotal.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(196, 31)
        Me.txtSubtotal.TabIndex = 10
        '
        'txtSalesTax
        '
        Me.txtSalesTax.Location = New System.Drawing.Point(244, 444)
        Me.txtSalesTax.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtSalesTax.Name = "txtSalesTax"
        Me.txtSalesTax.ReadOnly = True
        Me.txtSalesTax.Size = New System.Drawing.Size(196, 31)
        Me.txtSalesTax.TabIndex = 11
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(244, 496)
        Me.txtTotalCost.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(196, 31)
        Me.txtTotalCost.TabIndex = 12
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(588, 17)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(176, 188)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 13
        Me.picLogo.TabStop = False
        '
        'btnCalcOrder
        '
        Me.btnCalcOrder.Location = New System.Drawing.Point(60, 302)
        Me.btnCalcOrder.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnCalcOrder.Name = "btnCalcOrder"
        Me.btnCalcOrder.Size = New System.Drawing.Size(178, 44)
        Me.btnCalcOrder.TabIndex = 14
        Me.btnCalcOrder.Text = "Calculate Order"
        Me.btnCalcOrder.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(464, 302)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(178, 44)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "EXIT?"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(262, 302)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(178, 44)
        Me.btnSubmit.TabIndex = 16
        Me.btnSubmit.Text = "Submit Order"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(87, 399)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(97, 25)
        Me.lblSubtotal.TabIndex = 17
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'DroneDogsOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 806)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalcOrder)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.txtSalesTax)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblSalesTax)
        Me.Controls.Add(Me.txtTurkeyDogs)
        Me.Controls.Add(Me.txtPorkDogs)
        Me.Controls.Add(Me.txtBeefDogs)
        Me.Controls.Add(Me.lblTurkeyDogs)
        Me.Controls.Add(Me.lblPorkDogs)
        Me.Controls.Add(Me.lblBeefDogs)
        Me.Controls.Add(Me.lblDroneDogHeader)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "DroneDogsOrder"
        Me.Text = "Eric Jennings"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDroneDogHeader As System.Windows.Forms.Label
    Friend WithEvents lblBeefDogs As System.Windows.Forms.Label
    Friend WithEvents lblPorkDogs As System.Windows.Forms.Label
    Friend WithEvents lblTurkeyDogs As System.Windows.Forms.Label
    Friend WithEvents txtBeefDogs As System.Windows.Forms.TextBox
    Friend WithEvents txtPorkDogs As System.Windows.Forms.TextBox
    Friend WithEvents txtTurkeyDogs As System.Windows.Forms.TextBox
    Friend WithEvents lblSalesTax As System.Windows.Forms.Label
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesTax As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnCalcOrder As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblSubtotal As Label
End Class
