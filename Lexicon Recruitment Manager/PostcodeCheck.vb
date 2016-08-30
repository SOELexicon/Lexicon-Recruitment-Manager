Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Public Class DialogPostcodeCheck

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub GridView1_RowStyle(ByVal sender As Object, _
ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim category As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Archived"))
            Dim category2 As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Division"))

            If category = "Checked" Then
                e.Appearance.BackColor = Color.OrangeRed
                e.Appearance.BackColor2 = Color.OrangeRed
            Else
                If category2 = "Industrial" Then

                    e.Appearance.BackColor = Color.MediumSeaGreen
                    e.Appearance.BackColor2 = Color.MediumSeaGreen
                Else
                    e.Appearance.BackColor = Color.MediumSlateBlue
                    e.Appearance.BackColor2 = Color.MediumSlateBlue
                End If
            End If

        End If
    End Sub
End Class
