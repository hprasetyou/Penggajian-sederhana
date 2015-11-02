Public Class Aplikasi_Penggajian

    Private Sub tutup()
        Hitung_gaji.Close()
        Kebijakan.Close()
        aktivitas.Close()
        Tampilkan_data_karyawan.Close()
        kinerja_karyawan.Close()


    End Sub

    Private Sub tspenggajian_Click_1(sender As Object, e As EventArgs) Handles tspenggajian.Click
        tutup()
        Hitung_gaji.MdiParent = Me
        Hitung_gaji.Show()

    End Sub

    Private Sub tskebijakan_Click_1(sender As Object, e As EventArgs) Handles tskebijakan.Click
        tutup()

        Kebijakan.MdiParent = Me
        Kebijakan.Show()

    End Sub

    Private Sub tsaktivitas_Click_1(sender As Object, e As EventArgs) Handles tsaktivitas.Click
        tutup()

        aktivitas.MdiParent = Me
        aktivitas.Show()

    End Sub


    Private Sub tsbdata_Click(sender As Object, e As EventArgs) Handles tsbdata.Click
        tutup()
        Tampilkan_data_karyawan.MdiParent = Me
        Tampilkan_data_karyawan.Show()

    End Sub

    Private Sub tsbpenilaian_Click(sender As Object, e As EventArgs) Handles tsbpenilaian.Click
        tutup()
        kinerja_karyawan.MdiParent = Me
        kinerja_karyawan.Show()

    End Sub

    Private Sub Tskeluar_Click(sender As Object, e As EventArgs) Handles Tskeluar.Click
        Me.Close()
        Login.Close()

    End Sub
End Class