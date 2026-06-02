''' <summary>
''' Domain entity tracking authenticated administrative security users authorized under POPIA boundaries.
''' </summary>
Public Class User
    Private _userId As Integer
    Private _username As String
    Private _passwordHash As String
    Private _isActive As Boolean

    Public Property UserID As Integer
        Get
            Return _userId
        End Get
        Set(value As Integer)
            _userId = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property PasswordHash As String
        Get
            Return _passwordHash
        End Get
        Set(value As String)
            _passwordHash = value
        End Set
    End Property

    Public Property IsActive As Boolean
        Get
            Return _isActive
        End Get
        Set(value As Boolean)
            _isActive = value
        End Set
    End Property
End Class