Imports MiX_Consulting.Domain.Models

Namespace Repositories
    Public Interface IRepresentativeRepository
        Function SearchRepresentatives(filterText As String) As IEnumerable(Of Representative)
        Function GetCompaniesLookup() As IEnumerable(Of KeyValuePair(Of Integer, String))
        Sub AddRepresentative(companyId As Integer, fullName As String, cellNumber As String, emailAddress As String)
        Sub UpdateRepresentative(repId As Integer, companyId As Integer, fullName As String, cellNumber As String, emailAddress As String)
        Sub DeleteRepresentative(repId As Integer)
    End Interface
End Namespace