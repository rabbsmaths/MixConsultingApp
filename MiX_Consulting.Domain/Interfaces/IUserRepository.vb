Namespace Repositories
    Public Interface IUserRepository
        Function GetByUsername(username As String) As UserDTO
    End Interface
End Namespace