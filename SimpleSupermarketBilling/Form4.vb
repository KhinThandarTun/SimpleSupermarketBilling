Imports System
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Public Class FileUploadFrm

    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        con = New SqlConnection("Server=DESKTOP-QRMI300\SQLEXPRESS;Initial Catalog=supermarket;Integrated Security=True")
        Dim query As String = "INSERT INTO tblImage (id, name, image) VALUES (@id, @name, @image)"
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        con.Open()
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@id", txtId.Text)
        cmd.Parameters.AddWithValue("@name", txtName.Text)
        cmd.Parameters.AddWithValue("@image", ms.ToArray())
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Image saved successfully!")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        con = New SqlConnection("Server=DESKTOP-QRMI300\SQLEXPRESS;Initial Catalog=supermarket;Integrated Security=True")

        Dim query As String = "SELECT * FROM tblImage WHERE id = @id"
        con.Open()
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@id", txtId.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        txtName.Text = dt.Rows(0)("name").ToString()
        Dim img() As Byte
        img = dt.Rows(0)("image")
        Dim ms As New MemoryStream(img)
        PictureBox1.Image = Image.FromStream(ms)
    End Sub
End Class