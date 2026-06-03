Imports System.Data
Imports Microsoft.Data.SqlClient
Imports Dapper
Imports Microsoft.Extensions.Configuration
Imports NLog
Imports MiX_Consulting.Domain
Imports MiX_Consulting.Domain.Repositories
Imports MiX_Consulting.Domain.DTOs

Namespace Repositories
    Public Class CompanyRepository
        Implements ICompanyRepository

        Private ReadOnly _connStr As String
        Private Shared ReadOnly ErrLogger As Logger = LogManager.GetCurrentClassLogger()

        Public Sub New(config As IConfiguration)
            _connStr = config.GetConnectionString("DefaultConnection")
            If String.IsNullOrEmpty(_connStr) Then
                Throw New InvalidOperationException("Critical Failure: DefaultConnection string missing from DI configuration.")
            End If
        End Sub

        ''' <summary>
        ''' Search operation (Optimized performance, left-joins to keep companies without mapped addresses)
        ''' </summary>
        Public Function SearchCompanies(filterText As String) As IEnumerable(Of CompanySummaryDTO) Implements ICompanyRepository.SearchCompanies
            Const sql As String = "SELECT c.CompanyID, c.CompanyName, c.VatNumber, c.RegistrationNumber, " &
                                 "CONCAT_WS(', ', a.Line1, NULLIF(a.Line2, ''), a.City, a.PostalCode) AS SharedAddress " &
                                 "FROM Companies c " &
                                 "LEFT JOIN CompanyAddresses ca ON c.CompanyID = ca.CompanyID AND ca.AddressType = 'Physical' " &
                                 "LEFT JOIN Addresses a ON ca.AddressID = a.AddressID " &
                                 "WHERE c.CompanyName LIKE @Query;"
            Try
                Using conn As New SqlConnection(_connStr)
                    Return conn.Query(Of CompanySummaryDTO)(sql, New With {.Query = "%" & filterText & "%"}).ToList()
                End Using
            Catch ex As SqlException
                ErrLogger.Error(ex, $"Infrastructure relational query failure on criteria: '{filterText}'.")
                Throw New ApplicationException("A database access exception occurred processing search routines.")
            End Try
        End Function

        ''' <summary>
        ''' Create transaction with physical address bridge assignment
        ''' </summary>
        Public Sub AddCompany(companyName As String, vatNum As String, regNum As String, addressId As Integer) Implements ICompanyRepository.AddCompany
            Const insertCompanySql As String = "INSERT INTO Companies (CompanyName, VatNumber, RegistrationNumber) " &
                                               "VALUES (@Name, @Vat, @Reg); SELECT CAST(SCOPE_IDENTITY() as int);"
            Const insertBridgeSql As String = "INSERT INTO CompanyAddresses (CompanyID, AddressID, AddressType) " &
                                             "VALUES (@CoID, @AddrID, 'Physical');"
            Try
                Using conn As New SqlConnection(_connStr)
                    conn.Open()
                    Using trans = conn.BeginTransaction()
                        Dim newCompanyId As Integer = conn.QuerySingle(Of Integer)(insertCompanySql, New With {.Name = companyName, .Vat = vatNum, .Reg = regNum}, trans)

                        If addressId > 0 Then
                            conn.Execute(insertBridgeSql, New With {.CoID = newCompanyId, .AddrID = addressId}, trans)
                        End If

                        trans.Commit()
                    End Using
                End Using
            Catch ex As SqlException
                ErrLogger.Error(ex, "Transaction aborted during company write pipeline aggregation execution loops.")
                Throw New ApplicationException("Data insertion transaction dropped due to connection failure state.")
            End Try
        End Sub

        ''' <summary>
        ''' Update Operation targeting matching primary entity keys safely inside isolated transitions
        ''' </summary>
        Public Sub UpdateCompany(companyId As Integer, companyName As String, vatNum As String, regNum As String, addressId As Integer) Implements ICompanyRepository.UpdateCompany
            Const updateCoSql As String = "UPDATE Companies SET CompanyName = @Name, VatNumber = @Vat, RegistrationNumber = @Reg WHERE CompanyID = @ID;"
            Const deleteBridgeSql As String = "DELETE FROM CompanyAddresses WHERE CompanyID = @ID AND AddressType = 'Physical';"
            Const insertBridgeSql As String = "INSERT INTO CompanyAddresses (CompanyID, AddressID, AddressType) VALUES (@CoID, @AddrID, 'Physical');"

            Try
                Using conn As New SqlConnection(_connStr)
                    conn.Open()
                    Using trans = conn.BeginTransaction()
                        conn.Execute(updateCoSql, New With {.Name = companyName, .Vat = vatNum, .Reg = regNum, .ID = companyId}, trans)
                        conn.Execute(deleteBridgeSql, New With {.ID = companyId}, trans)

                        If addressId > 0 Then
                            conn.Execute(insertBridgeSql, New With {.CoID = companyId, .AddrID = addressId}, trans)
                        End If

                        trans.Commit()
                    End Using
                End Using
            Catch ex As SqlException
                ErrLogger.Error(ex, $"Failed modifying entity state contextual baseline reference ID: {companyId}")
                Throw New ApplicationException("Data updating step pipeline sequence mapping fault encountered.")
            End Try
        End Sub

        ''' <summary>
        ''' Cascading removal operation relying on database foreign key rules
        ''' </summary>
        Public Sub DeleteCompany(companyId As Integer) Implements ICompanyRepository.DeleteCompany
            Const sql As String = "DELETE FROM Companies WHERE CompanyID = @ID;"
            Try
                Using conn As New SqlConnection(_connStr)
                    conn.Execute(sql, New With {.ID = companyId})
                End Using
            Catch ex As SqlException
                ErrLogger.Error(ex, $"Deletion transaction trace dropped abruptly for element identifier Key: {companyId}")
                Throw New ApplicationException("Cascading entity removal sequence processing aborted by host layer.")
            End Try
        End Sub

        ''' <summary>
        ''' Drop-down utility dataset fetch for multi-tier selection fields
        ''' </summary>
        Public Function GetAllAddresses() As IEnumerable(Of AddressLookupDTO) Implements ICompanyRepository.GetAllAddresses
            ' Beautifully selecting individual columns lets Dapper hydrate your model fields automatically!
            Const sql As String = "SELECT AddressID, Line1, Line2, City, PostalCode FROM Addresses;"
            Try
                Using conn As New SqlConnection(_connStr)
                    Return conn.Query(Of AddressLookupDTO)(sql).ToList()
                End Using
            Catch ex As SqlException
                ErrLogger.Error(ex, "Drop-down address indexing dictionary collection populate run faulted.")
                Return New List(Of AddressLookupDTO)()
            End Try
        End Function
    End Class
End Namespace