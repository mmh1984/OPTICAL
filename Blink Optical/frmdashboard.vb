

Public Class frmdashboard
    Public Shared userinfo As New List(Of String)
    Public Sub New(ByRef _userinfo As List(Of String))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        userinfo = _userinfo
    End Sub

    Private Sub frmdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'panel for work order
        change_panel(frmworkorder)

        'time and date
        Timer1.Start()
        lbluser.Text = "Logged as: " + userinfo(1) + "(" + userinfo(2) + ")"
        enable_restrictions(userinfo(2))

        load_config()

    End Sub
    Private Sub load_config()
        Dim configobj As New Configuration
        configobj.get_details()

        lblstorename.Text = configobj.getname
    End Sub
    Private Sub enable_restrictions(ByVal usertype As String)
        If usertype = "manager" Then
            btnusers.Enabled = True
        Else
            btnusers.Enabled = False
        End If
    End Sub
    Private Sub change_panel(ByVal form As Form)
        'For Each form1 In mainpanel.Controls.OfType(Of Form).ToList
        'form1.Close()
        'Next

        With form

            .TopLevel = False
            mainpanel.Controls.Clear()
            mainpanel.Controls.Add(form)
            .BringToFront()
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Top
            mainpanel.AutoScroll = True

            .Show()
        End With

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        lbldate.Text = "Date :" & Now.Date.ToString("dd-MM-yyyy")
    End Sub

    'functions
    Private Sub btnworkorder_Click(sender As Object, e As EventArgs) Handles btnworkorder.Click
        frmworkorder.Close()
        change_panel(frmworkorder)

    End Sub
    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim x As Integer
        x = MessageBox.Show("Confirm logout?", "Optical Shop POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = vbYes Then
            save_log()
            Me.Close()
            With frmlogin
                .txtusername.Clear()
                .txtpassword.Clear()
                .txtusername.Focus()
                .load_config()
                .Show()
            End With

        End If
    End Sub
    Private Sub save_log()
        Try
            Dim logobj As New Userlog
            logobj.setuser(userinfo(0))
            logobj.setstatus("logout")
            'logobj.setdate(Date.Now)
            'logobj.settime(Date.Now)
            logobj.save_log()
        Catch ex As Exception
            MsgBox("Save log:" + ex.Message)
        End Try
    End Sub
    Private Sub btnlenses_Click(sender As Object, e As EventArgs) Handles btnlenses.Click
        frmproducts.Close()
        change_panel(frmproducts)
    End Sub

    Private Sub btnaddon_Click(sender As Object, e As EventArgs) Handles btnaddon.Click
        frmaddons.Close()
        change_panel(frmaddons)
    End Sub

    Private Sub btnpackage_Click(sender As Object, e As EventArgs) Handles btnpackage.Click
        frmpackage.Close()
        change_panel(frmpackage)
    End Sub

    Private Sub btnbuy_Click(sender As Object, e As EventArgs) Handles btnbuy.Click
        frmpos.Close()
        change_panel(frmpos)
    End Sub

    Private Sub btntransaction_Click(sender As Object, e As EventArgs) Handles btntransaction.Click
        frmtransactionhistory.Close()
        change_panel(frmtransactionhistory)
    End Sub

    Private Sub btncustomers_Click(sender As Object, e As EventArgs) Handles btncustomers.Click
        frmcustomerrecord.Close()
        change_panel(frmcustomerrecord)

    End Sub

    Private Sub btnusers_Click(sender As Object, e As EventArgs) Handles btnusers.Click
        frmusers.Close()
        change_panel(frmusers)
    End Sub

    Private Sub btnprofile_Click(sender As Object, e As EventArgs) Handles btnprofile.Click

        Dim profile As New frmprofile
        profile.ShowDialog()
        load_config()
    End Sub

    Private Sub btnreports_Click(sender As Object, e As EventArgs) Handles btnreports.Click
        frmreports.Close()
        change_panel(frmreports)
    End Sub
End Class