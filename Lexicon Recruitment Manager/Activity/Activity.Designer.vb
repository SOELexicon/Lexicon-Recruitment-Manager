<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Activity
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Activity))
        Me.LexiconManagemnetToolsDataSet = New Lexrecmgr.LexiconManagemnetToolsDataSet()
        Me.ActivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivityTableAdapter = New Lexrecmgr.LexiconManagemnetToolsDataSetTableAdapters.ActivityTableAdapter()
        Me.TableAdapterManager = New Lexrecmgr.LexiconManagemnetToolsDataSetTableAdapters.TableAdapterManager()
        Me.ActivityBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ActivityBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ActivityGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colActivityId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeekEndingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranchId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BranchBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LexiconRecManagerDataSet = New Lexrecmgr.LexiconRecManagerDataSet()
        Me.colPlanTypeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PlanTypesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.colPlanErrors = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTempsOut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClients = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCancelled = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDNGNoCall = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDNGCalled = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInterviews = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommableMargin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlanErrorsPct = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDNGNCPct = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDNGCPct = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ActivityIdSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.WeekEndingDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.PlanErrorsSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.TempsOutSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ClientsSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.FTSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.CancelledSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.STSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DNGNoCallSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DNGCalledSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.RSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.UBSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.InterviewsSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.CommableMarginSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.PlanErrorsPctSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DNGNCPctSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DNGCPctSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.BranchIdSpinEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanTypeIdSpinEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.PlanTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BranchTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter()
        Me.PlanTypesTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.PlanTypesTableAdapter()
        CType(Me.LexiconManagemnetToolsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActivityBindingNavigator.SuspendLayout()
        CType(Me.ActivityGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanTypesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ActivityIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeekEndingDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeekEndingDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanErrorsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TempsOutSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FTSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelledSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DNGNoCallSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DNGCalledSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UBSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InterviewsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommableMarginSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanErrorsPctSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DNGNCPctSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DNGCPctSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanTypeIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LexiconManagemnetToolsDataSet
        '
        Me.LexiconManagemnetToolsDataSet.DataSetName = "LexiconManagemnetToolsDataSet"
        Me.LexiconManagemnetToolsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActivityBindingSource
        '
        Me.ActivityBindingSource.DataMember = "Activity"
        Me.ActivityBindingSource.DataSource = Me.LexiconManagemnetToolsDataSet
        '
        'ActivityTableAdapter
        '
        Me.ActivityTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActivityTableAdapter = Me.ActivityTableAdapter
        Me.TableAdapterManager.AssetsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ConsultantsTableAdapter = Nothing
        Me.TableAdapterManager.InterviewsTableAdapter = Nothing
        Me.TableAdapterManager.NewCompaniesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Lexrecmgr.LexiconManagemnetToolsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VisitsTableAdapter = Nothing
        Me.TableAdapterManager.WarningsTableAdapter = Nothing
        '
        'ActivityBindingNavigator
        '
        Me.ActivityBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ActivityBindingNavigator.AutoSize = False
        Me.ActivityBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.ActivityBindingNavigator.BindingSource = Me.ActivityBindingSource
        Me.ActivityBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ActivityBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ActivityBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.ActivityBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ActivityBindingNavigatorSaveItem})
        Me.ActivityBindingNavigator.Location = New System.Drawing.Point(12, 12)
        Me.ActivityBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ActivityBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ActivityBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ActivityBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ActivityBindingNavigator.Name = "ActivityBindingNavigator"
        Me.ActivityBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ActivityBindingNavigator.Size = New System.Drawing.Size(1181, 30)
        Me.ActivityBindingNavigator.TabIndex = 0
        Me.ActivityBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 27)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'ActivityBindingNavigatorSaveItem
        '
        Me.ActivityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ActivityBindingNavigatorSaveItem.Image = CType(resources.GetObject("ActivityBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ActivityBindingNavigatorSaveItem.Name = "ActivityBindingNavigatorSaveItem"
        Me.ActivityBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 27)
        Me.ActivityBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ActivityGridControl
        '
        Me.ActivityGridControl.DataSource = Me.ActivityBindingSource
        Me.ActivityGridControl.Location = New System.Drawing.Point(12, 126)
        Me.ActivityGridControl.MainView = Me.GridView1
        Me.ActivityGridControl.Name = "ActivityGridControl"
        Me.ActivityGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.ActivityGridControl.Size = New System.Drawing.Size(1181, 268)
        Me.ActivityGridControl.TabIndex = 20
        Me.ActivityGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colActivityId, Me.colWeekEndingDate, Me.colBranchId, Me.colPlanTypeId, Me.colPlanErrors, Me.colTempsOut, Me.colClients, Me.colFT, Me.colCancelled, Me.colST, Me.colDNGNoCall, Me.colDNGCalled, Me.colR, Me.colUB, Me.colInterviews, Me.colCommableMargin, Me.colPlanErrorsPct, Me.colDNGNCPct, Me.colDNGCPct})
        Me.GridView1.GridControl = Me.ActivityGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'colActivityId
        '
        Me.colActivityId.FieldName = "ActivityId"
        Me.colActivityId.Name = "colActivityId"
        Me.colActivityId.Visible = True
        Me.colActivityId.VisibleIndex = 0
        '
        'colWeekEndingDate
        '
        Me.colWeekEndingDate.FieldName = "WeekEndingDate"
        Me.colWeekEndingDate.Name = "colWeekEndingDate"
        Me.colWeekEndingDate.Visible = True
        Me.colWeekEndingDate.VisibleIndex = 1
        '
        'colBranchId
        '
        Me.colBranchId.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colBranchId.FieldName = "BranchId"
        Me.colBranchId.Name = "colBranchId"
        Me.colBranchId.Visible = True
        Me.colBranchId.VisibleIndex = 2
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.BranchBindingSource1
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Branch"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "BranchID"
        '
        'BranchBindingSource1
        '
        Me.BranchBindingSource1.DataMember = "Branch"
        Me.BranchBindingSource1.DataSource = Me.LexiconRecManagerDataSet
        '
        'LexiconRecManagerDataSet
        '
        Me.LexiconRecManagerDataSet.DataSetName = "LexiconRecManagerDataSet"
        Me.LexiconRecManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colPlanTypeId
        '
        Me.colPlanTypeId.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colPlanTypeId.FieldName = "PlanTypeId"
        Me.colPlanTypeId.Name = "colPlanTypeId"
        Me.colPlanTypeId.Visible = True
        Me.colPlanTypeId.VisibleIndex = 3
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.PlanTypesBindingSource1
        Me.RepositoryItemLookUpEdit2.DisplayMember = "PlanName"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "PlanTypeID"
        '
        'PlanTypesBindingSource1
        '
        Me.PlanTypesBindingSource1.DataMember = "PlanTypes"
        Me.PlanTypesBindingSource1.DataSource = Me.LexiconRecManagerDataSet
        '
        'colPlanErrors
        '
        Me.colPlanErrors.FieldName = "PlanErrors"
        Me.colPlanErrors.Name = "colPlanErrors"
        Me.colPlanErrors.Visible = True
        Me.colPlanErrors.VisibleIndex = 4
        '
        'colTempsOut
        '
        Me.colTempsOut.FieldName = "TempsOut"
        Me.colTempsOut.Name = "colTempsOut"
        Me.colTempsOut.Visible = True
        Me.colTempsOut.VisibleIndex = 5
        '
        'colClients
        '
        Me.colClients.FieldName = "Clients"
        Me.colClients.Name = "colClients"
        Me.colClients.Visible = True
        Me.colClients.VisibleIndex = 6
        '
        'colFT
        '
        Me.colFT.FieldName = "FT"
        Me.colFT.Name = "colFT"
        Me.colFT.Visible = True
        Me.colFT.VisibleIndex = 7
        '
        'colCancelled
        '
        Me.colCancelled.FieldName = "Cancelled"
        Me.colCancelled.Name = "colCancelled"
        Me.colCancelled.Visible = True
        Me.colCancelled.VisibleIndex = 8
        '
        'colST
        '
        Me.colST.FieldName = "ST"
        Me.colST.Name = "colST"
        Me.colST.Visible = True
        Me.colST.VisibleIndex = 9
        '
        'colDNGNoCall
        '
        Me.colDNGNoCall.FieldName = "DNGNoCall"
        Me.colDNGNoCall.Name = "colDNGNoCall"
        Me.colDNGNoCall.Visible = True
        Me.colDNGNoCall.VisibleIndex = 10
        '
        'colDNGCalled
        '
        Me.colDNGCalled.FieldName = "DNGCalled"
        Me.colDNGCalled.Name = "colDNGCalled"
        Me.colDNGCalled.Visible = True
        Me.colDNGCalled.VisibleIndex = 11
        '
        'colR
        '
        Me.colR.FieldName = "R"
        Me.colR.Name = "colR"
        Me.colR.Visible = True
        Me.colR.VisibleIndex = 12
        '
        'colUB
        '
        Me.colUB.FieldName = "UB"
        Me.colUB.Name = "colUB"
        Me.colUB.Visible = True
        Me.colUB.VisibleIndex = 13
        '
        'colInterviews
        '
        Me.colInterviews.FieldName = "Interviews"
        Me.colInterviews.Name = "colInterviews"
        Me.colInterviews.Visible = True
        Me.colInterviews.VisibleIndex = 14
        '
        'colCommableMargin
        '
        Me.colCommableMargin.FieldName = "CommableMargin"
        Me.colCommableMargin.Name = "colCommableMargin"
        Me.colCommableMargin.Visible = True
        Me.colCommableMargin.VisibleIndex = 15
        '
        'colPlanErrorsPct
        '
        Me.colPlanErrorsPct.FieldName = "PlanErrorsPct"
        Me.colPlanErrorsPct.Name = "colPlanErrorsPct"
        Me.colPlanErrorsPct.Visible = True
        Me.colPlanErrorsPct.VisibleIndex = 16
        '
        'colDNGNCPct
        '
        Me.colDNGNCPct.FieldName = "DNGNCPct"
        Me.colDNGNCPct.Name = "colDNGNCPct"
        Me.colDNGNCPct.Visible = True
        Me.colDNGNCPct.VisibleIndex = 17
        '
        'colDNGCPct
        '
        Me.colDNGCPct.FieldName = "DNGCPct"
        Me.colDNGCPct.Name = "colDNGCPct"
        Me.colDNGCPct.Visible = True
        Me.colDNGCPct.VisibleIndex = 18
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ActivityIdSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.WeekEndingDateDateEdit)
        Me.LayoutControl1.Controls.Add(Me.PlanErrorsSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.TempsOutSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.ClientsSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.FTSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.CancelledSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.STSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.DNGNoCallSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.DNGCalledSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.RSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.UBSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.InterviewsSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.CommableMarginSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.PlanErrorsPctSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.DNGNCPctSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.DNGCPctSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.ActivityBindingNavigator)
        Me.LayoutControl1.Controls.Add(Me.ActivityGridControl)
        Me.LayoutControl1.Controls.Add(Me.BranchIdSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.PlanTypeIdSpinEdit)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1205, 406)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ActivityIdSpinEdit
        '
        Me.ActivityIdSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "ActivityId", True))
        Me.ActivityIdSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ActivityIdSpinEdit.Location = New System.Drawing.Point(12, 62)
        Me.ActivityIdSpinEdit.Name = "ActivityIdSpinEdit"
        Me.ActivityIdSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ActivityIdSpinEdit.Size = New System.Drawing.Size(115, 20)
        Me.ActivityIdSpinEdit.StyleController = Me.LayoutControl1
        Me.ActivityIdSpinEdit.TabIndex = 2
        '
        'WeekEndingDateDateEdit
        '
        Me.WeekEndingDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "WeekEndingDate", True))
        Me.WeekEndingDateDateEdit.EditValue = Nothing
        Me.WeekEndingDateDateEdit.Location = New System.Drawing.Point(131, 62)
        Me.WeekEndingDateDateEdit.Name = "WeekEndingDateDateEdit"
        Me.WeekEndingDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WeekEndingDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WeekEndingDateDateEdit.Size = New System.Drawing.Size(115, 20)
        Me.WeekEndingDateDateEdit.StyleController = Me.LayoutControl1
        Me.WeekEndingDateDateEdit.TabIndex = 3
        '
        'PlanErrorsSpinEdit
        '
        Me.PlanErrorsSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "PlanErrors", True))
        Me.PlanErrorsSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PlanErrorsSpinEdit.Location = New System.Drawing.Point(488, 62)
        Me.PlanErrorsSpinEdit.Name = "PlanErrorsSpinEdit"
        Me.PlanErrorsSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PlanErrorsSpinEdit.Size = New System.Drawing.Size(115, 20)
        Me.PlanErrorsSpinEdit.StyleController = Me.LayoutControl1
        Me.PlanErrorsSpinEdit.TabIndex = 5
        '
        'TempsOutSpinEdit
        '
        Me.TempsOutSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "TempsOut", True))
        Me.TempsOutSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TempsOutSpinEdit.Location = New System.Drawing.Point(607, 62)
        Me.TempsOutSpinEdit.Name = "TempsOutSpinEdit"
        Me.TempsOutSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TempsOutSpinEdit.Size = New System.Drawing.Size(114, 20)
        Me.TempsOutSpinEdit.StyleController = Me.LayoutControl1
        Me.TempsOutSpinEdit.TabIndex = 6
        '
        'ClientsSpinEdit
        '
        Me.ClientsSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "Clients", True))
        Me.ClientsSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ClientsSpinEdit.Location = New System.Drawing.Point(725, 62)
        Me.ClientsSpinEdit.Name = "ClientsSpinEdit"
        Me.ClientsSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ClientsSpinEdit.Size = New System.Drawing.Size(232, 20)
        Me.ClientsSpinEdit.StyleController = Me.LayoutControl1
        Me.ClientsSpinEdit.TabIndex = 7
        '
        'FTSpinEdit
        '
        Me.FTSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "FT", True))
        Me.FTSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.FTSpinEdit.Location = New System.Drawing.Point(961, 62)
        Me.FTSpinEdit.Name = "FTSpinEdit"
        Me.FTSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FTSpinEdit.Size = New System.Drawing.Size(113, 20)
        Me.FTSpinEdit.StyleController = Me.LayoutControl1
        Me.FTSpinEdit.TabIndex = 8
        '
        'CancelledSpinEdit
        '
        Me.CancelledSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "Cancelled", True))
        Me.CancelledSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CancelledSpinEdit.Location = New System.Drawing.Point(1078, 62)
        Me.CancelledSpinEdit.Name = "CancelledSpinEdit"
        Me.CancelledSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CancelledSpinEdit.Size = New System.Drawing.Size(115, 20)
        Me.CancelledSpinEdit.StyleController = Me.LayoutControl1
        Me.CancelledSpinEdit.TabIndex = 9
        '
        'STSpinEdit
        '
        Me.STSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "ST", True))
        Me.STSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.STSpinEdit.Location = New System.Drawing.Point(12, 102)
        Me.STSpinEdit.Name = "STSpinEdit"
        Me.STSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.STSpinEdit.Size = New System.Drawing.Size(92, 20)
        Me.STSpinEdit.StyleController = Me.LayoutControl1
        Me.STSpinEdit.TabIndex = 10
        '
        'DNGNoCallSpinEdit
        '
        Me.DNGNoCallSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "DNGNoCall", True))
        Me.DNGNoCallSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DNGNoCallSpinEdit.Location = New System.Drawing.Point(108, 102)
        Me.DNGNoCallSpinEdit.Name = "DNGNoCallSpinEdit"
        Me.DNGNoCallSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DNGNoCallSpinEdit.Size = New System.Drawing.Size(114, 20)
        Me.DNGNoCallSpinEdit.StyleController = Me.LayoutControl1
        Me.DNGNoCallSpinEdit.TabIndex = 11
        '
        'DNGCalledSpinEdit
        '
        Me.DNGCalledSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "DNGCalled", True))
        Me.DNGCalledSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DNGCalledSpinEdit.Location = New System.Drawing.Point(226, 102)
        Me.DNGCalledSpinEdit.Name = "DNGCalledSpinEdit"
        Me.DNGCalledSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DNGCalledSpinEdit.Size = New System.Drawing.Size(104, 20)
        Me.DNGCalledSpinEdit.StyleController = Me.LayoutControl1
        Me.DNGCalledSpinEdit.TabIndex = 12
        '
        'RSpinEdit
        '
        Me.RSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "R", True))
        Me.RSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.RSpinEdit.Location = New System.Drawing.Point(334, 102)
        Me.RSpinEdit.Name = "RSpinEdit"
        Me.RSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RSpinEdit.Size = New System.Drawing.Size(92, 20)
        Me.RSpinEdit.StyleController = Me.LayoutControl1
        Me.RSpinEdit.TabIndex = 13
        '
        'UBSpinEdit
        '
        Me.UBSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "UB", True))
        Me.UBSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UBSpinEdit.Location = New System.Drawing.Point(430, 102)
        Me.UBSpinEdit.Name = "UBSpinEdit"
        Me.UBSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UBSpinEdit.Size = New System.Drawing.Size(92, 20)
        Me.UBSpinEdit.StyleController = Me.LayoutControl1
        Me.UBSpinEdit.TabIndex = 14
        '
        'InterviewsSpinEdit
        '
        Me.InterviewsSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "Interviews", True))
        Me.InterviewsSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.InterviewsSpinEdit.Location = New System.Drawing.Point(526, 102)
        Me.InterviewsSpinEdit.Name = "InterviewsSpinEdit"
        Me.InterviewsSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InterviewsSpinEdit.Size = New System.Drawing.Size(92, 20)
        Me.InterviewsSpinEdit.StyleController = Me.LayoutControl1
        Me.InterviewsSpinEdit.TabIndex = 15
        '
        'CommableMarginSpinEdit
        '
        Me.CommableMarginSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "CommableMargin", True))
        Me.CommableMarginSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CommableMarginSpinEdit.Location = New System.Drawing.Point(622, 102)
        Me.CommableMarginSpinEdit.Name = "CommableMarginSpinEdit"
        Me.CommableMarginSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CommableMarginSpinEdit.Size = New System.Drawing.Size(92, 20)
        Me.CommableMarginSpinEdit.StyleController = Me.LayoutControl1
        Me.CommableMarginSpinEdit.TabIndex = 16
        '
        'PlanErrorsPctSpinEdit
        '
        Me.PlanErrorsPctSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "PlanErrorsPct", True))
        Me.PlanErrorsPctSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PlanErrorsPctSpinEdit.Location = New System.Drawing.Point(718, 102)
        Me.PlanErrorsPctSpinEdit.Name = "PlanErrorsPctSpinEdit"
        Me.PlanErrorsPctSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PlanErrorsPctSpinEdit.Size = New System.Drawing.Size(235, 20)
        Me.PlanErrorsPctSpinEdit.StyleController = Me.LayoutControl1
        Me.PlanErrorsPctSpinEdit.TabIndex = 17
        '
        'DNGNCPctSpinEdit
        '
        Me.DNGNCPctSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "DNGNCPct", True))
        Me.DNGNCPctSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DNGNCPctSpinEdit.Location = New System.Drawing.Point(957, 102)
        Me.DNGNCPctSpinEdit.Name = "DNGNCPctSpinEdit"
        Me.DNGNCPctSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DNGNCPctSpinEdit.Size = New System.Drawing.Size(116, 20)
        Me.DNGNCPctSpinEdit.StyleController = Me.LayoutControl1
        Me.DNGNCPctSpinEdit.TabIndex = 18
        '
        'DNGCPctSpinEdit
        '
        Me.DNGCPctSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "DNGCPct", True))
        Me.DNGCPctSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DNGCPctSpinEdit.Location = New System.Drawing.Point(1077, 102)
        Me.DNGCPctSpinEdit.Name = "DNGCPctSpinEdit"
        Me.DNGCPctSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DNGCPctSpinEdit.Size = New System.Drawing.Size(116, 20)
        Me.DNGCPctSpinEdit.StyleController = Me.LayoutControl1
        Me.DNGCPctSpinEdit.TabIndex = 19
        '
        'BranchIdSpinEdit
        '
        Me.BranchIdSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "BranchId", True))
        Me.BranchIdSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.BranchIdSpinEdit.Location = New System.Drawing.Point(250, 62)
        Me.BranchIdSpinEdit.Name = "BranchIdSpinEdit"
        Me.BranchIdSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BranchIdSpinEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch", "Branch", 43, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BranchName", "Branch Name", 73, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BranchCounter", "Branch Counter", 85, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address1", "Address1", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address2", "Address2", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Town", "Town", 36, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("County", "County", 45, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PostCode", "Post Code", 59, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Telephone", "Telephone", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fax", "Fax", 28, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "Email", 34, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.BranchIdSpinEdit.Properties.DataSource = Me.BranchBindingSource
        Me.BranchIdSpinEdit.Properties.DisplayMember = "Branch"
        Me.BranchIdSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.BranchIdSpinEdit.Properties.NullText = ""
        Me.BranchIdSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BranchIdSpinEdit.Properties.ValueMember = "BranchID"
        Me.BranchIdSpinEdit.Size = New System.Drawing.Size(115, 20)
        Me.BranchIdSpinEdit.StyleController = Me.LayoutControl1
        Me.BranchIdSpinEdit.TabIndex = 4
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'PlanTypeIdSpinEdit
        '
        Me.PlanTypeIdSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ActivityBindingSource, "PlanTypeId", True))
        Me.PlanTypeIdSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PlanTypeIdSpinEdit.Location = New System.Drawing.Point(369, 62)
        Me.PlanTypeIdSpinEdit.Name = "PlanTypeIdSpinEdit"
        Me.PlanTypeIdSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PlanTypeIdSpinEdit.Properties.DataSource = Me.PlanTypesBindingSource
        Me.PlanTypeIdSpinEdit.Properties.DisplayMember = "PlanName"
        Me.PlanTypeIdSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.PlanTypeIdSpinEdit.Properties.NullText = ""
        Me.PlanTypeIdSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PlanTypeIdSpinEdit.Properties.ValueMember = "PlanTypeID"
        Me.PlanTypeIdSpinEdit.Size = New System.Drawing.Size(115, 20)
        Me.PlanTypeIdSpinEdit.StyleController = Me.LayoutControl1
        Me.PlanTypeIdSpinEdit.TabIndex = 4
        '
        'PlanTypesBindingSource
        '
        Me.PlanTypesBindingSource.DataMember = "PlanTypes"
        Me.PlanTypesBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem12, Me.LayoutControlItem1, Me.LayoutControlItem14, Me.LayoutControlItem16, Me.LayoutControlItem22, Me.LayoutControlItem24, Me.LayoutControlItem26, Me.LayoutControlItem18, Me.LayoutControlItem20, Me.LayoutControlItem28, Me.LayoutControlItem30, Me.LayoutControlItem32, Me.LayoutControlItem34, Me.LayoutControlItem36, Me.LayoutControlItem38, Me.LayoutControlItem40})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1205, 406)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ActivityBindingNavigator
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1185, 34)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.ActivityIdSpinEdit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 34)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(119, 40)
        Me.LayoutControlItem4.Text = "Activity Id:"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.WeekEndingDateDateEdit
        Me.LayoutControlItem6.Location = New System.Drawing.Point(119, 34)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(119, 40)
        Me.LayoutControlItem6.Text = "Week Ending Date:"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.BranchIdSpinEdit
        Me.LayoutControlItem8.Location = New System.Drawing.Point(238, 34)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(119, 40)
        Me.LayoutControlItem8.Text = "Branch Id:"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.PlanTypeIdSpinEdit
        Me.LayoutControlItem10.Location = New System.Drawing.Point(357, 34)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(119, 40)
        Me.LayoutControlItem10.Text = "Plan Type Id:"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.PlanErrorsSpinEdit
        Me.LayoutControlItem12.Location = New System.Drawing.Point(476, 34)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(119, 40)
        Me.LayoutControlItem12.Text = "Plan Errors:"
        Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ActivityGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 114)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1185, 272)
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.TempsOutSpinEdit
        Me.LayoutControlItem14.Location = New System.Drawing.Point(595, 34)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(118, 40)
        Me.LayoutControlItem14.Text = "Temps Out:"
        Me.LayoutControlItem14.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.ClientsSpinEdit
        Me.LayoutControlItem16.Location = New System.Drawing.Point(713, 34)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(236, 40)
        Me.LayoutControlItem16.Text = "Clients:"
        Me.LayoutControlItem16.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.STSpinEdit
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(96, 40)
        Me.LayoutControlItem22.Text = "ST:"
        Me.LayoutControlItem22.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.DNGNoCallSpinEdit
        Me.LayoutControlItem24.Location = New System.Drawing.Point(96, 74)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(118, 40)
        Me.LayoutControlItem24.Text = "DNGNo Call:"
        Me.LayoutControlItem24.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.DNGCalledSpinEdit
        Me.LayoutControlItem26.Location = New System.Drawing.Point(214, 74)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(108, 40)
        Me.LayoutControlItem26.Text = "DNGCalled:"
        Me.LayoutControlItem26.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.FTSpinEdit
        Me.LayoutControlItem18.Location = New System.Drawing.Point(949, 34)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(117, 40)
        Me.LayoutControlItem18.Text = "FT:"
        Me.LayoutControlItem18.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.CancelledSpinEdit
        Me.LayoutControlItem20.Location = New System.Drawing.Point(1066, 34)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(119, 40)
        Me.LayoutControlItem20.Text = "Cancelled:"
        Me.LayoutControlItem20.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.RSpinEdit
        Me.LayoutControlItem28.Location = New System.Drawing.Point(322, 74)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(96, 40)
        Me.LayoutControlItem28.Text = "R:"
        Me.LayoutControlItem28.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.UBSpinEdit
        Me.LayoutControlItem30.Location = New System.Drawing.Point(418, 74)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(96, 40)
        Me.LayoutControlItem30.Text = "UB:"
        Me.LayoutControlItem30.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.InterviewsSpinEdit
        Me.LayoutControlItem32.Location = New System.Drawing.Point(514, 74)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(96, 40)
        Me.LayoutControlItem32.Text = "Interviews:"
        Me.LayoutControlItem32.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.CommableMarginSpinEdit
        Me.LayoutControlItem34.Location = New System.Drawing.Point(610, 74)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(96, 40)
        Me.LayoutControlItem34.Text = "Commable Margin:"
        Me.LayoutControlItem34.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.Control = Me.PlanErrorsPctSpinEdit
        Me.LayoutControlItem36.Location = New System.Drawing.Point(706, 74)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(239, 40)
        Me.LayoutControlItem36.Text = "Plan Errors Pct:"
        Me.LayoutControlItem36.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem38
        '
        Me.LayoutControlItem38.Control = Me.DNGNCPctSpinEdit
        Me.LayoutControlItem38.Location = New System.Drawing.Point(945, 74)
        Me.LayoutControlItem38.Name = "LayoutControlItem38"
        Me.LayoutControlItem38.Size = New System.Drawing.Size(120, 40)
        Me.LayoutControlItem38.Text = "DNGNCPct:"
        Me.LayoutControlItem38.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem38.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem40
        '
        Me.LayoutControlItem40.Control = Me.DNGCPctSpinEdit
        Me.LayoutControlItem40.Location = New System.Drawing.Point(1065, 74)
        Me.LayoutControlItem40.Name = "LayoutControlItem40"
        Me.LayoutControlItem40.Size = New System.Drawing.Size(120, 40)
        Me.LayoutControlItem40.Text = "DNGCPct:"
        Me.LayoutControlItem40.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem40.TextSize = New System.Drawing.Size(92, 13)
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'PlanTypesTableAdapter
        '
        Me.PlanTypesTableAdapter.ClearBeforeFill = True
        '
        'Activity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1205, 406)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "Activity"
        Me.Text = "Activity"
        CType(Me.LexiconManagemnetToolsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActivityBindingNavigator.ResumeLayout(False)
        Me.ActivityBindingNavigator.PerformLayout()
        CType(Me.ActivityGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanTypesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ActivityIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeekEndingDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeekEndingDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanErrorsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TempsOutSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FTSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelledSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DNGNoCallSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DNGCalledSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UBSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InterviewsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommableMarginSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanErrorsPctSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DNGNCPctSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DNGCPctSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanTypeIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LexiconManagemnetToolsDataSet As Lexrecmgr.LexiconManagemnetToolsDataSet
    Friend WithEvents ActivityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivityTableAdapter As Lexrecmgr.LexiconManagemnetToolsDataSetTableAdapters.ActivityTableAdapter
    Friend WithEvents TableAdapterManager As Lexrecmgr.LexiconManagemnetToolsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ActivityBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ActivityBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ActivityGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colActivityId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeekEndingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanErrors As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTempsOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClients As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCancelled As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDNGNoCall As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDNGCalled As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInterviews As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommableMargin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanErrorsPct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDNGNCPct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDNGCPct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents ActivityIdSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents WeekEndingDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PlanErrorsSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TempsOutSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ClientsSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents FTSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CancelledSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents STSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DNGNoCallSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DNGCalledSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents RSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents UBSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents InterviewsSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CommableMarginSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PlanErrorsPctSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DNGNCPctSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DNGCPctSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents BranchIdSpinEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LexiconRecManagerDataSet As Lexrecmgr.LexiconRecManagerDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents PlanTypeIdSpinEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PlanTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanTypesTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.PlanTypesTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BranchBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PlanTypesBindingSource1 As System.Windows.Forms.BindingSource
End Class
