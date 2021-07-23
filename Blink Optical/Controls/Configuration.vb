
Imports System.Data.SqlClient
Public Class Configuration
    'connection
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Dim name, phone, email, address, tag, printer1, printer2, ig As String

    Public Sub setname(ByVal v As String)
        name = v
    End Sub
    Public Sub setphone(ByVal v As String)
        phone = v
    End Sub
    Public Sub setemail(ByVal v As String)
        email = v
    End Sub
    Public Sub setaddress(ByVal v As String)
        address = v
    End Sub
    Public Sub settag(ByVal v As String)
        tag = v
    End Sub
    Public Sub setprinter1(ByVal v As String)
        printer1 = v
    End Sub
    Public Sub setprinter2(ByVal v As String)
        printer2 = v
    End Sub
    Public Sub setig(ByVal v As String)
        ig = v
    End Sub

    Public Function getname()
        Return name
    End Function

    Public Function getphone()
        Return phone
    End Function
    Public Function getemail()
        Return email
    End Function
    Public Function getaddress()
        Return address
    End Function
    Public Function gettag()
        Return tag
    End Function

    Public Function getprinter1()
        Return printer1
    End Function
    Public Function getprinter2()
        Return printer2
    End Function
    Public Function getig()
        Return ig
    End Function
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
    Public Sub get_details()
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM tblconfiguration WHERE confid=1"
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader
            While rs.Read
                setname(rs(1).ToString)
                setaddress(rs(2).ToString)
                setphone(rs(3).ToString)
                setemail(rs(4).ToString)
                setig(rs(5).ToString)
                settag(rs(6).ToString)
                setprinter1(rs(7).ToString)
                setprinter2(rs(8).ToString)
            End While
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Configuration details:" + ex.Message)
        End Try
    End Sub

    Public Sub save_details()
        Try
            open_connection()
            Dim sql As String = "UPDATE tblconfiguration SET shopname=@v1,shopaddress=@v2,shopphone=@v3,shopemail=@v4,"
            sql += "shopsocial=@v5,shoptag=@v6,printer1=@v7,printer2=@v8 "
            sql += " WHERE confid=1"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@v1", name)
            cmd.Parameters.AddWithValue("@v2", address)
            cmd.Parameters.AddWithValue("@v3", phone)
            cmd.Parameters.AddWithValue("@v4", email)
            cmd.Parameters.AddWithValue("@v5", ig)
            cmd.Parameters.AddWithValue("@v6", tag)
            cmd.Parameters.AddWithValue("@v7", printer1)
            cmd.Parameters.AddWithValue("@v8", printer2)
            If cmd.ExecuteNonQuery Then
                MsgBox("Configuration Updated")
            End If
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Configuration details:" + ex.Message)
        End Try
    End Sub

End Class
