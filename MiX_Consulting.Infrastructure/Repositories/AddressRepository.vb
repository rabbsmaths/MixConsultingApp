Imports System.Data
Imports Dapper
Imports Microsoft.Data.SqlClient
Imports Microsoft.Extensions.Configuration
Imports MiX_Consulting.Domain.DTOs
Imports MiX_Consulting.Domain.Interfaces
Imports NLog

Namespace Repositories
    Public Class AddressRepository
        Implements IAddressRepository
        Private ReadOnly _connStr As String
        Private Shared ReadOnly ErrLogger As Logger = LogManager.GetCurrentClassLogger()

        Public Sub New(config As IConfiguration)
            _connStr = config.GetConnectionString("DefaultConnection")
            If String.IsNullOrEmpty(_connStr) Then
                Throw New InvalidOperationException("Critical database failure: DefaultConnection missing from DI configurations.")
            End If
        End Sub

        Public Function GetAllAddresses() As IEnumerable(Of AddressLookupDTO)
            Const sql As String = "SELECT AddressID, Line1, Line2, City, PostalCode FROM Addresses;"
            Try
                Using conn As New SqlConnection(_connStr)
                    Return conn.Query(Of AddressLookupDTO)(sql)
                End Using
            Catch ex As SqlException
                ErrLogger.Error(ex, "Failed gathering dictionary address registry map lists.")
                Return New List(Of AddressLookupDTO)()
            End Try
        End Function

        Public Sub AddAddress(line1 As String, line2 As String, city As String, postalCode As String)
            Const sql As String = "INSERT INTO Addresses (Line1, Line2, City, PostalCode) VALUES (@L1, @L2, @City, @Post);"
            Try
                Using conn As New SqlConnection(_connStr)
                    conn.Execute(sql, New With {.L1 = line1, .L2 = line2, .City = city, .Post = postalCode})
                End Using
            Catch ex As SqlException
                ErrLogger.Error(ex, "Insertion processing break inside the operational Address write channels.")
                Throw New ApplicationException("Could not persist the physical address profile mapping data.")
            End Try
        End Sub

        Public Sub UpdateAddress(addressId As Integer, line1 As String, line2 As String, city As String, postalCode As String)
            Const sql As String = "UPDATE Addresses SET Line1 = @L1, Line2 = @L2, City = @City, PostalCode = @Post WHERE AddressID = @ID;"
            Try
                Using conn As New SqlConnection(_connStr)
                    conn.Execute(sql, New With {.L1 = line1, .L2 = line2, .City = city, .Post = postalCode, .ID = addressId})
                End Using
            Catch ex As SqlException
                ErrLogger.Error(ex, $"Failed modifying address entry entity identifier key: {addressId}")
                Throw New ApplicationException("Execution failed when trying to apply structural updates to the address record.")
            End Try
        End Sub

        Public Sub DeleteAddress(addressId As Integer)
            Const sql As String = "DELETE FROM Addresses WHERE AddressID = @ID;"
            Try
                Using conn As New SqlConnection(_connStr)
                    conn.Execute(sql, New With {.ID = addressId})
                End Using
            Catch ex As SqlException
                ErrLogger.Error(ex, $"Constraints violation or execution fault dropping address ID: {addressId}")
                Throw New ApplicationException("The selected record could not be removed. Verify that no active corporate profiles are linked to this location.")
            End Try
        End Sub

        Private Function IAddressRepository_GetAllAddresses() As IEnumerable(Of AddressLookupDTO) Implements IAddressRepository.GetAllAddresses
            Return GetAllAddresses()
        End Function

        Private Sub IAddressRepository_AddAddress(line1 As String, line2 As String, city As String, postalCode As String) Implements IAddressRepository.AddAddress
            AddAddress(line1, line2, city, postalCode)
        End Sub

        Private Sub IAddressRepository_UpdateAddress(addressId As Integer, line1 As String, line2 As String, city As String, postalCode As String) Implements IAddressRepository.UpdateAddress
            UpdateAddress(addressId, line1, line2, city, postalCode)
        End Sub

        Private Sub IAddressRepository_DeleteAddress(addressId As Integer) Implements IAddressRepository.DeleteAddress
            DeleteAddress(addressId)
        End Sub
    End Class
End Namespace