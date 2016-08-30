Imports System.Data.SqlClient
Imports System.Linq
Imports System.Data.Linq
Public Class Plan2
    Dim changedRecordsTable As DataTable
    Public Sub loadAuditHistory()
        Try


            adSQLAdapter2 = New SqlDataAdapter("   select * from PlansAudit where PlanId =  " + PlanIDTextBox.Text + "  order by ID", Main.con)
            If Dset.Tables("PlanAudits") IsNot Nothing Then
                Dset.Tables("PlanAudits").Clear()
            End If
            adSQLAdapter2.Fill(Dset, "PlanAudits")
            DataGridView1.DataSource = Dset.Tables("PlanAudits")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub PlanBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PlanBindingNavigatorSaveItem.Click
        Try
            If CType(WeekEndingDateTextBox.Text, Date).ToString("dddd") <> "Sunday" Then
                MsgBox("Weekendingdate is not a sunday", MsgBoxStyle.Critical)
                WeekEndingDateTextBox.Focus()

                GoTo endofsave
            End If
            If IsDate(WeekEndingDateTextBox.Text) = False Then

                MsgBox("Weekendingdate is empty", MsgBoxStyle.Critical)
                WeekEndingDateTextBox.Focus()

                GoTo endofsave

            End If
            Me.TextBox20.Text = Now().Date.ToString
            Me.LastModifiedUserTextBox.Text = FrmLogin.UsernameTextBox.Text
            Me.PlanBindingSource.EndEdit()

            Me.Plan1TableAdapter.Update(PlanBindingSource.DataSource)
            '  Plan1TableAdapter.Update(Me.LexiconRecManagerDataSet.Plan1)
            If Me.LexiconRecManagerDataSet.Plan.GetChanges IsNot Nothing Then

                adSQLAdapter2 = New SqlDataAdapter("   EXECUTE  [dbo].[AuditPlan]  " + PlanIDTextBox.Text + " ", Main.con)
                If Dset.Tables("AuditPlan") IsNot Nothing Then
                    Dset.Tables("AuditPlan").Clear()
                End If
                adSQLAdapter2.Fill(Dset, "AuditPlan")

            End If
            refreshplandata()
            loadAuditHistory()
            loaddata()
        Catch ex As Exception
        End Try
