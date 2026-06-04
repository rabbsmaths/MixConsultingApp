Imports Dapper
Imports Microsoft.Data.SqlClient
Imports Microsoft.Extensions.Configuration
Imports MiX_Consulting.Domain
Imports MiX_Consulting.Domain.Repositories
Imports NLog

Namespace Repositories
    Public Class UserRepository
        Implements IUserRepository
        Private ReadOnly _connStr As String
        Private Shared ReadOnly ErrLogger As Logger = LogManager.GetCurrentClassLogger()

        Public Sub New(config As IConfiguration)
            _connStr = config.GetConnectionString("DefaultConnection")
            If String.IsNullOrEmpty(_connStr) Then
                Throw New InvalidOperationException("Critical Failure: DefaultConnection string missing.")
            End If
        End Sub

        Public Function GetByUsername(username As String) As UserDTO Implements IUserRepository.GetByUsername
            Const sql As String = "SELECT UserID, Username, PasswordHash, IsActive FROM AuthorizedUsers WHERE Username = @Username AND IsActive = 1;"

            Try
                Using conn As New SqlConnection(_connStr)
                    Return conn.QuerySingleOrDefault(Of UserDTO)(sql, New With {.Username = username})
                End Using
            Catch ex As SqlException
                ErrLogger.Error(ex, "Database driver exception during user lookup.")
                Return Nothing
            End Try
        End Function
    End Class
End Namespace