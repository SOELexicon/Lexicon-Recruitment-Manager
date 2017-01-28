Imports System.Data.SqlClient
Imports System.Linq
Imports System.Data.Linq
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Globalization
'Copyright 2012 Craig Wright
'Redistribution and use in source and binary forms, with or without 'modification, are permitted provided that the following conditions 'are met 

'1. Redistributions of source code must retain the above copyright 'notice, this list of conditions and the following disclaimer.
'2. Redistributions in binary form must reproduce the above copyright 'notice, this list of conditions and the following disclaimer in the 'documentation and/or other materials provided with the distribution.

'THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS '"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT'LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 'FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 'COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 'INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 'BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; 'LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER 'CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT 'LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN 'ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 'POSSIBILITY OF SUCH DAMAGE.

Public Class Plan
    Dim changedRecordsTable As DataTable

    Private Sub PlanBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PlanBindingNavigatorSaveItem.Click
        Try
            Dim dc As New DataClasses1DataContext

            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))
            DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormCaption("Saving Plan Record")
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
            Me.LastModifiedUserTextBox.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString()

            Me.Validate()
            Me.PlanBindingSource.EndEdit()
            Me.Plan2PerRecordTableAdapter.Update(PlanBindingSource.DataSource)
            If dc.CFN_GetControlBit(5) = 1 Then
                If PlanIDTextBox.Text > 0 Then
                    dc.AuditPlan(PlanIDTextBox.Text)
                End If
            End If

            refreshplandata()
            loaddata()
            MsgBox("Record Saved", MsgBoxStyle.Information)
        Catch ex2 As System.Data.DBConcurrencyException
            MsgBox("Someone Has Modified The Data Currently on Screen Please Close The Plan Screen and Reopen")
        Catch ex3 As InvalidCastException
            MsgBox("Please Select Weekendingdate at top before adding a record")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
