Namespace DTOs
    Public Class AddressLookupDTO
        Public Property AddressID As Integer
        Public Property Line1 As String
        Public Property Line2 As String
        Public Property City As String
        Public Property PostalCode As String

        ' MUST BE EXPLICITLY PUBLIC!
        Public ReadOnly Property InlineDisplay As String
            Get
                ' Fallback checks handle unassigned fields safely
                Dim street As String = If(String.IsNullOrWhiteSpace(Line1), "No Street Address", Line1)
                Dim location As String = If(String.IsNullOrWhiteSpace(City), "Unknown City", City)
                Return $"{street} ({location})"
            End Get
        End Property
    End Class
End Namespace