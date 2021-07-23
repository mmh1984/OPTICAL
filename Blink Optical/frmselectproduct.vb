Public Class frmselectproduct

    Public productid As String
    Public discount As Decimal
    Public qty, stock As Integer
    Dim productlist As List(Of ProductFrame)
    Dim plist As ListViewItem
    Dim amount As Decimal
    Private Sub frmselectproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        productid = 0
        discount = 0
        qty = 0
        load_types()
        load_all_products()

    End Sub
    Private Sub load_types()
        Try
            Dim list1 As New List(Of ProductType)
            Dim typeobj As New ProductType
            list1 = typeobj.get_category
            If list1 IsNot Nothing Then
                cbxproducttype.Enabled = True
                cbxproducttype.Items.Clear()
                Dim x As Integer
                For x = 0 To list1.Count - 1
                    cbxproducttype.Items.Add(list1(x).getname)
                Next
            Else
                cbxproducttype.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Load types:" + ex.Message)
        End Try
    End Sub
    Private Sub load_product_model()
        Try
            Dim obj1 As New ProductFrame
            Dim list1 As New List(Of String)
            list1 = obj1.get_model2(cbxproducttype.SelectedItem)
            If list1 IsNot Nothing Then
                cbxpmodel.Items.Clear()
                cbxpmodel.Enabled = True
                For Each item In list1
                    cbxpmodel.Items.Add(item)
                Next
            Else

                cbxpmodel.Enabled = False

            End If
        Catch ex As Exception
            MsgBox("Load Product Name:" + ex.Message)
        End Try
    End Sub

    Private Sub load_all_products()
        Try
            txtqty.Enabled = False
            txtdiscount.Enabled = False
            btnselect.Enabled = False
            productlist = New List(Of ProductFrame)
            Dim productobj As New ProductFrame
            productlist = productobj.load_products()

            If productlist IsNot Nothing Then
                Dim x As Integer
                lvproducts.Items.Clear()
                lvproducts.Enabled = True
                For x = 0 To productlist.Count - 1

                    plist = lvproducts.Items.Add(productlist(x).getid)
                    plist.SubItems.Add(productlist(x).get_type)
                    plist.SubItems.Add(productlist(x).getname & " " & productlist(x).getmodel)
                    plist.SubItems.Add(productlist(x).getprice)
                    plist.SubItems.Add(productlist(x).getdesc)
                    plist.SubItems.Add(productlist(x).getstock)
                    plist.SubItems.Add(productlist(x).getcolor)
                    plist.SubItems.Add("(" & productlist(x).getsph & ")" & "(" & productlist(x).getcyl & ")")
                Next
            Else
                Me.Close()
                MessageBox.Show("There are no products in the system", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox("Load products:" + ex.Message)

        End Try

    End Sub
    Private Sub search_products()
        Try
            txtqty.Enabled = False
            txtdiscount.Enabled = False
            btnselect.Enabled = False
            productlist = New List(Of ProductFrame)
            Dim productobj As New ProductFrame
            productlist = productobj.search_product_type(cbxproducttype.SelectedItem)

            If productlist IsNot Nothing Then
                Dim x As Integer
                lvproducts.Items.Clear()
                lvproducts.Enabled = True
                For x = 0 To productlist.Count - 1

                    plist = lvproducts.Items.Add(productlist(x).getid)
                    plist.SubItems.Add(productlist(x).get_type)
                    plist.SubItems.Add(productlist(x).getname & " " & productlist(x).getmodel)
                    plist.SubItems.Add(productlist(x).getprice)
                    plist.SubItems.Add(productlist(x).getdesc)
                    plist.SubItems.Add(productlist(x).getstock)
                    plist.SubItems.Add(productlist(x).getcolor)
                    plist.SubItems.Add("(" & productlist(x).getsph & ")" & "(" & productlist(x).getcyl & ")")
                Next
            Else

                MessageBox.Show("There are no products with the type selected", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox("Load products:" + ex.Message)

        End Try

    End Sub

    Private Sub search_product_name()
        Try
            txtqty.Enabled = False
            txtdiscount.Enabled = False
            btnselect.Enabled = False
            productlist = New List(Of ProductFrame)
            Dim productobj As New ProductFrame
            productlist = productobj.search_product_name(txtsearch.Text)

            If productlist IsNot Nothing Then
                Dim x As Integer
                lvproducts.Items.Clear()
                lvproducts.Enabled = True
                For x = 0 To productlist.Count - 1

                    plist = lvproducts.Items.Add(productlist(x).getid)
                    plist.SubItems.Add(productlist(x).get_type)
                    plist.SubItems.Add(productlist(x).getname & " " & productlist(x).getmodel)
                    plist.SubItems.Add(productlist(x).getprice)
                    plist.SubItems.Add(productlist(x).getdesc)
                    plist.SubItems.Add(productlist(x).getstock)
                    plist.SubItems.Add(productlist(x).getcolor)
                    plist.SubItems.Add("(" & productlist(x).getsph & ")" & "(" & productlist(x).getcyl & ")")
                Next
            Else

                MessageBox.Show("There are no products with the type selected", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox("Load products:" + ex.Message)

        End Try

    End Sub
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub cbxproducttype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxproducttype.SelectedIndexChanged
        If cbxproducttype.SelectedIndex <> -1 Then
            search_products()
            load_product_model()

            If cbxproducttype.SelectedItem = "Lens" Or cbxproducttype.SelectedItem = "Contact Lens" Then
                gbxlens.Enabled = True
            Else
                gbxlens.Enabled = False
            End If
        End If


    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        load_all_products()
        txtsearch.Clear()
    End Sub

    Private Sub txtsearch_Click(sender As Object, e As EventArgs) Handles txtsearch.Click

    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtsearch.Text.Length > 0 Then
                search_product_name()
            End If
        End If
    End Sub

    Private Sub lvproducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvproducts.SelectedIndexChanged

    End Sub

    Private Sub lvproducts_Click(sender As Object, e As EventArgs) Handles lvproducts.Click
        If lvproducts.Items.Count > 0 And lvproducts.SelectedItems(0).SubItems(5).Text <> "0" Then

            productid = 0
            discount = 0
            qty = 0
            stock = 0
            productid = lvproducts.SelectedItems(0).Text
            amount = lvproducts.SelectedItems(0).SubItems(3).Text
            lblamount.Text = amount.ToString()
            lbltotal.Text = amount - discount
            stock = lvproducts.SelectedItems(0).SubItems(5).Text
            txtdiscount.Enabled = True
            txtqty.Enabled = True
            txtqty.Text = "0"
            txtdiscount.Text = "0.0"
            btnselect.Enabled = True
            txtqty.Focus()
        Else
            productid = 0
            discount = 0
            qty = 0
            stock = 0

            amount = 0
            lblamount.Text = "0"
            lbltotal.Text = "0"
            stock = 0
            txtdiscount.Enabled = False
            txtqty.Enabled = False
            txtqty.Text = "0"
            txtdiscount.Text = "0.0"
            btnselect.Enabled = True
            txtqty.Focus()
        End If
    End Sub

    Private Sub txtqty_Leave(sender As Object, e As EventArgs) Handles txtqty.Leave
        Try
            qty = Integer.Parse(txtqty.Text)

            If qty <= 0 Then
                MsgBox("Quantity cannot be negative or zero", MsgBoxStyle.Exclamation)
                txtqty.Text = "0"
                txtqty.Focus()
            ElseIf stock > 1 Then

                If qty > stock Then
                    MsgBox("Quantity cannot exceed the available stock", MsgBoxStyle.Exclamation)
                Else
                    amount = amount * qty
                    lbltotal.Text = amount
                End If
            End If

        Catch ex As Exception
            txtqty.Text = "0"
            txtqty.Focus()
            MsgBox("Qty:" + ex.Message)
        End Try
    End Sub

    Private Sub txtdiscount_Leave(sender As Object, e As EventArgs) Handles txtdiscount.Leave
        Try
            discount = txtdiscount.Text
            If discount < 0 Then
                MessageBox.Show("Discount cannot be less than zero", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtdiscount.Focus()
            ElseIf discount >= amount Then
                MessageBox.Show("Maximum discount is less than amount", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtdiscount.Focus()
            Else
                txtdiscount.Text = discount.ToString("N2")
                amount = amount - discount
                lbltotal.Text = amount.ToString("N2")
            End If
        Catch ex As Exception
            txtdiscount.Text = "0"
            txtdiscount.Focus()
            MsgBox("Discount:" + ex.Message)
        End Try
    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso 'restricts anything but number keys
   e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then 'allows use of backspace
            e.Handled = True
        End If
    End Sub

    Private Sub txtdiscount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdiscount.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso 'restricts anything but number keys
   e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then 'allows use of backspace
            e.Handled = True
        End If
    End Sub

    Private Sub cbxpmodel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxpmodel.SelectedIndexChanged
        If (cbxpmodel.Items.Count > 0) Then
            If productlist IsNot Nothing Then
                Dim intcount As Integer = 0
                lvproducts.Items.Clear()
                For Each item In productlist
                    If item.get_type = cbxproducttype.SelectedItem And item.getname = cbxpmodel.SelectedItem Then
                        intcount += 1
                        plist = lvproducts.Items.Add(item.getid)
                        plist.SubItems.Add(item.get_type)
                        plist.SubItems.Add(item.getname & " " & item.getmodel)
                        plist.SubItems.Add(item.getprice)
                        plist.SubItems.Add(item.getdesc)
                        plist.SubItems.Add(item.getstock)
                        plist.SubItems.Add(item.getcolor)
                        plist.SubItems.Add("(" & item.getsph & ")" & "(" & item.getcyl & ")")
                    End If
                Next

            End If
        End If

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Try
            If txtsph.Text.Length = 0 Or txtcyl.Text.Length = 0 Then
                MsgBox("Enter SPH and CYL to search", MsgBoxStyle.Exclamation)
            Else
                Dim obj1 As New ProductFrame
                Dim lenslist As New List(Of ProductFrame)
                lenslist = obj1.search_lens(txtsph.Text, txtcyl.Text)
                If lenslist IsNot Nothing Then
                    Dim intcount As Integer = 0
                    lvproducts.Items.Clear()
                    For Each item In lenslist

                        intcount += 1
                        plist = lvproducts.Items.Add(item.getid)
                        plist.SubItems.Add(item.get_type)
                        plist.SubItems.Add(item.getname & " " & item.getmodel)
                        plist.SubItems.Add(item.getprice)
                        plist.SubItems.Add(item.getdesc)
                        plist.SubItems.Add(item.getstock)
                        plist.SubItems.Add(item.getcolor)
                        plist.SubItems.Add("(" & item.getsph & ")" & "(" & item.getcyl & ")")

                    Next

                Else
                    MsgBox("No results")
                End If
            End If
        Catch ex As Exception
            MsgBox("Search:" + ex.Message)
        End Try
    End Sub

    Private Sub txtqty_TextChanged(sender As Object, e As EventArgs) Handles txtqty.TextChanged

    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        If productid <> 0 And qty > 0 Then
            If qty > stock Then
                MessageBox.Show("Quantity cannot be greater than the stock", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtqty.Focus()
            ElseIf qty <= 0 Then
                MessageBox.Show("Quantity cannot be negative or zero", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtqty.Focus()
            Else
                discount = txtdiscount.Text
                Me.Close()
            End If

        Else
            MessageBox.Show("Quantity cannot be zero", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class