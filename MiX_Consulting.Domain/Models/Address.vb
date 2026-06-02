''' <summary>
''' Standalone domain entity capturing geographical coordinates, completely normalized to decouple from specific companies.
''' </summary>
Public Class Address
    Private _addressId As Integer
    Private _line1 As String
    Private _line2 As String
    Private _city As String
    Private _postalCode As String

    Public Property AddressID As Integer
        Get
            Return _addressId
        End Get
        Set(value As Integer)
            _addressId = value
        End Set
    End Property

    Public Property Line1 As String
        Get
            Return _line1
        End Get
        Set(value As String)
            _line1 = value
        End Set
    End Property

    Public Property Line2 As String
        Get
            Return _line2
        End Get
        Set(value As String)
            _line2 = value
        End Set
    End Property

    Public Property City As String
        Get
            Return _city
        End Get
        Set(value As String)
            _city = value
        End Set
    End Property

    Public Property PostalCode As String
        Get
            Return _postalCode
        End Get
        Set(value As String)
            _postalCode = value
        End Set
    End Property
End Class