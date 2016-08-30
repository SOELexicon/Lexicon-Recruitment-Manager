Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class Clients
    Dim adSQLAdapter2 As SqlDataAdapter
    Dim Dset2 As New DataSet
    Private Sub GridView1_RowStyle(ByVal sender As Object, _
ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim category As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("ClientStatus"))
            ' Dim category2 As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Division"))
            Select Case category
                Case "Blacklist"
                    e.Appearance.BackColor = Color.Black
                    e.Appearance.BackColor2 = Color.Black
                    e.Appearance.ForeColor = Color.White

                Case "On-Stop"
                    e.Appearance.BackColor = Color.OrangeRed
                    e.Appearance.BackColor2 = Color.OrangeRed
                Case "Archive"
                    e.Appearance.BackColor = Color.Gray
                    e.Appearance.BackColor2 = Color.Gray
                Case Else

            End Select

        End If
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sites1.Banks' table. You can move, or remove it, as needed.
        Me.BanksTableAdapter.Fill(Me.Sites1.Banks)
        'TODO: This line of code loads data into the 'LexiconManagemnetToolsDataSet.Consultants' table. You can move, or remove it, as needed.
        Me.ConsultantsTableAdapter.Fill(Me.LexiconManagemnetToolsDataSet.Consultants)
        'TODO: This line of code loads data into the 'Sites.JobCategory' table. You can move, or remove it, as needed.
        Me.JobCategoryTableAdapter1.Fill(Me.Sites.JobCategory)
        'TODO: This line of code loads data into the 'Sites.CompanyContacts' table. You can move, or remove it, as needed.
        Me.CompanyContactsTableAdapter1.Fill(Me.Sites.CompanyContacts)
        'TODO: This line of code loads data into the 'Sites._Sites' table. You can move, or remove it, as needed.
        Me.SitesTableAdapter1.Fill(Me.Sites._Sites)
        'TODO: This line of code loads data into the 'Sites._Sites' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.JobCategory' table. You can move, or remove it, as needed.
        Me.JobCategoryTableAdapter.Fill(Me.LexiconRecManagerDataSet.JobCategory)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.CompanyContacts' table. You can move, or remove it, as needed.
        Me.CompanyContactsTableAdapter.Fill(Me.LexiconRecManagerDataSet.CompanyContacts)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.CompanyContacts' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.LexiconRecManagerDataSet.Branch)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Sites' table. You can move, or remove it, as needed.
        Me.SitesTableAdapter.Fill(Me.LexiconRecManagerDataSet.Sites)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Sites' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Sites' table. You can move, or remove it, as needed.
        HoursPerShift.ReadOnly = True

        UserBranch = GetSecurityInfo2("Clients", "Lexicon")
        Dim UserBranch2 As String = UserBranch
        If UserBranch2 = "" Then
            UserBranch2 = -1
        End If
        If NotesRichTextBox.Text = "" Then
            NotesRichTextBox.BackColor = SystemColors.Window
            NotesRichTextBox.ForeColor = Color.Black
            NotesRichTextBox.Font = New Font(Me.Font, FontStyle.Regular)
        Else
            NotesRichTextBox.BackColor = Color.Red
            NotesRichTextBox.ForeColor = Color.Black
            NotesRichTextBox.Font = New Font(Me.Font, FontStyle.Bold)


        End If

        If GetSecurityInfo2("Clients - EnableSageRef", "Lexicon") <> 0 Then
            '  TabPage5.Show()
            ' TabControl1.TabPages.Add(TabPage5) 
            NotesRichTextBox.ReadOnly = False
            ArchiveCheckEdit.ReadOnly = False
            BranchIDComboBox.Enabled = True
            DNICheckBox.Enabled = True
        Else
            'TabPage5.Hide()
            NotesRichTextBox.ReadOnly = True
            ArchiveCheckEdit.ReadOnly = True
            BranchIDComboBox.Enabled = False
            DNICheckBox.Enabled = False
            '   BranchIDComboBox. = True


            TabControl1.TabPages.Remove(TabPage5)

        End If

        SitesBindingSource.Filter = "BranchId In (" + UserBranch2 + ")"

        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()
    End Sub
    Dim da2 As SqlDataAdapter
    Dim UserBranch, Sql As String
    Dim Dset As New DataTable
    Dim da3 As SqlDataAdapter
    Dim Dset3 As New DataTable
    Public Function GetSecurityInfo2(area As String, application As String)
        da3 = New SqlDataAdapter("SELECT isnull(SUBSTRING((SELECT        ',' + CAST(BranchuserSecurity.SecurityBranch AS nvarchar(MAX)) FROM Users INNER JOIN BranchUserSecurity ON Users.UserID = BranchUserSecurity.UserID INNER JOIN Applications ON BranchUserSecurity.ApplicationID = Applications.ApplicationId INNER JOIN ApplicationAreas ON BranchUserSecurity.ApplicationArea = ApplicationAreas.ApplicationAreaID  WHERE   (Applications.Application = '" + application + "') and (ApplicationAreas.ApplicationArea = '" + area + "') and  (Users.DomainUserID = '" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString() + "') FOR XML PATH('')),2,200000),0) AS CSV ", Main.con)
        If Dset3 IsNot Nothing Then
            Dset3.Clear()
        End If
        da3.Fill(Dset3)
        Return Dset3.Rows(0)(0).ToString()

    End Function
    

    Private Sub SitesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SitesBindingNavigatorSaveItem.Click
        Try
            If BranchIDComboBox.Text = "" Then
                GoTo errorinvalidbranch
            End If
                '    End if
            If TBCompanyId.Text < 0 Then
                CreatedByTimeEdit.Text = FrmLogin.UsernameTextBox.Text
                CreatedDateDateEdit.Text = Now()
            End If
            LastModifiedDateDateEdit.EditValue = Now()
            LastModifiedUserTimeEdit.Text = FrmLogin.UsernameTextBox.Text

                Me.Validate()
                Me.SitesBindingSource.EndEdit()
                Me.FKCompanyContactsSitesBindingSource.EndEdit()
                Me.SitesTableAdapter1.Update(Me.Sites._Sites)
                Me.CompanyContactsTableAdapter1.Update(Me.Sites.CompanyContacts)
       

                MsgBox("Updated", MsgBoxStyle.OkOnly)
                GoTo endofsave

