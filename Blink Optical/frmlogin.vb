
Public Class frmlogin
    Dim userinfo As New List(Of String)
    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim bigreceipt As New frmpossmall("1000010")
        'bigreceipt.ShowDialog()
        'Me.Close()
        Dim userobj As New Users
        'MsgBox(Date.Now.ToString("yyyy-MM-dd"))
        If userobj.user_check = 0 Then
            Dim newuser As New frmnewuser
            newuser.cbxuserlevel.SelectedIndex = 0
            newuser.cbxuserlevel.Enabled = False
            newuser.ShowDialog()

        End If
        load_config()
        ' Dim date1 As Date = "5/10/2021"
        'If Date.Now.Month = date1.Month And (date1.Year - Date.Now.Year) = 1 Then

        'MsgBox("Same day bro")
        'End If

    End Sub
    Public Sub load_config()
        Try
            Dim confobj As New Configuration
            confobj.get_details()
            lblshopname.Text = confobj.getname
            lbladdress.Text = confobj.getaddress
            lblphone.Text = "        " & confobj.getphone
            lblemail.Text = "        " & confobj.getemail
            lblsocial.Text = "        " & confobj.getig
        Catch ex As Exception
            MsgBox("Load config:" + ex.Message)
        End Try
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblphone.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername.Text.Length = 0 Then
            MessageBox.Show("Please enter your username", "Optical POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtusername.Focus()
        ElseIf txtpassword.Text.Length = 0 Then
            MessageBox.Show("Please enter your password", "Optical POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtusername.Focus()
        Else

            Dim userobj As New Users
            userinfo = userobj.login_user(txtusername.Text, txtpassword.Text)
            If userinfo IsNot Nothing Then
                save_log()
                MessageBox.Show("Login accepted", "Optical POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtusername.Clear()
                txtpassword.Clear()
                txtusername.Focus()

                Me.Hide()
                Dim dashboard As New frmdashboard(userinfo)
                dashboard.Show()

            Else
                MessageBox.Show("Incorrect username/password", "Optical POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub save_log()
        Try
            Dim logobj As New Userlog
            logobj.setuser(userinfo(0))
            logobj.setstatus("login")
            'logobj.setdate(Date.Now)
            'logobj.settime(Date.Now)
            logobj.save_log()
        Catch ex As Exception
            MsgBox("Save log:" + ex.Message)
        End Try
    End Sub
End Class