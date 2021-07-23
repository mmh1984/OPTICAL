Public Class frmposbig
    Dim receiptno As String
    Public Sub New(ByVal _receiptno As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        receiptno = _receiptno
    End Sub
    Private Sub frmposbig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dataset1.posbig' table. You can move, or remove it, as needed.
        Me.Dataset1.EnforceConstraints = False
        Me.posbigTableAdapter.Fill(Me.Dataset1.posbig, receiptno)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Print(sender As Object, e As Microsoft.Reporting.WinForms.ReportPrintEventArgs) Handles ReportViewer1.Print
        Dim config As New Configuration
        config.get_details()

        ReportViewer1.PrinterSettings.PrinterName = config.getprinter2
        ReportViewer1.PrinterSettings.Copies = 1
    End Sub
End Class