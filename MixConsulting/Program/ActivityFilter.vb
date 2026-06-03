Imports System.Windows.Forms
Imports MiX_Consulting.Domain.MiX_Consulting.Domain.Security
Imports MiX_Consulting.Domain.Security

Public Class ActivityFilter
    Implements IMessageFilter

    Private Const WM_MOUSEMOVE As Integer = &H200
    Private Const WM_LBUTTONDOWN As Integer = &H201
    Private Const WM_KEYDOWN As Integer = &H100

    Public Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
        If m.Msg = WM_MOUSEMOVE OrElse m.Msg = WM_LBUTTONDOWN OrElse m.Msg = WM_KEYDOWN Then
            SessionManager.RefreshSession()
        End If
        Return False
    End Function
End Class