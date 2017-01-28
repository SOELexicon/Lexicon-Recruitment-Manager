<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports_PlanClientCosting
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
        Me.Rpt_PlanClientCostingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LexiconRecManagerDataSet = New Lexrecmgr.LexiconRecManagerDataSet()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.weekenddate = New System.Windows.Forms.ComboBox()
        Me.PlanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sites = New Lexrecmgr.Sites()
        Me.plantype = New System.Windows.Forms.ComboBox()
        Me.PlanTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.branch = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.client = New System.Windows.Forms.ComboBox()
        Me.BlockTimeSheetClientListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Rpt_PlanClientCostingTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.Rpt_PlanClientCostingTableAdapter()
        Me.BlockTimeSheetClientListTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BlockTimeSheetClientListTableAdapter()
        Me.PlanTableAdapter = New Lexrecmgr.SitesTableAdapters.PlanTableAdapter()
        Me.PlanTypesTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.PlanTypesTableAdapter()
        Me.BranchTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter()
        Me.BlockTimeSheetClientListTableAdapter1 = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BlockTimeSheetClientListTableAdapter()
        CType(Me.Rpt_PlanClientCostingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PlanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlockTimeSheetClientListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Rpt_PlanClientCostingBindingSource
        '
        Me.Rpt_PlanClientCostingBindingSource.DataMember = "Rpt_PlanClientCosting"
        Me.Rpt_PlanClientCostingBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'LexiconRecManagerDataSet
        '
        Me.LexiconRecManagerDataSet.DataSetName = "LexiconRecManagerDataSet"
        Me.LexiconRecManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 328.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ReportViewer1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.weekenddate, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.plantype, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.branch, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.client, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 5, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1344, 443)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'ReportViewer1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ReportViewer1, 6)
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.DocumentMapWidth = 82
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Rpt_PlanClientCostingBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Lexrecmgr.Client Costing.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(4, 66)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1362, 348)
        Me.ReportViewer1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(420, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "WeekEndingDate"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'weekenddate
        '
        Me.weekenddate.DataSource = Me.PlanBindingSource
        Me.weekenddate.DisplayMember = "WeekEndingDate"
        Me.weekenddate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.weekenddate.FormattingEnabled = True
        Me.weekenddate.Location = New System.Drawing.Point(420, 29)
        Me.weekenddate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.weekenddate.Name = "weekenddate"
        Me.weekenddate.Size = New System.Drawing.Size(225, 24)
        Me.weekenddate.TabIndex = 1
        Me.weekenddate.ValueMember = "WeekEndingDate"
        '
        'PlanBindingSource
        '
        Me.PlanBindingSource.DataMember = "Plan"
        Me.PlanBindingSource.DataSource = Me.Sites
        '
        'Sites
        '
        Me.Sites.DataSetName = "Sites"
        Me.Sites.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'plantype
        '
        Me.plantype.DataSource = Me.PlanTypesBindingSource
        Me.plantype.DisplayMember = "PlanName"
        Me.plantype.Dock = System.Windows.Forms.DockStyle.Fill
        Me.plantype.FormattingEnabled = True
        Me.plantype.Location = New System.Drawing.Point(155, 29)
        Me.plantype.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.plantype.Name = "plantype"
        Me.plantype.Size = New System.Drawing.Size(257, 24)
        Me.plantype.TabIndex = 1
        Me.plantype.ValueMember = "PlanName"
        '
        'PlanTypesBindingSource
        '
        Me.PlanTypesBindingSource.DataMember = "PlanTypes"
        Me.PlanTypesBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'branch
        '
        Me.branch.DataSource = Me.BranchBindingSource
        Me.branch.DisplayMember = "Branch"
        Me.branch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.branch.FormattingEnabled = True
        Me.branch.Location = New System.Drawing.Point(4, 29)
        Me.branch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.branch.Name = "branch"
        Me.branch.Size = New System.Drawing.Size(143, 24)
        Me.branch.TabIndex = 8
        Me.branch.ValueMember = "Branch"
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(4, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Branch"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(155, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Plan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'client
        '
        Me.client.DataSource = Me.BlockTimeSheetClientListBindingSource
        Me.client.DisplayMember = "ClientCode"
        Me.client.FormattingEnabled = True
        Me.client.Location = New System.Drawing.Point(653, 29)
        Me.client.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.client.Name = "client"
        Me.client.Size = New System.Drawing.Size(155, 24)
        Me.client.TabIndex = 12
        Me.client.ValueMember = "ClientCode"
        '
        'BlockTimeSheetClientListBindingSource
        '
        Me.BlockTimeSheetClientListBindingSource.DataMember = "BlockTimeSheetClientList"
        Me.BlockTimeSheetClientListBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(653, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 25)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Client"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(826, 29)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Run Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1046, 29)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(260, 29)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "E-Mail Me The Report"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Rpt_PlanClientCostingTableAdapter
        '
        Me.Rpt_PlanClientCostingTableAdapter.ClearBeforeFill = True
        '
        'BlockTimeSheetClientListTableAdapter
        '
        Me.BlockTimeSheetClientListTableAdapter.ClearBeforeFill = True
        '
        'PlanTableAdapter
        '
        Me.PlanTableAdapter.ClearBeforeFill = True
        '
        'PlanTypesTableAdapter
        '
        Me.PlanTypesTableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'BlockTimeSheetClientListTableAdapter1
        '
        Me.BlockTimeSheetClientListTableAdapter1.ClearBeforeFill = True
        '
        'Reports_PlanClientCosting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 443)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Reports_PlanClientCosting"
        Me.Text = "Reports_Planview"
        CType(Me.Rpt_PlanClientCostingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PlanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlockTimeSheetClientListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents plantype As System.Windows.Forms.ComboBox
    Friend WithEvents weekenddate As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents branch As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents client As System.Windows.Forms.ComboBox
    Friend WithEvents Rpt_PlanClientCostingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LexiconRecManagerDataSet As Lexrecmgr.LexiconRecManagerDataSet
    Friend WithEvents Rpt_PlanClientCostingTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.Rpt_PlanClientCostingTableAdapter
    Friend WithEvents BlockTimeSheetClientListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BlockTimeSheetClientListTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BlockTimeSheetClientListTableAdapter
    Friend WithEvents Sites As Lexrecmgr.Sites
    Friend WithEvents PlanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanTableAdapter As Lexrecmgr.SitesTableAdapters.PlanTableAdapter
    Friend WithEvents PlanTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanTypesTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.PlanTypesTableAdapter
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents BlockTimeSheetClientListTableAdapter1 As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BlockTimeSheetClientListTableAdapter
End Class
