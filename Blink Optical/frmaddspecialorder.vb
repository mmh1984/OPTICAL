Imports System.Data.SqlClient

Public Class frmaddspecialorder
    'connection
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Public idselected As Integer

    Dim action As String
    Public Sub New(ByVal _action As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        action = _action
    End Sub
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub frmaddspecialorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_types()
        cbxproducttype.SelectedIndex = 0
        If action.Equals("NEW") Then
            btnupdate.Enabled = False
            btndelete.Enabled = False
            btnsave.Enabled = True
        Else
            btnupdate.Enabled = True
            btndelete.Enabled = True
            btnsave.Enabled = False
            idselected = action
            product_details()
        End If
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
    Private Sub product_details()
        Try
            open_connection()
            Dim sql As String
            sql = "SELECT * FROM tblspecialorder WHERE productid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", idselected)
            rs = cmd.ExecuteReader
            While rs.Read
                cbxproducttype.Text = rs(1).ToString()
                If (cbxproducttype.Text = "Lens" Or cbxproducttype.Text = "Contact Lens") Then
                    gblens.Enabled = True
                End If
                txtcode.Text = rs(2).ToString()
                txtname.Text = rs(3).ToString()
                txtbrand.Text = rs(4).ToString()
                txtmodel.Text = rs(5).ToString()
                txtcolor.Text = rs(6).ToString()
                txtdescription.Text = rs(7).ToString()
                txtprice.Text = rs(8).ToString()
                txtsph_r.Text = rs(10).ToString()
                txtcyl_r.Text = rs(11).ToString()
                txtsph_l.Text = rs(12).ToString()
                txtcyl_l.Text = rs(13).ToString()
            End While
            rs.Close()
            cmd.Dispose()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Open Connection:" & ex.Message)
        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If check_errors() = 0 Then
            save_product()
        End If
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
                MessageBox.Show("Products Added!", "Products", MessageBoxButtons.OK, MessageBoxIcon.Question)

                cmd.Dispose()
                conn.Close()
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Save Product:" & ex.Message)
        End Try
    End Sub
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

    Private Sub cbxproducttype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxproducttype.SelectedIndexChanged
        If cbxproducttype.SelectedIndex = 1 Or cbxproducttype.SelectedIndex = 2 Then
            gblens.Enabled = True
        Else
            gblens.Enabled = False
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If check_errors() = 0 Then
            update_product()

        End If
    End Sub

    Private Sub update_product()
        Try
            open_connection()
            Dim sql As String
            sql = "UPDATE tblspecialorder SET producttype=@v1,productcode=@v2,productname=@v3,productbrand=@v4,productmodel=@v5,"
            sql += "productcolor=@v6,productdescription=@v7,productprice=@v8,  "
            sql += "sph_r=@v10,cyl_r=@v11,sph_l=@v12,cyl_l=@v13 "
            sql += " WHERE productid=@id"

            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", idselected)

            cmd.Parameters.AddWithValue("@v1", cbxproducttype.SelectedItem)
            cmd.Parameters.AddWithValue("@v2", txtcode.Text)
            cmd.Parameters.AddWithValue("@v3", txtname.Text)
            cmd.Parameters.AddWithValue("@v4", txtbrand.Text)
            cmd.Parameters.AddWithValue("@v5", txtmodel.Text)
            cmd.Parameters.AddWithValue("@v6", txtcolor.Text)
            cmd.Parameters.AddWithValue("@v7", txtdescription.Text)
            cmd.Parameters.AddWithValue("@v8", txtprice.Text)
            'cmd.Parameters.AddWithValue("@v9", "0")
            cmd.Parameters.AddWithValue("@v10", txtsph_r.Text)
            cmd.Parameters.AddWithValue("@v11", txtcyl_r.Text)
            cmd.Parameters.AddWithValue("@v12", txtsph_l.Text)
            cmd.Parameters.AddWithValue("@v13", txtcyl_l.Text)

            If (cmd.ExecuteNonQuery) Then
                MessageBox.Show("Product Updated!", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmd.Dispose()
                conn.Close()


                Me.Close()

            End If
        Catch ex As Exception
            MessageBox.Show("Update Product:" & ex.Message)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            Dim x As Integer
            x = MessageBox.Show("Deleting this product will also delete the work order/receipt linked to it", "Optical Shop POS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If x = vbYes Then
                Dim confirm As frmconfirmation
                confirm = New frmconfirmation()

                Dim a As Integer = confirm.ShowDialog

                If (confirm.status = 1) Then
                    delete_product()
                Else
                    MessageBox.Show("Incorrect Credentials", "Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Delete Prescription:" + ex.Message)
        End Try
    End Sub

    Private Sub delete_product()
        Try
            open_connection()
            Dim sql As String = "UPDATE tblspecialorder SET productstatus='deleted' WHERE productid=@id"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", idselected)
            If (cmd.ExecuteNonQuery) Then
                MessageBox.Show("Product Deleted!", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmd.Dispose()
                conn.Close()
                Me.Close()

            End If
        Catch ex As Exception
            MessageBox.Show("Delete Product" + ex.Message)
        End Try

    End Sub
End Class