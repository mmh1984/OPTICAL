Imports System.Data.SqlClient
Public Class frmstocklog
    'connection
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim rs As SqlDataReader
    Dim userinfo As List(Of String)
    Dim pid As String
    Public Sub New(ByVal _pid As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pid = _pid
    End Sub
    Private Sub frmstocklog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Product ID: " + pid
        txtdate.CustomFormat = "dd-MM-yyyy"
        userinfo = frmdashboard.userinfo
    End Sub

    Private Sub txtqty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqty.KeyDown

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtqty.Text.Length <> 0 Then
            update_stock()
            product_log()

        Else
            MessageBox.Show("Please enter the arrival date and quantity")
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
    Private Sub update_stock()
        Try
            open_connection()
            Dim sql As String
            sql = "UPDATE tblproducts SET productstock=productstock + @value"
            sql += " WHERE productid=@id"

            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", pid)
            cmd.Parameters.AddWithValue("@value", txtqty.Text)

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
    Private Sub product_log()
        Try
            Dim productlog As New ProductLog
            productlog.setdate(txtdate.Value)
            productlog.setpid(pid)
            productlog.setlogname("stock update")
            productlog.setqty(txtqty.Text)
            productlog.setlogby(userinfo(0))
            productlog.setremarks(txtremarks.Text)
            productlog.save_log()
        Catch ex As Exception
            MessageBox.Show("Product Log" + ex.Message)
        End Try
    End Sub

    Private Sub txtqty_Leave(sender As Object, e As EventArgs) Handles txtqty.Leave
        Try
            Dim qty As Integer
            qty = Convert.ToInt32(txtqty.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            txtqty.Text = 0
            txtqty.Focus()
        End Try
    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso 'restricts anything but number keys
e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "-" Then 'allows use of backspace
            e.Handled = True
        End If
    End Sub
End Class