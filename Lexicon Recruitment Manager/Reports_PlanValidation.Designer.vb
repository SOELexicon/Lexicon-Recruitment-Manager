<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports_PlanValidation
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
        Me.RptPlanValidationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LexiconRecManagerDataSet1 = New Lexrecmgr.LexiconRecManagerDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PlanTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PlanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sites = New Lexrecmgr.Sites()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.BranchTableAdapter1 = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter()
        Me.PlanTableAdapter = New Lexrecmgr.SitesTableAdapters.PlanTableAdapter()
        Me.PlanTypesTableAdapter1 = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.PlanTypesTableAdapter()
        Me.Rpt_PlanValidationTableAdapter1 = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.Rpt_PlanValidationTableAdapter()
        CType(Me.RptPlanValidationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexiconRecManagerDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sites, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RptPlanValidationBindingSource
        '
        Me.RptPlanValidationBindingSource.DataMember = "Rpt_PlanValidation"
        Me.RptPlanValidationBindingSource.DataSource = Me.LexiconRecManagerDataSet1
        '
        'LexiconRecManagerDataSet1
        '
        Me.LexiconRecManagerDataSet1.DataSetName = "LexiconRecManagerDataSet"
        Me.LexiconRecManagerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(116, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Plan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Branch"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.BranchBindingSource
        Me.ComboBox3.DisplayMember = "Branch"
        Me.ComboBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(3, 23)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(107, 21)
        Me.ComboBox3.TabIndex = 8
        Me.ComboBox3.ValueMember = "BranchID"
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.LexiconRecManagerDataSet1
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.PlanTypesBindingSource
        Me.ComboBox1.DisplayMember = "PlanName"
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(116, 23)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(193, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "PlanTypeID"
        '
        'PlanTypesBindingSource
        '
        Me.PlanTypesBindingSource.DataMember = "PlanTypes"
        Me.PlanTypesBindingSource.DataSource = Me.LexiconRecManagerDataSet1
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.PlanBindingSource
        Me.ComboBox2.DisplayMember = "WeekEndingDate"
        Me.ComboBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(315, 23)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(169, 21)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(315, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "WeekEndingDate"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(623, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Run Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(729, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(242, 24)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "E-Mail Me The Report"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ReportViewer1, 6)
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.DocumentMapWidth = 82
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.RptPlanValidationBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Lexrecmgr.Plan Validation.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 53)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1002, 304)
        Me.ReportViewer1.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 282.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ReportViewer1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox2, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox4, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 5, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1008, 360)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'ComboBox4
        '
        Me.ComboBox4.DataSource = Me.RptPlanValidationBindingSource
        Me.ComboBox4.DisplayMember = "Weekendingdate"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(490, 23)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 10
        '
        'BranchTableAdapter1
        '
        Me.BranchTableAdapter1.ClearBeforeFill = True
        '
        'PlanTableAdapter
        '
        Me.PlanTableAdapter.ClearBeforeFill = True
        '
        'PlanTypesTableAdapter1
        '
        Me.PlanTypesTableAdapter1.ClearBeforeFill = True
        '
        'Rpt_PlanValidationTableAdapter1
        '
        Me.Rpt_PlanValidationTableAdapter1.ClearBeforeFill = True
        '
        'Reports_PlanValidation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 360)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Reports_PlanValidation"
        Me.Text = "Reports_Planview"
        CType(Me.RptPlanValidationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexiconRecManagerDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sites, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents LexiconRecManagerDataSet As Lexrecmgr.LexiconRecManagerDataSet
    Friend WithEvents DataTable1TableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.DataTable1TableAdapter
    Friend WithEvents TableAdapterManager As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlanTypesTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.PlanTypesTableAdapter
    Friend WithEvents Rpt_PlanTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.Rpt_PlanTableAdapter
    Friend WithEvents BranchTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents Rpt_PlanValidationTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.Rpt_PlanValidationTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LexiconRecManagerDataSet1 As Lexrecmgr.LexiconRecManagerDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter1 As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents Sites As Lexrecmgr.Sites
    Friend WithEvents PlanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanTableAdapter As Lexrecmgr.SitesTableAdapters.PlanTableAdapter
    Friend WithEvents PlanTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanTypesTableAdapter1 As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.PlanTypesTableAdapter
    Friend WithEvents RptPlanValidationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rpt_PlanValidationTableAdapter1 As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.Rpt_PlanValidationTableAdapter
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
End Class
