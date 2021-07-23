Public Class frmupdatepayment
    Dim list1 As New List(Of String)
    Public status As Boolean
    Public Sub New(ByVal _id As List(Of String))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        list1 = _id
    End Sub
    Private Sub frmupdatepayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblreceipt.Text = list1(0)
        txtamount.Text = list1(1)
        txtdeposit.Text = list1(2)
        txtbalance.Text = list1(3)
        txtpaymentamount.Enabled = True

    End Sub



    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        status = False
        Me.Close()
    End Sub

    Private Sub btnproceed_Click(sender As Object, e As EventArgs) Handles btnproceed.Click
        Dim amount As Decimal
        Dim balance As Decimal
        amount = Convert.ToDecimal(txtpaymentamount.Text)
        balance = list1(3)
        If amount > balance Then
            MsgBox("Payment exceeded the outstanding balance", MsgBoxStyle.Exclamation)
            txtpaymentamount.Focus()
        ElseIf amount < balance Then
            MsgBox("Payment is less the outstanding balance", MsgBoxStyle.Exclamation)
            txtpaymentamount.Focus()
        ElseIf amount = balance Then
            Dim obj1 As New Transaction
            If (obj1.update_payment(balance, list1(0))) Then
                status = True
                MsgBox("Payment Updated", MsgBoxStyle.Information)
                Me.Close()
            End If

        End If
    End Sub

    Private Sub txtpaymentamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpaymentamount.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso 'restricts anything but number keys
   e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then 'allows use of backspace
            e.Handled = True
        End If
    End Sub
End Class