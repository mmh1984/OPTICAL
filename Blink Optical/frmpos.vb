Public Class frmpos
    Dim productlist As List(Of ProductFrame)
    Dim plist As ListViewItem
    Dim totalprice, discount As Decimal
    Dim payableamount As Decimal
    Dim deposit, balance As Decimal
    Dim userinfo As List(Of String)
    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        Dim selectobj As New frmselectproduct
        selectobj.ShowDialog()
        If selectobj.productid = 0 Then
            MessageBox.Show("Product id cannot be zero", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            load_productselected(selectobj.productid, selectobj.qty, selectobj.discount)
            btnselect.Focus()
        End If


    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        If lvproducts.CheckedItems.Count > 0 Then
            For Each item As ListViewItem In lvproducts.Items
                If item.Checked Then
                    lvproducts.Items.Remove(item)
                End If
            Next
            txtdeposit.Text = "0.0"

            update_price()
        Else
            MsgBox("Check the item(s) that you want to remove")
        End If
    End Sub
    Private Sub update_price()
        Try
            If lvproducts.Items.Count > 0 Then
                payableamount = 0
                For Each item As ListViewItem In lvproducts.Items
                    payableamount += item.SubItems(7).Text
                Next
            Else
                payableamount = 0
            End If
            txtamount.Text = payableamount.ToString("C")
            deposit = Convert.ToDecimal(txtdeposit.Text)
            txtbalance.Text = payableamount - deposit
        Catch ex As Exception
            MsgBox("Update price: " + ex.Message)
        End Try

    End Sub

    Private Sub frmpos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxpayment.SelectedIndex = 0
        btnselect.Focus()
        userinfo = frmdashboard.userinfo
        txtissued.Text = userinfo(1)

    End Sub



    Private Sub btnproceed_Click_1(sender As Object, e As EventArgs) Handles btnproceed.Click
        Dim err As Boolean = False
        If cbxpayment.SelectedIndex = 1 Then
            If (cbxbank.SelectedIndex = -1) Then
                MessageBox.Show("Select the bank for card payments", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbxbank.Focus()
                err = True
            End If
        ElseIf payableamount = 0 Or lvproducts.Items.Count = 0 Then
            MessageBox.Show("There are no products in the list", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            err = True
        ElseIf deposit = 0 Then
            MessageBox.Show("Deposit cannot be zero", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtdeposit.Focus()
            err = True
        ElseIf txtissued.Text.Length = 0 Then
            MessageBox.Show("Issued by cannot be empty", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtissued.Focus()
            err = True
        End If


        If err = False Then

            save_transaction()
            save_items()
            totalprice = 0
            discount = 0
            payableamount = 0
            deposit = 0
            balance = 0
            update_price()
            txtamount.Text = "0.0"
            txtbalance.Text = "0.0"
            txtdeposit.Text = "0.0"
            cbxpayment.SelectedIndex = 0

            lvproducts.Items.Clear()
        End If
    End Sub
    Private Sub save_items()
        Dim itemlist As New List(Of TransactionItems)
        Dim getreceipt As New Transaction
        Dim receipt As Integer
        receipt = getreceipt.get_id
        Try
            For Each item As ListViewItem In lvproducts.Items
                Dim titems As New TransactionItems

                titems.setid(receipt)
                titems.setproduct(item.Text)
                titems.settype(item.SubItems(1).Text)
                titems.setprice(item.SubItems(3).Text)
                titems.setqty(item.SubItems(4).Text)
                titems.settotal(item.SubItems(5).Text)
                titems.setdiscount(item.SubItems(6).Text)
                titems.settotalprice(item.SubItems(7).Text)

                Dim pname, pdesc As String
                pname = ""
                pdesc = ""
                Dim desclist As New List(Of String)

                Dim productobj As New ProductFrame
                    desclist = productobj.search_product(titems.getproduct)
                    pname = "(" + desclist(4) + ") "
                    pname += desclist(3) + " "
                    pdesc = desclist(5) + " " + desclist(6)

                titems.setproductname(pname)
                titems.setproductdesc(pdesc)

                itemlist.Add(titems)

            Next
            Dim saveitems As New TransactionItems
            saveitems.save_items_transaction(itemlist)
            saveitems.update_items(itemlist)
            MessageBox.Show("Transaction Saved", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim smallreceipt As frmpossmall
            smallreceipt = New frmpossmall(receipt)
            smallreceipt.ShowDialog()
            Dim bigreceipt As frmposbig
            bigreceipt = New frmposbig(receipt)
            bigreceipt.ShowDialog()

            'save
        Catch ex As Exception
            MsgBox("Save Item List:" + ex.Message)
        End Try
    End Sub
    Private Sub save_transaction()
        Try
            Dim trans As New Transaction
            trans.setcustomer("0")
            trans.setreading("0")
            trans.setsizebridge("0")
            trans.setdeliverydate(DateTime.Now.ToString())
            trans.setedged("")

            trans.setpayable(payableamount)
            trans.setdeposit(txtdeposit.Text)
            trans.setbalance(txtbalance.Text)
            trans.setmethod(cbxpayment.SelectedItem)
            trans.setpos("POS")
            trans.setissued(userinfo(0))
            If cbxpayment.SelectedIndex = 1 Then
                trans.setbank(cbxbank.SelectedItem)
            Else
                trans.setbank("CASH")
            End If

            trans.save_transaction_details()
        Catch ex As Exception
            MsgBox("Save Transaction:" + ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim possmall As New frmposbig("1000050")
        possmall.ShowDialog()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub cbxpayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxpayment.SelectedIndexChanged
        If cbxpayment.SelectedIndex = 0 Or cbxpayment.SelectedIndex = 2 Then
            cbxbank.Enabled = False
        Else
            cbxbank.Enabled = True
        End If
    End Sub

    Private Sub txtamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtamount.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso 'restricts anything but number keys
   e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then 'allows use of backspace
            e.Handled = True
        End If
    End Sub

    Private Sub txtdeposit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdeposit.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso 'restricts anything but number keys
   e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then 'allows use of backspace
            e.Handled = True
        End If
    End Sub

    Private Sub txtdeposit_Leave(sender As Object, e As EventArgs) Handles txtdeposit.Leave
        Try
            txtdeposit.Text = Convert.ToDecimal(txtdeposit.Text).ToString("N2")
            deposit = Convert.ToDecimal(txtdeposit.Text)
            If deposit > payableamount Then
                MessageBox.Show("Your deposit exceeded the balance", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtdeposit.Text = "0.0"
                txtdeposit.Focus()
            ElseIf deposit <= 0 Then
                MessageBox.Show("Deposit cannot be zero", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtdeposit.Text = "0.0"
                txtdeposit.Focus()
            Else

                balance = payableamount - deposit
                txtbalance.Text = balance.ToString("N2")
            End If


        Catch ex As FormatException
            txtdeposit.Text = "0.0"
            txtdeposit.Focus()
            MsgBox("Conversion Error:" + ex.Message)
        End Try
    End Sub

    Private Sub load_productselected(ByVal id As String, ByVal qty As Integer, ByVal dis As Decimal)
        Try

            productlist = New List(Of ProductFrame)
            Dim productobj As New ProductFrame
            productlist = productobj.load_products()
            Dim productfound = False

            If lvproducts.Items.Count > 0 Then
                Dim i As Integer
                For i = 0 To lvproducts.Items.Count - 1

                    If lvproducts.Items(i).Text = id Then
                        productfound = True
                    End If

                Next
            End If


            Dim x As Integer
            lvproducts.Enabled = True
            If productfound = False Then
                For x = 0 To productlist.Count - 1
                    If productlist(x).getid = id Then

                        plist = lvproducts.Items.Add(productlist(x).getid)
                        plist.SubItems.Add(productlist(x).get_type)
                        plist.SubItems.Add(productlist(x).getname)
                        plist.SubItems.Add(productlist(x).getprice)
                        plist.SubItems.Add(qty)

                        totalprice = (productlist(x).getprice * qty)
                        plist.SubItems.Add(totalprice)
                        totalprice = totalprice - dis
                        plist.SubItems.Add(dis)
                        plist.SubItems.Add(totalprice)



                    End If

                Next
                update_price()
            Else

                MessageBox.Show("This product is already in the list", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MsgBox("Product selected: " + ex.Message)

        End Try

    End Sub
End Class