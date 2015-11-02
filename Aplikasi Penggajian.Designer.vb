<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aplikasi_Penggajian
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbdata = New System.Windows.Forms.ToolStripButton()
        Me.tsbpenilaian = New System.Windows.Forms.ToolStripButton()
        Me.tspenggajian = New System.Windows.Forms.ToolStripButton()
        Me.tskebijakan = New System.Windows.Forms.ToolStripButton()
        Me.tsaktivitas = New System.Windows.Forms.ToolStripButton()
        Me.Tskeluar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbdata, Me.ToolStripSeparator4, Me.tsbpenilaian, Me.ToolStripSeparator3, Me.tspenggajian, Me.tskebijakan, Me.ToolStripSeparator1, Me.tsaktivitas, Me.ToolStripSeparator2, Me.Tskeluar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(882, 29)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'tsbdata
        '
        Me.tsbdata.Image = Global.penghitungan_gaji.My.Resources.Resources.user_info
        Me.tsbdata.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbdata.Name = "tsbdata"
        Me.tsbdata.Size = New System.Drawing.Size(141, 26)
        Me.tsbdata.Text = "Data Karyawan"
        '
        'tsbpenilaian
        '
        Me.tsbpenilaian.Image = Global.penghitungan_gaji.My.Resources.Resources.alluser
        Me.tsbpenilaian.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbpenilaian.Name = "tsbpenilaian"
        Me.tsbpenilaian.Size = New System.Drawing.Size(156, 26)
        Me.tsbpenilaian.Text = "Kinerja Karyawan"
        '
        'tspenggajian
        '
        Me.tspenggajian.Image = Global.penghitungan_gaji.My.Resources.Resources.paper101
        Me.tspenggajian.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspenggajian.Name = "tspenggajian"
        Me.tspenggajian.Size = New System.Drawing.Size(108, 26)
        Me.tspenggajian.Text = "Penggajian"
        '
        'tskebijakan
        '
        Me.tskebijakan.Image = Global.penghitungan_gaji.My.Resources.Resources.calculator37
        Me.tskebijakan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tskebijakan.Name = "tskebijakan"
        Me.tskebijakan.Size = New System.Drawing.Size(100, 26)
        Me.tskebijakan.Text = "Kebijakan"
        '
        'tsaktivitas
        '
        Me.tsaktivitas.Image = Global.penghitungan_gaji.My.Resources.Resources.file_manager
        Me.tsaktivitas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsaktivitas.Name = "tsaktivitas"
        Me.tsaktivitas.Size = New System.Drawing.Size(92, 26)
        Me.tsaktivitas.Text = "Aktivitas"
        '
        'Tskeluar
        '
        Me.Tskeluar.Image = Global.penghitungan_gaji.My.Resources.Resources.delete
        Me.Tskeluar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tskeluar.Name = "Tskeluar"
        Me.Tskeluar.Size = New System.Drawing.Size(76, 26)
        Me.Tskeluar.Text = "Keluar"
        '
        'Aplikasi_Penggajian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 526)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Aplikasi_Penggajian"
        Me.Text = "Aplikasi_Penggajian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbdata As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbpenilaian As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tspenggajian As System.Windows.Forms.ToolStripButton
    Friend WithEvents tskebijakan As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsaktivitas As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tskeluar As System.Windows.Forms.ToolStripButton
End Class
