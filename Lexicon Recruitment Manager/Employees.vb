Imports System.Data.SqlClient
Imports System.Linq
Imports System.Data.Linq
Imports DevExpress.XtraGrid.Views.Grid
Public Class Employees
    'Copyright 2012 Craig Wright
    'Redistribution and use in source and binary forms, with or without     'modification, are permitted provided that the following conditions     'are met 

    '1. Redistributions of source code must retain the above copyright     'notice, this list of conditions and the following disclaimer.
    '2. Redistributions in binary form must reproduce the above copyright     'notice, this list of conditions and the following disclaimer in the     'documentation and/or other materials provided with the distribution.

    'THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS     '"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT    'LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS     'FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE     'COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT,     'INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING,     'BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;     'LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER     'CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT     'LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN     'ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE     'POSSIBILITY OF SUCH DAMAGE.
    Dim adSQLAdapter2 As SqlDataAdapter
    Dim Dset As New DataSet
    Private Sub EmployeesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmployeesBindingNavigatorSaveItem.Click

        Dim Validatoin As String
        Dim Validatoinchoice As String
        Try

            Validatoin = "The following fields are mandatory; "

            Validatoinchoice = "The following fields are Invalid; "

            If NINumberTextEdit.ReadOnly = False Then
                Dim dc As New DataClasses1DataContext
                Dim EmployeeLinqNICheck = (From Employees In dc.GetTable(Of LinqEmployee)() Where Employees.NINumber = NINumberTextEdit.Text Order By Employees.EmployeeID Descending).FirstOrDefault


                If EmployeeLinqNICheck IsNot Nothing Then
                    If EmployeeLinqNICheck.EmployeeCode IsNot Nothing Then
                        Select Case EmployeeLinqNICheck.Status
                            Case "Archive"
                                If EmployeeLinqNICheck.LastWorkedDate > DateAdd(DateInterval.Month, -6, Now()) Then
                                    MsgBox("Archived Employee Worked In Past 6 Months and NINumber isnt unique EmployeeCode:" + EmployeeLinqNICheck.EmployeeCode.ToString)
                                    Validatoin = Validatoin + "NiNumber ¦ "
                                    NINumberTextEdit.Focus()
                                Else
                                    MsgBox("Archived Employee Not Worked In Past 6 Months:" + EmployeeLinqNICheck.EmployeeCode.ToString)
                                End If
                            Case "N/S"
                                MsgBox("Employee Previously N/S:" + EmployeeLinqNICheck.EmployeeCode.ToString)

                            Case "Blacklisted"
                                MsgBox("Employee Previously BlackListed:" + EmployeeLinqNICheck.EmployeeCode.ToString)


                            Case "TOT"
                                MsgBox("NINumber isnt unique EmployeeCode:" + EmployeeLinqNICheck.EmployeeCode.ToString)
                                Validatoin = Validatoin + "NiNumber ¦ "
                                NINumberTextEdit.Focus()
                            Case Else
                                MsgBox("NINumber isnt unique EmployeeCode:" + EmployeeLinqNICheck.EmployeeCode.ToString)
                                Validatoin = Validatoin + "NiNumber ¦ "
                                NINumberTextEdit.Focus()
                        End Select



                    End If
                End If
            End If

            If NINumberTextEdit.Text = "" Then
                Validatoin = Validatoin + "NiNumber ¦ "
            End If
            If SchemeIDSpinEdit.Text = "" Then
                Validatoin = Validatoin + "SchemeID ¦ "
            End If
        
         
            If BranchIDSpinEdit.Text = "" Then
                Validatoin = Validatoin + "Branch ¦ "
            End If
            If TitleTextEdit.Text = "" Then
                Validatoin = Validatoin + "Title ¦ "
            End If
            If ForenameTextEdit.Text = "" Then
                Validatoin = Validatoin + "Forename ¦ "
            End If
            If SurnameTextEdit.Text = "" Then
                Validatoin = Validatoin + "Surname ¦ "
            End If
            If Address1TextEdit.Text = "" Then
                Validatoin = Validatoin + "Address1 ¦ "
            End If
            If TownTextEdit.Text = "" Then
                Validatoin = Validatoin + "Town/City ¦ "
            End If
            If CountyTextEdit.Text = "" Then
                Validatoin = Validatoin + "County ¦ "
            End If
            If PostCodeTextEdit.Text = "" Then
                Validatoin = Validatoin + "PostCode ¦ "
            End If
            If TaxCategoryTimeEdit.Text = "" Then
                Validatoin = Validatoin + "TaxCat ¦ "
            End If
            If IsNumeric(CoRegistrationNumberTextEdit.Text) = False And CoRegistrationNumberTextEdit.Text <> "" Then
                Validatoin = Validatoin + "CoRegNumber is not a number ¦ "

            End If
            If IsNumeric(VatNumberTextEdit.Text) = False And VatNumberTextEdit.Text <> "" Then
                Validatoin = Validatoin + "VATNumber is not a number ¦ "

            End If

            If Validatoin <> "The following fields are mandatory; " And Validatoinchoice <> "The following fields are Invalid; " Then
                Throw New Exception(String.Format(Validatoin + Environment.NewLine + Validatoinchoice))
            End If
            If Validatoin <> "The following fields are mandatory; " And Validatoinchoice = "The following fields are Invalid; " Then
                Throw New Exception(Validatoin)
            End If
            If Validatoin = "The following fields are mandatory; " And Validatoinchoice <> "The following fields are Invalid; " Then
                Throw New Exception(Validatoinchoice)
            End If
            If EmployeeIDSpinEdit.Text > 0 Then



                If StatusTextEdit.Text <> "TOT" Then

                    Select Case SystemTypeTextEdit.Text

                        Case "R"


                        Case Else
                            
                            Dim updatestatusstr As String = "   Update Employees set   SystemType = " + "'R'" + " WHERE(EmployeeID = " + EmployeeIDSpinEdit.ToString + ")"
                            adSQLAdapter2 = New SqlDataAdapter(updatestatusstr, Main.con)
                            If Dset.Tables("UpdateEmployee") IsNot Nothing Then
                                Dset.Tables("UpdateEmployee").Clear()
                            End If
                            adSQLAdapter2.Fill(Dset, "UpdateEmployee")


                    End Select


                End If
            End If
            Me.Validate()
            Me.EmployeesBranchFilterBindingSource.EndEdit()
            Me.EmployeesBranchFilterTableAdapter.Update(Me.LexiconRecManagerDataSet.EmployeesBranchFilter)



        Catch ex As Exception

            MsgBox(ex.Message.ToString, MsgBoxStyle.Exclamation)

        End Try

       
    End Sub
    Dim Dset2 As New DataTable
    Dim da2 As SqlDataAdapter

    Private Sub Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.LexiconRecManagerDataSet.Employees)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Schemes' table. You can move, or remove it, as needed.
        Me.SchemesTableAdapter.Fill(Me.LexiconRecManagerDataSet.Schemes)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.LexiconRecManagerDataSet.Branch)
        Dim asdfs As String = GetSecurityInfo("Employees", "Lexicon")
        BranchBindingSource.Filter = "BranchID in (" + asdfs + ")"

        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Employees' table. You can move, or remove it, as needed.


    End Sub
    Public Function GetSecurityInfo(area As String, application As String)
        da2 = New SqlDataAdapter("SELECT isnull(SUBSTRING((SELECT        ',' + CAST(BranchuserSecurity.SecurityBranch AS nvarchar(MAX)) FROM Users INNER JOIN BranchUserSecurity ON Users.UserID = BranchUserSecurity.UserID INNER JOIN Applications ON BranchUserSecurity.ApplicationID = Applications.ApplicationId INNER JOIN ApplicationAreas ON BranchUserSecurity.ApplicationArea = ApplicationAreas.ApplicationAreaID  WHERE   (Applications.Application = '" + application + "') and (ApplicationAreas.ApplicationArea = '" + area + "') and  (Users.DomainUserID = '" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString() + "') FOR XML PATH('')),2,200000),0) AS CSV ", Main.con)
        If Dset2 IsNot Nothing Then
            Dset2.Clear()
        End If
        da2.Fill(Dset2)
        Return Dset2.Rows(0)(0).ToString()


    End Function
    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

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

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpEdit1.EditValueChanged
        Me.EmployeesBranchFilterTableAdapter.Fill(Me.LexiconRecManagerDataSet.EmployeesBranchFilter, CType(LookUpEdit1.EditValue, Long))
    End Sub

    Private Sub FillToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub RefAvailable1CheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles RefAvailable1CheckEdit.CheckedChanged

    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        Me.EmployeeSelect1TableAdapter.Fill(Me.LexiconRecManagerDataSet.EmployeeSelect1, CType(EmployeesBranchFilterBindingSource.Current("EmployeeID").ToString, Long))

        Select Case StatusTextEdit.Text
            Case "Blacklisted"
                StatusTextEdit.Enabled = False
            Case "N/S"
                StatusTextEdit.Enabled = False
            Case Else
                StatusTextEdit.Enabled = True
        End Select
        Select Case SystemTypeTextEdit.Text
            Case "R"
                lblStatus.Text = "Status: Registered"
                lblStatus.ForeColor = Color.Red
            Case "P"
                lblStatus.Text = "Status: Processed/Checked"
                lblStatus.ForeColor = Color.Orange
            Case "C"
                lblStatus.Text = "Status: Completed"
                lblStatus.ForeColor = Color.Green
        End Select
        If SchemeIDSpinEdit.EditValue = 5 Then
            LayoutControlGroup11.Visibility = True


        Else

            LayoutControlGroup11.Visibility = False
        End If
        If GetSecurityInfo2("EmployeesHeadOffice", "Lexicon") <> 0 Then
        Else
            NINumberTextEdit.ReadOnly = True
        End If

        If lblStatus.Text = "Status: New" Then
            DateRegisteredDateEdit.Enabled = True

        Else
            DateRegisteredDateEdit.Enabled = False

        End If
        If GetSecurityInfo2("EmployeesHeadOffice", "Lexicon") <> 0 Then
            StatusTextEdit.Enabled = True
            StatusReasonTextEdit.ReadOnly = False

        Else
            Select Case StatusTextEdit.Text
                Case "Archive"
                    If LastWorkedDateDateEdit.Text > DateAdd(DateInterval.Month, -6, Now()) Then
                        StatusTextEdit.Enabled = True
                        StatusReasonTextEdit.ReadOnly = False
                    Else
                        StatusTextEdit.Enabled = False
                        StatusReasonTextEdit.ReadOnly = True

                    End If
                Case "N/S"
                    StatusTextEdit.Enabled = False
                    StatusReasonTextEdit.ReadOnly = True

                Case "Blacklisted"
                    StatusTextEdit.Enabled = False
                    StatusReasonTextEdit.ReadOnly = True


                Case "TOT"
                    StatusTextEdit.Enabled = True
                    StatusReasonTextEdit.ReadOnly = False

                Case Else
                    StatusTextEdit.Enabled = True
                    StatusReasonTextEdit.ReadOnly = False

            End Select


        End If
    End Sub

    Private Sub SchemeIDSpinEdit_EditValueChanged(sender As Object, e As EventArgs) Handles SchemeIDSpinEdit.EditValueChanged
        If IsDBNull(SchemeIDSpinEdit.EditValue) = False Then


            If SchemeIDSpinEdit.EditValue = 5 Then
                'TabControl1.TabPages.(TPLTDCompanyContratorDetails)
                LayoutControlGroup11.Visibility = True


            Else

                LayoutControlGroup11.Visibility = False




            End If
        Else
            LayoutControlGroup11.Visibility = False
        End If
    End Sub

    Private Sub BranchIDSpinEdit_EditValueChanged(sender As Object, e As EventArgs) Handles BranchIDSpinEdit.EditValueChanged
        Try
          
            If BranchIDSpinEdit.Text = "" Then
                MsgBox("Invalid Branch Selection")
            Else

                Main.con.Open()

                If EmployeeCodeTextEdit.Text = "" Then


                    adSQLAdapter2 = New SqlDataAdapter("DECLARE @RC int DECLARE @ID bigint DECLARE @Code nvarchar(30) EXECUTE  [dbo].[CFN_GetNextBranchNumber] " + BranchIDSpinEdit.EditValue + "  ,@Code OUTPUT   select @Code", Main.con)
                    If Dset.Tables("EmployeeCode") IsNot Nothing Then
                        Dset.Tables("EmployeeCode").Clear()
                    End If
                    adSQLAdapter2.Fill(Dset, "EmployeeCode")




                    ' cmd.ExecuteNonQuery()
                    EmployeeCodeTextEdit.Text = Dset.Tables("EmployeeCode").Rows(0)(0).ToString()
                End If

            End If
        Catch ex As Exception



        Finally
            Main.con.Close()
        End Try

    End Sub
End Class