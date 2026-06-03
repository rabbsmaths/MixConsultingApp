Imports MiX_Consulting.Domain.DTOs

Namespace Interfaces
    Public Interface IAddressRepository
        Function GetAllAddresses() As IEnumerable(Of AddressLookupDTO)

        Sub AddAddress(line1 As String, line2 As String, city As String, postalCode As String)

        Sub UpdateAddress(addressId As Integer, line1 As String, line2 As String, city As String, postalCode As String)

        Sub DeleteAddress(addressId As Integer)
    End Interface
End Namespace