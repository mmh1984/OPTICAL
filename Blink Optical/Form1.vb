Imports System.Data.SqlClient

Public Class frmworkorder
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Dim selectedcustomer As String
    Dim readingno As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'userinfo = _userinfo
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxsearchtype.SelectedIndex = 0
        cbxsort.SelectedIndex = 0
        load_customers()
        gbpreshistory.Enabled = False
        gbpres.Enabled = False
        btnprint.Visible = False

    End Sub

    Private Sub btnnewcustomer_Click(sender As Object, e As EventArgs) Handles btnnewcustomer.Click
        Dim customerform As frmcustomer
        customerform = New frmcustomer
        customerform.ShowDialog()

        load_customers()



    End Sub
    'functions
    '1 open connection
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
    Private Sub load_customers()
        Try
            clear_prescription()
            gbpres.Enabled = False
            btnprint.Visible = False
            open_connection()
            Dim sql As String
            sql = "SELECT * FROM tblcustomers WHERE customeric <> 'DELETED' ORDER BY customerid ASC"
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader
            lvprescriptions.Items.Clear()
            If rs.HasRows Then
                lvcustomers.Items.Clear()
                lvcustomers.Enabled = True
                Dim custlist As ListViewItem
                While rs.Read
                    Dim dob As String
                    dob = rs(8).ToString
                    custlist = lvcustomers.Items.Add(rs(0).ToString) 'id
                    custlist.SubItems.Add(rs(1).ToString) 'ic
                    custlist.SubItems.Add(rs(2).ToString) 'name
                    custlist.SubItems.Add(rs(4).ToString) 'mobile
                    custlist.SubItems.Add(rs(7).ToString) 'phone
                    custlist.SubItems.Add(rs(5).ToString) 'gender
                    custlist.SubItems.Add(rs(6).ToString) 'occupation
                    custlist.SubItems.Add(dob) 'dob
                    custlist.SubItems.Add(rs(9).ToString) 'email
                    custlist.SubItems.Add(rs(3).ToString) 'addrss
                End While
                rs.Close()
                cmd.Dispose()
                conn.Close()
            Else
                lvcustomers.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Load customers:" & ex.Message)
        End Try
    End Sub
    '3 search customer
    Private Sub search_customer()
        Try
            gbpreshistory.Enabled = False
            clear_prescription()
            open_connection()
            Dim sql As String = ""
            Select Case cbxsearchtype.Text
                Case "IC"
                    sql = "SELECT * FROM tblcustomers WHERE customeric=@v1"
                Case "Name"
                    sql = "SELECT * FROM tblcustomers WHERE customername LIKE @v1"
                Case "Phone"
                    sql = "SELECT * FROM tblcustomers WHERE customermobile=@v1 or customerphone=@v1"
            End Select
            lvprescriptions.Items.Clear()
            btnprint.Visible = False
            cmd = New SqlCommand(sql, conn)
            If (cbxsearchtype.Text = "Name") Then
                cmd.Parameters.AddWithValue("@v1", "%" + txtsearch.Text + "%")
            Else
                cmd.Parameters.AddWithValue("@v1", txtsearch.Text)
            End If

            rs = cmd.ExecuteReader
            If rs.HasRows Then
                lvcustomers.Items.Clear()
                MessageBox.Show("Search returned results", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lvcustomers.Enabled = True
                Dim custlist As ListViewItem
                While rs.Read
                    Dim dob As String
                    dob = rs(8).ToString
                    custlist = lvcustomers.Items.Add(rs(0).ToString) 'id
                    custlist.SubItems.Add(rs(1).ToString) 'ic
                    custlist.SubItems.Add(rs(2).ToString) 'name
                    custlist.SubItems.Add(rs(4).ToString) 'mobile
                    custlist.SubItems.Add(rs(7).ToString) 'phone
                    custlist.SubItems.Add(rs(5).ToString) 'gender
                    custlist.SubItems.Add(rs(6).ToString) 'occupation
                    custlist.SubItems.Add(dob) 'dob
                    custlist.SubItems.Add(rs(9).ToString) 'email
                    custlist.SubItems.Add(rs(3).ToString) 'addrss
                End While
                rs.Close()
                cmd.Dispose()
                conn.Close()
            Else
                lvcustomers.Enabled = False
                lvcustomers.Items.Clear()
                MessageBox.Show("No results found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Search customers:" & ex.Message)
        End Try
    End Sub

    '4 load prescriptions
    Public Sub load_prescriptions(ByVal id As String)
        Try
            clear_prescription()
            gbpres.Enabled = False
            btnprint.Visible = False
            open_connection()
            Dim sql As String
            sql = "SELECT * FROM tblprescription WHERE customerid=@id AND (pstatus<> 'deleted' or pstatus is null) ORDER BY readingdate DESC"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", id)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                lvprescriptions.Enabled = True
                lvprescriptions.Items.Clear()
                While rs.Read
                    Dim prescriptionlist As ListViewItem
                    Dim rdate As Date
                    rdate = rs(2)
                    prescriptionlist = lvprescriptions.Items.Add(rs(0)) 'id
                    prescriptionlist.SubItems.Add(rdate.ToString("dd-MM-yyyy"))
                    prescriptionlist.SubItems.Add(rs(3).ToString)
                    prescriptionlist.SubItems.Add(rs(4).ToString)
                    prescriptionlist.SubItems.Add(rs(5).ToString)
                    prescriptionlist.SubItems.Add(rs(6).ToString)
                    prescriptionlist.SubItems.Add(rs(7).ToString)
                    prescriptionlist.SubItems.Add(rs(8).ToString)
                    prescriptionlist.SubItems.Add(rs(9).ToString)
                    prescriptionlist.SubItems.Add(rs(10).ToString)
                    prescriptionlist.SubItems.Add(rs(11).ToString)
                    prescriptionlist.SubItems.Add(rs(12).ToString)
                    prescriptionlist.SubItems.Add(rs(13).ToString)
                    prescriptionlist.SubItems.Add(rs(14).ToString)
                    prescriptionlist.SubItems.Add(rs(15).ToString)
                    prescriptionlist.SubItems.Add(rs(16).ToString)
                    prescriptionlist.SubItems.Add(rs(17).ToString)
                    prescriptionlist.SubItems.Add(rs(17).ToString)
                End While
                rs.Close()
                cmd.Dispose()
                conn.Close()

            Else
                'MessageBox.Show("There is no prescription history for this customer. Click on + new prescription to add", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lvprescriptions.Items.Clear()
                lvprescriptions.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Load Prescriptions:" & ex.Message)
        End Try
    End Sub
    Public Sub prescription_details(ByVal id As String)
        Try
            open_connection()
            Dim sql As String
            sql = "SELECT * FROM tblprescription WHERE readingno=@id "
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", id)
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
    Private Sub clear_prescription()
        'RIGHT
        txtsph_r.Text = "0.0"
        txtcyl_r.Text = "0.0"
        txtaxis_r.Text = "0.0"
        txtadd_r.Text = "0.0"

        'LEFT
        txtsph_l.Text = "0.0"
        txtcyl_l.Text = "0.0"
        txtaxis_l.Text = "0.0"
        txtadd_l.Text = "0.0"
        'OTHERS
        txtpd_r.Text = "0.0"
        txtpd_l.Text = "0.0"
        txtpd_ht_r.Text = "0.0"
        txtfr_size.Text = "0.0"
        txtfr_ht.Text = "0.0"
        txtremarks.Text = ""
        txtprescribed.Text = ""
    End Sub

    Private Sub btnrefreshcustomer_Click(sender As Object, e As EventArgs) Handles btnrefreshcustomer.Click
        load_customers()
        txtsearch.Clear()
        cbxsearchtype.SelectedIndex = 0

    End Sub

    Private Sub btnsearchcustomer_Click(sender As Object, e As EventArgs) Handles btnsearchcustomer.Click
        If txtsearch.Text.Length = 0 Then
            MessageBox.Show("Please enter the parameters to search", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            search_customer()
            clear_prescription()
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub lvcustomers_Click(sender As Object, e As EventArgs) Handles lvcustomers.Click

        selectedcustomer = lvcustomers.SelectedItems(0).Text
        load_prescriptions(selectedcustomer)

        gbpreshistory.Enabled = True
        gbpres.Enabled = False
        clear_prescription()
    End Sub

    Private Sub lvcustomers_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvcustomers.MouseDoubleClick


    End Sub

    Private Sub btnnewprescription_Click(sender As Object, e As EventArgs) Handles btnnewprescription.Click
        Dim prescription As frmprescription
        prescription = New frmprescription(selectedcustomer)
        prescription.ShowDialog()
    End Sub

    Private Sub btnrefreshprescription_Click(sender As Object, e As EventArgs) Handles btnrefreshprescription.Click
        load_prescriptions(selectedcustomer)
    End Sub

    Private Sub lvprescriptions_Click(sender As Object, e As EventArgs) Handles lvprescriptions.Click
        readingno = lvprescriptions.SelectedItems(0).Text
        btnprint.Visible = True
        prescription_details(readingno)
        gbpres.Enabled = True
    End Sub

    Private Sub lvprescriptions_DoubleClick(sender As Object, e As EventArgs) Handles lvprescriptions.DoubleClick
        Dim editpres As frmeditprescription
        editpres = New frmeditprescription(selectedcustomer, readingno)

        If editpres.ShowDialog = DialogResult.OK Then
            load_prescriptions(selectedcustomer)
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim transaction As frmtransaction
        transaction = New frmtransaction(selectedcustomer, readingno, frmdashboard.userinfo)
        transaction.ShowDialog()
        cbxsearchtype.SelectedIndex = 0
        cbxsort.SelectedIndex = 0
        load_customers()
        gbpreshistory.Enabled = False
        gbpres.Enabled = False
        btnprint.Visible = False


    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Dim printpres As frmprescriptionreport
        printpres = New frmprescriptionreport(readingno)
        printpres.ShowDialog()
    End Sub

    Private Sub lvcustomers_DoubleClick(sender As Object, e As EventArgs) Handles lvcustomers.DoubleClick
        Dim customerid As String
        customerid = lvcustomers.SelectedItems(0).Text
        Dim editcustomer As frmeditcustomer
        editcustomer = New frmeditcustomer(customerid)
        If (editcustomer.ShowDialog() = DialogResult.OK) Then
            load_customers()
        End If
    End Sub

    Private Sub txtsph_r_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsph_r.KeyPress

    End Sub
End Class
