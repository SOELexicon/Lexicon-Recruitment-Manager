<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanTypes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlanTypes))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.PlanTypeIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.PlanTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LexiconRecManagerDataSet = New Lexrecmgr.LexiconRecManagerDataSet()
        Me.PlanNameTextBox = New System.Windows.Forms.TextBox()
        Me.PlanTypesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PlanTypesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PlanTypesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPlanTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlanName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.PlanTypesTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.PlanTypesTableAdapter()
        Me.TableAdapterManager = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.PlanTypeIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanTypesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlanTypesBindingNavigator.SuspendLayout()
        CType(Me.PlanTypesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.PlanTypeIDSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.PlanNameTextBox)
        Me.LayoutControl1.Controls.Add(Me.PlanTypesBindingNavigator)
        Me.LayoutControl1.Controls.Add(Me.PlanTypesGridControl)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1518, 842)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'PlanTypeIDSpinEdit
        '
        Me.PlanTypeIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PlanTypesBindingSource, "PlanTypeID", True))
        Me.PlanTypeIDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PlanTypeIDSpinEdit.Location = New System.Drawing.Point(96, 60)
        Me.PlanTypeIDSpinEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PlanTypeIDSpinEdit.Name = "PlanTypeIDSpinEdit"
        Me.PlanTypeIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PlanTypeIDSpinEdit.Properties.ReadOnly = True
        Me.PlanTypeIDSpinEdit.Size = New System.Drawing.Size(171, 22)
        Me.PlanTypeIDSpinEdit.StyleController = Me.LayoutControl1
        Me.PlanTypeIDSpinEdit.TabIndex = 7
        '
        'PlanTypesBindingSource
        '
        Me.PlanTypesBindingSource.DataMember = "PlanTypes"
        Me.PlanTypesBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'LexiconRecManagerDataSet
        '
        Me.LexiconRecManagerDataSet.DataSetName = "LexiconRecManagerDataSet"
        Me.LexiconRecManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlanNameTextBox
        '
        Me.PlanNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanTypesBindingSource, "PlanName", True))
        Me.PlanNameTextBox.Location = New System.Drawing.Point(353, 60)
        Me.PlanNameTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PlanNameTextBox.Name = "PlanNameTextBox"
        Me.PlanNameTextBox.Size = New System.Drawing.Size(1149, 25)
        Me.PlanNameTextBox.TabIndex = 9
        '
        'PlanTypesBindingNavigator
        '
        Me.PlanTypesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PlanTypesBindingNavigator.AutoSize = False
        Me.PlanTypesBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.PlanTypesBindingNavigator.BindingSource = Me.PlanTypesBindingSource
        Me.PlanTypesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PlanTypesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PlanTypesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.PlanTypesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PlanTypesBindingNavigatorSaveItem})
        Me.PlanTypesBindingNavigator.Location = New System.Drawing.Point(16, 16)
        Me.PlanTypesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PlanTypesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PlanTypesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PlanTypesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PlanTypesBindingNavigator.Name = "PlanTypesBindingNavigator"
        Me.PlanTypesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PlanTypesBindingNavigator.Size = New System.Drawing.Size(1486, 38)
        Me.PlanTypesBindingNavigator.TabIndex = 1
        Me.PlanTypesBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 35)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 38)
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'PlanTypesBindingNavigatorSaveItem
        '
        Me.PlanTypesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PlanTypesBindingNavigatorSaveItem.Image = CType(resources.GetObject("PlanTypesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PlanTypesBindingNavigatorSaveItem.Name = "PlanTypesBindingNavigatorSaveItem"
        Me.PlanTypesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 35)
        Me.PlanTypesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PlanTypesGridControl
        '
        Me.PlanTypesGridControl.DataSource = Me.PlanTypesBindingSource
        Me.PlanTypesGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PlanTypesGridControl.Location = New System.Drawing.Point(16, 91)
        Me.PlanTypesGridControl.MainView = Me.GridView1
        Me.PlanTypesGridControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PlanTypesGridControl.Name = "PlanTypesGridControl"
        Me.PlanTypesGridControl.Size = New System.Drawing.Size(1486, 735)
        Me.PlanTypesGridControl.TabIndex = 4
        Me.PlanTypesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPlanTypeID, Me.colPlanName})
        Me.GridView1.GridControl = Me.PlanTypesGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'colPlanTypeID
        '
        Me.colPlanTypeID.FieldName = "PlanTypeID"
        Me.colPlanTypeID.Name = "colPlanTypeID"
        Me.colPlanTypeID.Visible = True
        Me.colPlanTypeID.VisibleIndex = 0
        '
        'colPlanName
        '
        Me.colPlanName.FieldName = "PlanName"
        Me.colPlanName.Name = "colPlanName"
        Me.colPlanName.Visible = True
        Me.colPlanName.VisibleIndex = 1
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem6})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1518, 842)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PlanTypesGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 75)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1492, 741)
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.PlanTypesBindingNavigator
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1492, 44)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.PlanTypeIDSpinEdit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 44)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(257, 31)
        Me.LayoutControlItem4.Text = "Plan Type ID:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(77, 16)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.PlanNameTextBox
        Me.LayoutControlItem6.Location = New System.Drawing.Point(257, 44)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(1235, 31)
        Me.LayoutControlItem6.Text = "Plan Name:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(77, 16)
        '
        'PlanTypesTableAdapter
        '
        Me.PlanTypesTableAdapter.ClearBeforeFill = True
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
        'PlanTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1518, 842)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PlanTypes"
        Me.Text = "PlanTypes"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.PlanTypeIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanTypesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlanTypesBindingNavigator.ResumeLayout(False)
        Me.PlanTypesBindingNavigator.PerformLayout()
        CType(Me.PlanTypesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LexiconRecManagerDataSet As Lexrecmgr.LexiconRecManagerDataSet
    Friend WithEvents PlanTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanTypesTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.PlanTypesTableAdapter
    Friend WithEvents TableAdapterManager As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlanTypesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PlanTypesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PlanTypeIDSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PlanNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlanTypesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPlanTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
End Class
