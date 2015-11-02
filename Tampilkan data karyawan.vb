Imports System.Data.SqlClient

Public Class Tampilkan_data_karyawan
    Private Sub tampilData()
        bukakoneksi()
        sql = "select * from Tb_Karyawan"

        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dt As New DataTable
        For Each dt In ds.Tables
            DataGridView1.DataSource = dt

        Next
        tutupkoneksi()
    End Sub

    Private Sub Tampilkan_data_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()

    End Sub

    Private Sub status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles statusP.SelectedIndexChanged
        If statusP.Text = "MENIKAH" Then
            anak.Enabled = True

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        karyawanbaru.Show()

    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        id.Text = DataGridView1.Item(0, i).Value
        nama.Text = DataGridView1.Item(1, i).Value
        jekel.Text = DataGridView1.Item(2, i).Value
        tgl_lahir.Text = DataGridView1.Item(3, i).Value
        telepon.Text = DataGridView1.Item(4, i).Value
        agama.Text = DataGridView1.Item(5, i).Value
        statusP.Text = DataGridView1.Item(6, i).Value
        anak.Text = DataGridView1.Item(7, i).Value
        alamat.Text = DataGridView1.Item(8, i).Value

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bukakoneksi()
        Dim waktu, status As String
        waktu = Now
        status = "Data Karyawan " & nama.Text & " diubah"
        sql = "update tb_karyawan set Nama = '" & nama.Text & "' ,Jekel ='" & jekel.Text & "',Tgl_Lahir ='" & tgl_lahir.Text & "',Telepon ='" & telepon.Text & "',Agama ='" & agama.Text & "',Stts_Pernikahan  ='" & statusP.Text & "',Jml_Anak  ='" & anak.Text & "',Alamat ='" & alamat.Text & "' where id_karyawan='" & id.Text & "'" &
            "insert into tb_aktivitas values ('" & waktu & "','" & status & "','karyawan')"
        comSQL = New SqlCommand(sql, conn)
        Try
            comSQL.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Waduh, ono sing kleru")

        End Try

        tampilData()

        tutupkoneksi()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        If txtcari.Text <> "" Then
            bukakoneksi()
            sql = "select * from Tb_Karyawan where  ID_Karyawan like '%" & txtcari.Text & "%' or " &
            "Nama  like '%" & txtcari.Text & "%' or " &
          "jekel  like '%" & txtcari.Text & "%' or " &
           " tgl_lahir  like '%" & txtcari.Text & "%' or " &
          "  telepon like '%" & txtcari.Text & "%' or " &
           " agama  like '%" & txtcari.Text & "%' or " &
           " Stts_Pernikahan  like '%" & txtcari.Text & "%' or " &
           " Jml_Anak  like '%" & txtcari.Text & "%' or " &
           " alamat  like '%" & txtcari.Text & "%' or " &
           " Posisi  like '%" & txtcari.Text & "%' or " &
           " Divisi  like '%" & txtcari.Text & "%' or " &
           " Thn_Masuk  like '%" & txtcari.Text & "%' "

            Dim da As New SqlDataAdapter(sql, conn)
            Dim ds As New DataSet
            da.Fill(ds)
            Dim dt As New DataTable
            For Each dt In ds.Tables
                DataGridView1.DataSource = dt

            Next
            tutupkoneksi()
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        bukakoneksi()
        Dim waktu, status As String
        waktu = Now
        status = "Data Karyawan " & nama.Text & " dihapus"
        sql = "delete from tb_karyawan where id_karyawan='" & id.Text & "'" &
            "insert into tb_aktivitas values ('" & waktu & "','" & status & "','karyawan')"
        comSQL = New SqlCommand(sql, conn)
        Try
            comSQL.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Waduh, ono sing kleru")

        End Try

        tampilData()

        tutupkoneksi()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnsemua_Click(sender As Object, e As EventArgs) Handles btnsemua.Click
        tampilData()

    End Sub

    Private Sub Btnlaporank_Click(sender As Object, e As EventArgs) Handles Btnlaporank.Click
        lapdatakaryawan.Show()

    End Sub
End Class