Imports System.Windows.Forms
Imports System.Data.SqlClient
'Copyright 2012 Craig Wright
'Redistribution and use in source and binary forms, with or without 'modification, are permitted provided that the following conditions 'are met 

'1. Redistributions of source code must retain the above copyright 'notice, this list of conditions and the following disclaimer.
'2. Redistributions in binary form must reproduce the above copyright 'notice, this list of conditions and the following disclaimer in the 'documentation and/or other materials provided with the distribution.

'THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS '"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT'LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 'FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 'COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 'INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 'BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; 'LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER 'CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT 'LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN 'ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 'POSSIBILITY OF SUCH DAMAGE.
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
