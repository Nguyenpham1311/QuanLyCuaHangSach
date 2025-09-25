<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuSach
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuSach))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TrangChuSach = New System.Windows.Forms.ToolStripMenuItem()
        Me.GST = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoaDon = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThongKe = New System.Windows.Forms.ToolStripMenuItem()
        Me.THOAT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrangChuSach, Me.GST, Me.HoaDon, Me.ThongKe, Me.THOAT})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(606, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TrangChuSach
        '
        Me.TrangChuSach.Name = "TrangChuSach"
        Me.TrangChuSach.Size = New System.Drawing.Size(102, 20)
        Me.TrangChuSach.Text = "Trang Chủ Sách"
        '
        'GST
        '
        Me.GST.Name = "GST"
        Me.GST.Size = New System.Drawing.Size(101, 20)
        Me.GST.Text = "Giới Thiệu Sách"
        '
        'HoaDon
        '
        Me.HoaDon.Name = "HoaDon"
        Me.HoaDon.Size = New System.Drawing.Size(66, 20)
        Me.HoaDon.Text = "Hóa Đơn"
        '
        'ThongKe
        '
        Me.ThongKe.Name = "ThongKe"
        Me.ThongKe.Size = New System.Drawing.Size(70, 20)
        Me.ThongKe.Text = "Thống Kê"
        '
        'THOAT
        '
        Me.THOAT.Name = "THOAT"
        Me.THOAT.Size = New System.Drawing.Size(50, 20)
        Me.THOAT.Text = "Thoát"
        '
        'MenuSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication5.My.Resources.Resources.Free_vector_000459_bau_troi_nen_cho_video_truyen_hinh
        Me.ClientSize = New System.Drawing.Size(606, 176)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuSach"
        Me.Text = "MenuSach"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TrangChuSach As ToolStripMenuItem
    Friend WithEvents GST As ToolStripMenuItem
    Friend WithEvents HoaDon As ToolStripMenuItem
    Friend WithEvents ThongKe As ToolStripMenuItem
    Friend WithEvents THOAT As ToolStripMenuItem
End Class
