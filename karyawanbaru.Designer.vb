<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class karyawanbaru
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.agama = New System.Windows.Forms.ComboBox()
        Me.Divisi = New System.Windows.Forms.ComboBox()
        Me.tgl_lahir = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.posisi = New System.Windows.Forms.ComboBox()
        Me.status = New System.Windows.Forms.ComboBox()
        Me.jekel = New System.Windows.Forms.ComboBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.telepon = New System.Windows.Forms.TextBox()
        Me.anak = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(417, 557)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 35)
        Me.Button2.TabIndex = 109
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'agama
        '
        Me.agama.FormattingEnabled = True
        Me.agama.Items.AddRange(New Object() {"ISLAM", "PROTESTAN", "KATHOLIK", "HINDU", "BUDHA", "KONGHUCHU"})
        Me.agama.Location = New System.Drawing.Point(288, 266)
        Me.agama.Name = "agama"
        Me.agama.Size = New System.Drawing.Size(298, 21)
        Me.agama.TabIndex = 108
        '
        'Divisi
        '
        Me.Divisi.FormattingEnabled = True
        Me.Divisi.Location = New System.Drawing.Point(288, 437)
        Me.Divisi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Divisi.Name = "Divisi"
        Me.Divisi.Size = New System.Drawing.Size(298, 21)
        Me.Divisi.TabIndex = 107
        '
        'tgl_lahir
        '
        Me.tgl_lahir.Location = New System.Drawing.Point(288, 181)
        Me.tgl_lahir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tgl_lahir.Name = "tgl_lahir"
        Me.tgl_lahir.Size = New System.Drawing.Size(298, 20)
        Me.tgl_lahir.TabIndex = 106
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(59, 486)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 105
        Me.Label12.Text = "Alamat"
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(288, 486)
        Me.alamat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(298, 20)
        Me.alamat.TabIndex = 104
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(288, 557)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 35)
        Me.Button1.TabIndex = 103
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'posisi
        '
        Me.posisi.FormattingEnabled = True
        Me.posisi.Items.AddRange(New Object() {"CNT", "DRT", "GDG", "MNG", "MRK", "PRD", "SCR", "SVR"})
        Me.posisi.Location = New System.Drawing.Point(288, 392)
        Me.posisi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.posisi.Name = "posisi"
        Me.posisi.Size = New System.Drawing.Size(298, 21)
        Me.posisi.TabIndex = 102
        '
        'status
        '
        Me.status.FormattingEnabled = True
        Me.status.Items.AddRange(New Object() {"MENIKAH", "BLM_MENIKAH"})
        Me.status.Location = New System.Drawing.Point(288, 306)
        Me.status.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(298, 21)
        Me.status.TabIndex = 101
        '
        'jekel
        '
        Me.jekel.FormattingEnabled = True
        Me.jekel.Items.AddRange(New Object() {"PRIA", "WANITA"})
        Me.jekel.Location = New System.Drawing.Point(288, 137)
        Me.jekel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.jekel.Name = "jekel"
        Me.jekel.Size = New System.Drawing.Size(298, 21)
        Me.jekel.TabIndex = 100
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(288, 54)
        Me.id.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(298, 20)
        Me.id.TabIndex = 99
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(288, 95)
        Me.nama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(298, 20)
        Me.nama.TabIndex = 98
        '
        'telepon
        '
        Me.telepon.Location = New System.Drawing.Point(288, 223)
        Me.telepon.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.telepon.Name = "telepon"
        Me.telepon.Size = New System.Drawing.Size(298, 20)
        Me.telepon.TabIndex = 97
        '
        'anak
        '
        Me.anak.Enabled = False
        Me.anak.Location = New System.Drawing.Point(288, 351)
        Me.anak.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.anak.Name = "anak"
        Me.anak.Size = New System.Drawing.Size(298, 20)
        Me.anak.TabIndex = 96
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(60, 397)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "Posisi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(60, 441)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "Divisi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(62, 355)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Jumlah Anak"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 311)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 269)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Agama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 228)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Telepon"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 181)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 141)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Jekel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Id"
        '
        'karyawanbaru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 647)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.agama)
        Me.Controls.Add(Me.Divisi)
        Me.Controls.Add(Me.tgl_lahir)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.posisi)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.jekel)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.telepon)
        Me.Controls.Add(Me.anak)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "karyawanbaru"
        Me.Text = "karyawanbaru"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents agama As System.Windows.Forms.ComboBox
    Friend WithEvents Divisi As System.Windows.Forms.ComboBox
    Friend WithEvents tgl_lahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents alamat As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents posisi As System.Windows.Forms.ComboBox
    Friend WithEvents status As System.Windows.Forms.ComboBox
    Friend WithEvents jekel As System.Windows.Forms.ComboBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents telepon As System.Windows.Forms.TextBox
    Friend WithEvents anak As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
