Public Class MenuSach
    Private tenDangNhap As String

    ' Constructor nhận tham số
    Public Sub New(Optional ByVal TenDN As String = "")
        InitializeComponent()
        tenDangNhap = TenDN
    End Sub

    Private Sub MenuSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Menu Quản Lý Sách"
        ' Nếu có Label/TextBox tên TenDN thì hiển thị tên đăng nhập
        If tenDangNhap <> "" Then
            If Me.Controls.ContainsKey("TenDN") Then
                Me.Controls("TenDN").Text = tenDangNhap
            End If
        End If
    End Sub

    ' Trang Chủ Sách
    Private Sub TrangChuSach_Click(sender As Object, e As EventArgs) Handles TrangChuSach.Click
        Dim f As New Form_Sach()
        f.Show()
    End Sub

    ' Giới Thiệu Sách
    Private Sub GST_Click(sender As Object, e As EventArgs) Handles GST.Click
        Dim f As New GioiThieu()
        f.Show()
    End Sub

    ' Hóa Đơn
    Private Sub HoaDon_Click(sender As Object, e As EventArgs) Handles HoaDon.Click
        Dim f As New Form_HoaDon()
        f.Show()
    End Sub

    ' Thống Kê
    Private Sub ThongKe_Click(sender As Object, e As EventArgs) Handles ThongKe.Click
        Dim f As New Form_ThongKe()
        f.Show()
    End Sub

    ' Thoát
    Private Sub THOAT_Click(sender As Object, e As EventArgs) Handles THOAT.Click
        If MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
