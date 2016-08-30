Public Class Security 

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.UsersTableAdapter.Update(Me.LexiconRecManagerDataSet.Users)
      

    End Sub

    Private Sub Security_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.ApplicationAreas' table. You can move, or remove it, as needed.
        Me.ApplicationAreasTableAdapter.Fill(Me.LexiconRecManagerDataSet.ApplicationAreas)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Application' table. You can move, or remove it, as needed.
        Me.ApplicationTableAdapter.Fill(Me.LexiconRecManagerDataSet.Application)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.BranchUserSecurity' table. You can move, or remove it, as needed.
        Me.BranchUserSecurityTableAdapter.Fill(Me.LexiconRecManagerDataSet.BranchUserSecurity)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.LexiconRecManagerDataSet.Branch)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.LexiconRecManagerDataSet.Users)
        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()

    End Sub

    Private Sub ApplicationIDSpinEdit_EditValueChanged(sender As Object, e As EventArgs) Handles ApplicationIDSpinEdit.EditValueChanged
        If ApplicationIDSpinEdit.EditValue IsNot Nothing Then
            If ApplicationIDSpinEdit.EditValue.ToString <> "" Then

                ApplicationAreasBindingSource.Filter = "ApplicationID = " + ApplicationIDSpinEdit.EditValue.ToString
            End If
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.BranchUserSecurityBindingSource.EndEdit()
        Me.BranchUserSecurityTableAdapter.Update(Me.LexiconRecManagerDataSet.BranchUserSecurity)
    End Sub
End Class