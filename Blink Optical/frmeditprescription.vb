Imports System.Data.SqlClient

Public Class frmeditprescription
    Dim cid, rid As String
    'connection
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Public Sub New(ByVal _cid As String, ByVal _rid As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        rid = _rid
        cid = _cid
    End Sub
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
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

    Private Sub frmeditprescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customer_details()
        prescription_details()

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
        ElseIf txtpd_ht_r.Text.Length = 0 Or txtpd_ht_l.Text.Length = 0 Then
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
    Private Sub update_prescription()
        Try
            open_connection()
            Dim sql As String
            Dim readingdate As Date
            readingdate = Date.Now
            sql = "UPDATE tblprescription SET sph_r=@v3,cyl_r=@v4,axis_r=@v5,add_r=@v6,"
            sql += "sph_l=@v7,cyl_l=@v8,axis_l=@v9,add_l=@v10,"
            sql += "pd_r=@v11,pd_l=@v12,pd_ht_r=@v13r,pd_ht_l=@v13l,fr_size=@v14,"
            sql += "fr_height=@v15,remarks=@v16,prescribed=@v17 "
            sql += " WHERE readingno=@rno AND customerid=@cid"
            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@rno", rid)
            cmd.Parameters.AddWithValue("@cid", cid)
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
                MessageBox.Show("Prescriptions Updated", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmd.Dispose()
                conn.Close()

                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Update Prescription:" + ex.Message)
        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If (check_errors() = 0) Then
            update_prescription()

        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            Dim x As Integer
            x = MessageBox.Show("Deleting this prescription will also delete the work order/receipt linked to it", "Optical Shop POS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If x = vbYes Then
                Dim confirm As frmconfirmation
                confirm = New frmconfirmation()

                Dim a As Integer = confirm.ShowDialog

                If (confirm.status = 1) Then
                    delete_prescription()
                Else
                    MessageBox.Show("Incorrect Credentials", "Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Delete Prescription:" + ex.Message)
        End Try
    End Sub
    Private Sub delete_prescription()
        Try
            open_connection()
            Dim sql As String
            sql = "UPDATE tblprescription SET pstatus='deleted' WHERE readingno=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", rid)
            If (cmd.ExecuteNonQuery) Then
                MessageBox.Show("Prescriptions Deleted", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'delete the productid from the transaction
                cmd.Dispose()
                conn.Close()
                frmworkorder.load_prescriptions(cid)

                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Delete Prescription" + ex.Message)
        End Try
    End Sub

    'prescription
    Private Sub prescription_details()
        Try
            open_connection()
            Dim sql As String
            sql = "SELECT * FROM tblprescription WHERE readingno=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", rid)
            rs = cmd.ExecuteReader
            If rs.HasRows Then

                While rs.Read
                    'RIGHT
                    txtsph_r.Text = rs(3).ToString()
                    txtcyl_r.Text = rs(4).ToString()
                    txtaxis_r.Text = rs(5).ToString()
                    txtadd_r.Text = rs(6).ToString()

                    'LEFT
                    txtsph_l.Text = rs(7).ToString()
                    txtcyl_l.Text = rs(8).ToString()
                    txtaxis_l.Text = rs(9).ToString()
                    txtadd_l.Text = rs(10).ToString()
                    'OTHERS
                    txtpd_r.Text = rs(11).ToString()
                    txtpd_l.Text = rs(12).ToString()
                    txtpd_ht_r.Text = rs(13).ToString()
                    txtpd_ht_l.Text = rs(14).ToString()
                    txtfr_size.Text = rs(15).ToString()
                    txtfr_ht.Text = rs(16).ToString()
                    txtremarks.Text = rs(17).ToString()
                    txtprescribed.Text = rs(18).ToString()
                End While
                rs.Close()
                cmd.Dispose()
                conn.Close()


            End If
        Catch ex As Exception
            MessageBox.Show("Prescription details:" & ex.Message)
        End Try
    End Sub
End Class