Imports System.Threading

Public Class frmtransactionhistory
    Dim translist As List(Of Transaction)
    Dim transitems As ListViewItem
    Dim receiptlist As List(Of TransactionItems)
    Dim receiptitems As ListViewItem
    Dim datestart, dateend As Date
    Dim totaltransaction, cashpayment, cardpayment, totalitems As Integer
    Dim totalamount, totalprice, totaldeposit, totalbalance As Decimal
    Dim operation As String
    Dim receiptno, transactiontype As String
    Dim bibd, scb, baiduri, others As Integer

    Private Sub frmtransactionhistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bwload_transactions.RunWorkerAsync()
        btnprintreceipt.Visible = False
        btnupdate.Visible = False
    End Sub

    Private Sub load_transaction()
        Try
            operation = "all"
            totalitems = 0
            totalprice = 0
            totalbalance = 0
            totaldeposit = 0
            bibd = 0
            scb = 0
            baiduri = 0
            others = 0
            lbltotalprice.Text = "0"
            lbltotalproduct.Text = "0"
            lvproductlist.Items.Clear()
            If translist IsNot Nothing Then
                lvtransactionlist.Items.Clear()
                lvtransactionlist.Enabled = True
                Dim x As Integer
                totalamount = 0
                totaltransaction = 0
                cashpayment = 0
                cardpayment = 0
                For x = 0 To translist.Count - 1
                    totaltransaction += 1
                    totalamount += translist(x).getpayable
                    totaldeposit += translist(x).getdeposit
                    totalbalance += translist(x).getbalance
                    transitems = lvtransactionlist.Items.Add(translist(x).gettransdate)
                    transitems.SubItems.Add(translist(x).getid)
                    transitems.SubItems.Add(translist(x).getissued)
                    transitems.SubItems.Add(translist(x).getpayable)
                    transitems.SubItems.Add(translist(x).getdeposit)
                    transitems.SubItems.Add(translist(x).getbalance)
                    transitems.SubItems.Add(translist(x).getmethod)
                    transitems.SubItems.Add(translist(x).getbank)
                    transitems.SubItems.Add(translist(x).getpos)
                    If translist(x).getmethod.ToString.Contains("CASH") Then
                        cashpayment += 1
                    Else
                        cardpayment += 1
                        update_bank(translist(x).getbank)
                    End If
                Next

            Else
                totalamount = 0
                totaltransaction = 0
                cashpayment = 0
                cardpayment = 0
                btnprintreceipt.Visible = False
                MsgBox("No transaction found")

                lvtransactionlist.Enabled = False
                lvtransactionlist.Items.Clear()
            End If
            update_stats()
        Catch ex As Exception
            MsgBox("Transaction History (load_transaction): " + ex.Message)
        End Try
    End Sub
    Private Sub update_bank(ByVal bankname As String)
        Try
            Select Case bankname
                Case "BIBD"
                    bibd += 1
                Case "SCB"
                    scb += 1
                Case "BAIDURI"
                    scb += 1
                Case Else
                    others += 1
            End Select
        Catch ex As Exception
            MsgBox("update bank:" + ex.Message)
        End Try

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwload_transactions.DoWork
        Dim transactionobj As New Transaction
        translist = New List(Of Transaction)
        translist = transactionobj.load_transactions
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwload_transactions.ProgressChanged

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwload_transactions.RunWorkerCompleted
        load_transaction()
    End Sub

    Private Sub btnapply_Click(sender As Object, e As EventArgs) Handles btnapply.Click
        Try

            datestart = Convert.ToDateTime(dtstart.Value)
            dateend = Convert.ToDateTime(dtend.Value)

            If DateDiff(DateInterval.Day, Today, datestart) > 0 Then
                MsgBox("Date cannot be greater than today")
            ElseIf DateDiff(DateInterval.Day, dateend, datestart) > 0 Then
                MsgBox("End date must be greater than start date")
            ElseIf DateDiff(DateInterval.Day, Today, dateend) > 0 Then
                MsgBox("End date must not exceed today's date")
            Else
                datestart = datestart.ToShortDateString
                dateend = dateend.ToShortDateString
                search_date()

            End If
        Catch ex As Exception
            MsgBox("Search date: " + ex.Message)
        End Try

    End Sub

    Private Sub lvtransactionlist_DoubleClick(sender As Object, e As EventArgs) Handles lvtransactionlist.DoubleClick

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            Dim list1 As New List(Of String)
            list1.Add(lvtransactionlist.SelectedItems(0).SubItems(1).Text) 'id
            list1.Add(lvtransactionlist.SelectedItems(0).SubItems(3).Text) 'total
            list1.Add(lvtransactionlist.SelectedItems(0).SubItems(4).Text) 'deposit
            list1.Add(lvtransactionlist.SelectedItems(0).SubItems(5).Text) 'balance
            Dim obj1 As New frmupdatepayment(list1)
            obj1.ShowDialog()
            If obj1.status = True Then
                Dim obj2 As New frmsmallreceipt(receiptno)
                obj2.ShowDialog()
                Dim obj3 As New frmbigreceipt(receiptno)
                obj3.ShowDialog()
                bwload_transactions.RunWorkerAsync()

            End If
            btnupdate.Visible = False


        Catch ex As Exception
            MsgBox("Update:" + ex.Message)
        End Try
    End Sub

    Private Sub btnprintreceipt_Click(sender As Object, e As EventArgs) Handles btnprintreceipt.Click
        If transactiontype <> "" Then

            If transactiontype = "POS" Then
                Dim obj1 As New frmpossmall(receiptno)
                obj1.ShowDialog()
                Dim obj2 As New frmposbig(receiptno)
                obj2.ShowDialog()

            Else
                Dim obj1 As New frmsmallreceipt(receiptno)
                obj1.ShowDialog()
                Dim obj2 As New frmbigreceipt(receiptno)
                obj2.ShowDialog()
                Dim obj3 As New frmworeceipt(receiptno)
                obj3.Show()

            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        Try
            bwload_transactions.RunWorkerAsync()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub update_stats()
        lbltotaltransaction.Text = totaltransaction
        lbltotalamount.Text = totalamount.ToString("C")
        lbltotalbalance.Text = totalbalance.ToString("C")
        lbltotaldeposit.Text = totaldeposit.ToString("C")
        lblcash.Text = cashpayment
        lblcard.Text = cardpayment
        lblbibd.Text = "BIBD(" & bibd & ")"
        lblscb.Text = "SCB(" & scb & ")"
        lblbaiduri.Text = "BIBD(" & baiduri & ")"
        lblothers.Text = "OTHERS(" & others & ")"
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        If lvtransactionlist.Items.Count > 0 Then
            Dim printobj As New frmtransactionreport(operation)
            Dim amountlist As New List(Of Decimal)
            amountlist.Add(totalamount)
            amountlist.Add(totaldeposit)
            amountlist.Add(totalbalance)
            printobj.amountlist = amountlist
            printobj.setreceipt(txtsearch.Text)
            printobj.setdates(datestart, dateend)
            printobj.ShowDialog()
        Else
            MsgBox("No data to print")
        End If

    End Sub

    Private Sub lvtransactionlist_Click(sender As Object, e As EventArgs) Handles lvtransactionlist.Click
        If lvtransactionlist.Items.Count > 0 Then

            receiptno = lvtransactionlist.SelectedItems(0).SubItems(1).Text
            transactiontype = lvtransactionlist.SelectedItems(0).SubItems(8).Text
            load_items(receiptno)
            btnprintreceipt.Visible = True
            Dim balance As Decimal = lvtransactionlist.SelectedItems(0).SubItems(5).Text
            If balance > 0 Then
                btnupdate.Visible = True
            Else
                btnupdate.Visible = False
            End If
        End If
    End Sub
    Private Sub load_items(ByVal rno As String)
        Try
            lvproductlist.Items.Clear()
            Dim transactionobj As New TransactionItems
            receiptlist = New List(Of TransactionItems)
            receiptlist = transactionobj.load_items(rno)
            totalitems = 0
            totalprice = 0
            totaldeposit = 0
            totalbalance = 0
            If receiptlist IsNot Nothing Then
                lvproductlist.Enabled = True
                Dim x As Integer
                For x = 0 To receiptlist.Count - 1
                    totalitems += 1
                    totalprice += receiptlist(x).gettotalprice
                    totalbalance += translist(x).getbalance
                    totaldeposit += translist(x).getdeposit
                    receiptitems = lvproductlist.Items.Add(receiptlist(x).getid)
                    receiptitems.SubItems.Add(receiptlist(x).get_type)
                    receiptitems.SubItems.Add(receiptlist(x).getproductname)
                    receiptitems.SubItems.Add(receiptlist(x).getproductdesc)
                    receiptitems.SubItems.Add(receiptlist(x).getprice)
                    receiptitems.SubItems.Add(receiptlist(x).getqty)
                    receiptitems.SubItems.Add(receiptlist(x).gettotal)
                    receiptitems.SubItems.Add(receiptlist(x).getdiscount)
                    receiptitems.SubItems.Add(receiptlist(x).gettotalprice)
                Next
            Else
                MsgBox("No items in this transaction")
                lvproductlist.Enabled = False
                lvproductlist.Items.Clear()
            End If
            lbltotalproduct.Text = totalitems
            lbltotalprice.Text = totalprice.ToString("C")
        Catch ex As Exception
            MsgBox("Load items: " + ex.Message)
        End Try
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtsearch.Text.Count = 0 Then
                MsgBox("Please enter the receipt no")
            Else
                search_receipt()
            End If
        End If
    End Sub
    Private Sub search_receipt()

        Try
            operation = "receipt"
            totalitems = 0
            totalprice = 0
            totaldeposit = 0
            totalbalance = 0
            lbltotaldeposit.Text = 0
            lbltotalbalance.Text = 0
            lbltotalprice.Text = "0"
            lbltotalproduct.Text = "0"
            bibd = 0
            scb = 0
            baiduri = 0
            others = 0
            lvproductlist.Items.Clear()
            Dim transactionobj As New Transaction
            translist = New List(Of Transaction)
            translist = transactionobj.search_transaction_receipt(txtsearch.Text)
            If translist IsNot Nothing Then
                MsgBox(translist.Count.ToString + " results found")
                lvtransactionlist.Items.Clear()
                lvtransactionlist.Enabled = True
                Dim x As Integer
                cardpayment = 0
                cashpayment = 0
                totalamount = 0
                totaltransaction = 0
                For x = 0 To translist.Count - 1
                    totaltransaction += 1
                    totalamount += translist(x).getpayable
                    totalbalance += translist(x).getbalance
                    totaldeposit += translist(x).getdeposit
                    transitems = lvtransactionlist.Items.Add(translist(x).gettransdate)
                    transitems.SubItems.Add(translist(x).getid)
                    transitems.SubItems.Add(translist(x).getissued)
                    transitems.SubItems.Add(translist(x).getpayable)
                    transitems.SubItems.Add(translist(x).getdeposit)
                    transitems.SubItems.Add(translist(x).getbalance)
                    transitems.SubItems.Add(translist(x).getmethod)
                    transitems.SubItems.Add(translist(x).getbank)
                    transitems.SubItems.Add(translist(x).getpos)
                    If translist(x).getmethod.ToString.Contains("CASH") Then
                        cashpayment += 1
                    Else
                        cardpayment += 1
                        update_bank(translist(x).getbank)
                    End If
                Next

            Else
                totalamount = 0
                totaltransaction = 0
                totaldeposit = 0
                totalbalance = 0
                cashpayment = 0
                cardpayment = 0
                MsgBox("No transaction found")
                lvtransactionlist.Enabled = False
                lvtransactionlist.Items.Clear()
            End If
            update_stats()

        Catch ex As Exception
            MsgBox("Transaction History (load_transaction) :   " + ex.Message)
        End Try
    End Sub
    Private Sub search_date()

        Try
            operation = "range"
            totalitems = 0
            totalprice = 0
            totaldeposit = 0
            totalbalance = 0
            bibd = 0
            scb = 0
            baiduri = 0
            others = 0
            lbltotalprice.Text = "0"
            lbltotalproduct.Text = "0"
            lvproductlist.Items.Clear()
            Dim transactionobj As New Transaction
            translist = New List(Of Transaction)
            translist = transactionobj.search_transaction_date(datestart, dateend)
            If translist IsNot Nothing Then
                MsgBox(translist.Count.ToString + " results found")
                lvtransactionlist.Items.Clear()
                lvtransactionlist.Enabled = True
                Dim x As Integer
                cashpayment = 0
                cardpayment = 0
                totalamount = 0
                totaltransaction = 0
                For x = 0 To translist.Count - 1
                    totaltransaction += 1
                    totalamount += translist(x).getpayable
                    totalbalance += translist(x).getbalance
                    totaldeposit += translist(x).getdeposit
                    transitems = lvtransactionlist.Items.Add(translist(x).gettransdate)
                    transitems.SubItems.Add(translist(x).getid)
                    transitems.SubItems.Add(translist(x).getissued)
                    transitems.SubItems.Add(translist(x).getpayable)
                    transitems.SubItems.Add(translist(x).getdeposit)
                    transitems.SubItems.Add(translist(x).getbalance)
                    transitems.SubItems.Add(translist(x).getmethod)
                    transitems.SubItems.Add(translist(x).getbank)
                    transitems.SubItems.Add(translist(x).getpos)
                    If translist(x).getmethod.ToString.Contains("CASH") Then
                        cashpayment += 1
                    Else
                        cardpayment += 1
                        update_bank(translist(x).getbank)
                    End If
                Next

            Else
                totalamount = 0
                totaltransaction = 0
                totaldeposit = 0
                totalbalance = 0
                cashpayment = 0
                cardpayment = 0
                MsgBox("No transaction found On the dates selected")
                lvtransactionlist.Enabled = False
                lvtransactionlist.Items.Clear()
            End If
            update_stats()

        Catch ex As Exception
            MsgBox("Transaction History (load_transaction) :  " + ex.Message)
        End Try
    End Sub


End Class