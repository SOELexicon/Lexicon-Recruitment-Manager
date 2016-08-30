﻿Imports System.Xml
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.IO
Imports Microsoft.Reporting.WinForms


Public Class Reports_PlanClientCosting
    Public Sub loaddatatable()
       

    End Sub
    Public Sub loadreport()
        Try
            'ReportViewer1.LocalReport.DataSources.Clear()
            Me.Rpt_PlanClientCostingTableAdapter.Fill(Me.LexiconRecManagerDataSet.Rpt_PlanClientCosting, weekenddate.Text, branch.Text, plantype.Text, client.Text)
          
            Me.ReportViewer1.Refresh()
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub Reports_Planview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.LexiconRecManagerDataSet.Branch)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.PlanTypes' table. You can move, or remove it, as needed.
        Me.PlanTypesTableAdapter.Fill(Me.LexiconRecManagerDataSet.PlanTypes)
        'TODO: This line of code loads data into the 'Sites.Plan' table. You can move, or remove it, as needed.
        Me.PlanTableAdapter.Fill(Me.Sites.Plan)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.DataTable1' table. You can move, or remove it, as needed.
      
     
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

        'Message.CC.Add("santosh.poojari@gmail.com")

        Message.Subject = "Client Costing Report"
        Message.IsBodyHtml = True
        Message.Body = "Please find Attached Report herewith."
        Dim smtp As SmtpClient = New SmtpClient("PURESTAFFSERVER", 25)
        '  smtp.Credentials = New System.Net.NetworkCredential("johnsutton", "jennypure")
        ' smtp.Credentials = New System.Net.NetworkCredential("craig_wright156@hotmail.com", "cw84343751")
        'smtp.EnableSsl = True

        smtp.Send(Message)
        response.Close()
        response.Dispose()
    End Sub
    Dim filter1 As String

    
    
    Private Sub weekenddate_TabIndexChanged(sender As Object, e As EventArgs) Handles weekenddate.TabIndexChanged
       
    End Sub

    Private Sub weekenddate_TextChanged(sender As Object, e As EventArgs) Handles weekenddate.TextChanged
        Try


            Me.BlockTimeSheetClientListTableAdapter.Fill(Me.LexiconRecManagerDataSet.BlockTimeSheetClientList, branch.Text, weekenddate.Text, plantype.Text)
            BlockTimeSheetClientListBindingSource.Filter = "OrderNumberReq = 1"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub weekenddate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles weekenddate.SelectedIndexChanged
        Try


            Me.BlockTimeSheetClientListTableAdapter.Fill(Me.LexiconRecManagerDataSet.BlockTimeSheetClientList, branch.Text, weekenddate.Text, plantype.Text)
            BlockTimeSheetClientListBindingSource.Filter = "OrderNumberReq = 1"
        Catch ex As Exception

        End Try
    End Sub
End Class