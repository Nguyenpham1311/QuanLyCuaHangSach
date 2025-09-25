Imports System.Data.SqlClient
Public Class Form_Dangnhap
    Dim Ket_Noi As SqlConnection

    Private Sub Form1_Dangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ket_Noi = New SqlConnection("Data Source=DESKTOP-MOTCJLK\SQLEXPRESS;Initial Catalog=Sach;Integrated Security=True")

        Ket_Noi.Open()
    End Sub

    Private Sub Btdangnhap_Click(sender As Object, e As EventArgs) Handles Btdangnhap.Click
        If Txttendn.Text.Trim() = "" Or Txtmk.Text.Trim() = "" Then
            MsgBox("Bạn chưa nhập đầy đủ thông tin", vbExclamation, "Thông báo")
            Exit Sub
        End If

        Dim Ket_Noi As New SqlConnection("Data Source=DESKTOP-MOTCJLK\SQLEXPRESS;Initial Catalog=Sach;Integrated Security=True")
        Ket_Noi.Open()
        Dim SQL As New SqlDataAdapter("Select * From TaiKhoan Where TenDN=@TenDN AND MatKhau=@MatKhau", Ket_Noi)
        SQL.SelectCommand.Parameters.AddWithValue("@TenDN", Txttendn.Text.Trim())
        SQL.SelectCommand.Parameters.AddWithValue("@MatKhau", Txtmk.Text)
        Dim Db As New DataTable
        SQL.Fill(Db)
        Ket_Noi.Close()

        If Db.Rows.Count > 0 Then
            MsgBox("Đăng nhập thành công")
            Me.Hide()
            Dim fMenu As New MenuSach(Txttendn.Text.Trim())
            fMenu.ShowDialog() ' Chờ MenuSach đóng
            Me.Show()
        Else
            MsgBox("Sai tên đăng nhập hoặc mật khẩu")
        End If
    End Sub

    Private Sub Btdangky_Click(sender As Object, e As EventArgs) Handles Btdangky.Click
        Form_Dangky.Show()
        Me.Hide()
    End Sub
End Class