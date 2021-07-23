Imports System.Data.SqlClient
Public Class frmprofile
    Dim userinfo As List(Of String)
    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Private Sub frmprofile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userinfo = frmdashboard.userinfo
        If userinfo(2) = "manager" Then
            paneladmin.Enabled = True
        Else
            paneladmin.Enabled = False
        End If
        load_user()

    End Sub
    Private Sub load_user()
        Try
            Dim userlist As New List(Of String)
            Dim userobj As New Users
            userlist = userobj.user_details(userinfo(0))
            txtname.Text = userlist(1)
            txtpassword.Text = userlist(2)
            txtfullname.Text = userlist(3)
        Catch ex As Exception
            MsgBox("User info:" + ex.Message)
        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtname.Text.Length = 0 Then
            MessageBox.Show("Name cannot be empty", "Optical POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtpassword.Text.Length = 0 Then
            MessageBox.Show("Password cannot be empty", "Optical POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtfullname.Text.Length = 0 Then
            MessageBox.Show("Full name cannot be empty", "Optical POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim userobj As New Users
            userobj.setid(userinfo(0))
            userobj.setusername(txtname.Text)
            userobj.setuserpass(txtpassword.Text)
            userobj.setname(txtfullname.Text)
            If userobj.user_exists() = False Then
                userobj.update_user()
            Else
                MessageBox.Show("This username is already taken", "Optical POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btneditstore.Click
        Dim config As New frmconfiguration
        config.ShowDialog()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Try
            open_connection()
            Dim cmd As SqlCommand
            Dim qry As String
            Dim today As Date


            today = DateTime.Now
            SaveFileDialog1.FileName = "BACKUP_" & today.ToString("dd-MM-yyyy") & ".bak"
            If (SaveFileDialog1.ShowDialog() = DialogResult.OK) Then
                qry = "BACKUP DATABASE [opticaldb] TO  DISK = N'" & SaveFileDialog1.FileName & " ' WITH NOFORMAT, NOINIT,  NAME = N'KREM-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
                cmd = New SqlCommand(qry, con)
                If (cmd.ExecuteNonQuery) Then
                    MsgBox("Databased saved")
                End If
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub open_connection()
        Try
            Dim db As Connection
            db = New Connection

            con = New SqlConnection(db.get_connection)
            con.Open()

        Catch ex As Exception
            MessageBox.Show("Open Connection:" & ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim typeobj As New frmproducttype
        typeobj.ShowDialog()
    End Sub
End Class