Imports System.Data.SqlClient

Public Class frmClientDetails
    Public Idenifier, SqlType, SecondID As Integer
    Public NiNumberSelect As String

    Public Sub DynamicFillForm(ident As Integer)
        Idenifier = ident
        CreateObjects()
    End Sub
    Dim headings As String
    Dim CC_() As Control
    Dim Lbl_() As Label
    Dim Dset As DataSet
    Dim DsetTable() As String
    Private Sub CreateObjects()
        'Ident   Controll to check if labels are required for other areas
        '1 - ClientDetails
        'Main.con.Open()

        Select Case Idenifier
            Case 1
                ReDim DsetTable(3)

                Label1.Text = "Contacts"
                TabPage1.Text = "Details"
                TabPage3.Text = "AWR"
                TabPage4.Text = "H&S + Other"

                DsetTable(1) = "CompanyContacts"
                DsetTable(0) = "Sites"
                With TabControl1.TabPages
                    '  .Remove(TabPage3)
                    '.Remove(TabPage4)
                    .Remove(TabPage5)
                    .Remove(TabPage6)
                    .Remove(TabPage7)
                    .Remove(TabPage8)
                    .Remove(TabPage9)
                    .Remove(TabPage10)

                End With



                headings = "SELECT top 1 * from [ClientView]"
            Case 2
                ReDim DsetTable(3)
                Label1.Dispose()
                DataGridView1.Dispose()
                TableLayoutPanel1.Dock = DockStyle.Fill
                'Label1.Text = "Contacts"
                TabPage1.Text = "Details"
                TabPage3.Text = "Work History 1"

                TabPage4.Text = "Work History 2"
                TabPage5.Text = "Work History 3"
                TabPage6.Text = "ProofOfId"
                TabPage7.Text = "Industrial"
                TabPage8.Text = "Driving"
                TabPage9.Text = "Ltd Company Details"
                TabPage10.Text = "Other"
                DsetTable(1) = "CompanyContacts"
                DsetTable(0) = "Sites"
                headings = "SELECT   top 1 *  FROM employeeform"

        End Select
        Dim adSQLAdapter2 As New SqlDataAdapter(headings, Main.con)
        Dim commands As New SqlCommandBuilder(adSQLAdapter)
        Dset = New DataSet
        adSQLAdapter2.Fill(Dset, "Headings")
        Label1.Text = "Contacts"
        TabPage1.Text = "Details"
        Dim Array_Size As Integer = Dset.Tables("headings").Columns.Count - 1
        ReDim CC_(Array_Size)
        ReDim Lbl_(Array_Size)
        Dim RowOffset As Integer
        Dim CollumnOffset As Integer
        CollumnOffset = 1
        For i = 0 To Array_Size
            Select Case Dset.Tables("headings").Columns(i).DataType.ToString
                Case "System.Int32"
                    CC_(i) = New TextBox
                    CC_(i).Dock = DockStyle.Fill
                    CType(CC_(i), TextBox).ReadOnly = True
                    CType(CC_(i), TextBox).MaxLength = 200
                    CC_(i).Tag = "Int"
                Case "System.Int64"
                    CC_(i) = New TextBox
                    CC_(i).Dock = DockStyle.Fill
                    CType(CC_(i), TextBox).ReadOnly = True
                    CType(CC_(i), TextBox).MaxLength = 200
                    CC_(i).Tag = "Int"
                Case "System.String"
                    CC_(i) = New TextBox
                    CC_(i).Dock = DockStyle.Fill
                    CType(CC_(i), TextBox).ReadOnly = True
                    CType(CC_(i), TextBox).MaxLength = 200
                    CC_(i).Tag = "String"
                Case "System.DateTime"
                    CC_(i) = New TextBox
                    CC_(i).Dock = DockStyle.Fill
                    CType(CC_(i), TextBox).ReadOnly = True
                    CType(CC_(i), TextBox).MaxLength = 200
                    CC_(i).Tag = "String"
                Case "System.Decimal"
                    CC_(i) = New TextBox
                    CC_(i).Dock = DockStyle.Fill
                    CType(CC_(i), TextBox).ReadOnly = True
                    CType(CC_(i), TextBox).MaxLength = 200
                    CC_(i).Tag = "String"
                Case "System.Boolean"
                    CC_(i) = New CheckBox
                    CC_(i).Dock = DockStyle.Fill
                    CType(CC_(i), CheckBox).Enabled = False
                    CC_(i).Tag = "Boolean"
                Case Else
                    MsgBox(Dset.Tables("headings").Columns(i).DataType.ToString)
            End Select
            Lbl_(i) = New Label
            Lbl_(i).Dock = DockStyle.Fill
            Lbl_(i).Text = Dset.Tables("headings").Columns(i).Caption
            Select Case Idenifier
                Case 1

                Case 2
                    If CType(Lbl_(i), Label).Text = "Notes" Then
                        CType(CC_(i), TextBox).Multiline = True
                        '  CType(CC_(i), TextBox). = True
                    End If
            End Select

            Select Case Idenifier
                Case 1
                    Select Case i
                        Case 0 To 10
                            With TableLayoutPanel1
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 1)
                                .SetColumn(CC_(i), 2)
                                .SetRow(Lbl_(i), i + 1)
                                .SetRow(CC_(i), i + 1)
                            End With
                        Case 11 To 20 + CollumnOffset
                            RowOffset = 10 + CollumnOffset
                            With TableLayoutPanel1
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 3)
                                .SetColumn(CC_(i), 4)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                                .SetRow(CC_(i), i - RowOffset + 1)
                            End With
                        Case 21 + CollumnOffset To 34 + CollumnOffset
                            RowOffset = 21 + CollumnOffset
                            With TableLayoutPanel2
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 1)
                                .SetColumn(CC_(i), 2)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                        Case 35 + CollumnOffset To 45 + CollumnOffset
                            RowOffset = 35 + CollumnOffset
                            With TableLayoutPanel2

                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 3)
                                .SetColumn(CC_(i), 4)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                        Case 46 + CollumnOffset To 51 + CollumnOffset
                            RowOffset = 46 + CollumnOffset
                            With TableLayoutPanel3
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 1)
                                .SetColumn(CC_(i), 2)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                        Case 52 + CollumnOffset To 65 + CollumnOffset
                            RowOffset = 52 + CollumnOffset
                            With TableLayoutPanel4
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 1)
                                .SetColumn(CC_(i), 2)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                        Case 66 + CollumnOffset To 82 + CollumnOffset
                            RowOffset = 66 + CollumnOffset
                            With TableLayoutPanel4
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 3)
                                .SetColumn(CC_(i), 4)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                        Case 83 + CollumnOffset To 98 + CollumnOffset
                            RowOffset = 83 + CollumnOffset
                            With TableLayoutPanel7
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 1)
                                .SetColumn(CC_(i), 2)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                        Case 99 + CollumnOffset To 107 + CollumnOffset
                            RowOffset = 99 + CollumnOffset
                            '95 To 94
                            With TableLayoutPanel7
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 3)
                                .SetColumn(CC_(i), 4)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                        Case 108 + CollumnOffset To 123 + CollumnOffset
                            RowOffset = 108 + CollumnOffset
                            With TableLayoutPanel8
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 1)
                                .SetColumn(CC_(i), 2)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                        Case 124 + CollumnOffset To 139 + CollumnOffset
                            RowOffset = 124 + CollumnOffset
                            With TableLayoutPanel8
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 3)
                                .SetColumn(CC_(i), 4)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                        Case Else
                            RowOffset = 140 + CollumnOffset
                            With TableLayoutPanel9
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 1)
                                .SetColumn(CC_(i), 2)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                    End Select
                Case 2
                    Select Case i
                        Case 0 To 11
                            With TableLayoutPanel1
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 1)
                                .SetColumn(CC_(i), 2)
                                .SetRow(Lbl_(i), i + 1)
                                .SetRow(CC_(i), i + 1)
                            End With
                        Case 12 To 19 + CollumnOffset
                            RowOffset = 11 + CollumnOffset
                            With TableLayoutPanel1
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 3)
                                .SetColumn(CC_(i), 4)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                                .SetRow(CC_(i), i - RowOffset + 1)
                            End With
                        Case 20 + CollumnOffset To 27 + CollumnOffset
                            RowOffset = 20 + CollumnOffset
                            With TableLayoutPanel2
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 1)
                                .SetColumn(CC_(i), 2)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                        Case 28 + CollumnOffset To 40 + CollumnOffset
                            RowOffset = 28 + CollumnOffset
                            With TableLayoutPanel3

                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 1)
                                .SetColumn(CC_(i), 2)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                        Case 41 + CollumnOffset To 53 + CollumnOffset
                            RowOffset = 41 + CollumnOffset
                            With TableLayoutPanel4
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 1)
                                .SetColumn(CC_(i), 2)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                        Case 54 + CollumnOffset To 66 + CollumnOffset
                            RowOffset = 54 + CollumnOffset
                            With TableLayoutPanel5
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 1)
                                .SetColumn(CC_(i), 2)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                        Case 67 + CollumnOffset To 83 + CollumnOffset
                            RowOffset = 67 + CollumnOffset
                            With TableLayoutPanel6
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 1)
                                .SetColumn(CC_(i), 2)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                        Case 84 + CollumnOffset To 99 + CollumnOffset
                            RowOffset = 84 + CollumnOffset
                            With TableLayoutPanel7
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 1)
                                .SetColumn(CC_(i), 2)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                        Case 100 + CollumnOffset To 108 + CollumnOffset
                            RowOffset = 100 + CollumnOffset
                            '95 To 94
                            With TableLayoutPanel7
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 3)
                                .SetColumn(CC_(i), 4)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                        Case 109 + CollumnOffset To 124 + CollumnOffset
                            RowOffset = 109 + CollumnOffset
                            With TableLayoutPanel8
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 1)
                                .SetColumn(CC_(i), 2)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                        Case 125 + CollumnOffset To 140 + CollumnOffset
                            RowOffset = 125 + CollumnOffset
                            With TableLayoutPanel8
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 3)
                                .SetColumn(CC_(i), 4)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                        Case 141 + CollumnOffset To 145 + CollumnOffset
                            RowOffset = 141 + CollumnOffset
                            With TableLayoutPanel9
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 1)
                                .SetColumn(CC_(i), 2)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                        Case Else
                            RowOffset = 146 + CollumnOffset
                            With TableLayoutPanel10
                                .Controls.Add(Lbl_(i))
                                .Controls.Add(CC_(i))
                                .SetColumn(Lbl_(i), 1)
                                .SetColumn(CC_(i), 2)
                                .SetRow(CC_(i), i - RowOffset + 1)
                                .SetRow(Lbl_(i), i - RowOffset + 1)
                            End With
                    End Select
            End Select
        Next
    End Sub
    Private Sub ToolStripTextBox1_Enter(sender As System.Object, e As System.EventArgs) Handles ToolStripTextBox1.Enter
        ToolStripTextBox1.Text = ""
    End Sub
    Private Sub ToolStripTextBox1_Leave(sender As System.Object, e As System.EventArgs) Handles ToolStripTextBox1.Leave
        ToolStripTextBox1.Text = "Search"
    End Sub

    


    Dim adSQLAdapter2 As SqlDataAdapter
    Public Sub AddDataToTable(sql2 As String)
        Try
            Main.con.Open()
            adSQLAdapter2 = New SqlDataAdapter(sql2, Main.con)
            Select Case Idenifier
                Case 1
                    adSQLAdapter2.Fill(Dset, DsetTable(0))
                    Dim ClientDt As DataTable = Dset.Tables(DsetTable(0))
                    Dim iloop As Integer
                    While iloop < ClientDt.Columns.Count - 1
                        If IsDBNull(ClientDt.Rows(0)(iloop)) = False Then
                            Select Case iloop
                                Case 0
                                    CC_(iloop).DataBindings.Clear()
                                    CC_(iloop).DataBindings.Add("text", ClientDt, ClientDt.Columns(iloop).Caption)
                                    CC_(iloop).Tag = ClientDt.Columns(iloop).Caption
                                    Me.Text = "Client Details " + ClientDt.Rows(0)(iloop + 2)
                                    SecondID = ClientDt.Rows(0)(0)
                                Case 1 To 60
                                    CC_(iloop).DataBindings.Clear()
                                    Select Case ClientDt.Columns(iloop).DataType.ToString
                                        Case "System.Boolean"
                                            '  CC_(iloop).DataBindings.Clear()
                                            ' --   CC_(iloop).DataBindings.Add("checked", ClientDt, ClientDt.Columns(iloop).Caption)
                                            CType(CC_(iloop), CheckBox).Checked = ClientDt.Rows(0)(iloop)
                                            'Case "System.DateTime"
                                            '    CType(CC_(iloop), DateTimePicker).Value = ClientDt.Rows(0)(iloop)

                                        Case Else

                                            CType(CC_(iloop), TextBox).Text = ClientDt.Rows(0)(iloop)
                                    End Select
                                    CC_(iloop).Tag = ClientDt.Columns(iloop).Caption
                            End Select
                        End If
                        iloop = iloop + 1
                    End While
                Case 2
                    adSQLAdapter2.Fill(Dset, DsetTable(0))
                    Dim ClientDt As DataTable = Dset.Tables(DsetTable(0))
                    Dim iloop As Integer
                    While iloop < ClientDt.Columns.Count
                        If IsDBNull(ClientDt.Rows(0)(iloop)) = False Then
                            Select Case iloop
                                Case 0
                                    CC_(iloop).DataBindings.Clear()
                                    CC_(iloop).DataBindings.Add("text", ClientDt, ClientDt.Columns(iloop).Caption)
                                    CC_(iloop).Tag = ClientDt.Columns(iloop).Caption
                                    Me.Text = "Employee Details " + ClientDt.Rows(0)(iloop + 4)
                                Case Else
                                    Main.BarEditItem1.EditValue = (iloop / ClientDt.Columns.Count) * 100
                                    '  Main.ToolStripStatusLabel1.Text = ": Mapping Epmployee Field - " + ClientDt.Columns(iloop).Caption
                                    Select Case ClientDt.Columns(iloop).DataType.ToString
                                        Case "System.Boolean"
                                            '  CC_(iloop).DataBindings.Clear()
                                            ' --   CC_(iloop).DataBindings.Add("checked", ClientDt, ClientDt.Columns(iloop).Caption)
                                            CType(CC_(iloop), CheckBox).Checked = ClientDt.Rows(0)(iloop)
                                            'Case "System.DateTime"
                                            '    datefield = Now.Date
                                            '    If ClientDt.Rows(0)(iloop) <> null Then
                                            '        datefield = ClientDt.Rows(0)(iloop)
                                            '        End

                                            '        CType(CC_(iloop), DateTimePicker).Value = ClientDt.Rows(0)(iloop)
                                            '        End
                                        Case Else

                                            CType(CC_(iloop), TextBox).Text = ClientDt.Rows(0)(iloop)
                                    End Select
                                    CC_(iloop).Tag = ClientDt.Columns(iloop).Caption


                            End Select
                        End If
                        iloop = iloop + 1
                    End While
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            Main.con.Close()
        End Try

    End Sub

    Dim cmdBuilder As SqlCommandBuilder
    Public sql3 As String
    Dim adSQLAdapter As SqlDataAdapter
    Public Sub SqlSearch()
        Try
            'Dim sql As String = ("SELECT       companyId, Company, Site, Address, Address2, Address3, Town, County FROM Sites where Company like '%" + ParamStr + "%'")
            Dim dtTable As New DataTable()
            Dset = New DataSet
            Main.con.Open()
            Dim adSQLAdapter2 As New SqlDataAdapter(sql3, Main.con)
            Dim commands As New SqlCommandBuilder(adSQLAdapter)
            'POPULATE THE DATATABLE WITH DATA.
            dtTable.Clear()
            Select Case Idenifier
                Case 1
                    adSQLAdapter2.Fill(Dset, DsetTable(1))
                    DataGridView1.DataSource = Dset
                    DataGridView1.DataMember = DsetTable(1)

            End Select
         
        Catch SqlError As System.Data.SqlTypes.SqlTypeException
            MessageBox.Show("ERROR WITH THE SQL STATEMENT")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            Main.con.Close()
        End Try
    End Sub
    Dim sql As String
    Dim sql2 As String
    Dim da2 As SqlDataAdapter
    Dim UserBranch As String
    Dim Dset2 As New DataTable

    Public Function GetSecurityInfo(area As String, application As String)
        da2 = New SqlDataAdapter("SELECT isnull(SUBSTRING((SELECT        ',' + CAST(BranchuserSecurity.SecurityBranch AS nvarchar(MAX)) FROM Users INNER JOIN BranchUserSecurity ON Users.UserID = BranchUserSecurity.UserID INNER JOIN Applications ON BranchUserSecurity.ApplicationID = Applications.ApplicationId INNER JOIN ApplicationAreas ON BranchUserSecurity.ApplicationArea = ApplicationAreas.ApplicationAreaID  WHERE   (Applications.Application = '" + application + "') and (ApplicationAreas.ApplicationArea = '" + area + "') and  (Users.DomainUserID = '" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString() + "') FOR XML PATH('')),2,200000),0) AS CSV ", Main.con)
        If Dset2 IsNot Nothing Then
            Dset2.Clear()
        End If
        da2.Fill(Dset2)
        Return Dset2.Rows(0)(0).ToString()


    End Function

    Private Sub ToolStripTextBox1_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyUp
        Select Case e.KeyValue
            Case 13
                Dim d As New SearchDialog
                Select Case Idenifier
                    Case 1
                        d.Text = "Select An Client"
                        UserBranch = GetSecurityInfo("Clients", "Lexicon")
                        sql = "SELECT    companyid ,   CompanyName, Site, Address, Address2, Address3, Town, County FROM Sites where CompanyName like '%" + ToolStripTextBox1.Text + "%' and branchID in (" + UserBranch + ")"
                        sql2 = ("SELECT top 1 * from [ClientView] where companyid = " + SecondID.ToString)
                        sql3 = "SELECT        ContactID, Title, Forename, Surname, Department, Position, JobTitle, Fax, Email, Notes FROM    CompanyContacts where siteid = companyid" + SecondID.ToString
                    Case 2
                        UserBranch = GetSecurityInfo("Employees", "Lexicon")
                        sql = "SELECT        e.EmployeeID, e.EmployeeCode, e.Status, e.Title, e.Forename, e.Surname, Branch.Branch, e.NINumber, s.Scheme FROM            Employees AS e INNER JOIN Branch ON e.BranchID = Branch.BranchID INNER JOIN Schemes AS s ON e.SchemeID = s.SchemeID where EmployeeCode Like '%" + ToolStripTextBox1.Text + "%' or e.surname like '%" + ToolStripTextBox1.Text + "%' and e.branchID in (" + UserBranch + ") order by EmployeeCode"

                        ' sql3 = "SELECT      siteid,companyId,  ContactID, Title, Forename, Surname, Department, Position, JobTitle, Fax, Email, Notes,tempcontactid FROM    CompanyContacts where siteid = " + SecondID.ToString
                        d.Text = "Select An Employee"
                End Select

                d.sQLsEARCH(ToolStripTextBox1.Text, sql)

                Dim result As DialogResult = d.ShowDialog(Me)
                If result = Windows.Forms.DialogResult.OK Then
                    '  MsgBox(d.SearchText)
                    SecondID = d.SearchText
                    Select Case Idenifier
                        Case 1
                            sql2 = ("SELECT top 1 * from [ClientView] where companyid = " + SecondID.ToString)
                            sql3 = "SELECT        ContactID, Title, Forename, Surname, Department, Position, JobTitle, Fax, Email, Notes FROM    CompanyContacts where companyid = " + SecondID.ToString

                        Case 2
                            sql2 = ("SELECT   top 1    *  FROM employeeform where EmployeeID = " + SecondID.ToString)
                    End Select
                    SqlSearch()

                    '  d.DataGridView1.Columns(0).Visible = False
                    '  d.DataGridView1.Columns(1).Visible = False
                    AddDataToTable(sql2)



                    d.Dispose()
                End If



        End Select
    End Sub


    Dim changes As DataTable
    'Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
    '    Button1.Visible = False
    '    Try
    '        Dim cmd As New SqlCommand
    '        cmd.Connection = Main.con
    '        Select Case Idenifier
    '            Case 1
    '                ' cmd.Parameters.Add("@CompanyId", SqlDbType.Int).Value = ProductID
    '                changes = Dset.Tables("CompanyContacts").GetChanges
    '                Main.con.Open()
    '                If Not IsNothing(changes) Then


    '                    For i = 0 To changes.Rows.Count - 1
    '                        cmd.Parameters.Clear()
    '                        cmd.CommandType = CommandType.StoredProcedure
    '                        cmd.CommandText = "dbo.EmployeeAdd"
    '                        For i2 = 0 To changes.Columns.Count - 1
    '                            Select Case i2
    '                                Case 0 To 2
    '                                    cmd.Parameters.Add("@" + (i2 + 1).ToString, SqlDbType.Int).Value = changes.Rows(i)(i2)
    '                                Case 12
    '                                    cmd.Parameters.Add("@" + (i2 + 1).ToString, SqlDbType.Int).Value = changes.Rows(i)(i2).ToString
    '                                Case Else
    '                                    cmd.Parameters.Add("@" + (i2 + 1).ToString, SqlDbType.VarChar).Value = changes.Rows(i)(i2).ToString
    '                            End Select

    '                        Next

    '                        cmd.ExecuteNonQuery()
    '                    Next
    '                    changes.Clear()
    '                End If

    '                For i = 0 To CC_.Count - 1
    '                    Select Case i
    '                        Case 0 To CC_.Count - 1
    '                            ' MsgBox(Dset.Tables("Sites").Rows(0)(i).GetType.ToString)
    '                            Select Case Dset.Tables("Sites").Rows(0)(i).GetType.ToString
    '                                Case "System.Int32"
    '                                    Dset.Tables("Sites").Rows(0)(i) = Int32.Parse(CC_(i).Text)
    '                                Case "System.Boolean"

    '                                    If CType(CC_(i), CheckBox).Checked Then
    '                                        Dset.Tables("Sites").Rows(0)(i) = True
    '                                    Else
    '                                        Dset.Tables("Sites").Rows(0)(i) = False
    '                                    End If
    '                                Case Else
    '                                    Dset.Tables("Sites").Rows(0)(i) = CC_(i).Text

    '                            End Select

    '                        Case Else
    '                            ' MsgBox(Dset.Tables("Sites").Rows(0)(i).GetType.ToString)


    '                    End Select

    '                Next




    '                For i = 0 To Dset.Tables("Sites").Rows.Count - 1
    '                    cmd.Parameters.Clear()

    '                    cmd.CommandType = CommandType.StoredProcedure
    '                    cmd.CommandText = "sp_LexiconUpdateClients"
    '                    For i2 = 0 To Dset.Tables("Sites").Columns.Count - 1
    '                        Select Case i2
    '                            Case 0 To 1
    '                                cmd.Parameters.Add("@" + (i2 + 1).ToString, SqlDbType.Int).Value = Dset.Tables("Sites").Rows(i)(i2)

    '                            Case 26
    '                                cmd.Parameters.Add("@" + (i2 + 1).ToString, SqlDbType.Bit).Value = Dset.Tables("Sites").Rows(i)(i2)
    '                            Case Else
    '                                cmd.Parameters.Add("@" + (i2 + 1).ToString, SqlDbType.VarChar).Value = Dset.Tables("Sites").Rows(i)(i2)
    '                        End Select

    '                    Next
    '                    cmd.ExecuteNonQuery()
    '                Next
    '                MsgBox("Changes Done")


    '            Case 2


    '        End Select
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    Finally
    '        Main.con.Close()
    '    End Try


    'End Sub

    Private Sub frmClientDetails_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click
        Select Case Idenifier
            Case 1
                Dim d As New ClientEdit
                d.FetchData()
                Dim result As DialogResult = d.ShowDialog(Me)
                If result = Windows.Forms.DialogResult.OK Then
                    '  MsgBox(d.SearchTtaext)
                    SecondID = d.Tag
                    d.ident = 0
                    sql2 = ("SELECT top 1 * from [ClientView]  where companyid = " + SecondID.ToString)

                    SqlSearch()
                    AddDataToTable(sql2)

                End If
            Case 2
                Dim d As New EmployeeEdit
                d.FetchData()
                Dim result As DialogResult = d.ShowDialog(Me)
                If result = Windows.Forms.DialogResult.OK Then

                    'NiNumberSelect = d.Tag
                    'd.ident = 0
                    'sql2 = ("SELECT   top 1    *  FROM employeeform where NINumber = '" + NiNumberSelect + "'")

                    'SqlSearch()
                    'AddDataToTable(sql2)

                End If
        End Select



    End Sub

    Private Sub frmClientDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Select Case Idenifier
            Case 1
            Case 2
                BtnNew.Text = "New Employee"
        End Select
        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As System.Object, e As System.ComponentModel.ProgressChangedEventArgs)
        Main.BarEditItem1.EditValue = e.ProgressPercentage

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs)
        AddDataToTable(sql2)
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        If SecondID <> 0 Then
            Select Case Idenifier
                Case 1
                    Dim d As New ClientEdit
                    d.ident = 1

                    d.bigint = SecondID
                    d.FetchData()
                    Dim result As DialogResult = d.ShowDialog(Me)
                    If result = Windows.Forms.DialogResult.OK Then
                        '  MsgBox(d.SearchTtaext)
                        SecondID = d.bigint

                        sql2 = ("SELECT   top 1    *  FROM employeeform where EmployeeID = " + SecondID.ToString)

                        SqlSearch()
                        AddDataToTable(sql2)
                    End If
                Case 2
                    Dim d As New EmployeeEdit
                    d.ident = 1

                    d.bigint = SecondID
                    d.FetchData()
                    Dim result As DialogResult = d.ShowDialog(Me)
                    If result = Windows.Forms.DialogResult.OK Then
                        '  MsgBox(d.SearchTtaext)
                        SecondID = d.bigint

                        sql2 = ("SELECT   top 1    *  FROM employeeform where EmployeeID = " + SecondID.ToString)

                        SqlSearch()
                        AddDataToTable(sql2)
                    End If
            End Select
        End If


    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddToolStripMenuItem.Click
        Dim d As New CustomerContact

        d.ident = 0
        d.bigint = SecondID

        Dim result As DialogResult = d.ShowDialog(Me)
        If result = Windows.Forms.DialogResult.OK Then
            SqlSearch()
        End If

    End Sub

    Private Sub ModifyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModifyToolStripMenuItem.Click
        Dim d As New CustomerContact

        d.ident = 1
        d.bigint = SecondID
        d.bigint2 = Me.DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
        d.FetchData()

        Dim result As DialogResult = d.ShowDialog(Me)
        If result = Windows.Forms.DialogResult.OK Then
            SqlSearch()
        End If

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        da2 = New SqlDataAdapter("deletefrom", Main.con)
        If Dset.Tables("SecurityDetails") IsNot Nothing Then
            Dset.Tables("SecurityDetails").Clear()
        End If
        da2.Fill(Dset, "SecurityDetails")
    End Sub
End Class
