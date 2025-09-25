Imports System.Data.SqlClient

Public Class Form_Sach
    Private Ket_Noi As SqlConnection
    Dim viTriHienTai As Integer = 0

    Private Sub Sach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ket_Noi = New SqlConnection("Data Source=DESKTOP-MOTCJLK\SQLEXPRESS;Initial Catalog=Sach;Integrated Security=True")

        Ket_Noi.Open()

        Dim Adapter As New SqlDataAdapter("Select * From SACH", Ket_Noi)
        Dim DataSet As New DataSet()
        Adapter.Fill(DataSet, "SACH")
        Data_DS.DataSource = DataSet.Tables("SACH")
    End Sub

    Private Sub Load_dulieu()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter("Select * From SACH", Ket_Noi)
        da.Fill(dt)
        Data_DS.DataSource = dt
    End Sub

    Private Sub CapNhatDataGridView()
        If Data_DS.Rows.Count > 0 AndAlso viTriHienTai >= 0 AndAlso viTriHienTai < Data_DS.Rows.Count Then
            Data_DS.Rows(viTriHienTai).Selected = True
            Data_DS.CurrentCell = Data_DS.Rows(viTriHienTai).Cells(0)
        End If
    End Sub

    Private Sub BtTHEM_Click(sender As Object, e As EventArgs) Handles BtTHEM.Click
        If TxtMASACH.Text.Trim() = "" Then
            MsgBox("Khóa chính không được để trống", vbYes, "Chú ý...")
            TxtMASACH.Focus()
            Exit Sub
        End If

        Dim SQL_KiemTra As New SqlDataAdapter("SELECT * FROM SACH WHERE MASACH=@MASACH", Ket_Noi)
        SQL_KiemTra.SelectCommand.Parameters.AddWithValue("@MASACH", TxtMASACH.Text.Trim())
        Dim Db_Check As New DataTable
        SQL_KiemTra.Fill(Db_Check)

        If Db_Check.Rows.Count > 0 Then
            MsgBox("Mã sách đã tồn tại!", vbYes, "Nhập lại")
            TxtMASACH.Clear()
            TxtTenSach.Clear()
            TxtTacGia.Clear()
            TxtNamXB.Clear()
            TxtMASACH.Focus()
            Exit Sub
        End If

        Try
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            Dim SQL_DangKy As New SqlCommand("INSERT INTO SACH (MASACH, TenSach, TacGia, NamXuatBan) VALUES (@MASACH, @TenSach, @TacGia, @NamXuatBan)", Ket_Noi)
            SQL_DangKy.Parameters.AddWithValue("@MASACH", TxtMASACH.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@TenSach", TxtTenSach.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@TacGia", TxtTacGia.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@NamXuatBan", TxtNamXB.Text.Trim())
            SQL_DangKy.ExecuteNonQuery()

            MsgBox("Thêm thành công!", vbYes, "Thành công")
            TxtMASACH.Clear()
            TxtTenSach.Clear()
            TxtTacGia.Clear()
            TxtNamXB.Clear()
            TxtMASACH.Focus()
            Load_dulieu()

        Catch ex As SqlException
            MsgBox("Lỗi SQL: " & ex.Message, vbYes, "Lỗi")
        Finally
            Ket_Noi.Close()
        End Try
    End Sub

    Private Sub SUA_Click(sender As Object, e As EventArgs) Handles SUA.Click
        Dim maSach As String = InputBox("Nhập mã sách cần sửa:", "Sửa Thông Tin")
        If maSach = "" Then
            MessageBox.Show("Bạn chưa nhập mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "SELECT * FROM SACH WHERE MASACH = @MASACH"
        Dim command As New SqlCommand(query, Ket_Noi)
        command.Parameters.AddWithValue("@MASACH", maSach)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            TxtMASACH.Text = table.Rows(0)("MASACH").ToString()
            TxtTenSach.Text = table.Rows(0)("TenSach").ToString()
            TxtTacGia.Text = table.Rows(0)("TacGia").ToString()
            TxtNamXB.Text = table.Rows(0)("NamXuatBan").ToString()

            TxtTenSach.Enabled = True
            TxtTacGia.Enabled = True
            TxtNamXB.Enabled = True
            LUU.Enabled = True
        Else
            MessageBox.Show("Không tìm thấy mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LUU_Click(sender As Object, e As EventArgs) Handles LUU.Click
        Try
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            Dim Sql As String = "UPDATE SACH SET TenSach=@TenSach, TacGia=@TacGia, NamXuatBan=@NamXuatBan WHERE MASACH=@MASACH"
            Using Cmd As New SqlCommand(Sql, Ket_Noi)
                Cmd.Parameters.AddWithValue("@MASACH", TxtMASACH.Text)
                Cmd.Parameters.AddWithValue("@TenSach", TxtTenSach.Text)
                Cmd.Parameters.AddWithValue("@TacGia", TxtTacGia.Text)
                Cmd.Parameters.AddWithValue("@NamXuatBan", TxtNamXB.Text)

                Dim result As Integer = Cmd.ExecuteNonQuery()

                TxtMASACH.Clear()
                TxtTenSach.Clear()
                TxtTacGia.Clear()
                TxtNamXB.Clear()
                TxtMASACH.Focus()

                If result > 0 Then
                    MsgBox("Cập nhật thành công!", vbYes, "Thông báo")
                    Load_dulieu()
                Else
                    MsgBox("Không thể lưu!", vbYes, "Lỗi")
                End If
            End Using
            Ket_Noi.Close()
        Catch ex As Exception
            MsgBox("Lỗi SQL: " & ex.Message, vbYes, "Lỗi")
        End Try
    End Sub
End Class
