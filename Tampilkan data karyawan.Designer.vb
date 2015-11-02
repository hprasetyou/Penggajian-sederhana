<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tampilkan_data_karyawan
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
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.agama = New System.Windows.Forms.ComboBox()
        Me.tgl_lahir = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.statusP = New System.Windows.Forms.ComboBox()
        Me.jekel = New System.Windows.Forms.ComboBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.telepon = New System.Windows.Forms.TextBox()
        Me.anak = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnsemua = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Btnlaporank = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(126, 16)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(84, 34)
        Me.btnhapus.TabIndex = 3
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(16, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Pencarian :"
        '
        'agama
        '
        Me.agama.FormattingEnabled = True
        Me.agama.Items.AddRange(New Object() {"ISLAM", "PROTESTAN", "KATHOLIK", "HINDU", "BUDHA", "KONGHUCHU"})
        Me.agama.Location = New System.Drawing.Point(569, 97)
        Me.agama.Name = "agama"
        Me.agama.Size = New System.Drawing.Size(200, 28)
        Me.agama.TabIndex = 58
        '
        'tgl_lahir
        '
        Me.tgl_lahir.Location = New System.Drawing.Point(569, 41)
        Me.tgl_lahir.Name = "tgl_lahir"
        Me.tgl_lahir.Size = New System.Drawing.Size(200, 26)
        Me.tgl_lahir.TabIndex = 57
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(37, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 20)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Alamat"
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(188, 95)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(200, 26)
        Me.alamat.TabIndex = 51
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(1109, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 31)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'statusP
        '
        Me.statusP.FormattingEnabled = True
        Me.statusP.Items.AddRange(New Object() {"MENIKAH", "BLM_MENIKAH"})
        Me.statusP.Location = New System.Drawing.Point(992, 44)
        Me.statusP.Name = "statusP"
        Me.statusP.Size = New System.Drawing.Size(200, 28)
        Me.statusP.TabIndex = 48
        '
        'jekel
        '
        Me.jekel.FormattingEnabled = True
        Me.jekel.Items.AddRange(New Object() {"PRIA", "WANITA"})
        Me.jekel.Location = New System.Drawing.Point(188, 122)
        Me.jekel.Name = "jekel"
        Me.jekel.Size = New System.Drawing.Size(200, 28)
        Me.jekel.TabIndex = 47
        '
        'id
        '
        Me.id.Enabled = False
        Me.id.Location = New System.Drawing.Point(188, 41)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(200, 26)
        Me.id.TabIndex = 46
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(188, 68)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(200, 26)
        Me.nama.TabIndex = 45
        '
        'telepon
        '
        Me.telepon.Location = New System.Drawing.Point(570, 68)
        Me.telepon.Name = "telepon"
        Me.telepon.Size = New System.Drawing.Size(200, 26)
        Me.telepon.TabIndex = 43
        '
        'anak
        '
        Me.anak.Enabled = False
        Me.anak.Location = New System.Drawing.Point(992, 73)
        Me.anak.Name = "anak"
        Me.anak.Size = New System.Drawing.Size(200, 26)
        Me.anak.TabIndex = 42
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnsemua)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtcari)
        Me.GroupBox2.Location = New System.Drawing.Point(282, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(501, 60)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'btnsemua
        '
        Me.btnsemua.Location = New System.Drawing.Point(339, 16)
        Me.btnsemua.Name = "btnsemua"
        Me.btnsemua.Size = New System.Drawing.Size(106, 34)
        Me.btnsemua.TabIndex = 10
        Me.btnsemua.Text = "Tampilkan Semua"
        Me.btnsemua.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.Location = New System.Drawing.Point(110, 19)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(211, 26)
        Me.txtcari.TabIndex = 3
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(6, 16)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(94, 34)
        Me.btntambah.TabIndex = 2
        Me.btntambah.Text = "Tambah Data"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(841, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 20)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Jumlah Anak"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(841, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(419, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Agama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(418, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Jekel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Id"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnhapus)
        Me.GroupBox3.Controls.Add(Me.btntambah)
        Me.GroupBox3.Location = New System.Drawing.Point(37, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(226, 60)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.agama)
        Me.GroupBox1.Controls.Add(Me.tgl_lahir)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.alamat)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.statusP)
        Me.GroupBox1.Controls.Add(Me.jekel)
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(Me.nama)
        Me.GroupBox1.Controls.Add(Me.telepon)
        Me.GroupBox1.Controls.Add(Me.anak)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(37, 445)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1234, 173)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ubah Data"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(418, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Telepon"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(1234, 320)
        Me.DataGridView1.TabIndex = 6
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Btnlaporank)
        Me.GroupBox4.Location = New System.Drawing.Point(805, 28)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(153, 60)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        '
        'Btnlaporank
        '
        Me.Btnlaporank.Location = New System.Drawing.Point(29, 16)
        Me.Btnlaporank.Name = "Btnlaporank"
        Me.Btnlaporank.Size = New System.Drawing.Size(102, 34)
        Me.Btnlaporank.TabIndex = 0
        Me.Btnlaporank.Text = "Laporan"
        Me.Btnlaporank.UseVisualStyleBackColor = True
        '
        'Tampilkan_data_karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1308, 646)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Tampilkan_data_karyawan"
        Me.Text = "Tampilkan_data_karyawan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents agama As System.Windows.Forms.ComboBox
    Friend WithEvents tgl_lahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents alamat As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents statusP As System.Windows.Forms.ComboBox
    Friend WithEvents jekel As System.Windows.Forms.ComboBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents telepon As System.Windows.Forms.TextBox
    Friend WithEvents anak As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnsemua As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Btnlaporank As System.Windows.Forms.Button
End Class
