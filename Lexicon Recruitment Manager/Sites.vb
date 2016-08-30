Partial Class Sites
    Partial Class JobCategoryDataTable

        Private Sub JobCategoryDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.RulesorDetails3Column.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class HolidayEmployeeDropdownDataTable

        Private Sub HolidayEmployeeDropdownDataTable_HolidayEmployeeDropdownRowChanging(sender As Object, e As HolidayEmployeeDropdownRowChangeEvent) Handles Me.HolidayEmployeeDropdownRowChanging

        End Sub

    End Class

    Partial Class PlanDataTable

        Private Sub PlanDataTable_PlanRowChanging(sender As Object, e As PlanRowChangeEvent) Handles Me.PlanRowChanging

        End Sub

    End Class

End Class

Namespace SitesTableAdapters
    
    Partial Public Class HolidaysTableAdapter
    End Class
End Namespace
