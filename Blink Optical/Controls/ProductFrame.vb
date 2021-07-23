Imports System.Data.SqlClient
Public Class ProductFrame
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Dim pid As String
    Dim pcode As String
    Dim pbrand As String
    Dim pname, model, color As String
    Dim pprice As String
    Dim pstock As String
    Dim ptype As String
    Dim pdescription, sph, cyl As String

    Public Sub setid(ByVal v As String)
        pid = v
    End Sub

    Public Sub setcode(ByVal v As String)
        pcode = v
    End Sub

    Public Sub setname(ByVal v As String)
        pname = v
    End Sub
    Public Sub setmodel(ByVal v As String)
        model = v
    End Sub
    Public Sub setcolor(ByVal v As String)
        color = v
    End Sub
    Public Sub setbrand(ByVal v As String)
        pbrand = v
    End Sub

    Public Sub setprice(ByVal v As String)
        pprice = v
    End Sub

    Public Sub setstock(ByVal v As String)
        pstock = v
    End Sub
    Public Sub settype(ByVal v As String)
        ptype = v
    End Sub
    Public Sub setdesc(ByVal v As String)
        pdescription = v
    End Sub
    Public Sub setsph(ByVal v As String)
        sph = v
    End Sub
    Public Sub setcyl(ByVal v As String)
        cyl = v
    End Sub
    'getters
    Public Function getid() As String
        Return pid
    End Function

    Public Function getcode() As String
        Return pcode
    End Function

    Public Function getname() As String
        Return pname
    End Function
    Public Function getmodel() As String
        Return model
    End Function
    Public Function getbrand() As String
        Return pbrand
    End Function
    Public Function getcolor() As String
        Return color
    End Function

    Public Function getprice() As String
        Return pprice
    End Function

    Public Function getstock() As String
        Return pstock
    End Function
    Public Function get_type() As String
        Return ptype
    End Function
    Public Function getdesc() As String
        Return pdescription
    End Function
    Public Function getsph() As String
        Return sph
    End Function
    Public Function getcyl() As String
        Return cyl
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
    Public Sub reduce_stock(ByVal list1 As List(Of String))
        Try
            open_connection()
            Dim sql As String
            sql = "UPDATE tblproducts SET productstock=@qty "
            sql += " WHERE productid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", list1(0))
            cmd.Parameters.AddWithValue("@qty", list1(1))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Update Stock:" + ex.Message)
        End Try
    End Sub
    Public Function load_products()
        Dim list1 As New List(Of ProductFrame)
        Try
            open_connection()
            Dim sql As String
            sql = "SELECT * FROM tblproducts WHERE productstatus <> 'deleted' or productstatus is null ORDER BY productid ASC"
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim productobj As New ProductFrame
                    productobj.setid(rs(0).ToString)
                    productobj.settype(rs(1).ToString)
                    productobj.setcode(rs(2).ToString)
                    productobj.setname(rs(3).ToString)
                    productobj.setbrand(rs(4).ToString)
                    productobj.setmodel(rs(5).ToString)
                    productobj.setcolor(rs(6).ToString)
                    productobj.setdesc(rs(7).ToString)
                    productobj.setprice(rs(8).ToString)
                    productobj.setstock(rs(9).ToString)
                    productobj.setsph(rs(10).ToString)
                    productobj.setcyl(rs(11).ToString)
                    list1.Add(productobj)
                End While
                rs.Close()
                cmd.Dispose()
                conn.Close()
            Else
                list1 = Nothing
            End If

        Catch ex As Exception
            MsgBox("Load product Class:" + ex.Message)
        End Try

        Return list1

    End Function
    Public Function search_product_type(ByVal type As String)
        Dim list1 As New List(Of ProductFrame)
        Try
            open_connection()
            Dim sql As String
            sql = "SELECT * FROM tblproducts WHERE producttype=@type and (productstatus <> 'deleted' or productstatus is null) ORDER BY productid ASC"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@type", type)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim productobj As New ProductFrame
                    productobj.setid(rs(0).ToString)
                    productobj.settype(rs(1).ToString)
                    productobj.setcode(rs(2).ToString)
                    productobj.setname(rs(3).ToString)
                    productobj.setbrand(rs(4).ToString)
                    productobj.setmodel(rs(5).ToString)
                    productobj.setcolor(rs(6).ToString)
                    productobj.setdesc(rs(7).ToString)
                    productobj.setprice(rs(8).ToString)
                    productobj.setstock(rs(9).ToString)
                    productobj.setsph(rs(10).ToString)
                    productobj.setcyl(rs(11).ToString)
                    list1.Add(productobj)
                End While
                rs.Close()
                cmd.Dispose()
                conn.Close()
            Else
                list1 = Nothing
            End If

        Catch ex As Exception
            MsgBox("Load product Class:" + ex.Message)
        End Try

        Return list1

    End Function

    Public Function search_product_name(ByVal type As String)
        Dim list1 As New List(Of ProductFrame)
        Try
            open_connection()
            Dim sql As String
            sql = "SELECT * FROM tblproducts WHERE productname LIKE @type and (productstatus <> 'deleted' or productstatus is null) ORDER BY productid ASC"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@type", "%" & type & "%")
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim productobj As New ProductFrame
                    productobj.setid(rs(0).ToString)
                    productobj.settype(rs(1).ToString)
                    productobj.setcode(rs(2).ToString)
                    productobj.setname(rs(3).ToString)
                    productobj.setbrand(rs(4).ToString)
                    productobj.setmodel(rs(5).ToString)
                    productobj.setcolor(rs(6).ToString)
                    productobj.setdesc(rs(7).ToString)
                    productobj.setprice(rs(8).ToString)
                    productobj.setstock(rs(9).ToString)
                    productobj.setsph(rs(10).ToString)
                    productobj.setcyl(rs(11).ToString)
                    list1.Add(productobj)
                End While
                rs.Close()
                cmd.Dispose()
                conn.Close()
            Else
                list1 = Nothing
            End If

        Catch ex As Exception
            MsgBox("Load product Class:" + ex.Message)
        End Try

        Return list1

    End Function
    Public Sub add_stock(ByVal list1 As List(Of String))
        Try
            open_connection()
            Dim sql As String
            sql = "UPDATE tblproducts SET productstock=productstock + @qty "
            sql += " WHERE productid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", list1(0))
            cmd.Parameters.AddWithValue("@qty", list1(1))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Update Stock:" + ex.Message)
        End Try
    End Sub

    Public Function search_product(ByVal pid As String) As List(Of String)
        Dim list1 As New List(Of String)
        Try
            open_connection()
            Dim sql As String
            sql = "SELECT * FROM tblproducts WHERE productid=@id AND (productstatus <> 'deleted' or productstatus is null) ORDER BY productid DESC"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", pid)
            rs = cmd.ExecuteReader
            While rs.Read
                Dim i As Integer
                For i = 0 To 15
                    If Not IsDBNull(rs(i)) Then
                        list1.Add(rs(i))
                    Else
                        list1.Add(" ")
                    End If
                Next

            End While
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Search products:" + ex.Message)
        End Try
        Return list1
    End Function

    Public Function search_lens(ByVal v1 As String, ByVal v2 As String)
        Dim list1 As New List(Of ProductFrame)
        Try
            open_connection()
            Dim sql As String
            sql = "SELECT * FROM tblproducts WHERE sph_r=@v1 AND cyl_r=@v2 AND (productstatus <> 'deleted' or productstatus is null) ORDER BY productid DESC "
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@v1", v1)
            cmd.Parameters.AddWithValue("@v2", v2)
            rs = cmd.ExecuteReader
            While rs.Read
                Dim obj1 As New ProductFrame
                obj1.setid(rs(0))
                obj1.settype(rs(1))
                obj1.setcode(rs(2))
                obj1.setname(rs(3))
                obj1.setbrand(rs(4))
                obj1.setmodel(rs(5))
                obj1.setcolor(rs(6))
                obj1.setdesc(rs(7))
                obj1.setprice(rs(8))
                obj1.setstock(rs(9))
                obj1.setsph(rs(10))
                obj1.setcyl(rs(11))
                list1.Add(obj1)
            End While
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Search products:" + ex.Message)
        End Try
        Return list1
    End Function

    Public Function search_product_special(ByVal pid As String) As List(Of String)
        Dim list1 As New List(Of String)
        Try
            open_connection()
            Dim sql As String
            sql = "SELECT * FROM tblspecialorder WHERE productid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", pid)
            rs = cmd.ExecuteReader
            While rs.Read
                Dim i As Integer
                For i = 0 To 14
                    If Not IsDBNull(rs(i)) Then
                        list1.Add(rs(i))
                    Else
                        list1.Add(" ")
                    End If
                Next

            End While
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Search products:" + ex.Message)
        End Try
        Return list1
    End Function

    Public Function get_brand() As List(Of String)
        Dim list1 As New List(Of String)
        Try
            open_connection()
            Dim sql As String = "SELECT DISTINCT(productbrand) FROM tblproducts WHERE productbrand <> ''order by productbrand"
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    list1.Add(rs(0).ToString)
                End While
            Else
                list1 = Nothing
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Get brand:" + ex.Message)
        End Try
        Return list1
    End Function

    Public Function get_name() As List(Of String)
        Dim list1 As New List(Of String)
        Try
            open_connection()
            Dim sql As String = "SELECT DISTINCT(productname) FROM tblproducts WHERE productname <> '' ORDER BY productname"
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    list1.Add(rs(0).ToString)
                End While
            Else
                list1 = Nothing
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Get brand:" + ex.Message)
        End Try
        Return list1
    End Function

    Public Function get_model(ByVal key1 As String) As List(Of String)
        Dim list1 As New List(Of String)
        Try
            open_connection()
            Dim sql As String = "SELECT DISTINCT(productmodel) FROM tblproducts WHERE productname=@key1 AND productmodel <> ''"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@key1", key1)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    list1.Add(rs(0).ToString)
                End While
            Else
                list1 = Nothing
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Get brand:" + ex.Message)
        End Try
        Return list1
    End Function

    Public Function get_model2(ByVal key1 As String) As List(Of String)
        Dim list1 As New List(Of String)
        Try
            open_connection()
            Dim sql As String = "SELECT DISTINCT(productname) FROM tblproducts WHERE producttype=@key1 AND productname <> ''"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@key1", key1)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    list1.Add(rs(0).ToString)
                End While
            Else
                list1 = Nothing
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Get brand:" + ex.Message)
        End Try
        Return list1
    End Function
End Class
