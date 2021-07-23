Imports System.Data.SqlClient
Public Class frmproducts
    'connection
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Dim productid, productname As String
    Dim product_list As New List(Of ProductFrame)

    Dim path As String = "c:\blink\images\"
    Private Sub btncancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmproducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_all_products()
        productid = ""
        btnstocks.Enabled = False
        txtsearch.Focus()
        productimage.Enabled = False
        load_product_name()

    End Sub
    Private Sub load_product_name()
        Try
            Dim obj1 As New ProductFrame
            Dim list1 As New List(Of String)
            list1 = obj1.get_name
            If list1 IsNot Nothing Then
                cbxpname.Items.Clear()
                cbxpname.Enabled = True
                For Each item In list1
                    cbxpname.Items.Add(Trim(item))
                Next
            Else
                cbxpname.Enabled = False
                cbxpmodel.Enabled = False

            End If
        Catch ex As Exception
            MsgBox("Load Product Name:" + ex.Message)
        End Try
    End Sub

    Private Sub load_product_model()
        Try
            Dim obj1 As New ProductFrame
            Dim list1 As New List(Of String)
            list1 = obj1.get_model(cbxpname.SelectedItem)
            If list1 IsNot Nothing Then
                cbxpmodel.Items.Clear()
                cbxpmodel.Enabled = True
                For Each item In list1
                    cbxpmodel.Items.Add(Trim(item))
                Next
            Else

                cbxpmodel.Enabled = False

            End If
        Catch ex As Exception
            MsgBox("Load Product Name:" + ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        Dim addproduct As frmaddproducts
        addproduct = New frmaddproducts
        addproduct.ShowDialog()
        tabproducts.SelectedIndex = 0

        load_all_products()


    End Sub

    Private Sub producttab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabproducts.SelectedIndexChanged

        productimage.Image = Image.FromFile(path + "default.png")
        productimage.Enabled = False
        If tabproducts.SelectedTab.TabIndex = 0 Then
            'MessageBox.Show("All Products")
            load_all_products()
            productid = ""
        End If
        If tabproducts.SelectedTab.TabIndex = 1 Then
            'MessageBox.Show("Frames")
            load_frames()
            productid = ""
            btnstocks.Enabled = False
        End If
        If tabproducts.SelectedTab.TabIndex = 2 Then
            load_lens()
            productid = ""
            btnstocks.Enabled = False
        End If
        If tabproducts.SelectedTab.TabIndex = 3 Then
            load_contacts()
            productid = ""
            btnstocks.Enabled = False
        End If
        If tabproducts.SelectedTab.TabIndex = 4 Then
            load_solutions()
            productid = ""
            btnstocks.Enabled = False
        End If

        If tabproducts.SelectedTab.TabIndex = 5 Then
            load_special()
            productid = ""

        End If
        If tabproducts.SelectedTab.TabIndex = 6 Then
            load_others()
            productid = ""

        End If
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

    Private Sub load_all_products()
        Try
            open_connection()
            product_list.Clear()
            Dim sql As String
            sql = "SELECT * FROM tblproducts WHERE productstatus <> 'deleted' or productstatus is null ORDER BY productid DESC"
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                lvproducts.Enabled = True
                lvproducts.Items.Clear()
                While rs.Read

                    Dim obj1 As New ProductFrame
                    obj1.setid(rs(0))
                    obj1.settype(rs(1))
                    obj1.setcode(rs(2))
                    obj1.setname(Trim(rs(3)))
                    obj1.setbrand(rs(4))
                    obj1.setmodel(Trim(rs(5)))
                    obj1.setcolor(rs(6))
                    obj1.setdesc(rs(7))
                    obj1.setprice(rs(8))
                    obj1.setstock(rs(9))
                    obj1.setsph(rs(10))
                    obj1.setcyl(rs(11))
                    product_list.Add(obj1)
                End While
                rs.Close()
                cmd.Dispose()
                conn.Close()

            Else
                MessageBox.Show("No products in the system, add product by clicking the +add product button")
                lvproducts.Enabled = False
                btnstocks.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Load all products:" & ex.Message)
        End Try
    End Sub


    Private Sub load_frames()
        Try
            If product_list IsNot Nothing Then
                Dim intcount As Integer = 0
                lvproducts1.Items.Clear()
                For Each item In product_list

                    If item.get_type = "Frames" Then
                        intcount += 1
                        Dim listitem As New ListViewItem
                        listitem = lvproducts1.Items.Add(item.getid)
                        listitem.SubItems.Add(item.getcode)
                        listitem.SubItems.Add(item.getname)
                        listitem.SubItems.Add(item.getbrand)
                        listitem.SubItems.Add(item.getmodel)
                        listitem.SubItems.Add(item.getprice)
                        listitem.SubItems.Add(item.getstock)
                        listitem.SubItems.Add(item.getcolor)
                        listitem.SubItems.Add(item.getdesc)
                    End If
                Next
                lblitem2.Text = intcount
            Else
                MessageBox.Show("No products in the system, add product by clicking the +add product button")
                lvproducts2.Enabled = False
                btnstocks.Enabled = False
                tabproducts.SelectedIndex = 1
            End If
        Catch ex As Exception
            MessageBox.Show("Load frames:" & ex.Message)
        End Try
    End Sub

    Private Sub load_lens()

        Try
            If product_list IsNot Nothing Then
                Dim intcount As Integer = 0
                lvproducts2.Items.Clear()
                For Each item In product_list
                    If item.get_type = "Lens" Then
                        intcount += 1
                        Dim listitem As New ListViewItem
                        listitem = lvproducts2.Items.Add(item.getid)
                        listitem.SubItems.Add(item.getcode)
                        listitem.SubItems.Add(item.getname)
                        listitem.SubItems.Add(item.getsph)
                        listitem.SubItems.Add(item.getcyl)
                        listitem.SubItems.Add(item.getprice)
                        listitem.SubItems.Add(item.getstock)
                        listitem.SubItems.Add(item.getcolor)
                        listitem.SubItems.Add(item.getdesc)
                        listitem.SubItems.Add(item.getbrand)
                        listitem.SubItems.Add(item.getmodel)
                    End If
                Next
                lblitem3.Text = intcount
                If intcount = 0 Then
                    MsgBox("No lens product in the system", MsgBoxStyle.Exclamation)
                End If
            Else
                MessageBox.Show("No products in the system, add product by clicking the +add product button")
                    lvproducts2.Enabled = False
                    btnstocks.Enabled = False
                    tabproducts.SelectedIndex = 2
                End If

            Catch ex As Exception
                MessageBox.Show("Load frames:" & ex.Message)
            End Try

    End Sub

    Private Sub load_contacts()
        Try

            If product_list IsNot Nothing Then
                Dim intcount As Integer = 0
                lvproducts3.Items.Clear()
                For Each item In product_list
                    If item.get_type = "Contact Lens" Then
                        intcount += 1
                        Dim listitem As New ListViewItem
                        listitem = lvproducts3.Items.Add(item.getid)
                        listitem.SubItems.Add(item.getcode)
                        listitem.SubItems.Add(item.getname)
                        listitem.SubItems.Add(item.getsph)
                        listitem.SubItems.Add(item.getcyl)
                        listitem.SubItems.Add(item.getprice)
                        listitem.SubItems.Add(item.getstock)
                        listitem.SubItems.Add(item.getcolor)
                        listitem.SubItems.Add(item.getdesc)
                        listitem.SubItems.Add(item.getbrand)
                        listitem.SubItems.Add(item.getmodel)
                    End If
                Next
                lblitem4.Text = intcount
                If intcount = 0 Then
                    MsgBox("No lens product in the system", MsgBoxStyle.Exclamation)
                End If
            Else

                MessageBox.Show("No products in the system, add product by clicking the +add product button")
                lvproducts3.Enabled = False
                btnstocks.Enabled = False
                tabproducts.SelectedIndex = 0
            End If

        Catch ex As Exception
            MessageBox.Show("Load all products:" & ex.Message)
        End Try
    End Sub

    Private Sub load_solutions()
        Try
            If product_list IsNot Nothing Then
                Dim intcount As Integer = 0
                lvproducts4.Items.Clear()
                For Each item In product_list
                    If item.get_type = "Solutions" Then
                        intcount += 1
                        Dim listitem As New ListViewItem
                        listitem = lvproducts4.Items.Add(item.getid)
                        listitem.SubItems.Add(item.getcode)

                        listitem.SubItems.Add(item.getname)
                        listitem.SubItems.Add(item.getbrand)
                        listitem.SubItems.Add(item.getmodel)
                        listitem.SubItems.Add(item.getprice)
                        listitem.SubItems.Add(item.getstock)
                        listitem.SubItems.Add(item.getcolor)
                        listitem.SubItems.Add(item.getdesc)
                    End If
                Next
                lblitem5.Text = intcount
                If intcount = 0 Then
                    MsgBox("No solutions product in the system", MsgBoxStyle.Exclamation)
                End If
            Else


                btnstocks.Enabled = False
                MessageBox.Show("No products in the system, add product by clicking the +add product button")
                lvproducts4.Enabled = False
                tabproducts.SelectedIndex = 0
            End If

        Catch ex As Exception
            MessageBox.Show("Load all products:" & ex.Message)
        End Try
    End Sub
    Private Sub load_special()
        Try
            open_connection()
            Dim sql As String
            sql = "SELECT * FROM tblspecialorder WHERE productstatus <> 'deleted' or productstatus is null ORDER BY productid DESC"
            cmd = New SqlCommand(sql, conn)
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                Dim intcount As Integer = 0
                lvproducts5.Enabled = True
                lvproducts5.Items.Clear()
                While rs.Read
                    Dim productlist As ListViewItem
                    productlist = lvproducts5.Items.Add(rs(0))
                    productlist.SubItems.Add(rs(2))

                    productlist.SubItems.Add(rs(3))
                    productlist.SubItems.Add(rs(4))
                    productlist.SubItems.Add(rs(5))
                    productlist.SubItems.Add(rs(8))
                    productlist.SubItems.Add(rs(9))
                    productlist.SubItems.Add(rs(6))
                    productlist.SubItems.Add(rs(7))
                    productlist.SubItems.Add(rs(10))
                    productlist.SubItems.Add(rs(11))
                    intcount += 1

                End While
                rs.Close()
                cmd.Dispose()
                conn.Close()
                lblitem6.Text = intcount
            Else
                btnstocks.Enabled = False
                MessageBox.Show("No products in the system, add product by clicking the +add product button")

            End If

        Catch ex As Exception
            MessageBox.Show("Load all products:" & ex.Message)
        End Try
    End Sub

    Private Sub load_others()
        Try
            If product_list IsNot Nothing Then
                Dim intcount As Integer = 0
                lvproducts6.Items.Clear()
                For Each item In product_list
                    If item.get_type = "Frames" Then
                    ElseIf item.get_type = "Lens" Then
                    ElseIf item.get_type = "Contact Lens" Then
                    ElseIf item.get_type = "Solutions" Then
                    Else

                        intcount += 1
                        Dim listitem As New ListViewItem
                        listitem = lvproducts6.Items.Add(item.getid)
                        listitem.SubItems.Add(item.getcode)
                        listitem.SubItems.Add(item.get_type)
                        listitem.SubItems.Add(item.getname)
                        listitem.SubItems.Add(item.getbrand)
                        listitem.SubItems.Add(item.getmodel)
                        listitem.SubItems.Add(item.getprice)
                        listitem.SubItems.Add(item.getstock)
                        listitem.SubItems.Add(item.getcolor)
                        listitem.SubItems.Add(item.getdesc)
                    End If
                Next
                lblitem7.Text = intcount
                If intcount = 0 Then
                    MsgBox("No product in the system", MsgBoxStyle.Exclamation)
                End If
            Else


                btnstocks.Enabled = False
                MessageBox.Show("No products in the system, add product by clicking the +add product button")
                lvproducts6.Enabled = False
                tabproducts.SelectedIndex = 6
            End If

        Catch ex As Exception
            MessageBox.Show("Load all products:" & ex.Message)
        End Try
    End Sub
    Private Sub lvproducts4_Click(sender As Object, e As EventArgs) Handles lvproducts4.Click
        If lvproducts4.Items.Count > 0 Then
            productid = lvproducts4.SelectedItems(0).Text
            productname = lvproducts4.SelectedItems(0).SubItems(3).Text
            load_image()
            btnstocks.Enabled = True
        End If
    End Sub

    Private Sub lvproducts4_DoubleClick(sender As Object, e As EventArgs) Handles lvproducts4.DoubleClick
        If lvproducts4.Items.Count > 0 Then

            productid = lvproducts4.SelectedItems(0).Text
            Dim editproduct As frmeditproduct
            editproduct = New frmeditproduct(productid)
            editproduct.ShowDialog()
            load_solutions()
        End If
    End Sub

    Private Sub lvproducts_DoubleClick(sender As Object, e As EventArgs) Handles lvproducts.DoubleClick
        If lvproducts.Items.Count > 0 Then

            productid = lvproducts.SelectedItems(0).Text

            Dim editproduct As frmeditproduct
            editproduct = New frmeditproduct(productid)
            editproduct.ShowDialog()

        End If
    End Sub

    Private Sub lvproducts1_DoubleClick(sender As Object, e As EventArgs) Handles lvproducts1.DoubleClick
        If lvproducts1.Items.Count > 0 Then

            productid = lvproducts1.SelectedItems(0).Text
            Dim editproduct As frmeditproduct
            editproduct = New frmeditproduct(productid)
            editproduct.ShowDialog()
            load_frames()
        End If
    End Sub

    Private Sub lvproducts2_DoubleClick(sender As Object, e As EventArgs)
        If lvproducts2.Items.Count > 0 Then

            productid = lvproducts2.SelectedItems(0).Text
            Dim editproduct As frmeditproduct
            editproduct = New frmeditproduct(productid)
            editproduct.ShowDialog()
            load_lens()
        End If
    End Sub

    Private Sub lvproducts3_DoubleClick(sender As Object, e As EventArgs) Handles lvproducts3.DoubleClick
        If lvproducts3.Items.Count > 0 Then

            productid = lvproducts3.SelectedItems(0).Text
            Dim editproduct As frmeditproduct
            editproduct = New frmeditproduct(productid)
            editproduct.ShowDialog()
            load_contacts()

        End If
    End Sub

    Private Sub lvproducts_Click(sender As Object, e As EventArgs) Handles lvproducts.Click
        If lvproducts.Items.Count > 0 Then
            productid = lvproducts.SelectedItems(0).Text
            productname = lvproducts.SelectedItems(0).SubItems(3).Text
            load_image()

            btnstocks.Enabled = True
        End If
    End Sub

    Private Sub lvproducts1_MouseClick(sender As Object, e As MouseEventArgs) Handles lvproducts1.MouseClick
        If lvproducts1.Items.Count > 0 Then
            productid = lvproducts1.SelectedItems(0).Text
            btnstocks.Enabled = True
        End If
    End Sub



    Private Sub lvproducts2_Click(sender As Object, e As EventArgs)
        If lvproducts2.Items.Count > 0 Then
            productid = lvproducts2.SelectedItems(0).Text
            productname = lvproducts2.SelectedItems(0).SubItems(3).Text
            load_image()
            btnstocks.Enabled = True
        End If
    End Sub

    Private Sub lvproducts3_Click(sender As Object, e As EventArgs) Handles lvproducts3.Click
        If lvproducts3.Items.Count > 0 Then
            productid = lvproducts3.SelectedItems(0).Text
            productname = lvproducts3.SelectedItems(0).SubItems(3).Text
            load_image()
            btnstocks.Enabled = True
        End If
    End Sub

    Private Sub tabproducts_Click(sender As Object, e As EventArgs) Handles tabproducts.Click

    End Sub

    Private Sub btnstocks_Click(sender As Object, e As EventArgs) Handles btnstocks.Click
        If productid = "" Then
            MessageBox.Show("Select any product from the list to update", "Products", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim updatestock As New frmstocklog(productid)
            updatestock.ShowDialog()
            tabproducts.SelectedIndex = 0
            load_all_products()

        End If
    End Sub

    Private Sub btnrefreshprescription_Click(sender As Object, e As EventArgs) Handles btnrefreshprescription.Click
        load_all_products()
        tabproducts.SelectedIndex = 0
        txtsearch.Clear()
        txtsearch.Focus()
    End Sub

    Private Sub btnapply_Click(sender As Object, e As EventArgs) Handles btnapply.Click
        If txtsearch.Text.Length = 0 Then
            MessageBox.Show("Enter the keyword to search")
            txtsearch.Focus()
        Else
            search_product()
        End If
    End Sub

    Private Sub search_product()
        Try
            open_connection()
            Dim sql As String
            sql = "SELECT * FROM tblproducts WHERE productname LIKE @name AND "
            sql += "(productstatus <> 'deleted' or productstatus is null)"
            sql += "ORDER BY productid DESC"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@name", "%" + txtsearch.Text + "%")
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                lvproducts.Enabled = True
                lvproducts.Items.Clear()
                While rs.Read
                    Dim productlist As ListViewItem
                    productlist = lvproducts.Items.Add(rs(0))
                    productlist.SubItems.Add(rs(2))
                    productlist.SubItems.Add(rs(1))
                    productlist.SubItems.Add(rs(3))
                    productlist.SubItems.Add(rs(4))
                    productlist.SubItems.Add(rs(5))
                    productlist.SubItems.Add(rs(8))
                    productlist.SubItems.Add(rs(9))
                    productlist.SubItems.Add(rs(6))
                    productlist.SubItems.Add(rs(7))


                End While
                rs.Close()
                cmd.Dispose()
                conn.Close()
                txtsearch.Clear()

            Else
                MessageBox.Show("No products found")
                lvproducts.Enabled = False
                btnstocks.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Search:" & ex.Message)
        End Try
    End Sub

    Private Sub lvproducts5_DoubleClick(sender As Object, e As EventArgs) Handles lvproducts5.DoubleClick

        Dim specialobj As New frmaddspecialorder(lvproducts5.SelectedItems(0).Text)
        specialobj.ShowDialog()
        load_special()


    End Sub
    Private Sub delete_product(ByVal id As String)
        Try
            open_connection()
            Dim sql As String = "UPDATE tblspecialorder SET productstatus='deleted' WHERE productid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", id)
            If (cmd.ExecuteNonQuery) Then
                MessageBox.Show("Product Deleted!", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmd.Dispose()
                conn.Close()
                load_special()
            End If
        Catch ex As Exception
            MessageBox.Show("Delete Product" + ex.Message)
        End Try

    End Sub
    Private Sub load_image()
        Try

            open_connection()
            Dim sql As String = "SELECT imageurl FROm tblproducts WHERE productid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", productid)
            rs = cmd.ExecuteReader
            While rs.Read
                productimage.Enabled = True
                If rs(0) Is Nothing Or IsDBNull(rs(0)) Then

                    productimage.Image = Image.FromFile(path + "default.png")
                Else
                    productimage.Image = Image.FromFile(rs(0).ToString)
                End If
            End While
            rs.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Image:" + ex.Message)
        End Try
    End Sub
    Private Sub save_image()
        Try
            open_connection()
            Dim sql As String = "UPDATE tblproducts SET imageurl=@url WHERE productid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@url", path + productid + "_" + productname + ".png")
            cmd.Parameters.AddWithValue("@id", productid)
            If cmd.ExecuteNonQuery() Then
                MessageBox.Show("Image updated", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information)
                productimage.Image.Save(path + productid + "_" + productname + ".png")
            End If
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Save image:" + ex.Message)
        End Try
    End Sub

    Private Sub lvproducts1_Click(sender As Object, e As EventArgs) Handles lvproducts1.Click
        productname = lvproducts1.SelectedItems(0).SubItems(3).Text
        load_image()
    End Sub

    Private Sub lvproducts5_Click(sender As Object, e As EventArgs) Handles lvproducts5.Click
        productimage.Enabled = False
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtsearch.Text.Length = 0 Then
                MessageBox.Show("Enter the keyword to search")
                txtsearch.Focus()
            Else
                search_product()
            End If
        End If
    End Sub

    Private Sub cbxpname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxpname.SelectedIndexChanged
        If (cbxpname.Items.Count > 0) Then
            Dim obj1 As New ProductFrame
            Dim list1 As New List(Of ProductFrame)

            list1 = obj1.search_product_name(cbxpname.Text)

            If list1 IsNot Nothing Then
                Dim intcount As Integer = 0
                lvproducts.Items.Clear()
                For Each item In list1

                    intcount += 1
                        Dim listitem As New ListViewItem
                        listitem = lvproducts.Items.Add(item.getid)
                        listitem.SubItems.Add(item.getcode)
                        listitem.SubItems.Add(item.get_type)
                        listitem.SubItems.Add(item.getname)
                        listitem.SubItems.Add(item.getbrand)
                        listitem.SubItems.Add(item.getmodel)
                        listitem.SubItems.Add(item.getprice)
                        listitem.SubItems.Add(item.getstock)
                        listitem.SubItems.Add(item.getcolor)
                        listitem.SubItems.Add(item.getdesc)

                Next
                lblitem1.Text = intcount
            End If


            load_product_model()
        End If


    End Sub

    Private Sub cbxpmodel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxpmodel.SelectedIndexChanged
        If (cbxpmodel.Items.Count > 0) Then
            If product_list IsNot Nothing Then
                Dim intcount As Integer = 0
                lvproducts.Items.Clear()
                For Each item In product_list
                    If item.getname = cbxpname.SelectedItem And item.getmodel = cbxpmodel.SelectedItem Then
                        intcount += 1
                        Dim listitem As New ListViewItem
                        listitem = lvproducts.Items.Add(item.getid)
                        listitem.SubItems.Add(item.getcode)
                        listitem.SubItems.Add(item.get_type)
                        listitem.SubItems.Add(item.getname)
                        listitem.SubItems.Add(item.getbrand)
                        listitem.SubItems.Add(item.getmodel)
                        listitem.SubItems.Add(item.getprice)
                        listitem.SubItems.Add(item.getstock)
                        listitem.SubItems.Add(item.getcolor)
                        listitem.SubItems.Add(item.getdesc)
                    End If
                Next
                MsgBox(intcount)
                lblitem1.Text = intcount
            End If
        End If

    End Sub

    Private Sub btnreset1_Click(sender As Object, e As EventArgs) Handles btnreset1.Click
        load_all_products()
        lblitem1.Text = 0
    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Try
            If txtsph.Text.Length = 0 Or txtcyl.Text.Length = 0 Then
                MsgBox("Enter SPH and CYL to search", MsgBoxStyle.Exclamation)
            Else
                Dim obj1 As New ProductFrame
                Dim lenslist As New List(Of ProductFrame)
                lenslist = obj1.search_lens(txtsph.Text, txtcyl.Text)
                Dim intcount As Integer = 0
                If lenslist IsNot Nothing Then

                    lvproducts2.Items.Clear()
                    For Each item In lenslist
                        If item.get_type = "Lens" Then
                            intcount += 1
                            Dim listitem As New ListViewItem
                            listitem = lvproducts2.Items.Add(item.getid)
                            listitem.SubItems.Add(item.getcode)
                            listitem.SubItems.Add(item.getname)
                            listitem.SubItems.Add(item.getsph)
                            listitem.SubItems.Add(item.getcyl)
                            listitem.SubItems.Add(item.getprice)
                            listitem.SubItems.Add(item.getstock)
                            listitem.SubItems.Add(item.getcolor)
                            listitem.SubItems.Add(item.getdesc)
                            listitem.SubItems.Add(item.getbrand)
                            listitem.SubItems.Add(item.getmodel)
                        End If

                    Next
                    lblitem3.Text = intcount
                Else
                    MsgBox("No results")
                End If
                If intcount = 0 Then
                    MsgBox("No results", MsgBoxStyle.Exclamation)
                End If
            End If
        Catch ex As Exception
            MsgBox("Search:" + ex.Message)
        End Try

    End Sub

    Private Sub lvproducts2_Click_1(sender As Object, e As EventArgs) Handles lvproducts2.Click
        If lvproducts2.Items.Count > 0 Then
            productid = lvproducts2.SelectedItems(0).Text
            btnstocks.Enabled = True
        End If
    End Sub

    Private Sub lvproducts2_DoubleClick_1(sender As Object, e As EventArgs) Handles lvproducts2.DoubleClick
        If lvproducts2.Items.Count > 0 Then

            productid = lvproducts2.SelectedItems(0).Text
            Dim editproduct As frmeditproduct
            editproduct = New frmeditproduct(productid)
            editproduct.ShowDialog()
            load_lens()
        End If
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        load_lens()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim specialobj As New frmaddspecialorder("NEW")
        specialobj.ShowDialog()
        load_special()
    End Sub

    Private Sub btnsearch2_Click(sender As Object, e As EventArgs) Handles btnsearch2.Click
        Try
            If txtsph2.Text.Length = 0 Or txtcyl2.Text.Length = 0 Then
                MsgBox("Enter SPH and CYL to search", MsgBoxStyle.Exclamation)
            Else
                Dim obj1 As New ProductFrame
                Dim lenslist As New List(Of ProductFrame)
                lenslist = obj1.search_lens(txtsph2.Text, txtcyl2.Text)
                Dim intcount As Integer = 0
                If lenslist IsNot Nothing Then

                    lvproducts3.Items.Clear()
                    For Each item In lenslist
                        If item.get_type = "Contact Lens" Then
                            intcount += 1
                            Dim listitem As New ListViewItem
                            listitem = lvproducts3.Items.Add(item.getid)
                            listitem.SubItems.Add(item.getcode)
                            listitem.SubItems.Add(item.getname)
                            listitem.SubItems.Add(item.getsph)
                            listitem.SubItems.Add(item.getcyl)
                            listitem.SubItems.Add(item.getprice)
                            listitem.SubItems.Add(item.getstock)
                            listitem.SubItems.Add(item.getcolor)
                            listitem.SubItems.Add(item.getdesc)
                            listitem.SubItems.Add(item.getbrand)
                            listitem.SubItems.Add(item.getmodel)
                        End If

                    Next
                    lblitem4.Text = intcount
                Else
                    MsgBox("No results")
                End If
                If intcount = 0 Then
                    MsgBox("No results", MsgBoxStyle.Exclamation)
                End If
            End If
        Catch ex As Exception
            MsgBox("Search:" + ex.Message)
        End Try

    End Sub

    Private Sub btnreset2_Click(sender As Object, e As EventArgs) Handles btnreset2.Click
        load_contacts()
    End Sub

    Private Sub lvproducts6_DoubleClick(sender As Object, e As EventArgs) Handles lvproducts6.DoubleClick
        If lvproducts6.Items.Count > 0 Then

            productid = lvproducts6.SelectedItems(0).Text
            Dim editproduct As frmeditproduct
            editproduct = New frmeditproduct(productid)
            editproduct.ShowDialog()
            load_others()
        End If
    End Sub

    Private Sub productimage_DoubleClick(sender As Object, e As EventArgs) Handles productimage.DoubleClick
        Try
            OpenImage.FilterIndex = -1
            OpenImage.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
            If (OpenImage.ShowDialog() = DialogResult.OK) Then
                Dim filename As String = OpenImage.FileName
                If filename.Length = 0 Then
                    MessageBox.Show("No image selected")
                Else
                    productimage.Image.Dispose()
                    productimage.Image = Nothing

                    productimage.Image = Image.FromFile(filename)

                    save_image()


                End If
            Else
                MessageBox.Show("No image selected")
            End If


        Catch ex As Exception
            MessageBox.Show("Image:" + ex.Message)
        End Try
    End Sub


End Class