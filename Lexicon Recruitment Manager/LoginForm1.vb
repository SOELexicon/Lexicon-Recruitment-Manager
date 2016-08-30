Imports DevExpress.XtraSplashScreen

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
