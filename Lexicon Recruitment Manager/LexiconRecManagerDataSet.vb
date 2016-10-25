

Partial Public Class LexiconRecManagerDataSet



    Partial Class Plan1DataTable

        Private Sub Plan1DataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.RateColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class Plan2PerRecordDataTable

        Private Sub Plan2PerRecordDataTable_Plan2PerRecordRowChanging(sender As Object, e As Plan2PerRecordRowChangeEvent) Handles Me.Plan2PerRecordRowChanging

        End Sub

    End Class

    Partial Class Rpt_PlanClientCostingDataTable

        Private Sub Rpt_PlanClientCostingDataTable_Rpt_PlanClientCostingRowChanging(sender As Object, e As Rpt_PlanClientCostingRowChangeEvent) Handles Me.Rpt_PlanClientCostingRowChanging

        End Sub

    End Class

    Partial Class BlockTimesheetDataTable

        Private Sub BlockTimesheetDataTable_BlockTimesheetRowChanging(sender As Object, e As BlockTimesheetRowChangeEvent) Handles Me.BlockTimesheetRowChanging

        End Sub

    End Class

    Partial Class Rpt_PlanValidationDataTable

        Private Sub Rpt_PlanValidationDataTable_Rpt_PlanValidationRowChanging(sender As Object, e As Rpt_PlanValidationRowChangeEvent) Handles Me.Rpt_PlanValidationRowChanging

        End Sub

        Private Sub Rpt_PlanValidationDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.BranchNameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class Rpt_ConfirmationOfRates1DataTable

        Private Sub Rpt_ConfirmationOfRates1DataTable_Rpt_ConfirmationOfRates1RowChanging(sender As Object, e As Rpt_ConfirmationOfRates1RowChangeEvent) Handles Me.Rpt_ConfirmationOfRates1RowChanging

        End Sub

    End Class

    Partial Class DataTable2DataTable

        Private Sub DataTable2DataTable_DataTable2RowChanging(sender As Object, e As DataTable2RowChangeEvent) Handles Me.DataTable2RowChanging

        End Sub

    End Class

    Partial Class Rpt_CostingsDataTable

        Private Sub Rpt_CostingsDataTable_Rpt_CostingsRowChanging(sender As Object, e As Rpt_CostingsRowChangeEvent) Handles Me.Rpt_CostingsRowChanging

        End Sub

    End Class

    Partial Class PlanDataTable

    End Class

    Partial Class PlanViewDataTable

        Private Sub PlanViewDataTable_PlanViewRowChanging(sender As Object, e As PlanViewRowChangeEvent) Handles Me.PlanViewRowChanging

        End Sub

    End Class

    Partial Class SitesDataTable

        Private Sub SitesDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.LtdColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class


End Class

Namespace LexiconRecManagerDataSetTableAdapters
    
    Partial Class CanvassRegisterTableAdapter

    End Class

    Partial Class BranchTableAdapter

    End Class

    Partial Class Rpt_CostingsTableAdapter

    End Class

    Partial Class PlanTableAdapter

    End Class

    Partial Class SitesTableAdapter

    End Class

    Partial Public Class JobCategoryTableAdapter
    End Class
End Namespace
