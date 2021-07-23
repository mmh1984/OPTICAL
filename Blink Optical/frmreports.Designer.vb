<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tbltransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New Optical_POS.DataSet2()
        Me.TopSalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet3 = New Optical_POS.DataSet3()
        Me.ProductStockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btndaily = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnstock = New System.Windows.Forms.Button()
        Me.btnlog = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.btnproducts = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.panl = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btntopapply = New System.Windows.Forms.Button()
        Me.cbxtopyear = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxtopmonth = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ReportViewer4 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.cbxbrand = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxcategory = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cbxstockyear = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxstockmonth = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbltransactionTableAdapter = New Optical_POS.DataSet2TableAdapters.tbltransactionTableAdapter()
        Me.TopSalesTableAdapter = New Optical_POS.DataSet3TableAdapters.TopSalesTableAdapter()
        Me.ProductLogTableAdapter = New Optical_POS.DataSet3TableAdapters.ProductLogTableAdapter()
        Me.ProductStockTableAdapter = New Optical_POS.DataSet3TableAdapters.ProductStockTableAdapter()
        Me.bw_sales = New System.ComponentModel.BackgroundWorker()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.tbltransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopSalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductStockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.btnproducts.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panl.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbltransactionBindingSource
        '
        Me.tbltransactionBindingSource.DataMember = "tbltransaction"
        Me.tbltransactionBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TopSalesBindingSource
        '
        Me.TopSalesBindingSource.DataMember = "TopSales"
        Me.TopSalesBindingSource.DataSource = Me.DataSet3
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductStockBindingSource
        '
        Me.ProductStockBindingSource.DataMember = "ProductStock"
        Me.ProductStockBindingSource.DataSource = Me.DataSet3
        '
        'ProductLogBindingSource
        '
        Me.ProductLogBindingSource.DataMember = "ProductLog"
        Me.ProductLogBindingSource.DataSource = Me.DataSet3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1115, 40)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reports"
        '
        'btndaily
        '
        Me.btndaily.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndaily.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndaily.ForeColor = System.Drawing.Color.White
        Me.btndaily.Location = New System.Drawing.Point(17, 115)
        Me.btndaily.Name = "btndaily"
        Me.btndaily.Size = New System.Drawing.Size(186, 54)
        Me.btndaily.TabIndex = 1
        Me.btndaily.Text = "Daily Sales"
        Me.btndaily.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListView1.Location = New System.Drawing.Point(234, 40)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(881, 443)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(17, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 54)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Top selling products"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnstock
        '
        Me.btnstock.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstock.ForeColor = System.Drawing.Color.White
        Me.btnstock.Location = New System.Drawing.Point(17, 260)
        Me.btnstock.Name = "btnstock"
        Me.btnstock.Size = New System.Drawing.Size(186, 54)
        Me.btnstock.TabIndex = 4
        Me.btnstock.Text = "Stock Inventory"
        Me.btnstock.UseVisualStyleBackColor = False
        '
        'btnlog
        '
        Me.btnlog.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlog.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlog.ForeColor = System.Drawing.Color.White
        Me.btnlog.Location = New System.Drawing.Point(17, 334)
        Me.btnlog.Name = "btnlog"
        Me.btnlog.Size = New System.Drawing.Size(186, 54)
        Me.btnlog.TabIndex = 5
        Me.btnlog.Text = "Product Log"
        Me.btnlog.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.btnproducts)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(246, 47)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(857, 424)
        Me.TabControl1.TabIndex = 8
        '
        'btnproducts
        '
        Me.btnproducts.Controls.Add(Me.Panel2)
        Me.btnproducts.Location = New System.Drawing.Point(4, 29)
        Me.btnproducts.Name = "btnproducts"
        Me.btnproducts.Padding = New System.Windows.Forms.Padding(3)
        Me.btnproducts.Size = New System.Drawing.Size(849, 391)
        Me.btnproducts.TabIndex = 0
        Me.btnproducts.Text = "Daily Sales"
        Me.btnproducts.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ReportViewer1)
        Me.Panel2.Controls.Add(Me.panl)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(843, 385)
        Me.Panel2.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TransactionHistory"
        ReportDataSource1.Value = Me.tbltransactionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Optical_POS.TransactionHistory.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 52)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(843, 333)
        Me.ReportViewer1.TabIndex = 1
        '
        'panl
        '
        Me.panl.BackColor = System.Drawing.Color.Silver
        Me.panl.Controls.Add(Me.Label2)
        Me.panl.Dock = System.Windows.Forms.DockStyle.Top
        Me.panl.Location = New System.Drawing.Point(0, 0)
        Me.panl.Name = "panl"
        Me.panl.Size = New System.Drawing.Size(843, 52)
        Me.panl.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Daily Sales"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(849, 391)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Top Selling Products"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ReportViewer2)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(843, 385)
        Me.Panel4.TabIndex = 1
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "TopSales"
        ReportDataSource2.Value = Me.TopSalesBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "Optical_POS.TopSales.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 52)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(843, 333)
        Me.ReportViewer2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Controls.Add(Me.btntopapply)
        Me.Panel5.Controls.Add(Me.cbxtopyear)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.cbxtopmonth)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(843, 52)
        Me.Panel5.TabIndex = 0
        '
        'btntopapply
        '
        Me.btntopapply.Location = New System.Drawing.Point(710, 12)
        Me.btntopapply.Name = "btntopapply"
        Me.btntopapply.Size = New System.Drawing.Size(89, 28)
        Me.btntopapply.TabIndex = 10
        Me.btntopapply.Text = "Apply"
        Me.btntopapply.UseVisualStyleBackColor = True
        '
        'cbxtopyear
        '
        Me.cbxtopyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxtopyear.FormattingEnabled = True
        Me.cbxtopyear.Location = New System.Drawing.Point(629, 14)
        Me.cbxtopyear.Name = "cbxtopyear"
        Me.cbxtopyear.Size = New System.Drawing.Size(75, 25)
        Me.cbxtopyear.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(552, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Select Year"
        '
        'cbxtopmonth
        '
        Me.cbxtopmonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxtopmonth.FormattingEnabled = True
        Me.cbxtopmonth.Location = New System.Drawing.Point(467, 14)
        Me.cbxtopmonth.Name = "cbxtopmonth"
        Me.cbxtopmonth.Size = New System.Drawing.Size(75, 25)
        Me.cbxtopmonth.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(377, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Select Month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Top Selling Products"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel7)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(849, 391)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Stock Inventory"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.ReportViewer4)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(843, 385)
        Me.Panel7.TabIndex = 3
        '
        'ReportViewer4
        '
        Me.ReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "ProductStock"
        ReportDataSource3.Value = Me.ProductStockBindingSource
        Me.ReportViewer4.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer4.LocalReport.ReportEmbeddedResource = "Optical_POS.ProductStock.rdlc"
        Me.ReportViewer4.Location = New System.Drawing.Point(0, 52)
        Me.ReportViewer4.Name = "ReportViewer4"
        Me.ReportViewer4.Size = New System.Drawing.Size(843, 333)
        Me.ReportViewer4.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Silver
        Me.Panel8.Controls.Add(Me.btnreset)
        Me.Panel8.Controls.Add(Me.cbxbrand)
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Controls.Add(Me.cbxcategory)
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(843, 52)
        Me.Panel8.TabIndex = 0
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(704, 13)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(89, 28)
        Me.btnreset.TabIndex = 11
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'cbxbrand
        '
        Me.cbxbrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxbrand.FormattingEnabled = True
        Me.cbxbrand.Location = New System.Drawing.Point(561, 15)
        Me.cbxbrand.Name = "cbxbrand"
        Me.cbxbrand.Size = New System.Drawing.Size(124, 25)
        Me.cbxbrand.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(477, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Select Name"
        '
        'cbxcategory
        '
        Me.cbxcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxcategory.FormattingEnabled = True
        Me.cbxcategory.Items.AddRange(New Object() {"Frames", "Lens", "Contact Lens", "Solutions", "Nose Pads", "Ear Stopper", "Others"})
        Me.cbxcategory.Location = New System.Drawing.Point(332, 15)
        Me.cbxcategory.Name = "cbxcategory"
        Me.cbxcategory.Size = New System.Drawing.Size(128, 25)
        Me.cbxcategory.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(242, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 17)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Product Type"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 25)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Product Inventory"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Panel3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(849, 391)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Product Log"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ReportViewer3)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(843, 385)
        Me.Panel3.TabIndex = 2
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "Stocklog"
        ReportDataSource4.Value = Me.ProductLogBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "Optical_POS.Stocklog.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(0, 52)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(843, 333)
        Me.ReportViewer3.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.Controls.Add(Me.Button3)
        Me.Panel6.Controls.Add(Me.cbxstockyear)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.cbxstockmonth)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(843, 52)
        Me.Panel6.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(738, 11)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 31)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Apply"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cbxstockyear
        '
        Me.cbxstockyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxstockyear.FormattingEnabled = True
        Me.cbxstockyear.Location = New System.Drawing.Point(648, 14)
        Me.cbxstockyear.Name = "cbxstockyear"
        Me.cbxstockyear.Size = New System.Drawing.Size(75, 25)
        Me.cbxstockyear.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(571, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Select Year"
        '
        'cbxstockmonth
        '
        Me.cbxstockmonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxstockmonth.FormattingEnabled = True
        Me.cbxstockmonth.Location = New System.Drawing.Point(467, 14)
        Me.cbxstockmonth.Name = "cbxstockmonth"
        Me.cbxstockmonth.Size = New System.Drawing.Size(75, 25)
        Me.cbxstockmonth.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(377, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Select Month"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Product Log"
        '
        'tbltransactionTableAdapter
        '
        Me.tbltransactionTableAdapter.ClearBeforeFill = True
        '
        'TopSalesTableAdapter
        '
        Me.TopSalesTableAdapter.ClearBeforeFill = True
        '
        'ProductLogTableAdapter
        '
        Me.ProductLogTableAdapter.ClearBeforeFill = True
        '
        'ProductStockTableAdapter
        '
        Me.ProductStockTableAdapter.ClearBeforeFill = True
        '
        'bw_sales
        '
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(58, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 21)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Select Report"
        '
        'frmreports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1115, 483)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnlog)
        Me.Controls.Add(Me.btnstock)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btndaily)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmreports"
        CType(Me.tbltransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopSalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductStockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.btnproducts.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.panl.ResumeLayout(False)
        Me.panl.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btndaily As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents btnstock As Button
    Friend WithEvents btnlog As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents btnproducts As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents panl As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbltransactionBindingSource As BindingSource
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents tbltransactionTableAdapter As DataSet2TableAdapters.tbltransactionTableAdapter
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TopSalesBindingSource As BindingSource
    Friend WithEvents DataSet3 As DataSet3
    Friend WithEvents TopSalesTableAdapter As DataSet3TableAdapters.TopSalesTableAdapter
    Friend WithEvents btntopapply As Button
    Friend WithEvents cbxtopyear As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxtopmonth As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProductLogBindingSource As BindingSource
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents cbxstockyear As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxstockmonth As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ProductLogTableAdapter As DataSet3TableAdapters.ProductLogTableAdapter
    Friend WithEvents Panel7 As Panel
    Friend WithEvents ReportViewer4 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel8 As Panel
    Friend WithEvents cbxbrand As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxcategory As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ProductStockBindingSource As BindingSource
    Friend WithEvents ProductStockTableAdapter As DataSet3TableAdapters.ProductStockTableAdapter
    Friend WithEvents btnreset As Button
    Friend WithEvents bw_sales As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label12 As Label
End Class
