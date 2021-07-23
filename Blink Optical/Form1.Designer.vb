<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmworkorder
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
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnrefreshcustomer = New System.Windows.Forms.Button()
        Me.btnnewcustomer = New System.Windows.Forms.Button()
        Me.lvcustomers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnsearchcustomer = New System.Windows.Forms.Button()
        Me.cbxsearchtype = New System.Windows.Forms.ComboBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbpreshistory = New Guna.UI.WinForms.GunaGroupBox()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnrefreshprescription = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnnewprescription = New System.Windows.Forms.Button()
        Me.lvprescriptions = New System.Windows.Forms.ListView()
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader31 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader32 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader33 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader34 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader35 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader36 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnapply = New System.Windows.Forms.Button()
        Me.cbxsort = New System.Windows.Forms.ComboBox()
        Me.gbpres = New Guna.UI.WinForms.GunaGroupBox()
        Me.txtpd_ht_l = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprescribed = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtremarks = New System.Windows.Forms.RichTextBox()
        Me.txtpd_ht_r = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtfr_ht = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtpd_l = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtfr_size = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtpd_r = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtadd_l = New System.Windows.Forms.TextBox()
        Me.txtaxis_l = New System.Windows.Forms.TextBox()
        Me.txtcyl_l = New System.Windows.Forms.TextBox()
        Me.txtsph_l = New System.Windows.Forms.TextBox()
        Me.txtadd_r = New System.Windows.Forms.TextBox()
        Me.txtaxis_r = New System.Windows.Forms.TextBox()
        Me.txtcyl_r = New System.Windows.Forms.TextBox()
        Me.txtsph_r = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaGroupBox2.SuspendLayout()
        Me.gbpreshistory.SuspendLayout()
        Me.gbpres.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.GunaGroupBox2.Controls.Add(Me.Label18)
        Me.GunaGroupBox2.Controls.Add(Me.Label17)
        Me.GunaGroupBox2.Controls.Add(Me.btnrefreshcustomer)
        Me.GunaGroupBox2.Controls.Add(Me.btnnewcustomer)
        Me.GunaGroupBox2.Controls.Add(Me.lvcustomers)
        Me.GunaGroupBox2.Controls.Add(Me.btnsearchcustomer)
        Me.GunaGroupBox2.Controls.Add(Me.cbxsearchtype)
        Me.GunaGroupBox2.Controls.Add(Me.txtsearch)
        Me.GunaGroupBox2.Controls.Add(Me.Label1)
        Me.GunaGroupBox2.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaGroupBox2.LineRight = 1
        Me.GunaGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(741, 259)
        Me.GunaGroupBox2.TabIndex = 3
        Me.GunaGroupBox2.Text = "Customer"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(465, 77)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(273, 13)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "*Click on the customer id to check prescription history"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(5, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(183, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "*Double click on customer id to edit"
        '
        'btnrefreshcustomer
        '
        Me.btnrefreshcustomer.ForeColor = System.Drawing.Color.Black
        Me.btnrefreshcustomer.Location = New System.Drawing.Point(291, 49)
        Me.btnrefreshcustomer.Name = "btnrefreshcustomer"
        Me.btnrefreshcustomer.Size = New System.Drawing.Size(60, 25)
        Me.btnrefreshcustomer.TabIndex = 9
        Me.btnrefreshcustomer.Text = "Refresh"
        Me.btnrefreshcustomer.UseVisualStyleBackColor = True
        '
        'btnnewcustomer
        '
        Me.btnnewcustomer.BackColor = System.Drawing.Color.Gray
        Me.btnnewcustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnewcustomer.ForeColor = System.Drawing.Color.White
        Me.btnnewcustomer.Location = New System.Drawing.Point(621, 35)
        Me.btnnewcustomer.Name = "btnnewcustomer"
        Me.btnnewcustomer.Size = New System.Drawing.Size(104, 38)
        Me.btnnewcustomer.TabIndex = 5
        Me.btnnewcustomer.Text = "+ New Customer"
        Me.btnnewcustomer.UseVisualStyleBackColor = False
        '
        'lvcustomers
        '
        Me.lvcustomers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader19})
        Me.lvcustomers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvcustomers.FullRowSelect = True
        Me.lvcustomers.GridLines = True
        Me.lvcustomers.HideSelection = False
        Me.lvcustomers.HoverSelection = True
        Me.lvcustomers.Location = New System.Drawing.Point(0, 98)
        Me.lvcustomers.Name = "lvcustomers"
        Me.lvcustomers.Size = New System.Drawing.Size(741, 161)
        Me.lvcustomers.TabIndex = 4
        Me.lvcustomers.UseCompatibleStateImageBehavior = False
        Me.lvcustomers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer ID"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "IC Number"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Name"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Mobile"
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Phone"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Gender"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Occupation"
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "DOB"
        Me.ColumnHeader9.Width = 80
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Email"
        Me.ColumnHeader10.Width = 120
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Address"
        Me.ColumnHeader19.Width = 200
        '
        'btnsearchcustomer
        '
        Me.btnsearchcustomer.ForeColor = System.Drawing.Color.Black
        Me.btnsearchcustomer.Location = New System.Drawing.Point(235, 49)
        Me.btnsearchcustomer.Name = "btnsearchcustomer"
        Me.btnsearchcustomer.Size = New System.Drawing.Size(50, 25)
        Me.btnsearchcustomer.TabIndex = 3
        Me.btnsearchcustomer.Text = "Search"
        Me.btnsearchcustomer.UseVisualStyleBackColor = True
        '
        'cbxsearchtype
        '
        Me.cbxsearchtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxsearchtype.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxsearchtype.ForeColor = System.Drawing.Color.Black
        Me.cbxsearchtype.FormattingEnabled = True
        Me.cbxsearchtype.Items.AddRange(New Object() {"IC", "Name", "Phone"})
        Me.cbxsearchtype.Location = New System.Drawing.Point(136, 50)
        Me.cbxsearchtype.Name = "cbxsearchtype"
        Me.cbxsearchtype.Size = New System.Drawing.Size(93, 23)
        Me.cbxsearchtype.TabIndex = 2
        '
        'txtsearch
        '
        Me.txtsearch.ForeColor = System.Drawing.Color.Black
        Me.txtsearch.Location = New System.Drawing.Point(5, 50)
        Me.txtsearch.MaxLength = 128
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(125, 22)
        Me.txtsearch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(2, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Customer"
        '
        'gbpreshistory
        '
        Me.gbpreshistory.BackColor = System.Drawing.Color.Transparent
        Me.gbpreshistory.BaseColor = System.Drawing.Color.White
        Me.gbpreshistory.BorderColor = System.Drawing.Color.Teal
        Me.gbpreshistory.Controls.Add(Me.btnprint)
        Me.gbpreshistory.Controls.Add(Me.Label19)
        Me.gbpreshistory.Controls.Add(Me.Label20)
        Me.gbpreshistory.Controls.Add(Me.btnrefreshprescription)
        Me.gbpreshistory.Controls.Add(Me.Label2)
        Me.gbpreshistory.Controls.Add(Me.btnnewprescription)
        Me.gbpreshistory.Controls.Add(Me.lvprescriptions)
        Me.gbpreshistory.Controls.Add(Me.btnapply)
        Me.gbpreshistory.Controls.Add(Me.cbxsort)
        Me.gbpreshistory.ForeColor = System.Drawing.Color.White
        Me.gbpreshistory.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gbpreshistory.LineRight = 1
        Me.gbpreshistory.Location = New System.Drawing.Point(0, 262)
        Me.gbpreshistory.Name = "gbpreshistory"
        Me.gbpreshistory.Size = New System.Drawing.Size(741, 222)
        Me.gbpreshistory.TabIndex = 5
        Me.gbpreshistory.Text = "Prescription Histpry"
        Me.gbpreshistory.TextLocation = New System.Drawing.Point(10, 8)
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.Black
        Me.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprint.ForeColor = System.Drawing.Color.White
        Me.btnprint.Image = Global.Optical_POS.My.Resources.Resources.print_48
        Me.btnprint.Location = New System.Drawing.Point(535, 37)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(60, 38)
        Me.btnprint.TabIndex = 14
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(542, 78)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(180, 13)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "*Click on the reading no to proceed"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(3, 75)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(177, 13)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "*Double click on reading no to edit"
        '
        'btnrefreshprescription
        '
        Me.btnrefreshprescription.ForeColor = System.Drawing.Color.Black
        Me.btnrefreshprescription.Location = New System.Drawing.Point(242, 44)
        Me.btnrefreshprescription.Name = "btnrefreshprescription"
        Me.btnrefreshprescription.Size = New System.Drawing.Size(54, 25)
        Me.btnrefreshprescription.TabIndex = 8
        Me.btnrefreshprescription.Text = "Refresh"
        Me.btnrefreshprescription.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Sort"
        '
        'btnnewprescription
        '
        Me.btnnewprescription.BackColor = System.Drawing.Color.DimGray
        Me.btnnewprescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnewprescription.ForeColor = System.Drawing.Color.White
        Me.btnnewprescription.Location = New System.Drawing.Point(601, 37)
        Me.btnnewprescription.Name = "btnnewprescription"
        Me.btnnewprescription.Size = New System.Drawing.Size(121, 38)
        Me.btnnewprescription.TabIndex = 6
        Me.btnnewprescription.Text = "+ New Prescription"
        Me.btnnewprescription.UseVisualStyleBackColor = False
        '
        'lvprescriptions
        '
        Me.lvprescriptions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader30, Me.ColumnHeader31, Me.ColumnHeader32, Me.ColumnHeader5, Me.ColumnHeader33, Me.ColumnHeader34, Me.ColumnHeader35, Me.ColumnHeader36})
        Me.lvprescriptions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvprescriptions.ForeColor = System.Drawing.Color.Black
        Me.lvprescriptions.FullRowSelect = True
        Me.lvprescriptions.GridLines = True
        Me.lvprescriptions.HideSelection = False
        Me.lvprescriptions.HoverSelection = True
        Me.lvprescriptions.Location = New System.Drawing.Point(0, 104)
        Me.lvprescriptions.Name = "lvprescriptions"
        Me.lvprescriptions.Size = New System.Drawing.Size(741, 118)
        Me.lvprescriptions.TabIndex = 4
        Me.lvprescriptions.UseCompatibleStateImageBehavior = False
        Me.lvprescriptions.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Reading No"
        Me.ColumnHeader20.Width = 80
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Date"
        Me.ColumnHeader21.Width = 80
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "SPH(R)"
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "CYL(R)"
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "AXIS(R)"
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "ADD(R)"
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "SPH(L)"
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "CYL(L)"
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "AXIS(L)"
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "AXIS(L)"
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "PD(R)"
        '
        'ColumnHeader31
        '
        Me.ColumnHeader31.Text = "PD(L)"
        '
        'ColumnHeader32
        '
        Me.ColumnHeader32.Text = "PT(HT_R)"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "PT(HT_L)"
        '
        'ColumnHeader33
        '
        Me.ColumnHeader33.Text = "FR_SIZE"
        '
        'ColumnHeader34
        '
        Me.ColumnHeader34.Text = "FR_HT"
        '
        'ColumnHeader35
        '
        Me.ColumnHeader35.Text = "Remarks"
        '
        'ColumnHeader36
        '
        Me.ColumnHeader36.Text = "Read By"
        '
        'btnapply
        '
        Me.btnapply.ForeColor = System.Drawing.Color.Black
        Me.btnapply.Location = New System.Drawing.Point(183, 44)
        Me.btnapply.Name = "btnapply"
        Me.btnapply.Size = New System.Drawing.Size(53, 25)
        Me.btnapply.TabIndex = 3
        Me.btnapply.Text = "Apply"
        Me.btnapply.UseVisualStyleBackColor = True
        '
        'cbxsort
        '
        Me.cbxsort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxsort.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxsort.ForeColor = System.Drawing.Color.Black
        Me.cbxsort.FormattingEnabled = True
        Me.cbxsort.Items.AddRange(New Object() {"ASC", "DESC"})
        Me.cbxsort.Location = New System.Drawing.Point(56, 44)
        Me.cbxsort.Name = "cbxsort"
        Me.cbxsort.Size = New System.Drawing.Size(121, 23)
        Me.cbxsort.TabIndex = 2
        '
        'gbpres
        '
        Me.gbpres.BackColor = System.Drawing.Color.Transparent
        Me.gbpres.BaseColor = System.Drawing.Color.White
        Me.gbpres.BorderColor = System.Drawing.Color.Teal
        Me.gbpres.Controls.Add(Me.txtpd_ht_l)
        Me.gbpres.Controls.Add(Me.Label3)
        Me.gbpres.Controls.Add(Me.txtprescribed)
        Me.gbpres.Controls.Add(Me.Label16)
        Me.gbpres.Controls.Add(Me.btnsave)
        Me.gbpres.Controls.Add(Me.Label15)
        Me.gbpres.Controls.Add(Me.txtremarks)
        Me.gbpres.Controls.Add(Me.txtpd_ht_r)
        Me.gbpres.Controls.Add(Me.Label14)
        Me.gbpres.Controls.Add(Me.txtfr_ht)
        Me.gbpres.Controls.Add(Me.Label13)
        Me.gbpres.Controls.Add(Me.txtpd_l)
        Me.gbpres.Controls.Add(Me.Label12)
        Me.gbpres.Controls.Add(Me.txtfr_size)
        Me.gbpres.Controls.Add(Me.Label11)
        Me.gbpres.Controls.Add(Me.txtpd_r)
        Me.gbpres.Controls.Add(Me.Label10)
        Me.gbpres.Controls.Add(Me.Label9)
        Me.gbpres.Controls.Add(Me.Label8)
        Me.gbpres.Controls.Add(Me.Label7)
        Me.gbpres.Controls.Add(Me.Label6)
        Me.gbpres.Controls.Add(Me.txtadd_l)
        Me.gbpres.Controls.Add(Me.txtaxis_l)
        Me.gbpres.Controls.Add(Me.txtcyl_l)
        Me.gbpres.Controls.Add(Me.txtsph_l)
        Me.gbpres.Controls.Add(Me.txtadd_r)
        Me.gbpres.Controls.Add(Me.txtaxis_r)
        Me.gbpres.Controls.Add(Me.txtcyl_r)
        Me.gbpres.Controls.Add(Me.txtsph_r)
        Me.gbpres.Controls.Add(Me.Label5)
        Me.gbpres.Controls.Add(Me.Label4)
        Me.gbpres.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbpres.ForeColor = System.Drawing.Color.White
        Me.gbpres.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gbpres.Location = New System.Drawing.Point(747, 0)
        Me.gbpres.Name = "gbpres"
        Me.gbpres.Size = New System.Drawing.Size(352, 486)
        Me.gbpres.TabIndex = 7
        Me.gbpres.Text = "Prescriptions"
        Me.gbpres.TextLocation = New System.Drawing.Point(10, 8)
        '
        'txtpd_ht_l
        '
        Me.txtpd_ht_l.Enabled = False
        Me.txtpd_ht_l.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpd_ht_l.ForeColor = System.Drawing.Color.Black
        Me.txtpd_ht_l.Location = New System.Drawing.Point(196, 186)
        Me.txtpd_ht_l.MaxLength = 10
        Me.txtpd_ht_l.Name = "txtpd_ht_l"
        Me.txtpd_ht_l.Size = New System.Drawing.Size(52, 25)
        Me.txtpd_ht_l.TabIndex = 30
        Me.txtpd_ht_l.Text = "0.0"
        Me.txtpd_ht_l.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(138, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "HT-L"
        '
        'txtprescribed
        '
        Me.txtprescribed.Enabled = False
        Me.txtprescribed.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprescribed.ForeColor = System.Drawing.Color.Black
        Me.txtprescribed.Location = New System.Drawing.Point(100, 371)
        Me.txtprescribed.MaxLength = 64
        Me.txtprescribed.Name = "txtprescribed"
        Me.txtprescribed.Size = New System.Drawing.Size(234, 25)
        Me.txtprescribed.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(14, 374)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 17)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Prescribed By"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.DimGray
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(17, 425)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(317, 41)
        Me.btnsave.TabIndex = 26
        Me.btnsave.Text = "Proceed To Payment"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(14, 266)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 17)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Remarks"
        '
        'txtremarks
        '
        Me.txtremarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtremarks.Enabled = False
        Me.txtremarks.ForeColor = System.Drawing.Color.Black
        Me.txtremarks.Location = New System.Drawing.Point(17, 288)
        Me.txtremarks.MaxLength = 512
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(317, 69)
        Me.txtremarks.TabIndex = 24
        Me.txtremarks.Text = ""
        '
        'txtpd_ht_r
        '
        Me.txtpd_ht_r.Enabled = False
        Me.txtpd_ht_r.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpd_ht_r.ForeColor = System.Drawing.Color.Black
        Me.txtpd_ht_r.Location = New System.Drawing.Point(70, 185)
        Me.txtpd_ht_r.MaxLength = 10
        Me.txtpd_ht_r.Name = "txtpd_ht_r"
        Me.txtpd_ht_r.Size = New System.Drawing.Size(52, 25)
        Me.txtpd_ht_r.TabIndex = 23
        Me.txtpd_ht_r.Text = "0.0"
        Me.txtpd_ht_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(15, 189)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 17)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "HT-R"
        '
        'txtfr_ht
        '
        Me.txtfr_ht.Enabled = False
        Me.txtfr_ht.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfr_ht.ForeColor = System.Drawing.Color.Black
        Me.txtfr_ht.Location = New System.Drawing.Point(195, 220)
        Me.txtfr_ht.MaxLength = 10
        Me.txtfr_ht.Name = "txtfr_ht"
        Me.txtfr_ht.Size = New System.Drawing.Size(52, 25)
        Me.txtfr_ht.TabIndex = 21
        Me.txtfr_ht.Text = "0.0"
        Me.txtfr_ht.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(139, 224)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 17)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "FR-HT"
        '
        'txtpd_l
        '
        Me.txtpd_l.Enabled = False
        Me.txtpd_l.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpd_l.ForeColor = System.Drawing.Color.Black
        Me.txtpd_l.Location = New System.Drawing.Point(195, 149)
        Me.txtpd_l.MaxLength = 10
        Me.txtpd_l.Name = "txtpd_l"
        Me.txtpd_l.Size = New System.Drawing.Size(52, 25)
        Me.txtpd_l.TabIndex = 19
        Me.txtpd_l.Text = "0.0"
        Me.txtpd_l.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(140, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 17)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "PD-L"
        '
        'txtfr_size
        '
        Me.txtfr_size.Enabled = False
        Me.txtfr_size.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfr_size.ForeColor = System.Drawing.Color.Black
        Me.txtfr_size.Location = New System.Drawing.Point(70, 220)
        Me.txtfr_size.MaxLength = 10
        Me.txtfr_size.Name = "txtfr_size"
        Me.txtfr_size.Size = New System.Drawing.Size(52, 25)
        Me.txtfr_size.TabIndex = 17
        Me.txtfr_size.Text = "0.0"
        Me.txtfr_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(14, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 17)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "FR-SIZE"
        '
        'txtpd_r
        '
        Me.txtpd_r.Enabled = False
        Me.txtpd_r.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpd_r.ForeColor = System.Drawing.Color.Black
        Me.txtpd_r.Location = New System.Drawing.Point(70, 149)
        Me.txtpd_r.MaxLength = 10
        Me.txtpd_r.Name = "txtpd_r"
        Me.txtpd_r.Size = New System.Drawing.Size(52, 25)
        Me.txtpd_r.TabIndex = 15
        Me.txtpd_r.Text = "0.0"
        Me.txtpd_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(15, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "PD-R"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(278, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "ADD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(211, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "AXIS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(148, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "CYL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(80, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "SPH"
        '
        'txtadd_l
        '
        Me.txtadd_l.Enabled = False
        Me.txtadd_l.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadd_l.ForeColor = System.Drawing.Color.Black
        Me.txtadd_l.Location = New System.Drawing.Point(271, 96)
        Me.txtadd_l.MaxLength = 10
        Me.txtadd_l.Name = "txtadd_l"
        Me.txtadd_l.Size = New System.Drawing.Size(52, 25)
        Me.txtadd_l.TabIndex = 9
        Me.txtadd_l.Text = "0.0"
        Me.txtadd_l.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtaxis_l
        '
        Me.txtaxis_l.Enabled = False
        Me.txtaxis_l.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaxis_l.ForeColor = System.Drawing.Color.Black
        Me.txtaxis_l.Location = New System.Drawing.Point(204, 96)
        Me.txtaxis_l.MaxLength = 10
        Me.txtaxis_l.Name = "txtaxis_l"
        Me.txtaxis_l.Size = New System.Drawing.Size(52, 25)
        Me.txtaxis_l.TabIndex = 8
        Me.txtaxis_l.Text = "0.0"
        Me.txtaxis_l.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcyl_l
        '
        Me.txtcyl_l.Enabled = False
        Me.txtcyl_l.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcyl_l.ForeColor = System.Drawing.Color.Black
        Me.txtcyl_l.Location = New System.Drawing.Point(137, 96)
        Me.txtcyl_l.MaxLength = 10
        Me.txtcyl_l.Name = "txtcyl_l"
        Me.txtcyl_l.Size = New System.Drawing.Size(52, 25)
        Me.txtcyl_l.TabIndex = 7
        Me.txtcyl_l.Text = "0.0"
        Me.txtcyl_l.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsph_l
        '
        Me.txtsph_l.Enabled = False
        Me.txtsph_l.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsph_l.ForeColor = System.Drawing.Color.Black
        Me.txtsph_l.Location = New System.Drawing.Point(70, 96)
        Me.txtsph_l.MaxLength = 10
        Me.txtsph_l.Name = "txtsph_l"
        Me.txtsph_l.Size = New System.Drawing.Size(52, 25)
        Me.txtsph_l.TabIndex = 6
        Me.txtsph_l.Text = "0.0"
        Me.txtsph_l.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtadd_r
        '
        Me.txtadd_r.Enabled = False
        Me.txtadd_r.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadd_r.ForeColor = System.Drawing.Color.Black
        Me.txtadd_r.Location = New System.Drawing.Point(271, 60)
        Me.txtadd_r.MaxLength = 10
        Me.txtadd_r.Name = "txtadd_r"
        Me.txtadd_r.Size = New System.Drawing.Size(52, 25)
        Me.txtadd_r.TabIndex = 5
        Me.txtadd_r.Text = "0.0"
        Me.txtadd_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtaxis_r
        '
        Me.txtaxis_r.Enabled = False
        Me.txtaxis_r.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaxis_r.ForeColor = System.Drawing.Color.Black
        Me.txtaxis_r.Location = New System.Drawing.Point(204, 60)
        Me.txtaxis_r.MaxLength = 10
        Me.txtaxis_r.Name = "txtaxis_r"
        Me.txtaxis_r.Size = New System.Drawing.Size(52, 25)
        Me.txtaxis_r.TabIndex = 4
        Me.txtaxis_r.Text = "0.0"
        Me.txtaxis_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcyl_r
        '
        Me.txtcyl_r.Enabled = False
        Me.txtcyl_r.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcyl_r.ForeColor = System.Drawing.Color.Black
        Me.txtcyl_r.Location = New System.Drawing.Point(137, 60)
        Me.txtcyl_r.MaxLength = 10
        Me.txtcyl_r.Name = "txtcyl_r"
        Me.txtcyl_r.Size = New System.Drawing.Size(52, 25)
        Me.txtcyl_r.TabIndex = 3
        Me.txtcyl_r.Text = "0.0"
        Me.txtcyl_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsph_r
        '
        Me.txtsph_r.Enabled = False
        Me.txtsph_r.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsph_r.ForeColor = System.Drawing.Color.Black
        Me.txtsph_r.Location = New System.Drawing.Point(70, 60)
        Me.txtsph_r.MaxLength = 10
        Me.txtsph_r.Name = "txtsph_r"
        Me.txtsph_r.Size = New System.Drawing.Size(52, 25)
        Me.txtsph_r.TabIndex = 2
        Me.txtsph_r.Text = "0.0"
        Me.txtsph_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Left"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Right"
        '
        'frmworkorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1099, 486)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbpres)
        Me.Controls.Add(Me.gbpreshistory)
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmworkorder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Optical Shop POS"
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        Me.gbpreshistory.ResumeLayout(False)
        Me.gbpreshistory.PerformLayout()
        Me.gbpres.ResumeLayout(False)
        Me.gbpres.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxsearchtype As ComboBox
    Friend WithEvents lvcustomers As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents btnsearchcustomer As Button
    Friend WithEvents btnnewcustomer As Button
    Friend WithEvents gbpreshistory As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnnewprescription As Button
    Friend WithEvents lvprescriptions As ListView
    Friend WithEvents btnapply As Button
    Friend WithEvents cbxsort As ComboBox
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents btnrefreshcustomer As Button
    Friend WithEvents btnrefreshprescription As Button
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Friend WithEvents ColumnHeader21 As ColumnHeader
    Friend WithEvents ColumnHeader22 As ColumnHeader
    Friend WithEvents ColumnHeader23 As ColumnHeader
    Friend WithEvents ColumnHeader24 As ColumnHeader
    Friend WithEvents ColumnHeader25 As ColumnHeader
    Friend WithEvents ColumnHeader26 As ColumnHeader
    Friend WithEvents ColumnHeader27 As ColumnHeader
    Friend WithEvents ColumnHeader28 As ColumnHeader
    Friend WithEvents ColumnHeader29 As ColumnHeader
    Friend WithEvents ColumnHeader30 As ColumnHeader
    Friend WithEvents ColumnHeader31 As ColumnHeader
    Friend WithEvents ColumnHeader32 As ColumnHeader
    Friend WithEvents ColumnHeader33 As ColumnHeader
    Friend WithEvents ColumnHeader34 As ColumnHeader
    Friend WithEvents ColumnHeader35 As ColumnHeader
    Friend WithEvents ColumnHeader36 As ColumnHeader
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents gbpres As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents txtprescribed As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtremarks As RichTextBox
    Friend WithEvents txtpd_ht_r As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtfr_ht As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtpd_l As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtfr_size As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtpd_r As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtadd_l As TextBox
    Friend WithEvents txtaxis_l As TextBox
    Friend WithEvents txtcyl_l As TextBox
    Friend WithEvents txtsph_l As TextBox
    Friend WithEvents txtadd_r As TextBox
    Friend WithEvents txtaxis_r As TextBox
    Friend WithEvents txtcyl_r As TextBox
    Friend WithEvents txtsph_r As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpd_ht_l As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents btnprint As Button
End Class