errorinvalidbranch:
                MsgBox("Incorrect Branch", MsgBoxStyle.Exclamation, AcceptButton)
                BranchIDComboBox.Focus()
                GoTo endofsave

errorduplicateclientcode:
                MsgBox("ClientCode Exists", MsgBoxStyle.Exclamation, AcceptButton)
                BranchIDComboBox.Focus()
                GoTo endofsave

endofsave:
        Catch EX2 As DBConcurrencyException
            MsgBox("Someone else has saved something in the background whilst you had this loaded. " + (Chr(13)) + "Please Re-Open Client Screen")
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.OkOnly)
        End Try


    End Sub


    Private Sub ToolStripTextBox1_KeyUp_1(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyUp
        Select Case e.KeyValue
            Case 13
                Dim d As New SearchDialog

                Sql = "SELECT    companyid , ClientCode,  CompanyName,  Address, Address2,  Town, County FROM Sites where CompanyName like '%" + ToolStripTextBox1.Text + "%' and branchID in (" + GetSecurityInfo2("Clients", "Lexicon") + ")"

                d.sQLsEARCH(ToolStripTextBox1.Text, Sql)

                Dim result As DialogResult = d.ShowDialog(Me)
                If result = Windows.Forms.DialogResult.OK Then
                    '  MsgBox(d.SearchText)
                    SitesBindingSource.Filter = "CompanyId = " + d.SearchText
                    If NotesRichTextBox.Text = "" Then
                        NotesRichTextBox.BackColor = SystemColors.Window
                        NotesRichTextBox.ForeColor = Color.Black
                        NotesRichTextBox.Font = New Font(Me.Font, FontStyle.Regular)
                    Else
                        NotesRichTextBox.BackColor = Color.Red
                        NotesRichTextBox.ForeColor = Color.Black
                        NotesRichTextBox.Font = New Font(Me.Font, FontStyle.Bold)


                    End If
                End If
        End Select
    End Sub

    Private Sub TableLayoutPanel7_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            LastModifiedDateTextBox.Text = Now()
            LastModifiedUserTextBox.Text = FrmLogin.UsernameTextBox.Text
            If FKJobCategorySitesBindingSource.Count > 0 Then

                If ShiftNameTextBox.Text = "" Then
                    ShiftNameTextBox.Focus()
                    MsgBox("Shift Name Empty", MsgBoxStyle.Exclamation, AcceptButton)
                    GoTo endofsave
                End If
                If (HoursPerShift.Text = "") And ShiftNameTextBox.Text = "Shift Work" Then
                    HoursPerShift.Focus()
                    MsgBox("Hours Per Shift cannot be blank or zero", MsgBoxStyle.Exclamation, AcceptButton)
                    GoTo endofsave
                End If
                If TypicalStartTimeTextBox.Text = "" Then
                    TypicalStartTimeTextBox.Focus()
                    MsgBox("Typical Start Time Empty", MsgBoxStyle.Exclamation, AcceptButton)
                    GoTo endofsave
                End If
                If TypicalEndTimeTextBox.Text = "" Then
                    TypicalEndTimeTextBox.Focus()
                    MsgBox("Typical End Time Empty", MsgBoxStyle.Exclamation, AcceptButton)
                    GoTo endofsave
                End If
                If BreakEntitlementTextBox.Text = "" Then
                    BreakEntitlementTextBox.Focus()
                    MsgBox("Break Entitlement Empty", MsgBoxStyle.Exclamation, AcceptButton)
                    GoTo endofsave
                End If
                If TimesheetContactComboBox.Text = "" Then
                    TimesheetContactComboBox.Focus()
                    MsgBox("Timesheet Contact Empty", MsgBoxStyle.Exclamation, AcceptButton)
                    GoTo endofsave
                End If
                If TimeSheetSentViaTextBox.Text = "" Then
                    TimeSheetSentViaTextBox.Focus()
                    MsgBox("Time Sheet Sent Via Empty", MsgBoxStyle.Exclamation, AcceptButton)
                    GoTo endofsave
                End If
                If TimesheetTypeComboBox.Text = "" Then
                    TimesheetTypeComboBox.Focus()
                    MsgBox("Timesheet Type Empty", MsgBoxStyle.Exclamation, AcceptButton)
                    GoTo endofsave
                End If
                If NotesForTimeSheetTextBox.Text = "" Then
                    NotesForTimeSheetTextBox.Focus()
                    MsgBox("Notes For TimeSheet Empty", MsgBoxStyle.Exclamation, AcceptButton)
                    GoTo endofsave
                End If
                If ComboBox1.Text = "" Then
                    ComboBox1.Focus()
                    MsgBox("Start Of Week Empty", MsgBoxStyle.Exclamation, AcceptButton)
                    GoTo endofsave
                End If
                If DHHTextBox.Text = "" Then
                    DHHTextBox.Focus()
                    MsgBox("DHH Empty", MsgBoxStyle.Exclamation, AcceptButton)
                    GoTo endofsave
                End If
                If MinChargePerDayTextBox.Text = "" Then
                    MinChargePerDayTextBox.Focus()
                    MsgBox("Min Charge Per Day Empty", MsgBoxStyle.Exclamation, AcceptButton)
                    GoTo endofsave
                End If
                If TempToPermAfterTextBox.Text = "" Then
                    TempToPermAfterTextBox.Focus()
                    MsgBox("TempToPerm After Empty", MsgBoxStyle.Exclamation, AcceptButton)
                    GoTo endofsave
                End If
                If SWHTextBox.Text = "" Then
                    SWHTextBox.Focus()
                    MsgBox("SWH Empty", MsgBoxStyle.Exclamation, AcceptButton)
                    GoTo endofsave
                End If
                If SWHTextBox.Text = "" Then
                    SWHTextBox.Focus()
                    MsgBox("SWH Empty", MsgBoxStyle.Exclamation, AcceptButton)
                    GoTo endofsave
                End If
            End If
            Me.Validate()
            Me.FKJobCategorySitesBindingSource.EndEdit()

            Me.JobCategoryTableAdapter1.Update(Me.Sites.JobCategory)
            'Me.JobCategoryTableAdapter.Update(Me.LexiconRecManagerDataSet.JobCategory)
            MsgBox("Job Cat Saved: ")
endofsave:
        Catch ex As Exception

            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InvoiceToTextBox.Text = CompanyNameTextBox.Text
        InvAddressTextBox.Text = AddressTextBox.Text
        Address3TextBox.Text = Address2TextBox.Text
        InvTownTextBox.Text = TownTextBox.Text
        InvCountyComboBox.Text = CountyComboBox.Text
        InvCountryComboBox.Text = CountryComboBox.Text
        InvPostCodeTextBox.Text = PostalCodeTextBox.Text

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim result = MsgBox("Are you sure that you want to delete this job catagory", MsgBoxStyle.YesNo, "Delete Record?")
        If result = DialogResult.Cancel Then
            MessageBox.Show("Cancel pressed")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            If (Me.Validate() And Not (SitesBindingSource Is Nothing)) Then

                SitesBindingSource.RemoveCurrent()
                SitesBindingSource.EndEdit()
                MessageBox.Show("Row Deleted")
            End If
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem1_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem1.Click
        Dim result = MsgBox("Are you sure that you want to delete this job catagory", MsgBoxStyle.YesNo, "Delete Record?")
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            If (Me.Validate() And Not (FKCompanyContactsSitesBindingSource Is Nothing)) Then

                FKJobCategorySitesBindingSource.RemoveCurrent()
                FKJobCategorySitesBindingSource.EndEdit()
                MessageBox.Show("Row Deleted")
            End If
        End If

    End Sub
    'ClientCodeTextBox.TextChanged
    Private Sub ClientCodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles ClientCodeTextBox.Leave
        Try
            If ClientCodeTextBox.Text = "" Then
                ClientCodeTextBox.Focus()

            End If
            Dim dc As New DataClasses1DataContext

            Dim Sitespick = (From Sites In dc.GetTable(Of LinqSite)() Where Sites.ClientCode = ClientCodeTextBox.Text And Sites.CompanyID <> TBCompanyId.Text).ToList


            If Sitespick.Count > 0 Then

                MsgBox("Client Code Isnt Unique: " + Sitespick(0).CompanyName.ToString)
                ClientCodeTextBox.Focus()
            End If
        Catch ex As Exception

            If ex.ToString() <> "" Then
                MsgBox("Client Code Isnt Unique")
                ClientCodeTextBox.Focus()
            End If
        End Try
    End Sub



    Private Sub CBJobType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBJobType.SelectedIndexChanged
        If CBJobType.Text = "Shift Work" Then
            HoursPerShift.ReadOnly = False

        Else

            HoursPerShift.ReadOnly = True
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim db As New DataClasses1DataContext
        Dim ord As New LinqDocument With _
{.Attachment = False, _
 .DocumentType = ".pdf", _
 .SendDateAndTime = DateTime.Now, _
 .SendVia = "Email", _
.EmailSubject = ClientStatusTextEdit.Text + " Notification - ClientCode:" + ClientCodeTextBox.Text + " Name: " + CompanyNameTextBox.Text, _
        .EmailBody = "Client Status Change.<br>Branch: " + BranchIDComboBox.Text + " <br>Client Code: " + ClientCodeTextBox.Text + Environment.NewLine + "<br>Name: " + CompanyNameTextBox.Text + Environment.NewLine + "<br>Status: " + ClientStatusTextEdit.Text + Environment.NewLine + "<br>Reason: " + ClientStatusReasonTextEdit.Text, _
 .ReportLocation = "", _
 .SentTo = "allusers@purestaff.co.uk", _
 .Sent = False, _
 .Parameter1 = "", _
 .FileAttachment = False, _
 .FileLocation = "", _
 .ParameterName = ""
}

        ' Add the new object to the Orders collection.
        db.LinqDocuments.InsertOnSubmit(ord)

        ' Submit the change to the database. 
        Try
            db.SubmitChanges()
        Catch ex As Exception
            Console.WriteLine(ex)
            ' Make some adjustments. 
            ' ... 
            ' Try again.
            '   db.SubmitChanges()
        End Try
    End Sub

    Private Sub ClientStatusTextEdit_Leave(sender As Object, e As EventArgs) Handles ClientStatusTextEdit.Leave
        If ClientStatusTextEdit.Text = "Archive" Then
            'CompanyRegNumberTextBox.Text = ""
            TermsTextBox.Text = ""
            CreditLimitTextBox.Text = ""
            NotesRichTextBox.Text = ""
            SpecialInvoiceInstructionsRichTextBox.Text = ""
            OtherTextBox.Text = ""
            DNICheckBox.Checked = False
            PayParityPureEmbraceCheckBox.Checked = False
            SwedishderogationPureContractedCheckBox.Checked = False
            LtdCheckBox.Checked = False
            PLCCheckBox.Checked = False
            SoleTraderCheckBox.Checked = False

            AddressTextBox.Text = ""
            Address2TextBox.Text = ""
            TownTextBox.Text = ""
            CountyComboBox.Text = ""
            CountryComboBox.Text = ""
            PostalCodeTextBox.Text = ""
            EmailTextBox.Text = ""
            Telephone1TextBox.Text = ""
            Telephone2TextBox.Text = ""
            FaxTextBox.Text = ""
            InvAddressTextBox.Text = ""
            Address3TextBox.Text = ""
            InvoiceToTextBox.Text = ""
            InvTownTextBox.Text = ""
            InvCountyComboBox.Text = ""
            InvCountryComboBox.Text = ""
            InvPostCodeTextBox.Text = ""
            InvoicingMethodTextBox.Text = ""
            OrderNumberReq1CheckBox.Checked = False
            CanteenAvailableCheckBox.Checked = False
            SmokingAreaAvailableCheckBox.Checked = False
            ParkingAvailableCheckBox.Checked = False
            OtherFacilitiesTextBox.Text = ""
            HolidayEntitlementTextBox.Text = ""
            HowArePermanentVacanciesDisplayedTextBox.Text = ""

            H_SContactTextBox.Text = ""
            H_SPositionTextBox.Text = ""
            H_SMinAgeTextBox.Text = ""
            H_SMobileTextBox.Text = ""
            H_SEmailTextBox.Text = ""
            H_SRisksTextBox.Text = ""
            H_SStepsTextBox.Text = ""
            H_SBasicInductionCheckBox.Checked = False
            H_SInstructionGivenCheckBox.Checked = False
            H_SFirstAidAvailableCheckBox.Checked = False
            H_SAccidentsReportedCheckBox.Checked = False
            H_SSaftyBootsCheckBox.Checked = False
            H_SHiVizVestCheckBox.Checked = False
            H_SSaftyGogglesCheckBox.Checked = False
            H_SHardHatCheckBox.Checked = False
            H_SHiVisTrousersCheckBox.Checked = False
            H_SEarDefendersCheckBox.Checked = False
            H_SOtherEqupmentTextBox.Text = ""



        End If
    End Sub

    Private Sub HoursPerShift_EditValueChanged(sender As Object, e As EventArgs) Handles HoursPerShift.EditValueChanged

    End Sub

    Private Sub HoursPerShift_Leave(sender As Object, e As EventArgs) Handles HoursPerShift.Leave
        If CBJobType.Text = "Shift Work" Then
            If HoursPerShift.Text < 6 Then
                MsgBox("Hours per shift must be greater than 6 for Shift Work")
                HoursPerShift.Focus()
            End If
        End If
    End Sub

    Private Sub ShiftNameTextBox_Leave(sender As Object, e As EventArgs) Handles ShiftNameTextBox.Leave

    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If NotesRichTextBox.Text = "" Then
            NotesRichTextBox.BackColor = SystemColors.Window
            NotesRichTextBox.ForeColor = Color.Black
            NotesRichTextBox.Font = New Font(Me.Font, FontStyle.Regular)
        Else
            NotesRichTextBox.BackColor = Color.Red
            NotesRichTextBox.ForeColor = Color.Black
            NotesRichTextBox.Font = New Font(Me.Font, FontStyle.Bold)


        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
    End Sub
    Private Sub TBCompanyId_TextChanged(sender As Object, e As EventArgs) Handles TBCompanyId.TextChanged
        If GetSecurityInfo2("Clients - EnableSageRef", "Lexicon") <> 0 Then
            BranchIDComboBox.Enabled = True
        Else
        If TBCompanyId.Text <= 0 Then
            BranchIDComboBox.Enabled = True
        Else
            BranchIDComboBox.Enabled = False
        End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            If JobCategoryTextBox.Text.Contains(" (U25)") Then
                JobCategoryTextBox.Text = JobCategoryTextBox.Text.Replace(" (U25)", "")
            End If
        ElseIf CheckBox1.Checked = True Then
            If JobCategoryTextBox.Text.Contains(" (U25)") Then
            Else
                JobCategoryTextBox.Text = JobCategoryTextBox.Text + " (U25)"
            End If

        End If
    End Sub
End Class