Imports System.Data.SqlClient
Public Class Customers
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Dim id, ic, name, address, mobile, gender, occupation, phone, email As String
    Dim dob As String

    Public Sub New()

    End Sub
    'setters
    Public Sub setid(ByVal v As String)
        id = v
    End Sub
    Public Sub setic(ByVal v As String)
        ic = v
    End Sub
    Public Sub setname(ByVal v As String)
        name = v
    End Sub
    Public Sub setaddress(ByVal v As String)
        address = v
    End Sub
    Public Sub setmobile(ByVal v As String)
        mobile = v
    End Sub

    Public Sub setgender(ByVal v As String)
        gender = v
    End Sub
    Public Sub setoccupation(ByVal v As String)
        occupation = v
    End Sub
    Public Sub setphone(ByVal v As String)
        phone = v
    End Sub
    Public Sub setemail(ByVal v As String)
        email = v
    End Sub
    Public Sub setdob(ByVal v As String)
        dob = v
    End Sub
    'getters
    Public Function getid()
        Return id
    End Function

    Public Function getic()
        Return ic
    End Function
    Public Function getname()
        Return name
    End Function
    Public Function getaddress()
        Return address
    End Function
    Public Function getmobile()
        Return mobile
    End Function
    Public Function getgender()
        Return gender
    End Function
    Public Function getoccupation()
        Return occupation
    End Function
    Public Function getphone()
        Return phone
    End Function
    Public Function getdob()
        Return dob
    End Function
    Public Function getemail()
        Return email
    End Function
    'methods
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

    Public Function get_customers() As List(Of Customers)
        Dim customerlist As New List(Of Customers)
        Try

            open_connection()
            Dim sql As String
            sql = "SELECT * From tblcustomers WHERE customeric <> 'DELETED' ORDER BY customername ASC"
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim customerobj As New Customers
                    customerobj.setid(rs(0).ToString)
                    customerobj.setic(rs(1).ToString)
                    customerobj.setname(rs(2).ToString)
                    customerobj.setaddress(rs(3).ToString)
                    customerobj.setmobile(rs(4).ToString)
                    customerobj.setgender(rs(5).ToString)
                    customerobj.setoccupation(rs(6).ToString)
                    customerobj.setphone(rs(7).ToString)
                    customerobj.setdob(rs(8).ToString)
                    customerobj.setemail(rs(9).ToString)
                    customerlist.Add(customerobj)
                End While
            Else
                customerlist = Nothing
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Customer Class(get customers):" + ex.Message)
        End Try
        Return customerlist

    End Function
    Public Sub delete_customer(ByVal key1 As String)
        Try
            open_connection()
            Dim sql As String = "UPDATE tblcustomers SET customeric='DELETED'"
            sql += " WHERE customerid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", key1)
            If cmd.ExecuteNonQuery Then
                MsgBox("Customer deleted")
            End If
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Delete Customer:" + ex.Message)
        End Try
    End Sub
    Public Function search_customer(ByVal keyword As String) As List(Of Customers)
        Dim customerlist As New List(Of Customers)
        Try

            open_connection()
            Dim sql As String
            sql = "SELECT * From tblcustomers WHERE customername LIKE @name"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@name", "%" + keyword + "%")
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim customerobj As New Customers
                    customerobj.setid(rs(0).ToString)
                    customerobj.setic(rs(1).ToString)
                    customerobj.setname(rs(2).ToString)
                    customerobj.setaddress(rs(3).ToString)
                    customerobj.setmobile(rs(4).ToString)
                    customerobj.setgender(rs(5).ToString)
                    customerobj.setoccupation(rs(6).ToString)
                    customerobj.setphone(rs(7).ToString)
                    customerobj.setdob(rs(8).ToString)
                    customerobj.setemail(rs(9).ToString)
                    customerlist.Add(customerobj)
                End While
            Else
                customerlist = Nothing
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Customer Class(get customers):" + ex.Message)
        End Try
        Return customerlist

    End Function
    Public Function transaction_reminder()
        Dim customerlist As New List(Of Customers)
        Dim count As Integer
        open_connection()

        Try
            Dim sql As String = "SELECT DISTINCT 
c.customerid,c.customeric,c.customername,c.customeraddress, c.customermobile,c.customerphone,t.transactiondate  FROM tblcustomers AS C,tbltransaction as t
WHERE (MONTH(t.transactiondate)=MONTH(GETDATE())  AND Datediff(year,t.transactiondate,GETDATE()) > 0) 
AND t.customerid =c.customerid "
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While rs.Read
                    Dim obj1 As New Customers
                    obj1.setid(rs(0))
                    obj1.setic(rs(1))
                    obj1.setname(rs(2))
                    obj1.setaddress(rs(3))
                    obj1.setmobile(rs(4))
                    obj1.setphone(rs(5))
                    Dim tdate As Date = rs(6)
                    obj1.setdob(tdate.ToString("dd-MM-yyyy"))
                    customerlist.Add(obj1)
                End While
            End If
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Transaction reminder:" + ex.Message)
        End Try
        Return customerlist
    End Function
End Class
