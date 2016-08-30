Imports System.Data.SqlClient

Public Class Holidays

    

    Private Sub HolidaysBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles HolidaysBindingNavigatorSaveItem.Click
        Try

            Dim dc As New DataClasses1DataContext
            If Me.HolidayIDTextBox.Text <> "" Then


                If Me.HolidayIDTextBox.Text < 0 Then
                    Dim Sitespick = (From Holidays In dc.GetTable(Of LinqHoliday)() Where Holidays.Weekendingdate = CType(WeekendingdateTextBox.Text, Date) And Holidays.EmployeeId = EmployeeIdComboBox.SelectedValue.ToString).ToList
                    If Sitespick.Count > 0 Then
                        MsgBox("Employee Allready Exists On Holiday Register")
                        EmployeeIdComboBox.Focus()
                        GoTo endofsave

                    End If
                Else
                    Dim Sitespick = (From Holidays In dc.GetTable(Of LinqHoliday)() Where Holidays.Weekendingdate = CType(WeekendingdateTextBox.Text, Date) And Holidays.HolidayID <> Me.HolidayIDTextBox.Text And Holidays.EmployeeId = EmployeeIdComboBox.SelectedValue.ToString).ToList
                    If Sitespick.Count > 0 Then
                        MsgBox("Employee Allready Exists On Holiday Register")
                        EmployeeIdComboBox.Focus()
                        GoTo endofsave
                    End If
                End If

            End If
            Me.DateAddedTextBox.Text = Now.Date.ToString
            Me.LastModifiedUserTextBox.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString()
            Me.LastModifiedDateTextBox.Text = Now.ToString


            Me.SystemTypeTextBox.Text = "N"
            Me.Validate()
            Me.HolidaysBindingSource.EndEdit()
            Me.HolidaysTableAdapter.Update(Me.LexiconRecManagerDataSet.Holidays)

            Me.HollidayGridViewTableAdapter.Fill(Me.Sites.HollidayGridView)

            If BranchCB.SelectedValue IsNot Nothing Then


                If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then
                    HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and SystemType <> 'A'"
                Else
                    HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + ""


                End If
            End If
