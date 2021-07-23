Imports System.Data.SqlClient
Public Class ProductPackage
    Dim id, name, frame, lens, special, description As String
    Dim price As Decimal
    Dim qty As Integer
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader

    Public Sub New()

    End Sub
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
    Public Sub setid(ByVal v As String)
        id = v
    End Sub
    Public Sub setname(ByVal v As String)
        name = v
    End Sub
    Public Sub setframe(ByVal v As String)
        frame = v
    End Sub
    Public Sub setlens(ByVal v As String)
        lens = v
    End Sub
    Public Sub setspecial(ByVal v As String)
        special = v
    End Sub
    Public Sub setdescription(ByVal v As String)
        description = v
    End Sub
    Public Sub setprice(ByVal v As String)
        price = Convert.ToDecimal(v)
    End Sub
    Public Sub setqty(ByVal v As String)
        qty = Convert.ToInt32(v)
    End Sub
    'gettes
    Public Function getid() As String
        Return id
    End Function
    Public Function getname() As String
        Return name
    End Function
    Public Function getframe() As String
        Return frame
    End Function
    Public Function getlens() As String
        Return lens
    End Function
    Public Function getspecial() As String
        Return special
    End Function
    Public Function getdescription() As String
        Return description
    End Function
    Public Function getprice() As Decimal
        Return price
    End Function
    Public Function getqty() As Integer
        Return qty
    End Function

    'methods
    Public Function save_package(ByVal package As List(Of String)) As Boolean
        Dim ok As Boolean = False
        Try
            open_connection()
            Dim sql As String
            sql = "INSERT INTO tblpackage (packagename,frameid,lensid,specialid,packagedescription,packageprice,packageqty) "
            sql += " VALUES(@v1,@v2,@v3,@v4,@v5,@v6,@v7)"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@v1", package(0))
            cmd.Parameters.AddWithValue("@v2", package(1))
            cmd.Parameters.AddWithValue("@v3", package(2))
            cmd.Parameters.AddWithValue("@v4", package(3))
            cmd.Parameters.AddWithValue("@v5", package(4))
            cmd.Parameters.AddWithValue("@v6", package(5))
            cmd.Parameters.AddWithValue("@v7", package(6))
            If cmd.ExecuteNonQuery Then
                ok = True
            End If
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Save package:" + ex.Message)
        End Try
        Return ok
    End Function

    Public Function update_package(ByVal package As List(Of String)) As Boolean
        Dim ok As Boolean = False
        Try
            open_connection()
            Dim sql As String
            sql = "UPDATE tblpackage SET packagename=@v1,frameid=@v2,lensid=@v3,specialid=@v4,packagedescription=@v5,packageprice=@v6,packageqty=@v7 "
            sql += " WHERE packageid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@v1", package(0))
            cmd.Parameters.AddWithValue("@v2", package(1))
            cmd.Parameters.AddWithValue("@v3", package(2))
            cmd.Parameters.AddWithValue("@v4", package(3))
            cmd.Parameters.AddWithValue("@v5", package(4))
            cmd.Parameters.AddWithValue("@v6", package(5))
            cmd.Parameters.AddWithValue("@v7", package(6))
            cmd.Parameters.AddWithValue("@id", package(7))
            If cmd.ExecuteNonQuery Then
                ok = True
            End If
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Save package:" + ex.Message)
        End Try
        Return ok
    End Function

    Public Function load_packages() As List(Of ProductPackage)
        Dim list1 As New List(Of ProductPackage)
        Dim productobj As ProductPackage
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM tblpackage WHERE packagestatus <> 'deleted' or packagestatus is null ORDER BY packageid DESC "
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader
            If rs.HasRows Then

                While rs.Read
                    productobj = New ProductPackage
                    productobj.setid(rs(0))
                    productobj.setname(rs(1))
                    productobj.setframe(rs(2))
                    productobj.setlens(rs(3))
                    productobj.setspecial(rs(4))
                    productobj.setdescription(rs(5))
                    productobj.setprice(rs(6))
                    productobj.setqty(rs(7))
                    list1.Add(productobj)
                End While
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Load Package:" + ex.Message)
        End Try
        Return list1
    End Function

    Public Function search_package(ByVal pid As String) As List(Of String)
        Dim list1 As New List(Of String)
        Try
            open_connection()
            Dim sql As String
            sql = "SELECT * FROM tblpackage WHERE packageid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", pid)
            rs = cmd.ExecuteReader
            While rs.Read
                list1.Add(rs(0))
                list1.Add(rs(1))
                list1.Add(rs(2))
                list1.Add(rs(3))
                list1.Add(rs(4))
                list1.Add(rs(5))
                list1.Add(rs(6))
                list1.Add(rs(7))
            End While
            rs.Close()
            cmd.Dispose()
            conn.Close()

        Catch ex As Exception
            MsgBox("Search package:" + ex.Message)
        End Try
        Return list1
    End Function
    Public Function delete_package(ByVal pid As String) As Boolean
        Dim status As Boolean = False
        Try
            open_connection()
            Dim sql As String = "UPDATE tblpackage set packagestatus='deleted' WHERE packageid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", pid)
            If (cmd.ExecuteNonQuery) Then
                status = True
            End If
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Delete Package:" + ex.Message)
        End Try
        Return status
    End Function

End Class
