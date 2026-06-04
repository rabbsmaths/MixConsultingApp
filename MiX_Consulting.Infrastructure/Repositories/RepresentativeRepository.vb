Imports System.Data
Imports Dapper
Imports Microsoft.Data.SqlClient
Imports Microsoft.Extensions.Configuration
Imports MiX_Consulting.Domain
Imports MiX_Consulting.Domain.Interfaces
Imports NLog

Namespace Repositories
    Public Class RepresentativeRepository
        Implements IRepresentativeRepository

        Private ReadOnly _connStr As String
        Private Shared ReadOnly ErrLogger As Logger = LogManager.GetCurrentClassLogger()

        Public Sub New(config As IConfiguration)
            _connStr = config.GetConnectionString("DefaultConnection")
            If String.IsNullOrEmpty(_connStr) Then
                Throw New InvalidOperationException("Critical Failure: DefaultConnection string missing from DI configuration.")
            End If
        End Sub

        Public Function SearchRepresentatives(filterText As String) As IEnumerable(Of RepresentativeDTO) Implements IRepresentativeRepository.SearchRepresentatives
            Const sql As String = "SELECT r.RepresentativeID, r.CompanyID, c.CompanyName, r.FullName, r.CellNumber, r.EmailAddress " &
                          "FROM Representatives r " &
                          "INNER JOIN Companies c ON r.CompanyID = c.CompanyID " &
                          "WHERE r.FullName LIKE @Query;"
            Try
                Using conn As New SqlConnection(_connStr)
                    Return conn.Query(Of RepresentativeDTO)(sql, New With {.Query = "%" & filterText & "%"}).ToList()
                End Using
            Catch ex As SqlException
                ErrLogger.Error(ex, $"Failed to search for representatives with filter: '{filterText}'.")
                Throw New ApplicationException("An error occurred while searching for representatives.")
            End Try
        End Function

        Public Function GetCompaniesLookup() As IEnumerable(Of KeyValuePair(Of Integer, String)) Implements IRepresentativeRepository.GetCompaniesLookup
            Const sql As String = "SELECT CompanyID AS [Key], CompanyName AS [Value] FROM Companies ORDER BY CompanyName;"
            Try
                Using conn As New SqlConnection(_connStr)
                    Return conn.Query(Of KeyValuePair(Of Integer, String))(sql).ToList()
                End Using
            Catch ex As SqlException
                ErrLogger.Error(ex, "Failed to load the list of companies.")
                Return New List(Of KeyValuePair(Of Integer, String))()
            End Try
        End Function

        Public Sub AddRepresentative(companyId As Integer, fullName As String, cellNumber As String, emailAddress As String) Implements IRepresentativeRepository.AddRepresentative
            Const sql As String = "INSERT INTO Representatives (CompanyID, FullName, CellNumber, EmailAddress) VALUES (@CoID, @Name, @Cell, @Email);"
            Try
                Using conn As New SqlConnection(_connStr)
                    conn.Execute(sql, New With {.CoID = companyId, .Name = fullName, .Cell = cellNumber, .Email = emailAddress})
                End Using
            Catch ex As SqlException
                ErrLogger.Error(ex, "Failed to save the new representative.")
                Throw New ApplicationException("Could not save the representative profile.")
            End Try
        End Sub

        Public Sub UpdateRepresentative(repId As Integer, companyId As Integer, fullName As String, cellNumber As String, emailAddress As String) Implements IRepresentativeRepository.UpdateRepresentative
            Const sql As String = "UPDATE Representatives SET CompanyID = @CoID, FullName = @Name, CellNumber = @Cell, EmailAddress = @Email WHERE RepresentativeID = @ID;"
            Try
                Using conn As New SqlConnection(_connStr)
                    conn.Execute(sql, New With {.CoID = companyId, .Name = fullName, .Cell = cellNumber, .Email = emailAddress, .ID = repId})
                End Using
            Catch ex As SqlException
                ErrLogger.Error(ex, $"Failed to update representative ID: {repId}")
                Throw New ApplicationException("Could not update the representative profile.")
            End Try
        End Sub

        Public Sub DeleteRepresentative(repId As Integer) Implements IRepresentativeRepository.DeleteRepresentative
            Const sql As String = "DELETE FROM Representatives WHERE RepresentativeID = @ID;"
            Try
                Using conn As New SqlConnection(_connStr)
                    conn.Execute(sql, New With {.ID = repId})
                End Using
            Catch ex As SqlException
                ErrLogger.Error(ex, $"Failed to delete representative ID: {repId}")
                Throw New ApplicationException("The representative profile could not be deleted.")
            End Try
        End Sub
    End Class
End Namespace