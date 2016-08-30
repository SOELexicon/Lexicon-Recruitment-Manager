Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Configuration
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.UserSkins.BonusSkins
Imports DevExpress.XtraEditors.Repository
Imports System.IO
Imports DevExpress.XtraSplashScreen


Public Class Main
    Public UserBranch As Int64
    Public UserAdmin As Boolean

    Public UserID As Int64
    Public con As SqlConnection
    Dim cmd As SqlCommand
    Public UserName
    Dim da, da2 As SqlDataAdapter
    Dim Dset As New DataSet
    Dim da3 As SqlDataAdapter
    Dim Dset3 As New DataTable
    Public Function GetSecurityInfo2(area As String, application As String)
        da3 = New SqlDataAdapter("SELECT isnull(SUBSTRING((SELECT        ',' + CAST(BranchuserSecurity.SecurityBranch AS nvarchar(MAX)) FROM Users INNER JOIN BranchUserSecurity ON Users.UserID = BranchUserSecurity.UserID INNER JOIN Applications ON BranchUserSecurity.ApplicationID = Applications.ApplicationId INNER JOIN ApplicationAreas ON BranchUserSecurity.ApplicationArea = ApplicationAreas.ApplicationAreaID  WHERE   (Applications.Application = '" + application + "') and (ApplicationAreas.ApplicationArea = '" + area + "') and  (Users.DomainUserID = '" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString() + "') FOR XML PATH('')),2,200000),0) AS CSV ", Me.con)
        If Dset3 IsNot Nothing Then
            Dset3.Clear()
        End If
        da3.Fill(Dset3)
        Return Dset3.Rows(0)(0).ToString()


    End Function
 
    Public Sub SetUser()
        con.Open()

        da = New SqlDataAdapter("DECLARE	@return_value int,	@Code nvarchar(30),	@Active bit,@Admin bit,	@Branch bigint EXEC	@return_value = [dbo].[UserLogon]	@DomainUserID = N'" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString() + "',	@Code = @Code OUTPUT,	@Active = @Active OUTPUT,@Branch = @Branch OUTPUT,@Admin = @Admin output SELECT	@Code as N'@Code',		@Active as N'@Active',		@Branch as N'@Branch', @Admin as '@Admin'", con)

        If Dset.Tables("UserDetails") IsNot Nothing Then
            Dset.Tables("UserDetails").Clear()
        End If
        If Dset.Tables("SecurityDetails") IsNot Nothing Then
            Dset.Tables("SecurityDetails").Clear()
        End If
        da.Fill(Dset, "UserDetails")

        UserAdmin = Dset.Tables("UserDetails").Rows(0)(3).ToString()

        If UserAdmin = True Then
            NavBarGroup2.Visible = True

        Else
            NavBarGroup2.Visible = False

        End If
        ' cmd.ExecuteNonQuery()
        ' MsgBox("Error : " + Dset.Tables("UserDetails").Rows(0)(1).ToString() + "  - " + System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString())
        con.Close()
    End Sub

    Public Sub connectytosql()

        Try

            'Dim connectioinstringpick As String
            ''connectioinstringpick = "Data Source=192.168.0.4;Initial Catalog=LexiconRecManager;Integrated Security=False;User Id=sa;Password=serve99!"

            'connectioinstringpick = "Data Source=192.168.0.4;Initial Catalog=LexiconRecManager;Integrated Security=True"

            'If ConfigurationManager.ConnectionStrings("Lexrecmgr.My.MySettings.LexiconRecManagerConnectionString").ToString <> connectioinstringpick Then
            '    Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            '    config.ConnectionStrings.ConnectionStrings("Lexrecmgr.My.MySettings.LexiconRecManagerConnectionString").ConnectionString = connectioinstringpick
            '    config.Save(ConfigurationSaveMode.Modified)
            'End If
            'If ConfigurationManager.ConnectionStrings("Lexrecmgr.My.MySettings.LexiconRecManagerConnectionString1").ToString <> connectioinstringpick Then
            '    Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            '    config.ConnectionStrings.ConnectionStrings("Lexrecmgr.My.MySettings.LexiconRecManagerConnectionString").ConnectionString = connectioinstringpick
            '    config.Save(ConfigurationSaveMode.Modified)
            'End If

            con = New SqlConnection(ConfigurationManager.ConnectionStrings("Lexrecmgr.My.MySettings.LexiconRecManagerConnectionString").ToString)

            '--   con.Open()

            '--    Me.Show()
            '--  FrmLogin.Hide()
            '   con.Close()
            SetUser()
            Select Case Dset.Tables("UserDetails").Rows(0)(1).ToString()
                Case "True"


                    FrmLogin.Hide()


                    Me.Show()
                    LoadStartScreen()

                Case "False"
                    Throw New Exception("User Not Active!")
                Case ""
                    MsgBox("Account Doesnt Exist")
            End Select



        Catch ex As SqlException
            MsgBox("Sql Error : " + ex.ToString)

        Catch ex As Exception
            MsgBox("General Error : " + ex.ToString)
        End Try
    End Sub
    'Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
    '    ' Create a new instance of the child form.
    '    Dim ChildForm As New System.Windows.Forms.Form
    '    ' Make it a child of this MDI form before showing it.
    '    ChildForm.MdiParent = Me

    '    m_ChildFormNumber += 1
    '    ChildForm.Text = "Window " & m_ChildFormNumber

    '    ChildForm.Show()
    'End Sub

    'Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim OpenFileDialog As New OpenFileDialog
    '    OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    '    OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
    '    If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
    '        Dim FileName As String = OpenFileDialog.FileName
    '        ' TODO: Add code here to open the file.
    '    End If
    'End Sub

    'Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim SaveFileDialog As New SaveFileDialog
    '    SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    '    SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

    '    If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
    '        Dim FileName As String = SaveFileDialog.FileName
    '        ' TODO: Add code here to save the current contents of the form to a file.
    '    End If
    'End Sub








    'Private Sub ClientDetailsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
    '    ' Create a new instance of the child form.
    '    DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))

    '    Dim ChildForm As New Clients
    '    ' Make it a child of this MDI form before showing it.
    '    ChildForm.MdiParent = Me

    '    m_ChildFormNumber += 1
    '    ChildForm.Text = "Client Details " & m_ChildFormNumber

    '    ChildForm.Show()
    'End Sub
    'Public Sub openReportsForm()
    '    Dim ChildForm As New Reports
    '    ' Make it a child of this MDI form before showing it.
    '    ChildForm.MdiParent = Me

    '    m_ChildFormNumber += 1
    '    ChildForm.Text = "Reports " & m_ChildFormNumber

    '    ChildForm.Show()
    'End Sub
    'Public Sub openReportPlanForm()
    '    Dim ChildForm As New Reports_Planview
    '    ' Make it a child of this MDI form before showing it.
    '    ChildForm.MdiParent = Me

    '    m_ChildFormNumber += 1
    '    ChildForm.Text = "Report_Plans " & m_ChildFormNumber

    '    ChildForm.Show()
    '    ChildForm.loaddatatable()
    'End Sub
    'Public Sub openReportNetMargin()
    '    Dim ChildForm As New Reports_NetMarginReport
    '    ' Make it a child of this MDI form before showing it.
    '    ChildForm.MdiParent = Me

    '    m_ChildFormNumber += 1
    '    ChildForm.Text = "Report_NetMarginReport " & m_ChildFormNumber

    '    ChildForm.Show()
    '    ChildForm.loaddatatable()
    'End Sub

    'Public Sub openReportPlanSchemeCosting()
    '    Dim ChildForm As New Reports_PlanSchemeCosting

    '    ' Make it a child of this MDI form before showing it.
    '    ChildForm.MdiParent = Me

    '    m_ChildFormNumber += 1
    '    ChildForm.Text = "Reports_PlanSchemeCosting" & m_ChildFormNumber

    '    ChildForm.Show()
    '    ChildForm.loaddatatable()
    'End Sub
    'Public Sub openReportPlanValidationForm()
    '    Dim ChildForm As New Reports_PlanValidation
    '    ' Make it a child of this MDI form before showing it.
    '    ChildForm.MdiParent = Me

    '    m_ChildFormNumber += 1
    '    ChildForm.Text = "Report_PlanValidation " & m_ChildFormNumber

    '    ChildForm.Show()
    '    ChildForm.loaddatatable()
    'End Sub
    'Public Sub openReportsPlanClientCostingForm()
    '    Dim ChildForm As New Reports_PlanClientCosting
    '    ' Make it a child of this MDI form before showing it.
    '    ChildForm.MdiParent = Me

    '    m_ChildFormNumber += 1
    '    ChildForm.Text = "Report_ClientCosting" & m_ChildFormNumber

    '    ChildForm.Show()
    '    ChildForm.loaddatatable()
    'End Sub

    'Public Sub openReportBlockTimeSheetForm()
    '    Dim ChildForm As New Reports_BlockTimesheet
    '    ' Make it a child of this MDI form before showing it.
    '    ChildForm.MdiParent = Me

    '    m_ChildFormNumber += 1
    '    ChildForm.Text = "Report_BlockTimeSheet " & m_ChildFormNumber

    '    ChildForm.Show()
    '    ChildForm.loaddatatable()
    'End Sub
    'Public Sub openConfirmationOfRatesForm()
    '    Dim ChildForm As New Reports_ConfirmationOfRates
    '    ' Make it a child of this MDI form before showing it.
    '    ChildForm.MdiParent = Me

    '    m_ChildFormNumber += 1
    '    ChildForm.Text = "Report_ConfirmationOfRates " & m_ChildFormNumber

    '    ChildForm.Show()
    '    ChildForm.loaddatatable()
    'End Sub



    'Public Sub openReportPlanFollowUpForm()
    '    Dim ChildForm As New Reports_PlanFollowup

    '    ' Make it a child of this MDI form before showing it.
    '    ChildForm.MdiParent = Me

    '    m_ChildFormNumber += 1
    '    ChildForm.Text = "Report_Plan_Follow_Up" & m_ChildFormNumber

    '    ChildForm.Show()
    '    ChildForm.loaddatatable()
    'End Sub
    'Private Sub EmployeeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    '    Dim ChildForm As New frmClientDetails
    '    ' Make it a child of this MDI form before showing it.
    '    ChildForm.MdiParent = Me

    '    m_ChildFormNumber += 1
    '    ChildForm.Text = "Employee Details " & m_ChildFormNumber
    '    ChildForm.DynamicFillForm(2)
    '    ChildForm.Show()
    'End Sub

    'Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    Clients.Show()

    'End Sub

    'Private Sub PlansToolStripMenuItem_Click(sender As Object, e As EventArgs)

    '    Dim ChildForm As New Plan
    '    ' Make it a child of this MDI form before showing it.
    '    ChildForm.MdiParent = Me

    '    m_ChildFormNumber += 1
    '    ChildForm.Text = "Plans " & m_ChildFormNumber

    '    ChildForm.Show()
    'End Sub
    'Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    '  Invoices.Show()

    'End Sub

    'Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    openReportsForm()
    'End Sub

    'Private Sub BarButtonReports_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonReports.ItemClick
    '    openReportsForm()
    'End Sub


    Private m_ChildFormNumber As Integer
    Public Sub openclientsform()
        ' Create a new instance of the child form.
        DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormCaption("Client Screen")

        Dim ChildForm As New Clients
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Client Details " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub MDIParent1_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        For i = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        FrmLogin.Close()

    End Sub


    Public Sub openemployeesform()
        SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormCaption("Employee Screen")

        Dim ChildForm As New frmClientDetails
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Employee Details " & m_ChildFormNumber
        ChildForm.DynamicFillForm(2)
        ChildForm.Show()
    End Sub
    Public Sub loadplansform()
        SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormCaption("Plan Screen")


        Dim ChildForm As New Plan
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Plans " & m_ChildFormNumber

        ChildForm.Show()

    End Sub
    Public Sub LoadStartScreen()


        Dim ChildForm As New Web
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Start Screen " & m_ChildFormNumber

        ChildForm.Show()

    End Sub
    Private Sub AdminToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        If Me.UserAdmin = True Then

            UserSecurity.Show()
        End If

    End Sub


    Public Sub loadHolidayform()
        If GetSecurityInfo2("Holidays", "Lexicon") = 0 Then
            MsgBox("No Security Rights")

        Else
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))
            SplashScreenManager.Default.SetWaitFormCaption("Holiday Screen")

            Dim ChildForm As New Holidays
            ' Make it a child of this MDI form before showing it.
            ChildForm.MdiParent = Me

            m_ChildFormNumber += 1
            ChildForm.Text = "Holiday " & m_ChildFormNumber

            ChildForm.Show()

        End If


    End Sub

    Public Sub loadCanvassRegisterform()
        If GetSecurityInfo2("CanvassRegister", "Lexicon") = 0 Then
            MsgBox("No Security Rights")

        Else
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))
            SplashScreenManager.Default.SetWaitFormCaption("Canvass Register Screen")

            Dim ChildForm As New CanvassRegister
            ' Make it a child of this MDI form before showing it.
            ChildForm.MdiParent = Me
            AddHandler ChildForm.FormClosed, AddressOf Child_FormClosed
            m_ChildFormNumber += 1
            ChildForm.Text = "Canvass Register " & m_ChildFormNumber

            ChildForm.Show()

        End If


    End Sub
    Private Sub Child_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        RemoveHandler CType(sender, Form).FormClosed, AddressOf Child_FormClosed
        CType(sender, Form).Dispose()
    End Sub
 


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            For Each cnt As SkinContainer In SkinManager.Default.Skins
                TryCast(SkinsCB.Edit, RepositoryItemComboBox).Items.Add(cnt.SkinName)
            Next cnt
            Dim FILE_NAME As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)

            If (System.IO.File.Exists(FILE_NAME + "\Lexicon\Skins.txt")) Then
                Dim lines() As String = IO.File.ReadAllLines(FILE_NAME + "\Lexicon\Skins.txt")
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = lines(0)
                ' Main..LookAndFeel.UserLookAndFeel.Default.SkinName = lines(0)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '       SplashScreenManager.CloseForm()
        FrmLogin.Close()
    End Sub

    Private Sub NavBarClients_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarClients.LinkClicked
        openclientsform()
    End Sub
    Private Sub BarButtonClients_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonClients.ItemClick
        openclientsform()
    End Sub

    Private Sub BarButtonEmployees_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonEmployees.ItemClick
        openemployeesform()
    End Sub
    Private Sub NavBarEmployees_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarEmployees.LinkClicked
        openemployeesform()
    End Sub

    Private Sub BarButtonPlan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonPlan.ItemClick
        loadplansform()
    End Sub
    Private Sub NavBarPlan_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarPlan.LinkClicked
        ' Me.NavBarPlan.Enabled = False
        loadplansform()

        ' Me.NavBarPlan.Enabled = True
    End Sub


    Private Sub BarButtonHolidays_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonHolidays.ItemClick
        loadHolidayform()

    End Sub
    Private Sub NavBarHolidays_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarHolidays.LinkClicked
        loadHolidayform()
    End Sub
    Private Sub BarButtonCanvassRegister_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonCanvassRegister.ItemClick
        loadCanvassRegisterform()
    End Sub
    Private Sub NavBarCanvassRegister_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarCanvassRegister.LinkClicked
        loadCanvassRegisterform()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        FrmLogin.Close()
    End Sub

    Private Sub BarButtonAdmin_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonAdmin.ItemClick
        If Me.UserAdmin = True Then
          
            UserSecurity.Show()
        End If

    End Sub

    Private Sub BarButtonVertical_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonVertical.ItemClick
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub BarButtonHorizontal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonHorizontal.ItemClick
        Me.LayoutMdi(MdiLayout.TileHorizontal)

    End Sub

    Private Sub BarButtonCloseAll_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonCloseAll.ItemClick
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub BarButtonArrange_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonArrange.ItemClick
        Me.LayoutMdi(MdiLayout.ArrangeIcons)

    End Sub

    Private Sub BarButtonCascade_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonCascade.ItemClick
        Me.LayoutMdi(MdiLayout.Cascade)

    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        'Dashboard.Show()
    End Sub

    Private Sub BarEditItem3_EditValueChanged(sender As Object, e As EventArgs) Handles BarEditItem3.EditValueChanged


        ' Handle the SelectedIndexChanged event to respond to selecting the skin name.


        'Dim comboBox As ComboBoxEdit = sender
        'Dim skinName As String = comboBox.Text
        'DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = skinName


    End Sub

    Private Sub SkinsCB_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SkinsCB.ItemClick

    End Sub

    Private Sub SkinsCB_EditValueChanged(sender As Object, e As EventArgs) Handles SkinsCB.EditValueChanged

        Dim skinName As String = SkinsCB.EditValue
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = skinName
        Dim FILE_NAME As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)

        If (System.IO.Directory.Exists(FILE_NAME + "\Lexicon\")) Then
            System.IO.File.Delete(FILE_NAME + "\Lexicon\Skins.txt")
        End If
        If (Not System.IO.Directory.Exists(FILE_NAME + "\Lexicon\")) Then
            System.IO.Directory.CreateDirectory(FILE_NAME + "\Lexicon\")
        End If
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME + "\Lexicon\Skins.txt", True)


        objWriter.Write(skinName)


        objWriter.Close()

    End Sub
    Public Sub loadActivityForm()
        If GetSecurityInfo2("Activity", "Activity") = 0 Then
            MsgBox("No Security Rights")

        Else
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))
            SplashScreenManager.Default.SetWaitFormCaption("Activity Screen")

            Dim ChildForm As New Activity
            ' Make it a child of this MDI form before showing it.
            ChildForm.MdiParent = Me

            m_ChildFormNumber += 1
            ChildForm.Text = "Activity " & m_ChildFormNumber

            ChildForm.Show()

        End If
    End Sub

    Public Sub loadSecurityForm()
        DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormCaption("Security Screen")

        Dim ChildForm As New Security
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Admin - Security " & m_ChildFormNumber

        ChildForm.Show()



    End Sub
    Public Sub loadSchemesForm()
        DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormCaption("Scheme Screen")

        Dim ChildForm As New Schemes
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "Admin - Schemes " & m_ChildFormNumber
        ChildForm.Show()
    End Sub
    Public Sub loadPlanTypesForm()
        DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormCaption("PlanTypes Screen")

        Dim ChildForm As New PlanTypes
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "Admin - Plan Types " & m_ChildFormNumber
        ChildForm.Show()
    End Sub
    Public Sub loadControlsForm()
        DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormCaption("Control Screen")

        Dim ChildForm As New Controls
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "Admin - Controls " & m_ChildFormNumber
        ChildForm.Show()
    End Sub
    Public Sub loadBranchsForm()
        DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))
        SplashScreenManager.Default.SetWaitFormCaption("Branch Screen")

        Dim ChildForm As New Branchs
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "Admin - Branch's " & m_ChildFormNumber
        ChildForm.Show()
    End Sub
    Private Sub NavBarActivity_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarActivity.LinkClicked
        loadActivityForm()

    End Sub

    Private Sub NavBarItem8_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem8.LinkClicked
        loadSecurityForm()
    End Sub

    Private Sub NavBarItem7_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem7.LinkClicked
        loadSchemesForm()
    End Sub

    Private Sub NavBarItem6_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem6.LinkClicked
        loadPlanTypesForm()
    End Sub

    Private Sub NavBarControl_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarControl.LinkClicked
        loadControlsForm()
    End Sub

    Private Sub NavBarItem5_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem5.LinkClicked
        loadBranchsForm()
    End Sub

    Private Sub NavBarItem9_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem9.LinkClicked
        
        Dim ChildForm As New Employees
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "Admin - Branch's " & m_ChildFormNumber
        ChildForm.Show()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Plan_Import.Show()

    End Sub
End Class
