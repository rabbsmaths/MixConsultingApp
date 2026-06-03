Namespace DTOs
    Public Class AddressLookupDTO
        Public Property AddressID As Integer
        Public Property Line1 As String
        Public Property Line2 As String
        Public Property City As String
        Public Property PostalCode As String

        Public ReadOnly Property InlineDisplay As String
            Get
                Return $"{Line1} ({City})"
            End Get
        End Property
    End Class
End Namespace