Imports MiX_Consulting.Domain.MiX_Consulting.Domain.Security
''' <summary>
''' Acts as a global message filter to monitor user activity across the entire application.
''' It intercepts mouse movements, clicks, and keystrokes to trigger a session refresh, 
''' ensuring the session remains active while the user is interacting with the system.
''' </summary>
Public Class ActivityFilter
    Implements IMessageFilter

    Private Const WM_MOUSEMOVE As Integer = &H200
    Private Const WM_LBUTTONDOWN As Integer = &H201
    Private Const WM_KEYDOWN As Integer = &H100

    ''' <summary>
    ''' Filters Windows messages to detect user interaction.
    ''' </summary>
    Public Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
        ' Check if the message is a mouse move, left-click, or key press
        If m.Msg = WM_MOUSEMOVE OrElse m.Msg = WM_LBUTTONDOWN OrElse m.Msg = WM_KEYDOWN Then
            ' User is active, refresh the session deadline
            SessionManager.RefreshSession()
        End If

        ' Return False so the application continues to process the message normally
        Return False
    End Function
End Class