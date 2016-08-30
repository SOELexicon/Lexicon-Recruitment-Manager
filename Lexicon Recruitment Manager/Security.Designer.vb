<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Security
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
        Dim ApplicationLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Security))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.BranchUserSecurityIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.BranchUserSecurityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LexiconRecManagerDataSet = New Lexrecmgr.LexiconRecManagerDataSet()
        Me.UserIDSpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.SecurityProfileNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SecurityProfileDescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SecurityAreaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ApplicationTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.BranchUserSecurityGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBranchUserSecurityID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSecurityProfileName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSecurityProfileDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSecurityArea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSecurityBranch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colApplication = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApplicationID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colApplicationArea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ApplicationAreasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserIDSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DomainUserIDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UsernameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PasswordTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LastLoginDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ActiveCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.AdminCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.UsersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.UsersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UsersGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUserID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDomainUserID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsername = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPassword = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colLastLoginDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdmin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BranchSpinEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ApplicationIDSpinEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ApplicationAreaSpinEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.SecurityBranchSpinEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.BranchBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.UsersTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.UsersTableAdapter()
        Me.TableAdapterManager = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager()
        Me.BranchTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter()
        Me.BranchUserSecurityTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchUserSecurityTableAdapter()
        Me.ApplicationTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.ApplicationTableAdapter()
        Me.ApplicationAreasTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.ApplicationAreasTableAdapter()
        ApplicationLabel = New System.Windows.Forms.Label()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.BranchUserSecurityIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchUserSecurityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserIDSpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecurityProfileNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecurityProfileDescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecurityAreaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.BranchUserSecurityGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationAreasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DomainUserIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsernameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LastLoginDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LastLoginDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsersBindingNavigator.SuspendLayout()
        CType(Me.UsersGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationAreaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecurityBranchSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplicationLabel
        '
        ApplicationLabel.Location = New System.Drawing.Point(12, 401)
        ApplicationLabel.Name = "ApplicationLabel"
        ApplicationLabel.Size = New System.Drawing.Size(1359, 174)
        ApplicationLabel.TabIndex = 33
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.BranchUserSecurityIDSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.UserIDSpinEdit1)
        Me.LayoutControl1.Controls.Add(Me.SecurityProfileNameTextEdit)
        Me.LayoutControl1.Controls.Add(Me.SecurityProfileDescriptionTextEdit)
        Me.LayoutControl1.Controls.Add(Me.SecurityAreaTextEdit)
        Me.LayoutControl1.Controls.Add(Me.ApplicationTextEdit)
        Me.LayoutControl1.Controls.Add(Me.BindingNavigator1)
        Me.LayoutControl1.Controls.Add(Me.BranchUserSecurityGridControl)
        Me.LayoutControl1.Controls.Add(Me.UserIDSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.DomainUserIDTextEdit)
        Me.LayoutControl1.Controls.Add(Me.UsernameTextEdit)
        Me.LayoutControl1.Controls.Add(Me.PasswordTextEdit)
        Me.LayoutControl1.Controls.Add(Me.LastLoginDateDateEdit)
        Me.LayoutControl1.Controls.Add(Me.ActiveCheckEdit)
        Me.LayoutControl1.Controls.Add(Me.AdminCheckEdit)
        Me.LayoutControl1.Controls.Add(Me.UsersBindingNavigator)
        Me.LayoutControl1.Controls.Add(Me.UsersGridControl)
        Me.LayoutControl1.Controls.Add(Me.BranchSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.ApplicationIDSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.ApplicationAreaSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.SecurityBranchSpinEdit)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem25, Me.LayoutControlItem19, Me.LayoutControlItem15, Me.LayoutControlItem21, Me.LayoutControlItem11, Me.LayoutControlItem7})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1362, 685)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'BranchUserSecurityIDSpinEdit
        '
        Me.BranchUserSecurityIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BranchUserSecurityBindingSource, "BranchUserSecurityID", True))
        Me.BranchUserSecurityIDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.BranchUserSecurityIDSpinEdit.Location = New System.Drawing.Point(24, 133)
        Me.BranchUserSecurityIDSpinEdit.Name = "BranchUserSecurityIDSpinEdit"
        Me.BranchUserSecurityIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BranchUserSecurityIDSpinEdit.Properties.ReadOnly = True
        Me.BranchUserSecurityIDSpinEdit.Size = New System.Drawing.Size(132, 20)
        Me.BranchUserSecurityIDSpinEdit.StyleController = Me.LayoutControl1
        Me.BranchUserSecurityIDSpinEdit.TabIndex = 22
        '
        'BranchUserSecurityBindingSource
        '
        Me.BranchUserSecurityBindingSource.DataMember = "FK_BranchUserSecurity_Users"
        Me.BranchUserSecurityBindingSource.DataSource = Me.UsersBindingSource
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'LexiconRecManagerDataSet
        '
        Me.LexiconRecManagerDataSet.DataSetName = "LexiconRecManagerDataSet"
        Me.LexiconRecManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserIDSpinEdit1
        '
        Me.UserIDSpinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BranchUserSecurityBindingSource, "UserID", True))
        Me.UserIDSpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UserIDSpinEdit1.Location = New System.Drawing.Point(160, 133)
        Me.UserIDSpinEdit1.Name = "UserIDSpinEdit1"
        Me.UserIDSpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserIDSpinEdit1.Properties.ReadOnly = True
        Me.UserIDSpinEdit1.Size = New System.Drawing.Size(132, 20)
        Me.UserIDSpinEdit1.StyleController = Me.LayoutControl1
        Me.UserIDSpinEdit1.TabIndex = 24
        '
        'SecurityProfileNameTextEdit
        '
        Me.SecurityProfileNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BranchUserSecurityBindingSource, "SecurityProfileName", True))
        Me.SecurityProfileNameTextEdit.Location = New System.Drawing.Point(296, 133)
        Me.SecurityProfileNameTextEdit.Name = "SecurityProfileNameTextEdit"
        Me.SecurityProfileNameTextEdit.Size = New System.Drawing.Size(132, 20)
        Me.SecurityProfileNameTextEdit.StyleController = Me.LayoutControl1
        Me.SecurityProfileNameTextEdit.TabIndex = 26
        '
        'SecurityProfileDescriptionTextEdit
        '
        Me.SecurityProfileDescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BranchUserSecurityBindingSource, "SecurityProfileDescription", True))
        Me.SecurityProfileDescriptionTextEdit.Location = New System.Drawing.Point(432, 133)
        Me.SecurityProfileDescriptionTextEdit.Name = "SecurityProfileDescriptionTextEdit"
        Me.SecurityProfileDescriptionTextEdit.Size = New System.Drawing.Size(144, 20)
        Me.SecurityProfileDescriptionTextEdit.StyleController = Me.LayoutControl1
        Me.SecurityProfileDescriptionTextEdit.TabIndex = 28
        '
        'SecurityAreaTextEdit
        '
        Me.SecurityAreaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BranchUserSecurityBindingSource, "SecurityArea", True))
        Me.SecurityAreaTextEdit.Location = New System.Drawing.Point(296, 117)
        Me.SecurityAreaTextEdit.Name = "SecurityAreaTextEdit"
        Me.SecurityAreaTextEdit.Size = New System.Drawing.Size(416, 20)
        Me.SecurityAreaTextEdit.StyleController = Me.LayoutControl1
        Me.SecurityAreaTextEdit.TabIndex = 30
        '
        'ApplicationTextEdit
        '
        Me.ApplicationTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BranchUserSecurityBindingSource, "Application", True))
        Me.ApplicationTextEdit.Location = New System.Drawing.Point(903, 133)
        Me.ApplicationTextEdit.Name = "ApplicationTextEdit"
        Me.ApplicationTextEdit.Size = New System.Drawing.Size(179, 20)
        Me.ApplicationTextEdit.StyleController = Me.LayoutControl1
        Me.ApplicationTextEdit.TabIndex = 34
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.AutoSize = False
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator1.BindingSource = Me.BranchUserSecurityBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(24, 80)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(1314, 30)
        Me.BindingNavigator1.TabIndex = 37
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 27)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 27)
        Me.ToolStripButton1.Text = "Save Data"
        '
        'BranchUserSecurityGridControl
        '
        Me.BranchUserSecurityGridControl.DataSource = Me.BranchUserSecurityBindingSource
        Me.BranchUserSecurityGridControl.Location = New System.Drawing.Point(24, 154)
        Me.BranchUserSecurityGridControl.MainView = Me.GridView2
        Me.BranchUserSecurityGridControl.Name = "BranchUserSecurityGridControl"
        Me.BranchUserSecurityGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit4})
        Me.BranchUserSecurityGridControl.Size = New System.Drawing.Size(1314, 186)
        Me.BranchUserSecurityGridControl.TabIndex = 21
        Me.BranchUserSecurityGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBranchUserSecurityID, Me.colUserID1, Me.colSecurityProfileName, Me.colSecurityProfileDescription, Me.colSecurityArea, Me.colSecurityBranch, Me.colApplication, Me.colApplicationID, Me.colApplicationArea})
        Me.GridView2.GridControl = Me.BranchUserSecurityGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        '
        'colBranchUserSecurityID
        '
        Me.colBranchUserSecurityID.FieldName = "BranchUserSecurityID"
        Me.colBranchUserSecurityID.Name = "colBranchUserSecurityID"
        '
        'colUserID1
        '
        Me.colUserID1.FieldName = "UserID"
        Me.colUserID1.Name = "colUserID1"
        '
        'colSecurityProfileName
        '
        Me.colSecurityProfileName.FieldName = "SecurityProfileName"
        Me.colSecurityProfileName.Name = "colSecurityProfileName"
        '
        'colSecurityProfileDescription
        '
        Me.colSecurityProfileDescription.FieldName = "SecurityProfileDescription"
        Me.colSecurityProfileDescription.Name = "colSecurityProfileDescription"
        '
        'colSecurityArea
        '
        Me.colSecurityArea.FieldName = "SecurityArea"
        Me.colSecurityArea.Name = "colSecurityArea"
        '
        'colSecurityBranch
        '
        Me.colSecurityBranch.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colSecurityBranch.FieldName = "SecurityBranch"
        Me.colSecurityBranch.Name = "colSecurityBranch"
        Me.colSecurityBranch.Visible = True
        Me.colSecurityBranch.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.BranchBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Branch"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "BranchID"
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'colApplication
        '
        Me.colApplication.FieldName = "Application"
        Me.colApplication.Name = "colApplication"
        '
        'colApplicationID
        '
        Me.colApplicationID.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.colApplicationID.FieldName = "ApplicationID"
        Me.colApplicationID.Name = "colApplicationID"
        Me.colApplicationID.Visible = True
        Me.colApplicationID.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.DataSource = Me.ApplicationBindingSource
        Me.RepositoryItemLookUpEdit3.DisplayMember = "Application"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.ValueMember = "ApplicationId"
        '
        'ApplicationBindingSource
        '
        Me.ApplicationBindingSource.DataMember = "Application"
        Me.ApplicationBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'colApplicationArea
        '
        Me.colApplicationArea.ColumnEdit = Me.RepositoryItemLookUpEdit4
        Me.colApplicationArea.FieldName = "ApplicationArea"
        Me.colApplicationArea.Name = "colApplicationArea"
        Me.colApplicationArea.Visible = True
        Me.colApplicationArea.VisibleIndex = 2
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.DataSource = Me.ApplicationAreasBindingSource
        Me.RepositoryItemLookUpEdit4.DisplayMember = "ApplicationArea"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.ValueMember = "ApplicationAreaID"
        '
        'ApplicationAreasBindingSource
        '
        Me.ApplicationAreasBindingSource.DataMember = "ApplicationAreas"
        Me.ApplicationAreasBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'UserIDSpinEdit
        '
        Me.UserIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsersBindingSource, "UserID", True))
        Me.UserIDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UserIDSpinEdit.Location = New System.Drawing.Point(24, 96)
        Me.UserIDSpinEdit.Name = "UserIDSpinEdit"
        Me.UserIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserIDSpinEdit.Properties.ReadOnly = True
        Me.UserIDSpinEdit.Size = New System.Drawing.Size(149, 20)
        Me.UserIDSpinEdit.StyleController = Me.LayoutControl1
        Me.UserIDSpinEdit.TabIndex = 7
        '
        'DomainUserIDTextEdit
        '
        Me.DomainUserIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsersBindingSource, "DomainUserID", True))
        Me.DomainUserIDTextEdit.Location = New System.Drawing.Point(177, 96)
        Me.DomainUserIDTextEdit.Name = "DomainUserIDTextEdit"
        Me.DomainUserIDTextEdit.Size = New System.Drawing.Size(148, 20)
        Me.DomainUserIDTextEdit.StyleController = Me.LayoutControl1
        Me.DomainUserIDTextEdit.TabIndex = 9
        '
        'UsernameTextEdit
        '
        Me.UsernameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsersBindingSource, "Username", True))
        Me.UsernameTextEdit.Location = New System.Drawing.Point(329, 96)
        Me.UsernameTextEdit.Name = "UsernameTextEdit"
        Me.UsernameTextEdit.Size = New System.Drawing.Size(149, 20)
        Me.UsernameTextEdit.StyleController = Me.LayoutControl1
        Me.UsernameTextEdit.TabIndex = 11
        '
        'PasswordTextEdit
        '
        Me.PasswordTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsersBindingSource, "Password", True))
        Me.PasswordTextEdit.Location = New System.Drawing.Point(482, 96)
        Me.PasswordTextEdit.Name = "PasswordTextEdit"
        Me.PasswordTextEdit.Size = New System.Drawing.Size(148, 20)
        Me.PasswordTextEdit.StyleController = Me.LayoutControl1
        Me.PasswordTextEdit.TabIndex = 13
        '
        'LastLoginDateDateEdit
        '
        Me.LastLoginDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsersBindingSource, "LastLoginDate", True))
        Me.LastLoginDateDateEdit.EditValue = Nothing
        Me.LastLoginDateDateEdit.Location = New System.Drawing.Point(786, 96)
        Me.LastLoginDateDateEdit.Name = "LastLoginDateDateEdit"
        Me.LastLoginDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LastLoginDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LastLoginDateDateEdit.Size = New System.Drawing.Size(149, 20)
        Me.LastLoginDateDateEdit.StyleController = Me.LayoutControl1
        Me.LastLoginDateDateEdit.TabIndex = 17
        '
        'ActiveCheckEdit
        '
        Me.ActiveCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsersBindingSource, "Active", True))
        Me.ActiveCheckEdit.Location = New System.Drawing.Point(939, 80)
        Me.ActiveCheckEdit.Name = "ActiveCheckEdit"
        Me.ActiveCheckEdit.Properties.Caption = "Active"
        Me.ActiveCheckEdit.Size = New System.Drawing.Size(81, 19)
        Me.ActiveCheckEdit.StyleController = Me.LayoutControl1
        Me.ActiveCheckEdit.TabIndex = 19
        '
        'AdminCheckEdit
        '
        Me.AdminCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsersBindingSource, "Admin", True))
        Me.AdminCheckEdit.Location = New System.Drawing.Point(1024, 80)
        Me.AdminCheckEdit.Name = "AdminCheckEdit"
        Me.AdminCheckEdit.Properties.Caption = "Admin"
        Me.AdminCheckEdit.Size = New System.Drawing.Size(314, 19)
        Me.AdminCheckEdit.StyleController = Me.LayoutControl1
        Me.AdminCheckEdit.TabIndex = 21
        '
        'UsersBindingNavigator
        '
        Me.UsersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UsersBindingNavigator.AutoSize = False
        Me.UsersBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.UsersBindingNavigator.BindingSource = Me.UsersBindingSource
        Me.UsersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UsersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UsersBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.UsersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UsersBindingNavigatorSaveItem})
        Me.UsersBindingNavigator.Location = New System.Drawing.Point(12, 12)
        Me.UsersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UsersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UsersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UsersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UsersBindingNavigator.Name = "UsersBindingNavigator"
        Me.UsersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UsersBindingNavigator.Size = New System.Drawing.Size(1338, 30)
        Me.UsersBindingNavigator.TabIndex = 1
        Me.UsersBindingNavigator.Text = "BindingNavigator1"
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
        'UsersBindingNavigatorSaveItem
        '
        Me.UsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UsersBindingNavigatorSaveItem.Image = CType(resources.GetObject("UsersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UsersBindingNavigatorSaveItem.Name = "UsersBindingNavigatorSaveItem"
        Me.UsersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 27)
        Me.UsersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UsersGridControl
        '
        Me.UsersGridControl.DataSource = Me.UsersBindingSource
        Me.UsersGridControl.Location = New System.Drawing.Point(12, 356)
        Me.UsersGridControl.MainView = Me.GridView1
        Me.UsersGridControl.Name = "UsersGridControl"
        Me.UsersGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.UsersGridControl.Size = New System.Drawing.Size(1338, 317)
        Me.UsersGridControl.TabIndex = 4
        Me.UsersGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUserID, Me.colDomainUserID, Me.colUsername, Me.colPassword, Me.colBranch, Me.colLastLoginDate, Me.colActive, Me.colAdmin})
        Me.GridView1.GridControl = Me.UsersGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.GridView1.OptionsView.ShowDetailButtons = False
        '
        'colUserID
        '
        Me.colUserID.FieldName = "UserID"
        Me.colUserID.Name = "colUserID"
        '
        'colDomainUserID
        '
        Me.colDomainUserID.FieldName = "DomainUserID"
        Me.colDomainUserID.Name = "colDomainUserID"
        Me.colDomainUserID.Visible = True
        Me.colDomainUserID.VisibleIndex = 0
        '
        'colUsername
        '
        Me.colUsername.FieldName = "Username"
        Me.colUsername.Name = "colUsername"
        Me.colUsername.Visible = True
        Me.colUsername.VisibleIndex = 1
        '
        'colPassword
        '
        Me.colPassword.FieldName = "Password"
        Me.colPassword.Name = "colPassword"
        Me.colPassword.Visible = True
        Me.colPassword.VisibleIndex = 2
        '
        'colBranch
        '
        Me.colBranch.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colBranch.FieldName = "Branch"
        Me.colBranch.Name = "colBranch"
        Me.colBranch.Visible = True
        Me.colBranch.VisibleIndex = 3
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.BranchBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Branch"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "BranchID"
        '
        'colLastLoginDate
        '
        Me.colLastLoginDate.FieldName = "LastLoginDate"
        Me.colLastLoginDate.Name = "colLastLoginDate"
        Me.colLastLoginDate.Visible = True
        Me.colLastLoginDate.VisibleIndex = 4
        '
        'colActive
        '
        Me.colActive.FieldName = "Active"
        Me.colActive.Name = "colActive"
        Me.colActive.Visible = True
        Me.colActive.VisibleIndex = 5
        '
        'colAdmin
        '
        Me.colAdmin.FieldName = "Admin"
        Me.colAdmin.Name = "colAdmin"
        Me.colAdmin.Visible = True
        Me.colAdmin.VisibleIndex = 6
        '
        'BranchSpinEdit
        '
        Me.BranchSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UsersBindingSource, "Branch", True))
        Me.BranchSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.BranchSpinEdit.Location = New System.Drawing.Point(634, 96)
        Me.BranchSpinEdit.Name = "BranchSpinEdit"
        Me.BranchSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BranchSpinEdit.Properties.DataSource = Me.BranchBindingSource
        Me.BranchSpinEdit.Properties.DisplayMember = "Branch"
        Me.BranchSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.BranchSpinEdit.Properties.NullText = ""
        Me.BranchSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BranchSpinEdit.Properties.ValueMember = "BranchID"
        Me.BranchSpinEdit.Size = New System.Drawing.Size(148, 20)
        Me.BranchSpinEdit.StyleController = Me.LayoutControl1
        Me.BranchSpinEdit.TabIndex = 15
        '
        'ApplicationIDSpinEdit
        '
        Me.ApplicationIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BranchUserSecurityBindingSource, "ApplicationID", True))
        Me.ApplicationIDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ApplicationIDSpinEdit.Location = New System.Drawing.Point(844, 130)
        Me.ApplicationIDSpinEdit.Name = "ApplicationIDSpinEdit"
        Me.ApplicationIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ApplicationIDSpinEdit.Properties.DataSource = Me.ApplicationBindingSource
        Me.ApplicationIDSpinEdit.Properties.DisplayMember = "Application"
        Me.ApplicationIDSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.ApplicationIDSpinEdit.Properties.NullText = ""
        Me.ApplicationIDSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ApplicationIDSpinEdit.Properties.ValueMember = "ApplicationId"
        Me.ApplicationIDSpinEdit.Size = New System.Drawing.Size(357, 20)
        Me.ApplicationIDSpinEdit.StyleController = Me.LayoutControl1
        Me.ApplicationIDSpinEdit.TabIndex = 35
        '
        'ApplicationAreaSpinEdit
        '
        Me.ApplicationAreaSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BranchUserSecurityBindingSource, "ApplicationArea", True))
        Me.ApplicationAreaSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ApplicationAreaSpinEdit.Location = New System.Drawing.Point(1205, 130)
        Me.ApplicationAreaSpinEdit.Name = "ApplicationAreaSpinEdit"
        Me.ApplicationAreaSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ApplicationAreaSpinEdit.Properties.DataSource = Me.ApplicationAreasBindingSource
        Me.ApplicationAreaSpinEdit.Properties.DisplayMember = "ApplicationArea"
        Me.ApplicationAreaSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.ApplicationAreaSpinEdit.Properties.NullText = ""
        Me.ApplicationAreaSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ApplicationAreaSpinEdit.Properties.ValueMember = "ApplicationAreaID"
        Me.ApplicationAreaSpinEdit.Size = New System.Drawing.Size(133, 20)
        Me.ApplicationAreaSpinEdit.StyleController = Me.LayoutControl1
        Me.ApplicationAreaSpinEdit.TabIndex = 36
        '
        'SecurityBranchSpinEdit
        '
        Me.SecurityBranchSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BranchUserSecurityBindingSource, "SecurityBranch", True))
        Me.SecurityBranchSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SecurityBranchSpinEdit.Location = New System.Drawing.Point(24, 130)
        Me.SecurityBranchSpinEdit.Name = "SecurityBranchSpinEdit"
        Me.SecurityBranchSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SecurityBranchSpinEdit.Properties.DataSource = Me.BranchBindingSource1
        Me.SecurityBranchSpinEdit.Properties.DisplayMember = "Branch"
        Me.SecurityBranchSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.SecurityBranchSpinEdit.Properties.NullText = ""
        Me.SecurityBranchSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SecurityBranchSpinEdit.Properties.ValueMember = "BranchID"
        Me.SecurityBranchSpinEdit.Size = New System.Drawing.Size(816, 20)
        Me.SecurityBranchSpinEdit.StyleController = Me.LayoutControl1
        Me.SecurityBranchSpinEdit.TabIndex = 32
        '
        'BranchBindingSource1
        '
        Me.BranchBindingSource1.DataMember = "Branch"
        Me.BranchBindingSource1.DataSource = Me.LexiconRecManagerDataSet
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.ApplicationTextEdit
        Me.LayoutControlItem25.Location = New System.Drawing.Point(879, 34)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(183, 40)
        Me.LayoutControlItem25.Text = "Application:"
        Me.LayoutControlItem25.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(132, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.SecurityProfileDescriptionTextEdit
        Me.LayoutControlItem19.Location = New System.Drawing.Point(408, 34)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(148, 40)
        Me.LayoutControlItem19.Text = "Security Profile Description:"
        Me.LayoutControlItem19.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(132, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.SecurityProfileNameTextEdit
        Me.LayoutControlItem15.Location = New System.Drawing.Point(272, 34)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(136, 40)
        Me.LayoutControlItem15.Text = "Security Profile Name:"
        Me.LayoutControlItem15.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(132, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.SecurityAreaTextEdit
        Me.LayoutControlItem21.Location = New System.Drawing.Point(272, 34)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(420, 40)
        Me.LayoutControlItem21.Text = "Security Area:"
        Me.LayoutControlItem21.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.UserIDSpinEdit1
        Me.LayoutControlItem11.Location = New System.Drawing.Point(136, 34)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(136, 40)
        Me.LayoutControlItem11.Text = "User ID:"
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(132, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.BranchUserSecurityIDSpinEdit
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 34)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(136, 40)
        Me.LayoutControlItem7.Text = "Branch User Security ID:"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(132, 13)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.TabbedControlGroup1, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1362, 685)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.UsersBindingNavigator
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1342, 34)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 34)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup3
        Me.TabbedControlGroup1.SelectedTabPageIndex = 1
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(1342, 310)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3})
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem23, Me.LayoutControlItem9, Me.LayoutControlItem13, Me.LayoutControlItem5})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1318, 264)
        Me.LayoutControlGroup3.Text = "Security"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.BranchUserSecurityGridControl
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1318, 190)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.SecurityBranchSpinEdit
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 34)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(820, 40)
        Me.LayoutControlItem23.Text = "Security Branch:"
        Me.LayoutControlItem23.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.ApplicationIDSpinEdit
        Me.LayoutControlItem9.Location = New System.Drawing.Point(820, 34)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(361, 40)
        Me.LayoutControlItem9.Text = "Application ID:"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.ApplicationAreaSpinEdit
        Me.LayoutControlItem13.Location = New System.Drawing.Point(1181, 34)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(137, 40)
        Me.LayoutControlItem13.Text = "Application Area:"
        Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.BindingNavigator1
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1318, 34)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem12, Me.LayoutControlItem14, Me.LayoutControlItem16, Me.LayoutControlItem18, Me.EmptySpaceItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1318, 264)
        Me.LayoutControlGroup2.Text = "Users"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.UserIDSpinEdit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(153, 40)
        Me.LayoutControlItem4.Text = "User ID:"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.DomainUserIDTextEdit
        Me.LayoutControlItem6.Location = New System.Drawing.Point(153, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(152, 40)
        Me.LayoutControlItem6.Text = "Domain User ID:"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.UsernameTextEdit
        Me.LayoutControlItem8.Location = New System.Drawing.Point(305, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(153, 40)
        Me.LayoutControlItem8.Text = "Username:"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.PasswordTextEdit
        Me.LayoutControlItem10.Location = New System.Drawing.Point(458, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(152, 40)
        Me.LayoutControlItem10.Text = "Password:"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.BranchSpinEdit
        Me.LayoutControlItem12.Location = New System.Drawing.Point(610, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(152, 40)
        Me.LayoutControlItem12.Text = "Branch:"
        Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.LastLoginDateDateEdit
        Me.LayoutControlItem14.Location = New System.Drawing.Point(762, 0)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(153, 40)
        Me.LayoutControlItem14.Text = "Last Login Date:"
        Me.LayoutControlItem14.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.ActiveCheckEdit
        Me.LayoutControlItem16.Location = New System.Drawing.Point(915, 0)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(85, 40)
        Me.LayoutControlItem16.Text = "Active:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.AdminCheckEdit
        Me.LayoutControlItem18.Location = New System.Drawing.Point(1000, 0)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(318, 40)
        Me.LayoutControlItem18.Text = "Admin:"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 40)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(1318, 224)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.UsersGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 344)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1342, 321)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ApplicationAreasTableAdapter = Nothing
        Me.TableAdapterManager.ApplicationTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BranchTableAdapter = Me.BranchTableAdapter
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
        Me.TableAdapterManager.PlanTypesTableAdapter = Nothing
        Me.TableAdapterManager.SchemesTableAdapter = Nothing
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.uk_postcodesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Lexrecmgr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Me.UsersTableAdapter
        Me.TableAdapterManager.WeeknumbersTableAdapter = Nothing
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'BranchUserSecurityTableAdapter
        '
        Me.BranchUserSecurityTableAdapter.ClearBeforeFill = True
        '
        'ApplicationTableAdapter
        '
        Me.ApplicationTableAdapter.ClearBeforeFill = True
        '
        'ApplicationAreasTableAdapter
        '
        Me.ApplicationAreasTableAdapter.ClearBeforeFill = True
        '
        'Security
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 685)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "Security"
        Me.Text = "Security"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.BranchUserSecurityIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchUserSecurityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserIDSpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecurityProfileNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecurityProfileDescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecurityAreaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.BranchUserSecurityGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationAreasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DomainUserIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsernameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LastLoginDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LastLoginDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsersBindingNavigator.ResumeLayout(False)
        Me.UsersBindingNavigator.PerformLayout()
        CType(Me.UsersGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationAreaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecurityBranchSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LexiconRecManagerDataSet As Lexrecmgr.LexiconRecManagerDataSet
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents TableAdapterManager As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsersBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents UsersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UserIDSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DomainUserIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UsernameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PasswordTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LastLoginDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ActiveCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AdminCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents UsersGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDomainUserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsername As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPassword As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastLoginDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdmin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BranchSpinEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BranchTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BranchUserSecurityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchUserSecurityTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchUserSecurityTableAdapter
    Friend WithEvents BranchUserSecurityIDSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents UserIDSpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SecurityProfileNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SecurityProfileDescriptionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SecurityAreaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ApplicationTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BranchUserSecurityGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colBranchUserSecurityID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSecurityProfileName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSecurityProfileDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSecurityArea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSecurityBranch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApplication As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApplicationID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApplicationArea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ApplicationIDSpinEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ApplicationAreaSpinEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ApplicationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ApplicationTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.ApplicationTableAdapter
    Friend WithEvents ApplicationAreasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ApplicationAreasTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.ApplicationAreasTableAdapter
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SecurityBranchSpinEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BranchBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
