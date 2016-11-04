<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plan
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
        Dim WeekLabel2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Plan))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.PlanTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.PlanTableAdapter()
        Me.PlanTypesTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.PlanTypesTableAdapter()
        Me.SitesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sites = New Lexrecmgr.Sites()
        Me.SitesTableAdapter = New Lexrecmgr.SitesTableAdapters.SitesTableAdapter()
        Me.TableAdapterManager1 = New Lexrecmgr.SitesTableAdapters.TableAdapterManager()
        Me.JobCategoryTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.JobCategoryTableAdapter()
        Me.LexiconRecManagerDataSet2 = New Lexrecmgr.LexiconRecManagerDataSet()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchSelect = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LexiconRecManagerDataSet1 = New Lexrecmgr.LexiconRecManagerDataSet()
        Me.WeekSelect = New System.Windows.Forms.ComboBox()
        Me.PlanBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanSelect = New System.Windows.Forms.ComboBox()
        Me.PlanTypesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.PlanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LexiconRecManagerDataSet = New Lexrecmgr.LexiconRecManagerDataSet()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.JobCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchIdComboBox = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanIDTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.LastModifiedUserTextBox = New System.Windows.Forms.TextBox()
        Me.POAElseWhereTextBox = New System.Windows.Forms.TextBox()
        Me.HoursWorkedElseWhereTextBox = New System.Windows.Forms.TextBox()
        Me.POATextBox = New System.Windows.Forms.TextBox()
        Me.PoNumberTextBox = New System.Windows.Forms.TextBox()
        Me.WeekEndingDateTextBox = New System.Windows.Forms.TextBox()
        Me.WeekEndingDateIfLateTextBox = New System.Windows.Forms.TextBox()
        Me.FridayCheckBox = New System.Windows.Forms.CheckBox()
        Me.SaturdayCheckBox = New System.Windows.Forms.CheckBox()
        Me.SundayCheckBox = New System.Windows.Forms.CheckBox()
        Me.MondayCheckBox = New System.Windows.Forms.CheckBox()
        Me.TuesdayCheckBox = New System.Windows.Forms.CheckBox()
        Me.WednesdayCheckBox = New System.Windows.Forms.CheckBox()
        Me.ThursdayCheckBox = New System.Windows.Forms.CheckBox()
        Me.Friday2CheckBox = New System.Windows.Forms.CheckBox()
        Me.Saturday2CheckBox = New System.Windows.Forms.CheckBox()
        Me.Sunday2CheckBox = New System.Windows.Forms.CheckBox()
        Me.PlanTypeIdComboBox = New System.Windows.Forms.ComboBox()
        Me.PlanTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateAddedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.tbEndTime = New System.Windows.Forms.TextBox()
        Me.tbStartTime = New System.Windows.Forms.TextBox()
        Me.RulesOrDetailsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.ExpensesPrePayTextBox = New System.Windows.Forms.TextBox()
        Me.ExpensesPreNotesTextBox = New System.Windows.Forms.TextBox()
        Me.ExpensesPreChargeTextBox = New System.Windows.Forms.TextBox()
        Me.OT2ChargeTextBox = New System.Windows.Forms.TextBox()
        Me.OT2HoursTextBox = New System.Windows.Forms.TextBox()
        Me.OT2PayTextBox = New System.Windows.Forms.TextBox()
        Me.OT3ChargeTextBox = New System.Windows.Forms.TextBox()
        Me.OT3HoursTextBox = New System.Windows.Forms.TextBox()
        Me.OT3PayTextBox = New System.Windows.Forms.TextBox()
        Me.NightsOutCharge = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.NightsPay = New System.Windows.Forms.TextBox()
        Me.BankCharge = New System.Windows.Forms.TextBox()
        Me.BankHours = New System.Windows.Forms.TextBox()
        Me.BankPay = New System.Windows.Forms.TextBox()
        Me.SundayCharge = New System.Windows.Forms.TextBox()
        Me.SundayHours = New System.Windows.Forms.TextBox()
        Me.SundayPay = New System.Windows.Forms.TextBox()
        Me.SatCharge = New System.Windows.Forms.TextBox()
        Me.SatHours = New System.Windows.Forms.TextBox()
        Me.SatPay = New System.Windows.Forms.TextBox()
        Me.OT1ChargeTextBox = New System.Windows.Forms.TextBox()
        Me.OT1HoursTextBox = New System.Windows.Forms.TextBox()
        Me.OT1PayTextBox = New System.Windows.Forms.TextBox()
        Me.MinCharge = New System.Windows.Forms.TextBox()
        Me.SWHTextBox = New System.Windows.Forms.TextBox()
        Me.DHHTextBox = New System.Windows.Forms.TextBox()
        Me.ChargeTextBox = New System.Windows.Forms.TextBox()
        Me.HolidayPayTextBox = New System.Windows.Forms.TextBox()
        Me.PayTextBox = New System.Windows.Forms.TextBox()
        Me.HoursTextBox = New System.Windows.Forms.TextBox()
        Me.PlanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.PlanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.PlanViewDataGridView = New System.Windows.Forms.DataGridView()
        Me.Lock = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PlanIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SystemTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanTypeIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ForenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchemeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobCategoryIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShiftNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeekEndingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeekEndingDateIfLateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FridayDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SaturdayDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SundayDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MondayDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TuesdayDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WednesdayDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ThursdayDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Friday2DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Saturday2DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Sunday2DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.HoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HolidayPayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalHoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalChargeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalHolidayPayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalNiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstMarginDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNumberReqDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanTypesTableAdapter1 = New Lexrecmgr.SitesTableAdapters.PlanTypesTableAdapter()
        Me.PlanTableAdapter1 = New Lexrecmgr.SitesTableAdapters.PlanTableAdapter()
        Me.EmployeesTableAdapter = New Lexrecmgr.SitesTableAdapters.EmployeesTableAdapter()
        Me.DataTable1TableAdapter = New Lexrecmgr.SitesTableAdapters.DataTable1TableAdapter()
        Me.BranchTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter()
        Me.Plan1TableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.Plan1TableAdapter()
        Me.WeeknumbersTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.WeeknumbersTableAdapter()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.JobCategoryIdComboBox = New DevExpress.XtraEditors.LookUpEdit()
        Me.BreakDeductedCB = New DevExpress.XtraEditors.CheckEdit()
        Me.EntitlementTB = New System.Windows.Forms.TextBox()
        Me.EmployeeIdComboBox = New DevExpress.XtraEditors.LookUpEdit()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.PlansAuditBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBranchName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlanName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForename1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSurname1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployeeCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colScheme1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobCategory1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiftName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeekEndingDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeekEndingDateIfLate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFriday1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaturday1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSunday1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonday1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTuesday1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWednesday1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colThursday1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFriday21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaturday21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSunday21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastModifiedUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastModifiedDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Ratecombo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.CompanyLookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colPlanID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlanName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlanTypeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForename = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSurname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployeeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployeeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colScheme = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobCategoryId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiftName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeekEndingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeekEndingDateIfLate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFriday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaturday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSunday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTuesday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWednesday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colThursday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFriday2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaturday2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSunday2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHours = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHolidayPay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCharge = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalHours = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalPay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalCharge = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalHolidayPay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalNi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstMargin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderNumberReq = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranchId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSystemType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPoNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.WeekLabel = New DevExpress.XtraEditors.LabelControl()
        Me.WeekendingdateiflatereasonTextEdit = New DevExpress.XtraEditors.MemoExEdit()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.MemoExEdit()
        Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.WeekLabel23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem84 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem50 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem83 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem87 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem47 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem46 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem44 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem43 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem42 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem51 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem49 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem48 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem10 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem54 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem53 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem52 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup9 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem57 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem56 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem55 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem86 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup12 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem66 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem65 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem64 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup13 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem69 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem68 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem67 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem73 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup10 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem60 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem59 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem58 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup11 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem63 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem62 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem61 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup14 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem72 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem71 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem70 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup15 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem76 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem75 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem74 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup16 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem78 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem77 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup17 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem80 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem79 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup18 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem82 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem81 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup19 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem85 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem2 = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Plan2PerRecordTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.Plan2PerRecordTableAdapter()
        Me.Plan2PerRecordTableAdapter1 = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.Plan2PerRecordTableAdapter()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.TableAdapterManager = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager()
        Me.PlanViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WeeknumbersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.WeeknumbersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanViewBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanViewTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.PlanViewTableAdapter()
        Me.DataTable2TableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.DataTable2TableAdapter()
        Me.PlansAuditTableAdapter = New Lexrecmgr.SitesTableAdapters.PlansAuditTableAdapter()
        WeekLabel2 = New System.Windows.Forms.Label()
        CType(Me.SitesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexiconRecManagerDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexiconRecManagerDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanTypesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlanBindingNavigator.SuspendLayout()
        CType(Me.PlanViewDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.JobCategoryIdComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BreakDeductedCB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeIdComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlansAuditBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ratecombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeekendingdateiflatereasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeekLabel23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem84, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem83, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem87, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem86, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem73, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem72, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem70, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem76, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem75, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem78, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem77, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem80, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem79, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem82, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem85, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeeknumbersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeeknumbersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanViewBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WeekLabel2
        '
        WeekLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WeekLabel2.Location = New System.Drawing.Point(1247, 57)
        WeekLabel2.Name = "WeekLabel2"
        WeekLabel2.Size = New System.Drawing.Size(92, 47)
        WeekLabel2.TabIndex = 1
        WeekLabel2.Text = "Week:"
        '
        'PlanTableAdapter
        '
        Me.PlanTableAdapter.ClearBeforeFill = True
        '
        'PlanTypesTableAdapter
        '
        Me.PlanTypesTableAdapter.ClearBeforeFill = True
        '
        'SitesBindingSource
        '
        Me.SitesBindingSource.DataMember = "Sites"
        Me.SitesBindingSource.DataSource = Me.Sites
        Me.SitesBindingSource.Sort = "clientcode"
        '
        'Sites
        '
        Me.Sites.DataSetName = "Sites"
        Me.Sites.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SitesTableAdapter
        '
        Me.SitesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.BanksTableAdapter = Nothing
        Me.TableAdapterManager1.CompanyContactsTableAdapter = Nothing
        Me.TableAdapterManager1.EmployeesMoneyOwedTableAdapter = Nothing
        Me.TableAdapterManager1.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager1.HolidaysTableAdapter = Nothing
        Me.TableAdapterManager1.JobCategoryTableAdapter = Nothing
        Me.TableAdapterManager1.PlanTypesTableAdapter = Nothing
        Me.TableAdapterManager1.SitesTableAdapter = Me.SitesTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Lexrecmgr.SitesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UsersTableAdapter = Nothing
        '
        'JobCategoryTableAdapter
        '
        Me.JobCategoryTableAdapter.ClearBeforeFill = True
        '
        'LexiconRecManagerDataSet2
        '
        Me.LexiconRecManagerDataSet2.DataSetName = "LexiconRecManagerDataSet"
        Me.LexiconRecManagerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DataTable2BindingSource
        Me.ComboBox1.DisplayMember = "ClientCode"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(622, 79)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(196, 24)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.ValueMember = "CompanyId"
        Me.ComboBox1.Visible = False
        '
        'DataTable2BindingSource
        '
        Me.DataTable2BindingSource.AllowNew = False
        Me.DataTable2BindingSource.DataMember = "DataTable2"
        Me.DataTable2BindingSource.DataSource = Me.LexiconRecManagerDataSet2
        '
        'BranchSelect
        '
        Me.BranchSelect.DataSource = Me.BranchBindingSource1
        Me.BranchSelect.DisplayMember = "Branch"
        Me.BranchSelect.FormattingEnabled = True
        Me.BranchSelect.Location = New System.Drawing.Point(16, 79)
        Me.BranchSelect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BranchSelect.Name = "BranchSelect"
        Me.BranchSelect.Size = New System.Drawing.Size(196, 24)
        Me.BranchSelect.TabIndex = 2
        Me.BranchSelect.ValueMember = "BranchID"
        '
        'BranchBindingSource1
        '
        Me.BranchBindingSource1.DataMember = "Branch"
        Me.BranchBindingSource1.DataSource = Me.LexiconRecManagerDataSet1
        '
        'LexiconRecManagerDataSet1
        '
        Me.LexiconRecManagerDataSet1.DataSetName = "LexiconRecManagerDataSet"
        Me.LexiconRecManagerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WeekSelect
        '
        Me.WeekSelect.DataSource = Me.PlanBindingSource1
        Me.WeekSelect.DisplayMember = "WeekEndingDate"
        Me.WeekSelect.FormatString = "D"
        Me.WeekSelect.FormattingEnabled = True
        Me.WeekSelect.Location = New System.Drawing.Point(420, 79)
        Me.WeekSelect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WeekSelect.Name = "WeekSelect"
        Me.WeekSelect.Size = New System.Drawing.Size(196, 24)
        Me.WeekSelect.TabIndex = 4
        Me.WeekSelect.ValueMember = "WeekEndingDate"
        '
        'PlanBindingSource1
        '
        Me.PlanBindingSource1.DataMember = "Plan"
        Me.PlanBindingSource1.DataSource = Me.Sites
        '
        'PlanSelect
        '
        Me.PlanSelect.DataSource = Me.PlanTypesBindingSource1
        Me.PlanSelect.DisplayMember = "PlanName"
        Me.PlanSelect.FormattingEnabled = True
        Me.PlanSelect.Location = New System.Drawing.Point(218, 79)
        Me.PlanSelect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PlanSelect.Name = "PlanSelect"
        Me.PlanSelect.Size = New System.Drawing.Size(196, 24)
        Me.PlanSelect.TabIndex = 3
        Me.PlanSelect.ValueMember = "PlanTypeID"
        '
        'PlanTypesBindingSource1
        '
        Me.PlanTypesBindingSource1.DataMember = "PlanTypes"
        Me.PlanTypesBindingSource1.DataSource = Me.Sites
        '
        'TextBox22
        '
        Me.TextBox22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "SystemType", True))
        Me.TextBox22.Location = New System.Drawing.Point(875, 350)
        Me.TextBox22.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.ReadOnly = True
        Me.TextBox22.Size = New System.Drawing.Size(197, 25)
        Me.TextBox22.TabIndex = 1
        '
        'PlanBindingSource
        '
        Me.PlanBindingSource.DataMember = "Plan2PerRecord"
        Me.PlanBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'LexiconRecManagerDataSet
        '
        Me.LexiconRecManagerDataSet.DataSetName = "LexiconRecManagerDataSet"
        Me.LexiconRecManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox21
        '
        Me.TextBox21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobCategoryBindingSource, "StartOfWeek", True))
        Me.TextBox21.Location = New System.Drawing.Point(385, 190)
        Me.TextBox21.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.ReadOnly = True
        Me.TextBox21.Size = New System.Drawing.Size(172, 34)
        Me.TextBox21.TabIndex = 1
        '
        'JobCategoryBindingSource
        '
        Me.JobCategoryBindingSource.DataMember = "JobCategory"
        Me.JobCategoryBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'BranchIdComboBox
        '
        Me.BranchIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PlanBindingSource, "BranchId", True))
        Me.BranchIdComboBox.DataSource = Me.BranchBindingSource
        Me.BranchIdComboBox.DisplayMember = "Branch"
        Me.BranchIdComboBox.Enabled = False
        Me.BranchIdComboBox.FormattingEnabled = True
        Me.BranchIdComboBox.Location = New System.Drawing.Point(208, 190)
        Me.BranchIdComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BranchIdComboBox.Name = "BranchIdComboBox"
        Me.BranchIdComboBox.Size = New System.Drawing.Size(171, 24)
        Me.BranchIdComboBox.TabIndex = 1
        Me.BranchIdComboBox.ValueMember = "BranchID"
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'PlanIDTextBox
        '
        Me.PlanIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "PlanID", True))
        Me.PlanIDTextBox.Location = New System.Drawing.Point(1078, 350)
        Me.PlanIDTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PlanIDTextBox.Name = "PlanIDTextBox"
        Me.PlanIDTextBox.ReadOnly = True
        Me.PlanIDTextBox.Size = New System.Drawing.Size(258, 25)
        Me.PlanIDTextBox.TabIndex = 1
        '
        'TextBox20
        '
        Me.TextBox20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "LastModifiedDate", True))
        Me.TextBox20.Location = New System.Drawing.Point(506, 350)
        Me.TextBox20.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.ReadOnly = True
        Me.TextBox20.Size = New System.Drawing.Size(363, 25)
        Me.TextBox20.TabIndex = 1
        '
        'LastModifiedUserTextBox
        '
        Me.LastModifiedUserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "LastModifiedUser", True))
        Me.LastModifiedUserTextBox.Location = New System.Drawing.Point(31, 350)
        Me.LastModifiedUserTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LastModifiedUserTextBox.Name = "LastModifiedUserTextBox"
        Me.LastModifiedUserTextBox.ReadOnly = True
        Me.LastModifiedUserTextBox.Size = New System.Drawing.Size(469, 25)
        Me.LastModifiedUserTextBox.TabIndex = 1
        '
        'POAElseWhereTextBox
        '
        Me.POAElseWhereTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "POAElseWhere", True))
        Me.POAElseWhereTextBox.Location = New System.Drawing.Point(622, 300)
        Me.POAElseWhereTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.POAElseWhereTextBox.Name = "POAElseWhereTextBox"
        Me.POAElseWhereTextBox.Size = New System.Drawing.Size(191, 25)
        Me.POAElseWhereTextBox.TabIndex = 1
        '
        'HoursWorkedElseWhereTextBox
        '
        Me.HoursWorkedElseWhereTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "HoursWorkedElseWhere", True))
        Me.HoursWorkedElseWhereTextBox.Location = New System.Drawing.Point(425, 300)
        Me.HoursWorkedElseWhereTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HoursWorkedElseWhereTextBox.Name = "HoursWorkedElseWhereTextBox"
        Me.HoursWorkedElseWhereTextBox.Size = New System.Drawing.Size(191, 25)
        Me.HoursWorkedElseWhereTextBox.TabIndex = 1
        '
        'POATextBox
        '
        Me.POATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "POA", True))
        Me.POATextBox.Location = New System.Drawing.Point(228, 300)
        Me.POATextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.POATextBox.Name = "POATextBox"
        Me.POATextBox.Size = New System.Drawing.Size(191, 25)
        Me.POATextBox.TabIndex = 1
        '
        'PoNumberTextBox
        '
        Me.PoNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "PoNumber", True))
        Me.PoNumberTextBox.Location = New System.Drawing.Point(31, 300)
        Me.PoNumberTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PoNumberTextBox.Name = "PoNumberTextBox"
        Me.PoNumberTextBox.Size = New System.Drawing.Size(191, 25)
        Me.PoNumberTextBox.TabIndex = 1
        '
        'WeekEndingDateTextBox
        '
        Me.WeekEndingDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "WeekEndingDate", True))
        Me.WeekEndingDateTextBox.Location = New System.Drawing.Point(31, 249)
        Me.WeekEndingDateTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WeekEndingDateTextBox.Name = "WeekEndingDateTextBox"
        Me.WeekEndingDateTextBox.Size = New System.Drawing.Size(196, 25)
        Me.WeekEndingDateTextBox.TabIndex = 1
        '
        'WeekEndingDateIfLateTextBox
        '
        Me.WeekEndingDateIfLateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "WeekEndingDateIfLate", True))
        Me.WeekEndingDateIfLateTextBox.Location = New System.Drawing.Point(233, 249)
        Me.WeekEndingDateIfLateTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WeekEndingDateIfLateTextBox.Name = "WeekEndingDateIfLateTextBox"
        Me.WeekEndingDateIfLateTextBox.Size = New System.Drawing.Size(175, 26)
        Me.WeekEndingDateIfLateTextBox.TabIndex = 1
        '
        'FridayCheckBox
        '
        Me.FridayCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.FridayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Friday", True))
        Me.FridayCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FridayCheckBox.Location = New System.Drawing.Point(819, 281)
        Me.FridayCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FridayCheckBox.MinimumSize = New System.Drawing.Size(48, 25)
        Me.FridayCheckBox.Name = "FridayCheckBox"
        Me.FridayCheckBox.Size = New System.Drawing.Size(48, 44)
        Me.FridayCheckBox.TabIndex = 1
        Me.FridayCheckBox.Text = "Fri"
        Me.FridayCheckBox.UseVisualStyleBackColor = False
        '
        'SaturdayCheckBox
        '
        Me.SaturdayCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.SaturdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Saturday", True))
        Me.SaturdayCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaturdayCheckBox.Location = New System.Drawing.Point(873, 281)
        Me.SaturdayCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SaturdayCheckBox.MinimumSize = New System.Drawing.Size(58, 25)
        Me.SaturdayCheckBox.Name = "SaturdayCheckBox"
        Me.SaturdayCheckBox.Size = New System.Drawing.Size(58, 44)
        Me.SaturdayCheckBox.TabIndex = 1
        Me.SaturdayCheckBox.Text = "Sat"
        Me.SaturdayCheckBox.UseVisualStyleBackColor = False
        '
        'SundayCheckBox
        '
        Me.SundayCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.SundayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Sunday", True))
        Me.SundayCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SundayCheckBox.Location = New System.Drawing.Point(937, 281)
        Me.SundayCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SundayCheckBox.MinimumSize = New System.Drawing.Size(58, 25)
        Me.SundayCheckBox.Name = "SundayCheckBox"
        Me.SundayCheckBox.Size = New System.Drawing.Size(58, 44)
        Me.SundayCheckBox.TabIndex = 1
        Me.SundayCheckBox.Text = "Sun"
        Me.SundayCheckBox.UseVisualStyleBackColor = False
        '
        'MondayCheckBox
        '
        Me.MondayCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.MondayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Monday", True))
        Me.MondayCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MondayCheckBox.Location = New System.Drawing.Point(1001, 281)
        Me.MondayCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MondayCheckBox.MinimumSize = New System.Drawing.Size(58, 25)
        Me.MondayCheckBox.Name = "MondayCheckBox"
        Me.MondayCheckBox.Size = New System.Drawing.Size(58, 44)
        Me.MondayCheckBox.TabIndex = 1
        Me.MondayCheckBox.Text = "Mon"
        Me.MondayCheckBox.UseVisualStyleBackColor = False
        '
        'TuesdayCheckBox
        '
        Me.TuesdayCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.TuesdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Tuesday", True))
        Me.TuesdayCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TuesdayCheckBox.Location = New System.Drawing.Point(1065, 281)
        Me.TuesdayCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TuesdayCheckBox.MinimumSize = New System.Drawing.Size(48, 25)
        Me.TuesdayCheckBox.Name = "TuesdayCheckBox"
        Me.TuesdayCheckBox.Size = New System.Drawing.Size(54, 44)
        Me.TuesdayCheckBox.TabIndex = 1
        Me.TuesdayCheckBox.Text = "Tue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TuesdayCheckBox.UseVisualStyleBackColor = False
        '
        'WednesdayCheckBox
        '
        Me.WednesdayCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.WednesdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Wednesday", True))
        Me.WednesdayCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WednesdayCheckBox.Location = New System.Drawing.Point(1125, 281)
        Me.WednesdayCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WednesdayCheckBox.MinimumSize = New System.Drawing.Size(56, 25)
        Me.WednesdayCheckBox.Name = "WednesdayCheckBox"
        Me.WednesdayCheckBox.Size = New System.Drawing.Size(56, 44)
        Me.WednesdayCheckBox.TabIndex = 1
        Me.WednesdayCheckBox.Text = "Wed"
        Me.WednesdayCheckBox.UseVisualStyleBackColor = False
        '
        'ThursdayCheckBox
        '
        Me.ThursdayCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.ThursdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Thursday", True))
        Me.ThursdayCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThursdayCheckBox.Location = New System.Drawing.Point(1187, 281)
        Me.ThursdayCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ThursdayCheckBox.MinimumSize = New System.Drawing.Size(58, 25)
        Me.ThursdayCheckBox.Name = "ThursdayCheckBox"
        Me.ThursdayCheckBox.Size = New System.Drawing.Size(58, 44)
        Me.ThursdayCheckBox.TabIndex = 1
        Me.ThursdayCheckBox.Text = "Thur"
        Me.ThursdayCheckBox.UseVisualStyleBackColor = False
        '
        'Friday2CheckBox
        '
        Me.Friday2CheckBox.BackColor = System.Drawing.Color.Transparent
        Me.Friday2CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Friday2", True))
        Me.Friday2CheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Friday2CheckBox.Location = New System.Drawing.Point(1251, 281)
        Me.Friday2CheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Friday2CheckBox.MinimumSize = New System.Drawing.Size(48, 25)
        Me.Friday2CheckBox.Name = "Friday2CheckBox"
        Me.Friday2CheckBox.Size = New System.Drawing.Size(48, 44)
        Me.Friday2CheckBox.TabIndex = 1
        Me.Friday2CheckBox.Text = "Fri"
        Me.Friday2CheckBox.UseVisualStyleBackColor = False
        '
        'Saturday2CheckBox
        '
        Me.Saturday2CheckBox.BackColor = System.Drawing.Color.Transparent
        Me.Saturday2CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Saturday2", True))
        Me.Saturday2CheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Saturday2CheckBox.Location = New System.Drawing.Point(1305, 281)
        Me.Saturday2CheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Saturday2CheckBox.MinimumSize = New System.Drawing.Size(48, 25)
        Me.Saturday2CheckBox.Name = "Saturday2CheckBox"
        Me.Saturday2CheckBox.Size = New System.Drawing.Size(48, 44)
        Me.Saturday2CheckBox.TabIndex = 1
        Me.Saturday2CheckBox.Text = "Sat"
        Me.Saturday2CheckBox.UseVisualStyleBackColor = False
        '
        'Sunday2CheckBox
        '
        Me.Sunday2CheckBox.BackColor = System.Drawing.Color.Transparent
        Me.Sunday2CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Sunday2", True))
        Me.Sunday2CheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sunday2CheckBox.Location = New System.Drawing.Point(1359, 281)
        Me.Sunday2CheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Sunday2CheckBox.MinimumSize = New System.Drawing.Size(58, 25)
        Me.Sunday2CheckBox.Name = "Sunday2CheckBox"
        Me.Sunday2CheckBox.Size = New System.Drawing.Size(58, 44)
        Me.Sunday2CheckBox.TabIndex = 1
        Me.Sunday2CheckBox.Text = "Sun"
        Me.Sunday2CheckBox.UseVisualStyleBackColor = False
        '
        'PlanTypeIdComboBox
        '
        Me.PlanTypeIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PlanBindingSource, "PlanTypeId", True))
        Me.PlanTypeIdComboBox.DataSource = Me.PlanTypesBindingSource
        Me.PlanTypeIdComboBox.DisplayMember = "PlanName"
        Me.PlanTypeIdComboBox.Enabled = False
        Me.PlanTypeIdComboBox.FormattingEnabled = True
        Me.PlanTypeIdComboBox.Location = New System.Drawing.Point(414, 249)
        Me.PlanTypeIdComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PlanTypeIdComboBox.Name = "PlanTypeIdComboBox"
        Me.PlanTypeIdComboBox.Size = New System.Drawing.Size(196, 24)
        Me.PlanTypeIdComboBox.TabIndex = 1
        Me.PlanTypeIdComboBox.ValueMember = "PlanTypeID"
        '
        'PlanTypesBindingSource
        '
        Me.PlanTypesBindingSource.DataMember = "PlanTypes"
        Me.PlanTypesBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.Sites
        Me.EmployeesBindingSource.Filter = "SystemType = 'C'"
        '
        'DateAddedDateTimePicker
        '
        Me.DateAddedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PlanBindingSource, "DateAdded", True))
        Me.DateAddedDateTimePicker.Location = New System.Drawing.Point(31, 190)
        Me.DateAddedDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateAddedDateTimePicker.Name = "DateAddedDateTimePicker"
        Me.DateAddedDateTimePicker.Size = New System.Drawing.Size(171, 23)
        Me.DateAddedDateTimePicker.TabIndex = 1
        '
        'tbEndTime
        '
        Me.tbEndTime.Location = New System.Drawing.Point(691, 392)
        Me.tbEndTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbEndTime.Name = "tbEndTime"
        Me.tbEndTime.ReadOnly = True
        Me.tbEndTime.Size = New System.Drawing.Size(55, 25)
        Me.tbEndTime.TabIndex = 172
        '
        'tbStartTime
        '
        Me.tbStartTime.Location = New System.Drawing.Point(630, 392)
        Me.tbStartTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbStartTime.Name = "tbStartTime"
        Me.tbStartTime.ReadOnly = True
        Me.tbStartTime.Size = New System.Drawing.Size(55, 25)
        Me.tbStartTime.TabIndex = 170
        '
        'RulesOrDetailsRichTextBox
        '
        Me.RulesOrDetailsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "RulesOrDetails", True))
        Me.RulesOrDetailsRichTextBox.Location = New System.Drawing.Point(917, 276)
        Me.RulesOrDetailsRichTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RulesOrDetailsRichTextBox.Name = "RulesOrDetailsRichTextBox"
        Me.RulesOrDetailsRichTextBox.ReadOnly = True
        Me.RulesOrDetailsRichTextBox.Size = New System.Drawing.Size(510, 147)
        Me.RulesOrDetailsRichTextBox.TabIndex = 169
        Me.RulesOrDetailsRichTextBox.Text = ""
        '
        'TextBox18
        '
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "PostTaxDeductions", True))
        Me.TextBox18.Location = New System.Drawing.Point(333, 392)
        Me.TextBox18.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(77, 25)
        Me.TextBox18.TabIndex = 56
        '
        'TextBox19
        '
        Me.TextBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "PostTaxNotes", True))
        Me.TextBox19.Location = New System.Drawing.Point(416, 392)
        Me.TextBox19.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(196, 25)
        Me.TextBox19.TabIndex = 58
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "PreTaxDeductions", True))
        Me.TextBox16.Location = New System.Drawing.Point(37, 392)
        Me.TextBox16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(76, 25)
        Me.TextBox16.TabIndex = 56
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "PreTaxNotes", True))
        Me.TextBox17.Location = New System.Drawing.Point(119, 392)
        Me.TextBox17.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(196, 25)
        Me.TextBox17.TabIndex = 58
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "ExpensesPostPay", True))
        Me.TextBox13.Location = New System.Drawing.Point(576, 306)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(55, 25)
        Me.TextBox13.TabIndex = 56
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "ExpensesPostNotes", True))
        Me.TextBox14.Location = New System.Drawing.Point(698, 306)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(197, 25)
        Me.TextBox14.TabIndex = 58
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "ExpensesPostCharge", True))
        Me.TextBox15.Location = New System.Drawing.Point(637, 306)
        Me.TextBox15.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(55, 25)
        Me.TextBox15.TabIndex = 57
        '
        'ExpensesPrePayTextBox
        '
        Me.ExpensesPrePayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "ExpensesPrePay", True))
        Me.ExpensesPrePayTextBox.Location = New System.Drawing.Point(369, 306)
        Me.ExpensesPrePayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ExpensesPrePayTextBox.Name = "ExpensesPrePayTextBox"
        Me.ExpensesPrePayTextBox.Size = New System.Drawing.Size(55, 25)
        Me.ExpensesPrePayTextBox.TabIndex = 56
        '
        'ExpensesPreNotesTextBox
        '
        Me.ExpensesPreNotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "ExpensesPreNotes", True))
        Me.ExpensesPreNotesTextBox.Location = New System.Drawing.Point(491, 306)
        Me.ExpensesPreNotesTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ExpensesPreNotesTextBox.Name = "ExpensesPreNotesTextBox"
        Me.ExpensesPreNotesTextBox.Size = New System.Drawing.Size(67, 25)
        Me.ExpensesPreNotesTextBox.TabIndex = 58
        '
        'ExpensesPreChargeTextBox
        '
        Me.ExpensesPreChargeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "ExpensesPreCharge", True))
        Me.ExpensesPreChargeTextBox.Location = New System.Drawing.Point(430, 306)
        Me.ExpensesPreChargeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ExpensesPreChargeTextBox.Name = "ExpensesPreChargeTextBox"
        Me.ExpensesPreChargeTextBox.Size = New System.Drawing.Size(55, 25)
        Me.ExpensesPreChargeTextBox.TabIndex = 57
        '
        'OT2ChargeTextBox
        '
        Me.OT2ChargeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "OT2Charge", True))
        Me.OT2ChargeTextBox.Location = New System.Drawing.Point(783, 220)
        Me.OT2ChargeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OT2ChargeTextBox.Name = "OT2ChargeTextBox"
        Me.OT2ChargeTextBox.ReadOnly = True
        Me.OT2ChargeTextBox.Size = New System.Drawing.Size(28, 25)
        Me.OT2ChargeTextBox.TabIndex = 57
        '
        'OT2HoursTextBox
        '
        Me.OT2HoursTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "OT2Hours", True))
        Me.OT2HoursTextBox.Location = New System.Drawing.Point(680, 220)
        Me.OT2HoursTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OT2HoursTextBox.Name = "OT2HoursTextBox"
        Me.OT2HoursTextBox.Size = New System.Drawing.Size(45, 25)
        Me.OT2HoursTextBox.TabIndex = 22
        Me.OT2HoursTextBox.Text = "0"
        '
        'OT2PayTextBox
        '
        Me.OT2PayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "OT2Pay", True))
        Me.OT2PayTextBox.Location = New System.Drawing.Point(731, 220)
        Me.OT2PayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OT2PayTextBox.Name = "OT2PayTextBox"
        Me.OT2PayTextBox.Size = New System.Drawing.Size(46, 25)
        Me.OT2PayTextBox.TabIndex = 23
        '
        'OT3ChargeTextBox
        '
        Me.OT3ChargeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "OT3Charge", True))
        Me.OT3ChargeTextBox.Location = New System.Drawing.Point(911, 220)
        Me.OT3ChargeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OT3ChargeTextBox.Name = "OT3ChargeTextBox"
        Me.OT3ChargeTextBox.Size = New System.Drawing.Size(45, 25)
        Me.OT3ChargeTextBox.TabIndex = 58
        '
        'OT3HoursTextBox
        '
        Me.OT3HoursTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "OT3Hours", True))
        Me.OT3HoursTextBox.Location = New System.Drawing.Point(829, 220)
        Me.OT3HoursTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OT3HoursTextBox.MinimumSize = New System.Drawing.Size(4, 25)
        Me.OT3HoursTextBox.Name = "OT3HoursTextBox"
        Me.OT3HoursTextBox.Size = New System.Drawing.Size(35, 25)
        Me.OT3HoursTextBox.TabIndex = 56
        Me.OT3HoursTextBox.Text = "0"
        '
        'OT3PayTextBox
        '
        Me.OT3PayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "OT3Pay", True))
        Me.OT3PayTextBox.Location = New System.Drawing.Point(870, 220)
        Me.OT3PayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OT3PayTextBox.Name = "OT3PayTextBox"
        Me.OT3PayTextBox.Size = New System.Drawing.Size(35, 25)
        Me.OT3PayTextBox.TabIndex = 57
        '
        'NightsOutCharge
        '
        Me.NightsOutCharge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "NightsOutCharge", True))
        Me.NightsOutCharge.Location = New System.Drawing.Point(306, 306)
        Me.NightsOutCharge.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NightsOutCharge.Name = "NightsOutCharge"
        Me.NightsOutCharge.ReadOnly = True
        Me.NightsOutCharge.Size = New System.Drawing.Size(45, 25)
        Me.NightsOutCharge.TabIndex = 56
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "NightsOutHours", True))
        Me.TextBox11.Location = New System.Drawing.Point(203, 306)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(45, 25)
        Me.TextBox11.TabIndex = 51
        Me.TextBox11.Text = "0"
        '
        'NightsPay
        '
        Me.NightsPay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "NightsOutPay", True))
        Me.NightsPay.Location = New System.Drawing.Point(254, 306)
        Me.NightsPay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NightsPay.Name = "NightsPay"
        Me.NightsPay.Size = New System.Drawing.Size(46, 25)
        Me.NightsPay.TabIndex = 53
        '
        'BankCharge
        '
        Me.BankCharge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "BankCharge", True))
        Me.BankCharge.Location = New System.Drawing.Point(140, 306)
        Me.BankCharge.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BankCharge.Name = "BankCharge"
        Me.BankCharge.ReadOnly = True
        Me.BankCharge.Size = New System.Drawing.Size(45, 25)
        Me.BankCharge.TabIndex = 56
        '
        'BankHours
        '
        Me.BankHours.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "BankHours", True))
        Me.BankHours.Location = New System.Drawing.Point(37, 306)
        Me.BankHours.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BankHours.Name = "BankHours"
        Me.BankHours.Size = New System.Drawing.Size(45, 25)
        Me.BankHours.TabIndex = 51
        Me.BankHours.Text = "0"
        '
        'BankPay
        '
        Me.BankPay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "BankPay", True))
        Me.BankPay.Location = New System.Drawing.Point(88, 306)
        Me.BankPay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BankPay.Name = "BankPay"
        Me.BankPay.Size = New System.Drawing.Size(46, 25)
        Me.BankPay.TabIndex = 53
        '
        'SundayCharge
        '
        Me.SundayCharge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "SundayCharge", True))
        Me.SundayCharge.Location = New System.Drawing.Point(1329, 220)
        Me.SundayCharge.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SundayCharge.Name = "SundayCharge"
        Me.SundayCharge.ReadOnly = True
        Me.SundayCharge.Size = New System.Drawing.Size(56, 25)
        Me.SundayCharge.TabIndex = 56
        '
        'SundayHours
        '
        Me.SundayHours.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "SundayHours", True))
        Me.SundayHours.Location = New System.Drawing.Point(1238, 220)
        Me.SundayHours.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SundayHours.Name = "SundayHours"
        Me.SundayHours.Size = New System.Drawing.Size(35, 25)
        Me.SundayHours.TabIndex = 51
        Me.SundayHours.Text = "0"
        '
        'SundayPay
        '
        Me.SundayPay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "SundayPay", True))
        Me.SundayPay.Location = New System.Drawing.Point(1279, 220)
        Me.SundayPay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SundayPay.Name = "SundayPay"
        Me.SundayPay.Size = New System.Drawing.Size(44, 25)
        Me.SundayPay.TabIndex = 53
        '
        'SatCharge
        '
        Me.SatCharge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "SaturdayCharge", True))
        Me.SatCharge.Location = New System.Drawing.Point(1175, 220)
        Me.SatCharge.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SatCharge.Name = "SatCharge"
        Me.SatCharge.ReadOnly = True
        Me.SatCharge.Size = New System.Drawing.Size(45, 25)
        Me.SatCharge.TabIndex = 56
        '
        'SatHours
        '
        Me.SatHours.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "SaturdayHours", True))
        Me.SatHours.Location = New System.Drawing.Point(1093, 220)
        Me.SatHours.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SatHours.Name = "SatHours"
        Me.SatHours.Size = New System.Drawing.Size(35, 25)
        Me.SatHours.TabIndex = 51
        Me.SatHours.Text = "0"
        '
        'SatPay
        '
        Me.SatPay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "SaturdayPay", True))
        Me.SatPay.Location = New System.Drawing.Point(1134, 220)
        Me.SatPay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SatPay.Name = "SatPay"
        Me.SatPay.Size = New System.Drawing.Size(35, 25)
        Me.SatPay.TabIndex = 53
        '
        'OT1ChargeTextBox
        '
        Me.OT1ChargeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "OT1Charge", True))
        Me.OT1ChargeTextBox.Location = New System.Drawing.Point(616, 220)
        Me.OT1ChargeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OT1ChargeTextBox.Name = "OT1ChargeTextBox"
        Me.OT1ChargeTextBox.ReadOnly = True
        Me.OT1ChargeTextBox.Size = New System.Drawing.Size(46, 25)
        Me.OT1ChargeTextBox.TabIndex = 21
        '
        'OT1HoursTextBox
        '
        Me.OT1HoursTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "OT1Hours", True))
        Me.OT1HoursTextBox.Location = New System.Drawing.Point(534, 220)
        Me.OT1HoursTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OT1HoursTextBox.Name = "OT1HoursTextBox"
        Me.OT1HoursTextBox.Size = New System.Drawing.Size(35, 25)
        Me.OT1HoursTextBox.TabIndex = 19
        Me.OT1HoursTextBox.Text = "0"
        '
        'OT1PayTextBox
        '
        Me.OT1PayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "OT1Pay", True))
        Me.OT1PayTextBox.Location = New System.Drawing.Point(575, 220)
        Me.OT1PayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OT1PayTextBox.Name = "OT1PayTextBox"
        Me.OT1PayTextBox.Size = New System.Drawing.Size(35, 25)
        Me.OT1PayTextBox.TabIndex = 20
        '
        'MinCharge
        '
        Me.MinCharge.Location = New System.Drawing.Point(451, 218)
        Me.MinCharge.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinCharge.Name = "MinCharge"
        Me.MinCharge.ReadOnly = True
        Me.MinCharge.Size = New System.Drawing.Size(67, 29)
        Me.MinCharge.TabIndex = 18
        '
        'SWHTextBox
        '
        Me.SWHTextBox.Location = New System.Drawing.Point(390, 218)
        Me.SWHTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SWHTextBox.Name = "SWHTextBox"
        Me.SWHTextBox.ReadOnly = True
        Me.SWHTextBox.Size = New System.Drawing.Size(55, 29)
        Me.SWHTextBox.TabIndex = 17
        '
        'DHHTextBox
        '
        Me.DHHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "DHH", True))
        Me.DHHTextBox.Location = New System.Drawing.Point(338, 218)
        Me.DHHTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DHHTextBox.Name = "DHHTextBox"
        Me.DHHTextBox.ReadOnly = True
        Me.DHHTextBox.Size = New System.Drawing.Size(46, 29)
        Me.DHHTextBox.TabIndex = 16
        '
        'ChargeTextBox
        '
        Me.ChargeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "Charge", True))
        Me.ChargeTextBox.Location = New System.Drawing.Point(277, 218)
        Me.ChargeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ChargeTextBox.Name = "ChargeTextBox"
        Me.ChargeTextBox.ReadOnly = True
        Me.ChargeTextBox.Size = New System.Drawing.Size(55, 29)
        Me.ChargeTextBox.TabIndex = 15
        '
        'HolidayPayTextBox
        '
        Me.HolidayPayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "HolidayPay", True))
        Me.HolidayPayTextBox.Location = New System.Drawing.Point(208, 218)
        Me.HolidayPayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HolidayPayTextBox.Name = "HolidayPayTextBox"
        Me.HolidayPayTextBox.ReadOnly = True
        Me.HolidayPayTextBox.Size = New System.Drawing.Size(63, 29)
        Me.HolidayPayTextBox.TabIndex = 14
        '
        'PayTextBox
        '
        Me.PayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "Pay", True))
        Me.PayTextBox.Location = New System.Drawing.Point(157, 218)
        Me.PayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PayTextBox.Name = "PayTextBox"
        Me.PayTextBox.Size = New System.Drawing.Size(45, 29)
        Me.PayTextBox.TabIndex = 13
        '
        'HoursTextBox
        '
        Me.HoursTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "Hours", True))
        Me.HoursTextBox.Location = New System.Drawing.Point(106, 218)
        Me.HoursTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HoursTextBox.Name = "HoursTextBox"
        Me.HoursTextBox.Size = New System.Drawing.Size(45, 29)
        Me.HoursTextBox.TabIndex = 12
        '
        'PlanBindingNavigator
        '
        Me.PlanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PlanBindingNavigator.AutoSize = False
        Me.PlanBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.PlanBindingNavigator.BindingSource = Me.PlanBindingSource
        Me.PlanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PlanBindingNavigator.DeleteItem = Nothing
        Me.PlanBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.PlanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripButton3, Me.PlanBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.PlanBindingNavigator.Location = New System.Drawing.Point(16, 16)
        Me.PlanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PlanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PlanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PlanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PlanBindingNavigator.Name = "PlanBindingNavigator"
        Me.PlanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PlanBindingNavigator.Size = New System.Drawing.Size(1426, 38)
        Me.PlanBindingNavigator.TabIndex = 0
        Me.PlanBindingNavigator.Text = "BindingNavigator1"
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
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 35)
        Me.ToolStripButton3.Text = "Delete"
        '
        'PlanBindingNavigatorSaveItem
        '
        Me.PlanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PlanBindingNavigatorSaveItem.Image = CType(resources.GetObject("PlanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PlanBindingNavigatorSaveItem.Name = "PlanBindingNavigatorSaveItem"
        Me.PlanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 35)
        Me.PlanBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 35)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(228, 35)
        Me.ToolStripButton2.Text = "Insert Current Week Ending Date"
        '
        'PlanViewDataGridView
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PlanViewDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.PlanViewDataGridView.AutoGenerateColumns = False
        Me.PlanViewDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.PlanViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlanViewDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Lock, Me.PlanIDDataGridViewTextBoxColumn, Me.SystemTypeDataGridViewTextBoxColumn, Me.PlanNameDataGridViewTextBoxColumn, Me.PlanTypeIdDataGridViewTextBoxColumn, Me.CompanyIdDataGridViewTextBoxColumn, Me.CompanyNameDataGridViewTextBoxColumn, Me.ForenameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.EmployeeIdDataGridViewTextBoxColumn, Me.EmployeeCodeDataGridViewTextBoxColumn, Me.SchemeDataGridViewTextBoxColumn, Me.JobCategoryIdDataGridViewTextBoxColumn, Me.JobCategoryDataGridViewTextBoxColumn, Me.ShiftNameDataGridViewTextBoxColumn, Me.WeekEndingDateDataGridViewTextBoxColumn, Me.WeekEndingDateIfLateDataGridViewTextBoxColumn, Me.FridayDataGridViewCheckBoxColumn, Me.SaturdayDataGridViewCheckBoxColumn, Me.SundayDataGridViewCheckBoxColumn, Me.MondayDataGridViewCheckBoxColumn, Me.TuesdayDataGridViewCheckBoxColumn, Me.WednesdayDataGridViewCheckBoxColumn, Me.ThursdayDataGridViewCheckBoxColumn, Me.Friday2DataGridViewCheckBoxColumn, Me.Saturday2DataGridViewCheckBoxColumn, Me.Sunday2DataGridViewCheckBoxColumn, Me.HoursDataGridViewTextBoxColumn, Me.PayDataGridViewTextBoxColumn, Me.HolidayPayDataGridViewTextBoxColumn, Me.ChargeDataGridViewTextBoxColumn, Me.TotalHoursDataGridViewTextBoxColumn, Me.TotalPayDataGridViewTextBoxColumn, Me.TotalChargeDataGridViewTextBoxColumn, Me.TotalHolidayPayDataGridViewTextBoxColumn, Me.TotalNiDataGridViewTextBoxColumn, Me.TotalCostDataGridViewTextBoxColumn, Me.EstMarginDataGridViewTextBoxColumn, Me.BranchIdDataGridViewTextBoxColumn, Me.PoNumberDataGridViewTextBoxColumn, Me.OrderNumberReqDataGridViewCheckBoxColumn})
        Me.PlanViewDataGridView.DataSource = Me.DataTable1BindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 7.8!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PlanViewDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.PlanViewDataGridView.Location = New System.Drawing.Point(14, 489)
        Me.PlanViewDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PlanViewDataGridView.MultiSelect = False
        Me.PlanViewDataGridView.Name = "PlanViewDataGridView"
        Me.PlanViewDataGridView.ReadOnly = True
        Me.PlanViewDataGridView.Size = New System.Drawing.Size(1620, 148)
        Me.PlanViewDataGridView.TabIndex = 24
        '
        'Lock
        '
        Me.Lock.HeaderText = "Lock"
        Me.Lock.Name = "Lock"
        Me.Lock.ReadOnly = True
        '
        'PlanIDDataGridViewTextBoxColumn
        '
        Me.PlanIDDataGridViewTextBoxColumn.DataPropertyName = "PlanID"
        Me.PlanIDDataGridViewTextBoxColumn.HeaderText = "PlanID"
        Me.PlanIDDataGridViewTextBoxColumn.Name = "PlanIDDataGridViewTextBoxColumn"
        Me.PlanIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PlanIDDataGridViewTextBoxColumn.Visible = False
        '
        'SystemTypeDataGridViewTextBoxColumn
        '
        Me.SystemTypeDataGridViewTextBoxColumn.DataPropertyName = "SystemType"
        Me.SystemTypeDataGridViewTextBoxColumn.HeaderText = "SystemType"
        Me.SystemTypeDataGridViewTextBoxColumn.Name = "SystemTypeDataGridViewTextBoxColumn"
        Me.SystemTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PlanNameDataGridViewTextBoxColumn
        '
        Me.PlanNameDataGridViewTextBoxColumn.DataPropertyName = "PlanName"
        Me.PlanNameDataGridViewTextBoxColumn.HeaderText = "PlanName"
        Me.PlanNameDataGridViewTextBoxColumn.Name = "PlanNameDataGridViewTextBoxColumn"
        Me.PlanNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PlanTypeIdDataGridViewTextBoxColumn
        '
        Me.PlanTypeIdDataGridViewTextBoxColumn.DataPropertyName = "PlanTypeId"
        Me.PlanTypeIdDataGridViewTextBoxColumn.HeaderText = "PlanTypeId"
        Me.PlanTypeIdDataGridViewTextBoxColumn.Name = "PlanTypeIdDataGridViewTextBoxColumn"
        Me.PlanTypeIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.PlanTypeIdDataGridViewTextBoxColumn.Visible = False
        '
        'CompanyIdDataGridViewTextBoxColumn
        '
        Me.CompanyIdDataGridViewTextBoxColumn.DataPropertyName = "CompanyId"
        Me.CompanyIdDataGridViewTextBoxColumn.HeaderText = "CompanyId"
        Me.CompanyIdDataGridViewTextBoxColumn.Name = "CompanyIdDataGridViewTextBoxColumn"
        Me.CompanyIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.CompanyIdDataGridViewTextBoxColumn.Visible = False
        '
        'CompanyNameDataGridViewTextBoxColumn
        '
        Me.CompanyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName"
        Me.CompanyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName"
        Me.CompanyNameDataGridViewTextBoxColumn.Name = "CompanyNameDataGridViewTextBoxColumn"
        Me.CompanyNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ForenameDataGridViewTextBoxColumn
        '
        Me.ForenameDataGridViewTextBoxColumn.DataPropertyName = "Forename"
        Me.ForenameDataGridViewTextBoxColumn.HeaderText = "Forename"
        Me.ForenameDataGridViewTextBoxColumn.Name = "ForenameDataGridViewTextBoxColumn"
        Me.ForenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        Me.SurnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeeIdDataGridViewTextBoxColumn
        '
        Me.EmployeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId"
        Me.EmployeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId"
        Me.EmployeeIdDataGridViewTextBoxColumn.Name = "EmployeeIdDataGridViewTextBoxColumn"
        Me.EmployeeIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeIdDataGridViewTextBoxColumn.Visible = False
        '
        'EmployeeCodeDataGridViewTextBoxColumn
        '
        Me.EmployeeCodeDataGridViewTextBoxColumn.DataPropertyName = "EmployeeCode"
        Me.EmployeeCodeDataGridViewTextBoxColumn.HeaderText = "EmployeeCode"
        Me.EmployeeCodeDataGridViewTextBoxColumn.Name = "EmployeeCodeDataGridViewTextBoxColumn"
        Me.EmployeeCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SchemeDataGridViewTextBoxColumn
        '
        Me.SchemeDataGridViewTextBoxColumn.DataPropertyName = "Scheme"
        Me.SchemeDataGridViewTextBoxColumn.HeaderText = "Scheme"
        Me.SchemeDataGridViewTextBoxColumn.Name = "SchemeDataGridViewTextBoxColumn"
        Me.SchemeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JobCategoryIdDataGridViewTextBoxColumn
        '
        Me.JobCategoryIdDataGridViewTextBoxColumn.DataPropertyName = "JobCategoryId"
        Me.JobCategoryIdDataGridViewTextBoxColumn.HeaderText = "JobCategoryId"
        Me.JobCategoryIdDataGridViewTextBoxColumn.Name = "JobCategoryIdDataGridViewTextBoxColumn"
        Me.JobCategoryIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JobCategoryDataGridViewTextBoxColumn
        '
        Me.JobCategoryDataGridViewTextBoxColumn.DataPropertyName = "JobCategory"
        Me.JobCategoryDataGridViewTextBoxColumn.HeaderText = "JobCategory"
        Me.JobCategoryDataGridViewTextBoxColumn.Name = "JobCategoryDataGridViewTextBoxColumn"
        Me.JobCategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShiftNameDataGridViewTextBoxColumn
        '
        Me.ShiftNameDataGridViewTextBoxColumn.DataPropertyName = "ShiftName"
        Me.ShiftNameDataGridViewTextBoxColumn.HeaderText = "ShiftName"
        Me.ShiftNameDataGridViewTextBoxColumn.Name = "ShiftNameDataGridViewTextBoxColumn"
        Me.ShiftNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WeekEndingDateDataGridViewTextBoxColumn
        '
        Me.WeekEndingDateDataGridViewTextBoxColumn.DataPropertyName = "WeekEndingDate"
        Me.WeekEndingDateDataGridViewTextBoxColumn.HeaderText = "WeekEndingDate"
        Me.WeekEndingDateDataGridViewTextBoxColumn.Name = "WeekEndingDateDataGridViewTextBoxColumn"
        Me.WeekEndingDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WeekEndingDateIfLateDataGridViewTextBoxColumn
        '
        Me.WeekEndingDateIfLateDataGridViewTextBoxColumn.DataPropertyName = "WeekEndingDateIfLate"
        Me.WeekEndingDateIfLateDataGridViewTextBoxColumn.HeaderText = "WeekEndingDateIfLate"
        Me.WeekEndingDateIfLateDataGridViewTextBoxColumn.Name = "WeekEndingDateIfLateDataGridViewTextBoxColumn"
        Me.WeekEndingDateIfLateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FridayDataGridViewCheckBoxColumn
        '
        Me.FridayDataGridViewCheckBoxColumn.DataPropertyName = "Friday"
        Me.FridayDataGridViewCheckBoxColumn.HeaderText = "Friday"
        Me.FridayDataGridViewCheckBoxColumn.Name = "FridayDataGridViewCheckBoxColumn"
        Me.FridayDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'SaturdayDataGridViewCheckBoxColumn
        '
        Me.SaturdayDataGridViewCheckBoxColumn.DataPropertyName = "Saturday"
        Me.SaturdayDataGridViewCheckBoxColumn.HeaderText = "Saturday"
        Me.SaturdayDataGridViewCheckBoxColumn.Name = "SaturdayDataGridViewCheckBoxColumn"
        Me.SaturdayDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'SundayDataGridViewCheckBoxColumn
        '
        Me.SundayDataGridViewCheckBoxColumn.DataPropertyName = "Sunday"
        Me.SundayDataGridViewCheckBoxColumn.HeaderText = "Sunday"
        Me.SundayDataGridViewCheckBoxColumn.Name = "SundayDataGridViewCheckBoxColumn"
        Me.SundayDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'MondayDataGridViewCheckBoxColumn
        '
        Me.MondayDataGridViewCheckBoxColumn.DataPropertyName = "Monday"
        Me.MondayDataGridViewCheckBoxColumn.HeaderText = "Monday"
        Me.MondayDataGridViewCheckBoxColumn.Name = "MondayDataGridViewCheckBoxColumn"
        Me.MondayDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'TuesdayDataGridViewCheckBoxColumn
        '
        Me.TuesdayDataGridViewCheckBoxColumn.DataPropertyName = "Tuesday"
        Me.TuesdayDataGridViewCheckBoxColumn.HeaderText = "Tuesday"
        Me.TuesdayDataGridViewCheckBoxColumn.Name = "TuesdayDataGridViewCheckBoxColumn"
        Me.TuesdayDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'WednesdayDataGridViewCheckBoxColumn
        '
        Me.WednesdayDataGridViewCheckBoxColumn.DataPropertyName = "Wednesday"
        Me.WednesdayDataGridViewCheckBoxColumn.HeaderText = "Wednesday"
        Me.WednesdayDataGridViewCheckBoxColumn.Name = "WednesdayDataGridViewCheckBoxColumn"
        Me.WednesdayDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ThursdayDataGridViewCheckBoxColumn
        '
        Me.ThursdayDataGridViewCheckBoxColumn.DataPropertyName = "Thursday"
        Me.ThursdayDataGridViewCheckBoxColumn.HeaderText = "Thursday"
        Me.ThursdayDataGridViewCheckBoxColumn.Name = "ThursdayDataGridViewCheckBoxColumn"
        Me.ThursdayDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Friday2DataGridViewCheckBoxColumn
        '
        Me.Friday2DataGridViewCheckBoxColumn.DataPropertyName = "Friday2"
        Me.Friday2DataGridViewCheckBoxColumn.HeaderText = "Friday2"
        Me.Friday2DataGridViewCheckBoxColumn.Name = "Friday2DataGridViewCheckBoxColumn"
        Me.Friday2DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Saturday2DataGridViewCheckBoxColumn
        '
        Me.Saturday2DataGridViewCheckBoxColumn.DataPropertyName = "Saturday2"
        Me.Saturday2DataGridViewCheckBoxColumn.HeaderText = "Saturday2"
        Me.Saturday2DataGridViewCheckBoxColumn.Name = "Saturday2DataGridViewCheckBoxColumn"
        Me.Saturday2DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Sunday2DataGridViewCheckBoxColumn
        '
        Me.Sunday2DataGridViewCheckBoxColumn.DataPropertyName = "Sunday2"
        Me.Sunday2DataGridViewCheckBoxColumn.HeaderText = "Sunday2"
        Me.Sunday2DataGridViewCheckBoxColumn.Name = "Sunday2DataGridViewCheckBoxColumn"
        Me.Sunday2DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'HoursDataGridViewTextBoxColumn
        '
        Me.HoursDataGridViewTextBoxColumn.DataPropertyName = "Hours"
        Me.HoursDataGridViewTextBoxColumn.HeaderText = "Hours"
        Me.HoursDataGridViewTextBoxColumn.Name = "HoursDataGridViewTextBoxColumn"
        Me.HoursDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PayDataGridViewTextBoxColumn
        '
        Me.PayDataGridViewTextBoxColumn.DataPropertyName = "Pay"
        Me.PayDataGridViewTextBoxColumn.HeaderText = "Pay"
        Me.PayDataGridViewTextBoxColumn.Name = "PayDataGridViewTextBoxColumn"
        Me.PayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HolidayPayDataGridViewTextBoxColumn
        '
        Me.HolidayPayDataGridViewTextBoxColumn.DataPropertyName = "HolidayPay"
        Me.HolidayPayDataGridViewTextBoxColumn.HeaderText = "HolidayPay"
        Me.HolidayPayDataGridViewTextBoxColumn.Name = "HolidayPayDataGridViewTextBoxColumn"
        Me.HolidayPayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChargeDataGridViewTextBoxColumn
        '
        Me.ChargeDataGridViewTextBoxColumn.DataPropertyName = "Charge"
        Me.ChargeDataGridViewTextBoxColumn.HeaderText = "Charge"
        Me.ChargeDataGridViewTextBoxColumn.Name = "ChargeDataGridViewTextBoxColumn"
        Me.ChargeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalHoursDataGridViewTextBoxColumn
        '
        Me.TotalHoursDataGridViewTextBoxColumn.DataPropertyName = "TotalHours"
        Me.TotalHoursDataGridViewTextBoxColumn.HeaderText = "TotalHours"
        Me.TotalHoursDataGridViewTextBoxColumn.Name = "TotalHoursDataGridViewTextBoxColumn"
        Me.TotalHoursDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalPayDataGridViewTextBoxColumn
        '
        Me.TotalPayDataGridViewTextBoxColumn.DataPropertyName = "TotalPay"
        Me.TotalPayDataGridViewTextBoxColumn.HeaderText = "TotalPay"
        Me.TotalPayDataGridViewTextBoxColumn.Name = "TotalPayDataGridViewTextBoxColumn"
        Me.TotalPayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalChargeDataGridViewTextBoxColumn
        '
        Me.TotalChargeDataGridViewTextBoxColumn.DataPropertyName = "TotalCharge"
        Me.TotalChargeDataGridViewTextBoxColumn.HeaderText = "TotalCharge"
        Me.TotalChargeDataGridViewTextBoxColumn.Name = "TotalChargeDataGridViewTextBoxColumn"
        Me.TotalChargeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalHolidayPayDataGridViewTextBoxColumn
        '
        Me.TotalHolidayPayDataGridViewTextBoxColumn.DataPropertyName = "TotalHolidayPay"
        Me.TotalHolidayPayDataGridViewTextBoxColumn.HeaderText = "TotalHolidayPay"
        Me.TotalHolidayPayDataGridViewTextBoxColumn.Name = "TotalHolidayPayDataGridViewTextBoxColumn"
        Me.TotalHolidayPayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalNiDataGridViewTextBoxColumn
        '
        Me.TotalNiDataGridViewTextBoxColumn.DataPropertyName = "TotalNi"
        Me.TotalNiDataGridViewTextBoxColumn.HeaderText = "TotalNi"
        Me.TotalNiDataGridViewTextBoxColumn.Name = "TotalNiDataGridViewTextBoxColumn"
        Me.TotalNiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalCostDataGridViewTextBoxColumn
        '
        Me.TotalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost"
        Me.TotalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost"
        Me.TotalCostDataGridViewTextBoxColumn.Name = "TotalCostDataGridViewTextBoxColumn"
        Me.TotalCostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstMarginDataGridViewTextBoxColumn
        '
        Me.EstMarginDataGridViewTextBoxColumn.DataPropertyName = "EstMargin"
        Me.EstMarginDataGridViewTextBoxColumn.HeaderText = "EstMargin"
        Me.EstMarginDataGridViewTextBoxColumn.Name = "EstMarginDataGridViewTextBoxColumn"
        Me.EstMarginDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BranchIdDataGridViewTextBoxColumn
        '
        Me.BranchIdDataGridViewTextBoxColumn.DataPropertyName = "BranchId"
        Me.BranchIdDataGridViewTextBoxColumn.HeaderText = "BranchId"
        Me.BranchIdDataGridViewTextBoxColumn.Name = "BranchIdDataGridViewTextBoxColumn"
        Me.BranchIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PoNumberDataGridViewTextBoxColumn
        '
        Me.PoNumberDataGridViewTextBoxColumn.DataPropertyName = "PoNumber"
        Me.PoNumberDataGridViewTextBoxColumn.HeaderText = "PoNumber"
        Me.PoNumberDataGridViewTextBoxColumn.Name = "PoNumberDataGridViewTextBoxColumn"
        Me.PoNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrderNumberReqDataGridViewCheckBoxColumn
        '
        Me.OrderNumberReqDataGridViewCheckBoxColumn.DataPropertyName = "OrderNumberReq"
        Me.OrderNumberReqDataGridViewCheckBoxColumn.HeaderText = "OrderNumberReq"
        Me.OrderNumberReqDataGridViewCheckBoxColumn.Name = "OrderNumberReqDataGridViewCheckBoxColumn"
        Me.OrderNumberReqDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.Sites
        '
        'PlanTypesTableAdapter1
        '
        Me.PlanTypesTableAdapter1.ClearBeforeFill = True
        '
        'PlanTableAdapter1
        '
        Me.PlanTableAdapter1.ClearBeforeFill = True
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'Plan1TableAdapter
        '
        Me.Plan1TableAdapter.ClearBeforeFill = True
        '
        'WeeknumbersTableAdapter
        '
        Me.WeeknumbersTableAdapter.ClearBeforeFill = True
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.JobCategoryIdComboBox)
        Me.LayoutControl1.Controls.Add(Me.BreakDeductedCB)
        Me.LayoutControl1.Controls.Add(Me.EntitlementTB)
        Me.LayoutControl1.Controls.Add(Me.EmployeeIdComboBox)
        Me.LayoutControl1.Controls.Add(Me.GridControl2)
        Me.LayoutControl1.Controls.Add(Me.Ratecombo)
        Me.LayoutControl1.Controls.Add(Me.CompanyLookUpEdit1)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton4)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.WeekLabel)
        Me.LayoutControl1.Controls.Add(Me.tbEndTime)
        Me.LayoutControl1.Controls.Add(Me.TextBox19)
        Me.LayoutControl1.Controls.Add(Me.TextBox18)
        Me.LayoutControl1.Controls.Add(Me.tbStartTime)
        Me.LayoutControl1.Controls.Add(Me.TextBox17)
        Me.LayoutControl1.Controls.Add(Me.TextBox16)
        Me.LayoutControl1.Controls.Add(Me.TextBox14)
        Me.LayoutControl1.Controls.Add(Me.TextBox13)
        Me.LayoutControl1.Controls.Add(Me.TextBox15)
        Me.LayoutControl1.Controls.Add(Me.ExpensesPreNotesTextBox)
        Me.LayoutControl1.Controls.Add(Me.ExpensesPrePayTextBox)
        Me.LayoutControl1.Controls.Add(Me.ExpensesPreChargeTextBox)
        Me.LayoutControl1.Controls.Add(Me.NightsOutCharge)
        Me.LayoutControl1.Controls.Add(Me.RulesOrDetailsRichTextBox)
        Me.LayoutControl1.Controls.Add(Me.NightsPay)
        Me.LayoutControl1.Controls.Add(Me.TextBox11)
        Me.LayoutControl1.Controls.Add(Me.BankCharge)
        Me.LayoutControl1.Controls.Add(Me.BankPay)
        Me.LayoutControl1.Controls.Add(Me.BankHours)
        Me.LayoutControl1.Controls.Add(Me.SundayCharge)
        Me.LayoutControl1.Controls.Add(Me.SundayPay)
        Me.LayoutControl1.Controls.Add(Me.SundayHours)
        Me.LayoutControl1.Controls.Add(Me.SatCharge)
        Me.LayoutControl1.Controls.Add(Me.SatPay)
        Me.LayoutControl1.Controls.Add(Me.SatHours)
        Me.LayoutControl1.Controls.Add(Me.OT3ChargeTextBox)
        Me.LayoutControl1.Controls.Add(Me.OT3HoursTextBox)
        Me.LayoutControl1.Controls.Add(Me.OT3PayTextBox)
        Me.LayoutControl1.Controls.Add(Me.OT2ChargeTextBox)
        Me.LayoutControl1.Controls.Add(Me.OT2HoursTextBox)
        Me.LayoutControl1.Controls.Add(Me.OT2PayTextBox)
        Me.LayoutControl1.Controls.Add(Me.OT1ChargeTextBox)
        Me.LayoutControl1.Controls.Add(Me.MinCharge)
        Me.LayoutControl1.Controls.Add(Me.OT1PayTextBox)
        Me.LayoutControl1.Controls.Add(Me.OT1HoursTextBox)
        Me.LayoutControl1.Controls.Add(Me.SWHTextBox)
        Me.LayoutControl1.Controls.Add(Me.PlanBindingNavigator)
        Me.LayoutControl1.Controls.Add(WeekLabel2)
        Me.LayoutControl1.Controls.Add(Me.PlanViewDataGridView)
        Me.LayoutControl1.Controls.Add(Me.DHHTextBox)
        Me.LayoutControl1.Controls.Add(Me.ChargeTextBox)
        Me.LayoutControl1.Controls.Add(Me.HolidayPayTextBox)
        Me.LayoutControl1.Controls.Add(Me.ComboBox1)
        Me.LayoutControl1.Controls.Add(Me.PayTextBox)
        Me.LayoutControl1.Controls.Add(Me.HoursTextBox)
        Me.LayoutControl1.Controls.Add(Me.TextBox22)
        Me.LayoutControl1.Controls.Add(Me.PlanIDTextBox)
        Me.LayoutControl1.Controls.Add(Me.BranchSelect)
        Me.LayoutControl1.Controls.Add(Me.DateAddedDateTimePicker)
        Me.LayoutControl1.Controls.Add(Me.BranchIdComboBox)
        Me.LayoutControl1.Controls.Add(Me.TextBox21)
        Me.LayoutControl1.Controls.Add(Me.WeekSelect)
        Me.LayoutControl1.Controls.Add(Me.TextBox20)
        Me.LayoutControl1.Controls.Add(Me.PlanSelect)
        Me.LayoutControl1.Controls.Add(Me.PlanTypeIdComboBox)
        Me.LayoutControl1.Controls.Add(Me.LastModifiedUserTextBox)
        Me.LayoutControl1.Controls.Add(Me.WeekEndingDateTextBox)
        Me.LayoutControl1.Controls.Add(Me.POAElseWhereTextBox)
        Me.LayoutControl1.Controls.Add(Me.WeekEndingDateIfLateTextBox)
        Me.LayoutControl1.Controls.Add(Me.FridayCheckBox)
        Me.LayoutControl1.Controls.Add(Me.HoursWorkedElseWhereTextBox)
        Me.LayoutControl1.Controls.Add(Me.SaturdayCheckBox)
        Me.LayoutControl1.Controls.Add(Me.SundayCheckBox)
        Me.LayoutControl1.Controls.Add(Me.POATextBox)
        Me.LayoutControl1.Controls.Add(Me.MondayCheckBox)
        Me.LayoutControl1.Controls.Add(Me.TuesdayCheckBox)
        Me.LayoutControl1.Controls.Add(Me.PoNumberTextBox)
        Me.LayoutControl1.Controls.Add(Me.WednesdayCheckBox)
        Me.LayoutControl1.Controls.Add(Me.ThursdayCheckBox)
        Me.LayoutControl1.Controls.Add(Me.Friday2CheckBox)
        Me.LayoutControl1.Controls.Add(Me.Saturday2CheckBox)
        Me.LayoutControl1.Controls.Add(Me.Sunday2CheckBox)
        Me.LayoutControl1.Controls.Add(Me.WeekendingdateiflatereasonTextEdit)
        Me.LayoutControl1.Controls.Add(Me.ComboBoxEdit1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem38, Me.LayoutControlItem29})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(331, 126, 539, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1416, 913)
        Me.LayoutControl1.TabIndex = 160
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'JobCategoryIdComboBox
        '
        Me.JobCategoryIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PlanBindingSource, "JobCategoryId", True))
        Me.JobCategoryIdComboBox.EditValue = ""
        Me.JobCategoryIdComboBox.Location = New System.Drawing.Point(1020, 249)
        Me.JobCategoryIdComboBox.Name = "JobCategoryIdComboBox"
        Me.JobCategoryIdComboBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JobCategoryIdComboBox.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("JobCategory", "Job Category", 84, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShiftName", "Shift Name", 73, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("U25Rate", "U25Rate", 58, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.JobCategoryIdComboBox.Properties.DataSource = Me.JobCategoryBindingSource
        Me.JobCategoryIdComboBox.Properties.DisplayMember = "Job"
        Me.JobCategoryIdComboBox.Properties.NullText = ""
        Me.JobCategoryIdComboBox.Properties.ValueMember = "JobCatId"
        Me.JobCategoryIdComboBox.Size = New System.Drawing.Size(195, 22)
        Me.JobCategoryIdComboBox.StyleController = Me.LayoutControl1
        Me.JobCategoryIdComboBox.TabIndex = 187
        '
        'BreakDeductedCB
        '
        Me.BreakDeductedCB.Location = New System.Drawing.Point(764, 392)
        Me.BreakDeductedCB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BreakDeductedCB.Name = "BreakDeductedCB"
        Me.BreakDeductedCB.Properties.Caption = ""
        Me.BreakDeductedCB.Size = New System.Drawing.Size(57, 19)
        Me.BreakDeductedCB.StyleController = Me.LayoutControl1
        Me.BreakDeductedCB.TabIndex = 185
        '
        'EntitlementTB
        '
        Me.EntitlementTB.Location = New System.Drawing.Point(827, 392)
        Me.EntitlementTB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EntitlementTB.Name = "EntitlementTB"
        Me.EntitlementTB.Size = New System.Drawing.Size(55, 25)
        Me.EntitlementTB.TabIndex = 184
        '
        'EmployeeIdComboBox
        '
        Me.EmployeeIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PlanBindingSource, "EmployeeId", True))
        Me.EmployeeIdComboBox.Location = New System.Drawing.Point(818, 249)
        Me.EmployeeIdComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmployeeIdComboBox.Name = "EmployeeIdComboBox"
        Me.EmployeeIdComboBox.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.EmployeeIdComboBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmployeeIdComboBox.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeID", "Employee ID", 83, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeCode", "Employee Code", 84, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.EmployeeIdComboBox.Properties.DataSource = Me.EmployeesBindingSource
        Me.EmployeeIdComboBox.Properties.DisplayMember = "EmployeeCode"
        Me.EmployeeIdComboBox.Properties.NullText = ""
        Me.EmployeeIdComboBox.Properties.ValueMember = "EmployeeID"
        Me.EmployeeIdComboBox.Size = New System.Drawing.Size(196, 22)
        Me.EmployeeIdComboBox.StyleController = Me.LayoutControl1
        Me.EmployeeIdComboBox.TabIndex = 183
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.PlansAuditBindingSource
        Me.GridControl2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GridControl2.Location = New System.Drawing.Point(31, 171)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1396, 252)
        Me.GridControl2.TabIndex = 182
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'PlansAuditBindingSource
        '
        Me.PlansAuditBindingSource.DataMember = "PlansAudit"
        Me.PlansAuditBindingSource.DataSource = Me.Sites
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBranchName, Me.colPlanName1, Me.colClientCode, Me.colCompanyName1, Me.colForename1, Me.colSurname1, Me.colEmployeeCode1, Me.colScheme1, Me.colJobCategory1, Me.colShiftName1, Me.colWeekEndingDate1, Me.colWeekEndingDateIfLate1, Me.colFriday1, Me.colSaturday1, Me.colSunday1, Me.colMonday1, Me.colTuesday1, Me.colWednesday1, Me.colThursday1, Me.colFriday21, Me.colSaturday21, Me.colSunday21, Me.colLastModifiedUser, Me.colLastModifiedDate, Me.colLastModifiedDateTime})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        '
        'colBranchName
        '
        Me.colBranchName.FieldName = "BranchName"
        Me.colBranchName.Name = "colBranchName"
        Me.colBranchName.Visible = True
        Me.colBranchName.VisibleIndex = 0
        '
        'colPlanName1
        '
        Me.colPlanName1.FieldName = "PlanName"
        Me.colPlanName1.Name = "colPlanName1"
        Me.colPlanName1.Visible = True
        Me.colPlanName1.VisibleIndex = 1
        '
        'colClientCode
        '
        Me.colClientCode.FieldName = "ClientCode"
        Me.colClientCode.Name = "colClientCode"
        Me.colClientCode.Visible = True
        Me.colClientCode.VisibleIndex = 2
        '
        'colCompanyName1
        '
        Me.colCompanyName1.FieldName = "CompanyName"
        Me.colCompanyName1.Name = "colCompanyName1"
        Me.colCompanyName1.Visible = True
        Me.colCompanyName1.VisibleIndex = 3
        '
        'colForename1
        '
        Me.colForename1.FieldName = "Forename"
        Me.colForename1.Name = "colForename1"
        Me.colForename1.Visible = True
        Me.colForename1.VisibleIndex = 4
        '
        'colSurname1
        '
        Me.colSurname1.FieldName = "Surname"
        Me.colSurname1.Name = "colSurname1"
        Me.colSurname1.Visible = True
        Me.colSurname1.VisibleIndex = 5
        '
        'colEmployeeCode1
        '
        Me.colEmployeeCode1.FieldName = "EmployeeCode"
        Me.colEmployeeCode1.Name = "colEmployeeCode1"
        Me.colEmployeeCode1.Visible = True
        Me.colEmployeeCode1.VisibleIndex = 6
        '
        'colScheme1
        '
        Me.colScheme1.FieldName = "Scheme"
        Me.colScheme1.Name = "colScheme1"
        Me.colScheme1.Visible = True
        Me.colScheme1.VisibleIndex = 7
        '
        'colJobCategory1
        '
        Me.colJobCategory1.FieldName = "JobCategory"
        Me.colJobCategory1.Name = "colJobCategory1"
        Me.colJobCategory1.Visible = True
        Me.colJobCategory1.VisibleIndex = 8
        '
        'colShiftName1
        '
        Me.colShiftName1.FieldName = "ShiftName"
        Me.colShiftName1.Name = "colShiftName1"
        Me.colShiftName1.Visible = True
        Me.colShiftName1.VisibleIndex = 9
        '
        'colWeekEndingDate1
        '
        Me.colWeekEndingDate1.FieldName = "WeekEndingDate"
        Me.colWeekEndingDate1.Name = "colWeekEndingDate1"
        Me.colWeekEndingDate1.Visible = True
        Me.colWeekEndingDate1.VisibleIndex = 10
        '
        'colWeekEndingDateIfLate1
        '
        Me.colWeekEndingDateIfLate1.FieldName = "WeekEndingDateIfLate"
        Me.colWeekEndingDateIfLate1.Name = "colWeekEndingDateIfLate1"
        Me.colWeekEndingDateIfLate1.Visible = True
        Me.colWeekEndingDateIfLate1.VisibleIndex = 11
        '
        'colFriday1
        '
        Me.colFriday1.FieldName = "Friday"
        Me.colFriday1.Name = "colFriday1"
        Me.colFriday1.Visible = True
        Me.colFriday1.VisibleIndex = 12
        '
        'colSaturday1
        '
        Me.colSaturday1.FieldName = "Saturday"
        Me.colSaturday1.Name = "colSaturday1"
        Me.colSaturday1.Visible = True
        Me.colSaturday1.VisibleIndex = 13
        '
        'colSunday1
        '
        Me.colSunday1.FieldName = "Sunday"
        Me.colSunday1.Name = "colSunday1"
        Me.colSunday1.Visible = True
        Me.colSunday1.VisibleIndex = 14
        '
        'colMonday1
        '
        Me.colMonday1.FieldName = "Monday"
        Me.colMonday1.Name = "colMonday1"
        Me.colMonday1.Visible = True
        Me.colMonday1.VisibleIndex = 15
        '
        'colTuesday1
        '
        Me.colTuesday1.FieldName = "Tuesday"
        Me.colTuesday1.Name = "colTuesday1"
        Me.colTuesday1.Visible = True
        Me.colTuesday1.VisibleIndex = 16
        '
        'colWednesday1
        '
        Me.colWednesday1.FieldName = "Wednesday"
        Me.colWednesday1.Name = "colWednesday1"
        Me.colWednesday1.Visible = True
        Me.colWednesday1.VisibleIndex = 17
        '
        'colThursday1
        '
        Me.colThursday1.FieldName = "Thursday"
        Me.colThursday1.Name = "colThursday1"
        Me.colThursday1.Visible = True
        Me.colThursday1.VisibleIndex = 18
        '
        'colFriday21
        '
        Me.colFriday21.FieldName = "Friday2"
        Me.colFriday21.Name = "colFriday21"
        Me.colFriday21.Visible = True
        Me.colFriday21.VisibleIndex = 19
        '
        'colSaturday21
        '
        Me.colSaturday21.FieldName = "Saturday2"
        Me.colSaturday21.Name = "colSaturday21"
        Me.colSaturday21.Visible = True
        Me.colSaturday21.VisibleIndex = 20
        '
        'colSunday21
        '
        Me.colSunday21.FieldName = "Sunday2"
        Me.colSunday21.Name = "colSunday21"
        Me.colSunday21.Visible = True
        Me.colSunday21.VisibleIndex = 21
        '
        'colLastModifiedUser
        '
        Me.colLastModifiedUser.FieldName = "LastModifiedUser"
        Me.colLastModifiedUser.Name = "colLastModifiedUser"
        Me.colLastModifiedUser.Visible = True
        Me.colLastModifiedUser.VisibleIndex = 22
        '
        'colLastModifiedDate
        '
        Me.colLastModifiedDate.FieldName = "LastModifiedDate"
        Me.colLastModifiedDate.Name = "colLastModifiedDate"
        Me.colLastModifiedDate.Visible = True
        Me.colLastModifiedDate.VisibleIndex = 23
        '
        'colLastModifiedDateTime
        '
        Me.colLastModifiedDateTime.FieldName = "LastModifiedDateTime"
        Me.colLastModifiedDateTime.Name = "colLastModifiedDateTime"
        Me.colLastModifiedDateTime.Visible = True
        Me.colLastModifiedDateTime.VisibleIndex = 24
        '
        'Ratecombo
        '
        Me.Ratecombo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "Rate", True))
        Me.Ratecombo.Location = New System.Drawing.Point(35, 218)
        Me.Ratecombo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ratecombo.Name = "Ratecombo"
        Me.Ratecombo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ratecombo.Properties.Items.AddRange(New Object() {"Rate 1", "Rate 2", "Rate 3", "Rate 4"})
        Me.Ratecombo.Size = New System.Drawing.Size(65, 22)
        Me.Ratecombo.StyleController = Me.LayoutControl1
        Me.Ratecombo.TabIndex = 180
        '
        'CompanyLookUpEdit1
        '
        Me.CompanyLookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PlanBindingSource, "CompanyId", True))
        Me.CompanyLookUpEdit1.Enabled = False
        Me.CompanyLookUpEdit1.Location = New System.Drawing.Point(616, 249)
        Me.CompanyLookUpEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CompanyLookUpEdit1.Name = "CompanyLookUpEdit1"
        Me.CompanyLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompanyLookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClientCode", "Client Code", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Company Name", 85, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("StartOfWeek", "Start Of Week", 79, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ConvertedBy", "Converted By", 76, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrderNumberReq", "Order Number Req", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Active", "Active", 40, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClientStatus", "Client Status", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CompanyLookUpEdit1.Properties.DataSource = Me.SitesBindingSource
        Me.CompanyLookUpEdit1.Properties.DisplayMember = "ClientCode"
        Me.CompanyLookUpEdit1.Properties.NullText = ""
        Me.CompanyLookUpEdit1.Properties.PopupFormMinSize = New System.Drawing.Size(700, 0)
        Me.CompanyLookUpEdit1.Properties.ValueMember = "CompanyID"
        Me.CompanyLookUpEdit1.Size = New System.Drawing.Size(196, 22)
        Me.CompanyLookUpEdit1.StyleController = Me.LayoutControl1
        Me.CompanyLookUpEdit1.TabIndex = 179
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.DataTable1BindingSource
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        GridLevelNode2.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.GridControl1.Location = New System.Drawing.Point(16, 454)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(1426, 422)
        Me.GridControl1.TabIndex = 178
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colPlanID, Me.colPlanName, Me.colPlanTypeId, Me.colCompanyId, Me.colCompanyName, Me.colStatus, Me.colForename, Me.colSurname, Me.colEmployeeId, Me.colEmployeeCode, Me.colScheme, Me.colJobCategoryId, Me.colJobCategory, Me.colShiftName, Me.colWeekEndingDate, Me.colWeekEndingDateIfLate, Me.colFriday, Me.colSaturday, Me.colSunday, Me.colMonday, Me.colTuesday, Me.colWednesday, Me.colThursday, Me.colFriday2, Me.colSaturday2, Me.colSunday2, Me.colHours, Me.colPay, Me.colHolidayPay, Me.colCharge, Me.colTotalHours, Me.colTotalPay, Me.colTotalCharge, Me.colTotalHolidayPay, Me.colTotalNi, Me.colTotalCost, Me.colEstMargin, Me.colOrderNumberReq, Me.colBranchId, Me.colSystemType, Me.colPoNumber})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Lock"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemButtonEdit1
        Me.GridColumn1.Image = Global.Lexrecmgr.My.Resources.Resources.padlock_closed
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.Appearance.Image = Global.Lexrecmgr.My.Resources.Resources.padlock_closed
        Me.RepositoryItemButtonEdit1.Appearance.Options.UseImage = True
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colPlanID
        '
        Me.colPlanID.FieldName = "PlanID"
        Me.colPlanID.Name = "colPlanID"
        Me.colPlanID.OptionsColumn.AllowEdit = False
        '
        'colPlanName
        '
        Me.colPlanName.FieldName = "PlanName"
        Me.colPlanName.Name = "colPlanName"
        Me.colPlanName.OptionsColumn.AllowEdit = False
        Me.colPlanName.Visible = True
        Me.colPlanName.VisibleIndex = 2
        '
        'colPlanTypeId
        '
        Me.colPlanTypeId.FieldName = "PlanTypeId"
        Me.colPlanTypeId.Name = "colPlanTypeId"
        Me.colPlanTypeId.OptionsColumn.AllowEdit = False
        '
        'colCompanyId
        '
        Me.colCompanyId.FieldName = "CompanyId"
        Me.colCompanyId.Name = "colCompanyId"
        Me.colCompanyId.OptionsColumn.AllowEdit = False
        '
        'colCompanyName
        '
        Me.colCompanyName.FieldName = "CompanyName"
        Me.colCompanyName.Name = "colCompanyName"
        Me.colCompanyName.OptionsColumn.AllowEdit = False
        Me.colCompanyName.Visible = True
        Me.colCompanyName.VisibleIndex = 3
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 4
        '
        'colForename
        '
        Me.colForename.FieldName = "Forename"
        Me.colForename.Name = "colForename"
        Me.colForename.OptionsColumn.AllowEdit = False
        Me.colForename.Visible = True
        Me.colForename.VisibleIndex = 5
        '
        'colSurname
        '
        Me.colSurname.FieldName = "Surname"
        Me.colSurname.Name = "colSurname"
        Me.colSurname.OptionsColumn.AllowEdit = False
        Me.colSurname.Visible = True
        Me.colSurname.VisibleIndex = 6
        '
        'colEmployeeId
        '
        Me.colEmployeeId.FieldName = "EmployeeId"
        Me.colEmployeeId.Name = "colEmployeeId"
        Me.colEmployeeId.OptionsColumn.AllowEdit = False
        Me.colEmployeeId.Visible = True
        Me.colEmployeeId.VisibleIndex = 37
        '
        'colEmployeeCode
        '
        Me.colEmployeeCode.FieldName = "EmployeeCode"
        Me.colEmployeeCode.Name = "colEmployeeCode"
        Me.colEmployeeCode.OptionsColumn.AllowEdit = False
        Me.colEmployeeCode.Visible = True
        Me.colEmployeeCode.VisibleIndex = 7
        '
        'colScheme
        '
        Me.colScheme.FieldName = "Scheme"
        Me.colScheme.Name = "colScheme"
        Me.colScheme.OptionsColumn.AllowEdit = False
        Me.colScheme.Visible = True
        Me.colScheme.VisibleIndex = 8
        '
        'colJobCategoryId
        '
        Me.colJobCategoryId.FieldName = "JobCategoryId"
        Me.colJobCategoryId.Name = "colJobCategoryId"
        Me.colJobCategoryId.OptionsColumn.AllowEdit = False
        '
        'colJobCategory
        '
        Me.colJobCategory.FieldName = "JobCategory"
        Me.colJobCategory.Name = "colJobCategory"
        Me.colJobCategory.OptionsColumn.AllowEdit = False
        Me.colJobCategory.Visible = True
        Me.colJobCategory.VisibleIndex = 9
        '
        'colShiftName
        '
        Me.colShiftName.FieldName = "ShiftName"
        Me.colShiftName.Name = "colShiftName"
        Me.colShiftName.OptionsColumn.AllowEdit = False
        Me.colShiftName.Visible = True
        Me.colShiftName.VisibleIndex = 10
        '
        'colWeekEndingDate
        '
        Me.colWeekEndingDate.FieldName = "WeekEndingDate"
        Me.colWeekEndingDate.Name = "colWeekEndingDate"
        Me.colWeekEndingDate.OptionsColumn.AllowEdit = False
        Me.colWeekEndingDate.Visible = True
        Me.colWeekEndingDate.VisibleIndex = 11
        '
        'colWeekEndingDateIfLate
        '
        Me.colWeekEndingDateIfLate.FieldName = "WeekEndingDateIfLate"
        Me.colWeekEndingDateIfLate.Name = "colWeekEndingDateIfLate"
        Me.colWeekEndingDateIfLate.OptionsColumn.AllowEdit = False
        Me.colWeekEndingDateIfLate.Visible = True
        Me.colWeekEndingDateIfLate.VisibleIndex = 12
        '
        'colFriday
        '
        Me.colFriday.FieldName = "Friday"
        Me.colFriday.Name = "colFriday"
        Me.colFriday.OptionsColumn.AllowEdit = False
        Me.colFriday.Visible = True
        Me.colFriday.VisibleIndex = 13
        '
        'colSaturday
        '
        Me.colSaturday.FieldName = "Saturday"
        Me.colSaturday.Name = "colSaturday"
        Me.colSaturday.OptionsColumn.AllowEdit = False
        Me.colSaturday.Visible = True
        Me.colSaturday.VisibleIndex = 14
        '
        'colSunday
        '
        Me.colSunday.FieldName = "Sunday"
        Me.colSunday.Name = "colSunday"
        Me.colSunday.OptionsColumn.AllowEdit = False
        Me.colSunday.Visible = True
        Me.colSunday.VisibleIndex = 15
        '
        'colMonday
        '
        Me.colMonday.FieldName = "Monday"
        Me.colMonday.Name = "colMonday"
        Me.colMonday.OptionsColumn.AllowEdit = False
        Me.colMonday.Visible = True
        Me.colMonday.VisibleIndex = 16
        '
        'colTuesday
        '
        Me.colTuesday.FieldName = "Tuesday"
        Me.colTuesday.Name = "colTuesday"
        Me.colTuesday.OptionsColumn.AllowEdit = False
        Me.colTuesday.Visible = True
        Me.colTuesday.VisibleIndex = 17
        '
        'colWednesday
        '
        Me.colWednesday.FieldName = "Wednesday"
        Me.colWednesday.Name = "colWednesday"
        Me.colWednesday.OptionsColumn.AllowEdit = False
        Me.colWednesday.Visible = True
        Me.colWednesday.VisibleIndex = 18
        '
        'colThursday
        '
        Me.colThursday.FieldName = "Thursday"
        Me.colThursday.Name = "colThursday"
        Me.colThursday.OptionsColumn.AllowEdit = False
        Me.colThursday.Visible = True
        Me.colThursday.VisibleIndex = 19
        '
        'colFriday2
        '
        Me.colFriday2.FieldName = "Friday2"
        Me.colFriday2.Name = "colFriday2"
        Me.colFriday2.OptionsColumn.AllowEdit = False
        Me.colFriday2.Visible = True
        Me.colFriday2.VisibleIndex = 20
        '
        'colSaturday2
        '
        Me.colSaturday2.FieldName = "Saturday2"
        Me.colSaturday2.Name = "colSaturday2"
        Me.colSaturday2.OptionsColumn.AllowEdit = False
        Me.colSaturday2.Visible = True
        Me.colSaturday2.VisibleIndex = 21
        '
        'colSunday2
        '
        Me.colSunday2.FieldName = "Sunday2"
        Me.colSunday2.Name = "colSunday2"
        Me.colSunday2.OptionsColumn.AllowEdit = False
        Me.colSunday2.Visible = True
        Me.colSunday2.VisibleIndex = 22
        '
        'colHours
        '
        Me.colHours.FieldName = "Hours"
        Me.colHours.Name = "colHours"
        Me.colHours.OptionsColumn.AllowEdit = False
        Me.colHours.Visible = True
        Me.colHours.VisibleIndex = 23
        '
        'colPay
        '
        Me.colPay.FieldName = "Pay"
        Me.colPay.Name = "colPay"
        Me.colPay.OptionsColumn.AllowEdit = False
        Me.colPay.Visible = True
        Me.colPay.VisibleIndex = 24
        '
        'colHolidayPay
        '
        Me.colHolidayPay.FieldName = "HolidayPay"
        Me.colHolidayPay.Name = "colHolidayPay"
        Me.colHolidayPay.OptionsColumn.AllowEdit = False
        Me.colHolidayPay.Visible = True
        Me.colHolidayPay.VisibleIndex = 25
        '
        'colCharge
        '
        Me.colCharge.FieldName = "Charge"
        Me.colCharge.Name = "colCharge"
        Me.colCharge.OptionsColumn.AllowEdit = False
        Me.colCharge.Visible = True
        Me.colCharge.VisibleIndex = 26
        '
        'colTotalHours
        '
        Me.colTotalHours.FieldName = "TotalHours"
        Me.colTotalHours.Name = "colTotalHours"
        Me.colTotalHours.OptionsColumn.AllowEdit = False
        Me.colTotalHours.Visible = True
        Me.colTotalHours.VisibleIndex = 27
        '
        'colTotalPay
        '
        Me.colTotalPay.FieldName = "TotalPay"
        Me.colTotalPay.Name = "colTotalPay"
        Me.colTotalPay.OptionsColumn.AllowEdit = False
        Me.colTotalPay.Visible = True
        Me.colTotalPay.VisibleIndex = 28
        '
        'colTotalCharge
        '
        Me.colTotalCharge.FieldName = "TotalCharge"
        Me.colTotalCharge.Name = "colTotalCharge"
        Me.colTotalCharge.OptionsColumn.AllowEdit = False
        Me.colTotalCharge.Visible = True
        Me.colTotalCharge.VisibleIndex = 29
        '
        'colTotalHolidayPay
        '
        Me.colTotalHolidayPay.FieldName = "TotalHolidayPay"
        Me.colTotalHolidayPay.Name = "colTotalHolidayPay"
        Me.colTotalHolidayPay.OptionsColumn.AllowEdit = False
        Me.colTotalHolidayPay.Visible = True
        Me.colTotalHolidayPay.VisibleIndex = 30
        '
        'colTotalNi
        '
        Me.colTotalNi.FieldName = "TotalNi"
        Me.colTotalNi.Name = "colTotalNi"
        Me.colTotalNi.OptionsColumn.AllowEdit = False
        Me.colTotalNi.Visible = True
        Me.colTotalNi.VisibleIndex = 31
        '
        'colTotalCost
        '
        Me.colTotalCost.FieldName = "TotalCost"
        Me.colTotalCost.Name = "colTotalCost"
        Me.colTotalCost.OptionsColumn.AllowEdit = False
        Me.colTotalCost.Visible = True
        Me.colTotalCost.VisibleIndex = 32
        '
        'colEstMargin
        '
        Me.colEstMargin.FieldName = "EstMargin"
        Me.colEstMargin.Name = "colEstMargin"
        Me.colEstMargin.OptionsColumn.AllowEdit = False
        Me.colEstMargin.Visible = True
        Me.colEstMargin.VisibleIndex = 33
        '
        'colOrderNumberReq
        '
        Me.colOrderNumberReq.FieldName = "OrderNumberReq"
        Me.colOrderNumberReq.Name = "colOrderNumberReq"
        Me.colOrderNumberReq.OptionsColumn.AllowEdit = False
        Me.colOrderNumberReq.Visible = True
        Me.colOrderNumberReq.VisibleIndex = 34
        '
        'colBranchId
        '
        Me.colBranchId.FieldName = "BranchId"
        Me.colBranchId.Name = "colBranchId"
        Me.colBranchId.OptionsColumn.AllowEdit = False
        Me.colBranchId.Visible = True
        Me.colBranchId.VisibleIndex = 35
        '
        'colSystemType
        '
        Me.colSystemType.FieldName = "SystemType"
        Me.colSystemType.Name = "colSystemType"
        Me.colSystemType.OptionsColumn.AllowEdit = False
        Me.colSystemType.Visible = True
        Me.colSystemType.VisibleIndex = 1
        '
        'colPoNumber
        '
        Me.colPoNumber.FieldName = "PoNumber"
        Me.colPoNumber.Name = "colPoNumber"
        Me.colPoNumber.OptionsColumn.AllowEdit = False
        Me.colPoNumber.Visible = True
        Me.colPoNumber.VisibleIndex = 36
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.SimpleButton4.Location = New System.Drawing.Point(824, 60)
        Me.SimpleButton4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(86, 45)
        Me.SimpleButton4.StyleController = Me.LayoutControl1
        Me.SimpleButton4.TabIndex = 177
        Me.SimpleButton4.Text = "Lock Plan"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.SimpleButton3.Location = New System.Drawing.Point(916, 60)
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(81, 45)
        Me.SimpleButton3.StyleController = Me.LayoutControl1
        Me.SimpleButton3.TabIndex = 176
        Me.SimpleButton3.Text = "Unlock Plan"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.SimpleButton2.Location = New System.Drawing.Point(1003, 60)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(89, 45)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 175
        Me.SimpleButton2.Text = "Archive Plan"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(1098, 60)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(94, 45)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 174
        Me.SimpleButton1.Text = "Create Follow Up"
        '
        'WeekLabel
        '
        Me.WeekLabel.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.WeekLabel.Location = New System.Drawing.Point(1342, 331)
        Me.WeekLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WeekLabel.Name = "WeekLabel"
        Me.WeekLabel.Size = New System.Drawing.Size(85, 36)
        Me.WeekLabel.StyleController = Me.LayoutControl1
        Me.WeekLabel.TabIndex = 173
        Me.WeekLabel.Text = "Week:"
        '
        'WeekendingdateiflatereasonTextEdit
        '
        Me.WeekendingdateiflatereasonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PlanBindingSource, "Weekendingdateiflatereason", True))
        Me.WeekendingdateiflatereasonTextEdit.EditValue = ""
        Me.WeekendingdateiflatereasonTextEdit.Location = New System.Drawing.Point(1221, 249)
        Me.WeekendingdateiflatereasonTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WeekendingdateiflatereasonTextEdit.Name = "WeekendingdateiflatereasonTextEdit"
        Me.WeekendingdateiflatereasonTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WeekendingdateiflatereasonTextEdit.Size = New System.Drawing.Size(196, 22)
        Me.WeekendingdateiflatereasonTextEdit.StyleController = Me.LayoutControl1
        Me.WeekendingdateiflatereasonTextEdit.TabIndex = 181
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PlanBindingSource, "OT3Reason", True))
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(962, 220)
        Me.ComboBoxEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(113, 22)
        Me.ComboBoxEdit1.StyleController = Me.LayoutControl1
        Me.ComboBoxEdit1.TabIndex = 186
        '
        'LayoutControlItem38
        '
        Me.LayoutControlItem38.Control = WeekLabel2
        Me.LayoutControlItem38.Location = New System.Drawing.Point(1057, 34)
        Me.LayoutControlItem38.Name = "LayoutControlItem38"
        Me.LayoutControlItem38.Size = New System.Drawing.Size(83, 42)
        Me.LayoutControlItem38.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem38.TextVisible = False
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.PlanViewDataGridView
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 385)
        Me.LayoutControlItem29.MinSize = New System.Drawing.Size(104, 24)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(1393, 124)
        Me.LayoutControlItem29.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem29.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem29.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1, Me.SplitterItem2, Me.LayoutControlItem39, Me.LayoutControlItem33, Me.LayoutControlItem32, Me.LayoutControlItem31, Me.LayoutControlItem30, Me.EmptySpaceItem7, Me.LayoutControlItem28, Me.LayoutControlItem37, Me.LayoutControlItem35, Me.LayoutControlItem36, Me.LayoutControlItem34, Me.EmptySpaceItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1458, 892)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 110)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup3
        Me.TabbedControlGroup1.SelectedTabPageIndex = 0
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(1432, 318)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlGroup6})
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem3, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.LayoutControlItem20, Me.LayoutControlItem25, Me.LayoutControlItem26, Me.LayoutControlItem27, Me.WeekLabel23, Me.EmptySpaceItem5, Me.LayoutControlItem84, Me.LayoutControlItem50, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem83, Me.LayoutControlItem4, Me.LayoutControlItem2, Me.LayoutControlItem87, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem10, Me.LayoutControlItem12, Me.LayoutControlItem15, Me.LayoutControlItem13, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem11, Me.EmptySpaceItem4, Me.LayoutControlItem14})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1402, 258)
        Me.LayoutControlGroup3.Text = "Details"
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(1392, 59)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(10, 51)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.DateAddedDateTimePicker
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(173, 50)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(177, 59)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Date Added:"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TextBox21
        Me.LayoutControlItem3.Location = New System.Drawing.Point(354, 0)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(173, 50)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(178, 59)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Start Of Week:"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(191, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(532, 0)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(106, 26)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(870, 59)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.PoNumberTextBox
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 110)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(197, 50)
        Me.LayoutControlItem20.Text = "Po Number:"
        Me.LayoutControlItem20.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.TextBox20
        Me.LayoutControlItem25.Location = New System.Drawing.Point(475, 160)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(369, 50)
        Me.LayoutControlItem25.Text = "Last Modified Date:"
        Me.LayoutControlItem25.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.TextBox22
        Me.LayoutControlItem26.Location = New System.Drawing.Point(844, 160)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(203, 50)
        Me.LayoutControlItem26.Text = "System Type:"
        Me.LayoutControlItem26.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.PlanIDTextBox
        Me.LayoutControlItem27.Location = New System.Drawing.Point(1047, 160)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(264, 50)
        Me.LayoutControlItem27.Text = "Plan ID:"
        Me.LayoutControlItem27.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(191, 16)
        '
        'WeekLabel23
        '
        Me.WeekLabel23.Control = Me.WeekLabel
        Me.WeekLabel23.Location = New System.Drawing.Point(1311, 160)
        Me.WeekLabel23.Name = "WeekLabel23"
        Me.WeekLabel23.Size = New System.Drawing.Size(91, 50)
        Me.WeekLabel23.Text = "Week:"
        Me.WeekLabel23.TextSize = New System.Drawing.Size(0, 0)
        Me.WeekLabel23.TextVisible = False
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 210)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(1402, 48)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem84
        '
        Me.LayoutControlItem84.Control = Me.WeekendingdateiflatereasonTextEdit
        Me.LayoutControlItem84.Location = New System.Drawing.Point(1190, 59)
        Me.LayoutControlItem84.Name = "LayoutControlItem84"
        Me.LayoutControlItem84.Size = New System.Drawing.Size(202, 51)
        Me.LayoutControlItem84.Text = "WeekEnding Date If Late Reason:"
        Me.LayoutControlItem84.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem84.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem50
        '
        Me.LayoutControlItem50.Control = Me.EmployeeIdComboBox
        Me.LayoutControlItem50.Location = New System.Drawing.Point(787, 59)
        Me.LayoutControlItem50.Name = "LayoutControlItem50"
        Me.LayoutControlItem50.Size = New System.Drawing.Size(202, 51)
        Me.LayoutControlItem50.Text = "Employee:"
        Me.LayoutControlItem50.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem50.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.WeekEndingDateTextBox
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 59)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(202, 51)
        Me.LayoutControlItem8.Text = "Week Endng Date:"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.WeekEndingDateIfLateTextBox
        Me.LayoutControlItem9.Location = New System.Drawing.Point(202, 59)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(177, 50)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(181, 51)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "Week Ending Date If Late:"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem83
        '
        Me.LayoutControlItem83.Control = Me.CompanyLookUpEdit1
        Me.LayoutControlItem83.Location = New System.Drawing.Point(585, 59)
        Me.LayoutControlItem83.Name = "LayoutControlItem83"
        Me.LayoutControlItem83.Size = New System.Drawing.Size(202, 51)
        Me.LayoutControlItem83.Text = "Company:"
        Me.LayoutControlItem83.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem83.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.PlanTypeIdComboBox
        Me.LayoutControlItem4.Location = New System.Drawing.Point(383, 59)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(202, 51)
        Me.LayoutControlItem4.Text = "Plan Type:"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.BranchIdComboBox
        Me.LayoutControlItem2.Location = New System.Drawing.Point(177, 0)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(173, 51)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(177, 59)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Branch:"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem87
        '
        Me.LayoutControlItem87.Control = Me.JobCategoryIdComboBox
        Me.LayoutControlItem87.Location = New System.Drawing.Point(989, 59)
        Me.LayoutControlItem87.Name = "LayoutControlItem87"
        Me.LayoutControlItem87.Size = New System.Drawing.Size(201, 51)
        Me.LayoutControlItem87.Text = "Job Category"
        Me.LayoutControlItem87.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem87.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.POATextBox
        Me.LayoutControlItem21.Location = New System.Drawing.Point(197, 110)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(197, 50)
        Me.LayoutControlItem21.Text = "POA:"
        Me.LayoutControlItem21.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.HoursWorkedElseWhereTextBox
        Me.LayoutControlItem22.Location = New System.Drawing.Point(394, 110)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(197, 50)
        Me.LayoutControlItem22.Text = "Hours Worked Else Where:"
        Me.LayoutControlItem22.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.POAElseWhereTextBox
        Me.LayoutControlItem23.Location = New System.Drawing.Point(591, 110)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(197, 50)
        Me.LayoutControlItem23.Text = "POAElse Where:"
        Me.LayoutControlItem23.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.LastModifiedUserTextBox
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 160)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(475, 50)
        Me.LayoutControlItem24.Text = "Last Modified User:"
        Me.LayoutControlItem24.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.ThursdayCheckBox
        Me.LayoutControlItem16.Location = New System.Drawing.Point(1156, 110)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(64, 31)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(64, 50)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.Friday2CheckBox
        Me.LayoutControlItem17.Location = New System.Drawing.Point(1220, 110)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(54, 31)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(54, 50)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.FridayCheckBox
        Me.LayoutControlItem10.Location = New System.Drawing.Point(788, 110)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(54, 31)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(54, 50)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.SundayCheckBox
        Me.LayoutControlItem12.Location = New System.Drawing.Point(906, 110)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(64, 31)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(64, 50)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.WednesdayCheckBox
        Me.LayoutControlItem15.Location = New System.Drawing.Point(1094, 110)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(62, 31)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(62, 50)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.MondayCheckBox
        Me.LayoutControlItem13.Location = New System.Drawing.Point(970, 110)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(64, 31)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(64, 50)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.Saturday2CheckBox
        Me.LayoutControlItem18.Location = New System.Drawing.Point(1274, 110)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(54, 31)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(54, 50)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.Sunday2CheckBox
        Me.LayoutControlItem19.Location = New System.Drawing.Point(1328, 110)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(64, 31)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(64, 50)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.SaturdayCheckBox
        Me.LayoutControlItem11.Location = New System.Drawing.Point(842, 110)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(64, 31)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(64, 50)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(1392, 110)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(10, 50)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.TuesdayCheckBox
        Me.LayoutControlItem14.Location = New System.Drawing.Point(1034, 110)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(60, 31)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(60, 50)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "Rates"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup5, Me.EmptySpaceItem8, Me.LayoutControlGroup7, Me.EmptySpaceItem10, Me.EmptySpaceItem6, Me.LayoutControlGroup8, Me.LayoutControlGroup9, Me.LayoutControlGroup12, Me.LayoutControlGroup13, Me.LayoutControlItem73, Me.LayoutControlGroup10, Me.LayoutControlGroup11, Me.LayoutControlGroup14, Me.LayoutControlGroup15, Me.LayoutControlGroup16, Me.LayoutControlGroup17, Me.LayoutControlGroup18, Me.LayoutControlGroup19})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(1402, 258)
        Me.LayoutControlGroup4.Text = "Rates"
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem47, Me.LayoutControlItem46, Me.LayoutControlItem45, Me.LayoutControlItem44, Me.LayoutControlItem43, Me.LayoutControlItem42, Me.LayoutControlItem41, Me.LayoutControlItem5})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(497, 86)
        Me.LayoutControlGroup5.Spacing = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.LayoutControlGroup5.Text = "Basic"
        '
        'LayoutControlItem47
        '
        Me.LayoutControlItem47.Control = Me.MinCharge
        Me.LayoutControlItem47.Location = New System.Drawing.Point(416, 0)
        Me.LayoutControlItem47.MinSize = New System.Drawing.Size(70, 40)
        Me.LayoutControlItem47.Name = "LayoutControlItem47"
        Me.LayoutControlItem47.Size = New System.Drawing.Size(73, 54)
        Me.LayoutControlItem47.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem47.Text = "Min Charge:"
        Me.LayoutControlItem47.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem47.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem46
        '
        Me.LayoutControlItem46.Control = Me.SWHTextBox
        Me.LayoutControlItem46.Location = New System.Drawing.Point(355, 0)
        Me.LayoutControlItem46.MinSize = New System.Drawing.Size(60, 40)
        Me.LayoutControlItem46.Name = "LayoutControlItem46"
        Me.LayoutControlItem46.Size = New System.Drawing.Size(61, 54)
        Me.LayoutControlItem46.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem46.Text = "SWH:"
        Me.LayoutControlItem46.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem46.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem45
        '
        Me.LayoutControlItem45.Control = Me.DHHTextBox
        Me.LayoutControlItem45.Location = New System.Drawing.Point(303, 0)
        Me.LayoutControlItem45.MinSize = New System.Drawing.Size(50, 40)
        Me.LayoutControlItem45.Name = "LayoutControlItem45"
        Me.LayoutControlItem45.Size = New System.Drawing.Size(52, 54)
        Me.LayoutControlItem45.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem45.Text = "DHH:"
        Me.LayoutControlItem45.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem45.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem44
        '
        Me.LayoutControlItem44.Control = Me.ChargeTextBox
        Me.LayoutControlItem44.Location = New System.Drawing.Point(242, 0)
        Me.LayoutControlItem44.MinSize = New System.Drawing.Size(60, 40)
        Me.LayoutControlItem44.Name = "LayoutControlItem44"
        Me.LayoutControlItem44.Size = New System.Drawing.Size(61, 54)
        Me.LayoutControlItem44.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem44.Text = "Charge:"
        Me.LayoutControlItem44.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem44.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem43
        '
        Me.LayoutControlItem43.Control = Me.HolidayPayTextBox
        Me.LayoutControlItem43.Location = New System.Drawing.Point(173, 0)
        Me.LayoutControlItem43.MinSize = New System.Drawing.Size(67, 40)
        Me.LayoutControlItem43.Name = "LayoutControlItem43"
        Me.LayoutControlItem43.Size = New System.Drawing.Size(69, 54)
        Me.LayoutControlItem43.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem43.Text = "Holiday Pay:"
        Me.LayoutControlItem43.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem43.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem42
        '
        Me.LayoutControlItem42.Control = Me.PayTextBox
        Me.LayoutControlItem42.Location = New System.Drawing.Point(122, 0)
        Me.LayoutControlItem42.MinSize = New System.Drawing.Size(50, 40)
        Me.LayoutControlItem42.Name = "LayoutControlItem42"
        Me.LayoutControlItem42.Size = New System.Drawing.Size(51, 54)
        Me.LayoutControlItem42.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem42.Text = "Pay:"
        Me.LayoutControlItem42.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem42.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem41
        '
        Me.LayoutControlItem41.Control = Me.HoursTextBox
        Me.LayoutControlItem41.Location = New System.Drawing.Point(71, 0)
        Me.LayoutControlItem41.MinSize = New System.Drawing.Size(50, 40)
        Me.LayoutControlItem41.Name = "LayoutControlItem41"
        Me.LayoutControlItem41.Size = New System.Drawing.Size(51, 54)
        Me.LayoutControlItem41.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem41.Text = "Hours:"
        Me.LayoutControlItem41.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem41.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Ratecombo
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(70, 40)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(71, 54)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Rate:"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(191, 16)
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(863, 172)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(23, 86)
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem51, Me.LayoutControlItem49, Me.LayoutControlItem48})
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(497, 0)
        Me.LayoutControlGroup7.Name = "LayoutControlGroup7"
        Me.LayoutControlGroup7.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(146, 86)
        Me.LayoutControlGroup7.Text = "OT1"
        '
        'LayoutControlItem51
        '
        Me.LayoutControlItem51.Control = Me.OT1ChargeTextBox
        Me.LayoutControlItem51.Location = New System.Drawing.Point(82, 0)
        Me.LayoutControlItem51.MinSize = New System.Drawing.Size(50, 40)
        Me.LayoutControlItem51.Name = "LayoutControlItem51"
        Me.LayoutControlItem51.Size = New System.Drawing.Size(52, 50)
        Me.LayoutControlItem51.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem51.Text = "Charge:"
        Me.LayoutControlItem51.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem51.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem49
        '
        Me.LayoutControlItem49.Control = Me.OT1PayTextBox
        Me.LayoutControlItem49.Location = New System.Drawing.Point(41, 0)
        Me.LayoutControlItem49.MinSize = New System.Drawing.Size(40, 40)
        Me.LayoutControlItem49.Name = "LayoutControlItem49"
        Me.LayoutControlItem49.Size = New System.Drawing.Size(41, 50)
        Me.LayoutControlItem49.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem49.Text = "Pay:"
        Me.LayoutControlItem49.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem49.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem48
        '
        Me.LayoutControlItem48.Control = Me.OT1HoursTextBox
        Me.LayoutControlItem48.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem48.MinSize = New System.Drawing.Size(40, 40)
        Me.LayoutControlItem48.Name = "LayoutControlItem48"
        Me.LayoutControlItem48.Size = New System.Drawing.Size(41, 50)
        Me.LayoutControlItem48.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem48.Text = "Hours:"
        Me.LayoutControlItem48.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem48.TextSize = New System.Drawing.Size(191, 16)
        '
        'EmptySpaceItem10
        '
        Me.EmptySpaceItem10.AllowHotTrack = False
        Me.EmptySpaceItem10.Location = New System.Drawing.Point(876, 86)
        Me.EmptySpaceItem10.Name = "EmptySpaceItem10"
        Me.EmptySpaceItem10.Size = New System.Drawing.Size(10, 86)
        Me.EmptySpaceItem10.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(1366, 0)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(36, 86)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup8
        '
        Me.LayoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem54, Me.LayoutControlItem53, Me.LayoutControlItem52})
        Me.LayoutControlGroup8.Location = New System.Drawing.Point(643, 0)
        Me.LayoutControlGroup8.Name = "LayoutControlGroup8"
        Me.LayoutControlGroup8.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup8.Size = New System.Drawing.Size(149, 86)
        Me.LayoutControlGroup8.Text = "OT2"
        '
        'LayoutControlItem54
        '
        Me.LayoutControlItem54.Control = Me.OT2ChargeTextBox
        Me.LayoutControlItem54.Location = New System.Drawing.Point(103, 0)
        Me.LayoutControlItem54.MinSize = New System.Drawing.Size(33, 50)
        Me.LayoutControlItem54.Name = "LayoutControlItem54"
        Me.LayoutControlItem54.Size = New System.Drawing.Size(34, 50)
        Me.LayoutControlItem54.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem54.Text = "Charge:"
        Me.LayoutControlItem54.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem54.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem53
        '
        Me.LayoutControlItem53.Control = Me.OT2PayTextBox
        Me.LayoutControlItem53.Location = New System.Drawing.Point(51, 0)
        Me.LayoutControlItem53.MinSize = New System.Drawing.Size(50, 40)
        Me.LayoutControlItem53.Name = "LayoutControlItem53"
        Me.LayoutControlItem53.Size = New System.Drawing.Size(52, 50)
        Me.LayoutControlItem53.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem53.Text = "Pay:"
        Me.LayoutControlItem53.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem53.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem52
        '
        Me.LayoutControlItem52.Control = Me.OT2HoursTextBox
        Me.LayoutControlItem52.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem52.MinSize = New System.Drawing.Size(50, 40)
        Me.LayoutControlItem52.Name = "LayoutControlItem52"
        Me.LayoutControlItem52.Size = New System.Drawing.Size(51, 50)
        Me.LayoutControlItem52.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem52.Text = "Hours:"
        Me.LayoutControlItem52.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem52.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlGroup9
        '
        Me.LayoutControlGroup9.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem57, Me.LayoutControlItem56, Me.LayoutControlItem55, Me.LayoutControlItem86})
        Me.LayoutControlGroup9.Location = New System.Drawing.Point(792, 0)
        Me.LayoutControlGroup9.Name = "LayoutControlGroup9"
        Me.LayoutControlGroup9.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup9.Size = New System.Drawing.Size(264, 86)
        Me.LayoutControlGroup9.Text = "OT3"
        '
        'LayoutControlItem57
        '
        Me.LayoutControlItem57.Control = Me.OT3ChargeTextBox
        Me.LayoutControlItem57.Location = New System.Drawing.Point(82, 0)
        Me.LayoutControlItem57.MinSize = New System.Drawing.Size(50, 40)
        Me.LayoutControlItem57.Name = "LayoutControlItem57"
        Me.LayoutControlItem57.Size = New System.Drawing.Size(51, 50)
        Me.LayoutControlItem57.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem57.Text = "Charge:"
        Me.LayoutControlItem57.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem57.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem56
        '
        Me.LayoutControlItem56.Control = Me.OT3PayTextBox
        Me.LayoutControlItem56.Location = New System.Drawing.Point(41, 0)
        Me.LayoutControlItem56.MinSize = New System.Drawing.Size(40, 40)
        Me.LayoutControlItem56.Name = "LayoutControlItem56"
        Me.LayoutControlItem56.Size = New System.Drawing.Size(41, 50)
        Me.LayoutControlItem56.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem56.Text = "Pay:"
        Me.LayoutControlItem56.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem56.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem55
        '
        Me.LayoutControlItem55.Control = Me.OT3HoursTextBox
        Me.LayoutControlItem55.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem55.MaxSize = New System.Drawing.Size(133, 40)
        Me.LayoutControlItem55.MinSize = New System.Drawing.Size(40, 40)
        Me.LayoutControlItem55.Name = "LayoutControlItem55"
        Me.LayoutControlItem55.Size = New System.Drawing.Size(41, 50)
        Me.LayoutControlItem55.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem55.Text = "Hours:"
        Me.LayoutControlItem55.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem55.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem86
        '
        Me.LayoutControlItem86.Control = Me.ComboBoxEdit1
        Me.LayoutControlItem86.Location = New System.Drawing.Point(133, 0)
        Me.LayoutControlItem86.MinSize = New System.Drawing.Size(50, 25)
        Me.LayoutControlItem86.Name = "LayoutControlItem86"
        Me.LayoutControlItem86.Size = New System.Drawing.Size(119, 50)
        Me.LayoutControlItem86.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem86.Text = "Reason"
        Me.LayoutControlItem86.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem86.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlGroup12
        '
        Me.LayoutControlGroup12.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem66, Me.LayoutControlItem65, Me.LayoutControlItem64})
        Me.LayoutControlGroup12.Location = New System.Drawing.Point(0, 86)
        Me.LayoutControlGroup12.Name = "LayoutControlGroup12"
        Me.LayoutControlGroup12.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup12.Size = New System.Drawing.Size(166, 86)
        Me.LayoutControlGroup12.Text = "Bank Holiday:"
        '
        'LayoutControlItem66
        '
        Me.LayoutControlItem66.Control = Me.BankCharge
        Me.LayoutControlItem66.Location = New System.Drawing.Point(103, 0)
        Me.LayoutControlItem66.MinSize = New System.Drawing.Size(50, 40)
        Me.LayoutControlItem66.Name = "LayoutControlItem66"
        Me.LayoutControlItem66.Size = New System.Drawing.Size(51, 50)
        Me.LayoutControlItem66.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem66.Text = "Charge:"
        Me.LayoutControlItem66.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem66.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem65
        '
        Me.LayoutControlItem65.Control = Me.BankPay
        Me.LayoutControlItem65.Location = New System.Drawing.Point(51, 0)
        Me.LayoutControlItem65.MinSize = New System.Drawing.Size(50, 40)
        Me.LayoutControlItem65.Name = "LayoutControlItem65"
        Me.LayoutControlItem65.Size = New System.Drawing.Size(52, 50)
        Me.LayoutControlItem65.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem65.Text = "Pay:"
        Me.LayoutControlItem65.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem65.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem64
        '
        Me.LayoutControlItem64.Control = Me.BankHours
        Me.LayoutControlItem64.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem64.MinSize = New System.Drawing.Size(50, 40)
        Me.LayoutControlItem64.Name = "LayoutControlItem64"
        Me.LayoutControlItem64.Size = New System.Drawing.Size(51, 50)
        Me.LayoutControlItem64.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem64.Text = "Hours:"
        Me.LayoutControlItem64.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem64.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlGroup13
        '
        Me.LayoutControlGroup13.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem69, Me.LayoutControlItem68, Me.LayoutControlItem67})
        Me.LayoutControlGroup13.Location = New System.Drawing.Point(166, 86)
        Me.LayoutControlGroup13.Name = "LayoutControlGroup13"
        Me.LayoutControlGroup13.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup13.Size = New System.Drawing.Size(166, 86)
        Me.LayoutControlGroup13.Text = "Nights Out:"
        '
        'LayoutControlItem69
        '
        Me.LayoutControlItem69.Control = Me.NightsOutCharge
        Me.LayoutControlItem69.Location = New System.Drawing.Point(103, 0)
        Me.LayoutControlItem69.MinSize = New System.Drawing.Size(50, 40)
        Me.LayoutControlItem69.Name = "LayoutControlItem69"
        Me.LayoutControlItem69.Size = New System.Drawing.Size(51, 50)
        Me.LayoutControlItem69.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem69.Text = "Charge:"
        Me.LayoutControlItem69.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem69.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem68
        '
        Me.LayoutControlItem68.Control = Me.NightsPay
        Me.LayoutControlItem68.Location = New System.Drawing.Point(51, 0)
        Me.LayoutControlItem68.MinSize = New System.Drawing.Size(50, 40)
        Me.LayoutControlItem68.Name = "LayoutControlItem68"
        Me.LayoutControlItem68.Size = New System.Drawing.Size(52, 50)
        Me.LayoutControlItem68.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem68.Text = "Pay:"
        Me.LayoutControlItem68.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem68.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem67
        '
        Me.LayoutControlItem67.Control = Me.TextBox11
        Me.LayoutControlItem67.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem67.MinSize = New System.Drawing.Size(50, 40)
        Me.LayoutControlItem67.Name = "LayoutControlItem67"
        Me.LayoutControlItem67.Size = New System.Drawing.Size(51, 50)
        Me.LayoutControlItem67.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem67.Text = "Hours:"
        Me.LayoutControlItem67.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem67.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem73
        '
        Me.LayoutControlItem73.Control = Me.RulesOrDetailsRichTextBox
        Me.LayoutControlItem73.Location = New System.Drawing.Point(886, 86)
        Me.LayoutControlItem73.MinSize = New System.Drawing.Size(133, 40)
        Me.LayoutControlItem73.Name = "LayoutControlItem73"
        Me.LayoutControlItem73.Size = New System.Drawing.Size(516, 172)
        Me.LayoutControlItem73.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem73.Text = "Rules Or Details"
        Me.LayoutControlItem73.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem73.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlGroup10
        '
        Me.LayoutControlGroup10.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem60, Me.LayoutControlItem59, Me.LayoutControlItem58})
        Me.LayoutControlGroup10.Location = New System.Drawing.Point(1056, 0)
        Me.LayoutControlGroup10.Name = "LayoutControlGroup10"
        Me.LayoutControlGroup10.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup10.Size = New System.Drawing.Size(145, 86)
        Me.LayoutControlGroup10.Text = "Saturday"
        '
        'LayoutControlItem60
        '
        Me.LayoutControlItem60.Control = Me.SatCharge
        Me.LayoutControlItem60.Location = New System.Drawing.Point(82, 0)
        Me.LayoutControlItem60.MinSize = New System.Drawing.Size(50, 40)
        Me.LayoutControlItem60.Name = "LayoutControlItem60"
        Me.LayoutControlItem60.Size = New System.Drawing.Size(51, 50)
        Me.LayoutControlItem60.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem60.Text = "Charge:"
        Me.LayoutControlItem60.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem60.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem59
        '
        Me.LayoutControlItem59.Control = Me.SatPay
        Me.LayoutControlItem59.Location = New System.Drawing.Point(41, 0)
        Me.LayoutControlItem59.MinSize = New System.Drawing.Size(40, 40)
        Me.LayoutControlItem59.Name = "LayoutControlItem59"
        Me.LayoutControlItem59.Size = New System.Drawing.Size(41, 50)
        Me.LayoutControlItem59.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem59.Text = "Pay:"
        Me.LayoutControlItem59.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem59.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem58
        '
        Me.LayoutControlItem58.Control = Me.SatHours
        Me.LayoutControlItem58.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem58.MinSize = New System.Drawing.Size(40, 40)
        Me.LayoutControlItem58.Name = "LayoutControlItem58"
        Me.LayoutControlItem58.Size = New System.Drawing.Size(41, 50)
        Me.LayoutControlItem58.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem58.Text = "Hours:"
        Me.LayoutControlItem58.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem58.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlGroup11
        '
        Me.LayoutControlGroup11.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem63, Me.LayoutControlItem62, Me.LayoutControlItem61})
        Me.LayoutControlGroup11.Location = New System.Drawing.Point(1201, 0)
        Me.LayoutControlGroup11.Name = "LayoutControlGroup11"
        Me.LayoutControlGroup11.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup11.Size = New System.Drawing.Size(165, 86)
        Me.LayoutControlGroup11.Text = "Sunday"
        '
        'LayoutControlItem63
        '
        Me.LayoutControlItem63.Control = Me.SundayCharge
        Me.LayoutControlItem63.Location = New System.Drawing.Point(91, 0)
        Me.LayoutControlItem63.MinSize = New System.Drawing.Size(60, 40)
        Me.LayoutControlItem63.Name = "LayoutControlItem63"
        Me.LayoutControlItem63.Size = New System.Drawing.Size(62, 50)
        Me.LayoutControlItem63.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem63.Text = "Charge:"
        Me.LayoutControlItem63.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem63.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem62
        '
        Me.LayoutControlItem62.Control = Me.SundayPay
        Me.LayoutControlItem62.Location = New System.Drawing.Point(41, 0)
        Me.LayoutControlItem62.MinSize = New System.Drawing.Size(50, 40)
        Me.LayoutControlItem62.Name = "LayoutControlItem62"
        Me.LayoutControlItem62.Size = New System.Drawing.Size(50, 50)
        Me.LayoutControlItem62.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem62.Text = "Pay:"
        Me.LayoutControlItem62.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem62.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem61
        '
        Me.LayoutControlItem61.Control = Me.SundayHours
        Me.LayoutControlItem61.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem61.MinSize = New System.Drawing.Size(40, 40)
        Me.LayoutControlItem61.Name = "LayoutControlItem61"
        Me.LayoutControlItem61.Size = New System.Drawing.Size(41, 50)
        Me.LayoutControlItem61.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem61.Text = "Hours"
        Me.LayoutControlItem61.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem61.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlGroup14
        '
        Me.LayoutControlGroup14.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem72, Me.LayoutControlItem71, Me.LayoutControlItem70})
        Me.LayoutControlGroup14.Location = New System.Drawing.Point(332, 86)
        Me.LayoutControlGroup14.Name = "LayoutControlGroup14"
        Me.LayoutControlGroup14.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup14.Size = New System.Drawing.Size(207, 86)
        Me.LayoutControlGroup14.Text = "Expenses Pre:"
        '
        'LayoutControlItem72
        '
        Me.LayoutControlItem72.Control = Me.ExpensesPreNotesTextBox
        Me.LayoutControlItem72.Location = New System.Drawing.Point(122, 0)
        Me.LayoutControlItem72.MinSize = New System.Drawing.Size(70, 40)
        Me.LayoutControlItem72.Name = "LayoutControlItem72"
        Me.LayoutControlItem72.Size = New System.Drawing.Size(73, 50)
        Me.LayoutControlItem72.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem72.Text = "Notes:"
        Me.LayoutControlItem72.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem72.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem71
        '
        Me.LayoutControlItem71.Control = Me.ExpensesPreChargeTextBox
        Me.LayoutControlItem71.Location = New System.Drawing.Point(61, 0)
        Me.LayoutControlItem71.MinSize = New System.Drawing.Size(60, 40)
        Me.LayoutControlItem71.Name = "LayoutControlItem71"
        Me.LayoutControlItem71.Size = New System.Drawing.Size(61, 50)
        Me.LayoutControlItem71.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem71.Text = "Charge:"
        Me.LayoutControlItem71.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem71.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem70
        '
        Me.LayoutControlItem70.Control = Me.ExpensesPrePayTextBox
        Me.LayoutControlItem70.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem70.MinSize = New System.Drawing.Size(60, 40)
        Me.LayoutControlItem70.Name = "LayoutControlItem70"
        Me.LayoutControlItem70.Size = New System.Drawing.Size(61, 50)
        Me.LayoutControlItem70.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem70.Text = "Pay"
        Me.LayoutControlItem70.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem70.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlGroup15
        '
        Me.LayoutControlGroup15.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem76, Me.LayoutControlItem75, Me.LayoutControlItem74})
        Me.LayoutControlGroup15.Location = New System.Drawing.Point(539, 86)
        Me.LayoutControlGroup15.Name = "LayoutControlGroup15"
        Me.LayoutControlGroup15.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup15.Size = New System.Drawing.Size(337, 86)
        Me.LayoutControlGroup15.Text = "Expenses Post"
        '
        'LayoutControlItem76
        '
        Me.LayoutControlItem76.Control = Me.TextBox14
        Me.LayoutControlItem76.Location = New System.Drawing.Point(122, 0)
        Me.LayoutControlItem76.Name = "LayoutControlItem76"
        Me.LayoutControlItem76.Size = New System.Drawing.Size(203, 50)
        Me.LayoutControlItem76.Text = "Notes:"
        Me.LayoutControlItem76.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem76.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem75
        '
        Me.LayoutControlItem75.Control = Me.TextBox15
        Me.LayoutControlItem75.Location = New System.Drawing.Point(61, 0)
        Me.LayoutControlItem75.MinSize = New System.Drawing.Size(60, 40)
        Me.LayoutControlItem75.Name = "LayoutControlItem75"
        Me.LayoutControlItem75.Size = New System.Drawing.Size(61, 50)
        Me.LayoutControlItem75.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem75.Text = "Charge:"
        Me.LayoutControlItem75.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem75.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem74
        '
        Me.LayoutControlItem74.Control = Me.TextBox13
        Me.LayoutControlItem74.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem74.MinSize = New System.Drawing.Size(60, 40)
        Me.LayoutControlItem74.Name = "LayoutControlItem74"
        Me.LayoutControlItem74.Size = New System.Drawing.Size(61, 50)
        Me.LayoutControlItem74.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem74.Text = "Pay:"
        Me.LayoutControlItem74.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem74.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlGroup16
        '
        Me.LayoutControlGroup16.CaptionImagePadding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 2)
        Me.LayoutControlGroup16.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem78, Me.LayoutControlItem77})
        Me.LayoutControlGroup16.Location = New System.Drawing.Point(0, 172)
        Me.LayoutControlGroup16.Name = "LayoutControlGroup16"
        Me.LayoutControlGroup16.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup16.Size = New System.Drawing.Size(296, 86)
        Me.LayoutControlGroup16.Text = "Pre Tax"
        '
        'LayoutControlItem78
        '
        Me.LayoutControlItem78.Control = Me.TextBox17
        Me.LayoutControlItem78.Location = New System.Drawing.Point(82, 0)
        Me.LayoutControlItem78.Name = "LayoutControlItem78"
        Me.LayoutControlItem78.Size = New System.Drawing.Size(202, 50)
        Me.LayoutControlItem78.Text = "Notes:"
        Me.LayoutControlItem78.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem78.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem77
        '
        Me.LayoutControlItem77.Control = Me.TextBox16
        Me.LayoutControlItem77.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem77.MinSize = New System.Drawing.Size(80, 40)
        Me.LayoutControlItem77.Name = "LayoutControlItem77"
        Me.LayoutControlItem77.Size = New System.Drawing.Size(82, 50)
        Me.LayoutControlItem77.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem77.Text = "Deductions:"
        Me.LayoutControlItem77.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem77.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlGroup17
        '
        Me.LayoutControlGroup17.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem80, Me.LayoutControlItem79})
        Me.LayoutControlGroup17.Location = New System.Drawing.Point(296, 172)
        Me.LayoutControlGroup17.Name = "LayoutControlGroup17"
        Me.LayoutControlGroup17.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup17.Size = New System.Drawing.Size(297, 86)
        Me.LayoutControlGroup17.Text = "Post Tax"
        '
        'LayoutControlItem80
        '
        Me.LayoutControlItem80.Control = Me.TextBox19
        Me.LayoutControlItem80.Location = New System.Drawing.Point(83, 0)
        Me.LayoutControlItem80.Name = "LayoutControlItem80"
        Me.LayoutControlItem80.Size = New System.Drawing.Size(202, 50)
        Me.LayoutControlItem80.Text = "Notes:"
        Me.LayoutControlItem80.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem80.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem79
        '
        Me.LayoutControlItem79.Control = Me.TextBox18
        Me.LayoutControlItem79.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem79.MinSize = New System.Drawing.Size(80, 40)
        Me.LayoutControlItem79.Name = "LayoutControlItem79"
        Me.LayoutControlItem79.Size = New System.Drawing.Size(83, 50)
        Me.LayoutControlItem79.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem79.Text = "Deductions:"
        Me.LayoutControlItem79.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem79.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlGroup18
        '
        Me.LayoutControlGroup18.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem82, Me.LayoutControlItem81})
        Me.LayoutControlGroup18.Location = New System.Drawing.Point(593, 172)
        Me.LayoutControlGroup18.Name = "LayoutControlGroup18"
        Me.LayoutControlGroup18.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup18.Size = New System.Drawing.Size(134, 86)
        Me.LayoutControlGroup18.Text = "Typical Start/End Times:"
        '
        'LayoutControlItem82
        '
        Me.LayoutControlItem82.Control = Me.tbEndTime
        Me.LayoutControlItem82.Location = New System.Drawing.Point(61, 0)
        Me.LayoutControlItem82.MinSize = New System.Drawing.Size(60, 40)
        Me.LayoutControlItem82.Name = "LayoutControlItem82"
        Me.LayoutControlItem82.Size = New System.Drawing.Size(61, 50)
        Me.LayoutControlItem82.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem82.Text = "End Time:"
        Me.LayoutControlItem82.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem82.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem81
        '
        Me.LayoutControlItem81.Control = Me.tbStartTime
        Me.LayoutControlItem81.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem81.MinSize = New System.Drawing.Size(60, 40)
        Me.LayoutControlItem81.Name = "LayoutControlItem81"
        Me.LayoutControlItem81.Size = New System.Drawing.Size(61, 50)
        Me.LayoutControlItem81.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem81.Text = "Start Time:"
        Me.LayoutControlItem81.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem81.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlGroup19
        '
        Me.LayoutControlGroup19.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem85, Me.LayoutControlItem6})
        Me.LayoutControlGroup19.Location = New System.Drawing.Point(727, 172)
        Me.LayoutControlGroup19.Name = "LayoutControlGroup19"
        Me.LayoutControlGroup19.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup19.Size = New System.Drawing.Size(136, 86)
        Me.LayoutControlGroup19.Text = "Breaks"
        '
        'LayoutControlItem85
        '
        Me.LayoutControlItem85.Control = Me.BreakDeductedCB
        Me.LayoutControlItem85.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem85.MinSize = New System.Drawing.Size(60, 39)
        Me.LayoutControlItem85.Name = "LayoutControlItem85"
        Me.LayoutControlItem85.Size = New System.Drawing.Size(63, 50)
        Me.LayoutControlItem85.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem85.Text = "Deducted"
        Me.LayoutControlItem85.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem85.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.EntitlementTB
        Me.LayoutControlItem6.Location = New System.Drawing.Point(63, 0)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(60, 40)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(61, 50)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Enititlement"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem40})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(1402, 258)
        Me.LayoutControlGroup6.Text = "Audit History"
        '
        'LayoutControlItem40
        '
        Me.LayoutControlItem40.Control = Me.GridControl2
        Me.LayoutControlItem40.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem40.Name = "LayoutControlItem40"
        Me.LayoutControlItem40.Size = New System.Drawing.Size(1402, 258)
        Me.LayoutControlItem40.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem40.TextVisible = False
        '
        'SplitterItem2
        '
        Me.SplitterItem2.AllowHotTrack = True
        Me.SplitterItem2.Location = New System.Drawing.Point(0, 95)
        Me.SplitterItem2.Name = "SplitterItem2"
        Me.SplitterItem2.Size = New System.Drawing.Size(1432, 15)
        '
        'LayoutControlItem39
        '
        Me.LayoutControlItem39.Control = Me.PlanBindingNavigator
        Me.LayoutControlItem39.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem39.Name = "LayoutControlItem39"
        Me.LayoutControlItem39.Size = New System.Drawing.Size(1432, 44)
        Me.LayoutControlItem39.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem39.TextVisible = False
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.ComboBox1
        Me.LayoutControlItem33.Location = New System.Drawing.Point(606, 44)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(202, 51)
        Me.LayoutControlItem33.Text = "Client"
        Me.LayoutControlItem33.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(191, 16)
        Me.LayoutControlItem33.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.WeekSelect
        Me.LayoutControlItem32.Location = New System.Drawing.Point(404, 44)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(202, 51)
        Me.LayoutControlItem32.Text = "Week Ending Date:"
        Me.LayoutControlItem32.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.PlanSelect
        Me.LayoutControlItem31.Location = New System.Drawing.Point(202, 44)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(202, 51)
        Me.LayoutControlItem31.Text = "Plan Type"
        Me.LayoutControlItem31.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(191, 16)
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.BranchSelect
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 44)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(202, 51)
        Me.LayoutControlItem30.Text = "Branch"
        Me.LayoutControlItem30.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(191, 16)
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(1182, 44)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(250, 51)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.SimpleButton1
        Me.LayoutControlItem28.Location = New System.Drawing.Point(1082, 44)
        Me.LayoutControlItem28.MinSize = New System.Drawing.Size(81, 26)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(100, 51)
        Me.LayoutControlItem28.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem28.TextVisible = False
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.Control = Me.SimpleButton2
        Me.LayoutControlItem37.Location = New System.Drawing.Point(987, 44)
        Me.LayoutControlItem37.MinSize = New System.Drawing.Size(72, 26)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(95, 51)
        Me.LayoutControlItem37.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem37.TextVisible = False
        '
        'LayoutControlItem35
        '
        Me.LayoutControlItem35.Control = Me.SimpleButton3
        Me.LayoutControlItem35.Location = New System.Drawing.Point(900, 44)
        Me.LayoutControlItem35.MinSize = New System.Drawing.Size(67, 26)
        Me.LayoutControlItem35.Name = "LayoutControlItem35"
        Me.LayoutControlItem35.Size = New System.Drawing.Size(87, 51)
        Me.LayoutControlItem35.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem35.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem35.TextVisible = False
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.Control = Me.SimpleButton4
        Me.LayoutControlItem36.Location = New System.Drawing.Point(808, 44)
        Me.LayoutControlItem36.MinSize = New System.Drawing.Size(57, 26)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(92, 51)
        Me.LayoutControlItem36.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem36.TextVisible = False
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.GridControl1
        Me.LayoutControlItem34.Location = New System.Drawing.Point(0, 438)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(1432, 428)
        Me.LayoutControlItem34.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem34.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 428)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(1432, 10)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'Plan2PerRecordTableAdapter
        '
        Me.Plan2PerRecordTableAdapter.ClearBeforeFill = True
        '
        'Plan2PerRecordTableAdapter1
        '
        Me.Plan2PerRecordTableAdapter1.ClearBeforeFill = True
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
        Me.TableAdapterManager.Connection = Nothing
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
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.WeeknumbersTableAdapter = Nothing
        '
        'PlanViewBindingSource
        '
        Me.PlanViewBindingSource.DataMember = "PlanView"
        Me.PlanViewBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'WeeknumbersBindingSource1
        '
        Me.WeeknumbersBindingSource1.DataMember = "Weeknumbers"
        Me.WeeknumbersBindingSource1.DataSource = Me.LexiconRecManagerDataSet2
        '
        'WeeknumbersBindingSource
        '
        Me.WeeknumbersBindingSource.DataMember = "Weeknumbers"
        Me.WeeknumbersBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'PlanViewBindingSource1
        '
        Me.PlanViewBindingSource1.AllowNew = False
        Me.PlanViewBindingSource1.DataMember = "PlanView"
        Me.PlanViewBindingSource1.DataSource = Me.LexiconRecManagerDataSet
        '
        'PlanViewTableAdapter
        '
        Me.PlanViewTableAdapter.ClearBeforeFill = True
        '
        'DataTable2TableAdapter
        '
        Me.DataTable2TableAdapter.ClearBeforeFill = True
        '
        'PlansAuditTableAdapter
        '
        Me.PlansAuditTableAdapter.ClearBeforeFill = True
        '
        'Plan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1416, 913)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Plan"
        Me.Text = "Form2"
        CType(Me.SitesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexiconRecManagerDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexiconRecManagerDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanTypesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlanBindingNavigator.ResumeLayout(False)
        Me.PlanBindingNavigator.PerformLayout()
        CType(Me.PlanViewDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.JobCategoryIdComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BreakDeductedCB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeIdComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlansAuditBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ratecombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeekendingdateiflatereasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeekLabel23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem84, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem83, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem87, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem86, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem73, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem72, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem70, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem76, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem75, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem78, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem77, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem80, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem79, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem82, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem85, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeeknumbersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeeknumbersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanViewBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PlanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanTableAdapter As LexrecMGr.LexiconRecManagerDataSetTableAdapters.PlanTableAdapter
    Friend WithEvents TableAdapterManager As LexrecMGr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlanTypesTableAdapter As LexrecMGr.LexiconRecManagerDataSetTableAdapters.PlanTypesTableAdapter
    Friend WithEvents PlanTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanViewTableAdapter As LexrecMGr.LexiconRecManagerDataSetTableAdapters.PlanViewTableAdapter
    Friend WithEvents Sites As LexrecMGr.Sites
    Friend WithEvents SitesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SitesTableAdapter As LexrecMGr.SitesTableAdapters.SitesTableAdapter
    Friend WithEvents TableAdapterManager1 As LexrecMGr.SitesTableAdapters.TableAdapterManager
    Friend WithEvents JobCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobCategoryTableAdapter As LexrecMGr.LexiconRecManagerDataSetTableAdapters.JobCategoryTableAdapter
    Friend WithEvents PoNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WeekEndingDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WeekEndingDateIfLateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FridayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SaturdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SundayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MondayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TuesdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents WednesdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ThursdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Friday2CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Saturday2CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Sunday2CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PlanTypeIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DateAddedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PlanBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PlanBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PlanViewDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents WeekSelect As System.Windows.Forms.ComboBox
    Friend WithEvents PlanSelect As System.Windows.Forms.ComboBox
    Friend WithEvents PlanTypesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PlanTypesTableAdapter1 As LexrecMGr.SitesTableAdapters.PlanTypesTableAdapter
    Friend WithEvents PlanBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PlanTableAdapter1 As LexrecMGr.SitesTableAdapters.PlanTableAdapter
    Friend WithEvents EmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeesTableAdapter As LexrecMGr.SitesTableAdapters.EmployeesTableAdapter
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents ExpensesPrePayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExpensesPreNotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExpensesPreChargeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OT2ChargeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OT2HoursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OT2PayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OT3ChargeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OT3HoursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OT3PayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NightsOutCharge As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents NightsPay As System.Windows.Forms.TextBox
    Friend WithEvents BankCharge As System.Windows.Forms.TextBox
    Friend WithEvents BankHours As System.Windows.Forms.TextBox
    Friend WithEvents BankPay As System.Windows.Forms.TextBox
    Friend WithEvents SundayCharge As System.Windows.Forms.TextBox
    Friend WithEvents SundayHours As System.Windows.Forms.TextBox
    Friend WithEvents SundayPay As System.Windows.Forms.TextBox
    Friend WithEvents SatCharge As System.Windows.Forms.TextBox
    Friend WithEvents SatHours As System.Windows.Forms.TextBox
    Friend WithEvents SatPay As System.Windows.Forms.TextBox
    Friend WithEvents OT1ChargeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OT1HoursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OT1PayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChargeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HolidayPayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HoursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents POAElseWhereTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HoursWorkedElseWhereTextBox As System.Windows.Forms.TextBox
    Friend WithEvents POATextBox As System.Windows.Forms.TextBox
    Friend WithEvents RulesOrDetailsRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents PlanViewBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1TableAdapter As LexrecMGr.SitesTableAdapters.DataTable1TableAdapter
    Friend WithEvents LastModifiedUserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents PlanIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BranchIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As LexrecMGr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents BranchSelect As System.Windows.Forms.ComboBox
    Friend WithEvents LexiconRecManagerDataSet1 As LexrecMGr.LexiconRecManagerDataSet
    Friend WithEvents BranchBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DHHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents Plan1TableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.Plan1TableAdapter
    Friend WithEvents SWHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MinCharge As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataTable2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LexiconRecManagerDataSet2 As Lexrecmgr.LexiconRecManagerDataSet
    Friend WithEvents DataTable2TableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.DataTable2TableAdapter
    Friend WithEvents WeeknumbersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WeeknumbersTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.WeeknumbersTableAdapter
    Friend WithEvents WeeknumbersBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents tbEndTime As System.Windows.Forms.TextBox
    Friend WithEvents tbStartTime As System.Windows.Forms.TextBox
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem47 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem46 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem45 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem44 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem43 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem42 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem54 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem53 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem52 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup10 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem60 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem59 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem58 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup9 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem57 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem56 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem55 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup12 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem66 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem65 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem64 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup13 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem69 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem68 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem67 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup14 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem72 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem71 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem70 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem73 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup15 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem76 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem75 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem74 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup16 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem78 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem77 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup17 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem80 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem79 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup18 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem82 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem81 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem51 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem49 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem48 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup11 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem63 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem62 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem61 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem10 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SplitterItem2 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Plan2PerRecordTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.Plan2PerRecordTableAdapter
    Friend WithEvents Plan2PerRecordTableAdapter1 As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.Plan2PerRecordTableAdapter
    Friend WithEvents WeekLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents WeekLabel23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Lock As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PlanIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SystemTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlanNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlanTypeIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanyIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanyNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ForenameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchemeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobCategoryIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobCategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShiftNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WeekEndingDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WeekEndingDateIfLateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FridayDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SaturdayDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SundayDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MondayDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TuesdayDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WednesdayDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ThursdayDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Friday2DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Saturday2DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Sunday2DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents HoursDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HolidayPayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChargeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalHoursDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalChargeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalHolidayPayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalNiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstMarginDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BranchIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PoNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderNumberReqDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colPlanID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colForename As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSurname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colScheme As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobCategoryId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiftName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeekEndingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeekEndingDateIfLate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFriday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaturday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSunday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTuesday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWednesday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colThursday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFriday2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaturday2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSunday2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHolidayPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCharge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalHours As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCharge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalHolidayPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalNi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstMargin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderNumberReq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSystemType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPoNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CompanyLookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem83 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Ratecombo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents WeekendingdateiflatereasonTextEdit As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents LayoutControlItem84 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LexiconRecManagerDataSet As Lexrecmgr.LexiconRecManagerDataSet
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PlansAuditBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlansAuditTableAdapter As Lexrecmgr.SitesTableAdapters.PlansAuditTableAdapter
    Friend WithEvents colBranchName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colForename1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSurname1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colScheme1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobCategory1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiftName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeekEndingDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeekEndingDateIfLate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFriday1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaturday1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSunday1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonday1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTuesday1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWednesday1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colThursday1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFriday21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaturday21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSunday21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastModifiedUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastModifiedDateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmployeeIdComboBox As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem50 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BreakDeductedCB As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents EntitlementTB As System.Windows.Forms.TextBox
    Friend WithEvents LayoutControlGroup19 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem85 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem86 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents JobCategoryIdComboBox As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem87 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
End Class
