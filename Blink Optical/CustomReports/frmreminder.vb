Public Class frmreminder
    Private Sub frmreminder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet3.Reminder' table. You can move, or remove it, as needed.
        Me.ReminderTableAdapter.Fill(Me.DataSet3.Reminder)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Print(sender As Object, e As Microsoft.Reporting.WinForms.ReportPrintEventArgs) Handles ReportViewer1.Print
        Dim config As New Configuration
        config.get_details()

        ReportViewer1.PrinterSettings.PrinterName = config.getprinter2
        ReportViewer1.PrinterSettings.Copies = 1
    End Sub
End Class