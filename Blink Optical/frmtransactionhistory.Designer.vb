<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmtransactionhistory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.paneltop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelhead = New System.Windows.Forms.Panel()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnapply = New System.Windows.Forms.Button()
        Me.dtend = New System.Windows.Forms.DateTimePicker()
        Me.dtstart = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.panelbody = New System.Windows.Forms.Panel()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnprintreceipt = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbltotalprice = New System.Windows.Forms.Label()
        Me.lbltotalproduct = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lvproductlist = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvtransactionlist = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.panelbodyright = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblothers = New System.Windows.Forms.Label()
        Me.lblbaiduri = New System.Windows.Forms.Label()
        Me.lblscb = New System.Windows.Forms.Label()
        Me.lblbibd = New System.Windows.Forms.Label()
        Me.lblcard = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblcash = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbltotalamount = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbltotaltransaction = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bwload_transactions = New System.ComponentModel.BackgroundWorker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbltotaldeposit = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbltotalbalance = New System.Windows.Forms.Label()
        Me.paneltop.SuspendLayout()
        Me.panelhead.SuspendLayout()
        Me.panelbody.SuspendLayout()
        Me.panelbodyright.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'paneltop
        '
        Me.paneltop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.paneltop.Controls.Add(Me.Label1)
        Me.paneltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.paneltop.Location = New System.Drawing.Point(0, 0)
        Me.paneltop.Name = "paneltop"
        Me.paneltop.Size = New System.Drawing.Size(1115, 32)
        Me.paneltop.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaction History"
        '
        'panelhead
        '
        Me.panelhead.Controls.Add(Me.btnreset)
        Me.panelhead.Controls.Add(Me.btnapply)
        Me.panelhead.Controls.Add(Me.dtend)
        Me.panelhead.Controls.Add(Me.dtstart)
        Me.panelhead.Controls.Add(Me.Label2)
        Me.panelhead.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelhead.Location = New System.Drawing.Point(0, 32)
        Me.panelhead.Name = "panelhead"
        Me.panelhead.Size = New System.Drawing.Size(1115, 52)
        Me.panelhead.TabIndex = 1
        '
        'btnreset
        '
        Me.btnreset.ForeColor = System.Drawing.Color.Black
        Me.btnreset.Location = New System.Drawing.Point(362, 23)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(76, 25)
        Me.btnreset.TabIndex = 4
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnapply
        '
        Me.btnapply.ForeColor = System.Drawing.Color.Black
        Me.btnapply.Location = New System.Drawing.Point(282, 23)
        Me.btnapply.Name = "btnapply"
        Me.btnapply.Size = New System.Drawing.Size(76, 25)
        Me.btnapply.TabIndex = 3
        Me.btnapply.Text = "Apply"
        Me.btnapply.UseVisualStyleBackColor = True
        '
        'dtend
        '
        Me.dtend.CustomFormat = "dd/MM/yyyy"
        Me.dtend.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtend.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtend.Location = New System.Drawing.Point(159, 23)
        Me.dtend.Name = "dtend"
        Me.dtend.Size = New System.Drawing.Size(117, 25)
        Me.dtend.TabIndex = 2
        '
        'dtstart
        '
        Me.dtstart.CustomFormat = "dd/MM/yyyy"
        Me.dtstart.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtstart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtstart.Location = New System.Drawing.Point(35, 23)
        Me.dtstart.Name = "dtstart"
        Me.dtstart.Size = New System.Drawing.Size(118, 25)
        Me.dtstart.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date Range:"
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(790, 3)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(108, 23)
        Me.btnprint.TabIndex = 8
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Search Transaction:"
        '
        'txtsearch
        '
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.Location = New System.Drawing.Point(149, 6)
        Me.txtsearch.MaxLength = 10
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(178, 22)
        Me.txtsearch.TabIndex = 5
        '
        'panelbody
        '
        Me.panelbody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelbody.Controls.Add(Me.btnupdate)
        Me.panelbody.Controls.Add(Me.btnprintreceipt)
        Me.panelbody.Controls.Add(Me.btnprint)
        Me.panelbody.Controls.Add(Me.Label9)
        Me.panelbody.Controls.Add(Me.lbltotalprice)
        Me.panelbody.Controls.Add(Me.Label3)
        Me.panelbody.Controls.Add(Me.lbltotalproduct)
        Me.panelbody.Controls.Add(Me.Label8)
        Me.panelbody.Controls.Add(Me.txtsearch)
        Me.panelbody.Controls.Add(Me.lvproductlist)
        Me.panelbody.Controls.Add(Me.lvtransactionlist)
        Me.panelbody.Controls.Add(Me.panelbodyright)
        Me.panelbody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelbody.Location = New System.Drawing.Point(0, 84)
        Me.panelbody.Name = "panelbody"
        Me.panelbody.Size = New System.Drawing.Size(1115, 399)
        Me.panelbody.TabIndex = 2
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(676, 3)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(108, 23)
        Me.btnupdate.TabIndex = 13
        Me.btnupdate.Text = "Update Payment"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnprintreceipt
        '
        Me.btnprintreceipt.Location = New System.Drawing.Point(333, 6)
        Me.btnprintreceipt.Name = "btnprintreceipt"
        Me.btnprintreceipt.Size = New System.Drawing.Size(108, 23)
        Me.btnprintreceipt.TabIndex = 12
        Me.btnprintreceipt.Text = "Print Receipt"
        Me.btnprintreceipt.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(31, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(267, 21)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Select the transaction above to view items"
        '
        'lbltotalprice
        '
        Me.lbltotalprice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalprice.Location = New System.Drawing.Point(803, 370)
        Me.lbltotalprice.Name = "lbltotalprice"
        Me.lbltotalprice.Size = New System.Drawing.Size(95, 21)
        Me.lbltotalprice.TabIndex = 10
        Me.lbltotalprice.Text = "0"
        Me.lbltotalprice.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbltotalproduct
        '
        Me.lbltotalproduct.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalproduct.Location = New System.Drawing.Point(631, 370)
        Me.lbltotalproduct.Name = "lbltotalproduct"
        Me.lbltotalproduct.Size = New System.Drawing.Size(42, 21)
        Me.lbltotalproduct.TabIndex = 9
        Me.lbltotalproduct.Text = "0"
        Me.lbltotalproduct.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(539, 370)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 21)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Total"
        '
        'lvproductlist
        '
        Me.lvproductlist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25})
        Me.lvproductlist.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvproductlist.GridLines = True
        Me.lvproductlist.Location = New System.Drawing.Point(31, 252)
        Me.lvproductlist.Name = "lvproductlist"
        Me.lvproductlist.Size = New System.Drawing.Size(867, 115)
        Me.lvproductlist.TabIndex = 2
        Me.lvproductlist.UseCompatibleStateImageBehavior = False
        Me.lvproductlist.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Product ID"
        Me.ColumnHeader10.Width = 80
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Product Type"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Product Name"
        Me.ColumnHeader19.Width = 150
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Description"
        Me.ColumnHeader20.Width = 200
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Unit Price"
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Qty"
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Total"
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Dis %"
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Total Price"
        Me.ColumnHeader25.Width = 80
        '
        'lvtransactionlist
        '
        Me.lvtransactionlist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvtransactionlist.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvtransactionlist.FullRowSelect = True
        Me.lvtransactionlist.GridLines = True
        Me.lvtransactionlist.Location = New System.Drawing.Point(31, 30)
        Me.lvtransactionlist.Name = "lvtransactionlist"
        Me.lvtransactionlist.Size = New System.Drawing.Size(867, 171)
        Me.lvtransactionlist.TabIndex = 1
        Me.lvtransactionlist.UseCompatibleStateImageBehavior = False
        Me.lvtransactionlist.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Date"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Receipt No"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Issued By"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Total"
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Deposit"
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Balance"
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Payment Method"
        Me.ColumnHeader7.Width = 120
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Bank"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Transaction Type"
        Me.ColumnHeader9.Width = 120
        '
        'panelbodyright
        '
        Me.panelbodyright.BackColor = System.Drawing.Color.White
        Me.panelbodyright.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelbodyright.Controls.Add(Me.Panel7)
        Me.panelbodyright.Controls.Add(Me.Panel5)
        Me.panelbodyright.Controls.Add(Me.Panel3)
        Me.panelbodyright.Controls.Add(Me.Panel1)
        Me.panelbodyright.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelbodyright.Location = New System.Drawing.Point(904, 0)
        Me.panelbodyright.Name = "panelbodyright"
        Me.panelbodyright.Size = New System.Drawing.Size(209, 397)
        Me.panelbodyright.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lblothers)
        Me.Panel7.Controls.Add(Me.lblbaiduri)
        Me.Panel7.Controls.Add(Me.lblscb)
        Me.Panel7.Controls.Add(Me.lblbibd)
        Me.Panel7.Controls.Add(Me.lblcard)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 239)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(207, 167)
        Me.Panel7.TabIndex = 3
        '
        'lblothers
        '
        Me.lblothers.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblothers.Location = New System.Drawing.Point(96, 130)
        Me.lblothers.Name = "lblothers"
        Me.lblothers.Size = New System.Drawing.Size(108, 34)
        Me.lblothers.TabIndex = 8
        Me.lblothers.Text = "OTHERS"
        '
        'lblbaiduri
        '
        Me.lblbaiduri.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbaiduri.Location = New System.Drawing.Point(96, 93)
        Me.lblbaiduri.Name = "lblbaiduri"
        Me.lblbaiduri.Size = New System.Drawing.Size(109, 28)
        Me.lblbaiduri.TabIndex = 7
        Me.lblbaiduri.Text = "BAIDURI"
        '
        'lblscb
        '
        Me.lblscb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscb.Location = New System.Drawing.Point(3, 130)
        Me.lblscb.Name = "lblscb"
        Me.lblscb.Size = New System.Drawing.Size(87, 34)
        Me.lblscb.TabIndex = 6
        Me.lblscb.Text = "SCB"
        '
        'lblbibd
        '
        Me.lblbibd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbibd.Location = New System.Drawing.Point(3, 93)
        Me.lblbibd.Name = "lblbibd"
        Me.lblbibd.Size = New System.Drawing.Size(87, 28)
        Me.lblbibd.TabIndex = 5
        Me.lblbibd.Text = "BIBD"
        '
        'lblcard
        '
        Me.lblcard.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcard.Location = New System.Drawing.Point(78, 46)
        Me.lblcard.Name = "lblcard"
        Me.lblcard.Size = New System.Drawing.Size(44, 47)
        Me.lblcard.TabIndex = 4
        Me.lblcard.Text = "0"
        Me.lblcard.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(207, 25)
        Me.Panel8.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(55, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Card Payments"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblcash)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 166)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(207, 73)
        Me.Panel5.TabIndex = 2
        '
        'lblcash
        '
        Me.lblcash.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcash.Location = New System.Drawing.Point(25, 28)
        Me.lblcash.Name = "lblcash"
        Me.lblcash.Size = New System.Drawing.Size(155, 42)
        Me.lblcash.TabIndex = 3
        Me.lblcash.Text = "0"
        Me.lblcash.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(207, 25)
        Me.Panel6.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(56, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cash Payments"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.lbltotalbalance)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.lbltotaldeposit)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.lbltotalamount)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 72)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(207, 94)
        Me.Panel3.TabIndex = 1
        '
        'lbltotalamount
        '
        Me.lbltotalamount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalamount.Location = New System.Drawing.Point(100, 28)
        Me.lbltotalamount.Name = "lbltotalamount"
        Me.lbltotalamount.Size = New System.Drawing.Size(80, 22)
        Me.lbltotalamount.TabIndex = 2
        Me.lbltotalamount.Text = "0"
        Me.lbltotalamount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(207, 25)
        Me.Panel4.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(60, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Amount"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbltotaltransaction)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(207, 72)
        Me.Panel1.TabIndex = 0
        '
        'lbltotaltransaction
        '
        Me.lbltotaltransaction.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotaltransaction.Location = New System.Drawing.Point(20, 29)
        Me.lbltotaltransaction.Name = "lbltotaltransaction"
        Me.lbltotaltransaction.Size = New System.Drawing.Size(160, 32)
        Me.lbltotaltransaction.TabIndex = 1
        Me.lbltotaltransaction.Text = "0"
        Me.lbltotaltransaction.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(207, 25)
        Me.Panel2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(48, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total Transactions"
        '
        'bwload_transactions
        '
        Me.bwload_transactions.WorkerReportsProgress = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(5, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 17)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Total Amount"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(5, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 17)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Total Deposit"
        '
        'lbltotaldeposit
        '
        Me.lbltotaldeposit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotaldeposit.Location = New System.Drawing.Point(100, 47)
        Me.lbltotaldeposit.Name = "lbltotaldeposit"
        Me.lbltotaldeposit.Size = New System.Drawing.Size(80, 22)
        Me.lbltotaldeposit.TabIndex = 4
        Me.lbltotaldeposit.Text = "0"
        Me.lbltotaldeposit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(5, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 17)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Total Balance"
        '
        'lbltotalbalance
        '
        Me.lbltotalbalance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalbalance.Location = New System.Drawing.Point(100, 66)
        Me.lbltotalbalance.Name = "lbltotalbalance"
        Me.lbltotalbalance.Size = New System.Drawing.Size(80, 22)
        Me.lbltotalbalance.TabIndex = 6
        Me.lbltotalbalance.Text = "0"
        Me.lbltotalbalance.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmtransactionhistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1115, 483)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelbody)
        Me.Controls.Add(Me.panelhead)
        Me.Controls.Add(Me.paneltop)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmtransactionhistory"
        Me.Text = "frmtransactionhistory"
        Me.paneltop.ResumeLayout(False)
        Me.paneltop.PerformLayout()
        Me.panelhead.ResumeLayout(False)
        Me.panelhead.PerformLayout()
        Me.panelbody.ResumeLayout(False)
        Me.panelbody.PerformLayout()
        Me.panelbodyright.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents paneltop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents panelhead As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dtend As DateTimePicker
    Friend WithEvents dtstart As DateTimePicker
    Friend WithEvents panelbody As Panel
    Friend WithEvents panelbodyright As Panel
    Friend WithEvents btnapply As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lvtransactionlist As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents lvproductlist As ListView
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Friend WithEvents ColumnHeader21 As ColumnHeader
    Friend WithEvents ColumnHeader22 As ColumnHeader
    Friend WithEvents ColumnHeader23 As ColumnHeader
    Friend WithEvents ColumnHeader24 As ColumnHeader
    Friend WithEvents ColumnHeader25 As ColumnHeader
    Friend WithEvents bwload_transactions As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnreset As Button
    Friend WithEvents lbltotalamount As Label
    Friend WithEvents lbltotaltransaction As Label
    Friend WithEvents lblcard As Label
    Friend WithEvents lblcash As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbltotalprice As Label
    Friend WithEvents lbltotalproduct As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnprint As Button
    Friend WithEvents lblbibd As Label
    Friend WithEvents lblothers As Label
    Friend WithEvents lblbaiduri As Label
    Friend WithEvents lblscb As Label
    Friend WithEvents btnprintreceipt As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents lbltotalbalance As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbltotaldeposit As Label
    Friend WithEvents Label10 As Label
End Class
