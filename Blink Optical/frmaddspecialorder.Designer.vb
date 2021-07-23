<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddspecialorder
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
        Me.btncancel = New System.Windows.Forms.Button()
        Me.gblens = New System.Windows.Forms.GroupBox()
        Me.txtcyl_l = New System.Windows.Forms.TextBox()
        Me.txtcyl_r = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsph_l = New System.Windows.Forms.TextBox()
        Me.txtsph_r = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdescription = New System.Windows.Forms.RichTextBox()
        Me.txtcolor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbrand = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.cbxproducttype = New System.Windows.Forms.ComboBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txtmodel = New System.Windows.Forms.TextBox()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.gblens.SuspendLayout()
        Me.SuspendLayout()
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Location = New System.Drawing.Point(386, 383)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(103, 41)
        Me.btncancel.TabIndex = 82
        Me.btncancel.Text = "Cancel "
        Me.btncancel.UseVisualStyleBackColor = False
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
        Me.gblens.Location = New System.Drawing.Point(326, 118)
        Me.gblens.Name = "gblens"
        Me.gblens.Size = New System.Drawing.Size(205, 100)
        Me.gblens.TabIndex = 81
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
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "CYL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(25, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
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
        'txtdescription
        '
        Me.txtdescription.Location = New System.Drawing.Point(148, 230)
        Me.txtdescription.MaxLength = 1024
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(383, 96)
        Me.txtdescription.TabIndex = 70
        Me.txtdescription.Text = ""
        '
        'txtcolor
        '
        Me.txtcolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcolor.Location = New System.Drawing.Point(148, 193)
        Me.txtcolor.MaxLength = 64
        Me.txtcolor.Name = "txtcolor"
        Me.txtcolor.Size = New System.Drawing.Size(172, 22)
        Me.txtcolor.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(17, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 18)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Color:"
        '
        'txtbrand
        '
        Me.txtbrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrand.Location = New System.Drawing.Point(148, 124)
        Me.txtbrand.MaxLength = 64
        Me.txtbrand.Name = "txtbrand"
        Me.txtbrand.Size = New System.Drawing.Size(172, 22)
        Me.txtbrand.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 18)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "*Product Brand:"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(148, 89)
        Me.txtname.MaxLength = 128
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(383, 22)
        Me.txtname.TabIndex = 66
        '
        'cbxproducttype
        '
        Me.cbxproducttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxproducttype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxproducttype.FormattingEnabled = True
        Me.cbxproducttype.Items.AddRange(New Object() {"Frames", "Lens", "Contact Lens", "Solutions", "Nose Pads", "Ear Stopper"})
        Me.cbxproducttype.Location = New System.Drawing.Point(148, 17)
        Me.cbxproducttype.Name = "cbxproducttype"
        Me.cbxproducttype.Size = New System.Drawing.Size(172, 24)
        Me.cbxproducttype.TabIndex = 64
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(148, 337)
        Me.txtprice.MaxLength = 8
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(149, 22)
        Me.txtprice.TabIndex = 71
        Me.txtprice.Text = "0.0"
        '
        'txtmodel
        '
        Me.txtmodel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmodel.Location = New System.Drawing.Point(148, 159)
        Me.txtmodel.MaxLength = 64
        Me.txtmodel.Name = "txtmodel"
        Me.txtmodel.Size = New System.Drawing.Size(172, 22)
        Me.txtmodel.TabIndex = 68
        '
        'txtcode
        '
        Me.txtcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.Location = New System.Drawing.Point(148, 54)
        Me.txtcode.MaxLength = 64
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(172, 22)
        Me.txtcode.TabIndex = 65
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.DimGray
        Me.Label31.Location = New System.Drawing.Point(17, 337)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(114, 18)
        Me.Label31.TabIndex = 78
        Me.Label31.Text = "*Selling Price:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DimGray
        Me.Label23.Location = New System.Drawing.Point(17, 224)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(106, 18)
        Me.Label23.TabIndex = 77
        Me.Label23.Text = "*Description:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DimGray
        Me.Label21.Location = New System.Drawing.Point(17, 157)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(123, 18)
        Me.Label21.TabIndex = 76
        Me.Label21.Text = "Product Model:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DimGray
        Me.Label19.Location = New System.Drawing.Point(12, 89)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 18)
        Me.Label19.TabIndex = 75
        Me.Label19.Text = "*Product Name:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DimGray
        Me.Label17.Location = New System.Drawing.Point(12, 55)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(124, 18)
        Me.Label17.TabIndex = 74
        Me.Label17.Text = "*Product Code:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "*Product Type:"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.DimGray
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(83, 383)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(95, 41)
        Me.btnsave.TabIndex = 72
        Me.btnsave.Text = "Save "
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(184, 383)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(95, 41)
        Me.btnupdate.TabIndex = 83
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Maroon
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(285, 383)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(95, 41)
        Me.btndelete.TabIndex = 84
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'frmaddspecialorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(557, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.gblens)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.txtcolor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtbrand)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.cbxproducttype)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtmodel)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmaddspecialorder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Special Order"
        Me.gblens.ResumeLayout(False)
        Me.gblens.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncancel As Button
    Friend WithEvents gblens As GroupBox
    Friend WithEvents txtcyl_l As TextBox
    Friend WithEvents txtcyl_r As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtsph_l As TextBox
    Friend WithEvents txtsph_r As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdescription As RichTextBox
    Friend WithEvents txtcolor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbrand As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents cbxproducttype As ComboBox
    Friend WithEvents txtprice As TextBox
    Friend WithEvents txtmodel As TextBox
    Friend WithEvents txtcode As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
End Class
