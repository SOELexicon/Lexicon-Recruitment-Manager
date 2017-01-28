<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports_BlockTimesheet
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
        Me.BlockTimesheetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LexiconRecManagerDataSet = New Lexrecmgr.LexiconRecManagerDataSet()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.WeekEndDate = New System.Windows.Forms.ComboBox()
        Me.PlanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sites = New Lexrecmgr.Sites()
        Me.Plan = New System.Windows.Forms.ComboBox()
        Me.PlanTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LexiconRecManagerDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Branch = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Branch1 = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Client = New System.Windows.Forms.ComboBox()
        Me.BlockTimeSheetClientListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BranchTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter()
        Me.PlanTypesTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.PlanTypesTableAdapter()
        Me.BlockTimeSheetClientListTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BlockTimeSheetClientListTableAdapter()
        Me.BlockTimesheetTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BlockTimesheetTableAdapter()
        Me.PlanTableAdapter = New Lexrecmgr.SitesTableAdapters.PlanTableAdapter()
        CType(Me.BlockTimesheetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PlanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexiconRecManagerDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlockTimeSheetClientListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BlockTimesheetBindingSource
        '
        Me.BlockTimesheetBindingSource.DataMember = "BlockTimesheet"
        Me.BlockTimesheetBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'LexiconRecManagerDataSet
        '
        Me.LexiconRecManagerDataSet.DataSetName = "LexiconRecManagerDataSet"
        Me.LexiconRecManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 277.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.WeekEndDate, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Plan, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Branch, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Branch1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Client, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 5, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1344, 443)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'WeekEndDate
        '
        Me.WeekEndDate.DataSource = Me.PlanBindingSource
        Me.WeekEndDate.DisplayMember = "WeekEndingDate"
        Me.WeekEndDate.FormattingEnabled = True
        Me.WeekEndDate.Location = New System.Drawing.Point(420, 27)
        Me.WeekEndDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.WeekEndDate.Name = "WeekEndDate"
        Me.WeekEndDate.Size = New System.Drawing.Size(183, 24)
        Me.WeekEndDate.TabIndex = 12
        Me.WeekEndDate.ValueMember = "WeekEndingDate"
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
        'Plan
        '
        Me.Plan.DataSource = Me.PlanTypesBindingSource
        Me.Plan.DisplayMember = "PlanName"
        Me.Plan.FormattingEnabled = True
        Me.Plan.Location = New System.Drawing.Point(281, 27)
        Me.Plan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Plan.Name = "Plan"
        Me.Plan.Size = New System.Drawing.Size(129, 24)
        Me.Plan.TabIndex = 11
        Me.Plan.ValueMember = "PlanName"
        '
        'PlanTypesBindingSource
        '
        Me.PlanTypesBindingSource.DataMember = "PlanTypes"
        Me.PlanTypesBindingSource.DataSource = Me.LexiconRecManagerDataSetBindingSource
        '
        'LexiconRecManagerDataSetBindingSource
        '
        Me.LexiconRecManagerDataSetBindingSource.DataSource = Me.LexiconRecManagerDataSet
        Me.LexiconRecManagerDataSetBindingSource.Position = 0
        '
        'Branch
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Branch, 6)
        Me.Branch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Branch.DocumentMapWidth = 82
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.BlockTimesheetBindingSource
        Me.Branch.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Branch.LocalReport.ReportEmbeddedResource = "Lexrecmgr.BlockTimesheet.rdlc"
        Me.Branch.Location = New System.Drawing.Point(4, 65)
        Me.Branch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Branch.Name = "Branch"
        Me.Branch.Size = New System.Drawing.Size(1336, 374)
        Me.Branch.TabIndex = 3
        Me.Branch.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'Branch1
        '
        Me.Branch1.DataSource = Me.BranchBindingSource
        Me.Branch1.DisplayMember = "Branch"
        Me.Branch1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Branch1.FormattingEnabled = True
        Me.Branch1.Location = New System.Drawing.Point(4, 27)
        Me.Branch1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Branch1.Name = "Branch1"
        Me.Branch1.Size = New System.Drawing.Size(269, 24)
        Me.Branch1.TabIndex = 1
        Me.Branch1.ValueMember = "Branch"
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.LexiconRecManagerDataSetBindingSource
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(831, 27)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(225, 30)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Run Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Client
        '
        Me.Client.DataSource = Me.BlockTimeSheetClientListBindingSource
        Me.Client.DisplayMember = "ClientCode"
        Me.Client.FormattingEnabled = True
        Me.Client.Location = New System.Drawing.Point(635, 27)
        Me.Client.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Client.Name = "Client"
        Me.Client.Size = New System.Drawing.Size(160, 24)
        Me.Client.TabIndex = 13
        Me.Client.ValueMember = "CompanyID"
        '
        'BlockTimeSheetClientListBindingSource
        '
        Me.BlockTimeSheetClientListBindingSource.DataMember = "BlockTimeSheetClientList"
        Me.BlockTimeSheetClientListBindingSource.DataSource = Me.LexiconRecManagerDataSetBindingSource
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(281, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(420, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(635, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Label4"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1064, 27)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(276, 30)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "E-Mail Me The Report"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'PlanTypesTableAdapter
        '
        Me.PlanTypesTableAdapter.ClearBeforeFill = True
        '
        'BlockTimeSheetClientListTableAdapter
        '
        Me.BlockTimeSheetClientListTableAdapter.ClearBeforeFill = True
        '
        'BlockTimesheetTableAdapter
        '
        Me.BlockTimesheetTableAdapter.ClearBeforeFill = True
        '
        'PlanTableAdapter
        '
        Me.PlanTableAdapter.ClearBeforeFill = True
        '
        'Reports_BlockTimesheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 443)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Reports_BlockTimesheet"
        Me.Text = "Reports_Planview"
        CType(Me.BlockTimesheetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PlanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexiconRecManagerDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlockTimeSheetClientListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Branch As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Branch1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LexiconRecManagerDataSet As LexrecMGr.LexiconRecManagerDataSet
    Friend WithEvents LexiconRecManagerDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WeekEndDate As System.Windows.Forms.ComboBox
    Friend WithEvents Plan As System.Windows.Forms.ComboBox
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As LexrecMGr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents PlanTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanTypesTableAdapter As LexrecMGr.LexiconRecManagerDataSetTableAdapters.PlanTypesTableAdapter
    Friend WithEvents Client As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BlockTimeSheetClientListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BlockTimeSheetClientListTableAdapter As LexrecMGr.LexiconRecManagerDataSetTableAdapters.BlockTimeSheetClientListTableAdapter
    Friend WithEvents BlockTimesheetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BlockTimesheetTableAdapter As LexrecMGr.LexiconRecManagerDataSetTableAdapters.BlockTimesheetTableAdapter
    Friend WithEvents Sites As LexrecMGr.Sites
    Friend WithEvents PlanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanTableAdapter As LexrecMGr.SitesTableAdapters.PlanTableAdapter
End Class
