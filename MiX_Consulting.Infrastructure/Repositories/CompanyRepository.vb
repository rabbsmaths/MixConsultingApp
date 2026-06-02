Imports Microsoft.Data.SqlClient
Imports Dapper
Imports Microsoft.Extensions.Configuration
Imports NLog

Namespace Repositories
    Public Class CompanyRepository
        Private ReadOnly _connStr As String
        Private Shared ReadOnly ErrLogger As Logger = LogManager.GetCurrentClassLogger()

        ''' <summary>
        ''' Constructor accepting injected application configurations.
        ''' </summary>
        Public Sub New(config As IConfiguration)
            _connStr = config.GetConnectionString("DefaultConnection")

            If String.IsNullOrEmpty(_connStr) Then
                Throw New InvalidOperationException("Critical Failure: DefaultConnection string missing from DI configuration.")
            End If
        End Sub

        Public Function SearchCompanies(filterText As String) As IEnumerable(Of Object)
            Const sql As String = "SELECT c.CompanyID, c.CompanyName, c.VatNumber, c.RegistrationNumber, " &
                                 "a.Line1 + ', ' + ISNULL(a.Line2, '') + ', ' + a.City + ' ' + a.PostalCode AS SharedAddress " &
                                 "FROM Companies c " &
                                 "INNER JOIN CompanyAddresses ca ON c.CompanyID = ca.CompanyID " &
                                 "INNER JOIN Addresses a ON ca.AddressID = a.AddressID " &
                                 "WHERE ca.AddressType = 'Physical' AND c.CompanyName LIKE @Query;"
            Try
                Using conn As New SqlConnection(_connStr)
                    Return conn.Query(Of Object)(sql, New With {.Query = "%" & filterText & "%"})
                End Using
            Catch ex As SqlException
                ErrLogger.Error(ex, $"Many-to-many infrastructure relation break occurring on query: '{filterText}'.")
                Throw New ApplicationException("A connectivity error prevented successful execution of the company profiling request loop.")
            End Try
        End Function
    End Class
End Namespace