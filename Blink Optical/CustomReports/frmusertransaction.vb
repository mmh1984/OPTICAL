Public Class frmusertransaction
    Dim userid As String
    Public Sub New(ByVal _userid As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        userid = _userid
    End Sub
    Private Sub frmusertransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.tblusertransaction' table. You can move, or remove it, as needed.
        Me.DataSet2.EnforceConstraints = False
        Me.tblusertransactionTableAdapter.Fill(Me.DataSet2.tblusertransaction, userid)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Print(sender As Object, e As Microsoft.Reporting.WinForms.ReportPrintEventArgs) Handles ReportViewer1.Print
        Dim config As New Configuration
        config.get_details()

        ReportViewer1.PrinterSettings.PrinterName = config.getprinter2
        ReportViewer1.PrinterSettings.Copies = 2
    End Sub
End Class