endofsave:
        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()
    End Sub

    Dim loaded As Boolean
    Dim dt As DataTable

    Public Sub loaddata()
        Me.DataTable1TableAdapter.Fill(Me.Sites.DataTable1, PlanSelect.SelectedValue.ToString, WeekSelect.SelectedValue.ToString, BranchSelect.SelectedValue.ToString)
        'dt = Me.LexiconRecManagerDataSet.Plan.GetChanges()
    End Sub

    Public Shared Sub SetDoubleBuffered(c As System.Windows.Forms.Control)

        If System.Windows.Forms.SystemInformation.TerminalServerSession Then
            Return
        End If

        Dim aProp As System.Reflection.PropertyInfo = GetType(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)

        aProp.SetValue(c, True, Nothing)
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.DoubleBuffered = True
        'ControlHelper.SuspendRedraw(LayoutControl1)
        'SetDoubleBuffered(LayoutControl1)
        'SetDoubleBuffered(DataGridView1)
        AddHandler JobCategoryIdComboBox.MouseWheel, AddressOf buttonHandler
        AddHandler CompanyLookUpEdit1.MouseWheel, AddressOf buttonHandler
        AddHandler EmployeeIdComboBox.MouseWheel, AddressOf buttonHandler
        AddHandler BranchIdComboBox.MouseWheel, AddressOf buttonHandler
        AddHandler PlanTypeIdComboBox.MouseWheel, AddressOf buttonHandler

        AddHandler BranchSelect.MouseWheel, AddressOf buttonHandler
        AddHandler PlanSelect.MouseWheel, AddressOf buttonHandler

        AddHandler WeekSelect.MouseWheel, AddressOf buttonHandler


        Me.BranchTableAdapter.Fill(Me.LexiconRecManagerDataSet1.Branch)
        Me.BranchTableAdapter.Fill(Me.LexiconRecManagerDataSet.Branch)
        Me.EmployeesTableAdapter.Fill(Me.Sites.Employees)
        Me.PlanTableAdapter1.Fill(Me.Sites.Plan)
        Me.PlanTypesTableAdapter1.Fill(Me.Sites.PlanTypes)
        Me.JobCategoryTableAdapter.Fill(Me.LexiconRecManagerDataSet.JobCategory)
        Me.SitesTableAdapter.Fill(Me.Sites._Sites)
        Me.PlanTypesTableAdapter.Fill(Me.LexiconRecManagerDataSet.PlanTypes)
        loaded = True
        Dim asdfs As String
        asdfs = GetSecurityInfo("Plan", "Lexicon")
        If asdfs <> "" Then
            BranchBindingSource1.Filter = "BranchId in (" + asdfs + ")"
            BranchBindingSource.Filter = "BranchId in (" + asdfs + ")"
        Else
            BranchBindingSource1.Filter = "BranchId = 0 "
            BranchBindingSource.Filter = "BranchId = 0 "
        End If
        If GetSecurityInfo("Plan-LockAll", "Lexicon") <> "0" Then
            SimpleButton4.Visible = True
        Else
            SimpleButton4.Visible = False
        End If
        applyfilter()

        Dim saveIndex As Integer = TabbedControlGroup1.SelectedTabPageIndex
        For i As Integer = 0 To TabbedControlGroup1.TabPages.Count - 1
            TabbedControlGroup1.SelectedTabPageIndex = i
        Next
        TabbedControlGroup1.SelectedTabPageIndex = saveIndex

        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()

    End Sub
    Public hours, dhh As Decimal
    Dim da As SqlDataAdapter
    Dim Dset As New DataSet

    Public Sub Updatehours()
        If Me.JobCategoryIdComboBox.EditValue IsNot Nothing Then
            Dim dc As New DataClasses1DataContext
            Dim JobCatLinq = (From Jobcat In dc.GetTable(Of LinqJobCategory)() Where Jobcat.JobCatId = Me.JobCategoryIdComboBox.EditValue.ToString).SingleOrDefault
            If JobCatLinq.DHH IsNot Nothing Then
                DHHTextBox.Text = JobCatLinq.DHH

            End If
            hours = 0
            If FridayCheckBox.CheckState = CheckState.Checked And (Friday2CheckBox.CheckState = CheckState.Unchecked Or Friday2CheckBox.CheckState = CheckState.Indeterminate) Then
                hours = hours + DHHTextBox.Text
            End If
            If Friday2CheckBox.CheckState = CheckState.Checked And (FridayCheckBox.CheckState = CheckState.Unchecked Or FridayCheckBox.CheckState = CheckState.Indeterminate) Then
                hours = hours + DHHTextBox.Text
            End If
            If Friday2CheckBox.CheckState = CheckState.Checked And (FridayCheckBox.CheckState = CheckState.Checked) Then
                hours = hours + DHHTextBox.Text
            End If
            If SaturdayCheckBox.CheckState = CheckState.Checked And (Saturday2CheckBox.CheckState = CheckState.Checked) Then
                hours = hours + DHHTextBox.Text
            End If
            If SaturdayCheckBox.CheckState = CheckState.Checked And (Saturday2CheckBox.CheckState = CheckState.Unchecked Or Saturday2CheckBox.CheckState = CheckState.Indeterminate) Then
                hours = hours + DHHTextBox.Text
            End If
            If Saturday2CheckBox.CheckState = CheckState.Checked And (SaturdayCheckBox.CheckState = CheckState.Unchecked Or SaturdayCheckBox.CheckState = CheckState.Indeterminate) Then
                hours = hours + DHHTextBox.Text
            End If
            If SundayCheckBox.CheckState = CheckState.Checked And (Sunday2CheckBox.CheckState = CheckState.Checked) Then
                hours = hours + DHHTextBox.Text
            End If
            If SundayCheckBox.CheckState = CheckState.Checked And (Sunday2CheckBox.CheckState = CheckState.Unchecked Or Sunday2CheckBox.CheckState = CheckState.Indeterminate) Then
                hours = hours + DHHTextBox.Text
            End If
            If Sunday2CheckBox.CheckState = CheckState.Checked And (SundayCheckBox.CheckState = CheckState.Unchecked Or SundayCheckBox.CheckState = CheckState.Indeterminate) Then
                hours = hours + DHHTextBox.Text
            End If
            If MondayCheckBox.CheckState = CheckState.Checked Then
                hours = hours + DHHTextBox.Text
            End If
            If TuesdayCheckBox.CheckState = CheckState.Checked Then
                hours = hours + DHHTextBox.Text
            End If
            If WednesdayCheckBox.CheckState = CheckState.Checked Then
                hours = hours + DHHTextBox.Text
            End If
            If ThursdayCheckBox.CheckState = CheckState.Checked Then
                hours = hours + DHHTextBox.Text
            End If
            HoursTextBox.Text = hours

        End If
    End Sub
    Dim da2 As SqlDataAdapter
    Dim UserBranch, Sql As String
    Dim Dset2 As New DataTable
    Public Function GetSecurityInfo(area As String, application As String)
        da2 = New SqlDataAdapter("SELECT isnull(SUBSTRING((SELECT        ',' + CAST(BranchuserSecurity.SecurityBranch AS nvarchar(MAX)) FROM Users INNER JOIN BranchUserSecurity ON Users.UserID = BranchUserSecurity.UserID INNER JOIN Applications ON BranchUserSecurity.ApplicationID = Applications.ApplicationId INNER JOIN ApplicationAreas ON BranchUserSecurity.ApplicationArea = ApplicationAreas.ApplicationAreaID  WHERE   (Applications.Application = '" + application + "') and (ApplicationAreas.ApplicationArea = '" + area + "') and  (Users.DomainUserID = '" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString() + "') FOR XML PATH('')),2,200000),0) AS CSV ", Main.con)
        If Dset2 IsNot Nothing Then
            Dset2.Clear()
        End If
        da2.Fill(Dset2)
        Return Dset2.Rows(0)(0).ToString()


    End Function

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.JobCategoryTableAdapter.Fill(Me.LexiconRecManagerDataSet.JobCategory)
        Me.SitesTableAdapter.Fill(Me.Sites._Sites)
        Me.PlanTableAdapter1.Fill(Me.Sites.Plan)
        Try
            Me.DataTable1TableAdapter.Fill(Me.Sites.DataTable1, PlanSelect.SelectedValue.ToString, WeekSelect.SelectedValue.ToString, BranchSelect.SelectedValue.ToString)

        Catch ex As Exception

        End Try
        Me.EmployeesTableAdapter.Fill(Me.Sites.Employees)
    End Sub
    Private Sub FridayCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles FridayCheckBox.Click, SaturdayCheckBox.Click, SundayCheckBox.Click, MondayCheckBox.Click, TuesdayCheckBox.Click _
        , WednesdayCheckBox.Click, ThursdayCheckBox.Click, Friday2CheckBox.Click, Saturday2CheckBox.Click, Sunday2CheckBox.Click
        Updatehours()
    End Sub




    Private Sub JobCategoryIdComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        If Me.JobCategoryIdComboBox.EditValue IsNot Nothing Then
            Try
                Dim dc As New DataClasses1DataContext
                Dim JobCatLinq = (From Jobcat In dc.GetTable(Of LinqJobCategory)() Where Jobcat.JobCatId = Me.JobCategoryIdComboBox.EditValue.ToString).SingleOrDefault
                DHHTextBox.Text = JobCatLinq.DHH
                EntitlementTB.Text = JobCatLinq.BreakEntitlement
                BreakDeductedCB.Checked = JobCatLinq.BreakDeducted
                SWHTextBox.Text = JobCatLinq.SWH
                MinCharge.ReadOnly = False
                MinCharge.Text = JobCatLinq.MinChargePerDay
                MinCharge.ReadOnly = True
                tbEndTime.Text = JobCatLinq.TypicalEndTime
                tbStartTime.Text = JobCatLinq.TypicalStartTime
                If JobCatLinq.DHH <> "" Then

                Else

                    DHHTextBox.ReadOnly = False
                    DHHTextBox.Text = 0
                    DHHTextBox.ReadOnly = True
                End If
            Catch ex As Exception

            Finally
            End Try
        End If

    End Sub

    Private Sub PlanSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PlanSelect.SelectedIndexChanged, WeekSelect.SelectedIndexChanged, BranchSelect.SelectedIndexChanged
        Try
            If IsDate(WeekSelect.Text) Then

                Me.WeeknumbersTableAdapter.Fill(Me.LexiconRecManagerDataSet2.Weeknumbers, CType(WeekSelect.Text, Date))

                WeekLabel.Text = "Week: " + WeeknumbersBindingSource1.Current("Week").ToString


            End If
        Catch ex As System.Exception
        End Try
        filter()
    End Sub
    Public filtertext, filtertext2, filtertext3 As String
    Public Sub filter()
        Try
            If IsDate(WeekSelect.Text) Then
                Me.DataTable1TableAdapter.Fill(Me.Sites.DataTable1, PlanSelect.SelectedValue.ToString, WeekSelect.SelectedValue.ToString, BranchSelect.SelectedValue.ToString)
                ' PlanViewDataGridView.Refresh()
                Me.DataTable2TableAdapter.Fill(Me.LexiconRecManagerDataSet2.DataTable2, WeekSelect.Text, BranchSelect.Text, PlanSelect.Text)

                If PlanIDTextBox.Text = "" Then
                    PlanTypeIdComboBox.Enabled = True
                    BranchIdComboBox.Enabled = True
                    CompanyLookUpEdit1.Enabled = True
                    EmployeeIdComboBox.Enabled = True
                    'JobCategoryIdComboBox.Enabled = False
                    '   WeekEndingDateTextBox.Enabled = False
                ElseIf PlanIDTextBox.Text > 0 Then
                    PlanTypeIdComboBox.Enabled = False
                    BranchIdComboBox.Enabled = False
                    CompanyLookUpEdit1.Enabled = False
                    EmployeeIdComboBox.Enabled = False
                    'JobCategoryIdComboBox.Enabled = False
                    '   WeekEndingDateTextBox.Enabled = False
                Else
                    PlanTypeIdComboBox.Enabled = True
                    BranchIdComboBox.Enabled = True
                    CompanyLookUpEdit1.Enabled = True
                    EmployeeIdComboBox.Enabled = True
                    '   JobCategoryIdComboBox.Enabled = True
                    '   WeekEndingDateTextBox.Enabled = True

                End If
            
            End If

        Catch ex As Exception
            '' MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub WeekSelect_SelectedIndexChanged(sender As Object, e As EventArgs)
        filter()
    End Sub



    Private Sub RateComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ratecombo.Leave
        Try
            If Me.JobCategoryIdComboBox.EditValue.ToString <> "" Then
                Dim dc As New DataClasses1DataContext
                Dim JobCatLinq = (From Jobcat In dc.GetTable(Of LinqJobCategory)() Where Jobcat.JobCatId = Me.JobCategoryIdComboBox.EditValue.ToString).SingleOrDefault
                If JobCatLinq.DHH IsNot Nothing Then
                    DHHTextBox.Text = JobCatLinq.DHH
                    EntitlementTB.Text = JobCatLinq.BreakEntitlement
                    BreakDeductedCB.Checked = JobCatLinq.BreakDeducted
                End If


                ChargeTextBox.Enabled = True
                ' ChargeTextBox.ReadOnly = False
                Select Case Ratecombo.Text
                    Case "Rate 1"
                        If JobCatLinq.RulesorDetails.Length >= 550 Then
                            RulesOrDetailsRichTextBox.Text = JobCatLinq.RulesorDetails.Substring(0, JobCatLinq.RulesorDetails.Length - (JobCatLinq.RulesorDetails.Length - 550))
                        Else
                            RulesOrDetailsRichTextBox.Text = JobCatLinq.RulesorDetails
                        End If
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
                        If JobCatLinq.RulesorDetails1 IsNot Nothing Then
                            If JobCatLinq.RulesorDetails1.Length >= 550 Then
                                RulesOrDetailsRichTextBox.Text = JobCatLinq.RulesorDetails1.Substring(0, JobCatLinq.RulesorDetails1.Length - (JobCatLinq.RulesorDetails1.Length - 550))
                            Else
                                RulesOrDetailsRichTextBox.Text = JobCatLinq.RulesorDetails1
                            End If
                        End If
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
                        If JobCatLinq.RulesorDetails2.Length >= 550 Then
                            RulesOrDetailsRichTextBox.Text = JobCatLinq.RulesorDetails2.Substring(0, JobCatLinq.RulesorDetails2.Length - (JobCatLinq.RulesorDetails2.Length - 550))
                        Else
                            RulesOrDetailsRichTextBox.Text = JobCatLinq.RulesorDetails2
                        End If
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
                        If JobCatLinq.RulesorDetails3.Length >= 550 Then
                            RulesOrDetailsRichTextBox.Text = JobCatLinq.RulesorDetails3.Substring(0, JobCatLinq.RulesorDetails3.Length - (JobCatLinq.RulesorDetails3.Length - 550))
                        Else
                            RulesOrDetailsRichTextBox.Text = JobCatLinq.RulesorDetails3
                        End If
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
                'ChargeTextBox.ReadOnly = True
                ChargeTextBox.Enabled = False

            End If
        Catch ex As Exception
        Finally
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        TextBox21.Text = ""
        If PlanIDTextBox.Text IsNot Nothing Then
            If PlanIDTextBox.Text = "" Then
                PlanTypeIdComboBox.Enabled = True
                BranchIdComboBox.Enabled = True
                CompanyLookUpEdit1.Enabled = True
                EmployeeIdComboBox.Enabled = True
                JobCategoryIdComboBox.Enabled = True
                '  WeekEndingDateTextBox.Enabled = True
            Else

                If PlanIDTextBox.Text <= 0 Then
                    PlanTypeIdComboBox.Enabled = True
                    BranchIdComboBox.Enabled = True
                    CompanyLookUpEdit1.Enabled = True
                    EmployeeIdComboBox.Enabled = True
                    JobCategoryIdComboBox.Enabled = True
                    '  WeekEndingDateTextBox.Enabled = True
                Else

                    PlanTypeIdComboBox.Enabled = False
                    BranchIdComboBox.Enabled = False
                    CompanyLookUpEdit1.Enabled = False
                    EmployeeIdComboBox.Enabled = False
                    JobCategoryIdComboBox.Enabled = False
                    ' WeekEndingDateTextBox.Enabled = False
                End If
            End If
        Else
            PlanTypeIdComboBox.Enabled = False
            BranchIdComboBox.Enabled = False
            CompanyLookUpEdit1.Enabled = False
            EmployeeIdComboBox.Enabled = False
            JobCategoryIdComboBox.Enabled = False
            ' WeekEndingDateTextBox.Enabled = False
        End If
    End Sub


    Dim adSQLAdapter2 As SqlDataAdapter




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

    Private Sub PlanUnlock_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click


    End Sub

    Private Sub PlanLock_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If GetSecurityInfo("Plan-LockAll", "Lexicon") <> "0" Then
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
    Private Sub GridView1_RowStyle(ByVal sender As Object, _
ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim category As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("SystemType"))
            Dim Employeeidcat As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("EmployeeId"))
            Dim dc As New DataClasses1DataContext
            If Employeeidcat <> "" Then
                Dim LinqMoneyOwed = (From MoneyOwed In dc.GetTable(Of LinqEmployeesMoneyOwed)() Where MoneyOwed.EmployeeID = Employeeidcat And MoneyOwed.Paid = False).Count


                ' Dim category2 As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Division"))
                If LinqMoneyOwed > 0 Then
                    e.Appearance.BackColor = Color.Black
                    e.Appearance.BackColor2 = Color.Black
                    e.Appearance.ForeColor = Color.White
                    ' e.Appearance.Forecolor2 = Color.Black
                Else

                    Select Case category
                        Case "L"
                            e.Appearance.BackColor = Color.Orange
                            e.Appearance.BackColor2 = Color.Orange
                        Case "LP"
                            e.Appearance.BackColor = Color.Green
                            e.Appearance.BackColor2 = Color.Green
                        Case "U"
                            e.Appearance.BackColor = Color.OrangeRed
                            e.Appearance.BackColor2 = Color.OrangeRed
                        Case Else

                    End Select
                End If
            End If
        End If

    End Sub
    Public Sub applyfilter()
        Try
            If IsNothing(BranchIdComboBox.SelectedValue) Then
                SitesBindingSource.Filter = "BranchID = 0 and (ClientStatus = 'OK' )"
            Else
                SitesBindingSource.Filter = "BranchID = " + BranchIdComboBox.SelectedValue.ToString + " and (ClientStatus = 'OK' )"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BranchIdComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BranchIdComboBox.SelectedIndexChanged
        applyfilter()
    End Sub

    Private Sub BranchIdComboBox_TextUpdate(sender As Object, e As EventArgs) Handles BranchIdComboBox.TextUpdate
        If BranchIdComboBox.SelectedValue.ToString IsNot Nothing Then
            SitesBindingSource.Filter = "BranchID = " + BranchIdComboBox.SelectedValue.ToString + " and (ClientStatus = 'OK' or ClientStatus = '')"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to create a followup?", "Create Follow Up?", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Cancelled Request")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Cancelled Request")

        ElseIf result = DialogResult.Yes Then
            If GetSecurityInfo("Plan-CreateFollowUp", "Lexicon") <> "0" Then
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
            CompanyLookUpEdit1.Enabled = False
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
            CompanyLookUpEdit1.Enabled = True
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

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click 'DeleteButton Locked Records
        Dim planid As String = DataTable1BindingSource.Current("PlanID").ToString
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
                    If planid > 0 Then

                        Dim db As New DataClasses1DataContext
                        db.DeletePlan(planid, System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString())
                        Me.DataTable1TableAdapter.Fill(Me.Sites.DataTable1, PlanSelect.SelectedValue.ToString, WeekSelect.SelectedValue.ToString, BranchSelect.SelectedValue.ToString)

                    Else
                        PlanBindingSource.RemoveCurrent()
                    End If
                End If
        End Select
    End Sub

    Private Sub ArchiveButton_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If GetSecurityInfo("Plan-Archive", "Lexicon") <> "0" Then
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

    Private Sub ClientSelect_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        '  Dim selectclient = ComboBox1.SelectedValue
        If ComboBox1.Text <> "" Then
            DataTable1BindingSource.Filter = "CompanyId = " + ComboBox1.SelectedValue.ToString + ""
        Else
            DataTable1BindingSource.Filter = ""
        End If
    End Sub

    Private Sub WeekEndingDateTextBox_TextChanged(sender As Object, e As EventArgs) Handles WeekEndingDateTextBox.Leave
        Try
            If IsDate(WeekEndingDateTextBox.Text) Then
                Me.WeeknumbersTableAdapter.Fill(Me.LexiconRecManagerDataSet.Weeknumbers, CType(WeekEndingDateTextBox.Text, Date))
                WeekLabel.Text = WeeknumbersBindingSource.Current("Week").ToString
            End If
        Catch ex As System.Exception
            '  System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
    Private Sub repositoryItemButtonEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit1.ButtonClick
        Try
            'Me.TextBox20.Text = Now().Date.ToString
            'Me.LastModifiedUserTextBox.Text = FrmLogin.UsernameTextBox.Text
            'Me.PlanBindingSource.EndEdit()
            'Me.Plan2PerRecordTableAdapter.Update(PlanBindingSource.DataSource)
            If GetSecurityInfo("Plan-LockdownUnlock", "Lexicon") <> "0" Then
                Dim jobcatids As Int64 = DataTable1BindingSource.Current("JobCategoryId")
                Dim employeeids As Int64 = DataTable1BindingSource.Current("EmployeeId")
                Dim CompanyIDs As Int64 = DataTable1BindingSource.Current("CompanyId")
                Dim dc As New DataClasses1DataContext
                Dim JobCatLinq = (From Jobcat In dc.GetTable(Of LinqJobCategory)() Where Jobcat.JobCatId = jobcatids).First
                Dim Linqemployee1 = (From employee1 In dc.GetTable(Of LinqEmployee)() Where employee1.EmployeeID = employeeids).First
                Dim LinqCompany1 = (From siteLinq In dc.GetTable(Of LinqSite)() Where siteLinq.CompanyID = CompanyIDs).First
                Dim Schemelinq = (From scheme1 In dc.GetTable(Of LinqScheme)() Where scheme1.SchemeID = Linqemployee1.SchemeID).First

                'National Lving wage
                Dim NationalLivingWage = (From Controls In dc.GetTable(Of LinqControl)() Where Controls.Control = 9).First.ControlValue
                Dim NationalMinimumWage = (From Controls In dc.GetTable(Of LinqControl)() Where Controls.Control = 8).First.ControlValue
                Dim Rate18to20 = (From Controls In dc.GetTable(Of LinqControl)() Where Controls.Control = 10).First.ControlValue
                Dim RateUnder18 = (From Controls In dc.GetTable(Of LinqControl)() Where Controls.Control = 8).First.ControlValue
                Dim todayweekend As Date
                Dim DateofBirthcheck As Date = DateTime.ParseExact(Linqemployee1.DOB,
                                       "dd/MM/yyyy",
                                       CultureInfo.GetCultureInfo("en-GB"))
                Dim SchemeisGLA As Boolean
                If (IsNothing(Schemelinq.GLAScheme)) Then
                    SchemeisGLA = False

                Else

                    SchemeisGLA = Schemelinq.GLAScheme
                End If


                If SchemeisGLA = False And LinqCompany1.GLAClient = True Then
                    MsgBox("Unable to lock! - Your trying to add an employee on a GLA Client for a scheme that isn’t GLA Approved.")
                    GoTo Finishlok

                ElseIf DataTable1BindingSource.Current("OT3Reason").ToString = "" And DataTable1BindingSource.Current("OT3Hours").ToString > 0 Then
                    MsgBox("Unable to lock! - OT3 reason has not been provided.")
					  GoTo Finishlok
                ElseIf DataTable1BindingSource.Current("Status").ToString <> "TOT" Then
                    MsgBox("Unable to lock! - Employee status must be TOT")
                    GoTo Finishlok

                ElseIf (Linqemployee1.VisaExpiryDate <= DataTable1BindingSource.Current("weekendingdate") And Linqemployee1.Visa = True) Then
                    MsgBox("Unable to lock! - Employee's Visa Expired!!")
                    GoTo Finishlok
                Else
                    If DataTable1BindingSource.Current("Pay") > 0 Then


                        If DataTable1BindingSource.Current("Weekendingdateiflate").ToString = "" Then
                            todayweekend = DateTime.ParseExact(DataTable1BindingSource.Current("weekendingdate"),
                                        "dd/MM/yyyy",
                                        CultureInfo.GetCultureInfo("en-GB"))
                            If GetCurrentAge(DateofBirthcheck, todayweekend) >= 25 And (DataTable1BindingSource.Current("Pay") < NationalLivingWage) Then
                                MsgBox("worker is in breach of *NLW rate")
                                GoTo Finishlok
                            ElseIf (GetCurrentAge(DateofBirthcheck, todayweekend) > 20 And DateDiff(DateInterval.Year, DateofBirthcheck, todayweekend) < 25) And (DataTable1BindingSource.Current("Pay") < NationalMinimumWage) Then
                                MsgBox("worker is in breach of *NMW rate")
                                GoTo Finishlok
                            ElseIf (GetCurrentAge(DateofBirthcheck, todayweekend) >= 18 And DateDiff(DateInterval.Year, DateofBirthcheck, todayweekend) <= 20) And (DataTable1BindingSource.Current("Pay") < Rate18to20) Then
                                MsgBox("worker is in breach of *18 to 20 rate")
                                GoTo Finishlok
                            ElseIf (GetCurrentAge(DateofBirthcheck, todayweekend) < 18) And (DataTable1BindingSource.Current("Pay") < RateUnder18) Then
                                MsgBox("worker is in breach of *Under 18 rate")
                                GoTo Finishlok
                            End If
                        Else
                            todayweekend = DateTime.ParseExact(DataTable1BindingSource.Current("Weekendingdateiflate"),
                                "dd/MM/yyyy",
                                CultureInfo.GetCultureInfo("en-GB"))
                            If GetCurrentAge(DateofBirthcheck, todayweekend) >= 25 And (DataTable1BindingSource.Current("Pay") < NationalLivingWage) Then
                                MsgBox("worker is in breach of *NLW rate")
                                GoTo Finishlok
                            ElseIf (GetCurrentAge(DateofBirthcheck, todayweekend) > 20 And DateDiff(DateInterval.Year, DateofBirthcheck, todayweekend) < 25) And (DataTable1BindingSource.Current("Pay") < NationalMinimumWage) Then
                                MsgBox("worker is in breach of *NMW rate")
                                GoTo Finishlok
                            ElseIf (GetCurrentAge(DateofBirthcheck, todayweekend) >= 18 And DateDiff(DateInterval.Year, DateofBirthcheck, todayweekend) <= 20) And (DataTable1BindingSource.Current("Pay") < Rate18to20) Then
                                MsgBox("worker is in breach of *18 to 20 rate")
                                GoTo Finishlok
                            ElseIf (GetCurrentAge(DateofBirthcheck, todayweekend) < 18) And (DataTable1BindingSource.Current("Pay") < RateUnder18) Then
                                MsgBox("worker is in breach of *Under 18 rate")
                                GoTo Finishlok
                            End If
                        End If
                    End If
                    Select Case DataTable1BindingSource.Current("SystemType").ToString
                        Case "L"
                            Dim result = MsgBox("Are you sure you want to lock this entry?", MsgBoxStyle.YesNo, "Checked?")
                            If result = DialogResult.Cancel Then
                                MessageBox.Show("Cancel pressed")
                            ElseIf result = DialogResult.No Then
                                MessageBox.Show("No pressed")
                            ElseIf result = DialogResult.Yes Then
                                adSQLAdapter2 = New SqlDataAdapter("   EXECUTE  [dbo].[LockPlan]  " + DataTable1BindingSource.Current("PlanID").ToString, Main.con)
                                If Dset.Tables("LockPlan") IsNot Nothing Then
                                    Dset.Tables("LockPlan").Clear()
                                End If
                                adSQLAdapter2.Fill(Dset, "LockPlan")
                                DataTable1BindingSource.Current("SystemType") = "U"
                                refreshplandata()
                                GoTo Finishlok
                            End If
                        Case "LP"
                        Case Else
                            If (DataTable1BindingSource.Current("PoNumber").ToString() = "" And DataTable1BindingSource.Current("OrderNumberReq") = True) Then
                                MsgBox("Cannot Lock Record - Order Number Required", MsgBoxStyle.Exclamation)
                            Else
                                If DataTable1BindingSource.Current("WeekEndingDateIfLate").ToString <> "" And DataTable1BindingSource.Current("Weekendingdateiflatereason").ToString = "" Then
                                    MsgBox("Cannot Lock Record Week Ending Date If Late Reason Blank")
                                Else
                                    If GetSecurityInfo("Plan-LockdownLock", "Lexicon") <> "0" Then
                                        Dim result = MsgBox("Are you sure you want to lock this entry?", MsgBoxStyle.YesNo, "Checked?")
                                        If result = DialogResult.Cancel Then
                                            MessageBox.Show("Cancel pressed")
                                        ElseIf result = DialogResult.No Then
                                            MessageBox.Show("No pressed")
                                        ElseIf result = DialogResult.Yes Then
                                            adSQLAdapter2 = New SqlDataAdapter("   EXECUTE  [dbo].[LockPlan]  " + DataTable1BindingSource.Current("PlanID").ToString, Main.con)
                                            If Dset.Tables("LockPlan") IsNot Nothing Then
                                                Dset.Tables("LockPlan").Clear()
                                            End If
                                            adSQLAdapter2.Fill(Dset, "LockPlan")
                                            DataTable1BindingSource.Current("SystemType") = "L"
                                            MsgBox("Record Locked!", MsgBoxStyle.Exclamation)
                                            refreshplandata()
                                            GoTo Finishlok
                                        End If
                                    End If
                                End If
                            End If

                            If DataTable1BindingSource.Current("OrderNumberReq") = False Then
                                If DataTable1BindingSource.Current("WeekEndingDateIfLate").ToString <> "" And DataTable1BindingSource.Current("Weekendingdateiflatereason").ToString = "" Then
                                    MsgBox("Cannot Lock Record Week Ending Date If Late Reason Blank")
                                Else

                                    If GetSecurityInfo("Plan-LockdownLock", "Lexicon") <> "0" Then
                                        Dim result = MsgBox("Are you sure you want to lock this entry?", MsgBoxStyle.YesNo, "Checked?")
                                        If result = DialogResult.Cancel Then
                                            MessageBox.Show("Cancel pressed")
                                        ElseIf result = DialogResult.No Then
                                            MessageBox.Show("No pressed")
                                        ElseIf result = DialogResult.Yes Then
                                            adSQLAdapter2 = New SqlDataAdapter("   EXECUTE  [dbo].[LockPlan]  " + DataTable1BindingSource.Current("PlanID").ToString, Main.con)
                                            If Dset.Tables("LockPlan") IsNot Nothing Then
                                                Dset.Tables("LockPlan").Clear()
                                            End If
                                            adSQLAdapter2.Fill(Dset, "LockPlan")
                                            DataTable1BindingSource.Current("SystemType") = "L"
                                            MsgBox("Record Locked!", MsgBoxStyle.Exclamation)
                                            refreshplandata()
                                        End If
                                    End If
                                End If
                            End If

                    End Select

                End If
            End If
