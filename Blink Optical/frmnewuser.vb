Public Class frmnewuser
    Private Sub frmnewuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxuserlevel.SelectedIndex = 0
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtusername.Text.Length = 0 Then
            MessageBox.Show("Please enter the username", "Optical POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtpassword.Text.Length = 0 Then
            MessageBox.Show("Please enter the password", "Optical POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtfullname.Text.Length = 0 Then
            MessageBox.Show("Please enter the password", "Optical POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim userobj As New Users
            userobj.setusername(txtusername.Text)
            userobj.setuserpass(txtpassword.Text)
            userobj.setname(txtfullname.Text)
            userobj.setlevel(cbxuserlevel.SelectedItem)
            If userobj.user_exists(txtusername.Text) = False Then
                If userobj.save_user() Then
                    MessageBox.Show("New user created", "Optical POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            Else
                MessageBox.Show("This username is not available", "Optical POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub
End Class