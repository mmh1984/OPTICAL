Public Class frmusers
    Dim userselected As String
    Dim translist As New List(Of Transaction)
    Dim loglist As New List(Of Userlog)
    Dim totaltransaction, monthlytransaction As Integer

    Private Sub frmusers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_all_users()
        btnprintcustomers.Enabled = False

        btnresetpassword.Enabled = False
        btndelete.Enabled = False


    End Sub
    Public Sub load_all_users()
        Try
            Dim userlist As New List(Of Users)
            Dim userobj As New Users
            userlist = userobj.load_users
            If userlist IsNot Nothing Then
                Dim x As Integer
                lvusers.Items.Clear()
                lvlogs.Items.Clear()
                lvtransactionlist.Items.Clear()
                update_stats()
                totaltransaction = 0
                monthlytransaction = 0
                Dim useritems As ListViewItem
                For x = 0 To userlist.Count - 1

                    useritems = lvusers.Items.Add(userlist(x).getid)

                    useritems.SubItems.Add(userlist(x).getfullname)
                    useritems.SubItems.Add(userlist(x).getlevel)
                    useritems.SubItems.Add(userlist(x).getusername)

                Next
            Else
                MsgBox("No users")
            End If
        Catch ex As Exception
            MsgBox("Load all users:" + ex.Message)
        End Try
    End Sub

    Private Sub lvusers_Click(sender As Object, e As EventArgs) Handles lvusers.Click
        If lvusers.Items.Count > 0 Then
            userselected = lvusers.SelectedItems(0).Text
            load_transaction()
            load_logs()
            btndelete.Enabled = True
            btnresetpassword.Enabled = True
        End If
    End Sub
    Private Sub load_logs()
        Try
            bw_log.RunWorkerAsync()

        Catch ex As Exception
            MsgBox("Logs:" + ex.Message)
        End Try
    End Sub

    Private Sub load_transaction()
        Try
            Dim transactionobj As New Transaction
            translist = transactionobj.search_transaction_issued(userselected)
            'totalitems = 0
            'totalprice = 0
            'lbltotalprice.Text = "0"
            lbltotaltransaction.Text = "0"
            lblmonthly.Text = "0"
            Dim transitems As ListViewItem
            If translist IsNot Nothing Then
                btnprintcustomers.Enabled = True
                lvtransactionlist.Items.Clear()
                lvtransactionlist.Enabled = True
                Dim x As Integer
                'totalamount = 0
                totaltransaction = 0
                monthlytransaction = 0
                'cashpayment = 0
                'cardpayment = 0
                For x = 0 To translist.Count - 1
                    totaltransaction += 1
                    'totalamount += translist(x).getpayable
                    If (Month(translist(x).gettransdate) = Month(Today)) Then
                        monthlytransaction += 1
                    End If
                    transitems = lvtransactionlist.Items.Add(translist(x).gettransdate)
                    transitems.SubItems.Add(translist(x).getid)
                    transitems.SubItems.Add(translist(x).getissued)
                    transitems.SubItems.Add(translist(x).getpayable)
                    transitems.SubItems.Add(translist(x).getdeposit)
                    transitems.SubItems.Add(translist(x).getbalance)
                    transitems.SubItems.Add(translist(x).getmethod)
                    transitems.SubItems.Add(translist(x).getbank)
                    transitems.SubItems.Add(translist(x).getpos)
                    If translist(x).getmethod.ToString.Contains("CASH") Then
                        'cashpayment += 1
                    Else
                        'cardpayment += 1
                    End If
                Next

            Else
                'totalamount = 0
                'totaltransaction = 0
                'cashpayment = 0
                'cardpayment = 0
                MsgBox("No transaction found")
                lvtransactionlist.Enabled = False
                lvtransactionlist.Items.Clear()
                totaltransaction = 0
                monthlytransaction = 0
            End If
            update_stats()
        Catch ex As Exception
            MsgBox("Load transaction:" + ex.Message)
        End Try
    End Sub
    Private Sub update_stats()
        lbltotaltransaction.Text = totaltransaction
        lblmonthly.Text = monthlytransaction
        'lblcash.Text = cashpayment
        'lblcard.Text = cardpayment
    End Sub

    Private Sub btnprintcustomers_Click(sender As Object, e As EventArgs) Handles btnprintcustomers.Click
        Dim usertransaction As New frmusertransaction(userselected)
        usertransaction.ShowDialog()
    End Sub

    Private Sub bw_log_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_log.DoWork
        Try
            Dim userobj As New Userlog
            loglist = userobj.user_logs(userselected)
        Catch ex As Exception
            MsgBox("bw logs:" + ex.Message)
        End Try
    End Sub

    Private Sub btnnewuser_Click(sender As Object, e As EventArgs) Handles btnnewuser.Click
        Dim newuser As New frmnewuser
        newuser.ShowDialog()
        load_all_users()


    End Sub

    Private Sub btnresetpassword_Click(sender As Object, e As EventArgs) Handles btnresetpassword.Click
        Dim userobj As New Users
        userobj.resetpassword(userselected)
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim x As Integer
        x = MessageBox.Show("Delete this user?", "Optical POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = vbYes Then
            'MsgBox(lvusers.SelectedItems(0).SubItems(2).Text + ":" + frmdashboard.userinfo(1))
            If lvusers.SelectedItems(0).SubItems(3).Text = frmdashboard.userinfo(2) And lvusers.SelectedItems(0).SubItems(2).Text = frmdashboard.userinfo(1) Then
                MsgBox("Error, this user is currently logged in.", MsgBoxStyle.Exclamation)
            Else

                Dim userobj As New Users
                userobj.deleteuser(userselected)
                load_all_users()
            End If
        End If

    End Sub

    Private Sub lvusers_MouseClick(sender As Object, e As MouseEventArgs) Handles lvusers.MouseClick

    End Sub

    Private Sub bw_log_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bw_log.RunWorkerCompleted
        Try
            If loglist IsNot Nothing Then

                lvlogs.Items.Clear()
                Dim x As Integer
                Dim loglv As ListViewItem
                For x = 0 To loglist.Count - 1
                    loglv = lvlogs.Items.Add(loglist(x).getdate)
                    loglv.SubItems.Add(loglist(x).gettime)
                    loglv.SubItems.Add(loglist(x).getstatus)
                Next
            Else


                lvlogs.Items.Clear()
            End If
        Catch ex As Exception
            MsgBox("Logs:" + ex.Message)
        End Try
    End Sub

    Private Sub bw_transaction_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_transaction.DoWork
        Try
            Dim transactionobj As New Transaction
            translist = transactionobj.search_transaction_issued(userselected)
        Catch ex As Exception
            MsgBox("Transaction BW:" + ex.Message)
        End Try
    End Sub
End Class