Finishlok:
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Private Sub CompanyLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles CompanyLookUpEdit1.EditValueChanged
        If Me.JobCategoryIdComboBox.EditValue.ToString <> "" Then
            Dim dc As New DataClasses1DataContext
            Dim JobCatLinq = (From Jobcat In dc.GetTable(Of LinqJobCategory)() Where Jobcat.JobCatId = Me.JobCategoryIdComboBox.EditValue.ToString).SingleOrDefault
            DHHTextBox.Text = JobCatLinq.DHH
            If JobCatLinq.DHH IsNot Nothing Then
                dhh = JobCatLinq.DHH
            End If
        End If
        If Me.CompanyLookUpEdit1.EditValue.ToString <> "" Then
            Dim dc As New DataClasses1DataContext
            Dim SiteLinq = (From Sites In dc.GetTable(Of LinqSite)() Where Sites.CompanyID = CompanyLookUpEdit1.EditValue.ToString).SingleOrDefault
            Select Case SiteLinq.OrderNumberReq
                Case "True"
                    PoNumberTextBox.ReadOnly = False
                Case Else
                    PoNumberTextBox.ReadOnly = True
            End Select
        End If
        Try
            If EmployeeIdComboBox.EditValue.ToString = "" Then
                If loaded = True And Me.CompanyLookUpEdit1.EditValue.ToString <> "" Then
                    JobCategoryBindingSource.Filter = "IsNull(Archive,0) = 0 and CompanyId = " + CompanyLookUpEdit1.EditValue.ToString
                End If

            Else
                Dim dc As New DataClasses1DataContext
                Dim Linqemployee1 = (From employee1 In dc.GetTable(Of LinqEmployee)() Where employee1.EmployeeID = EmployeeIdComboBox.EditValue.ToString).FirstOrDefault
                Dim DateofBirthcheck As Date = DateTime.ParseExact(Linqemployee1.DOB,
                                         "dd/MM/yyyy",
                                         CultureInfo.GetCultureInfo("en-GB"))
                Dim todayweekend As Date
                If WeekEndingDateTextBox.Text <> "" Then


                    If WeekEndingDateIfLateTextBox.Text = "" Then

                        todayweekend = DateTime.ParseExact(WeekEndingDateTextBox.Text,
                                               "dd/MM/yyyy",
                                               CultureInfo.GetCultureInfo("en-GB"))
                        If GetCurrentAge(DateofBirthcheck, todayweekend) >= 25 Then
                            JobCategoryBindingSource.Filter = "IsNull(Archive,0) = 0 and IsNull(U25Rate,0) = 0 and CompanyId = " + CompanyLookUpEdit1.EditValue.ToString

                        Else
                            JobCategoryBindingSource.Filter = "IsNull(Archive,0) = 0 and CompanyId = " + CompanyLookUpEdit1.EditValue.ToString
                        End If
                    Else
                        todayweekend = DateTime.ParseExact(WeekEndingDateIfLateTextBox.Text,
                                              "dd/MM/yyyy",
                                              CultureInfo.GetCultureInfo("en-GB"))
                        If GetCurrentAge(DateofBirthcheck, todayweekend) >= 25 Then
                            JobCategoryBindingSource.Filter = "IsNull(Archive,0) = 0 and IsNull(U25Rate,0) = 0 and CompanyId = " + CompanyLookUpEdit1.EditValue.ToString

                        Else
                            JobCategoryBindingSource.Filter = "IsNull(Archive,0) = 0 and CompanyId = " + CompanyLookUpEdit1.EditValue.ToString
                        End If
                    End If
                End If
            End If



        Catch ex As Exception
        End Try
    End Sub


    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        selectplanitem()
    End Sub

    Private Sub GridView1_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        selectplanitem()
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
        '  selectplanitem()
    End Sub
    Public Sub refreshplandata()
        Try
            Me.DataTable1TableAdapter.Fill(Me.Sites.DataTable1, PlanSelect.SelectedValue.ToString, WeekSelect.SelectedValue.ToString, BranchSelect.SelectedValue.ToString)
            Select Case DataTable1BindingSource.Current("SystemType").ToString
                Case "L"
                    If GetSecurityInfo("Plan-LockdownUnlock", "Lexicon") <> "0" Then
                        Me.Plan2PerRecordTableAdapter.Fill(Me.LexiconRecManagerDataSet.Plan2PerRecord, DataTable1BindingSource.Current("PlanID").ToString)
                    Else
                        PlanBindingSource.Filter = "PlanID = 0"
                        MsgBox("Record Locked", MsgBoxStyle.Exclamation)
                    End If
                Case "LP"
                    If GetSecurityInfo("Plan-LockAll", "Lexicon") <> "0" Then
                        Me.Plan2PerRecordTableAdapter.Fill(Me.LexiconRecManagerDataSet.Plan2PerRecord, DataTable1BindingSource.Current("PlanID").ToString)
                    Else
                        Me.Plan2PerRecordTableAdapter.Fill(Me.LexiconRecManagerDataSet.Plan2PerRecord, 0)
                    End If
                Case Else
                    Me.Plan2PerRecordTableAdapter.Fill(Me.LexiconRecManagerDataSet.Plan2PerRecord, DataTable1BindingSource.Current("PlanID").ToString)
            End Select

            Dim dc As New DataClasses1DataContext
            Dim JobCatLinq = (From Jobcat In dc.GetTable(Of LinqJobCategory)() Where Jobcat.JobCatId = Me.JobCategoryIdComboBox.EditValue.ToString).SingleOrDefault
            DHHTextBox.Text = JobCatLinq.DHH
            SWHTextBox.Text = JobCatLinq.SWH
            EntitlementTB.Text = JobCatLinq.BreakEntitlement
            BreakDeductedCB.Checked = JobCatLinq.BreakDeducted
            tbEndTime.Text = JobCatLinq.TypicalEndTime
            tbStartTime.Text = JobCatLinq.TypicalStartTime
            MinCharge.ReadOnly = False
            MinCharge.Text = JobCatLinq.MinChargePerDay
            MinCharge.ReadOnly = True
            If PlanIDTextBox.Text > 0 Then
                PlanTypeIdComboBox.Enabled = False
                BranchIdComboBox.Enabled = False
                CompanyLookUpEdit1.Enabled = False
                EmployeeIdComboBox.Enabled = False
                JobCategoryIdComboBox.Enabled = False
                '   WeekEndingDateTextBox.Enabled = False
            Else
                PlanTypeIdComboBox.Enabled = True
                BranchIdComboBox.Enabled = True
                CompanyLookUpEdit1.Enabled = True
                EmployeeIdComboBox.Enabled = True
                JobCategoryIdComboBox.Enabled = True
                '   WeekEndingDateTextBox.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub selectplanitem()
        Try
            
            If DataTable1BindingSource.Count = 0 Then
            Else

                Select Case DataTable1BindingSource.Current("SystemType").ToString
                    Case "L"
                        If GetSecurityInfo("Plan-LockdownUnlock", "Lexicon") <> "0" Then
                            Me.Plan2PerRecordTableAdapter.Fill(Me.LexiconRecManagerDataSet.Plan2PerRecord, CType(DataTable1BindingSource.Current("PlanID"), Int64))
                        Else
                            Me.Plan2PerRecordTableAdapter.Fill(Me.LexiconRecManagerDataSet.Plan2PerRecord, CType(0, Int64))
                        End If
                    Case "LP"
                        If GetSecurityInfo("Plan-LockAll", "Lexicon") <> "0" Then
                            Me.Plan2PerRecordTableAdapter.Fill(Me.LexiconRecManagerDataSet.Plan2PerRecord, CType(DataTable1BindingSource.Current("PlanID"), Int64))
                        Else
                            Me.Plan2PerRecordTableAdapter.Fill(Me.LexiconRecManagerDataSet.Plan2PerRecord, CType(0, Int64))
                        End If
                    Case Else
                        Me.Plan2PerRecordTableAdapter.Fill(Me.LexiconRecManagerDataSet.Plan2PerRecord, CType(DataTable1BindingSource.Current("PlanID"), Int64))
                End Select
                Dim jobcatidint As Int64 = DataTable1BindingSource.Current("JobCategoryId")
                Dim dc As New DataClasses1DataContext
                Dim JobCatLinq = (From Jobcat In dc.GetTable(Of LinqJobCategory)() Where Jobcat.JobCatId = jobcatidint).SingleOrDefault
                DHHTextBox.Text = JobCatLinq.DHH
                SWHTextBox.Text = JobCatLinq.SWH
                EntitlementTB.Text = JobCatLinq.BreakEntitlement
                BreakDeductedCB.Checked = JobCatLinq.BreakDeducted
                tbEndTime.Text = JobCatLinq.TypicalEndTime
                tbStartTime.Text = JobCatLinq.TypicalStartTime
                MinCharge.ReadOnly = False
                MinCharge.Text = JobCatLinq.MinChargePerDay
                MinCharge.ReadOnly = True
                TextBox21.Text = JobCatLinq.StartOfWeek
                If PlanIDTextBox.Text > 0  Then
                    PlanTypeIdComboBox.Enabled = False
                    BranchIdComboBox.Enabled = False
                    CompanyLookUpEdit1.Enabled = False
                    EmployeeIdComboBox.Enabled = False
                    JobCategoryIdComboBox.Enabled = False
                    '  WeekEndingDateTextBox.Enabled = False
                Else
                    PlanTypeIdComboBox.Enabled = True
                    BranchIdComboBox.Enabled = True
                    CompanyLookUpEdit1.Enabled = True
                    EmployeeIdComboBox.Enabled = True
                    JobCategoryIdComboBox.Enabled = True
                    '    WeekEndingDateTextBox.Enabled = True

                End If
            End If

        Catch ex As Exception
        Finally

        End Try
        Try
            If DataTable1BindingSource.Count > 1 Then


            If PlanIDTextBox.Text > 0 Then
                Me.PlansAuditTableAdapter.Fill(Me.Sites.PlansAudit, New System.Nullable(Of Long)(CType(DataTable1BindingSource.Current("PlanID").ToString, Long)))
            Else
                Me.PlansAuditTableAdapter.Fill(Me.Sites.PlansAudit, New System.Nullable(Of Long)(CType(0, Long)))

            End If
            End If
        Catch ex As Exception
        End Try

    End Sub
    Private Sub GridView1_CustomRowFilter(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowFilterEventArgs) Handles GridView1.CustomRowFilter

    End Sub

    Private Sub buttonHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim mwe As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        mwe.Handled = True
    End Sub
    Private Sub GridView1_ColumnFilterChanged(sender As Object, e As EventArgs) Handles GridView1.ColumnFilterChanged
        selectplanitem()

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Function GetCurrentAge(ByVal dob As Date, ByVal Weekend As Date) As Integer
        Dim age As Integer
        age = Weekend.Year - dob.Year
        If (dob > Weekend.AddYears(-age)) Then age -= 1
        Return age
    End Function
    Private Sub EmployeeIdComboBox_Leave(sender As Object, e As EventArgs) Handles EmployeeIdComboBox.Leave
        If WeekEndingDateTextBox.Text = "" Then
            MsgBox("No Weekendingdate Entered")
        Else

            Dim dc As New DataClasses1DataContext
            Dim LinqMoneyOwed3 = (From MoneyOwed In dc.GetTable(Of LinqEmployeesMoneyOwed)() Where MoneyOwed.EmployeeID = EmployeeIdComboBox.EditValue.ToString And MoneyOwed.Paid = False).Count
            Dim Linqemployee1 = (From employee1 In dc.GetTable(Of LinqEmployee)() Where employee1.EmployeeID = EmployeeIdComboBox.EditValue.ToString).FirstOrDefault
            Dim DateofBirthcheck As Date = DateTime.ParseExact(Linqemployee1.DOB.ToShortDateString,
                                             "dd/MM/yyyy",
                                             CultureInfo.GetCultureInfo("en-GB"))
            Dim todayweekend As Date


            If WeekEndingDateIfLateTextBox.Text = "" Then

                todayweekend = DateTime.ParseExact(WeekEndingDateTextBox.Text,
                                             "dd/MM/yyyy",
                                             CultureInfo.GetCultureInfo("en-GB"))
                If GetCurrentAge(DateofBirthcheck, todayweekend) >= 25 Then
                    JobCategoryBindingSource.Filter = "IsNull(Archive,0) = 0 and IsNull(U25Rate,0) = 0 and CompanyId = " + CompanyLookUpEdit1.EditValue.ToString

                Else
                    JobCategoryBindingSource.Filter = "IsNull(Archive,0) = 0 and CompanyId = " + CompanyLookUpEdit1.EditValue.ToString
                End If
            Else
                todayweekend = DateTime.ParseExact(WeekEndingDateIfLateTextBox.Text,
                                      "dd/MM/yyyy",
                                      CultureInfo.GetCultureInfo("en-GB"))
                If GetCurrentAge(DateofBirthcheck, todayweekend) >= 25 Then
                    JobCategoryBindingSource.Filter = "IsNull(Archive,0) = 0 and IsNull(U25Rate,0) = 0 and CompanyId = " + CompanyLookUpEdit1.EditValue.ToString

                Else
                    JobCategoryBindingSource.Filter = "IsNull(Archive,0) = 0 and CompanyId = " + CompanyLookUpEdit1.EditValue.ToString
                End If
            End If
            If LinqMoneyOwed3 > 0 Then
                MsgBox("Employee Has An Outstanding Deduction On Record", MsgBoxStyle.Information)
            End If

            dc.Dispose()
        End If
    End Sub

    Private Sub Plan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        GC.SuppressFinalize(Me)
        GC.Collect()

    End Sub

    Private Sub Plan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed


    End Sub
End Class