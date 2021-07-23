Imports System.Data.SqlClient

Public Class frmaddproducts
    'connection
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Private Sub frmaddproducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_types()
        cbxproducttype.SelectedIndex = 0
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
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()

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
    Private Function check_errors() As Integer
        Dim interror As Integer = 0
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
        End If

        If cbxproducttype.SelectedItem = "Lens" Or cbxproducttype.SelectedItem = "Contact Lens" Then
            If txtsph_l.Text.Length = 0 Or txtsph_r.Text.Length = 0 Then
                MessageBox.Show("Please SPH values", "Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
                interror += 1
            ElseIf txtcyl_l.Text.Length = 0 Or txtcyl_r.Text.Length = 0 Then
                MessageBox.Show("Please CYL values", "Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
                interror += 1
            End If
        End If

        Return interror
    End Function
    Private Sub save_product()
        Try
            open_connection()
            Dim sql As String
            sql = "INSERT INTO tblproducts(producttype,productcode,productname,productbrand,productmodel,productcolor,productdescription,productprice,productstock,sph_r,cyl_r,sph_l,cyl_l) "
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
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Save Product:" & ex.Message)
        End Try
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
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If check_errors() = 0 Then
            save_product()
        End If
    End Sub

    Private Sub cbxproducttype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxproducttype.SelectedIndexChanged
        If cbxproducttype.SelectedItem = "Lens" Or cbxproducttype.SelectedItem = "Contact Lens" Then
            gblens.Enabled = True
        Else
            gblens.Enabled = False
        End If
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

    Private Sub txtprice_TextChanged(sender As Object, e As EventArgs) Handles txtprice.TextChanged

    End Sub

    Private Sub txtprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso 'restricts anything but number keys
    e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then 'allows use of backspace
            e.Handled = True
        End If

    End Sub

End Class