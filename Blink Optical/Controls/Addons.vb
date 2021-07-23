Imports System.Data.SqlClient
Public Class Addons
    'connection
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader

    Dim id, brand, name, description, price, status As String


    Public Sub setid(ByVal v As String)
        id = v
    End Sub
    Public Sub setname(ByVal v As String)
        name = v
    End Sub
    Public Sub setbrand(ByVal v As String)
        brand = v
    End Sub
    Public Sub setdesc(ByVal v As String)
        description = v
    End Sub
    Public Sub setprice(ByVal v As String)
        price = v
    End Sub
    Public Sub setstatus(ByVal v As String)
        status = v
    End Sub

    'getters
    Public Function getid() As String
        Return id
    End Function
    Public Function getbrand() As String
        Return brand
    End Function
    Public Function getname() As String
        Return name
    End Function
    Public Function getdesc() As String
        Return description
    End Function
    Public Function getprice() As String
        Return price
    End Function
    Public Function getstatus() As String
        Return status
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

    Public Function load_products() As List(Of Addons)
        Dim productlist As New List(Of Addons)
        Try
            open_connection()
            Dim sql As String = "Select * FROM tbladdons WHERE itemstatus <> 'deleted' or itemstatus is null ORDER BY itemid DESC"
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader

            productlist = New List(Of Addons)

            If rs.HasRows Then
                While rs.Read
                    Dim res As Addons
                    res = New Addons
                    res.setid(rs(0).ToString)
                    res.setbrand(rs(1).ToString)
                    res.setname(rs(2).ToString)
                    res.setdesc(rs(3).ToString)
                    res.setprice(rs(4).ToString)
                    res.setstatus(rs(5).ToString)
                    productlist.Add(res)

                End While

            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Add ons(load products):" + ex.Message)
        End Try
        Return productlist
    End Function


    Public Function search_products(ByVal keyword As String, ByVal col As String) As List(Of Addons)
        Dim productlist As New List(Of Addons)
        Try
            open_connection()
            Dim sql As String = ""
            If col = "name" Then
                sql = "Select * FROM tbladdons WHERE itemname LIKE @key AND (itemstatus <> 'deleted' or itemstatus is null) ORDER BY itemid DESC"
            ElseIf col = "brand" Then
                sql = "Select * FROM tbladdons WHERE itembrand = @key AND (itemstatus <> 'deleted' or itemstatus is null) ORDER BY itemid DESC"
            End If

            cmd = New SqlCommand(sql, conn)

            If col = "name" Then
                cmd.Parameters.AddWithValue("@key", "%" + keyword + "%")
            ElseIf col = "brand" Then
                cmd.Parameters.AddWithValue("@key", keyword)
            End If
            rs = cmd.ExecuteReader
            productlist = New List(Of Addons)

            If rs.HasRows Then
                While rs.Read
                    Dim res As Addons
                    res = New Addons
                    res.setid(rs(0).ToString)
                    res.setbrand(rs(1).ToString)
                    res.setname(rs(2).ToString)
                    res.setdesc(rs(3).ToString)
                    res.setprice(rs(4).ToString)
                    res.setstatus(rs(5).ToString)
                    productlist.Add(res)

                End While

            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Add ons(load products):" + ex.Message)
        End Try
        Return productlist
    End Function

    Public Function search_add_on(ByVal pid As String) As List(Of String)
        Dim productlist As New List(Of String)
        Try
            open_connection()
            Dim sql As String = ""

            sql = "Select * FROM tbladdons WHERE itemid =@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", pid)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read

                    productlist.Add(rs(0).ToString)
                    productlist.Add(rs(1).ToString)
                    productlist.Add(rs(2).ToString)
                    productlist.Add(rs(3).ToString)
                    productlist.Add(rs(4).ToString)
                    productlist.Add(rs(5).ToString)


                End While

            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Add ons(load products):" + ex.Message)
        End Try
        Return productlist
    End Function


    Public Function save_add_on(ByVal v As List(Of String)) As Boolean
        Dim status = False
        Try
            open_connection()

            Dim sql As String
            sql = "INSERT INTO tbladdons (itembrand,itemname,itemdescription,itemprice) "
            sql += " VALUES (@v1,@v2,@v3,@v4)"
            cmd = New SqlCommand(sql, conn)


            cmd.Parameters.AddWithValue("@v1", v(0))
            cmd.Parameters.AddWithValue("@v2", v(1))
            cmd.Parameters.AddWithValue("@v3", v(2))
            cmd.Parameters.AddWithValue("@v4", v(3))

            If (cmd.ExecuteNonQuery) Then
                status = True
            End If
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Add ons(save_add_ons):" + ex.Message)
        End Try
        Return status
    End Function


    Public Function update_add_on(ByVal v As List(Of String)) As Boolean
        Dim status = False
        Try
            open_connection()

            Dim sql As String
            sql = "UPDATE tbladdons SET itembrand=@v1,itemname=@v2,itemdescription=@v3,itemprice=@v4 "
            sql += " WHERE itemid=@id"
            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@v1", v(0))
            cmd.Parameters.AddWithValue("@v2", v(1))
            cmd.Parameters.AddWithValue("@v3", v(2))
            cmd.Parameters.AddWithValue("@v4", v(3))
            cmd.Parameters.AddWithValue("@id", v(4))
            If (cmd.ExecuteNonQuery) Then

                status = True
            End If
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Add ons(save_add_ons):" + ex.Message)
        End Try
        Return status
    End Function

    Public Function delete_add_on(ByVal id As String) As Boolean
        Dim status = False
        Try
            open_connection()

            Dim sql As String
            sql = "UPDATE tbladdons SET itemstatus='deleted' WHERE itemid=@id"
            cmd = New SqlCommand(sql, conn)


            cmd.Parameters.AddWithValue("@id", id)
            If (cmd.ExecuteNonQuery) Then

                status = True
            End If
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Add ons(save_add_ons):" + ex.Message)
        End Try
        Return status
    End Function

    Public Function get_brand() As List(Of String)
        Dim brandlist As New List(Of String)
        Try
            open_connection()
            Dim sql As String = "SELECT DISTINCT(ITEMBRAND) FROM tbladdons"
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                brandlist = New List(Of String)
                While rs.Read

                    brandlist.Add(rs(0))
                End While
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Add ons(brands):" + ex.Message)
        End Try
        Return brandlist
    End Function
End Class
