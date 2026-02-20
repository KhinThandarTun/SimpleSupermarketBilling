<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaleFrm
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
        Me.lblItemNumber = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblItemQty = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.lblBarCode = New System.Windows.Forms.Label()
        Me.txtItemNumber = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.txtBarCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblSaleId = New System.Windows.Forms.Label()
        Me.SaleGrid = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_SaleID = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSale = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lstItemName = New System.Windows.Forms.ListBox()
        Me.lstItemNo = New System.Windows.Forms.ListBox()
        Me.txtTotalItems = New System.Windows.Forms.TextBox()
        Me.txtSaleAmount = New System.Windows.Forms.TextBox()
        Me.txtSaleID = New System.Windows.Forms.TextBox()
        CType(Me.SaleGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblItemNumber
        '
        Me.lblItemNumber.AutoSize = True
        Me.lblItemNumber.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemNumber.Location = New System.Drawing.Point(53, 118)
        Me.lblItemNumber.Name = "lblItemNumber"
        Me.lblItemNumber.Size = New System.Drawing.Size(107, 19)
        Me.lblItemNumber.TabIndex = 0
        Me.lblItemNumber.Text = "Item Number"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(53, 146)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(85, 19)
        Me.lblItemName.TabIndex = 1
        Me.lblItemName.Text = "ItemName"
        '
        'lblItemQty
        '
        Me.lblItemQty.AutoSize = True
        Me.lblItemQty.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemQty.Location = New System.Drawing.Point(53, 171)
        Me.lblItemQty.Name = "lblItemQty"
        Me.lblItemQty.Size = New System.Drawing.Size(112, 19)
        Me.lblItemQty.TabIndex = 2
        Me.lblItemQty.Text = "Item Quantity"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(53, 202)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(88, 19)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "Item Price"
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.Location = New System.Drawing.Point(53, 232)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(94, 19)
        Me.lblGrade.TabIndex = 4
        Me.lblGrade.Text = "Item Grade"
        '
        'lblBarCode
        '
        Me.lblBarCode.AutoSize = True
        Me.lblBarCode.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarCode.Location = New System.Drawing.Point(53, 260)
        Me.lblBarCode.Name = "lblBarCode"
        Me.lblBarCode.Size = New System.Drawing.Size(117, 19)
        Me.lblBarCode.TabIndex = 5
        Me.lblBarCode.Text = "Item Bar Code"
        '
        'txtItemNumber
        '
        Me.txtItemNumber.BackColor = System.Drawing.SystemColors.Info
        Me.txtItemNumber.Location = New System.Drawing.Point(221, 117)
        Me.txtItemNumber.Name = "txtItemNumber"
        Me.txtItemNumber.Size = New System.Drawing.Size(191, 22)
        Me.txtItemNumber.TabIndex = 6
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.SystemColors.Info
        Me.txtItemName.Location = New System.Drawing.Point(221, 145)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(191, 22)
        Me.txtItemName.TabIndex = 7
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.SystemColors.Info
        Me.txtQty.Location = New System.Drawing.Point(221, 173)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(191, 22)
        Me.txtQty.TabIndex = 8
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.SystemColors.Info
        Me.txtPrice.Location = New System.Drawing.Point(221, 201)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(191, 22)
        Me.txtPrice.TabIndex = 9
        '
        'txtGrade
        '
        Me.txtGrade.BackColor = System.Drawing.SystemColors.Info
        Me.txtGrade.Location = New System.Drawing.Point(221, 229)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(191, 22)
        Me.txtGrade.TabIndex = 10
        '
        'txtBarCode
        '
        Me.txtBarCode.BackColor = System.Drawing.SystemColors.Info
        Me.txtBarCode.Location = New System.Drawing.Point(221, 257)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(191, 22)
        Me.txtBarCode.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(288, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 22)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Super Market Sale Window"
        '
        'lblTotalItems
        '
        Me.lblTotalItems.AutoSize = True
        Me.lblTotalItems.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalItems.Location = New System.Drawing.Point(921, 118)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(91, 19)
        Me.lblTotalItems.TabIndex = 13
        Me.lblTotalItems.Text = "Total Items"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(921, 160)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(142, 19)
        Me.lblTotalAmount.TabIndex = 14
        Me.lblTotalAmount.Text = "Total Sale Amount"
        '
        'lblSaleId
        '
        Me.lblSaleId.AutoSize = True
        Me.lblSaleId.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaleId.Location = New System.Drawing.Point(930, 201)
        Me.lblSaleId.Name = "lblSaleId"
        Me.lblSaleId.Size = New System.Drawing.Size(62, 19)
        Me.lblSaleId.TabIndex = 15
        Me.lblSaleId.Text = "Sale ID"
        '
        'SaleGrid
        '
        Me.SaleGrid.AllowUserToAddRows = False
        Me.SaleGrid.AllowUserToDeleteRows = False
        Me.SaleGrid.AllowUserToResizeColumns = False
        Me.SaleGrid.AllowUserToResizeRows = False
        Me.SaleGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.SaleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SaleGrid.Location = New System.Drawing.Point(12, 330)
        Me.SaleGrid.Name = "SaleGrid"
        Me.SaleGrid.ReadOnly = True
        Me.SaleGrid.RowHeadersWidth = 51
        Me.SaleGrid.RowTemplate.Height = 24
        Me.SaleGrid.Size = New System.Drawing.Size(1329, 404)
        Me.SaleGrid.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Select Sale ID"
        '
        'CB_SaleID
        '
        Me.CB_SaleID.BackColor = System.Drawing.Color.LightGray
        Me.CB_SaleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_SaleID.FormattingEnabled = True
        Me.CB_SaleID.Location = New System.Drawing.Point(221, 84)
        Me.CB_SaleID.Name = "CB_SaleID"
        Me.CB_SaleID.Size = New System.Drawing.Size(191, 23)
        Me.CB_SaleID.TabIndex = 18
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(422, 284)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(113, 33)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add Entry"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.Location = New System.Drawing.Point(561, 284)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(119, 33)
        Me.btnCheckOut.TabIndex = 20
        Me.btnCheckOut.Text = "CheckOut"
        Me.btnCheckOut.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(703, 284)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(131, 33)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "Clear Entry"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSale
        '
        Me.btnSale.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSale.Location = New System.Drawing.Point(872, 285)
        Me.btnSale.Name = "btnSale"
        Me.btnSale.Size = New System.Drawing.Size(130, 32)
        Me.btnSale.TabIndex = 22
        Me.btnSale.Text = "New Sale"
        Me.btnSale.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1032, 284)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(113, 33)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lstItemName
        '
        Me.lstItemName.FormattingEnabled = True
        Me.lstItemName.ItemHeight = 15
        Me.lstItemName.Location = New System.Drawing.Point(317, 96)
        Me.lstItemName.Name = "lstItemName"
        Me.lstItemName.Size = New System.Drawing.Size(224, 94)
        Me.lstItemName.TabIndex = 24
        '
        'lstItemNo
        '
        Me.lstItemNo.FormattingEnabled = True
        Me.lstItemNo.ItemHeight = 15
        Me.lstItemNo.Location = New System.Drawing.Point(317, 133)
        Me.lstItemNo.Name = "lstItemNo"
        Me.lstItemNo.Size = New System.Drawing.Size(224, 94)
        Me.lstItemNo.TabIndex = 25
        '
        'txtTotalItems
        '
        Me.txtTotalItems.Location = New System.Drawing.Point(1097, 114)
        Me.txtTotalItems.Name = "txtTotalItems"
        Me.txtTotalItems.Size = New System.Drawing.Size(198, 22)
        Me.txtTotalItems.TabIndex = 26
        '
        'txtSaleAmount
        '
        Me.txtSaleAmount.Location = New System.Drawing.Point(1097, 157)
        Me.txtSaleAmount.Name = "txtSaleAmount"
        Me.txtSaleAmount.Size = New System.Drawing.Size(198, 22)
        Me.txtSaleAmount.TabIndex = 27
        '
        'txtSaleID
        '
        Me.txtSaleID.Location = New System.Drawing.Point(1097, 198)
        Me.txtSaleID.Name = "txtSaleID"
        Me.txtSaleID.Size = New System.Drawing.Size(198, 22)
        Me.txtSaleID.TabIndex = 28
        '
        'SaleFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1353, 757)
        Me.Controls.Add(Me.txtSaleID)
        Me.Controls.Add(Me.txtSaleAmount)
        Me.Controls.Add(Me.txtTotalItems)
        Me.Controls.Add(Me.lstItemNo)
        Me.Controls.Add(Me.lstItemName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSale)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCheckOut)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.CB_SaleID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SaleGrid)
        Me.Controls.Add(Me.lblSaleId)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.lblTotalItems)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBarCode)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.txtItemNumber)
        Me.Controls.Add(Me.lblBarCode)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblItemQty)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.lblItemNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "SaleFrm"
        Me.Text = "Billing Window"
        CType(Me.SaleGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblItemNumber As Label
    Friend WithEvents lblItemName As Label
    Friend WithEvents lblItemQty As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblGrade As Label
    Friend WithEvents lblBarCode As Label
    Friend WithEvents txtItemNumber As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents txtBarCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalItems As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblSaleId As Label
    Friend WithEvents SaleGrid As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents CB_SaleID As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSale As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lstItemName As ListBox
    Friend WithEvents lstItemNo As ListBox
    Friend WithEvents txtTotalItems As TextBox
    Friend WithEvents txtSaleAmount As TextBox
    Friend WithEvents txtSaleID As TextBox
End Class
