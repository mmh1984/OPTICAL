Imports System.Data.SqlClient

Public Class frmcustomer
    'connection
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Dim datetoday As Date

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub frmcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxgender.SelectedIndex = 0

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If (check_errors() = 0) Then
            If (user_exists() = False) Then

                save_customer()
            End If

        End If
    End Sub
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
            Me.Close()
        End Try
    End Sub
    '1) VALIDATE ERRORS
    Private Function check_errors() As Integer
        Dim interror As Integer = 0
        'If txtic.Text.Length = 0 Or txtic.Text.Length < 8 Then
        'MessageBox.Show("IC number must not be less than 8 characters (e.g: 00000000)", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'interror += 1
        If txtname.Text.Length = 0 Then
            MessageBox.Show("Please enter the customer's name", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Error)
            interror += 1
            'ElseIf txtaddress.Text.Length = 0 Then
            'MessageBox.Show("Please enter the customer's address", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'interror += 1
        ElseIf txtmobile.Text.Length = 0 Then
            MessageBox.Show("Please enter the customer's mobile number", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Error)
            interror += 1
        ElseIf txtdob.MaskCompleted = False Then
            datetoday = Today
            'MessageBox.Show("Please enter the customer's date of birth (dd-MM-yyyy)", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'interror += 1
            'ElseIf (validate_date() = False) Then
            'MessageBox.Show("Incorrect date format (dd-MM-yyyy)", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


        Return interror
    End Function
    '2 VALIDATE THE DATE
    Private Function validate_date() As Boolean
        Dim valid As Boolean = True
        Dim m, d, y As Integer
        Dim strdate As String = txtdob.Text

        'if first digit is 0 get the 2nd digit
        If strdate.Substring(0, 1) = "0" Then
            d = strdate.Substring(1, 1)
        Else
            d = strdate.Substring(0, 2)
        End If


        'if first digit is 0 get the 2nd digit
        If strdate.Substring(0, 3) = "0" Then
            m = strdate.Substring(4, 1)
        Else
            m = strdate.Substring(3, 2)
        End If

        y = strdate.Substring(6, 4)

        'check if dob is valid
        If (d <= 0 And d > 31) Then
            valid = False
        ElseIf (m <= 0 And m > 12) Then
            valid = False
        ElseIf (y > Now.Year) Then
            valid = False
        End If


        Return valid
    End Function

    '3 SAVE CUSTOMER
    Private Sub save_customer()
        Try
            open_connection()
            Dim sql As String
            sql = "INSERT INTO tblcustomers(customeric,customername,customeraddress,customermobile,customergender,customeroccupation,customerphone,customerdob,customeremail) "
            sql += "VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9)"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@v1", txtic.Text)
            cmd.Parameters.AddWithValue("@v2", txtname.Text)
            cmd.Parameters.AddWithValue("@v3", txtaddress.Text)
            cmd.Parameters.AddWithValue("@v4", txtmobile.Text)
            cmd.Parameters.AddWithValue("@v5", cbxgender.SelectedItem)
            cmd.Parameters.AddWithValue("@v6", txtoccupation.Text)
            cmd.Parameters.AddWithValue("@v7", txtphone.Text)
            'Dim dob As Date
            'Dim strdate As String = txtdob.Text
            'dob = strdate.Substring(6, 4) + "-" + strdate.Substring(3, 2) + "-" + strdate.Substring(0, 2)
            If txtdob.MaskCompleted = False Then
                cmd.Parameters.AddWithValue("@v8", datetoday.ToString("dd-MM-yyyy"))
            Else
                Dim dob As Date = txtdob.Text
                cmd.Parameters.AddWithValue("@v8", dob.ToString("dd-MM-yyyy"))

            End If

            cmd.Parameters.AddWithValue("@v9", txtemail.Text)
            If (cmd.ExecuteNonQuery()) Then
                MessageBox.Show("New customer added!", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmd.Dispose()
                conn.Close()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Save customer:" + ex.Message)
        End Try
    End Sub

    Private Function user_exists() As Boolean
        Dim exists As Boolean = False
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM tblcustomers WHERE customername=@v1 and customermobile=@v2"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@v1", txtname.Text)
            cmd.Parameters.AddWithValue("@v2", txtmobile.Text)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                MessageBox.Show("This user already exists", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                exists = True
            End If

            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("user exists:" + ex.Message)
        End Try

        Return exists
    End Function

End Class