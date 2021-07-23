Imports System.Data.SqlClient
Public Class Users
    Dim id, username, userpass, fullname, userlevel As String
    'connection
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Public Sub setid(ByVal v As String)
        id = v
    End Sub
    Public Sub setusername(ByVal v As String)
        username = v
    End Sub
    Public Sub setuserpass(ByVal v As String)
        userpass = v
    End Sub
    Public Sub setname(ByVal v As String)
        fullname = v
    End Sub
    Public Sub setlevel(ByVal v As String)
        userlevel = v
    End Sub
    'getters
    Public Function getid()
        Return id
    End Function
    Public Function getusername()
        Return username
    End Function
    Public Function getuserpass()
        Return userpass
    End Function
    Public Function getfullname()
        Return fullname
    End Function
    Public Function getlevel()
        Return userlevel
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

    Public Function load_users()
        Dim userlist As New List(Of Users)
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM tblusers WHERE  userstatus <> 'deleted' or userstatus is null ORDER BY userlevel "
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim userobj As New Users
                    userobj.setid(rs(0).ToString)
                    userobj.setusername(rs(1).ToString)
                    userobj.setuserpass(rs(2).ToString)
                    userobj.setname(rs(3).ToString)
                    userobj.setlevel(rs(4).ToString)
                    userlist.Add(userobj)
                End While
            Else
                userlist = Nothing
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Load users:" + ex.Message)
        End Try
        Return userlist
    End Function

    Public Function user_details(ByVal userid As String)
        Dim userlist As New List(Of String)
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM tblusers WHERE  userid=@id "
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", userid)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim userobj As New Users
                    userlist.Add(rs(0).ToString())
                    userlist.Add(rs(1).ToString())
                    userlist.Add(rs(2).ToString())
                    userlist.Add(rs(3).ToString())
                End While
            Else
                userlist = Nothing
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Load users:" + ex.Message)
        End Try
        Return userlist
    End Function

    Public Function save_user()
        Dim status As Boolean = False
        Try
            open_connection()
            Dim sql As String
            sql = "INSERT INTO tblusers (username,userpass,fullname,userlevel,userstatus) "
            sql += " VALUES(@v1,@v2,@v3,@v4,@v5) "
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@v1", username)
            cmd.Parameters.AddWithValue("@v2", userpass)
            cmd.Parameters.AddWithValue("@v3", fullname)
            cmd.Parameters.AddWithValue("@v4", userlevel)
            cmd.Parameters.AddWithValue("@v5", "active")

            If (cmd.ExecuteNonQuery()) Then
                status = True
            End If
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("New user:" + ex.Message)
        End Try
        Return status
    End Function

    Public Function user_exists(ByVal uname As String)
        Dim exists As Boolean = False
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM tblusers WHERE username=@name  AND (userstatus <> 'deleted' or userstatus is null)"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@name", uname)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                exists = True

            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("user exists:" + ex.Message)
        End Try
        Return exists
    End Function
    Public Sub resetpassword(ByVal userno As String)
        Try
            open_connection()
            Dim sql As String = "UPDATE tblusers SET userpass=@newpass "
            sql += " WHERE userid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@newpass", "abcd1234")
            cmd.Parameters.AddWithValue("@id", userno)
            If cmd.ExecuteNonQuery Then
                MessageBox.Show("User password updated to: abcd1234", "Optical POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Reset password:" + ex.Message)
        End Try
    End Sub

    Public Sub deleteuser(ByVal userno As String)
        Try
            open_connection()
            Dim sql As String = "UPDATE tblusers SET userstatus=@newpass "
            sql += " WHERE userid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@newpass", "deleted")
            cmd.Parameters.AddWithValue("@id", userno)
            If cmd.ExecuteNonQuery Then
                MessageBox.Show("User Deleted", "Optical POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Reset password:" + ex.Message)
        End Try
    End Sub

    Public Sub update_user()
        Try
            open_connection()
            Dim sql As String = "UPDATE tblusers SET username=@name,userpass=@pass,fullname=@fname "
            sql += " WHERE userid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@name", username)
            cmd.Parameters.AddWithValue("@pass", userpass)
            cmd.Parameters.AddWithValue("@fname", fullname)
            cmd.Parameters.AddWithValue("@id", id)
            If cmd.ExecuteNonQuery Then
                MessageBox.Show("User details updated", "Optical POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Reset password:" + ex.Message)
        End Try
    End Sub
    Public Function user_exists()
        Dim exists As Boolean = False
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM tblusers WHERE (username=@name AND userid <> @id) AND (userstatus = 'deleted' or userstatus is null) "
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@name", username)
            cmd.Parameters.AddWithValue("@id", id)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                exists = True
            End If
        Catch ex As Exception

        End Try
        Return exists
    End Function
    Public Function user_check()
        Dim manager As Integer = 0
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM tblusers WHERE userlevel='manager'"
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                manager = 1
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Check manager:  " + ex.Message)
        End Try
        Return manager
    End Function
    Public Function login_user(ByVal uname As String, ByVal upass As String)
        Dim userfound As New List(Of String)
        Try
            open_connection()
            Dim sql As String = "SELECT userid,username,userlevel FROM tblusers "
            sql += " WHERE (username=@name AND userpass=@pass) and (userstatus <> 'deleted' or userstatus is null)"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@name", uname)
            cmd.Parameters.AddWithValue("@pass", upass)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    userfound.Add(rs(0).ToString)
                    userfound.Add(rs(1).ToString)
                    userfound.Add(rs(2).ToString)
                End While
            Else
                userfound = Nothing
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Login user:" + ex.Message)
        End Try
        Return userfound
    End Function
End Class
