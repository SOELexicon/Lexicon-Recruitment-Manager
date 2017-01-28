<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports_ConfirmationOfRates
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
        Me.Rpt_ConfirmationOfRates1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LexiconRecManagerDataSet = New Lexrecmgr.LexiconRecManagerDataSet()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LexiconRecManagerDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rpt_ConfirmationOfRates1TableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.Rpt_ConfirmationOfRates1TableAdapter()
        CType(Me.Rpt_ConfirmationOfRates1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LexiconRecManagerDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Rpt_ConfirmationOfRates1BindingSource
        '
        Me.Rpt_ConfirmationOfRates1BindingSource.DataMember = "Rpt_ConfirmationOfRates1"
        Me.Rpt_ConfirmationOfRates1BindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'LexiconRecManagerDataSet
        '
        Me.LexiconRecManagerDataSet.DataSetName = "LexiconRecManagerDataSet"
        Me.LexiconRecManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 277.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 281.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 413.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ReportViewer1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 3, 1)
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
        ReportDataSource1.Value = Me.Rpt_ConfirmationOfRates1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Lexrecmgr.ConfirmationOfRates.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(4, 65)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1336, 374)
        Me.ReportViewer1.TabIndex = 3
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'ComboBox1
        '
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Basic Rates", "AWR WK 13 Rates", "Rates 2", "Rates 3"})
        Me.ComboBox1.Location = New System.Drawing.Point(281, 27)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(131, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(4, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(269, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ClientCode"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(281, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Rate"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(4, 27)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(268, 22)
        Me.TextBox1.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(420, 27)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(225, 30)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Run Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(653, 27)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(273, 30)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "E-Mail Me The Report"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LexiconRecManagerDataSetBindingSource
        '
        Me.LexiconRecManagerDataSetBindingSource.DataSource = Me.LexiconRecManagerDataSet
        Me.LexiconRecManagerDataSetBindingSource.Position = 0
        '
        'Rpt_ConfirmationOfRates1TableAdapter
        '
        Me.Rpt_ConfirmationOfRates1TableAdapter.ClearBeforeFill = True
        '
        'Reports_ConfirmationOfRates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 443)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Reports_ConfirmationOfRates"
        Me.Text = "Reports_Planview"
        CType(Me.Rpt_ConfirmationOfRates1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.LexiconRecManagerDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Rpt_ConfirmationOfRates1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LexiconRecManagerDataSet As Lexrecmgr.LexiconRecManagerDataSet
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LexiconRecManagerDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rpt_ConfirmationOfRates1TableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.Rpt_ConfirmationOfRates1TableAdapter
End Class
