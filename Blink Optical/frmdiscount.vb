Public Class frmdiscount
    Dim amount As Decimal
    Public newamount As Decimal = 0.0
    Public discount As Decimal = 0.0

    Public Sub New(ByVal _amount As Decimal)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        amount = _amount
    End Sub
    Private Sub frmdiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblamount.Text = amount.ToString("N2")
        cbxtype.SelectedIndex = 0
        txtvalue.Focus()

    End Sub
    Private Sub calculate_discount()
        Try
            discount = txtvalue.Text
            If cbxtype.SelectedIndex = 0 Then
                If discount < 0 Or discount >= 100 Then
                    MsgBox("Discount cannot be less than 0 or greater than 100", MsgBoxStyle.Exclamation)
                    txtvalue.Focus()
                Else
                    discount = amount * (discount / 100)
                    newamount = amount - discount
                End If

            Else
                If discount > amount Or discount < 0 Then
                    MsgBox("Discount cannot be less than 0 or greater than the amount", MsgBoxStyle.Exclamation)
                    txtvalue.Focus()
                Else
                    newamount = amount - discount
                End If

            End If

            lbltotal.Text = newamount.ToString("N2")
        Catch ex As Exception
            MsgBox("Discount:" + ex.Message)
            txtvalue.Text = "0.0"
            txtvalue.Focus()
        End Try
    End Sub
    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        calculate_discount()
    End Sub

    Private Sub cbxtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxtype.SelectedIndexChanged
        If cbxtype.SelectedIndex = 0 Then
            lblpercent.Visible = True
            calculate_discount()
        Else
            lblpercent.Visible = False
            calculate_discount()
        End If
    End Sub

    Private Sub txtvalue_Leave(sender As Object, e As EventArgs) Handles txtvalue.Leave
        Try
            Dim dis As Decimal
            dis = txtvalue.Text
            txtvalue.Text = dis.ToString("N2")
            calculate_discount()
        Catch ex As Exception
            MsgBox(ex.Message)
            txtvalue.Text = "0"
        End Try

    End Sub

    Private Sub txtvalue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvalue.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso 'restricts anything but number keys
    e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then 'allows use of backspace
            e.Handled = True
        End If

    End Sub
End Class