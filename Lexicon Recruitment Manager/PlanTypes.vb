'Copyright 2012 Craig Wright
'Redistribution and use in source and binary forms, with or without 'modification, are permitted provided that the following conditions 'are met 

'1. Redistributions of source code must retain the above copyright 'notice, this list of conditions and the following disclaimer.
'2. Redistributions in binary form must reproduce the above copyright 'notice, this list of conditions and the following disclaimer in the 'documentation and/or other materials provided with the distribution.

'THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS '"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT'LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 'FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 'COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 'INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 'BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; 'LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER 'CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT 'LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN 'ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 'POSSIBILITY OF SUCH DAMAGE.

Public Class PlanTypes

    Private Sub PlanTypesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PlanTypesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PlanTypesBindingSource.EndEdit()
        Me.PlanTypesTableAdapter.Update(Me.LexiconRecManagerDataSet.PlanTypes)

    End Sub

    Private Sub PlanTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LexiconRecManagerDataSet.PlanTypes' table. You can move, or remove it, as needed.
        Me.PlanTypesTableAdapter.Fill(Me.LexiconRecManagerDataSet.PlanTypes)

        DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()
    End Sub
End Class