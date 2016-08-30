Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class CustomerContact
    Public bigint As Int64
    Public bigint2 As Int64

    Public ident As Integer
    Dim adSQLAdapter2 As SqlDataAdapter
    Dim Dset As New DataSet
    Public Sub FetchData()
     
        Select ident

            Case 0


            Case 1

                adSQLAdapter2 = New SqlDataAdapter("select * from [dbo].[CompanyContacts] where ContactID ='" + bigint2.ToString + "'", Main.con)
                adSQLAdapter2.Fill(Dset, "CompanyContacts")
                Dset.Tables("CompanyContacts").Rows(0)(1).ToString()
                Title.Text = Dset.Tables("CompanyContacts").Rows(0)(2).ToString()
                Forename.Text = Dset.Tables("CompanyContacts").Rows(0)(3).ToString()
                Initials.Text = Dset.Tables("CompanyContacts").Rows(0)(4).ToString()

                Surname.Text = Dset.Tables("CompanyContacts").Rows(0)(5).ToString()
                Department.Text = Dset.Tables("CompanyContacts").Rows(0)(6).ToString()
                JobTitle.Text = Dset.Tables("CompanyContacts").Rows(0)(7).ToString()
                Telephone.Text = Dset.Tables("CompanyContacts").Rows(0)(8).ToString()
                Email.Text = Dset.Tables("CompanyContacts").Rows(0)(9).ToString()
                Fax.Text = Dset.Tables("CompanyContacts").Rows(0)(10).ToString()
                DateLastContact.Text = Dset.Tables("CompanyContacts").Rows(0)(11).ToString()
                ContactedBy.Text = Dset.Tables("CompanyContacts").Rows(0)(12).ToString()
                Address.Text = Dset.Tables("CompanyContacts").Rows(0)(13).ToString()
                Town.Text = Dset.Tables("CompanyContacts").Rows(0)(14).ToString()
                County.Text = Dset.Tables("CompanyContacts").Rows(0)(15).ToString()
                Country.Text = Dset.Tables("CompanyContacts").Rows(0)(16).ToString()
                PostalCode.Text = Dset.Tables("CompanyContacts").Rows(0)(17).ToString()
                Position.Text = Dset.Tables("CompanyContacts").Rows(0)(18).ToString()
                CostCentre.Text = Dset.Tables("CompanyContacts").Rows(0)(19).ToString()
                Category.Text = Dset.Tables("CompanyContacts").Rows(0)(20).ToString()
                Category2.Text = Dset.Tables("CompanyContacts").Rows(0)(21).ToString()
                Telephone2.Text = Dset.Tables("CompanyContacts").Rows(0)(22).ToString()
                If Dset.Tables("CompanyContacts").Rows(0)(23).ToString() = "" Then
                    Active.Checked = True
                Else
                    Active.Checked = Dset.Tables("CompanyContacts").Rows(0)(23).ToString()
                End If

                Notes.Text = Dset.Tables("CompanyContacts").Rows(0)(24).ToString()
        End Select



    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Select Case ident
            Case 0
                ClientContactAdd()
            Case 1

                ClientContactModify()
        End Select
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Public Sub ClientContactAdd()
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = Main.con
            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "dbo.ClientContactAdd"

            cmd.Parameters.Add("@ContactID", SqlDbType.BigInt).Value = 0
            cmd.Parameters.Add("@CompanyId", SqlDbType.BigInt).Value = bigint
            cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = Title.Text
            cmd.Parameters.Add("@Forename", SqlDbType.NVarChar).Value = Forename.Text
            cmd.Parameters.Add("@Initials", SqlDbType.NVarChar).Value = Initials.Text
            cmd.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = Surname.Text
            cmd.Parameters.Add("@department", SqlDbType.NVarChar).Value = Department.Text
            cmd.Parameters.Add("@JobTitle", SqlDbType.NVarChar).Value = JobTitle.Text
            cmd.Parameters.Add("@Telephone", SqlDbType.NVarChar).Value = Telephone.Text
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email.Text
            cmd.Parameters.Add("@Fax", SqlDbType.NVarChar).Value = Fax.Text
            cmd.Parameters.Add("@DateLastContact", SqlDbType.NVarChar).Value = DateLastContact.Text
            cmd.Parameters.Add("@ContactedBy", SqlDbType.NVarChar).Value = ContactedBy.Text
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address.Text
            cmd.Parameters.Add("@Town", SqlDbType.NVarChar).Value = Town.Text
            cmd.Parameters.Add("@County", SqlDbType.NVarChar).Value = County.Text
            cmd.Parameters.Add("@Country", SqlDbType.NVarChar).Value = Country.Text
            cmd.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = PostalCode.Text
            cmd.Parameters.Add("@Position", SqlDbType.NVarChar).Value = Position.Text
            cmd.Parameters.Add("@CostCentre", SqlDbType.NVarChar).Value = CostCentre.Text
            cmd.Parameters.Add("@Category", SqlDbType.NVarChar).Value = Category.Text
            cmd.Parameters.Add("@Category2", SqlDbType.NVarChar).Value = Category2.Text
            cmd.Parameters.Add("@Telephone2", SqlDbType.NVarChar).Value = Telephone2.Text
            cmd.Parameters.Add("@Active", SqlDbType.Bit).Value = Active.Checked
            cmd.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = Notes.Text




            Main.con.Open()
            cmd.ExecuteNonQuery()



        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Main.con.Close()
        End Try
    End Sub
    Public Sub ClientContactModify()
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = Main.con
            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "dbo.ClientContactAdd"

            cmd.Parameters.Add("@ContactID", SqlDbType.BigInt).Value = bigint2
            cmd.Parameters.Add("@CompanyId", SqlDbType.BigInt).Value = bigint
            cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = Title.Text
            cmd.Parameters.Add("@Forename", SqlDbType.NVarChar).Value = Forename.Text
            cmd.Parameters.Add("@Initials", SqlDbType.NVarChar).Value = Initials.Text
            cmd.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = Surname.Text
            cmd.Parameters.Add("@department", SqlDbType.NVarChar).Value = Department.Text
            cmd.Parameters.Add("@JobTitle", SqlDbType.NVarChar).Value = JobTitle.Text
            cmd.Parameters.Add("@Telephone", SqlDbType.NVarChar).Value = Telephone.Text
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email.Text
            cmd.Parameters.Add("@Fax", SqlDbType.NVarChar).Value = Fax.Text
            cmd.Parameters.Add("@DateLastContact", SqlDbType.NVarChar).Value = DateLastContact.Text
            cmd.Parameters.Add("@ContactedBy", SqlDbType.NVarChar).Value = ContactedBy.Text
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address.Text
            cmd.Parameters.Add("@Town", SqlDbType.NVarChar).Value = Town.Text
            cmd.Parameters.Add("@County", SqlDbType.NVarChar).Value = County.Text
            cmd.Parameters.Add("@Country", SqlDbType.NVarChar).Value = Country.Text
            cmd.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = PostalCode.Text
            cmd.Parameters.Add("@Position", SqlDbType.NVarChar).Value = Position.Text
            cmd.Parameters.Add("@CostCentre", SqlDbType.NVarChar).Value = CostCentre.Text
            cmd.Parameters.Add("@Category", SqlDbType.NVarChar).Value = Category.Text
            cmd.Parameters.Add("@Category2", SqlDbType.NVarChar).Value = Category2.Text
            cmd.Parameters.Add("@Telephone2", SqlDbType.NVarChar).Value = Telephone2.Text
            cmd.Parameters.Add("@Active", SqlDbType.Bit).Value = Active.Checked
            cmd.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = Notes.Text




            Main.con.Open()
            cmd.ExecuteNonQuery()



        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Main.con.Close()
        End Try
    End Sub


    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click, Label9.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, Label22.Click, Label21.Click, Label20.Click, Label19.Click, Label18.Click, Label17.Click, Label16.Click, Label15.Click, Label14.Click, Label13.Click, Label12.Click, Label11.Click, Label10.Click, Label1.Click, Label23.Click

    End Sub

    Private Sub Notes_TextChanged(sender As System.Object, e As System.EventArgs) Handles Notes.TextChanged

    End Sub
End Class
