Imports System.Data.SqlClient

Public Class SaleFrm
    Dim totalItems As Integer
    Dim totalSale As Decimal
    Dim saleId As Integer

    Dim conn As SqlConnection
    Dim cmd As SqlCommand

    Private Sub SaleFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Server=DESKTOP-QRMI300\SQLEXPRESS;Initial Catalog=supermarket;Integrated Security=True")

        lstItemName.Visible = False
        lstItemNo.Visible = False

        totalItems = 0
        totalSale = 0.00
        saleId = 0

        txtTotalItems.Text = totalItems
        txtSaleAmount.Text = Format(totalSale.ToString, "Standard")
        txtSaleID.Text = saleId

        If (GlobalVariables.FormType = "SaleForm") Then
            lblSaleId.Visible = False
            CB_SaleID.Visible = False

            GENERATESALE_ID()

        ElseIf (GlobalVariables.FormType = "UpdateSaleForm") Then
            lblSaleId.Visible = False
            CB_SaleID.Visible = False
            ' Load existing sale IDs into the combo box for selection
        End If
    End Sub

    Private Sub GENERATESALE_ID()
        Dim random As New Random()
        Dim randomNumber As Integer = random.Next(100, 999)
        txtSaleID.Text = saleId.ToString() & randomNumber.ToString()
        MessageBox.Show(randomNumber.ToString())
    End Sub
End Class

