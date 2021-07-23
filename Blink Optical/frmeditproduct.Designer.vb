<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmeditproduct
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
        Me.txtdescription = New System.Windows.Forms.RichTextBox()
        Me.txtcolor = New System.Windows.Forms.TextBox()
        Me.txtbrand = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.cbxproducttype = New System.Windows.Forms.ComboBox()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.gblens = New System.Windows.Forms.GroupBox()
        Me.txtcyl_l = New System.Windows.Forms.TextBox()
        Me.txtcyl_r = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsph_l = New System.Windows.Forms.TextBox()
        Me.txtsph_r = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txtmodel = New System.Windows.Forms.TextBox()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.GunaGroupBox1.SuspendLayout()
        Me.gblens.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtdescription
        '
        Me.txtdescription.Location = New System.Drawing.Point(150, 259)
        Me.txtdescription.MaxLength = 1024
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(360, 96)
        Me.txtdescription.TabIndex = 14
        Me.txtdescription.Text = ""
        '
        'txtcolor
        '
        Me.txtcolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcolor.Location = New System.Drawing.Point(150, 222)
        Me.txtcolor.MaxLength = 64
        Me.txtcolor.Name = "txtcolor"
        Me.txtcolor.Size = New System.Drawing.Size(149, 22)
        Me.txtcolor.TabIndex = 12
        '
        'txtbrand
        '
        Me.txtbrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrand.Location = New System.Drawing.Point(150, 153)
        Me.txtbrand.MaxLength = 64
        Me.txtbrand.Name = "txtbrand"
        Me.txtbrand.Size = New System.Drawing.Size(149, 22)
        Me.txtbrand.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(14, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 18)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Product Brand:"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(150, 118)
        Me.txtname.MaxLength = 128
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(360, 22)
        Me.txtname.TabIndex = 6
        '
        'cbxproducttype
        '
        Me.cbxproducttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxproducttype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxproducttype.FormattingEnabled = True
        Me.cbxproducttype.Items.AddRange(New Object() {"Frames", "Lens", "Contact Lens", "Solutions", "Nose Pads", "Ear Stopper"})
        Me.cbxproducttype.Location = New System.Drawing.Point(150, 46)
        Me.cbxproducttype.Name = "cbxproducttype"
        Me.cbxproducttype.Size = New System.Drawing.Size(149, 24)
        Me.cbxproducttype.TabIndex = 2
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Teal
        Me.GunaGroupBox1.Controls.Add(Me.btnsave)
        Me.GunaGroupBox1.Controls.Add(Me.gblens)
        Me.GunaGroupBox1.Controls.Add(Me.btndelete)
        Me.GunaGroupBox1.Controls.Add(Me.txtdescription)
        Me.GunaGroupBox1.Controls.Add(Me.txtcolor)
        Me.GunaGroupBox1.Controls.Add(Me.Label4)
        Me.GunaGroupBox1.Controls.Add(Me.txtbrand)
        Me.GunaGroupBox1.Controls.Add(Me.Label3)
        Me.GunaGroupBox1.Controls.Add(Me.txtname)
        Me.GunaGroupBox1.Controls.Add(Me.cbxproducttype)
        Me.GunaGroupBox1.Controls.Add(Me.btncancel)
        Me.GunaGroupBox1.Controls.Add(Me.txtprice)
        Me.GunaGroupBox1.Controls.Add(Me.txtmodel)
        Me.GunaGroupBox1.Controls.Add(Me.txtcode)
        Me.GunaGroupBox1.Controls.Add(Me.Label31)
        Me.GunaGroupBox1.Controls.Add(Me.Label23)
        Me.GunaGroupBox1.Controls.Add(Me.Label21)
        Me.GunaGroupBox1.Controls.Add(Me.Label19)
        Me.GunaGroupBox1.Controls.Add(Me.Label17)
        Me.GunaGroupBox1.Controls.Add(Me.Label1)
        Me.GunaGroupBox1.Controls.Add(Me.btnupdate)
        Me.GunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(523, 467)
        Me.GunaGroupBox1.TabIndex = 7
        Me.GunaGroupBox1.Text = "Product Details (* REQUIRED)"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'gblens
        '
        Me.gblens.Controls.Add(Me.txtcyl_l)
        Me.gblens.Controls.Add(Me.txtcyl_r)
        Me.gblens.Controls.Add(Me.Label7)
        Me.gblens.Controls.Add(Me.Label6)
        Me.gblens.Controls.Add(Me.txtsph_l)
        Me.gblens.Controls.Add(Me.txtsph_r)
        Me.gblens.Controls.Add(Me.Label5)
        Me.gblens.Controls.Add(Me.Label2)
        Me.gblens.Location = New System.Drawing.Point(305, 146)
        Me.gblens.Name = "gblens"
        Me.gblens.Size = New System.Drawing.Size(205, 100)
        Me.gblens.TabIndex = 44
        Me.gblens.TabStop = False
        Me.gblens.Text = "(For Lens and Contact Lens)"
        '
        'txtcyl_l
        '
        Me.txtcyl_l.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcyl_l.Location = New System.Drawing.Point(125, 67)
        Me.txtcyl_l.MaxLength = 8
        Me.txtcyl_l.Name = "txtcyl_l"
        Me.txtcyl_l.Size = New System.Drawing.Size(49, 22)
        Me.txtcyl_l.TabIndex = 51
        Me.txtcyl_l.Text = "0.0"
        Me.txtcyl_l.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcyl_r
        '
        Me.txtcyl_r.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcyl_r.Location = New System.Drawing.Point(70, 67)
        Me.txtcyl_r.MaxLength = 8
        Me.txtcyl_r.Name = "txtcyl_r"
        Me.txtcyl_r.Size = New System.Drawing.Size(49, 22)
        Me.txtcyl_r.TabIndex = 50
        Me.txtcyl_r.Text = "0.0"
        Me.txtcyl_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(25, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 16)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "CYL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(25, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "SPH"
        '
        'txtsph_l
        '
        Me.txtsph_l.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsph_l.Location = New System.Drawing.Point(125, 41)
        Me.txtsph_l.MaxLength = 8
        Me.txtsph_l.Name = "txtsph_l"
        Me.txtsph_l.Size = New System.Drawing.Size(49, 22)
        Me.txtsph_l.TabIndex = 47
        Me.txtsph_l.Text = "0.0"
        Me.txtsph_l.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsph_r
        '
        Me.txtsph_r.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsph_r.Location = New System.Drawing.Point(70, 41)
        Me.txtsph_r.MaxLength = 8
        Me.txtsph_r.Name = "txtsph_r"
        Me.txtsph_r.Size = New System.Drawing.Size(49, 22)
        Me.txtsph_r.TabIndex = 46
        Me.txtsph_r.Text = "0.0"
        Me.txtsph_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(143, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 18)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "L"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(85, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 18)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "R"
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(343, 414)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(71, 41)
        Me.btndelete.TabIndex = 43
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(19, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 18)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Color:"
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Location = New System.Drawing.Point(420, 414)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(71, 41)
        Me.btncancel.TabIndex = 20
        Me.btncancel.Text = "Close"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(150, 366)
        Me.txtprice.MaxLength = 8
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(149, 22)
        Me.txtprice.TabIndex = 16
        Me.txtprice.Text = "0.0"
        '
        'txtmodel
        '
        Me.txtmodel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmodel.Location = New System.Drawing.Point(150, 188)
        Me.txtmodel.MaxLength = 64
        Me.txtmodel.Name = "txtmodel"
        Me.txtmodel.Size = New System.Drawing.Size(149, 22)
        Me.txtmodel.TabIndex = 10
        '
        'txtcode
        '
        Me.txtcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.Location = New System.Drawing.Point(150, 83)
        Me.txtcode.MaxLength = 64
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(149, 22)
        Me.txtcode.TabIndex = 4
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.DimGray
        Me.Label31.Location = New System.Drawing.Point(19, 366)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(114, 18)
        Me.Label31.TabIndex = 35
        Me.Label31.Text = "*Selling Price:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DimGray
        Me.Label23.Location = New System.Drawing.Point(19, 253)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(99, 18)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "Description:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DimGray
        Me.Label21.Location = New System.Drawing.Point(14, 186)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(123, 18)
        Me.Label21.TabIndex = 30
        Me.Label21.Text = "Product Model:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DimGray
        Me.Label19.Location = New System.Drawing.Point(14, 118)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 18)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "*Product Name:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DimGray
        Me.Label17.Location = New System.Drawing.Point(14, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 18)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Product Code:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(14, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Product Type:"
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.DimGray
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(266, 414)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(71, 41)
        Me.btnupdate.TabIndex = 18
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Green
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(33, 414)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(146, 41)
        Me.btnsave.TabIndex = 45
        Me.btnsave.Text = "Save as new"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'frmeditproduct
        '
        Me.AcceptButton = Me.btnupdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btncancel
        Me.ClientSize = New System.Drawing.Size(523, 467)
        Me.ControlBox = False
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmeditproduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Products"
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.gblens.ResumeLayout(False)
        Me.gblens.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtdescription As RichTextBox
    Friend WithEvents txtcolor As TextBox
    Friend WithEvents txtbrand As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents cbxproducttype As ComboBox
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents txtprice As TextBox
    Friend WithEvents txtmodel As TextBox
    Friend WithEvents txtcode As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents gblens As GroupBox
    Friend WithEvents txtcyl_l As TextBox
    Friend WithEvents txtcyl_r As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtsph_l As TextBox
    Friend WithEvents txtsph_r As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsave As Button
End Class
