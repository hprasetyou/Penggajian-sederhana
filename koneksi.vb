Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Module Module1
    Public comSQL As New SqlClient.SqlCommand
    Public sql As String
    Public conn As New SqlConnection
    Public str As String = "Data Source = .\SQLEXPRESS;initial catalog=db_Penggajian;trusted_connection = true"


    Public Sub bukakoneksi()
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = str
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox("koneksi gagal" & ex.ToString)
            End Try
        End If
    End Sub
    Public Sub tutupkoneksi()
        If conn.State = ConnectionState.Open Then
            Try
                conn.Close()


            Catch ex As Exception
                MsgBox("koneksi menutup" & ex.ToString)
            End Try
        End If
    End Sub

End Module
