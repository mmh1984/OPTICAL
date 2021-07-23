Imports System.Data.SqlClient

Public Class frmprescription
    Dim cid As String
    'connection
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Public Sub New(ByVal customerid As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        cid = customerid
    End Sub
    Private Sub frmprescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customer_details()
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

    'customer details
    Private Sub customer_details()
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM tblcustomers WHERE customerid=@id "
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", cid)
            rs = cmd.ExecuteReader
            While rs.Read
                Dim dob As String
                dob = rs(8)
                lblic.Text = rs(1).ToString()
                lblname.Text = rs(2).ToString()
                lbladdress.Text = rs(3).ToString()
                lblmobile.Text = rs(4).ToString()
                lblgender.Text = rs(5).ToString()
                lbloccupation.Text = rs(6).ToString()
                lblphone.Text = rs(7).ToString()
                lbldob.Text = dob
                lblemail.Text = rs(9).ToString()
            End While
            rs.Close()
            cmd.Dispose()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Customer details:" + ex.Message)
        End Try
    End Sub
    Private Function check_errors() As Integer
        Dim interror As Integer = 0
        'RIGHT
        If txtsph_r.Text.Length = 0 Then
            MessageBox.Show("Enter the SPHERE(SPH) value for the right eye", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            interror += 1
        ElseIf txtcyl_r.Text.Length = 0 Then
            MessageBox.Show("Enter the CYLINDER(CYL) value for the right eye", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            interror += 1
        ElseIf txtaxis_r.Text.Length = 0 Then
            MessageBox.Show("Enter the AXIS value for the right eye", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            interror += 1
        ElseIf txtadd_r.Text.Length = 0 Then
            MessageBox.Show("Enter the ADDITION(ADD) value for the right eye", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            interror += 1
            'LEFT
        ElseIf txtsph_l.Text.Length = 0 Then
            MessageBox.Show("Enter the SPHERE(SPH) value for the left eye", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            interror += 1
        ElseIf txtcyl_l.Text.Length = 0 Then
            MessageBox.Show("Enter the CYLINDER(CYL) value for the left eye", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            interror += 1
        ElseIf txtaxis_l.Text.Length = 0 Then
            MessageBox.Show("Enter the AXIS value for the left eye", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            interror += 1
        ElseIf txtadd_l.Text.Length = 0 Then
            MessageBox.Show("Enter the ADDITION(ADD) value for the left eye", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            interror += 1
            'PD
        ElseIf txtpd_r.Text.Length = 0 Then
            MessageBox.Show("Enter the Pupillary Distance (PD) value for the right eye", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            interror += 1
        ElseIf txtpd_l.Text.Length = 0 Then
            MessageBox.Show("Enter the Pupillary Distance (PD) value for the left eye", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            interror += 1
        ElseIf txtpd_ht_r.Text.Length = 0 Then
            MessageBox.Show("Enter the (PD_HT) value", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            interror += 1
        ElseIf txtpd_ht_r.Text.Length = 0 Then
            MessageBox.Show("Enter the (PD_HT) value", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            interror += 1
        ElseIf txtfr_size.Text.Length = 0 Then
            MessageBox.Show("Enter the (FR_SIZE) value", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            interror += 1
        ElseIf txtfr_ht.Text.Length = 0 Then
            MessageBox.Show("Enter the (FR_HT) value", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            interror += 1
        ElseIf txtremarks.Text.Length = 0 Then
            MessageBox.Show("Please enter any remarks", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            interror += 1
        ElseIf txtprescribed.Text.Length = 0 Then
            MessageBox.Show("Prescribed/Read by, cannot be empty", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            interror += 1
        End If
        Return interror

    End Function
    Private Sub save_prescription()
        Try
            open_connection()
            Dim sql As String
            Dim readingdate As Date
            readingdate = Date.Now
            sql = "INSERT INTO tblprescription (customerid,readingdate,sph_r,cyl_r,axis_r,add_r,"
            sql += "sph_l,cyl_l,axis_l,add_l,pd_r,pd_l,pd_ht_r,pd_ht_l,fr_size,fr_height,remarks,prescribed) "
            sql += " VALUES(@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10,@v11,@v12,@v13r,@v13l,@v14,@v15,@v16,@v17)"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@v1", cid)
            cmd.Parameters.AddWithValue("@v2", readingdate.ToString("yyyy-MM-dd"))
            'RIGHT
            cmd.Parameters.AddWithValue("@v3", txtsph_r.Text)
            cmd.Parameters.AddWithValue("@v4", txtcyl_r.Text)
            cmd.Parameters.AddWithValue("@v5", txtaxis_r.Text)
            cmd.Parameters.AddWithValue("@v6", txtadd_r.Text)
            'LEFT
            cmd.Parameters.AddWithValue("@v7", txtsph_l.Text)
            cmd.Parameters.AddWithValue("@v8", txtcyl_l.Text)
            cmd.Parameters.AddWithValue("@v9", txtaxis_l.Text)
            cmd.Parameters.AddWithValue("@v10", txtadd_l.Text)
            'OTHERS
            cmd.Parameters.AddWithValue("@v11", txtpd_r.Text)
            cmd.Parameters.AddWithValue("@v12", txtpd_l.Text)
            cmd.Parameters.AddWithValue("@v13r", txtpd_ht_r.Text)
            cmd.Parameters.AddWithValue("@v13l", txtpd_ht_l.Text)
            cmd.Parameters.AddWithValue("@v14", txtfr_size.Text)
            cmd.Parameters.AddWithValue("@v15", txtfr_ht.Text)
            cmd.Parameters.AddWithValue("@v16", txtremarks.Text)
            cmd.Parameters.AddWithValue("@v17", txtprescribed.Text)

            If (cmd.ExecuteNonQuery) Then
                MessageBox.Show("Prescriptions added", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmd.Dispose()
                conn.Close()
                frmworkorder.load_prescriptions(cid)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Save Prescription:" + ex.Message)
        End Try
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If check_errors() = 0 Then
            save_prescription()
        End If
    End Sub

End Class