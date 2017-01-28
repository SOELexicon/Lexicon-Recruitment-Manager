Imports DevExpress.XtraSplashScreen
'Copyright 2012 Craig Wright
'Redistribution and use in source and binary forms, with or without 'modification, are permitted provided that the following conditions 'are met 

'1. Redistributions of source code must retain the above copyright 'notice, this list of conditions and the following disclaimer.
'2. Redistributions in binary form must reproduce the above copyright 'notice, this list of conditions and the following disclaimer in the 'documentation and/or other materials provided with the distribution.

'THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS '"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT'LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 'FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 'COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 'INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 'BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; 'LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER 'CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT 'LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN 'ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 'POSSIBILITY OF SUCH DAMAGE.
Public Class FrmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        'If Now >= "1 october 2014  " Then
        '  Me.Close()
        ' End If
        Main.connectytosql()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.spl()
        UsernameTextBox.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString()
        '    Dim appData As String = GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
        Dim FILE_NAME As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)

        If (System.IO.File.Exists(FILE_NAME + "\Lexicon\Skins.txt")) Then
            Dim lines() As String = IO.File.ReadAllLines(FILE_NAME + "\Lexicon\Skins.txt")
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = lines(0)
            ' Main..LookAndFeel.UserLookAndFeel.Default.SkinName = lines(0)
        End If



        ' Display the path

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        LogoPictureBox.Image.Save("C:\Users\craigwright\SkyDrive Pro\Lexicon\Lexicon Recruitment Manager\Lexicon Recruitment Manager\Login.png")
    End Sub

    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '   SplashScreenManager.CloseForm()

    End Sub
End Class
