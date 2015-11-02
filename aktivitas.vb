Imports System.Data.SqlClient
Public Class aktivitas
    Private Sub tampilaktivitas()
        Dim bulan, tahun, bulansekarang, tahunsekarang As String
        bulansekarang = Month(Now)
        tahunsekarang = Year(Now)
        bulan = ""
        If tscbbulan.Text = "Sekarang" Then
            bulan = bulansekarang
        ElseIf tscbbulan.Text = "Januari" Then
            bulan = "1"
        ElseIf tscbbulan.Text = "Februari" Then
            bulan = "2"
        ElseIf tscbbulan.Text = "Maret" Then
            bulan = "3"
        ElseIf tscbbulan.Text = "April" Then
            bulan = "4"
        ElseIf tscbbulan.Text = "Mei" Then
            bulan = "5"
        ElseIf tscbbulan.Text = "Juni" Then
            bulan = "6"
        ElseIf tscbbulan.Text = "Juli" Then
            bulan = "7"
        ElseIf tscbbulan.Text = "Agustus" Then
            bulan = "8"
        ElseIf tscbbulan.Text = "September" Then
            bulan = "9"
        ElseIf tscbbulan.Text = "Oktober" Then
            bulan = "10"
        ElseIf tscbbulan.Text = "November" Then
            bulan = "11"
        ElseIf tscbbulan.Text = "Desember" Then
            bulan = "12"
        ElseIf tscbbulan.Text = "" Then
            bulan = bulansekarang
        End If

        If tscbtahun.Text = "Sekarang" Or tscbtahun.Text = "" Then
            tahun = tahunsekarang
        Else
            tahun = tscbtahun.Text

        End If

        bukakoneksi()
        Dim jenis As String
        jenis = ""
        If tscbjenis.Text = "" Then
            jenis = ""
        ElseIf tscbjenis.Text = "semua" Then
            jenis = ""
        ElseIf tscbjenis.Text = "kategori" Then
            jenis = ""
        ElseIf tscbjenis.Text = "penggajian" Then
            jenis = "jenis='penggajian' and"
        ElseIf tscbjenis.Text = "kebijakan" Then
            jenis = "jenis='kebijakan' and"
        End If

        sql = "select Waktu, Jenis, Aktivitas from tb_aktivitas where " & jenis & " right((left(waktu, 5)),2)='" & bulan & "' and right((left(waktu, 10)),4)='" & tahun & "' order by waktu asc"

        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dt As New DataTable
        For Each dt In ds.Tables
            BinSourceaktivitas.DataSource = dt
            BindNavaktivitas.BindingSource = BinSourceaktivitas
            dgaktivitas.DataSource = BinSourceaktivitas


        Next

        tutupkoneksi()

    End Sub

    Private Sub aktivitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilaktivitas()

    End Sub

    Private Sub dgaktivitas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgaktivitas.CellClick
        Dim i As Integer
        i = dgaktivitas.CurrentRow.Index
        GBAktivitas.Text = dgaktivitas.Item(0, i).Value
        txtaktivitas.Text = dgaktivitas.Item(2, i).Value
    End Sub


    Private Sub tscbjenis_TextChanged(sender As Object, e As EventArgs)
        tampilaktivitas()
    End Sub



    Private Sub bulan_TextChanged(sender As Object, e As EventArgs) Handles tscbbulan.TextChanged
        tampilaktivitas()
    End Sub

End Class