endofsave:

    End Sub
    Dim loaded As Boolean
    Dim dt As DataTable

    Public Sub loaddata()

        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.JobCategory' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Sites' table. You can move, or remove it, as needed.
        '    Me.SitesTableAdapter.Fill(Me.LexiconRecManagerDataSet.Sites)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.PlanView' table. You can move, or remove it, as needed.
        'Me.PlanViewTableAdapter.Fill(Me.LexiconRecManagerDataSet.PlanView)

        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.PlanTypes' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Plan' table. You can move, or remove it, as needed.
        Me.Plan1TableAdapter.Fill(Me.LexiconRecManagerDataSet.Plan1, PlanSelect.SelectedValue.ToString, WeekSelect.SelectedValue.ToString, BranchSelect.SelectedValue.ToString)
        'TODO: This line of code loads data into the 'Sites.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.Sites.DataTable1, PlanSelect.SelectedValue.ToString, WeekSelect.SelectedValue.ToString, BranchSelect.SelectedValue.ToString)
        dt = Me.LexiconRecManagerDataSet.Plan.GetChanges()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Plan1' table. You can move, or remove it, as needed.
        '   Me.Plan1TableAdapter.Fill(Me.LexiconRecManagerDataSet.Plan1, PlanSelect.SelectedValue.ToString, WeekSelect.SelectedValue.ToString, BranchSelect.SelectedValue.ToString)



        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet1.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.LexiconRecManagerDataSet1.Branch)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.LexiconRecManagerDataSet.Branch)
        'TODO: This line of code loads data into the 'Sites.DataTable1' table. You can move, or remove it, as needed.
        '  Me.DataTable1TableAdapter.Fill(Me.Sites.DataTable1, PlanSelect.SelectedValue.ToString, WeekSelect.SelectedValue.ToString, BranchSelect.SelectedValue.ToString)
        'TODO: This line of code loads data into the 'Sites.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.Sites.Employees)
        'TODO: This line of code loads data into the 'Sites.Plan' table. You can move, or remove it, as needed.
        Me.PlanTableAdapter1.Fill(Me.Sites.Plan)
        'TODO: This line of code loads data into the 'Sites.PlanTypes' table. You can move, or remove it, as needed.
        Me.PlanTypesTableAdapter1.Fill(Me.Sites.PlanTypes)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Employees' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.JobCategory' table. You can move, or remove it, as needed.
        Me.JobCategoryTableAdapter.Fill(Me.LexiconRecManagerDataSet.JobCategory)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.JobCategory' table. You can move, or remove it, as needed.
        Me.SitesTableAdapter.Fill(Me.Sites._Sites)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Sites' table. You can move, or remove it, as needed.
        '    Me.SitesTableAdapter.Fill(Me.LexiconRecManagerDataSet.Sites)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.PlanView' table. You can move, or remove it, as needed.
        ' Me.PlanViewTableAdapter.Fill(Me.LexiconRecManagerDataSet.PlanView, PlanSelect.SelectedValue.ToString, WeekSelect.SelectedValue.ToString, BranchSelect.SelectedValue.ToString)

        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.PlanTypes' table. You can move, or remove it, as needed.
        Me.PlanTypesTableAdapter.Fill(Me.LexiconRecManagerDataSet.PlanTypes)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Plan' table. You can move, or remove it, as needed.
        '   Me.Plan1TableAdapter.Fill(Me.LexiconRecManagerDataSet.Plan1, PlanSelect.SelectedValue.ToString, WeekSelect.SelectedValue.ToString, BranchSelect.SelectedValue.ToString)

        loaded = True
        Dim asdfs As String
        asdfs = GetSecurityInfo("Plan")
        If asdfs <> "" Then
            BranchBindingSource1.Filter = "BranchId in (" + asdfs + ")"
            BranchBindingSource.Filter = "BranchId in (" + asdfs + ")"


        Else
            BranchBindingSource1.Filter = "BranchId = 0 "
            BranchBindingSource.Filter = "BranchId = 0 "


        End If
        If GetSecurityInfo("Plan-LockAll") <> "" Then
            PlanLock.Visible = True
        Else
            PlanLock.Visible = False

        End If
        applyfilter()
    End Sub
    Public hours, dhh As Decimal
    Dim da As SqlDataAdapter
    Dim Dset As New DataSet

    Public Sub Updatehours()


        If Me.JobCategoryIdComboBox.SelectedValue IsNot Nothing Then

            hours = 0
            If FridayCheckBox.CheckState = CheckState.Checked And (Friday2CheckBox.CheckState = CheckState.Unchecked Or Friday2CheckBox.CheckState = CheckState.Indeterminate) Then
                hours = hours + dhh
            End If
            If Friday2CheckBox.CheckState = CheckState.Checked And (FridayCheckBox.CheckState = CheckState.Unchecked Or FridayCheckBox.CheckState = CheckState.Indeterminate) Then
                hours = hours + dhh
            End If
            If Friday2CheckBox.CheckState = CheckState.Checked And (FridayCheckBox.CheckState = CheckState.Checked) Then
                hours = hours + dhh
            End If
            If SaturdayCheckBox.CheckState = CheckState.Checked And (Saturday2CheckBox.CheckState = CheckState.Checked) Then
                hours = hours + dhh
            End If
            If SaturdayCheckBox.CheckState = CheckState.Checked And (Saturday2CheckBox.CheckState = CheckState.Unchecked Or Saturday2CheckBox.CheckState = CheckState.Indeterminate) Then
                hours = hours + dhh
            End If
            If Saturday2CheckBox.CheckState = CheckState.Checked And (SaturdayCheckBox.CheckState = CheckState.Unchecked Or SaturdayCheckBox.CheckState = CheckState.Indeterminate) Then
                hours = hours + dhh
            End If
            If SundayCheckBox.CheckState = CheckState.Checked And (Sunday2CheckBox.CheckState = CheckState.Checked) Then
                hours = hours + dhh
            End If
            If SundayCheckBox.CheckState = CheckState.Checked And (Sunday2CheckBox.CheckState = CheckState.Unchecked Or Sunday2CheckBox.CheckState = CheckState.Indeterminate) Then
                hours = hours + dhh
            End If
            If Sunday2CheckBox.CheckState = CheckState.Checked And (SundayCheckBox.CheckState = CheckState.Unchecked Or SundayCheckBox.CheckState = CheckState.Indeterminate) Then
                hours = hours + dhh
            End If
            If MondayCheckBox.CheckState = CheckState.Checked Then
                hours = hours + dhh
            End If
            If TuesdayCheckBox.CheckState = CheckState.Checked Then
                hours = hours + dhh
            End If
            If WednesdayCheckBox.CheckState = CheckState.Checked Then
                hours = hours + dhh
            End If
            If ThursdayCheckBox.CheckState = CheckState.Checked Then
                hours = hours + dhh
            End If
            HoursTextBox.Text = hours

            DHHTextBox.Text = dhh


        End If


    End Sub
    Public Sub Readonlycomponents(test As Boolean)
        Select Case test
            Case False

            Case True

        End Select
    End Sub
    Dim da2 As SqlDataAdapter
    Dim UserBranch, Sql As String
    Dim Dset2 As New DataTable
    Public Function GetSecurityInfo(area As String)
        da2 = New SqlDataAdapter("SELECT SUBSTRING((SELECT        ',' + CAST(BranchuserSecurity.SecurityBranch AS nvarchar(MAX)) FROM            Users INNER JOIN   BranchUserSecurity ON Users.UserID = BranchUserSecurity.UserID WHERE      (BranchuserSecurity.SecurityArea = '" + area + "') and  (Users.DomainUserID = '" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString() + "') FOR XML PATH('')),2,200000) AS CSV ", Main.con)
        If Dset2 IsNot Nothing Then
            Dset2.Clear()
        End If
        da2.Fill(Dset2)
        Return Dset2.Rows(0)(0).ToString()


    End Function

    Private Sub PlanViewDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PlanViewDataGridView.CellClick
        Try
            'Me.PlanTableAdapter.Fill(Me.LexiconRecManagerDataSet.Plan)
            Select Case PlanViewDataGridView.Item(2, PlanViewDataGridView.CurrentRow.Index).Value.ToString

                Case "L"
                    If GetSecurityInfo("Plan-LockdownUnlock") <> "" Then
                        PlanBindingSource.Filter = "PlanID = " + PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value.ToString
                        PlanBindingSource.Position() = PlanBindingSource.Find("PlanID", PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value)
                        loadAuditHistory()
                    Else
                        PlanBindingSource.Filter = "PlanID = 0"
                    End If
                Case "LP"
                    If GetSecurityInfo("Plan-LockAll") <> "" Then
                        PlanBindingSource.Filter = "PlanID = " + PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value.ToString
                        PlanBindingSource.Position() = PlanBindingSource.Find("PlanID", PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value)
                        loadAuditHistory()
                    Else
                        PlanBindingSource.Filter = "PlanID = 0"
                    End If
                Case Else
                    PlanBindingSource.Filter = "PlanID = " + PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value.ToString

                    PlanBindingSource.Position() = PlanBindingSource.Find("PlanID", PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value)
                    loadAuditHistory()
            End Select

            Dim dc As New DataClasses1DataContext

            Dim JobCatLinq = (From Jobcat In dc.GetTable(Of LinqJobCategory)() Where Jobcat.JobCatId = Me.JobCategoryIdComboBox.SelectedValue.ToString).SingleOrDefault
            DHHTextBox.Text = JobCatLinq.DHH
            SWHTextBox.Text = JobCatLinq.SWH
            tbEndTime.Text = JobCatLinq.TypicalEndTime
            tbStartTime.Text = JobCatLinq.TypicalStartTime

            MinCharge.ReadOnly = False
            MinCharge.Text = JobCatLinq.MinChargePerDay
            MinCharge.ReadOnly = True
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.JobCategoryTableAdapter.Fill(Me.LexiconRecManagerDataSet.JobCategory)
        Me.SitesTableAdapter.Fill(Me.Sites._Sites)
        Me.PlanTableAdapter1.Fill(Me.Sites.Plan)
        Try
            Me.DataTable1TableAdapter.Fill(Me.Sites.DataTable1, PlanSelect.SelectedValue.ToString, WeekSelect.SelectedValue.ToString, BranchSelect.SelectedValue.ToString)

        Catch ex As Exception

        End Try
        Me.EmployeesTableAdapter.Fill(Me.Sites.Employees)

        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.PlanTypes' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Plan' table. You can move, or remove it, as needed.
        Me.Plan1TableAdapter.Fill(Me.LexiconRecManagerDataSet.Plan1, PlanSelect.SelectedValue.ToString, WeekSelect.SelectedValue.ToString, BranchSelect.SelectedValue.ToString)

    End Sub
    Private Sub Totalcollumn(ByVal sender As Object, ByVal e As EventArgs) Handles PlanViewDataGridView.Click
        If PlanViewDataGridView.Rows.Count > 0 Then
            Label21.Text = Total().ToString("c")
        End If
    End Sub

    Private Function Total() As Double
        Dim tot As Double = 0
        Dim i As Integer = 0
        'For i = 0 To PlanViewDataGridView.Rows.Count - 1
        '    tot = tot + Convert.ToDouble(PlanViewDataGridView.Item(35, i).Value)
        'Next i
        Return tot
    End Function
    Private Sub FridayCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles FridayCheckBox.Click


        sender.ToString()
        Updatehours()
    End Sub

    Private Sub SaturdayCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SaturdayCheckBox.Click
        Updatehours()
    End Sub

    Private Sub SundayCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SundayCheckBox.Click
        Updatehours()
    End Sub

    Private Sub MondayCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles MondayCheckBox.Click
        Updatehours()
    End Sub

    Private Sub TuesdayCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TuesdayCheckBox.Click
        Updatehours()
    End Sub

    Private Sub WednesdayCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles WednesdayCheckBox.Click
        Updatehours()
    End Sub

    Private Sub ThursdayCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ThursdayCheckBox.Click
        Updatehours()
    End Sub

    Private Sub Friday2CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Friday2CheckBox.Click
        Updatehours()
    End Sub

    Private Sub Saturday2CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Saturday2CheckBox.Click
        Updatehours()
    End Sub

    Private Sub Sunday2CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Sunday2CheckBox.Click
        Updatehours()
    End Sub

    Private Sub CompanyIdComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles CompanyIdComboBox.SelectedValueChanged
        Try

            If loaded = True And Me.CompanyIdComboBox.SelectedValue IsNot Nothing Then

                JobCategoryBindingSource.Filter = "CompanyId = " + CompanyIdComboBox.SelectedValue.ToString
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub JobCategoryIdComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JobCategoryIdComboBox.SelectedIndexChanged
        If Me.JobCategoryIdComboBox.SelectedValue IsNot Nothing Then

            Try
                Dim dc As New DataClasses1DataContext

                Dim JobCatLinq = (From Jobcat In dc.GetTable(Of LinqJobCategory)() Where Jobcat.JobCatId = Me.JobCategoryIdComboBox.SelectedValue.ToString).SingleOrDefault
                DHHTextBox.Text = JobCatLinq.DHH
                SWHTextBox.Text = JobCatLinq.SWH
                MinCharge.ReadOnly = False
                MinCharge.Text = JobCatLinq.MinChargePerDay
                MinCharge.ReadOnly = True
                tbEndTime.Text = JobCatLinq.TypicalEndTime
                tbStartTime.Text = JobCatLinq.TypicalStartTime
                If JobCatLinq.DHH <> "" Then
                    dhh = JobCatLinq.DHH

                Else
                    dhh = 0
                    ' SWHTextBox.Text = 0
                    DHHTextBox.ReadOnly = False

                    DHHTextBox.Text = 0
                    DHHTextBox.ReadOnly = True

                End If
                ' End If
                ' cmd.ExecuteNonQuery()
                'MsgBox("Error : " + Dset.Tables("JobCat").Rows(0)(1).ToString() + "  - " + System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString())

            Catch ex As Exception

            Finally
                ' Main.con.Close()
            End Try
        End If

    End Sub

    Private Sub PlanSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PlanSelect.SelectedIndexChanged, WeekSelect.SelectedIndexChanged, BranchSelect.SelectedIndexChanged
        Try
            Me.WeeknumbersTableAdapter.Fill(Me.LexiconRecManagerDataSet2.Weeknumbers, CType(PlanSelect.Text, Date))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        filter()
    End Sub
    Public filtertext, filtertext2, filtertext3 As String
    Public Sub filter()
        'filtertext = ""
        'filtertext2 = ""
        'filtertext3 = ""

        Try
            '    If PlanSelect.SelectedValue.ToString IsNot Nothing Then
            '        filtertext = "PlanTypeID = " + PlanSelect.SelectedValue.ToString
            '    End If
            '    If PlanSelect.SelectedValue IsNot Nothing And WeekSelect.SelectedValue IsNot Nothing Then
            '        filtertext2 = " And WeekEndingDate = '" + WeekSelect.SelectedValue.ToString + "'"
            '    End If
            '    If (PlanSelect.SelectedValue IsNot Nothing Or WeekSelect.SelectedValue IsNot Nothing) And BranchSelect.SelectedValue IsNot Nothing Then
            '        filtertext3 = " And BranchId = '" + BranchSelect.SelectedValue.ToString + "'"
            '    End If
            '    If WeekSelect.SelectedValue IsNot Nothing And PlanSelect.SelectedValue Is Nothing Then
            '        filtertext = ""
            '        filtertext2 = " WeekEndingDate = '" + WeekSelect.SelectedValue.ToString + "'"
            '    End If
            '    If PlanSelect.SelectedValue Is Nothing And WeekSelect.SelectedValue Is Nothing And BranchSelect.SelectedValue IsNot Nothing Then
            '        filtertext = ""
            '        filtertext2 = ""
            '        filtertext3 = " BranchId = '" + BranchSelect.SelectedValue.ToString + "'"
            '    End If
            ' Me.PlanViewTableAdapter.Fill(Me.LexiconRecManagerDataSet.PlanView, PlanSelect.SelectedValue.ToString, WeekSelect.SelectedValue.ToString, BranchSelect.SelectedValue.ToString)
            Me.Plan1TableAdapter.Fill(Me.LexiconRecManagerDataSet.Plan1, PlanSelect.SelectedValue.ToString, WeekSelect.SelectedValue.ToString, BranchSelect.SelectedValue.ToString)
            Me.DataTable1TableAdapter.Fill(Me.Sites.DataTable1, PlanSelect.SelectedValue.ToString, WeekSelect.SelectedValue.ToString, BranchSelect.SelectedValue.ToString)
            'DataTable1BindingSource.Filter = filtertext + filtertext2 + filtertext3
            PlanViewDataGridView.Refresh()
            Me.DataTable2TableAdapter.Fill(Me.LexiconRecManagerDataSet2.DataTable2, WeekSelect.Text, BranchSelect.Text, PlanSelect.Text)

            PlanBindingSource.Filter = "PlanID = " + PlanViewDataGridView.Item(29, PlanViewDataGridView.CurrentRow.Index).Value.ToString

            PlanBindingSource.Position() = PlanBindingSource.Find("PlanID", PlanViewDataGridView.Item(29, PlanViewDataGridView.CurrentRow.Index).Value)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub WeekSelect_SelectedIndexChanged(sender As Object, e As EventArgs)
        filter()
    End Sub

    Private Sub FridayCheckBox_CheckedChanged_1(sender As Object, e As EventArgs) Handles FridayCheckBox.CheckedChanged

    End Sub

    Private Sub RateComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RateComboBox.SelectionChangeCommitted
        Try
            ' Main.con.Open()
            '                               0           1               2              3       4       5       6               7       8           9           10            11      12    13      14              15      16              17          18          19          20      21      22              23          24          25                 26      27       28         29 
            If Me.JobCategoryIdComboBox.SelectedValue.ToString <> "" Then
                Dim dc As New DataClasses1DataContext
                Dim JobCatLinq = (From Jobcat In dc.GetTable(Of LinqJobCategory)() Where Jobcat.JobCatId = Me.JobCategoryIdComboBox.SelectedValue.ToString).SingleOrDefault
                '

                ' da = New SqlDataAdapter("select DHH ,[RulesorDetails], [PBasicPay] ,[POT1] ,[POT2] ,[POT3] ,[PSaturday] ,[PSunday] ,[PBankHol] ,[PNightsOut] ,[CBasicPay] ,[COT1] ,[COT2] ,[COT3] ,[CSaturday] ,[CSunday] ,[CBankHol] ,[CNightsOut] ,[P2BasicPay] ,[P2OT1] ,[P2OT2] ,[P2OT3] ,[P2Saturday] ,[P2Sunday] ,[P2BankHol] ,[P2NightsOut] ,[C2BasicPay] ,[C2OT1] ,[C2OT2] ,[C2OT3] ,[C2Saturday] ,[C2Sunday] ,[C2BankHol] ,[C2NightsOut] ,[P3BasicPay] ,[P3OT1] ,[P3OT2] ,[P3OT3] ,[P3Saturday] ,[P3Sunday] ,[P3BankHol] ,[P3NightsOut] ,[C3BasicPay] ,[C3OT1] ,[C3OT2] ,[C3OT3] ,[C3Saturday] ,[C3Sunday] ,[C3BankHol] ,[C3NightsOut] ,[P4BasicPay] ,[P4OT1] ,[P4OT2] ,[P4OT3] ,[P4Saturday] ,[P4Sunday] ,[P4BankHol] ,[P4NightsOut] ,[C4BasicPay] ,[C4OT1] ,[C4OT2] ,[C4OT3] ,[C4Saturday] ,[C4Sunday] ,[C4BankHol] ,[C4NightsOut],[RulesorDetails1],[RulesorDetails2],[RulesorDetails3] from jobCategory where [JobCatId] = " + Me.JobCategoryIdComboBox.SelectedValue.ToString, Main.con)

                '   If Dset.Tables("JobCat").Rows(0)(1).ToString <> "" Then
                ChargeTextBox.Enabled = True


                ChargeTextBox.ReadOnly = False

                Select Case RateComboBox.Text
                    Case "Rate 1"
                        RulesOrDetailsRichTextBox.Text = JobCatLinq.RulesorDetails

                        PayTextBox.Text = JobCatLinq.PBasicPay
                        OT1PayTextBox.Text = JobCatLinq.POT1
                        OT2PayTextBox.Text = JobCatLinq.POT2
                        OT3PayTextBox.Text = JobCatLinq.POT3
                        SatPay.Text = JobCatLinq.PSaturday
                        SundayPay.Text = JobCatLinq.PSunday

                        BankPay.Text = JobCatLinq.PBankHol
                        NightsPay.Text = JobCatLinq.PNightsOut
                        ChargeTextBox.Text = JobCatLinq.CBasicPay
                        OT1ChargeTextBox.Text = JobCatLinq.COT1
                        OT2ChargeTextBox.Text = JobCatLinq.COT2
                        OT3ChargeTextBox.Text = JobCatLinq.COT3
                        SatCharge.Text = JobCatLinq.CSaturday
                        SundayCharge.Text = JobCatLinq.CSunday
                        BankCharge.Text = JobCatLinq.CBankHol
                        NightsOutCharge.Text = JobCatLinq.CNightsOut
                    Case "Rate 2"
                        RulesOrDetailsRichTextBox.Text = JobCatLinq.RulesorDetails1
                        PayTextBox.Text = JobCatLinq.P2BasicPay
                        OT1PayTextBox.Text = JobCatLinq.P2OT1
                        OT2PayTextBox.Text = JobCatLinq.P2OT2
                        OT3PayTextBox.Text = JobCatLinq.P2OT3
                        SatPay.Text = JobCatLinq.P2Saturday
                        SundayPay.Text = JobCatLinq.P2Sunday
                        BankPay.Text = JobCatLinq.P2BankHol
                        NightsPay.Text = JobCatLinq.P2NightsOut
                        ChargeTextBox.Text = JobCatLinq.C2BasicPay
                        OT1ChargeTextBox.Text = JobCatLinq.C2OT1
                        OT2ChargeTextBox.Text = JobCatLinq.C2OT2
                        OT3ChargeTextBox.Text = JobCatLinq.C2OT3
                        SatCharge.Text = JobCatLinq.C2Saturday
                        SundayCharge.Text = JobCatLinq.C2Sunday
                        BankCharge.Text = JobCatLinq.C2BankHol
                        NightsOutCharge.Text = JobCatLinq.C2NightsOut

                    Case "Rate 3"
                        RulesOrDetailsRichTextBox.Text = JobCatLinq.RulesorDetails2
                        PayTextBox.Text = JobCatLinq.P3BasicPay
                        OT1PayTextBox.Text = JobCatLinq.P3OT1
                        OT2PayTextBox.Text = JobCatLinq.P3OT2
                        OT3PayTextBox.Text = JobCatLinq.P3OT3
                        SatPay.Text = JobCatLinq.P3Saturday
                        SundayPay.Text = JobCatLinq.P3Sunday
                        BankPay.Text = JobCatLinq.P3BankHol
                        NightsPay.Text = JobCatLinq.P3NightsOut
                        ChargeTextBox.Text = JobCatLinq.C3BasicPay
                        OT1ChargeTextBox.Text = JobCatLinq.C3OT1
                        OT2ChargeTextBox.Text = JobCatLinq.C3OT2
                        OT3ChargeTextBox.Text = JobCatLinq.C3OT3
                        SatCharge.Text = JobCatLinq.C3Saturday
                        SundayCharge.Text = JobCatLinq.C3Sunday
                        BankCharge.Text = JobCatLinq.C3BankHol
                        NightsOutCharge.Text = JobCatLinq.C3NightsOut
                    Case "Rate 4"
                        RulesOrDetailsRichTextBox.Text = JobCatLinq.RulesorDetails3
                        PayTextBox.Text = JobCatLinq.P4BasicPay
                        OT1PayTextBox.Text = JobCatLinq.P4OT1
                        OT2PayTextBox.Text = JobCatLinq.P4OT2
                        OT3PayTextBox.Text = JobCatLinq.P4OT3
                        SatPay.Text = JobCatLinq.P4Saturday
                        SundayPay.Text = JobCatLinq.P4Sunday
                        BankPay.Text = JobCatLinq.P4BankHol
                        NightsPay.Text = JobCatLinq.P4NightsOut
                        ChargeTextBox.Text = JobCatLinq.C4BasicPay
                        OT1ChargeTextBox.Text = JobCatLinq.C4OT1
                        OT2ChargeTextBox.Text = JobCatLinq.C4OT2
                        OT3ChargeTextBox.Text = JobCatLinq.C4OT3
                        SatCharge.Text = JobCatLinq.C4Saturday
                        SundayCharge.Text = JobCatLinq.C4Sunday
                        BankCharge.Text = JobCatLinq.C4BankHol
                        NightsOutCharge.Text = JobCatLinq.C4NightsOut
                End Select

                ChargeTextBox.ReadOnly = True

                'End If
                ' cmd.ExecuteNonQuery()
                'MsgBox("Error : " + Dset.Tables("JobCat").Rows(0)(1).ToString() + "  - " + System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString())
            End If
        Catch ex As Exception

        Finally
            '   Main.con.Close()
        End Try

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        TextBox21.Text = ""
    End Sub

    Private Sub PlanBindingSource1_AddingNew(sender As Object, e As System.ComponentModel.AddingNewEventArgs) Handles PlanBindingSource1.AddingNew


    End Sub

    Private Sub BindingNavigatorPositionItem_TextChanged(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.TextChanged

    End Sub
    Dim adSQLAdapter2 As SqlDataAdapter
    Private Sub PlanViewDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PlanViewDataGridView.CellContentClick
        Try

            Me.TextBox20.Text = Now().Date.ToString
            Me.LastModifiedUserTextBox.Text = FrmLogin.UsernameTextBox.Text
            Me.PlanBindingSource.EndEdit()

            Me.Plan1TableAdapter.Update(PlanBindingSource.DataSource)
            '  Plan1TableAdapter.Update(Me.LexiconRecManagerDataSet.Plan1)
            If Me.LexiconRecManagerDataSet.Plan.GetChanges IsNot Nothing Then

                adSQLAdapter2 = New SqlDataAdapter("   EXECUTE  [dbo].[AuditPlan]  " + PlanIDTextBox.Text + " ", Main.con)
                If Dset.Tables("AuditPlan") IsNot Nothing Then
                    Dset.Tables("AuditPlan").Clear()
                End If
                adSQLAdapter2.Fill(Dset, "AuditPlan")

            End If
            Dim gr As New DataGridView
            gr = sender
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "Lock"
                            If GetSecurityInfo("Plan-LockdownUnlock") <> "" Then

                                Select Case PlanViewDataGridView.Item(2, PlanViewDataGridView.CurrentRow.Index).Value.ToString()
                                    Case "L"


                                        Dim result = MsgBox("Are you sure you want to lock this entry?", MsgBoxStyle.YesNo, "Checked?")
                                        If result = DialogResult.Cancel Then
                                            MessageBox.Show("Cancel pressed")
                                        ElseIf result = DialogResult.No Then
                                            MessageBox.Show("No pressed")
                                        ElseIf result = DialogResult.Yes Then


                                            adSQLAdapter2 = New SqlDataAdapter("   EXECUTE  [dbo].[LockPlan]  " + PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value.ToString(), Main.con)
                                            If Dset.Tables("LockPlan") IsNot Nothing Then
                                                Dset.Tables("LockPlan").Clear()
                                            End If
                                            adSQLAdapter2.Fill(Dset, "LockPlan")
                                            PlanViewDataGridView.Item(2, PlanViewDataGridView.CurrentRow.Index).Value = "U"

                                            refreshplandata()
                                            GoTo Finishlok


                                        End If
                                    Case "LP"

                                    Case Else
                                        If (PlanViewDataGridView.Item(39, PlanViewDataGridView.CurrentRow.Index).Value.ToString() = "" And PlanViewDataGridView.Item(40, PlanViewDataGridView.CurrentRow.Index).Value.ToString() = True) Then
                                            MsgBox("Cannot Lock Record - Order Number Required", MsgBoxStyle.Exclamation)

                                        Else

                                            If GetSecurityInfo("Plan-LockdownLock") <> "" Then
                                                Dim result = MsgBox("Are you sure you want to lock this entry?", MsgBoxStyle.YesNo, "Checked?")
                                                If result = DialogResult.Cancel Then
                                                    MessageBox.Show("Cancel pressed")
                                                ElseIf result = DialogResult.No Then
                                                    MessageBox.Show("No pressed")
                                                ElseIf result = DialogResult.Yes Then
                                                    adSQLAdapter2 = New SqlDataAdapter("   EXECUTE  [dbo].[LockPlan]  " + PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value.ToString(), Main.con)
                                                    If Dset.Tables("LockPlan") IsNot Nothing Then
                                                        Dset.Tables("LockPlan").Clear()
                                                    End If
                                                    adSQLAdapter2.Fill(Dset, "LockPlan")
                                                    PlanViewDataGridView.Item(2, PlanViewDataGridView.CurrentRow.Index).Value = "L"
                                                    MsgBox("Record Locked!", MsgBoxStyle.Exclamation)

                                                    refreshplandata()

                                                    GoTo Finishlok
                                                End If

                                            End If
                                        End If
                                        If PlanViewDataGridView.Item(40, PlanViewDataGridView.CurrentRow.Index).Value.ToString() = False Then
                                            If GetSecurityInfo("Plan-LockdownLock") <> "" Then
                                                Dim result = MsgBox("Are you sure you want to lock this entry?", MsgBoxStyle.YesNo, "Checked?")
                                                If result = DialogResult.Cancel Then
                                                    MessageBox.Show("Cancel pressed")
                                                ElseIf result = DialogResult.No Then
                                                    MessageBox.Show("No pressed")
                                                ElseIf result = DialogResult.Yes Then
                                                    adSQLAdapter2 = New SqlDataAdapter("   EXECUTE  [dbo].[LockPlan]  " + PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value.ToString(), Main.con)
                                                    If Dset.Tables("LockPlan") IsNot Nothing Then
                                                        Dset.Tables("LockPlan").Clear()
                                                    End If
                                                    adSQLAdapter2.Fill(Dset, "LockPlan")
                                                    PlanViewDataGridView.Item(2, PlanViewDataGridView.CurrentRow.Index).Value = "L"
                                                    MsgBox("Record Locked!", MsgBoxStyle.Exclamation)
                                                    refreshplandata()

                                                End If
                                            End If

                                        End If
                                End Select
                            End If

Finishlok:



                    End Select
            End Select
        Catch ex As Exception
        End Try

    End Sub
    Dim client2 As SqlDataAdapter


    Private Sub CompanyIdComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CompanyIdComboBox.SelectedIndexChanged
        '  Main.con.Open()

        If Me.JobCategoryIdComboBox.SelectedValue IsNot Nothing Then
            Dim dc As New DataClasses1DataContext
            Dim JobCatLinq = (From Jobcat In dc.GetTable(Of LinqJobCategory)() Where Jobcat.JobCatId = Me.JobCategoryIdComboBox.SelectedValue.ToString).SingleOrDefault

            'da = New SqlDataAdapter("select DHH ,[RulesorDetails], [PBasicPay] ,[POT1] ,[POT2] ,[POT3] ,[PSaturday] ,[PSunday] ,[PBankHol] ,[PNightsOut] ,[CBasicPay] ,[COT1] ,[COT2] ,[COT3] ,[CSaturday] ,[CSunday] ,[CBankHol] ,[CNightsOut] ,[P2BasicPay] ,[P2OT1] ,[P2OT2] ,[P2OT3] ,[P2Saturday] ,[P2Sunday] ,[P2BankHol] ,[P2NightsOut] ,[C2BasicPay] ,[C2OT1] ,[C2OT2] ,[C2OT3] ,[C2Saturday] ,[C2Sunday] ,[C2BankHol] ,[C2NightsOut] ,[P3BasicPay] ,[P3OT1] ,[P3OT2] ,[P3OT3] ,[P3Saturday] ,[P3Sunday] ,[P3BankHol] ,[P3NightsOut] ,[C3BasicPay] ,[C3OT1] ,[C3OT2] ,[C3OT3] ,[C3Saturday] ,[C3Sunday] ,[C3BankHol] ,[C3NightsOut] ,[P4BasicPay] ,[P4OT1] ,[P4OT2] ,[P4OT3] ,[P4Saturday] ,[P4Sunday] ,[P4BankHol] ,[P4NightsOut] ,[C4BasicPay] ,[C4OT1] ,[C4OT2] ,[C4OT3] ,[C4Saturday] ,[C4Sunday] ,[C4BankHol] ,[C4NightsOut] from jobCategory where [JobCatId] = " + Me.JobCategoryIdComboBox.SelectedValue.ToString, Main.con)

            'If Dset.Tables("JobCat") IsNot Nothing Then
            '    Dset.Tables("JobCat").Clear()
            'End If
            'da.Fill(Dset, "JobCat")
            '  DHHTextBox.ReadOnly = False

            DHHTextBox.Text = JobCatLinq.DHH
            '  DHHTextBox.ReadOnly = True

            If JobCatLinq.DHH IsNot Nothing Then
                dhh = JobCatLinq.DHH
            End If
        End If
        ' cmd.ExecuteNonQuery()
        'MsgBox("Error : " + Dset.Tables("JobCat").Rows(0)(1).ToString() + "  - " + System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString())
        If Me.CompanyIdComboBox.SelectedValue IsNot Nothing Then
            Dim dc As New DataClasses1DataContext
            Dim SiteLinq = (From Sites In dc.GetTable(Of LinqSite)() Where Sites.CompanyID = Me.CompanyIdComboBox.SelectedValue.ToString).SingleOrDefault

            'client2 = New SqlDataAdapter("select OrderNumberReq from Sites where [CompanyId] = " + Me.CompanyIdComboBox.SelectedValue.ToString, Main.con)
            'If Dset.Tables("CLientPoNo") IsNot Nothing Then
            '    Dset.Tables("CLientPoNo").Clear()
            'End If
            'client2.Fill(Dset, "CLientPoNo")
            ' MsgBox(Dset.Tables("CLientPoNo").Rows(0)(0).ToString())
            Select Case SiteLinq.OrderNumberReq
                Case "True"
                    PoNumberTextBox.ReadOnly = False
                Case Else
                    PoNumberTextBox.ReadOnly = True
            End Select
        End If

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Public Sub refreshplandata()
        Try
            Me.DataTable1TableAdapter.Fill(Me.Sites.DataTable1, PlanSelect.SelectedValue.ToString, WeekSelect.SelectedValue.ToString, BranchSelect.SelectedValue.ToString)

            Select Case PlanViewDataGridView.Item(2, PlanViewDataGridView.CurrentRow.Index).Value.ToString
                Case "L"
                    MsgBox("Record Locked", MsgBoxStyle.Exclamation)
                    If GetSecurityInfo("Plan-LockdownUnlock") <> "" Then
                        PlanBindingSource.Filter = "PlanID = " + PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value.ToString
                        PlanBindingSource.Position() = PlanBindingSource.Find("PlanID", PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value)
                        loadAuditHistory()
                    Else
                        PlanBindingSource.Filter = "PlanID = 0"
                    End If
                Case "LP"
                    If GetSecurityInfo("Plan-LockAll") <> "" Then
                        PlanBindingSource.Filter = "PlanID = " + PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value.ToString
                        PlanBindingSource.Position() = PlanBindingSource.Find("PlanID", PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value)
                        loadAuditHistory()
                    Else
                        PlanBindingSource.Filter = "PlanID = 0"
                    End If
                Case Else
                    PlanBindingSource.Filter = "PlanID = " + PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value.ToString
                    PlanBindingSource.Position() = PlanBindingSource.Find("PlanID", PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value)
                    loadAuditHistory()
            End Select
            If PlanViewDataGridView.Item(2, PlanViewDataGridView.CurrentRow.Index).Value.ToString <> "L" Then
                PlanBindingSource.Filter = "PlanID = " + PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value.ToString
                PlanBindingSource.Position() = PlanBindingSource.Find("PlanID", PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value)
                loadAuditHistory()
            Else
                MsgBox("Record Locked", MsgBoxStyle.Exclamation)
                If GetSecurityInfo("Plan-LockdownUnlock") <> "" Then
                    PlanBindingSource.Filter = "PlanID = " + PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value.ToString
                    PlanBindingSource.Position() = PlanBindingSource.Find("PlanID", PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value)
                    loadAuditHistory()
                Else
                    PlanBindingSource.Filter = "PlanID = 0"
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            Main.con.Open()
            da = New SqlDataAdapter("DECLARE @RC int DECLARE @Code date EXECUTE @RC = [dbo].[CFN_GetCurrentWeekEndingDate]  @Code OUTPUT    select @Code ", Main.con)
            If Dset.Tables("GetWeekEndDate") IsNot Nothing Then
                Dset.Tables("GetWeekEndDate").Clear()
            End If
            da.Fill(Dset, "GetWeekEndDate")
            WeekEndingDateTextBox.Text = Dset.Tables("GetWeekEndDate").Rows(0)(0).ToString()
        Catch ex As Exception
        Finally
            Main.con.Close()
        End Try
    End Sub

    Private Sub PlanUnlock_Click(sender As Object, e As EventArgs) Handles PlanUnlock.Click


    End Sub

    Private Sub PlanLock_Click(sender As Object, e As EventArgs) Handles PlanLock.Click
        If GetSecurityInfo("Plan-LockAll") <> "" Then
            adSQLAdapter2 = New SqlDataAdapter("   EXECUTE  [dbo].[LockPlanAll]  " + BranchSelect.SelectedValue.ToString + "," + PlanSelect.SelectedValue.ToString + ",'" + WeekSelect.Text + "'", Main.con)
            If Dset.Tables("Plan-LockAll") IsNot Nothing Then
                Dset.Tables("Plan-LockAll").Clear()
            End If
            adSQLAdapter2.Fill(Dset, "Plan-LockAll")
            MsgBox("Plan Locked", MsgBoxStyle.Information)
        Else
            MsgBox("Insufficient Permissions", MsgBoxStyle.Exclamation)
        End If

    End Sub


    Public Sub applyfilter()
        Try
            If IsNothing(BranchIdComboBox.SelectedValue) Then
                SitesBindingSource.Filter = "BranchID = 0"
            Else
                SitesBindingSource.Filter = "BranchID = " + BranchIdComboBox.SelectedValue.ToString
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BranchIdComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BranchIdComboBox.SelectedIndexChanged
        applyfilter()
    End Sub

    Private Sub BranchIdComboBox_TextUpdate(sender As Object, e As EventArgs) Handles BranchIdComboBox.TextUpdate
        If BranchIdComboBox.SelectedValue.ToString IsNot Nothing Then
            SitesBindingSource.Filter = "BranchID = " + BranchIdComboBox.SelectedValue.ToString
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to create a followup?", "Create Follow Up?", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Cancelled Request")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Cancelled Request")

        ElseIf result = DialogResult.Yes Then
            If GetSecurityInfo("Plan-CreateFollowUp") <> "" Then
                adSQLAdapter2 = New SqlDataAdapter("   EXECUTE  [dbo].[createfollowup]  " + BranchSelect.SelectedValue.ToString + "," + PlanSelect.SelectedValue.ToString + ",'" + WeekSelect.Text + "'", Main.con)
                If Dset.Tables("createfollowup") IsNot Nothing Then
                    Dset.Tables("createfollowup").Clear()
                End If
                adSQLAdapter2.Fill(Dset, "createfollowup")
                MsgBox("Follow Up Created", MsgBoxStyle.Information)
            Else
                MsgBox("Insufficient Permissions", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub

    Private Sub PlanIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles PlanIDTextBox.TextChanged
        If PlanIDTextBox.Text = "" Then
            BranchIdComboBox.Enabled = False
            DateAddedDateTimePicker.Enabled = False
            PlanTypeIdComboBox.Enabled = False
            CompanyIdComboBox.Enabled = False
            EmployeeIdComboBox.Enabled = False
            JobCategoryIdComboBox.Enabled = False
            WeekEndingDateIfLateTextBox.Enabled = False
            WeekEndingDateTextBox.Enabled = False
            Friday2CheckBox.Enabled = False
            FridayCheckBox.Enabled = False
            MondayCheckBox.Enabled = False
            TuesdayCheckBox.Enabled = False
            WednesdayCheckBox.Enabled = False
            ThursdayCheckBox.Enabled = False
            Saturday2CheckBox.Enabled = False
            SaturdayCheckBox.Enabled = False
            Sunday2CheckBox.Enabled = False
            SundayCheckBox.Enabled = False
            PoNumberTextBox.Enabled = False
            POAElseWhereTextBox.Enabled = False
            HoursWorkedElseWhereTextBox.Enabled = False
        Else
            BranchIdComboBox.Enabled = True
            DateAddedDateTimePicker.Enabled = True
            PlanTypeIdComboBox.Enabled = True
            CompanyIdComboBox.Enabled = True
            EmployeeIdComboBox.Enabled = True
            JobCategoryIdComboBox.Enabled = True
            WeekEndingDateIfLateTextBox.Enabled = True
            WeekEndingDateTextBox.Enabled = True
            Friday2CheckBox.Enabled = True
            FridayCheckBox.Enabled = True
            MondayCheckBox.Enabled = True
            TuesdayCheckBox.Enabled = True
            WednesdayCheckBox.Enabled = True
            ThursdayCheckBox.Enabled = True
            Saturday2CheckBox.Enabled = True
            SaturdayCheckBox.Enabled = True
            Sunday2CheckBox.Enabled = True
            SundayCheckBox.Enabled = True
            PoNumberTextBox.Enabled = True
            POAElseWhereTextBox.Enabled = True
            HoursWorkedElseWhereTextBox.Enabled = True
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Select Case TextBox22.Text
            Case "L"
                MsgBox("Cannot Delete Locked Records")
            Case "LP"
                MsgBox("Cannot Delete Locked Records")
            Case Else
                Dim result As Integer = MessageBox.Show("DELETE RECORD!!", "Are you sure?", MessageBoxButtons.YesNo)
                If result = DialogResult.Cancel Then
                ElseIf result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    Me.PlanBindingSource.RemoveCurrent()
                End If
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If GetSecurityInfo("Plan-Archive") <> "" Then
            adSQLAdapter2 = New SqlDataAdapter("   EXECUTE  [dbo].[ArchivePlanAll]  " + BranchSelect.SelectedValue.ToString + "," + PlanSelect.SelectedValue.ToString + ",'" + WeekSelect.Text + "'", Main.con)
            If Dset.Tables("Plan-Archive") IsNot Nothing Then
                Dset.Tables("Plan-Archive").Clear()
            End If
            adSQLAdapter2.Fill(Dset, "Plan-Archive")
            MsgBox("Plan Archived", MsgBoxStyle.Information)
        Else
            MsgBox("Insufficient Permissions", MsgBoxStyle.Exclamation)

        End If
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        '  Dim selectclient = ComboBox1.SelectedValue
        If ComboBox1.Text <> "" Then
            DataTable1BindingSource.Filter = "CompanyId = " + ComboBox1.SelectedValue.ToString + ""
        Else
            DataTable1BindingSource.Filter = ""
        End If
    End Sub

    Private Sub WeekEndingDateTextBox_TextChanged(sender As Object, e As EventArgs) Handles WeekEndingDateTextBox.TextChanged
        Try
            Me.WeeknumbersTableAdapter.Fill(Me.LexiconRecManagerDataSet.Weeknumbers, CType(WeekEndingDateTextBox.Text, Date))
        Catch ex As System.Exception
            '  System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SplitContainer2_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer2.Panel1.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class