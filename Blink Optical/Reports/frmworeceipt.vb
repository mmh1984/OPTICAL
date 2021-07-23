Public Class frmworeceipt
    Dim receiptno As String
    Public Sub New(ByVal rno As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        receiptno = rno
    End Sub
    Private Sub frmworeceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dataset1.EnforceConstraints = False
        'TODO: This line of code loads data into the 'Dataset1.bigreceipt' table. You can move, or remove it, as needed.
        Me.bigreceiptTableAdapter.Fill(Me.Dataset1.bigreceipt, receiptno)
        'TODO: This line of code loads data into the 'Dataset1.workorder' table. You can move, or remove it, as needed.


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Print(sender As Object, e As Microsoft.Reporting.WinForms.ReportPrintEventArgs) Handles ReportViewer1.Print
        Dim config As New Configuration
        config.get_details()

        ReportViewer1.PrinterSettings.PrinterName = config.getprinter2
        ReportViewer1.PrinterSettings.Copies = 1
    End Sub
End Class