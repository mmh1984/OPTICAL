<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcustomerrecord
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
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvcustomers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.panelbody = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnviewreminder = New System.Windows.Forms.Button()
        Me.lblreminder = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnprinttransaction = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbltransaction = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lvtransactions = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.panelbodyright = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbltotalcustomer = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bwload_customers = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelhead = New System.Windows.Forms.Panel()
        Me.btndeletecustomer = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnprintcustomers = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.paneltop = New System.Windows.Forms.Panel()
        Me.bwload_transactions = New System.ComponentModel.BackgroundWorker()
        Me.panelbody.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.panelbodyright.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panelhead.SuspendLayout()
        Me.paneltop.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Occupation"
        Me.ColumnHeader7.Width = 120
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "DOB"
        Me.ColumnHeader9.Width = 120
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Email"
        '
        'lvcustomers
        '
        Me.lvcustomers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader12})
        Me.lvcustomers.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvcustomers.FullRowSelect = True
        Me.lvcustomers.GridLines = True
        Me.lvcustomers.Location = New System.Drawing.Point(9, 14)
        Me.lvcustomers.Name = "lvcustomers"
        Me.lvcustomers.Size = New System.Drawing.Size(933, 214)
        Me.lvcustomers.TabIndex = 1
        Me.lvcustomers.UseCompatibleStateImageBehavior = False
        Me.lvcustomers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "IC"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Name"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Address"
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Mobile"
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Gender"
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Phone"
        '
        'panelbody
        '
        Me.panelbody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelbody.Controls.Add(Me.Panel9)
        Me.panelbody.Controls.Add(Me.btnprinttransaction)
        Me.panelbody.Controls.Add(Me.Panel6)
        Me.panelbody.Controls.Add(Me.Panel3)
        Me.panelbody.Controls.Add(Me.Label9)
        Me.panelbody.Controls.Add(Me.lvtransactions)
        Me.panelbody.Controls.Add(Me.panelbodyright)
        Me.panelbody.Controls.Add(Me.lvcustomers)
        Me.panelbody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelbody.Location = New System.Drawing.Point(0, 64)
        Me.panelbody.Name = "panelbody"
        Me.panelbody.Size = New System.Drawing.Size(1115, 419)
        Me.panelbody.TabIndex = 8
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.btnviewreminder)
        Me.Panel9.Controls.Add(Me.lblreminder)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Location = New System.Drawing.Point(947, 14)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(160, 115)
        Me.Panel9.TabIndex = 22
        '
        'btnviewreminder
        '
        Me.btnviewreminder.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnviewreminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnviewreminder.ForeColor = System.Drawing.Color.White
        Me.btnviewreminder.Location = New System.Drawing.Point(32, 79)
        Me.btnviewreminder.Name = "btnviewreminder"
        Me.btnviewreminder.Size = New System.Drawing.Size(95, 23)
        Me.btnviewreminder.TabIndex = 23
        Me.btnviewreminder.Text = "VIEW"
        Me.btnviewreminder.UseVisualStyleBackColor = False
        '
        'lblreminder
        '
        Me.lblreminder.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreminder.Location = New System.Drawing.Point(12, 30)
        Me.lblreminder.Name = "lblreminder"
        Me.lblreminder.Size = New System.Drawing.Size(140, 38)
        Me.lblreminder.TabIndex = 2
        Me.lblreminder.Text = "0"
        Me.lblreminder.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label6)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(158, 25)
        Me.Panel10.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(35, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Call Reminder"
        '
        'btnprinttransaction
        '
        Me.btnprinttransaction.Location = New System.Drawing.Point(789, 241)
        Me.btnprinttransaction.Name = "btnprinttransaction"
        Me.btnprinttransaction.Size = New System.Drawing.Size(153, 23)
        Me.btnprinttransaction.TabIndex = 20
        Me.btnprinttransaction.Text = "Print Customer Transaction"
        Me.btnprinttransaction.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Location = New System.Drawing.Point(952, 332)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(159, 74)
        Me.Panel6.TabIndex = 19
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lbltotal)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(157, 73)
        Me.Panel7.TabIndex = 0
        '
        'lbltotal
        '
        Me.lbltotal.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(8, 28)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(146, 44)
        Me.lbltotal.TabIndex = 1
        Me.lbltotal.Text = "0"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(157, 25)
        Me.Panel8.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(27, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total Amount"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(951, 253)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(159, 74)
        Me.Panel3.TabIndex = 18
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lbltransaction)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(157, 73)
        Me.Panel4.TabIndex = 0
        '
        'lbltransaction
        '
        Me.lbltransaction.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltransaction.Location = New System.Drawing.Point(8, 28)
        Me.lbltransaction.Name = "lbltransaction"
        Me.lbltransaction.Size = New System.Drawing.Size(146, 44)
        Me.lbltransaction.TabIndex = 1
        Me.lbltransaction.Text = "0"
        Me.lbltransaction.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(157, 25)
        Me.Panel5.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(20, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Transactions"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(16, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(300, 21)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Select the customer above to view transaction history"
        '
        'lvtransactions
        '
        Me.lvtransactions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24})
        Me.lvtransactions.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvtransactions.GridLines = True
        Me.lvtransactions.Location = New System.Drawing.Point(9, 270)
        Me.lvtransactions.Name = "lvtransactions"
        Me.lvtransactions.Size = New System.Drawing.Size(933, 136)
        Me.lvtransactions.TabIndex = 13
        Me.lvtransactions.UseCompatibleStateImageBehavior = False
        Me.lvtransactions.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Receipt No"
        Me.ColumnHeader10.Width = 80
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Date"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Issued By"
        Me.ColumnHeader19.Width = 150
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Total Amount"
        Me.ColumnHeader20.Width = 90
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Deposit"
        Me.ColumnHeader21.Width = 80
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Balance"
        Me.ColumnHeader22.Width = 80
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Payment Method"
        Me.ColumnHeader23.Width = 120
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Bank"
        Me.ColumnHeader24.Width = 80
        '
        'panelbodyright
        '
        Me.panelbodyright.BackColor = System.Drawing.Color.White
        Me.panelbodyright.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelbodyright.Controls.Add(Me.Panel1)
        Me.panelbodyright.Location = New System.Drawing.Point(949, 165)
        Me.panelbodyright.Name = "panelbodyright"
        Me.panelbodyright.Size = New System.Drawing.Size(162, 82)
        Me.panelbodyright.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbltotalcustomer)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 83)
        Me.Panel1.TabIndex = 1
        '
        'lbltotalcustomer
        '
        Me.lbltotalcustomer.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalcustomer.Location = New System.Drawing.Point(11, 28)
        Me.lbltotalcustomer.Name = "lbltotalcustomer"
        Me.lbltotalcustomer.Size = New System.Drawing.Size(140, 44)
        Me.lbltotalcustomer.TabIndex = 1
        Me.lbltotalcustomer.Text = "0"
        Me.lbltotalcustomer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(160, 25)
        Me.Panel2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(26, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total Customers"
        '
        'bwload_customers
        '
        Me.bwload_customers.WorkerReportsProgress = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Record"
        '
        'panelhead
        '
        Me.panelhead.Controls.Add(Me.btndeletecustomer)
        Me.panelhead.Controls.Add(Me.btnreset)
        Me.panelhead.Controls.Add(Me.btnprintcustomers)
        Me.panelhead.Controls.Add(Me.Label3)
        Me.panelhead.Controls.Add(Me.txtsearch)
        Me.panelhead.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelhead.Location = New System.Drawing.Point(0, 32)
        Me.panelhead.Name = "panelhead"
        Me.panelhead.Size = New System.Drawing.Size(1115, 32)
        Me.panelhead.TabIndex = 7
        '
        'btndeletecustomer
        '
        Me.btndeletecustomer.BackColor = System.Drawing.Color.Maroon
        Me.btndeletecustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeletecustomer.ForeColor = System.Drawing.Color.White
        Me.btndeletecustomer.Location = New System.Drawing.Point(663, 6)
        Me.btndeletecustomer.Name = "btndeletecustomer"
        Me.btndeletecustomer.Size = New System.Drawing.Size(120, 23)
        Me.btndeletecustomer.TabIndex = 10
        Me.btndeletecustomer.Text = "Delete Customer"
        Me.btndeletecustomer.UseVisualStyleBackColor = False
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(323, 6)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(72, 23)
        Me.btnreset.TabIndex = 9
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnprintcustomers
        '
        Me.btnprintcustomers.Location = New System.Drawing.Point(791, 6)
        Me.btnprintcustomers.Name = "btnprintcustomers"
        Me.btnprintcustomers.Size = New System.Drawing.Size(153, 23)
        Me.btnprintcustomers.TabIndex = 8
        Me.btnprintcustomers.Text = "Print Customer Record"
        Me.btnprintcustomers.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Search Customer:"
        '
        'txtsearch
        '
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.Location = New System.Drawing.Point(139, 6)
        Me.txtsearch.MaxLength = 128
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(178, 22)
        Me.txtsearch.TabIndex = 5
        '
        'paneltop
        '
        Me.paneltop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.paneltop.Controls.Add(Me.Label1)
        Me.paneltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.paneltop.Location = New System.Drawing.Point(0, 0)
        Me.paneltop.Name = "paneltop"
        Me.paneltop.Size = New System.Drawing.Size(1115, 32)
        Me.paneltop.TabIndex = 6
        '
        'bwload_transactions
        '
        Me.bwload_transactions.WorkerReportsProgress = True
        '
        'frmcustomerrecord
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
        Me.Name = "frmcustomerrecord"
        Me.Text = "frmcustomerrecord"
        Me.panelbody.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.panelbodyright.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelhead.ResumeLayout(False)
        Me.panelhead.PerformLayout()
        Me.paneltop.ResumeLayout(False)
        Me.paneltop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents lvcustomers As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents panelbody As Panel
    Friend WithEvents bwload_customers As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents panelhead As Panel
    Friend WithEvents btnprintcustomers As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents paneltop As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbltransaction As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lvtransactions As ListView
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Friend WithEvents ColumnHeader21 As ColumnHeader
    Friend WithEvents ColumnHeader22 As ColumnHeader
    Friend WithEvents ColumnHeader23 As ColumnHeader
    Friend WithEvents ColumnHeader24 As ColumnHeader
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lbltotal As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents panelbodyright As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbltotalcustomer As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents bwload_transactions As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnprinttransaction As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents btndeletecustomer As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btnviewreminder As Button
    Friend WithEvents lblreminder As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label6 As Label
End Class
