<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmeditcustomer
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
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtic = New System.Windows.Forms.TextBox()
        Me.txtdob = New System.Windows.Forms.MaskedTextBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.cbxgender = New System.Windows.Forms.ComboBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtoccupation = New System.Windows.Forms.TextBox()
        Me.txtmobile = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.RichTextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.GunaGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Teal
        Me.GunaGroupBox1.Controls.Add(Me.Label2)
        Me.GunaGroupBox1.Controls.Add(Me.txtic)
        Me.GunaGroupBox1.Controls.Add(Me.txtdob)
        Me.GunaGroupBox1.Controls.Add(Me.btncancel)
        Me.GunaGroupBox1.Controls.Add(Me.cbxgender)
        Me.GunaGroupBox1.Controls.Add(Me.txtemail)
        Me.GunaGroupBox1.Controls.Add(Me.txtphone)
        Me.GunaGroupBox1.Controls.Add(Me.txtoccupation)
        Me.GunaGroupBox1.Controls.Add(Me.txtmobile)
        Me.GunaGroupBox1.Controls.Add(Me.txtaddress)
        Me.GunaGroupBox1.Controls.Add(Me.txtname)
        Me.GunaGroupBox1.Controls.Add(Me.Label31)
        Me.GunaGroupBox1.Controls.Add(Me.Label29)
        Me.GunaGroupBox1.Controls.Add(Me.Label27)
        Me.GunaGroupBox1.Controls.Add(Me.Label25)
        Me.GunaGroupBox1.Controls.Add(Me.Label23)
        Me.GunaGroupBox1.Controls.Add(Me.Label21)
        Me.GunaGroupBox1.Controls.Add(Me.Label19)
        Me.GunaGroupBox1.Controls.Add(Me.Label17)
        Me.GunaGroupBox1.Controls.Add(Me.Label1)
        Me.GunaGroupBox1.Controls.Add(Me.btnupdate)
        Me.GunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(489, 493)
        Me.GunaGroupBox1.TabIndex = 6
        Me.GunaGroupBox1.Text = "Customer Details (* REQUIRED)"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(291, 362)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "dd-MM-yyyy"
        '
        'txtic
        '
        Me.txtic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtic.Location = New System.Drawing.Point(136, 49)
        Me.txtic.MaxLength = 16
        Me.txtic.Name = "txtic"
        Me.txtic.Size = New System.Drawing.Size(149, 22)
        Me.txtic.TabIndex = 1
        '
        'txtdob
        '
        Me.txtdob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdob.Location = New System.Drawing.Point(136, 360)
        Me.txtdob.Mask = "00-00-0000"
        Me.txtdob.Name = "txtdob"
        Me.txtdob.Size = New System.Drawing.Size(149, 22)
        Me.txtdob.TabIndex = 8
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Location = New System.Drawing.Point(249, 446)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(146, 41)
        Me.btncancel.TabIndex = 11
        Me.btncancel.Text = "Close"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'cbxgender
        '
        Me.cbxgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxgender.FormattingEnabled = True
        Me.cbxgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbxgender.Location = New System.Drawing.Point(136, 253)
        Me.cbxgender.Name = "cbxgender"
        Me.cbxgender.Size = New System.Drawing.Size(149, 24)
        Me.cbxgender.TabIndex = 5
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(136, 395)
        Me.txtemail.MaxLength = 64
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(339, 22)
        Me.txtemail.TabIndex = 9
        '
        'txtphone
        '
        Me.txtphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone.Location = New System.Drawing.Point(136, 325)
        Me.txtphone.MaxLength = 16
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(149, 22)
        Me.txtphone.TabIndex = 7
        '
        'txtoccupation
        '
        Me.txtoccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoccupation.Location = New System.Drawing.Point(136, 290)
        Me.txtoccupation.MaxLength = 32
        Me.txtoccupation.Name = "txtoccupation"
        Me.txtoccupation.Size = New System.Drawing.Size(339, 22)
        Me.txtoccupation.TabIndex = 6
        '
        'txtmobile
        '
        Me.txtmobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmobile.Location = New System.Drawing.Point(136, 216)
        Me.txtmobile.MaxLength = 32
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.Size = New System.Drawing.Size(339, 22)
        Me.txtmobile.TabIndex = 4
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(136, 126)
        Me.txtaddress.MaxLength = 1024
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(339, 67)
        Me.txtaddress.TabIndex = 3
        Me.txtaddress.Text = ""
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(136, 87)
        Me.txtname.MaxLength = 128
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(339, 22)
        Me.txtname.TabIndex = 2
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.DimGray
        Me.Label31.Location = New System.Drawing.Point(14, 398)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(55, 18)
        Me.Label31.TabIndex = 35
        Me.Label31.Text = "Email:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.DimGray
        Me.Label29.Location = New System.Drawing.Point(14, 290)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(99, 18)
        Me.Label29.TabIndex = 34
        Me.Label29.Text = "Occupation:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.DimGray
        Me.Label27.Location = New System.Drawing.Point(14, 362)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 18)
        Me.Label27.TabIndex = 33
        Me.Label27.Text = "DOB:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DimGray
        Me.Label25.Location = New System.Drawing.Point(14, 254)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(68, 18)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "Gender:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DimGray
        Me.Label23.Location = New System.Drawing.Point(14, 326)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(75, 18)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "Phone #:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DimGray
        Me.Label21.Location = New System.Drawing.Point(14, 216)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 18)
        Me.Label21.TabIndex = 30
        Me.Label21.Text = "*Mobile #:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DimGray
        Me.Label19.Location = New System.Drawing.Point(14, 120)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 18)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Address:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DimGray
        Me.Label17.Location = New System.Drawing.Point(14, 85)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 18)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "*Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(14, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "IC-Number:"
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.DimGray
        Me.btnupdate.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(97, 446)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(146, 41)
        Me.btnupdate.TabIndex = 10
        Me.btnupdate.Text = "Update "
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'frmeditcustomer
        '
        Me.AcceptButton = Me.btnupdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btncancel
        Me.ClientSize = New System.Drawing.Size(489, 493)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmeditcustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer"
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtic As TextBox
    Friend WithEvents txtdob As MaskedTextBox
    Friend WithEvents btncancel As Button
    Friend WithEvents cbxgender As ComboBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtoccupation As TextBox
    Friend WithEvents txtmobile As TextBox
    Friend WithEvents txtaddress As RichTextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnupdate As Button
End Class
