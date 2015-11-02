Imports System.Data.SqlClient

Public Class karyawanbaru

    Private Sub simpanData()
        bukakoneksi()
        Dim id_karyawan, ttl As String
        id_karyawan = posisi.Text & "-" & Divisi.Text & id.Text
        ttl = tgl_lahir.Text

        sql = "INSERT INTO Tb_Karyawan values(" &
        "'" & id_karyawan & "'," &
        "'" & nama.Text & "'," &
        "'" & jekel.Text & "'," &
        "'" & ttl & "'," &
        "'" & telepon.Text & "'," &
        "'" & agama.Text & "'," &
        "'" & status.Text & "'," &
        "'" & anak.Text & "'," &
        "'" & alamat.Text & "'," &
        "'" & posisi.Text & "'," &
        "'" & Divisi.Text & "'," &
        "'" & Year(Now) & "')"

        comSQL = New SqlCommand(sql, conn)
        Try
            comSQL.ExecuteNonQuery()
            MsgBox("simpan berhasil")
            Me.Close()

        Catch ex As Exception
            MsgBox("gagal" & ex.ToString)


        End Try

        tutupkoneksi()
    End Sub
    Private Sub posisi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles posisi.SelectedIndexChanged
        If posisi.Text = "CNT" Then
            Divisi.Items.Clear()
            Divisi.Items.Add("A")
            Divisi.Items.Add("B")
            Divisi.Items.Add("C")
        ElseIf posisi.Text = "GDG" Then
            Divisi.Items.Clear()
            Divisi.Items.Add("D")
            Divisi.Items.Add("E")
            Divisi.Items.Add("F")
        ElseIf posisi.Text = "MNG" Then
            Divisi.Items.Clear()
            Divisi.Items.Add("A")
            Divisi.Items.Add("B")
            Divisi.Items.Add("C")
            Divisi.Items.Add("D")
            Divisi.Items.Add("E")
            Divisi.Items.Add("F")
        ElseIf posisi.Text = "MRK" Then
            Divisi.Items.Clear()
            Divisi.Items.Add("G")
            Divisi.Items.Add("H")
            Divisi.Items.Add("I")
        ElseIf posisi.Text = "PRD" Then
            Divisi.Items.Clear()
            Divisi.Items.Add("A")
            Divisi.Items.Add("B")
            Divisi.Items.Add("C")
        ElseIf posisi.Text = "SCR" Then
            Divisi.Items.Clear()
            Divisi.Items.Add("-")
        ElseIf posisi.Text = "SVR" Then
            Divisi.Items.Clear()
            Divisi.Items.Add("A")
            Divisi.Items.Add("B")
            Divisi.Items.Add("C")
            Divisi.Items.Add("D")
            Divisi.Items.Add("E")
            Divisi.Items.Add("F")
        End If


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpanData()

    End Sub

    Private Sub status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles status.SelectedIndexChanged
        If status.Text = "MENIKAH" Then
            anak.Enabled = True

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub


End Class