<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeEdit))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.Communication = New System.Windows.Forms.ComboBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Interviewer = New System.Windows.Forms.ComboBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.DateRegistered = New System.Windows.Forms.DateTimePicker()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.ComboBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.StatusReason = New System.Windows.Forms.TextBox()
        Me.Notes = New System.Windows.Forms.TextBox()
        Me.CBCardArchived = New System.Windows.Forms.CheckBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.DriverLicenseCheckConsentFormCompleteCB = New DevExpress.XtraEditors.CheckEdit()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.DateDrivingLicenceLastChecked = New DevExpress.XtraEditors.DateEdit()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.PriorRefTE = New DevExpress.XtraEditors.TextEdit()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.EmployeesMoneyOwedGridControl = New DevExpress.XtraGrid.GridControl()
        Me.EmployeesMoneyOwedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sites = New Lexrecmgr.Sites()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEmployeeMoneyOwedID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateOwed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colPaidChangedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaidChangedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.StatusChangeDateTb = New DevExpress.XtraEditors.TextEdit()
        Me.LastWorkedDateTb = New DevExpress.XtraEditors.TextEdit()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.TPLTDCompanyContratorDetails = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.LtdCompanyName = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.CoRegistrationNumber = New System.Windows.Forms.TextBox()
        Me.CorporationCertCopied = New System.Windows.Forms.CheckBox()
        Me.VatRegistered = New System.Windows.Forms.CheckBox()
        Me.VatNumber = New System.Windows.Forms.TextBox()
        Me.TPDriving = New System.Windows.Forms.TabPage()
        Me.tblelayour = New System.Windows.Forms.TableLayoutPanel()
        Me.CE = New System.Windows.Forms.CheckBox()
        Me.C = New System.Windows.Forms.CheckBox()
        Me.Tonn75 = New System.Windows.Forms.CheckBox()
        Me.Van = New System.Windows.Forms.CheckBox()
        Me.Hiab = New System.Windows.Forms.CheckBox()
        Me.Moffat = New System.Windows.Forms.CheckBox()
        Me.Tipper1 = New System.Windows.Forms.CheckBox()
        Me.Tipper2 = New System.Windows.Forms.CheckBox()
        Me.Tipper75T = New System.Windows.Forms.CheckBox()
        Me.RollOnOff = New System.Windows.Forms.CheckBox()
        Me.MultiLift = New System.Windows.Forms.CheckBox()
        Me.PVC = New System.Windows.Forms.CheckBox()
        Me.MB = New System.Windows.Forms.CheckBox()
        Me.AFrame = New System.Windows.Forms.CheckBox()
        Me.CloseCoupled = New System.Windows.Forms.CheckBox()
        Me.CurtainBox = New System.Windows.Forms.CheckBox()
        Me.FlatFridge = New System.Windows.Forms.CheckBox()
        Me.Lowloader = New System.Windows.Forms.CheckBox()
        Me.Container1 = New System.Windows.Forms.CheckBox()
        Me.DeMounts = New System.Windows.Forms.CheckBox()
        Me.WalkingFloor = New System.Windows.Forms.CheckBox()
        Me.DoubleDeck = New System.Windows.Forms.CheckBox()
        Me.ChainnDog = New System.Windows.Forms.CheckBox()
        Me.Strap = New System.Windows.Forms.CheckBox()
        Me.Rope = New System.Windows.Forms.CheckBox()
        Me.Sheet = New System.Windows.Forms.CheckBox()
        Me.SteelShunter = New System.Windows.Forms.CheckBox()
        Me.HBall = New System.Windows.Forms.CheckBox()
        Me.TLift = New System.Windows.Forms.CheckBox()
        Me.FLT = New System.Windows.Forms.CheckBox()
        Me.ADRTanks = New System.Windows.Forms.CheckBox()
        Me.ADRPackages = New System.Windows.Forms.CheckBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Assembler = New System.Windows.Forms.CheckBox()
        Me.Production = New System.Windows.Forms.CheckBox()
        Me.Warehouse = New System.Windows.Forms.CheckBox()
        Me.Groundwork = New System.Windows.Forms.CheckBox()
        Me.TrafficMngt = New System.Windows.Forms.CheckBox()
        Me.MigWelder = New System.Windows.Forms.CheckBox()
        Me.GeneralOp = New System.Windows.Forms.CheckBox()
        Me.MachineOp = New System.Windows.Forms.CheckBox()
        Me.PressOp = New System.Windows.Forms.CheckBox()
        Me.OrderPicker = New System.Windows.Forms.CheckBox()
        Me.Labourer = New System.Windows.Forms.CheckBox()
        Me.Joiner = New System.Windows.Forms.CheckBox()
        Me.TigWelder = New System.Windows.Forms.CheckBox()
        Me.QInspector = New System.Windows.Forms.CheckBox()
        Me.Setter = New System.Windows.Forms.CheckBox()
        Me.Driving = New System.Windows.Forms.CheckBox()
        Me.Packer = New System.Windows.Forms.CheckBox()
        Me.Cleaner = New System.Windows.Forms.CheckBox()
        Me.Admin = New System.Windows.Forms.CheckBox()
        Me.Braize = New System.Windows.Forms.CheckBox()
        Me.FSA = New System.Windows.Forms.CheckBox()
        Me.FLTRT = New System.Windows.Forms.CheckBox()
        Me.FLTNA = New System.Windows.Forms.CheckBox()
        Me.FLTBendi = New System.Windows.Forms.CheckBox()
        Me.FLTCB = New System.Windows.Forms.CheckBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Passport = New System.Windows.Forms.CheckBox()
        Me.NatIdCard = New System.Windows.Forms.CheckBox()
        Me.ProofOfNi = New System.Windows.Forms.CheckBox()
        Me.BirthCert = New System.Windows.Forms.CheckBox()
        Me.NiCard = New System.Windows.Forms.CheckBox()
        Me.UtilityBill = New System.Windows.Forms.CheckBox()
        Me.CV = New System.Windows.Forms.CheckBox()
        Me.Visa = New System.Windows.Forms.CheckBox()
        Me.CSCSCard = New System.Windows.Forms.CheckBox()
        Me.CPCSCard = New System.Windows.Forms.CheckBox()
        Me.DrivingLicense = New System.Windows.Forms.CheckBox()
        Me.DigiCard = New System.Windows.Forms.CheckBox()
        Me.CPCM1 = New System.Windows.Forms.CheckBox()
        Me.CPCM2 = New System.Windows.Forms.CheckBox()
        Me.CPCM4 = New System.Windows.Forms.CheckBox()
        Me.CPCM5 = New System.Windows.Forms.CheckBox()
        Me.CPCM3 = New System.Windows.Forms.CheckBox()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.DrivingExpiryDate = New DevExpress.XtraEditors.DateEdit()
        Me.VisaExpiryDate = New DevExpress.XtraEditors.DateEdit()
        Me.PassportExpiryDate = New DevExpress.XtraEditors.DateEdit()
        Me.DigiCardExpiryDate = New DevExpress.XtraEditors.DateEdit()
        Me.DQCExpiryDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.WorkFrom3 = New System.Windows.Forms.DateTimePicker()
        Me.WorkTo3 = New System.Windows.Forms.DateTimePicker()
        Me.WorkedVia3 = New System.Windows.Forms.ComboBox()
        Me.AgencyName3 = New System.Windows.Forms.TextBox()
        Me.CompanyName3 = New System.Windows.Forms.TextBox()
        Me.Location3 = New System.Windows.Forms.TextBox()
        Me.JobTitle3 = New System.Windows.Forms.TextBox()
        Me.Shift3 = New System.Windows.Forms.TextBox()
        Me.Pay3 = New System.Windows.Forms.TextBox()
        Me.ReasonForLeaving3 = New System.Windows.Forms.TextBox()
        Me.Manager3 = New System.Windows.Forms.TextBox()
        Me.RefAvailable2 = New System.Windows.Forms.CheckBox()
        Me.ContactNumber3 = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.WorkFrom2 = New System.Windows.Forms.DateTimePicker()
        Me.WorkTo2 = New System.Windows.Forms.DateTimePicker()
        Me.WorkedVia2 = New System.Windows.Forms.ComboBox()
        Me.AgencyName2 = New System.Windows.Forms.TextBox()
        Me.CompanyName2 = New System.Windows.Forms.TextBox()
        Me.Location2 = New System.Windows.Forms.TextBox()
        Me.JobTitle2 = New System.Windows.Forms.TextBox()
        Me.Shift2 = New System.Windows.Forms.TextBox()
        Me.Pay2 = New System.Windows.Forms.TextBox()
        Me.ReasonForLeaving2 = New System.Windows.Forms.TextBox()
        Me.Manager2 = New System.Windows.Forms.TextBox()
        Me.RefAvailable1 = New System.Windows.Forms.CheckBox()
        Me.ContactNumber2 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.WorkFrom = New System.Windows.Forms.DateTimePicker()
        Me.WorkTo = New System.Windows.Forms.DateTimePicker()
        Me.WorkedVia = New System.Windows.Forms.ComboBox()
        Me.AgencyName = New System.Windows.Forms.TextBox()
        Me.CompanyName1 = New System.Windows.Forms.TextBox()
        Me.Location1 = New System.Windows.Forms.TextBox()
        Me.JobTitle = New System.Windows.Forms.TextBox()
        Me.Shift = New System.Windows.Forms.TextBox()
        Me.Pay = New System.Windows.Forms.TextBox()
        Me.ReasonForLeaving = New System.Windows.Forms.TextBox()
        Me.Manager = New System.Windows.Forms.TextBox()
        Me.RefAvailable = New System.Windows.Forms.CheckBox()
        Me.ContactNumber = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Sortcode = New System.Windows.Forms.TextBox()
        Me.AccountNo = New System.Windows.Forms.TextBox()
        Me.AccountInTheNameOf = New System.Windows.Forms.TextBox()
        Me.Bank = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.CheckBox()
        Me.TaxCategory = New System.Windows.Forms.ComboBox()
        Me.TaxDetails = New System.Windows.Forms.ComboBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.StudentLoan = New System.Windows.Forms.CheckBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.PaymentFrequency = New System.Windows.Forms.ComboBox()
        Me.lbl536 = New System.Windows.Forms.Label()
        Me.Tb_Email = New DevExpress.XtraEditors.TextEdit()
        Me.BankReference = New System.Windows.Forms.TextBox()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Scheme = New System.Windows.Forms.ComboBox()
        Me.Branch = New System.Windows.Forms.ComboBox()
        Me.EmployeeCode = New System.Windows.Forms.TextBox()
        Me.Forename = New System.Windows.Forms.TextBox()
        Me.Surname = New System.Windows.Forms.TextBox()
        Me.Title = New System.Windows.Forms.ComboBox()
        Me.EthnicOrigin = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.EmergencyTelephone = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.EmergencyContact = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Mobile = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Telephone = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DOB = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PostCode = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.County = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.City = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Address2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Address1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EmployeeID = New System.Windows.Forms.TextBox()
        Me.MaritalStatus = New System.Windows.Forms.ComboBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.systemtypeTb = New System.Windows.Forms.TextBox()
        Me.NiNumber = New DevExpress.XtraEditors.TextEdit()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TBHeadOffice = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.SageRef = New DevExpress.XtraEditors.TextEdit()
        Me.BranchLUE = New DevExpress.XtraEditors.LookUpEdit()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LexiconRecManagerDataSet = New Lexrecmgr.LexiconRecManagerDataSet()
        Me.SchemeLUE = New DevExpress.XtraEditors.LookUpEdit()
        Me.SchemesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.LoyaltyCard = New DevExpress.XtraEditors.CheckEdit()
        Me.LoyaltyRank = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.LoyaltyPoints = New DevExpress.XtraEditors.TextEdit()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.BranchTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter()
        Me.SchemesTableAdapter = New Lexrecmgr.LexiconRecManagerDataSetTableAdapters.SchemesTableAdapter()
        Me.EmployeesMoneyOwedTableAdapter = New Lexrecmgr.SitesTableAdapters.EmployeesMoneyOwedTableAdapter()
        Me.TableAdapterManager = New Lexrecmgr.SitesTableAdapters.TableAdapterManager()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        CType(Me.DriverLicenseCheckConsentFormCompleteCB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateDrivingLicenceLastChecked.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateDrivingLicenceLastChecked.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriorRefTE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesMoneyOwedGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesMoneyOwedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusChangeDateTb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LastWorkedDateTb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPLTDCompanyContratorDetails.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TPDriving.SuspendLayout()
        Me.tblelayour.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.DrivingExpiryDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrivingExpiryDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisaExpiryDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisaExpiryDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassportExpiryDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassportExpiryDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigiCardExpiryDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigiCardExpiryDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DQCExpiryDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DQCExpiryDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.Tb_Email.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.NiNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TBHeadOffice.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        CType(Me.SageRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchLUE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchemeLUE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchemesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoyaltyCard.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoyaltyRank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoyaltyPoints.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(948, 633)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(78, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Save"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(88, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(78, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.Color.Transparent
        Me.TabPage8.Controls.Add(Me.TableLayoutPanel9)
        Me.TabPage8.Location = New System.Drawing.Point(4, 25)
        Me.TabPage8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage8.Size = New System.Drawing.Size(1118, 593)
        Me.TabPage8.TabIndex = 9
        Me.TabPage8.Text = "Other"
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel9.ColumnCount = 5
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.4693!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.0573!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.23738!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.50887!))
        Me.TableLayoutPanel9.Controls.Add(Me.Communication, 2, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.Label74, 1, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.Label80, 1, 2)
        Me.TableLayoutPanel9.Controls.Add(Me.Interviewer, 2, 2)
        Me.TableLayoutPanel9.Controls.Add(Me.Label81, 1, 3)
        Me.TableLayoutPanel9.Controls.Add(Me.DateRegistered, 2, 3)
        Me.TableLayoutPanel9.Controls.Add(Me.Label82, 1, 4)
        Me.TableLayoutPanel9.Controls.Add(Me.Status, 2, 4)
        Me.TableLayoutPanel9.Controls.Add(Me.Label83, 1, 5)
        Me.TableLayoutPanel9.Controls.Add(Me.StatusReason, 2, 5)
        Me.TableLayoutPanel9.Controls.Add(Me.Notes, 2, 6)
        Me.TableLayoutPanel9.Controls.Add(Me.CBCardArchived, 2, 7)
        Me.TableLayoutPanel9.Controls.Add(Me.Label69, 1, 7)
        Me.TableLayoutPanel9.Controls.Add(Me.DriverLicenseCheckConsentFormCompleteCB, 2, 8)
        Me.TableLayoutPanel9.Controls.Add(Me.Label70, 1, 6)
        Me.TableLayoutPanel9.Controls.Add(Me.DateDrivingLicenceLastChecked, 2, 9)
        Me.TableLayoutPanel9.Controls.Add(Me.Label84, 1, 9)
        Me.TableLayoutPanel9.Controls.Add(Me.Label71, 1, 8)
        Me.TableLayoutPanel9.Controls.Add(Me.PriorRefTE, 2, 10)
        Me.TableLayoutPanel9.Controls.Add(Me.Label86, 1, 10)
        Me.TableLayoutPanel9.Controls.Add(Me.EmployeesMoneyOwedGridControl, 1, 12)
        Me.TableLayoutPanel9.Controls.Add(Me.DataNavigator1, 1, 11)
        Me.TableLayoutPanel9.Controls.Add(Me.Label87, 3, 4)
        Me.TableLayoutPanel9.Controls.Add(Me.StatusChangeDateTb, 4, 4)
        Me.TableLayoutPanel9.Controls.Add(Me.LastWorkedDateTb, 4, 5)
        Me.TableLayoutPanel9.Controls.Add(Me.Label94, 3, 5)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 4)
        Me.TableLayoutPanel9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 19
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(1112, 585)
        Me.TableLayoutPanel9.TabIndex = 9
        '
        'Communication
        '
        Me.Communication.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Communication.FormattingEnabled = True
        Me.Communication.Items.AddRange(New Object() {"A", "B", "C"})
        Me.Communication.Location = New System.Drawing.Point(378, 22)
        Me.Communication.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Communication.Name = "Communication"
        Me.Communication.Size = New System.Drawing.Size(276, 24)
        Me.Communication.TabIndex = 5
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(26, 18)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(104, 17)
        Me.Label74.TabIndex = 6
        Me.Label74.Text = "Communication"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(26, 50)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(89, 17)
        Me.Label80.TabIndex = 7
        Me.Label80.Text = "Interviewer"
        '
        'Interviewer
        '
        Me.Interviewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Interviewer.FormattingEnabled = True
        Me.Interviewer.Location = New System.Drawing.Point(378, 54)
        Me.Interviewer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Interviewer.Name = "Interviewer"
        Me.Interviewer.Size = New System.Drawing.Size(276, 24)
        Me.Interviewer.TabIndex = 6
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Location = New System.Drawing.Point(26, 80)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(105, 17)
        Me.Label81.TabIndex = 8
        Me.Label81.Text = "Date Registered"
        '
        'DateRegistered
        '
        Me.DateRegistered.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateRegistered.Location = New System.Drawing.Point(378, 84)
        Me.DateRegistered.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateRegistered.Name = "DateRegistered"
        Me.DateRegistered.Size = New System.Drawing.Size(276, 23)
        Me.DateRegistered.TabIndex = 7
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(26, 111)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(53, 17)
        Me.Label82.TabIndex = 9
        Me.Label82.Text = "Status"
        '
        'Status
        '
        Me.Status.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Status.FormattingEnabled = True
        Me.Status.Items.AddRange(New Object() {"TOT", "Blacklisted", "Archive", "N/S"})
        Me.Status.Location = New System.Drawing.Point(378, 115)
        Me.Status.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(276, 24)
        Me.Status.TabIndex = 8
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Location = New System.Drawing.Point(26, 142)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(96, 17)
        Me.Label83.TabIndex = 10
        Me.Label83.Text = "Status Reason"
        '
        'StatusReason
        '
        Me.StatusReason.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusReason.Location = New System.Drawing.Point(378, 146)
        Me.StatusReason.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StatusReason.Name = "StatusReason"
        Me.StatusReason.Size = New System.Drawing.Size(276, 23)
        Me.StatusReason.TabIndex = 9
        '
        'Notes
        '
        Me.Notes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Notes.Location = New System.Drawing.Point(378, 177)
        Me.Notes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(276, 23)
        Me.Notes.TabIndex = 10
        '
        'CBCardArchived
        '
        Me.CBCardArchived.AutoSize = True
        Me.CBCardArchived.Location = New System.Drawing.Point(378, 208)
        Me.CBCardArchived.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CBCardArchived.Name = "CBCardArchived"
        Me.CBCardArchived.Size = New System.Drawing.Size(18, 17)
        Me.CBCardArchived.TabIndex = 12
        Me.CBCardArchived.UseVisualStyleBackColor = True
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label69.Location = New System.Drawing.Point(26, 204)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(346, 31)
        Me.Label69.TabIndex = 13
        Me.Label69.Text = "Card Archived"
        '
        'DriverLicenseCheckConsentFormCompleteCB
        '
        Me.DriverLicenseCheckConsentFormCompleteCB.Location = New System.Drawing.Point(378, 239)
        Me.DriverLicenseCheckConsentFormCompleteCB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DriverLicenseCheckConsentFormCompleteCB.Name = "DriverLicenseCheckConsentFormCompleteCB"
        Me.DriverLicenseCheckConsentFormCompleteCB.Properties.Caption = ""
        Me.DriverLicenseCheckConsentFormCompleteCB.Size = New System.Drawing.Size(17, 19)
        Me.DriverLicenseCheckConsentFormCompleteCB.TabIndex = 14
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(26, 173)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(49, 17)
        Me.Label70.TabIndex = 11
        Me.Label70.Text = "Notes"
        '
        'DateDrivingLicenceLastChecked
        '
        Me.DateDrivingLicenceLastChecked.EditValue = Nothing
        Me.DateDrivingLicenceLastChecked.Location = New System.Drawing.Point(378, 270)
        Me.DateDrivingLicenceLastChecked.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateDrivingLicenceLastChecked.Name = "DateDrivingLicenceLastChecked"
        Me.DateDrivingLicenceLastChecked.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateDrivingLicenceLastChecked.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateDrivingLicenceLastChecked.Properties.DisplayFormat.FormatString = "d MMM yyyy"
        Me.DateDrivingLicenceLastChecked.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateDrivingLicenceLastChecked.Properties.EditFormat.FormatString = "d MMM yyyy"
        Me.DateDrivingLicenceLastChecked.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateDrivingLicenceLastChecked.Properties.Mask.EditMask = "d MMM yyyy"
        Me.DateDrivingLicenceLastChecked.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.DateDrivingLicenceLastChecked.Size = New System.Drawing.Size(203, 22)
        Me.DateDrivingLicenceLastChecked.TabIndex = 15
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Location = New System.Drawing.Point(26, 266)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(219, 17)
        Me.Label84.TabIndex = 11
        Me.Label84.Text = "Date Driving Licence Last Checked"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(26, 235)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(288, 17)
        Me.Label71.TabIndex = 11
        Me.Label71.Text = "Driver License Check Consent Form Complete"
        '
        'PriorRefTE
        '
        Me.PriorRefTE.Enabled = False
        Me.PriorRefTE.Location = New System.Drawing.Point(378, 301)
        Me.PriorRefTE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PriorRefTE.Name = "PriorRefTE"
        Me.PriorRefTE.Size = New System.Drawing.Size(203, 22)
        Me.PriorRefTE.TabIndex = 16
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Location = New System.Drawing.Point(26, 297)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(125, 17)
        Me.Label86.TabIndex = 11
        Me.Label86.Text = "Previous Reference"
        '
        'EmployeesMoneyOwedGridControl
        '
        Me.TableLayoutPanel9.SetColumnSpan(Me.EmployeesMoneyOwedGridControl, 4)
        Me.EmployeesMoneyOwedGridControl.DataSource = Me.EmployeesMoneyOwedBindingSource
        Me.EmployeesMoneyOwedGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmployeesMoneyOwedGridControl.Location = New System.Drawing.Point(26, 363)
        Me.EmployeesMoneyOwedGridControl.MainView = Me.GridView1
        Me.EmployeesMoneyOwedGridControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmployeesMoneyOwedGridControl.Name = "EmployeesMoneyOwedGridControl"
        Me.EmployeesMoneyOwedGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemDateEdit1})
        Me.TableLayoutPanel9.SetRowSpan(Me.EmployeesMoneyOwedGridControl, 5)
        Me.EmployeesMoneyOwedGridControl.Size = New System.Drawing.Size(1078, 146)
        Me.EmployeesMoneyOwedGridControl.TabIndex = 20
        Me.EmployeesMoneyOwedGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'EmployeesMoneyOwedBindingSource
        '
        Me.EmployeesMoneyOwedBindingSource.DataMember = "EmployeesMoneyOwed"
        Me.EmployeesMoneyOwedBindingSource.DataSource = Me.Sites
        '
        'Sites
        '
        Me.Sites.DataSetName = "Sites"
        Me.Sites.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEmployeeMoneyOwedID, Me.colEmployeeID, Me.colDateOwed, Me.colDescription, Me.colAmount, Me.colPaid, Me.colPaidChangedBy, Me.colPaidChangedDate})
        Me.GridView1.GridControl = Me.EmployeesMoneyOwedGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.GridView1.OptionsEditForm.EditFormColumnCount = 1
        Me.GridView1.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colEmployeeMoneyOwedID
        '
        Me.colEmployeeMoneyOwedID.FieldName = "EmployeeMoneyOwedID"
        Me.colEmployeeMoneyOwedID.Name = "colEmployeeMoneyOwedID"
        '
        'colEmployeeID
        '
        Me.colEmployeeID.FieldName = "EmployeeID"
        Me.colEmployeeID.Name = "colEmployeeID"
        Me.colEmployeeID.OptionsColumn.ReadOnly = True
        Me.colEmployeeID.Visible = True
        Me.colEmployeeID.VisibleIndex = 0
        Me.colEmployeeID.Width = 51
        '
        'colDateOwed
        '
        Me.colDateOwed.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colDateOwed.FieldName = "DateOwed"
        Me.colDateOwed.Name = "colDateOwed"
        Me.colDateOwed.Visible = True
        Me.colDateOwed.VisibleIndex = 1
        Me.colDateOwed.Width = 76
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'colDescription
        '
        Me.colDescription.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 2
        Me.colDescription.Width = 76
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'colAmount
        '
        Me.colAmount.FieldName = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.Visible = True
        Me.colAmount.VisibleIndex = 3
        Me.colAmount.Width = 76
        '
        'colPaid
        '
        Me.colPaid.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colPaid.FieldName = "Paid"
        Me.colPaid.Name = "colPaid"
        Me.colPaid.Visible = True
        Me.colPaid.VisibleIndex = 4
        Me.colPaid.Width = 76
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colPaidChangedBy
        '
        Me.colPaidChangedBy.FieldName = "PaidChangedBy"
        Me.colPaidChangedBy.Name = "colPaidChangedBy"
        Me.colPaidChangedBy.OptionsColumn.ReadOnly = True
        Me.colPaidChangedBy.Visible = True
        Me.colPaidChangedBy.VisibleIndex = 5
        Me.colPaidChangedBy.Width = 76
        '
        'colPaidChangedDate
        '
        Me.colPaidChangedDate.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colPaidChangedDate.FieldName = "PaidChangedDate"
        Me.colPaidChangedDate.Name = "colPaidChangedDate"
        Me.colPaidChangedDate.OptionsColumn.ReadOnly = True
        Me.colPaidChangedDate.Visible = True
        Me.colPaidChangedDate.VisibleIndex = 6
        Me.colPaidChangedDate.Width = 81
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'DataNavigator1
        '
        Me.DataNavigator1.Buttons.Remove.Enabled = False
        Me.TableLayoutPanel9.SetColumnSpan(Me.DataNavigator1, 4)
        Me.DataNavigator1.DataSource = Me.EmployeesMoneyOwedBindingSource
        Me.DataNavigator1.Location = New System.Drawing.Point(26, 332)
        Me.DataNavigator1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataNavigator1.Name = "DataNavigator1"
        Me.DataNavigator1.Size = New System.Drawing.Size(847, 23)
        Me.DataNavigator1.TabIndex = 21
        Me.DataNavigator1.Text = "DataNavigator1"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(660, 111)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(144, 17)
        Me.Label87.TabIndex = 9
        Me.Label87.Text = "Status Changed Date:"
        '
        'StatusChangeDateTb
        '
        Me.StatusChangeDateTb.Location = New System.Drawing.Point(901, 115)
        Me.StatusChangeDateTb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StatusChangeDateTb.Name = "StatusChangeDateTb"
        Me.StatusChangeDateTb.Size = New System.Drawing.Size(160, 22)
        Me.StatusChangeDateTb.TabIndex = 22
        '
        'LastWorkedDateTb
        '
        Me.LastWorkedDateTb.Enabled = False
        Me.LastWorkedDateTb.Location = New System.Drawing.Point(901, 146)
        Me.LastWorkedDateTb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LastWorkedDateTb.Name = "LastWorkedDateTb"
        Me.LastWorkedDateTb.Size = New System.Drawing.Size(160, 22)
        Me.LastWorkedDateTb.TabIndex = 23
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label94.Location = New System.Drawing.Point(660, 142)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(235, 31)
        Me.Label94.TabIndex = 24
        Me.Label94.Text = "Last Worked Date:"
        '
        'TPLTDCompanyContratorDetails
        '
        Me.TPLTDCompanyContratorDetails.BackColor = System.Drawing.Color.Transparent
        Me.TPLTDCompanyContratorDetails.Controls.Add(Me.TableLayoutPanel10)
        Me.TPLTDCompanyContratorDetails.Location = New System.Drawing.Point(4, 25)
        Me.TPLTDCompanyContratorDetails.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TPLTDCompanyContratorDetails.Name = "TPLTDCompanyContratorDetails"
        Me.TPLTDCompanyContratorDetails.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TPLTDCompanyContratorDetails.Size = New System.Drawing.Size(1118, 593)
        Me.TPLTDCompanyContratorDetails.TabIndex = 8
        Me.TPLTDCompanyContratorDetails.Text = "LTD Company Contrator Details"
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 5
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.41883!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.64939!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.45916!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.43047!))
        Me.TableLayoutPanel10.Controls.Add(Me.LtdCompanyName, 2, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.Label64, 1, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.Label65, 1, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.Label66, 1, 3)
        Me.TableLayoutPanel10.Controls.Add(Me.Label67, 1, 4)
        Me.TableLayoutPanel10.Controls.Add(Me.Label68, 1, 5)
        Me.TableLayoutPanel10.Controls.Add(Me.CoRegistrationNumber, 2, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.CorporationCertCopied, 2, 3)
        Me.TableLayoutPanel10.Controls.Add(Me.VatRegistered, 2, 4)
        Me.TableLayoutPanel10.Controls.Add(Me.VatNumber, 2, 5)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 4)
        Me.TableLayoutPanel10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 19
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(1112, 585)
        Me.TableLayoutPanel10.TabIndex = 8
        '
        'LtdCompanyName
        '
        Me.LtdCompanyName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LtdCompanyName.Location = New System.Drawing.Point(259, 22)
        Me.LtdCompanyName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LtdCompanyName.Name = "LtdCompanyName"
        Me.LtdCompanyName.Size = New System.Drawing.Size(306, 23)
        Me.LtdCompanyName.TabIndex = 0
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(26, 18)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(145, 17)
        Me.Label64.TabIndex = 1
        Me.Label64.Text = "Ltd Company Name"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(26, 50)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(175, 17)
        Me.Label65.TabIndex = 2
        Me.Label65.Text = "Co Registration Number"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(26, 80)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(177, 17)
        Me.Label66.TabIndex = 3
        Me.Label66.Text = "Corperation Cert Copied"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(26, 111)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(96, 17)
        Me.Label67.TabIndex = 4
        Me.Label67.Text = "Vat Registered"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(26, 142)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(81, 17)
        Me.Label68.TabIndex = 5
        Me.Label68.Text = "Vat Number"
        '
        'CoRegistrationNumber
        '
        Me.CoRegistrationNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CoRegistrationNumber.Location = New System.Drawing.Point(259, 54)
        Me.CoRegistrationNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CoRegistrationNumber.Name = "CoRegistrationNumber"
        Me.CoRegistrationNumber.Size = New System.Drawing.Size(306, 23)
        Me.CoRegistrationNumber.TabIndex = 1
        '
        'CorporationCertCopied
        '
        Me.CorporationCertCopied.AutoSize = True
        Me.CorporationCertCopied.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CorporationCertCopied.Location = New System.Drawing.Point(259, 84)
        Me.CorporationCertCopied.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CorporationCertCopied.Name = "CorporationCertCopied"
        Me.CorporationCertCopied.Size = New System.Drawing.Size(306, 23)
        Me.CorporationCertCopied.TabIndex = 2
        Me.CorporationCertCopied.UseVisualStyleBackColor = True
        '
        'VatRegistered
        '
        Me.VatRegistered.AutoSize = True
        Me.VatRegistered.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VatRegistered.Location = New System.Drawing.Point(259, 115)
        Me.VatRegistered.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.VatRegistered.Name = "VatRegistered"
        Me.VatRegistered.Size = New System.Drawing.Size(306, 23)
        Me.VatRegistered.TabIndex = 3
        Me.VatRegistered.UseVisualStyleBackColor = True
        '
        'VatNumber
        '
        Me.VatNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VatNumber.Location = New System.Drawing.Point(259, 146)
        Me.VatNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.VatNumber.Name = "VatNumber"
        Me.VatNumber.Size = New System.Drawing.Size(306, 23)
        Me.VatNumber.TabIndex = 4
        '
        'TPDriving
        '
        Me.TPDriving.BackColor = System.Drawing.Color.Transparent
        Me.TPDriving.Controls.Add(Me.tblelayour)
        Me.TPDriving.Location = New System.Drawing.Point(4, 25)
        Me.TPDriving.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TPDriving.Name = "TPDriving"
        Me.TPDriving.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TPDriving.Size = New System.Drawing.Size(1118, 593)
        Me.TPDriving.TabIndex = 7
        Me.TPDriving.Text = "Driving"
        '
        'tblelayour
        '
        Me.tblelayour.BackColor = System.Drawing.Color.Transparent
        Me.tblelayour.ColumnCount = 5
        Me.tblelayour.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.tblelayour.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.90066!))
        Me.tblelayour.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.42643!))
        Me.tblelayour.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.07481!))
        Me.tblelayour.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.43047!))
        Me.tblelayour.Controls.Add(Me.CE, 2, 1)
        Me.tblelayour.Controls.Add(Me.C, 2, 2)
        Me.tblelayour.Controls.Add(Me.Tonn75, 2, 3)
        Me.tblelayour.Controls.Add(Me.Van, 2, 4)
        Me.tblelayour.Controls.Add(Me.Hiab, 2, 5)
        Me.tblelayour.Controls.Add(Me.Moffat, 2, 6)
        Me.tblelayour.Controls.Add(Me.Tipper1, 2, 7)
        Me.tblelayour.Controls.Add(Me.Tipper2, 2, 8)
        Me.tblelayour.Controls.Add(Me.Tipper75T, 2, 9)
        Me.tblelayour.Controls.Add(Me.RollOnOff, 2, 10)
        Me.tblelayour.Controls.Add(Me.MultiLift, 2, 11)
        Me.tblelayour.Controls.Add(Me.PVC, 2, 12)
        Me.tblelayour.Controls.Add(Me.MB, 2, 13)
        Me.tblelayour.Controls.Add(Me.AFrame, 2, 14)
        Me.tblelayour.Controls.Add(Me.CloseCoupled, 2, 15)
        Me.tblelayour.Controls.Add(Me.CurtainBox, 2, 16)
        Me.tblelayour.Controls.Add(Me.FlatFridge, 4, 1)
        Me.tblelayour.Controls.Add(Me.Lowloader, 4, 2)
        Me.tblelayour.Controls.Add(Me.Container1, 4, 3)
        Me.tblelayour.Controls.Add(Me.DeMounts, 4, 4)
        Me.tblelayour.Controls.Add(Me.WalkingFloor, 4, 6)
        Me.tblelayour.Controls.Add(Me.DoubleDeck, 4, 5)
        Me.tblelayour.Controls.Add(Me.ChainnDog, 4, 7)
        Me.tblelayour.Controls.Add(Me.Strap, 4, 8)
        Me.tblelayour.Controls.Add(Me.Rope, 4, 9)
        Me.tblelayour.Controls.Add(Me.Sheet, 4, 10)
        Me.tblelayour.Controls.Add(Me.SteelShunter, 4, 11)
        Me.tblelayour.Controls.Add(Me.HBall, 4, 12)
        Me.tblelayour.Controls.Add(Me.TLift, 4, 13)
        Me.tblelayour.Controls.Add(Me.FLT, 4, 14)
        Me.tblelayour.Controls.Add(Me.ADRTanks, 4, 15)
        Me.tblelayour.Controls.Add(Me.ADRPackages, 4, 16)
        Me.tblelayour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblelayour.Location = New System.Drawing.Point(3, 4)
        Me.tblelayour.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tblelayour.Name = "tblelayour"
        Me.tblelayour.RowCount = 19
        Me.tblelayour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tblelayour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tblelayour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblelayour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tblelayour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tblelayour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tblelayour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tblelayour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tblelayour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tblelayour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tblelayour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tblelayour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tblelayour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tblelayour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tblelayour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tblelayour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tblelayour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tblelayour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tblelayour.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tblelayour.Size = New System.Drawing.Size(1112, 585)
        Me.tblelayour.TabIndex = 6
        '
        'CE
        '
        Me.CE.AutoSize = True
        Me.CE.Location = New System.Drawing.Point(188, 22)
        Me.CE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CE.Name = "CE"
        Me.CE.Size = New System.Drawing.Size(47, 21)
        Me.CE.TabIndex = 0
        Me.CE.Text = "CE"
        Me.CE.UseVisualStyleBackColor = True
        '
        'C
        '
        Me.C.AutoSize = True
        Me.C.Location = New System.Drawing.Point(188, 54)
        Me.C.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(39, 21)
        Me.C.TabIndex = 1
        Me.C.Text = "C"
        Me.C.UseVisualStyleBackColor = True
        '
        'Tonn75
        '
        Me.Tonn75.AutoSize = True
        Me.Tonn75.Location = New System.Drawing.Point(188, 84)
        Me.Tonn75.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Tonn75.Name = "Tonn75"
        Me.Tonn75.Size = New System.Drawing.Size(86, 21)
        Me.Tonn75.TabIndex = 2
        Me.Tonn75.Text = "7.5 Tonn"
        Me.Tonn75.UseVisualStyleBackColor = True
        '
        'Van
        '
        Me.Van.AutoSize = True
        Me.Van.Location = New System.Drawing.Point(188, 115)
        Me.Van.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Van.Name = "Van"
        Me.Van.Size = New System.Drawing.Size(53, 21)
        Me.Van.TabIndex = 3
        Me.Van.Text = "Van"
        Me.Van.UseVisualStyleBackColor = True
        '
        'Hiab
        '
        Me.Hiab.Location = New System.Drawing.Point(188, 146)
        Me.Hiab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Hiab.Name = "Hiab"
        Me.Hiab.Size = New System.Drawing.Size(121, 23)
        Me.Hiab.TabIndex = 4
        Me.Hiab.Text = "Hiab"
        Me.Hiab.UseVisualStyleBackColor = True
        '
        'Moffat
        '
        Me.Moffat.AutoSize = True
        Me.Moffat.Location = New System.Drawing.Point(188, 177)
        Me.Moffat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Moffat.Name = "Moffat"
        Me.Moffat.Size = New System.Drawing.Size(68, 21)
        Me.Moffat.TabIndex = 5
        Me.Moffat.Text = "Moffat"
        Me.Moffat.UseVisualStyleBackColor = True
        '
        'Tipper1
        '
        Me.Tipper1.AutoSize = True
        Me.Tipper1.Location = New System.Drawing.Point(188, 208)
        Me.Tipper1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Tipper1.Name = "Tipper1"
        Me.Tipper1.Size = New System.Drawing.Size(76, 21)
        Me.Tipper1.TabIndex = 6
        Me.Tipper1.Text = "Tipper1"
        Me.Tipper1.UseVisualStyleBackColor = True
        '
        'Tipper2
        '
        Me.Tipper2.AutoSize = True
        Me.Tipper2.Location = New System.Drawing.Point(188, 239)
        Me.Tipper2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Tipper2.Name = "Tipper2"
        Me.Tipper2.Size = New System.Drawing.Size(76, 21)
        Me.Tipper2.TabIndex = 7
        Me.Tipper2.Text = "Tipper2"
        Me.Tipper2.UseVisualStyleBackColor = True
        '
        'Tipper75T
        '
        Me.Tipper75T.AutoSize = True
        Me.Tipper75T.Location = New System.Drawing.Point(188, 270)
        Me.Tipper75T.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Tipper75T.Name = "Tipper75T"
        Me.Tipper75T.Size = New System.Drawing.Size(96, 21)
        Me.Tipper75T.TabIndex = 8
        Me.Tipper75T.Text = "Tipper7.5T"
        Me.Tipper75T.UseVisualStyleBackColor = True
        '
        'RollOnOff
        '
        Me.RollOnOff.AutoSize = True
        Me.RollOnOff.Location = New System.Drawing.Point(188, 301)
        Me.RollOnOff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RollOnOff.Name = "RollOnOff"
        Me.RollOnOff.Size = New System.Drawing.Size(96, 21)
        Me.RollOnOff.TabIndex = 9
        Me.RollOnOff.Text = "Roll On/Off"
        Me.RollOnOff.UseVisualStyleBackColor = True
        '
        'MultiLift
        '
        Me.MultiLift.AutoSize = True
        Me.MultiLift.Location = New System.Drawing.Point(188, 332)
        Me.MultiLift.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MultiLift.Name = "MultiLift"
        Me.MultiLift.Size = New System.Drawing.Size(80, 21)
        Me.MultiLift.TabIndex = 10
        Me.MultiLift.Text = "Multi-Lift"
        Me.MultiLift.UseVisualStyleBackColor = True
        '
        'PVC
        '
        Me.PVC.AutoSize = True
        Me.PVC.Location = New System.Drawing.Point(188, 363)
        Me.PVC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PVC.Name = "PVC"
        Me.PVC.Size = New System.Drawing.Size(55, 21)
        Me.PVC.TabIndex = 11
        Me.PVC.Text = "PVC"
        Me.PVC.UseVisualStyleBackColor = True
        '
        'MB
        '
        Me.MB.AutoSize = True
        Me.MB.Location = New System.Drawing.Point(188, 394)
        Me.MB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MB.Name = "MB"
        Me.MB.Size = New System.Drawing.Size(53, 21)
        Me.MB.TabIndex = 12
        Me.MB.Text = "M/B"
        Me.MB.UseVisualStyleBackColor = True
        '
        'AFrame
        '
        Me.AFrame.AutoSize = True
        Me.AFrame.Location = New System.Drawing.Point(188, 425)
        Me.AFrame.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AFrame.Name = "AFrame"
        Me.AFrame.Size = New System.Drawing.Size(80, 21)
        Me.AFrame.TabIndex = 13
        Me.AFrame.Text = "A Frame"
        Me.AFrame.UseVisualStyleBackColor = True
        '
        'CloseCoupled
        '
        Me.CloseCoupled.AutoSize = True
        Me.CloseCoupled.Location = New System.Drawing.Point(188, 456)
        Me.CloseCoupled.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CloseCoupled.Name = "CloseCoupled"
        Me.CloseCoupled.Size = New System.Drawing.Size(116, 21)
        Me.CloseCoupled.TabIndex = 14
        Me.CloseCoupled.Text = "Close Coupled"
        Me.CloseCoupled.UseVisualStyleBackColor = True
        '
        'CurtainBox
        '
        Me.CurtainBox.AutoSize = True
        Me.CurtainBox.Location = New System.Drawing.Point(188, 487)
        Me.CurtainBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CurtainBox.Name = "CurtainBox"
        Me.CurtainBox.Size = New System.Drawing.Size(102, 21)
        Me.CurtainBox.TabIndex = 15
        Me.CurtainBox.Text = "Curtain Box"
        Me.CurtainBox.UseVisualStyleBackColor = True
        '
        'FlatFridge
        '
        Me.FlatFridge.AutoSize = True
        Me.FlatFridge.Location = New System.Drawing.Point(726, 22)
        Me.FlatFridge.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FlatFridge.Name = "FlatFridge"
        Me.FlatFridge.Size = New System.Drawing.Size(92, 21)
        Me.FlatFridge.TabIndex = 16
        Me.FlatFridge.Text = "Flat Fridge"
        Me.FlatFridge.UseVisualStyleBackColor = True
        '
        'Lowloader
        '
        Me.Lowloader.AutoSize = True
        Me.Lowloader.Location = New System.Drawing.Point(726, 54)
        Me.Lowloader.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Lowloader.Name = "Lowloader"
        Me.Lowloader.Size = New System.Drawing.Size(96, 21)
        Me.Lowloader.TabIndex = 17
        Me.Lowloader.Text = "Low loader"
        Me.Lowloader.UseVisualStyleBackColor = True
        '
        'Container1
        '
        Me.Container1.AutoSize = True
        Me.Container1.Location = New System.Drawing.Point(726, 84)
        Me.Container1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Container1.Name = "Container1"
        Me.Container1.Size = New System.Drawing.Size(89, 21)
        Me.Container1.TabIndex = 18
        Me.Container1.Text = "Container"
        Me.Container1.UseVisualStyleBackColor = True
        '
        'DeMounts
        '
        Me.DeMounts.AutoSize = True
        Me.DeMounts.Location = New System.Drawing.Point(726, 115)
        Me.DeMounts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DeMounts.Name = "DeMounts"
        Me.DeMounts.Size = New System.Drawing.Size(97, 21)
        Me.DeMounts.TabIndex = 19
        Me.DeMounts.Text = "De-Mounts"
        Me.DeMounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DeMounts.UseVisualStyleBackColor = True
        '
        'WalkingFloor
        '
        Me.WalkingFloor.AutoSize = True
        Me.WalkingFloor.Location = New System.Drawing.Point(726, 177)
        Me.WalkingFloor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WalkingFloor.Name = "WalkingFloor"
        Me.WalkingFloor.Size = New System.Drawing.Size(112, 21)
        Me.WalkingFloor.TabIndex = 21
        Me.WalkingFloor.Text = "Walking Floor"
        Me.WalkingFloor.UseVisualStyleBackColor = True
        '
        'DoubleDeck
        '
        Me.DoubleDeck.AutoSize = True
        Me.DoubleDeck.Location = New System.Drawing.Point(726, 146)
        Me.DoubleDeck.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DoubleDeck.Name = "DoubleDeck"
        Me.DoubleDeck.Size = New System.Drawing.Size(108, 21)
        Me.DoubleDeck.TabIndex = 20
        Me.DoubleDeck.Text = "Double Deck"
        Me.DoubleDeck.UseVisualStyleBackColor = True
        '
        'ChainnDog
        '
        Me.ChainnDog.AutoSize = True
        Me.ChainnDog.Location = New System.Drawing.Point(726, 208)
        Me.ChainnDog.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ChainnDog.Name = "ChainnDog"
        Me.ChainnDog.Size = New System.Drawing.Size(106, 21)
        Me.ChainnDog.TabIndex = 22
        Me.ChainnDog.Text = "Chain n Dog"
        Me.ChainnDog.UseVisualStyleBackColor = True
        '
        'Strap
        '
        Me.Strap.AutoSize = True
        Me.Strap.Location = New System.Drawing.Point(726, 239)
        Me.Strap.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Strap.Name = "Strap"
        Me.Strap.Size = New System.Drawing.Size(63, 21)
        Me.Strap.TabIndex = 23
        Me.Strap.Text = "Strap"
        Me.Strap.UseVisualStyleBackColor = True
        '
        'Rope
        '
        Me.Rope.AutoSize = True
        Me.Rope.Location = New System.Drawing.Point(726, 270)
        Me.Rope.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Rope.Name = "Rope"
        Me.Rope.Size = New System.Drawing.Size(62, 21)
        Me.Rope.TabIndex = 24
        Me.Rope.Text = "Rope"
        Me.Rope.UseVisualStyleBackColor = True
        '
        'Sheet
        '
        Me.Sheet.AutoSize = True
        Me.Sheet.Location = New System.Drawing.Point(726, 301)
        Me.Sheet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Sheet.Name = "Sheet"
        Me.Sheet.Size = New System.Drawing.Size(65, 21)
        Me.Sheet.TabIndex = 25
        Me.Sheet.Text = "Sheet"
        Me.Sheet.UseVisualStyleBackColor = True
        '
        'SteelShunter
        '
        Me.SteelShunter.AutoSize = True
        Me.SteelShunter.Location = New System.Drawing.Point(726, 332)
        Me.SteelShunter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SteelShunter.Name = "SteelShunter"
        Me.SteelShunter.Size = New System.Drawing.Size(112, 21)
        Me.SteelShunter.TabIndex = 26
        Me.SteelShunter.Text = "Steel Shunter"
        Me.SteelShunter.UseVisualStyleBackColor = True
        '
        'HBall
        '
        Me.HBall.AutoSize = True
        Me.HBall.Location = New System.Drawing.Point(726, 363)
        Me.HBall.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HBall.Name = "HBall"
        Me.HBall.Size = New System.Drawing.Size(63, 21)
        Me.HBall.TabIndex = 27
        Me.HBall.Text = "H/Ball"
        Me.HBall.UseVisualStyleBackColor = True
        '
        'TLift
        '
        Me.TLift.AutoSize = True
        Me.TLift.Location = New System.Drawing.Point(726, 394)
        Me.TLift.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TLift.Name = "TLift"
        Me.TLift.Size = New System.Drawing.Size(61, 21)
        Me.TLift.TabIndex = 28
        Me.TLift.Text = "T/Lift"
        Me.TLift.UseVisualStyleBackColor = True
        '
        'FLT
        '
        Me.FLT.AutoSize = True
        Me.FLT.Location = New System.Drawing.Point(726, 425)
        Me.FLT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FLT.Name = "FLT"
        Me.FLT.Size = New System.Drawing.Size(52, 21)
        Me.FLT.TabIndex = 29
        Me.FLT.Text = "FLT"
        Me.FLT.UseVisualStyleBackColor = True
        '
        'ADRTanks
        '
        Me.ADRTanks.AutoSize = True
        Me.ADRTanks.Location = New System.Drawing.Point(726, 456)
        Me.ADRTanks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ADRTanks.Name = "ADRTanks"
        Me.ADRTanks.Size = New System.Drawing.Size(97, 21)
        Me.ADRTanks.TabIndex = 30
        Me.ADRTanks.Text = "ADR Tanks"
        Me.ADRTanks.UseVisualStyleBackColor = True
        '
        'ADRPackages
        '
        Me.ADRPackages.AutoSize = True
        Me.ADRPackages.Location = New System.Drawing.Point(726, 487)
        Me.ADRPackages.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ADRPackages.Name = "ADRPackages"
        Me.ADRPackages.Size = New System.Drawing.Size(118, 21)
        Me.ADRPackages.TabIndex = 31
        Me.ADRPackages.Text = "ADR Packages"
        Me.ADRPackages.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.Transparent
        Me.TabPage7.Controls.Add(Me.TableLayoutPanel8)
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage7.Size = New System.Drawing.Size(1118, 593)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Industrial"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 5
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.90066!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.20971!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.45916!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.43047!))
        Me.TableLayoutPanel8.Controls.Add(Me.Assembler, 2, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.Production, 2, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.Warehouse, 2, 3)
        Me.TableLayoutPanel8.Controls.Add(Me.Groundwork, 2, 4)
        Me.TableLayoutPanel8.Controls.Add(Me.TrafficMngt, 2, 5)
        Me.TableLayoutPanel8.Controls.Add(Me.MigWelder, 2, 6)
        Me.TableLayoutPanel8.Controls.Add(Me.GeneralOp, 2, 7)
        Me.TableLayoutPanel8.Controls.Add(Me.MachineOp, 2, 8)
        Me.TableLayoutPanel8.Controls.Add(Me.PressOp, 2, 9)
        Me.TableLayoutPanel8.Controls.Add(Me.OrderPicker, 2, 10)
        Me.TableLayoutPanel8.Controls.Add(Me.Labourer, 2, 11)
        Me.TableLayoutPanel8.Controls.Add(Me.Joiner, 2, 12)
        Me.TableLayoutPanel8.Controls.Add(Me.TigWelder, 2, 13)
        Me.TableLayoutPanel8.Controls.Add(Me.QInspector, 2, 14)
        Me.TableLayoutPanel8.Controls.Add(Me.Setter, 2, 15)
        Me.TableLayoutPanel8.Controls.Add(Me.Driving, 2, 16)
        Me.TableLayoutPanel8.Controls.Add(Me.Packer, 4, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.Cleaner, 4, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.Admin, 4, 3)
        Me.TableLayoutPanel8.Controls.Add(Me.Braize, 4, 4)
        Me.TableLayoutPanel8.Controls.Add(Me.FSA, 4, 5)
        Me.TableLayoutPanel8.Controls.Add(Me.FLTRT, 4, 6)
        Me.TableLayoutPanel8.Controls.Add(Me.FLTNA, 4, 7)
        Me.TableLayoutPanel8.Controls.Add(Me.FLTBendi, 4, 8)
        Me.TableLayoutPanel8.Controls.Add(Me.FLTCB, 4, 9)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 4)
        Me.TableLayoutPanel8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 19
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(1112, 585)
        Me.TableLayoutPanel8.TabIndex = 7
        '
        'Assembler
        '
        Me.Assembler.AutoSize = True
        Me.Assembler.Location = New System.Drawing.Point(188, 22)
        Me.Assembler.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Assembler.Name = "Assembler"
        Me.Assembler.Size = New System.Drawing.Size(91, 21)
        Me.Assembler.TabIndex = 0
        Me.Assembler.Text = "Assembler"
        Me.Assembler.UseVisualStyleBackColor = True
        '
        'Production
        '
        Me.Production.AutoSize = True
        Me.Production.Location = New System.Drawing.Point(188, 54)
        Me.Production.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Production.Name = "Production"
        Me.Production.Size = New System.Drawing.Size(97, 21)
        Me.Production.TabIndex = 1
        Me.Production.Text = "Production"
        Me.Production.UseVisualStyleBackColor = True
        '
        'Warehouse
        '
        Me.Warehouse.AutoSize = True
        Me.Warehouse.Location = New System.Drawing.Point(188, 84)
        Me.Warehouse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Warehouse.Name = "Warehouse"
        Me.Warehouse.Size = New System.Drawing.Size(100, 21)
        Me.Warehouse.TabIndex = 2
        Me.Warehouse.Text = "Warehouse"
        Me.Warehouse.UseVisualStyleBackColor = True
        '
        'Groundwork
        '
        Me.Groundwork.AutoSize = True
        Me.Groundwork.Location = New System.Drawing.Point(188, 115)
        Me.Groundwork.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Groundwork.Name = "Groundwork"
        Me.Groundwork.Size = New System.Drawing.Size(101, 21)
        Me.Groundwork.TabIndex = 3
        Me.Groundwork.Text = "Goundwork"
        Me.Groundwork.UseVisualStyleBackColor = True
        '
        'TrafficMngt
        '
        Me.TrafficMngt.AutoSize = True
        Me.TrafficMngt.Location = New System.Drawing.Point(188, 146)
        Me.TrafficMngt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TrafficMngt.Name = "TrafficMngt"
        Me.TrafficMngt.Size = New System.Drawing.Size(98, 21)
        Me.TrafficMngt.TabIndex = 4
        Me.TrafficMngt.Text = "TrafficMngt"
        Me.TrafficMngt.UseVisualStyleBackColor = True
        '
        'MigWelder
        '
        Me.MigWelder.AutoSize = True
        Me.MigWelder.Location = New System.Drawing.Point(188, 177)
        Me.MigWelder.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MigWelder.Name = "MigWelder"
        Me.MigWelder.Size = New System.Drawing.Size(93, 21)
        Me.MigWelder.TabIndex = 5
        Me.MigWelder.Text = "MigWelder"
        Me.MigWelder.UseVisualStyleBackColor = True
        '
        'GeneralOp
        '
        Me.GeneralOp.AutoSize = True
        Me.GeneralOp.Location = New System.Drawing.Point(188, 208)
        Me.GeneralOp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GeneralOp.Name = "GeneralOp"
        Me.GeneralOp.Size = New System.Drawing.Size(93, 21)
        Me.GeneralOp.TabIndex = 6
        Me.GeneralOp.Text = "GeneralOp"
        Me.GeneralOp.UseVisualStyleBackColor = True
        '
        'MachineOp
        '
        Me.MachineOp.AutoSize = True
        Me.MachineOp.Location = New System.Drawing.Point(188, 239)
        Me.MachineOp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MachineOp.Name = "MachineOp"
        Me.MachineOp.Size = New System.Drawing.Size(97, 21)
        Me.MachineOp.TabIndex = 7
        Me.MachineOp.Text = "MachineOp"
        Me.MachineOp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MachineOp.UseVisualStyleBackColor = True
        '
        'PressOp
        '
        Me.PressOp.AutoSize = True
        Me.PressOp.Location = New System.Drawing.Point(188, 270)
        Me.PressOp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PressOp.Name = "PressOp"
        Me.PressOp.Size = New System.Drawing.Size(80, 21)
        Me.PressOp.TabIndex = 8
        Me.PressOp.Text = "PressOp"
        Me.PressOp.UseVisualStyleBackColor = True
        '
        'OrderPicker
        '
        Me.OrderPicker.AutoSize = True
        Me.OrderPicker.Location = New System.Drawing.Point(188, 301)
        Me.OrderPicker.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OrderPicker.Name = "OrderPicker"
        Me.OrderPicker.Size = New System.Drawing.Size(101, 21)
        Me.OrderPicker.TabIndex = 9
        Me.OrderPicker.Text = "OrderPicker"
        Me.OrderPicker.UseVisualStyleBackColor = True
        '
        'Labourer
        '
        Me.Labourer.AutoSize = True
        Me.Labourer.Location = New System.Drawing.Point(188, 332)
        Me.Labourer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Labourer.Name = "Labourer"
        Me.Labourer.Size = New System.Drawing.Size(85, 21)
        Me.Labourer.TabIndex = 10
        Me.Labourer.Text = "Labourer"
        Me.Labourer.UseVisualStyleBackColor = True
        '
        'Joiner
        '
        Me.Joiner.AutoSize = True
        Me.Joiner.Location = New System.Drawing.Point(188, 363)
        Me.Joiner.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Joiner.Name = "Joiner"
        Me.Joiner.Size = New System.Drawing.Size(66, 21)
        Me.Joiner.TabIndex = 11
        Me.Joiner.Text = "Joiner"
        Me.Joiner.UseVisualStyleBackColor = True
        '
        'TigWelder
        '
        Me.TigWelder.AutoSize = True
        Me.TigWelder.Location = New System.Drawing.Point(188, 394)
        Me.TigWelder.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TigWelder.Name = "TigWelder"
        Me.TigWelder.Size = New System.Drawing.Size(91, 21)
        Me.TigWelder.TabIndex = 12
        Me.TigWelder.Text = "TigWelder"
        Me.TigWelder.UseVisualStyleBackColor = True
        '
        'QInspector
        '
        Me.QInspector.AutoSize = True
        Me.QInspector.Location = New System.Drawing.Point(188, 425)
        Me.QInspector.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QInspector.Name = "QInspector"
        Me.QInspector.Size = New System.Drawing.Size(98, 21)
        Me.QInspector.TabIndex = 13
        Me.QInspector.Text = "QInspector"
        Me.QInspector.UseVisualStyleBackColor = True
        '
        'Setter
        '
        Me.Setter.AutoSize = True
        Me.Setter.Location = New System.Drawing.Point(188, 456)
        Me.Setter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Setter.Name = "Setter"
        Me.Setter.Size = New System.Drawing.Size(67, 21)
        Me.Setter.TabIndex = 14
        Me.Setter.Text = "Setter"
        Me.Setter.UseVisualStyleBackColor = True
        '
        'Driving
        '
        Me.Driving.AutoSize = True
        Me.Driving.Location = New System.Drawing.Point(188, 487)
        Me.Driving.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Driving.Name = "Driving"
        Me.Driving.Size = New System.Drawing.Size(73, 21)
        Me.Driving.TabIndex = 15
        Me.Driving.Text = "Driving"
        Me.Driving.UseVisualStyleBackColor = True
        '
        'Packer
        '
        Me.Packer.AutoSize = True
        Me.Packer.Location = New System.Drawing.Point(728, 22)
        Me.Packer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Packer.Name = "Packer"
        Me.Packer.Size = New System.Drawing.Size(71, 21)
        Me.Packer.TabIndex = 16
        Me.Packer.Text = "Packer"
        Me.Packer.UseVisualStyleBackColor = True
        '
        'Cleaner
        '
        Me.Cleaner.AutoSize = True
        Me.Cleaner.Location = New System.Drawing.Point(728, 54)
        Me.Cleaner.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cleaner.Name = "Cleaner"
        Me.Cleaner.Size = New System.Drawing.Size(75, 21)
        Me.Cleaner.TabIndex = 17
        Me.Cleaner.Text = "Cleaner"
        Me.Cleaner.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.Admin.AutoSize = True
        Me.Admin.Location = New System.Drawing.Point(728, 84)
        Me.Admin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(68, 21)
        Me.Admin.TabIndex = 18
        Me.Admin.Text = "Admin"
        Me.Admin.UseVisualStyleBackColor = True
        '
        'Braize
        '
        Me.Braize.AutoSize = True
        Me.Braize.Location = New System.Drawing.Point(728, 115)
        Me.Braize.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Braize.Name = "Braize"
        Me.Braize.Size = New System.Drawing.Size(65, 21)
        Me.Braize.TabIndex = 19
        Me.Braize.Text = "Braize"
        Me.Braize.UseVisualStyleBackColor = True
        '
        'FSA
        '
        Me.FSA.AutoSize = True
        Me.FSA.Location = New System.Drawing.Point(728, 146)
        Me.FSA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FSA.Name = "FSA"
        Me.FSA.Size = New System.Drawing.Size(53, 21)
        Me.FSA.TabIndex = 20
        Me.FSA.Text = "FSA"
        Me.FSA.UseVisualStyleBackColor = True
        '
        'FLTRT
        '
        Me.FLTRT.AutoSize = True
        Me.FLTRT.Location = New System.Drawing.Point(728, 177)
        Me.FLTRT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FLTRT.Name = "FLTRT"
        Me.FLTRT.Size = New System.Drawing.Size(69, 21)
        Me.FLTRT.TabIndex = 21
        Me.FLTRT.Text = "FLTRT"
        Me.FLTRT.UseVisualStyleBackColor = True
        '
        'FLTNA
        '
        Me.FLTNA.AutoSize = True
        Me.FLTNA.Location = New System.Drawing.Point(728, 208)
        Me.FLTNA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FLTNA.Name = "FLTNA"
        Me.FLTNA.Size = New System.Drawing.Size(69, 21)
        Me.FLTNA.TabIndex = 22
        Me.FLTNA.Text = "FLTNA"
        Me.FLTNA.UseVisualStyleBackColor = True
        '
        'FLTBendi
        '
        Me.FLTBendi.AutoSize = True
        Me.FLTBendi.Location = New System.Drawing.Point(728, 239)
        Me.FLTBendi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FLTBendi.Name = "FLTBendi"
        Me.FLTBendi.Size = New System.Drawing.Size(85, 21)
        Me.FLTBendi.TabIndex = 23
        Me.FLTBendi.Text = "FLTBendi"
        Me.FLTBendi.UseVisualStyleBackColor = True
        '
        'FLTCB
        '
        Me.FLTCB.AutoSize = True
        Me.FLTCB.Location = New System.Drawing.Point(728, 270)
        Me.FLTCB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FLTCB.Name = "FLTCB"
        Me.FLTCB.Size = New System.Drawing.Size(69, 21)
        Me.FLTCB.TabIndex = 24
        Me.FLTCB.Text = "FLTCB"
        Me.FLTCB.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.Transparent
        Me.TabPage6.Controls.Add(Me.TableLayoutPanel7)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage6.Size = New System.Drawing.Size(1118, 593)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "ProofOfID"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel7.ColumnCount = 5
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.27558!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.69441!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.05321!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.84038!))
        Me.TableLayoutPanel7.Controls.Add(Me.Passport, 2, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.NatIdCard, 2, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.ProofOfNi, 2, 3)
        Me.TableLayoutPanel7.Controls.Add(Me.BirthCert, 2, 4)
        Me.TableLayoutPanel7.Controls.Add(Me.NiCard, 2, 5)
        Me.TableLayoutPanel7.Controls.Add(Me.UtilityBill, 2, 6)
        Me.TableLayoutPanel7.Controls.Add(Me.CV, 2, 7)
        Me.TableLayoutPanel7.Controls.Add(Me.Visa, 2, 8)
        Me.TableLayoutPanel7.Controls.Add(Me.CSCSCard, 2, 9)
        Me.TableLayoutPanel7.Controls.Add(Me.CPCSCard, 2, 10)
        Me.TableLayoutPanel7.Controls.Add(Me.DrivingLicense, 2, 11)
        Me.TableLayoutPanel7.Controls.Add(Me.DigiCard, 2, 12)
        Me.TableLayoutPanel7.Controls.Add(Me.CPCM1, 2, 13)
        Me.TableLayoutPanel7.Controls.Add(Me.CPCM2, 2, 14)
        Me.TableLayoutPanel7.Controls.Add(Me.CPCM4, 2, 16)
        Me.TableLayoutPanel7.Controls.Add(Me.CPCM5, 2, 17)
        Me.TableLayoutPanel7.Controls.Add(Me.CPCM3, 2, 15)
        Me.TableLayoutPanel7.Controls.Add(Me.Label88, 3, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Label89, 3, 8)
        Me.TableLayoutPanel7.Controls.Add(Me.Label90, 3, 11)
        Me.TableLayoutPanel7.Controls.Add(Me.DrivingExpiryDate, 4, 11)
        Me.TableLayoutPanel7.Controls.Add(Me.VisaExpiryDate, 4, 8)
        Me.TableLayoutPanel7.Controls.Add(Me.PassportExpiryDate, 4, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.DigiCardExpiryDate, 4, 12)
        Me.TableLayoutPanel7.Controls.Add(Me.DQCExpiryDate, 4, 13)
        Me.TableLayoutPanel7.Controls.Add(Me.Label92, 3, 12)
        Me.TableLayoutPanel7.Controls.Add(Me.Label93, 3, 13)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 4)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 19
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1112, 585)
        Me.TableLayoutPanel7.TabIndex = 7
        '
        'Passport
        '
        Me.Passport.AutoSize = True
        Me.Passport.Location = New System.Drawing.Point(94, 22)
        Me.Passport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Passport.Name = "Passport"
        Me.Passport.Size = New System.Drawing.Size(83, 21)
        Me.Passport.TabIndex = 0
        Me.Passport.Text = "Passport"
        Me.Passport.UseVisualStyleBackColor = True
        '
        'NatIdCard
        '
        Me.NatIdCard.AutoSize = True
        Me.NatIdCard.Location = New System.Drawing.Point(94, 54)
        Me.NatIdCard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NatIdCard.Name = "NatIdCard"
        Me.NatIdCard.Size = New System.Drawing.Size(92, 21)
        Me.NatIdCard.TabIndex = 1
        Me.NatIdCard.Text = "NatIdCard"
        Me.NatIdCard.UseVisualStyleBackColor = True
        '
        'ProofOfNi
        '
        Me.ProofOfNi.AutoSize = True
        Me.ProofOfNi.Location = New System.Drawing.Point(94, 84)
        Me.ProofOfNi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProofOfNi.Name = "ProofOfNi"
        Me.ProofOfNi.Size = New System.Drawing.Size(88, 21)
        Me.ProofOfNi.TabIndex = 2
        Me.ProofOfNi.Text = "ProofOfNi"
        Me.ProofOfNi.UseVisualStyleBackColor = True
        '
        'BirthCert
        '
        Me.BirthCert.AutoSize = True
        Me.BirthCert.Location = New System.Drawing.Point(94, 115)
        Me.BirthCert.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BirthCert.Name = "BirthCert"
        Me.BirthCert.Size = New System.Drawing.Size(84, 21)
        Me.BirthCert.TabIndex = 3
        Me.BirthCert.Text = "BirthCert"
        Me.BirthCert.UseVisualStyleBackColor = True
        '
        'NiCard
        '
        Me.NiCard.AutoSize = True
        Me.NiCard.Location = New System.Drawing.Point(94, 146)
        Me.NiCard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NiCard.Name = "NiCard"
        Me.NiCard.Size = New System.Drawing.Size(70, 21)
        Me.NiCard.TabIndex = 4
        Me.NiCard.Text = "NiCard"
        Me.NiCard.UseVisualStyleBackColor = True
        '
        'UtilityBill
        '
        Me.UtilityBill.AutoSize = True
        Me.UtilityBill.Location = New System.Drawing.Point(94, 177)
        Me.UtilityBill.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UtilityBill.Name = "UtilityBill"
        Me.UtilityBill.Size = New System.Drawing.Size(77, 21)
        Me.UtilityBill.TabIndex = 5
        Me.UtilityBill.Text = "UtilityBill"
        Me.UtilityBill.UseVisualStyleBackColor = True
        '
        'CV
        '
        Me.CV.AutoSize = True
        Me.CV.Location = New System.Drawing.Point(94, 208)
        Me.CV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CV.Name = "CV"
        Me.CV.Size = New System.Drawing.Size(47, 21)
        Me.CV.TabIndex = 6
        Me.CV.Text = "CV"
        Me.CV.UseVisualStyleBackColor = True
        '
        'Visa
        '
        Me.Visa.AutoSize = True
        Me.Visa.Location = New System.Drawing.Point(94, 239)
        Me.Visa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Visa.Name = "Visa"
        Me.Visa.Size = New System.Drawing.Size(53, 21)
        Me.Visa.TabIndex = 7
        Me.Visa.Text = "Visa"
        Me.Visa.UseVisualStyleBackColor = True
        '
        'CSCSCard
        '
        Me.CSCSCard.AutoSize = True
        Me.CSCSCard.Location = New System.Drawing.Point(94, 270)
        Me.CSCSCard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CSCSCard.Name = "CSCSCard"
        Me.CSCSCard.Size = New System.Drawing.Size(93, 21)
        Me.CSCSCard.TabIndex = 8
        Me.CSCSCard.Text = "CSCSCard"
        Me.CSCSCard.UseVisualStyleBackColor = True
        '
        'CPCSCard
        '
        Me.CPCSCard.AutoSize = True
        Me.CPCSCard.Location = New System.Drawing.Point(94, 301)
        Me.CPCSCard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CPCSCard.Name = "CPCSCard"
        Me.CPCSCard.Size = New System.Drawing.Size(93, 21)
        Me.CPCSCard.TabIndex = 9
        Me.CPCSCard.Text = "CPCSCard"
        Me.CPCSCard.UseVisualStyleBackColor = True
        '
        'DrivingLicense
        '
        Me.DrivingLicense.AutoSize = True
        Me.DrivingLicense.Location = New System.Drawing.Point(94, 332)
        Me.DrivingLicense.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DrivingLicense.Name = "DrivingLicense"
        Me.DrivingLicense.Size = New System.Drawing.Size(117, 21)
        Me.DrivingLicense.TabIndex = 10
        Me.DrivingLicense.Text = "DrivingLicense"
        Me.DrivingLicense.UseVisualStyleBackColor = True
        '
        'DigiCard
        '
        Me.DigiCard.AutoSize = True
        Me.DigiCard.Location = New System.Drawing.Point(94, 363)
        Me.DigiCard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DigiCard.Name = "DigiCard"
        Me.DigiCard.Size = New System.Drawing.Size(81, 21)
        Me.DigiCard.TabIndex = 11
        Me.DigiCard.Text = "DigiCard"
        Me.DigiCard.UseVisualStyleBackColor = True
        '
        'CPCM1
        '
        Me.CPCM1.AutoSize = True
        Me.CPCM1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CPCM1.Location = New System.Drawing.Point(94, 394)
        Me.CPCM1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CPCM1.Name = "CPCM1"
        Me.CPCM1.Size = New System.Drawing.Size(296, 23)
        Me.CPCM1.TabIndex = 12
        Me.CPCM1.Text = "CPCM1 (Drivers Qualification Card)"
        Me.CPCM1.UseVisualStyleBackColor = True
        '
        'CPCM2
        '
        Me.CPCM2.AutoSize = True
        Me.CPCM2.Location = New System.Drawing.Point(94, 425)
        Me.CPCM2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CPCM2.Name = "CPCM2"
        Me.CPCM2.Size = New System.Drawing.Size(74, 21)
        Me.CPCM2.TabIndex = 13
        Me.CPCM2.Text = "CPCM2"
        Me.CPCM2.UseVisualStyleBackColor = True
        Me.CPCM2.Visible = False
        '
        'CPCM4
        '
        Me.CPCM4.AutoSize = True
        Me.CPCM4.Location = New System.Drawing.Point(94, 487)
        Me.CPCM4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CPCM4.Name = "CPCM4"
        Me.CPCM4.Size = New System.Drawing.Size(74, 21)
        Me.CPCM4.TabIndex = 15
        Me.CPCM4.Text = "CPCM4"
        Me.CPCM4.UseVisualStyleBackColor = True
        Me.CPCM4.Visible = False
        '
        'CPCM5
        '
        Me.CPCM5.AutoSize = True
        Me.CPCM5.Location = New System.Drawing.Point(94, 518)
        Me.CPCM5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CPCM5.Name = "CPCM5"
        Me.CPCM5.Size = New System.Drawing.Size(74, 21)
        Me.CPCM5.TabIndex = 16
        Me.CPCM5.Text = "CPCM5"
        Me.CPCM5.UseVisualStyleBackColor = True
        Me.CPCM5.Visible = False
        '
        'CPCM3
        '
        Me.CPCM3.AutoSize = True
        Me.CPCM3.Location = New System.Drawing.Point(94, 456)
        Me.CPCM3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CPCM3.Name = "CPCM3"
        Me.CPCM3.Size = New System.Drawing.Size(74, 21)
        Me.CPCM3.TabIndex = 14
        Me.CPCM3.Text = "CPCM3"
        Me.CPCM3.UseVisualStyleBackColor = True
        Me.CPCM3.Visible = False
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label88.Location = New System.Drawing.Point(396, 18)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(179, 32)
        Me.Label88.TabIndex = 18
        Me.Label88.Text = "Passport Expiry Date"
        Me.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label89.Location = New System.Drawing.Point(396, 235)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(179, 31)
        Me.Label89.TabIndex = 19
        Me.Label89.Text = "Visa Expiry Date"
        Me.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label90.Location = New System.Drawing.Point(396, 328)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(179, 31)
        Me.Label90.TabIndex = 20
        Me.Label90.Text = "Driving Expiry Date"
        Me.Label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DrivingExpiryDate
        '
        Me.DrivingExpiryDate.EditValue = Nothing
        Me.DrivingExpiryDate.Location = New System.Drawing.Point(581, 332)
        Me.DrivingExpiryDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DrivingExpiryDate.Name = "DrivingExpiryDate"
        Me.DrivingExpiryDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DrivingExpiryDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DrivingExpiryDate.Properties.DisplayFormat.FormatString = "d MMM yyyy"
        Me.DrivingExpiryDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DrivingExpiryDate.Properties.EditFormat.FormatString = "d MMM yyyy"
        Me.DrivingExpiryDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DrivingExpiryDate.Properties.Mask.EditMask = "d MMM yyyy"
        Me.DrivingExpiryDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.DrivingExpiryDate.Size = New System.Drawing.Size(453, 22)
        Me.DrivingExpiryDate.TabIndex = 24
        '
        'VisaExpiryDate
        '
        Me.VisaExpiryDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisaExpiryDate.EditValue = Nothing
        Me.VisaExpiryDate.Location = New System.Drawing.Point(581, 239)
        Me.VisaExpiryDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.VisaExpiryDate.Name = "VisaExpiryDate"
        Me.VisaExpiryDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VisaExpiryDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VisaExpiryDate.Properties.DisplayFormat.FormatString = "d MMM yyyy"
        Me.VisaExpiryDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.VisaExpiryDate.Properties.EditFormat.FormatString = "d MMM yyyy"
        Me.VisaExpiryDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.VisaExpiryDate.Properties.Mask.EditMask = "d MMM yyyy"
        Me.VisaExpiryDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.VisaExpiryDate.Size = New System.Drawing.Size(528, 22)
        Me.VisaExpiryDate.TabIndex = 25
        '
        'PassportExpiryDate
        '
        Me.PassportExpiryDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PassportExpiryDate.EditValue = Nothing
        Me.PassportExpiryDate.Location = New System.Drawing.Point(581, 22)
        Me.PassportExpiryDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PassportExpiryDate.Name = "PassportExpiryDate"
        Me.PassportExpiryDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PassportExpiryDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PassportExpiryDate.Properties.DisplayFormat.FormatString = "d MMM yyyy"
        Me.PassportExpiryDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PassportExpiryDate.Properties.EditFormat.FormatString = "d MMM yyyy"
        Me.PassportExpiryDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PassportExpiryDate.Properties.Mask.EditMask = "d MMM yyyy"
        Me.PassportExpiryDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.PassportExpiryDate.Size = New System.Drawing.Size(528, 22)
        Me.PassportExpiryDate.TabIndex = 26
        '
        'DigiCardExpiryDate
        '
        Me.DigiCardExpiryDate.EditValue = Nothing
        Me.DigiCardExpiryDate.Location = New System.Drawing.Point(581, 363)
        Me.DigiCardExpiryDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DigiCardExpiryDate.Name = "DigiCardExpiryDate"
        Me.DigiCardExpiryDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DigiCardExpiryDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DigiCardExpiryDate.Properties.DisplayFormat.FormatString = "d MMM yyyy"
        Me.DigiCardExpiryDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DigiCardExpiryDate.Properties.EditFormat.FormatString = "d MMM yyyy"
        Me.DigiCardExpiryDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DigiCardExpiryDate.Properties.Mask.EditMask = "d MMM yyyy"
        Me.DigiCardExpiryDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.DigiCardExpiryDate.Size = New System.Drawing.Size(453, 22)
        Me.DigiCardExpiryDate.TabIndex = 24
        '
        'DQCExpiryDate
        '
        Me.DQCExpiryDate.EditValue = Nothing
        Me.DQCExpiryDate.Location = New System.Drawing.Point(581, 394)
        Me.DQCExpiryDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DQCExpiryDate.Name = "DQCExpiryDate"
        Me.DQCExpiryDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DQCExpiryDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DQCExpiryDate.Properties.DisplayFormat.FormatString = "d MMM yyyy"
        Me.DQCExpiryDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DQCExpiryDate.Properties.EditFormat.FormatString = "d MMM yyyy"
        Me.DQCExpiryDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DQCExpiryDate.Properties.Mask.EditMask = "d MMM yyyy"
        Me.DQCExpiryDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.DQCExpiryDate.Size = New System.Drawing.Size(453, 22)
        Me.DQCExpiryDate.TabIndex = 24
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label92.Location = New System.Drawing.Point(396, 359)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(179, 31)
        Me.Label92.TabIndex = 20
        Me.Label92.Text = "Digi Card Expiry Date"
        Me.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label93.Location = New System.Drawing.Point(396, 390)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(179, 31)
        Me.Label93.TabIndex = 20
        Me.Label93.Text = "Drivers Qualification Card Expiry Date"
        Me.Label93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.Transparent
        Me.TabPage5.Controls.Add(Me.TableLayoutPanel6)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage5.Size = New System.Drawing.Size(1118, 593)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "WorkHistory3"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 5
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.90066!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.20971!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.45916!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.43047!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label51, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Label52, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Label53, 1, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.Label54, 1, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.Label55, 1, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.Label56, 1, 6)
        Me.TableLayoutPanel6.Controls.Add(Me.Label57, 1, 7)
        Me.TableLayoutPanel6.Controls.Add(Me.Label58, 1, 8)
        Me.TableLayoutPanel6.Controls.Add(Me.Label59, 1, 9)
        Me.TableLayoutPanel6.Controls.Add(Me.Label60, 1, 10)
        Me.TableLayoutPanel6.Controls.Add(Me.Label61, 1, 11)
        Me.TableLayoutPanel6.Controls.Add(Me.Label62, 1, 12)
        Me.TableLayoutPanel6.Controls.Add(Me.Label63, 1, 13)
        Me.TableLayoutPanel6.Controls.Add(Me.WorkFrom3, 2, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.WorkTo3, 2, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.WorkedVia3, 2, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.AgencyName3, 2, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.CompanyName3, 2, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.Location3, 2, 6)
        Me.TableLayoutPanel6.Controls.Add(Me.JobTitle3, 2, 7)
        Me.TableLayoutPanel6.Controls.Add(Me.Shift3, 2, 8)
        Me.TableLayoutPanel6.Controls.Add(Me.Pay3, 2, 9)
        Me.TableLayoutPanel6.Controls.Add(Me.ReasonForLeaving3, 2, 10)
        Me.TableLayoutPanel6.Controls.Add(Me.Manager3, 2, 11)
        Me.TableLayoutPanel6.Controls.Add(Me.RefAvailable2, 2, 12)
        Me.TableLayoutPanel6.Controls.Add(Me.ContactNumber3, 2, 13)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 4)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 16
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(1112, 585)
        Me.TableLayoutPanel6.TabIndex = 3
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(26, 18)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(74, 17)
        Me.Label51.TabIndex = 0
        Me.Label51.Text = "WorkFrom"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(26, 50)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(58, 17)
        Me.Label52.TabIndex = 1
        Me.Label52.Text = "WorkTo"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(26, 80)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(74, 17)
        Me.Label53.TabIndex = 2
        Me.Label53.Text = "WorkedVia"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(26, 111)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(99, 17)
        Me.Label54.TabIndex = 3
        Me.Label54.Text = "AgencyName"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(26, 142)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(103, 17)
        Me.Label55.TabIndex = 4
        Me.Label55.Text = "CompanyName"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(26, 173)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(60, 17)
        Me.Label56.TabIndex = 5
        Me.Label56.Text = "Location"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(26, 204)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(54, 17)
        Me.Label57.TabIndex = 6
        Me.Label57.Text = "JobTitle"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(26, 235)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(35, 17)
        Me.Label58.TabIndex = 7
        Me.Label58.Text = "Shift"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(26, 266)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(31, 17)
        Me.Label59.TabIndex = 8
        Me.Label59.Text = "Pay"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(26, 297)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(120, 17)
        Me.Label60.TabIndex = 9
        Me.Label60.Text = "ReasonForLeaving"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(26, 328)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(60, 17)
        Me.Label61.TabIndex = 10
        Me.Label61.Text = "Manager"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(26, 359)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(83, 17)
        Me.Label62.TabIndex = 11
        Me.Label62.Text = "Ref Available"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(26, 390)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(110, 17)
        Me.Label63.TabIndex = 12
        Me.Label63.Text = "Contact Number"
        '
        'WorkFrom3
        '
        Me.WorkFrom3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkFrom3.Location = New System.Drawing.Point(188, 22)
        Me.WorkFrom3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WorkFrom3.Name = "WorkFrom3"
        Me.WorkFrom3.Size = New System.Drawing.Size(377, 23)
        Me.WorkFrom3.TabIndex = 13
        '
        'WorkTo3
        '
        Me.WorkTo3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkTo3.Location = New System.Drawing.Point(188, 54)
        Me.WorkTo3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WorkTo3.Name = "WorkTo3"
        Me.WorkTo3.Size = New System.Drawing.Size(377, 23)
        Me.WorkTo3.TabIndex = 14
        '
        'WorkedVia3
        '
        Me.WorkedVia3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.WorkedVia3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkedVia3.FormattingEnabled = True
        Me.WorkedVia3.Items.AddRange(New Object() {"Agency ", "Direct", "Unemployed "})
        Me.WorkedVia3.Location = New System.Drawing.Point(188, 84)
        Me.WorkedVia3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WorkedVia3.Name = "WorkedVia3"
        Me.WorkedVia3.Size = New System.Drawing.Size(377, 24)
        Me.WorkedVia3.TabIndex = 15
        '
        'AgencyName3
        '
        Me.AgencyName3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AgencyName3.Location = New System.Drawing.Point(188, 115)
        Me.AgencyName3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AgencyName3.Name = "AgencyName3"
        Me.AgencyName3.Size = New System.Drawing.Size(377, 23)
        Me.AgencyName3.TabIndex = 16
        '
        'CompanyName3
        '
        Me.CompanyName3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CompanyName3.Location = New System.Drawing.Point(188, 146)
        Me.CompanyName3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CompanyName3.Name = "CompanyName3"
        Me.CompanyName3.Size = New System.Drawing.Size(377, 23)
        Me.CompanyName3.TabIndex = 17
        '
        'Location3
        '
        Me.Location3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Location3.Location = New System.Drawing.Point(188, 177)
        Me.Location3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Location3.Name = "Location3"
        Me.Location3.Size = New System.Drawing.Size(377, 23)
        Me.Location3.TabIndex = 18
        '
        'JobTitle3
        '
        Me.JobTitle3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JobTitle3.Location = New System.Drawing.Point(188, 208)
        Me.JobTitle3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JobTitle3.Name = "JobTitle3"
        Me.JobTitle3.Size = New System.Drawing.Size(377, 23)
        Me.JobTitle3.TabIndex = 19
        '
        'Shift3
        '
        Me.Shift3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Shift3.Location = New System.Drawing.Point(188, 239)
        Me.Shift3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Shift3.Name = "Shift3"
        Me.Shift3.Size = New System.Drawing.Size(377, 23)
        Me.Shift3.TabIndex = 20
        '
        'Pay3
        '
        Me.Pay3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pay3.Location = New System.Drawing.Point(188, 270)
        Me.Pay3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pay3.Name = "Pay3"
        Me.Pay3.Size = New System.Drawing.Size(377, 23)
        Me.Pay3.TabIndex = 21
        '
        'ReasonForLeaving3
        '
        Me.ReasonForLeaving3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReasonForLeaving3.Location = New System.Drawing.Point(188, 301)
        Me.ReasonForLeaving3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReasonForLeaving3.Name = "ReasonForLeaving3"
        Me.ReasonForLeaving3.Size = New System.Drawing.Size(377, 23)
        Me.ReasonForLeaving3.TabIndex = 22
        '
        'Manager3
        '
        Me.Manager3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Manager3.Location = New System.Drawing.Point(188, 332)
        Me.Manager3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Manager3.Name = "Manager3"
        Me.Manager3.Size = New System.Drawing.Size(377, 23)
        Me.Manager3.TabIndex = 23
        '
        'RefAvailable2
        '
        Me.RefAvailable2.AutoSize = True
        Me.RefAvailable2.Location = New System.Drawing.Point(188, 363)
        Me.RefAvailable2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RefAvailable2.Name = "RefAvailable2"
        Me.RefAvailable2.Size = New System.Drawing.Size(18, 17)
        Me.RefAvailable2.TabIndex = 24
        Me.RefAvailable2.UseVisualStyleBackColor = True
        '
        'ContactNumber3
        '
        Me.ContactNumber3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContactNumber3.Location = New System.Drawing.Point(188, 394)
        Me.ContactNumber3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ContactNumber3.Name = "ContactNumber3"
        Me.ContactNumber3.Size = New System.Drawing.Size(377, 23)
        Me.ContactNumber3.TabIndex = 25
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Transparent
        Me.TabPage4.Controls.Add(Me.TableLayoutPanel5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage4.Size = New System.Drawing.Size(1118, 593)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "WorkHistory2"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel5.ColumnCount = 5
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.90066!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.20971!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.45916!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.43047!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label38, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label39, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Label40, 1, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.Label41, 1, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.Label42, 1, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.Label43, 1, 6)
        Me.TableLayoutPanel5.Controls.Add(Me.Label44, 1, 7)
        Me.TableLayoutPanel5.Controls.Add(Me.Label45, 1, 8)
        Me.TableLayoutPanel5.Controls.Add(Me.Label46, 1, 9)
        Me.TableLayoutPanel5.Controls.Add(Me.Label47, 1, 10)
        Me.TableLayoutPanel5.Controls.Add(Me.Label48, 1, 11)
        Me.TableLayoutPanel5.Controls.Add(Me.Label49, 1, 12)
        Me.TableLayoutPanel5.Controls.Add(Me.Label50, 1, 13)
        Me.TableLayoutPanel5.Controls.Add(Me.WorkFrom2, 2, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.WorkTo2, 2, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.WorkedVia2, 2, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.AgencyName2, 2, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.CompanyName2, 2, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.Location2, 2, 6)
        Me.TableLayoutPanel5.Controls.Add(Me.JobTitle2, 2, 7)
        Me.TableLayoutPanel5.Controls.Add(Me.Shift2, 2, 8)
        Me.TableLayoutPanel5.Controls.Add(Me.Pay2, 2, 9)
        Me.TableLayoutPanel5.Controls.Add(Me.ReasonForLeaving2, 2, 10)
        Me.TableLayoutPanel5.Controls.Add(Me.Manager2, 2, 11)
        Me.TableLayoutPanel5.Controls.Add(Me.RefAvailable1, 2, 12)
        Me.TableLayoutPanel5.Controls.Add(Me.ContactNumber2, 2, 13)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 4)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 16
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1112, 585)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(26, 18)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(74, 17)
        Me.Label38.TabIndex = 0
        Me.Label38.Text = "WorkFrom"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(26, 50)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(58, 17)
        Me.Label39.TabIndex = 1
        Me.Label39.Text = "WorkTo"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(26, 80)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(74, 17)
        Me.Label40.TabIndex = 2
        Me.Label40.Text = "WorkedVia"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(26, 111)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(99, 17)
        Me.Label41.TabIndex = 3
        Me.Label41.Text = "AgencyName"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(26, 142)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(103, 17)
        Me.Label42.TabIndex = 4
        Me.Label42.Text = "CompanyName"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(26, 173)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(60, 17)
        Me.Label43.TabIndex = 5
        Me.Label43.Text = "Location"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(26, 204)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(54, 17)
        Me.Label44.TabIndex = 6
        Me.Label44.Text = "JobTitle"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(26, 235)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(35, 17)
        Me.Label45.TabIndex = 7
        Me.Label45.Text = "Shift"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(26, 266)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(31, 17)
        Me.Label46.TabIndex = 8
        Me.Label46.Text = "Pay"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(26, 297)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(120, 17)
        Me.Label47.TabIndex = 9
        Me.Label47.Text = "ReasonForLeaving"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(26, 328)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(60, 17)
        Me.Label48.TabIndex = 10
        Me.Label48.Text = "Manager"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(26, 359)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(83, 17)
        Me.Label49.TabIndex = 11
        Me.Label49.Text = "Ref Available"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(26, 390)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(110, 17)
        Me.Label50.TabIndex = 12
        Me.Label50.Text = "Contact Number"
        '
        'WorkFrom2
        '
        Me.WorkFrom2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkFrom2.Location = New System.Drawing.Point(188, 22)
        Me.WorkFrom2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WorkFrom2.Name = "WorkFrom2"
        Me.WorkFrom2.Size = New System.Drawing.Size(377, 23)
        Me.WorkFrom2.TabIndex = 13
        '
        'WorkTo2
        '
        Me.WorkTo2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkTo2.Location = New System.Drawing.Point(188, 54)
        Me.WorkTo2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WorkTo2.Name = "WorkTo2"
        Me.WorkTo2.Size = New System.Drawing.Size(377, 23)
        Me.WorkTo2.TabIndex = 14
        '
        'WorkedVia2
        '
        Me.WorkedVia2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.WorkedVia2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkedVia2.FormattingEnabled = True
        Me.WorkedVia2.Items.AddRange(New Object() {"Agency ", "Direct", "Unemployed "})
        Me.WorkedVia2.Location = New System.Drawing.Point(188, 84)
        Me.WorkedVia2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WorkedVia2.Name = "WorkedVia2"
        Me.WorkedVia2.Size = New System.Drawing.Size(377, 24)
        Me.WorkedVia2.TabIndex = 15
        '
        'AgencyName2
        '
        Me.AgencyName2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AgencyName2.Location = New System.Drawing.Point(188, 115)
        Me.AgencyName2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AgencyName2.Name = "AgencyName2"
        Me.AgencyName2.Size = New System.Drawing.Size(377, 23)
        Me.AgencyName2.TabIndex = 16
        '
        'CompanyName2
        '
        Me.CompanyName2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CompanyName2.Location = New System.Drawing.Point(188, 146)
        Me.CompanyName2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CompanyName2.Name = "CompanyName2"
        Me.CompanyName2.Size = New System.Drawing.Size(377, 23)
        Me.CompanyName2.TabIndex = 17
        '
        'Location2
        '
        Me.Location2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Location2.Location = New System.Drawing.Point(188, 177)
        Me.Location2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Location2.Name = "Location2"
        Me.Location2.Size = New System.Drawing.Size(377, 23)
        Me.Location2.TabIndex = 18
        '
        'JobTitle2
        '
        Me.JobTitle2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JobTitle2.Location = New System.Drawing.Point(188, 208)
        Me.JobTitle2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JobTitle2.Name = "JobTitle2"
        Me.JobTitle2.Size = New System.Drawing.Size(377, 23)
        Me.JobTitle2.TabIndex = 19
        '
        'Shift2
        '
        Me.Shift2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Shift2.Location = New System.Drawing.Point(188, 239)
        Me.Shift2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Shift2.Name = "Shift2"
        Me.Shift2.Size = New System.Drawing.Size(377, 23)
        Me.Shift2.TabIndex = 20
        '
        'Pay2
        '
        Me.Pay2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pay2.Location = New System.Drawing.Point(188, 270)
        Me.Pay2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pay2.Name = "Pay2"
        Me.Pay2.Size = New System.Drawing.Size(377, 23)
        Me.Pay2.TabIndex = 21
        '
        'ReasonForLeaving2
        '
        Me.ReasonForLeaving2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReasonForLeaving2.Location = New System.Drawing.Point(188, 301)
        Me.ReasonForLeaving2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReasonForLeaving2.Name = "ReasonForLeaving2"
        Me.ReasonForLeaving2.Size = New System.Drawing.Size(377, 23)
        Me.ReasonForLeaving2.TabIndex = 22
        '
        'Manager2
        '
        Me.Manager2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Manager2.Location = New System.Drawing.Point(188, 332)
        Me.Manager2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Manager2.Name = "Manager2"
        Me.Manager2.Size = New System.Drawing.Size(377, 23)
        Me.Manager2.TabIndex = 23
        '
        'RefAvailable1
        '
        Me.RefAvailable1.AutoSize = True
        Me.RefAvailable1.Location = New System.Drawing.Point(188, 363)
        Me.RefAvailable1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RefAvailable1.Name = "RefAvailable1"
        Me.RefAvailable1.Size = New System.Drawing.Size(18, 17)
        Me.RefAvailable1.TabIndex = 24
        Me.RefAvailable1.UseVisualStyleBackColor = True
        '
        'ContactNumber2
        '
        Me.ContactNumber2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContactNumber2.Location = New System.Drawing.Point(188, 394)
        Me.ContactNumber2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ContactNumber2.Name = "ContactNumber2"
        Me.ContactNumber2.Size = New System.Drawing.Size(377, 23)
        Me.ContactNumber2.TabIndex = 25
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage3.Size = New System.Drawing.Size(1118, 593)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "WorkHistory"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.90066!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.20971!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.45916!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.43047!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label25, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label26, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label27, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Label28, 1, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.Label29, 1, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.Label30, 1, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.Label31, 1, 7)
        Me.TableLayoutPanel4.Controls.Add(Me.Label32, 1, 8)
        Me.TableLayoutPanel4.Controls.Add(Me.Label33, 1, 9)
        Me.TableLayoutPanel4.Controls.Add(Me.Label34, 1, 10)
        Me.TableLayoutPanel4.Controls.Add(Me.Label35, 1, 11)
        Me.TableLayoutPanel4.Controls.Add(Me.Label36, 1, 12)
        Me.TableLayoutPanel4.Controls.Add(Me.Label37, 1, 13)
        Me.TableLayoutPanel4.Controls.Add(Me.WorkFrom, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.WorkTo, 2, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.WorkedVia, 2, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.AgencyName, 2, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.CompanyName1, 2, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.Location1, 2, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.JobTitle, 2, 7)
        Me.TableLayoutPanel4.Controls.Add(Me.Shift, 2, 8)
        Me.TableLayoutPanel4.Controls.Add(Me.Pay, 2, 9)
        Me.TableLayoutPanel4.Controls.Add(Me.ReasonForLeaving, 2, 10)
        Me.TableLayoutPanel4.Controls.Add(Me.Manager, 2, 11)
        Me.TableLayoutPanel4.Controls.Add(Me.RefAvailable, 2, 12)
        Me.TableLayoutPanel4.Controls.Add(Me.ContactNumber, 2, 13)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 4)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 16
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1112, 585)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(26, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(74, 17)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "WorkFrom"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(26, 50)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(58, 17)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "WorkTo"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(26, 80)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(74, 17)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "WorkedVia"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(26, 111)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(99, 17)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "AgencyName"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(26, 142)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(103, 17)
        Me.Label29.TabIndex = 4
        Me.Label29.Text = "CompanyName"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(26, 173)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(60, 17)
        Me.Label30.TabIndex = 5
        Me.Label30.Text = "Location"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(26, 204)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(54, 17)
        Me.Label31.TabIndex = 6
        Me.Label31.Text = "JobTitle"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(26, 235)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(35, 17)
        Me.Label32.TabIndex = 7
        Me.Label32.Text = "Shift"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(26, 266)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(31, 17)
        Me.Label33.TabIndex = 8
        Me.Label33.Text = "Pay"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(26, 297)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(120, 17)
        Me.Label34.TabIndex = 9
        Me.Label34.Text = "ReasonForLeaving"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(26, 328)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(60, 17)
        Me.Label35.TabIndex = 10
        Me.Label35.Text = "Manager"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(26, 359)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(83, 17)
        Me.Label36.TabIndex = 11
        Me.Label36.Text = "Ref Available"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(26, 390)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(110, 17)
        Me.Label37.TabIndex = 12
        Me.Label37.Text = "Contact Number"
        '
        'WorkFrom
        '
        Me.WorkFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkFrom.Location = New System.Drawing.Point(188, 22)
        Me.WorkFrom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WorkFrom.Name = "WorkFrom"
        Me.WorkFrom.Size = New System.Drawing.Size(377, 23)
        Me.WorkFrom.TabIndex = 1
        '
        'WorkTo
        '
        Me.WorkTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkTo.Location = New System.Drawing.Point(188, 54)
        Me.WorkTo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WorkTo.Name = "WorkTo"
        Me.WorkTo.Size = New System.Drawing.Size(377, 23)
        Me.WorkTo.TabIndex = 2
        '
        'WorkedVia
        '
        Me.WorkedVia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.WorkedVia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkedVia.FormattingEnabled = True
        Me.WorkedVia.Items.AddRange(New Object() {"Agency ", "Direct", "Unemployed "})
        Me.WorkedVia.Location = New System.Drawing.Point(188, 84)
        Me.WorkedVia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WorkedVia.Name = "WorkedVia"
        Me.WorkedVia.Size = New System.Drawing.Size(377, 24)
        Me.WorkedVia.TabIndex = 3
        '
        'AgencyName
        '
        Me.AgencyName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AgencyName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgencyName.Location = New System.Drawing.Point(188, 115)
        Me.AgencyName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AgencyName.Name = "AgencyName"
        Me.AgencyName.Size = New System.Drawing.Size(377, 24)
        Me.AgencyName.TabIndex = 4
        '
        'CompanyName1
        '
        Me.CompanyName1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CompanyName1.Location = New System.Drawing.Point(188, 146)
        Me.CompanyName1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CompanyName1.Name = "CompanyName1"
        Me.CompanyName1.Size = New System.Drawing.Size(377, 23)
        Me.CompanyName1.TabIndex = 5
        '
        'Location1
        '
        Me.Location1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Location1.Location = New System.Drawing.Point(188, 177)
        Me.Location1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Location1.Name = "Location1"
        Me.Location1.Size = New System.Drawing.Size(377, 23)
        Me.Location1.TabIndex = 6
        '
        'JobTitle
        '
        Me.JobTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JobTitle.Location = New System.Drawing.Point(188, 208)
        Me.JobTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.JobTitle.Name = "JobTitle"
        Me.JobTitle.Size = New System.Drawing.Size(377, 23)
        Me.JobTitle.TabIndex = 7
        '
        'Shift
        '
        Me.Shift.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Shift.Location = New System.Drawing.Point(188, 239)
        Me.Shift.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Shift.Name = "Shift"
        Me.Shift.Size = New System.Drawing.Size(377, 23)
        Me.Shift.TabIndex = 8
        '
        'Pay
        '
        Me.Pay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pay.Location = New System.Drawing.Point(188, 270)
        Me.Pay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pay.Name = "Pay"
        Me.Pay.Size = New System.Drawing.Size(377, 23)
        Me.Pay.TabIndex = 9
        '
        'ReasonForLeaving
        '
        Me.ReasonForLeaving.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReasonForLeaving.Location = New System.Drawing.Point(188, 301)
        Me.ReasonForLeaving.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReasonForLeaving.Name = "ReasonForLeaving"
        Me.ReasonForLeaving.Size = New System.Drawing.Size(377, 23)
        Me.ReasonForLeaving.TabIndex = 10
        '
        'Manager
        '
        Me.Manager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Manager.Location = New System.Drawing.Point(188, 332)
        Me.Manager.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Manager.Name = "Manager"
        Me.Manager.Size = New System.Drawing.Size(377, 23)
        Me.Manager.TabIndex = 11
        '
        'RefAvailable
        '
        Me.RefAvailable.AutoSize = True
        Me.RefAvailable.Location = New System.Drawing.Point(188, 363)
        Me.RefAvailable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RefAvailable.Name = "RefAvailable"
        Me.RefAvailable.Size = New System.Drawing.Size(18, 17)
        Me.RefAvailable.TabIndex = 12
        Me.RefAvailable.UseVisualStyleBackColor = True
        '
        'ContactNumber
        '
        Me.ContactNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContactNumber.Location = New System.Drawing.Point(188, 394)
        Me.ContactNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ContactNumber.Name = "ContactNumber"
        Me.ContactNumber.Size = New System.Drawing.Size(377, 23)
        Me.ContactNumber.TabIndex = 13
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Size = New System.Drawing.Size(1118, 593)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Accounts"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.96317!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.10505!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.45916!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.43047!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label19, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label20, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label21, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label22, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label23, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label24, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Sortcode, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.AccountNo, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.AccountInTheNameOf, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Bank, 2, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Email, 2, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.TaxCategory, 2, 8)
        Me.TableLayoutPanel3.Controls.Add(Me.TaxDetails, 2, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.Label76, 1, 8)
        Me.TableLayoutPanel3.Controls.Add(Me.Label75, 1, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.StudentLoan, 2, 9)
        Me.TableLayoutPanel3.Controls.Add(Me.Label79, 1, 9)
        Me.TableLayoutPanel3.Controls.Add(Me.PaymentFrequency, 2, 10)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl536, 1, 10)
        Me.TableLayoutPanel3.Controls.Add(Me.Tb_Email, 2, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.BankReference, 2, 11)
        Me.TableLayoutPanel3.Controls.Add(Me.Label91, 1, 11)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 4)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 16
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1112, 585)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(26, 18)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(200, 32)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Sort-Code"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(26, 50)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(200, 30)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Account No"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(26, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(200, 31)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Account In The Name Of"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(26, 111)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(200, 31)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "Bank"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label23.Location = New System.Drawing.Point(26, 142)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(200, 31)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Email Payslip"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label24.Location = New System.Drawing.Point(26, 173)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(200, 31)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Email"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Sortcode
        '
        Me.Sortcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sortcode.Location = New System.Drawing.Point(232, 22)
        Me.Sortcode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Sortcode.MaxLength = 6
        Me.Sortcode.Name = "Sortcode"
        Me.Sortcode.Size = New System.Drawing.Size(332, 23)
        Me.Sortcode.TabIndex = 1
        '
        'AccountNo
        '
        Me.AccountNo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountNo.Location = New System.Drawing.Point(232, 54)
        Me.AccountNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AccountNo.MaxLength = 8
        Me.AccountNo.Name = "AccountNo"
        Me.AccountNo.Size = New System.Drawing.Size(332, 23)
        Me.AccountNo.TabIndex = 2
        '
        'AccountInTheNameOf
        '
        Me.AccountInTheNameOf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountInTheNameOf.Location = New System.Drawing.Point(232, 84)
        Me.AccountInTheNameOf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AccountInTheNameOf.MaxLength = 100
        Me.AccountInTheNameOf.Name = "AccountInTheNameOf"
        Me.AccountInTheNameOf.Size = New System.Drawing.Size(332, 23)
        Me.AccountInTheNameOf.TabIndex = 3
        '
        'Bank
        '
        Me.Bank.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Bank.Location = New System.Drawing.Point(232, 115)
        Me.Bank.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Bank.MaxLength = 50
        Me.Bank.Name = "Bank"
        Me.Bank.Size = New System.Drawing.Size(332, 23)
        Me.Bank.TabIndex = 4
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Email.Location = New System.Drawing.Point(232, 146)
        Me.Email.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(332, 23)
        Me.Email.TabIndex = 5
        Me.Email.UseVisualStyleBackColor = True
        '
        'TaxCategory
        '
        Me.TaxCategory.FormattingEnabled = True
        Me.TaxCategory.Items.AddRange(New Object() {"A", "B", "C", "None"})
        Me.TaxCategory.Location = New System.Drawing.Point(232, 239)
        Me.TaxCategory.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TaxCategory.Name = "TaxCategory"
        Me.TaxCategory.Size = New System.Drawing.Size(258, 24)
        Me.TaxCategory.TabIndex = 14
        '
        'TaxDetails
        '
        Me.TaxDetails.FormattingEnabled = True
        Me.TaxDetails.Items.AddRange(New Object() {"P46", "P45", "P38", "None"})
        Me.TaxDetails.Location = New System.Drawing.Point(232, 208)
        Me.TaxDetails.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TaxDetails.Name = "TaxDetails"
        Me.TaxDetails.Size = New System.Drawing.Size(258, 24)
        Me.TaxDetails.TabIndex = 13
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label76.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(26, 235)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(200, 31)
        Me.Label76.TabIndex = 16
        Me.Label76.Text = "TaxCatagory"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label75.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(26, 204)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(200, 31)
        Me.Label75.TabIndex = 15
        Me.Label75.Text = "Tax Details"
        Me.Label75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StudentLoan
        '
        Me.StudentLoan.AutoSize = True
        Me.StudentLoan.Location = New System.Drawing.Point(232, 270)
        Me.StudentLoan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StudentLoan.Name = "StudentLoan"
        Me.StudentLoan.Size = New System.Drawing.Size(18, 17)
        Me.StudentLoan.TabIndex = 17
        Me.StudentLoan.UseVisualStyleBackColor = True
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label79.Location = New System.Drawing.Point(26, 266)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(200, 31)
        Me.Label79.TabIndex = 18
        Me.Label79.Text = "Student Loan"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PaymentFrequency
        '
        Me.PaymentFrequency.FormattingEnabled = True
        Me.PaymentFrequency.Items.AddRange(New Object() {"Weekly", "Monthly"})
        Me.PaymentFrequency.Location = New System.Drawing.Point(232, 301)
        Me.PaymentFrequency.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PaymentFrequency.Name = "PaymentFrequency"
        Me.PaymentFrequency.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PaymentFrequency.Size = New System.Drawing.Size(237, 24)
        Me.PaymentFrequency.TabIndex = 14
        Me.PaymentFrequency.Text = "Weekly"
        '
        'lbl536
        '
        Me.lbl536.AutoSize = True
        Me.lbl536.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl536.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl536.Location = New System.Drawing.Point(26, 297)
        Me.lbl536.Name = "lbl536"
        Me.lbl536.Size = New System.Drawing.Size(200, 31)
        Me.lbl536.TabIndex = 18
        Me.lbl536.Text = "Payment Frequency"
        Me.lbl536.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tb_Email
        '
        Me.Tb_Email.Location = New System.Drawing.Point(232, 177)
        Me.Tb_Email.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Tb_Email.Name = "Tb_Email"
        Me.Tb_Email.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None
        Me.Tb_Email.Properties.Mask.EditMask = "(\w|[\.\-])+@(\w|[\-]+\.)*(\w|[\-]){2,63}\.[a-zA-Z\.]{2,7}"
        Me.Tb_Email.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.Tb_Email.Properties.Mask.ShowPlaceHolders = False
        Me.Tb_Email.Size = New System.Drawing.Size(259, 22)
        Me.Tb_Email.TabIndex = 19
        '
        'BankReference
        '
        Me.BankReference.Location = New System.Drawing.Point(232, 332)
        Me.BankReference.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BankReference.Name = "BankReference"
        Me.BankReference.Size = New System.Drawing.Size(258, 23)
        Me.BankReference.TabIndex = 20
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label91.Location = New System.Drawing.Point(26, 328)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(200, 31)
        Me.Label91.TabIndex = 21
        Me.Label91.Text = "BankReference"
        Me.Label91.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(1118, 593)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.93363!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.28761!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.5075!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.42428!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Scheme, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Branch, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.EmployeeCode, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Forename, 2, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Surname, 2, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Title, 2, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.EthnicOrigin, 4, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.Label18, 3, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.EmergencyTelephone, 4, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.Label17, 3, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.EmergencyContact, 4, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Label16, 3, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Mobile, 4, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Label15, 3, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Telephone, 4, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 3, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.DOB, 4, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 3, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.PostCode, 4, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.County, 4, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.City, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Address2, 2, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 1, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.Address1, 2, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 1, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.EmployeeID, 2, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.MaritalStatus, 2, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.Label77, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.Gender, 2, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.Label78, 1, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.systemtypeTb, 4, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.NiNumber, 2, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 4)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 13
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1112, 585)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NI-Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Scheme"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Branch"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "EmployeeCode"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Title"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Forename"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Surname"
        '
        'Scheme
        '
        Me.Scheme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Scheme.FormattingEnabled = True
        Me.Scheme.Location = New System.Drawing.Point(188, 54)
        Me.Scheme.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Scheme.Name = "Scheme"
        Me.Scheme.Size = New System.Drawing.Size(377, 24)
        Me.Scheme.TabIndex = 2
        '
        'Branch
        '
        Me.Branch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Branch.FormattingEnabled = True
        Me.Branch.Location = New System.Drawing.Point(188, 84)
        Me.Branch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Branch.Name = "Branch"
        Me.Branch.Size = New System.Drawing.Size(377, 24)
        Me.Branch.TabIndex = 3
        '
        'EmployeeCode
        '
        Me.EmployeeCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmployeeCode.Location = New System.Drawing.Point(188, 115)
        Me.EmployeeCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmployeeCode.MaxLength = 100
        Me.EmployeeCode.Name = "EmployeeCode"
        Me.EmployeeCode.Size = New System.Drawing.Size(377, 23)
        Me.EmployeeCode.TabIndex = 4
        '
        'Forename
        '
        Me.Forename.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Forename.Location = New System.Drawing.Point(188, 177)
        Me.Forename.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Forename.MaxLength = 50
        Me.Forename.Name = "Forename"
        Me.Forename.Size = New System.Drawing.Size(377, 23)
        Me.Forename.TabIndex = 6
        '
        'Surname
        '
        Me.Surname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Surname.Location = New System.Drawing.Point(188, 208)
        Me.Surname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Surname.MaxLength = 50
        Me.Surname.Name = "Surname"
        Me.Surname.Size = New System.Drawing.Size(377, 23)
        Me.Surname.TabIndex = 7
        '
        'Title
        '
        Me.Title.AutoCompleteCustomSource.AddRange(New String() {"Mr", "Mrs", "Miss", "Ms"})
        Me.Title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Title.FormattingEnabled = True
        Me.Title.Items.AddRange(New Object() {"Mr", "Mrs", "Miss", "Ms"})
        Me.Title.Location = New System.Drawing.Point(188, 146)
        Me.Title.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Title.MaxLength = 20
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(377, 24)
        Me.Title.TabIndex = 5
        '
        'EthnicOrigin
        '
        Me.EthnicOrigin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EthnicOrigin.FormattingEnabled = True
        Me.EthnicOrigin.Items.AddRange(New Object() {"White other", "Black Other", "Bangledeshi", "Black African", "Indian", "Chinese", "White European", "Black Caribbean", "Pakistan", "Black European", "Other"})
        Me.EthnicOrigin.Location = New System.Drawing.Point(750, 270)
        Me.EthnicOrigin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EthnicOrigin.Name = "EthnicOrigin"
        Me.EthnicOrigin.Size = New System.Drawing.Size(359, 24)
        Me.EthnicOrigin.TabIndex = 20
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(571, 266)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 17)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Ethnic Origin"
        '
        'EmergencyTelephone
        '
        Me.EmergencyTelephone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmergencyTelephone.Location = New System.Drawing.Point(750, 239)
        Me.EmergencyTelephone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmergencyTelephone.MaxLength = 11
        Me.EmergencyTelephone.Name = "EmergencyTelephone"
        Me.EmergencyTelephone.Size = New System.Drawing.Size(359, 23)
        Me.EmergencyTelephone.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(571, 235)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(157, 17)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "EmergencyTelephone"
        '
        'EmergencyContact
        '
        Me.EmergencyContact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmergencyContact.Location = New System.Drawing.Point(750, 208)
        Me.EmergencyContact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmergencyContact.MaxLength = 50
        Me.EmergencyContact.Name = "EmergencyContact"
        Me.EmergencyContact.Size = New System.Drawing.Size(359, 23)
        Me.EmergencyContact.TabIndex = 18
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(571, 204)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(140, 17)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "EmergencyContact"
        '
        'Mobile
        '
        Me.Mobile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Mobile.Location = New System.Drawing.Point(750, 177)
        Me.Mobile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Mobile.Mask = "00000000000"
        Me.Mobile.Name = "Mobile"
        Me.Mobile.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Mobile.Size = New System.Drawing.Size(359, 23)
        Me.Mobile.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(571, 173)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 17)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Mobile"
        '
        'Telephone
        '
        Me.Telephone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Telephone.Location = New System.Drawing.Point(750, 146)
        Me.Telephone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Telephone.Mask = "00000000000"
        Me.Telephone.Name = "Telephone"
        Me.Telephone.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Telephone.Size = New System.Drawing.Size(359, 23)
        Me.Telephone.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(571, 142)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 17)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Telephone"
        '
        'DOB
        '
        Me.DOB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DOB.Location = New System.Drawing.Point(750, 115)
        Me.DOB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(359, 23)
        Me.DOB.TabIndex = 15
        Me.DOB.Value = New Date(2013, 6, 5, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(571, 111)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 17)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "DOB"
        '
        'PostCode
        '
        Me.PostCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PostCode.Location = New System.Drawing.Point(750, 84)
        Me.PostCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PostCode.MaxLength = 10
        Me.PostCode.Name = "PostCode"
        Me.PostCode.Size = New System.Drawing.Size(359, 23)
        Me.PostCode.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(571, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 17)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "PostCode"
        '
        'County
        '
        Me.County.Dock = System.Windows.Forms.DockStyle.Fill
        Me.County.Location = New System.Drawing.Point(750, 54)
        Me.County.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.County.MaxLength = 200
        Me.County.Name = "County"
        Me.County.Size = New System.Drawing.Size(359, 23)
        Me.County.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(571, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 17)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "County"
        '
        'City
        '
        Me.City.Dock = System.Windows.Forms.DockStyle.Fill
        Me.City.Location = New System.Drawing.Point(750, 22)
        Me.City.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.City.MaxLength = 200
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(359, 23)
        Me.City.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(571, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Town/City"
        '
        'Address2
        '
        Me.Address2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Address2.Location = New System.Drawing.Point(188, 333)
        Me.Address2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Address2.MaxLength = 200
        Me.Address2.Name = "Address2"
        Me.Address2.Size = New System.Drawing.Size(377, 23)
        Me.Address2.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Address 2"
        '
        'Address1
        '
        Me.Address1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Address1.Location = New System.Drawing.Point(188, 301)
        Me.Address1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Address1.MaxLength = 200
        Me.Address1.Name = "Address1"
        Me.Address1.Size = New System.Drawing.Size(377, 23)
        Me.Address1.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Address 1"
        '
        'EmployeeID
        '
        Me.EmployeeID.Location = New System.Drawing.Point(188, 363)
        Me.EmployeeID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(116, 23)
        Me.EmployeeID.TabIndex = 41
        Me.EmployeeID.Visible = False
        '
        'MaritalStatus
        '
        Me.MaritalStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaritalStatus.FormattingEnabled = True
        Me.MaritalStatus.Items.AddRange(New Object() {"Single", "Married", "Widowed", "Divorced"})
        Me.MaritalStatus.Location = New System.Drawing.Point(188, 239)
        Me.MaritalStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaritalStatus.Name = "MaritalStatus"
        Me.MaritalStatus.Size = New System.Drawing.Size(377, 24)
        Me.MaritalStatus.TabIndex = 8
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(26, 235)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(103, 17)
        Me.Label77.TabIndex = 7
        Me.Label77.Text = "Marital Status"
        '
        'Gender
        '
        Me.Gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Gender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gender.FormattingEnabled = True
        Me.Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.Gender.Location = New System.Drawing.Point(188, 270)
        Me.Gender.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(377, 24)
        Me.Gender.TabIndex = 9
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(26, 266)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(58, 17)
        Me.Label78.TabIndex = 7
        Me.Label78.Text = "Gender"
        '
        'systemtypeTb
        '
        Me.systemtypeTb.Location = New System.Drawing.Point(750, 363)
        Me.systemtypeTb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.systemtypeTb.Name = "systemtypeTb"
        Me.systemtypeTb.Size = New System.Drawing.Size(116, 23)
        Me.systemtypeTb.TabIndex = 42
        Me.systemtypeTb.Visible = False
        '
        'NiNumber
        '
        Me.NiNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NiNumber.Location = New System.Drawing.Point(188, 22)
        Me.NiNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NiNumber.Name = "NiNumber"
        Me.NiNumber.Properties.Mask.BeepOnError = True
        Me.NiNumber.Properties.Mask.EditMask = "\p{Lu}\p{Lu}\d\d\d\d\d\d\p{Lu}"
        Me.NiNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.NiNumber.Properties.Mask.ShowPlaceHolders = False
        Me.NiNumber.Size = New System.Drawing.Size(377, 22)
        Me.NiNumber.TabIndex = 43
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TPDriving)
        Me.TabControl1.Controls.Add(Me.TPLTDCompanyContratorDetails)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TBHeadOffice)
        Me.TabControl1.Location = New System.Drawing.Point(2, 4)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1126, 622)
        Me.TabControl1.TabIndex = 0
        '
        'TBHeadOffice
        '
        Me.TBHeadOffice.Controls.Add(Me.TableLayoutPanel11)
        Me.TBHeadOffice.Location = New System.Drawing.Point(4, 25)
        Me.TBHeadOffice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBHeadOffice.Name = "TBHeadOffice"
        Me.TBHeadOffice.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBHeadOffice.Size = New System.Drawing.Size(1118, 593)
        Me.TBHeadOffice.TabIndex = 10
        Me.TBHeadOffice.Text = "Head Office"
        Me.TBHeadOffice.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel11.ColumnCount = 5
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.37108!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.191!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.05321!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.38472!))
        Me.TableLayoutPanel11.Controls.Add(Me.Label72, 1, 1)
        Me.TableLayoutPanel11.Controls.Add(Me.SageRef, 2, 1)
        Me.TableLayoutPanel11.Controls.Add(Me.BranchLUE, 1, 4)
        Me.TableLayoutPanel11.Controls.Add(Me.SchemeLUE, 2, 4)
        Me.TableLayoutPanel11.Controls.Add(Me.Label73, 1, 3)
        Me.TableLayoutPanel11.Controls.Add(Me.Label85, 2, 3)
        Me.TableLayoutPanel11.Controls.Add(Me.SimpleButton1, 3, 4)
        Me.TableLayoutPanel11.Controls.Add(Me.Label95, 1, 6)
        Me.TableLayoutPanel11.Controls.Add(Me.Label96, 1, 7)
        Me.TableLayoutPanel11.Controls.Add(Me.Label97, 1, 8)
        Me.TableLayoutPanel11.Controls.Add(Me.Label98, 1, 9)
        Me.TableLayoutPanel11.Controls.Add(Me.LoyaltyCard, 2, 7)
        Me.TableLayoutPanel11.Controls.Add(Me.LoyaltyRank, 2, 9)
        Me.TableLayoutPanel11.Controls.Add(Me.LoyaltyPoints, 2, 8)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(3, 4)
        Me.TableLayoutPanel11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 19
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(1112, 585)
        Me.TableLayoutPanel11.TabIndex = 10
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label72.Location = New System.Drawing.Point(26, 18)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(172, 32)
        Me.Label72.TabIndex = 6
        Me.Label72.Text = "SageRef"
        '
        'SageRef
        '
        Me.SageRef.Location = New System.Drawing.Point(204, 22)
        Me.SageRef.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SageRef.Name = "SageRef"
        Me.SageRef.Size = New System.Drawing.Size(117, 22)
        Me.SageRef.TabIndex = 7
        '
        'BranchLUE
        '
        Me.BranchLUE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BranchLUE.EditValue = ""
        Me.BranchLUE.Location = New System.Drawing.Point(26, 114)
        Me.BranchLUE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BranchLUE.Name = "BranchLUE"
        Me.BranchLUE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BranchLUE.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BranchID", "Branch ID", 70, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch", "Branch", 43, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.BranchLUE.Properties.DataSource = Me.BranchBindingSource
        Me.BranchLUE.Properties.DisplayMember = "Branch"
        Me.BranchLUE.Properties.NullText = ""
        Me.BranchLUE.Properties.ValueMember = "BranchID"
        Me.BranchLUE.Size = New System.Drawing.Size(172, 22)
        Me.BranchLUE.TabIndex = 8
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
        'SchemeLUE
        '
        Me.SchemeLUE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SchemeLUE.Location = New System.Drawing.Point(204, 114)
        Me.SchemeLUE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SchemeLUE.Name = "SchemeLUE"
        Me.SchemeLUE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SchemeLUE.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SchemeID", "Scheme ID", 74, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Scheme", "Scheme", 47, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Holiday", "Holiday", 45, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.SchemeLUE.Properties.DataSource = Me.SchemesBindingSource
        Me.SchemeLUE.Properties.DisplayMember = "Scheme"
        Me.SchemeLUE.Properties.NullText = ""
        Me.SchemeLUE.Properties.ValueMember = "SchemeID"
        Me.SchemeLUE.Size = New System.Drawing.Size(213, 22)
        Me.SchemeLUE.TabIndex = 9
        '
        'SchemesBindingSource
        '
        Me.SchemesBindingSource.DataMember = "Schemes"
        Me.SchemesBindingSource.DataSource = Me.LexiconRecManagerDataSet
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label73.Location = New System.Drawing.Point(26, 80)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(172, 30)
        Me.Label73.TabIndex = 10
        Me.Label73.Text = "Branch"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label85.Location = New System.Drawing.Point(204, 80)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(213, 30)
        Me.Label85.TabIndex = 10
        Me.Label85.Text = "Scheme"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SimpleButton1.Location = New System.Drawing.Point(423, 114)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(179, 24)
        Me.SimpleButton1.TabIndex = 11
        Me.SimpleButton1.Text = "Clone"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Tahoma", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label95.Location = New System.Drawing.Point(26, 173)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(160, 23)
        Me.Label95.TabIndex = 12
        Me.Label95.Text = "Loyalty Scheme"
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Location = New System.Drawing.Point(26, 204)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(129, 17)
        Me.Label96.TabIndex = 13
        Me.Label96.Text = "Loyalty Card Issued"
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Location = New System.Drawing.Point(26, 235)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(94, 17)
        Me.Label97.TabIndex = 14
        Me.Label97.Text = "Loyalty Points"
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Location = New System.Drawing.Point(26, 266)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(88, 17)
        Me.Label98.TabIndex = 15
        Me.Label98.Text = "Loyalty Rank"
        '
        'LoyaltyCard
        '
        Me.LoyaltyCard.Location = New System.Drawing.Point(204, 207)
        Me.LoyaltyCard.Name = "LoyaltyCard"
        Me.LoyaltyCard.Properties.Caption = ""
        Me.LoyaltyCard.Size = New System.Drawing.Size(75, 19)
        Me.LoyaltyCard.TabIndex = 16
        '
        'LoyaltyRank
        '
        Me.LoyaltyRank.Location = New System.Drawing.Point(204, 269)
        Me.LoyaltyRank.Name = "LoyaltyRank"
        Me.LoyaltyRank.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LoyaltyRank.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bronze", "Bronze", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Silver", "Silver", 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Gold", "Gold", 2)})
        Me.LoyaltyRank.Properties.LargeImages = Me.ImageCollection1
        Me.LoyaltyRank.Properties.SmallImages = Me.ImageCollection1
        Me.LoyaltyRank.Size = New System.Drawing.Size(213, 22)
        Me.LoyaltyRank.TabIndex = 17
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "Bonze.jpg")
        Me.ImageCollection1.Images.SetKeyName(1, "Silver.jpg")
        Me.ImageCollection1.Images.SetKeyName(2, "Gold.jpg")
        '
        'LoyaltyPoints
        '
        Me.LoyaltyPoints.Location = New System.Drawing.Point(204, 238)
        Me.LoyaltyPoints.Name = "LoyaltyPoints"
        Me.LoyaltyPoints.Properties.Mask.EditMask = "n0"
        Me.LoyaltyPoints.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.LoyaltyPoints.Size = New System.Drawing.Size(213, 22)
        Me.LoyaltyPoints.TabIndex = 18
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(35, 640)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(129, 25)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Status: New"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(414, 638)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Upgrade Status"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(565, 638)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 28)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'SchemesTableAdapter
        '
        Me.SchemesTableAdapter.ClearBeforeFill = True
        '
        'EmployeesMoneyOwedTableAdapter
        '
        Me.EmployeesMoneyOwedTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BanksTableAdapter = Nothing
        Me.TableAdapterManager.CompanyContactsTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesMoneyOwedTableAdapter = Me.EmployeesMoneyOwedTableAdapter
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.HolidaysTableAdapter = Nothing
        Me.TableAdapterManager.JobCategoryTableAdapter = Nothing
        Me.TableAdapterManager.PlanTypesTableAdapter = Nothing
        Me.TableAdapterManager.SitesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Lexrecmgr.SitesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'EmployeeEdit
        '
        Me.AcceptButton = Me.OK_Button
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1133, 683)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EmployeeEdit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dialog2"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        CType(Me.DriverLicenseCheckConsentFormCompleteCB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateDrivingLicenceLastChecked.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateDrivingLicenceLastChecked.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriorRefTE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesMoneyOwedGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesMoneyOwedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusChangeDateTb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LastWorkedDateTb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPLTDCompanyContratorDetails.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.TPDriving.ResumeLayout(False)
        Me.tblelayour.ResumeLayout(False)
        Me.tblelayour.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        CType(Me.DrivingExpiryDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrivingExpiryDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisaExpiryDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisaExpiryDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassportExpiryDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassportExpiryDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigiCardExpiryDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigiCardExpiryDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DQCExpiryDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DQCExpiryDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.Tb_Email.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.NiNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TBHeadOffice.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        CType(Me.SageRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchLUE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexiconRecManagerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchemeLUE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchemesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoyaltyCard.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoyaltyRank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoyaltyPoints.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel9 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Communication As System.Windows.Forms.ComboBox
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Interviewer As System.Windows.Forms.ComboBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents DateRegistered As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Status As System.Windows.Forms.ComboBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents StatusReason As System.Windows.Forms.TextBox
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Notes As System.Windows.Forms.TextBox
    Friend WithEvents TPLTDCompanyContratorDetails As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel10 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LtdCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents CoRegistrationNumber As System.Windows.Forms.TextBox
    Friend WithEvents CorporationCertCopied As System.Windows.Forms.CheckBox
    Friend WithEvents VatRegistered As System.Windows.Forms.CheckBox
    Friend WithEvents VatNumber As System.Windows.Forms.TextBox
    Friend WithEvents TPDriving As System.Windows.Forms.TabPage
    Friend WithEvents tblelayour As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CE As System.Windows.Forms.CheckBox
    Friend WithEvents C As System.Windows.Forms.CheckBox
    Friend WithEvents Tonn75 As System.Windows.Forms.CheckBox
    Friend WithEvents Van As System.Windows.Forms.CheckBox
    Friend WithEvents Hiab As System.Windows.Forms.CheckBox
    Friend WithEvents Moffat As System.Windows.Forms.CheckBox
    Friend WithEvents Tipper1 As System.Windows.Forms.CheckBox
    Friend WithEvents Tipper2 As System.Windows.Forms.CheckBox
    Friend WithEvents Tipper75T As System.Windows.Forms.CheckBox
    Friend WithEvents RollOnOff As System.Windows.Forms.CheckBox
    Friend WithEvents MultiLift As System.Windows.Forms.CheckBox
    Friend WithEvents PVC As System.Windows.Forms.CheckBox
    Friend WithEvents MB As System.Windows.Forms.CheckBox
    Friend WithEvents AFrame As System.Windows.Forms.CheckBox
    Friend WithEvents CloseCoupled As System.Windows.Forms.CheckBox
    Friend WithEvents CurtainBox As System.Windows.Forms.CheckBox
    Friend WithEvents FlatFridge As System.Windows.Forms.CheckBox
    Friend WithEvents Lowloader As System.Windows.Forms.CheckBox
    Friend WithEvents Container1 As System.Windows.Forms.CheckBox
    Friend WithEvents DeMounts As System.Windows.Forms.CheckBox
    Friend WithEvents WalkingFloor As System.Windows.Forms.CheckBox
    Friend WithEvents DoubleDeck As System.Windows.Forms.CheckBox
    Friend WithEvents ChainnDog As System.Windows.Forms.CheckBox
    Friend WithEvents Strap As System.Windows.Forms.CheckBox
    Friend WithEvents Rope As System.Windows.Forms.CheckBox
    Friend WithEvents Sheet As System.Windows.Forms.CheckBox
    Friend WithEvents SteelShunter As System.Windows.Forms.CheckBox
    Friend WithEvents HBall As System.Windows.Forms.CheckBox
    Friend WithEvents TLift As System.Windows.Forms.CheckBox
    Friend WithEvents FLT As System.Windows.Forms.CheckBox
    Friend WithEvents ADRTanks As System.Windows.Forms.CheckBox
    Friend WithEvents ADRPackages As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Assembler As System.Windows.Forms.CheckBox
    Friend WithEvents Production As System.Windows.Forms.CheckBox
    Friend WithEvents Warehouse As System.Windows.Forms.CheckBox
    Friend WithEvents Groundwork As System.Windows.Forms.CheckBox
    Friend WithEvents TrafficMngt As System.Windows.Forms.CheckBox
    Friend WithEvents MigWelder As System.Windows.Forms.CheckBox
    Friend WithEvents GeneralOp As System.Windows.Forms.CheckBox
    Friend WithEvents MachineOp As System.Windows.Forms.CheckBox
    Friend WithEvents PressOp As System.Windows.Forms.CheckBox
    Friend WithEvents OrderPicker As System.Windows.Forms.CheckBox
    Friend WithEvents Labourer As System.Windows.Forms.CheckBox
    Friend WithEvents Joiner As System.Windows.Forms.CheckBox
    Friend WithEvents TigWelder As System.Windows.Forms.CheckBox
    Friend WithEvents QInspector As System.Windows.Forms.CheckBox
    Friend WithEvents Setter As System.Windows.Forms.CheckBox
    Friend WithEvents Driving As System.Windows.Forms.CheckBox
    Friend WithEvents Packer As System.Windows.Forms.CheckBox
    Friend WithEvents Cleaner As System.Windows.Forms.CheckBox
    Friend WithEvents Admin As System.Windows.Forms.CheckBox
    Friend WithEvents Braize As System.Windows.Forms.CheckBox
    Friend WithEvents FSA As System.Windows.Forms.CheckBox
    Friend WithEvents FLTRT As System.Windows.Forms.CheckBox
    Friend WithEvents FLTNA As System.Windows.Forms.CheckBox
    Friend WithEvents FLTBendi As System.Windows.Forms.CheckBox
    Friend WithEvents FLTCB As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Passport As System.Windows.Forms.CheckBox
    Friend WithEvents NatIdCard As System.Windows.Forms.CheckBox
    Friend WithEvents ProofOfNi As System.Windows.Forms.CheckBox
    Friend WithEvents BirthCert As System.Windows.Forms.CheckBox
    Friend WithEvents NiCard As System.Windows.Forms.CheckBox
    Friend WithEvents UtilityBill As System.Windows.Forms.CheckBox
    Friend WithEvents CV As System.Windows.Forms.CheckBox
    Friend WithEvents Visa As System.Windows.Forms.CheckBox
    Friend WithEvents CSCSCard As System.Windows.Forms.CheckBox
    Friend WithEvents CPCSCard As System.Windows.Forms.CheckBox
    Friend WithEvents DrivingLicense As System.Windows.Forms.CheckBox
    Friend WithEvents DigiCard As System.Windows.Forms.CheckBox
    Friend WithEvents CPCM1 As System.Windows.Forms.CheckBox
    Friend WithEvents CPCM2 As System.Windows.Forms.CheckBox
    Friend WithEvents CPCM4 As System.Windows.Forms.CheckBox
    Friend WithEvents CPCM5 As System.Windows.Forms.CheckBox
    Friend WithEvents CPCM3 As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents WorkFrom3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents WorkTo3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents WorkedVia3 As System.Windows.Forms.ComboBox
    Friend WithEvents AgencyName3 As System.Windows.Forms.TextBox
    Friend WithEvents CompanyName3 As System.Windows.Forms.TextBox
    Friend WithEvents Location3 As System.Windows.Forms.TextBox
    Friend WithEvents JobTitle3 As System.Windows.Forms.TextBox
    Friend WithEvents Shift3 As System.Windows.Forms.TextBox
    Friend WithEvents Pay3 As System.Windows.Forms.TextBox
    Friend WithEvents ReasonForLeaving3 As System.Windows.Forms.TextBox
    Friend WithEvents Manager3 As System.Windows.Forms.TextBox
    Friend WithEvents RefAvailable2 As System.Windows.Forms.CheckBox
    Friend WithEvents ContactNumber3 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents WorkFrom2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents WorkTo2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents WorkedVia2 As System.Windows.Forms.ComboBox
    Friend WithEvents AgencyName2 As System.Windows.Forms.TextBox
    Friend WithEvents CompanyName2 As System.Windows.Forms.TextBox
    Friend WithEvents Location2 As System.Windows.Forms.TextBox
    Friend WithEvents JobTitle2 As System.Windows.Forms.TextBox
    Friend WithEvents Shift2 As System.Windows.Forms.TextBox
    Friend WithEvents Pay2 As System.Windows.Forms.TextBox
    Friend WithEvents ReasonForLeaving2 As System.Windows.Forms.TextBox
    Friend WithEvents Manager2 As System.Windows.Forms.TextBox
    Friend WithEvents RefAvailable1 As System.Windows.Forms.CheckBox
    Friend WithEvents ContactNumber2 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents WorkFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents WorkTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents WorkedVia As System.Windows.Forms.ComboBox
    Friend WithEvents AgencyName As System.Windows.Forms.TextBox
    Friend WithEvents CompanyName1 As System.Windows.Forms.TextBox
    Friend WithEvents Location1 As System.Windows.Forms.TextBox
    Friend WithEvents JobTitle As System.Windows.Forms.TextBox
    Friend WithEvents Shift As System.Windows.Forms.TextBox
    Friend WithEvents Pay As System.Windows.Forms.TextBox
    Friend WithEvents ReasonForLeaving As System.Windows.Forms.TextBox
    Friend WithEvents Manager As System.Windows.Forms.TextBox
    Friend WithEvents RefAvailable As System.Windows.Forms.CheckBox
    Friend WithEvents ContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Sortcode As System.Windows.Forms.TextBox
    Friend WithEvents AccountNo As System.Windows.Forms.TextBox
    Friend WithEvents AccountInTheNameOf As System.Windows.Forms.TextBox
    Friend WithEvents Bank As System.Windows.Forms.TextBox
    Friend WithEvents Email As System.Windows.Forms.CheckBox
    Friend WithEvents TaxCategory As System.Windows.Forms.ComboBox
    Friend WithEvents TaxDetails As System.Windows.Forms.ComboBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents StudentLoan As System.Windows.Forms.CheckBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Scheme As System.Windows.Forms.ComboBox
    Friend WithEvents Branch As System.Windows.Forms.ComboBox
    Friend WithEvents EmployeeCode As System.Windows.Forms.TextBox
    Friend WithEvents Forename As System.Windows.Forms.TextBox
    Friend WithEvents Surname As System.Windows.Forms.TextBox
    Friend WithEvents Title As System.Windows.Forms.ComboBox
    Friend WithEvents EthnicOrigin As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents EmergencyTelephone As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents EmergencyContact As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Mobile As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Telephone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PostCode As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents County As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents City As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Address2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Address1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents EmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents MaritalStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Gender As System.Windows.Forms.ComboBox
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PaymentFrequency As System.Windows.Forms.ComboBox
    Friend WithEvents lbl536 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents systemtypeTb As System.Windows.Forms.TextBox
    Friend WithEvents CBCardArchived As System.Windows.Forms.CheckBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents Tb_Email As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NiNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DriverLicenseCheckConsentFormCompleteCB As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents DateDrivingLicenceLastChecked As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents TBHeadOffice As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel11 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents SageRef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BranchLUE As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SchemeLUE As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents LexiconRecManagerDataSet As Lexrecmgr.LexiconRecManagerDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents SchemesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SchemesTableAdapter As Lexrecmgr.LexiconRecManagerDataSetTableAdapters.SchemesTableAdapter
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PriorRefTE As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Sites As Lexrecmgr.Sites
    Friend WithEvents EmployeesMoneyOwedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeesMoneyOwedTableAdapter As Lexrecmgr.SitesTableAdapters.EmployeesMoneyOwedTableAdapter
    Friend WithEvents TableAdapterManager As Lexrecmgr.SitesTableAdapters.TableAdapterManager
    Friend WithEvents EmployeesMoneyOwedGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEmployeeMoneyOwedID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataNavigator1 As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents colPaidChangedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaidChangedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents StatusChangeDateTb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents BankReference As System.Windows.Forms.TextBox
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents DrivingExpiryDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents VisaExpiryDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PassportExpiryDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DigiCardExpiryDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DQCExpiryDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents LastWorkedDateTb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents colDateOwed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents LoyaltyCard As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LoyaltyRank As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents LoyaltyPoints As DevExpress.XtraEditors.TextEdit

End Class
