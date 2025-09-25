<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Dangnhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Dangnhap))
        Me.Txttendn = New System.Windows.Forms.TextBox()
        Me.Txtmk = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btdangnhap = New System.Windows.Forms.Button()
        Me.Btdangky = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txttendn
        '
        Me.Txttendn.Location = New System.Drawing.Point(215, 44)
        Me.Txttendn.Name = "Txttendn"
        Me.Txttendn.Size = New System.Drawing.Size(159, 20)
        Me.Txttendn.TabIndex = 0
        '
        'Txtmk
        '
        Me.Txtmk.Location = New System.Drawing.Point(215, 88)
        Me.Txtmk.Name = "Txtmk"
        Me.Txtmk.Size = New System.Drawing.Size(159, 20)
        Me.Txtmk.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tên đăng nhập:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mật khẩu:"
        '
        'Btdangnhap
        '
        Me.Btdangnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btdangnhap.Location = New System.Drawing.Point(51, 171)
        Me.Btdangnhap.Name = "Btdangnhap"
        Me.Btdangnhap.Size = New System.Drawing.Size(124, 31)
        Me.Btdangnhap.TabIndex = 4
        Me.Btdangnhap.Text = "Đăng nhập"
        Me.Btdangnhap.UseVisualStyleBackColor = True
        '
        'Btdangky
        '
        Me.Btdangky.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btdangky.Location = New System.Drawing.Point(226, 171)
        Me.Btdangky.Name = "Btdangky"
        Me.Btdangky.Size = New System.Drawing.Size(124, 31)
        Me.Btdangky.TabIndex = 5
        Me.Btdangky.Text = "Đăng ký"
        Me.Btdangky.UseVisualStyleBackColor = True
        '
        'Form_Dangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication5.My.Resources.Resources.Free_vector_000459_bau_troi_nen_cho_video_truyen_hinh
        Me.ClientSize = New System.Drawing.Size(411, 228)
        Me.Controls.Add(Me.Btdangky)
        Me.Controls.Add(Me.Btdangnhap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtmk)
        Me.Controls.Add(Me.Txttendn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Dangnhap"
        Me.Text = "Đăng nhập hệ thống"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txttendn As TextBox
    Friend WithEvents Txtmk As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btdangnhap As Button
    Friend WithEvents Btdangky As Button
End Class
