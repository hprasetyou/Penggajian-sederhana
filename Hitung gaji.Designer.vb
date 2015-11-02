<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hitung_gaji
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
        Me.cbtahun = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblpajak = New System.Windows.Forms.Label()
        Me.lblgalem = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblbonus = New System.Windows.Forms.Label()
        Me.lblpotongan = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTunjangan = New System.Windows.Forms.Label()
        Me.lblGapok = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btntampilgaji = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnresetgaji = New System.Windows.Forms.Button()
        Me.btn_hitung_gapok = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Laporan = New System.Windows.Forms.GroupBox()
        Me.Btnlapgaji = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cbkonghucu = New System.Windows.Forms.CheckBox()
        Me.cbnyepi = New System.Windows.Forms.CheckBox()
        Me.cbwaisak = New System.Windows.Forms.CheckBox()
        Me.cbnatal = New System.Windows.Forms.CheckBox()
        Me.cbidulfitri = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgtotalgaji = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbbulan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Laporan.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgtotalgaji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbtahun
        '
        Me.cbtahun.FormattingEnabled = True
        Me.cbtahun.Items.AddRange(New Object() {"Sekarang", "2014", "2013"})
        Me.cbtahun.Location = New System.Drawing.Point(403, 19)
        Me.cbtahun.Name = "cbtahun"
        Me.cbtahun.Size = New System.Drawing.Size(111, 28)
        Me.cbtahun.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Controls.Add(Me.lblpajak)
        Me.GroupBox3.Controls.Add(Me.lblgalem)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.lbltotal)
        Me.GroupBox3.Controls.Add(Me.lblbonus)
        Me.GroupBox3.Controls.Add(Me.lblpotongan)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lblTunjangan)
        Me.GroupBox3.Controls.Add(Me.lblGapok)
        Me.GroupBox3.Controls.Add(Me.lblNama)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(883, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(395, 408)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'lblpajak
        '
        Me.lblpajak.AutoSize = True
        Me.lblpajak.Location = New System.Drawing.Point(183, 286)
        Me.lblpajak.Name = "lblpajak"
        Me.lblpajak.Size = New System.Drawing.Size(14, 20)
        Me.lblpajak.TabIndex = 15
        Me.lblpajak.Text = "-"
        '
        'lblgalem
        '
        Me.lblgalem.AutoSize = True
        Me.lblgalem.Location = New System.Drawing.Point(183, 142)
        Me.lblgalem.Name = "lblgalem"
        Me.lblgalem.Size = New System.Drawing.Size(14, 20)
        Me.lblgalem.TabIndex = 14
        Me.lblgalem.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Pajak"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Gaji Lembur"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 327)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Potongan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Bonus"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(182, 327)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(14, 20)
        Me.lbltotal.TabIndex = 8
        Me.lbltotal.Text = "-"
        '
        'lblbonus
        '
        Me.lblbonus.AutoSize = True
        Me.lblbonus.Location = New System.Drawing.Point(181, 214)
        Me.lblbonus.Name = "lblbonus"
        Me.lblbonus.Size = New System.Drawing.Size(14, 20)
        Me.lblbonus.TabIndex = 7
        Me.lblbonus.Text = "-"
        '
        'lblpotongan
        '
        Me.lblpotongan.AutoSize = True
        Me.lblpotongan.Location = New System.Drawing.Point(183, 249)
        Me.lblpotongan.Name = "lblpotongan"
        Me.lblpotongan.Size = New System.Drawing.Size(14, 20)
        Me.lblpotongan.TabIndex = 6
        Me.lblpotongan.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tunjangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Gaji Pokok"
        '
        'lblTunjangan
        '
        Me.lblTunjangan.AutoSize = True
        Me.lblTunjangan.Location = New System.Drawing.Point(183, 181)
        Me.lblTunjangan.Name = "lblTunjangan"
        Me.lblTunjangan.Size = New System.Drawing.Size(14, 20)
        Me.lblTunjangan.TabIndex = 3
        Me.lblTunjangan.Text = "-"
        '
        'lblGapok
        '
        Me.lblGapok.AutoSize = True
        Me.lblGapok.Location = New System.Drawing.Point(183, 102)
        Me.lblGapok.Name = "lblGapok"
        Me.lblGapok.Size = New System.Drawing.Size(14, 20)
        Me.lblGapok.TabIndex = 2
        Me.lblGapok.Text = "-"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(183, 62)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(14, 20)
        Me.lblNama.TabIndex = 1
        Me.lblNama.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'btntampilgaji
        '
        Me.btntampilgaji.Location = New System.Drawing.Point(540, 18)
        Me.btntampilgaji.Name = "btntampilgaji"
        Me.btntampilgaji.Size = New System.Drawing.Size(75, 29)
        Me.btntampilgaji.TabIndex = 4
        Me.btntampilgaji.Text = "Tampil"
        Me.btntampilgaji.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(339, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tahun "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnresetgaji)
        Me.GroupBox4.Controls.Add(Me.btn_hitung_gapok)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 522)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(268, 70)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Operasi"
        '
        'btnresetgaji
        '
        Me.btnresetgaji.Location = New System.Drawing.Point(142, 19)
        Me.btnresetgaji.Name = "btnresetgaji"
        Me.btnresetgaji.Size = New System.Drawing.Size(108, 29)
        Me.btnresetgaji.TabIndex = 1
        Me.btnresetgaji.Text = "Atur Ulang"
        Me.btnresetgaji.UseVisualStyleBackColor = True
        '
        'btn_hitung_gapok
        '
        Me.btn_hitung_gapok.Location = New System.Drawing.Point(8, 20)
        Me.btn_hitung_gapok.Name = "btn_hitung_gapok"
        Me.btn_hitung_gapok.Size = New System.Drawing.Size(113, 28)
        Me.btn_hitung_gapok.TabIndex = 0
        Me.btn_hitung_gapok.Text = "Hitung Gaji"
        Me.btn_hitung_gapok.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(846, 449)
        Me.DataGridView1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Laporan)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1284, 608)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'Laporan
        '
        Me.Laporan.Controls.Add(Me.Btnlapgaji)
        Me.Laporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Laporan.Location = New System.Drawing.Point(296, 522)
        Me.Laporan.Name = "Laporan"
        Me.Laporan.Size = New System.Drawing.Size(200, 70)
        Me.Laporan.TabIndex = 2
        Me.Laporan.TabStop = False
        Me.Laporan.Text = "Laporan"
        '
        'Btnlapgaji
        '
        Me.Btnlapgaji.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlapgaji.Location = New System.Drawing.Point(17, 23)
        Me.Btnlapgaji.Name = "Btnlapgaji"
        Me.Btnlapgaji.Size = New System.Drawing.Size(141, 29)
        Me.Btnlapgaji.TabIndex = 0
        Me.Btnlapgaji.Text = "Buat Laporan"
        Me.Btnlapgaji.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cbkonghucu)
        Me.GroupBox6.Controls.Add(Me.cbnyepi)
        Me.GroupBox6.Controls.Add(Me.cbwaisak)
        Me.GroupBox6.Controls.Add(Me.cbnatal)
        Me.GroupBox6.Controls.Add(Me.cbidulfitri)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox6.Location = New System.Drawing.Point(886, 467)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(392, 133)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Hari Raya"
        '
        'cbkonghucu
        '
        Me.cbkonghucu.AutoSize = True
        Me.cbkonghucu.Location = New System.Drawing.Point(253, 30)
        Me.cbkonghucu.Name = "cbkonghucu"
        Me.cbkonghucu.Size = New System.Drawing.Size(133, 24)
        Me.cbkonghucu.TabIndex = 4
        Me.cbkonghucu.Text = "Hari Konghucu"
        Me.cbkonghucu.UseVisualStyleBackColor = True
        '
        'cbnyepi
        '
        Me.cbnyepi.AutoSize = True
        Me.cbnyepi.Location = New System.Drawing.Point(134, 69)
        Me.cbnyepi.Name = "cbnyepi"
        Me.cbnyepi.Size = New System.Drawing.Size(67, 24)
        Me.cbnyepi.TabIndex = 3
        Me.cbnyepi.Text = "Nyepi"
        Me.cbnyepi.UseVisualStyleBackColor = True
        '
        'cbwaisak
        '
        Me.cbwaisak.AutoSize = True
        Me.cbwaisak.Location = New System.Drawing.Point(134, 30)
        Me.cbwaisak.Name = "cbwaisak"
        Me.cbwaisak.Size = New System.Drawing.Size(80, 24)
        Me.cbwaisak.TabIndex = 2
        Me.cbwaisak.Text = "Waisak"
        Me.cbwaisak.UseVisualStyleBackColor = True
        '
        'cbnatal
        '
        Me.cbnatal.AutoSize = True
        Me.cbnatal.Location = New System.Drawing.Point(21, 66)
        Me.cbnatal.Name = "cbnatal"
        Me.cbnatal.Size = New System.Drawing.Size(65, 24)
        Me.cbnatal.TabIndex = 1
        Me.cbnatal.Text = "Natal"
        Me.cbnatal.UseVisualStyleBackColor = True
        '
        'cbidulfitri
        '
        Me.cbidulfitri.AutoSize = True
        Me.cbidulfitri.Location = New System.Drawing.Point(19, 30)
        Me.cbidulfitri.Name = "cbidulfitri"
        Me.cbidulfitri.Size = New System.Drawing.Size(84, 24)
        Me.cbidulfitri.TabIndex = 0
        Me.cbidulfitri.Text = "Idul Fitri"
        Me.cbidulfitri.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgtotalgaji)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(690, 526)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(162, 76)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'dgtotalgaji
        '
        Me.dgtotalgaji.AllowUserToAddRows = False
        Me.dgtotalgaji.AllowUserToDeleteRows = False
        Me.dgtotalgaji.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgtotalgaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtotalgaji.Location = New System.Drawing.Point(12, 15)
        Me.dgtotalgaji.Name = "dgtotalgaji"
        Me.dgtotalgaji.ReadOnly = True
        Me.dgtotalgaji.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgtotalgaji.Size = New System.Drawing.Size(138, 56)
        Me.dgtotalgaji.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btntampilgaji)
        Me.GroupBox5.Controls.Add(Me.cbtahun)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.cbbulan)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(846, 56)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        '
        'cbbulan
        '
        Me.cbbulan.FormattingEnabled = True
        Me.cbbulan.Items.AddRange(New Object() {"Sekarang", "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.cbbulan.Location = New System.Drawing.Point(164, 19)
        Me.cbbulan.Name = "cbbulan"
        Me.cbbulan.Size = New System.Drawing.Size(169, 28)
        Me.cbbulan.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(6, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tampilkan gaji bulan"
        '
        'Hitung_gaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1308, 653)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Hitung_gaji"
        Me.Text = "Hitung_gaji"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Laporan.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgtotalgaji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbtahun As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblpajak As System.Windows.Forms.Label
    Friend WithEvents lblgalem As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lblbonus As System.Windows.Forms.Label
    Friend WithEvents lblpotongan As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTunjangan As System.Windows.Forms.Label
    Friend WithEvents lblGapok As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btntampilgaji As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnresetgaji As System.Windows.Forms.Button
    Friend WithEvents btn_hitung_gapok As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Laporan As System.Windows.Forms.GroupBox
    Friend WithEvents Btnlapgaji As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cbkonghucu As System.Windows.Forms.CheckBox
    Friend WithEvents cbnyepi As System.Windows.Forms.CheckBox
    Friend WithEvents cbwaisak As System.Windows.Forms.CheckBox
    Friend WithEvents cbnatal As System.Windows.Forms.CheckBox
    Friend WithEvents cbidulfitri As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgtotalgaji As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cbbulan As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
