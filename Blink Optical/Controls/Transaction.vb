Imports System.Data.SqlClient
Public Class Transaction
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Dim id, customer, reading, tdate, sizeandbridge, edged, issued, method, bank, pos As String
    Dim payable, deposit, balance As Decimal
    Dim deliverydate, transactiondate As Date
    Public Sub New()

    End Sub
    Public Sub setid(ByVal v As String)
        id = v

    End Sub
    Public Sub setcustomer(ByVal v As String)
        customer = v

    End Sub
    Public Sub setreading(ByVal v As String)
        reading = v

    End Sub
    Public Sub setsizebridge(ByVal v As String)
        sizeandbridge = v

    End Sub
    Public Sub setdeliverydate(ByVal v As String)
        deliverydate = Convert.ToDateTime(v)

    End Sub
    Public Sub settransdate(ByVal v As String)
        transactiondate = Convert.ToDateTime(v)

    End Sub
    Public Sub setedged(ByVal v As String)
        edged = v

    End Sub

    Public Sub setissued(ByVal v As String)
        issued = v

    End Sub


    Public Sub setpayable(ByVal v As String)
        payable = Convert.ToDecimal(v)

    End Sub
    Public Sub setdeposit(ByVal v As String)
        deposit = Convert.ToDecimal(v)

    End Sub

    Public Sub setbalance(ByVal v As String)
        balance = Convert.ToDecimal(v)

    End Sub
    Public Sub setmethod(ByVal v As String)
        method = v

    End Sub
    Public Sub setbank(ByVal v As String)
        bank = v

    End Sub
    Public Sub setpos(ByVal v As String)
        pos = v

    End Sub
    'getters
    Public Function getid()
        Return id
    End Function
    Public Function getcustomer()
        Return customer

    End Function
    Public Function getreading()
        Return reading

    End Function
    Public Function getsizebridge()
        Return sizeandbridge
    End Function
    Public Function getdeliverydate()
        Return deliverydate
    End Function
    Public Function gettransdate()
        Return transactiondate
    End Function
    Public Function getedged()
        Return edged
    End Function

    Public Function getissued()
        Return issued
    End Function
    Public Function getpayable()
        Return payable
    End Function
    Public Function getdeposit()
        Return deposit
    End Function

    Public Function getbalance()
        Return balance
    End Function
    Public Function getmethod()
        Return method
    End Function
    Public Function getbank()
        Return bank
    End Function
    Public Function getpos()
        Return pos
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
    Public Function get_id() As Integer
        Dim receiptno As Integer = 0
        Try
            open_connection()
            Dim sql As String = "SELECT TOP 1 * FROM tbltransaction ORDER BY transactionid DESC"
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    receiptno = rs(0).ToString
                End While
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Get ID:" + ex.Message)
        End Try
        Return receiptno
    End Function

    Public Function save_transaction_details() As Boolean
        Dim status = False
        Try
            open_connection()

            Dim sql As String
            sql = "INSERT INTO tbltransaction(customerid,readingno,sizeandbridge,deliverydate,transactiondate,edgedby,issuedby,payableamount,depositamount,balanceamount,paymentmethod,bankname,transactionstatus,pos) "
            sql += "VALUES (@v1,@v2,@v3,@v3_1,@v3_2,@v4,@v5,@v6,@v7,@v8,@v9,@v10,@v11,@v12)"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@v1", customer)
            cmd.Parameters.AddWithValue("@v2", reading)
            cmd.Parameters.AddWithValue("@v3", sizeandbridge)
            cmd.Parameters.AddWithValue("@v3_1", deliverydate.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@v3_2", Date.Now.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@v4", edged)
            cmd.Parameters.AddWithValue("@v5", issued)
            cmd.Parameters.AddWithValue("@v6", payable)
            cmd.Parameters.AddWithValue("@v7", deposit)
            cmd.Parameters.AddWithValue("@v8", balance)
            cmd.Parameters.AddWithValue("@v9", method)
            cmd.Parameters.AddWithValue("@v10", bank)
            cmd.Parameters.AddWithValue("@v11", "paid")
            cmd.Parameters.AddWithValue("@v12", pos)
            If cmd.ExecuteNonQuery Then

                status = True
            End If
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Transaction save:" + ex.Message)
        End Try
        Return status
    End Function

    Public Function load_transactions() As List(Of Transaction)
        Dim tlist As New List(Of Transaction)
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM tbltransaction ORDER BY transactionid DESC "
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim transactionobj As New Transaction
                    transactionobj.setid(rs(0).ToString)
                    transactionobj.setcustomer(rs(1).ToString)
                    transactionobj.setreading(rs(2).ToString)
                    transactionobj.setsizebridge(rs(3).ToString)
                    transactionobj.setdeliverydate(rs(4).ToString)
                    transactionobj.settransdate(rs(5).ToString)
                    transactionobj.setedged(rs(6).ToString)
                    transactionobj.setissued(rs(7).ToString)
                    transactionobj.setpayable(rs(8).ToString)
                    transactionobj.setdeposit(rs(9).ToString)
                    transactionobj.setbalance(rs(10).ToString)
                    transactionobj.setmethod(rs(11).ToString)
                    transactionobj.setbank(rs(12).ToString)
                    transactionobj.setpos(rs(14).ToString)
                    tlist.Add(transactionobj)
                End While

            Else
                tlist = Nothing
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Transaction (load)" + ex.Message)
        End Try
        Return tlist
    End Function


    Public Function search_transaction_date(ByVal startd As Date, ByVal endd As Date) As List(Of Transaction)
        Dim tlist As New List(Of Transaction)
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM tbltransaction "
            sql += " WHERE transactiondate >= @start AND  transactiondate <=@end ORDER BY transactiondate ASC "
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@start", startd)
            cmd.Parameters.AddWithValue("@end", endd)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim transactionobj As New Transaction
                    transactionobj.setid(rs(0).ToString)
                    transactionobj.setcustomer(rs(1).ToString)
                    transactionobj.setreading(rs(2).ToString)
                    transactionobj.setsizebridge(rs(3).ToString)
                    transactionobj.setdeliverydate(rs(4).ToString)
                    transactionobj.settransdate(rs(5).ToString)
                    transactionobj.setedged(rs(6).ToString)
                    transactionobj.setissued(rs(7).ToString)
                    transactionobj.setpayable(rs(8).ToString)
                    transactionobj.setdeposit(rs(9).ToString)
                    transactionobj.setbalance(rs(10).ToString)
                    transactionobj.setmethod(rs(11).ToString)
                    transactionobj.setbank(rs(12).ToString)
                    transactionobj.setpos(rs(14).ToString)
                    tlist.Add(transactionobj)
                End While

            Else
                tlist = Nothing
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Transaction (load)" + ex.Message)
        End Try
        Return tlist
    End Function

    Public Function search_transaction_receipt(ByVal no As String) As List(Of Transaction)
        Dim tlist As New List(Of Transaction)
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM tbltransaction "
            sql += "WHERE transactionid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", no)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim transactionobj As New Transaction
                    transactionobj.setid(rs(0).ToString)
                    transactionobj.setcustomer(rs(1).ToString)
                    transactionobj.setreading(rs(2).ToString)
                    transactionobj.setsizebridge(rs(3).ToString)
                    transactionobj.setdeliverydate(rs(4).ToString)
                    transactionobj.settransdate(rs(5).ToString)
                    transactionobj.setedged(rs(6).ToString)
                    transactionobj.setissued(rs(7).ToString)
                    transactionobj.setpayable(rs(8).ToString)
                    transactionobj.setdeposit(rs(9).ToString)
                    transactionobj.setbalance(rs(10).ToString)
                    transactionobj.setmethod(rs(11).ToString)
                    transactionobj.setbank(rs(12).ToString)
                    transactionobj.setpos(rs(14).ToString)
                    tlist.Add(transactionobj)
                End While

            Else
                tlist = Nothing
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Transaction (load)" + ex.Message)
        End Try
        Return tlist
    End Function

    Public Function search_transaction_customer(ByVal no As String) As List(Of Transaction)
        Dim tlist As New List(Of Transaction)
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM tbltransaction "
            sql += "WHERE customerid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", no)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim transactionobj As New Transaction
                    transactionobj.setid(rs(0).ToString)
                    transactionobj.setcustomer(rs(1).ToString)
                    transactionobj.setreading(rs(2).ToString)
                    transactionobj.setsizebridge(rs(3).ToString)
                    transactionobj.setdeliverydate(rs(4).ToString)
                    transactionobj.settransdate(rs(5).ToString)
                    transactionobj.setedged(rs(6).ToString)
                    transactionobj.setissued(rs(7).ToString)
                    transactionobj.setpayable(rs(8).ToString)
                    transactionobj.setdeposit(rs(9).ToString)
                    transactionobj.setbalance(rs(10).ToString)
                    transactionobj.setmethod(rs(11).ToString)
                    transactionobj.setbank(rs(12).ToString)
                    transactionobj.setpos(rs(14).ToString)
                    tlist.Add(transactionobj)
                End While

            Else
                tlist = Nothing
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Transaction (customer)" + ex.Message)
        End Try
        Return tlist
    End Function

    Public Function search_transaction_issued(ByVal no As String) As List(Of Transaction)
        Dim tlist As New List(Of Transaction)
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM tbltransaction "
            sql += "WHERE issuedby=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", no)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim transactionobj As New Transaction
                    transactionobj.setid(rs(0).ToString)
                    transactionobj.setcustomer(rs(1).ToString)
                    transactionobj.setreading(rs(2).ToString)
                    transactionobj.setsizebridge(rs(3).ToString)
                    transactionobj.setdeliverydate(rs(4).ToString)
                    transactionobj.settransdate(rs(5).ToString)
                    transactionobj.setedged(rs(6).ToString)
                    transactionobj.setissued(rs(7).ToString)
                    transactionobj.setpayable(rs(8).ToString)
                    transactionobj.setdeposit(rs(9).ToString)
                    transactionobj.setbalance(rs(10).ToString)
                    transactionobj.setmethod(rs(11).ToString)
                    transactionobj.setbank(rs(12).ToString)
                    transactionobj.setpos(rs(14).ToString)
                    tlist.Add(transactionobj)
                End While

            Else
                tlist = Nothing
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Transaction (customer)" + ex.Message)
        End Try
        Return tlist
    End Function

    Public Function update_payment(ByVal key1 As Decimal, ByVal key2 As String)
        Dim bool As Boolean = False
        Try
            open_connection()
            Dim sql As String = "UPDATE tbltransaction set depositamount=depositamount+@key1, balanceamount=balanceamount-@key1 "
            sql += " WHERE transactionid=@key2"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@key1", key1)
            cmd.Parameters.AddWithValue("@key2", key2)
            If cmd.ExecuteNonQuery Then
                bool = True
            End If
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Update Payment:" + ex.Message)
        End Try
        Return bool
    End Function

    Public Function get_amount()
        Dim amountlist As New List(Of Decimal)
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM tbltransaction WHERE transactiondate=@date"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"))
            rs = cmd.ExecuteReader
            Dim total, balance, deposit As Decimal
            If rs.HasRows Then
                While rs.Read
                    total += rs(8)
                    deposit += rs(9)
                    balance += rs(10)
                End While
                amountlist.Add(total)
                amountlist.Add(deposit)
                amountlist.Add(balance)

            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Amount:" + ex.Message)
        End Try
        Return amountlist
    End Function

End Class
