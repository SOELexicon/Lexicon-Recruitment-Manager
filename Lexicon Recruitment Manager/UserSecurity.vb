Public Class UserSecurity
    'Copyright 2012 Craig Wright
    'Redistribution and use in source and binary forms, with or without     'modification, are permitted provided that the following conditions     'are met 

    '1. Redistributions of source code must retain the above copyright     'notice, this list of conditions and the following disclaimer.
    '2. Redistributions in binary form must reproduce the above copyright     'notice, this list of conditions and the following disclaimer in the     'documentation and/or other materials provided with the distribution.

    'THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS     '"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT    'LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS     'FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE     'COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT,     'INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING,     'BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;     'LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER     'CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT     'LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN     'ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE     'POSSIBILITY OF SUCH DAMAGE.
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