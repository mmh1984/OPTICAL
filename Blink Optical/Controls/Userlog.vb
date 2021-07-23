Imports System.Data.SqlClient
Public Class Userlog
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Dim id, user, logstatus As String
    Dim logdate, logtime As Date

    Public Sub setid(ByVal v As String)
        id = v
    End Sub
    Public Sub setuser(ByVal v As String)
        user = v
    End Sub
    Public Sub setstatus(ByVal v As String)
        logstatus = v
    End Sub
    Public Sub setdate(ByVal v As Date)
        logdate = v.ToString("yyyy-MM-dd")
    End Sub
    Public Sub settime(ByVal v As Date)
        logtime = v.ToString("hh:mm:ss tt")
    End Sub

    Public Function getid()
        Return id
    End Function
    Public Function getname()
        Return user
    End Function
    Public Function getstatus()
        Return logstatus
    End Function
    Public Function getdate()
        Return logdate
    End Function
    Public Function gettime()
        Return logtime
    End Function
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

    Public Function user_logs(ByVal userid As String)
        Dim loglist As New List(Of Userlog)
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM userlog WHERE userid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", userid)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim userobj As New Userlog
                    userobj.setid(rs(0).ToString())
                    userobj.setuser(rs(1).ToString())
                    userobj.setstatus(rs(2).ToString())
                    userobj.setdate(rs(3).ToString())
                    userobj.settime(rs(4).ToString())
                    loglist.Add(userobj)
                End While
            Else
                loglist = Nothing
            End If
        Catch ex As Exception
            MsgBox("User logs:" + ex.Message)
        End Try
        Return loglist
    End Function

    Public Sub save_log()
        Try
            open_connection()
            Dim sql As String = "INSERT INTO userlog (userid,logstatus,logdate,logtime) "
            sql += " VALUES(@v1,@v2,@v3,@v4)"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@v1", user)
            cmd.Parameters.AddWithValue("@v2", logstatus)
            cmd.Parameters.AddWithValue("@v3", Date.Now)
            cmd.Parameters.AddWithValue("@v4", Date.Now)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("user log:" + ex.Message)
        End Try
    End Sub
End Class