endofsave:
            If HollidayGridViewDataGridView.Item(1, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString <> "" Then
                Me.HolidaysTableAdapter.Fill(Me.LexiconRecManagerDataSet.Holidays, HollidayGridViewDataGridView.Item(0, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString)
            End If
            Select Case HollidayGridViewDataGridView.Item(2, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString
                Case "L"
                    readonlyset()
                Case "A"
                    readonlyset()
                Case Else
                    readonlyunset()
            End Select
            If GetSecurityInfo2("Holidays-Adjustment", "Lexicon") = 0 Then
                Accruedadj.ReadOnly = True
            Else
                Accruedadj.ReadOnly = False


            End If

            'refreshdata()
        Catch ex As Exception

        End Try

    End Sub

    Dim lastfilter As String

    Public Sub refreshdata()
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.LexiconRecManagerDataSet.Branch)
        'TODO: This line of code loads data into the 'Sites.HollidayGridView' table. You can move, or remove it, as needed.
        Me.HollidayGridViewTableAdapter.Fill(Me.Sites.HollidayGridView)
        'TODO: This line of code loads data into the 'Sites.Holidays' table. You can move, or remove it, as needed.
     
    End Sub
    'Dim Systemtypefilter As String(0-)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Holidays' table. You can move, or remove it, as needed.
        ' Me.HolidaysTableAdapter.Fill(Me.LexiconRecManagerDataSet.Holidays)
        'TODO: This line of code loads data into the 'Sites.Holidays' table. You can move, or remove it, as needed.

        Try
            refreshdata()
            Dim securityholidays As String = GetSecurityInfo2("Holidays", "Lexicon")
            BranchBindingSource.Filter = "BranchId In (" + securityholidays + ")"

            If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then
                HollidayGridViewBindingSource.Filter = "BranchId In (" + securityholidays + ") and SystemType <> 'A'"

            Else
                HollidayGridViewBindingSource.Filter = "BranchId In (" + securityholidays + ") "

            End If
            HollidayGridViewBindingSource.Filter = "BranchId = 0"
       

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then

                Me.HolidaysWeekendingDropdownTableAdapter.Fill(Me.Sites.HolidaysWeekendingDropdown, BranchCB.SelectedValue, ",N,L,U,N,LP,")
            Else


                Me.HolidaysWeekendingDropdownTableAdapter.Fill(Me.Sites.HolidaysWeekendingDropdown, BranchCB.SelectedValue, ",N,L,U,N,LP,A,")
            End If
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()

        End Try
    End Sub
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



    Private Sub HolidayFormReceivedCheckBox_Click(sender As Object, e As EventArgs)
        HollidayFormReceivedLMUTextBox.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString()
        HollidayFormReceivedLMDTextBox.Text = Now()
    End Sub


    Private Sub HollidayGridViewDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles HollidayGridViewDataGridView.CellContentClick

    End Sub
    Public Sub readonlyset()
        Try
            HollidayFormReceivedLMUTextBox.ReadOnly = True
            HollidayFormReceivedLMDTextBox.Enabled = False
            ' EmployeeIdComboBox.Enabled = False
            WeekendingdateTextBox.Enabled = False
            WeekEndingDateIfLateTextBox.Enabled = False
            MondayCheckBox.Enabled = False
            TuesdayCheckBox.Enabled = False
            WednesdayCheckBox.Enabled = False
            ThursdayCheckBox.Enabled = False
            FridayCheckBox.Enabled = False
            SaturdayCheckBox.Enabled = False
            SundayCheckBox.Enabled = False
            LastModifiedUserTextBox.Enabled = False
            LastModifiedDateTextBox.Enabled = False
            HolidayFormReceivedCheckBox.Enabled = False
            If HolidayIDTextBox.Text = "" Then

                EmployeeIdComboBox.Enabled = False
            ElseIf HolidayIDTextBox.Text <= 0 Then

                EmployeeIdComboBox.Enabled = False
            Else
                EmployeeIdComboBox.Enabled = False

            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub readonlyunset()
        Try


            HollidayFormReceivedLMUTextBox.ReadOnly = True
            HollidayFormReceivedLMDTextBox.Enabled = False
            'EmployeeIdComboBox.Enabled = True
            WeekendingdateTextBox.Enabled = True
            WeekEndingDateIfLateTextBox.Enabled = True
            MondayCheckBox.Enabled = True
            TuesdayCheckBox.Enabled = True
            WednesdayCheckBox.Enabled = True
            ThursdayCheckBox.Enabled = True
            FridayCheckBox.Enabled = True
            SaturdayCheckBox.Enabled = True
            SundayCheckBox.Enabled = True
            LastModifiedUserTextBox.Enabled = False
            LastModifiedDateTextBox.Enabled = False
            HolidayFormReceivedCheckBox.Enabled = True
            If HolidayIDTextBox.Text <= 0 Then
                EmployeeIdComboBox.Enabled = True
            Else
                EmployeeIdComboBox.Enabled = False

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub HollidayGridViewDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles HollidayGridViewDataGridView.CellClick
        If HollidayGridViewDataGridView.Item(1, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString <> "" Then
            Me.HolidaysTableAdapter.Fill(Me.LexiconRecManagerDataSet.Holidays, HollidayGridViewDataGridView.Item(0, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString)
        End If
        Select Case HollidayGridViewDataGridView.Item(2, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString
            Case "L"
                readonlyset()
            Case "A"
                readonlyset()
            Case Else
                readonlyunset()
        End Select
        If GetSecurityInfo2("Holidays-Adjustment", "Lexicon") = 0 Then
            Accruedadj.ReadOnly = True
        Else
            Accruedadj.ReadOnly = False
        End If
        If HolidayIDTextBox.Text <= 0 Then
            EmployeeIdComboBox.Enabled = True
        Else
            EmployeeIdComboBox.Enabled = False

        End If
    End Sub

    Private Sub HolidayFormReceivedCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles HolidayFormReceivedCheckBox.CheckedChanged
        If HolidayFormReceivedCheckBox.Checked = True Then
            Select Case SystemTypeTextBox.Text
                Case "L"

                Case Else
                    readonlyunset()
            End Select
        Else
            Select Case SystemTypeTextBox.Text
                Case "L"

                Case Else
                    readonlyset()
                    HolidayFormReceivedCheckBox.Enabled = True

            End Select
        End If
        HollidayFormReceivedLMUTextBox.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString()
        HollidayFormReceivedLMDTextBox.Text = Now()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BranchCB.SelectedIndexChanged
        If BranchCB.SelectedValue IsNot Nothing Then


            Me.HolidayEmployeeDropdownTableAdapter.Fill(Me.Sites.HolidayEmployeeDropdown, BranchCB.SelectedValue)

            If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then

                Me.HolidaysWeekendingDropdownTableAdapter.Fill(Me.Sites.HolidaysWeekendingDropdown, BranchCB.SelectedValue, ",N,L,U,N,LP,")
            Else


                Me.HolidaysWeekendingDropdownTableAdapter.Fill(Me.Sites.HolidaysWeekendingDropdown, BranchCB.SelectedValue, ",N,L,U,N,LP,A,")
            End If
            If ComboBox2.Text <> "" Then
                If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then

                    HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and Weekendingdate = '" + ComboBox2.Text + "' and SystemType <> 'A'"
                Else
                    HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and Weekendingdate = '" + ComboBox2.Text + "'"

                End If
            Else
                If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then
                    HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and SystemType <> 'A'"
                Else
                    HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " "

                End If
            End If

        End If
    End Sub

    Public Sub checkemployeeexists()

        Dim dc As New DataClasses1DataContext
        If Me.HolidayIDTextBox.Text <> "" Then


            If Me.HolidayIDTextBox.Text < 0 Then
                Dim Sitespick = (From Holidays In dc.GetTable(Of LinqHoliday)() Where Holidays.Weekendingdate = CType(WeekendingdateTextBox.Text, Date) And Holidays.EmployeeId = EmployeeIdComboBox.SelectedValue.ToString).ToList
                If Sitespick.Count > 0 Then
                    MsgBox("Employee Allready Exists On Holiday Register")
                    EmployeeIdComboBox.Focus()

                End If
            Else
                Dim Sitespick = (From Holidays In dc.GetTable(Of LinqHoliday)() Where Holidays.Weekendingdate = CType(WeekendingdateTextBox.Text, Date) And Holidays.HolidayID <> Me.HolidayIDTextBox.Text And Holidays.EmployeeId = EmployeeIdComboBox.SelectedValue.ToString).ToList
                If Sitespick.Count > 0 Then
                    MsgBox("Employee Allready Exists On Holiday Register")
                    EmployeeIdComboBox.Focus()

                End If
            End If

        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged


    End Sub

    Private Sub ComboBox2_TextChanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
        Try
            If ComboBox2.Text <> "" Then
                If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then
                    HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and Weekendingdate = '" + ComboBox2.Text + "' and SystemType <> 'A'"
                Else
                    HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and Weekendingdate = '" + ComboBox2.Text + "'"
                End If
            Else
                If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then
                    HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and SystemType <> 'A'"
                Else
                    HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " "
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub EmployeeIdComboBox_Leave(sender As Object, e As EventArgs) Handles EmployeeIdComboBox.Leave
        checkemployeeexists()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LockAll.Click
        Dim dc As New DataClasses1DataContext
        Dim sites As String() = GetSecurityInfo2("Holidays-LockAll", "Lexicon").Split(","c)
        For Each s As String In sites
            If s = HollidayGridViewDataGridView.Item(1, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString Then
                dc.LockHolidayPlan(ComboBox2.Text, BranchCB.SelectedValue)
                MsgBox("Records Locked")
                Me.HollidayGridViewTableAdapter.Fill(Me.Sites.HollidayGridView)
                If ComboBox2.Text <> "" Then
                    If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then
                        HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and Weekendingdate = '" + ComboBox2.Text + "' and SystemType <> 'A'"
                    Else
                        HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and Weekendingdate = '" + ComboBox2.Text + "'"
                    End If
                Else
                    If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then
                        HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and SystemType <> 'A'"
                    Else
                        HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " "
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub LockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LockToolStripMenuItem.Click
        Dim found As Boolean = False
        If GetSecurityInfo2("Holidays", "Lexicon") = 0 Then
            MsgBox("Cannot Lock - Insufficient Rights")
        Else
            If HollidayGridViewDataGridView.Item(2, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString = "N" Then
                Dim dc As New DataClasses1DataContext
                Dim LinqHol = (From Hol In dc.GetTable(Of LinqHoliday)() Where Hol.HolidayID = HollidayGridViewDataGridView.Item(0, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString).FirstOrDefault
                Dim sites As String() = GetSecurityInfo2("Holidays", "Lexicon").Split(","c)
                For Each s As String In sites
                    If s = HollidayGridViewDataGridView.Item(1, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString Then
                        If HollidayGridViewDataGridView.Item(26, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString >= 0 Then
                            found = True
                            LinqHol.SystemType = "L"
                            dc.SubmitChanges()
                            MsgBox("Record Locked")
                            Me.HollidayGridViewTableAdapter.Fill(Me.Sites.HollidayGridView)
                            If ComboBox2.Text <> "" Then
                                If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then
                                    HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and Weekendingdate = '" + ComboBox2.Text + "' and SystemType <> 'A'"
                                Else
                                    HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and Weekendingdate = '" + ComboBox2.Text + "'"
                                End If
                            Else
                                If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then
                                    HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and SystemType <> 'A'"
                                Else
                                    HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " "
                                End If
                            End If
                        Else
                            MsgBox("Cannot Lock Record Days Left Below 0")
                        End If
                    End If
                Next
                If found = False Then
                    MsgBox("Cannot Lock - Insufficient Rights")
                End If
            Else
                MsgBox("Cannot Lock - allready Locked")
            End If
        End If
    End Sub

    Private Sub UnlockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnlockToolStripMenuItem.Click
        Dim found As Boolean = False
        If GetSecurityInfo2("Holidays", "Lexicon") = 0 Then
            MsgBox("Cannot unlock - Insufficient Rights")
        Else
            If HollidayGridViewDataGridView.Item(2, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString = "L" Then
                Dim dc As New DataClasses1DataContext
                Dim LinqHol = (From Hol In dc.GetTable(Of LinqHoliday)() Where Hol.HolidayID = HollidayGridViewDataGridView.Item(0, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString).FirstOrDefault
                Dim sites As String() = GetSecurityInfo2("Holidays", "Lexicon").Split(","c)
                For Each s As String In sites
                    If s = HollidayGridViewDataGridView.Item(1, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString Then
                        found = True
                        LinqHol.SystemType = "N"
                        dc.SubmitChanges()
                        MsgBox("Record unlocked")
                        Me.HollidayGridViewTableAdapter.Fill(Me.Sites.HollidayGridView)
                        If ComboBox2.Text <> "" Then
                            If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then
                                HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and Weekendingdate = '" + ComboBox2.Text + "' and SystemType <> 'A'"
                            Else
                                HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and Weekendingdate = '" + ComboBox2.Text + "'"
                            End If
                        Else
                            If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then
                                HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and SystemType <> 'A'"
                            Else
                                HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " "
                            End If
                        End If
                    End If
                Next
                If found = False Then
                    MsgBox("Cannot unlock - Insufficient Rights")
                End If
            Else
                MsgBox("Cannot unlock - allready unlocked")
            End If
        End If
    End Sub

    Private Sub HollidayGridViewDataGridView_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles HollidayGridViewDataGridView.CellMouseDown
        If e.Button = MouseButtons.Right Then
            HollidayGridViewDataGridView.CurrentCell = HollidayGridViewDataGridView(e.ColumnIndex, e.RowIndex)
        End If
    End Sub

    Private Sub ArchiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchiveToolStripMenuItem.Click
        Dim found As Boolean = False
        If GetSecurityInfo2("Holidays-Archive", "Lexicon") = 0 Then
            MsgBox("Cannot Archive - Insufficient Rights")
        Else
            If HollidayGridViewDataGridView.Item(2, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString = "L" Then
                Dim dc As New DataClasses1DataContext
                Dim LinqHol = (From Hol In dc.GetTable(Of LinqHoliday)() Where Hol.HolidayID = HollidayGridViewDataGridView.Item(0, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString).FirstOrDefault
                Dim sites As String() = GetSecurityInfo2("Holidays-Archive", "Lexicon").Split(","c)
                For Each s As String In sites
                    If s = HollidayGridViewDataGridView.Item(1, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString Then
                        found = True
                        LinqHol.SystemType = "A"
                        dc.SubmitChanges()
                        MsgBox("Record Archived")
                        Me.HollidayGridViewTableAdapter.Fill(Me.Sites.HollidayGridView)
                        If ComboBox2.Text <> "" Then
                            If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then
                                HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and Weekendingdate = '" + ComboBox2.Text + "' and SystemType <> 'A'"
                            Else
                                HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and Weekendingdate = '" + ComboBox2.Text + "'"
                            End If
                        Else
                            If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then
                                HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and SystemType <> 'A'"
                            Else
                                HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " "
                            End If
                        End If
                    End If
                Next
                If found = False Then
                    MsgBox("Cannot Archive - Insufficient Rights")
                End If
            Else
                MsgBox("Cannot Archive")
            End If
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ArchiveAll.Click
        Dim dc As New DataClasses1DataContext
        Dim sites As String() = GetSecurityInfo2("Holidays-Archive", "Lexicon").Split(","c)
        For Each s As String In sites

            If s = HollidayGridViewDataGridView.Item(1, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString Then
                dc.ArchiveHolidayPlan(ComboBox2.Text, BranchCB.SelectedValue)
                MsgBox("Records Archived")
                Me.HollidayGridViewTableAdapter.Fill(Me.Sites.HollidayGridView)
                If ComboBox2.Text <> "" Then
                    If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then
                        HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and Weekendingdate = '" + ComboBox2.Text + "' and SystemType <> 'A'"
                    Else
                        HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and Weekendingdate = '" + ComboBox2.Text + "'"
                    End If
                Else
                    If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then
                        HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and SystemType <> 'A'"
                    Else
                        HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " "
                    End If
                End If
            End If

        Next
    End Sub

    Private Sub UnlockAll_Click(sender As Object, e As EventArgs) Handles UnlockAll.Click
        Dim dc As New DataClasses1DataContext
        Dim sites As String() = GetSecurityInfo2("Holidays-UnlockAll", "Lexicon").Split(","c)
        For Each s As String In sites
            If s = HollidayGridViewDataGridView.Item(1, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString Then
                dc.UnLockHolidayPlan(ComboBox2.Text, BranchCB.SelectedValue)
                MsgBox("Records Unlocked")
                Me.HollidayGridViewTableAdapter.Fill(Me.Sites.HollidayGridView)
                If ComboBox2.Text <> "" Then
                    If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then
                        HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and Weekendingdate = '" + ComboBox2.Text + "' and SystemType <> 'A'"
                    Else
                        HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and Weekendingdate = '" + ComboBox2.Text + "'"
                    End If
                Else
                    If GetSecurityInfo2("Holidays-ArchiveView", "Lexicon") = 0 Then
                        HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " and SystemType <> 'A'"
                    Else
                        HollidayGridViewBindingSource.Filter = "BranchId = " + BranchCB.SelectedValue.ToString + " "
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub WeekendingdateTextBox_Leave(sender As Object, e As EventArgs) Handles WeekendingdateTextBox.Leave
        Try
            If (DateTime.Parse(WeekendingdateTextBox.Text) <= "1/1/1900") Then
                MsgBox("invalid Weekending Date")
                WeekendingdateTextBox.Focus()
            End If
        Catch ex As System.FormatException
            MsgBox("Error WeekEndingDate Format Is Wrong Or Invalid.")
            WeekendingdateTextBox.Focus()
        End Try
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        If HollidayGridViewDataGridView.Item(2, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString = "L" Then
            MsgBox("Cannot Delete Locked Record")
        ElseIf HollidayGridViewDataGridView.Item(2, HollidayGridViewDataGridView.CurrentRow.Index).Value.ToString = "A" Then
            MsgBox("Cannot Delete Archived Record")
        Else
            HolidaysBindingSource.RemoveCurrent()
            Me.Validate()
            Me.HolidaysBindingSource.EndEdit()
            Me.HolidaysTableAdapter.Update(Me.LexiconRecManagerDataSet.Holidays)

            Me.HollidayGridViewTableAdapter.Fill(Me.Sites.HollidayGridView)

        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to add a new record. If you haven’t saved the previous one you will lose your changes", "Add New Record?", MessageBoxButtons.YesNo)
        If result = DialogResult.Cancel Then
        ElseIf result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            Me.HolidaysTableAdapter.Fill(Me.LexiconRecManagerDataSet.Holidays, 0)
            HolidaysBindingSource.AddNew()
            If HolidayIDTextBox.Text <= 0 Then
                EmployeeIdComboBox.Enabled = True
            Else
                EmployeeIdComboBox.Enabled = False

            End If
        End If

    End Sub

    Private Sub Holidays_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class