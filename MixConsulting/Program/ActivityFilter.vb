Imports System.Windows.Forms
Imports MiX_Consulting.Domain.Security

''' <summary>
''' Intercepts system message patterns across active window frames to catch structural user interaction events.
''' </summary>
Public Class ActivityFilter
    Implements IMessageFilter

    Private Const WM_MOUSEMOVE As Integer = &H200
    Private Const WM_LBUTTONDOWN As Integer = &H201
    Private Const WM_KEYDOWN As Integer = &H100

    ''' <summary>
    ''' Filters application-level windows messages before routing them to specific form container instances.
    ''' </summary>
    Public Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
        If m.Msg = WM_MOUSEMOVE OrElse m.Msg = WM_LBUTTONDOWN OrElse m.Msg = WM_KEYDOWN Then
            ' Automatically slide the inactivity safety deadline outward
            RefreshSession()
        End If
        Return False
    End Function
End Class