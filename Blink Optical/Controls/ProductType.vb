Imports System.Data.SqlClient
Public Class ProductType
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Dim id, name, status As String
    Public Sub setid(ByVal v As String)
        id = v
    End Sub
    Public Sub setname(ByVal v As String)
        name = v
    End Sub
    Public Sub setstatus(ByVal v As String)
        status = v
    End Sub

    Public Function getid()
        Return id

    End Function
    Public Function getname()
        Return name
    End Function
    Public Function getstatus()
        Return status
    End Function
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

    Public Function get_category() As List(Of ProductType)
        Dim typelist As New List(Of ProductType)
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM tblproducttype WHERE typestatus <> 'deleted' ORDER BY typeid ASC"
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim typeobj As New ProductType
                    typeobj.setid(rs(0).ToString)
                    typeobj.setname(rs(1).ToString)
                    typelist.Add(typeobj)
                End While
            Else
                typelist = Nothing
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Get category:" + ex.Message)
        End Try
        Return typelist
    End Function

    Public Sub save_type()
        Try
            open_connection()
            Dim sql As String = "INSERT INTO tblproducttype (typename,typestatus) VALUES (@v1,@v2)"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@v1", name)
            cmd.Parameters.AddWithValue("@v2", status)
            cmd.ExecuteNonQuery()

            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Save type:" + ex.Message)
        End Try
    End Sub

    Public Function update_type()
        Dim res As Boolean = False
        Try
            open_connection()
            Dim sql As String = "UPDATE tblproducttype SET typename=@v1,typestatus=@v2 "
            sql += " WHERE typeid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@v1", name)
            cmd.Parameters.AddWithValue("@v2", status)
            cmd.Parameters.AddWithValue("@id", id)
            If cmd.ExecuteNonQuery Then
                res = True
            End If
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Save type:" + ex.Message)
        End Try
        Return res
    End Function
End Class
