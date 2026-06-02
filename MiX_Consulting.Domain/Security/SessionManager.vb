Imports NLog

Namespace Security
    Public Module SessionManager
        Private ReadOnly AuditLogger As Logger = LogManager.GetLogger("SecurityLogger")

        Public Property ActiveUser As String
        Public Property SessionDeadline As DateTime

        Public Sub StartSession(username As String)
            ActiveUser = username
            SessionDeadline = DateTime.Now.AddMinutes(15)
            AuditLogger.Info($"Session mapping initialized for user: '{username}'.")
        End Sub

        Public Sub RefreshSession()
            If ActiveUser IsNot Nothing Then
                SessionDeadline = DateTime.Now.AddMinutes(15)
            End If
        End Sub

        Public ReadOnly Property IsExpired As Boolean
            Get
                Return ActiveUser IsNot Nothing AndAlso DateTime.Now >= SessionDeadline
            End Get
        End Property

        Public Sub TerminateSession()
            ActiveUser = Nothing
        End Sub
    End Module
End Namespace