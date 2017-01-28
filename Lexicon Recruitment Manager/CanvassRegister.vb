Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.SqlClient
'Copyright 2012 Craig Wright
'Redistribution and use in source and binary forms, with or without 'modification, are permitted provided that the following conditions 'are met 

'1. Redistributions of source code must retain the above copyright 'notice, this list of conditions and the following disclaimer.
'2. Redistributions in binary form must reproduce the above copyright 'notice, this list of conditions and the following disclaimer in the 'documentation and/or other materials provided with the distribution.

'THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS '"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT'LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 'FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 'COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 'INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 'BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; 'LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER 'CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT 'LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN 'ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 'POSSIBILITY OF SUCH DAMAGE.
Public Class CanvassRegister



    Private Sub CanvassRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Branch' table. You can move, or remove it, as needed.
        CanvassRegisterBindingSource.Filter = "BranchID in (" + GetSecurityInfo2("CanvassRegister", "Lexicon") + ")"
        BranchBindingSource.Filter = "BranchID in (" + GetSecurityInfo2("CanvassRegister", "Lexicon") + ")"
        BranchBindingSource1.Filter = "BranchID in (" + GetSecurityInfo2("CanvassRegister", "Lexicon") + ")"

        Me.BranchTableAdapter.Fill(Me.LexiconRecManagerDataSet.Branch)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.CanvassJobCatContacts' table. You can move, or remove it, as needed.
        Me.CanvassJobCatContactsTableAdapter.Fill(Me.LexiconRecManagerDataSet.CanvassJobCatContacts)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.CanvassJobCats' table. You can move, or remove it, as needed.
        Me.CanvassJobCatsTableAdapter.Fill(Me.LexiconRecManagerDataSet.CanvassJobCats)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.CanvassRegister' table. You can move, or remove it, as needed.
        Me.CanvassRegisterTableAdapter.Fill(Me.LexiconRecManagerDataSet.CanvassRegister)
        'TODO: This line of code loads data into the 'LexiconManagemnetToolsDataSet.Consultants' table. You can move, or remove it, as needed.
        Me.ConsultantsTableAdapter.Fill(Me.LexiconManagemnetToolsDataSet.Consultants)

        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()

    End Sub



    Private Sub PostcodeTextBox_Leave(sender As Object, e As EventArgs) Handles PostcodeTextEdit.Leave
        Try
            If CanvassIDSpinEdit.Text <= 0 Then
                Dim dc As New DataClasses1DataContext
                Dim PostcodeLinqCheck = (From CanvassPostcode In dc.GetTable(Of LinqCanvassRegisterLookup)() Where CanvassPostcode.Postcode = Replace(Me.PostcodeTextEdit.Text, " ", "")).ToList


                DialogPostcodeCheck.GridControl1.DataSource = PostcodeLinqCheck

                Dim result As DialogResult = DialogPostcodeCheck.ShowDialog(Me)

                If result = Windows.Forms.DialogResult.OK Then
                    CanvassRegisterBindingSource.RemoveCurrent()

                End If
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub GridView1_RowStyle(ByVal sender As Object, _
ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim category As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Archived"))
            Dim category2 As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Division"))

            If category = "Checked" Then
                e.Appearance.BackColor = Color.OrangeRed
                e.Appearance.BackColor2 = Color.OrangeRed
            Else
                If category2 = "Industrial" Then

                    e.Appearance.BackColor = Color.MediumSeaGreen
                    e.Appearance.BackColor2 = Color.MediumSeaGreen
                Else
                    e.Appearance.BackColor = Color.MediumSlateBlue
                    e.Appearance.BackColor2 = Color.MediumSlateBlue
                End If
            End If

        End If
    End Sub

    Private Sub DataNavigator1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.EndEdit Then
            If RatesCodeWrittenOnCardCheckEdit.Checked = True Then


                DateLastModifiedTextBox1.Text = Now()
                LastModifiedUserTextEdit.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString()
                If CanvassIDSpinEdit.Text <= 0 Then
                    DateCreatedTextBox1.Text = Now()
                    CreatedByTextEdit.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString()
                End If
                Me.Validate()
                Me.CanvassRegisterBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.LexiconRecManagerDataSet)
                MsgBox("Saved")
            Else
                MsgBox("Unable to save - rates code written on card box is not ticked, Ensure that the card has the rates code on and then tick this box in order to save", MsgBoxStyle.Critical)
                RatesCodeWrittenOnCardCheckEdit.Focus()
            End If
        End If
    End Sub

    Private Sub DataNavigator2_ButtonClick(sender As Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles DataNavigator2.ButtonClick, DataNavigator1.ButtonClick
        If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.EndEdit Then

            If RatesCodeWrittenOnCardCheckEdit.Checked = True Then


                DateLastModifiedTextBox1.Text = Now()
                LastModifiedUserTextEdit.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString()
                If CanvassIDSpinEdit.Text <= 0 Then
                    DateCreatedTextBox1.Text = Now()
                    CreatedByTextEdit.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString()
                End If
                Try


                    Me.Validate()
                    Me.CanvassJobCatContactsBindingSource.EndEdit()
                    Me.CanvassRegisterBindingSource.EndEdit()
                    Me.CanvassRegisterTableAdapter.Update(Me.LexiconRecManagerDataSet.CanvassRegister)

                    Me.CanvassJobCatContactsTableAdapter.Update(Me.LexiconRecManagerDataSet.CanvassJobCatContacts)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                MsgBox("Saved")
            Else
                MsgBox("Unable to save - rates code written on card box is not ticked, Ensure that the card has the rates code on and then tick this box in order to save", MsgBoxStyle.Critical)
                RatesCodeWrittenOnCardCheckEdit.Focus()
            End If
        End If

    End Sub

    Private Sub DataNavigator3_ButtonClick(sender As Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles DataNavigator3.ButtonClick
        If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.EndEdit Then

            If CanvassJobCatIdSpinEdit.Text = "" Then
            Else

                QuotedDateDateEdit.DateTime = Now()
            End If
            Me.Validate()
            Me.CanvassJobCatsBindingSource.EndEdit()
            Me.CanvassJobCatsTableAdapter.Update(Me.LexiconRecManagerDataSet.CanvassJobCats)
        End If

    End Sub

    Private Sub LookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpEdit1.EditValueChanged
        If LookUpEdit1.EditValue IsNot Nothing Then
            'BranchBindingSource.Filter = "BranchID = " + LookUpEdit1.EditValue.ToString
            CanvassRegisterBindingSource.Filter = "BranchID = " + LookUpEdit1.EditValue.ToString

        Else
            'BranchBindingSource.Filter = "BranchID = 0"
            CanvassRegisterBindingSource.Filter = "BranchID = 0"

        End If
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

End Class