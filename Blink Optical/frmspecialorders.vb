Imports System.Data.SqlClient
Public Class frmspecialorders
    'connection
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Public idselected As Integer
    Public productname As String
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If check_errors() = 0 Then
            save_product()
        End If
    End Sub

    Private Sub cbxproducttype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxproducttype.SelectedIndexChanged
        If cbxproducttype.SelectedIndex = 1 Or cbxproducttype.SelectedIndex = 2 Then
            gblens.Enabled = True
        Else
            gblens.Enabled = False
        End If
    End Sub
    Private Sub clear_inputs()
        cbxproducttype.SelectedIndex = 0
        txtcode.Clear()
        txtbrand.Clear()
        txtmodel.Clear()
        txtname.Clear()
        txtcolor.Clear()
        txtdescription.Clear()
        txtprice.Text = "0.0"
        cbxproducttype.Focus()
        txtcyl_r.Text = "0.0"
        txtcyl_l.Text = "0.0"
        txtsph_r.Text = "0.0"
        txtsph_l.Text = "0.0"
    End Sub
    Private Sub save_product()
        Try
            open_connection()
            Dim sql As String
            sql = "INSERT INTO tblspecialorder(producttype,productcode,productname,productbrand,productmodel,productcolor,productdescription,productprice,productstock,sph_r,cyl_r,sph_l,cyl_l) "
            sql += "VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10,@v11,@v12,@v13)"
            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@v1", cbxproducttype.SelectedItem)
            cmd.Parameters.AddWithValue("@v2", txtcode.Text)
            cmd.Parameters.AddWithValue("@v3", txtname.Text)
            cmd.Parameters.AddWithValue("@v4", txtbrand.Text)
            cmd.Parameters.AddWithValue("@v5", txtmodel.Text)
            cmd.Parameters.AddWithValue("@v6", txtcolor.Text)
            cmd.Parameters.AddWithValue("@v7", txtdescription.Text)
            cmd.Parameters.AddWithValue("@v8", txtprice.Text)
            cmd.Parameters.AddWithValue("@v9", "0")
            cmd.Parameters.AddWithValue("@v10", txtsph_r.Text)
            cmd.Parameters.AddWithValue("@v11", txtcyl_r.Text)
            cmd.Parameters.AddWithValue("@v12", txtsph_l.Text)
            cmd.Parameters.AddWithValue("@v13", txtcyl_l.Text)

            If (cmd.ExecuteNonQuery) Then
                Dim x As Integer = MessageBox.Show("Products Added!,Would you like to add another product?", "Products", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If x = vbYes Then
                    clear_inputs()
                Else
                    cmd.Dispose()
                    conn.Close()
                    tab1.SelectedIndex = 0
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Save Product:" & ex.Message)
        End Try
    End Sub

    Private Function check_errors() As Integer
        Dim interror As Integer = 0
        Try
            'If txtcode.Text.Length = 0 Then
            'MessageBox.Show("Please enter the product code", "Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'interror += 1
            If txtname.Text.Length = 0 Then
                MessageBox.Show("Please enter the product name", "Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
                interror += 1
                'ElseIf txtbrand.Text.Length = 0 Then
                'MessageBox.Show("Please enter the product model", "Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'interror += 1
                'ElseIf txtdescription.Text.Length = 0 Then
                'MessageBox.Show("Please enter the product description", "Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'interror += 1
            ElseIf txtprice.Text.Length = 0 Then
                MessageBox.Show("Please enter the product price", "Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
                interror += 1
            ElseIf Convert.ToDecimal(txtprice.Text) <= 0 Then
                MessageBox.Show("Please enter the product price", "Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
                interror += 1
            End If

            If cbxproducttype.SelectedIndex = 1 Or cbxproducttype.SelectedIndex = 2 Then
                If txtsph_l.Text.Length = 0 Or txtsph_r.Text.Length = 0 Then
                    MessageBox.Show("Please enter SPH values", "Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    interror += 1
                ElseIf txtcyl_l.Text.Length = 0 Or txtcyl_r.Text.Length = 0 Then
                    MessageBox.Show("Please enter CYL values", "Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    interror += 1
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            interror += 1
        End Try

        Return interror
    End Function

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

    Private Sub frmspecialorders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxproducttype.SelectedIndex = 0
        idselected = 0
        productname = ""
        load_products()
    End Sub

    Private Sub tab1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tab1.SelectedIndexChanged
        If tab1.SelectedIndex = 1 Then
            clear_inputs()
            cbxproducttype.Focus()
        ElseIf tab1.SelectedIndex = 0 Then
            load_products()
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        tab1.SelectedIndex = 0

    End Sub
    Private Sub load_products()
        Try

            open_connection()
            Dim sql As String

            sql = "SELECT * FROM tblspecialorder WHERE productstatus <> 'deleted' or productstatus is null"


            cmd = New SqlCommand(sql, conn)

            rs = cmd.ExecuteReader
            If (rs.HasRows) Then
                lvorders.Items.Clear()
                While rs.Read
                    Dim lvproducts As ListViewItem
                    lvproducts = lvorders.Items.Add(rs(0)) 'code
                    lvproducts.SubItems.Add(rs(3)) 'name
                    lvproducts.SubItems.Add(rs(8)) 'price
                    lvproducts.SubItems.Add(rs(7)) 'description

                End While


                rs.Close()
                cmd.Dispose()
                conn.Close()
            Else
                MessageBox.Show("There are no product list in the list,add a product to select in the products form")
                tab1.SelectedIndex = 1

            End If
        Catch ex As Exception
            MessageBox.Show("Load Products:" + ex.Message)
        End Try
    End Sub

    Private Sub lvorders_Click(sender As Object, e As EventArgs) Handles lvorders.Click
        idselected = lvorders.SelectedItems(0).Text
        productname = lvorders.SelectedItems(0).SubItems(1).Text
    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        Me.Close()
    End Sub

    Private Sub lvorders_DoubleClick(sender As Object, e As EventArgs) Handles lvorders.DoubleClick
        idselected = lvorders.SelectedItems(0).Text
        productname = lvorders.SelectedItems(0).SubItems(1).Text
        Me.Close()
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtsearch.Text.Length > 0 Then
                search_products()
            End If

        End If
    End Sub

    Private Sub search_products()
        Try

            open_connection()
            Dim sql As String

            sql = "SELECT * FROM tblspecialorder WHERE productname LIKE @name AND (producttype='Lens' or producttype='Contact Lens') AND (productstatus <> 'deleted' or productstatus is null)"


            cmd = New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@name", "%" + txtsearch.Text + "%")
            rs = cmd.ExecuteReader
            If (rs.HasRows) Then
                lvorders.Items.Clear()

                While rs.Read
                    Dim lvproducts As ListViewItem
                    lvproducts = lvorders.Items.Add(rs(0)) 'code
                    lvproducts.SubItems.Add(rs(3)) 'name
                    lvproducts.SubItems.Add(rs(8)) 'price
                    lvproducts.SubItems.Add(rs(7)) 'description
                    lvproducts.SubItems.Add(rs(9)) 'stock
                End While


                rs.Close()
                cmd.Dispose()
                conn.Close()
            Else
                MessageBox.Show("There are no product list in the list,add a product to select in the products form")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Load Products:" + ex.Message)
        End Try
    End Sub

    Private Sub txtprice_Leave(sender As Object, e As EventArgs) Handles txtprice.Leave
        Try

            txtprice.Text = Convert.ToDecimal(txtprice.Text)
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