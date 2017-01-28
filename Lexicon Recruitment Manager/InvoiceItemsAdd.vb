Imports System.Data.SqlClient
'Copyright 2012 Craig Wright
'Redistribution and use in source and binary forms, with or without 'modification, are permitted provided that the following conditions 'are met 

'1. Redistributions of source code must retain the above copyright 'notice, this list of conditions and the following disclaimer.
'2. Redistributions in binary form must reproduce the above copyright 'notice, this list of conditions and the following disclaimer in the 'documentation and/or other materials provided with the distribution.

'THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS '"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT'LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 'FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 'COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 'INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 'BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; 'LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER 'CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT 'LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN 'ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 'POSSIBILITY OF SUCH DAMAGE.
Public Class InvoiceItemsAdd
    Dim da As SqlDataAdapter
    Dim Dset As New DataSet
    Dim adSQLAdapter2 As SqlDataAdapter

    Private Sub PlanInvoiceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()

        Me.TableAdapterManager.UpdateAll(Me.LexiconRecManagerDataSet)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PlanInvoiceAddItemsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PlanInvoiceAddItemsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PlanInvoiceAddItemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LexiconRecManagerDataSet)

    End Sub

    Private Sub FillToolStripButton_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.PlanInvoiceAddItemsTableAdapter.Fill(Me.LexiconRecManagerDataSet.PlanInvoiceAddItems, CType(CompanyToolStripTextBox.SelectedValue, Integer), CType(BranchIdToolStripTextBox.SelectedValue, Long), CType(PlanTypeIdToolStripTextBox.SelectedValue, Long), WeekendingdateToolStripTextBox.Text)

            adSQLAdapter2 = New SqlDataAdapter("   EXECUTE  [dbo].[GenerateInvoice]      " + CType(CompanyToolStripTextBox.SelectedValue, Integer).ToString + ", " + CType(BranchIdToolStripTextBox.SelectedValue, Long).ToString + ", " + CType(PlanTypeIdToolStripTextBox.SelectedValue, Long).ToString() + ", '" + WeekendingdateToolStripTextBox.Text + "'", Main.con)
            If Dset.Tables("LockPlan") IsNot Nothing Then
                Dset.Tables("LockPlan").Clear()
            End If
            adSQLAdapter2.Fill(Dset, "LockPlan")

               Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label3.Click, Label4.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.PlanTypes' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.SitesOnPlanWithoutInvoices' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.LexiconRecManagerDataSet.Branch)

    End Sub

    Private Sub CompanyToolStripTextBox_TextChanged(sender As Object, e As EventArgs) Handles CompanyToolStripTextBox.TextChanged
        Me.PlanItemsWithoutInvoicesWeDateTableAdapter.Fill(Me.LexiconRecManagerDataSet.PlanItemsWithoutInvoicesWeDate, CType(PlanTypeIdToolStripTextBox.SelectedValue, Long), CType(BranchIdToolStripTextBox.SelectedValue, Long), CType(CompanyToolStripTextBox.SelectedValue, Integer))

    End Sub

    Private Sub PlanTypeIdToolStripTextBox_TextChanged(sender As Object, e As EventArgs) Handles PlanTypeIdToolStripTextBox.TextChanged

        Me.SitesOnPlanWithoutInvoicesTableAdapter.Fill(Me.LexiconRecManagerDataSet.SitesOnPlanWithoutInvoices, CType(PlanTypeIdToolStripTextBox.SelectedValue, Long), BranchIdToolStripTextBox.SelectedValue.ToString)
    End Sub
End Class