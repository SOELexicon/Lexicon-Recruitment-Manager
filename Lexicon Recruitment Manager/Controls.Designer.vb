<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Controls
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Controls))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ControlsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ControlsBindingSource = New System.Windows.Forms.BindingSource()
        Me.LexiconRecManagerDataSet = New Lexrecmgr.LexiconRecManagerDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colControl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colControlName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colControlValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colControlBit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ControlsBindingNavigator = New System.Windows.Forms.BindingNavigator()
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
        Me.ControlsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ControlSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ControlNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ControlValueSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ControlBitCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ControlsTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.ControlsTableAdapter()
        Me.TableAdapterManager = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ControlsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ControlsBindingNavigator.SuspendLayout()
        CType(Me.ControlSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlValueSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlBitCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ControlsGridControl)
        Me.LayoutControl1.Controls.Add(Me.ControlsBindingNavigator)
        Me.LayoutControl1.Controls.Add(Me.ControlSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.ControlNameTextEdit)
        Me.LayoutControl1.Controls.Add(Me.ControlValueSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.ControlBitCheckEdit)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1114, 680)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ControlsGridControl
        '
        Me.ControlsGridControl.DataSource = Me.ControlsBindingSource
        Me.ControlsGridControl.Location = New System.Drawing.Point(12, 86)
        Me.ControlsGridControl.MainView = Me.GridView1
        Me.ControlsGridControl.Name = "ControlsGridControl"
        Me.ControlsGridControl.Size = New System.Drawing.Size(1090, 582)
        Me.ControlsGridControl.TabIndex = 11
        Me.ControlsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ControlsBindingSource
        '
        Me.ControlsBindingSource.DataMember = "Controls"
        Me.ControlsBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'LexiconRecManagerDataSet
        '
        Me.LexiconRecManagerDataSet.DataSetName = "LexiconRecManagerDataSet"
        Me.LexiconRecManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colControl, Me.colControlName, Me.colControlValue, Me.colControlBit})
        Me.GridView1.GridControl = Me.ControlsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'colControl
        '
        Me.colControl.FieldName = "Control"
        Me.colControl.Name = "colControl"
        Me.colControl.Visible = True
        Me.colControl.VisibleIndex = 0
        '
        'colControlName
        '
        Me.colControlName.FieldName = "ControlName"
        Me.colControlName.Name = "colControlName"
        Me.colControlName.Visible = True
        Me.colControlName.VisibleIndex = 1
        '
        'colControlValue
        '
        Me.colControlValue.FieldName = "ControlValue"
        Me.colControlValue.Name = "colControlValue"
        Me.colControlValue.Visible = True
        Me.colControlValue.VisibleIndex = 2
        '
        'colControlBit
        '
        Me.colControlBit.FieldName = "ControlBit"
        Me.colControlBit.Name = "colControlBit"
        Me.colControlBit.Visible = True
        Me.colControlBit.VisibleIndex = 3
        '
        'ControlsBindingNavigator
        '
        Me.ControlsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ControlsBindingNavigator.AutoSize = False
        Me.ControlsBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.ControlsBindingNavigator.BindingSource = Me.ControlsBindingSource
        Me.ControlsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ControlsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ControlsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.ControlsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ControlsBindingNavigatorSaveItem})
        Me.ControlsBindingNavigator.Location = New System.Drawing.Point(12, 12)
        Me.ControlsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ControlsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ControlsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ControlsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ControlsBindingNavigator.Name = "ControlsBindingNavigator"
        Me.ControlsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ControlsBindingNavigator.Size = New System.Drawing.Size(1090, 30)
        Me.ControlsBindingNavigator.TabIndex = 1
        Me.ControlsBindingNavigator.Text = "BindingNavigator1"
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
        'ControlsBindingNavigatorSaveItem
        '
        Me.ControlsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ControlsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ControlsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ControlsBindingNavigatorSaveItem.Name = "ControlsBindingNavigatorSaveItem"
        Me.ControlsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 27)
        Me.ControlsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ControlSpinEdit
        '
        Me.ControlSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ControlsBindingSource, "Control", True))
        Me.ControlSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ControlSpinEdit.Location = New System.Drawing.Point(12, 62)
        Me.ControlSpinEdit.Name = "ControlSpinEdit"
        Me.ControlSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ControlSpinEdit.Properties.ReadOnly = True
        Me.ControlSpinEdit.Size = New System.Drawing.Size(96, 20)
        Me.ControlSpinEdit.StyleController = Me.LayoutControl1
        Me.ControlSpinEdit.TabIndex = 5
        '
        'ControlNameTextEdit
        '
        Me.ControlNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ControlsBindingSource, "ControlName", True))
        Me.ControlNameTextEdit.Location = New System.Drawing.Point(112, 62)
        Me.ControlNameTextEdit.Name = "ControlNameTextEdit"
        Me.ControlNameTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.ControlNameTextEdit.StyleController = Me.LayoutControl1
        Me.ControlNameTextEdit.TabIndex = 7
        '
        'ControlValueSpinEdit
        '
        Me.ControlValueSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ControlsBindingSource, "ControlValue", True))
        Me.ControlValueSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ControlValueSpinEdit.Location = New System.Drawing.Point(282, 62)
        Me.ControlValueSpinEdit.Name = "ControlValueSpinEdit"
        Me.ControlValueSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ControlValueSpinEdit.Size = New System.Drawing.Size(223, 20)
        Me.ControlValueSpinEdit.StyleController = Me.LayoutControl1
        Me.ControlValueSpinEdit.TabIndex = 9
        '
        'ControlBitCheckEdit
        '
        Me.ControlBitCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ControlsBindingSource, "ControlBit", True))
        Me.ControlBitCheckEdit.Location = New System.Drawing.Point(509, 62)
        Me.ControlBitCheckEdit.Name = "ControlBitCheckEdit"
        Me.ControlBitCheckEdit.Properties.Caption = ""
        Me.ControlBitCheckEdit.Size = New System.Drawing.Size(593, 19)
        Me.ControlBitCheckEdit.StyleController = Me.LayoutControl1
        Me.ControlBitCheckEdit.TabIndex = 11
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1114, 680)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ControlSpinEdit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 34)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(100, 40)
        Me.LayoutControlItem2.Text = "Control:"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ControlsBindingNavigator
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1094, 34)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.ControlNameTextEdit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(100, 34)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(170, 40)
        Me.LayoutControlItem4.Text = "Control Name:"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.ControlValueSpinEdit
        Me.LayoutControlItem6.Location = New System.Drawing.Point(270, 34)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(227, 40)
        Me.LayoutControlItem6.Text = "Control Value:"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.ControlBitCheckEdit
        Me.LayoutControlItem8.Location = New System.Drawing.Point(497, 34)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(597, 40)
        Me.LayoutControlItem8.Text = "Control Bit:"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.ControlsGridControl
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1094, 586)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'ControlsTableAdapter
        '
        Me.ControlsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ControlsTableAdapter = Me.ControlsTableAdapter
        Me.TableAdapterManager.CountersTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.HolidaysTableAdapter = Nothing
        Me.TableAdapterManager.Import_EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.JobCategoryTableAdapter = Nothing
        Me.TableAdapterManager.Plan1TableAdapter = Nothing
        Me.TableAdapterManager.Plan2PerRecordTableAdapter = Nothing
        Me.TableAdapterManager.PlanInvoiceTableAdapter = Nothing
        Me.TableAdapterManager.PlanTableAdapter = Nothing
        Me.TableAdapterManager.PlanTypesTableAdapter = Nothing
        Me.TableAdapterManager.SchemesTableAdapter = Nothing
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.uk_postcodesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Lexrecmgr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.WeeknumbersTableAdapter = Nothing
        '
        'Controls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 680)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "Controls"
        Me.Text = "Controls"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ControlsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ControlsBindingNavigator.ResumeLayout(False)
        Me.ControlsBindingNavigator.PerformLayout()
        CType(Me.ControlSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlValueSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlBitCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LexiconRecManagerDataSet As Lexrecmgr.LexiconRecManagerDataSet
    Friend WithEvents ControlsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ControlsTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.ControlsTableAdapter
    Friend WithEvents TableAdapterManager As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ControlsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ControlsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ControlsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colControl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colControlName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colControlValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colControlBit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ControlSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ControlNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ControlValueSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ControlBitCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
End Class
