Public Class MainFrm
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBL_VAL_TIME.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub UpdateSaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateSaleToolStripMenuItem.Click

    End Sub

    Private Sub SaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaleToolStripMenuItem.Click
        Dim SaleFrm1 As New SaleFrm
        SaleFrm1.MdiParent = Me
        SaleFrm1.Show()
    End Sub
End Class
