Imports Microsoft.Reporting.WinForms

Public Class frmreports
    Dim printername As String

    Private Sub btndaily_Click(sender As Object, e As EventArgs) Handles btndaily.Click
        TabControl1.Enabled = True
        TabControl1.SelectedIndex = 0
        load_daily()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.Enabled = True
        TabControl1.SelectedIndex = 1
        load_top_sales()
    End Sub

    Private Sub btnstock_Click(sender As Object, e As EventArgs) Handles btnstock.Click
        TabControl1.Enabled = True
        TabControl1.SelectedIndex = 2
        load_inventory()
    End Sub

    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        TabControl1.Enabled = True
        TabControl1.SelectedIndex = 3
        load_stock_log()
    End Sub

    Private Sub frmreports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet3.ProductStock' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DataSet3.ProductLog' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DataSet3.TopSales' table. You can move, or remove it, as needed.

        Me.DataSet2.EnforceConstraints = False
        Me.DataSet3.EnforceConstraints = False
        'load_daily()
        TabControl1.Enabled = False
        load_dates()
        load_brand()
        load_types()
        Dim config As New Configuration
        config.get_details()
        printername = config.getprinter2
    End Sub
    Private Sub load_types()
        Try
            Dim list1 As New List(Of ProductType)
            Dim typeobj As New ProductType
            list1 = typeobj.get_category
            If list1 IsNot Nothing Then
                cbxcategory.Enabled = True
                cbxcategory.Items.Clear()
                Dim x As Integer
                For x = 0 To list1.Count - 1
                    cbxcategory.Items.Add(list1(x).getname)
                Next
            Else
                cbxcategory.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Load types:" + ex.Message)
        End Try
    End Sub
    Private Sub load_brand()
        Try
            Dim productobj As New ProductFrame
            Dim list1 As New List(Of String)
            list1 = productobj.get_name
            cbxbrand.Enabled = True
            cbxbrand.Items.Clear()
            If list1 IsNot Nothing Then
                For Each item In list1
                    cbxbrand.Items.Add(item)
                Next
            Else
                MsgBox("No contents")
                cbxbrand.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("load brand:" + ex.Message)
        End Try
    End Sub
    Public Sub load_dates()
        Try
            Dim m, y As Integer
            For m = 1 To 12
                cbxtopmonth.Items.Add(m)
                cbxstockmonth.Items.Add(m)
            Next
            y = Year(Now)
            Dim x As Integer
            For x = y To y - 4 Step -1
                cbxtopyear.Items.Add(x)
                cbxstockyear.Items.Add(x)
            Next
            cbxtopmonth.SelectedItem = Month(Today)
            cbxtopyear.SelectedItem = y
            cbxstockmonth.SelectedItem = Month(Today)
            cbxstockyear.SelectedItem = y
        Catch ex As Exception
            MsgBox("Load dates:" + ex.Message)
        End Try
    End Sub
    Public Sub load_daily()
        Try
            Me.tbltransactionTableAdapter.FillBy2(Me.DataSet2.tbltransaction, Date.Now)

            If Me.DataSet2.tbltransaction.Rows.Count <> 0 Then

                Dim param As New List(Of ReportParameter)
                Dim tranobj As New Transaction
                Dim amountlist As New List(Of Decimal)
                amountlist = tranobj.get_amount()

                param.Add(New ReportParameter("Parameter1", "Date:" + Date.Now.ToString("dd/MM/yyyy")))
                param.Add(New ReportParameter("Total", amountlist(0)))
                param.Add(New ReportParameter("Deposit", amountlist(1)))
                param.Add(New ReportParameter("Balance", amountlist(2)))
                Me.ReportViewer1.LocalReport.SetParameters(param)
                Me.ReportViewer1.RefreshReport()
            Else
                MsgBox("No sales for today")
            End If

        Catch ex As Exception
            MsgBox("Daily:" + ex.Message)
        End Try

    End Sub
    Private Sub load_top_sales()
        Try
            Me.TopSalesTableAdapter.Fill(Me.DataSet3.TopSales, cbxtopmonth.SelectedItem, cbxtopyear.SelectedItem)
            If DataSet3.TopSales.Rows.Count <> 0 Then
                'TODO: This line of code loads data into the 'DataSet3.TopSales' table. You can move, or remove it, as needed.

                'TODO: This line of code loads data into the 'DataSet2.tbltransaction' table. You can move, or remove it, as needed.

                Dim param As New ReportParameter
                param = New ReportParameter("ReportParameter1", cbxtopmonth.SelectedItem.ToString + "/" + cbxtopyear.SelectedItem.ToString)
                Me.ReportViewer2.LocalReport.SetParameters(New ReportParameter() {param})
                Me.ReportViewer2.RefreshReport()
            Else
                MsgBox("No sales data on the selected dates(s)")
            End If

        Catch ex As Exception
            MsgBox("Top sales:" + ex.Message)
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0
                load_daily()
            Case 1
                load_top_sales()
            Case 2
                load_inventory()
            Case 3
                load_stock_log()
        End Select
    End Sub

    Private Sub load_stock_log()
        Try
            Me.ProductLogTableAdapter.Fill(Me.DataSet3.ProductLog, cbxstockmonth.SelectedItem, cbxstockyear.SelectedItem)
            If Me.DataSet3.ProductLog.Rows.Count <> 0 Then

                Dim param As New ReportParameter
                param = New ReportParameter("ReportParameter1", cbxstockmonth.SelectedItem.ToString + "/" + cbxstockyear.SelectedItem.ToString)
                Me.ReportViewer3.LocalReport.SetParameters(New ReportParameter() {param})
                Me.ReportViewer3.RefreshReport()
            Else
                MsgBox("No logs on the selected date")
            End If

        Catch ex As Exception
            MsgBox("Stock log:" + ex.Message)
        End Try
    End Sub
    Private Sub load_inventory()
        Try


            Me.ProductStockTableAdapter.Fill(Me.DataSet3.ProductStock)
            If Me.DataSet3.ProductStock.Rows.Count <> 0 Then

                Me.ReportViewer4.RefreshReport()
            Else
                MsgBox("No inventory data")
            End If
        Catch ex As Exception
            MsgBox("Load stocks:" + ex.Message)
        End Try
    End Sub

    Private Sub btntopapply_Click(sender As Object, e As EventArgs) Handles btntopapply.Click
        load_top_sales()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        load_stock_log()
    End Sub

    Private Sub cbxcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxcategory.SelectedIndexChanged
        Try
            Me.ProductStockTableAdapter.FillBy(Me.DataSet3.ProductStock, cbxcategory.SelectedItem)
            If Me.DataSet3.ProductStock.Rows.Count <> 0 Then

                Me.ReportViewer4.RefreshReport()

                load_brand()
            Else
                MsgBox("No inventory data")
            End If
        Catch ex As Exception
            MsgBox("Filter Category:" + ex.Message)
        End Try
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        load_inventory()
    End Sub

    Private Sub cbxbrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxbrand.SelectedIndexChanged
        Try
            Me.ProductStockTableAdapter.FillBy1(Me.DataSet3.ProductStock, cbxbrand.SelectedItem)
            If Me.DataSet3.ProductStock.Rows.Count <> 0 Then

                Me.ReportViewer4.RefreshReport()
            Else
                MsgBox("No inventory data")
            End If
        Catch ex As Exception
            MsgBox("Filter Brand:" + ex.Message)
        End Try
    End Sub

    Private Sub bw_sales_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_sales.DoWork
        load_top_sales()
    End Sub

    Private Sub ReportViewer1_Print(sender As Object, e As ReportPrintEventArgs) Handles ReportViewer1.Print


        ReportViewer1.PrinterSettings.PrinterName = printername
        ReportViewer1.PrinterSettings.Copies = 1
    End Sub

    Private Sub ReportViewer2_Print(sender As Object, e As ReportPrintEventArgs) Handles ReportViewer2.Print


        ReportViewer2.PrinterSettings.PrinterName = printername
        ReportViewer2.PrinterSettings.Copies = 1
    End Sub

    Private Sub ReportViewer4_Print(sender As Object, e As ReportPrintEventArgs) Handles ReportViewer4.Print

        ReportViewer4.PrinterSettings.PrinterName = printername
        ReportViewer4.PrinterSettings.Copies = 1
    End Sub

    Private Sub ReportViewer3_Print(sender As Object, e As ReportPrintEventArgs) Handles ReportViewer3.Print


        ReportViewer3.PrinterSettings.PrinterName = printername
        ReportViewer3.PrinterSettings.Copies = 1
    End Sub
End Class