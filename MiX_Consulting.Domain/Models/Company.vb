''' <summary>
''' Core business domain entity managing company parameters, structurally isolated from direct address string components.
''' </summary>
Public Class Company
    Private _companyId As Integer
    Private _companyName As String
    Private _vatNumber As String
    Private _registrationNumber As String

    Public Property CompanyID As Integer
        Get
            Return _companyId
        End Get
        Set(value As Integer)
            _companyId = value
        End Set
    End Property

    Public Property CompanyName As String
        Get
            Return _companyName
        End Get
        Set(value As String)
            _companyName = value
        End Set
    End Property

    Public Property VatNumber As String
        Get
            Return _vatNumber
        End Get
        Set(value As String)
            _vatNumber = value
        End Set
    End Property

    Public Property RegistrationNumber As String
        Get
            Return _registrationNumber
        End Get
        Set(value As String)
            _registrationNumber = value
        End Set
    End Property
End Class