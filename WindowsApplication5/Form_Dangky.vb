Imports System.Data.SqlClient
Public Class Form_Dangky
    Dim Ket_Noi As SqlConnection
    Private Sub Form_Dangky_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ket_Noi = New SqlConnection("Data Source=DESKTOP-MOTCJLK\SQLEXPRESS;Initial Catalog=Sach;Integrated Security=True")

        Ket_Noi.Open()
    End Sub
    Private Sub Btdangky_Click(sender As Object, e As EventArgs) Handles Btdangky.Click
        If TextBox1.Text.Trim() = "" Then
            MsgBox("Tên đăng nhập không được để trống!")
            Exit Sub
        End If

        If TextBox2.Text.Trim() = "" Then
            MsgBox("Mật khẩu không được để trống!")
            Exit Sub
        End If

        If TextBox2.Text.Length < 6 Then
            MsgBox("Mật khẩu phải có ít nhất 6 ký tự!")
            TextBox2.Clear()
            Exit Sub
        End If
        Dim Mk_lnHoa As Boolean = TextBox2.Text.Any(Function(c) Char.IsUpper(c))
        Dim Mk_lnth As Boolean = TextBox2.Text.Any(Function(c) Char.IsLower(c))
        Dim Mk_So As Boolean = TextBox2.Text.Any(Function(c) Char.IsDigit(c))
        Dim Mk_Dacbiet As Boolean = TextBox2.Text.Any(Function(c) Not Char.IsLetterOrDigit(c))

        If Not (Mk_lnHoa And Mk_lnth And Mk_So And Mk_Dacbiet) Then
            MsgBox("Mật khẩu phải có ít nhất 1 kt in hoa, in thường, số, ký tự đặc biệt")
            TextBox2.Clear()
        End If

        Dim SQL_Kiemtra As New SqlDataAdapter("Select * From TaiKhoan Where TenDN=@TenDN", Ket_Noi)
        SQL_Kiemtra.SelectCommand.Parameters.AddWithValue("@TenDN", TextBox1.Text.Trim())
        Dim Db_Check As New DataTable
        SQL_Kiemtra.Fill(Db_Check)
        If Db_Check.Rows.Count > 0 Then
            MsgBox("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!")
            Exit Sub
        End If

        Dim SQL_DangKy As New SqlCommand("INSERT INTO TaiKhoan (TenDN, MatKhau) VALUES (@TenDN,@MatKhau)", Ket_Noi)
        SQL_DangKy.Parameters.AddWithValue("@TenDN", TextBox1.Text.Trim())
        SQL_DangKy.Parameters.AddWithValue("@MatKhau", TextBox2.Text)
        Try
            SQL_DangKy.ExecuteNonQuery()
            MsgBox("Đăng ký thành công!")
            Me.Close()
        Catch ex As Exception
            MsgBox("Có lỗi xảy ra khi đăng ký:" & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class