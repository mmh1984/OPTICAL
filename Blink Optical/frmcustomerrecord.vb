Public Class frmcustomerrecord
    Dim customerlist As List(Of Customers)
    Dim lvcustomeritem As ListViewItem
    Dim transactionlist As New List(Of Transaction)
    Dim customerid As String
    Dim transactionitems As ListViewItem
    Dim total, deposit, balance As Decimal
    Private Sub frmcustomerrecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bwload_customers.RunWorkerAsync()
        btnprinttransaction.Visible = False
        btndeletecustomer.Visible = False
        view_reminder()
    End Sub
    Private Sub view_reminder()
        Try
            Dim obj1 As New List(Of Customers)
            Dim custobj As New Customers
            obj1 = custobj.transaction_reminder
            If obj1 IsNot Nothing Then
                lblreminder.Text = obj1.Count
                btnviewreminder.Enabled = True
            Else
                btnviewreminder.Enabled = False
            End If

        Catch ex As Exception
            MsgBox("Customer Reminder:" + ex.Message)
        End Try
    End Sub
    Private Sub bwload_customers_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
        Try
            customerlist = New List(Of Customers)
            Dim customerobj As New Customers
            customerlist = customerobj.get_customers

        Catch ex As Exception
            MsgBox("BW load customers: " + ex.Message)
        End Try

    End Sub

    Private Sub bwload_customers_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs)

    End Sub
    Private Sub load_customers()
        Try
            If customerlist IsNot Nothing Then
                lvcustomers.Items.Clear()
                lvcustomers.Enabled = True
                Dim x As Integer
                For x = 0 To customerlist.Count - 1
                    lvcustomeritem = lvcustomers.Items.Add(customerlist(x).getid)
                    lvcustomeritem.SubItems.Add(customerlist(x).getic)
                    lvcustomeritem.SubItems.Add(customerlist(x).getname)
                    lvcustomeritem.SubItems.Add(customerlist(x).getaddress)
                    lvcustomeritem.SubItems.Add(customerlist(x).getmobile)
                    lvcustomeritem.SubItems.Add(customerlist(x).getgender)
                    lvcustomeritem.SubItems.Add(customerlist(x).getoccupation)
                    lvcustomeritem.SubItems.Add(customerlist(x).getphone)
                    lvcustomeritem.SubItems.Add(customerlist(x).getdob)
                    lvcustomeritem.SubItems.Add(customerlist(x).getemail)
                Next
                lbltotalcustomer.Text = customerlist.Count
            Else
                MsgBox("No customer record")
                lvcustomers.Items.Clear()
                lvcustomers.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Load customers:" + ex.Message)
        End Try
    End Sub

    Private Sub lvcustomers_Click(sender As Object, e As EventArgs) Handles lvcustomers.Click
        If lvcustomers.Items.Count > 0 Then

            customerid = lvcustomers.SelectedItems(0).Text
            btndeletecustomer.Visible = True
            bwload_transactions.RunWorkerAsync()



        End If
    End Sub

    Private Sub load_transaction()
        Try
            If transactionlist IsNot Nothing Then
                lvtransactions.Items.Clear()
                btnprinttransaction.Visible = True
                Dim x As Integer
                total = 0
                deposit = 0
                balance = 0
                For x = 0 To transactionlist.Count - 1
                    transactionitems = lvtransactions.Items.Add(transactionlist(x).getid)
                    transactionitems.SubItems.Add(transactionlist(x).gettransdate)
                    transactionitems.SubItems.Add(transactionlist(x).getissued)
                    transactionitems.SubItems.Add(transactionlist(x).getpayable)
                    transactionitems.SubItems.Add(transactionlist(x).getdeposit)
                    transactionitems.SubItems.Add(transactionlist(x).getbalance)
                    transactionitems.SubItems.Add(transactionlist(x).getmethod)
                    transactionitems.SubItems.Add(transactionlist(x).getbank)
                    total += transactionlist(x).getpayable
                    deposit += transactionlist(x).getdeposit
                    balance += transactionlist(x).getbalance
                Next
                lbltotal.Text = total.ToString("C")
                lbltransaction.Text = transactionlist.Count
            Else
                MsgBox("No transactions for this customer")
                lvtransactions.Items.Clear()
                lbltotal.Text = "0"
                lbltransaction.Text = "0"
                btnprinttransaction.Visible = False
            End If
        Catch ex As Exception
            MsgBox("Load transaction: " + ex.Message)
        End Try
    End Sub

    Private Sub bwload_transactions_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwload_transactions.DoWork
        Try
            Dim transactionobj As New Transaction
            transactionlist = transactionobj.search_transaction_customer(customerid)
        Catch ex As Exception
            MsgBox("load transactions: " + ex.Message)
        End Try
    End Sub

    Private Sub bwload_transactions_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwload_transactions.RunWorkerCompleted
        load_transaction()
    End Sub

    Private Sub bwload_customers_DoWork_1(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwload_customers.DoWork
        Try
            Dim customerobj As New Customers
            customerlist = customerobj.get_customers
        Catch ex As Exception
            MsgBox("load customer: " + ex.Message)
        End Try
    End Sub

    Private Sub bwload_customers_RunWorkerCompleted_1(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwload_customers.RunWorkerCompleted
        load_customers()
    End Sub

    Private Sub btnprintcustomers_Click(sender As Object, e As EventArgs) Handles btnprintcustomers.Click
        Dim customerrecord As New frmcustomerreport
        customerrecord.ShowDialog()
    End Sub

    Private Sub btnprinttransaction_Click(sender As Object, e As EventArgs) Handles btnprinttransaction.Click
        Dim customertransaction As New frmcustomertransaction(customerid)
        Dim amountlist As New List(Of Decimal)
        amountlist.Add(total)
        amountlist.Add(deposit)
        amountlist.Add(balance)
        customertransaction.amountlist = amountlist
        customertransaction.ShowDialog()
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtsearch.Text.Length = 0 Then
                MsgBox("Please enter the customer name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtsearch.Focus()
            Else
                search_customer()
            End If
        End If
    End Sub
    Private Sub search_customer()
        Try
            customerlist = New List(Of Customers)
            Dim customerobj As New Customers
            customerlist = customerobj.search_customer(txtsearch.Text)
            If customerlist IsNot Nothing Then
                lvcustomers.Items.Clear()
                lvcustomers.Enabled = True
                txtsearch.Clear()
                Dim x As Integer
                For x = 0 To customerlist.Count - 1
                    lvcustomeritem = lvcustomers.Items.Add(customerlist(x).getid)
                    lvcustomeritem.SubItems.Add(customerlist(x).getic)
                    lvcustomeritem.SubItems.Add(customerlist(x).getname)
                    lvcustomeritem.SubItems.Add(customerlist(x).getaddress)
                    lvcustomeritem.SubItems.Add(customerlist(x).getmobile)
                    lvcustomeritem.SubItems.Add(customerlist(x).getgender)
                    lvcustomeritem.SubItems.Add(customerlist(x).getoccupation)
                    lvcustomeritem.SubItems.Add(customerlist(x).getphone)
                    lvcustomeritem.SubItems.Add(customerlist(x).getdob)
                    lvcustomeritem.SubItems.Add(customerlist(x).getemail)
                Next
                lbltotalcustomer.Text = customerlist.Count
            Else
                MsgBox("No customer found")
                lvcustomers.Items.Clear()
                lvcustomers.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Search customer:" + ex.Message)
        End Try
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        bwload_customers.RunWorkerAsync()
    End Sub

    Private Sub btndeletecustomer_Click(sender As Object, e As EventArgs) Handles btndeletecustomer.Click
        Try
            Dim x As Integer
            x = MessageBox.Show("Deleting this customer will also delete the work order/receipt linked to it", "Optical Shop POS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If x = vbYes Then
                Dim confirm As frmconfirmation
                confirm = New frmconfirmation()

                Dim a As Integer = confirm.ShowDialog

                If (confirm.status = 1) Then
                    Dim obj1 As New Customers
                    obj1.delete_customer(customerid)
                    btndeletecustomer.Visible = False
                    bwload_customers.RunWorkerAsync()
                Else
                    MessageBox.Show("Incorrect Credentials", "Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Delete Prescription:" + ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnviewreminder.Click
        Dim reminder As New frmreminder
        reminder.ShowDialog()
    End Sub
End Class