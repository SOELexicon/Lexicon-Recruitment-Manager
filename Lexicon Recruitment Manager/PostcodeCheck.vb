Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
'Copyright 2012 Craig Wright
'Redistribution and use in source and binary forms, with or without 'modification, are permitted provided that the following conditions 'are met 

'1. Redistributions of source code must retain the above copyright 'notice, this list of conditions and the following disclaimer.
'2. Redistributions in binary form must reproduce the above copyright 'notice, this list of conditions and the following disclaimer in the 'documentation and/or other materials provided with the distribution.

'THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS '"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT'LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 'FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 'COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 'INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 'BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; 'LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER 'CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT 'LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN 'ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 'POSSIBILITY OF SUCH DAMAGE.

Public Class DialogPostcodeCheck

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub GridView1_RowStyle(ByVal sender As Object, _
ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim category As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Archived"))
            Dim category2 As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Division"))

            If category = "Checked" Then
                e.Appearance.BackColor = Color.OrangeRed
                e.Appearance.BackColor2 = Color.OrangeRed
            Else
                If category2 = "Industrial" Then

                    e.Appearance.BackColor = Color.MediumSeaGreen
                    e.Appearance.BackColor2 = Color.MediumSeaGreen
                Else
                    e.Appearance.BackColor = Color.MediumSlateBlue
                    e.Appearance.BackColor2 = Color.MediumSlateBlue
                End If
            End If

        End If
    End Sub
End Class
