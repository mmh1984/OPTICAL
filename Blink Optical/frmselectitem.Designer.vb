<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmselectitem
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnselect = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.lvorders = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.gbxlens = New System.Windows.Forms.GroupBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtcyl = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtsph = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxpmodel = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.gbxlens.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnselect)
        Me.Panel1.Controls.Add(Me.btncancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 414)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(765, 58)
        Me.Panel1.TabIndex = 41
        '
        'btnselect
        '
        Me.btnselect.BackColor = System.Drawing.Color.DimGray
        Me.btnselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnselect.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselect.ForeColor = System.Drawing.Color.White
        Me.btnselect.Location = New System.Drawing.Point(206, 6)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(146, 41)
        Me.btnselect.TabIndex = 21
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
        Me.btncancel.Location = New System.Drawing.Point(402, 6)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(146, 41)
        Me.btncancel.TabIndex = 22
        Me.btncancel.Text = "Close"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'lvorders
        '
        Me.lvorders.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvorders.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvorders.FullRowSelect = True
        Me.lvorders.GridLines = True
        Me.lvorders.Location = New System.Drawing.Point(0, 103)
        Me.lvorders.Name = "lvorders"
        Me.lvorders.Size = New System.Drawing.Size(765, 311)
        Me.lvorders.TabIndex = 42
        Me.lvorders.UseCompatibleStateImageBehavior = False
        Me.lvorders.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name and Model"
        Me.ColumnHeader2.Width = 220
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Price"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Description"
        Me.ColumnHeader5.Width = 220
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Stock"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Color"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "SPH & CYL"
        Me.ColumnHeader7.Width = 100
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(12, 40)
        Me.txtsearch.MaxLength = 64
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(205, 25)
        Me.txtsearch.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(12, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(205, 16)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Type the product and press enter"
        '
        'btnrefresh
        '
        Me.btnrefresh.ForeColor = System.Drawing.Color.Black
        Me.btnrefresh.Location = New System.Drawing.Point(265, 71)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(87, 25)
        Me.btnrefresh.TabIndex = 46
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'gbxlens
        '
        Me.gbxlens.Controls.Add(Me.btnsearch)
        Me.gbxlens.Controls.Add(Me.txtcyl)
        Me.gbxlens.Controls.Add(Me.Label18)
        Me.gbxlens.Controls.Add(Me.Label22)
        Me.gbxlens.Controls.Add(Me.txtsph)
        Me.gbxlens.Location = New System.Drawing.Point(359, 14)
        Me.gbxlens.Name = "gbxlens"
        Me.gbxlens.Size = New System.Drawing.Size(200, 77)
        Me.gbxlens.TabIndex = 67
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(229, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Name"
        '
        'cbxpmodel
        '
        Me.cbxpmodel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxpmodel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxpmodel.FormattingEnabled = True
        Me.cbxpmodel.Location = New System.Drawing.Point(232, 40)
        Me.cbxpmodel.Name = "cbxpmodel"
        Me.cbxpmodel.Size = New System.Drawing.Size(121, 25)
        Me.cbxpmodel.TabIndex = 65
        '
        'frmselectitem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(765, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbxlens)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxpmodel)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lvorders)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmselectitem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Item"
        Me.Panel1.ResumeLayout(False)
        Me.gbxlens.ResumeLayout(False)
        Me.gbxlens.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnselect As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents lvorders As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnrefresh As Button
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents gbxlens As GroupBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtcyl As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtsph As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxpmodel As ComboBox
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
End Class
