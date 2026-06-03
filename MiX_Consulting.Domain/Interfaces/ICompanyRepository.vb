Imports System.Collections.Generic
Imports MiX_Consulting.Domain.DTOs

Namespace Interfaces
    Public Interface ICompanyRepository

        ''' <summary>
        ''' Searches for companies matching the filtered text criteria.
        ''' </summary>
        Function SearchCompanies(filterText As String) As IEnumerable(Of CompanySummaryDTO)

        ''' <summary>
        ''' Commits a new company record alongside its physical address routing bridge.
        ''' </summary>
        Sub AddCompany(companyName As String, vatNum As String, regNum As String, addressId As Integer)

        ''' <summary>
        ''' Modifies an existing company record and synchronizes its structural address assignment.
        ''' </summary>
        Sub UpdateCompany(companyId As Integer, companyName As String, vatNum As String, regNum As String, addressId As Integer)

        ''' <summary>
        ''' Removes a company record entirely from the database.
        ''' </summary>
        Sub DeleteCompany(companyId As Integer)

        ''' <summary>
        ''' Fetches structural address data formatted for multi-tier selection dropdown fields.
        ''' </summary>
        Function GetAllAddresses() As IEnumerable(Of AddressLookupDTO)

    End Interface
End Namespace