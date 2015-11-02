Imports System.Data.SqlClient
Public Class Kebijakan

    Private Sub tampilDataGapok()
        bukakoneksi()
        sql = "select id_posisi as ID, nm_posisi as 'Nama Posisi', gaji as Gaji from Tb_posisi"
        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dt As New DataTable
        For Each dt In ds.Tables
            DataGridView1.DataSource = dt

        Next
        tutupkoneksi()
    End Sub
    Private Sub tampilDataGaLem()
        bukakoneksi()
        sql = "select nama as 'ID Lembur', nilai as 'Nilai', Keterangan from tb_lainlain where jenis='lembur'"

        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dt As New DataTable
        For Each dt In ds.Tables
            Dggalem.DataSource = dt

        Next
        tutupkoneksi()
    End Sub
    Private Sub tampilDataTunjangan()
        bukakoneksi()
        sql = "select id_lainlain as 'ID Tunjangan', nama as 'Nama Tunjangan', nilai as 'Nilai', Keterangan from tb_lainlain where jenis='tunjangan'"

        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dt As New DataTable
        For Each dt In ds.Tables
            DGTunjangan.DataSource = dt

        Next
        tutupkoneksi()
    End Sub
    Private Sub tampilDataBonus()
        bukakoneksi()
        sql = "select nilai as 'Bonus saat ini' from tb_lainlain where jenis='bonus'"

        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dt As New DataTable
        For Each dt In ds.Tables
            dgbonus.DataSource = dt

        Next
        tutupkoneksi()
    End Sub
    Private Sub tampildatapotongan()
        bukakoneksi()
        sql = "select id_lainlain as 'ID Potongan', nama as 'Nama Potongan', nilai as 'Nilai', Keterangan from tb_lainlain where jenis='potongan'"

        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dt As New DataTable
        For Each dt In ds.Tables
            Dgpotongan.DataSource = dt

        Next
        tutupkoneksi()
    End Sub

    Private Sub ubahdata()
        bukakoneksi()
        Dim waktu, status As String
        waktu = Now
        status = ""
        If TXTID.Text = "" Then
            MsgBox("Tidak ada data yang dipilih", vbOKOnly, "Peringatan!")
            GoTo lanjut
        End If
        If TXTGAJIBARU.Text = "" Then
            MsgBox("Lengkapi data", vbOKOnly, "Peringatan!")
            GoTo lanjut
        End If


        sql = "Update tb_posisi set gaji='" & TXTGAJIBARU.Text & "' where id_posisi='" & TXTID.Text & "'"
        comSQL = New SqlCommand(sql, conn)
        Try
            comSQL.ExecuteNonQuery()
            If TXTGAJIBARU.Text > TXTGAJILAMA.Text Then
                status = "menaikkan gaji karyawan posisi " & TXTPOSISI.Text & " sebesar " & TXTGAJIBARU.Text - TXTGAJILAMA.Text & ", gaji sekarang adalah " & TXTGAJIBARU.Text
            ElseIf TXTGAJIBARU.Text < TXTGAJILAMA.Text Then
                status = "menurunkan gaji karyawan posisi " & TXTPOSISI.Text & " sebesar " & TXTGAJILAMA.Text - TXTGAJIBARU.Text & ", gaji sekarang adalah " & TXTGAJIBARU.Text
            End If

            txtketerangan.Text = "Berhasil " & status
            sql = "insert into tb_aktivitas values('" & waktu & "','" & status & "','kebijakan')"
            comSQL = New SqlCommand(sql, conn)
            Try
                comSQL.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Waduh, ono sing kleru" & ex.ToString)
            End Try
        Catch ex As Exception
            MsgBox("Waduh, ono sing kleru")
        End Try
