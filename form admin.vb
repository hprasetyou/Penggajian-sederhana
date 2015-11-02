Imports System.Data.SqlClient
Public Class form_admin

    Private Sub tampil()
        bukakoneksi()

        sql = "SELECT * FROM TB_USER WHERE USERNAME <> 'admin'"
        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dt As New DataTable
        For Each dt In ds.Tables
           
            DataGridView1.DataSource = dt


        Next
        tutupkoneksi()

    End Sub
    Private Sub ubahdatauser()
        bukakoneksi()

        sql = "update tb_user set  password='" & txtpass.Text & "' where username='" & txtusername.Text & "'"

        comSQL = New SqlCommand(sql, conn)
        Try
            comSQL.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Waduh, ono sing kleru")

        End Try
        tutupkoneksi()

    End Sub
 

    Private Sub form_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        grptambahdata.Hide()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        txtusername.Text = DataGridView1.Item(0, i).Value
        txtpass.Text = DataGridView1.Item(1, i).Value

    End Sub

    Private Sub txtsimpan_Click(sender As Object, e As EventArgs) Handles txtsimpan.Click
        bukakoneksi()

        sql = "select * from tb_user where username='admin' and password='" & txtpasslama.Text & "' "

        comSQL = New SqlCommand(sql, conn)
        Dim nik As SqlDataReader = comSQL.ExecuteReader()
        nik.Read()
        If nik.HasRows Then
            If txtpassbaru.Text = txtconfirm.Text Then
                sql = "update tb_user set  password='" & txtpass.Text & "' where username='admin'"

                comSQL = New SqlCommand(sql, conn)
                Try
                    comSQL.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("Waduh, ono sing kleru" & ex.ToString)

                End Try
            Else
                MsgBox("Password tidak cocok")

            End If
        Else

            MsgBox("Password salah")
        End If

       
        tutupkoneksi()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ubahdatauser()
        tampil()

    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        grptambahdata.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        grptambahdata.Hide()

    End Sub

    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        bukakoneksi()
        

        sql = "insert into tb_user values('" & txtuserbaru.Text & "','" & passuserbaru.Text & "')"

        comSQL = New SqlCommand(sql, conn)
        Try
            comSQL.ExecuteNonQuery()
            MsgBox("simpan berhasil")
            tampil()


        Catch ex As Exception
            MsgBox("gagal" & ex.ToString)


        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Login.Close()

    End Sub
End Class