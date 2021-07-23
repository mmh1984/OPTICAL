<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmconfiguration
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttag = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxthermalprinter = New System.Windows.Forms.ComboBox()
        Me.cbxlaserprinter = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.txtaddress = New System.Windows.Forms.RichTextBox()
        Me.txtinstagram = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Shop Name"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(114, 12)
        Me.txtname.MaxLength = 64
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(314, 22)
        Me.txtname.TabIndex = 1
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(114, 53)
        Me.txtphone.MaxLength = 16
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(314, 22)
        Me.txtphone.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Phone No"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(114, 96)
        Me.txtemail.MaxLength = 64
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(314, 22)
        Me.txtemail.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Address"
        '
        'txttag
        '
        Me.txttag.Location = New System.Drawing.Point(114, 260)
        Me.txttag.MaxLength = 128
        Me.txttag.Name = "txttag"
        Me.txttag.Size = New System.Drawing.Size(314, 22)
        Me.txttag.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tagline"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Thermal Printer"
        '
        'cbxthermalprinter
        '
        Me.cbxthermalprinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxthermalprinter.FormattingEnabled = True
        Me.cbxthermalprinter.Location = New System.Drawing.Point(114, 298)
        Me.cbxthermalprinter.Name = "cbxthermalprinter"
        Me.cbxthermalprinter.Size = New System.Drawing.Size(314, 24)
        Me.cbxthermalprinter.TabIndex = 7
        '
        'cbxlaserprinter
        '
        Me.cbxlaserprinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxlaserprinter.FormattingEnabled = True
        Me.cbxlaserprinter.Location = New System.Drawing.Point(114, 342)
        Me.cbxlaserprinter.Name = "cbxlaserprinter"
        Me.cbxlaserprinter.Size = New System.Drawing.Size(314, 24)
        Me.cbxlaserprinter.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 347)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Laser/Inkjet"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(114, 385)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(116, 40)
        Me.btnsave.TabIndex = 9
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(247, 385)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(116, 40)
        Me.btnclose.TabIndex = 10
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(114, 139)
        Me.txtaddress.MaxLength = 1024
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(314, 69)
        Me.txtaddress.TabIndex = 4
        Me.txtaddress.Text = ""
        '
        'txtinstagram
        '
        Me.txtinstagram.Location = New System.Drawing.Point(114, 221)
        Me.txtinstagram.MaxLength = 64
        Me.txtinstagram.Name = "txtinstagram"
        Me.txtinstagram.Size = New System.Drawing.Size(314, 22)
        Me.txtinstagram.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Instagram"
        '
        'frmconfiguration
        '
        Me.AcceptButton = Me.btnsave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(448, 456)
        Me.Controls.Add(Me.txtinstagram)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cbxlaserprinter)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbxthermalprinter)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txttag)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmconfiguration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txttag As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxthermalprinter As ComboBox
    Friend WithEvents cbxlaserprinter As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents txtaddress As RichTextBox
    Friend WithEvents txtinstagram As TextBox
    Friend WithEvents Label8 As Label
End Class
