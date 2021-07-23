Imports Microsoft.Reporting.WinForms

Public Class frmcustomertransaction
    Dim customerid As String
    Public amountlist As New List(Of Decimal)
    Public Sub New(ByVal _id As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        customerid = _id
    End Sub
    Private Sub frmcustomertransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.tblcustomertransaction' table. You can move, or remove it, as needed.
        DataSet2.EnforceConstraints = False
        Me.tblcustomertransactionTableAdapter.Fill(Me.DataSet2.tblcustomertransaction, customerid)
        Dim param As New List(Of ReportParameter)
        param.Add(New ReportParameter("Total", amountlist(0)))
        param.Add(New ReportParameter("Deposit", amountlist(1)))
        param.Add(New ReportParameter("Balance", amountlist(2)))
        Me.ReportViewer1.LocalReport.SetParameters(param)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Print(sender As Object, e As Microsoft.Reporting.WinForms.ReportPrintEventArgs) Handles ReportViewer1.Print
        Dim config As New Configuration
        config.get_details()

        ReportViewer1.PrinterSettings.PrinterName = config.getprinter2
        ReportViewer1.PrinterSettings.Copies = 1
    End Sub
End Class