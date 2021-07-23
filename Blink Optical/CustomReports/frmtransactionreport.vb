

Imports Microsoft.Reporting.WinForms

Public Class frmtransactionreport
    Dim datestart, dateend As Date
    Dim receiptno As String
    Dim operation As String
    Public amountlist As New List(Of Decimal)
    Public Sub New(ByVal _operation As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        operation = _operation
    End Sub
    Private Sub frmtransactionreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.DataSet2.EnforceConstraints = False
            Dim param As New List(Of ReportParameter)
            If operation = "range" Then
                Dim strparam As String = "Date(s):" + datestart.ToString("dd-MM-yyyy") + " to " + dateend.ToString("dd-MM-yyyy")
                param.Add(New ReportParameter("Parameter1", strparam))
                Me.tbltransactionTableAdapter.FillBy(Me.DataSet2.tbltransaction, datestart, dateend)

            ElseIf operation = "receipt" Then
                param.Add(New ReportParameter("Parameter1", "Date:" + Today.ToString("dd-MM-yyyy")))
                Me.tbltransactionTableAdapter.FillBy1(Me.DataSet2.tbltransaction, receiptno)
            Else
                param.Add(New ReportParameter("Parameter1", "Date:" + Today.ToString("dd-MM-yyyy")))
                Me.tbltransactionTableAdapter.Fill(Me.DataSet2.tbltransaction)

            End If

            'TODO: This line of code loads data into the 'DataSet2.tbltransaction' table. You can move, or remove it, as needed.

            'TODO: This line of code loads data into the 'DataSet2.tbltransactionitem' table. You can move, or remove it, as needed.

            param.Add(New ReportParameter("Total", amountlist(0)))
            param.Add(New ReportParameter("Deposit", amountlist(1)))
            param.Add(New ReportParameter("Balance", amountlist(2)))
            Me.ReportViewer1.LocalReport.SetParameters(param)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("Transaction History: " + ex.Message)
            Me.Close()
        End Try

    End Sub
    Public Sub setdates(ByVal d1 As Date, ByVal d2 As Date)
        datestart = d1
        dateend = d2
    End Sub

    Private Sub ReportViewer1_Print(sender As Object, e As ReportPrintEventArgs) Handles ReportViewer1.Print
        Dim config As New Configuration
        config.get_details()

        ReportViewer1.PrinterSettings.PrinterName = config.getprinter2
        ReportViewer1.PrinterSettings.Copies = 1
    End Sub

    Public Sub setreceipt(ByVal no As String)
        receiptno = no
    End Sub
End Class