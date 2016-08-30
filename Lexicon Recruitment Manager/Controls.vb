Public Class Controls 

    Private Sub ControlsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ControlsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ControlsBindingSource.EndEdit()
        Me.ControlsTableAdapter.Update(Me.LexiconRecManagerDataSet.Controls)

    End Sub

    Private Sub Controls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.Controls' table. You can move, or remove it, as needed.
        Me.ControlsTableAdapter.Fill(Me.LexiconRecManagerDataSet.Controls)

        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()
    End Sub
End Class