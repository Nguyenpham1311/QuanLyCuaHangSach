Public Class GioiThieu
    Private Sub GioiThieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScaleMode = AutoScaleMode.None
        Me.Size = New Size(800, 500)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog

        ' Tiêu đề Label
        Dim lblTitle As New Label()
        lblTitle.Text = "Giới thiệu về sách"
        lblTitle.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        lblTitle.Location = New Point(20, 20)
        lblTitle.AutoSize = True
        Me.Controls.Add(lblTitle)

        ' TextBox hiển thị nội dung giới thiệu
        Dim txtGioiThieu As New TextBox()
        txtGioiThieu.Multiline = True
        txtGioiThieu.ScrollBars = ScrollBars.Vertical
        txtGioiThieu.Size = New Size(740, 330)
        txtGioiThieu.Location = New Point(20, 60)
        txtGioiThieu.ReadOnly = True
        txtGioiThieu.Font = New Font("Segoe UI", 10)
        txtGioiThieu.Text = "Nếu bạn đang tìm kiếm một cuốn sách:" & vbCrLf &
            "✓ Truyền cảm hứng và tiếp thêm năng lượng sống" & vbCrLf &
            "✓ Mang lại trải nghiệm cuốn hút như xem một bộ phim ngay trong tâm trí" & vbCrLf &
            "✓ Khiến bạn phải suy nghĩ và thay đổi cách nhìn về cuộc sống" & vbCrLf &
            "✓ Không chỉ là một cuốn sách, mà là một người bạn đồng hành" & vbCrLf &
            "✓ Một hành trình cảm xúc dẫn bạn đến những bất ngờ"
        Me.Controls.Add(txtGioiThieu)

        ' Nút Quay Lại
        Dim btnQuayLai As New Button()
        btnQuayLai.Text = "Quay lại Menu"
        btnQuayLai.Size = New Size(120, 35)
        btnQuayLai.Location = New Point(20, 410)
        AddHandler btnQuayLai.Click, AddressOf btnQuayLai_Click
        Me.Controls.Add(btnQuayLai)

        ' Nút Xem Sách
        Dim btnXemSach As New Button()
        btnXemSach.Text = "Xem Sách"
        btnXemSach.Size = New Size(120, 35)
        btnXemSach.Location = New Point(160, 410)
        AddHandler btnXemSach.Click, AddressOf btnXemSach_Click
        Me.Controls.Add(btnXemSach)

        ' Nút Đóng
        Dim btnDong As New Button()
        btnDong.Text = "Đóng"
        btnDong.Size = New Size(120, 35)
        btnDong.Location = New Point(300, 410)
        AddHandler btnDong.Click, AddressOf btnDong_Click
        Me.Controls.Add(btnDong)

        ' Nút Thoát
        Dim btnThoat As New Button()
        btnThoat.Text = "Thoát ứng dụng"
        btnThoat.Size = New Size(120, 35)
        btnThoat.Location = New Point(440, 410)
        AddHandler btnThoat.Click, AddressOf btnThoat_Click
        Me.Controls.Add(btnThoat)
    End Sub

    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs)
        Dim menuForm As New MenuSach()
        menuForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnXemSach_Click(sender As Object, e As EventArgs)
        Dim sachForm As New Form_Sach()
        sachForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
End Class