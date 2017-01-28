<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports_Planview
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
        Me.Rpt_PlanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LexiconRecManagerDataSet = New Lexrecmgr.LexiconRecManagerDataSet()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PlanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sites = New Lexrecmgr.Sites()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PlanTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataTable1TableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.DataTable1TableAdapter()
        Me.TableAdapterManager = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager()
        Me.PlanTypesTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.PlanTypesTableAdapter()
        Me.PlanTableAdapter = New Lexrecmgr.SitesTableAdapters.PlanTableAdapter()
        Me.Rpt_PlanTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.Rpt_PlanTableAdapter()
        Me.BranchTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter()
        CType(Me.Rpt_PlanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PlanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Rpt_PlanBindingSource
        '
        Me.Rpt_PlanBindingSource.DataMember = "Rpt_Plan"
        Me.Rpt_PlanBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'LexiconRecManagerDataSet
        '
        Me.LexiconRecManagerDataSet.DataSetName = "LexiconRecManagerDataSet"
        Me.LexiconRecManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "Rpt_Plan"
        Me.DataTable1BindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 281.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 413.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ReportViewer1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox2, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 4, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1344, 443)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'ReportViewer1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ReportViewer1, 5)
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.DocumentMapWidth = 82
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Rpt_PlanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Lexrecmgr.Plan.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(4, 65)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1336, 374)
        Me.ReportViewer1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(420, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "WeekEndingDate"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.PlanBindingSource
        Me.ComboBox2.DisplayMember = "WeekEndingDate"
        Me.ComboBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(420, 27)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(225, 24)
        Me.ComboBox2.TabIndex = 1
        Me.ComboBox2.ValueMember = "WeekEndingDate"
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
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.PlanTypesBindingSource
        Me.ComboBox1.DisplayMember = "PlanName"
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(155, 27)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(257, 24)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "PlanTypeID"
        '
        'PlanTypesBindingSource
        '
        Me.PlanTypesBindingSource.DataMember = "PlanTypes"
        Me.PlanTypesBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.BranchBindingSource
        Me.ComboBox3.DisplayMember = "Branch"
        Me.ComboBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(4, 27)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(143, 24)
        Me.ComboBox3.TabIndex = 8
        Me.ComboBox3.ValueMember = "BranchID"
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
        Me.Label3.Size = New System.Drawing.Size(143, 23)
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
        Me.Label1.Size = New System.Drawing.Size(257, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Plan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(653, 27)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(203, 30)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Run Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(934, 27)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(317, 30)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "E-Mail Me The Report"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ApplicationAreasTableAdapter = Nothing
        Me.TableAdapterManager.ApplicationTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BranchTableAdapter = Nothing
        Me.TableAdapterManager.BranchUserSecurityTableAdapter = Nothing
        Me.TableAdapterManager.CanvassJobCatContactsTableAdapter = Nothing
        Me.TableAdapterManager.CanvassJobCatsTableAdapter = Nothing
        Me.TableAdapterManager.CanvassRegisterTableAdapter = Nothing
        Me.TableAdapterManager.CompanyContactsTableAdapter = Nothing
        Me.TableAdapterManager.ControlsTableAdapter = Nothing
        Me.TableAdapterManager.CountersTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesBranchFilterTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeSelect1TableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.HolidaysTableAdapter = Nothing
        Me.TableAdapterManager.Import_EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.JobCategoryTableAdapter = Nothing
        Me.TableAdapterManager.Plan1TableAdapter = Nothing
        Me.TableAdapterManager.Plan2PerRecordTableAdapter = Nothing
        Me.TableAdapterManager.PlanInvoiceTableAdapter = Nothing
        Me.TableAdapterManager.PlanTableAdapter = Nothing
        Me.TableAdapterManager.PlanTypesTableAdapter = Me.PlanTypesTableAdapter
        Me.TableAdapterManager.SchemesTableAdapter = Nothing
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.uk_postcodesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Lexrecmgr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.WeeknumbersTableAdapter = Nothing
        '
        'PlanTypesTableAdapter
        '
        Me.PlanTypesTableAdapter.ClearBeforeFill = True
        '
        'PlanTableAdapter
        '
        Me.PlanTableAdapter.ClearBeforeFill = True
        '
        'Rpt_PlanTableAdapter
        '
        Me.Rpt_PlanTableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'Reports_Planview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 443)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Reports_Planview"
        Me.Text = "Reports_Planview"
        CType(Me.Rpt_PlanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PlanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LexiconRecManagerDataSet As Lexrecmgr.LexiconRecManagerDataSet
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1TableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.DataTable1TableAdapter
    Friend WithEvents TableAdapterManager As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlanTypesTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.PlanTypesTableAdapter
    Friend WithEvents PlanTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sites As Lexrecmgr.Sites
    Friend WithEvents PlanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanTableAdapter As Lexrecmgr.SitesTableAdapters.PlanTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Rpt_PlanTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.Rpt_PlanTableAdapter
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Rpt_PlanBindingSource As System.Windows.Forms.BindingSource
End Class
