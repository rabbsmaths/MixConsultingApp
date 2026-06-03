Imports MiX_Consulting.Domain.Models

Namespace Interfaces
    Public Interface IUserRepository
        Function GetByUsername(username As String) As User
    End Interface
End Namespace