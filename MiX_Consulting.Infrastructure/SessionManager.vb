Imports NLog

Namespace MiX_Consulting.Domain.Security
    Public Module SessionManager
        Private ReadOnly AuditLogger As Logger = LogManager.GetLogger("SecurityLogger")

        Public Property ActiveUser As String
        Public Property SessionDeadline As DateTime
        Private ReadOnly InactivityLimitMinutes As Integer = 1

        Public Sub StartSession(username As String)
            ActiveUser = username
            SessionDeadline = DateTime.Now.AddMinutes(InactivityLimitMinutes)
            AuditLogger.Info($"Context identity mapping verified for user: '{username}'.")
        End Sub

        Public Sub RefreshSession()
            If ActiveUser IsNot Nothing Then
                SessionDeadline = DateTime.Now.AddMinutes(InactivityLimitMinutes)
            End If
        End Sub

        Public ReadOnly Property IsExpired As Boolean
            Get
                Return ActiveUser IsNot Nothing AndAlso DateTime.Now >= SessionDeadline
            End Get
        End Property

        Public Sub TerminateSession()
            AuditLogger.Warn($"Session terminated automatically due to inactivity timeout limits for user: '{ActiveUser}'.")
            ActiveUser = Nothing
        End Sub
    End Module
End Namespace