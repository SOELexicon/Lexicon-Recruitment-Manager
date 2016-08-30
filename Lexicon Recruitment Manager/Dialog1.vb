Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class Dialog1
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
            DataGridView1.DataSource = dtTable



        Catch SqlError As System.Data.SqlTypes.SqlTypeException
            MessageBox.Show("ERROR WITH THE SQL STATEMENT")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)



        Finally
            Main.con.Close()

        End Try
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Try
          
                SearchText = Me.DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
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

    Private Sub DataGridView1_CellContentDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        SearchText = Me.DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub
End Class
