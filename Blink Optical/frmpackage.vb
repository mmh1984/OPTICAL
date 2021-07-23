Imports System.Data.SqlClient

Public Class frmpackage
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Dim productlist As List(Of ProductFrame)
    Dim speciallist As List(Of ProductFrame)
    Dim addonlist As List(Of Addons)
    Dim list1 As ListViewItem
    Dim idselected As String
    Dim packageid As String
    Private Sub cbxframe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxframe.SelectedIndexChanged
        If cbxframe.SelectedIndex = 0 Then

            Dim selectitem As New frmselectitem("Frames")
            selectitem.ShowDialog()

            If (selectitem.idselected <> 0) Then
                add_item(selectitem.idselected, "Frames")
            Else
                MessageBox.Show("No item selected")

            End If
        ElseIf cbxframe.SelectedIndex = 1 Then
            Dim specialorder As New frmspecialorders
            specialorder.ShowDialog()
            If (specialorder.idselected <> 0) Then
                add_item_special(specialorder.idselected, "Frames")
            Else
                MessageBox.Show("No item selected")

            End If

        End If
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
                    lens.setbrand(rs(4).ToString)
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
    Private Sub item_details(ByVal id As String, ByVal type As String)
        load_products()
        For i = 0 To productlist.Count - 1
            If productlist(i).getid = id Then
                If (type = "Frames") Then
                    lvframes.Items.Clear()
                    list1 = lvframes.Items.Add(productlist(i).getid)
                    list1.SubItems.Add(productlist(i).getname)
                    list1.SubItems.Add(productlist(i).getbrand)
                    list1.SubItems.Add(productlist(i).getstock)
                ElseIf (type = "Lens") Then
                    lvlens.Items.Clear()
                    list1 = lvlens.Items.Add(productlist(i).getid)
                    list1.SubItems.Add(productlist(i).getname)
                    list1.SubItems.Add(productlist(i).getbrand)
                    list1.SubItems.Add(productlist(i).getstock)

                End If

            End If
        Next

    End Sub
    Private Sub add_item(ByVal id As String, ByVal type As String)

        load_products()
        txtqty.Text = 0
        Dim i As Integer
        For i = 0 To productlist.Count - 1
            If productlist(i).getid = id Then
                If (productlist(i).getstock <> "0" And type = "Frames") Then
                    lvframes.Items.Clear()
                    list1 = lvframes.Items.Add(productlist(i).getid)
                    list1.SubItems.Add(productlist(i).getname)
                    list1.SubItems.Add(productlist(i).getbrand)
                    list1.SubItems.Add(productlist(i).getstock)
                ElseIf (productlist(i).getstock <> "0" And type = "Lens") Then
                    lvlens.Items.Clear()
                    list1 = lvlens.Items.Add(productlist(i).getid)
                    list1.SubItems.Add(productlist(i).getname)
                    list1.SubItems.Add(productlist(i).getbrand)
                    list1.SubItems.Add(productlist(i).getstock)
                Else
                    MessageBox.Show("This item has no stock available", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Next

    End Sub

    Private Sub add_item_special(ByVal id As String, ByVal type As String)

        load_special()
        txtqty.Text = 0
        Dim i As Integer
        For i = 0 To speciallist.Count - 1
            If speciallist(i).getid = id Then
                If (type = "Frames") Then
                    lvframes.Items.Clear()
                    list1 = lvframes.Items.Add(speciallist(i).getid)
                    list1.SubItems.Add("(SPECIAL ORDER)" + speciallist(i).getname)
                    list1.SubItems.Add(speciallist(i).getbrand)
                    list1.SubItems.Add(speciallist(i).getstock)
                ElseIf (type = "Lens") Then
                    lvlens.Items.Clear()
                    list1 = lvlens.Items.Add(speciallist(i).getid)
                    list1.SubItems.Add("(SPECIAL ORDER)" + speciallist(i).getname)
                    list1.SubItems.Add(speciallist(i).getbrand)
                    list1.SubItems.Add(speciallist(i).getstock)
                Else
                    MessageBox.Show("This item has no stock available", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Next

    End Sub
    Private Sub load_package()
        Dim list1 As New List(Of ProductPackage)
        Dim productobj As New ProductPackage
        list1 = productobj.load_packages
        If list1 IsNot Nothing Then
            lvpackage.Enabled = True
            lvpackage.Items.Clear()
            Dim packagelist As New ListViewItem
            Dim x As Integer
            For x = 0 To list1.Count - 1
                packagelist = lvpackage.Items.Add(list1(x).getid)
                packagelist.SubItems.Add(list1(x).getname)
                packagelist.SubItems.Add(list1(x).getqty)
                packagelist.SubItems.Add(list1(x).getprice)
                packagelist.SubItems.Add(list1(x).getdescription)
            Next
        Else
            lvpackage.Enabled = True
        End If
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
                add_item_special(specialorder.idselected, "Lens")
            Else
                MessageBox.Show("No item selected")

            End If
        End If
    End Sub

    Private Sub frmpackage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_package()
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btncancel.Enabled = False

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click

        If lvframes.Items.Count > 0 And lvlens.Items.Count > 0 Then
            Dim framestock As Integer = lvframes.Items(0).SubItems(3).Text
            Dim lensstock As Integer = lvlens.Items(0).SubItems(3).Text
            Dim qty As Integer = 0
            qty=txtqty.Text  
            If framestock > 0 Then
                If lensstock > 0 Then
                    lensstock -= 1
                    framestock -= 1
                    qty += 1
                    txtqty.Text = qty
                    lvframes.Items(0).SubItems(3).Text = framestock
                    lvlens.Items(0).SubItems(3).Text = lensstock
                Else
                    MessageBox.Show("Quantity cannot exceed your current stock", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Quantity cannot exceed your current stock", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


        End If

    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        Dim qty As Integer
        qty = txtqty.Text
        If (qty = 1) Then
            MsgBox("Quantity cannot be 0")
        Else
            qty -= 1
            Dim framestock As Integer = lvframes.Items(0).SubItems(3).Text
            Dim lensstock As Integer = lvlens.Items(0).SubItems(3).Text
            framestock += 1
            lensstock += 1
            lvframes.Items(0).SubItems(3).Text = framestock
            lvlens.Items(0).SubItems(3).Text = lensstock
            txtqty.Text = qty
        End If


    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If lvlens.Items.Count <= 0 Or lvframes.Items.Count <= 0 Then
            MessageBox.Show("Please select the lens and frames", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtname.Text.Length = 0 Then
            MessageBox.Show("Please enter the name of this package", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtprice.Text.Length = 0 Then
            MessageBox.Show("Please enter the price of this package", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Convert.ToDecimal(txtprice.text) <= 0 Then
            MessageBox.Show("Price cannot be zero", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtqty.Text = "0" Then
            MessageBox.Show("Quantity cannot be zero", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            txtprice.Text = Convert.ToDecimal(txtprice.Text).ToString("N2")
            Dim package As New ProductPackage
            Dim list1 As New List(Of String)
            list1.Add(txtname.Text)
            list1.Add(lvframes.Items(0).Text)
            If lvlens.Items(0).SubItems(1).Text.Contains("SPECIAL ORDER") Then
                list1.Add("0")
                list1.Add(lvlens.Items(0).Text)
            Else
                list1.Add(lvlens.Items(0).Text)
                list1.Add("0")
            End If
            list1.Add(txtdescription.Text)
            list1.Add(txtprice.Text)
            list1.Add(txtqty.Text)
            If package.save_package(list1) Then
                MessageBox.Show("New package created", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim productobj As New ProductFrame
                Dim framelist As New List(Of String)
                Dim lenslist As New List(Of String)
                framelist.Add(lvframes.Items(0).Text)
                framelist.Add(lvframes.Items(0).SubItems(3).Text)
                If lvlens.Items(0).SubItems(1).Text.Contains("SPECIAL ORDER") = False Then

                    lenslist.Add(lvlens.Items(0).Text)
                    lenslist.Add(lvlens.Items(0).SubItems(3).Text)
                    productobj.reduce_stock(lenslist)
                End If
                productobj.reduce_stock(framelist)
                load_package()
            End If

        End If
    End Sub

    Private Sub lvpackage_Click(sender As Object, e As EventArgs) Handles lvpackage.Click
        If lvpackage.Items.Count > 0 Then
            packageid = lvpackage.SelectedItems(0).Text
            Dim packagelist As New ProductPackage
            Dim plist As List(Of String)
            plist = packagelist.search_package(packageid)
            item_details(plist(2), "Frames")
            If (plist(3).Equals("0")) Then
                add_item_special(plist(4), "Lens")
            Else
                item_details(plist(3), "Lens")
            End If

            txtname.Text = plist(1)
            txtdescription.Text = plist(5)
            txtprice.Text = plist(6)
            txtqty.Text = plist(7)
            btnsave.Enabled = False
            btnupdate.Enabled = True
            btndelete.Enabled = True
            btncancel.Enabled = True
            cbxframe.Enabled = False
            cbxlens.Enabled = False
        End If
    End Sub

    Private Sub lvpackage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvpackage.SelectedIndexChanged

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        reset_fields()
    End Sub
    Private Sub reset_fields()
        packageid = 0
        btnsave.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False
        cbxframe.Enabled = True
        cbxlens.Enabled = True
        lvframes.Items.Clear()
        lvlens.Items.Clear()
        txtdescription.Clear()
        txtname.Clear()
        txtqty.Text = 1
        txtprice.Text = 0
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            Dim x As Integer
            x = MessageBox.Show("Delete this package?", "Optical Shop POS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If x = vbYes Then
                Dim confirm As frmconfirmation
                confirm = New frmconfirmation()

                Dim a As Integer = confirm.ShowDialog

                If (confirm.status = 1) Then
                    Dim packageobj As New ProductPackage
                    If (packageobj.delete_package(packageid)) Then
                        MessageBox.Show("Package Deleted", "Package", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim productobj As New ProductFrame
                        Dim framelist As New List(Of String)
                        Dim lenslist As New List(Of String)
                        framelist.Add(lvframes.Items(0).Text)
                        framelist.Add(txtqty.Text)
                        If lvlens.Items(0).SubItems(1).Text.Contains("SPECIAL ORDER") = False Then

                            lenslist.Add(lvlens.Items(0).Text)
                            lenslist.Add(txtqty.Text)
                            productobj.add_stock(lenslist)
                        End If
                        productobj.add_stock(framelist)

                        reset_fields()
                        load_package()
                    End If
                Else
                    MessageBox.Show("Incorrect Credentials", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Delete Prescription:" + ex.Message)
        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If lvlens.Items.Count <= 0 Or lvframes.Items.Count <= 0 Then
            MessageBox.Show("Please select the lens and frames", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtname.Text.Length = 0 Then
            MessageBox.Show("Please enter the name of this package", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtprice.Text.Length = 0 Then
            MessageBox.Show("Please enter the price of this package", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim package As New ProductPackage
            Dim list1 As New List(Of String)
            list1.Add(txtname.Text)
            list1.Add(lvframes.Items(0).Text)
            If lvlens.Items(0).SubItems(1).Text.Contains("SPECIAL ORDER") Then
                list1.Add("0")
                list1.Add(lvlens.Items(0).Text)
            Else
                list1.Add(lvlens.Items(0).Text)
                list1.Add("0")
            End If
            list1.Add(txtdescription.Text)
            list1.Add(txtprice.Text)
            list1.Add(txtqty.Text)
            list1.Add(packageid)
            If package.update_package(list1) Then
                MessageBox.Show("Package updated", "Optical Shop POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim productobj As New ProductFrame
                Dim framelist As New List(Of String)
                Dim lenslist As New List(Of String)
                framelist.Add(lvframes.Items(0).Text)
                framelist.Add(lvframes.Items(0).SubItems(3).Text)
                If lvlens.Items(0).SubItems(1).Text.Contains("SPECIAL ORDER") = False Then

                    lenslist.Add(lvlens.Items(0).Text)
                    lenslist.Add(lvlens.Items(0).SubItems(3).Text)
                    productobj.reduce_stock(lenslist)
                End If
                productobj.reduce_stock(framelist)
                reset_fields()
                load_package()
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

    Private Sub txtprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso 'restricts anything but number keys
   e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then 'allows use of backspace
            e.Handled = True
        End If
    End Sub
End Class