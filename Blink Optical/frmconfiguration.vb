Imports System.Drawing.Printing
Imports System.IO
Public Class frmconfiguration

    Private Sub open_drawer()
        Try
            Dim intFileNo As Integer = FreeFile()

            FileOpen(1, "c:\blink\escapes.txt", OpenMode.Output)

            PrintLine(1, Chr(27) & "p" & Chr(0) & Chr(25) & Chr(250))

            FileClose(1)
            Dim sCommand As String
            sCommand = "start /min notepad /P " + "c:\blink\escapes.txt"
            Shell("cmd.exe /c " & sCommand, AppWinStyle.Hide)

            MsgBox("OPen")
        Catch ex As Exception
            MsgBox("OPen Drawer")
        End Try
    End Sub

    Private Sub frmconfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_printer()
        load_config()
    End Sub
    Private Sub load_config()
        Try
            Dim config As New Configuration
            config.get_details()
            txtname.Text = config.getname
            txtphone.Text = config.getphone
            txtemail.Text = config.getemail
            txtinstagram.Text = config.getig
            txtaddress.Text = config.getaddress
            txttag.Text = config.gettag
            For Each item In cbxthermalprinter.Items

                If item = config.getprinter1 Then

                    cbxthermalprinter.SelectedItem = item
                Else
                    cbxthermalprinter.SelectedIndex = 0
                End If
            Next
            For Each item In cbxlaserprinter.Items
                If item = config.getprinter2 Then

                    cbxlaserprinter.SelectedItem = item
                Else
                    cbxlaserprinter.SelectedIndex = 0
                End If
            Next
        Catch ex As Exception
            MsgBox("Load configuration" + ex.Message)
        End Try
    End Sub
    Private Sub load_printer()
        Dim installedprinter As String
        For Each installedprinter In PrinterSettings.InstalledPrinters
            cbxlaserprinter.Items.Add(installedprinter)
            cbxthermalprinter.Items.Add(installedprinter)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtname.Text.Length = 0 Then
            MessageBox.Show("Please enter the shop's name", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtphone.Text.Length = 0 Then
            MessageBox.Show("Please enter the shop's phone", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtemail.Text.Length = 0 Then
            MessageBox.Show("Please enter the shop's email", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtaddress.Text.Length = 0 Then
            MessageBox.Show("Please enter the shop's address", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtinstagram.Text.Length = 0 Then
            MessageBox.Show("Please enter the shop's instagram", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim config As New Configuration
            config.setname(txtname.Text)
            config.setphone(txtphone.Text)
            config.setemail(txtemail.Text)
            config.setaddress(txtaddress.Text)
            config.setig(txtinstagram.Text)
            config.settag(txttag.Text)
            config.setprinter1(cbxthermalprinter.SelectedItem)
            config.setprinter2(cbxlaserprinter.SelectedItem)
            config.save_details()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class