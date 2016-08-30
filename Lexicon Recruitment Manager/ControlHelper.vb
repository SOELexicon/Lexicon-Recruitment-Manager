
Public NotInheritable Class ControlHelper
    Private Sub New()
    End Sub
    Public Shared Sub SuspendRedraw(control As Control)
        If control Is Nothing OrElse control.IsDisposed OrElse Not control.IsHandleCreated Then
            Return
        End If

        Win32API.SendMessage(control.Handle, Messages.WM_SETREDRAW, New IntPtr(If(0, 1, 0)), IntPtr.Zero)

    End Sub

    Public Shared Sub ResumeRedraw(control As Control)
        If control Is Nothing OrElse control.IsDisposed OrElse Not control.IsHandleCreated Then
            Return
        End If
        Win32API.SendMessage(control.Handle, Messages.WM_SETREDRAW, New IntPtr(If(1, 1, 0)), IntPtr.Zero)
    End Sub
End Class


Public NotInheritable Class Win32API
    Private Sub New()
    End Sub
    Const USER32 As String = "user32.dll"


    Public Shared Function SendMessage(hWnd As IntPtr, Msg As UInteger, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function
End Class

Public NotInheritable Class Messages
    Public Const WM_SETREDRAW As Integer = &HB
End Class

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
