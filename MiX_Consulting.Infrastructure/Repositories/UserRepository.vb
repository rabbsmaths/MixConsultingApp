Imports Dapper
Imports Microsoft.Data.SqlClient
Imports Microsoft.Extensions.Configuration
Imports MiX_Consulting.Domain
Imports MiX_Consulting.Domain.Models ' Adjust if your User model lives here
Imports NLog

Namespace Repositories
    Public Class UserRepository
        Private ReadOnly _connStr As String
        Private Shared ReadOnly ErrLogger As Logger = LogManager.GetCurrentClassLogger()

        ''' <summary>
        ''' Constructor accepting injected application configurations.
        ''' </summary>
        Public Sub New(config As IConfiguration)
            ' Read the string out of the centralized appsettings setup
            _connStr = config.GetConnectionString("DefaultConnection")

            If String.IsNullOrEmpty(_connStr) Then
                Throw New InvalidOperationException("Critical Failure: DefaultConnection string missing from DI configuration.")
            End If
        End Sub

        Public Function GetByUsername(username As String) As User
            Const sql As String = "SELECT UserID, Username, PasswordHash, IsActive FROM AuthorizedUsers WHERE Username = @Username AND IsActive = 1;"
            Try
                Using conn As New SqlConnection(_connStr)
                    Return conn.QuerySingleOrDefault(Of User)(sql, New With {.Username = username})
                End Using
            Catch ex As SqlException
                ErrLogger.Error(ex, "Database framework driver exception raised during identity authentication parsing.")
                Return Nothing
            End Try
        End Function
    End Class
End Namespace