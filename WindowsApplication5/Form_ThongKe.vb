Imports System.Data.SqlClient

Public Class Form_ThongKe
    Dim KetNoi As New SqlConnection("Data Source=DESKTOP-MOTCJLK\SQLEXPRESS;Initial Catalog=Sach;Integrated Security=True")

    Private Sub Form_ThongKe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mặc định load thống kê theo ngày
        LoadTheoNgay()
    End Sub

    Private Sub LoadTheoNgay()
        Dim dt As New DataTable
        Dim sql As String = "SELECT NgayLap, SUM(ThanhTien) AS TongDoanhThu FROM HOADON GROUP BY NgayLap ORDER BY NgayLap"
        Dim da As New SqlDataAdapter(sql, KetNoi)
        da.Fill(dt)
        dgvThongKe.DataSource = dt
    End Sub

    Private Sub LoadTheoThang()
        Dim dt As New DataTable
        Dim sql As String = "SELECT YEAR(NgayLap) AS Nam, MONTH(NgayLap) AS Thang, SUM(ThanhTien) AS TongDoanhThu " &
                            "FROM HOADON GROUP BY YEAR(NgayLap), MONTH(NgayLap) ORDER BY Nam, Thang"
        Dim da As New SqlDataAdapter(sql, KetNoi)
        da.Fill(dt)
        dgvThongKe.DataSource = dt
    End Sub

    Private Sub LoadTheoSach()
        Dim dt As New DataTable
        Dim sql As String = "SELECT S.TenSach, SUM(H.SoLuong * H.DonGia) AS TongDoanhThu " &
                            "FROM HOADON H JOIN SACH S ON H.MaSach = S.MaSach " &
                            "GROUP BY S.TenSach ORDER BY TongDoanhThu DESC"
        Dim da As New SqlDataAdapter(sql, KetNoi)
        da.Fill(dt)
        dgvThongKe.DataSource = dt
    End Sub

    ' Sự kiện các nút
    Private Sub btnTheoNgay_Click(sender As Object, e As EventArgs) Handles btnTheoNgay.Click
        LoadTheoNgay()
    End Sub

    Private Sub btnTheoThang_Click(sender As Object, e As EventArgs) Handles btnTheoThang.Click
        LoadTheoThang()
    End Sub

    Private Sub btnTheoSach_Click(sender As Object, e As EventArgs) Handles btnTheoSach.Click
        LoadTheoSach()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class
