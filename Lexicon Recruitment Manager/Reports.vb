Public Class Reports

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        ' ListView1.SelectedItems.Item(0).ToString()
        Try

    
            'Select Case ListView1.SelectedItems.Item(0).ToString()
            '    Case "ListViewItem: {Plans}"
            '        Main.openReportPlanForm()
            '    Case "ListViewItem: {Plan Follow Up}"
            '        Main.openReportPlanFollowUpForm()
            '    Case "ListViewItem: {Confirmation Of Rates}"
            '        Main.openConfirmationOfRatesForm()
            '    Case "ListViewItem: {Plan Validation}"

            '        Main.openReportPlanValidationForm()
            '    Case "ListViewItem: {Block}"
            '        Main.openReportBlockTimeSheetForm()
            '    Case "ListViewItem: {Scheme}"
            '        Main.openReportPlanSchemeCosting()
            '    Case "ListViewItem: {Client}"

            '        Main.openReportsPlanClientCostingForm()
            '    Case "ListViewItem: {Net Margin Report}"
            '        Main.openReportNetMargin()
            'End Select
        Catch ex As Exception

        End Try
    End Sub
    
End Class