lanjut:
        tutupkoneksi()
    End Sub
    Private Sub ubahtunjangan()
        bukakoneksi()
        Dim waktu, status As String
        waktu = Now
        status = "Perubahan pada nilai tunjangan " & NM_Tunjangan.Text & " dari " & TxtTunjLama.Text & " menjadi " & txtTunjBaru.Text

        sql = "update tb_lainlain set nilai='" & txtTunjBaru.Text & "' where id_lainlain='" & gbtunj.Text & "'" &
            "insert into tb_aktivitas values ('" & waktu & "','" & status & "','kebijakan')"
        comSQL = New SqlCommand(sql, conn)
        Try
            comSQL.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Waduh, ono sing kleru")

        End Try
        txtketerangan.Text = status

        tutupkoneksi()

    End Sub
    Private Sub ubahbonus()
        bukakoneksi()
        Dim waktu, status As String
        waktu = Now
        status = "Perubahan nilai pada bonus menjadi" & txtbonusbaru.Text
        sql = "update tb_lainlain set nilai='" & txtbonusbaru.Text & "' where id_lainlain='5'" &
            "insert into tb_aktivitas values ('" & waktu & "','" & status & "','kebijakan')"
        comSQL = New SqlCommand(sql, conn)
        Try
            comSQL.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Waduh, ono sing kleru")

        End Try
        txtketerangan.Text = status

        tutupkoneksi()
    End Sub
    Private Sub ubahpajak()
        bukakoneksi()
        Dim waktu, status As String

        waktu = Now
        status = "Perubahan pajak menjadi " & txtpajakbaru.Text & " % "
        sql = "update tb_lainlain set nilai='" & txtpajakbaru.Text & "' where id_lainlain=9" &
            "insert into tb_aktivitas values ('" & waktu & "','" & status & "','kebijakan')"
        comSQL = New SqlCommand(sql, conn)
        Try
            comSQL.ExecuteNonQuery()
            txtketerangan.Text = status
        Catch ex As Exception
            MsgBox("Waduh, ono sing kleru")

        End Try


        tutupkoneksi()
    End Sub
    Private Sub ubahpotongan()
        bukakoneksi()
        Dim waktu, status As String

        waktu = Now
        status = "Perubahan potongan. " & txtketpotongan.Text & " menjadi " & txtpotongan.Text
        sql = "update tb_lainlain set nilai='" & txtpotongan.Text & "' where id_lainlain='" & lblidpot.Text & "'" &
            "insert into tb_aktivitas values ('" & waktu & "','" & status & "','kebijakan')"
        comSQL = New SqlCommand(sql, conn)
        Try
            comSQL.ExecuteNonQuery()
            txtketerangan.Text = status
        Catch ex As Exception
            MsgBox("Waduh, ono sing kleru")

        End Try


        tutupkoneksi()
    End Sub
    Private Sub ubahgalem()
        bukakoneksi()
        Dim waktu, status As String

        waktu = Now
        status = "Perubahan gaji lembur kategori " & txtketgalem.Text & " menjadi " & Txtgalem.Text
        sql = "update tb_lainlain set nilai='" & Txtgalem.Text & "' where nama='" & Gbgalem.Text & "'" &
            "insert into tb_aktivitas values ('" & waktu & "','" & status & "','kebijakan')"
        comSQL = New SqlCommand(sql, conn)
        Try
            comSQL.ExecuteNonQuery()
            txtketerangan.Text = status
        Catch ex As Exception
            MsgBox("Waduh, ono sing kleru")

        End Try


        tutupkoneksi()
    End Sub

    'LOAD SEMUANYA...'

    Private Sub Kebijakan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilDataGapok()
        tampilDataTunjangan()
        tampilDataBonus()
        tampildatapotongan()
        tampilDataGaLem()



    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        TXTID.Text = DataGridView1.Item(0, i).Value
        TXTPOSISI.Text = DataGridView1.Item(1, i).Value
        TXTGAJILAMA.Text = DataGridView1.Item(2, i).Value


    End Sub


    Private Sub BTNATUR_Click(sender As Object, e As EventArgs) Handles BTNATUR.Click

        ubahdata()
        tampilDataGapok()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TXTID.Text = ""
        TXTPOSISI.Text = ""
        TXTGAJIBARU.Text = ""
        TXTGAJILAMA.Text = ""

    End Sub




    Private Sub DGTunjangan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTunjangan.CellClick
        Dim i As Integer
        i = DGTunjangan.CurrentRow.Index

        NM_Tunjangan.Text = "Tunjangan " & DGTunjangan.Item(1, i).Value
        lbl_Keterangan_Tunj.Text = DGTunjangan.Item(3, i).Value
        TxtTunjLama.Text = DGTunjangan.Item(2, i).Value
        gbtunj.Text = DGTunjangan.Item(0, i).Value

    End Sub
    Public Sub daftartunjangan()
        Dim anak, menikah, pengalaman, raya As Integer
        menikah = DGTunjangan.Item(2, 0).Value
        anak = DGTunjangan.Item(2, 1).Value
        raya = DGTunjangan.Item(2, 2).Value
        pengalaman = DGTunjangan.Item(2, 3).Value

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ubahtunjangan()
        tampilDataTunjangan()

    End Sub

    Private Sub Dggalem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dggalem.CellClick
        Dim i As Integer
        i = Dggalem.CurrentRow.Index

        Gbgalem.Text = Dggalem.Item(0, i).Value
        txtketgalem.Text = Dggalem.Item(2, i).Value
        Txtgalem.Text = Dggalem.Item(1, i).Value

    End Sub

    Private Sub Dgpotongan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgpotongan.CellClick
        Dim i As Integer
        i = Dgpotongan.CurrentRow.Index

        NM_Tunjangan.Text = "Tunjangan " & Dgpotongan.Item(1, i).Value
        txtketpotongan.Text = Dgpotongan.Item(3, i).Value
        txtpotongan.Text = Dgpotongan.Item(2, i).Value
        lblidpot.Text = Dgpotongan.Item(0, i).Value

    End Sub

    Private Sub btnaturbonus_Click(sender As Object, e As EventArgs) Handles btnaturbonus.Click
        ubahbonus()
        tampilDataBonus()

    End Sub

    Private Sub btnaturpajak_Click(sender As Object, e As EventArgs) Handles btnaturpajak.Click
        ubahpajak()

    End Sub


    Private Sub btnubahgalem_Click(sender As Object, e As EventArgs) Handles btnubahgalem.Click
        ubahgalem()
        tampilDataGaLem()

    End Sub

    Private Sub btnaturpotongan_Click(sender As Object, e As EventArgs) Handles btnaturpotongan.Click
        ubahpotongan()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class