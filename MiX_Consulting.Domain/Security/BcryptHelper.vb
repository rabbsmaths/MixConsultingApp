Imports BCrypt.Net

Namespace MiX_Consulting.Domain.Security
    Public Class BcryptHelper
        Private Const StandardWorkFactor As Integer = 12

        ''' <summary>
        ''' Computes an adaptive cryptographic salt and hash signature for new user creation or password updates.
        ''' </summary>
        Public Shared Function HashPassword(plainText As String) As String
            If String.IsNullOrWhiteSpace(plainText) Then Return String.Empty
            Return BCrypt.Net.BCrypt.HashPassword(plainText, StandardWorkFactor)
        End Function

        ''' <summary>
        ''' Compares plain-text login inputs securely against an existing extracted database signature.
        ''' </summary>
        Public Shared Function VerifyPassword(plainText As String, hashedRecord As String) As Boolean
            If String.IsNullOrWhiteSpace(plainText) OrElse String.IsNullOrWhiteSpace(hashedRecord) Then Return False
            Try
                Return BCrypt.Net.BCrypt.Verify(plainText, hashedRecord)
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class
End Namespace