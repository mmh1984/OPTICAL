Imports System.Data.SqlClient
Public Class frmtransaction
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Dim cid, pid As String
    Dim productlist As List(Of ProductFrame)
    Dim speciallist As List(Of ProductFrame)
    Dim packagelist As List(Of ProductPackage)
    Dim addonlist As List(Of Addons)
    Dim deposit As Decimal = 0
    Dim balance As Decimal = 0
    Dim list1 As ListViewItem
    Dim totalprice As Decimal
    Dim discount As Decimal = 0
    Dim userinfo As List(Of String)

    Public Sub New(ByVal _cid As String, ByVal _pid As String, ByVal _userinfo As List(Of String))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        cid = _cid
        pid = _pid
        userinfo = _userinfo
    End Sub
    Private Sub frmtransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdate.CustomFormat = "dd-MM-yyyy"
        customer_details()
        prescription_details(pid)
        load_products()
        lbldate.Text = Date.Now.ToString("dd-MM-yyyy")
        btnaddqty.Enabled = False
        btnreduceqty.Enabled = False
        cbxpayment.SelectedIndex = 0
        txtissued.Text = userinfo(1)
        load_add_ons()
    End Sub
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

    Private Sub load_add_ons()
        Try
            Dim brandlist As List(Of String)
            Dim add_ons As New Addons
            brandlist = New List(Of String)
            brandlist = add_ons.get_brand
            cbxitem.Enabled = False
            If brandlist IsNot Nothing Then
                cbxbrand.Enabled = True

                For Each item In brandlist
                    cbxbrand.Items.Add(item)
                Next
            Else
                cbxbrand.Enabled = False
                cbxitem.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Add ons" + ex.Message)
        End Try
    End Sub
    Private Sub customer_details()
        Try
            open_connection()
            Dim sql As String = "SELECT * FROM tblcustomers WHERE customerid=@id "
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", cid)
            rs = cmd.ExecuteReader
            While rs.Read
                'Dim dob As Date
                'dob = rs(8)
                lblic.Text = rs(1).ToString()
                lblname.Text = rs(2).ToString()
                lbladdress.Text = rs(3).ToString()
                lblmobile.Text = rs(4).ToString()

            End While
            rs.Close()
            cmd.Dispose()
            conn.Close()


        Catch ex As Exception
            MessageBox.Show("Customer Details:" & ex.Message)
        End Try
    End Sub



    Private Sub txtdeposit_Leave(sender As Object, e As EventArgs) Handles txtdeposit.Leave
        check_deposit()
    End Sub
    Private Sub check_deposit()
        Try
            deposit = Convert.ToDecimal(txtdeposit.Text)
            If deposit > totalprice Then
                MessageBox.Show("Your deposit exceeded the balance", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtdeposit.Text = "0.0"
                txtdeposit.Focus()
            ElseIf deposit <= 0 And totalprice > 0 Then
                MessageBox.Show("Deposit cannot be zero", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtdeposit.Text = "0.0"
                txtdeposit.Focus()
            Else
                txtdeposit.Text = deposit.ToString("N2")
                balance = totalprice - deposit
                txtbalance.Text = balance.ToString("N2")
            End If


        Catch ex As FormatException
            txtdeposit.Text = "0.0"
            txtdeposit.Focus()
            MsgBox("Conversion Error:" + ex.Message)
        End Try
    End Sub


    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        If lvorders.CheckedItems.Count > 0 Then
            For Each item As ListViewItem In lvorders.Items
                If item.Checked Then
                    lvorders.Items.Remove(item)
                End If
            Next
            btnaddqty.Enabled = False
            btnreduceqty.Enabled = False
            txtdeposit.Text = "0.0"
            txtbalance.Text = "0.0"
            update_price()
        Else
            MsgBox("Check the item(s) that you want to remove")
        End If
    End Sub

    Private Sub update_price()
        Try
            If lvorders.Items.Count > 0 Then
                totalprice = 0
                For Each item As ListViewItem In lvorders.Items
                    Dim price As Decimal
                    price = Convert.ToDecimal(item.SubItems(7).Text)
                    totalprice += price

                Next
                txtamount.Text = totalprice.ToString()
                deposit = Convert.ToDecimal(txtdeposit.Text)
                txtbalance.Text = totalprice - deposit
            Else
                totalprice = 0
                txtamount.Text = totalprice.ToString()
            End If

        Catch ex As Exception
            MsgBox("Update Price:" + ex.Message)
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

                    txtpdr.Text = rs(11).ToString()
                    txtpdl.Text = rs(12).ToString()
                    txthtr.Text = rs(13).ToString()
                    txthtl.Text = rs(14).ToString()

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
    Private Sub load_products()
        Try
            productlist = New List(Of ProductFrame)
            open_connection()
            Dim sql As String = "SELECT * FROM tblproducts WHERE productstatus<> 'deleted' or productstatus is null"
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader
            If (rs.HasRows) Then
                While rs.Read
                    Dim lens As ProductFrame
                    lens = New ProductFrame
                    lens.setid(rs(0).ToString)
                    lens.setcode(rs(2).ToString)
                    lens.setname(rs(3).ToString)
                    lens.setprice(rs(8).ToString)
                    lens.setstock(rs(9).ToString)

                    productlist.Add(lens)
                End While


                rs.Close()
                cmd.Dispose()
                conn.Close()
            Else
                MessageBox.Show("There are no product in the list,add products using the form")

            End If
        Catch ex As Exception
            MessageBox.Show("Load Products:" + ex.Message)
        End Try
    End Sub

    Private Sub load_special()
        Try
            speciallist = New List(Of ProductFrame)
            open_connection()
            Dim sql As String = "SELECT * FROM tblspecialorder WHERE productstatus<> 'deleted' or productstatus is null"
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader
            If (rs.HasRows) Then
                While rs.Read
                    Dim lens As ProductFrame
                    lens = New ProductFrame
                    lens.setid(rs(0).ToString)
                    lens.setcode(rs(2).ToString)
                    lens.setname(rs(3).ToString)
                    lens.setprice(rs(8).ToString)
                    lens.setstock(rs(9).ToString)

                    speciallist.Add(lens)
                End While


                rs.Close()
                cmd.Dispose()
                conn.Close()
            Else
                MessageBox.Show("There are no product in the list,add products using the form")

            End If
        Catch ex As Exception
            MessageBox.Show("Load Products:" + ex.Message)
        End Try
    End Sub

    Private Sub load_package()
        Try
            packagelist = New List(Of ProductPackage)
            open_connection()
            Dim sql As String = "SELECT * FROM tblpackage WHERE packagestatus<> 'deleted' or packagestatus is null"
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader
            If (rs.HasRows) Then
                While rs.Read
                    Dim pkg As New ProductPackage

                    pkg.setid(rs(0).ToString)
                    pkg.setname(rs(1).ToString)
                    pkg.setdescription(rs(5).ToString)
                    pkg.setprice(rs(6).ToString)
                    pkg.setqty(rs(7).ToString)
                    packagelist.Add(pkg)
                End While


                rs.Close()
                cmd.Dispose()
                conn.Close()
            Else
                MessageBox.Show("There are no product in the list,add products using the form")

            End If
        Catch ex As Exception
            MessageBox.Show("Load Products:" + ex.Message)
        End Try
    End Sub
    Private Sub cbxframe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxframe.SelectedIndexChanged
        If cbxframe.SelectedIndex = 0 Then
            Dim selectitem As New frmselectitem("Frames")
            selectitem.ShowDialog()

            If (selectitem.idselected <> 0) Then
                add_item(selectitem.idselected, "Frames")
                cbxlens.Enabled = True
            Else
                MessageBox.Show("No item selected")

            End If
        ElseIf cbxframe.SelectedIndex = 1 Then
            Dim specialorder As New frmspecialorders
            specialorder.ShowDialog()
            If (specialorder.idselected <> 0) Then
                add_item_special(specialorder.idselected, specialorder.productname)
                cbxlens.Enabled = True
            Else
                MessageBox.Show("No item selected")

            End If
        ElseIf cbxframe.SelectedIndex = 2 Then
            Dim packageorder As New frmselectpackage
            packageorder.ShowDialog()
            If (packageorder.idselected <> 0) Then
                add_package(packageorder.idselected, packageorder.productname)
                cbxlens.Enabled = False
            Else
                MessageBox.Show("No item selected")

            End If
        ElseIf cbxframe.SelectedIndex = 3 Then
            list1 = lvorders.Items.Add("0")
            list1.SubItems.Add("(OWN FRAME) ")
            list1.SubItems.Add("0")
            list1.SubItems.Add("0")
            list1.SubItems.Add("0")

            list1.SubItems.Add("0")
            list1.SubItems.Add("0")
            list1.SubItems.Add("0")
            list1.SubItems.Add("OWN FRAME")
        End If
        update_price()
    End Sub

    Private Sub cbxlens_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxlens.SelectedIndexChanged
        If cbxlens.SelectedIndex = 0 Then
            Dim selectitem As New frmselectitem("Lens")
            selectitem.ShowDialog()

            If (selectitem.idselected <> 0) Then
                add_item(selectitem.idselected, "Lens")
            Else
                MessageBox.Show("No item selected")

            End If
        ElseIf cbxlens.SelectedIndex = 1 Then
            Dim specialorder As New frmspecialorders
            specialorder.ShowDialog()
            If (specialorder.idselected <> 0) Then
                add_item_special(specialorder.idselected, specialorder.productname)
            Else
                MessageBox.Show("No item selected")

            End If
        End If
        update_price()
    End Sub

    Private Sub btnaddqty_Click(sender As Object, e As EventArgs) Handles btnaddqty.Click
        Try
            If lvorders.Items.Count > 0 And lvorders.SelectedItems.Count > 0 Then
                Dim qty, stock As Integer
                Dim price, total As Decimal
                Dim productname As String
                productname = lvorders.SelectedItems(0).SubItems(1).Text

                qty = Convert.ToInt32(lvorders.SelectedItems(0).SubItems(4).Text)
                stock = Convert.ToInt32(lvorders.SelectedItems(0).SubItems(2).Text)
                price = Convert.ToDecimal(lvorders.SelectedItems(0).SubItems(3).Text)
                total = Convert.ToDecimal(lvorders.SelectedItems(0).SubItems(5).Text)
                discount = Convert.ToDecimal(lvorders.SelectedItems(0).SubItems(6).Text)
                If stock > qty Or productname.Contains("Special Order") Then
                    qty += 1

                    total = qty * price
                    Dim discounttotal As Decimal = total - discount
                    'discounttotal = discounttotal * qty
                    lvorders.SelectedItems(0).SubItems(4).Text = qty.ToString
                    lvorders.SelectedItems(0).SubItems(5).Text = total.ToString("N2")
                    lvorders.SelectedItems(0).SubItems(7).Text = discounttotal.ToString("N2")
                    txtdeposit.Text = "0.0"
                    update_price()
                ElseIf productname.Contains("SPECIAL ORDER") Then
                    qty += 1
                    total = qty * price
                    Dim discounttotal As Decimal = total - discount
                    lvorders.SelectedItems(0).SubItems(4).Text = qty.ToString
                    lvorders.SelectedItems(0).SubItems(5).Text = total.ToString("N2")
                    lvorders.SelectedItems(0).SubItems(7).Text = discounttotal.ToString("N2")
                    txtdeposit.Text = "0.0"
                    update_price()
                ElseIf productname.Contains("OWN FRAME") Then
                    MsgBox("Option not available for own frames", MsgBoxStyle.Exclamation)
                Else
                    MessageBox.Show("Cannot increase quantity, Stock must be higher than quantity")

                End If
            Else
                MessageBox.Show("Select item in the list to increase quantity")
            End If
        Catch ex As Exception
            MsgBox("Add:" + ex.Message)
        End Try

    End Sub

    Private Sub lvorders_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lvorders_Click_1(sender As Object, e As EventArgs) Handles lvorders.Click
        If lvorders.Items.Count > 0 And lvorders.SelectedItems(0).SubItems(1).Text.Contains("OWN FRAME") = False Then
            btnaddqty.Enabled = True
            btnreduceqty.Enabled = True
            btndiscount.Enabled = True
        Else
            btnaddqty.Enabled = False
            btnreduceqty.Enabled = False
            btndiscount.Enabled = False
        End If
    End Sub

    Private Sub btnreduceqty_Click(sender As Object, e As EventArgs) Handles btnreduceqty.Click
        Try
            If lvorders.Items.Count > 0 And lvorders.SelectedItems.Count > 0 Then
                Dim qty, stock As Integer
                Dim price, total As Decimal
                qty = Convert.ToInt32(lvorders.SelectedItems(0).SubItems(4).Text)
                stock = Convert.ToInt32(lvorders.SelectedItems(0).SubItems(2).Text)
                price = Convert.ToDecimal(lvorders.SelectedItems(0).SubItems(3).Text)
                total = Convert.ToDecimal(lvorders.SelectedItems(0).SubItems(5).Text)
                discount = Convert.ToDecimal(lvorders.SelectedItems(0).SubItems(6).Text)
                If qty > 1 Then
                    qty -= 1
                    total = qty * price
                    Dim discounttotal As Decimal = total - discount
                    'discounttotal = discounttotal * qty
                    lvorders.SelectedItems(0).SubItems(4).Text = qty.ToString
                    lvorders.SelectedItems(0).SubItems(5).Text = total.ToString("N2")
                    lvorders.SelectedItems(0).SubItems(7).Text = discounttotal.ToString("N2")
                    txtdeposit.Text = "0.0"
                    update_price()
                Else
                    MsgBox("Quantity cannot be zero")

                End If
            Else
                MessageBox.Show("Select item in the list to reduce quantity")
            End If
        Catch ex As Exception
            MsgBox("Reduce:" + ex.Message)
        End Try

    End Sub

    Private Sub btncalculate_Click(sender As Object, e As EventArgs)
        update_price()
    End Sub

    Private Sub add_item(ByVal id As String, ByVal type As String)


        Dim lensfound As Boolean = False
        For Each item As ListViewItem In lvorders.Items
            If item.SubItems(0).Text = id Then
                lensfound = True
            End If
        Next

        If lensfound = False Then
            discount = 0
            Dim i As Integer
            For i = 0 To productlist.Count - 1
                If productlist(i).getid = id Then
                    If (productlist(i).getstock <> "0") Then
                        list1 = lvorders.Items.Add(productlist(i).getid)
                        list1.SubItems.Add(productlist(i).getname)
                        list1.SubItems.Add(productlist(i).getstock)
                        list1.SubItems.Add(productlist(i).getprice)
                        list1.SubItems.Add("1")
                        Dim itemprice As Decimal
                        itemprice = 1 * Convert.ToDecimal(productlist(i).getprice)
                        itemprice = itemprice * (1 - (discount / 100))
                        list1.SubItems.Add(itemprice.ToString)
                        list1.SubItems.Add(discount)
                        list1.SubItems.Add(itemprice.ToString())
                        list1.SubItems.Add(type)
                        update_price()
                    Else
                        MessageBox.Show("This item has no stock available", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            Next

        Else
            MsgBox("This item is already in the list")
        End If


    End Sub

    Private Sub cbxbrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxbrand.SelectedIndexChanged
        If cbxbrand.SelectedIndex <> -1 Then
            load_add_on_items()
        End If
    End Sub

    Private Sub add_item_special(ByVal id As String, ByVal name As String)

        load_special()
        Dim lensfound As Boolean = False
        For Each item As ListViewItem In lvorders.Items
            If item.SubItems(1).Text = "(SPECIAL ORDER) " + name Then
                lensfound = True
            End If
        Next

        If lensfound = False Then
            discount = 0
            Dim i As Integer
            For i = 0 To speciallist.Count - 1
                If speciallist(i).getid = id Then

                    list1 = lvorders.Items.Add(speciallist(i).getid)
                    list1.SubItems.Add("(SPECIAL ORDER) " + speciallist(i).getname)
                    list1.SubItems.Add(speciallist(i).getstock)
                    list1.SubItems.Add(speciallist(i).getprice)
                    list1.SubItems.Add("1")
                    Dim itemprice As Decimal
                    itemprice = 1 * Convert.ToDecimal(speciallist(i).getprice)
                    itemprice = itemprice * (1 - (discount / 100))
                    list1.SubItems.Add(itemprice.ToString)
                    list1.SubItems.Add(discount)
                    list1.SubItems.Add(itemprice.ToString)
                    list1.SubItems.Add("SPECIAL ORDER")
                    update_price()
                End If
            Next
        Else
            MsgBox("This item is already in the list")
        End If
    End Sub
    Private Sub add_package(ByVal id As String, ByVal name As String)

        load_package()
        Dim lensfound As Boolean = False
        For Each item As ListViewItem In lvorders.Items
            If item.SubItems(1).Text = "(PACKAGE) " + name Then
                lensfound = True
            End If
        Next

        If lensfound = False Then
            discount = 0
            Dim i As Integer
            For i = 0 To packagelist.Count - 1
                If packagelist(i).getid = id Then

                    list1 = lvorders.Items.Add(packagelist(i).getid)
                    list1.SubItems.Add("(PACKAGE) " + packagelist(i).getname)
                    list1.SubItems.Add(packagelist(i).getqty)
                    list1.SubItems.Add(packagelist(i).getprice)
                    list1.SubItems.Add("1")
                    Dim itemprice As Decimal
                    itemprice = 1 * Convert.ToDecimal(packagelist(i).getprice)
                    itemprice = itemprice * (1 - (discount / 100))
                    list1.SubItems.Add(itemprice.ToString)
                    list1.SubItems.Add(discount)
                    list1.SubItems.Add(itemprice.ToString)
                    list1.SubItems.Add("PACKAGE")
                    update_price()
                End If
            Next
        Else
            MsgBox("This item is already in the list")
        End If
    End Sub
    Private Sub load_add_on_items()

        addonlist = New List(Of Addons)
        Dim add_ons As New Addons
        addonlist = add_ons.search_products(cbxbrand.SelectedItem, "brand")
        If addonlist IsNot Nothing Or addonlist.Count <> 0 Then
            cbxitem.Items.Clear()
            cbxitem.Enabled = True
            For Each item In addonlist

                cbxitem.Items.Add(item.getname)
            Next
        Else
            cbxitem.Enabled = False
        End If

    End Sub

    Private Sub cbxitem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxitem.SelectedIndexChanged
        For Each item In addonlist
            If (item.getname = cbxitem.SelectedItem And item.getbrand = cbxbrand.SelectedItem) Then
                add_item_add_ons(item.getid, item.getname)
            End If
        Next
        update_price()
    End Sub

    Private Sub btndiscount_Click(sender As Object, e As EventArgs) Handles btndiscount.Click
        Try
            If lvorders.Items.Count > 0 And lvorders.SelectedItems.Count > 0 Then
                Dim price, total As Decimal
                Dim qty As Integer
                Dim productname As String
                productname = lvorders.SelectedItems(0).SubItems(1).Text
                qty = Convert.ToInt32(lvorders.SelectedItems(0).SubItems(4).Text)
                price = Convert.ToDecimal(lvorders.SelectedItems(0).SubItems(3).Text)
                total = Convert.ToDecimal(lvorders.SelectedItems(0).SubItems(5).Text)
                Dim discountobj As New frmdiscount(total)
                If discountobj.ShowDialog = DialogResult.OK Then
                    discount = discountobj.discount
                    lvorders.SelectedItems(0).SubItems(6).Text = discount.ToString("N2")
                    lvorders.SelectedItems(0).SubItems(7).Text = discountobj.newamount.ToString("N2")
                    txtdeposit.Text = "0.0"
                    update_price()
                End If
            Else
                    MessageBox.Show("Select item in the list to add discount")
            End If
        Catch ex As Exception
            MessageBox.Show("Add Discount:" + ex.Message)
        End Try
    End Sub

    Private Sub btnproceed_Click(sender As Object, e As EventArgs) Handles btnproceed.Click
        If check_errors() = 0 Then
            save_transaction()
            save_items()

        End If
    End Sub
    Private Sub save_items()
        Dim itemlist As New List(Of TransactionItems)
        Dim getreceipt As New Transaction
        Dim receipt As Integer
        receipt = getreceipt.get_id
        Try
            For Each item As ListViewItem In lvorders.Items
                Dim titems As New TransactionItems

                titems.setid(receipt)
                titems.setproduct(item.Text)
                titems.settype(item.SubItems(8).Text)
                titems.setprice(item.SubItems(3).Text)
                titems.setqty(item.SubItems(4).Text)
                titems.settotal(item.SubItems(5).Text)
                titems.setdiscount(item.SubItems(6).Text)
                titems.settotalprice(item.SubItems(7).Text)
                Dim pname, pdesc As String
                pname = ""
                pdesc = ""
                Dim desclist As New List(Of String)

                If titems.get_type = "Frames" Or titems.get_type = "Lens" Then
                    desclist.Clear()
                    Dim productobj As New ProductFrame
                    desclist = productobj.search_product(titems.getproduct)
                    pname = "(" + desclist(4) + ") "
                    pname += desclist(3) + " "
                    pdesc = desclist(5) + " " + desclist(6)

                ElseIf titems.get_type = "SPECIAL ORDER" Then
                    desclist.Clear()
                    Dim productobj As New ProductFrame
                    desclist = productobj.search_product_special(titems.getproduct)
                    pname = "(" + desclist(4) + ") "
                    pname += desclist(3) + " "
                    pdesc = desclist(5) + " " + desclist(6)
                ElseIf titems.get_type = "PACKAGE" Then
                    desclist.Clear()
                    Dim productobj As New ProductPackage
                    desclist = productobj.search_package(titems.getproduct)
                    pname = desclist(1)
                    pdesc = desclist(5)
                ElseIf titems.get_type = "ADD-ON" Then
                    desclist.Clear()
                    Dim productobj As New Addons
                    desclist = productobj.search_add_on(titems.getproduct)
                    pname = "(" + desclist(1) + ") "
                    pname += desclist(2) + " "
                    pdesc = desclist(4)

                ElseIf titems.get_type = "OWN FRAME" Then

                    pname = "(OWN FRAME) "
                    pdesc = ""
                    titems.settype("")
                End If

                titems.setproductname(pname)
                titems.setproductdesc(pdesc)

                itemlist.Add(titems)

            Next
            Dim saveitems As New TransactionItems
            saveitems.save_items_transaction(itemlist)
            saveitems.update_items(itemlist)
            MessageBox.Show("Transaction Saved", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim smallreceipt As New frmsmallreceipt(receipt)

            smallreceipt.ShowDialog()
            Dim bigreceipt As New frmbigreceipt(receipt)

            bigreceipt.ShowDialog()
            Dim woreceipt As New frmworeceipt(receipt)

            woreceipt.ShowDialog()
            Me.Close()
            'save
        Catch ex As Exception
            MsgBox("Save Item List:" + ex.Message)
        End Try
    End Sub
    Private Sub save_transaction()
        Try
            Dim trans As New Transaction
            trans.setcustomer(cid)
            trans.setreading(pid)
            trans.setsizebridge(txtsize.Text)
            trans.setdeliverydate(txtdate.Text)
            trans.setedged(txtedged.Text)
            trans.setissued(userinfo(0))
            trans.setpayable(txtamount.Text)
            trans.setdeposit(txtdeposit.Text)
            trans.setbalance(txtbalance.Text)
            trans.setmethod(cbxpayment.SelectedItem)
            trans.setpos("WO")
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
    Private Function check_errors() As Integer
        Dim err As Integer = 0
        If lvorders.Items.Count = 0 Then
            MessageBox.Show("There are no items in the list", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            err += 1

        ElseIf txtissued.Text.Length = 0 Then
            MessageBox.Show("Issued by cannot be empty", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            err += 1
        ElseIf txtedged.Text.Length = 0 Then
            MessageBox.Show("Edged by cannot be empty", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            err += 1

        ElseIf cbxpayment.SelectedIndex = 1 Then
            If (cbxbank.SelectedIndex = -1) Then
                MessageBox.Show("Select the bank for card payments", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                err += 1
            End If
        ElseIf deposit = 0 And totalprice > 0 Then
            MessageBox.Show("Deposit must not be zero", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            err += 1
        ElseIf deposit > totalprice Then
            MessageBox.Show("Deposit must not be greater than the amount", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtdeposit.Text = "0.0"
            err += 1
        End If

        Return err
    End Function

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

    Private Sub add_item_add_ons(ByVal id As String, ByVal name As String)


        Dim lensfound As Boolean = False
        For Each item As ListViewItem In lvorders.Items
            If (item.SubItems(0).Text.Equals(id)) And item.SubItems(1).Text.Equals("(ADD-ON)" + name) Then
                lensfound = True
            End If
        Next

        If lensfound = False Then
            discount = 0
            Dim i As Integer
            For i = 0 To addonlist.Count - 1
                If addonlist(i).getid = id Then

                    list1 = lvorders.Items.Add(addonlist(i).getid)
                    list1.SubItems.Add("(ADD-ON)" + addonlist(i).getname)
                    list1.SubItems.Add("1")
                    list1.SubItems.Add(addonlist(i).getprice)
                    list1.SubItems.Add("1")
                    Dim itemprice As Decimal
                    itemprice = 1 * Convert.ToDecimal(addonlist(i).getprice)
                    itemprice = itemprice * (1 - (discount / 100))
                    list1.SubItems.Add(itemprice.ToString)
                    list1.SubItems.Add(discount)
                    list1.SubItems.Add(itemprice.ToString)
                    list1.SubItems.Add("ADD-ON")
                    update_price()
                End If
            Next
        Else
            MsgBox("This item is already in the list")
        End If
    End Sub
End Class