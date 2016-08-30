Imports System.Xml
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.IO
Imports Microsoft.Reporting.WinForms


Public Class Reports_Planview
    Public Sub loaddatatable()
        '  Me.DataTable1TableAdapter.Fill(Me.LexiconRecManagerDataSet.DataTable1)
        'TODO: This line of code loads data into thLexiconRecManagerDataSete 'Sites.Plan' table. You can move, or remove it, as needed.
        Me.PlanTableAdapter.Fill(Me.Sites.Plan)
        'TODO: This line of code loads data into the 'Sites.PlanTypes' table. You can move, or remove it, as needed.
        Me.PlanTypesTableAdapter.Fill(Me.LexiconRecManagerDataSet.PlanTypes)

    End Sub
    Public Sub loadreport()
        Try
            'ReportViewer1.LocalReport.DataSources.Clear()
            Me.Rpt_PlanTableAdapter.Fill(Me.LexiconRecManagerDataSet.Rpt_Plan, ComboBox2.Text, ComboBox3.Text, ComboBox1.Text)
          
            Me.ReportViewer1.Refresh()
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub Reports_Planview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Rpt_Plan' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.LexiconRecManagerDataSet.Branch)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Rpt_Plan' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.DataTable1' table. You can move, or remove it, as needed.
        ' Me.DataTable1TableAdapter.Fill(Me.LexiconRecManagerDataSet.DataTable1)
        loaddatatable()
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
        bytes = ReportViewer1.LocalReport.Render("PDF", Nothing, mimeType, encoding, extension, streamids, warnings)

        response = New MemoryStream(bytes)
        response.Seek(0, SeekOrigin.Begin)

        Dim Message As MailMessage = New MailMessage()
        Dim Attachment As Attachment = New Attachment(response, "BusinessReport.PDF")
        Message.Attachments.Add(Attachment)
        Message.From = New MailAddress("Lexicon@Purestaff.co.uk")
        Message.To.Add(userEmail)


        Message.Subject = "Plan View Report - " + ComboBox2.Text + " " + ComboBox3.Text + " " + ComboBox1.Text
        Message.IsBodyHtml = True
        Message.Body = "Please find Attached Report herewith."
        Dim smtp As SmtpClient = New SmtpClient("PURESTAFFSERVER", 25)

        smtp.Send(Message)
        response.Close()
        response.Dispose()
    End Sub
    Dim filter1 As String

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub
End Class