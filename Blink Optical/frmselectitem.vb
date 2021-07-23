Imports System.Data.SqlClient
Public Class frmselectitem

    Dim productype As String
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Dim productlist As New List(Of ProductFrame)
    Public idselected As Integer
    Public Sub New(ByVal _productype As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        productype = _productype
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

            open_connection()
            Dim sql As String
            If productype = "Frames" Then
                sql = "SELECT * FROM tblproducts WHERE producttype=@type AND (productstatus <> 'deleted' or productstatus is null)"
            Else
                sql = "SELECT * FROM tblproducts WHERE (producttype='Lens' or producttype='Contact Lens') AND (productstatus <> 'deleted' or productstatus is null)"
            End If

            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@type", productype)
            rs = cmd.ExecuteReader
            If (rs.HasRows) Then
                lvorders.Items.Clear()
                While rs.Read


                    Dim obj1 As New ProductFrame
                    obj1.setid(rs(0))
                    obj1.setname(rs(3))
                    obj1.setmodel(rs(5))
                    obj1.setprice(rs(8))
                    obj1.setdesc(rs(7))
                    obj1.setstock(rs(9))
                    obj1.setcolor(rs(6))
                    obj1.setsph(rs(10))
                    obj1.setcyl(rs(11))
                    productlist.Add(obj1)
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

    Private Sub frmselectitem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idselected = 0
        load_products()
        load_product_model()
        If (productype = "Frames") Then
            gbxlens.Enabled = False
        Else
            gbxlens.Enabled = True
        End If
    End Sub
    Private Sub load_product_model()
        Try
            Dim obj1 As New ProductFrame
            Dim list1 As New List(Of String)
            list1 = obj1.get_model2(productype)
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
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click


        Me.Close()

    End Sub

    Private Sub lvorders_Click(sender As Object, e As EventArgs) Handles lvorders.Click
        idselected = lvorders.SelectedItems(0).Text
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
            If productype = "Frames" Then
                sql = "SELECT * FROM tblproducts WHERE producttype=@type AND productname LIKE @name AND (productstatus <> 'deleted' or productstatus is null)"
            Else
                sql = "SELECT * FROM tblproducts WHERE productname LIKE @name AND (producttype='Lens' or producttype='Contact Lens') AND (productstatus <> 'deleted' or productstatus is null)"
            End If

            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@type", productype)
            cmd.Parameters.AddWithValue("@name", "%" + txtsearch.Text + "%")
            rs = cmd.ExecuteReader
            If (rs.HasRows) Then
                lvorders.Items.Clear()

                While rs.Read
                    Dim lvproducts As ListViewItem
                    lvproducts = lvorders.Items.Add(rs(0)) 'code
                    lvproducts.SubItems.Add(rs(3) & " " & rs(5)) 'name
                    lvproducts.SubItems.Add(rs(8)) 'price
                    lvproducts.SubItems.Add(rs(7)) 'description
                    lvproducts.SubItems.Add(rs(9)) 'stock

                    lvproducts.SubItems.Add(rs(6)) 'color
                    lvproducts.SubItems.Add("(" & rs(10) & ")" & "(" & rs(11) & ")") 'SPH CYL
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

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        load_products()
        txtsearch.Clear()

    End Sub

    Private Sub lvorders_DoubleClick(sender As Object, e As EventArgs) Handles lvorders.DoubleClick
        idselected = lvorders.SelectedItems(0).Text
        Me.Close()

    End Sub

    Private Sub cbxpmodel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxpmodel.SelectedIndexChanged
        If (cbxpmodel.Items.Count > 0) Then
            If productlist IsNot Nothing Then
                Dim intcount As Integer = 0
                lvorders.Items.Clear()
                For Each item In productlist
                    If item.getname = cbxpmodel.SelectedItem Then
                        intcount += 1
                        Dim plist As ListViewItem
                        plist = lvorders.Items.Add(item.getid)

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
                    lvorders.Items.Clear()
                    For Each item In lenslist

                        intcount += 1
                        Dim plist As ListViewItem
                        plist = lvorders.Items.Add(item.getid)

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
End Class