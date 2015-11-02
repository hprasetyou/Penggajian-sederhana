Imports System.Data.SqlClient

Public Class Login
    

    Private Sub login()

        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Username dan Password belum lengkap !")
        End If
        bukakoneksi()

        sql = "select * from tb_user where username='" & UsernameTextBox.Text & "' and password='" & PasswordTextBox.Text & "' "

        comSQL = New SqlCommand(sql, conn)
        Dim nik As SqlDataReader = comSQL.ExecuteReader()
        nik.Read()
        If nik.HasRows Then
            If UsernameTextBox.Text = "admin" Then
                tutupkoneksi()
                Me.Hide()
                form_admin.Show()
            Else
                tutupkoneksi()
                Me.Hide()
                Aplikasi_Penggajian.Show()
            End If

        Else
            MsgBox("Login Gagal, Penyusup!!")
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""

        End If


        tutupkoneksi()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        login()


    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()

    End Sub
End Class