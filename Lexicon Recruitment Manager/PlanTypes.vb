Public Class PlanTypes 

    Private Sub PlanTypesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PlanTypesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PlanTypesBindingSource.EndEdit()
        Me.PlanTypesTableAdapter.Update(Me.LexiconRecManagerDataSet.PlanTypes)

    End Sub

    Private Sub PlanTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.PlanTypes' table. You can move, or remove it, as needed.
        Me.PlanTypesTableAdapter.Fill(Me.LexiconRecManagerDataSet.PlanTypes)

        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()
    End Sub
End Class