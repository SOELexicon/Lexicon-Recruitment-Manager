<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Holidays
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Holidays))
        Me.ArchiveAll = New System.Windows.Forms.Button()
        Me.UnlockAll = New System.Windows.Forms.Button()
        Me.LockAll = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.HolidaysWeekendingDropdownBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sites = New Lexrecmgr.Sites()
        Me.HolidayIDTextBox = New System.Windows.Forms.TextBox()
        Me.HolidaysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LexiconRecManagerDataSet = New Lexrecmgr.LexiconRecManagerDataSet()
        Me.EmployeeIdComboBox = New System.Windows.Forms.ComboBox()
        Me.HolidayEmployeeDropdownBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateAddedTextBox = New System.Windows.Forms.TextBox()
        Me.SystemTypeTextBox = New System.Windows.Forms.TextBox()
        Me.WeekendingdateTextBox = New System.Windows.Forms.TextBox()
        Me.Accruedadj = New System.Windows.Forms.TextBox()
        Me.WeekEndingDateIfLateTextBox = New System.Windows.Forms.TextBox()
        Me.HolidayFormReceivedCheckBox = New System.Windows.Forms.CheckBox()
        Me.HollidayFormReceivedLMUTextBox = New System.Windows.Forms.TextBox()
        Me.HollidayFormReceivedLMDTextBox = New System.Windows.Forms.TextBox()
        Me.MondayCheckBox = New System.Windows.Forms.CheckBox()
        Me.TuesdayCheckBox = New System.Windows.Forms.CheckBox()
        Me.WednesdayCheckBox = New System.Windows.Forms.CheckBox()
        Me.ThursdayCheckBox = New System.Windows.Forms.CheckBox()
        Me.FridayCheckBox = New System.Windows.Forms.CheckBox()
        Me.SaturdayCheckBox = New System.Windows.Forms.CheckBox()
        Me.SundayCheckBox = New System.Windows.Forms.CheckBox()
        Me.LastModifiedUserTextBox = New System.Windows.Forms.TextBox()
        Me.LastModifiedDateTextBox = New System.Windows.Forms.TextBox()
        Me.HollidayGridViewDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnlockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchiveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HollidayGridViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchCB = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HolidaysBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.HolidaysBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.HolidaysTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.HolidaysTableAdapter()
        Me.BranchTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter()
        Me.TableAdapterManager1 = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager()
        Me.TableAdapterManager = New Lexrecmgr.SitesTableAdapters.TableAdapterManager()
        Me.HollidayGridViewTableAdapter = New Lexrecmgr.SitesTableAdapters.HollidayGridViewTableAdapter()
        Me.HolidaysWeekendingDropdownTableAdapter = New Lexrecmgr.SitesTableAdapters.HolidaysWeekendingDropdownTableAdapter()
        Me.HolidayEmployeeDropdownTableAdapter = New Lexrecmgr.SitesTableAdapters.HolidayEmployeeDropdownTableAdapter()
        CType(Me.HolidaysWeekendingDropdownBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HolidaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HolidayEmployeeDropdownBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HollidayGridViewDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.HollidayGridViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HolidaysBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HolidaysBindingNavigator.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ArchiveAll
        '
        Me.ArchiveAll.Location = New System.Drawing.Point(1166, 75)
        Me.ArchiveAll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ArchiveAll.Name = "ArchiveAll"
        Me.ArchiveAll.Size = New System.Drawing.Size(81, 45)
        Me.ArchiveAll.TabIndex = 2
        Me.ArchiveAll.Text = "Archive All"
        Me.ArchiveAll.UseVisualStyleBackColor = True
        '
        'UnlockAll
        '
        Me.UnlockAll.Location = New System.Drawing.Point(1087, 75)
        Me.UnlockAll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UnlockAll.Name = "UnlockAll"
        Me.UnlockAll.Size = New System.Drawing.Size(73, 45)
        Me.UnlockAll.TabIndex = 2
        Me.UnlockAll.Text = "Unlock All"
        Me.UnlockAll.UseVisualStyleBackColor = True
        '
        'LockAll
        '
        Me.LockAll.Location = New System.Drawing.Point(979, 75)
        Me.LockAll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LockAll.Name = "LockAll"
        Me.LockAll.Size = New System.Drawing.Size(102, 45)
        Me.LockAll.TabIndex = 2
        Me.LockAll.Text = "Lock All"
        Me.LockAll.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.HolidaysWeekendingDropdownBindingSource
        Me.ComboBox2.DisplayMember = "Weekendingdate"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(639, 94)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(334, 24)
        Me.ComboBox2.TabIndex = 0
        Me.ComboBox2.ValueMember = "Weekendingdate"
        '
        'HolidaysWeekendingDropdownBindingSource
        '
        Me.HolidaysWeekendingDropdownBindingSource.DataMember = "HolidaysWeekendingDropdown"
        Me.HolidaysWeekendingDropdownBindingSource.DataSource = Me.Sites
        '
        'Sites
        '
        Me.Sites.DataSetName = "Sites"
        Me.Sites.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HolidayIDTextBox
        '
        Me.HolidayIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HolidaysBindingSource, "HolidayID", True))
        Me.HolidayIDTextBox.Enabled = False
        Me.HolidayIDTextBox.Location = New System.Drawing.Point(31, 145)
        Me.HolidayIDTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HolidayIDTextBox.Name = "HolidayIDTextBox"
        Me.HolidayIDTextBox.Size = New System.Drawing.Size(334, 25)
        Me.HolidayIDTextBox.TabIndex = 1
        '
        'HolidaysBindingSource
        '
        Me.HolidaysBindingSource.DataMember = "Holidays"
        Me.HolidaysBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'LexiconRecManagerDataSet
        '
        Me.LexiconRecManagerDataSet.DataSetName = "LexiconRecManagerDataSet"
        Me.LexiconRecManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeIdComboBox
        '
        Me.EmployeeIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HolidaysBindingSource, "EmployeeId", True))
        Me.EmployeeIdComboBox.DataSource = Me.HolidayEmployeeDropdownBindingSource
        Me.EmployeeIdComboBox.DisplayMember = "employeecode"
        Me.EmployeeIdComboBox.Enabled = False
        Me.EmployeeIdComboBox.FormattingEnabled = True
        Me.EmployeeIdComboBox.Location = New System.Drawing.Point(568, 195)
        Me.EmployeeIdComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmployeeIdComboBox.Name = "EmployeeIdComboBox"
        Me.EmployeeIdComboBox.Size = New System.Drawing.Size(209, 24)
        Me.EmployeeIdComboBox.TabIndex = 3
        Me.EmployeeIdComboBox.ValueMember = "employeeid"
        '
        'HolidayEmployeeDropdownBindingSource
        '
        Me.HolidayEmployeeDropdownBindingSource.DataMember = "HolidayEmployeeDropdown"
        Me.HolidayEmployeeDropdownBindingSource.DataSource = Me.Sites
        '
        'DateAddedTextBox
        '
        Me.DateAddedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HolidaysBindingSource, "DateAdded", True))
        Me.DateAddedTextBox.Enabled = False
        Me.DateAddedTextBox.Location = New System.Drawing.Point(371, 145)
        Me.DateAddedTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateAddedTextBox.Name = "DateAddedTextBox"
        Me.DateAddedTextBox.Size = New System.Drawing.Size(334, 25)
        Me.DateAddedTextBox.TabIndex = 5
        '
        'SystemTypeTextBox
        '
        Me.SystemTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HolidaysBindingSource, "SystemType", True))
        Me.SystemTypeTextBox.Enabled = False
        Me.SystemTypeTextBox.Location = New System.Drawing.Point(711, 145)
        Me.SystemTypeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SystemTypeTextBox.Name = "SystemTypeTextBox"
        Me.SystemTypeTextBox.Size = New System.Drawing.Size(333, 25)
        Me.SystemTypeTextBox.TabIndex = 7
        '
        'WeekendingdateTextBox
        '
        Me.WeekendingdateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HolidaysBindingSource, "Weekendingdate", True))
        Me.WeekendingdateTextBox.Enabled = False
        Me.WeekendingdateTextBox.Location = New System.Drawing.Point(129, 195)
        Me.WeekendingdateTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WeekendingdateTextBox.Name = "WeekendingdateTextBox"
        Me.WeekendingdateTextBox.Size = New System.Drawing.Size(214, 25)
        Me.WeekendingdateTextBox.TabIndex = 9
        '
        'Accruedadj
        '
        Me.Accruedadj.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HolidaysBindingSource, "AccruedAdj", True))
        Me.Accruedadj.Location = New System.Drawing.Point(1050, 145)
        Me.Accruedadj.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Accruedadj.Name = "Accruedadj"
        Me.Accruedadj.ReadOnly = True
        Me.Accruedadj.Size = New System.Drawing.Size(500, 25)
        Me.Accruedadj.TabIndex = 11
        '
        'WeekEndingDateIfLateTextBox
        '
        Me.WeekEndingDateIfLateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HolidaysBindingSource, "WeekEndingDateIfLate", True))
        Me.WeekEndingDateIfLateTextBox.Enabled = False
        Me.WeekEndingDateIfLateTextBox.Location = New System.Drawing.Point(349, 195)
        Me.WeekEndingDateIfLateTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WeekEndingDateIfLateTextBox.Name = "WeekEndingDateIfLateTextBox"
        Me.WeekEndingDateIfLateTextBox.Size = New System.Drawing.Size(213, 25)
        Me.WeekEndingDateIfLateTextBox.TabIndex = 11
        '
        'HolidayFormReceivedCheckBox
        '
        Me.HolidayFormReceivedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.HolidaysBindingSource, "HolidayFormReceived", True))
        Me.HolidayFormReceivedCheckBox.Location = New System.Drawing.Point(31, 176)
        Me.HolidayFormReceivedCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HolidayFormReceivedCheckBox.Name = "HolidayFormReceivedCheckBox"
        Me.HolidayFormReceivedCheckBox.Size = New System.Drawing.Size(92, 35)
        Me.HolidayFormReceivedCheckBox.TabIndex = 13
        Me.HolidayFormReceivedCheckBox.Text = "Holiday Form Received:"
        Me.HolidayFormReceivedCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.HolidayFormReceivedCheckBox.UseVisualStyleBackColor = True
        '
        'HollidayFormReceivedLMUTextBox
        '
        Me.HollidayFormReceivedLMUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HolidaysBindingSource, "HollidayFormReceivedLMU", True))
        Me.HollidayFormReceivedLMUTextBox.Enabled = False
        Me.HollidayFormReceivedLMUTextBox.Location = New System.Drawing.Point(31, 276)
        Me.HollidayFormReceivedLMUTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HollidayFormReceivedLMUTextBox.Name = "HollidayFormReceivedLMUTextBox"
        Me.HollidayFormReceivedLMUTextBox.Size = New System.Drawing.Size(289, 25)
        Me.HollidayFormReceivedLMUTextBox.TabIndex = 15
        '
        'HollidayFormReceivedLMDTextBox
        '
        Me.HollidayFormReceivedLMDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HolidaysBindingSource, "HollidayFormReceivedLMD", True))
        Me.HollidayFormReceivedLMDTextBox.Enabled = False
        Me.HollidayFormReceivedLMDTextBox.Location = New System.Drawing.Point(326, 276)
        Me.HollidayFormReceivedLMDTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HollidayFormReceivedLMDTextBox.Name = "HollidayFormReceivedLMDTextBox"
        Me.HollidayFormReceivedLMDTextBox.Size = New System.Drawing.Size(236, 25)
        Me.HollidayFormReceivedLMDTextBox.TabIndex = 17
        '
        'MondayCheckBox
        '
        Me.MondayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.HolidaysBindingSource, "Monday", True))
        Me.MondayCheckBox.Enabled = False
        Me.MondayCheckBox.Location = New System.Drawing.Point(796, 213)
        Me.MondayCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MondayCheckBox.MaximumSize = New System.Drawing.Size(56, 25)
        Me.MondayCheckBox.MinimumSize = New System.Drawing.Size(56, 25)
        Me.MondayCheckBox.Name = "MondayCheckBox"
        Me.MondayCheckBox.Size = New System.Drawing.Size(56, 25)
        Me.MondayCheckBox.TabIndex = 19
        Me.MondayCheckBox.Text = "Mon"
        Me.MondayCheckBox.UseVisualStyleBackColor = True
        '
        'TuesdayCheckBox
        '
        Me.TuesdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.HolidaysBindingSource, "Tuesday", True))
        Me.TuesdayCheckBox.Enabled = False
        Me.TuesdayCheckBox.Location = New System.Drawing.Point(858, 213)
        Me.TuesdayCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TuesdayCheckBox.MaximumSize = New System.Drawing.Size(56, 25)
        Me.TuesdayCheckBox.MinimumSize = New System.Drawing.Size(56, 25)
        Me.TuesdayCheckBox.Name = "TuesdayCheckBox"
        Me.TuesdayCheckBox.Size = New System.Drawing.Size(56, 25)
        Me.TuesdayCheckBox.TabIndex = 21
        Me.TuesdayCheckBox.Text = "Tue"
        Me.TuesdayCheckBox.UseVisualStyleBackColor = True
        '
        'WednesdayCheckBox
        '
        Me.WednesdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.HolidaysBindingSource, "Wednesday", True))
        Me.WednesdayCheckBox.Enabled = False
        Me.WednesdayCheckBox.Location = New System.Drawing.Point(920, 213)
        Me.WednesdayCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WednesdayCheckBox.MaximumSize = New System.Drawing.Size(56, 25)
        Me.WednesdayCheckBox.MinimumSize = New System.Drawing.Size(56, 25)
        Me.WednesdayCheckBox.Name = "WednesdayCheckBox"
        Me.WednesdayCheckBox.Size = New System.Drawing.Size(56, 25)
        Me.WednesdayCheckBox.TabIndex = 23
        Me.WednesdayCheckBox.Text = "Wed"
        Me.WednesdayCheckBox.UseVisualStyleBackColor = True
        '
        'ThursdayCheckBox
        '
        Me.ThursdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.HolidaysBindingSource, "Thursday", True))
        Me.ThursdayCheckBox.Enabled = False
        Me.ThursdayCheckBox.Location = New System.Drawing.Point(982, 213)
        Me.ThursdayCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ThursdayCheckBox.MaximumSize = New System.Drawing.Size(62, 25)
        Me.ThursdayCheckBox.MinimumSize = New System.Drawing.Size(62, 25)
        Me.ThursdayCheckBox.Name = "ThursdayCheckBox"
        Me.ThursdayCheckBox.Size = New System.Drawing.Size(62, 25)
        Me.ThursdayCheckBox.TabIndex = 25
        Me.ThursdayCheckBox.Text = "Thurs"
        Me.ThursdayCheckBox.UseVisualStyleBackColor = True
        '
        'FridayCheckBox
        '
        Me.FridayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.HolidaysBindingSource, "Friday", True))
        Me.FridayCheckBox.Enabled = False
        Me.FridayCheckBox.Location = New System.Drawing.Point(1050, 213)
        Me.FridayCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FridayCheckBox.MaximumSize = New System.Drawing.Size(56, 25)
        Me.FridayCheckBox.MinimumSize = New System.Drawing.Size(56, 25)
        Me.FridayCheckBox.Name = "FridayCheckBox"
        Me.FridayCheckBox.Size = New System.Drawing.Size(56, 25)
        Me.FridayCheckBox.TabIndex = 27
        Me.FridayCheckBox.Text = "Fri"
        Me.FridayCheckBox.UseVisualStyleBackColor = True
        '
        'SaturdayCheckBox
        '
        Me.SaturdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.HolidaysBindingSource, "Saturday", True))
        Me.SaturdayCheckBox.Enabled = False
        Me.SaturdayCheckBox.Location = New System.Drawing.Point(1112, 213)
        Me.SaturdayCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SaturdayCheckBox.MaximumSize = New System.Drawing.Size(56, 25)
        Me.SaturdayCheckBox.MinimumSize = New System.Drawing.Size(56, 25)
        Me.SaturdayCheckBox.Name = "SaturdayCheckBox"
        Me.SaturdayCheckBox.Size = New System.Drawing.Size(56, 25)
        Me.SaturdayCheckBox.TabIndex = 29
        Me.SaturdayCheckBox.Text = "Sat"
        Me.SaturdayCheckBox.UseVisualStyleBackColor = True
        '
        'SundayCheckBox
        '
        Me.SundayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.HolidaysBindingSource, "Sunday", True))
        Me.SundayCheckBox.Enabled = False
        Me.SundayCheckBox.Location = New System.Drawing.Point(1174, 213)
        Me.SundayCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SundayCheckBox.MaximumSize = New System.Drawing.Size(56, 25)
        Me.SundayCheckBox.MinimumSize = New System.Drawing.Size(56, 25)
        Me.SundayCheckBox.Name = "SundayCheckBox"
        Me.SundayCheckBox.Size = New System.Drawing.Size(56, 25)
        Me.SundayCheckBox.TabIndex = 31
        Me.SundayCheckBox.Text = "Sun"
        Me.SundayCheckBox.UseVisualStyleBackColor = True
        '
        'LastModifiedUserTextBox
        '
        Me.LastModifiedUserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HolidaysBindingSource, "LastModifiedUser", True))
        Me.LastModifiedUserTextBox.Enabled = False
        Me.LastModifiedUserTextBox.Location = New System.Drawing.Point(568, 276)
        Me.LastModifiedUserTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LastModifiedUserTextBox.Name = "LastModifiedUserTextBox"
        Me.LastModifiedUserTextBox.Size = New System.Drawing.Size(194, 25)
        Me.LastModifiedUserTextBox.TabIndex = 33
        '
        'LastModifiedDateTextBox
        '
        Me.LastModifiedDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HolidaysBindingSource, "LastModifiedDate", True))
        Me.LastModifiedDateTextBox.Enabled = False
        Me.LastModifiedDateTextBox.Location = New System.Drawing.Point(768, 276)
        Me.LastModifiedDateTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LastModifiedDateTextBox.Name = "LastModifiedDateTextBox"
        Me.LastModifiedDateTextBox.Size = New System.Drawing.Size(782, 25)
        Me.LastModifiedDateTextBox.TabIndex = 35
        '
        'HollidayGridViewDataGridView
        '
        Me.HollidayGridViewDataGridView.AutoGenerateColumns = False
        Me.HollidayGridViewDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.HollidayGridViewDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewCheckBoxColumn5, Me.DataGridViewCheckBoxColumn6, Me.DataGridViewCheckBoxColumn7, Me.DataGridViewCheckBoxColumn8, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.HollidayGridViewDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.HollidayGridViewDataGridView.DataSource = Me.HollidayGridViewBindingSource
        Me.HollidayGridViewDataGridView.Location = New System.Drawing.Point(31, 443)
        Me.HollidayGridViewDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HollidayGridViewDataGridView.MultiSelect = False
        Me.HollidayGridViewDataGridView.Name = "HollidayGridViewDataGridView"
        Me.HollidayGridViewDataGridView.ReadOnly = True
        Me.HollidayGridViewDataGridView.Size = New System.Drawing.Size(1519, 298)
        Me.HollidayGridViewDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "HolidayID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "HolidayID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BranchID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "BranchID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SystemType"
        Me.DataGridViewTextBoxColumn3.HeaderText = "System Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EmployeeCode"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Employee Code"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Forename"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Forename"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 60
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "EmployeeSystemType"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Employee System Type"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 55
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Scheme"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Scheme"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 50
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "LastWorkedDate"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Last Worked Date"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 80
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Weekendingdate"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Week Ending Date"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 80
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "WeekEndingDateIfLate"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Week Ending Date If Late"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 80
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "HolidayFormReceived"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Holiday Form Received"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "HollidayFormReceivedLMU"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Holliday Form Received LMU"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 50
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "HollidayFormReceivedLMD"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Holliday Form Received LMD"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 50
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Monday"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Monday"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Width = 50
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Tuesday"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Tuesday"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        Me.DataGridViewCheckBoxColumn3.Width = 50
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "Wednesday"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "Wednesday"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.ReadOnly = True
        Me.DataGridViewCheckBoxColumn4.Width = 50
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "Thursday"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "Thursday"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        Me.DataGridViewCheckBoxColumn5.ReadOnly = True
        Me.DataGridViewCheckBoxColumn5.Width = 55
        '
        'DataGridViewCheckBoxColumn6
        '
        Me.DataGridViewCheckBoxColumn6.DataPropertyName = "Friday"
        Me.DataGridViewCheckBoxColumn6.HeaderText = "Friday"
        Me.DataGridViewCheckBoxColumn6.Name = "DataGridViewCheckBoxColumn6"
        Me.DataGridViewCheckBoxColumn6.ReadOnly = True
        Me.DataGridViewCheckBoxColumn6.Width = 45
        '
        'DataGridViewCheckBoxColumn7
        '
        Me.DataGridViewCheckBoxColumn7.DataPropertyName = "Saturday"
        Me.DataGridViewCheckBoxColumn7.HeaderText = "Saturday"
        Me.DataGridViewCheckBoxColumn7.Name = "DataGridViewCheckBoxColumn7"
        Me.DataGridViewCheckBoxColumn7.ReadOnly = True
        Me.DataGridViewCheckBoxColumn7.Width = 50
        '
        'DataGridViewCheckBoxColumn8
        '
        Me.DataGridViewCheckBoxColumn8.DataPropertyName = "Sunday"
        Me.DataGridViewCheckBoxColumn8.HeaderText = "Sunday"
        Me.DataGridViewCheckBoxColumn8.Name = "DataGridViewCheckBoxColumn8"
        Me.DataGridViewCheckBoxColumn8.ReadOnly = True
        Me.DataGridViewCheckBoxColumn8.Width = 50
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "LastModifiedUser"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Last Modified User"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 80
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "LastModifiedDate"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Last Modified Date"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 80
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "DaysAccrued"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Days Accrued"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 50
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "DaysTaken"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Days Taken"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 50
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "DaysLeft"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Days Left"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 50
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "DailyHolidayRate"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Daily Holiday Rate"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 50
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Expr1"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Total Pay:"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 50
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LockToolStripMenuItem, Me.UnlockToolStripMenuItem, Me.ArchiveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(128, 76)
        '
        'LockToolStripMenuItem
        '
        Me.LockToolStripMenuItem.Name = "LockToolStripMenuItem"
        Me.LockToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.LockToolStripMenuItem.Text = "Lock"
        '
        'UnlockToolStripMenuItem
        '
        Me.UnlockToolStripMenuItem.Name = "UnlockToolStripMenuItem"
        Me.UnlockToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.UnlockToolStripMenuItem.Text = "Unlock"
        '
        'ArchiveToolStripMenuItem
        '
        Me.ArchiveToolStripMenuItem.Name = "ArchiveToolStripMenuItem"
        Me.ArchiveToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.ArchiveToolStripMenuItem.Text = "Archive"
        '
        'HollidayGridViewBindingSource
        '
        Me.HollidayGridViewBindingSource.DataMember = "HollidayGridView"
        Me.HollidayGridViewBindingSource.DataSource = Me.Sites
        '
        'BranchCB
        '
        Me.BranchCB.DataSource = Me.BranchBindingSource
        Me.BranchCB.DisplayMember = "Branch"
        Me.BranchCB.FormattingEnabled = True
        Me.BranchCB.Location = New System.Drawing.Point(31, 94)
        Me.BranchCB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BranchCB.Name = "BranchCB"
        Me.BranchCB.Size = New System.Drawing.Size(602, 24)
        Me.BranchCB.TabIndex = 0
        Me.BranchCB.ValueMember = "BranchID"
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 35)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'HolidaysBindingNavigator
        '
        Me.HolidaysBindingNavigator.AddNewItem = Nothing
        Me.HolidaysBindingNavigator.AutoSize = False
        Me.HolidaysBindingNavigator.BindingSource = Me.HolidaysBindingSource
        Me.HolidaysBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HolidaysBindingNavigator.DeleteItem = Nothing
        Me.HolidaysBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.HolidaysBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HolidaysBindingNavigatorSaveItem})
        Me.HolidaysBindingNavigator.Location = New System.Drawing.Point(16, 16)
        Me.HolidaysBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HolidaysBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HolidaysBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HolidaysBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HolidaysBindingNavigator.Name = "HolidaysBindingNavigator"
        Me.HolidaysBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HolidaysBindingNavigator.Size = New System.Drawing.Size(1549, 38)
        Me.HolidaysBindingNavigator.TabIndex = 1
        Me.HolidaysBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'HolidaysBindingNavigatorSaveItem
        '
        Me.HolidaysBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HolidaysBindingNavigatorSaveItem.Image = CType(resources.GetObject("HolidaysBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HolidaysBindingNavigatorSaveItem.Name = "HolidaysBindingNavigatorSaveItem"
        Me.HolidaysBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 35)
        Me.HolidaysBindingNavigatorSaveItem.Text = "Save Data"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.HollidayGridViewDataGridView)
        Me.LayoutControl1.Controls.Add(Me.EmployeeIdComboBox)
        Me.LayoutControl1.Controls.Add(Me.ArchiveAll)
        Me.LayoutControl1.Controls.Add(Me.HolidayIDTextBox)
        Me.LayoutControl1.Controls.Add(Me.LockAll)
        Me.LayoutControl1.Controls.Add(Me.UnlockAll)
        Me.LayoutControl1.Controls.Add(Me.WeekendingdateTextBox)
        Me.LayoutControl1.Controls.Add(Me.DateAddedTextBox)
        Me.LayoutControl1.Controls.Add(Me.HollidayFormReceivedLMUTextBox)
        Me.LayoutControl1.Controls.Add(Me.HollidayFormReceivedLMDTextBox)
        Me.LayoutControl1.Controls.Add(Me.LastModifiedUserTextBox)
        Me.LayoutControl1.Controls.Add(Me.LastModifiedDateTextBox)
        Me.LayoutControl1.Controls.Add(Me.WeekEndingDateIfLateTextBox)
        Me.LayoutControl1.Controls.Add(Me.SystemTypeTextBox)
        Me.LayoutControl1.Controls.Add(Me.Accruedadj)
        Me.LayoutControl1.Controls.Add(Me.HolidayFormReceivedCheckBox)
        Me.LayoutControl1.Controls.Add(Me.HolidaysBindingNavigator)
        Me.LayoutControl1.Controls.Add(Me.ComboBox2)
        Me.LayoutControl1.Controls.Add(Me.BranchCB)
        Me.LayoutControl1.Controls.Add(Me.MondayCheckBox)
        Me.LayoutControl1.Controls.Add(Me.TuesdayCheckBox)
        Me.LayoutControl1.Controls.Add(Me.WednesdayCheckBox)
        Me.LayoutControl1.Controls.Add(Me.ThursdayCheckBox)
        Me.LayoutControl1.Controls.Add(Me.FridayCheckBox)
        Me.LayoutControl1.Controls.Add(Me.SaturdayCheckBox)
        Me.LayoutControl1.Controls.Add(Me.SundayCheckBox)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1581, 772)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1581, 772)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.HolidaysBindingNavigator
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1555, 44)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.LayoutControlGroup3, Me.LayoutControlItem22, Me.LayoutControlItem26, Me.EmptySpaceItem3, Me.EmptySpaceItem5, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 44)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1555, 702)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.BranchCB
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(608, 51)
        Me.LayoutControlItem2.Text = "Branch:"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(166, 16)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.ComboBox2
        Me.LayoutControlItem3.Location = New System.Drawing.Point(608, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(340, 51)
        Me.LayoutControlItem3.Text = "Week Ending Date:"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(166, 16)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.LockAll
        Me.LayoutControlItem4.Location = New System.Drawing.Point(948, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(108, 51)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.UnlockAll
        Me.LayoutControlItem5.Location = New System.Drawing.Point(1056, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(79, 51)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.ArchiveAll
        Me.LayoutControlItem6.Location = New System.Drawing.Point(1135, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(87, 51)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.HolidayIDTextBox
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 51)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(340, 50)
        Me.LayoutControlItem7.Text = "Holiday ID:"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(166, 16)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.DateAddedTextBox
        Me.LayoutControlItem8.Location = New System.Drawing.Point(340, 51)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(340, 50)
        Me.LayoutControlItem8.Text = "Date Added:"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(166, 16)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.SystemTypeTextBox
        Me.LayoutControlItem9.Location = New System.Drawing.Point(680, 51)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(339, 50)
        Me.LayoutControlItem9.Text = "System Type:"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(166, 16)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.Accruedadj
        Me.LayoutControlItem10.Location = New System.Drawing.Point(1019, 51)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(506, 50)
        Me.LayoutControlItem10.Text = "Accrued Adjustment"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(166, 16)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.HollidayGridViewDataGridView
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 368)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(1525, 304)
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.HolidayFormReceivedCheckBox
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 101)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(98, 41)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(98, 41)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(98, 81)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.Text = "Holiday Form Received"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.WeekendingdateTextBox
        Me.LayoutControlItem20.Location = New System.Drawing.Point(98, 101)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(220, 81)
        Me.LayoutControlItem20.Text = "Week Ending Date"
        Me.LayoutControlItem20.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(166, 16)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.WeekEndingDateIfLateTextBox
        Me.LayoutControlItem21.Location = New System.Drawing.Point(318, 101)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(219, 81)
        Me.LayoutControlItem21.Text = "Week Ending Date If Late:"
        Me.LayoutControlItem21.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(166, 16)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.HollidayFormReceivedLMUTextBox
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 182)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(295, 50)
        Me.LayoutControlItem23.Text = "Holliday Form Received LMU:"
        Me.LayoutControlItem23.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(166, 16)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.HollidayFormReceivedLMDTextBox
        Me.LayoutControlItem24.Location = New System.Drawing.Point(295, 182)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(242, 50)
        Me.LayoutControlItem24.Text = "Holliday Form Received LMD:"
        Me.LayoutControlItem24.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(166, 16)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.LastModifiedUserTextBox
        Me.LayoutControlItem25.Location = New System.Drawing.Point(537, 182)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(200, 50)
        Me.LayoutControlItem25.Text = "Last Modified User:"
        Me.LayoutControlItem25.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(166, 16)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.EmptySpaceItem2})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(752, 101)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(568, 81)
        Me.LayoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.LayoutControlGroup3.Text = "Days"
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.MondayCheckBox
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(62, 31)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.TuesdayCheckBox
        Me.LayoutControlItem13.Location = New System.Drawing.Point(62, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(62, 31)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.WednesdayCheckBox
        Me.LayoutControlItem14.Location = New System.Drawing.Point(124, 0)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(62, 31)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.ThursdayCheckBox
        Me.LayoutControlItem15.Location = New System.Drawing.Point(186, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(68, 31)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.FridayCheckBox
        Me.LayoutControlItem16.Location = New System.Drawing.Point(254, 0)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(62, 31)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.SaturdayCheckBox
        Me.LayoutControlItem17.Location = New System.Drawing.Point(316, 0)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(62, 31)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.SundayCheckBox
        Me.LayoutControlItem18.Location = New System.Drawing.Point(378, 0)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(62, 31)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(440, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(102, 31)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.EmployeeIdComboBox
        Me.LayoutControlItem22.Location = New System.Drawing.Point(537, 101)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(215, 81)
        Me.LayoutControlItem22.Text = "Employee"
        Me.LayoutControlItem22.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(166, 16)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.LastModifiedDateTextBox
        Me.LayoutControlItem26.Location = New System.Drawing.Point(737, 182)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(788, 50)
        Me.LayoutControlItem26.Text = "Last Modified Date:"
        Me.LayoutControlItem26.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(166, 16)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(1320, 101)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(205, 81)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(1222, 0)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(303, 51)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 232)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(1525, 136)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'HolidaysTableAdapter
        '
        Me.HolidaysTableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.ApplicationAreasTableAdapter = Nothing
        Me.TableAdapterManager1.ApplicationTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.BranchTableAdapter = Nothing
        Me.TableAdapterManager1.BranchUserSecurityTableAdapter = Nothing
        Me.TableAdapterManager1.CanvassJobCatContactsTableAdapter = Nothing
        Me.TableAdapterManager1.CanvassJobCatsTableAdapter = Nothing
        Me.TableAdapterManager1.CanvassRegisterTableAdapter = Nothing
        Me.TableAdapterManager1.CompanyContactsTableAdapter = Nothing
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.ControlsTableAdapter = Nothing
        Me.TableAdapterManager1.CountersTableAdapter = Nothing
        Me.TableAdapterManager1.EmployeesBranchFilterTableAdapter = Nothing
        Me.TableAdapterManager1.EmployeeSelect1TableAdapter = Nothing
        Me.TableAdapterManager1.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager1.HolidaysTableAdapter = Nothing
        Me.TableAdapterManager1.Import_EmployeesTableAdapter = Nothing
        Me.TableAdapterManager1.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager1.JobCategoryTableAdapter = Nothing
        Me.TableAdapterManager1.Plan1TableAdapter = Nothing
        Me.TableAdapterManager1.Plan2PerRecordTableAdapter = Nothing
        Me.TableAdapterManager1.PlanInvoiceTableAdapter = Nothing
        Me.TableAdapterManager1.PlanTableAdapter = Nothing
        Me.TableAdapterManager1.PlanTypesTableAdapter = Nothing
        Me.TableAdapterManager1.SchemesTableAdapter = Nothing
        Me.TableAdapterManager1.SitesTableAdapter = Nothing
        Me.TableAdapterManager1.uk_postcodesTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Lexrecmgr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UsersTableAdapter = Nothing
        Me.TableAdapterManager1.WeeknumbersTableAdapter = Nothing
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BanksTableAdapter = Nothing
        Me.TableAdapterManager.CompanyContactsTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.EmployeesMoneyOwedTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.HolidaysTableAdapter = Nothing
        Me.TableAdapterManager.JobCategoryTableAdapter = Nothing
        Me.TableAdapterManager.PlanTypesTableAdapter = Nothing
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Lexrecmgr.SitesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'HollidayGridViewTableAdapter
        '
        Me.HollidayGridViewTableAdapter.ClearBeforeFill = True
        '
        'HolidaysWeekendingDropdownTableAdapter
        '
        Me.HolidaysWeekendingDropdownTableAdapter.ClearBeforeFill = True
        '
        'HolidayEmployeeDropdownTableAdapter
        '
        Me.HolidayEmployeeDropdownTableAdapter.ClearBeforeFill = True
        '
        'Holidays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1581, 772)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Holidays"
        Me.Text = ","
        CType(Me.HolidaysWeekendingDropdownBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HolidaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HolidayEmployeeDropdownBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HollidayGridViewDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.HollidayGridViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HolidaysBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HolidaysBindingNavigator.ResumeLayout(False)
        Me.HolidaysBindingNavigator.PerformLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Sites As Lexrecmgr.Sites
    Friend WithEvents TableAdapterManager As Lexrecmgr.SitesTableAdapters.TableAdapterManager
    Friend WithEvents HollidayGridViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HollidayGridViewTableAdapter As Lexrecmgr.SitesTableAdapters.HollidayGridViewTableAdapter
    Friend WithEvents HollidayGridViewDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents BranchCB As System.Windows.Forms.ComboBox
    Friend WithEvents LexiconRecManagerDataSet As Lexrecmgr.LexiconRecManagerDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents HolidaysWeekendingDropdownBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HolidaysWeekendingDropdownTableAdapter As Lexrecmgr.SitesTableAdapters.HolidaysWeekendingDropdownTableAdapter
    Friend WithEvents HolidayEmployeeDropdownBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HolidayEmployeeDropdownTableAdapter As Lexrecmgr.SitesTableAdapters.HolidayEmployeeDropdownTableAdapter
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents HolidaysBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents HolidaysBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents HolidaysBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HolidaysTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.HolidaysTableAdapter
    Friend WithEvents TableAdapterManager1 As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HolidayIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DateAddedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SystemTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WeekendingdateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WeekEndingDateIfLateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HolidayFormReceivedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HollidayFormReceivedLMUTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HollidayFormReceivedLMDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MondayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TuesdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents WednesdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ThursdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FridayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SaturdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SundayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LastModifiedUserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastModifiedDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LockAll As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnlockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchiveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Accruedadj As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn6 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn7 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn8 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArchiveAll As System.Windows.Forms.Button
    Friend WithEvents UnlockAll As System.Windows.Forms.Button
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
End Class
