Imports System.Xml
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.IO
Imports Microsoft.Reporting.WinForms


Public Class Reports_BlockTimesheet
    Public Sub loaddatatable()


    End Sub
    Public Sub loadreport()
        Try
            'ReportViewer1.LocalReport.DataSources.Clear()
            
            Me.BlockTimesheetTableAdapter.Fill(Me.LexiconRecManagerDataSet.BlockTimesheet, WeekEndDate.SelectedValue, Client.SelectedValue, Branch1.Text, Plan.Text)
            Me.Branch.Refresh()
            Me.Branch.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles Branch.Load

    End Sub

    Private Sub Reports_Planview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.BlockTimesheet' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'Sites.Plan' table. You can move, or remove it, as needed.
        Me.PlanTableAdapter.Fill(Me.Sites.Plan)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.BlockTimesheet' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'Sites.Plan' table. You can move, or remove it, as needed.
        Me.PlanTableAdapter.Fill(Me.Sites.Plan)
        'TODO: This line of code loads data into the 'Sites.DataTable1' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.PlanTypes' table. You can move, or remove it, as needed.
        Me.PlanTypesTableAdapter.Fill(Me.LexiconRecManagerDataSet.PlanTypes)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.LexiconRecManagerDataSet.Branch)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Rpt_ConfirmationOfRates1' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loadreport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            Dim warnings() As Microsoft.Reporting.WinForms.Warning = Nothing

        Dim streamids As String() = Nothing

        Dim mimeType As String = Nothing

        Dim encoding As String = Nothing

        Dim extension As String = Nothing
        Dim currentADUser As System.DirectoryServices.AccountManagement.UserPrincipal
        currentADUser = System.DirectoryServices.AccountManagement.UserPrincipal.Current
        Dim userEmail As String = currentADUser.EmailAddress
        Dim bytes As Byte()
        Dim response As System.IO.MemoryStream
        bytes = Branch.LocalReport.Render("PDF", Nothing, mimeType, encoding, extension, streamids, warnings)

        response = New MemoryStream(bytes)
        response.Seek(0, SeekOrigin.Begin)

        Dim Message As MailMessage = New MailMessage()
        Dim Attachment As Attachment = New Attachment(response, "BusinessReport.PDF")
        Message.Attachments.Add(Attachment)
        Message.From = New MailAddress("Lexicon@Purestaff.co.uk")
        Message.To.Add(userEmail)


        Message.Subject = "Block Timesheet Report"
        Message.IsBodyHtml = True
        Message.Body = "Please find Attached Report herewith."
        Dim smtp As SmtpClient = New SmtpClient("PURESTAFFSERVER", 25)

        smtp.Send(Message)
        response.Close()
        response.Dispose()
    End Sub
    Dim filter1 As String

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Rpt_ConfirmationOfRates1BindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub WeekEndDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WeekEndDate.SelectedIndexChanged, Plan.SelectedIndexChanged, Branch1.SelectedIndexChanged
        Me.BlockTimeSheetClientListTableAdapter.Fill(Me.LexiconRecManagerDataSet.BlockTimeSheetClientList, Branch1.Text, WeekEndDate.SelectedValue, Plan.Text)
    End Sub
End Class