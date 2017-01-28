Imports System.Windows.Forms
Imports System.Data.SqlClient
'Copyright 2012 Craig Wright
'Redistribution and use in source and binary forms, with or without 'modification, are permitted provided that the following conditions 'are met 

'1. Redistributions of source code must retain the above copyright 'notice, this list of conditions and the following disclaimer.
'2. Redistributions in binary form must reproduce the above copyright 'notice, this list of conditions and the following disclaimer in the 'documentation and/or other materials provided with the distribution.

'THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS '"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT'LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 'FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 'COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 'INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 'BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; 'LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER 'CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT 'LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN 'ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 'POSSIBILITY OF SUCH DAMAGE.
Public Class ClientEdit
    Public bigint As Int64
    Public bigint2 As Int64

    Public ident As Integer
    Dim adSQLAdapter2 As SqlDataAdapter
    Dim Dset As New DataSet

    Public Sub ClientContactAdd()
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = Main.con
            cmd.Parameters.Clear()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "dbo.ClientContactAdd"
            cmd.Parameters.Add("@CompanyId", SqlDbType.BigInt).Value = 0
            cmd.Parameters.Add("@Company", SqlDbType.NVarChar).Value = Company.Text

            cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address1.Text
            cmd.Parameters.Add("@Address2", SqlDbType.NVarChar).Value = Address2.Text
            cmd.Parameters.Add("@Address3", SqlDbType.NVarChar).Value = Address3.Text
            cmd.Parameters.Add("@Town", SqlDbType.NVarChar).Value = Town.Text
            cmd.Parameters.Add("@County", SqlDbType.NVarChar).Value = County.Text
            cmd.Parameters.Add("@Country", SqlDbType.NVarChar).Value = Country.Text
            cmd.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = PostalCode.Text
            cmd.Parameters.Add("@Telephone1", SqlDbType.NVarChar).Value = Telephone1.Text
            cmd.Parameters.Add("@Telephone2", SqlDbType.NVarChar).Value = Telephone2.Text
            cmd.Parameters.Add("@Fax", SqlDbType.NVarChar).Value = Fax.Text
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email.Text
            cmd.Parameters.Add("@Bussiness", SqlDbType.NVarChar).Value = Business.Text
            cmd.Parameters.Add("@InvAddress", SqlDbType.NVarChar).Value = InvoiceAddress.Text
            cmd.Parameters.Add("@InvTown", SqlDbType.NVarChar).Value = InvoiceTown.Text
            cmd.Parameters.Add("@InvCounty", SqlDbType.NVarChar).Value = InvoiceCounty.Text
            cmd.Parameters.Add("@InvCountry", SqlDbType.NVarChar).Value = InvoiceCountry.Text
            cmd.Parameters.Add("@InvPostCode", SqlDbType.NVarChar).Value = InvoicePostcode.Text
            cmd.Parameters.Add("@AccountNumber", SqlDbType.NVarChar).Value = AccountNo.Text
            cmd.Parameters.Add("@CompanyRegNumber", SqlDbType.NVarChar).Value = CompanyRegNo.Text
            cmd.Parameters.Add("@ClientsVatRegNo", SqlDbType.NVarChar).Value = VATRegNo.Text
            cmd.Parameters.Add("@Terms", SqlDbType.NVarChar).Value = Terms.Text
            cmd.Parameters.Add("@OrderNumberReq", SqlDbType.NVarChar).Value = OrdernumberReq.Text
            cmd.Parameters.Add("@Ltd", SqlDbType.Bit).Value = Ltd.Checked
            cmd.Parameters.Add("@SpecialInvoiceInstructions", SqlDbType.NVarChar).Value = SpecialInvoiceInstructions.Text




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
            cmd.Parameters.Add("@CompanyId", SqlDbType.BigInt).Value = bigint

            cmd.Parameters.Add("@Company", SqlDbType.NVarChar).Value = Company.Text

            cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address1.Text
            cmd.Parameters.Add("@Address2", SqlDbType.NVarChar).Value = Address2.Text
            cmd.Parameters.Add("@Address3", SqlDbType.NVarChar).Value = Address3.Text
            cmd.Parameters.Add("@Town", SqlDbType.NVarChar).Value = Town.Text
            cmd.Parameters.Add("@County", SqlDbType.NVarChar).Value = County.Text
            cmd.Parameters.Add("@Country", SqlDbType.NVarChar).Value = Country.Text
            cmd.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = PostalCode.Text
            cmd.Parameters.Add("@Telephone1", SqlDbType.NVarChar).Value = Telephone1.Text
            cmd.Parameters.Add("@Telephone2", SqlDbType.NVarChar).Value = Telephone2.Text
            cmd.Parameters.Add("@Fax", SqlDbType.NVarChar).Value = Fax.Text
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email.Text
            cmd.Parameters.Add("@Bussiness", SqlDbType.NVarChar).Value = Business.Text
            cmd.Parameters.Add("@InvAddress", SqlDbType.NVarChar).Value = InvoiceAddress.Text
            cmd.Parameters.Add("@InvTown", SqlDbType.NVarChar).Value = InvoiceTown.Text
            cmd.Parameters.Add("@InvCounty", SqlDbType.NVarChar).Value = InvoiceCounty.Text
            cmd.Parameters.Add("@InvCountry", SqlDbType.NVarChar).Value = InvoiceCountry.Text
            cmd.Parameters.Add("@InvPostCode", SqlDbType.NVarChar).Value = InvoicePostcode.Text
            cmd.Parameters.Add("@AccountNumber", SqlDbType.NVarChar).Value = AccountNo.Text
            cmd.Parameters.Add("@CompanyRegNumber", SqlDbType.NVarChar).Value = CompanyRegNo.Text
            cmd.Parameters.Add("@ClientsVatRegNo", SqlDbType.NVarChar).Value = VATRegNo.Text
            cmd.Parameters.Add("@Terms", SqlDbType.NVarChar).Value = Terms.Text
            cmd.Parameters.Add("@OrderNumberReq", SqlDbType.NVarChar).Value = OrdernumberReq.Text
            cmd.Parameters.Add("@Ltd", SqlDbType.Bit).Value = Ltd.Checked
            cmd.Parameters.Add("@SpecialInvoiceInstructions", SqlDbType.NVarChar).Value = SpecialInvoiceInstructions.Text




            Main.con.Open()
            cmd.ExecuteNonQuery()



        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Main.con.Close()
        End Try
    End Sub

    Public Sub FetchData()

        Select Case ident

            Case 0
                adSQLAdapter2 = New SqlDataAdapter("select Expr1 from CV_BranchDropdown", Main.con)
                adSQLAdapter2.Fill(Dset, "Branch")
                For i = 0 To Dset.Tables("Branch").Rows.Count - 1
                    Branch.Items.Add(Dset.Tables("Branch").Rows(i)(0).ToString())
                Next

            Case 1
                adSQLAdapter2 = New SqlDataAdapter("select Expr1 from CV_BranchDropdown", Main.con)
                adSQLAdapter2.Fill(Dset, "Branch")
                For i = 0 To Dset.Tables("Branch").Rows.Count - 1
                    Branch.Items.Add(Dset.Tables("Branch").Rows(i)(0).ToString())
                Next

                'adSQLAdapter2 = New SqlDataAdapter("select * from [dbo].[CompanyContacts] where ContactID ='" + bigint2.ToString + "'", Main.con)
                'adSQLAdapter2.Fill(Dset, "CompanyContacts")
                'Dset.Tables("CompanyContacts").Rows(0)(1).ToString()
                'Title.Text = Dset.Tables("CompanyContacts").Rows(0)(2).ToString()
                'Forename.Text = Dset.Tables("CompanyContacts").Rows(0)(3).ToString()
                'Initials.Text = Dset.Tables("CompanyContacts").Rows(0)(4).ToString()

                'Surname.Text = Dset.Tables("CompanyContacts").Rows(0)(5).ToString()
                'Department.Text = Dset.Tables("CompanyContacts").Rows(0)(6).ToString()     
                'JobTitle.Text = Dset.Tables("CompanyContacts").Rows(0)(7).ToString()
                'Telephone.Text = Dset.Tables("CompanyContacts").Rows(0)(8).ToString()
                'Email.Text = Dset.Tables("CompanyContacts").Rows(0)(9).ToString()
                'Fax.Text = Dset.Tables("CompanyContacts").Rows(0)(10).ToString()
                'DateLastContact.Text = Dset.Tables("CompanyContacts").Rows(0)(11).ToString()
                'ContactedBy.Text = Dset.Tables("CompanyContacts").Rows(0)(12).ToString()
                'Address.Text = Dset.Tables("CompanyContacts").Rows(0)(13).ToString()
                'Town.Text = Dset.Tables("CompanyContacts").Rows(0)(14).ToString()
                'County.Text = Dset.Tables("CompanyContacts").Rows(0)(15).ToString()
                'Country.Text = Dset.Tables("CompanyContacts").Rows(0)(16).ToString()
                'PostalCode.Text = Dset.Tables("CompanyContacts").Rows(0)(17).ToString()
                'Position.Text = Dset.Tables("CompanyContacts").Rows(0)(18).ToString()
                'CostCentre.Text = Dset.Tables("CompanyContacts").Rows(0)(19).ToString()
                'Category.Text = Dset.Tables("CompanyContacts").Rows(0)(20).ToString()
                'Category2.Text = Dset.Tables("CompanyContacts").Rows(0)(21).ToString()
                'Telephone2.Text = Dset.Tables("CompanyContacts").Rows(0)(22).ToString()
                'If Dset.Tables("CompanyContacts").Rows(0)(23).ToString() = "" Then
                '    Active.Checked = True
                'Else
                '    Active.Checked = Dset.Tables("CompanyContacts").Rows(0)(23).ToString()
                'End If

                'Notes.Text = Dset.Tables("CompanyContacts").Rows(0)(24).ToString()

        End Select



    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



    Private Sub Branch_TextChanged(sender As System.Object, e As System.EventArgs) Handles Branch.TextChanged
        Try
            If Dset.Tables("BranchId") IsNot Nothing Then
                Dset.Tables("BranchId").Clear()
            End If
            If Branch.Text = "" Then

            Else

                adSQLAdapter2 = New SqlDataAdapter("select BranchId from CV_BranchDropdown where Expr1 = '" + Branch.Text + "'", Main.con)


                adSQLAdapter2.Fill(Dset, "BranchId")

                Main.con.Open()
                Branch.Tag = Dset.Tables("BranchId").Rows(0)(0).ToString


            End If
        Catch ex As Exception

            MsgBox("Invalid Branch Selection")

        Finally
            Main.con.Close()
        End Try

    End Sub

    Private Sub ClientEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
