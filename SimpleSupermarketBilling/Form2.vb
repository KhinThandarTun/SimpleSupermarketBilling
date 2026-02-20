Imports System.Data.SqlClient

Public Class SaleFrm
    Dim totalItems As Integer
    Dim totalSale As Decimal
    Dim saleId As Integer
    Private Sub SaleFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection("Server=DESKTOP-QRMI300\SQLEXPRESS;Initial Catalog=supermarket;Integrated Security=True")

        lstItemName.Visible = False
        lstItemNo.Visible = False

        totalItems = 0
        totalSale = 0.00
        saleId = 0

        txtTotalItems.Text = totalItems
        txtSaleAmount.Text = totalSale
        txtSaleID.Text = saleId

    End Sub
End Class