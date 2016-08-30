<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plan2
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
        Dim CompanyIdLabel As System.Windows.Forms.Label
        Dim WeekEndingDateLabel As System.Windows.Forms.Label
        Dim WeekEndingDateIfLateLabel As System.Windows.Forms.Label
        Dim FridayLabel As System.Windows.Forms.Label
        Dim SaturdayLabel As System.Windows.Forms.Label
        Dim SundayLabel As System.Windows.Forms.Label
        Dim MondayLabel As System.Windows.Forms.Label
        Dim TuesdayLabel As System.Windows.Forms.Label
        Dim WednesdayLabel As System.Windows.Forms.Label
        Dim ThursdayLabel As System.Windows.Forms.Label
        Dim Friday2Label As System.Windows.Forms.Label
        Dim Saturday2Label As System.Windows.Forms.Label
        Dim Sunday2Label As System.Windows.Forms.Label
        Dim PlanTypeIdLabel As System.Windows.Forms.Label
        Dim EmployeeIdLabel As System.Windows.Forms.Label
        Dim JobCategoryIdLabel As System.Windows.Forms.Label
        Dim DateAddedLabel As System.Windows.Forms.Label
        Dim PoNumberLabel As System.Windows.Forms.Label
        Dim OT2ChargeLabel As System.Windows.Forms.Label
        Dim OT2HoursLabel As System.Windows.Forms.Label
        Dim OT2PayLabel As System.Windows.Forms.Label
        Dim OT3ChargeLabel As System.Windows.Forms.Label
        Dim OT3HoursLabel As System.Windows.Forms.Label
        Dim OT3PayLabel As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim OT1ChargeLabel As System.Windows.Forms.Label
        Dim OT1HoursLabel As System.Windows.Forms.Label
        Dim OT1PayLabel As System.Windows.Forms.Label
        Dim ChargeLabel As System.Windows.Forms.Label
        Dim HolidayPayLabel As System.Windows.Forms.Label
        Dim PayLabel As System.Windows.Forms.Label
        Dim RateLabel As System.Windows.Forms.Label
        Dim HoursLabel As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim ExpensesPreChargeLabel As System.Windows.Forms.Label
        Dim ExpensesPreNotesLabel As System.Windows.Forms.Label
        Dim ExpensesPrePayLabel As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim RulesOrDetailsLabel As System.Windows.Forms.Label
        Dim POALabel As System.Windows.Forms.Label
        Dim HoursWorkedElseWhereLabel As System.Windows.Forms.Label
        Dim POAElseWhereLabel As System.Windows.Forms.Label
        Dim LastModifiedUserLabel As System.Windows.Forms.Label
        Dim LastModifiedDateLabel As System.Windows.Forms.Label
        Dim PlanIDLabel As System.Windows.Forms.Label
        Dim BranchIdLabel As System.Windows.Forms.Label
        Dim DHHLabel As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim Label25 As System.Windows.Forms.Label
        Dim Label26 As System.Windows.Forms.Label
        Dim Label27 As System.Windows.Forms.Label
        Dim WeekLabel As System.Windows.Forms.Label
        Dim WeekLabel2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Plan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LexiconRecManagerDataSet = New Lexrecmgr.LexiconRecManagerDataSet()
        Me.PlanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.PlanTableAdapter()
        Me.TableAdapterManager = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager()
        Me.PlanTypesTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.PlanTypesTableAdapter()
        Me.SitesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sites = New Lexrecmgr.Sites()
        Me.PlanTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanViewTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.PlanViewTableAdapter()
        Me.SitesTableAdapter = New Lexrecmgr.SitesTableAdapters.SitesTableAdapter()
        Me.TableAdapterManager1 = New Lexrecmgr.SitesTableAdapters.TableAdapterManager()
        Me.JobCategoryTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.JobCategoryTableAdapter()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.WeekLabel3 = New System.Windows.Forms.Label()
        Me.WeeknumbersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LexiconRecManagerDataSet2 = New Lexrecmgr.LexiconRecManagerDataSet()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PlanLock = New System.Windows.Forms.Button()
        Me.PlanUnlock = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.BranchSelect = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LexiconRecManagerDataSet1 = New Lexrecmgr.LexiconRecManagerDataSet()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.WeekSelect = New System.Windows.Forms.ComboBox()
        Me.PlanBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanSelect = New System.Windows.Forms.ComboBox()
        Me.PlanTypesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WeekLabel1 = New System.Windows.Forms.Label()
        Me.WeeknumbersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.BranchIdComboBox = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanIDTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.LastModifiedUserTextBox = New System.Windows.Forms.TextBox()
        Me.POAElseWhereTextBox = New System.Windows.Forms.TextBox()
        Me.HoursWorkedElseWhereTextBox = New System.Windows.Forms.TextBox()
        Me.POATextBox = New System.Windows.Forms.TextBox()
        Me.PoNumberTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyIdComboBox = New System.Windows.Forms.ComboBox()
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
        Me.EmployeeIdComboBox = New System.Windows.Forms.ComboBox()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobCategoryIdComboBox = New System.Windows.Forms.ComboBox()
        Me.DateAddedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.tbEndTime = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tbStartTime = New System.Windows.Forms.TextBox()
        Me.RulesOrDetailsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.ExpensesPrePayTextBox = New System.Windows.Forms.TextBox()
        Me.ExpensesPreNotesTextBox = New System.Windows.Forms.TextBox()
        Me.ExpensesPreChargeTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.OT2ChargeTextBox = New System.Windows.Forms.TextBox()
        Me.OT2HoursTextBox = New System.Windows.Forms.TextBox()
        Me.OT2PayTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OT3ChargeTextBox = New System.Windows.Forms.TextBox()
        Me.OT3HoursTextBox = New System.Windows.Forms.TextBox()
        Me.OT3PayTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.NightsOutCharge = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.NightsPay = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.BankCharge = New System.Windows.Forms.TextBox()
        Me.BankHours = New System.Windows.Forms.TextBox()
        Me.BankPay = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.SundayCharge = New System.Windows.Forms.TextBox()
        Me.SundayHours = New System.Windows.Forms.TextBox()
        Me.SundayPay = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.SatCharge = New System.Windows.Forms.TextBox()
        Me.SatHours = New System.Windows.Forms.TextBox()
        Me.SatPay = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OT1ChargeTextBox = New System.Windows.Forms.TextBox()
        Me.OT1HoursTextBox = New System.Windows.Forms.TextBox()
        Me.OT1PayTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MinCharge = New System.Windows.Forms.TextBox()
        Me.SWHTextBox = New System.Windows.Forms.TextBox()
        Me.DHHTextBox = New System.Windows.Forms.TextBox()
        Me.ChargeTextBox = New System.Windows.Forms.TextBox()
        Me.HolidayPayTextBox = New System.Windows.Forms.TextBox()
        Me.PayTextBox = New System.Windows.Forms.TextBox()
        Me.HoursTextBox = New System.Windows.Forms.TextBox()
        Me.RateComboBox = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.PlanViewBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanTypesTableAdapter1 = New Lexrecmgr.SitesTableAdapters.PlanTypesTableAdapter()
        Me.PlanTableAdapter1 = New Lexrecmgr.SitesTableAdapters.PlanTableAdapter()
        Me.EmployeesTableAdapter = New Lexrecmgr.SitesTableAdapters.EmployeesTableAdapter()
        Me.DataTable1TableAdapter = New Lexrecmgr.SitesTableAdapters.DataTable1TableAdapter()
        Me.BranchTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter()
        Me.Plan1TableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.Plan1TableAdapter()
        Me.DataTable2TableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.DataTable2TableAdapter()
        Me.WeeknumbersTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.WeeknumbersTableAdapter()
        CompanyIdLabel = New System.Windows.Forms.Label()
        WeekEndingDateLabel = New System.Windows.Forms.Label()
        WeekEndingDateIfLateLabel = New System.Windows.Forms.Label()
        FridayLabel = New System.Windows.Forms.Label()
        SaturdayLabel = New System.Windows.Forms.Label()
        SundayLabel = New System.Windows.Forms.Label()
        MondayLabel = New System.Windows.Forms.Label()
        TuesdayLabel = New System.Windows.Forms.Label()
        WednesdayLabel = New System.Windows.Forms.Label()
        ThursdayLabel = New System.Windows.Forms.Label()
        Friday2Label = New System.Windows.Forms.Label()
        Saturday2Label = New System.Windows.Forms.Label()
        Sunday2Label = New System.Windows.Forms.Label()
        PlanTypeIdLabel = New System.Windows.Forms.Label()
        EmployeeIdLabel = New System.Windows.Forms.Label()
        JobCategoryIdLabel = New System.Windows.Forms.Label()
        DateAddedLabel = New System.Windows.Forms.Label()
        PoNumberLabel = New System.Windows.Forms.Label()
        OT2ChargeLabel = New System.Windows.Forms.Label()
        OT2HoursLabel = New System.Windows.Forms.Label()
        OT2PayLabel = New System.Windows.Forms.Label()
        OT3ChargeLabel = New System.Windows.Forms.Label()
        OT3HoursLabel = New System.Windows.Forms.Label()
        OT3PayLabel = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        OT1ChargeLabel = New System.Windows.Forms.Label()
        OT1HoursLabel = New System.Windows.Forms.Label()
        OT1PayLabel = New System.Windows.Forms.Label()
        ChargeLabel = New System.Windows.Forms.Label()
        HolidayPayLabel = New System.Windows.Forms.Label()
        PayLabel = New System.Windows.Forms.Label()
        RateLabel = New System.Windows.Forms.Label()
        HoursLabel = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        ExpensesPreChargeLabel = New System.Windows.Forms.Label()
        ExpensesPreNotesLabel = New System.Windows.Forms.Label()
        ExpensesPrePayLabel = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        RulesOrDetailsLabel = New System.Windows.Forms.Label()
        POALabel = New System.Windows.Forms.Label()
        HoursWorkedElseWhereLabel = New System.Windows.Forms.Label()
        POAElseWhereLabel = New System.Windows.Forms.Label()
        LastModifiedUserLabel = New System.Windows.Forms.Label()
        LastModifiedDateLabel = New System.Windows.Forms.Label()
        PlanIDLabel = New System.Windows.Forms.Label()
        BranchIdLabel = New System.Windows.Forms.Label()
        DHHLabel = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        Label25 = New System.Windows.Forms.Label()
        Label26 = New System.Windows.Forms.Label()
        Label27 = New System.Windows.Forms.Label()
        WeekLabel = New System.Windows.Forms.Label()
        WeekLabel2 = New System.Windows.Forms.Label()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SitesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.WeeknumbersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexiconRecManagerDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexiconRecManagerDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanTypesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.WeeknumbersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlanBindingNavigator.SuspendLayout()
        CType(Me.PlanViewDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanViewBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CompanyIdLabel
        '
        CompanyIdLabel.AutoSize = True
        CompanyIdLabel.Location = New System.Drawing.Point(123, 42)
        CompanyIdLabel.Name = "CompanyIdLabel"
        CompanyIdLabel.Size = New System.Drawing.Size(54, 13)
        CompanyIdLabel.TabIndex = 113
        CompanyIdLabel.Text = "Company:"
        '
        'WeekEndingDateLabel
        '
        WeekEndingDateLabel.AutoSize = True
        WeekEndingDateLabel.Location = New System.Drawing.Point(507, 42)
        WeekEndingDateLabel.Name = "WeekEndingDateLabel"
        WeekEndingDateLabel.Size = New System.Drawing.Size(101, 13)
        WeekEndingDateLabel.TabIndex = 115
        WeekEndingDateLabel.Text = "Week Ending Date:"
        '
        'WeekEndingDateIfLateLabel
        '
        WeekEndingDateIfLateLabel.AutoSize = True
        WeekEndingDateIfLateLabel.Location = New System.Drawing.Point(621, 42)
        WeekEndingDateIfLateLabel.Name = "WeekEndingDateIfLateLabel"
        WeekEndingDateIfLateLabel.Size = New System.Drawing.Size(134, 13)
        WeekEndingDateIfLateLabel.TabIndex = 117
        WeekEndingDateIfLateLabel.Text = "Week Ending Date If Late:"
        '
        'FridayLabel
        '
        FridayLabel.AutoSize = True
        FridayLabel.Location = New System.Drawing.Point(765, 42)
        FridayLabel.Name = "FridayLabel"
        FridayLabel.Size = New System.Drawing.Size(21, 13)
        FridayLabel.TabIndex = 119
        FridayLabel.Text = "Fri:"
        '
        'SaturdayLabel
        '
        SaturdayLabel.AutoSize = True
        SaturdayLabel.Location = New System.Drawing.Point(794, 42)
        SaturdayLabel.Name = "SaturdayLabel"
        SaturdayLabel.Size = New System.Drawing.Size(26, 13)
        SaturdayLabel.TabIndex = 121
        SaturdayLabel.Text = "Sat:"
        '
        'SundayLabel
        '
        SundayLabel.AutoSize = True
        SundayLabel.Location = New System.Drawing.Point(826, 42)
        SundayLabel.Name = "SundayLabel"
        SundayLabel.Size = New System.Drawing.Size(29, 13)
        SundayLabel.TabIndex = 123
        SundayLabel.Text = "Sun:"
        '
        'MondayLabel
        '
        MondayLabel.AutoSize = True
        MondayLabel.Location = New System.Drawing.Point(861, 42)
        MondayLabel.Name = "MondayLabel"
        MondayLabel.Size = New System.Drawing.Size(31, 13)
        MondayLabel.TabIndex = 125
        MondayLabel.Text = "Mon:"
        '
        'TuesdayLabel
        '
        TuesdayLabel.AutoSize = True
        TuesdayLabel.Location = New System.Drawing.Point(898, 42)
        TuesdayLabel.Name = "TuesdayLabel"
        TuesdayLabel.Size = New System.Drawing.Size(34, 13)
        TuesdayLabel.TabIndex = 127
        TuesdayLabel.Text = "Tues:"
        '
        'WednesdayLabel
        '
        WednesdayLabel.AutoSize = True
        WednesdayLabel.Location = New System.Drawing.Point(938, 42)
        WednesdayLabel.Name = "WednesdayLabel"
        WednesdayLabel.Size = New System.Drawing.Size(33, 13)
        WednesdayLabel.TabIndex = 129
        WednesdayLabel.Text = "Wed:"
        '
        'ThursdayLabel
        '
        ThursdayLabel.AutoSize = True
        ThursdayLabel.Location = New System.Drawing.Point(977, 42)
        ThursdayLabel.Name = "ThursdayLabel"
        ThursdayLabel.Size = New System.Drawing.Size(37, 13)
        ThursdayLabel.TabIndex = 131
        ThursdayLabel.Text = "Thurs:"
        '
        'Friday2Label
        '
        Friday2Label.AutoSize = True
        Friday2Label.Location = New System.Drawing.Point(1020, 42)
        Friday2Label.Name = "Friday2Label"
        Friday2Label.Size = New System.Drawing.Size(21, 13)
        Friday2Label.TabIndex = 133
        Friday2Label.Text = "Fri:"
        '
        'Saturday2Label
        '
        Saturday2Label.AutoSize = True
        Saturday2Label.Location = New System.Drawing.Point(1054, 42)
        Saturday2Label.Name = "Saturday2Label"
        Saturday2Label.Size = New System.Drawing.Size(26, 13)
        Saturday2Label.TabIndex = 135
        Saturday2Label.Text = "Sat:"
        '
        'Sunday2Label
        '
        Sunday2Label.AutoSize = True
        Sunday2Label.Location = New System.Drawing.Point(1086, 42)
        Sunday2Label.Name = "Sunday2Label"
        Sunday2Label.Size = New System.Drawing.Size(29, 13)
        Sunday2Label.TabIndex = 137
        Sunday2Label.Text = "Sun:"
        '
        'PlanTypeIdLabel
        '
        PlanTypeIdLabel.AutoSize = True
        PlanTypeIdLabel.Location = New System.Drawing.Point(33, 42)
        PlanTypeIdLabel.Name = "PlanTypeIdLabel"
        PlanTypeIdLabel.Size = New System.Drawing.Size(58, 13)
        PlanTypeIdLabel.TabIndex = 139
        PlanTypeIdLabel.Text = "Plan Type:"
        '
        'EmployeeIdLabel
        '
        EmployeeIdLabel.AutoSize = True
        EmployeeIdLabel.Location = New System.Drawing.Point(195, 42)
        EmployeeIdLabel.Name = "EmployeeIdLabel"
        EmployeeIdLabel.Size = New System.Drawing.Size(56, 13)
        EmployeeIdLabel.TabIndex = 141
        EmployeeIdLabel.Text = "Employee:"
        '
        'JobCategoryIdLabel
        '
        JobCategoryIdLabel.AutoSize = True
        JobCategoryIdLabel.Location = New System.Drawing.Point(341, 42)
        JobCategoryIdLabel.Name = "JobCategoryIdLabel"
        JobCategoryIdLabel.Size = New System.Drawing.Size(72, 13)
        JobCategoryIdLabel.TabIndex = 143
        JobCategoryIdLabel.Text = "Job Category:"
        '
        'DateAddedLabel
        '
        DateAddedLabel.AutoSize = True
        DateAddedLabel.Location = New System.Drawing.Point(33, 3)
        DateAddedLabel.Name = "DateAddedLabel"
        DateAddedLabel.Size = New System.Drawing.Size(67, 13)
        DateAddedLabel.TabIndex = 145
        DateAddedLabel.Text = "Date Added:"
        '
        'PoNumberLabel
        '
        PoNumberLabel.AutoSize = True
        PoNumberLabel.Location = New System.Drawing.Point(1136, 42)
        PoNumberLabel.Name = "PoNumberLabel"
        PoNumberLabel.Size = New System.Drawing.Size(63, 13)
        PoNumberLabel.TabIndex = 58
        PoNumberLabel.Text = "Po Number:"
        '
        'OT2ChargeLabel
        '
        OT2ChargeLabel.AutoSize = True
        OT2ChargeLabel.Location = New System.Drawing.Point(133, 15)
        OT2ChargeLabel.Name = "OT2ChargeLabel"
        OT2ChargeLabel.Size = New System.Drawing.Size(44, 13)
        OT2ChargeLabel.TabIndex = 56
        OT2ChargeLabel.Text = "Charge:"
        '
        'OT2HoursLabel
        '
        OT2HoursLabel.AutoSize = True
        OT2HoursLabel.Location = New System.Drawing.Point(9, 15)
        OT2HoursLabel.Name = "OT2HoursLabel"
        OT2HoursLabel.Size = New System.Drawing.Size(38, 13)
        OT2HoursLabel.TabIndex = 55
        OT2HoursLabel.Text = "Hours:"
        '
        'OT2PayLabel
        '
        OT2PayLabel.AutoSize = True
        OT2PayLabel.Location = New System.Drawing.Point(68, 15)
        OT2PayLabel.Name = "OT2PayLabel"
        OT2PayLabel.Size = New System.Drawing.Size(28, 13)
        OT2PayLabel.TabIndex = 55
        OT2PayLabel.Text = "Pay:"
        '
        'OT3ChargeLabel
        '
        OT3ChargeLabel.AutoSize = True
        OT3ChargeLabel.Location = New System.Drawing.Point(126, 16)
        OT3ChargeLabel.Name = "OT3ChargeLabel"
        OT3ChargeLabel.Size = New System.Drawing.Size(44, 13)
        OT3ChargeLabel.TabIndex = 57
        OT3ChargeLabel.Text = "Charge:"
        '
        'OT3HoursLabel
        '
        OT3HoursLabel.AutoSize = True
        OT3HoursLabel.Location = New System.Drawing.Point(6, 16)
        OT3HoursLabel.Name = "OT3HoursLabel"
        OT3HoursLabel.Size = New System.Drawing.Size(38, 13)
        OT3HoursLabel.TabIndex = 55
        OT3HoursLabel.Text = "Hours:"
        '
        'OT3PayLabel
        '
        OT3PayLabel.AutoSize = True
        OT3PayLabel.Location = New System.Drawing.Point(71, 16)
        OT3PayLabel.Name = "OT3PayLabel"
        OT3PayLabel.Size = New System.Drawing.Size(28, 13)
        OT3PayLabel.TabIndex = 56
        OT3PayLabel.Text = "Pay:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(121, 16)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(44, 13)
        Label10.TabIndex = 55
        Label10.Text = "Charge:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(5, 15)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(38, 13)
        Label11.TabIndex = 50
        Label11.Text = "Hours:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(56, 16)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(28, 13)
        Label12.TabIndex = 52
        Label12.Text = "Pay:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(121, 16)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(44, 13)
        Label7.TabIndex = 55
        Label7.Text = "Charge:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(5, 15)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(38, 13)
        Label8.TabIndex = 50
        Label8.Text = "Hours:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(56, 16)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(28, 13)
        Label9.TabIndex = 52
        Label9.Text = "Pay:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(121, 16)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(44, 13)
        Label4.TabIndex = 55
        Label4.Text = "Charge:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(5, 15)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(38, 13)
        Label5.TabIndex = 50
        Label5.Text = "Hours:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(56, 16)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(28, 13)
        Label6.TabIndex = 52
        Label6.Text = "Pay:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(121, 16)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(44, 13)
        Label1.TabIndex = 55
        Label1.Text = "Charge:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(5, 15)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(38, 13)
        Label2.TabIndex = 50
        Label2.Text = "Hours:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(56, 16)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(28, 13)
        Label3.TabIndex = 52
        Label3.Text = "Pay:"
        '
        'OT1ChargeLabel
        '
        OT1ChargeLabel.AutoSize = True
        OT1ChargeLabel.Location = New System.Drawing.Point(121, 16)
        OT1ChargeLabel.Name = "OT1ChargeLabel"
        OT1ChargeLabel.Size = New System.Drawing.Size(44, 13)
        OT1ChargeLabel.TabIndex = 55
        OT1ChargeLabel.Text = "Charge:"
        '
        'OT1HoursLabel
        '
        OT1HoursLabel.AutoSize = True
        OT1HoursLabel.Location = New System.Drawing.Point(5, 15)
        OT1HoursLabel.Name = "OT1HoursLabel"
        OT1HoursLabel.Size = New System.Drawing.Size(38, 13)
        OT1HoursLabel.TabIndex = 50
        OT1HoursLabel.Text = "Hours:"
        '
        'OT1PayLabel
        '
        OT1PayLabel.AutoSize = True
        OT1PayLabel.Location = New System.Drawing.Point(56, 16)
        OT1PayLabel.Name = "OT1PayLabel"
        OT1PayLabel.Size = New System.Drawing.Size(28, 13)
        OT1PayLabel.TabIndex = 52
        OT1PayLabel.Text = "Pay:"
        '
        'ChargeLabel
        '
        ChargeLabel.AutoSize = True
        ChargeLabel.Location = New System.Drawing.Point(261, 16)
        ChargeLabel.Name = "ChargeLabel"
        ChargeLabel.Size = New System.Drawing.Size(44, 13)
        ChargeLabel.TabIndex = 43
        ChargeLabel.Text = "Charge:"
        '
        'HolidayPayLabel
        '
        HolidayPayLabel.AutoSize = True
        HolidayPayLabel.Location = New System.Drawing.Point(185, 15)
        HolidayPayLabel.Name = "HolidayPayLabel"
        HolidayPayLabel.Size = New System.Drawing.Size(66, 13)
        HolidayPayLabel.TabIndex = 41
        HolidayPayLabel.Text = "Holiday Pay:"
        '
        'PayLabel
        '
        PayLabel.AutoSize = True
        PayLabel.Location = New System.Drawing.Point(129, 15)
        PayLabel.Name = "PayLabel"
        PayLabel.Size = New System.Drawing.Size(28, 13)
        PayLabel.TabIndex = 31
        PayLabel.Text = "Pay:"
        '
        'RateLabel
        '
        RateLabel.AutoSize = True
        RateLabel.Location = New System.Drawing.Point(12, 16)
        RateLabel.Name = "RateLabel"
        RateLabel.Size = New System.Drawing.Size(33, 13)
        RateLabel.TabIndex = 48
        RateLabel.Text = "Rate:"
        '
        'HoursLabel
        '
        HoursLabel.AutoSize = True
        HoursLabel.Location = New System.Drawing.Point(83, 16)
        HoursLabel.Name = "HoursLabel"
        HoursLabel.Size = New System.Drawing.Size(38, 13)
        HoursLabel.TabIndex = 29
        HoursLabel.Text = "Hours:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(82, 14)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(44, 13)
        Label13.TabIndex = 56
        Label13.Text = "Charge:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(133, 14)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(38, 13)
        Label14.TabIndex = 57
        Label14.Text = "Notes:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(5, 14)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(28, 13)
        Label15.TabIndex = 55
        Label15.Text = "Pay:"
        '
        'ExpensesPreChargeLabel
        '
        ExpensesPreChargeLabel.AutoSize = True
        ExpensesPreChargeLabel.Location = New System.Drawing.Point(68, 14)
        ExpensesPreChargeLabel.Name = "ExpensesPreChargeLabel"
        ExpensesPreChargeLabel.Size = New System.Drawing.Size(44, 13)
        ExpensesPreChargeLabel.TabIndex = 56
        ExpensesPreChargeLabel.Text = "Charge:"
        '
        'ExpensesPreNotesLabel
        '
        ExpensesPreNotesLabel.AutoSize = True
        ExpensesPreNotesLabel.Location = New System.Drawing.Point(140, 14)
        ExpensesPreNotesLabel.Name = "ExpensesPreNotesLabel"
        ExpensesPreNotesLabel.Size = New System.Drawing.Size(38, 13)
        ExpensesPreNotesLabel.TabIndex = 57
        ExpensesPreNotesLabel.Text = "Notes:"
        '
        'ExpensesPrePayLabel
        '
        ExpensesPrePayLabel.AutoSize = True
        ExpensesPrePayLabel.Location = New System.Drawing.Point(5, 14)
        ExpensesPrePayLabel.Name = "ExpensesPrePayLabel"
        ExpensesPrePayLabel.Size = New System.Drawing.Size(28, 13)
        ExpensesPrePayLabel.TabIndex = 55
        ExpensesPrePayLabel.Text = "Pay:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(123, 14)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(38, 13)
        Label16.TabIndex = 57
        Label16.Text = "Notes:"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Location = New System.Drawing.Point(5, 14)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(61, 13)
        Label19.TabIndex = 55
        Label19.Text = "Deductions"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(69, 14)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(38, 13)
        Label17.TabIndex = 57
        Label17.Text = "Notes:"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(5, 14)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(61, 13)
        Label18.TabIndex = 55
        Label18.Text = "Deductions"
        '
        'RulesOrDetailsLabel
        '
        RulesOrDetailsLabel.AutoSize = True
        RulesOrDetailsLabel.Location = New System.Drawing.Point(804, 78)
        RulesOrDetailsLabel.Name = "RulesOrDetailsLabel"
        RulesOrDetailsLabel.Size = New System.Drawing.Size(86, 13)
        RulesOrDetailsLabel.TabIndex = 168
        RulesOrDetailsLabel.Text = "Rules Or Details:"
        '
        'POALabel
        '
        POALabel.AutoSize = True
        POALabel.Location = New System.Drawing.Point(33, 85)
        POALabel.Name = "POALabel"
        POALabel.Size = New System.Drawing.Size(32, 13)
        POALabel.TabIndex = 148
        POALabel.Text = "POA:"
        '
        'HoursWorkedElseWhereLabel
        '
        HoursWorkedElseWhereLabel.AutoSize = True
        HoursWorkedElseWhereLabel.Location = New System.Drawing.Point(146, 85)
        HoursWorkedElseWhereLabel.Name = "HoursWorkedElseWhereLabel"
        HoursWorkedElseWhereLabel.Size = New System.Drawing.Size(137, 13)
        HoursWorkedElseWhereLabel.TabIndex = 149
        HoursWorkedElseWhereLabel.Text = "Hours Worked Else Where:"
        '
        'POAElseWhereLabel
        '
        POAElseWhereLabel.AutoSize = True
        POAElseWhereLabel.Location = New System.Drawing.Point(289, 85)
        POAElseWhereLabel.Name = "POAElseWhereLabel"
        POAElseWhereLabel.Size = New System.Drawing.Size(87, 13)
        POAElseWhereLabel.TabIndex = 150
        POAElseWhereLabel.Text = "POAElse Where:"
        '
        'LastModifiedUserLabel
        '
        LastModifiedUserLabel.AutoSize = True
        LastModifiedUserLabel.Location = New System.Drawing.Point(400, 85)
        LastModifiedUserLabel.Name = "LastModifiedUserLabel"
        LastModifiedUserLabel.Size = New System.Drawing.Size(98, 13)
        LastModifiedUserLabel.TabIndex = 151
        LastModifiedUserLabel.Text = "Last Modified User:"
        '
        'LastModifiedDateLabel
        '
        LastModifiedDateLabel.AutoSize = True
        LastModifiedDateLabel.Location = New System.Drawing.Point(505, 85)
        LastModifiedDateLabel.Name = "LastModifiedDateLabel"
        LastModifiedDateLabel.Size = New System.Drawing.Size(99, 13)
        LastModifiedDateLabel.TabIndex = 152
        LastModifiedDateLabel.Text = "Last Modified Date:"
        '
        'PlanIDLabel
        '
        PlanIDLabel.AutoSize = True
        PlanIDLabel.Location = New System.Drawing.Point(610, 85)
        PlanIDLabel.Name = "PlanIDLabel"
        PlanIDLabel.Size = New System.Drawing.Size(45, 13)
        PlanIDLabel.TabIndex = 153
        PlanIDLabel.Text = "Plan ID:"
        PlanIDLabel.Visible = False
        '
        'BranchIdLabel
        '
        BranchIdLabel.AutoSize = True
        BranchIdLabel.Location = New System.Drawing.Point(261, 21)
        BranchIdLabel.Name = "BranchIdLabel"
        BranchIdLabel.Size = New System.Drawing.Size(56, 13)
        BranchIdLabel.TabIndex = 154
        BranchIdLabel.Text = "Branch Id:"
        '
        'DHHLabel
        '
        DHHLabel.AutoSize = True
        DHHLabel.Location = New System.Drawing.Point(316, 16)
        DHHLabel.Name = "DHHLabel"
        DHHLabel.Size = New System.Drawing.Size(34, 13)
        DHHLabel.TabIndex = 151
        DHHLabel.Text = "DHH:"
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Location = New System.Drawing.Point(670, 21)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(78, 13)
        Label24.TabIndex = 156
        Label24.Text = "Start Of Week:"
        '
        'Label25
        '
        Label25.AutoSize = True
        Label25.Location = New System.Drawing.Point(376, 16)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(36, 13)
        Label25.TabIndex = 153
        Label25.Text = "SWH:"
        '
        'Label26
        '
        Label26.AutoSize = True
        Label26.Location = New System.Drawing.Point(427, 16)
        Label26.Name = "Label26"
        Label26.Size = New System.Drawing.Size(64, 13)
        Label26.TabIndex = 155
        Label26.Text = "Min Charge:"
        '
        'Label27
        '
        Label27.AutoSize = True
        Label27.Location = New System.Drawing.Point(33, 137)
        Label27.Name = "Label27"
        Label27.Size = New System.Drawing.Size(68, 13)
        Label27.TabIndex = 157
        Label27.Text = "SystemType:"
        Label27.Visible = False
        '
        'WeekLabel
        '
        WeekLabel.AutoSize = True
        WeekLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WeekLabel.Location = New System.Drawing.Point(715, 97)
        WeekLabel.Name = "WeekLabel"
        WeekLabel.Size = New System.Drawing.Size(81, 29)
        WeekLabel.TabIndex = 158
        WeekLabel.Text = "Week:"
        '
        'WeekLabel2
        '
        WeekLabel2.AutoSize = True
        WeekLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WeekLabel2.Location = New System.Drawing.Point(830, 25)
        WeekLabel2.Name = "WeekLabel2"
        WeekLabel2.Size = New System.Drawing.Size(54, 20)
        WeekLabel2.TabIndex = 13
        WeekLabel2.Text = "Week:"
        '
        'LexiconRecManagerDataSet
        '
        Me.LexiconRecManagerDataSet.DataSetName = "LexiconRecManagerDataSet"
        Me.LexiconRecManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlanBindingSource
        '
        Me.PlanBindingSource.DataMember = "Plan1"
        Me.PlanBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'PlanTableAdapter
        '
        Me.PlanTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BranchTableAdapter = Nothing
        Me.TableAdapterManager.BranchUserSecurityTableAdapter = Nothing
        Me.TableAdapterManager.CompanyContactsTableAdapter = Nothing
        Me.TableAdapterManager.ControlsTableAdapter = Nothing
        Me.TableAdapterManager.CountersTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Import_EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.JobCategoryTableAdapter = Nothing
        Me.TableAdapterManager.Plan1TableAdapter = Nothing
        Me.TableAdapterManager.PlanInvoiceTableAdapter = Nothing
        Me.TableAdapterManager.PlanTableAdapter = Me.PlanTableAdapter
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
        'PlanTypesBindingSource
        '
        Me.PlanTypesBindingSource.DataMember = "PlanTypes"
        Me.PlanTypesBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'JobCategoryBindingSource
        '
        Me.JobCategoryBindingSource.DataMember = "JobCategory"
        Me.JobCategoryBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'PlanViewBindingSource
        '
        Me.PlanViewBindingSource.DataSource = Me.LexiconRecManagerDataSet
        Me.PlanViewBindingSource.Position = 0
        '
        'PlanViewTableAdapter
        '
        Me.PlanViewTableAdapter.ClearBeforeFill = True
        '
        'SitesTableAdapter
        '
        Me.SitesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CompanyContactsTableAdapter = Nothing
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PlanBindingNavigator)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PlanViewDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(1293, 733)
        Me.SplitContainer1.SplitterDistance = 429
        Me.SplitContainer1.TabIndex = 60
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.SplitContainer2.Panel1.Controls.Add(WeekLabel2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.WeekLabel3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ComboBox1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PlanLock)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PlanUnlock)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label23)
        Me.SplitContainer2.Panel1.Controls.Add(Me.BranchSelect)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label21)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label28)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label22)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label20)
        Me.SplitContainer2.Panel1.Controls.Add(Me.WeekSelect)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PlanSelect)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1293, 404)
        Me.SplitContainer2.SplitterDistance = 56
        Me.SplitContainer2.TabIndex = 61
        '
        'WeekLabel3
        '
        Me.WeekLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WeeknumbersBindingSource1, "Week", True))
        Me.WeekLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeekLabel3.Location = New System.Drawing.Point(890, 25)
        Me.WeekLabel3.Name = "WeekLabel3"
        Me.WeekLabel3.Size = New System.Drawing.Size(85, 23)
        Me.WeekLabel3.TabIndex = 14
        '
        'WeeknumbersBindingSource1
        '
        Me.WeeknumbersBindingSource1.DataMember = "Weeknumbers"
        Me.WeeknumbersBindingSource1.DataSource = Me.LexiconRecManagerDataSet2
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
        Me.ComboBox1.Location = New System.Drawing.Point(296, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.ValueMember = "CompanyId"
        '
        'DataTable2BindingSource
        '
        Me.DataTable2BindingSource.AllowNew = False
        Me.DataTable2BindingSource.DataMember = "DataTable2"
        Me.DataTable2BindingSource.DataSource = Me.LexiconRecManagerDataSet2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(716, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 22)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Create Follow Up"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(634, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Archive Plan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PlanLock
        '
        Me.PlanLock.Location = New System.Drawing.Point(476, 22)
        Me.PlanLock.Name = "PlanLock"
        Me.PlanLock.Size = New System.Drawing.Size(75, 23)
        Me.PlanLock.TabIndex = 5
        Me.PlanLock.Text = "Lock Plan"
        Me.PlanLock.UseVisualStyleBackColor = True
        '
        'PlanUnlock
        '
        Me.PlanUnlock.Location = New System.Drawing.Point(553, 22)
        Me.PlanUnlock.Name = "PlanUnlock"
        Me.PlanUnlock.Size = New System.Drawing.Size(75, 23)
        Me.PlanUnlock.TabIndex = 5
        Me.PlanUnlock.Text = "Unlock Plan"
        Me.PlanUnlock.UseVisualStyleBackColor = True
        Me.PlanUnlock.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(3, 9)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(41, 13)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Branch"
        '
        'BranchSelect
        '
        Me.BranchSelect.DataSource = Me.BranchBindingSource1
        Me.BranchSelect.DisplayMember = "Branch"
        Me.BranchSelect.FormattingEnabled = True
        Me.BranchSelect.Location = New System.Drawing.Point(6, 25)
        Me.BranchSelect.Name = "BranchSelect"
        Me.BranchSelect.Size = New System.Drawing.Size(89, 21)
        Me.BranchSelect.TabIndex = 3
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
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(741, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Label21"
        Me.Label21.Visible = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(293, 9)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(33, 13)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "Client"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(186, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(92, 13)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "WeekEndingDate"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(98, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Plan Type"
        '
        'WeekSelect
        '
        Me.WeekSelect.DataSource = Me.PlanBindingSource1
        Me.WeekSelect.DisplayMember = "WeekEndingDate"
        Me.WeekSelect.FormatString = "D"
        Me.WeekSelect.FormattingEnabled = True
        Me.WeekSelect.Location = New System.Drawing.Point(187, 25)
        Me.WeekSelect.Name = "WeekSelect"
        Me.WeekSelect.Size = New System.Drawing.Size(91, 21)
        Me.WeekSelect.TabIndex = 0
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
        Me.PlanSelect.Location = New System.Drawing.Point(101, 25)
        Me.PlanSelect.Name = "PlanSelect"
        Me.PlanSelect.Size = New System.Drawing.Size(80, 21)
        Me.PlanSelect.TabIndex = 0
        Me.PlanSelect.ValueMember = "PlanTypeID"
        '
        'PlanTypesBindingSource1
        '
        Me.PlanTypesBindingSource1.DataMember = "PlanTypes"
        Me.PlanTypesBindingSource1.DataSource = Me.Sites
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1293, 344)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage1.Controls.Add(WeekLabel)
        Me.TabPage1.Controls.Add(Me.WeekLabel1)
        Me.TabPage1.Controls.Add(Label27)
        Me.TabPage1.Controls.Add(Me.TextBox22)
        Me.TabPage1.Controls.Add(Label24)
        Me.TabPage1.Controls.Add(Me.TextBox21)
        Me.TabPage1.Controls.Add(BranchIdLabel)
        Me.TabPage1.Controls.Add(Me.BranchIdComboBox)
        Me.TabPage1.Controls.Add(PlanIDLabel)
        Me.TabPage1.Controls.Add(Me.PlanIDTextBox)
        Me.TabPage1.Controls.Add(Me.TextBox20)
        Me.TabPage1.Controls.Add(LastModifiedDateLabel)
        Me.TabPage1.Controls.Add(LastModifiedUserLabel)
        Me.TabPage1.Controls.Add(Me.LastModifiedUserTextBox)
        Me.TabPage1.Controls.Add(POAElseWhereLabel)
        Me.TabPage1.Controls.Add(Me.POAElseWhereTextBox)
        Me.TabPage1.Controls.Add(HoursWorkedElseWhereLabel)
        Me.TabPage1.Controls.Add(Me.HoursWorkedElseWhereTextBox)
        Me.TabPage1.Controls.Add(POALabel)
        Me.TabPage1.Controls.Add(Me.POATextBox)
        Me.TabPage1.Controls.Add(PoNumberLabel)
        Me.TabPage1.Controls.Add(Me.PoNumberTextBox)
        Me.TabPage1.Controls.Add(CompanyIdLabel)
        Me.TabPage1.Controls.Add(Me.CompanyIdComboBox)
        Me.TabPage1.Controls.Add(WeekEndingDateLabel)
        Me.TabPage1.Controls.Add(Me.WeekEndingDateTextBox)
        Me.TabPage1.Controls.Add(WeekEndingDateIfLateLabel)
        Me.TabPage1.Controls.Add(Me.WeekEndingDateIfLateTextBox)
        Me.TabPage1.Controls.Add(FridayLabel)
        Me.TabPage1.Controls.Add(Me.FridayCheckBox)
        Me.TabPage1.Controls.Add(SaturdayLabel)
        Me.TabPage1.Controls.Add(Me.SaturdayCheckBox)
        Me.TabPage1.Controls.Add(SundayLabel)
        Me.TabPage1.Controls.Add(Me.SundayCheckBox)
        Me.TabPage1.Controls.Add(MondayLabel)
        Me.TabPage1.Controls.Add(Me.MondayCheckBox)
        Me.TabPage1.Controls.Add(TuesdayLabel)
        Me.TabPage1.Controls.Add(Me.TuesdayCheckBox)
        Me.TabPage1.Controls.Add(WednesdayLabel)
        Me.TabPage1.Controls.Add(Me.WednesdayCheckBox)
        Me.TabPage1.Controls.Add(ThursdayLabel)
        Me.TabPage1.Controls.Add(Me.ThursdayCheckBox)
        Me.TabPage1.Controls.Add(Friday2Label)
        Me.TabPage1.Controls.Add(Me.Friday2CheckBox)
        Me.TabPage1.Controls.Add(Saturday2Label)
        Me.TabPage1.Controls.Add(Me.Saturday2CheckBox)
        Me.TabPage1.Controls.Add(Sunday2Label)
        Me.TabPage1.Controls.Add(Me.Sunday2CheckBox)
        Me.TabPage1.Controls.Add(PlanTypeIdLabel)
        Me.TabPage1.Controls.Add(Me.PlanTypeIdComboBox)
        Me.TabPage1.Controls.Add(EmployeeIdLabel)
        Me.TabPage1.Controls.Add(Me.EmployeeIdComboBox)
        Me.TabPage1.Controls.Add(JobCategoryIdLabel)
        Me.TabPage1.Controls.Add(Me.JobCategoryIdComboBox)
        Me.TabPage1.Controls.Add(DateAddedLabel)
        Me.TabPage1.Controls.Add(Me.DateAddedDateTimePicker)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1285, 318)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        '
        'WeekLabel1
        '
        Me.WeekLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WeeknumbersBindingSource, "Week", True))
        Me.WeekLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeekLabel1.Location = New System.Drawing.Point(792, 97)
        Me.WeekLabel1.Name = "WeekLabel1"
        Me.WeekLabel1.Size = New System.Drawing.Size(68, 23)
        Me.WeekLabel1.TabIndex = 159
        '
        'WeeknumbersBindingSource
        '
        Me.WeeknumbersBindingSource.DataMember = "Weeknumbers"
        Me.WeeknumbersBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'TextBox22
        '
        Me.TextBox22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "SystemType", True))
        Me.TextBox22.Location = New System.Drawing.Point(33, 153)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.ReadOnly = True
        Me.TextBox22.Size = New System.Drawing.Size(100, 20)
        Me.TextBox22.TabIndex = 158
        '
        'TextBox21
        '
        Me.TextBox21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobCategoryBindingSource, "StartOfWeek", True))
        Me.TextBox21.Location = New System.Drawing.Point(754, 18)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.ReadOnly = True
        Me.TextBox21.Size = New System.Drawing.Size(140, 20)
        Me.TextBox21.TabIndex = 155
        '
        'BranchIdComboBox
        '
        Me.BranchIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PlanBindingSource, "BranchId", True))
        Me.BranchIdComboBox.DataSource = Me.BranchBindingSource
        Me.BranchIdComboBox.DisplayMember = "Branch"
        Me.BranchIdComboBox.FormattingEnabled = True
        Me.BranchIdComboBox.Location = New System.Drawing.Point(323, 18)
        Me.BranchIdComboBox.Name = "BranchIdComboBox"
        Me.BranchIdComboBox.Size = New System.Drawing.Size(121, 21)
        Me.BranchIdComboBox.TabIndex = 2
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
        Me.PlanIDTextBox.Location = New System.Drawing.Point(610, 101)
        Me.PlanIDTextBox.Name = "PlanIDTextBox"
        Me.PlanIDTextBox.ReadOnly = True
        Me.PlanIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PlanIDTextBox.TabIndex = 154
        '
        'TextBox20
        '
        Me.TextBox20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "LastModifiedDate", True))
        Me.TextBox20.Location = New System.Drawing.Point(504, 101)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.ReadOnly = True
        Me.TextBox20.Size = New System.Drawing.Size(100, 20)
        Me.TextBox20.TabIndex = 153
        '
        'LastModifiedUserTextBox
        '
        Me.LastModifiedUserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "LastModifiedUser", True))
        Me.LastModifiedUserTextBox.Location = New System.Drawing.Point(398, 101)
        Me.LastModifiedUserTextBox.Name = "LastModifiedUserTextBox"
        Me.LastModifiedUserTextBox.ReadOnly = True
        Me.LastModifiedUserTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastModifiedUserTextBox.TabIndex = 152
        '
        'POAElseWhereTextBox
        '
        Me.POAElseWhereTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "POAElseWhere", True))
        Me.POAElseWhereTextBox.Location = New System.Drawing.Point(292, 101)
        Me.POAElseWhereTextBox.Name = "POAElseWhereTextBox"
        Me.POAElseWhereTextBox.Size = New System.Drawing.Size(100, 20)
        Me.POAElseWhereTextBox.TabIndex = 23
        '
        'HoursWorkedElseWhereTextBox
        '
        Me.HoursWorkedElseWhereTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "HoursWorkedElseWhere", True))
        Me.HoursWorkedElseWhereTextBox.Location = New System.Drawing.Point(149, 101)
        Me.HoursWorkedElseWhereTextBox.Name = "HoursWorkedElseWhereTextBox"
        Me.HoursWorkedElseWhereTextBox.Size = New System.Drawing.Size(134, 20)
        Me.HoursWorkedElseWhereTextBox.TabIndex = 22
        '
        'POATextBox
        '
        Me.POATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "POA", True))
        Me.POATextBox.Location = New System.Drawing.Point(36, 101)
        Me.POATextBox.Name = "POATextBox"
        Me.POATextBox.Size = New System.Drawing.Size(100, 20)
        Me.POATextBox.TabIndex = 21
        '
        'PoNumberTextBox
        '
        Me.PoNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "PoNumber", True))
        Me.PoNumberTextBox.Location = New System.Drawing.Point(1139, 58)
        Me.PoNumberTextBox.Name = "PoNumberTextBox"
        Me.PoNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PoNumberTextBox.TabIndex = 20
        '
        'CompanyIdComboBox
        '
        Me.CompanyIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PlanBindingSource, "CompanyId", True))
        Me.CompanyIdComboBox.DataSource = Me.SitesBindingSource
        Me.CompanyIdComboBox.DisplayMember = "ClientCode"
        Me.CompanyIdComboBox.FormattingEnabled = True
        Me.CompanyIdComboBox.Location = New System.Drawing.Point(126, 58)
        Me.CompanyIdComboBox.Name = "CompanyIdComboBox"
        Me.CompanyIdComboBox.Size = New System.Drawing.Size(63, 21)
        Me.CompanyIdComboBox.TabIndex = 5
        Me.CompanyIdComboBox.ValueMember = "CompanyID"
        '
        'WeekEndingDateTextBox
        '
        Me.WeekEndingDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "WeekEndingDate", True))
        Me.WeekEndingDateTextBox.Location = New System.Drawing.Point(510, 58)
        Me.WeekEndingDateTextBox.Name = "WeekEndingDateTextBox"
        Me.WeekEndingDateTextBox.Size = New System.Drawing.Size(105, 20)
        Me.WeekEndingDateTextBox.TabIndex = 8
        '
        'WeekEndingDateIfLateTextBox
        '
        Me.WeekEndingDateIfLateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "WeekEndingDateIfLate", True))
        Me.WeekEndingDateIfLateTextBox.Location = New System.Drawing.Point(624, 58)
        Me.WeekEndingDateIfLateTextBox.Name = "WeekEndingDateIfLateTextBox"
        Me.WeekEndingDateIfLateTextBox.Size = New System.Drawing.Size(123, 20)
        Me.WeekEndingDateIfLateTextBox.TabIndex = 9
        '
        'FridayCheckBox
        '
        Me.FridayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Friday", True))
        Me.FridayCheckBox.Location = New System.Drawing.Point(768, 58)
        Me.FridayCheckBox.Name = "FridayCheckBox"
        Me.FridayCheckBox.Size = New System.Drawing.Size(20, 24)
        Me.FridayCheckBox.TabIndex = 10
        Me.FridayCheckBox.UseVisualStyleBackColor = True
        '
        'SaturdayCheckBox
        '
        Me.SaturdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Saturday", True))
        Me.SaturdayCheckBox.Location = New System.Drawing.Point(797, 58)
        Me.SaturdayCheckBox.Name = "SaturdayCheckBox"
        Me.SaturdayCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.SaturdayCheckBox.TabIndex = 11
        Me.SaturdayCheckBox.UseVisualStyleBackColor = True
        '
        'SundayCheckBox
        '
        Me.SundayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Sunday", True))
        Me.SundayCheckBox.Location = New System.Drawing.Point(829, 58)
        Me.SundayCheckBox.Name = "SundayCheckBox"
        Me.SundayCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.SundayCheckBox.TabIndex = 12
        Me.SundayCheckBox.UseVisualStyleBackColor = True
        '
        'MondayCheckBox
        '
        Me.MondayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Monday", True))
        Me.MondayCheckBox.Location = New System.Drawing.Point(864, 58)
        Me.MondayCheckBox.Name = "MondayCheckBox"
        Me.MondayCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.MondayCheckBox.TabIndex = 13
        Me.MondayCheckBox.UseVisualStyleBackColor = True
        '
        'TuesdayCheckBox
        '
        Me.TuesdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Tuesday", True))
        Me.TuesdayCheckBox.Location = New System.Drawing.Point(901, 58)
        Me.TuesdayCheckBox.Name = "TuesdayCheckBox"
        Me.TuesdayCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.TuesdayCheckBox.TabIndex = 14
        Me.TuesdayCheckBox.UseVisualStyleBackColor = True
        '
        'WednesdayCheckBox
        '
        Me.WednesdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Wednesday", True))
        Me.WednesdayCheckBox.Location = New System.Drawing.Point(941, 58)
        Me.WednesdayCheckBox.Name = "WednesdayCheckBox"
        Me.WednesdayCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.WednesdayCheckBox.TabIndex = 15
        Me.WednesdayCheckBox.UseVisualStyleBackColor = True
        '
        'ThursdayCheckBox
        '
        Me.ThursdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Thursday", True))
        Me.ThursdayCheckBox.Location = New System.Drawing.Point(980, 58)
        Me.ThursdayCheckBox.Name = "ThursdayCheckBox"
        Me.ThursdayCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.ThursdayCheckBox.TabIndex = 16
        Me.ThursdayCheckBox.UseVisualStyleBackColor = True
        '
        'Friday2CheckBox
        '
        Me.Friday2CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Friday2", True))
        Me.Friday2CheckBox.Location = New System.Drawing.Point(1026, 58)
        Me.Friday2CheckBox.Name = "Friday2CheckBox"
        Me.Friday2CheckBox.Size = New System.Drawing.Size(15, 24)
        Me.Friday2CheckBox.TabIndex = 17
        Me.Friday2CheckBox.UseVisualStyleBackColor = True
        '
        'Saturday2CheckBox
        '
        Me.Saturday2CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Saturday2", True))
        Me.Saturday2CheckBox.Location = New System.Drawing.Point(1057, 58)
        Me.Saturday2CheckBox.Name = "Saturday2CheckBox"
        Me.Saturday2CheckBox.Size = New System.Drawing.Size(15, 24)
        Me.Saturday2CheckBox.TabIndex = 18
        Me.Saturday2CheckBox.UseVisualStyleBackColor = True
        '
        'Sunday2CheckBox
        '
        Me.Sunday2CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PlanBindingSource, "Sunday2", True))
        Me.Sunday2CheckBox.Location = New System.Drawing.Point(1089, 58)
        Me.Sunday2CheckBox.Name = "Sunday2CheckBox"
        Me.Sunday2CheckBox.Size = New System.Drawing.Size(15, 24)
        Me.Sunday2CheckBox.TabIndex = 19
        Me.Sunday2CheckBox.UseVisualStyleBackColor = True
        '
        'PlanTypeIdComboBox
        '
        Me.PlanTypeIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PlanBindingSource, "PlanTypeId", True))
        Me.PlanTypeIdComboBox.DataSource = Me.PlanTypesBindingSource
        Me.PlanTypeIdComboBox.DisplayMember = "PlanName"
        Me.PlanTypeIdComboBox.FormattingEnabled = True
        Me.PlanTypeIdComboBox.Location = New System.Drawing.Point(36, 58)
        Me.PlanTypeIdComboBox.Name = "PlanTypeIdComboBox"
        Me.PlanTypeIdComboBox.Size = New System.Drawing.Size(87, 21)
        Me.PlanTypeIdComboBox.TabIndex = 4
        Me.PlanTypeIdComboBox.ValueMember = "PlanTypeID"
        '
        'EmployeeIdComboBox
        '
        Me.EmployeeIdComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.EmployeeIdComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EmployeeIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PlanBindingSource, "EmployeeId", True))
        Me.EmployeeIdComboBox.DataSource = Me.EmployeesBindingSource
        Me.EmployeeIdComboBox.DisplayMember = "EmployeeCode"
        Me.EmployeeIdComboBox.FormattingEnabled = True
        Me.EmployeeIdComboBox.Location = New System.Drawing.Point(198, 58)
        Me.EmployeeIdComboBox.Name = "EmployeeIdComboBox"
        Me.EmployeeIdComboBox.Size = New System.Drawing.Size(140, 21)
        Me.EmployeeIdComboBox.TabIndex = 6
        Me.EmployeeIdComboBox.ValueMember = "EmployeeID"
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.Sites
        Me.EmployeesBindingSource.Filter = "SystemType = 'C'"
        '
        'JobCategoryIdComboBox
        '
        Me.JobCategoryIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PlanBindingSource, "JobCategoryId", True))
        Me.JobCategoryIdComboBox.DataSource = Me.JobCategoryBindingSource
        Me.JobCategoryIdComboBox.DisplayMember = "Job"
        Me.JobCategoryIdComboBox.FormattingEnabled = True
        Me.JobCategoryIdComboBox.Location = New System.Drawing.Point(344, 58)
        Me.JobCategoryIdComboBox.Name = "JobCategoryIdComboBox"
        Me.JobCategoryIdComboBox.Size = New System.Drawing.Size(143, 21)
        Me.JobCategoryIdComboBox.TabIndex = 7
        Me.JobCategoryIdComboBox.ValueMember = "JobCatId"
        '
        'DateAddedDateTimePicker
        '
        Me.DateAddedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PlanBindingSource, "DateAdded", True))
        Me.DateAddedDateTimePicker.Location = New System.Drawing.Point(33, 19)
        Me.DateAddedDateTimePicker.Name = "DateAddedDateTimePicker"
        Me.DateAddedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateAddedDateTimePicker.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage2.Controls.Add(Me.Label30)
        Me.TabPage2.Controls.Add(Me.tbEndTime)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.tbStartTime)
        Me.TabPage2.Controls.Add(RulesOrDetailsLabel)
        Me.TabPage2.Controls.Add(Me.RulesOrDetailsRichTextBox)
        Me.TabPage2.Controls.Add(Me.GroupBox12)
        Me.TabPage2.Controls.Add(Me.GroupBox11)
        Me.TabPage2.Controls.Add(Me.GroupBox10)
        Me.TabPage2.Controls.Add(Me.GroupBox9)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox8)
        Me.TabPage2.Controls.Add(Me.GroupBox7)
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1285, 318)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rates"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(929, 255)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(89, 13)
        Me.Label30.TabIndex = 173
        Me.Label30.Text = "Typical End Time"
        '
        'tbEndTime
        '
        Me.tbEndTime.Location = New System.Drawing.Point(927, 269)
        Me.tbEndTime.Name = "tbEndTime"
        Me.tbEndTime.ReadOnly = True
        Me.tbEndTime.Size = New System.Drawing.Size(100, 20)
        Me.tbEndTime.TabIndex = 172
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(804, 255)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(92, 13)
        Me.Label29.TabIndex = 171
        Me.Label29.Text = "Typical Start Time"
        '
        'tbStartTime
        '
        Me.tbStartTime.Location = New System.Drawing.Point(805, 269)
        Me.tbStartTime.Name = "tbStartTime"
        Me.tbStartTime.ReadOnly = True
        Me.tbStartTime.Size = New System.Drawing.Size(100, 20)
        Me.tbStartTime.TabIndex = 170
        '
        'RulesOrDetailsRichTextBox
        '
        Me.RulesOrDetailsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "RulesOrDetails", True))
        Me.RulesOrDetailsRichTextBox.Location = New System.Drawing.Point(805, 96)
        Me.RulesOrDetailsRichTextBox.Name = "RulesOrDetailsRichTextBox"
        Me.RulesOrDetailsRichTextBox.Size = New System.Drawing.Size(441, 156)
        Me.RulesOrDetailsRichTextBox.TabIndex = 169
        Me.RulesOrDetailsRichTextBox.Text = ""
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Label16)
        Me.GroupBox12.Controls.Add(Me.TextBox18)
        Me.GroupBox12.Controls.Add(Me.TextBox19)
        Me.GroupBox12.Controls.Add(Label19)
        Me.GroupBox12.Location = New System.Drawing.Point(339, 192)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(427, 60)
        Me.GroupBox12.TabIndex = 168
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Post Tax"
        '
        'TextBox18
        '
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "PostTaxDeductions", True))
        Me.TextBox18.Location = New System.Drawing.Point(6, 31)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(100, 20)
        Me.TextBox18.TabIndex = 56
        '
        'TextBox19
        '
        Me.TextBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "PostTaxNotes", True))
        Me.TextBox19.Location = New System.Drawing.Point(126, 31)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(296, 20)
        Me.TextBox19.TabIndex = 58
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Label17)
        Me.GroupBox11.Controls.Add(Me.TextBox16)
        Me.GroupBox11.Controls.Add(Me.TextBox17)
        Me.GroupBox11.Controls.Add(Label18)
        Me.GroupBox11.Location = New System.Drawing.Point(8, 192)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(325, 60)
        Me.GroupBox11.TabIndex = 167
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Pre Tax"
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "PreTaxDeductions", True))
        Me.TextBox16.Location = New System.Drawing.Point(6, 31)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(60, 20)
        Me.TextBox16.TabIndex = 56
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "PreTaxNotes", True))
        Me.TextBox17.Location = New System.Drawing.Point(72, 31)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(235, 20)
        Me.TextBox17.TabIndex = 58
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Label13)
        Me.GroupBox10.Controls.Add(Label14)
        Me.GroupBox10.Controls.Add(Me.TextBox13)
        Me.GroupBox10.Controls.Add(Me.TextBox14)
        Me.GroupBox10.Controls.Add(Label15)
        Me.GroupBox10.Controls.Add(Me.TextBox15)
        Me.GroupBox10.Location = New System.Drawing.Point(413, 130)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(329, 56)
        Me.GroupBox10.TabIndex = 165
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Expenses Post"
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "ExpensesPostPay", True))
        Me.TextBox13.Location = New System.Drawing.Point(6, 31)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(75, 20)
        Me.TextBox13.TabIndex = 56
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "ExpensesPostNotes", True))
        Me.TextBox14.Location = New System.Drawing.Point(136, 31)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(179, 20)
        Me.TextBox14.TabIndex = 58
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "ExpensesPostCharge", True))
        Me.TextBox15.Location = New System.Drawing.Point(85, 31)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(45, 20)
        Me.TextBox15.TabIndex = 57
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(ExpensesPreChargeLabel)
        Me.GroupBox9.Controls.Add(ExpensesPreNotesLabel)
        Me.GroupBox9.Controls.Add(Me.ExpensesPrePayTextBox)
        Me.GroupBox9.Controls.Add(Me.ExpensesPreNotesTextBox)
        Me.GroupBox9.Controls.Add(ExpensesPrePayLabel)
        Me.GroupBox9.Controls.Add(Me.ExpensesPreChargeTextBox)
        Me.GroupBox9.Location = New System.Drawing.Point(8, 130)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(399, 56)
        Me.GroupBox9.TabIndex = 166
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Expenses Pre"
        '
        'ExpensesPrePayTextBox
        '
        Me.ExpensesPrePayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "ExpensesPrePay", True))
        Me.ExpensesPrePayTextBox.Location = New System.Drawing.Point(6, 31)
        Me.ExpensesPrePayTextBox.Name = "ExpensesPrePayTextBox"
        Me.ExpensesPrePayTextBox.Size = New System.Drawing.Size(59, 20)
        Me.ExpensesPrePayTextBox.TabIndex = 56
        '
        'ExpensesPreNotesTextBox
        '
        Me.ExpensesPreNotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "ExpensesPreNotes", True))
        Me.ExpensesPreNotesTextBox.Location = New System.Drawing.Point(143, 31)
        Me.ExpensesPreNotesTextBox.Name = "ExpensesPreNotesTextBox"
        Me.ExpensesPreNotesTextBox.Size = New System.Drawing.Size(240, 20)
        Me.ExpensesPreNotesTextBox.TabIndex = 58
        '
        'ExpensesPreChargeTextBox
        '
        Me.ExpensesPreChargeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "ExpensesPreCharge", True))
        Me.ExpensesPreChargeTextBox.Location = New System.Drawing.Point(71, 31)
        Me.ExpensesPreChargeTextBox.Name = "ExpensesPreChargeTextBox"
        Me.ExpensesPreChargeTextBox.Size = New System.Drawing.Size(66, 20)
        Me.ExpensesPreChargeTextBox.TabIndex = 57
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(OT2ChargeLabel)
        Me.GroupBox4.Controls.Add(OT2HoursLabel)
        Me.GroupBox4.Controls.Add(Me.OT2ChargeTextBox)
        Me.GroupBox4.Controls.Add(Me.OT2HoursTextBox)
        Me.GroupBox4.Controls.Add(OT2PayLabel)
        Me.GroupBox4.Controls.Add(Me.OT2PayTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(739, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(187, 57)
        Me.GroupBox4.TabIndex = 159
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "OT2"
        '
        'OT2ChargeTextBox
        '
        Me.OT2ChargeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "OT2Charge", True))
        Me.OT2ChargeTextBox.Location = New System.Drawing.Point(134, 31)
        Me.OT2ChargeTextBox.Name = "OT2ChargeTextBox"
        Me.OT2ChargeTextBox.ReadOnly = True
        Me.OT2ChargeTextBox.Size = New System.Drawing.Size(52, 20)
        Me.OT2ChargeTextBox.TabIndex = 57
        '
        'OT2HoursTextBox
        '
        Me.OT2HoursTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "OT2Hours", True))
        Me.OT2HoursTextBox.Location = New System.Drawing.Point(6, 31)
        Me.OT2HoursTextBox.Name = "OT2HoursTextBox"
        Me.OT2HoursTextBox.Size = New System.Drawing.Size(55, 20)
        Me.OT2HoursTextBox.TabIndex = 56
        Me.OT2HoursTextBox.Text = "0"
        '
        'OT2PayTextBox
        '
        Me.OT2PayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "OT2Pay", True))
        Me.OT2PayTextBox.Location = New System.Drawing.Point(67, 31)
        Me.OT2PayTextBox.Name = "OT2PayTextBox"
        Me.OT2PayTextBox.Size = New System.Drawing.Size(61, 20)
        Me.OT2PayTextBox.TabIndex = 56
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(OT3ChargeLabel)
        Me.GroupBox3.Controls.Add(OT3HoursLabel)
        Me.GroupBox3.Controls.Add(Me.OT3ChargeTextBox)
        Me.GroupBox3.Controls.Add(Me.OT3HoursTextBox)
        Me.GroupBox3.Controls.Add(OT3PayLabel)
        Me.GroupBox3.Controls.Add(Me.OT3PayTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(932, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(183, 57)
        Me.GroupBox3.TabIndex = 160
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "OT3"
        '
        'OT3ChargeTextBox
        '
        Me.OT3ChargeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "OT3Charge", True))
        Me.OT3ChargeTextBox.Location = New System.Drawing.Point(126, 32)
        Me.OT3ChargeTextBox.Name = "OT3ChargeTextBox"
        Me.OT3ChargeTextBox.Size = New System.Drawing.Size(44, 20)
        Me.OT3ChargeTextBox.TabIndex = 58
        '
        'OT3HoursTextBox
        '
        Me.OT3HoursTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "OT3Hours", True))
        Me.OT3HoursTextBox.Location = New System.Drawing.Point(9, 32)
        Me.OT3HoursTextBox.Name = "OT3HoursTextBox"
        Me.OT3HoursTextBox.Size = New System.Drawing.Size(56, 20)
        Me.OT3HoursTextBox.TabIndex = 56
        Me.OT3HoursTextBox.Text = "0"
        '
        'OT3PayTextBox
        '
        Me.OT3PayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "OT3Pay", True))
        Me.OT3PayTextBox.Location = New System.Drawing.Point(71, 32)
        Me.OT3PayTextBox.Name = "OT3PayTextBox"
        Me.OT3PayTextBox.Size = New System.Drawing.Size(49, 20)
        Me.OT3PayTextBox.TabIndex = 57
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Label10)
        Me.GroupBox8.Controls.Add(Label11)
        Me.GroupBox8.Controls.Add(Me.NightsOutCharge)
        Me.GroupBox8.Controls.Add(Me.TextBox11)
        Me.GroupBox8.Controls.Add(Me.NightsPay)
        Me.GroupBox8.Controls.Add(Label12)
        Me.GroupBox8.Location = New System.Drawing.Point(430, 64)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(194, 57)
        Me.GroupBox8.TabIndex = 161
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Nights Out"
        '
        'NightsOutCharge
        '
        Me.NightsOutCharge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "NightsOutCharge", True))
        Me.NightsOutCharge.Location = New System.Drawing.Point(121, 32)
        Me.NightsOutCharge.Name = "NightsOutCharge"
        Me.NightsOutCharge.ReadOnly = True
        Me.NightsOutCharge.Size = New System.Drawing.Size(65, 20)
        Me.NightsOutCharge.TabIndex = 56
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "NightsOutHours", True))
        Me.TextBox11.Location = New System.Drawing.Point(5, 32)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(46, 20)
        Me.TextBox11.TabIndex = 51
        Me.TextBox11.Text = "0"
        '
        'NightsPay
        '
        Me.NightsPay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "NightsOutPay", True))
        Me.NightsPay.Location = New System.Drawing.Point(59, 32)
        Me.NightsPay.Name = "NightsPay"
        Me.NightsPay.Size = New System.Drawing.Size(58, 20)
        Me.NightsPay.TabIndex = 53
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Label7)
        Me.GroupBox7.Controls.Add(Label8)
        Me.GroupBox7.Controls.Add(Me.BankCharge)
        Me.GroupBox7.Controls.Add(Me.BankHours)
        Me.GroupBox7.Controls.Add(Me.BankPay)
        Me.GroupBox7.Controls.Add(Label9)
        Me.GroupBox7.Location = New System.Drawing.Point(230, 64)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(194, 57)
        Me.GroupBox7.TabIndex = 162
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Bank Holiday:"
        '
        'BankCharge
        '
        Me.BankCharge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "BankCharge", True))
        Me.BankCharge.Location = New System.Drawing.Point(121, 32)
        Me.BankCharge.Name = "BankCharge"
        Me.BankCharge.ReadOnly = True
        Me.BankCharge.Size = New System.Drawing.Size(65, 20)
        Me.BankCharge.TabIndex = 56
        '
        'BankHours
        '
        Me.BankHours.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "BankHours", True))
        Me.BankHours.Location = New System.Drawing.Point(5, 32)
        Me.BankHours.Name = "BankHours"
        Me.BankHours.Size = New System.Drawing.Size(46, 20)
        Me.BankHours.TabIndex = 51
        Me.BankHours.Text = "0"
        '
        'BankPay
        '
        Me.BankPay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "BankPay", True))
        Me.BankPay.Location = New System.Drawing.Point(59, 32)
        Me.BankPay.Name = "BankPay"
        Me.BankPay.Size = New System.Drawing.Size(58, 20)
        Me.BankPay.TabIndex = 53
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Label4)
        Me.GroupBox6.Controls.Add(Label5)
        Me.GroupBox6.Controls.Add(Me.SundayCharge)
        Me.GroupBox6.Controls.Add(Me.SundayHours)
        Me.GroupBox6.Controls.Add(Me.SundayPay)
        Me.GroupBox6.Controls.Add(Label6)
        Me.GroupBox6.Location = New System.Drawing.Point(23, 64)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(194, 57)
        Me.GroupBox6.TabIndex = 163
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Sunday"
        '
        'SundayCharge
        '
        Me.SundayCharge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "SundayCharge", True))
        Me.SundayCharge.Location = New System.Drawing.Point(121, 32)
        Me.SundayCharge.Name = "SundayCharge"
        Me.SundayCharge.ReadOnly = True
        Me.SundayCharge.Size = New System.Drawing.Size(65, 20)
        Me.SundayCharge.TabIndex = 56
        '
        'SundayHours
        '
        Me.SundayHours.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "SundayHours", True))
        Me.SundayHours.Location = New System.Drawing.Point(5, 32)
        Me.SundayHours.Name = "SundayHours"
        Me.SundayHours.Size = New System.Drawing.Size(46, 20)
        Me.SundayHours.TabIndex = 51
        Me.SundayHours.Text = "0"
        '
        'SundayPay
        '
        Me.SundayPay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "SundayPay", True))
        Me.SundayPay.Location = New System.Drawing.Point(59, 32)
        Me.SundayPay.Name = "SundayPay"
        Me.SundayPay.Size = New System.Drawing.Size(58, 20)
        Me.SundayPay.TabIndex = 53
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Label1)
        Me.GroupBox5.Controls.Add(Label2)
        Me.GroupBox5.Controls.Add(Me.SatCharge)
        Me.GroupBox5.Controls.Add(Me.SatHours)
        Me.GroupBox5.Controls.Add(Me.SatPay)
        Me.GroupBox5.Controls.Add(Label3)
        Me.GroupBox5.Location = New System.Drawing.Point(1112, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(164, 57)
        Me.GroupBox5.TabIndex = 164
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Saturday:"
        '
        'SatCharge
        '
        Me.SatCharge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "SaturdayCharge", True))
        Me.SatCharge.Location = New System.Drawing.Point(121, 32)
        Me.SatCharge.Name = "SatCharge"
        Me.SatCharge.ReadOnly = True
        Me.SatCharge.Size = New System.Drawing.Size(44, 20)
        Me.SatCharge.TabIndex = 56
        '
        'SatHours
        '
        Me.SatHours.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "SaturdayHours", True))
        Me.SatHours.Location = New System.Drawing.Point(5, 32)
        Me.SatHours.Name = "SatHours"
        Me.SatHours.Size = New System.Drawing.Size(46, 20)
        Me.SatHours.TabIndex = 51
        Me.SatHours.Text = "0"
        '
        'SatPay
        '
        Me.SatPay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "SaturdayPay", True))
        Me.SatPay.Location = New System.Drawing.Point(59, 32)
        Me.SatPay.Name = "SatPay"
        Me.SatPay.Size = New System.Drawing.Size(58, 20)
        Me.SatPay.TabIndex = 53
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(OT1ChargeLabel)
        Me.GroupBox2.Controls.Add(OT1HoursLabel)
        Me.GroupBox2.Controls.Add(Me.OT1ChargeTextBox)
        Me.GroupBox2.Controls.Add(Me.OT1HoursTextBox)
        Me.GroupBox2.Controls.Add(Me.OT1PayTextBox)
        Me.GroupBox2.Controls.Add(OT1PayLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(541, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(197, 57)
        Me.GroupBox2.TabIndex = 158
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OT1"
        '
        'OT1ChargeTextBox
        '
        Me.OT1ChargeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "OT1Charge", True))
        Me.OT1ChargeTextBox.Location = New System.Drawing.Point(121, 32)
        Me.OT1ChargeTextBox.Name = "OT1ChargeTextBox"
        Me.OT1ChargeTextBox.ReadOnly = True
        Me.OT1ChargeTextBox.Size = New System.Drawing.Size(65, 20)
        Me.OT1ChargeTextBox.TabIndex = 56
        '
        'OT1HoursTextBox
        '
        Me.OT1HoursTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "OT1Hours", True))
        Me.OT1HoursTextBox.Location = New System.Drawing.Point(5, 32)
        Me.OT1HoursTextBox.Name = "OT1HoursTextBox"
        Me.OT1HoursTextBox.Size = New System.Drawing.Size(46, 20)
        Me.OT1HoursTextBox.TabIndex = 51
        Me.OT1HoursTextBox.Text = "0"
        '
        'OT1PayTextBox
        '
        Me.OT1PayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "OT1Pay", True))
        Me.OT1PayTextBox.Location = New System.Drawing.Point(59, 32)
        Me.OT1PayTextBox.Name = "OT1PayTextBox"
        Me.OT1PayTextBox.Size = New System.Drawing.Size(58, 20)
        Me.OT1PayTextBox.TabIndex = 53
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label26)
        Me.GroupBox1.Controls.Add(Me.MinCharge)
        Me.GroupBox1.Controls.Add(Label25)
        Me.GroupBox1.Controls.Add(Me.SWHTextBox)
        Me.GroupBox1.Controls.Add(DHHLabel)
        Me.GroupBox1.Controls.Add(Me.DHHTextBox)
        Me.GroupBox1.Controls.Add(Me.ChargeTextBox)
        Me.GroupBox1.Controls.Add(ChargeLabel)
        Me.GroupBox1.Controls.Add(Me.HolidayPayTextBox)
        Me.GroupBox1.Controls.Add(HolidayPayLabel)
        Me.GroupBox1.Controls.Add(Me.PayTextBox)
        Me.GroupBox1.Controls.Add(PayLabel)
        Me.GroupBox1.Controls.Add(RateLabel)
        Me.GroupBox1.Controls.Add(Me.HoursTextBox)
        Me.GroupBox1.Controls.Add(Me.RateComboBox)
        Me.GroupBox1.Controls.Add(HoursLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 57)
        Me.GroupBox1.TabIndex = 157
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic:"
        '
        'MinCharge
        '
        Me.MinCharge.Location = New System.Drawing.Point(427, 32)
        Me.MinCharge.Name = "MinCharge"
        Me.MinCharge.ReadOnly = True
        Me.MinCharge.Size = New System.Drawing.Size(46, 20)
        Me.MinCharge.TabIndex = 154
        '
        'SWHTextBox
        '
        Me.SWHTextBox.Location = New System.Drawing.Point(376, 32)
        Me.SWHTextBox.Name = "SWHTextBox"
        Me.SWHTextBox.ReadOnly = True
        Me.SWHTextBox.Size = New System.Drawing.Size(46, 20)
        Me.SWHTextBox.TabIndex = 152
        '
        'DHHTextBox
        '
        Me.DHHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "DHH", True))
        Me.DHHTextBox.Location = New System.Drawing.Point(319, 32)
        Me.DHHTextBox.Name = "DHHTextBox"
        Me.DHHTextBox.ReadOnly = True
        Me.DHHTextBox.Size = New System.Drawing.Size(51, 20)
        Me.DHHTextBox.TabIndex = 150
        '
        'ChargeTextBox
        '
        Me.ChargeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "Charge", True))
        Me.ChargeTextBox.Location = New System.Drawing.Point(264, 32)
        Me.ChargeTextBox.Name = "ChargeTextBox"
        Me.ChargeTextBox.ReadOnly = True
        Me.ChargeTextBox.Size = New System.Drawing.Size(49, 20)
        Me.ChargeTextBox.TabIndex = 44
        '
        'HolidayPayTextBox
        '
        Me.HolidayPayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "HolidayPay", True))
        Me.HolidayPayTextBox.Location = New System.Drawing.Point(188, 32)
        Me.HolidayPayTextBox.Name = "HolidayPayTextBox"
        Me.HolidayPayTextBox.ReadOnly = True
        Me.HolidayPayTextBox.Size = New System.Drawing.Size(70, 20)
        Me.HolidayPayTextBox.TabIndex = 42
        '
        'PayTextBox
        '
        Me.PayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "Pay", True))
        Me.PayTextBox.Location = New System.Drawing.Point(132, 32)
        Me.PayTextBox.Name = "PayTextBox"
        Me.PayTextBox.Size = New System.Drawing.Size(50, 20)
        Me.PayTextBox.TabIndex = 32
        '
        'HoursTextBox
        '
        Me.HoursTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "Hours", True))
        Me.HoursTextBox.Location = New System.Drawing.Point(86, 32)
        Me.HoursTextBox.Name = "HoursTextBox"
        Me.HoursTextBox.Size = New System.Drawing.Size(35, 20)
        Me.HoursTextBox.TabIndex = 30
        '
        'RateComboBox
        '
        Me.RateComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlanBindingSource, "Rate", True))
        Me.RateComboBox.FormattingEnabled = True
        Me.RateComboBox.Items.AddRange(New Object() {"Rate 1", "Rate 2", "Rate 3", "Rate 4"})
        Me.RateComboBox.Location = New System.Drawing.Point(12, 32)
        Me.RateComboBox.Name = "RateComboBox"
        Me.RateComboBox.Size = New System.Drawing.Size(65, 21)
        Me.RateComboBox.TabIndex = 49
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1285, 318)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "AuditHistory"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1279, 312)
        Me.DataGridView1.TabIndex = 0
        '
        'PlanBindingNavigator
        '
        Me.PlanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PlanBindingNavigator.BindingSource = Me.PlanBindingSource
        Me.PlanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PlanBindingNavigator.DeleteItem = Nothing
        Me.PlanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripButton3, Me.PlanBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.PlanBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PlanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PlanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PlanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PlanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PlanBindingNavigator.Name = "PlanBindingNavigator"
        Me.PlanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PlanBindingNavigator.Size = New System.Drawing.Size(1293, 25)
        Me.PlanBindingNavigator.TabIndex = 60
        Me.PlanBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Delete"
        '
        'PlanBindingNavigatorSaveItem
        '
        Me.PlanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PlanBindingNavigatorSaveItem.Image = CType(resources.GetObject("PlanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PlanBindingNavigatorSaveItem.Name = "PlanBindingNavigatorSaveItem"
        Me.PlanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PlanBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Lexrecmgr.My.Resources.Resources.refresh
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(182, 22)
        Me.ToolStripButton2.Text = "Insert Current Week Ending Date"
        '
        'PlanViewDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PlanViewDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.PlanViewDataGridView.AutoGenerateColumns = False
        Me.PlanViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlanViewDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Lock, Me.PlanIDDataGridViewTextBoxColumn, Me.SystemTypeDataGridViewTextBoxColumn, Me.PlanNameDataGridViewTextBoxColumn, Me.PlanTypeIdDataGridViewTextBoxColumn, Me.CompanyIdDataGridViewTextBoxColumn, Me.CompanyNameDataGridViewTextBoxColumn, Me.ForenameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.EmployeeIdDataGridViewTextBoxColumn, Me.EmployeeCodeDataGridViewTextBoxColumn, Me.SchemeDataGridViewTextBoxColumn, Me.JobCategoryIdDataGridViewTextBoxColumn, Me.JobCategoryDataGridViewTextBoxColumn, Me.ShiftNameDataGridViewTextBoxColumn, Me.WeekEndingDateDataGridViewTextBoxColumn, Me.WeekEndingDateIfLateDataGridViewTextBoxColumn, Me.FridayDataGridViewCheckBoxColumn, Me.SaturdayDataGridViewCheckBoxColumn, Me.SundayDataGridViewCheckBoxColumn, Me.MondayDataGridViewCheckBoxColumn, Me.TuesdayDataGridViewCheckBoxColumn, Me.WednesdayDataGridViewCheckBoxColumn, Me.ThursdayDataGridViewCheckBoxColumn, Me.Friday2DataGridViewCheckBoxColumn, Me.Saturday2DataGridViewCheckBoxColumn, Me.Sunday2DataGridViewCheckBoxColumn, Me.HoursDataGridViewTextBoxColumn, Me.PayDataGridViewTextBoxColumn, Me.HolidayPayDataGridViewTextBoxColumn, Me.ChargeDataGridViewTextBoxColumn, Me.TotalHoursDataGridViewTextBoxColumn, Me.TotalPayDataGridViewTextBoxColumn, Me.TotalChargeDataGridViewTextBoxColumn, Me.TotalHolidayPayDataGridViewTextBoxColumn, Me.TotalNiDataGridViewTextBoxColumn, Me.TotalCostDataGridViewTextBoxColumn, Me.EstMarginDataGridViewTextBoxColumn, Me.BranchIdDataGridViewTextBoxColumn, Me.PoNumberDataGridViewTextBoxColumn, Me.OrderNumberReqDataGridViewCheckBoxColumn})
        Me.PlanViewDataGridView.DataSource = Me.DataTable1BindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PlanViewDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.PlanViewDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlanViewDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.PlanViewDataGridView.MultiSelect = False
        Me.PlanViewDataGridView.Name = "PlanViewDataGridView"
        Me.PlanViewDataGridView.ReadOnly = True
        Me.PlanViewDataGridView.Size = New System.Drawing.Size(1293, 300)
        Me.PlanViewDataGridView.TabIndex = 48
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
        'PlanViewBindingSource1
        '
        Me.PlanViewBindingSource1.AllowNew = False
        Me.PlanViewBindingSource1.DataMember = "PlanView"
        Me.PlanViewBindingSource1.DataSource = Me.LexiconRecManagerDataSet
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
        'DataTable2TableAdapter
        '
        Me.DataTable2TableAdapter.ClearBeforeFill = True
        '
        'WeeknumbersTableAdapter
        '
        Me.WeeknumbersTableAdapter.ClearBeforeFill = True
        '
        'Plan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1293, 733)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Plan"
        Me.Text = "Form2"
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SitesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.WeeknumbersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexiconRecManagerDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexiconRecManagerDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanTypesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.WeeknumbersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlanBindingNavigator.ResumeLayout(False)
        Me.PlanBindingNavigator.PerformLayout()
        CType(Me.PlanViewDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanViewBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LexiconRecManagerDataSet As LexrecMGr.LexiconRecManagerDataSet
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
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents PoNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanyIdComboBox As System.Windows.Forms.ComboBox
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
    Friend WithEvents EmployeeIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents JobCategoryIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DateAddedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
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
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents PlanBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PlanTableAdapter1 As LexrecMGr.SitesTableAdapters.PlanTableAdapter
    Friend WithEvents EmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeesTableAdapter As LexrecMGr.SitesTableAdapters.EmployeesTableAdapter
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents ExpensesPrePayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExpensesPreNotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExpensesPreChargeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents OT2ChargeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OT2HoursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OT2PayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents OT3ChargeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OT3HoursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OT3PayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents NightsOutCharge As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents NightsPay As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents BankCharge As System.Windows.Forms.TextBox
    Friend WithEvents BankHours As System.Windows.Forms.TextBox
    Friend WithEvents BankPay As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents SundayCharge As System.Windows.Forms.TextBox
    Friend WithEvents SundayHours As System.Windows.Forms.TextBox
    Friend WithEvents SundayPay As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents SatCharge As System.Windows.Forms.TextBox
    Friend WithEvents SatHours As System.Windows.Forms.TextBox
    Friend WithEvents SatPay As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OT1ChargeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OT1HoursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OT1PayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChargeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HolidayPayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HoursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents POAElseWhereTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HoursWorkedElseWhereTextBox As System.Windows.Forms.TextBox
    Friend WithEvents POATextBox As System.Windows.Forms.TextBox
    Friend WithEvents RulesOrDetailsRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PlanViewBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1TableAdapter As LexrecMGr.SitesTableAdapters.DataTable1TableAdapter
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LastModifiedUserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents PlanIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BranchIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As LexrecMGr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents BranchSelect As System.Windows.Forms.ComboBox
    Friend WithEvents LexiconRecManagerDataSet1 As LexrecMGr.LexiconRecManagerDataSet
    Friend WithEvents BranchBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PlanUnlock As System.Windows.Forms.Button
    Friend WithEvents PlanLock As System.Windows.Forms.Button
    Friend WithEvents DHHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents Plan1TableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.Plan1TableAdapter
    Friend WithEvents SWHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MinCharge As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
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
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataTable2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LexiconRecManagerDataSet2 As Lexrecmgr.LexiconRecManagerDataSet
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents DataTable2TableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.DataTable2TableAdapter
    Friend WithEvents WeeknumbersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WeeknumbersTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.WeeknumbersTableAdapter
    Friend WithEvents WeekLabel1 As System.Windows.Forms.Label
    Friend WithEvents WeeknumbersBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents WeekLabel3 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents tbEndTime As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents tbStartTime As System.Windows.Forms.TextBox
End Class
