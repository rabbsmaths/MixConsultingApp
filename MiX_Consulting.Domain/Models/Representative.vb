''' <summary>
''' Domain business entity tracing internal corporate representative details mapped directly to a parent Company profile.
''' </summary>
Public Class Representative
    Private _representativeId As Integer
    Private _companyId As Integer
    Private _fullName As String
    Private _cellNumber As String
    Private _emailAddress As String

    Public Property RepresentativeID As Integer
        Get
            Return _representativeId
        End Get
        Set(value As Integer)
            _representativeId = value
        End Set
    End Property

    Public Property CompanyID As Integer
        Get
            Return _companyId
        End Get
        Set(value As Integer)
            _companyId = value
        End Set
    End Property

    Public Property FullName As String
        Get
            Return _fullName
        End Get
        Set(value As String)
            _fullName = value
        End Set
    End Property

    Public Property CellNumber As String
        Get
            Return _cellNumber
        End Get
        Set(value As String)
            _cellNumber = value
        End Set
    End Property

    Public Property EmailAddress As String
        Get
            Return _emailAddress
        End Get
        Set(value As String)
            _emailAddress = value
        End Set
    End Property
End Class