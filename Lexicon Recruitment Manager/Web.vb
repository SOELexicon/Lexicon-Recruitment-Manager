﻿Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Core.Drawing
'Copyright 2012 Craig Wright
'Redistribution and use in source and binary forms, with or without 'modification, are permitted provided that the following conditions 'are met 

'1. Redistributions of source code must retain the above copyright 'notice, this list of conditions and the following disclaimer.
'2. Redistributions in binary form must reproduce the above copyright 'notice, this list of conditions and the following disclaimer in the 'documentation and/or other materials provided with the distribution.

'THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS '"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT'LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 'FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 'COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 'INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 'BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; 'LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER 'CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT 'LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN 'ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 'POSSIBILITY OF SUCH DAMAGE.
Public Class Web

    Sub New()

        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
        CountOfEmployeesCurrentWeekTableAdapter1.Fill(Sites2.CountOfEmployeesCurrentWeek)
    End Sub

    Private Sub Web_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sites3.CountOfEmployeesPriorWeek' table. You can move, or remove it, as needed.
        Me.CountOfEmployeesPriorWeekTableAdapter.Fill(Me.Sites3.CountOfEmployeesPriorWeek)
        Try

      
        'TODO: This line of code loads data into the 'Sites1.DailyTempsOnPlan' table. You can move, or remove it, as needed.
            '  Me.DailyTempsOnPlanTableAdapter1.Fill(Me.Sites1.DailyTempsOnPlan)
        'TODO: This line of code loads data into the 'Sites.DailyTempsOnPlan' table. You can move, or remove it, as needed.
        '   Me.DailyTempsOnPlanTableAdapter.Fill(Me.Sites.DailyTempsOnPlan)
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.TempsOnPlanArchiveHistory' table. You can move, or remove it, as needed.
            '  Me.TempsOnPlanArchiveHistoryTableAdapter.Fill(Me.LexiconRecManagerDataSet.TempsOnPlanArchiveHistory)
            CountOfEmployeesCurrentWeekTableAdapter1.Fill(Sites2.CountOfEmployeesCurrentWeek)
            Label1.Text = "Welcome: " + FrmLogin.UsernameTextBox.Text
            Dim strPath As String = System.IO.Path.GetDirectoryName( _
            System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
            RichEditControl1.LoadDocument("Messages.txt")
            updategauge()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Main.openclientsform()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Main.openemployeesform()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Main.loadplansform()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs)
    '    ' Create a new instance of the child form.
    '    Main.openReportsForm()
    'End Sub

    Private Sub Web_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

        Main.loadHolidayform()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Main.loadCanvassRegisterform()
    End Sub

    Private Sub MemoEdit1_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichEditControl1_Click(sender As Object, e As EventArgs) Handles RichEditControl1.Click

    End Sub
    Public Sub updategauge()
        Dim dc As New DataClasses1DataContext
        Dim PlanItems = (From PlanItems2 In dc.GetTable(Of LinqViewPlanItemsLockedUnlocked)()).SingleOrDefault
        Dim range1 As ArcScaleRange = New ArcScaleRange()
        ArcScaleComponent1.MaxValue = PlanItems.TotalCurrent
        ArcScaleComponent1.Value = PlanItems.currentunlocked
        LabelComponent1.Text = PlanItems.currentunlocked
        range1.AppearanceRange.ContentBrush = New SolidBrushObject(Color.OrangeRed)
        range1.StartValue = 0
        range1.EndValue = PlanItems.currentunlocked
        ArcScaleComponent1.Ranges.AddRange(New ArcScaleRange() {range1})
        LabelControl1.Text = PlanItems.currentdate.ToString


        Dim range2 As ArcScaleRange = New ArcScaleRange()
        ArcScaleComponent2.MaxValue = PlanItems.TotalCurrent
        ArcScaleComponent2.Value = PlanItems.CurrentLocked
        LabelComponent2.Text = PlanItems.CurrentLocked
        range2.AppearanceRange.ContentBrush = New SolidBrushObject(Color.Orange)
        range2.StartValue = 0
        range2.EndValue = PlanItems.CurrentLocked
        ArcScaleComponent2.Ranges.AddRange(New ArcScaleRange() {range2})

        Dim range3 As ArcScaleRange = New ArcScaleRange()
        ArcScaleComponent3.MaxValue = PlanItems.TotalCurrent
        ArcScaleComponent3.Value = PlanItems.CurrentLockedPlans
        LabelComponent3.Text = PlanItems.CurrentLockedPlans
        range3.AppearanceRange.ContentBrush = New SolidBrushObject(Color.Green)
        range3.StartValue = 0
        range3.EndValue = PlanItems.CurrentLockedPlans
        ArcScaleComponent3.Ranges.AddRange(New ArcScaleRange() {range3})

        LabelControl2.Text = PlanItems.PreviousDate1.ToString

        Dim range4 As ArcScaleRange = New ArcScaleRange()
        ArcScaleComponent4.MaxValue = PlanItems.Previous1Current
        ArcScaleComponent4.Value = PlanItems.Previous1unlocked
        LabelComponent4.Text = PlanItems.Previous1unlocked
        range4.AppearanceRange.ContentBrush = New SolidBrushObject(Color.OrangeRed)
        range4.StartValue = 0
        range4.EndValue = PlanItems.Previous1unlocked
        ArcScaleComponent4.Ranges.AddRange(New ArcScaleRange() {range4})

        Dim range5 As ArcScaleRange = New ArcScaleRange()
        ArcScaleComponent5.MaxValue = PlanItems.Previous1Current
        ArcScaleComponent5.Value = PlanItems.Previous1Locked
        LabelComponent5.Text = PlanItems.Previous1Locked
        range5.AppearanceRange.ContentBrush = New SolidBrushObject(Color.Orange)
        range5.StartValue = 0
        range5.EndValue = PlanItems.Previous1Locked
        ArcScaleComponent5.Ranges.AddRange(New ArcScaleRange() {range5})

        Dim range6 As ArcScaleRange = New ArcScaleRange()
        ArcScaleComponent6.MaxValue = PlanItems.Previous1Current
        ArcScaleComponent6.Value = PlanItems.Previous1LockedPlans
        LabelComponent6.Text = PlanItems.Previous1LockedPlans
        range6.AppearanceRange.ContentBrush = New SolidBrushObject(Color.Green)
        range6.StartValue = 0
        range6.EndValue = PlanItems.Previous1LockedPlans
        ArcScaleComponent6.Ranges.AddRange(New ArcScaleRange() {range6})

        LabelControl3.Text = PlanItems.PreviousDate2.ToString

        Dim range7 As ArcScaleRange = New ArcScaleRange()
        ArcScaleComponent7.MaxValue = PlanItems.Previous2Current
        ArcScaleComponent7.Value = PlanItems.Previous2unlocked
        LabelComponent7.Text = PlanItems.Previous2unlocked
        range7.AppearanceRange.ContentBrush = New SolidBrushObject(Color.OrangeRed)
        range7.StartValue = 0
        range7.EndValue = PlanItems.Previous2unlocked
        ArcScaleComponent7.Ranges.AddRange(New ArcScaleRange() {range7})

        Dim range8 As ArcScaleRange = New ArcScaleRange()
        ArcScaleComponent8.MaxValue = PlanItems.Previous2Current
        ArcScaleComponent8.Value = PlanItems.Previous2Locked
        LabelComponent8.Text = PlanItems.Previous2Locked
        range8.AppearanceRange.ContentBrush = New SolidBrushObject(Color.Orange)
        range8.StartValue = 0
        range8.EndValue = PlanItems.Previous2Locked
        ArcScaleComponent8.Ranges.AddRange(New ArcScaleRange() {range8})

        Dim range9 As ArcScaleRange = New ArcScaleRange()
        ArcScaleComponent9.MaxValue = PlanItems.Previous2Current
        ArcScaleComponent9.Value = PlanItems.Previous2LockedPlans
        LabelComponent9.Text = PlanItems.Previous2LockedPlans
        range9.AppearanceRange.ContentBrush = New SolidBrushObject(Color.Green)
        range9.StartValue = 0
        range9.EndValue = PlanItems.Previous2LockedPlans
        ArcScaleComponent9.Ranges.AddRange(New ArcScaleRange() {range9})

    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        updategauge()
        '  ArcScaleComponent1.AppearanceScale.Brush = New SolidBrushObject(Color.OrangeRed)
    End Sub
End Class