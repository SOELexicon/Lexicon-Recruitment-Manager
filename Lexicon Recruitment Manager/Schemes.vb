Public Class Schemes 

    Private Sub SchemesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SchemesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SchemesBindingSource.EndEdit()
        Me.SchemesTableAdapter.Update(Me.LexiconRecManagerDataSet.Schemes)

    End Sub

    Private Sub Schemes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Schemes' table. You can move, or remove it, as needed.
        Me.SchemesTableAdapter.Fill(Me.LexiconRecManagerDataSet.Schemes)
        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()

    End Sub
End Class