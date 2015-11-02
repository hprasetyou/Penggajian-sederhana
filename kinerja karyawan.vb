Imports System.Data.SqlClient

Public Class kinerja_karyawan


    Dim bulan, tahun As String



    Private Sub tampildatakinerja()
        bukakoneksi()
        sql = "select tb_kinerjak.ID_Kinerja, Tb_Karyawan.nama , tb_kinerjak.Absen, tb_kinerjak.Jam_Lembur, tb_kinerjak.Penilaian from Tb_Karyawan left join Tb_kinerjaK on Tb_Karyawan.ID_Karyawan=Tb_kinerjaK.ID_Karyawan where bulan='" & Month(Now) & "' and tahun='" & Year(Now) & "'"

        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dt As New DataTable
        For Each dt In ds.Tables
            DataGridView1.DataSource = dt

        Next
        tutupkoneksi()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildatakinerja()
    End Sub

    Private Sub hapus()
        bukakoneksi()
        bulan = Month(Now)
        tahun = Year(Now)

        sql = "delete from Tb_kinerjak where bulan='" & bulan & "' and tahun='" & tahun & "'"
        comSQL = New SqlCommand(sql, conn)
        Try
            comSQL.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        tutupkoneksi()
    End Sub
    Private Sub isi()
        bukakoneksi()

        bulan = Month(Now)
        tahun = Year(Now)
        sql = "insert into Tb_kinerjaK (Id_kinerja, bulan, tahun, ID_Karyawan, Absen ,Jam_Lembur,Penilaian ) select CONCAT('PEN-" & bulan & "-" & tahun & "-',id_karyawan) AS ID_KINERJA, '" & bulan & "','" & tahun & "', ID_Karyawan,'0','0','7'  from Tb_Karyawan"
        comSQL = New SqlCommand(sql, conn)
        Try
            comSQL.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        tutupkoneksi()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        isi()
        tampildatakinerja()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hapus()
        tampildatakinerja()

    End Sub

   

    Private Sub BTNSIMPAN_Click(sender As Object, e As EventArgs) Handles BTNSIMPAN.Click
        bukakoneksi()
        sql = "update tb_kinerjaK set Absen='" & TXTAbsen.Text & "',Jam_Lembur='" & TXTJam_Lembur.Text & "',Penilaian='" & TXTPenilaian.Text & "' from Tb_kinerjak where ID_Kinerja='" & GroupBox1.Text & "'"

        comSQL = New SqlCommand(sql, conn)
        Try
            comSQL.ExecuteNonQuery()
            MsgBox("Simpan")

        Catch ex As Exception
            MsgBox("Waduh, ono sing kleru")

        End Try

        tampildatakinerja()

        tutupkoneksi()
    End Sub

  
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        GroupBox1.Text = DataGridView1.Item(0, i).Value
        LBLPENILAIAN.Text = "Kinerja karyawan id " & DataGridView1.Item(1, i).Value
        TXTAbsen.Text = DataGridView1.Item(2, i).Value
        TXTJam_Lembur.Text = DataGridView1.Item(3, i).Value
        TXTPenilaian.Text = DataGridView1.Item(4, i).Value
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class