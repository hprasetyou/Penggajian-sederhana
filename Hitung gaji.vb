Imports System.Data.SqlClient
Public Class Hitung_gaji
    Private Sub htg_gaji_bulan_ini()
        bukakoneksi()
        Dim bulan, tahun As Integer
        Dim waktu, status, thr As String
        waktu = Now
        status = "Gaji bulan ini dihitung"
        thr = ""

        bulan = Month(Now)
        tahun = Year(Now)

        If cbidulfitri.Checked = True Then
            thr = thr & " update tb_penggajian set tunjangan=(tunjangan + (select nilai from tb_lainlain where nama='hari raya')) where id_karyawan in (select id_karyawan from tb_karyawan where agama='ISLAM')  and bulan = '" & bulan & "' and tahun='" & tahun & "'" &
                " insert into tb_aktivitas values ('" & waktu & "','Bulan ini Hari Raya Idul Fitri','penggajian')"

        End If
        If cbnatal.Checked = True Then
            thr = thr & "  update tb_penggajian set tunjangan=(tunjangan + (select nilai from tb_lainlain where nama='hari raya')) where id_karyawan in (select id_karyawan from tb_karyawan where agama='PROTESTAN' or agama='KATHOLIK')  and bulan = '" & bulan & "' and tahun='" & tahun & "'" &
                " insert into tb_aktivitas values ('" & waktu & "','Bulan ini Hari Raya Natal','penggajian')"
        End If
        If cbwaisak.Checked = True Then
            thr = thr & " update tb_penggajian set tunjangan=(tunjangan + (select nilai from tb_lainlain where nama='hari raya')) where id_karyawan in (select id_karyawan from tb_karyawan where agama='BUDHA')  and bulan = '" & bulan & "' and tahun='" & tahun & "'" &
                " insert into tb_aktivitas values ('" & waktu & "','Bulan ini Hari Raya Waisak','penggajian')"

        End If
        If cbnyepi.Checked = True Then
            thr = thr & " update tb_penggajian set tunjangan=(tunjangan + (select nilai from tb_lainlain where nama='hari raya')) where id_karyawan in (select id_karyawan from tb_karyawan where agama='HINDU')  and bulan = '" & bulan & "' and tahun='" & tahun & "'" &
                " insert into tb_aktivitas values ('" & waktu & "','Bulan ini Hari Raya Nyepi','penggajian')"

        End If
        If cbkonghucu.Checked = True Then
            thr = thr & " update tb_penggajian set tunjangan=(tunjangan + (select nilai from tb_lainlain where nama='hari raya')) where id_karyawan in (select id_karyawan from tb_karyawan where agama='KONGHUCHU')  and bulan = '" & bulan & "' and tahun='" & tahun & "'" &
                " insert into tb_aktivitas values ('" & waktu & "','Bulan ini Hari Raya Imlek','penggajian')"
        End If
        



        sql = "INSERT INTO Tb_Penggajian(id_transaksi, id_karyawan, bulan, tahun, gapok, Tunjangan ,Bonus ,Gaji_Lembur ,Potongan ,Pajak ,Total) SELECT CONCAT(" & bulan & "," & tahun & ",ID_KARYAWAN) AS id_transaksi,id_karyawan, '" & bulan & "' AS BULAN,'" & tahun & "' as tahun ,GAJI, 0 as 'Tunjangan' , 0 as 'Bonus' , 0 as 'Gaji_Lembur' , 0 as 'Potongan' , 0 as 'Pajak' , 0 as 'Total'  FROM Tb_Karyawan JOIN TB_POSISI ON Tb_Karyawan.POSISI=tb_posisi.id_posisi" &
              " update Tb_Penggajian set Tunjangan= case when (ID_Karyawan in (select id_karyawan from tb_karyawan where Jml_Anak > 0)) then (select nilai from tb_lainlain where nama='anak') when (ID_Karyawan in (select id_karyawan from tb_karyawan where Jml_Anak = 0)) then '0' else '0' end where bulan = '" & bulan & "' and tahun='" & tahun & "'" &
              " update tb_penggajian set tunjangan=(tunjangan+ (select nilai from tb_lainlain where nama='menikah')) where ID_Karyawan in (select ID_Karyawan from Tb_Karyawan where Stts_Pernikahan = 'menikah') and bulan = '" & bulan & "' and tahun='" & tahun & "'" &
              " update tb_penggajian set bonus= (select nilai from tb_lainlain where nama='teladan') where ID_Karyawan in (select ID_Karyawan from Tb_kinerjaK where Penilaian > 7)  and bulan = '" & bulan & "' and tahun='" & tahun & "'" &
              " update tb_penggajian set tunjangan=(tunjangan+ (select nilai from tb_lainlain where nama='pengalaman')* gapok /100) where ID_Karyawan in (select ID_Karyawan from Tb_Karyawan where " & tahun & "-Thn_Masuk > 2 ) and bulan = '" & bulan & "' and tahun='" & tahun & "'" &
              " update tb_penggajian set potongan=(select nilai from tb_lainlain where nama='bolos') where ID_Karyawan in (select ID_Karyawan from Tb_kinerjaK where Absen between 1 and 3 )   and bulan = '" & bulan & "' and tahun='" & tahun & "'" &
              " update tb_penggajian set potongan=(select nilai from tb_lainlain where nama='bolosparah') where ID_Karyawan in (select ID_Karyawan from Tb_kinerjaK where Absen >3)   and bulan = '" & bulan & "' and tahun='" & tahun & "'" &
              " update tb_penggajian set potongan=(select nilai from tb_lainlain where nama='buruk') where ID_Karyawan in (select ID_Karyawan from Tb_kinerjaK where Penilaian < 6)   and bulan = '" & bulan & "' and tahun='" & tahun & "'" &
              " update tb_penggajian set pajak=(select nilai from tb_lainlain where nama='pajak') * gapok /100 where bulan = " & bulan &
              " update tb_penggajian set Gaji_Lembur= case when (id_karyawan in (select ID_Karyawan from Tb_kinerjaK where Jam_Lembur between 1 and 6 )) then (select nilai from tb_lainlain where nama='lembur1') when (id_karyawan in (select ID_Karyawan from Tb_kinerjaK where Jam_Lembur between 7 and 14 )) then (select nilai from tb_lainlain where nama='lembur2') when (id_karyawan in (select ID_Karyawan from Tb_kinerjaK where Jam_Lembur between 15 and 20 )) then (select nilai from tb_lainlain where nama='lembur3') when (id_karyawan in (select ID_Karyawan from Tb_kinerjaK where Jam_Lembur > 20 )) then (select nilai from tb_lainlain where nama='lembur4') else 0 end  where bulan = 11" &
              " update Tb_Penggajian set Total= ((gapok+Tunjangan+bonus+Gaji_Lembur)-(Potongan+pajak))  where bulan = '" & bulan & "' and tahun='" & tahun & "'" &
              " insert into tb_aktivitas values('" & waktu & "',(select concat('Penghitungan gaji bulan " & bulan & " tahun " & tahun & ",  gaji bulan ini total Rp. ',(select sum(total) from tb_penggajian), ' untuk menggaji karyawan sebanyak ',(select count(total) from tb_penggajian))),'penggajian')" & thr



        comSQL = New SqlCommand(sql, conn)

        Try
            comSQL.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Gaji bulan ini sudah dihitung!" & ex.ToString, vbOKOnly, "Peringatan")
        End Try

        tutupkoneksi()

    End Sub

    Private Sub hapusgaji()
        bukakoneksi()
        Dim bulan, tahun As Integer
        Dim waktu, status As String
        waktu = Now


        status = "Gaji bulan ini direset"

        bulan = Month(Now)
        tahun = Year(Now)

        sql = "delete from tb_penggajian where bulan='" & bulan & "' and tahun='" & tahun & "'" &
            " insert into tb_aktivitas values ('" & waktu & "','" & status & "','penggajian')"

        comSQL = New SqlCommand(sql, conn)

        Try
            comSQL.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Gagal mereset gaji bulan ini " & ex.ToString, vbOKOnly, "Peringatan")
        End Try


        tutupkoneksi()
    End Sub
    Private Sub tampitotalgaji()
        bukakoneksi()
        Dim bulansekarang, tahunsekarang As String
        bulansekarang = Month(Now)
        tahunsekarang = Year(Now)
        sql = "select sum(total) as 'Total gaji' from tb_penggajian where bulan='" & bulansekarang & "' and tahun='" & tahunsekarang & "' "

        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dt As New DataTable
        For Each dt In ds.Tables
            dgtotalgaji.DataSource = dt

        Next
        tutupkoneksi()
    End Sub
    Private Sub tampil_gaji()
        bukakoneksi()
        Dim bulan, tahun, bulansekarang, tahunsekarang As String
        bulansekarang = Month(Now)
        tahunsekarang = Year(Now)
        bulan = ""
        If cbbulan.Text = "Sekarang" Then
            bulan = bulansekarang
        ElseIf cbbulan.Text = "Januari" Then
            bulan = "1"
        ElseIf cbbulan.Text = "Februari" Then
            bulan = "2"
        ElseIf cbbulan.Text = "Maret" Then
            bulan = "3"
        ElseIf cbbulan.Text = "April" Then
            bulan = "4"
        ElseIf cbbulan.Text = "Mei" Then
            bulan = "5"
        ElseIf cbbulan.Text = "Juni" Then
            bulan = "6"
        ElseIf cbbulan.Text = "Juli" Then
            bulan = "7"
        ElseIf cbbulan.Text = "Agustus" Then
            bulan = "8"
        ElseIf cbbulan.Text = "September" Then
            bulan = "9"
        ElseIf cbbulan.Text = "Oktober" Then
            bulan = "10"
        ElseIf cbbulan.Text = "November" Then
            bulan = "11"
        ElseIf cbbulan.Text = "Desember" Then
            bulan = "12"
        ElseIf cbbulan.Text = "" Then
            bulan = bulansekarang
        End If

        If cbtahun.Text = "Sekarang" Or cbtahun.Text = "" Then
            tahun = tahunsekarang
        Else
            tahun = cbtahun.Text

        End If


        sql = "select nama as 'Nama Karyawan', gapok as 'Gaji Pokok', gaji_Lembur as 'Gaji Lembur', Tunjangan, Bonus, Potongan, Pajak, Total from tb_karyawan join Tb_Penggajian on tb_karyawan.id_karyawan=Tb_Penggajian.id_karyawan where bulan='" & bulan & "' and tahun='" & tahun & "'"

        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dt As New DataTable
        For Each dt In ds.Tables
            DataGridView1.DataSource = dt

        Next
        tutupkoneksi()

    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        lblNama.Text = DataGridView1.Item(0, i).Value
        lblGapok.Text = DataGridView1.Item(1, i).Value
        lblgalem.Text = DataGridView1.Item(2, i).Value
        lblTunjangan.Text = DataGridView1.Item(3, i).Value
        lblbonus.Text = DataGridView1.Item(4, i).Value
        lblpotongan.Text = DataGridView1.Item(5, i).Value
        lblpajak.Text = DataGridView1.Item(6, i).Value
        lbltotal.Text = DataGridView1.Item(7, i).Value



    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_hitung_gapok.Click
        htg_gaji_bulan_ini()
        tampil_gaji()
        tampitotalgaji()

    End Sub

    Private Sub Hitung_gaji_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil_gaji()
        tampitotalgaji()


    End Sub

    Private Sub btntampilgaji_Click(sender As Object, e As EventArgs) Handles btntampilgaji.Click
        tampil_gaji()

    End Sub


    Private Sub btnresetgaji_Click(sender As Object, e As EventArgs) Handles btnresetgaji.Click
        hapusgaji()
        tampil_gaji()

    End Sub


    Private Sub Btnlapgaji_Click(sender As Object, e As EventArgs) Handles Btnlapgaji.Click
        lapgaji.Show()

    End Sub
End Class