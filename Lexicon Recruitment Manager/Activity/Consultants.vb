Public Class Consultants 

    Private Sub ConsultantsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ConsultantsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ConsultantsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LexiconManagemnetToolsDataSet)

    End Sub

    Private Sub Consultants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LexiconManagemnetToolsDataSet.Consultants' table. You can move, or remove it, as needed.
        Me.ConsultantsTableAdapter.Fill(Me.LexiconManagemnetToolsDataSet.Consultants)
        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()

    End Sub
End Class