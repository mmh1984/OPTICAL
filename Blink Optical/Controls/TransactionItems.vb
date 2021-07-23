Imports System.Data.SqlClient
Public Class TransactionItems
    Dim id, product, productype, price, qty, total, discount, totalprice As String
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Dim productname, productdescription As String
    Public Sub New()

    End Sub
    Public Sub setid(ByVal v As String)
        id = v
    End Sub
    Public Sub setproduct(ByVal v As String)
        product = v
    End Sub
    Public Sub settype(ByVal v As String)
        productype = v
    End Sub
    Public Sub setprice(ByVal v As String)
        price = v
    End Sub
    Public Sub setqty(ByVal v As String)
        qty = v
    End Sub
    Public Sub settotal(ByVal v As String)
        total = v
    End Sub
    Public Sub setdiscount(ByVal v As String)
        discount = v
    End Sub
    Public Sub settotalprice(ByVal v As String)
        totalprice = v
    End Sub
    Public Sub setproductname(ByVal v As String)
        productname = v
    End Sub

    Public Sub setproductdesc(ByVal v As String)
        productdescription = v
    End Sub

    'getters
    Public Function getid()
        Return id
    End Function
    Public Function getproduct()
        Return product
    End Function
    Public Function getproducttype()
        Return productype
    End Function
    Public Function getprice()
        Return price
    End Function
    Public Function get_type()
        Return productype
    End Function
    Public Function getqty()
        Return qty
    End Function
    Public Function gettotal()
        Return total
    End Function
    Public Function getdiscount()
        Return discount
    End Function
    Public Function gettotalprice()
        Return totalprice
    End Function
    Public Function getproductname()
        Return productname
    End Function
    Public Function getproductdesc()
        Return productdescription
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
    Public Sub save_items_transaction(ByVal itemlist As List(Of TransactionItems))

        Try
            Dim introw As Integer
            For introw = 0 To itemlist.Count - 1


                open_connection()
                Dim sql As String = "INSERT INTO tbltransactionitem (transactionid,productid,producttype,productprice,itemqty,producttotal,itemdiscount,totalprice,productname,productdescription) "
                sql += " VALUES(@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10)"
                cmd = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@v1", itemlist(introw).getid)
                cmd.Parameters.AddWithValue("@v2", itemlist(introw).getproduct)
                cmd.Parameters.AddWithValue("@v3", itemlist(introw).getproducttype)
                cmd.Parameters.AddWithValue("@v4", itemlist(introw).getprice)
                cmd.Parameters.AddWithValue("@v5", itemlist(introw).getqty)
                cmd.Parameters.AddWithValue("@v6", itemlist(introw).gettotal)
                cmd.Parameters.AddWithValue("@v7", itemlist(introw).getdiscount)
                cmd.Parameters.AddWithValue("@v8", itemlist(introw).gettotalprice)
                cmd.Parameters.AddWithValue("@v9", itemlist(introw).getproductname)
                cmd.Parameters.AddWithValue("@v10", itemlist(introw).getproductdesc)
                cmd.ExecuteNonQuery()
            Next
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Save Transaction Item:" + ex.Message)
        End Try

    End Sub

    Public Sub update_items(ByVal itemlist As List(Of TransactionItems))
        Try
            Dim introw As Integer
            For introw = 0 To itemlist.Count - 1

                If (itemlist(introw).getproducttype <> "SPECIAL ORDER" And itemlist(introw).getproducttype <> "ADD-ON") Then
                    open_connection()
                    Dim sql As String = "UPDATE tblproducts SET productstock=productstock-@qty "
                    sql += " WHERE productid=@id"
                    cmd = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@qty", itemlist(introw).getqty)
                    cmd.Parameters.AddWithValue("@id", itemlist(introw).getproduct)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    conn.Close()
                ElseIf itemlist(introw).getproducttype = "PACKAGE" Then
                    open_connection()
                    Dim sql As String = "UPDATE tblpackage SET packageqty=packageqty-@qty "
                    sql += " WHERE packageid=@id"
                    cmd = New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@qty", itemlist(introw).getqty)
                    cmd.Parameters.AddWithValue("@id", itemlist(introw).getproduct)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    conn.Close()
                End If

            Next

        Catch ex As Exception
            MsgBox("Update Items: " + ex.Message)
        End Try
    End Sub

    Public Function load_items(ByVal tid) As List(Of TransactionItems)
        Dim itemlist As New List(Of TransactionItems)
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM tbltransactionitem WHERE transactionid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", tid)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim transobj As New TransactionItems
                    transobj.setid(rs(2).ToString)
                    transobj.settype(rs(3).ToString)
                    transobj.setprice(rs(4).ToString)
                    transobj.setqty(rs(5).ToString)
                    transobj.settotal(rs(6).ToString)
                    transobj.setdiscount(rs(7).ToString)
                    transobj.settotalprice(rs(8).ToString)
                    transobj.setproductname(rs(9).ToString)
                    transobj.setproductdesc(rs(10).ToString)
                    itemlist.Add(transobj)
                End While
            Else
                itemlist = Nothing
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()

        Catch ex As Exception
            MsgBox("Transaction Items (load_items):" + ex.Message)
        End Try
        Return itemlist
    End Function
End Class
