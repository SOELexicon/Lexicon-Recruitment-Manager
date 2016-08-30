Public Class Branchs 

    Private Sub BranchBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BranchBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BranchBindingSource.EndEdit()
        Me.BranchTableAdapter.Update(Me.LexiconRecManagerDataSet.Branch)

    End Sub

    Private Sub Branchs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.LexiconRecManagerDataSet.Branch)
        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()

    End Sub
End Class