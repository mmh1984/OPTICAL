Imports System.Data.SqlClient
Public Class ProductLog
    Dim logname, pid, adate, qty, logby, remarks As String
    'connection
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Dim productid As String

    'functions and procedures

    'open connection
    Private Sub open_connection()
        Try
            Dim db As Connection
            db = New Connection

            conn = New SqlConnection(db.get_connection)
            conn.Open()

        Catch ex As Exception
            MessageBox.Show("Open Connection:" & ex.Message)

        End Try
    End Sub
    Public Sub setlogname(ByVal v As String)
        logname = v
    End Sub

    Public Sub setpid(ByVal v As String)
        pid = v
    End Sub
    Public Sub setdate(ByVal v As String)
        adate = v

    End Sub

    Public Sub setqty(ByVal v As String)
        qty = v
    End Sub
    Public Sub setlogby(ByVal v As String)
        logby = v
    End Sub
    Public Sub setremarks(ByVal v As String)
        remarks = v
    End Sub

    Public Sub save_log()
        Try
            open_connection()
            Dim sql As String
            Dim d_date As Date
            d_date = adate
            sql = "INSERT INTO productstocklog (logname,productid,arrivaldate,qty,logdate,logby,remarks) "
            sql += "VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7)"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@v1", logname)
            cmd.Parameters.AddWithValue("@v2", pid)
            cmd.Parameters.AddWithValue("@v3", d_date.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@v4", qty)
            cmd.Parameters.AddWithValue("@v5", DateTime.Now.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@v6", logby)
            cmd.Parameters.AddWithValue("@v7", remarks)
            If cmd.ExecuteNonQuery Then

                cmd.Dispose()
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Product Log" + ex.Message)
        End Try
    End Sub
End Class
