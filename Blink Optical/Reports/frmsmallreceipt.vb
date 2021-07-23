Imports System.Drawing.Printing
Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic.PowerPacks.Printing

Public Class frmsmallreceipt
    Dim receiptno As Integer
    Private bmp As Bitmap
    Public Sub New(ByVal _receiptno As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        receiptno = Convert.ToInt32(_receiptno)
    End Sub
    Private Sub frmsmallreceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Dataset1.EnforceConstraints = False
        'TODO: This line of code loads data into the 'Dataset1.smallreceipt' table. You can move, or remove it, as needed.

        Me.smallreceiptTableAdapter.Fill(Me.Dataset1.smallreceipt, receiptno)
        Dim configobj As New Configuration
        configobj.get_details()

        Dim param As New List(Of ReportParameter)
        Dim p1 As New ReportParameter("Shopname", configobj.getname.ToString)
        Dim p2 As New ReportParameter("Shopaddress", configobj.getaddress.ToString)
        Dim p3 As New ReportParameter("Phonenumber", configobj.getphone.ToString)
        Dim p4 As New ReportParameter("Emailaddress", configobj.getemail.ToString)
        Dim p5 As New ReportParameter("Shopig", configobj.getig.ToString)
        param.Add(p1)
        param.Add(p2)
        param.Add(p3)
        param.Add(p4)
        param.Add(p5)
        Me.ReportViewer1.LocalReport.SetParameters(param)
        Me.ReportViewer1.RefreshReport()



    End Sub
    Private Sub PrintReceipt()
        pf.Form = Me
        pf.PrinterSettings.Copies = 2
        pf.PrinterSettings.DefaultPageSettings.Margins = New Printing.Margins(3, 3, 3, 3)
        pf.PrinterSettings.DefaultPageSettings.PaperSize.RawKind = Printing.PaperKind.Letter
        pf.PrinterSettings.PrinterName = "Adobe PDF"
        pf.PrintAction = Printing.PrintAction.PrintToPreview
        pf.Print(Me, PrintForm.PrintOption.ClientAreaOnly)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        bmp = New Bitmap(Panel1.Width, Panel1.Height)
        Dim G As Graphics = Graphics.FromImage(bmp)
        Panel1.DrawToBitmap(bmp, Panel1.ClientRectangle)
        G.Dispose()
        Me.Hide()
        PrintPreviewDialog1.Document = PrintDocument1
        If (PrintPreviewDialog1.ShowDialog() = DialogResult.OK) Then
            Me.Close()
        Else
            Me.Show()
        End If

    End Sub



    Private Sub ReportViewer1_Print(sender As Object, e As Microsoft.Reporting.WinForms.ReportPrintEventArgs) Handles ReportViewer1.Print
        Dim config As New Configuration
        config.get_details()

        ReportViewer1.PrinterSettings.PrinterName = config.getprinter1
        ReportViewer1.PrinterSettings.Copies = 1


    End Sub
End Class