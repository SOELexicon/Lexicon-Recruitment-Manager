Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class SearchDialog
    Public SearchText As String
    Dim dtTable As New DataTable()
    Public Sub sQLsEARCH(ParamStr As String, sql As String)


        Try
            'Dim sql As String = ("SELECT       companyId, Company, Site, Address, Address2, Address3, Town, County FROM Sites where Company like '%" + ParamStr + "%'")
            Main.con.Open()

            Dim adSQLAdapter As New SqlDataAdapter(sql, Main.con)
            Dim commands As New SqlCommandBuilder(adSQLAdapter)


            'POPULATE THE DATATABLE WITH DATA.
            adSQLAdapter.Fill(dtTable)

            GridControl1.DataSource = dtTable



        Catch SqlError As System.Data.SqlTypes.SqlTypeException
            MessageBox.Show("ERROR WITH THE SQL STATEMENT")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR2", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Main.con.Close()

        End Try
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Try

            'SearchText = Me.DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
            If GridView1.Columns("companyid") IsNot Nothing Then
                SearchText = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "companyid")
            Else
                SearchText = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "EmployeeID")

            End If

            Me.DialogResult = System.Windows.Forms.DialogResult.OK


        Catch ex As Exception
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()

        End Try



    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub DataGridView1_CellContentDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    SearchText = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "companyid")
    '    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    'End Sub
    Private Sub DoRowDoubleClick(ByVal view As GridView, ByVal pt As Point)
        Dim info As GridHitInfo = view.CalcHitInfo(pt)
        '  If info.InRow OrElse info.InRowCell Then
        '    SearchText = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "companyid")
        If GridView1.Columns("companyid") IsNot Nothing Then
            SearchText = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "companyid")
        Else
            SearchText = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "EmployeeID")

        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        ' End If
    End Sub
    Private Sub DataGrid1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Dim view As GridView = CType(sender, GridView)
        Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
        DoRowDoubleClick(view, pt)
    End Sub
End Class
