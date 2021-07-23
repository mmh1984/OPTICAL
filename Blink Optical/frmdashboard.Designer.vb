<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmdashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblstorename = New System.Windows.Forms.Label()
        Me.paneluser = New System.Windows.Forms.Panel()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.mainpanel = New System.Windows.Forms.Panel()
        Me.btnpackage = New System.Windows.Forms.Button()
        Me.btnlenses = New System.Windows.Forms.Button()
        Me.btnaddon = New System.Windows.Forms.Button()
        Me.btnbuy = New System.Windows.Forms.Button()
        Me.btnworkorder = New System.Windows.Forms.Button()
        Me.btntransaction = New System.Windows.Forms.Button()
        Me.btncustomers = New System.Windows.Forms.Button()
        Me.btnreports = New System.Windows.Forms.Button()
        Me.btnusers = New System.Windows.Forms.Button()
        Me.btnprofile = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.paneluser.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnpackage)
        Me.Panel1.Controls.Add(Me.btnlenses)
        Me.Panel1.Controls.Add(Me.btnaddon)
        Me.Panel1.Controls.Add(Me.btnbuy)
        Me.Panel1.Controls.Add(Me.btnworkorder)
        Me.Panel1.Controls.Add(Me.btntransaction)
        Me.Panel1.Controls.Add(Me.btncustomers)
        Me.Panel1.Controls.Add(Me.btnreports)
        Me.Panel1.Controls.Add(Me.btnusers)
        Me.Panel1.Controls.Add(Me.btnprofile)
        Me.Panel1.Controls.Add(Me.btnlogout)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1115, 76)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblstorename)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(297, 76)
        Me.Panel2.TabIndex = 26
        '
        'lblstorename
        '
        Me.lblstorename.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblstorename.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstorename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblstorename.Location = New System.Drawing.Point(10, 10)
        Me.lblstorename.Name = "lblstorename"
        Me.lblstorename.Size = New System.Drawing.Size(277, 56)
        Me.lblstorename.TabIndex = 0
        Me.lblstorename.Text = "Label1"
        Me.lblstorename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'paneluser
        '
        Me.paneluser.BackColor = System.Drawing.Color.White
        Me.paneluser.Controls.Add(Me.lbltime)
        Me.paneluser.Controls.Add(Me.lbldate)
        Me.paneluser.Controls.Add(Me.lbluser)
        Me.paneluser.Dock = System.Windows.Forms.DockStyle.Top
        Me.paneluser.Location = New System.Drawing.Point(0, 76)
        Me.paneluser.Name = "paneluser"
        Me.paneluser.Size = New System.Drawing.Size(1115, 31)
        Me.paneluser.TabIndex = 2
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(1008, 8)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(58, 17)
        Me.lbltime.TabIndex = 2
        Me.lbltime.Text = "00:00:00"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbldate.Location = New System.Drawing.Point(884, 8)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(41, 17)
        Me.lbldate.TabIndex = 1
        Me.lbldate.Text = "Date:"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbluser.Location = New System.Drawing.Point(13, 7)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(75, 17)
        Me.lbluser.TabIndex = 0
        Me.lbluser.Text = "Logged as:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'mainpanel
        '
        Me.mainpanel.BackColor = System.Drawing.Color.White
        Me.mainpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.mainpanel.Location = New System.Drawing.Point(0, 107)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(1115, 483)
        Me.mainpanel.TabIndex = 3
        '
        'btnpackage
        '
        Me.btnpackage.BackColor = System.Drawing.Color.Teal
        Me.btnpackage.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnpackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpackage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpackage.ForeColor = System.Drawing.Color.White
        Me.btnpackage.Image = Global.Optical_POS.My.Resources.Resources.package
        Me.btnpackage.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnpackage.Location = New System.Drawing.Point(471, 0)
        Me.btnpackage.Name = "btnpackage"
        Me.btnpackage.Size = New System.Drawing.Size(71, 76)
        Me.btnpackage.TabIndex = 25
        Me.btnpackage.Text = "Frame & Lens Package"
        Me.btnpackage.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnpackage.UseVisualStyleBackColor = False
        '
        'btnlenses
        '
        Me.btnlenses.BackColor = System.Drawing.Color.Teal
        Me.btnlenses.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnlenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlenses.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlenses.ForeColor = System.Drawing.Color.White
        Me.btnlenses.Image = Global.Optical_POS.My.Resources.Resources.glasses_2_48
        Me.btnlenses.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnlenses.Location = New System.Drawing.Point(542, 0)
        Me.btnlenses.Name = "btnlenses"
        Me.btnlenses.Size = New System.Drawing.Size(71, 76)
        Me.btnlenses.TabIndex = 24
        Me.btnlenses.Text = "Products"
        Me.btnlenses.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnlenses.UseVisualStyleBackColor = False
        '
        'btnaddon
        '
        Me.btnaddon.BackColor = System.Drawing.Color.Teal
        Me.btnaddon.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnaddon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddon.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddon.ForeColor = System.Drawing.Color.White
        Me.btnaddon.Image = Global.Optical_POS.My.Resources.Resources.add_on1
        Me.btnaddon.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnaddon.Location = New System.Drawing.Point(613, 0)
        Me.btnaddon.Name = "btnaddon"
        Me.btnaddon.Size = New System.Drawing.Size(71, 76)
        Me.btnaddon.TabIndex = 23
        Me.btnaddon.Text = "Add-Ons"
        Me.btnaddon.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnaddon.UseVisualStyleBackColor = False
        '
        'btnbuy
        '
        Me.btnbuy.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnbuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuy.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuy.ForeColor = System.Drawing.Color.White
        Me.btnbuy.Image = Global.Optical_POS.My.Resources.Resources.buy_2_32
        Me.btnbuy.Location = New System.Drawing.Point(387, 0)
        Me.btnbuy.Name = "btnbuy"
        Me.btnbuy.Size = New System.Drawing.Size(84, 76)
        Me.btnbuy.TabIndex = 21
        Me.btnbuy.Text = "Buy"
        Me.btnbuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnbuy.UseVisualStyleBackColor = False
        '
        'btnworkorder
        '
        Me.btnworkorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnworkorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnworkorder.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnworkorder.ForeColor = System.Drawing.Color.White
        Me.btnworkorder.Image = Global.Optical_POS.My.Resources.Resources.work_order1
        Me.btnworkorder.Location = New System.Drawing.Point(303, 0)
        Me.btnworkorder.Name = "btnworkorder"
        Me.btnworkorder.Size = New System.Drawing.Size(84, 76)
        Me.btnworkorder.TabIndex = 20
        Me.btnworkorder.Text = "Work Order"
        Me.btnworkorder.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnworkorder.UseVisualStyleBackColor = False
        '
        'btntransaction
        '
        Me.btntransaction.BackColor = System.Drawing.Color.Teal
        Me.btntransaction.Dock = System.Windows.Forms.DockStyle.Right
        Me.btntransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntransaction.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntransaction.ForeColor = System.Drawing.Color.White
        Me.btntransaction.Image = Global.Optical_POS.My.Resources.Resources.transaction
        Me.btntransaction.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btntransaction.Location = New System.Drawing.Point(684, 0)
        Me.btntransaction.Name = "btntransaction"
        Me.btntransaction.Size = New System.Drawing.Size(76, 76)
        Me.btntransaction.TabIndex = 18
        Me.btntransaction.Text = "Transaction"
        Me.btntransaction.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btntransaction.UseVisualStyleBackColor = False
        '
        'btncustomers
        '
        Me.btncustomers.BackColor = System.Drawing.Color.Teal
        Me.btncustomers.Dock = System.Windows.Forms.DockStyle.Right
        Me.btncustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncustomers.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncustomers.ForeColor = System.Drawing.Color.White
        Me.btncustomers.Image = Global.Optical_POS.My.Resources.Resources.conference_48
        Me.btncustomers.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncustomers.Location = New System.Drawing.Point(760, 0)
        Me.btncustomers.Name = "btncustomers"
        Me.btncustomers.Size = New System.Drawing.Size(71, 76)
        Me.btncustomers.TabIndex = 16
        Me.btncustomers.Text = "Customers"
        Me.btncustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncustomers.UseVisualStyleBackColor = False
        '
        'btnreports
        '
        Me.btnreports.BackColor = System.Drawing.Color.Teal
        Me.btnreports.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreports.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreports.ForeColor = System.Drawing.Color.White
        Me.btnreports.Image = Global.Optical_POS.My.Resources.Resources.report_2_48
        Me.btnreports.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnreports.Location = New System.Drawing.Point(831, 0)
        Me.btnreports.Name = "btnreports"
        Me.btnreports.Size = New System.Drawing.Size(71, 76)
        Me.btnreports.TabIndex = 15
        Me.btnreports.Text = "Reports"
        Me.btnreports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnreports.UseVisualStyleBackColor = False
        '
        'btnusers
        '
        Me.btnusers.BackColor = System.Drawing.Color.Teal
        Me.btnusers.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnusers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnusers.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnusers.ForeColor = System.Drawing.Color.White
        Me.btnusers.Image = Global.Optical_POS.My.Resources.Resources.add_user_48
        Me.btnusers.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnusers.Location = New System.Drawing.Point(902, 0)
        Me.btnusers.Name = "btnusers"
        Me.btnusers.Size = New System.Drawing.Size(71, 76)
        Me.btnusers.TabIndex = 14
        Me.btnusers.Text = "Users"
        Me.btnusers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnusers.UseVisualStyleBackColor = False
        '
        'btnprofile
        '
        Me.btnprofile.BackColor = System.Drawing.Color.Teal
        Me.btnprofile.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprofile.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprofile.ForeColor = System.Drawing.Color.White
        Me.btnprofile.Image = Global.Optical_POS.My.Resources.Resources.gear_48
        Me.btnprofile.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnprofile.Location = New System.Drawing.Point(973, 0)
        Me.btnprofile.Name = "btnprofile"
        Me.btnprofile.Size = New System.Drawing.Size(71, 76)
        Me.btnprofile.TabIndex = 12
        Me.btnprofile.Text = "Profile"
        Me.btnprofile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnprofile.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlogout.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.White
        Me.btnlogout.Image = Global.Optical_POS.My.Resources.Resources.logout_48
        Me.btnlogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnlogout.Location = New System.Drawing.Point(1044, 0)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(71, 76)
        Me.btnlogout.TabIndex = 11
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'frmdashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 597)
        Me.ControlBox = False
        Me.Controls.Add(Me.mainpanel)
        Me.Controls.Add(Me.paneluser)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmdashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Optical Shop POS-User Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.paneluser.ResumeLayout(False)
        Me.paneluser.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents paneluser As Panel
    Friend WithEvents lbldate As Label
    Friend WithEvents lbluser As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnworkorder As Button
    Friend WithEvents btncustomers As Button
    Friend WithEvents btnreports As Button
    Friend WithEvents btnusers As Button
    Friend WithEvents btnprofile As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents btnbuy As Button
    Friend WithEvents btntransaction As Button
    Friend WithEvents btnlenses As Button
    Friend WithEvents btnaddon As Button
    Friend WithEvents mainpanel As Panel
    Friend WithEvents btnpackage As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblstorename As Label
End Class
