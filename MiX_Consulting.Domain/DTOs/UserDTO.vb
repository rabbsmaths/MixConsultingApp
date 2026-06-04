''' <summary>
''' Data Transfer Object for User information, excluding sensitive authentication credentials.
''' </summary>
Public Class UserDTO
    Public Property UserID As Integer
    Public Property Username As String
    Public Property PasswordHash As String
    Public Property IsActive As Boolean
End Class