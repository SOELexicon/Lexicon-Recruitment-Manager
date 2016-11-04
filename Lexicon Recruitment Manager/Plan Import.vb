Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid

Public Class Plan_Import
    Dim Dt As DataTable
    Dim distinctDT As DataTable
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btnImport.Click

        Select Case ImportRoutine.Text
            Case "Lander"
                OpenFileDialog1.Filter = "Excel Files (*.xls)|*.xls|All Files (*.*)|*.*"
                OpenFileDialog1.FilterIndex = 1
                Dim result As DialogResult = OpenFileDialog1.ShowDialog()
                If result = DialogResult.OK Then
                    landerimport(Dt, OpenFileDialog1.FileName)
                End If


                GridImport.DataSource = Dt
                GridControl2.DataSource = distinctDT

        End Select
    End Sub
    Dim ImportDataset As DataTable
    Private Sub LanderSubmit()
        LabelControl1.Text = "Import Progress:"
        Dim dc As New DataClasses1DataContext
        Dim i As Integer
        ProgressBarControl1.Properties.Maximum = ImportDataset.Rows.Count

        For Each row As DataRow In ImportDataset.Rows
            dc.ImportPlan("Lander", row("PlanTypeID").ToString, row("BranchID").ToString, row("CompanyID").ToString, row("EmployeeID").ToString _
                          , row("JobCategoryID").ToString, row("SystemType").ToString, row("Rate").ToString, 0, 0, 0, row("Monday").ToString, row("Tuesday").ToString _
                          , row("Wednesday").ToString, row("Thursday").ToString, row("Friday2").ToString, row("Saturday2").ToString, row("Sunday2").ToString _
                          , row("BasicHours").ToString, row("WeekEndingDate").ToString, row("PayRate").ToString, row("ChargeRate").ToString _
                          , row("DHH").ToString, row("OT1Hours").ToString, row("OT1PayRate").ToString, row("OT1ChargeRate").ToString, "", "", 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)

            ProgressBarControl1.EditValue = i

            i = i + 1

        Next row
    End Sub

    Private Sub landerimport(ByRef objdt As DataTable, ByVal StrFilePath As String)
        Dim dc As New DataClasses1DataContext
        Dim ExcelCon As New OleDbConnection
        Dim ExcelAdp As OleDbDataAdapter
        Dim ExcelComm As OleDbCommand
        Dim ColBasicHours, ColOT1Hours, Col1Basic, ColEmployeeID, ColDateAdded, ColSystemType, ColError, ColErrorDetail, ColChargeRate, ColBasicPay, ColDHH, ColOT1Pay, ColOT1Charge As DataColumn
        ProgressBarControl1.EditValue = 0
        LabelControl1.Text = "Import Progress:"
        Try
            Dim StrSql As String = "Select * From [Export$]"
            ExcelCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                "Data Source= " & StrFilePath & _
                ";Extended Properties=""Excel 8.0;ImportMixedTypes=Text;IMEX=1"""
            ExcelCon.Open()
            ExcelComm = New OleDbCommand(StrSql, ExcelCon)
            ExcelAdp = New OleDbDataAdapter(ExcelComm)
            objdt = New DataTable()
            ExcelAdp.Fill(objdt)



            'Empty Collumn for basic Hours Calculation
            ColBasicHours = New DataColumn
            With ColBasicHours
                .DefaultValue = 0
                .DataType = System.Type.GetType("System.Double")
                .Caption = "Basic Hours"
                .ColumnName = "BasicHours"
            End With
            'Empty Collumn for OT1 Hours Calculation
            ColOT1Hours = New DataColumn
            With ColOT1Hours
                .DefaultValue = 0
                .DataType = System.Type.GetType("System.Double")
                .Caption = "OT1 Hours"
                .ColumnName = "OT1Hours"
            End With

            'Empty Collumn to Import EmployeeId
            ColEmployeeID = New DataColumn
            With ColEmployeeID
                .DefaultValue = 0
                .DataType = System.Type.GetType("System.Int64")
                .Caption = "EmployeeID"
                .ColumnName = "EmployeeID"


            End With
            'Empty Collumn to Import DateAdded
            ColDateAdded = New DataColumn
            With ColDateAdded
                .DefaultValue = Now.Date()
                .DataType = System.Type.GetType("System.DateTime")
                .Caption = "DateAdded"
                .ColumnName = "DateAdded"
            End With
            'Empty Collumn to Import SystemType
            ColSystemType = New DataColumn
            With ColSystemType
                .DefaultValue = "U"
                .DataType = System.Type.GetType("System.String")
                .Caption = "SystemType"
                .ColumnName = "SystemType"
            End With

            'Empty Collumn to to show import errors
            ColError = New DataColumn
            With ColError
                .DefaultValue = False
                .DataType = System.Type.GetType("System.Boolean")
                .Caption = "Error"
                .ColumnName = "Error"
            End With

            'Empty Collumn to show import error Reason
            ColErrorDetail = New DataColumn
            With ColErrorDetail
                .DefaultValue = ""
                .DataType = System.Type.GetType("System.String")
                .Caption = "ErrorDetail"
                .ColumnName = "ErrorDetail"
            End With
            ColDHH = New DataColumn

            'Empty Collumn to Import DHH
            With ColDHH
                .DefaultValue = 0
                .DataType = System.Type.GetType("System.Decimal")
                .Caption = "DHH"
                .ColumnName = "DHH"
            End With

            'Empty Collumn to Import BasicPay
            ColBasicPay = New DataColumn
            With ColBasicPay
                .DefaultValue = 0
                .DataType = System.Type.GetType("System.Decimal")
                .Caption = "Pay Basic"
                .ColumnName = "PayRate"
                '.SetOrdinal(2)

            End With
            'Empty Collumn to Import ChargeRate
            ColChargeRate = New DataColumn
            With ColChargeRate
                .DefaultValue = 0
                .DataType = System.Type.GetType("System.Decimal")
                .Caption = "Charge Basic"
                .ColumnName = "ChargeRate"
                '.SetOrdinal(2)

            End With

            'Empty Collumn to Import OT1PayRate
            ColOT1Pay = New DataColumn
            With ColOT1Pay
                .DefaultValue = 0
                .DataType = System.Type.GetType("System.Decimal")
                .Caption = "OT1 Pay"
                .ColumnName = "OT1PayRate"
                '.SetOrdinal(2)

            End With

            'Empty Collumn to Import OT1ChargeRate
            ColOT1Charge = New DataColumn
            With ColOT1Charge
                .DefaultValue = 0
                .DataType = System.Type.GetType("System.Decimal")
                .Caption = "OT1 Charge"
                .ColumnName = "OT1ChargeRate"
                '.SetOrdinal(2)

            End With

            'Add Collumns to end of Import Grid
            objdt.Columns.Add(ColBasicHours)
            objdt.Columns.Add(ColEmployeeID)
            ColEmployeeID.SetOrdinal(2)
            objdt.Columns.Add(ColDateAdded)
            objdt.Columns.Add(ColSystemType)
            objdt.Columns.Add(ColError)
            objdt.Columns.Add(ColErrorDetail)
            objdt.Columns.Add(ColDHH)
            objdt.Columns.Add(ColBasicPay)
            objdt.Columns.Add(ColChargeRate)
            objdt.Columns.Add(ColOT1Pay)
            objdt.Columns.Add(ColOT1Hours)
            objdt.Columns.Add(ColOT1Charge)
            ColError.SetOrdinal(0)
            ColErrorDetail.SetOrdinal(1)


            'New Collumn for storing employees total basic hours
            Col1Basic = New DataColumn
            With Col1Basic
                .DefaultValue = 0
                .DataType = System.Type.GetType("System.Double")
                .Caption = "Basic Hours"
                .ColumnName = "BasicHours"
            End With


            'Select distinct list of employees
            StrSql = "Select distinct  [Pure Staff ref Number] From [Export$]"
            ExcelComm = New OleDbCommand(StrSql, ExcelCon)
            ExcelAdp = New OleDbDataAdapter(ExcelComm)
            distinctDT = New DataTable()
            ExcelAdp.Fill(distinctDT)
            distinctDT.Columns.Add(Col1Basic)
            ExcelCon.Close()
        Catch ex As Exception

        Finally
            'Close Connections
            ExcelCon = Nothing
            ExcelAdp = Nothing
            ExcelComm = Nothing
        End Try

        'Adds Collumn to distinct employeelist to record total basic hours
        Dim i As Integer = 1
        'Loop through to work out employee split
        ProgressBarControl1.Properties.Maximum = objdt.Rows.Count
        For Each row As DataRow In objdt.Rows
            ProgressBarControl1.EditValue = i
            Application.DoEvents()
            Dim dr As DataRow = distinctDT.[Select]("[Pure Staff ref Number] = '" + row("Pure Staff ref Number") + "'").FirstOrDefault()
            If dr IsNot Nothing Then
                'changes the Sets Basic Hours and OT1 Hours Based on Employees Total Basic Horus
                If dr("BasicHours") + row("Hours TOTAL") <= 38 Then
                    row("BasicHours") = row("Hours TOTAL")
                    dr("BasicHours") = dr("BasicHours") + row("Hours TOTAL")
                ElseIf dr("BasicHours") + row("Hours TOTAL") > 38 Then
                    row("OT1Hours") = (dr("BasicHours") + row("Hours TOTAL")) - 38
                    row("BasicHours") = 38 - dr("BasicHours")
                    dr("BasicHours") = 38 - dr("BasicHours")
                End If

            End If
            'Linq to pull data for import
            Try
                Dim JobCatLinq = (From Jobcat In dc.GetTable(Of LinqJobCategory)() Where Jobcat.CompanyID = row("CompanyID").ToString And Jobcat.JobCategory = row("JobCategoryID").ToString.Replace("Agency ", "") And Jobcat.ShiftName = row("Shift Category").ToString).SingleOrDefault
                row("JobCategoryID") = JobCatLinq.JobCatId
                row("ChargeRate") = JobCatLinq.CBasicPay
                row("PayRate") = JobCatLinq.PBasicPay
                row("DHH") = JobCatLinq.DHH
                row("OT1PayRate") = JobCatLinq.POT1
                row("OT1ChargeRate") = JobCatLinq.COT1



            Catch ex As Exception
                row("Error") = True
                row("ErrorDetail") = "Error JobCat Doesn't Match"
            End Try

            Try
                Dim EmployeeLinq = (From Employee In dc.GetTable(Of LinqEmployee)() Where Employee.EmployeeCode = row("Pure Staff ref Number").ToString).SingleOrDefault
                row("EmployeeID") = EmployeeLinq.EmployeeID
                ' row("SystemType") = EmployeeLinq.Forename + " " + EmployeeLinq.Surname
            Catch ex As Exception
                row("Error") = True
                row("ErrorDetail") = "Error EmployeeCode Doesn't Match"
            End Try
            Try
                Dim EmployeeLinq = (From Employee In dc.GetTable(Of LinqEmployee)() Where Employee.EmployeeCode = row("Pure Staff ref Number").ToString).SingleOrDefault
                If EmployeeLinq.Status <> "TOT" Then
                    row("Error") = True
                    row("ErrorDetail") = "Error Employee Not TOT"
                End If
                ' row("SystemType") = EmployeeLinq.Forename + " " + EmployeeLinq.Surname
            Catch ex As Exception
        
            End Try

            i = i + 1
        Next row

        ImportDataset = objdt




    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim FileName As String = "C:\\excel\\Grid.xls"
        GridImport.ExportToXls(FileName)
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim errors As Integer = 0
        For Each row As DataRow In ImportDataset.Rows
            If row("Error") = True Then
                errors = errors + 1

            End If

        Next
        If errors > 0 Then
            Label1.Text = "Errors: " + errors.ToString
            MsgBox("Import has " + errors.ToString + " Errors, please check fix where needed and retry")
        Else
            Try
                LanderSubmit()
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                MsgBox("Import has completed")
            End Try

        End If

    End Sub

    Private Sub GridView1_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim category As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Error"))
           
          

                Select Case category
                Case "Checked"
                    e.Appearance.BackColor = Color.OrangeRed
                    e.Appearance.BackColor2 = Color.OrangeRed
                Case "Unchecked"
                    e.Appearance.BackColor = Color.Green
                    e.Appearance.BackColor2 = Color.Green


            End Select

        End If

    End Sub

    Private Sub Plan_Import_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
End Class