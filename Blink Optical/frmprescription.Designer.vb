<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmprescription
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
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.txtpd_ht_l = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.btnclose = New System.Windows.Forms.Button()
        Me.txtprescribed = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtremarks = New System.Windows.Forms.RichTextBox()
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
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lbloccupation = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblphone = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblmobile = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblic = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GunaGroupBox1.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Teal
        Me.GunaGroupBox1.Controls.Add(Me.txtpd_ht_l)
        Me.GunaGroupBox1.Controls.Add(Me.Label3)
        Me.GunaGroupBox1.Controls.Add(Me.txtpd_ht_r)
        Me.GunaGroupBox1.Controls.Add(Me.Label14)
        Me.GunaGroupBox1.Controls.Add(Me.txtfr_ht)
        Me.GunaGroupBox1.Controls.Add(Me.Label13)
        Me.GunaGroupBox1.Controls.Add(Me.txtpd_l)
        Me.GunaGroupBox1.Controls.Add(Me.Label12)
        Me.GunaGroupBox1.Controls.Add(Me.txtfr_size)
        Me.GunaGroupBox1.Controls.Add(Me.Label11)
        Me.GunaGroupBox1.Controls.Add(Me.txtpd_r)
        Me.GunaGroupBox1.Controls.Add(Me.Label10)
        Me.GunaGroupBox1.Controls.Add(Me.btnclose)
        Me.GunaGroupBox1.Controls.Add(Me.txtprescribed)
        Me.GunaGroupBox1.Controls.Add(Me.Label16)
        Me.GunaGroupBox1.Controls.Add(Me.btnsave)
        Me.GunaGroupBox1.Controls.Add(Me.Label15)
        Me.GunaGroupBox1.Controls.Add(Me.txtremarks)
        Me.GunaGroupBox1.Controls.Add(Me.Label9)
        Me.GunaGroupBox1.Controls.Add(Me.Label8)
        Me.GunaGroupBox1.Controls.Add(Me.Label7)
        Me.GunaGroupBox1.Controls.Add(Me.Label6)
        Me.GunaGroupBox1.Controls.Add(Me.txtadd_l)
        Me.GunaGroupBox1.Controls.Add(Me.txtaxis_l)
        Me.GunaGroupBox1.Controls.Add(Me.txtcyl_l)
        Me.GunaGroupBox1.Controls.Add(Me.txtsph_l)
        Me.GunaGroupBox1.Controls.Add(Me.txtadd_r)
        Me.GunaGroupBox1.Controls.Add(Me.txtaxis_r)
        Me.GunaGroupBox1.Controls.Add(Me.txtcyl_r)
        Me.GunaGroupBox1.Controls.Add(Me.txtsph_r)
        Me.GunaGroupBox1.Controls.Add(Me.Label5)
        Me.GunaGroupBox1.Controls.Add(Me.Label4)
        Me.GunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaGroupBox1.Location = New System.Drawing.Point(394, 0)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(371, 463)
        Me.GunaGroupBox1.TabIndex = 6
        Me.GunaGroupBox1.Text = "Prescriptions"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'txtpd_ht_l
        '
        Me.txtpd_ht_l.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpd_ht_l.ForeColor = System.Drawing.Color.Black
        Me.txtpd_ht_l.Location = New System.Drawing.Point(196, 189)
        Me.txtpd_ht_l.MaxLength = 10
        Me.txtpd_ht_l.Name = "txtpd_ht_l"
        Me.txtpd_ht_l.Size = New System.Drawing.Size(52, 25)
        Me.txtpd_ht_l.TabIndex = 13
        Me.txtpd_ht_l.Text = "0.0"
        Me.txtpd_ht_l.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(138, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "HT-L"
        '
        'txtpd_ht_r
        '
        Me.txtpd_ht_r.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpd_ht_r.ForeColor = System.Drawing.Color.Black
        Me.txtpd_ht_r.Location = New System.Drawing.Point(70, 188)
        Me.txtpd_ht_r.MaxLength = 10
        Me.txtpd_ht_r.Name = "txtpd_ht_r"
        Me.txtpd_ht_r.Size = New System.Drawing.Size(52, 25)
        Me.txtpd_ht_r.TabIndex = 12
        Me.txtpd_ht_r.Text = "0.0"
        Me.txtpd_ht_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(15, 192)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 17)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "HT-R"
        '
        'txtfr_ht
        '
        Me.txtfr_ht.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfr_ht.ForeColor = System.Drawing.Color.Black
        Me.txtfr_ht.Location = New System.Drawing.Point(195, 223)
        Me.txtfr_ht.MaxLength = 10
        Me.txtfr_ht.Name = "txtfr_ht"
        Me.txtfr_ht.Size = New System.Drawing.Size(52, 25)
        Me.txtfr_ht.TabIndex = 15
        Me.txtfr_ht.Text = "0.0"
        Me.txtfr_ht.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(139, 227)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 17)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "FR-HT"
        '
        'txtpd_l
        '
        Me.txtpd_l.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpd_l.ForeColor = System.Drawing.Color.Black
        Me.txtpd_l.Location = New System.Drawing.Point(195, 152)
        Me.txtpd_l.MaxLength = 10
        Me.txtpd_l.Name = "txtpd_l"
        Me.txtpd_l.Size = New System.Drawing.Size(52, 25)
        Me.txtpd_l.TabIndex = 11
        Me.txtpd_l.Text = "0.0"
        Me.txtpd_l.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(140, 156)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 17)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "PD-L"
        '
        'txtfr_size
        '
        Me.txtfr_size.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfr_size.ForeColor = System.Drawing.Color.Black
        Me.txtfr_size.Location = New System.Drawing.Point(70, 223)
        Me.txtfr_size.MaxLength = 10
        Me.txtfr_size.Name = "txtfr_size"
        Me.txtfr_size.Size = New System.Drawing.Size(52, 25)
        Me.txtfr_size.TabIndex = 14
        Me.txtfr_size.Text = "0.0"
        Me.txtfr_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(14, 227)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 17)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "FR-SIZE"
        '
        'txtpd_r
        '
        Me.txtpd_r.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpd_r.ForeColor = System.Drawing.Color.Black
        Me.txtpd_r.Location = New System.Drawing.Point(70, 152)
        Me.txtpd_r.MaxLength = 10
        Me.txtpd_r.Name = "txtpd_r"
        Me.txtpd_r.Size = New System.Drawing.Size(52, 25)
        Me.txtpd_r.TabIndex = 10
        Me.txtpd_r.Text = "0.0"
        Me.txtpd_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(15, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 17)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "PD-R"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(185, 415)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(107, 41)
        Me.btnclose.TabIndex = 19
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'txtprescribed
        '
        Me.txtprescribed.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprescribed.ForeColor = System.Drawing.Color.Black
        Me.txtprescribed.Location = New System.Drawing.Point(103, 371)
        Me.txtprescribed.MaxLength = 64
        Me.txtprescribed.Name = "txtprescribed"
        Me.txtprescribed.Size = New System.Drawing.Size(229, 25)
        Me.txtprescribed.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(14, 374)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 17)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Prescribed by"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(82, 415)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(97, 41)
        Me.btnsave.TabIndex = 18
        Me.btnsave.Text = "Save"
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
        Me.txtremarks.ForeColor = System.Drawing.Color.Black
        Me.txtremarks.Location = New System.Drawing.Point(17, 288)
        Me.txtremarks.MaxLength = 512
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(317, 69)
        Me.txtremarks.TabIndex = 16
        Me.txtremarks.Text = ""
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
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Teal
        Me.GunaGroupBox2.Controls.Add(Me.lblemail)
        Me.GunaGroupBox2.Controls.Add(Me.Label31)
        Me.GunaGroupBox2.Controls.Add(Me.lbloccupation)
        Me.GunaGroupBox2.Controls.Add(Me.Label29)
        Me.GunaGroupBox2.Controls.Add(Me.lbldob)
        Me.GunaGroupBox2.Controls.Add(Me.Label27)
        Me.GunaGroupBox2.Controls.Add(Me.lblgender)
        Me.GunaGroupBox2.Controls.Add(Me.Label25)
        Me.GunaGroupBox2.Controls.Add(Me.lblphone)
        Me.GunaGroupBox2.Controls.Add(Me.Label23)
        Me.GunaGroupBox2.Controls.Add(Me.lblmobile)
        Me.GunaGroupBox2.Controls.Add(Me.Label21)
        Me.GunaGroupBox2.Controls.Add(Me.lbladdress)
        Me.GunaGroupBox2.Controls.Add(Me.Label19)
        Me.GunaGroupBox2.Controls.Add(Me.lblname)
        Me.GunaGroupBox2.Controls.Add(Me.Label17)
        Me.GunaGroupBox2.Controls.Add(Me.lblic)
        Me.GunaGroupBox2.Controls.Add(Me.Label1)
        Me.GunaGroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaGroupBox2.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaGroupBox2.LineRight = 1
        Me.GunaGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(394, 463)
        Me.GunaGroupBox2.TabIndex = 7
        Me.GunaGroupBox2.Text = "Customer Details"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.ForeColor = System.Drawing.Color.Black
        Me.lblemail.Location = New System.Drawing.Point(125, 357)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(89, 18)
        Me.lblemail.TabIndex = 17
        Me.lblemail.Text = "IC-Number"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.DimGray
        Me.Label31.Location = New System.Drawing.Point(24, 357)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(55, 18)
        Me.Label31.TabIndex = 16
        Me.Label31.Text = "Email:"
        '
        'lbloccupation
        '
        Me.lbloccupation.AutoSize = True
        Me.lbloccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloccupation.ForeColor = System.Drawing.Color.Black
        Me.lbloccupation.Location = New System.Drawing.Point(125, 266)
        Me.lbloccupation.Name = "lbloccupation"
        Me.lbloccupation.Size = New System.Drawing.Size(89, 18)
        Me.lbloccupation.TabIndex = 15
        Me.lbloccupation.Text = "IC-Number"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.DimGray
        Me.Label29.Location = New System.Drawing.Point(24, 266)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(99, 18)
        Me.Label29.TabIndex = 14
        Me.Label29.Text = "Occupation:"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldob.ForeColor = System.Drawing.Color.Black
        Me.lbldob.Location = New System.Drawing.Point(125, 327)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(89, 18)
        Me.lbldob.TabIndex = 13
        Me.lbldob.Text = "IC-Number"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.DimGray
        Me.Label27.Location = New System.Drawing.Point(24, 327)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 18)
        Me.Label27.TabIndex = 12
        Me.Label27.Text = "DOB:"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.ForeColor = System.Drawing.Color.Black
        Me.lblgender.Location = New System.Drawing.Point(125, 236)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(89, 18)
        Me.lblgender.TabIndex = 11
        Me.lblgender.Text = "IC-Number"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DimGray
        Me.Label25.Location = New System.Drawing.Point(24, 236)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(68, 18)
        Me.Label25.TabIndex = 10
        Me.Label25.Text = "Gender:"
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphone.ForeColor = System.Drawing.Color.Black
        Me.lblphone.Location = New System.Drawing.Point(125, 297)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(89, 18)
        Me.lblphone.TabIndex = 9
        Me.lblphone.Text = "IC-Number"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DimGray
        Me.Label23.Location = New System.Drawing.Point(24, 297)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(75, 18)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Phone #:"
        '
        'lblmobile
        '
        Me.lblmobile.AutoSize = True
        Me.lblmobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmobile.ForeColor = System.Drawing.Color.Black
        Me.lblmobile.Location = New System.Drawing.Point(125, 206)
        Me.lblmobile.Name = "lblmobile"
        Me.lblmobile.Size = New System.Drawing.Size(89, 18)
        Me.lblmobile.TabIndex = 7
        Me.lblmobile.Text = "IC-Number"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DimGray
        Me.Label21.Location = New System.Drawing.Point(24, 206)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 18)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Mobile #:"
        '
        'lbladdress
        '
        Me.lbladdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.ForeColor = System.Drawing.Color.Black
        Me.lbladdress.Location = New System.Drawing.Point(125, 124)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(263, 77)
        Me.lbladdress.TabIndex = 5
        Me.lbladdress.Text = "IC-Number"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DimGray
        Me.Label19.Location = New System.Drawing.Point(24, 124)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 18)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Address:"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.Black
        Me.lblname.Location = New System.Drawing.Point(125, 94)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(89, 18)
        Me.lblname.TabIndex = 3
        Me.lblname.Text = "IC-Number"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DimGray
        Me.Label17.Location = New System.Drawing.Point(24, 94)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 18)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Name:"
        '
        'lblic
        '
        Me.lblic.AutoSize = True
        Me.lblic.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblic.ForeColor = System.Drawing.Color.Black
        Me.lblic.Location = New System.Drawing.Point(125, 66)
        Me.lblic.Name = "lblic"
        Me.lblic.Size = New System.Drawing.Size(89, 18)
        Me.lblic.TabIndex = 1
        Me.lblic.Text = "IC-Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(24, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IC-Number:"
        '
        'frmprescription
        '
        Me.AcceptButton = Me.btnsave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(765, 463)
        Me.ControlBox = False
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Name = "frmprescription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Prescription"
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents btnclose As Button
    Friend WithEvents txtprescribed As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtremarks As RichTextBox
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
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents lblemail As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents lbloccupation As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents lbldob As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lblgender As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lblphone As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblmobile As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lbladdress As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblname As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblic As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtpd_ht_l As TextBox
    Friend WithEvents Label3 As Label
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
End Class
