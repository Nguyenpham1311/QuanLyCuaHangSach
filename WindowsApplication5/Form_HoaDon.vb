Imports System.Data.SqlClient

Public Class Form_HoaDon
    Private KetNoi As SqlConnection

    Private Sub Form_HoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Quản Lý Hóa Đơn"
        Me.Size = New Size(900, 500)

        ' ✅ Kết nối CSDL
        KetNoi = New SqlConnection("Data Source=DESKTOP-MOTCJLK\SQLEXPRESS;Initial Catalog=Sach;Integrated Security=True")

        LoadHoaDon()
    End Sub

    ' ✅ Hàm load dữ liệu từ bảng HOADON
    Private Sub LoadHoaDon()
        Try
            If KetNoi.State = ConnectionState.Closed Then KetNoi.Open()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter("SELECT * FROM HOADON", KetNoi)
            da.Fill(dt)
            dgvHoaDon.DataSource = dt
        Catch ex As Exception
            MsgBox("Lỗi tải dữ liệu: " & ex.Message)
        Finally
            KetNoi.Close()
        End Try
    End Sub

    ' ✅ Thêm hóa đơn (đã sửa hoàn chỉnh)
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            ' Kiểm tra dữ liệu trống
            If txtMaHD.Text.Trim() = "" Or txtTenKH.Text.Trim() = "" Or txtTenSach.Text.Trim() = "" Or txtSoLuong.Text.Trim() = "" Or txtDonGia.Text.Trim() = "" Then
                MsgBox("⚠️ Vui lòng nhập đầy đủ thông tin trước khi thêm!", vbExclamation, "Thiếu dữ liệu")
                Exit Sub
            End If

            ' Kiểm tra kiểu dữ liệu số lượng và đơn giá
            Dim soLuong As Integer
            Dim donGia As Decimal

            If Not Integer.TryParse(txtSoLuong.Text.Trim(), soLuong) Then
                MsgBox("⚠️ Số lượng phải là số nguyên!", vbExclamation, "Lỗi nhập liệu")
                Exit Sub
            End If

            If Not Decimal.TryParse(txtDonGia.Text.Trim(), donGia) Then
                MsgBox("⚠️ Đơn giá phải là số!", vbExclamation, "Lỗi nhập liệu")
                Exit Sub
            End If

            ' Thực hiện thêm dữ liệu
            If KetNoi.State = ConnectionState.Closed Then KetNoi.Open()

            Dim sql As String = "INSERT INTO HOADON (MaHD, NgayLap, TenKH, TenSach, SoLuong, DonGia) 
                                 VALUES (@MaHD, @NgayLap, @TenKH, @TenSach, @SoLuong, @DonGia)"

            Using cmd As New SqlCommand(sql, KetNoi)
                cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text.Trim())
                cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value)
                cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text.Trim())
                cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text.Trim())
                cmd.Parameters.AddWithValue("@SoLuong", soLuong)
                cmd.Parameters.AddWithValue("@DonGia", donGia)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("✅ Thêm hóa đơn thành công!", vbInformation, "Thông báo")
            LoadHoaDon()

        Catch ex As Exception
            MsgBox("Lỗi thêm: " & ex.Message)
        Finally
            KetNoi.Close()
        End Try
    End Sub

    ' ✅ Sửa hóa đơn (đã sửa hoàn chỉnh)
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Try
            If txtMaHD.Text.Trim() = "" Then
                MsgBox("⚠️ Vui lòng nhập Mã hóa đơn cần sửa!", vbExclamation, "Thiếu dữ liệu")
                Exit Sub
            End If

            ' Kiểm tra kiểu dữ liệu số lượng và đơn giá
            Dim soLuong As Integer
            Dim donGia As Decimal

            If Not Integer.TryParse(txtSoLuong.Text.Trim(), soLuong) Then
                MsgBox("⚠️ Số lượng phải là số nguyên!", vbExclamation, "Lỗi nhập liệu")
                Exit Sub
            End If

            If Not Decimal.TryParse(txtDonGia.Text.Trim(), donGia) Then
                MsgBox("⚠️ Đơn giá phải là số!", vbExclamation, "Lỗi nhập liệu")
                Exit Sub
            End If

            ' Thực hiện cập nhật dữ liệu
            If KetNoi.State = ConnectionState.Closed Then KetNoi.Open()

            Dim sql As String = "UPDATE HOADON SET NgayLap=@NgayLap, TenKH=@TenKH, TenSach=@TenSach, SoLuong=@SoLuong, DonGia=@DonGia WHERE MaHD=@MaHD"

            Using cmd As New SqlCommand(sql, KetNoi)
                cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text.Trim())
                cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value)
                cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text.Trim())
                cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text.Trim())
                cmd.Parameters.AddWithValue("@SoLuong", soLuong)
                cmd.Parameters.AddWithValue("@DonGia", donGia)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("✅ Sửa hóa đơn thành công!", vbInformation, "Thông báo")
            LoadHoaDon()

        Catch ex As Exception
            MsgBox("Lỗi sửa: " & ex.Message)
        Finally
            KetNoi.Close()
        End Try
    End Sub

    ' ✅ Xóa hóa đơn
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Try
            If KetNoi.State = ConnectionState.Closed Then KetNoi.Open()

            Dim sql As String = "DELETE FROM HOADON WHERE MaHD=@MaHD"

            Using cmd As New SqlCommand(sql, KetNoi)
                cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text.Trim())
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("✅ Xóa hóa đơn thành công!", vbInformation, "Thông báo")
            LoadHoaDon()

        Catch ex As Exception
            MsgBox("Lỗi xóa: " & ex.Message)
        Finally
            KetNoi.Close()
        End Try
    End Sub

    ' ✅ Thoát
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    ' ✅ Khi click vào 1 dòng trong DataGridView => đổ dữ liệu vào textbox
    Private Sub dgvHoaDon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHoaDon.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvHoaDon.Rows(e.RowIndex)
            txtMaHD.Text = row.Cells("MaHD").Value.ToString()
            dtpNgayLap.Value = Convert.ToDateTime(row.Cells("NgayLap").Value)
            txtTenKH.Text = row.Cells("TenKH").Value.ToString()
            txtTenSach.Text = row.Cells("TenSach").Value.ToString()
            txtSoLuong.Text = row.Cells("SoLuong").Value.ToString()
            txtDonGia.Text = row.Cells("DonGia").Value.ToString()
        End If
    End Sub
End Class
