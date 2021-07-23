
Public Class frmaddons

    Dim productlist As List(Of Addons)
    Dim idselected As String

    Private Sub btncancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub button_events(ByVal strevent As String)
        Select Case strevent
            Case "load"
                btnnew.Enabled = True
                btnsave.Enabled = False
                btnudate.Enabled = False
                btndelete.Enabled = False
                btncancel.Enabled = False
                inputpanel.Enabled = False
                clear_inputs()
            Case "new"
                btnnew.Enabled = False
                btnsave.Enabled = True
                btnudate.Enabled = False
                btndelete.Enabled = False
                btncancel.Enabled = True
                inputpanel.Enabled = True
                inputpanel.Enabled = True
            Case "select"
                btnnew.Enabled = False
                btnsave.Enabled = False
                btnudate.Enabled = True
                btndelete.Enabled = True
                btncancel.Enabled = True
                inputpanel.Enabled = True
        End Select

    End Sub

    Private Sub frmaddons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        button_events("load")
        productlist = New List(Of Addons)
        load_products()
        load_brands()
    End Sub
    Private Sub btncancel_Click_1(sender As Object, e As EventArgs)
        button_events("load")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnnew_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnsave_Click_1(sender As Object, e As EventArgs)
        If (check_error() = 0) Then
            Dim save As Addons
            save = New Addons
            Dim contents As List(Of String)
            contents = New List(Of String)

            contents.Add(txtname.Text)
            contents.Add(txtbrand.Text)
            contents.Add(txtdescription.Text)
            contents.Add(txtprice.Text)
            If (save.save_add_on(contents)) Then
                MessageBox.Show("New add-ons added", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                button_events("load")
                load_products()
            End If


        End If


    End Sub

    Private Sub btnudate_Click_1(sender As Object, e As EventArgs)
        button_events("load")
    End Sub

    Private Sub btndelete_Click_1(sender As Object, e As EventArgs)
        button_events("load")
    End Sub

    Private Sub btncancel_Click_2(sender As Object, e As EventArgs)
        button_events("load")
    End Sub

    Private Sub load_products()

        productlist.Clear()

        Dim products As New Addons

        productlist = products.load_products()
        If productlist Is Nothing Then
            MessageBox.Show("List is empty")
        Else
            lvdetails.Items.Clear()
            Dim i As Integer
            For i = 0 To productlist.Count - 1
                Dim lvitems As ListViewItem
                lvitems = lvdetails.Items.Add(productlist(i).getid)
                lvitems.SubItems.Add(productlist(i).getbrand)
                lvitems.SubItems.Add(productlist(i).getname)
                lvitems.SubItems.Add(productlist(i).getdesc)
                lvitems.SubItems.Add(productlist(i).getprice)

            Next


        End If
    End Sub
    Private Sub load_brands()
        'load brands
        Dim brandlist As New List(Of String)

        cbxbrand.Items.Clear()
        Dim products As New Addons

        brandlist = products.get_brand
        If brandlist IsNot Nothing Then
            cbxbrand.Enabled = True
            For Each items In brandlist
                cbxbrand.Items.Add(items)
            Next
        Else
            cbxbrand.Enabled = False
        End If



    End Sub
    Private Function check_error() As Integer
        Dim err As Integer = 0
        Try

            If txtbrand.Text.Length = 0 Then
                MessageBox.Show("Please enter the product brand", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Err += 1
            ElseIf txtname.Text.Length = 0 Then
                MessageBox.Show("Please enter the product name", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Err += 1
            ElseIf txtprice.Text.Length = 0 Then

                MessageBox.Show("Please enter the product price", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Err += 1
            ElseIf Convert.ToDecimal(txtprice.Text) <= 0 Then
                MessageBox.Show("Price cannot be zero", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Err += 1
            End If


        Catch ex As Exception
            Err += 1
            MsgBox(ex.Message)
        End Try
        Return err
    End Function
    Private Sub clear_inputs()
        txtbrand.Clear()
        txtname.Clear()
        txtdescription.Clear()
        txtprice.Text = "0.0"
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        button_events("new")
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtsearch.Text.Length = 0 Then
                MessageBox.Show("Enter the keyword to search", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                search_add_ons(txtsearch.Text, "name")
            End If
        End If
    End Sub
    Private Sub search_add_ons(ByVal key As String, ByVal col As String)
        productlist.Clear()
        Dim products As Addons
        products = New Addons


        productlist = products.search_products(key, col)
        If productlist Is Nothing Then
            MessageBox.Show("No results")
        Else
            lvdetails.Items.Clear()
            Dim i As Integer
            For i = 0 To productlist.Count - 1
                Dim lvitems As ListViewItem
                lvitems = lvdetails.Items.Add(productlist(i).getid)
                lvitems.SubItems.Add(productlist(i).getbrand)
                lvitems.SubItems.Add(productlist(i).getname)
                lvitems.SubItems.Add(productlist(i).getdesc)
                lvitems.SubItems.Add(productlist(i).getprice)

            Next
        End If
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        load_products()
        txtsearch.Clear()
    End Sub

    Private Sub cbxbrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxbrand.SelectedIndexChanged
        If cbxbrand.SelectedIndex <> -1 Then
            search_add_ons(cbxbrand.SelectedItem, "brand")
        End If
    End Sub

    Private Sub lvdetails_Click(sender As Object, e As EventArgs) Handles lvdetails.Click
        idselected = lvdetails.SelectedIndices(0).ToString
        txtbrand.Text = productlist(idselected).getbrand
        txtname.Text = productlist(idselected).getname
        txtdescription.Text = productlist(idselected).getdesc
        txtprice.Text = productlist(idselected).getprice
        button_events("select")
    End Sub

    Private Sub btncancel_Click_3(sender As Object, e As EventArgs) Handles btncancel.Click
        button_events("load")
        idselected = ""
        txtsearch.Focus()
    End Sub

    Private Sub btnudate_Click(sender As Object, e As EventArgs) Handles btnudate.Click
        If (check_error() = 0) Then
            Dim save As Addons
            save = New Addons
            Dim contents As List(Of String)
            contents = New List(Of String)
            contents.Add(txtbrand.Text)
            contents.Add(txtname.Text)
            contents.Add(txtdescription.Text)
            contents.Add(txtprice.Text)
            contents.Add(productlist(idselected).getid)
            If (save.update_add_on(contents)) Then
                MessageBox.Show("Record updated", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                button_events("load")
                load_products()
                load_brands()
            Else
                MessageBox.Show("Error")
            End If


        End If


    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If (check_error() = 0) Then
            Dim save As Addons
            save = New Addons
            Dim contents As List(Of String)
            contents = New List(Of String)
            contents.Add(txtbrand.Text)
            contents.Add(txtname.Text)
            contents.Add(txtdescription.Text)
            contents.Add(txtprice.Text)
            If (save.save_add_on(contents)) Then
                MessageBox.Show("New add-ons added", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                button_events("load")
                load_products()
            End If


        End If


    End Sub

    Private Sub txtsearch_Enter(sender As Object, e As EventArgs) Handles txtsearch.Enter
        button_events("load")
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim x As Integer
        x = MessageBox.Show("Deleting this prescription will also delete the work order/receipt linked to it", "Optical Shop POS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If x = vbYes Then
            Dim confirm As frmconfirmation
            confirm = New frmconfirmation()

            Dim a As Integer = confirm.ShowDialog

            If (confirm.status = 1) Then
                Dim product As New Addons
                If (product.delete_add_on(productlist(idselected).getid)) Then
                    MessageBox.Show("Record Deleted", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    load_products()
                    load_brands()
                    button_events("load")
                End If
            Else
                MessageBox.Show("Incorrect Credentials", "Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub txtprice_Leave(sender As Object, e As EventArgs) Handles txtprice.Leave
        Try

            txtprice.Text = Convert.ToDecimal(txtprice.Text).ToString("N2")
            Dim price As Decimal
            price = txtprice.Text
            If price <= 0 Then
                MsgBox("Price cannot be zero", MsgBoxStyle.Exclamation)
                txtprice.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            txtprice.Text = "0.0"
            txtprice.Focus()
        End Try
    End Sub

    Private Sub txtprice_KeyUp(sender As Object, e As KeyEventArgs) Handles txtprice.KeyUp

    End Sub

    Private Sub txtprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso 'restricts anything but number keys
    e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then 'allows use of backspace
            e.Handled = True
        End If

    End Sub
End Class