Public Class UserSecurity

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.LexiconRecManagerDataSet.Branch)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.BranchUserSecurity' table. You can move, or remove it, as needed.
        Me.BranchUserSecurityTableAdapter.Fill(Me.LexiconRecManagerDataSet.BranchUserSecurity)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.LexiconRecManagerDataSet.Users)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Branch' table. You can move, or remove it, as needed.
        Me.PlanTypesTableAdapter.Fill(Me.LexiconRecManagerDataSet2.PlanTypes)
        Me.SchemesTableAdapter.Fill(Me.LexiconRecManagerDataSet3.Schemes)
        Me.ControlsTableAdapter.Fill(Me.LexiconRecManagerDataSet4.Controls)
    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
       

    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.UsersTableAdapter.Update(Me.LexiconRecManagerDataSet.Users)
        Me.BranchUserSecurityTableAdapter.Update(Me.LexiconRecManagerDataSet.BranchUserSecurity)

    End Sub

    Private Sub BranchBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BranchBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BranchBindingSource.EndEdit()
        Me.BranchTableAdapter1.Update(Me.LexiconRecManagerDataSet.Branch)

    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Me.Validate()
        Me.PlanTypesBindingSource.EndEdit()
        Me.PlanTypesTableAdapter.Update(Me.LexiconRecManagerDataSet2.PlanTypes)
    End Sub

    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        Me.Validate()
        Me.SchemesBindingSource1.EndEdit()
        Me.SchemesTableAdapter.Update(Me.LexiconRecManagerDataSet3.Schemes)
    End Sub

    Private Sub ToolStripButton21_Click(sender As Object, e As EventArgs) Handles ToolStripButton21.Click
        Me.Validate()
        Me.ControlsBindingSource.EndEdit()
        Me.ControlsTableAdapter.Update(Me.LexiconRecManagerDataSet4.Controls)
    End Sub

    Private Sub BranchUserSecurityDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BranchUserSecurityDataGridView.CellContentClick

        Dim gr As New DataGridView
        gr = sender
        Select Case e.ColumnIndex
            Case Is > -1
                Select Case gr.Columns(e.ColumnIndex).Name
                    Case "Delete"
                        Me.BranchUserSecurityBindingSource.RemoveCurrent()
                        'adSQLAdapter2 = New SqlDataAdapter("   EXECUTE  [dbo].[ArchivePlan]  " + PlanViewDataGridView.Item(1, PlanViewDataGridView.CurrentRow.Index).Value.ToString() + " ", Main.con)
                        'If Dset.Tables("ArchivePlan") IsNot Nothing Then
                        '    Dset.Tables("ArchivePlan").Clear()
                        'End If
                        'adSQLAdapter2.Fill(Dset, "ArchivePlan")


                End Select
        End Select
    End Sub
End Class