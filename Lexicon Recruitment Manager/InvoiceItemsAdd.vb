Imports System.Data.SqlClient
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