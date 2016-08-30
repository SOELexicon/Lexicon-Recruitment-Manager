<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clients
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
        Dim SwedishderogationPureContractedLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clients))
        Me.SitesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sites = New Lexrecmgr.Sites()
        Me.SitesTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.SitesTableAdapter()
        Me.TableAdapterManager = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager()
        Me.BranchTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter()
        Me.CompanyContactsTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.CompanyContactsTableAdapter()
        Me.JobCategoryTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.JobCategoryTableAdapter()
        Me.SitesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.SitesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GLAClientCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.DataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
        Me.CompanyContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKCompanyContactsSitesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyContactsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colForename = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSurname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartment1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colJobTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelephone21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelephone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFax1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActive1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DNICheckBox = New System.Windows.Forms.CheckBox()
        Me.BranchIDComboBox = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LexiconRecManagerDataSet = New Lexrecmgr.LexiconRecManagerDataSet()
        Me.OtherTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.ClientCodeTextBox = New System.Windows.Forms.TextBox()
        Me.CreditLimitTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyRegNumberTextBox = New System.Windows.Forms.TextBox()
        Me.LtdCheckBox = New System.Windows.Forms.CheckBox()
        Me.TermsTextBox = New System.Windows.Forms.TextBox()
        Me.SpecialInvoiceInstructionsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TBCompanyId = New System.Windows.Forms.TextBox()
        Me.PLCCheckBox = New System.Windows.Forms.CheckBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ConsultantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LexiconManagemnetToolsDataSet = New Lexrecmgr.LexiconManagemnetToolsDataSet()
        Me.SoleTraderCheckBox = New System.Windows.Forms.CheckBox()
        Me.PayParityPureEmbraceCheckBox = New System.Windows.Forms.CheckBox()
        Me.SwedishderogationPureContractedCheckBox = New System.Windows.Forms.CheckBox()
        Me.NotesRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.CreatedByTimeEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CreatedDateDateEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LastModifiedUserTimeEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LastModifiedDateDateEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem158 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem161 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem162 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem163 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem164 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem168 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.InvoicingMethodTextBox = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Address2TextBox = New System.Windows.Forms.TextBox()
        Me.TownTextBox = New System.Windows.Forms.TextBox()
        Me.CountyComboBox = New System.Windows.Forms.ComboBox()
        Me.CountryComboBox = New System.Windows.Forms.ComboBox()
        Me.PostalCodeTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Telephone1TextBox = New System.Windows.Forms.TextBox()
        Me.Telephone2TextBox = New System.Windows.Forms.TextBox()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        Me.InvPostCodeTextBox = New System.Windows.Forms.TextBox()
        Me.InvCountryComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.InvCountyComboBox = New System.Windows.Forms.ComboBox()
        Me.InvoiceToTextBox = New System.Windows.Forms.TextBox()
        Me.ArchiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.InvTownTextBox = New System.Windows.Forms.TextBox()
        Me.InvAddressTextBox = New System.Windows.Forms.TextBox()
        Me.OrderNumberReq1CheckBox = New System.Windows.Forms.CheckBox()
        Me.Address3TextBox = New System.Windows.Forms.TextBox()
        Me.POtypeTextEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.BankIDSpinEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.BanksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sites1 = New Lexrecmgr.Sites()
        Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem167 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem166 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.asdas = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.LayoutControl4 = New DevExpress.XtraLayout.LayoutControl()
        Me.HolidayEntitlementTextBox = New System.Windows.Forms.TextBox()
        Me.HowArePermanentVacanciesDisplayedTextBox = New System.Windows.Forms.TextBox()
        Me.CanteenAvailableCheckBox = New System.Windows.Forms.CheckBox()
        Me.OtherFacilitiesTextBox = New System.Windows.Forms.TextBox()
        Me.SmokingAreaAvailableCheckBox = New System.Windows.Forms.CheckBox()
        Me.ParkingAvailableCheckBox = New System.Windows.Forms.CheckBox()
        Me.LayoutControlGroup18 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem111 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem132 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem133 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem134 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem135 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem136 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SplitterItem3 = New DevExpress.XtraLayout.SplitterItem()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.LayoutControl5 = New DevExpress.XtraLayout.LayoutControl()
        Me.H_SEarDefendersCheckBox = New System.Windows.Forms.CheckBox()
        Me.H_SOtherEqupmentTextBox = New System.Windows.Forms.TextBox()
        Me.H_SContactTextBox = New System.Windows.Forms.TextBox()
        Me.H_SHiVisTrousersCheckBox = New System.Windows.Forms.CheckBox()
        Me.H_SPositionTextBox = New System.Windows.Forms.TextBox()
        Me.H_SMobileTextBox = New System.Windows.Forms.TextBox()
        Me.H_SHardHatCheckBox = New System.Windows.Forms.CheckBox()
        Me.H_SEmailTextBox = New System.Windows.Forms.TextBox()
        Me.H_SRisksTextBox = New System.Windows.Forms.TextBox()
        Me.H_SSaftyGogglesCheckBox = New System.Windows.Forms.CheckBox()
        Me.H_SStepsTextBox = New System.Windows.Forms.TextBox()
        Me.H_SMinAgeTextBox = New System.Windows.Forms.TextBox()
        Me.H_SHiVizVestCheckBox = New System.Windows.Forms.CheckBox()
        Me.H_SBasicInductionCheckBox = New System.Windows.Forms.CheckBox()
        Me.H_SInstructionGivenCheckBox = New System.Windows.Forms.CheckBox()
        Me.H_SSaftyBootsCheckBox = New System.Windows.Forms.CheckBox()
        Me.H_SFirstAidAvailableCheckBox = New System.Windows.Forms.CheckBox()
        Me.H_SAccidentsReportedCheckBox = New System.Windows.Forms.CheckBox()
        Me.LayoutControlGroup19 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem137 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem138 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem139 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem140 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem141 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem142 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem143 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem144 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem145 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem146 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem147 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem148 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem149 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem150 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem151 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem152 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem153 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem154 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.FKJobCategorySitesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArchiveCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.JobCatIdSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colJobCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiftName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTypicalStartTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTypicalEndTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArchive1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MinChargePerDayTextBox = New System.Windows.Forms.TextBox()
        Me.TempToPermAfterTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.NotesForTimeSheetTextBox = New System.Windows.Forms.TextBox()
        Me.MemoEdit4 = New DevExpress.XtraEditors.MemoEdit()
        Me.MemoEdit3 = New DevExpress.XtraEditors.MemoEdit()
        Me.TimesheetTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.MemoEdit2 = New DevExpress.XtraEditors.MemoEdit()
        Me.C4NightsOutTextBox = New System.Windows.Forms.TextBox()
        Me.TimeSheetSentViaTextBox = New System.Windows.Forms.TextBox()
        Me.SWHTextBox = New System.Windows.Forms.TextBox()
        Me.LastModifiedDateTextBox = New System.Windows.Forms.TextBox()
        Me.LastModifiedUserTextBox = New System.Windows.Forms.TextBox()
        Me.CBJobType = New System.Windows.Forms.ComboBox()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.C3NightsOutTextBox = New System.Windows.Forms.TextBox()
        Me.TimesheetContactComboBox = New System.Windows.Forms.ComboBox()
        Me.DHHTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.C4BankHolTextBox = New System.Windows.Forms.TextBox()
        Me.C2NightsOutTextBox = New System.Windows.Forms.TextBox()
        Me.C4SundayTextBox = New System.Windows.Forms.TextBox()
        Me.C3BankHolTextBox = New System.Windows.Forms.TextBox()
        Me.BreakDeductedCheckBox = New System.Windows.Forms.CheckBox()
        Me.CNightsOutTextBox = New System.Windows.Forms.TextBox()
        Me.C4SaturdayTextBox = New System.Windows.Forms.TextBox()
        Me.BreakEntitlementTextBox = New System.Windows.Forms.TextBox()
        Me.C2BankHolTextBox = New System.Windows.Forms.TextBox()
        Me.C3SundayTextBox = New System.Windows.Forms.TextBox()
        Me.TypicalEndTimeTextBox = New System.Windows.Forms.TextBox()
        Me.C4OT3TextBox = New System.Windows.Forms.TextBox()
        Me.CBankHolTextBox = New System.Windows.Forms.TextBox()
        Me.TypicalStartTimeTextBox = New System.Windows.Forms.TextBox()
        Me.C2SundayTextBox = New System.Windows.Forms.TextBox()
        Me.C4OT2TextBox = New System.Windows.Forms.TextBox()
        Me.ShiftNameTextBox = New System.Windows.Forms.TextBox()
        Me.C3SaturdayTextBox = New System.Windows.Forms.TextBox()
        Me.C4OT1TextBox = New System.Windows.Forms.TextBox()
        Me.JobCategoryTextBox = New System.Windows.Forms.TextBox()
        Me.C3OT3TextBox = New System.Windows.Forms.TextBox()
        Me.C4BasicPayTextBox = New System.Windows.Forms.TextBox()
        Me.PBasicPayTextBox = New System.Windows.Forms.TextBox()
        Me.C2SaturdayTextBox = New System.Windows.Forms.TextBox()
        Me.P4NightsOutTextBox = New System.Windows.Forms.TextBox()
        Me.C3OT2TextBox = New System.Windows.Forms.TextBox()
        Me.POT1TextBox = New System.Windows.Forms.TextBox()
        Me.P4BankHolTextBox = New System.Windows.Forms.TextBox()
        Me.CSundayTextBox = New System.Windows.Forms.TextBox()
        Me.C3OT1TextBox = New System.Windows.Forms.TextBox()
        Me.P4SundayTextBox = New System.Windows.Forms.TextBox()
        Me.C2OT3TextBox = New System.Windows.Forms.TextBox()
        Me.POT2TextBox = New System.Windows.Forms.TextBox()
        Me.P4SaturdayTextBox = New System.Windows.Forms.TextBox()
        Me.C3BasicPayTextBox = New System.Windows.Forms.TextBox()
        Me.POT3TextBox = New System.Windows.Forms.TextBox()
        Me.P4OT3TextBox = New System.Windows.Forms.TextBox()
        Me.C2OT2TextBox = New System.Windows.Forms.TextBox()
        Me.P3NightsOutTextBox = New System.Windows.Forms.TextBox()
        Me.P4OT2TextBox = New System.Windows.Forms.TextBox()
        Me.PSaturdayTextBox = New System.Windows.Forms.TextBox()
        Me.CSaturdayTextBox = New System.Windows.Forms.TextBox()
        Me.P4OT1TextBox = New System.Windows.Forms.TextBox()
        Me.P3BankHolTextBox = New System.Windows.Forms.TextBox()
        Me.C2OT1TextBox = New System.Windows.Forms.TextBox()
        Me.P4BasicPayTextBox = New System.Windows.Forms.TextBox()
        Me.PSundayTextBox = New System.Windows.Forms.TextBox()
        Me.P3SundayTextBox = New System.Windows.Forms.TextBox()
        Me.PBankHolTextBox = New System.Windows.Forms.TextBox()
        Me.C2BasicPayTextBox = New System.Windows.Forms.TextBox()
        Me.P3SaturdayTextBox = New System.Windows.Forms.TextBox()
        Me.COT3TextBox = New System.Windows.Forms.TextBox()
        Me.PNightsOutTextBox = New System.Windows.Forms.TextBox()
        Me.P3OT3TextBox = New System.Windows.Forms.TextBox()
        Me.P2NightsOutTextBox = New System.Windows.Forms.TextBox()
        Me.CBasicPayTextBox = New System.Windows.Forms.TextBox()
        Me.P3OT2TextBox = New System.Windows.Forms.TextBox()
        Me.COT2TextBox = New System.Windows.Forms.TextBox()
        Me.P2BankHolTextBox = New System.Windows.Forms.TextBox()
        Me.P3OT1TextBox = New System.Windows.Forms.TextBox()
        Me.COT1TextBox = New System.Windows.Forms.TextBox()
        Me.P2BasicPayTextBox = New System.Windows.Forms.TextBox()
        Me.P3BasicPayTextBox = New System.Windows.Forms.TextBox()
        Me.P2SundayTextBox = New System.Windows.Forms.TextBox()
        Me.P2OT1TextBox = New System.Windows.Forms.TextBox()
        Me.P2OT2TextBox = New System.Windows.Forms.TextBox()
        Me.P2SaturdayTextBox = New System.Windows.Forms.TextBox()
        Me.P2OT3TextBox = New System.Windows.Forms.TextBox()
        Me.HoursPerShift = New DevExpress.XtraEditors.CalcEdit()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem42 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem43 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem44 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem46 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem48 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem47 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem49 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem50 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem51 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem52 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem53 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem54 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem55 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem56 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem57 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem58 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup9 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup10 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem59 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem60 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem61 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem62 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem63 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem64 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem65 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem66 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup11 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem68 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem67 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem69 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem70 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem71 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem72 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem73 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem74 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem75 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup12 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup13 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem79 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem78 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem77 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem76 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem80 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem81 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem82 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem83 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup14 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem85 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem84 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem86 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem87 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem88 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem89 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem90 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem91 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem92 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup15 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup16 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem100 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem98 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem99 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem97 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem96 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem95 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem94 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem93 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup17 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem108 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem107 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem106 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem105 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem103 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem104 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem102 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem101 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem109 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem112 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem110 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem113 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem114 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem115 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem116 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem117 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem118 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem119 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem120 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem121 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem122 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem123 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem124 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem125 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem126 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem127 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem128 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem129 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SplitterItem2 = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutControlItem131 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem130 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem160 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem159 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem165 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.LayoutControl6 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ClientStatusTextEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ClientStatusReasonTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControlGroup20 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup21 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem156 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem157 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup22 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem155 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.JobCategoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SitesTableAdapter1 = New Lexrecmgr.SitesTableAdapters.SitesTableAdapter()
        Me.CompanyContactsTableAdapter1 = New Lexrecmgr.SitesTableAdapters.CompanyContactsTableAdapter()
        Me.JobCategoryTableAdapter1 = New Lexrecmgr.SitesTableAdapters.JobCategoryTableAdapter()
        Me.TableAdapterManager1 = New Lexrecmgr.SitesTableAdapters.TableAdapterManager()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SitesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCompanyID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientStatusReason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranchID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLtd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPLC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSoleTrader = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSwedishderogationPureContracted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPayParityPureEmbrace = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStartOfWeek = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOther = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConvertedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyRegNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClientsVatRegNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBaseLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelephone1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelephone2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTown = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCounty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceTo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvTown = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvCounty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvPostCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoicingMethod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderNumberReq = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSpecialInvoiceInstructions = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDNI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreditLimit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTerms = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCanteenAvailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSmokingAreaAvailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParkingAvailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOtherFacilities = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHolidayEntitlement = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHowArePermanentVacanciesDisplayed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTempsUsed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanySize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoEmployees = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAgenciesUsed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMemo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArchive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderNumberReq1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvAddress2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ConsultantsTableAdapter = New Lexrecmgr.LexiconManagemnetToolsDataSetTableAdapters.ConsultantsTableAdapter()
        Me.CompanyContactsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.BanksTableAdapter = New Lexrecmgr.SitesTableAdapters.BanksTableAdapter()
        SwedishderogationPureContractedLabel = New System.Windows.Forms.Label()
        CType(Me.SitesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SitesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SitesBindingNavigator.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GLAClientCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKCompanyContactsSitesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyContactsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexiconManagemnetToolsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreatedByTimeEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreatedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LastModifiedUserTimeEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LastModifiedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem158, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem161, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem162, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem163, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem164, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem168, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.InvoicingMethodTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POtypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BanksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sites1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem167, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem166, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.asdas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl4.SuspendLayout()
        CType(Me.LayoutControlGroup18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem111, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem132, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem133, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem134, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem135, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem136, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.LayoutControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl5.SuspendLayout()
        CType(Me.LayoutControlGroup19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem137, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem138, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem139, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem140, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem141, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem142, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem143, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem144, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem145, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem146, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem147, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem148, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem149, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem150, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem151, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem152, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem153, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem154, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage10.SuspendLayout()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.FKJobCategorySitesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArchiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobCatIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.MemoEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoursPerShift.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem70, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem72, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem73, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem75, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem79, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem78, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem77, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem76, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem80, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem82, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem83, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem85, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem84, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem86, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem87, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem88, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem89, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem90, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem91, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem92, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem98, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem99, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem97, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem96, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem95, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem94, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem93, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem108, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem107, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem106, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem105, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem103, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem104, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem102, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem101, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem109, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem112, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem110, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem113, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem114, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem115, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem116, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem117, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem118, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem119, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem120, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem121, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem122, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem123, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem124, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem125, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem126, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem127, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem128, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem129, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem131, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem130, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem160, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem159, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem165, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.LayoutControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl6.SuspendLayout()
        CType(Me.ClientStatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientStatusReasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem156, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem157, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem155, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobCategoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SitesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyContactsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SwedishderogationPureContractedLabel
        '
        SwedishderogationPureContractedLabel.Location = New System.Drawing.Point(16, 285)
        SwedishderogationPureContractedLabel.Name = "SwedishderogationPureContractedLabel"
        SwedishderogationPureContractedLabel.Size = New System.Drawing.Size(1543, 19)
        SwedishderogationPureContractedLabel.TabIndex = 1
        SwedishderogationPureContractedLabel.Text = "Contract Type:"
        '
        'SitesBindingSource
        '
        Me.SitesBindingSource.DataMember = "Sites"
        Me.SitesBindingSource.DataSource = Me.Sites
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
        Me.TableAdapterManager.CompanyContactsTableAdapter = Me.CompanyContactsTableAdapter
        Me.TableAdapterManager.ControlsTableAdapter = Nothing
        Me.TableAdapterManager.CountersTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesBranchFilterTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeSelect1TableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.HolidaysTableAdapter = Nothing
        Me.TableAdapterManager.Import_EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.JobCategoryTableAdapter = Me.JobCategoryTableAdapter
        Me.TableAdapterManager.Plan1TableAdapter = Nothing
        Me.TableAdapterManager.Plan2PerRecordTableAdapter = Nothing
        Me.TableAdapterManager.PlanInvoiceTableAdapter = Nothing
        Me.TableAdapterManager.PlanTableAdapter = Nothing
        Me.TableAdapterManager.PlanTypesTableAdapter = Nothing
        Me.TableAdapterManager.SchemesTableAdapter = Nothing
        Me.TableAdapterManager.SitesTableAdapter = Me.SitesTableAdapter
        Me.TableAdapterManager.uk_postcodesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Lexrecmgr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.WeeknumbersTableAdapter = Nothing
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'CompanyContactsTableAdapter
        '
        Me.CompanyContactsTableAdapter.ClearBeforeFill = True
        '
        'JobCategoryTableAdapter
        '
        Me.JobCategoryTableAdapter.ClearBeforeFill = True
        '
        'SitesBindingNavigator
        '
        Me.SitesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SitesBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.SitesBindingNavigator.BindingSource = Me.SitesBindingSource
        Me.SitesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SitesBindingNavigator.DeleteItem = Nothing
        Me.SitesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.ToolStripTextBox1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SitesBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.SitesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SitesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SitesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SitesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SitesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SitesBindingNavigator.Name = "SitesBindingNavigator"
        Me.SitesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SitesBindingNavigator.Size = New System.Drawing.Size(1589, 27)
        Me.SitesBindingNavigator.TabIndex = 4
        Me.SitesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(116, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Enabled = False
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'SitesBindingNavigatorSaveItem
        '
        Me.SitesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SitesBindingNavigatorSaveItem.Image = CType(resources.GetObject("SitesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SitesBindingNavigatorSaveItem.Name = "SitesBindingNavigatorSaveItem"
        Me.SitesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.SitesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage10)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1589, 693)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.LayoutControl1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(1581, 661)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GLAClientCheckEdit)
        Me.LayoutControl1.Controls.Add(Me.DataNavigator1)
        Me.LayoutControl1.Controls.Add(Me.CompanyContactsGridControl)
        Me.LayoutControl1.Controls.Add(Me.DNICheckBox)
        Me.LayoutControl1.Controls.Add(Me.BranchIDComboBox)
        Me.LayoutControl1.Controls.Add(Me.OtherTextBox)
        Me.LayoutControl1.Controls.Add(Me.CompanyNameTextBox)
        Me.LayoutControl1.Controls.Add(Me.ClientCodeTextBox)
        Me.LayoutControl1.Controls.Add(Me.CreditLimitTextBox)
        Me.LayoutControl1.Controls.Add(Me.CompanyRegNumberTextBox)
        Me.LayoutControl1.Controls.Add(Me.LtdCheckBox)
        Me.LayoutControl1.Controls.Add(Me.TermsTextBox)
        Me.LayoutControl1.Controls.Add(Me.SpecialInvoiceInstructionsRichTextBox)
        Me.LayoutControl1.Controls.Add(Me.TBCompanyId)
        Me.LayoutControl1.Controls.Add(Me.PLCCheckBox)
        Me.LayoutControl1.Controls.Add(SwedishderogationPureContractedLabel)
        Me.LayoutControl1.Controls.Add(Me.ComboBox2)
        Me.LayoutControl1.Controls.Add(Me.SoleTraderCheckBox)
        Me.LayoutControl1.Controls.Add(Me.PayParityPureEmbraceCheckBox)
        Me.LayoutControl1.Controls.Add(Me.SwedishderogationPureContractedCheckBox)
        Me.LayoutControl1.Controls.Add(Me.NotesRichTextBox)
        Me.LayoutControl1.Controls.Add(Me.CreatedByTimeEdit)
        Me.LayoutControl1.Controls.Add(Me.CreatedDateDateEdit)
        Me.LayoutControl1.Controls.Add(Me.LastModifiedUserTimeEdit)
        Me.LayoutControl1.Controls.Add(Me.LastModifiedDateDateEdit)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(3, 4)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(475, 196, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1575, 653)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GLAClientCheckEdit
        '
        Me.GLAClientCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SitesBindingSource, "GLAClient", True))
        Me.GLAClientCheckEdit.Location = New System.Drawing.Point(855, 310)
        Me.GLAClientCheckEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GLAClientCheckEdit.Name = "GLAClientCheckEdit"
        Me.GLAClientCheckEdit.Properties.Caption = "GLA Client"
        Me.GLAClientCheckEdit.Size = New System.Drawing.Size(704, 20)
        Me.GLAClientCheckEdit.StyleController = Me.LayoutControl1
        Me.GLAClientCheckEdit.TabIndex = 14
        '
        'DataNavigator1
        '
        Me.DataNavigator1.Buttons.CancelEdit.Visible = False
        Me.DataNavigator1.Buttons.EndEdit.Visible = False
        Me.DataNavigator1.DataSource = Me.CompanyContactsBindingSource
        Me.DataNavigator1.Location = New System.Drawing.Point(16, 423)
        Me.DataNavigator1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataNavigator1.Name = "DataNavigator1"
        Me.DataNavigator1.Size = New System.Drawing.Size(1543, 69)
        Me.DataNavigator1.StyleController = Me.LayoutControl1
        Me.DataNavigator1.TabIndex = 1
        Me.DataNavigator1.Text = "DataNavigator1"
        '
        'CompanyContactsBindingSource
        '
        Me.CompanyContactsBindingSource.DataSource = Me.FKCompanyContactsSitesBindingSource
        '
        'FKCompanyContactsSitesBindingSource
        '
        Me.FKCompanyContactsSitesBindingSource.DataMember = "FK_CompanyContacts_Sites"
        Me.FKCompanyContactsSitesBindingSource.DataSource = Me.SitesBindingSource
        '
        'CompanyContactsGridControl
        '
        Me.CompanyContactsGridControl.DataSource = Me.CompanyContactsBindingSource
        Me.CompanyContactsGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.CompanyContactsGridControl.Location = New System.Drawing.Point(16, 517)
        Me.CompanyContactsGridControl.MainView = Me.GridView2
        Me.CompanyContactsGridControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CompanyContactsGridControl.Name = "CompanyContactsGridControl"
        Me.CompanyContactsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1})
        Me.CompanyContactsGridControl.Size = New System.Drawing.Size(1543, 120)
        Me.CompanyContactsGridControl.TabIndex = 23
        Me.CompanyContactsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colForename, Me.colSurname, Me.colDepartment1, Me.colJobTitle, Me.colTelephone21, Me.colTelephone, Me.colEmail1, Me.colFax1, Me.colActive1, Me.colNotes1})
        Me.GridView2.GridControl = Me.CompanyContactsGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colForename
        '
        Me.colForename.FieldName = "Forename"
        Me.colForename.Name = "colForename"
        Me.colForename.Visible = True
        Me.colForename.VisibleIndex = 0
        '
        'colSurname
        '
        Me.colSurname.FieldName = "Surname"
        Me.colSurname.Name = "colSurname"
        Me.colSurname.Visible = True
        Me.colSurname.VisibleIndex = 1
        '
        'colDepartment1
        '
        Me.colDepartment1.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colDepartment1.DisplayFormat.FormatString = "Contact Type:"
        Me.colDepartment1.FieldName = "Department"
        Me.colDepartment1.Name = "colDepartment1"
        Me.colDepartment1.Visible = True
        Me.colDepartment1.VisibleIndex = 2
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoComplete = False
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"TC1", "TC2", "MAN", "INV", "PO", "H&S"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colJobTitle
        '
        Me.colJobTitle.FieldName = "JobTitle"
        Me.colJobTitle.Name = "colJobTitle"
        Me.colJobTitle.Visible = True
        Me.colJobTitle.VisibleIndex = 3
        '
        'colTelephone21
        '
        Me.colTelephone21.DisplayFormat.FormatString = "Mobile:"
        Me.colTelephone21.FieldName = "Telephone2"
        Me.colTelephone21.Name = "colTelephone21"
        Me.colTelephone21.Visible = True
        Me.colTelephone21.VisibleIndex = 7
        '
        'colTelephone
        '
        Me.colTelephone.FieldName = "Telephone"
        Me.colTelephone.Name = "colTelephone"
        Me.colTelephone.Visible = True
        Me.colTelephone.VisibleIndex = 4
        '
        'colEmail1
        '
        Me.colEmail1.FieldName = "Email"
        Me.colEmail1.Name = "colEmail1"
        Me.colEmail1.Visible = True
        Me.colEmail1.VisibleIndex = 5
        '
        'colFax1
        '
        Me.colFax1.FieldName = "Fax"
        Me.colFax1.Name = "colFax1"
        Me.colFax1.Visible = True
        Me.colFax1.VisibleIndex = 6
        '
        'colActive1
        '
        Me.colActive1.FieldName = "Active"
        Me.colActive1.Name = "colActive1"
        Me.colActive1.Visible = True
        Me.colActive1.VisibleIndex = 8
        '
        'colNotes1
        '
        Me.colNotes1.FieldName = "Notes"
        Me.colNotes1.Name = "colNotes1"
        Me.colNotes1.Visible = True
        Me.colNotes1.VisibleIndex = 9
        '
        'DNICheckBox
        '
        Me.DNICheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "DNI", True))
        Me.DNICheckBox.Location = New System.Drawing.Point(790, 341)
        Me.DNICheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DNICheckBox.Name = "DNICheckBox"
        Me.DNICheckBox.Size = New System.Drawing.Size(769, 25)
        Me.DNICheckBox.TabIndex = 16
        Me.DNICheckBox.Text = "DNI"
        Me.DNICheckBox.UseVisualStyleBackColor = True
        '
        'BranchIDComboBox
        '
        Me.BranchIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SitesBindingSource, "BranchID", True))
        Me.BranchIDComboBox.DataSource = Me.BranchBindingSource
        Me.BranchIDComboBox.DisplayMember = "Branch"
        Me.BranchIDComboBox.FormattingEnabled = True
        Me.BranchIDComboBox.Location = New System.Drawing.Point(179, 47)
        Me.BranchIDComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BranchIDComboBox.Name = "BranchIDComboBox"
        Me.BranchIDComboBox.Size = New System.Drawing.Size(348, 24)
        Me.BranchIDComboBox.TabIndex = 3
        Me.BranchIDComboBox.ValueMember = "BranchID"
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'LexiconRecManagerDataSet
        '
        Me.LexiconRecManagerDataSet.DataSetName = "LexiconRecManagerDataSet"
        Me.LexiconRecManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OtherTextBox
        '
        Me.OtherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "Other", True))
        Me.OtherTextBox.Location = New System.Drawing.Point(179, 341)
        Me.OtherTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OtherTextBox.Name = "OtherTextBox"
        Me.OtherTextBox.Size = New System.Drawing.Size(605, 25)
        Me.OtherTextBox.TabIndex = 15
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "CompanyName", True))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(179, 16)
        Me.CompanyNameTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(348, 25)
        Me.CompanyNameTextBox.TabIndex = 0
        '
        'ClientCodeTextBox
        '
        Me.ClientCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "ClientCode", True))
        Me.ClientCodeTextBox.Location = New System.Drawing.Point(696, 16)
        Me.ClientCodeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ClientCodeTextBox.Name = "ClientCodeTextBox"
        Me.ClientCodeTextBox.Size = New System.Drawing.Size(863, 25)
        Me.ClientCodeTextBox.TabIndex = 2
        '
        'CreditLimitTextBox
        '
        Me.CreditLimitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "CreditLimit", True))
        Me.CreditLimitTextBox.Location = New System.Drawing.Point(696, 109)
        Me.CreditLimitTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CreditLimitTextBox.Name = "CreditLimitTextBox"
        Me.CreditLimitTextBox.Size = New System.Drawing.Size(863, 25)
        Me.CreditLimitTextBox.TabIndex = 7
        '
        'CompanyRegNumberTextBox
        '
        Me.CompanyRegNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "CompanyRegNumber", True))
        Me.CompanyRegNumberTextBox.Location = New System.Drawing.Point(696, 47)
        Me.CompanyRegNumberTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CompanyRegNumberTextBox.Name = "CompanyRegNumberTextBox"
        Me.CompanyRegNumberTextBox.Size = New System.Drawing.Size(863, 25)
        Me.CompanyRegNumberTextBox.TabIndex = 4
        '
        'LtdCheckBox
        '
        Me.LtdCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "Ltd", True))
        Me.LtdCheckBox.Location = New System.Drawing.Point(16, 79)
        Me.LtdCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LtdCheckBox.Name = "LtdCheckBox"
        Me.LtdCheckBox.Size = New System.Drawing.Size(511, 25)
        Me.LtdCheckBox.TabIndex = 6
        Me.LtdCheckBox.Text = "Ltd"
        Me.LtdCheckBox.UseVisualStyleBackColor = True
        '
        'TermsTextBox
        '
        Me.TermsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "Terms", True))
        Me.TermsTextBox.Location = New System.Drawing.Point(696, 78)
        Me.TermsTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TermsTextBox.Name = "TermsTextBox"
        Me.TermsTextBox.Size = New System.Drawing.Size(863, 25)
        Me.TermsTextBox.TabIndex = 5
        '
        'SpecialInvoiceInstructionsRichTextBox
        '
        Me.SpecialInvoiceInstructionsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "SpecialInvoiceInstructions", True))
        Me.SpecialInvoiceInstructionsRichTextBox.Location = New System.Drawing.Point(179, 226)
        Me.SpecialInvoiceInstructionsRichTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SpecialInvoiceInstructionsRichTextBox.Name = "SpecialInvoiceInstructionsRichTextBox"
        Me.SpecialInvoiceInstructionsRichTextBox.Size = New System.Drawing.Size(1380, 50)
        Me.SpecialInvoiceInstructionsRichTextBox.TabIndex = 11
        Me.SpecialInvoiceInstructionsRichTextBox.Text = ""
        '
        'TBCompanyId
        '
        Me.TBCompanyId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "CompanyID", True))
        Me.TBCompanyId.Location = New System.Drawing.Point(182, 391)
        Me.TBCompanyId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBCompanyId.Name = "TBCompanyId"
        Me.TBCompanyId.ReadOnly = True
        Me.TBCompanyId.Size = New System.Drawing.Size(160, 25)
        Me.TBCompanyId.TabIndex = 18
        '
        'PLCCheckBox
        '
        Me.PLCCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "PLC", True))
        Me.PLCCheckBox.Location = New System.Drawing.Point(16, 110)
        Me.PLCCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PLCCheckBox.Name = "PLCCheckBox"
        Me.PLCCheckBox.Size = New System.Drawing.Size(511, 25)
        Me.PLCCheckBox.TabIndex = 8
        Me.PLCCheckBox.Text = "PLC"
        Me.PLCCheckBox.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "ConvertedBy", True))
        Me.ComboBox2.DataSource = Me.ConsultantsBindingSource
        Me.ComboBox2.DisplayMember = "ConsultantCode"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(16, 391)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox2.TabIndex = 17
        Me.ComboBox2.ValueMember = "ConsultantCode"
        '
        'ConsultantsBindingSource
        '
        Me.ConsultantsBindingSource.DataMember = "Consultants"
        Me.ConsultantsBindingSource.DataSource = Me.LexiconManagemnetToolsDataSet
        '
        'LexiconManagemnetToolsDataSet
        '
        Me.LexiconManagemnetToolsDataSet.DataSetName = "LexiconManagemnetToolsDataSet"
        Me.LexiconManagemnetToolsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SoleTraderCheckBox
        '
        Me.SoleTraderCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "SoleTrader", True))
        Me.SoleTraderCheckBox.Location = New System.Drawing.Point(16, 141)
        Me.SoleTraderCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SoleTraderCheckBox.Name = "SoleTraderCheckBox"
        Me.SoleTraderCheckBox.Size = New System.Drawing.Size(511, 25)
        Me.SoleTraderCheckBox.TabIndex = 9
        Me.SoleTraderCheckBox.Text = "Sole Trader"
        Me.SoleTraderCheckBox.UseVisualStyleBackColor = True
        '
        'PayParityPureEmbraceCheckBox
        '
        Me.PayParityPureEmbraceCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "PayParityPureEmbrace", True))
        Me.PayParityPureEmbraceCheckBox.Location = New System.Drawing.Point(16, 310)
        Me.PayParityPureEmbraceCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PayParityPureEmbraceCheckBox.Name = "PayParityPureEmbraceCheckBox"
        Me.PayParityPureEmbraceCheckBox.Size = New System.Drawing.Size(510, 25)
        Me.PayParityPureEmbraceCheckBox.TabIndex = 12
        Me.PayParityPureEmbraceCheckBox.Text = "Pay Parity/Pure Embrace"
        Me.PayParityPureEmbraceCheckBox.UseVisualStyleBackColor = True
        '
        'SwedishderogationPureContractedCheckBox
        '
        Me.SwedishderogationPureContractedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "SwedishderogationPureContracted", True))
        Me.SwedishderogationPureContractedCheckBox.Location = New System.Drawing.Point(532, 310)
        Me.SwedishderogationPureContractedCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SwedishderogationPureContractedCheckBox.Name = "SwedishderogationPureContractedCheckBox"
        Me.SwedishderogationPureContractedCheckBox.Size = New System.Drawing.Size(317, 25)
        Me.SwedishderogationPureContractedCheckBox.TabIndex = 13
        Me.SwedishderogationPureContractedCheckBox.Text = "Swedish Derogation/Pure Contracted"
        Me.SwedishderogationPureContractedCheckBox.UseVisualStyleBackColor = True
        '
        'NotesRichTextBox
        '
        Me.NotesRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "Notes", True))
        Me.NotesRichTextBox.Location = New System.Drawing.Point(179, 172)
        Me.NotesRichTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NotesRichTextBox.Name = "NotesRichTextBox"
        Me.NotesRichTextBox.Size = New System.Drawing.Size(1380, 48)
        Me.NotesRichTextBox.TabIndex = 10
        Me.NotesRichTextBox.Text = ""
        '
        'CreatedByTimeEdit
        '
        Me.CreatedByTimeEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SitesBindingSource, "CreatedBy", True))
        Me.CreatedByTimeEdit.EditValue = ""
        Me.CreatedByTimeEdit.Enabled = False
        Me.CreatedByTimeEdit.Location = New System.Drawing.Point(348, 391)
        Me.CreatedByTimeEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CreatedByTimeEdit.Name = "CreatedByTimeEdit"
        Me.CreatedByTimeEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.CreatedByTimeEdit.Properties.Mask.EditMask = "T"
        Me.CreatedByTimeEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.CreatedByTimeEdit.Size = New System.Drawing.Size(325, 22)
        Me.CreatedByTimeEdit.StyleController = Me.LayoutControl1
        Me.CreatedByTimeEdit.TabIndex = 19
        '
        'CreatedDateDateEdit
        '
        Me.CreatedDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SitesBindingSource, "CreatedDate", True))
        Me.CreatedDateDateEdit.Enabled = False
        Me.CreatedDateDateEdit.Location = New System.Drawing.Point(679, 391)
        Me.CreatedDateDateEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CreatedDateDateEdit.Name = "CreatedDateDateEdit"
        Me.CreatedDateDateEdit.Properties.DisplayFormat.FormatString = "d"
        Me.CreatedDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.CreatedDateDateEdit.Properties.EditFormat.FormatString = "d"
        Me.CreatedDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.CreatedDateDateEdit.Properties.Mask.EditMask = "d"
        Me.CreatedDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.CreatedDateDateEdit.Size = New System.Drawing.Size(239, 22)
        Me.CreatedDateDateEdit.StyleController = Me.LayoutControl1
        Me.CreatedDateDateEdit.TabIndex = 20
        '
        'LastModifiedUserTimeEdit
        '
        Me.LastModifiedUserTimeEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SitesBindingSource, "LastModifiedUser", True))
        Me.LastModifiedUserTimeEdit.EditValue = ""
        Me.LastModifiedUserTimeEdit.Enabled = False
        Me.LastModifiedUserTimeEdit.Location = New System.Drawing.Point(924, 391)
        Me.LastModifiedUserTimeEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LastModifiedUserTimeEdit.Name = "LastModifiedUserTimeEdit"
        Me.LastModifiedUserTimeEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.LastModifiedUserTimeEdit.Properties.Mask.EditMask = "T"
        Me.LastModifiedUserTimeEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.LastModifiedUserTimeEdit.Size = New System.Drawing.Size(319, 22)
        Me.LastModifiedUserTimeEdit.StyleController = Me.LayoutControl1
        Me.LastModifiedUserTimeEdit.TabIndex = 21
        '
        'LastModifiedDateDateEdit
        '
        Me.LastModifiedDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SitesBindingSource, "LastModifiedDate", True))
        Me.LastModifiedDateDateEdit.Enabled = False
        Me.LastModifiedDateDateEdit.Location = New System.Drawing.Point(1249, 391)
        Me.LastModifiedDateDateEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LastModifiedDateDateEdit.Name = "LastModifiedDateDateEdit"
        Me.LastModifiedDateDateEdit.Properties.DisplayFormat.FormatString = "d"
        Me.LastModifiedDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.LastModifiedDateDateEdit.Properties.EditFormat.FormatString = "d"
        Me.LastModifiedDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.LastModifiedDateDateEdit.Properties.Mask.EditMask = "d"
        Me.LastModifiedDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.LastModifiedDateDateEdit.Size = New System.Drawing.Size(310, 22)
        Me.LastModifiedDateDateEdit.StyleController = Me.LayoutControl1
        Me.LastModifiedDateDateEdit.TabIndex = 22
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem15, Me.SimpleSeparator1, Me.LayoutControlItem14, Me.LayoutControlItem19, Me.LayoutControlItem18, Me.LayoutControlItem16, Me.LayoutControlItem20, Me.LayoutControlItem158, Me.LayoutControlItem161, Me.LayoutControlItem162, Me.LayoutControlItem17, Me.LayoutControlItem163, Me.LayoutControlItem164, Me.LayoutControlItem168})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1575, 653)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.CompanyNameTextBox
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(517, 31)
        Me.LayoutControlItem1.Text = "Company Name:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(160, 16)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.BranchIDComboBox
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(517, 32)
        Me.LayoutControlItem2.Text = "Branch"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(160, 16)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.ClientCodeTextBox
        Me.LayoutControlItem3.Location = New System.Drawing.Point(517, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1032, 31)
        Me.LayoutControlItem3.Text = "Client Code:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(160, 16)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.CompanyRegNumberTextBox
        Me.LayoutControlItem4.Location = New System.Drawing.Point(517, 31)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(1032, 31)
        Me.LayoutControlItem4.Text = "Company Reg No:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(160, 16)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.LtdCheckBox
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 63)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(517, 31)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.PLCCheckBox
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 94)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(517, 31)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SoleTraderCheckBox
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 125)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(517, 31)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.TermsTextBox
        Me.LayoutControlItem9.Location = New System.Drawing.Point(517, 62)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(1032, 31)
        Me.LayoutControlItem9.Text = "Terms"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(160, 16)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.CreditLimitTextBox
        Me.LayoutControlItem10.Location = New System.Drawing.Point(517, 93)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(1032, 63)
        Me.LayoutControlItem10.Text = "Credit Limit:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(160, 16)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.NotesRichTextBox
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 156)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(0, 54)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(163, 54)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(1549, 54)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.Text = "Action Points:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(160, 16)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.SpecialInvoiceInstructionsRichTextBox
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(0, 56)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(163, 56)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(1549, 56)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "Special Invoice Instructions:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(160, 16)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = SwedishderogationPureContractedLabel
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 269)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(0, 25)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(24, 25)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(1549, 25)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.PayParityPureEmbraceCheckBox
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 294)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(516, 31)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 266)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(1549, 3)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.SwedishderogationPureContractedCheckBox
        Me.LayoutControlItem14.Location = New System.Drawing.Point(516, 294)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(323, 31)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.TBCompanyId
        Me.LayoutControlItem19.Location = New System.Drawing.Point(166, 356)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(166, 51)
        Me.LayoutControlItem19.Text = "CompanyId"
        Me.LayoutControlItem19.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(160, 16)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.ComboBox2
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 356)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(166, 51)
        Me.LayoutControlItem18.Text = "Converted By:"
        Me.LayoutControlItem18.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(160, 16)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.OtherTextBox
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 325)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(774, 31)
        Me.LayoutControlItem16.Text = "Other"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(160, 16)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.CompanyContactsGridControl
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 482)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(1549, 145)
        Me.LayoutControlItem20.Text = "Contacts"
        Me.LayoutControlItem20.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(160, 16)
        '
        'LayoutControlItem158
        '
        Me.LayoutControlItem158.Control = Me.DataNavigator1
        Me.LayoutControlItem158.Location = New System.Drawing.Point(0, 407)
        Me.LayoutControlItem158.MinSize = New System.Drawing.Size(166, 23)
        Me.LayoutControlItem158.Name = "LayoutControlItem158"
        Me.LayoutControlItem158.Size = New System.Drawing.Size(1549, 75)
        Me.LayoutControlItem158.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem158.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem158.TextVisible = False
        '
        'LayoutControlItem161
        '
        Me.LayoutControlItem161.Control = Me.CreatedByTimeEdit
        Me.LayoutControlItem161.Location = New System.Drawing.Point(332, 356)
        Me.LayoutControlItem161.Name = "LayoutControlItem161"
        Me.LayoutControlItem161.Size = New System.Drawing.Size(331, 51)
        Me.LayoutControlItem161.Text = "Created By:"
        Me.LayoutControlItem161.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem161.TextSize = New System.Drawing.Size(160, 16)
        '
        'LayoutControlItem162
        '
        Me.LayoutControlItem162.Control = Me.CreatedDateDateEdit
        Me.LayoutControlItem162.Location = New System.Drawing.Point(663, 356)
        Me.LayoutControlItem162.Name = "LayoutControlItem162"
        Me.LayoutControlItem162.Size = New System.Drawing.Size(245, 51)
        Me.LayoutControlItem162.Text = "Created Date:"
        Me.LayoutControlItem162.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem162.TextSize = New System.Drawing.Size(160, 16)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.DNICheckBox
        Me.LayoutControlItem17.Location = New System.Drawing.Point(774, 325)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(775, 31)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem163
        '
        Me.LayoutControlItem163.Control = Me.LastModifiedDateDateEdit
        Me.LayoutControlItem163.Location = New System.Drawing.Point(1233, 356)
        Me.LayoutControlItem163.Name = "LayoutControlItem163"
        Me.LayoutControlItem163.Size = New System.Drawing.Size(316, 51)
        Me.LayoutControlItem163.Text = "Last Modified Date:"
        Me.LayoutControlItem163.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem163.TextSize = New System.Drawing.Size(160, 16)
        '
        'LayoutControlItem164
        '
        Me.LayoutControlItem164.Control = Me.LastModifiedUserTimeEdit
        Me.LayoutControlItem164.Location = New System.Drawing.Point(908, 356)
        Me.LayoutControlItem164.Name = "LayoutControlItem164"
        Me.LayoutControlItem164.Size = New System.Drawing.Size(325, 51)
        Me.LayoutControlItem164.Text = "Last Modified User:"
        Me.LayoutControlItem164.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem164.TextSize = New System.Drawing.Size(160, 16)
        '
        'LayoutControlItem168
        '
        Me.LayoutControlItem168.Control = Me.GLAClientCheckEdit
        Me.LayoutControlItem168.Location = New System.Drawing.Point(839, 294)
        Me.LayoutControlItem168.Name = "LayoutControlItem168"
        Me.LayoutControlItem168.Size = New System.Drawing.Size(710, 31)
        Me.LayoutControlItem168.Text = "GLAClient:"
        Me.LayoutControlItem168.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem168.TextVisible = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.LayoutControl2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Size = New System.Drawing.Size(1581, 661)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Accounts"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.InvoicingMethodTextBox)
        Me.LayoutControl2.Controls.Add(Me.AddressTextBox)
        Me.LayoutControl2.Controls.Add(Me.Address2TextBox)
        Me.LayoutControl2.Controls.Add(Me.TownTextBox)
        Me.LayoutControl2.Controls.Add(Me.CountyComboBox)
        Me.LayoutControl2.Controls.Add(Me.CountryComboBox)
        Me.LayoutControl2.Controls.Add(Me.PostalCodeTextBox)
        Me.LayoutControl2.Controls.Add(Me.EmailTextBox)
        Me.LayoutControl2.Controls.Add(Me.Telephone1TextBox)
        Me.LayoutControl2.Controls.Add(Me.Telephone2TextBox)
        Me.LayoutControl2.Controls.Add(Me.FaxTextBox)
        Me.LayoutControl2.Controls.Add(Me.InvPostCodeTextBox)
        Me.LayoutControl2.Controls.Add(Me.InvCountryComboBox)
        Me.LayoutControl2.Controls.Add(Me.Button1)
        Me.LayoutControl2.Controls.Add(Me.InvCountyComboBox)
        Me.LayoutControl2.Controls.Add(Me.InvoiceToTextBox)
        Me.LayoutControl2.Controls.Add(Me.ArchiveCheckBox)
        Me.LayoutControl2.Controls.Add(Me.InvTownTextBox)
        Me.LayoutControl2.Controls.Add(Me.InvAddressTextBox)
        Me.LayoutControl2.Controls.Add(Me.OrderNumberReq1CheckBox)
        Me.LayoutControl2.Controls.Add(Me.Address3TextBox)
        Me.LayoutControl2.Controls.Add(Me.POtypeTextEdit)
        Me.LayoutControl2.Controls.Add(Me.BankIDSpinEdit)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem41})
        Me.LayoutControl2.Location = New System.Drawing.Point(3, 4)
        Me.LayoutControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(1575, 653)
        Me.LayoutControl2.TabIndex = 2
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'InvoicingMethodTextBox
        '
        Me.InvoicingMethodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "InvoicingMethod", True))
        Me.InvoicingMethodTextBox.Location = New System.Drawing.Point(928, 311)
        Me.InvoicingMethodTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InvoicingMethodTextBox.Name = "InvoicingMethodTextBox"
        Me.InvoicingMethodTextBox.Properties.AllowMouseWheel = False
        Me.InvoicingMethodTextBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InvoicingMethodTextBox.Properties.Items.AddRange(New Object() {"PO number", "Job Category", "Standard", "Per temp"})
        Me.InvoicingMethodTextBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.InvoicingMethodTextBox.Size = New System.Drawing.Size(616, 22)
        Me.InvoicingMethodTextBox.StyleController = Me.LayoutControl2
        Me.InvoicingMethodTextBox.TabIndex = 20
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(135, 92)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(653, 25)
        Me.AddressTextBox.TabIndex = 2
        '
        'Address2TextBox
        '
        Me.Address2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "Address2", True))
        Me.Address2TextBox.Location = New System.Drawing.Point(135, 123)
        Me.Address2TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Address2TextBox.Name = "Address2TextBox"
        Me.Address2TextBox.Size = New System.Drawing.Size(653, 25)
        Me.Address2TextBox.TabIndex = 3
        '
        'TownTextBox
        '
        Me.TownTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "Town", True))
        Me.TownTextBox.Location = New System.Drawing.Point(135, 154)
        Me.TownTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TownTextBox.Name = "TownTextBox"
        Me.TownTextBox.Size = New System.Drawing.Size(653, 25)
        Me.TownTextBox.TabIndex = 4
        '
        'CountyComboBox
        '
        Me.CountyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "County", True))
        Me.CountyComboBox.FormattingEnabled = True
        Me.CountyComboBox.Location = New System.Drawing.Point(135, 185)
        Me.CountyComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CountyComboBox.Name = "CountyComboBox"
        Me.CountyComboBox.Size = New System.Drawing.Size(653, 24)
        Me.CountyComboBox.TabIndex = 5
        '
        'CountryComboBox
        '
        Me.CountryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "Country", True))
        Me.CountryComboBox.FormattingEnabled = True
        Me.CountryComboBox.Location = New System.Drawing.Point(135, 217)
        Me.CountryComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CountryComboBox.Name = "CountryComboBox"
        Me.CountryComboBox.Size = New System.Drawing.Size(653, 24)
        Me.CountryComboBox.TabIndex = 6
        '
        'PostalCodeTextBox
        '
        Me.PostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "PostalCode", True))
        Me.PostalCodeTextBox.Location = New System.Drawing.Point(135, 249)
        Me.PostalCodeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PostalCodeTextBox.Name = "PostalCodeTextBox"
        Me.PostalCodeTextBox.Size = New System.Drawing.Size(653, 25)
        Me.PostalCodeTextBox.TabIndex = 7
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(135, 280)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(653, 25)
        Me.EmailTextBox.TabIndex = 8
        '
        'Telephone1TextBox
        '
        Me.Telephone1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "Telephone1", True))
        Me.Telephone1TextBox.Location = New System.Drawing.Point(135, 311)
        Me.Telephone1TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Telephone1TextBox.Name = "Telephone1TextBox"
        Me.Telephone1TextBox.Size = New System.Drawing.Size(653, 25)
        Me.Telephone1TextBox.TabIndex = 9
        '
        'Telephone2TextBox
        '
        Me.Telephone2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "Telephone2", True))
        Me.Telephone2TextBox.Location = New System.Drawing.Point(135, 342)
        Me.Telephone2TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Telephone2TextBox.Name = "Telephone2TextBox"
        Me.Telephone2TextBox.Size = New System.Drawing.Size(653, 25)
        Me.Telephone2TextBox.TabIndex = 10
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "Fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(135, 373)
        Me.FaxTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(653, 25)
        Me.FaxTextBox.TabIndex = 11
        '
        'InvPostCodeTextBox
        '
        Me.InvPostCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "InvPostCode", True))
        Me.InvPostCodeTextBox.Location = New System.Drawing.Point(928, 280)
        Me.InvPostCodeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InvPostCodeTextBox.Name = "InvPostCodeTextBox"
        Me.InvPostCodeTextBox.Size = New System.Drawing.Size(616, 25)
        Me.InvPostCodeTextBox.TabIndex = 19
        '
        'InvCountryComboBox
        '
        Me.InvCountryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "InvCountry", True))
        Me.InvCountryComboBox.FormattingEnabled = True
        Me.InvCountryComboBox.Location = New System.Drawing.Point(928, 248)
        Me.InvCountryComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InvCountryComboBox.Name = "InvCountryComboBox"
        Me.InvCountryComboBox.Size = New System.Drawing.Size(616, 24)
        Me.InvCountryComboBox.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 16)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1543, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Copy Supply Address to Invoice Address"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InvCountyComboBox
        '
        Me.InvCountyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "InvCounty", True))
        Me.InvCountyComboBox.FormattingEnabled = True
        Me.InvCountyComboBox.Location = New System.Drawing.Point(928, 216)
        Me.InvCountyComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InvCountyComboBox.Name = "InvCountyComboBox"
        Me.InvCountyComboBox.Size = New System.Drawing.Size(616, 24)
        Me.InvCountyComboBox.TabIndex = 17
        '
        'InvoiceToTextBox
        '
        Me.InvoiceToTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "InvoiceTo", True))
        Me.InvoiceToTextBox.Location = New System.Drawing.Point(928, 92)
        Me.InvoiceToTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InvoiceToTextBox.Name = "InvoiceToTextBox"
        Me.InvoiceToTextBox.Size = New System.Drawing.Size(616, 25)
        Me.InvoiceToTextBox.TabIndex = 13
        '
        'ArchiveCheckBox
        '
        Me.ArchiveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "Archive", True))
        Me.ArchiveCheckBox.Location = New System.Drawing.Point(898, 369)
        Me.ArchiveCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ArchiveCheckBox.Name = "ArchiveCheckBox"
        Me.ArchiveCheckBox.Size = New System.Drawing.Size(797, 25)
        Me.ArchiveCheckBox.TabIndex = 1
        Me.ArchiveCheckBox.Text = "Archive:"
        Me.ArchiveCheckBox.UseVisualStyleBackColor = True
        '
        'InvTownTextBox
        '
        Me.InvTownTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "InvTown", True))
        Me.InvTownTextBox.Location = New System.Drawing.Point(928, 185)
        Me.InvTownTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InvTownTextBox.Name = "InvTownTextBox"
        Me.InvTownTextBox.Size = New System.Drawing.Size(616, 25)
        Me.InvTownTextBox.TabIndex = 16
        '
        'InvAddressTextBox
        '
        Me.InvAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "InvAddress", True))
        Me.InvAddressTextBox.Location = New System.Drawing.Point(928, 123)
        Me.InvAddressTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InvAddressTextBox.Name = "InvAddressTextBox"
        Me.InvAddressTextBox.Size = New System.Drawing.Size(616, 25)
        Me.InvAddressTextBox.TabIndex = 14
        '
        'OrderNumberReq1CheckBox
        '
        Me.OrderNumberReq1CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "OrderNumberReq1", True))
        Me.OrderNumberReq1CheckBox.Location = New System.Drawing.Point(824, 339)
        Me.OrderNumberReq1CheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OrderNumberReq1CheckBox.Name = "OrderNumberReq1CheckBox"
        Me.OrderNumberReq1CheckBox.Size = New System.Drawing.Size(720, 25)
        Me.OrderNumberReq1CheckBox.TabIndex = 21
        Me.OrderNumberReq1CheckBox.Text = "Order Number Required:"
        Me.OrderNumberReq1CheckBox.UseVisualStyleBackColor = True
        '
        'Address3TextBox
        '
        Me.Address3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "InvAddress2", True))
        Me.Address3TextBox.Location = New System.Drawing.Point(928, 154)
        Me.Address3TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Address3TextBox.Name = "Address3TextBox"
        Me.Address3TextBox.Size = New System.Drawing.Size(616, 25)
        Me.Address3TextBox.TabIndex = 15
        '
        'POtypeTextEdit
        '
        Me.POtypeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SitesBindingSource, "POtype", True))
        Me.POtypeTextEdit.Location = New System.Drawing.Point(928, 370)
        Me.POtypeTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.POtypeTextEdit.Name = "POtypeTextEdit"
        Me.POtypeTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.POtypeTextEdit.Properties.Items.AddRange(New Object() {"Per Employee", "Cost Based", "Static ", "Per Site", "Per Job Category"})
        Me.POtypeTextEdit.Size = New System.Drawing.Size(616, 22)
        Me.POtypeTextEdit.StyleController = Me.LayoutControl2
        Me.POtypeTextEdit.TabIndex = 22
        '
        'BankIDSpinEdit
        '
        Me.BankIDSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SitesBindingSource, "BankID", True))
        Me.BankIDSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.BankIDSpinEdit.Location = New System.Drawing.Point(135, 404)
        Me.BankIDSpinEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BankIDSpinEdit.Name = "BankIDSpinEdit"
        Me.BankIDSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BankIDSpinEdit.Properties.DataSource = Me.BanksBindingSource
        Me.BankIDSpinEdit.Properties.DisplayMember = "BankName"
        Me.BankIDSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.BankIDSpinEdit.Properties.NullText = ""
        Me.BankIDSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BankIDSpinEdit.Properties.ValueMember = "BankID"
        Me.BankIDSpinEdit.Size = New System.Drawing.Size(653, 22)
        Me.BankIDSpinEdit.StyleController = Me.LayoutControl2
        Me.BankIDSpinEdit.TabIndex = 12
        '
        'BanksBindingSource
        '
        Me.BanksBindingSource.DataMember = "Banks"
        Me.BanksBindingSource.DataSource = Me.Sites1
        '
        'Sites1
        '
        Me.Sites1.DataSetName = "Sites"
        Me.Sites1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LayoutControlItem41
        '
        Me.LayoutControlItem41.Control = Me.ArchiveCheckBox
        Me.LayoutControlItem41.Location = New System.Drawing.Point(0, 219)
        Me.LayoutControlItem41.Name = "LayoutControlItem41"
        Me.LayoutControlItem41.Size = New System.Drawing.Size(687, 24)
        Me.LayoutControlItem41.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem41.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem21, Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1575, 653)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.Button1
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem21.MaxSize = New System.Drawing.Size(0, 38)
        Me.LayoutControlItem21.MinSize = New System.Drawing.Size(24, 38)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(1549, 38)
        Me.LayoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem32, Me.LayoutControlItem31, Me.LayoutControlItem30, Me.LayoutControlItem29, Me.LayoutControlItem28, Me.LayoutControlItem27, Me.LayoutControlItem26, Me.LayoutControlItem25, Me.LayoutControlItem23, Me.LayoutControlItem22, Me.LayoutControlItem167})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 38)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(793, 393)
        Me.LayoutControlGroup3.Text = "Supply Address:"
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.FaxTextBox
        Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 281)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(763, 31)
        Me.LayoutControlItem32.Text = "Fax:"
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.Telephone2TextBox
        Me.LayoutControlItem31.Location = New System.Drawing.Point(0, 250)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(763, 31)
        Me.LayoutControlItem31.Text = "Telephone 2:"
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.Telephone1TextBox
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 219)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(763, 31)
        Me.LayoutControlItem30.Text = "Telephone 1:"
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.EmailTextBox
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 188)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(763, 31)
        Me.LayoutControlItem29.Text = "Email:"
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.PostalCodeTextBox
        Me.LayoutControlItem28.Location = New System.Drawing.Point(0, 157)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(763, 31)
        Me.LayoutControlItem28.Text = "Postal Code:"
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.CountryComboBox
        Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 125)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(763, 32)
        Me.LayoutControlItem27.Text = "Country"
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.CountyComboBox
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 93)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(763, 32)
        Me.LayoutControlItem26.Text = "County"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.TownTextBox
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(763, 31)
        Me.LayoutControlItem25.Text = "Town:"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.Address2TextBox
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(763, 31)
        Me.LayoutControlItem23.Text = "Address 2:"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.AddressTextBox
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(763, 31)
        Me.LayoutControlItem22.Text = "Address:"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem167
        '
        Me.LayoutControlItem167.Control = Me.BankIDSpinEdit
        Me.LayoutControlItem167.Location = New System.Drawing.Point(0, 312)
        Me.LayoutControlItem167.Name = "LayoutControlItem167"
        Me.LayoutControlItem167.Size = New System.Drawing.Size(763, 28)
        Me.LayoutControlItem167.Text = "Bank:"
        Me.LayoutControlItem167.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem40, Me.LayoutControlItem39, Me.LayoutControlItem38, Me.LayoutControlItem37, Me.LayoutControlItem36, Me.LayoutControlItem35, Me.LayoutControlItem34, Me.LayoutControlItem33, Me.LayoutControlItem166, Me.asdas})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(793, 38)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(756, 393)
        Me.LayoutControlGroup4.Text = "Invoice Details:"
        '
        'LayoutControlItem40
        '
        Me.LayoutControlItem40.Control = Me.OrderNumberReq1CheckBox
        Me.LayoutControlItem40.Location = New System.Drawing.Point(0, 247)
        Me.LayoutControlItem40.Name = "LayoutControlItem40"
        Me.LayoutControlItem40.Size = New System.Drawing.Size(726, 31)
        Me.LayoutControlItem40.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem40.TextVisible = False
        '
        'LayoutControlItem39
        '
        Me.LayoutControlItem39.Control = Me.InvPostCodeTextBox
        Me.LayoutControlItem39.Location = New System.Drawing.Point(0, 188)
        Me.LayoutControlItem39.Name = "LayoutControlItem39"
        Me.LayoutControlItem39.Size = New System.Drawing.Size(726, 31)
        Me.LayoutControlItem39.Text = "Inv Postal Code:"
        Me.LayoutControlItem39.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem38
        '
        Me.LayoutControlItem38.Control = Me.InvCountryComboBox
        Me.LayoutControlItem38.Location = New System.Drawing.Point(0, 156)
        Me.LayoutControlItem38.Name = "LayoutControlItem38"
        Me.LayoutControlItem38.Size = New System.Drawing.Size(726, 32)
        Me.LayoutControlItem38.Text = "Inv Country:"
        Me.LayoutControlItem38.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.Control = Me.InvCountyComboBox
        Me.LayoutControlItem37.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(726, 32)
        Me.LayoutControlItem37.Text = "Inv County"
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.Control = Me.InvTownTextBox
        Me.LayoutControlItem36.Location = New System.Drawing.Point(0, 93)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(726, 31)
        Me.LayoutControlItem36.Text = "Inv Town:"
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem35
        '
        Me.LayoutControlItem35.Control = Me.Address3TextBox
        Me.LayoutControlItem35.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem35.Name = "LayoutControlItem35"
        Me.LayoutControlItem35.Size = New System.Drawing.Size(726, 31)
        Me.LayoutControlItem35.Text = "Inv Address 2:"
        Me.LayoutControlItem35.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.InvAddressTextBox
        Me.LayoutControlItem34.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(726, 31)
        Me.LayoutControlItem34.Text = "Inv Address"
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.InvoiceToTextBox
        Me.LayoutControlItem33.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(726, 31)
        Me.LayoutControlItem33.Text = "Invoice To:"
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem166
        '
        Me.LayoutControlItem166.Control = Me.POtypeTextEdit
        Me.LayoutControlItem166.Location = New System.Drawing.Point(0, 278)
        Me.LayoutControlItem166.Name = "LayoutControlItem166"
        Me.LayoutControlItem166.Size = New System.Drawing.Size(726, 62)
        Me.LayoutControlItem166.Text = "POtype:"
        Me.LayoutControlItem166.TextSize = New System.Drawing.Size(101, 16)
        '
        'asdas
        '
        Me.asdas.Control = Me.InvoicingMethodTextBox
        Me.asdas.Location = New System.Drawing.Point(0, 219)
        Me.asdas.Name = "asdas"
        Me.asdas.Size = New System.Drawing.Size(726, 28)
        Me.asdas.Text = "Invoicing Method:"
        Me.asdas.TextSize = New System.Drawing.Size(101, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 431)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(1549, 196)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Transparent
        Me.TabPage3.Controls.Add(Me.LayoutControl4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage3.Size = New System.Drawing.Size(1581, 661)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "AWR"
        '
        'LayoutControl4
        '
        Me.LayoutControl4.Controls.Add(Me.HolidayEntitlementTextBox)
        Me.LayoutControl4.Controls.Add(Me.HowArePermanentVacanciesDisplayedTextBox)
        Me.LayoutControl4.Controls.Add(Me.CanteenAvailableCheckBox)
        Me.LayoutControl4.Controls.Add(Me.OtherFacilitiesTextBox)
        Me.LayoutControl4.Controls.Add(Me.SmokingAreaAvailableCheckBox)
        Me.LayoutControl4.Controls.Add(Me.ParkingAvailableCheckBox)
        Me.LayoutControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl4.Location = New System.Drawing.Point(3, 4)
        Me.LayoutControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LayoutControl4.Name = "LayoutControl4"
        Me.LayoutControl4.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(443, 475, 250, 350)
        Me.LayoutControl4.Root = Me.LayoutControlGroup18
        Me.LayoutControl4.Size = New System.Drawing.Size(1575, 653)
        Me.LayoutControl4.TabIndex = 3
        Me.LayoutControl4.Text = "LayoutControl4"
        '
        'HolidayEntitlementTextBox
        '
        Me.HolidayEntitlementTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "HolidayEntitlement", True))
        Me.HolidayEntitlementTextBox.Location = New System.Drawing.Point(258, 140)
        Me.HolidayEntitlementTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HolidayEntitlementTextBox.Name = "HolidayEntitlementTextBox"
        Me.HolidayEntitlementTextBox.Size = New System.Drawing.Size(204, 25)
        Me.HolidayEntitlementTextBox.TabIndex = 5
        '
        'HowArePermanentVacanciesDisplayedTextBox
        '
        Me.HowArePermanentVacanciesDisplayedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "HowArePermanentVacanciesDisplayed", True))
        Me.HowArePermanentVacanciesDisplayedTextBox.Location = New System.Drawing.Point(258, 171)
        Me.HowArePermanentVacanciesDisplayedTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HowArePermanentVacanciesDisplayedTextBox.Name = "HowArePermanentVacanciesDisplayedTextBox"
        Me.HowArePermanentVacanciesDisplayedTextBox.Size = New System.Drawing.Size(204, 25)
        Me.HowArePermanentVacanciesDisplayedTextBox.TabIndex = 6
        '
        'CanteenAvailableCheckBox
        '
        Me.CanteenAvailableCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "CanteenAvailable", True))
        Me.CanteenAvailableCheckBox.Location = New System.Drawing.Point(16, 16)
        Me.CanteenAvailableCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CanteenAvailableCheckBox.Name = "CanteenAvailableCheckBox"
        Me.CanteenAvailableCheckBox.Size = New System.Drawing.Size(446, 25)
        Me.CanteenAvailableCheckBox.TabIndex = 0
        Me.CanteenAvailableCheckBox.Text = "Canteen Available:"
        Me.CanteenAvailableCheckBox.UseVisualStyleBackColor = True
        '
        'OtherFacilitiesTextBox
        '
        Me.OtherFacilitiesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "OtherFacilities", True))
        Me.OtherFacilitiesTextBox.Location = New System.Drawing.Point(258, 109)
        Me.OtherFacilitiesTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OtherFacilitiesTextBox.Name = "OtherFacilitiesTextBox"
        Me.OtherFacilitiesTextBox.Size = New System.Drawing.Size(204, 25)
        Me.OtherFacilitiesTextBox.TabIndex = 4
        '
        'SmokingAreaAvailableCheckBox
        '
        Me.SmokingAreaAvailableCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "SmokingAreaAvailable", True))
        Me.SmokingAreaAvailableCheckBox.Location = New System.Drawing.Point(16, 47)
        Me.SmokingAreaAvailableCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SmokingAreaAvailableCheckBox.Name = "SmokingAreaAvailableCheckBox"
        Me.SmokingAreaAvailableCheckBox.Size = New System.Drawing.Size(446, 25)
        Me.SmokingAreaAvailableCheckBox.TabIndex = 2
        Me.SmokingAreaAvailableCheckBox.Text = "Smoking Area Available:"
        Me.SmokingAreaAvailableCheckBox.UseVisualStyleBackColor = True
        '
        'ParkingAvailableCheckBox
        '
        Me.ParkingAvailableCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "ParkingAvailable", True))
        Me.ParkingAvailableCheckBox.Location = New System.Drawing.Point(16, 78)
        Me.ParkingAvailableCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ParkingAvailableCheckBox.Name = "ParkingAvailableCheckBox"
        Me.ParkingAvailableCheckBox.Size = New System.Drawing.Size(446, 25)
        Me.ParkingAvailableCheckBox.TabIndex = 3
        Me.ParkingAvailableCheckBox.Text = "Parking Available:"
        Me.ParkingAvailableCheckBox.UseVisualStyleBackColor = True
        '
        'LayoutControlGroup18
        '
        Me.LayoutControlGroup18.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup18.GroupBordersVisible = False
        Me.LayoutControlGroup18.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem111, Me.LayoutControlItem132, Me.LayoutControlItem133, Me.LayoutControlItem134, Me.LayoutControlItem135, Me.LayoutControlItem136, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.SplitterItem3})
        Me.LayoutControlGroup18.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup18.Name = "Root"
        Me.LayoutControlGroup18.Size = New System.Drawing.Size(1575, 653)
        Me.LayoutControlGroup18.TextVisible = False
        '
        'LayoutControlItem111
        '
        Me.LayoutControlItem111.Control = Me.CanteenAvailableCheckBox
        Me.LayoutControlItem111.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem111.Name = "LayoutControlItem111"
        Me.LayoutControlItem111.Size = New System.Drawing.Size(452, 31)
        Me.LayoutControlItem111.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem111.TextVisible = False
        '
        'LayoutControlItem132
        '
        Me.LayoutControlItem132.Control = Me.SmokingAreaAvailableCheckBox
        Me.LayoutControlItem132.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem132.Name = "LayoutControlItem132"
        Me.LayoutControlItem132.Size = New System.Drawing.Size(452, 31)
        Me.LayoutControlItem132.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem132.TextVisible = False
        '
        'LayoutControlItem133
        '
        Me.LayoutControlItem133.Control = Me.ParkingAvailableCheckBox
        Me.LayoutControlItem133.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem133.Name = "LayoutControlItem133"
        Me.LayoutControlItem133.Size = New System.Drawing.Size(452, 31)
        Me.LayoutControlItem133.Text = "Parking Available:"
        Me.LayoutControlItem133.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem133.TextVisible = False
        '
        'LayoutControlItem134
        '
        Me.LayoutControlItem134.Control = Me.OtherFacilitiesTextBox
        Me.LayoutControlItem134.Location = New System.Drawing.Point(0, 93)
        Me.LayoutControlItem134.Name = "LayoutControlItem134"
        Me.LayoutControlItem134.Size = New System.Drawing.Size(452, 31)
        Me.LayoutControlItem134.Text = "Other Facilities:"
        Me.LayoutControlItem134.TextSize = New System.Drawing.Size(239, 16)
        '
        'LayoutControlItem135
        '
        Me.LayoutControlItem135.Control = Me.HolidayEntitlementTextBox
        Me.LayoutControlItem135.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem135.Name = "LayoutControlItem135"
        Me.LayoutControlItem135.Size = New System.Drawing.Size(452, 31)
        Me.LayoutControlItem135.Text = "Holiday Entitlement:"
        Me.LayoutControlItem135.TextSize = New System.Drawing.Size(239, 16)
        '
        'LayoutControlItem136
        '
        Me.LayoutControlItem136.Control = Me.HowArePermanentVacanciesDisplayedTextBox
        Me.LayoutControlItem136.Location = New System.Drawing.Point(0, 155)
        Me.LayoutControlItem136.Name = "LayoutControlItem136"
        Me.LayoutControlItem136.Size = New System.Drawing.Size(452, 31)
        Me.LayoutControlItem136.Text = "How Are Permanent Vacancies Displayed:"
        Me.LayoutControlItem136.TextSize = New System.Drawing.Size(239, 16)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 186)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(452, 441)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(458, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(1091, 627)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'SplitterItem3
        '
        Me.SplitterItem3.AllowHotTrack = True
        Me.SplitterItem3.Location = New System.Drawing.Point(452, 0)
        Me.SplitterItem3.Name = "SplitterItem3"
        Me.SplitterItem3.Size = New System.Drawing.Size(6, 627)
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Transparent
        Me.TabPage4.Controls.Add(Me.LayoutControl5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 28)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage4.Size = New System.Drawing.Size(1581, 661)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Health & Safety"
        '
        'LayoutControl5
        '
        Me.LayoutControl5.Controls.Add(Me.H_SEarDefendersCheckBox)
        Me.LayoutControl5.Controls.Add(Me.H_SOtherEqupmentTextBox)
        Me.LayoutControl5.Controls.Add(Me.H_SContactTextBox)
        Me.LayoutControl5.Controls.Add(Me.H_SHiVisTrousersCheckBox)
        Me.LayoutControl5.Controls.Add(Me.H_SPositionTextBox)
        Me.LayoutControl5.Controls.Add(Me.H_SMobileTextBox)
        Me.LayoutControl5.Controls.Add(Me.H_SHardHatCheckBox)
        Me.LayoutControl5.Controls.Add(Me.H_SEmailTextBox)
        Me.LayoutControl5.Controls.Add(Me.H_SRisksTextBox)
        Me.LayoutControl5.Controls.Add(Me.H_SSaftyGogglesCheckBox)
        Me.LayoutControl5.Controls.Add(Me.H_SStepsTextBox)
        Me.LayoutControl5.Controls.Add(Me.H_SMinAgeTextBox)
        Me.LayoutControl5.Controls.Add(Me.H_SHiVizVestCheckBox)
        Me.LayoutControl5.Controls.Add(Me.H_SBasicInductionCheckBox)
        Me.LayoutControl5.Controls.Add(Me.H_SInstructionGivenCheckBox)
        Me.LayoutControl5.Controls.Add(Me.H_SSaftyBootsCheckBox)
        Me.LayoutControl5.Controls.Add(Me.H_SFirstAidAvailableCheckBox)
        Me.LayoutControl5.Controls.Add(Me.H_SAccidentsReportedCheckBox)
        Me.LayoutControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl5.Location = New System.Drawing.Point(3, 4)
        Me.LayoutControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LayoutControl5.Name = "LayoutControl5"
        Me.LayoutControl5.Root = Me.LayoutControlGroup19
        Me.LayoutControl5.Size = New System.Drawing.Size(1575, 653)
        Me.LayoutControl5.TabIndex = 4
        Me.LayoutControl5.Text = "LayoutControl5"
        '
        'H_SEarDefendersCheckBox
        '
        Me.H_SEarDefendersCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "H&SEarDefenders", True))
        Me.H_SEarDefendersCheckBox.Location = New System.Drawing.Point(324, 171)
        Me.H_SEarDefendersCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.H_SEarDefendersCheckBox.Name = "H_SEarDefendersCheckBox"
        Me.H_SEarDefendersCheckBox.Size = New System.Drawing.Size(328, 25)
        Me.H_SEarDefendersCheckBox.TabIndex = 12
        Me.H_SEarDefendersCheckBox.Text = "H&&S Ear Defenders:"
        Me.H_SEarDefendersCheckBox.UseVisualStyleBackColor = True
        '
        'H_SOtherEqupmentTextBox
        '
        Me.H_SOtherEqupmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "H&SOtherEqupment", True))
        Me.H_SOtherEqupmentTextBox.Location = New System.Drawing.Point(457, 202)
        Me.H_SOtherEqupmentTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.H_SOtherEqupmentTextBox.Name = "H_SOtherEqupmentTextBox"
        Me.H_SOtherEqupmentTextBox.Size = New System.Drawing.Size(195, 25)
        Me.H_SOtherEqupmentTextBox.TabIndex = 14
        '
        'H_SContactTextBox
        '
        Me.H_SContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "H&SContact", True))
        Me.H_SContactTextBox.Location = New System.Drawing.Point(149, 16)
        Me.H_SContactTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.H_SContactTextBox.Name = "H_SContactTextBox"
        Me.H_SContactTextBox.Size = New System.Drawing.Size(169, 25)
        Me.H_SContactTextBox.TabIndex = 0
        '
        'H_SHiVisTrousersCheckBox
        '
        Me.H_SHiVisTrousersCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "H&SHiVisTrousers", True))
        Me.H_SHiVisTrousersCheckBox.Location = New System.Drawing.Point(324, 140)
        Me.H_SHiVisTrousersCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.H_SHiVisTrousersCheckBox.Name = "H_SHiVisTrousersCheckBox"
        Me.H_SHiVisTrousersCheckBox.Size = New System.Drawing.Size(328, 25)
        Me.H_SHiVisTrousersCheckBox.TabIndex = 10
        Me.H_SHiVisTrousersCheckBox.Text = "H&&S Hi Vis Trousers:"
        Me.H_SHiVisTrousersCheckBox.UseVisualStyleBackColor = True
        '
        'H_SPositionTextBox
        '
        Me.H_SPositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "H&SPosition", True))
        Me.H_SPositionTextBox.Location = New System.Drawing.Point(149, 47)
        Me.H_SPositionTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.H_SPositionTextBox.Name = "H_SPositionTextBox"
        Me.H_SPositionTextBox.Size = New System.Drawing.Size(169, 25)
        Me.H_SPositionTextBox.TabIndex = 3
        '
        'H_SMobileTextBox
        '
        Me.H_SMobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "H&SMobile", True))
        Me.H_SMobileTextBox.Location = New System.Drawing.Point(149, 78)
        Me.H_SMobileTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.H_SMobileTextBox.Name = "H_SMobileTextBox"
        Me.H_SMobileTextBox.Size = New System.Drawing.Size(169, 25)
        Me.H_SMobileTextBox.TabIndex = 5
        '
        'H_SHardHatCheckBox
        '
        Me.H_SHardHatCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "H&SHardHat", True))
        Me.H_SHardHatCheckBox.Location = New System.Drawing.Point(324, 109)
        Me.H_SHardHatCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.H_SHardHatCheckBox.Name = "H_SHardHatCheckBox"
        Me.H_SHardHatCheckBox.Size = New System.Drawing.Size(328, 25)
        Me.H_SHardHatCheckBox.TabIndex = 8
        Me.H_SHardHatCheckBox.Text = "H&&S Hard Hat:"
        Me.H_SHardHatCheckBox.UseVisualStyleBackColor = True
        '
        'H_SEmailTextBox
        '
        Me.H_SEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "H&SEmail", True))
        Me.H_SEmailTextBox.Location = New System.Drawing.Point(149, 109)
        Me.H_SEmailTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.H_SEmailTextBox.Name = "H_SEmailTextBox"
        Me.H_SEmailTextBox.Size = New System.Drawing.Size(169, 25)
        Me.H_SEmailTextBox.TabIndex = 7
        '
        'H_SRisksTextBox
        '
        Me.H_SRisksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "H&SRisks", True))
        Me.H_SRisksTextBox.Location = New System.Drawing.Point(149, 140)
        Me.H_SRisksTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.H_SRisksTextBox.Name = "H_SRisksTextBox"
        Me.H_SRisksTextBox.Size = New System.Drawing.Size(169, 25)
        Me.H_SRisksTextBox.TabIndex = 9
        '
        'H_SSaftyGogglesCheckBox
        '
        Me.H_SSaftyGogglesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "H&SSaftyGoggles", True))
        Me.H_SSaftyGogglesCheckBox.Location = New System.Drawing.Point(324, 78)
        Me.H_SSaftyGogglesCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.H_SSaftyGogglesCheckBox.Name = "H_SSaftyGogglesCheckBox"
        Me.H_SSaftyGogglesCheckBox.Size = New System.Drawing.Size(328, 25)
        Me.H_SSaftyGogglesCheckBox.TabIndex = 6
        Me.H_SSaftyGogglesCheckBox.Text = "H&&S Safty Goggles:"
        Me.H_SSaftyGogglesCheckBox.UseVisualStyleBackColor = True
        '
        'H_SStepsTextBox
        '
        Me.H_SStepsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "H&SSteps", True))
        Me.H_SStepsTextBox.Location = New System.Drawing.Point(149, 171)
        Me.H_SStepsTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.H_SStepsTextBox.Name = "H_SStepsTextBox"
        Me.H_SStepsTextBox.Size = New System.Drawing.Size(169, 25)
        Me.H_SStepsTextBox.TabIndex = 11
        '
        'H_SMinAgeTextBox
        '
        Me.H_SMinAgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "H&SMinAge", True))
        Me.H_SMinAgeTextBox.Location = New System.Drawing.Point(149, 202)
        Me.H_SMinAgeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.H_SMinAgeTextBox.Name = "H_SMinAgeTextBox"
        Me.H_SMinAgeTextBox.Size = New System.Drawing.Size(169, 25)
        Me.H_SMinAgeTextBox.TabIndex = 13
        '
        'H_SHiVizVestCheckBox
        '
        Me.H_SHiVizVestCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "H&SHiVizVest", True))
        Me.H_SHiVizVestCheckBox.Location = New System.Drawing.Point(324, 47)
        Me.H_SHiVizVestCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.H_SHiVizVestCheckBox.Name = "H_SHiVizVestCheckBox"
        Me.H_SHiVizVestCheckBox.Size = New System.Drawing.Size(328, 25)
        Me.H_SHiVizVestCheckBox.TabIndex = 4
        Me.H_SHiVizVestCheckBox.Text = "H&&S Hi Vis Vest:"
        Me.H_SHiVizVestCheckBox.UseVisualStyleBackColor = True
        '
        'H_SBasicInductionCheckBox
        '
        Me.H_SBasicInductionCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "H&SBasicInduction", True))
        Me.H_SBasicInductionCheckBox.Location = New System.Drawing.Point(16, 233)
        Me.H_SBasicInductionCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.H_SBasicInductionCheckBox.Name = "H_SBasicInductionCheckBox"
        Me.H_SBasicInductionCheckBox.Size = New System.Drawing.Size(302, 25)
        Me.H_SBasicInductionCheckBox.TabIndex = 15
        Me.H_SBasicInductionCheckBox.Text = "H&&S Basic Induction:"
        Me.H_SBasicInductionCheckBox.UseVisualStyleBackColor = True
        '
        'H_SInstructionGivenCheckBox
        '
        Me.H_SInstructionGivenCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "H&SInstructionGiven", True))
        Me.H_SInstructionGivenCheckBox.Location = New System.Drawing.Point(16, 264)
        Me.H_SInstructionGivenCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.H_SInstructionGivenCheckBox.Name = "H_SInstructionGivenCheckBox"
        Me.H_SInstructionGivenCheckBox.Size = New System.Drawing.Size(302, 25)
        Me.H_SInstructionGivenCheckBox.TabIndex = 16
        Me.H_SInstructionGivenCheckBox.Text = "H&&S Instruction Given:"
        Me.H_SInstructionGivenCheckBox.UseVisualStyleBackColor = True
        '
        'H_SSaftyBootsCheckBox
        '
        Me.H_SSaftyBootsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "H&SSaftyBoots", True))
        Me.H_SSaftyBootsCheckBox.Location = New System.Drawing.Point(324, 16)
        Me.H_SSaftyBootsCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.H_SSaftyBootsCheckBox.Name = "H_SSaftyBootsCheckBox"
        Me.H_SSaftyBootsCheckBox.Size = New System.Drawing.Size(328, 25)
        Me.H_SSaftyBootsCheckBox.TabIndex = 2
        Me.H_SSaftyBootsCheckBox.Text = "H&&S Safty Boots:"
        Me.H_SSaftyBootsCheckBox.UseVisualStyleBackColor = True
        '
        'H_SFirstAidAvailableCheckBox
        '
        Me.H_SFirstAidAvailableCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "H&SFirstAidAvailable", True))
        Me.H_SFirstAidAvailableCheckBox.Location = New System.Drawing.Point(16, 295)
        Me.H_SFirstAidAvailableCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.H_SFirstAidAvailableCheckBox.Name = "H_SFirstAidAvailableCheckBox"
        Me.H_SFirstAidAvailableCheckBox.Size = New System.Drawing.Size(302, 25)
        Me.H_SFirstAidAvailableCheckBox.TabIndex = 17
        Me.H_SFirstAidAvailableCheckBox.Text = "H&&S First Aid Available:"
        Me.H_SFirstAidAvailableCheckBox.UseVisualStyleBackColor = True
        '
        'H_SAccidentsReportedCheckBox
        '
        Me.H_SAccidentsReportedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SitesBindingSource, "H&SAccidentsReported", True))
        Me.H_SAccidentsReportedCheckBox.Location = New System.Drawing.Point(16, 326)
        Me.H_SAccidentsReportedCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.H_SAccidentsReportedCheckBox.Name = "H_SAccidentsReportedCheckBox"
        Me.H_SAccidentsReportedCheckBox.Size = New System.Drawing.Size(302, 25)
        Me.H_SAccidentsReportedCheckBox.TabIndex = 18
        Me.H_SAccidentsReportedCheckBox.Text = "H&&S Accidents:"
        Me.H_SAccidentsReportedCheckBox.UseVisualStyleBackColor = True
        '
        'LayoutControlGroup19
        '
        Me.LayoutControlGroup19.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup19.GroupBordersVisible = False
        Me.LayoutControlGroup19.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem137, Me.LayoutControlItem138, Me.LayoutControlItem139, Me.LayoutControlItem140, Me.LayoutControlItem141, Me.LayoutControlItem142, Me.LayoutControlItem143, Me.LayoutControlItem144, Me.LayoutControlItem145, Me.LayoutControlItem146, Me.LayoutControlItem147, Me.LayoutControlItem148, Me.LayoutControlItem149, Me.LayoutControlItem150, Me.LayoutControlItem151, Me.LayoutControlItem152, Me.LayoutControlItem153, Me.LayoutControlItem154, Me.EmptySpaceItem5})
        Me.LayoutControlGroup19.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup19.Name = "LayoutControlGroup19"
        Me.LayoutControlGroup19.Size = New System.Drawing.Size(1575, 653)
        Me.LayoutControlGroup19.TextVisible = False
        '
        'LayoutControlItem137
        '
        Me.LayoutControlItem137.Control = Me.H_SContactTextBox
        Me.LayoutControlItem137.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem137.Name = "LayoutControlItem137"
        Me.LayoutControlItem137.Size = New System.Drawing.Size(308, 31)
        Me.LayoutControlItem137.Text = "H&&S Contact:"
        Me.LayoutControlItem137.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem138
        '
        Me.LayoutControlItem138.Control = Me.H_SPositionTextBox
        Me.LayoutControlItem138.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem138.Name = "LayoutControlItem138"
        Me.LayoutControlItem138.Size = New System.Drawing.Size(308, 31)
        Me.LayoutControlItem138.Text = "H&&S Position:"
        Me.LayoutControlItem138.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem139
        '
        Me.LayoutControlItem139.Control = Me.H_SMobileTextBox
        Me.LayoutControlItem139.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem139.Name = "LayoutControlItem139"
        Me.LayoutControlItem139.Size = New System.Drawing.Size(308, 31)
        Me.LayoutControlItem139.Text = "H&&S Mobile:"
        Me.LayoutControlItem139.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem140
        '
        Me.LayoutControlItem140.Control = Me.H_SEmailTextBox
        Me.LayoutControlItem140.Location = New System.Drawing.Point(0, 93)
        Me.LayoutControlItem140.Name = "LayoutControlItem140"
        Me.LayoutControlItem140.Size = New System.Drawing.Size(308, 31)
        Me.LayoutControlItem140.Text = "H&&S Email:"
        Me.LayoutControlItem140.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem141
        '
        Me.LayoutControlItem141.Control = Me.H_SRisksTextBox
        Me.LayoutControlItem141.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem141.Name = "LayoutControlItem141"
        Me.LayoutControlItem141.Size = New System.Drawing.Size(308, 31)
        Me.LayoutControlItem141.Text = "H&&S Risks:"
        Me.LayoutControlItem141.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem142
        '
        Me.LayoutControlItem142.Control = Me.H_SStepsTextBox
        Me.LayoutControlItem142.Location = New System.Drawing.Point(0, 155)
        Me.LayoutControlItem142.Name = "LayoutControlItem142"
        Me.LayoutControlItem142.Size = New System.Drawing.Size(308, 31)
        Me.LayoutControlItem142.Text = "H&&S Steps:"
        Me.LayoutControlItem142.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem143
        '
        Me.LayoutControlItem143.Control = Me.H_SMinAgeTextBox
        Me.LayoutControlItem143.Location = New System.Drawing.Point(0, 186)
        Me.LayoutControlItem143.Name = "LayoutControlItem143"
        Me.LayoutControlItem143.Size = New System.Drawing.Size(308, 31)
        Me.LayoutControlItem143.Text = "H&&S Min Age:"
        Me.LayoutControlItem143.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem144
        '
        Me.LayoutControlItem144.Control = Me.H_SBasicInductionCheckBox
        Me.LayoutControlItem144.Location = New System.Drawing.Point(0, 217)
        Me.LayoutControlItem144.Name = "LayoutControlItem144"
        Me.LayoutControlItem144.Size = New System.Drawing.Size(308, 31)
        Me.LayoutControlItem144.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem144.TextVisible = False
        '
        'LayoutControlItem145
        '
        Me.LayoutControlItem145.Control = Me.H_SInstructionGivenCheckBox
        Me.LayoutControlItem145.Location = New System.Drawing.Point(0, 248)
        Me.LayoutControlItem145.Name = "LayoutControlItem145"
        Me.LayoutControlItem145.Size = New System.Drawing.Size(308, 31)
        Me.LayoutControlItem145.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem145.TextVisible = False
        '
        'LayoutControlItem146
        '
        Me.LayoutControlItem146.Control = Me.H_SFirstAidAvailableCheckBox
        Me.LayoutControlItem146.Location = New System.Drawing.Point(0, 279)
        Me.LayoutControlItem146.Name = "LayoutControlItem146"
        Me.LayoutControlItem146.Size = New System.Drawing.Size(308, 31)
        Me.LayoutControlItem146.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem146.TextVisible = False
        '
        'LayoutControlItem147
        '
        Me.LayoutControlItem147.Control = Me.H_SAccidentsReportedCheckBox
        Me.LayoutControlItem147.Location = New System.Drawing.Point(0, 310)
        Me.LayoutControlItem147.Name = "LayoutControlItem147"
        Me.LayoutControlItem147.Size = New System.Drawing.Size(308, 317)
        Me.LayoutControlItem147.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem147.TextVisible = False
        '
        'LayoutControlItem148
        '
        Me.LayoutControlItem148.Control = Me.H_SSaftyBootsCheckBox
        Me.LayoutControlItem148.Location = New System.Drawing.Point(308, 0)
        Me.LayoutControlItem148.Name = "LayoutControlItem148"
        Me.LayoutControlItem148.Size = New System.Drawing.Size(334, 31)
        Me.LayoutControlItem148.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem148.TextVisible = False
        '
        'LayoutControlItem149
        '
        Me.LayoutControlItem149.Control = Me.H_SHiVizVestCheckBox
        Me.LayoutControlItem149.Location = New System.Drawing.Point(308, 31)
        Me.LayoutControlItem149.Name = "LayoutControlItem149"
        Me.LayoutControlItem149.Size = New System.Drawing.Size(334, 31)
        Me.LayoutControlItem149.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem149.TextVisible = False
        '
        'LayoutControlItem150
        '
        Me.LayoutControlItem150.Control = Me.H_SSaftyGogglesCheckBox
        Me.LayoutControlItem150.Location = New System.Drawing.Point(308, 62)
        Me.LayoutControlItem150.Name = "LayoutControlItem150"
        Me.LayoutControlItem150.Size = New System.Drawing.Size(334, 31)
        Me.LayoutControlItem150.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem150.TextVisible = False
        '
        'LayoutControlItem151
        '
        Me.LayoutControlItem151.Control = Me.H_SHardHatCheckBox
        Me.LayoutControlItem151.Location = New System.Drawing.Point(308, 93)
        Me.LayoutControlItem151.Name = "LayoutControlItem151"
        Me.LayoutControlItem151.Size = New System.Drawing.Size(334, 31)
        Me.LayoutControlItem151.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem151.TextVisible = False
        '
        'LayoutControlItem152
        '
        Me.LayoutControlItem152.Control = Me.H_SHiVisTrousersCheckBox
        Me.LayoutControlItem152.Location = New System.Drawing.Point(308, 124)
        Me.LayoutControlItem152.Name = "LayoutControlItem152"
        Me.LayoutControlItem152.Size = New System.Drawing.Size(334, 31)
        Me.LayoutControlItem152.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem152.TextVisible = False
        '
        'LayoutControlItem153
        '
        Me.LayoutControlItem153.Control = Me.H_SEarDefendersCheckBox
        Me.LayoutControlItem153.Location = New System.Drawing.Point(308, 155)
        Me.LayoutControlItem153.Name = "LayoutControlItem153"
        Me.LayoutControlItem153.Size = New System.Drawing.Size(334, 31)
        Me.LayoutControlItem153.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem153.TextVisible = False
        '
        'LayoutControlItem154
        '
        Me.LayoutControlItem154.Control = Me.H_SOtherEqupmentTextBox
        Me.LayoutControlItem154.Location = New System.Drawing.Point(308, 186)
        Me.LayoutControlItem154.Name = "LayoutControlItem154"
        Me.LayoutControlItem154.Size = New System.Drawing.Size(334, 441)
        Me.LayoutControlItem154.Text = "H&&S Other Equipment:"
        Me.LayoutControlItem154.TextSize = New System.Drawing.Size(130, 16)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(642, 0)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(907, 627)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'TabPage10
        '
        Me.TabPage10.AutoScroll = True
        Me.TabPage10.BackColor = System.Drawing.Color.Transparent
        Me.TabPage10.Controls.Add(Me.LayoutControl3)
        Me.TabPage10.Location = New System.Drawing.Point(4, 28)
        Me.TabPage10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage10.Size = New System.Drawing.Size(1581, 661)
        Me.TabPage10.TabIndex = 9
        Me.TabPage10.Text = "Job Categories"
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.CheckBox1)
        Me.LayoutControl3.Controls.Add(Me.ArchiveCheckEdit)
        Me.LayoutControl3.Controls.Add(Me.JobCatIdSpinEdit)
        Me.LayoutControl3.Controls.Add(Me.GridControl1)
        Me.LayoutControl3.Controls.Add(Me.MinChargePerDayTextBox)
        Me.LayoutControl3.Controls.Add(Me.TempToPermAfterTextBox)
        Me.LayoutControl3.Controls.Add(Me.BindingNavigator1)
        Me.LayoutControl3.Controls.Add(Me.NotesForTimeSheetTextBox)
        Me.LayoutControl3.Controls.Add(Me.MemoEdit4)
        Me.LayoutControl3.Controls.Add(Me.MemoEdit3)
        Me.LayoutControl3.Controls.Add(Me.TimesheetTypeComboBox)
        Me.LayoutControl3.Controls.Add(Me.MemoEdit2)
        Me.LayoutControl3.Controls.Add(Me.C4NightsOutTextBox)
        Me.LayoutControl3.Controls.Add(Me.TimeSheetSentViaTextBox)
        Me.LayoutControl3.Controls.Add(Me.SWHTextBox)
        Me.LayoutControl3.Controls.Add(Me.LastModifiedDateTextBox)
        Me.LayoutControl3.Controls.Add(Me.LastModifiedUserTextBox)
        Me.LayoutControl3.Controls.Add(Me.CBJobType)
        Me.LayoutControl3.Controls.Add(Me.MemoEdit1)
        Me.LayoutControl3.Controls.Add(Me.C3NightsOutTextBox)
        Me.LayoutControl3.Controls.Add(Me.TimesheetContactComboBox)
        Me.LayoutControl3.Controls.Add(Me.DHHTextBox)
        Me.LayoutControl3.Controls.Add(Me.ComboBox1)
        Me.LayoutControl3.Controls.Add(Me.C4BankHolTextBox)
        Me.LayoutControl3.Controls.Add(Me.C2NightsOutTextBox)
        Me.LayoutControl3.Controls.Add(Me.C4SundayTextBox)
        Me.LayoutControl3.Controls.Add(Me.C3BankHolTextBox)
        Me.LayoutControl3.Controls.Add(Me.BreakDeductedCheckBox)
        Me.LayoutControl3.Controls.Add(Me.CNightsOutTextBox)
        Me.LayoutControl3.Controls.Add(Me.C4SaturdayTextBox)
        Me.LayoutControl3.Controls.Add(Me.BreakEntitlementTextBox)
        Me.LayoutControl3.Controls.Add(Me.C2BankHolTextBox)
        Me.LayoutControl3.Controls.Add(Me.C3SundayTextBox)
        Me.LayoutControl3.Controls.Add(Me.TypicalEndTimeTextBox)
        Me.LayoutControl3.Controls.Add(Me.C4OT3TextBox)
        Me.LayoutControl3.Controls.Add(Me.CBankHolTextBox)
        Me.LayoutControl3.Controls.Add(Me.TypicalStartTimeTextBox)
        Me.LayoutControl3.Controls.Add(Me.C2SundayTextBox)
        Me.LayoutControl3.Controls.Add(Me.C4OT2TextBox)
        Me.LayoutControl3.Controls.Add(Me.ShiftNameTextBox)
        Me.LayoutControl3.Controls.Add(Me.C3SaturdayTextBox)
        Me.LayoutControl3.Controls.Add(Me.C4OT1TextBox)
        Me.LayoutControl3.Controls.Add(Me.JobCategoryTextBox)
        Me.LayoutControl3.Controls.Add(Me.C3OT3TextBox)
        Me.LayoutControl3.Controls.Add(Me.C4BasicPayTextBox)
        Me.LayoutControl3.Controls.Add(Me.PBasicPayTextBox)
        Me.LayoutControl3.Controls.Add(Me.C2SaturdayTextBox)
        Me.LayoutControl3.Controls.Add(Me.P4NightsOutTextBox)
        Me.LayoutControl3.Controls.Add(Me.C3OT2TextBox)
        Me.LayoutControl3.Controls.Add(Me.POT1TextBox)
        Me.LayoutControl3.Controls.Add(Me.P4BankHolTextBox)
        Me.LayoutControl3.Controls.Add(Me.CSundayTextBox)
        Me.LayoutControl3.Controls.Add(Me.C3OT1TextBox)
        Me.LayoutControl3.Controls.Add(Me.P4SundayTextBox)
        Me.LayoutControl3.Controls.Add(Me.C2OT3TextBox)
        Me.LayoutControl3.Controls.Add(Me.POT2TextBox)
        Me.LayoutControl3.Controls.Add(Me.P4SaturdayTextBox)
        Me.LayoutControl3.Controls.Add(Me.C3BasicPayTextBox)
        Me.LayoutControl3.Controls.Add(Me.POT3TextBox)
        Me.LayoutControl3.Controls.Add(Me.P4OT3TextBox)
        Me.LayoutControl3.Controls.Add(Me.C2OT2TextBox)
        Me.LayoutControl3.Controls.Add(Me.P3NightsOutTextBox)
        Me.LayoutControl3.Controls.Add(Me.P4OT2TextBox)
        Me.LayoutControl3.Controls.Add(Me.PSaturdayTextBox)
        Me.LayoutControl3.Controls.Add(Me.CSaturdayTextBox)
        Me.LayoutControl3.Controls.Add(Me.P4OT1TextBox)
        Me.LayoutControl3.Controls.Add(Me.P3BankHolTextBox)
        Me.LayoutControl3.Controls.Add(Me.C2OT1TextBox)
        Me.LayoutControl3.Controls.Add(Me.P4BasicPayTextBox)
        Me.LayoutControl3.Controls.Add(Me.PSundayTextBox)
        Me.LayoutControl3.Controls.Add(Me.P3SundayTextBox)
        Me.LayoutControl3.Controls.Add(Me.PBankHolTextBox)
        Me.LayoutControl3.Controls.Add(Me.C2BasicPayTextBox)
        Me.LayoutControl3.Controls.Add(Me.P3SaturdayTextBox)
        Me.LayoutControl3.Controls.Add(Me.COT3TextBox)
        Me.LayoutControl3.Controls.Add(Me.PNightsOutTextBox)
        Me.LayoutControl3.Controls.Add(Me.P3OT3TextBox)
        Me.LayoutControl3.Controls.Add(Me.P2NightsOutTextBox)
        Me.LayoutControl3.Controls.Add(Me.CBasicPayTextBox)
        Me.LayoutControl3.Controls.Add(Me.P3OT2TextBox)
        Me.LayoutControl3.Controls.Add(Me.COT2TextBox)
        Me.LayoutControl3.Controls.Add(Me.P2BankHolTextBox)
        Me.LayoutControl3.Controls.Add(Me.P3OT1TextBox)
        Me.LayoutControl3.Controls.Add(Me.COT1TextBox)
        Me.LayoutControl3.Controls.Add(Me.P2BasicPayTextBox)
        Me.LayoutControl3.Controls.Add(Me.P3BasicPayTextBox)
        Me.LayoutControl3.Controls.Add(Me.P2SundayTextBox)
        Me.LayoutControl3.Controls.Add(Me.P2OT1TextBox)
        Me.LayoutControl3.Controls.Add(Me.P2OT2TextBox)
        Me.LayoutControl3.Controls.Add(Me.P2SaturdayTextBox)
        Me.LayoutControl3.Controls.Add(Me.P2OT3TextBox)
        Me.LayoutControl3.Controls.Add(Me.HoursPerShift)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(3, 4)
        Me.LayoutControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(891, 266, 250, 350)
        Me.LayoutControl3.Root = Me.LayoutControlGroup5
        Me.LayoutControl3.Size = New System.Drawing.Size(1575, 653)
        Me.LayoutControl3.TabIndex = 2
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'CheckBox1
        '
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FKJobCategorySitesBindingSource, "U25Rate", True))
        Me.CheckBox1.Location = New System.Drawing.Point(672, 243)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(161, 25)
        Me.CheckBox1.TabIndex = 28
        Me.CheckBox1.Text = "U25 Rate"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FKJobCategorySitesBindingSource
        '
        Me.FKJobCategorySitesBindingSource.DataMember = "FK_JobCategory_Sites"
        Me.FKJobCategorySitesBindingSource.DataSource = Me.SitesBindingSource
        '
        'ArchiveCheckEdit
        '
        Me.ArchiveCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FKJobCategorySitesBindingSource, "Archive", True))
        Me.ArchiveCheckEdit.Location = New System.Drawing.Point(652, 678)
        Me.ArchiveCheckEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ArchiveCheckEdit.Name = "ArchiveCheckEdit"
        Me.ArchiveCheckEdit.Properties.Caption = ""
        Me.ArchiveCheckEdit.Size = New System.Drawing.Size(181, 19)
        Me.ArchiveCheckEdit.StyleController = Me.LayoutControl3
        Me.ArchiveCheckEdit.TabIndex = 42
        '
        'JobCatIdSpinEdit
        '
        Me.JobCatIdSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FKJobCategorySitesBindingSource, "JobCatId", True))
        Me.JobCatIdSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.JobCatIdSpinEdit.Enabled = False
        Me.JobCatIdSpinEdit.Location = New System.Drawing.Point(652, 60)
        Me.JobCatIdSpinEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JobCatIdSpinEdit.Name = "JobCatIdSpinEdit"
        Me.JobCatIdSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JobCatIdSpinEdit.Size = New System.Drawing.Size(181, 22)
        Me.JobCatIdSpinEdit.StyleController = Me.LayoutControl3
        Me.JobCatIdSpinEdit.TabIndex = 3
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.FKJobCategorySitesBindingSource
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GridControl1.Location = New System.Drawing.Point(16, 60)
        Me.GridControl1.MainView = Me.GridView3
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(491, 637)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colJobCategory, Me.colShiftName, Me.colTypicalStartTime, Me.colTypicalEndTime, Me.colArchive1})
        Me.GridView3.GridControl = Me.GridControl1
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        '
        'colJobCategory
        '
        Me.colJobCategory.FieldName = "JobCategory"
        Me.colJobCategory.Name = "colJobCategory"
        Me.colJobCategory.Visible = True
        Me.colJobCategory.VisibleIndex = 0
        '
        'colShiftName
        '
        Me.colShiftName.FieldName = "ShiftName"
        Me.colShiftName.Name = "colShiftName"
        Me.colShiftName.Visible = True
        Me.colShiftName.VisibleIndex = 1
        '
        'colTypicalStartTime
        '
        Me.colTypicalStartTime.FieldName = "TypicalStartTime"
        Me.colTypicalStartTime.Name = "colTypicalStartTime"
        Me.colTypicalStartTime.Visible = True
        Me.colTypicalStartTime.VisibleIndex = 2
        '
        'colTypicalEndTime
        '
        Me.colTypicalEndTime.FieldName = "TypicalEndTime"
        Me.colTypicalEndTime.Name = "colTypicalEndTime"
        Me.colTypicalEndTime.Visible = True
        Me.colTypicalEndTime.VisibleIndex = 3
        '
        'colArchive1
        '
        Me.colArchive1.FieldName = "Archive"
        Me.colArchive1.Name = "colArchive1"
        Me.colArchive1.Visible = True
        Me.colArchive1.VisibleIndex = 4
        '
        'MinChargePerDayTextBox
        '
        Me.MinChargePerDayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "MinChargePerDay", True))
        Me.MinChargePerDayTextBox.Location = New System.Drawing.Point(652, 463)
        Me.MinChargePerDayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinChargePerDayTextBox.Name = "MinChargePerDayTextBox"
        Me.MinChargePerDayTextBox.Size = New System.Drawing.Size(181, 25)
        Me.MinChargePerDayTextBox.TabIndex = 35
        '
        'TempToPermAfterTextBox
        '
        Me.TempToPermAfterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "TempToPermAfter", True))
        Me.TempToPermAfterTextBox.Location = New System.Drawing.Point(652, 494)
        Me.TempToPermAfterTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TempToPermAfterTextBox.Name = "TempToPermAfterTextBox"
        Me.TempToPermAfterTextBox.Size = New System.Drawing.Size(181, 25)
        Me.TempToPermAfterTextBox.TabIndex = 36
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.AutoSize = False
        Me.BindingNavigator1.BindingSource = Me.FKJobCategorySitesBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.SaveToolStripButton, Me.toolStripSeparator})
        Me.BindingNavigator1.Location = New System.Drawing.Point(16, 16)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(1543, 38)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(45, 35)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(58, 27)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Enabled = False
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 35)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 35)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 38)
        '
        'NotesForTimeSheetTextBox
        '
        Me.NotesForTimeSheetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "NotesForTimeSheet", True))
        Me.NotesForTimeSheetTextBox.Location = New System.Drawing.Point(652, 369)
        Me.NotesForTimeSheetTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NotesForTimeSheetTextBox.Name = "NotesForTimeSheetTextBox"
        Me.NotesForTimeSheetTextBox.Size = New System.Drawing.Size(181, 25)
        Me.NotesForTimeSheetTextBox.TabIndex = 32
        '
        'MemoEdit4
        '
        Me.MemoEdit4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "RulesorDetails3", True))
        Me.MemoEdit4.Location = New System.Drawing.Point(854, 422)
        Me.MemoEdit4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MemoEdit4.Name = "MemoEdit4"
        Me.MemoEdit4.Size = New System.Drawing.Size(690, 260)
        Me.MemoEdit4.StyleController = Me.LayoutControl3
        Me.MemoEdit4.TabIndex = 1
        '
        'MemoEdit3
        '
        Me.MemoEdit3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "RulesorDetails2", True))
        Me.MemoEdit3.Location = New System.Drawing.Point(854, 422)
        Me.MemoEdit3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MemoEdit3.Name = "MemoEdit3"
        Me.MemoEdit3.Size = New System.Drawing.Size(690, 260)
        Me.MemoEdit3.StyleController = Me.LayoutControl3
        Me.MemoEdit3.TabIndex = 1
        '
        'TimesheetTypeComboBox
        '
        Me.TimesheetTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "TimesheetType", True))
        Me.TimesheetTypeComboBox.FormattingEnabled = True
        Me.TimesheetTypeComboBox.Items.AddRange(New Object() {"Single to temp ", "Single to client ", "Be-Spoke", "Block Timesheet "})
        Me.TimesheetTypeComboBox.Location = New System.Drawing.Point(652, 337)
        Me.TimesheetTypeComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TimesheetTypeComboBox.Name = "TimesheetTypeComboBox"
        Me.TimesheetTypeComboBox.Size = New System.Drawing.Size(181, 24)
        Me.TimesheetTypeComboBox.TabIndex = 31
        '
        'MemoEdit2
        '
        Me.MemoEdit2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "RulesorDetails1", True))
        Me.MemoEdit2.Location = New System.Drawing.Point(854, 422)
        Me.MemoEdit2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MemoEdit2.Name = "MemoEdit2"
        Me.MemoEdit2.Size = New System.Drawing.Size(690, 260)
        Me.MemoEdit2.StyleController = Me.LayoutControl3
        Me.MemoEdit2.TabIndex = 1
        '
        'C4NightsOutTextBox
        '
        Me.C4NightsOutTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C4NightsOut", True))
        Me.C4NightsOutTextBox.Location = New System.Drawing.Point(1356, 357)
        Me.C4NightsOutTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C4NightsOutTextBox.Name = "C4NightsOutTextBox"
        Me.C4NightsOutTextBox.Size = New System.Drawing.Size(173, 25)
        Me.C4NightsOutTextBox.TabIndex = 1
        '
        'TimeSheetSentViaTextBox
        '
        Me.TimeSheetSentViaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "TimeSheetSentVia", True))
        Me.TimeSheetSentViaTextBox.Location = New System.Drawing.Point(652, 306)
        Me.TimeSheetSentViaTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TimeSheetSentViaTextBox.Name = "TimeSheetSentViaTextBox"
        Me.TimeSheetSentViaTextBox.Size = New System.Drawing.Size(181, 25)
        Me.TimeSheetSentViaTextBox.TabIndex = 30
        '
        'SWHTextBox
        '
        Me.SWHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "SWH", True))
        Me.SWHTextBox.Location = New System.Drawing.Point(652, 525)
        Me.SWHTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SWHTextBox.Name = "SWHTextBox"
        Me.SWHTextBox.Size = New System.Drawing.Size(181, 25)
        Me.SWHTextBox.TabIndex = 37
        '
        'LastModifiedDateTextBox
        '
        Me.LastModifiedDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "LastModifiedDate", True))
        Me.LastModifiedDateTextBox.Location = New System.Drawing.Point(652, 587)
        Me.LastModifiedDateTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LastModifiedDateTextBox.Name = "LastModifiedDateTextBox"
        Me.LastModifiedDateTextBox.ReadOnly = True
        Me.LastModifiedDateTextBox.Size = New System.Drawing.Size(181, 25)
        Me.LastModifiedDateTextBox.TabIndex = 39
        '
        'LastModifiedUserTextBox
        '
        Me.LastModifiedUserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "LastModifiedUser", True))
        Me.LastModifiedUserTextBox.Location = New System.Drawing.Point(652, 556)
        Me.LastModifiedUserTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LastModifiedUserTextBox.Name = "LastModifiedUserTextBox"
        Me.LastModifiedUserTextBox.ReadOnly = True
        Me.LastModifiedUserTextBox.Size = New System.Drawing.Size(181, 25)
        Me.LastModifiedUserTextBox.TabIndex = 38
        '
        'CBJobType
        '
        Me.CBJobType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "JobType", True))
        Me.CBJobType.FormattingEnabled = True
        Me.CBJobType.Items.AddRange(New Object() {"Hourly Work", "Shift Work"})
        Me.CBJobType.Location = New System.Drawing.Point(652, 618)
        Me.CBJobType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CBJobType.Name = "CBJobType"
        Me.CBJobType.Size = New System.Drawing.Size(181, 24)
        Me.CBJobType.TabIndex = 40
        Me.CBJobType.Text = "Hourly Work"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "RulesorDetails", True))
        Me.MemoEdit1.Location = New System.Drawing.Point(854, 422)
        Me.MemoEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(690, 260)
        Me.MemoEdit1.StyleController = Me.LayoutControl3
        Me.MemoEdit1.TabIndex = 21
        '
        'C3NightsOutTextBox
        '
        Me.C3NightsOutTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C3NightsOut", True))
        Me.C3NightsOutTextBox.Location = New System.Drawing.Point(1356, 357)
        Me.C3NightsOutTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C3NightsOutTextBox.Name = "C3NightsOutTextBox"
        Me.C3NightsOutTextBox.Size = New System.Drawing.Size(173, 25)
        Me.C3NightsOutTextBox.TabIndex = 1
        '
        'TimesheetContactComboBox
        '
        Me.TimesheetContactComboBox.CausesValidation = False
        Me.TimesheetContactComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FKJobCategorySitesBindingSource, "TimesheetContact", True))
        Me.TimesheetContactComboBox.DataSource = Me.CompanyContactsBindingSource
        Me.TimesheetContactComboBox.DisplayMember = "FullName"
        Me.TimesheetContactComboBox.FormattingEnabled = True
        Me.TimesheetContactComboBox.Location = New System.Drawing.Point(652, 274)
        Me.TimesheetContactComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TimesheetContactComboBox.Name = "TimesheetContactComboBox"
        Me.TimesheetContactComboBox.Size = New System.Drawing.Size(181, 24)
        Me.TimesheetContactComboBox.TabIndex = 29
        Me.TimesheetContactComboBox.ValueMember = "ContactID"
        '
        'DHHTextBox
        '
        Me.DHHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "DHH", True))
        Me.DHHTextBox.Location = New System.Drawing.Point(652, 432)
        Me.DHHTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DHHTextBox.Name = "DHHTextBox"
        Me.DHHTextBox.Size = New System.Drawing.Size(181, 25)
        Me.DHHTextBox.TabIndex = 34
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "StartOfWeek", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.ComboBox1.Location = New System.Drawing.Point(652, 400)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(181, 24)
        Me.ComboBox1.TabIndex = 33
        '
        'C4BankHolTextBox
        '
        Me.C4BankHolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C4BankHol", True))
        Me.C4BankHolTextBox.Location = New System.Drawing.Point(1356, 326)
        Me.C4BankHolTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C4BankHolTextBox.Name = "C4BankHolTextBox"
        Me.C4BankHolTextBox.Size = New System.Drawing.Size(173, 25)
        Me.C4BankHolTextBox.TabIndex = 1
        '
        'C2NightsOutTextBox
        '
        Me.C2NightsOutTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C2NightsOut", True))
        Me.C2NightsOutTextBox.Location = New System.Drawing.Point(1356, 357)
        Me.C2NightsOutTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C2NightsOutTextBox.Name = "C2NightsOutTextBox"
        Me.C2NightsOutTextBox.Size = New System.Drawing.Size(173, 25)
        Me.C2NightsOutTextBox.TabIndex = 1
        '
        'C4SundayTextBox
        '
        Me.C4SundayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C4Sunday", True))
        Me.C4SundayTextBox.Location = New System.Drawing.Point(1356, 295)
        Me.C4SundayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C4SundayTextBox.Name = "C4SundayTextBox"
        Me.C4SundayTextBox.Size = New System.Drawing.Size(173, 25)
        Me.C4SundayTextBox.TabIndex = 1
        '
        'C3BankHolTextBox
        '
        Me.C3BankHolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C3BankHol", True))
        Me.C3BankHolTextBox.Location = New System.Drawing.Point(1356, 326)
        Me.C3BankHolTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C3BankHolTextBox.Name = "C3BankHolTextBox"
        Me.C3BankHolTextBox.Size = New System.Drawing.Size(173, 25)
        Me.C3BankHolTextBox.TabIndex = 1
        '
        'BreakDeductedCheckBox
        '
        Me.BreakDeductedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FKJobCategorySitesBindingSource, "BreakDeducted", True))
        Me.BreakDeductedCheckBox.Location = New System.Drawing.Point(519, 243)
        Me.BreakDeductedCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BreakDeductedCheckBox.Name = "BreakDeductedCheckBox"
        Me.BreakDeductedCheckBox.Size = New System.Drawing.Size(147, 25)
        Me.BreakDeductedCheckBox.TabIndex = 27
        Me.BreakDeductedCheckBox.Text = "Break Deducted:"
        Me.BreakDeductedCheckBox.UseVisualStyleBackColor = True
        '
        'CNightsOutTextBox
        '
        Me.CNightsOutTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "CNightsOut", True))
        Me.CNightsOutTextBox.Location = New System.Drawing.Point(1356, 357)
        Me.CNightsOutTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CNightsOutTextBox.Name = "CNightsOutTextBox"
        Me.CNightsOutTextBox.Size = New System.Drawing.Size(173, 25)
        Me.CNightsOutTextBox.TabIndex = 20
        '
        'C4SaturdayTextBox
        '
        Me.C4SaturdayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C4Saturday", True))
        Me.C4SaturdayTextBox.Location = New System.Drawing.Point(1356, 264)
        Me.C4SaturdayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C4SaturdayTextBox.Name = "C4SaturdayTextBox"
        Me.C4SaturdayTextBox.Size = New System.Drawing.Size(173, 25)
        Me.C4SaturdayTextBox.TabIndex = 1
        '
        'BreakEntitlementTextBox
        '
        Me.BreakEntitlementTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "BreakEntitlement", True))
        Me.BreakEntitlementTextBox.Location = New System.Drawing.Point(652, 212)
        Me.BreakEntitlementTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BreakEntitlementTextBox.Name = "BreakEntitlementTextBox"
        Me.BreakEntitlementTextBox.Size = New System.Drawing.Size(181, 25)
        Me.BreakEntitlementTextBox.TabIndex = 26
        '
        'C2BankHolTextBox
        '
        Me.C2BankHolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C2BankHol", True))
        Me.C2BankHolTextBox.Location = New System.Drawing.Point(1356, 326)
        Me.C2BankHolTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C2BankHolTextBox.Name = "C2BankHolTextBox"
        Me.C2BankHolTextBox.Size = New System.Drawing.Size(173, 25)
        Me.C2BankHolTextBox.TabIndex = 1
        '
        'C3SundayTextBox
        '
        Me.C3SundayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C3Sunday", True))
        Me.C3SundayTextBox.Location = New System.Drawing.Point(1356, 295)
        Me.C3SundayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C3SundayTextBox.Name = "C3SundayTextBox"
        Me.C3SundayTextBox.Size = New System.Drawing.Size(173, 25)
        Me.C3SundayTextBox.TabIndex = 1
        '
        'TypicalEndTimeTextBox
        '
        Me.TypicalEndTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "TypicalEndTime", True))
        Me.TypicalEndTimeTextBox.Location = New System.Drawing.Point(652, 181)
        Me.TypicalEndTimeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TypicalEndTimeTextBox.Name = "TypicalEndTimeTextBox"
        Me.TypicalEndTimeTextBox.Size = New System.Drawing.Size(181, 25)
        Me.TypicalEndTimeTextBox.TabIndex = 25
        '
        'C4OT3TextBox
        '
        Me.C4OT3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C4OT3", True))
        Me.C4OT3TextBox.Location = New System.Drawing.Point(1356, 233)
        Me.C4OT3TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C4OT3TextBox.Name = "C4OT3TextBox"
        Me.C4OT3TextBox.Size = New System.Drawing.Size(173, 25)
        Me.C4OT3TextBox.TabIndex = 1
        '
        'CBankHolTextBox
        '
        Me.CBankHolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "CBankHol", True))
        Me.CBankHolTextBox.Location = New System.Drawing.Point(1356, 326)
        Me.CBankHolTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CBankHolTextBox.Name = "CBankHolTextBox"
        Me.CBankHolTextBox.Size = New System.Drawing.Size(173, 25)
        Me.CBankHolTextBox.TabIndex = 19
        '
        'TypicalStartTimeTextBox
        '
        Me.TypicalStartTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "TypicalStartTime", True))
        Me.TypicalStartTimeTextBox.Location = New System.Drawing.Point(652, 150)
        Me.TypicalStartTimeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TypicalStartTimeTextBox.Name = "TypicalStartTimeTextBox"
        Me.TypicalStartTimeTextBox.Size = New System.Drawing.Size(181, 25)
        Me.TypicalStartTimeTextBox.TabIndex = 24
        '
        'C2SundayTextBox
        '
        Me.C2SundayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C2Sunday", True))
        Me.C2SundayTextBox.Location = New System.Drawing.Point(1356, 295)
        Me.C2SundayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C2SundayTextBox.Name = "C2SundayTextBox"
        Me.C2SundayTextBox.Size = New System.Drawing.Size(173, 25)
        Me.C2SundayTextBox.TabIndex = 1
        '
        'C4OT2TextBox
        '
        Me.C4OT2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C4OT2", True))
        Me.C4OT2TextBox.Location = New System.Drawing.Point(1356, 202)
        Me.C4OT2TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C4OT2TextBox.Name = "C4OT2TextBox"
        Me.C4OT2TextBox.Size = New System.Drawing.Size(173, 25)
        Me.C4OT2TextBox.TabIndex = 1
        '
        'ShiftNameTextBox
        '
        Me.ShiftNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "ShiftName", True))
        Me.ShiftNameTextBox.Location = New System.Drawing.Point(652, 119)
        Me.ShiftNameTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ShiftNameTextBox.Name = "ShiftNameTextBox"
        Me.ShiftNameTextBox.Size = New System.Drawing.Size(181, 25)
        Me.ShiftNameTextBox.TabIndex = 23
        '
        'C3SaturdayTextBox
        '
        Me.C3SaturdayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C3Saturday", True))
        Me.C3SaturdayTextBox.Location = New System.Drawing.Point(1356, 264)
        Me.C3SaturdayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C3SaturdayTextBox.Name = "C3SaturdayTextBox"
        Me.C3SaturdayTextBox.Size = New System.Drawing.Size(173, 25)
        Me.C3SaturdayTextBox.TabIndex = 1
        '
        'C4OT1TextBox
        '
        Me.C4OT1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C4OT1", True))
        Me.C4OT1TextBox.Location = New System.Drawing.Point(1356, 171)
        Me.C4OT1TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C4OT1TextBox.Name = "C4OT1TextBox"
        Me.C4OT1TextBox.Size = New System.Drawing.Size(173, 25)
        Me.C4OT1TextBox.TabIndex = 1
        '
        'JobCategoryTextBox
        '
        Me.JobCategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "JobCategory", True))
        Me.JobCategoryTextBox.Location = New System.Drawing.Point(652, 88)
        Me.JobCategoryTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JobCategoryTextBox.Name = "JobCategoryTextBox"
        Me.JobCategoryTextBox.Size = New System.Drawing.Size(181, 25)
        Me.JobCategoryTextBox.TabIndex = 22
        '
        'C3OT3TextBox
        '
        Me.C3OT3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C3OT3", True))
        Me.C3OT3TextBox.Location = New System.Drawing.Point(1356, 233)
        Me.C3OT3TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C3OT3TextBox.Name = "C3OT3TextBox"
        Me.C3OT3TextBox.Size = New System.Drawing.Size(173, 25)
        Me.C3OT3TextBox.TabIndex = 1
        '
        'C4BasicPayTextBox
        '
        Me.C4BasicPayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C4BasicPay", True))
        Me.C4BasicPayTextBox.Location = New System.Drawing.Point(1356, 140)
        Me.C4BasicPayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C4BasicPayTextBox.Name = "C4BasicPayTextBox"
        Me.C4BasicPayTextBox.Size = New System.Drawing.Size(173, 25)
        Me.C4BasicPayTextBox.TabIndex = 1
        '
        'PBasicPayTextBox
        '
        Me.PBasicPayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "PBasicPay", True))
        Me.PBasicPayTextBox.Location = New System.Drawing.Point(1002, 140)
        Me.PBasicPayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PBasicPayTextBox.Name = "PBasicPayTextBox"
        Me.PBasicPayTextBox.Size = New System.Drawing.Size(185, 25)
        Me.PBasicPayTextBox.TabIndex = 5
        '
        'C2SaturdayTextBox
        '
        Me.C2SaturdayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C2Saturday", True))
        Me.C2SaturdayTextBox.Location = New System.Drawing.Point(1356, 264)
        Me.C2SaturdayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C2SaturdayTextBox.Name = "C2SaturdayTextBox"
        Me.C2SaturdayTextBox.Size = New System.Drawing.Size(173, 25)
        Me.C2SaturdayTextBox.TabIndex = 1
        '
        'P4NightsOutTextBox
        '
        Me.P4NightsOutTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P4NightsOut", True))
        Me.P4NightsOutTextBox.Location = New System.Drawing.Point(1002, 357)
        Me.P4NightsOutTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P4NightsOutTextBox.Name = "P4NightsOutTextBox"
        Me.P4NightsOutTextBox.Size = New System.Drawing.Size(185, 25)
        Me.P4NightsOutTextBox.TabIndex = 1
        '
        'C3OT2TextBox
        '
        Me.C3OT2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C3OT2", True))
        Me.C3OT2TextBox.Location = New System.Drawing.Point(1356, 202)
        Me.C3OT2TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C3OT2TextBox.Name = "C3OT2TextBox"
        Me.C3OT2TextBox.Size = New System.Drawing.Size(173, 25)
        Me.C3OT2TextBox.TabIndex = 1
        '
        'POT1TextBox
        '
        Me.POT1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "POT1", True))
        Me.POT1TextBox.Location = New System.Drawing.Point(1002, 171)
        Me.POT1TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.POT1TextBox.Name = "POT1TextBox"
        Me.POT1TextBox.Size = New System.Drawing.Size(185, 25)
        Me.POT1TextBox.TabIndex = 6
        '
        'P4BankHolTextBox
        '
        Me.P4BankHolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P4BankHol", True))
        Me.P4BankHolTextBox.Location = New System.Drawing.Point(1002, 326)
        Me.P4BankHolTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P4BankHolTextBox.Name = "P4BankHolTextBox"
        Me.P4BankHolTextBox.Size = New System.Drawing.Size(185, 25)
        Me.P4BankHolTextBox.TabIndex = 1
        '
        'CSundayTextBox
        '
        Me.CSundayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "CSunday", True))
        Me.CSundayTextBox.Location = New System.Drawing.Point(1356, 295)
        Me.CSundayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CSundayTextBox.Name = "CSundayTextBox"
        Me.CSundayTextBox.Size = New System.Drawing.Size(173, 25)
        Me.CSundayTextBox.TabIndex = 18
        '
        'C3OT1TextBox
        '
        Me.C3OT1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C3OT1", True))
        Me.C3OT1TextBox.Location = New System.Drawing.Point(1356, 171)
        Me.C3OT1TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C3OT1TextBox.Name = "C3OT1TextBox"
        Me.C3OT1TextBox.Size = New System.Drawing.Size(173, 25)
        Me.C3OT1TextBox.TabIndex = 1
        '
        'P4SundayTextBox
        '
        Me.P4SundayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P4Sunday", True))
        Me.P4SundayTextBox.Location = New System.Drawing.Point(1002, 295)
        Me.P4SundayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P4SundayTextBox.Name = "P4SundayTextBox"
        Me.P4SundayTextBox.Size = New System.Drawing.Size(185, 25)
        Me.P4SundayTextBox.TabIndex = 1
        '
        'C2OT3TextBox
        '
        Me.C2OT3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C2OT3", True))
        Me.C2OT3TextBox.Location = New System.Drawing.Point(1356, 233)
        Me.C2OT3TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C2OT3TextBox.Name = "C2OT3TextBox"
        Me.C2OT3TextBox.Size = New System.Drawing.Size(173, 25)
        Me.C2OT3TextBox.TabIndex = 1
        '
        'POT2TextBox
        '
        Me.POT2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "POT2", True))
        Me.POT2TextBox.Location = New System.Drawing.Point(1002, 202)
        Me.POT2TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.POT2TextBox.Name = "POT2TextBox"
        Me.POT2TextBox.Size = New System.Drawing.Size(185, 25)
        Me.POT2TextBox.TabIndex = 7
        '
        'P4SaturdayTextBox
        '
        Me.P4SaturdayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P4Saturday", True))
        Me.P4SaturdayTextBox.Location = New System.Drawing.Point(1002, 264)
        Me.P4SaturdayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P4SaturdayTextBox.Name = "P4SaturdayTextBox"
        Me.P4SaturdayTextBox.Size = New System.Drawing.Size(185, 25)
        Me.P4SaturdayTextBox.TabIndex = 1
        '
        'C3BasicPayTextBox
        '
        Me.C3BasicPayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C3BasicPay", True))
        Me.C3BasicPayTextBox.Location = New System.Drawing.Point(1356, 140)
        Me.C3BasicPayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C3BasicPayTextBox.Name = "C3BasicPayTextBox"
        Me.C3BasicPayTextBox.Size = New System.Drawing.Size(173, 25)
        Me.C3BasicPayTextBox.TabIndex = 1
        '
        'POT3TextBox
        '
        Me.POT3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "POT3", True))
        Me.POT3TextBox.Location = New System.Drawing.Point(1002, 233)
        Me.POT3TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.POT3TextBox.Name = "POT3TextBox"
        Me.POT3TextBox.Size = New System.Drawing.Size(185, 25)
        Me.POT3TextBox.TabIndex = 8
        '
        'P4OT3TextBox
        '
        Me.P4OT3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P4OT3", True))
        Me.P4OT3TextBox.Location = New System.Drawing.Point(1002, 233)
        Me.P4OT3TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P4OT3TextBox.Name = "P4OT3TextBox"
        Me.P4OT3TextBox.Size = New System.Drawing.Size(185, 25)
        Me.P4OT3TextBox.TabIndex = 1
        '
        'C2OT2TextBox
        '
        Me.C2OT2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C2OT2", True))
        Me.C2OT2TextBox.Location = New System.Drawing.Point(1356, 202)
        Me.C2OT2TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C2OT2TextBox.Name = "C2OT2TextBox"
        Me.C2OT2TextBox.Size = New System.Drawing.Size(173, 25)
        Me.C2OT2TextBox.TabIndex = 1
        '
        'P3NightsOutTextBox
        '
        Me.P3NightsOutTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P3NightsOut", True))
        Me.P3NightsOutTextBox.Location = New System.Drawing.Point(1002, 357)
        Me.P3NightsOutTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P3NightsOutTextBox.Name = "P3NightsOutTextBox"
        Me.P3NightsOutTextBox.Size = New System.Drawing.Size(185, 25)
        Me.P3NightsOutTextBox.TabIndex = 1
        '
        'P4OT2TextBox
        '
        Me.P4OT2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P4OT2", True))
        Me.P4OT2TextBox.Location = New System.Drawing.Point(1002, 202)
        Me.P4OT2TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P4OT2TextBox.Name = "P4OT2TextBox"
        Me.P4OT2TextBox.Size = New System.Drawing.Size(185, 25)
        Me.P4OT2TextBox.TabIndex = 1
        '
        'PSaturdayTextBox
        '
        Me.PSaturdayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "PSaturday", True))
        Me.PSaturdayTextBox.Location = New System.Drawing.Point(1002, 264)
        Me.PSaturdayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PSaturdayTextBox.Name = "PSaturdayTextBox"
        Me.PSaturdayTextBox.Size = New System.Drawing.Size(185, 25)
        Me.PSaturdayTextBox.TabIndex = 9
        '
        'CSaturdayTextBox
        '
        Me.CSaturdayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "CSaturday", True))
        Me.CSaturdayTextBox.Location = New System.Drawing.Point(1356, 264)
        Me.CSaturdayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CSaturdayTextBox.Name = "CSaturdayTextBox"
        Me.CSaturdayTextBox.Size = New System.Drawing.Size(173, 25)
        Me.CSaturdayTextBox.TabIndex = 17
        '
        'P4OT1TextBox
        '
        Me.P4OT1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P4OT1", True))
        Me.P4OT1TextBox.Location = New System.Drawing.Point(1002, 171)
        Me.P4OT1TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P4OT1TextBox.Name = "P4OT1TextBox"
        Me.P4OT1TextBox.Size = New System.Drawing.Size(185, 25)
        Me.P4OT1TextBox.TabIndex = 1
        '
        'P3BankHolTextBox
        '
        Me.P3BankHolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P3BankHol", True))
        Me.P3BankHolTextBox.Location = New System.Drawing.Point(1002, 326)
        Me.P3BankHolTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P3BankHolTextBox.Name = "P3BankHolTextBox"
        Me.P3BankHolTextBox.Size = New System.Drawing.Size(185, 25)
        Me.P3BankHolTextBox.TabIndex = 1
        '
        'C2OT1TextBox
        '
        Me.C2OT1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C2OT1", True))
        Me.C2OT1TextBox.Location = New System.Drawing.Point(1356, 171)
        Me.C2OT1TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C2OT1TextBox.Name = "C2OT1TextBox"
        Me.C2OT1TextBox.Size = New System.Drawing.Size(173, 25)
        Me.C2OT1TextBox.TabIndex = 1
        '
        'P4BasicPayTextBox
        '
        Me.P4BasicPayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P4BasicPay", True))
        Me.P4BasicPayTextBox.Location = New System.Drawing.Point(1002, 140)
        Me.P4BasicPayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P4BasicPayTextBox.Name = "P4BasicPayTextBox"
        Me.P4BasicPayTextBox.Size = New System.Drawing.Size(185, 25)
        Me.P4BasicPayTextBox.TabIndex = 1
        '
        'PSundayTextBox
        '
        Me.PSundayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "PSunday", True))
        Me.PSundayTextBox.Location = New System.Drawing.Point(1002, 295)
        Me.PSundayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PSundayTextBox.Name = "PSundayTextBox"
        Me.PSundayTextBox.Size = New System.Drawing.Size(185, 25)
        Me.PSundayTextBox.TabIndex = 10
        '
        'P3SundayTextBox
        '
        Me.P3SundayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P3Sunday", True))
        Me.P3SundayTextBox.Location = New System.Drawing.Point(1002, 295)
        Me.P3SundayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P3SundayTextBox.Name = "P3SundayTextBox"
        Me.P3SundayTextBox.Size = New System.Drawing.Size(185, 25)
        Me.P3SundayTextBox.TabIndex = 1
        '
        'PBankHolTextBox
        '
        Me.PBankHolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "PBankHol", True))
        Me.PBankHolTextBox.Location = New System.Drawing.Point(1002, 326)
        Me.PBankHolTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PBankHolTextBox.Name = "PBankHolTextBox"
        Me.PBankHolTextBox.Size = New System.Drawing.Size(185, 25)
        Me.PBankHolTextBox.TabIndex = 11
        '
        'C2BasicPayTextBox
        '
        Me.C2BasicPayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "C2BasicPay", True))
        Me.C2BasicPayTextBox.Location = New System.Drawing.Point(1356, 140)
        Me.C2BasicPayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C2BasicPayTextBox.Name = "C2BasicPayTextBox"
        Me.C2BasicPayTextBox.Size = New System.Drawing.Size(173, 25)
        Me.C2BasicPayTextBox.TabIndex = 1
        '
        'P3SaturdayTextBox
        '
        Me.P3SaturdayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P3Saturday", True))
        Me.P3SaturdayTextBox.Location = New System.Drawing.Point(1002, 264)
        Me.P3SaturdayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P3SaturdayTextBox.Name = "P3SaturdayTextBox"
        Me.P3SaturdayTextBox.Size = New System.Drawing.Size(185, 25)
        Me.P3SaturdayTextBox.TabIndex = 1
        '
        'COT3TextBox
        '
        Me.COT3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "COT3", True))
        Me.COT3TextBox.Location = New System.Drawing.Point(1356, 233)
        Me.COT3TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.COT3TextBox.Name = "COT3TextBox"
        Me.COT3TextBox.Size = New System.Drawing.Size(173, 25)
        Me.COT3TextBox.TabIndex = 16
        '
        'PNightsOutTextBox
        '
        Me.PNightsOutTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "PNightsOut", True))
        Me.PNightsOutTextBox.Location = New System.Drawing.Point(1002, 357)
        Me.PNightsOutTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PNightsOutTextBox.Name = "PNightsOutTextBox"
        Me.PNightsOutTextBox.Size = New System.Drawing.Size(185, 25)
        Me.PNightsOutTextBox.TabIndex = 12
        '
        'P3OT3TextBox
        '
        Me.P3OT3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P3OT3", True))
        Me.P3OT3TextBox.Location = New System.Drawing.Point(1002, 233)
        Me.P3OT3TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P3OT3TextBox.Name = "P3OT3TextBox"
        Me.P3OT3TextBox.Size = New System.Drawing.Size(185, 25)
        Me.P3OT3TextBox.TabIndex = 1
        '
        'P2NightsOutTextBox
        '
        Me.P2NightsOutTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P2NightsOut", True))
        Me.P2NightsOutTextBox.Location = New System.Drawing.Point(1002, 357)
        Me.P2NightsOutTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P2NightsOutTextBox.Name = "P2NightsOutTextBox"
        Me.P2NightsOutTextBox.Size = New System.Drawing.Size(185, 25)
        Me.P2NightsOutTextBox.TabIndex = 1
        '
        'CBasicPayTextBox
        '
        Me.CBasicPayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "CBasicPay", True))
        Me.CBasicPayTextBox.Location = New System.Drawing.Point(1356, 140)
        Me.CBasicPayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CBasicPayTextBox.Name = "CBasicPayTextBox"
        Me.CBasicPayTextBox.Size = New System.Drawing.Size(173, 25)
        Me.CBasicPayTextBox.TabIndex = 13
        '
        'P3OT2TextBox
        '
        Me.P3OT2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P3OT2", True))
        Me.P3OT2TextBox.Location = New System.Drawing.Point(1002, 202)
        Me.P3OT2TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P3OT2TextBox.Name = "P3OT2TextBox"
        Me.P3OT2TextBox.Size = New System.Drawing.Size(185, 25)
        Me.P3OT2TextBox.TabIndex = 1
        '
        'COT2TextBox
        '
        Me.COT2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "COT2", True))
        Me.COT2TextBox.Location = New System.Drawing.Point(1356, 202)
        Me.COT2TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.COT2TextBox.Name = "COT2TextBox"
        Me.COT2TextBox.Size = New System.Drawing.Size(173, 25)
        Me.COT2TextBox.TabIndex = 15
        '
        'P2BankHolTextBox
        '
        Me.P2BankHolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P2BankHol", True))
        Me.P2BankHolTextBox.Location = New System.Drawing.Point(1002, 326)
        Me.P2BankHolTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P2BankHolTextBox.Name = "P2BankHolTextBox"
        Me.P2BankHolTextBox.Size = New System.Drawing.Size(185, 25)
        Me.P2BankHolTextBox.TabIndex = 1
        '
        'P3OT1TextBox
        '
        Me.P3OT1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P3OT1", True))
        Me.P3OT1TextBox.Location = New System.Drawing.Point(1002, 171)
        Me.P3OT1TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P3OT1TextBox.Name = "P3OT1TextBox"
        Me.P3OT1TextBox.Size = New System.Drawing.Size(185, 25)
        Me.P3OT1TextBox.TabIndex = 1
        '
        'COT1TextBox
        '
        Me.COT1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "COT1", True))
        Me.COT1TextBox.Location = New System.Drawing.Point(1356, 171)
        Me.COT1TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.COT1TextBox.Name = "COT1TextBox"
        Me.COT1TextBox.Size = New System.Drawing.Size(173, 25)
        Me.COT1TextBox.TabIndex = 14
        '
        'P2BasicPayTextBox
        '
        Me.P2BasicPayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P2BasicPay", True))
        Me.P2BasicPayTextBox.Location = New System.Drawing.Point(1002, 140)
        Me.P2BasicPayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P2BasicPayTextBox.Name = "P2BasicPayTextBox"
        Me.P2BasicPayTextBox.Size = New System.Drawing.Size(185, 25)
        Me.P2BasicPayTextBox.TabIndex = 1
        '
        'P3BasicPayTextBox
        '
        Me.P3BasicPayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P3BasicPay", True))
        Me.P3BasicPayTextBox.Location = New System.Drawing.Point(1002, 140)
        Me.P3BasicPayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P3BasicPayTextBox.Name = "P3BasicPayTextBox"
        Me.P3BasicPayTextBox.Size = New System.Drawing.Size(185, 25)
        Me.P3BasicPayTextBox.TabIndex = 1
        '
        'P2SundayTextBox
        '
        Me.P2SundayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P2Sunday", True))
        Me.P2SundayTextBox.Location = New System.Drawing.Point(1002, 295)
        Me.P2SundayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P2SundayTextBox.Name = "P2SundayTextBox"
        Me.P2SundayTextBox.Size = New System.Drawing.Size(185, 25)
        Me.P2SundayTextBox.TabIndex = 1
        '
        'P2OT1TextBox
        '
        Me.P2OT1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P2OT1", True))
        Me.P2OT1TextBox.Location = New System.Drawing.Point(1002, 171)
        Me.P2OT1TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P2OT1TextBox.Name = "P2OT1TextBox"
        Me.P2OT1TextBox.Size = New System.Drawing.Size(185, 25)
        Me.P2OT1TextBox.TabIndex = 1
        '
        'P2OT2TextBox
        '
        Me.P2OT2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P2OT2", True))
        Me.P2OT2TextBox.Location = New System.Drawing.Point(1002, 202)
        Me.P2OT2TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P2OT2TextBox.Name = "P2OT2TextBox"
        Me.P2OT2TextBox.Size = New System.Drawing.Size(185, 25)
        Me.P2OT2TextBox.TabIndex = 1
        '
        'P2SaturdayTextBox
        '
        Me.P2SaturdayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P2Saturday", True))
        Me.P2SaturdayTextBox.Location = New System.Drawing.Point(1002, 264)
        Me.P2SaturdayTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P2SaturdayTextBox.Name = "P2SaturdayTextBox"
        Me.P2SaturdayTextBox.Size = New System.Drawing.Size(185, 25)
        Me.P2SaturdayTextBox.TabIndex = 1
        '
        'P2OT3TextBox
        '
        Me.P2OT3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKJobCategorySitesBindingSource, "P2OT3", True))
        Me.P2OT3TextBox.Location = New System.Drawing.Point(1002, 233)
        Me.P2OT3TextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.P2OT3TextBox.Name = "P2OT3TextBox"
        Me.P2OT3TextBox.Size = New System.Drawing.Size(185, 25)
        Me.P2OT3TextBox.TabIndex = 1
        '
        'HoursPerShift
        '
        Me.HoursPerShift.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FKJobCategorySitesBindingSource, "HoursPerShift", True))
        Me.HoursPerShift.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.HoursPerShift.Location = New System.Drawing.Point(652, 650)
        Me.HoursPerShift.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HoursPerShift.Name = "HoursPerShift"
        Me.HoursPerShift.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.HoursPerShift.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.HoursPerShift.Size = New System.Drawing.Size(181, 22)
        Me.HoursPerShift.StyleController = Me.LayoutControl3
        Me.HoursPerShift.TabIndex = 41
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup5.GroupBordersVisible = False
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1, Me.LayoutControlItem112, Me.LayoutControlItem110, Me.LayoutControlItem113, Me.LayoutControlItem114, Me.LayoutControlItem115, Me.LayoutControlItem116, Me.LayoutControlItem117, Me.LayoutControlItem118, Me.LayoutControlItem119, Me.LayoutControlItem120, Me.LayoutControlItem121, Me.LayoutControlItem122, Me.LayoutControlItem123, Me.LayoutControlItem124, Me.LayoutControlItem125, Me.LayoutControlItem126, Me.LayoutControlItem127, Me.LayoutControlItem128, Me.LayoutControlItem129, Me.SplitterItem1, Me.EmptySpaceItem2, Me.SplitterItem2, Me.LayoutControlItem131, Me.LayoutControlItem130, Me.LayoutControlItem160, Me.LayoutControlItem159, Me.LayoutControlItem165})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "Root"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(1575, 729)
        Me.LayoutControlGroup5.TextVisible = False
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(823, 44)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup6
        Me.TabbedControlGroup1.SelectedTabPageIndex = 0
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(726, 643)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup6, Me.LayoutControlGroup9, Me.LayoutControlGroup12, Me.LayoutControlGroup15})
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup7, Me.LayoutControlGroup8, Me.LayoutControlItem58})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(696, 586)
        Me.LayoutControlGroup6.Text = "Basic Rate"
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem42, Me.LayoutControlItem43, Me.LayoutControlItem44, Me.LayoutControlItem45, Me.LayoutControlItem46, Me.LayoutControlItem48, Me.LayoutControlItem47, Me.LayoutControlItem49})
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup7.Name = "LayoutControlGroup7"
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(354, 301)
        Me.LayoutControlGroup7.Text = "Pay"
        '
        'LayoutControlItem42
        '
        Me.LayoutControlItem42.Control = Me.PNightsOutTextBox
        Me.LayoutControlItem42.Location = New System.Drawing.Point(0, 217)
        Me.LayoutControlItem42.Name = "LayoutControlItem42"
        Me.LayoutControlItem42.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem42.Text = "Nights Out:"
        Me.LayoutControlItem42.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem43
        '
        Me.LayoutControlItem43.Control = Me.PBankHolTextBox
        Me.LayoutControlItem43.Location = New System.Drawing.Point(0, 186)
        Me.LayoutControlItem43.Name = "LayoutControlItem43"
        Me.LayoutControlItem43.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem43.Text = "Bank Hol:"
        Me.LayoutControlItem43.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem44
        '
        Me.LayoutControlItem44.Control = Me.PSundayTextBox
        Me.LayoutControlItem44.Location = New System.Drawing.Point(0, 155)
        Me.LayoutControlItem44.Name = "LayoutControlItem44"
        Me.LayoutControlItem44.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem44.Text = "Sunday:"
        Me.LayoutControlItem44.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem45
        '
        Me.LayoutControlItem45.Control = Me.PSaturdayTextBox
        Me.LayoutControlItem45.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem45.Name = "LayoutControlItem45"
        Me.LayoutControlItem45.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem45.Text = "Saturday:"
        Me.LayoutControlItem45.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem46
        '
        Me.LayoutControlItem46.Control = Me.POT3TextBox
        Me.LayoutControlItem46.Location = New System.Drawing.Point(0, 93)
        Me.LayoutControlItem46.Name = "LayoutControlItem46"
        Me.LayoutControlItem46.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem46.Text = "OT3:"
        Me.LayoutControlItem46.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem48
        '
        Me.LayoutControlItem48.Control = Me.POT1TextBox
        Me.LayoutControlItem48.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem48.Name = "LayoutControlItem48"
        Me.LayoutControlItem48.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem48.Text = "OT1:"
        Me.LayoutControlItem48.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem47
        '
        Me.LayoutControlItem47.Control = Me.POT2TextBox
        Me.LayoutControlItem47.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem47.Name = "LayoutControlItem47"
        Me.LayoutControlItem47.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem47.Text = "OT2:"
        Me.LayoutControlItem47.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem49
        '
        Me.LayoutControlItem49.Control = Me.PBasicPayTextBox
        Me.LayoutControlItem49.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem49.Name = "LayoutControlItem49"
        Me.LayoutControlItem49.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem49.Text = "Basic Pay:"
        Me.LayoutControlItem49.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlGroup8
        '
        Me.LayoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem50, Me.LayoutControlItem51, Me.LayoutControlItem52, Me.LayoutControlItem53, Me.LayoutControlItem54, Me.LayoutControlItem55, Me.LayoutControlItem56, Me.LayoutControlItem57})
        Me.LayoutControlGroup8.Location = New System.Drawing.Point(354, 0)
        Me.LayoutControlGroup8.Name = "LayoutControlGroup8"
        Me.LayoutControlGroup8.Size = New System.Drawing.Size(342, 301)
        Me.LayoutControlGroup8.Text = "Charge"
        '
        'LayoutControlItem50
        '
        Me.LayoutControlItem50.Control = Me.CBasicPayTextBox
        Me.LayoutControlItem50.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem50.Name = "LayoutControlItem50"
        Me.LayoutControlItem50.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem50.Text = "Basic Charge:"
        Me.LayoutControlItem50.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem51
        '
        Me.LayoutControlItem51.Control = Me.COT1TextBox
        Me.LayoutControlItem51.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem51.Name = "LayoutControlItem51"
        Me.LayoutControlItem51.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem51.Text = "OT1:"
        Me.LayoutControlItem51.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem52
        '
        Me.LayoutControlItem52.Control = Me.COT2TextBox
        Me.LayoutControlItem52.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem52.Name = "LayoutControlItem52"
        Me.LayoutControlItem52.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem52.Text = "OT2:"
        Me.LayoutControlItem52.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem53
        '
        Me.LayoutControlItem53.Control = Me.COT3TextBox
        Me.LayoutControlItem53.Location = New System.Drawing.Point(0, 93)
        Me.LayoutControlItem53.Name = "LayoutControlItem53"
        Me.LayoutControlItem53.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem53.Text = "OT3:"
        Me.LayoutControlItem53.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem54
        '
        Me.LayoutControlItem54.Control = Me.CSaturdayTextBox
        Me.LayoutControlItem54.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem54.Name = "LayoutControlItem54"
        Me.LayoutControlItem54.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem54.Text = "Saturday:"
        Me.LayoutControlItem54.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem55
        '
        Me.LayoutControlItem55.Control = Me.CSundayTextBox
        Me.LayoutControlItem55.Location = New System.Drawing.Point(0, 155)
        Me.LayoutControlItem55.Name = "LayoutControlItem55"
        Me.LayoutControlItem55.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem55.Text = "Sunday:"
        Me.LayoutControlItem55.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem56
        '
        Me.LayoutControlItem56.Control = Me.CBankHolTextBox
        Me.LayoutControlItem56.Location = New System.Drawing.Point(0, 186)
        Me.LayoutControlItem56.Name = "LayoutControlItem56"
        Me.LayoutControlItem56.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem56.Text = "Bank Hol:"
        Me.LayoutControlItem56.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem57
        '
        Me.LayoutControlItem57.Control = Me.CNightsOutTextBox
        Me.LayoutControlItem57.Location = New System.Drawing.Point(0, 217)
        Me.LayoutControlItem57.Name = "LayoutControlItem57"
        Me.LayoutControlItem57.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem57.Text = "Nights Out:"
        Me.LayoutControlItem57.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem58
        '
        Me.LayoutControlItem58.Control = Me.MemoEdit1
        Me.LayoutControlItem58.Location = New System.Drawing.Point(0, 301)
        Me.LayoutControlItem58.Name = "LayoutControlItem58"
        Me.LayoutControlItem58.Size = New System.Drawing.Size(696, 285)
        Me.LayoutControlItem58.Text = "Rules Or Details:"
        Me.LayoutControlItem58.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem58.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlGroup9
        '
        Me.LayoutControlGroup9.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup10, Me.LayoutControlGroup11, Me.LayoutControlItem75})
        Me.LayoutControlGroup9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup9.Name = "LayoutControlGroup9"
        Me.LayoutControlGroup9.Size = New System.Drawing.Size(696, 586)
        Me.LayoutControlGroup9.Text = "AWR 13th Week Rate"
        '
        'LayoutControlGroup10
        '
        Me.LayoutControlGroup10.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem59, Me.LayoutControlItem60, Me.LayoutControlItem61, Me.LayoutControlItem62, Me.LayoutControlItem63, Me.LayoutControlItem64, Me.LayoutControlItem65, Me.LayoutControlItem66})
        Me.LayoutControlGroup10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup10.Name = "LayoutControlGroup10"
        Me.LayoutControlGroup10.Size = New System.Drawing.Size(354, 301)
        Me.LayoutControlGroup10.Text = "Pay"
        '
        'LayoutControlItem59
        '
        Me.LayoutControlItem59.Control = Me.P2BasicPayTextBox
        Me.LayoutControlItem59.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem59.Name = "LayoutControlItem59"
        Me.LayoutControlItem59.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem59.Text = "Basic Pay:"
        Me.LayoutControlItem59.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem60
        '
        Me.LayoutControlItem60.Control = Me.P2OT1TextBox
        Me.LayoutControlItem60.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem60.Name = "LayoutControlItem60"
        Me.LayoutControlItem60.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem60.Text = "OT1:"
        Me.LayoutControlItem60.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem61
        '
        Me.LayoutControlItem61.Control = Me.P2OT2TextBox
        Me.LayoutControlItem61.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem61.Name = "LayoutControlItem61"
        Me.LayoutControlItem61.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem61.Text = "OT2:"
        Me.LayoutControlItem61.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem62
        '
        Me.LayoutControlItem62.Control = Me.P2OT3TextBox
        Me.LayoutControlItem62.Location = New System.Drawing.Point(0, 93)
        Me.LayoutControlItem62.Name = "LayoutControlItem62"
        Me.LayoutControlItem62.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem62.Text = "OT3:"
        Me.LayoutControlItem62.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem63
        '
        Me.LayoutControlItem63.Control = Me.P2SaturdayTextBox
        Me.LayoutControlItem63.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem63.Name = "LayoutControlItem63"
        Me.LayoutControlItem63.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem63.Text = "Saturday:"
        Me.LayoutControlItem63.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem64
        '
        Me.LayoutControlItem64.Control = Me.P2SundayTextBox
        Me.LayoutControlItem64.Location = New System.Drawing.Point(0, 155)
        Me.LayoutControlItem64.Name = "LayoutControlItem64"
        Me.LayoutControlItem64.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem64.Text = "Sunday:"
        Me.LayoutControlItem64.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem65
        '
        Me.LayoutControlItem65.Control = Me.P2BankHolTextBox
        Me.LayoutControlItem65.Location = New System.Drawing.Point(0, 186)
        Me.LayoutControlItem65.Name = "LayoutControlItem65"
        Me.LayoutControlItem65.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem65.Text = "Bank Hol:"
        Me.LayoutControlItem65.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem66
        '
        Me.LayoutControlItem66.Control = Me.P2NightsOutTextBox
        Me.LayoutControlItem66.Location = New System.Drawing.Point(0, 217)
        Me.LayoutControlItem66.Name = "LayoutControlItem66"
        Me.LayoutControlItem66.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem66.Text = "Nights Out:"
        Me.LayoutControlItem66.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlGroup11
        '
        Me.LayoutControlGroup11.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem68, Me.LayoutControlItem67, Me.LayoutControlItem69, Me.LayoutControlItem70, Me.LayoutControlItem71, Me.LayoutControlItem72, Me.LayoutControlItem73, Me.LayoutControlItem74})
        Me.LayoutControlGroup11.Location = New System.Drawing.Point(354, 0)
        Me.LayoutControlGroup11.Name = "LayoutControlGroup11"
        Me.LayoutControlGroup11.Size = New System.Drawing.Size(342, 301)
        Me.LayoutControlGroup11.Text = "Charge"
        '
        'LayoutControlItem68
        '
        Me.LayoutControlItem68.Control = Me.C2OT1TextBox
        Me.LayoutControlItem68.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem68.Name = "LayoutControlItem68"
        Me.LayoutControlItem68.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem68.Text = "OT1:"
        Me.LayoutControlItem68.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem67
        '
        Me.LayoutControlItem67.Control = Me.C2BasicPayTextBox
        Me.LayoutControlItem67.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem67.Name = "LayoutControlItem67"
        Me.LayoutControlItem67.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem67.Text = "Basic Charge:"
        Me.LayoutControlItem67.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem69
        '
        Me.LayoutControlItem69.Control = Me.C2OT2TextBox
        Me.LayoutControlItem69.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem69.Name = "LayoutControlItem69"
        Me.LayoutControlItem69.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem69.Text = "OT2:"
        Me.LayoutControlItem69.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem70
        '
        Me.LayoutControlItem70.Control = Me.C2OT3TextBox
        Me.LayoutControlItem70.Location = New System.Drawing.Point(0, 93)
        Me.LayoutControlItem70.Name = "LayoutControlItem70"
        Me.LayoutControlItem70.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem70.Text = "OT3:"
        Me.LayoutControlItem70.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem71
        '
        Me.LayoutControlItem71.Control = Me.C2SaturdayTextBox
        Me.LayoutControlItem71.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem71.Name = "LayoutControlItem71"
        Me.LayoutControlItem71.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem71.Text = "Saturday:"
        Me.LayoutControlItem71.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem72
        '
        Me.LayoutControlItem72.Control = Me.C2SundayTextBox
        Me.LayoutControlItem72.Location = New System.Drawing.Point(0, 155)
        Me.LayoutControlItem72.Name = "LayoutControlItem72"
        Me.LayoutControlItem72.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem72.Text = "Sunday:"
        Me.LayoutControlItem72.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem73
        '
        Me.LayoutControlItem73.Control = Me.C2BankHolTextBox
        Me.LayoutControlItem73.Location = New System.Drawing.Point(0, 186)
        Me.LayoutControlItem73.Name = "LayoutControlItem73"
        Me.LayoutControlItem73.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem73.Text = "Bank Hol:"
        Me.LayoutControlItem73.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem74
        '
        Me.LayoutControlItem74.Control = Me.C2NightsOutTextBox
        Me.LayoutControlItem74.Location = New System.Drawing.Point(0, 217)
        Me.LayoutControlItem74.Name = "LayoutControlItem74"
        Me.LayoutControlItem74.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem74.Text = "Nights Out:"
        Me.LayoutControlItem74.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem75
        '
        Me.LayoutControlItem75.Control = Me.MemoEdit2
        Me.LayoutControlItem75.Location = New System.Drawing.Point(0, 301)
        Me.LayoutControlItem75.Name = "LayoutControlItem75"
        Me.LayoutControlItem75.Size = New System.Drawing.Size(696, 285)
        Me.LayoutControlItem75.Text = "Rules Or Details:"
        Me.LayoutControlItem75.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem75.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlGroup12
        '
        Me.LayoutControlGroup12.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup13, Me.LayoutControlGroup14, Me.LayoutControlItem92})
        Me.LayoutControlGroup12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup12.Name = "LayoutControlGroup12"
        Me.LayoutControlGroup12.Size = New System.Drawing.Size(696, 586)
        Me.LayoutControlGroup12.Text = "Rate 2"
        '
        'LayoutControlGroup13
        '
        Me.LayoutControlGroup13.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem79, Me.LayoutControlItem78, Me.LayoutControlItem77, Me.LayoutControlItem76, Me.LayoutControlItem80, Me.LayoutControlItem81, Me.LayoutControlItem82, Me.LayoutControlItem83})
        Me.LayoutControlGroup13.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup13.Name = "LayoutControlGroup13"
        Me.LayoutControlGroup13.Size = New System.Drawing.Size(354, 301)
        Me.LayoutControlGroup13.Text = "Pay:"
        '
        'LayoutControlItem79
        '
        Me.LayoutControlItem79.Control = Me.P3OT3TextBox
        Me.LayoutControlItem79.Location = New System.Drawing.Point(0, 93)
        Me.LayoutControlItem79.Name = "LayoutControlItem79"
        Me.LayoutControlItem79.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem79.Text = "OT3:"
        Me.LayoutControlItem79.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem78
        '
        Me.LayoutControlItem78.Control = Me.P3OT2TextBox
        Me.LayoutControlItem78.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem78.Name = "LayoutControlItem78"
        Me.LayoutControlItem78.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem78.Text = "OT2:"
        Me.LayoutControlItem78.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem77
        '
        Me.LayoutControlItem77.Control = Me.P3OT1TextBox
        Me.LayoutControlItem77.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem77.Name = "LayoutControlItem77"
        Me.LayoutControlItem77.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem77.Text = "OT1:"
        Me.LayoutControlItem77.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem76
        '
        Me.LayoutControlItem76.Control = Me.P3BasicPayTextBox
        Me.LayoutControlItem76.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem76.Name = "LayoutControlItem76"
        Me.LayoutControlItem76.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem76.Text = "Basic Pay:"
        Me.LayoutControlItem76.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem80
        '
        Me.LayoutControlItem80.Control = Me.P3SaturdayTextBox
        Me.LayoutControlItem80.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem80.Name = "LayoutControlItem80"
        Me.LayoutControlItem80.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem80.Text = "Saturday:"
        Me.LayoutControlItem80.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem81
        '
        Me.LayoutControlItem81.Control = Me.P3SundayTextBox
        Me.LayoutControlItem81.Location = New System.Drawing.Point(0, 155)
        Me.LayoutControlItem81.Name = "LayoutControlItem81"
        Me.LayoutControlItem81.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem81.Text = "Sunday:"
        Me.LayoutControlItem81.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem82
        '
        Me.LayoutControlItem82.Control = Me.P3BankHolTextBox
        Me.LayoutControlItem82.Location = New System.Drawing.Point(0, 186)
        Me.LayoutControlItem82.Name = "LayoutControlItem82"
        Me.LayoutControlItem82.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem82.Text = "Bank Hol:"
        Me.LayoutControlItem82.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem83
        '
        Me.LayoutControlItem83.Control = Me.P3NightsOutTextBox
        Me.LayoutControlItem83.Location = New System.Drawing.Point(0, 217)
        Me.LayoutControlItem83.Name = "LayoutControlItem83"
        Me.LayoutControlItem83.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem83.Text = "Nights Out:"
        Me.LayoutControlItem83.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlGroup14
        '
        Me.LayoutControlGroup14.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem85, Me.LayoutControlItem84, Me.LayoutControlItem86, Me.LayoutControlItem87, Me.LayoutControlItem88, Me.LayoutControlItem89, Me.LayoutControlItem90, Me.LayoutControlItem91})
        Me.LayoutControlGroup14.Location = New System.Drawing.Point(354, 0)
        Me.LayoutControlGroup14.Name = "LayoutControlGroup14"
        Me.LayoutControlGroup14.Size = New System.Drawing.Size(342, 301)
        Me.LayoutControlGroup14.Text = "Charge:"
        '
        'LayoutControlItem85
        '
        Me.LayoutControlItem85.Control = Me.C3OT1TextBox
        Me.LayoutControlItem85.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem85.Name = "LayoutControlItem85"
        Me.LayoutControlItem85.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem85.Text = "OT1:"
        Me.LayoutControlItem85.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem84
        '
        Me.LayoutControlItem84.Control = Me.C3BasicPayTextBox
        Me.LayoutControlItem84.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem84.Name = "LayoutControlItem84"
        Me.LayoutControlItem84.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem84.Text = "Basic Charge:"
        Me.LayoutControlItem84.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem86
        '
        Me.LayoutControlItem86.Control = Me.C3OT2TextBox
        Me.LayoutControlItem86.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem86.Name = "LayoutControlItem86"
        Me.LayoutControlItem86.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem86.Text = "OT2:"
        Me.LayoutControlItem86.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem87
        '
        Me.LayoutControlItem87.Control = Me.C3OT3TextBox
        Me.LayoutControlItem87.Location = New System.Drawing.Point(0, 93)
        Me.LayoutControlItem87.Name = "LayoutControlItem87"
        Me.LayoutControlItem87.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem87.Text = "OT3:"
        Me.LayoutControlItem87.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem88
        '
        Me.LayoutControlItem88.Control = Me.C3SaturdayTextBox
        Me.LayoutControlItem88.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem88.Name = "LayoutControlItem88"
        Me.LayoutControlItem88.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem88.Text = "Saturday:"
        Me.LayoutControlItem88.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem89
        '
        Me.LayoutControlItem89.Control = Me.C3SundayTextBox
        Me.LayoutControlItem89.Location = New System.Drawing.Point(0, 155)
        Me.LayoutControlItem89.Name = "LayoutControlItem89"
        Me.LayoutControlItem89.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem89.Text = "Sunday:"
        Me.LayoutControlItem89.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem90
        '
        Me.LayoutControlItem90.Control = Me.C3BankHolTextBox
        Me.LayoutControlItem90.Location = New System.Drawing.Point(0, 186)
        Me.LayoutControlItem90.Name = "LayoutControlItem90"
        Me.LayoutControlItem90.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem90.Text = "Bank Hol:"
        Me.LayoutControlItem90.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem91
        '
        Me.LayoutControlItem91.Control = Me.C3NightsOutTextBox
        Me.LayoutControlItem91.Location = New System.Drawing.Point(0, 217)
        Me.LayoutControlItem91.Name = "LayoutControlItem91"
        Me.LayoutControlItem91.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem91.Text = "Nights Out:"
        Me.LayoutControlItem91.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem92
        '
        Me.LayoutControlItem92.Control = Me.MemoEdit3
        Me.LayoutControlItem92.Location = New System.Drawing.Point(0, 301)
        Me.LayoutControlItem92.Name = "LayoutControlItem92"
        Me.LayoutControlItem92.Size = New System.Drawing.Size(696, 285)
        Me.LayoutControlItem92.Text = "Rules Or Details:"
        Me.LayoutControlItem92.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem92.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlGroup15
        '
        Me.LayoutControlGroup15.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup16, Me.LayoutControlGroup17, Me.LayoutControlItem109})
        Me.LayoutControlGroup15.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup15.Name = "LayoutControlGroup15"
        Me.LayoutControlGroup15.Size = New System.Drawing.Size(696, 586)
        Me.LayoutControlGroup15.Text = "Rate 3"
        '
        'LayoutControlGroup16
        '
        Me.LayoutControlGroup16.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem100, Me.LayoutControlItem98, Me.LayoutControlItem99, Me.LayoutControlItem97, Me.LayoutControlItem96, Me.LayoutControlItem95, Me.LayoutControlItem94, Me.LayoutControlItem93})
        Me.LayoutControlGroup16.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup16.Name = "LayoutControlGroup16"
        Me.LayoutControlGroup16.Size = New System.Drawing.Size(354, 301)
        Me.LayoutControlGroup16.Text = "Pay:"
        '
        'LayoutControlItem100
        '
        Me.LayoutControlItem100.Control = Me.P4NightsOutTextBox
        Me.LayoutControlItem100.Location = New System.Drawing.Point(0, 217)
        Me.LayoutControlItem100.Name = "LayoutControlItem100"
        Me.LayoutControlItem100.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem100.Text = "Nights Out:"
        Me.LayoutControlItem100.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem98
        '
        Me.LayoutControlItem98.Control = Me.P4SundayTextBox
        Me.LayoutControlItem98.Location = New System.Drawing.Point(0, 155)
        Me.LayoutControlItem98.Name = "LayoutControlItem98"
        Me.LayoutControlItem98.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem98.Text = "Sunday:"
        Me.LayoutControlItem98.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem99
        '
        Me.LayoutControlItem99.Control = Me.P4BankHolTextBox
        Me.LayoutControlItem99.Location = New System.Drawing.Point(0, 186)
        Me.LayoutControlItem99.Name = "LayoutControlItem99"
        Me.LayoutControlItem99.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem99.Text = "Bank Hol:"
        Me.LayoutControlItem99.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem97
        '
        Me.LayoutControlItem97.Control = Me.P4SaturdayTextBox
        Me.LayoutControlItem97.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem97.Name = "LayoutControlItem97"
        Me.LayoutControlItem97.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem97.Text = "Saturday:"
        Me.LayoutControlItem97.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem96
        '
        Me.LayoutControlItem96.Control = Me.P4OT3TextBox
        Me.LayoutControlItem96.Location = New System.Drawing.Point(0, 93)
        Me.LayoutControlItem96.Name = "LayoutControlItem96"
        Me.LayoutControlItem96.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem96.Text = "OT3:"
        Me.LayoutControlItem96.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem95
        '
        Me.LayoutControlItem95.Control = Me.P4OT2TextBox
        Me.LayoutControlItem95.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem95.Name = "LayoutControlItem95"
        Me.LayoutControlItem95.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem95.Text = "OT2:"
        Me.LayoutControlItem95.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem94
        '
        Me.LayoutControlItem94.Control = Me.P4OT1TextBox
        Me.LayoutControlItem94.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem94.Name = "LayoutControlItem94"
        Me.LayoutControlItem94.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem94.Text = "OT1:"
        Me.LayoutControlItem94.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem93
        '
        Me.LayoutControlItem93.Control = Me.P4BasicPayTextBox
        Me.LayoutControlItem93.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem93.Name = "LayoutControlItem93"
        Me.LayoutControlItem93.Size = New System.Drawing.Size(324, 31)
        Me.LayoutControlItem93.Text = "Basic Pay:"
        Me.LayoutControlItem93.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlGroup17
        '
        Me.LayoutControlGroup17.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem108, Me.LayoutControlItem107, Me.LayoutControlItem106, Me.LayoutControlItem105, Me.LayoutControlItem103, Me.LayoutControlItem104, Me.LayoutControlItem102, Me.LayoutControlItem101})
        Me.LayoutControlGroup17.Location = New System.Drawing.Point(354, 0)
        Me.LayoutControlGroup17.Name = "LayoutControlGroup17"
        Me.LayoutControlGroup17.Size = New System.Drawing.Size(342, 301)
        Me.LayoutControlGroup17.Text = "Charge"
        '
        'LayoutControlItem108
        '
        Me.LayoutControlItem108.Control = Me.C4NightsOutTextBox
        Me.LayoutControlItem108.Location = New System.Drawing.Point(0, 217)
        Me.LayoutControlItem108.Name = "LayoutControlItem108"
        Me.LayoutControlItem108.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem108.Text = "Nights Out:"
        Me.LayoutControlItem108.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem107
        '
        Me.LayoutControlItem107.Control = Me.C4BankHolTextBox
        Me.LayoutControlItem107.Location = New System.Drawing.Point(0, 186)
        Me.LayoutControlItem107.Name = "LayoutControlItem107"
        Me.LayoutControlItem107.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem107.Text = "Bank Hol:"
        Me.LayoutControlItem107.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem106
        '
        Me.LayoutControlItem106.Control = Me.C4SundayTextBox
        Me.LayoutControlItem106.Location = New System.Drawing.Point(0, 155)
        Me.LayoutControlItem106.Name = "LayoutControlItem106"
        Me.LayoutControlItem106.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem106.Text = "Sunday:"
        Me.LayoutControlItem106.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem105
        '
        Me.LayoutControlItem105.Control = Me.C4SaturdayTextBox
        Me.LayoutControlItem105.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem105.Name = "LayoutControlItem105"
        Me.LayoutControlItem105.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem105.Text = "Saturday:"
        Me.LayoutControlItem105.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem103
        '
        Me.LayoutControlItem103.Control = Me.C4OT2TextBox
        Me.LayoutControlItem103.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem103.Name = "LayoutControlItem103"
        Me.LayoutControlItem103.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem103.Text = "OT2:"
        Me.LayoutControlItem103.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem104
        '
        Me.LayoutControlItem104.Control = Me.C4OT3TextBox
        Me.LayoutControlItem104.Location = New System.Drawing.Point(0, 93)
        Me.LayoutControlItem104.Name = "LayoutControlItem104"
        Me.LayoutControlItem104.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem104.Text = "OT3:"
        Me.LayoutControlItem104.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem102
        '
        Me.LayoutControlItem102.Control = Me.C4OT1TextBox
        Me.LayoutControlItem102.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem102.Name = "LayoutControlItem102"
        Me.LayoutControlItem102.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem102.Text = "OT1:"
        Me.LayoutControlItem102.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem101
        '
        Me.LayoutControlItem101.Control = Me.C4BasicPayTextBox
        Me.LayoutControlItem101.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem101.Name = "LayoutControlItem101"
        Me.LayoutControlItem101.Size = New System.Drawing.Size(312, 31)
        Me.LayoutControlItem101.Text = "Basic Charge:"
        Me.LayoutControlItem101.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem109
        '
        Me.LayoutControlItem109.Control = Me.MemoEdit4
        Me.LayoutControlItem109.Location = New System.Drawing.Point(0, 301)
        Me.LayoutControlItem109.Name = "LayoutControlItem109"
        Me.LayoutControlItem109.Size = New System.Drawing.Size(696, 285)
        Me.LayoutControlItem109.Text = "Rules Or Details:"
        Me.LayoutControlItem109.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem109.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem112
        '
        Me.LayoutControlItem112.Control = Me.JobCategoryTextBox
        Me.LayoutControlItem112.Location = New System.Drawing.Point(503, 72)
        Me.LayoutControlItem112.Name = "LayoutControlItem112"
        Me.LayoutControlItem112.Size = New System.Drawing.Size(320, 31)
        Me.LayoutControlItem112.Text = "Job Category:"
        Me.LayoutControlItem112.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem110
        '
        Me.LayoutControlItem110.Control = Me.BindingNavigator1
        Me.LayoutControlItem110.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem110.Name = "LayoutControlItem110"
        Me.LayoutControlItem110.Size = New System.Drawing.Size(1549, 44)
        Me.LayoutControlItem110.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem110.TextVisible = False
        '
        'LayoutControlItem113
        '
        Me.LayoutControlItem113.Control = Me.ShiftNameTextBox
        Me.LayoutControlItem113.Location = New System.Drawing.Point(503, 103)
        Me.LayoutControlItem113.Name = "LayoutControlItem113"
        Me.LayoutControlItem113.Size = New System.Drawing.Size(320, 31)
        Me.LayoutControlItem113.Text = "Shift Name:"
        Me.LayoutControlItem113.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem114
        '
        Me.LayoutControlItem114.Control = Me.TypicalStartTimeTextBox
        Me.LayoutControlItem114.Location = New System.Drawing.Point(503, 134)
        Me.LayoutControlItem114.Name = "LayoutControlItem114"
        Me.LayoutControlItem114.Size = New System.Drawing.Size(320, 31)
        Me.LayoutControlItem114.Text = "Typical Start Time:"
        Me.LayoutControlItem114.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem115
        '
        Me.LayoutControlItem115.Control = Me.TypicalEndTimeTextBox
        Me.LayoutControlItem115.Location = New System.Drawing.Point(503, 165)
        Me.LayoutControlItem115.Name = "LayoutControlItem115"
        Me.LayoutControlItem115.Size = New System.Drawing.Size(320, 31)
        Me.LayoutControlItem115.Text = "Typical End Time:"
        Me.LayoutControlItem115.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem116
        '
        Me.LayoutControlItem116.Control = Me.BreakEntitlementTextBox
        Me.LayoutControlItem116.Location = New System.Drawing.Point(503, 196)
        Me.LayoutControlItem116.Name = "LayoutControlItem116"
        Me.LayoutControlItem116.Size = New System.Drawing.Size(320, 31)
        Me.LayoutControlItem116.Text = "Break Entitlement:"
        Me.LayoutControlItem116.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem117
        '
        Me.LayoutControlItem117.Control = Me.BreakDeductedCheckBox
        Me.LayoutControlItem117.Location = New System.Drawing.Point(503, 227)
        Me.LayoutControlItem117.Name = "LayoutControlItem117"
        Me.LayoutControlItem117.Size = New System.Drawing.Size(153, 31)
        Me.LayoutControlItem117.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem117.TextVisible = False
        '
        'LayoutControlItem118
        '
        Me.LayoutControlItem118.Control = Me.TimesheetContactComboBox
        Me.LayoutControlItem118.Location = New System.Drawing.Point(503, 258)
        Me.LayoutControlItem118.Name = "LayoutControlItem118"
        Me.LayoutControlItem118.Size = New System.Drawing.Size(320, 32)
        Me.LayoutControlItem118.Text = "Time Sheet Contact:"
        Me.LayoutControlItem118.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem119
        '
        Me.LayoutControlItem119.Control = Me.TimeSheetSentViaTextBox
        Me.LayoutControlItem119.Location = New System.Drawing.Point(503, 290)
        Me.LayoutControlItem119.Name = "LayoutControlItem119"
        Me.LayoutControlItem119.Size = New System.Drawing.Size(320, 31)
        Me.LayoutControlItem119.Text = "Time Sheet Sent Via:"
        Me.LayoutControlItem119.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem120
        '
        Me.LayoutControlItem120.Control = Me.TimesheetTypeComboBox
        Me.LayoutControlItem120.Location = New System.Drawing.Point(503, 321)
        Me.LayoutControlItem120.Name = "LayoutControlItem120"
        Me.LayoutControlItem120.Size = New System.Drawing.Size(320, 32)
        Me.LayoutControlItem120.Text = "Time Sheet Type:"
        Me.LayoutControlItem120.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem121
        '
        Me.LayoutControlItem121.Control = Me.NotesForTimeSheetTextBox
        Me.LayoutControlItem121.Location = New System.Drawing.Point(503, 353)
        Me.LayoutControlItem121.Name = "LayoutControlItem121"
        Me.LayoutControlItem121.Size = New System.Drawing.Size(320, 31)
        Me.LayoutControlItem121.Text = "Notes For Time Sheet:"
        Me.LayoutControlItem121.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem122
        '
        Me.LayoutControlItem122.Control = Me.ComboBox1
        Me.LayoutControlItem122.Location = New System.Drawing.Point(503, 384)
        Me.LayoutControlItem122.Name = "LayoutControlItem122"
        Me.LayoutControlItem122.Size = New System.Drawing.Size(320, 32)
        Me.LayoutControlItem122.Text = "Start Of Week:"
        Me.LayoutControlItem122.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem123
        '
        Me.LayoutControlItem123.Control = Me.DHHTextBox
        Me.LayoutControlItem123.Location = New System.Drawing.Point(503, 416)
        Me.LayoutControlItem123.Name = "LayoutControlItem123"
        Me.LayoutControlItem123.Size = New System.Drawing.Size(320, 31)
        Me.LayoutControlItem123.Text = "DHH:"
        Me.LayoutControlItem123.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem124
        '
        Me.LayoutControlItem124.Control = Me.MinChargePerDayTextBox
        Me.LayoutControlItem124.Location = New System.Drawing.Point(503, 447)
        Me.LayoutControlItem124.Name = "LayoutControlItem124"
        Me.LayoutControlItem124.Size = New System.Drawing.Size(320, 31)
        Me.LayoutControlItem124.Text = "Min Charge Per Day:"
        Me.LayoutControlItem124.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem125
        '
        Me.LayoutControlItem125.Control = Me.TempToPermAfterTextBox
        Me.LayoutControlItem125.Location = New System.Drawing.Point(503, 478)
        Me.LayoutControlItem125.Name = "LayoutControlItem125"
        Me.LayoutControlItem125.Size = New System.Drawing.Size(320, 31)
        Me.LayoutControlItem125.Text = "Temp To Perm After:"
        Me.LayoutControlItem125.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem126
        '
        Me.LayoutControlItem126.Control = Me.SWHTextBox
        Me.LayoutControlItem126.Location = New System.Drawing.Point(503, 509)
        Me.LayoutControlItem126.MinSize = New System.Drawing.Size(164, 31)
        Me.LayoutControlItem126.Name = "LayoutControlItem126"
        Me.LayoutControlItem126.Size = New System.Drawing.Size(320, 31)
        Me.LayoutControlItem126.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem126.Text = "SWH:"
        Me.LayoutControlItem126.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem127
        '
        Me.LayoutControlItem127.Control = Me.LastModifiedUserTextBox
        Me.LayoutControlItem127.Location = New System.Drawing.Point(503, 540)
        Me.LayoutControlItem127.Name = "LayoutControlItem127"
        Me.LayoutControlItem127.Size = New System.Drawing.Size(320, 31)
        Me.LayoutControlItem127.Text = "Last Modified User:"
        Me.LayoutControlItem127.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem128
        '
        Me.LayoutControlItem128.Control = Me.LastModifiedDateTextBox
        Me.LayoutControlItem128.Location = New System.Drawing.Point(503, 571)
        Me.LayoutControlItem128.Name = "LayoutControlItem128"
        Me.LayoutControlItem128.Size = New System.Drawing.Size(320, 31)
        Me.LayoutControlItem128.Text = "Last Modified Date:"
        Me.LayoutControlItem128.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem129
        '
        Me.LayoutControlItem129.Control = Me.CBJobType
        Me.LayoutControlItem129.Location = New System.Drawing.Point(503, 602)
        Me.LayoutControlItem129.Name = "LayoutControlItem129"
        Me.LayoutControlItem129.Size = New System.Drawing.Size(320, 32)
        Me.LayoutControlItem129.Text = "Job Type:"
        Me.LayoutControlItem129.TextSize = New System.Drawing.Size(130, 16)
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.Location = New System.Drawing.Point(497, 44)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(6, 643)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 693)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(1549, 10)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'SplitterItem2
        '
        Me.SplitterItem2.AllowHotTrack = True
        Me.SplitterItem2.Location = New System.Drawing.Point(0, 687)
        Me.SplitterItem2.Name = "SplitterItem2"
        Me.SplitterItem2.Size = New System.Drawing.Size(1549, 6)
        '
        'LayoutControlItem131
        '
        Me.LayoutControlItem131.Control = Me.GridControl1
        Me.LayoutControlItem131.Location = New System.Drawing.Point(0, 44)
        Me.LayoutControlItem131.Name = "LayoutControlItem131"
        Me.LayoutControlItem131.Size = New System.Drawing.Size(497, 643)
        Me.LayoutControlItem131.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem131.TextVisible = False
        '
        'LayoutControlItem130
        '
        Me.LayoutControlItem130.Control = Me.HoursPerShift
        Me.LayoutControlItem130.Location = New System.Drawing.Point(503, 634)
        Me.LayoutControlItem130.Name = "LayoutControlItem130"
        Me.LayoutControlItem130.Size = New System.Drawing.Size(320, 28)
        Me.LayoutControlItem130.Text = "Hours Per Shift:"
        Me.LayoutControlItem130.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem160
        '
        Me.LayoutControlItem160.Control = Me.JobCatIdSpinEdit
        Me.LayoutControlItem160.Location = New System.Drawing.Point(503, 44)
        Me.LayoutControlItem160.Name = "LayoutControlItem160"
        Me.LayoutControlItem160.Size = New System.Drawing.Size(320, 28)
        Me.LayoutControlItem160.Text = "Job Cat Id:"
        Me.LayoutControlItem160.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem159
        '
        Me.LayoutControlItem159.Control = Me.ArchiveCheckEdit
        Me.LayoutControlItem159.Location = New System.Drawing.Point(503, 662)
        Me.LayoutControlItem159.Name = "LayoutControlItem159"
        Me.LayoutControlItem159.Size = New System.Drawing.Size(320, 25)
        Me.LayoutControlItem159.Text = "Archive"
        Me.LayoutControlItem159.TextSize = New System.Drawing.Size(130, 16)
        '
        'LayoutControlItem165
        '
        Me.LayoutControlItem165.Control = Me.CheckBox1
        Me.LayoutControlItem165.Location = New System.Drawing.Point(656, 227)
        Me.LayoutControlItem165.Name = "LayoutControlItem165"
        Me.LayoutControlItem165.Size = New System.Drawing.Size(167, 31)
        Me.LayoutControlItem165.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem165.TextVisible = False
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.Transparent
        Me.TabPage5.Controls.Add(Me.LayoutControl6)
        Me.TabPage5.Location = New System.Drawing.Point(4, 28)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage5.Size = New System.Drawing.Size(1581, 661)
        Me.TabPage5.TabIndex = 10
        Me.TabPage5.Text = "Head Office"
        '
        'LayoutControl6
        '
        Me.LayoutControl6.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl6.Controls.Add(Me.TextBox1)
        Me.LayoutControl6.Controls.Add(Me.ClientStatusTextEdit)
        Me.LayoutControl6.Controls.Add(Me.ClientStatusReasonTextEdit)
        Me.LayoutControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl6.Location = New System.Drawing.Point(3, 4)
        Me.LayoutControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LayoutControl6.Name = "LayoutControl6"
        Me.LayoutControl6.Root = Me.LayoutControlGroup20
        Me.LayoutControl6.Size = New System.Drawing.Size(1575, 653)
        Me.LayoutControl6.TabIndex = 0
        Me.LayoutControl6.Text = "LayoutControl6"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1416, 92)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(113, 40)
        Me.SimpleButton1.StyleController = Me.LayoutControl6
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "Send"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SitesBindingSource, "ClientsVatRegNo", True))
        Me.TextBox1.Location = New System.Drawing.Point(16, 35)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(133, 25)
        Me.TextBox1.TabIndex = 0
        '
        'ClientStatusTextEdit
        '
        Me.ClientStatusTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SitesBindingSource, "ClientStatus", True))
        Me.ClientStatusTextEdit.Location = New System.Drawing.Point(170, 73)
        Me.ClientStatusTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ClientStatusTextEdit.Name = "ClientStatusTextEdit"
        Me.ClientStatusTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ClientStatusTextEdit.Properties.Items.AddRange(New Object() {"OK", "Archive", "On-Stop", "Blacklist"})
        Me.ClientStatusTextEdit.Size = New System.Drawing.Size(637, 22)
        Me.ClientStatusTextEdit.StyleController = Me.LayoutControl6
        Me.ClientStatusTextEdit.TabIndex = 2
        '
        'ClientStatusReasonTextEdit
        '
        Me.ClientStatusReasonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SitesBindingSource, "ClientStatusReason", True))
        Me.ClientStatusReasonTextEdit.Location = New System.Drawing.Point(813, 73)
        Me.ClientStatusReasonTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ClientStatusReasonTextEdit.Name = "ClientStatusReasonTextEdit"
        Me.ClientStatusReasonTextEdit.Size = New System.Drawing.Size(582, 74)
        Me.ClientStatusReasonTextEdit.StyleController = Me.LayoutControl6
        Me.ClientStatusReasonTextEdit.TabIndex = 3
        '
        'LayoutControlGroup20
        '
        Me.LayoutControlGroup20.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup20.GroupBordersVisible = False
        Me.LayoutControlGroup20.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup21, Me.LayoutControlItem8, Me.EmptySpaceItem6})
        Me.LayoutControlGroup20.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup20.Name = "LayoutControlGroup20"
        Me.LayoutControlGroup20.Size = New System.Drawing.Size(1575, 653)
        Me.LayoutControlGroup20.TextVisible = False
        '
        'LayoutControlGroup21
        '
        Me.LayoutControlGroup21.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem156, Me.LayoutControlItem157, Me.LayoutControlGroup22})
        Me.LayoutControlGroup21.Location = New System.Drawing.Point(139, 0)
        Me.LayoutControlGroup21.Name = "LayoutControlGroup21"
        Me.LayoutControlGroup21.Size = New System.Drawing.Size(1410, 152)
        '
        'LayoutControlItem156
        '
        Me.LayoutControlItem156.Control = Me.ClientStatusTextEdit
        Me.LayoutControlItem156.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem156.Name = "LayoutControlItem156"
        Me.LayoutControlItem156.Size = New System.Drawing.Size(643, 99)
        Me.LayoutControlItem156.Text = "Client Status:"
        Me.LayoutControlItem156.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem156.TextSize = New System.Drawing.Size(123, 16)
        '
        'LayoutControlItem157
        '
        Me.LayoutControlItem157.Control = Me.ClientStatusReasonTextEdit
        Me.LayoutControlItem157.Location = New System.Drawing.Point(643, 0)
        Me.LayoutControlItem157.Name = "LayoutControlItem157"
        Me.LayoutControlItem157.Size = New System.Drawing.Size(588, 99)
        Me.LayoutControlItem157.Text = "Client Status Reason:"
        Me.LayoutControlItem157.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem157.TextSize = New System.Drawing.Size(123, 16)
        '
        'LayoutControlGroup22
        '
        Me.LayoutControlGroup22.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem155})
        Me.LayoutControlGroup22.Location = New System.Drawing.Point(1231, 0)
        Me.LayoutControlGroup22.Name = "LayoutControlGroup22"
        Me.LayoutControlGroup22.Size = New System.Drawing.Size(149, 99)
        Me.LayoutControlGroup22.Text = "E-Mail Alert"
        '
        'LayoutControlItem155
        '
        Me.LayoutControlItem155.Control = Me.SimpleButton1
        Me.LayoutControlItem155.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem155.Name = "LayoutControlItem155"
        Me.LayoutControlItem155.Size = New System.Drawing.Size(119, 46)
        Me.LayoutControlItem155.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem155.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.TextBox1
        Me.LayoutControlItem8.CustomizationFormText = "Sage Ref:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(139, 152)
        Me.LayoutControlItem8.Text = "Sage Ref:"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(123, 16)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(0, 152)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(1549, 475)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'JobCategoryBindingSource1
        '
        Me.JobCategoryBindingSource1.DataMember = "JobCategory"
        Me.JobCategoryBindingSource1.DataSource = Me.LexiconRecManagerDataSet
        '
        'JobCategoryBindingSource
        '
        Me.JobCategoryBindingSource.DataSource = Me.SitesBindingSource
        '
        'SitesTableAdapter1
        '
        Me.SitesTableAdapter1.ClearBeforeFill = True
        '
        'CompanyContactsTableAdapter1
        '
        Me.CompanyContactsTableAdapter1.ClearBeforeFill = True
        '
        'JobCategoryTableAdapter1
        '
        Me.JobCategoryTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.BanksTableAdapter = Nothing
        Me.TableAdapterManager1.CompanyContactsTableAdapter = Me.CompanyContactsTableAdapter1
        Me.TableAdapterManager1.EmployeesMoneyOwedTableAdapter = Nothing
        Me.TableAdapterManager1.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager1.HolidaysTableAdapter = Nothing
        Me.TableAdapterManager1.JobCategoryTableAdapter = Me.JobCategoryTableAdapter1
        Me.TableAdapterManager1.PlanTypesTableAdapter = Nothing
        Me.TableAdapterManager1.SitesTableAdapter = Me.SitesTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = Lexrecmgr.SitesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UsersTableAdapter = Nothing
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 27)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SitesGridControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(1589, 886)
        Me.SplitContainer1.SplitterDistance = 693
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 6
        '
        'SitesGridControl
        '
        Me.SitesGridControl.DataSource = Me.SitesBindingSource
        Me.SitesGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SitesGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SitesGridControl.Location = New System.Drawing.Point(0, 0)
        Me.SitesGridControl.MainView = Me.GridView1
        Me.SitesGridControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SitesGridControl.Name = "SitesGridControl"
        Me.SitesGridControl.Size = New System.Drawing.Size(1589, 188)
        Me.SitesGridControl.TabIndex = 0
        Me.SitesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCompanyID, Me.colClientStatus, Me.colClientStatusReason, Me.colClientCode, Me.colCompanyName, Me.colBranchID, Me.colLtd, Me.colPLC, Me.colSoleTrader, Me.colNotes, Me.colSwedishderogationPureContracted, Me.colPayParityPureEmbrace, Me.colStartOfWeek, Me.colOther, Me.colConvertedBy, Me.colCompanyRegNumber, Me.colClientsVatRegNo, Me.colBaseLocation, Me.colCategory, Me.colDepartment, Me.colEmail, Me.colTelephone1, Me.colTelephone2, Me.colFax, Me.colAddress, Me.colAddress2, Me.colTown, Me.colCounty, Me.colCountry, Me.colPostalCode, Me.colInvoiceTo, Me.colInvAddress, Me.colInvTown, Me.colInvCounty, Me.colInvCountry, Me.colInvPostCode, Me.colInvoicingMethod, Me.colOrderNumberReq, Me.colSpecialInvoiceInstructions, Me.colDNI, Me.colCreditLimit, Me.colTerms, Me.colCanteenAvailable, Me.colSmokingAreaAvailable, Me.colParkingAvailable, Me.colOtherFacilities, Me.colHolidayEntitlement, Me.colHowArePermanentVacanciesDisplayed, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.colTempsUsed, Me.colCompanySize, Me.colNoEmployees, Me.colAgenciesUsed, Me.colMemo, Me.colArchive, Me.colActive, Me.colOrderNumberReq1, Me.colInvAddress2})
        Me.GridView1.GridControl = Me.SitesGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        '
        'colCompanyID
        '
        Me.colCompanyID.FieldName = "CompanyID"
        Me.colCompanyID.Name = "colCompanyID"
        '
        'colClientStatus
        '
        Me.colClientStatus.FieldName = "ClientStatus"
        Me.colClientStatus.Name = "colClientStatus"
        Me.colClientStatus.Visible = True
        Me.colClientStatus.VisibleIndex = 2
        '
        'colClientStatusReason
        '
        Me.colClientStatusReason.FieldName = "ClientStatusReason"
        Me.colClientStatusReason.Name = "colClientStatusReason"
        Me.colClientStatusReason.Visible = True
        Me.colClientStatusReason.VisibleIndex = 1
        '
        'colClientCode
        '
        Me.colClientCode.FieldName = "ClientCode"
        Me.colClientCode.Name = "colClientCode"
        Me.colClientCode.Visible = True
        Me.colClientCode.VisibleIndex = 0
        '
        'colCompanyName
        '
        Me.colCompanyName.FieldName = "CompanyName"
        Me.colCompanyName.Name = "colCompanyName"
        Me.colCompanyName.Visible = True
        Me.colCompanyName.VisibleIndex = 3
        '
        'colBranchID
        '
        Me.colBranchID.FieldName = "BranchID"
        Me.colBranchID.Name = "colBranchID"
        '
        'colLtd
        '
        Me.colLtd.FieldName = "Ltd"
        Me.colLtd.Name = "colLtd"
        Me.colLtd.Visible = True
        Me.colLtd.VisibleIndex = 4
        '
        'colPLC
        '
        Me.colPLC.FieldName = "PLC"
        Me.colPLC.Name = "colPLC"
        Me.colPLC.Visible = True
        Me.colPLC.VisibleIndex = 5
        '
        'colSoleTrader
        '
        Me.colSoleTrader.FieldName = "SoleTrader"
        Me.colSoleTrader.Name = "colSoleTrader"
        Me.colSoleTrader.Visible = True
        Me.colSoleTrader.VisibleIndex = 6
        '
        'colNotes
        '
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        '
        'colSwedishderogationPureContracted
        '
        Me.colSwedishderogationPureContracted.FieldName = "SwedishderogationPureContracted"
        Me.colSwedishderogationPureContracted.Name = "colSwedishderogationPureContracted"
        '
        'colPayParityPureEmbrace
        '
        Me.colPayParityPureEmbrace.FieldName = "PayParityPureEmbrace"
        Me.colPayParityPureEmbrace.Name = "colPayParityPureEmbrace"
        '
        'colStartOfWeek
        '
        Me.colStartOfWeek.FieldName = "StartOfWeek"
        Me.colStartOfWeek.Name = "colStartOfWeek"
        '
        'colOther
        '
        Me.colOther.FieldName = "Other"
        Me.colOther.Name = "colOther"
        '
        'colConvertedBy
        '
        Me.colConvertedBy.FieldName = "ConvertedBy"
        Me.colConvertedBy.Name = "colConvertedBy"
        Me.colConvertedBy.Visible = True
        Me.colConvertedBy.VisibleIndex = 7
        '
        'colCompanyRegNumber
        '
        Me.colCompanyRegNumber.FieldName = "CompanyRegNumber"
        Me.colCompanyRegNumber.Name = "colCompanyRegNumber"
        '
        'colClientsVatRegNo
        '
        Me.colClientsVatRegNo.FieldName = "ClientsVatRegNo"
        Me.colClientsVatRegNo.Name = "colClientsVatRegNo"
        '
        'colBaseLocation
        '
        Me.colBaseLocation.FieldName = "BaseLocation"
        Me.colBaseLocation.Name = "colBaseLocation"
        Me.colBaseLocation.Visible = True
        Me.colBaseLocation.VisibleIndex = 8
        '
        'colCategory
        '
        Me.colCategory.FieldName = "Category"
        Me.colCategory.Name = "colCategory"
        '
        'colDepartment
        '
        Me.colDepartment.FieldName = "Department"
        Me.colDepartment.Name = "colDepartment"
        Me.colDepartment.Visible = True
        Me.colDepartment.VisibleIndex = 9
        '
        'colEmail
        '
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 10
        '
        'colTelephone1
        '
        Me.colTelephone1.FieldName = "Telephone1"
        Me.colTelephone1.Name = "colTelephone1"
        Me.colTelephone1.Visible = True
        Me.colTelephone1.VisibleIndex = 11
        '
        'colTelephone2
        '
        Me.colTelephone2.FieldName = "Telephone2"
        Me.colTelephone2.Name = "colTelephone2"
        Me.colTelephone2.Visible = True
        Me.colTelephone2.VisibleIndex = 12
        '
        'colFax
        '
        Me.colFax.FieldName = "Fax"
        Me.colFax.Name = "colFax"
        Me.colFax.Visible = True
        Me.colFax.VisibleIndex = 13
        '
        'colAddress
        '
        Me.colAddress.FieldName = "Address"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.Visible = True
        Me.colAddress.VisibleIndex = 14
        '
        'colAddress2
        '
        Me.colAddress2.FieldName = "Address2"
        Me.colAddress2.Name = "colAddress2"
        Me.colAddress2.Visible = True
        Me.colAddress2.VisibleIndex = 15
        '
        'colTown
        '
        Me.colTown.FieldName = "Town"
        Me.colTown.Name = "colTown"
        Me.colTown.Visible = True
        Me.colTown.VisibleIndex = 16
        '
        'colCounty
        '
        Me.colCounty.FieldName = "County"
        Me.colCounty.Name = "colCounty"
        Me.colCounty.Visible = True
        Me.colCounty.VisibleIndex = 17
        '
        'colCountry
        '
        Me.colCountry.FieldName = "Country"
        Me.colCountry.Name = "colCountry"
        Me.colCountry.Visible = True
        Me.colCountry.VisibleIndex = 18
        '
        'colPostalCode
        '
        Me.colPostalCode.FieldName = "PostalCode"
        Me.colPostalCode.Name = "colPostalCode"
        Me.colPostalCode.Visible = True
        Me.colPostalCode.VisibleIndex = 19
        '
        'colInvoiceTo
        '
        Me.colInvoiceTo.FieldName = "InvoiceTo"
        Me.colInvoiceTo.Name = "colInvoiceTo"
        '
        'colInvAddress
        '
        Me.colInvAddress.FieldName = "InvAddress"
        Me.colInvAddress.Name = "colInvAddress"
        '
        'colInvTown
        '
        Me.colInvTown.FieldName = "InvTown"
        Me.colInvTown.Name = "colInvTown"
        '
        'colInvCounty
        '
        Me.colInvCounty.FieldName = "InvCounty"
        Me.colInvCounty.Name = "colInvCounty"
        '
        'colInvCountry
        '
        Me.colInvCountry.FieldName = "InvCountry"
        Me.colInvCountry.Name = "colInvCountry"
        '
        'colInvPostCode
        '
        Me.colInvPostCode.FieldName = "InvPostCode"
        Me.colInvPostCode.Name = "colInvPostCode"
        '
        'colInvoicingMethod
        '
        Me.colInvoicingMethod.FieldName = "InvoicingMethod"
        Me.colInvoicingMethod.Name = "colInvoicingMethod"
        '
        'colOrderNumberReq
        '
        Me.colOrderNumberReq.FieldName = "OrderNumberReq"
        Me.colOrderNumberReq.Name = "colOrderNumberReq"
        '
        'colSpecialInvoiceInstructions
        '
        Me.colSpecialInvoiceInstructions.FieldName = "SpecialInvoiceInstructions"
        Me.colSpecialInvoiceInstructions.Name = "colSpecialInvoiceInstructions"
        '
        'colDNI
        '
        Me.colDNI.FieldName = "DNI"
        Me.colDNI.Name = "colDNI"
        '
        'colCreditLimit
        '
        Me.colCreditLimit.FieldName = "CreditLimit"
        Me.colCreditLimit.Name = "colCreditLimit"
        '
        'colTerms
        '
        Me.colTerms.FieldName = "Terms"
        Me.colTerms.Name = "colTerms"
        '
        'colCanteenAvailable
        '
        Me.colCanteenAvailable.FieldName = "CanteenAvailable"
        Me.colCanteenAvailable.Name = "colCanteenAvailable"
        '
        'colSmokingAreaAvailable
        '
        Me.colSmokingAreaAvailable.FieldName = "SmokingAreaAvailable"
        Me.colSmokingAreaAvailable.Name = "colSmokingAreaAvailable"
        '
        'colParkingAvailable
        '
        Me.colParkingAvailable.FieldName = "ParkingAvailable"
        Me.colParkingAvailable.Name = "colParkingAvailable"
        '
        'colOtherFacilities
        '
        Me.colOtherFacilities.FieldName = "OtherFacilities"
        Me.colOtherFacilities.Name = "colOtherFacilities"
        '
        'colHolidayEntitlement
        '
        Me.colHolidayEntitlement.FieldName = "HolidayEntitlement"
        Me.colHolidayEntitlement.Name = "colHolidayEntitlement"
        '
        'colHowArePermanentVacanciesDisplayed
        '
        Me.colHowArePermanentVacanciesDisplayed.FieldName = "HowArePermanentVacanciesDisplayed"
        Me.colHowArePermanentVacanciesDisplayed.Name = "colHowArePermanentVacanciesDisplayed"
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "H&SContact"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "H&SPosition"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "H&SMobile"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "H&SEmail"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "H&SRisks"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "H&SSteps"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn7
        '
        Me.GridColumn7.FieldName = "H&SBasicInduction"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        Me.GridColumn8.FieldName = "H&SInstructionGiven"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'GridColumn9
        '
        Me.GridColumn9.FieldName = "H&SFirstAidAvailable"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn10
        '
        Me.GridColumn10.FieldName = "H&SAccidentsReported"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.FieldName = "H&SMinAge"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.FieldName = "H&SSaftyBoots"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.FieldName = "H&SHiVizVest"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn14
        '
        Me.GridColumn14.FieldName = "H&SSaftyGoggles"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'GridColumn15
        '
        Me.GridColumn15.FieldName = "H&SHardHat"
        Me.GridColumn15.Name = "GridColumn15"
        '
        'GridColumn16
        '
        Me.GridColumn16.FieldName = "H&SHiVisTrousers"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn17
        '
        Me.GridColumn17.FieldName = "H&SEarDefenders"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn18
        '
        Me.GridColumn18.FieldName = "H&SOtherEqupment"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'colTempsUsed
        '
        Me.colTempsUsed.FieldName = "TempsUsed"
        Me.colTempsUsed.Name = "colTempsUsed"
        '
        'colCompanySize
        '
        Me.colCompanySize.FieldName = "CompanySize"
        Me.colCompanySize.Name = "colCompanySize"
        '
        'colNoEmployees
        '
        Me.colNoEmployees.FieldName = "NoEmployees"
        Me.colNoEmployees.Name = "colNoEmployees"
        '
        'colAgenciesUsed
        '
        Me.colAgenciesUsed.FieldName = "AgenciesUsed"
        Me.colAgenciesUsed.Name = "colAgenciesUsed"
        '
        'colMemo
        '
        Me.colMemo.FieldName = "Memo"
        Me.colMemo.Name = "colMemo"
        '
        'colArchive
        '
        Me.colArchive.FieldName = "Archive"
        Me.colArchive.Name = "colArchive"
        Me.colArchive.Visible = True
        Me.colArchive.VisibleIndex = 20
        '
        'colActive
        '
        Me.colActive.FieldName = "Active"
        Me.colActive.Name = "colActive"
        Me.colActive.Visible = True
        Me.colActive.VisibleIndex = 21
        '
        'colOrderNumberReq1
        '
        Me.colOrderNumberReq1.FieldName = "OrderNumberReq1"
        Me.colOrderNumberReq1.Name = "colOrderNumberReq1"
        '
        'colInvAddress2
        '
        Me.colInvAddress2.FieldName = "InvAddress2"
        Me.colInvAddress2.Name = "colInvAddress2"
        '
        'ConsultantsTableAdapter
        '
        Me.ConsultantsTableAdapter.ClearBeforeFill = True
        '
        'CompanyContactsBindingSource1
        '
        Me.CompanyContactsBindingSource1.DataMember = "CompanyContacts"
        Me.CompanyContactsBindingSource1.DataSource = Me.LexiconRecManagerDataSet
        '
        'BanksTableAdapter
        '
        Me.BanksTableAdapter.ClearBeforeFill = True
        '
        'Clients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1589, 913)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.SitesBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Clients"
        Me.Text = "Form4"
        CType(Me.SitesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SitesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SitesBindingNavigator.ResumeLayout(False)
        Me.SitesBindingNavigator.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GLAClientCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKCompanyContactsSitesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyContactsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexiconManagemnetToolsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreatedByTimeEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreatedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LastModifiedUserTimeEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LastModifiedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem158, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem161, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem162, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem163, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem164, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem168, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.InvoicingMethodTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POtypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankIDSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BanksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sites1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem167, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem166, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.asdas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl4.ResumeLayout(False)
        CType(Me.LayoutControlGroup18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem111, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem132, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem133, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem134, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem135, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem136, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.LayoutControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl5.ResumeLayout(False)
        CType(Me.LayoutControlGroup19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem137, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem138, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem139, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem140, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem141, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem142, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem143, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem144, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem145, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem146, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem147, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem148, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem149, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem150, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem151, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem152, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem153, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem154, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage10.ResumeLayout(False)
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.FKJobCategorySitesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArchiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobCatIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.MemoEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoursPerShift.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem70, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem72, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem73, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem75, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem79, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem78, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem77, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem76, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem80, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem82, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem83, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem85, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem84, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem86, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem87, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem88, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem89, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem90, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem91, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem92, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem98, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem99, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem97, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem96, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem95, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem94, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem93, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem108, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem107, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem106, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem105, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem103, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem104, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem102, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem101, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem109, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem112, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem110, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem113, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem114, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem115, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem116, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem117, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem118, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem119, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem120, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem121, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem122, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem123, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem124, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem125, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem126, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem127, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem128, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem129, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem131, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem130, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem160, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem159, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem165, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.LayoutControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl6.ResumeLayout(False)
        CType(Me.ClientStatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientStatusReasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem156, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem157, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem155, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobCategoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SitesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyContactsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SitesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SitesTableAdapter As LexrecMGr.LexiconRecManagerDataSetTableAdapters.SitesTableAdapter
    Friend WithEvents TableAdapterManager As LexrecMGr.LexiconRecManagerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SitesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SitesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Sites As LexrecMGr.Sites
    Friend WithEvents BranchTableAdapter As LexrecMGr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents CompanyContactsTableAdapter As LexrecMGr.LexiconRecManagerDataSetTableAdapters.CompanyContactsTableAdapter
    Friend WithEvents JobCategoryTableAdapter As LexrecMGr.LexiconRecManagerDataSetTableAdapters.JobCategoryTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents BranchIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LexiconRecManagerDataSet As LexrecMGr.LexiconRecManagerDataSet
    Friend WithEvents ContactIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ForenameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobTitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelephoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanyContactsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DNICheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OtherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CreditLimitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TermsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanyRegNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SpecialInvoiceInstructionsRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents NotesRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents CompanyNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClientCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LtdCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PLCCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SoleTraderCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SwedishderogationPureContractedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PayParityPureEmbraceCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Address2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TownTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountyComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CountryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PostalCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telephone1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telephone2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents FaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InvPostCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InvCountryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents InvCountyComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents InvTownTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Address3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents InvAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InvoiceToTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents HowArePermanentVacanciesDisplayedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HolidayEntitlementTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OtherFacilitiesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ParkingAvailableCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SmokingAreaAvailableCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CanteenAvailableCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents H_SOtherEqupmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents H_SEarDefendersCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents H_SHiVisTrousersCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents H_SHardHatCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents H_SSaftyGogglesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents H_SHiVizVestCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents H_SSaftyBootsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents H_SAccidentsReportedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents H_SFirstAidAvailableCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents H_SInstructionGivenCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents H_SBasicInductionCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents H_SMinAgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents H_SStepsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents H_SRisksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents H_SEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents H_SMobileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents H_SPositionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents H_SContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LastModifiedDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastModifiedUserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SWHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DHHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotesForTimeSheetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TimesheetTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TimeSheetSentViaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TimesheetContactComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BreakDeductedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BreakEntitlementTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TypicalEndTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TypicalStartTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShiftNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JobCategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CNightsOutTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CBankHolTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CSundayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CSaturdayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents COT3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents COT2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents COT1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CBasicPayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PNightsOutTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PBankHolTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PSundayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PSaturdayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents POT3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents POT2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents POT1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents PBasicPayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C2NightsOutTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C2BankHolTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C2SundayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C2SaturdayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C2OT3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents C2OT2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents C2OT1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents C2BasicPayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents P2NightsOutTextBox As System.Windows.Forms.TextBox
    Friend WithEvents P2BankHolTextBox As System.Windows.Forms.TextBox
    Friend WithEvents P2SundayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents P2SaturdayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents P2OT3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents P2OT2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents P2OT1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents P2BasicPayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C3NightsOutTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C3BankHolTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C3SundayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C3SaturdayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C3OT3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents C3OT2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents C3OT1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents C3BasicPayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents P3NightsOutTextBox As System.Windows.Forms.TextBox
    Friend WithEvents P3BankHolTextBox As System.Windows.Forms.TextBox
    Friend WithEvents P3SundayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents P3SaturdayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents P3OT3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents P3OT2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents P3OT1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents P3BasicPayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C4NightsOutTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C4BankHolTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C4SundayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C4SaturdayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C4OT3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents C4OT2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents C4OT1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents C4BasicPayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents P4NightsOutTextBox As System.Windows.Forms.TextBox
    Friend WithEvents P4BankHolTextBox As System.Windows.Forms.TextBox
    Friend WithEvents P4SundayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents P4SaturdayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents P4OT3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents P4OT2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents P4OT1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents P4BasicPayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SitesTableAdapter1 As LexrecMGr.SitesTableAdapters.SitesTableAdapter
    Friend WithEvents FKCompanyContactsSitesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyContactsTableAdapter1 As LexrecMGr.SitesTableAdapters.CompanyContactsTableAdapter
    Friend WithEvents FKJobCategorySitesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobCategoryTableAdapter1 As LexrecMGr.SitesTableAdapters.JobCategoryTableAdapter
    Friend WithEvents PPERequiredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AssesmentReqDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MinChargePerDayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TempToPermAfterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArchiveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OrderNumberReq1CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TableAdapterManager1 As LexrecMGr.SitesTableAdapters.TableAdapterManager
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MinChargePerDayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JobCategoryBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TempToPermAfterTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBCompanyId As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents LexiconManagemnetToolsDataSet As Lexrecmgr.LexiconManagemnetToolsDataSet
    Friend WithEvents ConsultantsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConsultantsTableAdapter As Lexrecmgr.LexiconManagemnetToolsDataSetTableAdapters.ConsultantsTableAdapter
    Friend WithEvents CBJobType As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SitesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCompanyID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPLC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSoleTrader As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSwedishderogationPureContracted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayParityPureEmbrace As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStartOfWeek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOther As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConvertedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyRegNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientsVatRegNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBaseLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelephone1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelephone2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTown As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCounty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPostalCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceTo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvTown As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvCounty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvPostCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoicingMethod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderNumberReq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSpecialInvoiceInstructions As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDNI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreditLimit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTerms As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCanteenAvailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSmokingAreaAvailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParkingAvailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOtherFacilities As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHolidayEntitlement As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHowArePermanentVacanciesDisplayed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTempsUsed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanySize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoEmployees As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgenciesUsed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMemo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArchive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderNumberReq1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvAddress2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents CompanyContactsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colForename As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSurname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartment1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelephone21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelephone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFax1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActive1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CompanyContactsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents MemoEdit4 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents MemoEdit3 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents MemoEdit2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup9 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup10 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem59 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem60 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem61 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem62 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem63 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem64 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem65 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem66 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup11 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem68 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem67 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem69 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem70 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem71 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem72 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem73 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem74 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem75 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem42 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem43 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem44 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem45 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem46 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem48 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem47 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem49 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem50 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem51 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem52 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem53 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem54 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem55 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem56 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem57 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem58 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup12 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup13 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem79 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem78 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem77 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem76 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem80 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem81 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem82 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem83 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup14 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem85 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem84 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem86 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem87 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem88 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem89 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem90 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem91 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem92 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup15 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup16 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem100 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem98 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem99 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem97 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem96 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem95 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem94 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem93 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup17 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem108 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem107 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem106 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem105 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem103 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem104 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem102 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem101 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem109 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem112 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem110 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem113 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem114 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem115 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem116 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem117 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem118 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem119 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem120 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem121 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem122 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem123 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem124 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem125 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem126 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem127 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem128 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem129 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SplitterItem2 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colJobCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiftName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTypicalStartTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTypicalEndTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem131 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents LayoutControl4 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup18 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem111 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem132 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem133 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem134 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem135 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem136 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SplitterItem3 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents LayoutControl5 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup19 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem137 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem138 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem139 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem140 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem141 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem142 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem143 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem144 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem145 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem146 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem147 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem148 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem149 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem150 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem151 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem152 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem153 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem154 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents LayoutControl6 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LayoutControlGroup20 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ClientStatusTextEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ClientStatusReasonTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlGroup21 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem156 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem157 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup22 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem155 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colClientStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClientStatusReason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataNavigator1 As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents LayoutControlItem158 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem130 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents JobCatIdSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem160 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents HoursPerShift As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents CreatedByTimeEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CreatedDateDateEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LastModifiedUserTimeEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LastModifiedDateDateEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem161 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem162 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem163 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem164 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colArchive1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ArchiveCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem159 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents POtypeTextEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem166 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BankIDSpinEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem167 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Sites1 As Lexrecmgr.Sites
    Friend WithEvents BanksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BanksTableAdapter As Lexrecmgr.SitesTableAdapters.BanksTableAdapter
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents GLAClientCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem168 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents LayoutControlItem165 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents InvoicingMethodTextBox As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents asdas As DevExpress.XtraLayout.LayoutControlItem
End Class
