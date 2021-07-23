<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbigreceipt
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.bigreceiptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dataset1 = New Optical_POS.Dataset1()
        Me.WorkorderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.bigreceiptTableAdapter = New Optical_POS.Dataset1TableAdapters.bigreceiptTableAdapter()
        Me.WorkorderTableAdapter = New Optical_POS.Dataset1TableAdapters.workorderTableAdapter()
        CType(Me.bigreceiptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dataset1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkorderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bigreceiptBindingSource
        '
        Me.bigreceiptBindingSource.DataMember = "bigreceipt"
        Me.bigreceiptBindingSource.DataSource = Me.Dataset1
        '
        'Dataset1
        '
        Me.Dataset1.DataSetName = "Dataset1"
        Me.Dataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WorkorderBindingSource
        '
        Me.WorkorderBindingSource.DataMember = "workorder"
        Me.WorkorderBindingSource.DataSource = Me.Dataset1
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "BigReceipt"
        ReportDataSource1.Value = Me.bigreceiptBindingSource
        ReportDataSource2.Name = "Workorder"
        ReportDataSource2.Value = Me.WorkorderBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Optical_POS.bigreceipt.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(753, 491)
        Me.ReportViewer1.TabIndex = 0
        '
        'bigreceiptTableAdapter
        '
        Me.bigreceiptTableAdapter.ClearBeforeFill = True
        '
        'WorkorderTableAdapter
        '
        Me.WorkorderTableAdapter.ClearBeforeFill = True
        '
        'frmbigreceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 491)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmbigreceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Receipt"
        CType(Me.bigreceiptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dataset1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkorderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents bigreceiptBindingSource As BindingSource
    Friend WithEvents Dataset1 As Dataset1
    Friend WithEvents bigreceiptTableAdapter As Dataset1TableAdapters.bigreceiptTableAdapter
    Friend WithEvents WorkorderBindingSource As BindingSource
    Friend WithEvents WorkorderTableAdapter As Dataset1TableAdapters.workorderTableAdapter
End Class
