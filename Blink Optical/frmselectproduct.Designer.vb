<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmselectproduct
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
        Me.btnselect = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lvproducts = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cbxproducttype = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblamount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxpmodel = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbxlens = New System.Windows.Forms.GroupBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtcyl = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtsph = New System.Windows.Forms.TextBox()
        Me.gbxlens.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnselect
        '
        Me.btnselect.BackColor = System.Drawing.Color.DimGray
        Me.btnselect.Enabled = False
        Me.btnselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnselect.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselect.ForeColor = System.Drawing.Color.White
        Me.btnselect.Location = New System.Drawing.Point(841, 315)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(119, 41)
        Me.btnselect.TabIndex = 7
        Me.btnselect.Text = "Select"
        Me.btnselect.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Location = New System.Drawing.Point(841, 362)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(119, 41)
        Me.btncancel.TabIndex = 8
        Me.btncancel.Text = "Close"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnrefresh
        '
        Me.btnrefresh.ForeColor = System.Drawing.Color.Black
        Me.btnrefresh.Location = New System.Drawing.Point(452, 55)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(71, 25)
        Me.btnrefresh.TabIndex = 3
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(12, 30)
        Me.txtsearch.MaxLength = 64
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(221, 25)
        Me.txtsearch.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(12, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(205, 16)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Type the product and press enter"
        '
        'lvproducts
        '
        Me.lvproducts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader6, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader4, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvproducts.FullRowSelect = True
        Me.lvproducts.GridLines = True
        Me.lvproducts.HideSelection = False
        Me.lvproducts.Location = New System.Drawing.Point(0, 86)
        Me.lvproducts.Name = "lvproducts"
        Me.lvproducts.Size = New System.Drawing.Size(809, 321)
        Me.lvproducts.TabIndex = 4
        Me.lvproducts.UseCompatibleStateImageBehavior = False
        Me.lvproducts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Product Type"
        Me.ColumnHeader6.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name and Model"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Price"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Description"
        Me.ColumnHeader5.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Stock"
        Me.ColumnHeader4.Width = 50
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Color"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "SPH & CYL"
        Me.ColumnHeader8.Width = 100
        '
        'cbxproducttype
        '
        Me.cbxproducttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxproducttype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxproducttype.FormattingEnabled = True
        Me.cbxproducttype.Items.AddRange(New Object() {"Frames", "Lens", "Contact Lens", "Solutions", "Nose Pads", "Ear Stopper"})
        Me.cbxproducttype.Location = New System.Drawing.Point(245, 30)
        Me.cbxproducttype.Name = "cbxproducttype"
        Me.cbxproducttype.Size = New System.Drawing.Size(151, 24)
        Me.cbxproducttype.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(245, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Product Type"
        '
        'txtdiscount
        '
        Me.txtdiscount.Enabled = False
        Me.txtdiscount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscount.Location = New System.Drawing.Point(841, 188)
        Me.txtdiscount.MaxLength = 8
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(117, 29)
        Me.txtdiscount.TabIndex = 6
        Me.txtdiscount.Text = "0.0"
        Me.txtdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtqty
        '
        Me.txtqty.Enabled = False
        Me.txtqty.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(841, 127)
        Me.txtqty.MaxLength = 8
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(117, 29)
        Me.txtqty.TabIndex = 5
        Me.txtqty.Text = "0"
        Me.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(863, 169)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 16)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Discount"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(867, 108)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 16)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Quantity"
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.Color.Black
        Me.lbltotal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbltotal.Location = New System.Drawing.Point(843, 249)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(115, 25)
        Me.lbltotal.TabIndex = 60
        Me.lbltotal.Text = "0.0"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(874, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Total"
        '
        'lblamount
        '
        Me.lblamount.BackColor = System.Drawing.Color.Black
        Me.lblamount.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamount.ForeColor = System.Drawing.Color.White
        Me.lblamount.Location = New System.Drawing.Point(841, 66)
        Me.lblamount.Name = "lblamount"
        Me.lblamount.Size = New System.Drawing.Size(117, 25)
        Me.lblamount.TabIndex = 58
        Me.lblamount.Text = "0.0"
        Me.lblamount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(869, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Amount"
        '
        'cbxpmodel
        '
        Me.cbxpmodel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxpmodel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxpmodel.FormattingEnabled = True
        Me.cbxpmodel.Location = New System.Drawing.Point(402, 29)
        Me.cbxpmodel.Name = "cbxpmodel"
        Me.cbxpmodel.Size = New System.Drawing.Size(121, 25)
        Me.cbxpmodel.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(399, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Name"
        '
        'gbxlens
        '
        Me.gbxlens.Controls.Add(Me.btnsearch)
        Me.gbxlens.Controls.Add(Me.txtcyl)
        Me.gbxlens.Controls.Add(Me.Label18)
        Me.gbxlens.Controls.Add(Me.Label22)
        Me.gbxlens.Controls.Add(Me.txtsph)
        Me.gbxlens.Location = New System.Drawing.Point(529, 3)
        Me.gbxlens.Name = "gbxlens"
        Me.gbxlens.Size = New System.Drawing.Size(200, 77)
        Me.gbxlens.TabIndex = 63
        Me.gbxlens.TabStop = False
        Me.gbxlens.Text = "For Lens"
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.Black
        Me.btnsearch.Location = New System.Drawing.Point(123, 40)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(57, 23)
        Me.btnsearch.TabIndex = 60
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtcyl
        '
        Me.txtcyl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcyl.Location = New System.Drawing.Point(68, 40)
        Me.txtcyl.MaxLength = 8
        Me.txtcyl.Name = "txtcyl"
        Me.txtcyl.Size = New System.Drawing.Size(49, 22)
        Me.txtcyl.TabIndex = 59
        Me.txtcyl.Text = "0.0"
        Me.txtcyl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(78, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 17)
        Me.Label18.TabIndex = 58
        Me.Label18.Text = "CYL"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(23, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(31, 17)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = "SPH"
        '
        'txtsph
        '
        Me.txtsph.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsph.Location = New System.Drawing.Point(13, 40)
        Me.txtsph.MaxLength = 8
        Me.txtsph.Name = "txtsph"
        Me.txtsph.Size = New System.Drawing.Size(49, 22)
        Me.txtsph.TabIndex = 56
        Me.txtsph.Text = "0.0"
        Me.txtsph.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmselectproduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(982, 414)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbxlens)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxpmodel)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblamount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnselect)
        Me.Controls.Add(Me.txtdiscount)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxproducttype)
        Me.Controls.Add(Me.lvproducts)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label9)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmselectproduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Product"
        Me.gbxlens.ResumeLayout(False)
        Me.gbxlens.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnselect As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents btnrefresh As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lvproducts As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents cbxproducttype As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdiscount As TextBox
    Friend WithEvents txtqty As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblamount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents cbxpmodel As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents gbxlens As GroupBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtcyl As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtsph As TextBox
End Class
