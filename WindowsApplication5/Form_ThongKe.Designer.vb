<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ThongKe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ThongKe))
        Me.dgvThongKe = New System.Windows.Forms.DataGridView()
        Me.btnTheoNgay = New System.Windows.Forms.Button()
        Me.btnTheoThang = New System.Windows.Forms.Button()
        Me.btnTheoSach = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvThongKe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvThongKe
        '
        Me.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThongKe.Location = New System.Drawing.Point(24, 28)
        Me.dgvThongKe.Name = "dgvThongKe"
        Me.dgvThongKe.Size = New System.Drawing.Size(551, 121)
        Me.dgvThongKe.TabIndex = 0
        '
        'btnTheoNgay
        '
        Me.btnTheoNgay.Location = New System.Drawing.Point(53, 166)
        Me.btnTheoNgay.Name = "btnTheoNgay"
        Me.btnTheoNgay.Size = New System.Drawing.Size(96, 30)
        Me.btnTheoNgay.TabIndex = 2
        Me.btnTheoNgay.Text = "Theo Ngày"
        Me.btnTheoNgay.UseVisualStyleBackColor = True
        '
        'btnTheoThang
        '
        Me.btnTheoThang.Location = New System.Drawing.Point(53, 213)
        Me.btnTheoThang.Name = "btnTheoThang"
        Me.btnTheoThang.Size = New System.Drawing.Size(96, 30)
        Me.btnTheoThang.TabIndex = 3
        Me.btnTheoThang.Text = "Theo Tháng"
        Me.btnTheoThang.UseVisualStyleBackColor = True
        '
        'btnTheoSach
        '
        Me.btnTheoSach.Location = New System.Drawing.Point(382, 166)
        Me.btnTheoSach.Name = "btnTheoSach"
        Me.btnTheoSach.Size = New System.Drawing.Size(96, 30)
        Me.btnTheoSach.TabIndex = 4
        Me.btnTheoSach.Text = "Theo Sách"
        Me.btnTheoSach.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(382, 213)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(96, 30)
        Me.btnThoat.TabIndex = 5
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Tổng Số Doanh Thu Theo Ngày Tháng Và Sản Phẩm 💵💵"
        '
        'Form_ThongKe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication5.My.Resources.Resources.istockphoto_1094721986_612x612
        Me.ClientSize = New System.Drawing.Size(598, 345)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnTheoSach)
        Me.Controls.Add(Me.btnTheoThang)
        Me.Controls.Add(Me.btnTheoNgay)
        Me.Controls.Add(Me.dgvThongKe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_ThongKe"
        Me.Text = "Thống Kê Doanh Thu"
        CType(Me.dgvThongKe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvThongKe As DataGridView
    Friend WithEvents btnTheoNgay As Button
    Friend WithEvents btnTheoThang As Button
    Friend WithEvents btnTheoSach As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents Label1 As Label
End Class
