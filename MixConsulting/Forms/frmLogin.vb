Imports System.Windows.Forms
Imports Krypton.Toolkit
Imports MiX_Consulting.Domain.MiX_Consulting.Domain.Security
Imports MiX_Consulting.Infrastructure.Repositories

Public Class frmLogin
    Inherits KryptonForm

    Private ReadOnly _userRepo As UserRepository

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        If Program.ServiceProvider IsNot Nothing Then
            _userRepo = Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService(Of UserRepository)(Program.ServiceProvider)
        End If
        ApplyCustomStyling()
    End Sub

    Public Sub New(userRepo As UserRepository)
        MyBase.New()
        InitializeComponent()
        _userRepo = userRepo
        ApplyCustomStyling()
    End Sub

    Private Sub ApplyCustomStyling()
        Me.Text = "POPIA Verification Gateway"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            KryptonMessageBox.Show("Please populate all credential.", "Validation Fault", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
            Exit Sub
        End If

        If _userRepo IsNot Nothing Then
            Dim user = _userRepo.GetByUsername(txtUsername.Text.Trim())

            If user IsNot Nothing AndAlso BcryptHelper.VerifyPassword(txtPassword.Text, user.PasswordHash) Then
                SessionManager.StartSession(user.Username)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                KryptonMessageBox.Show("Access Denied: Invalid privilege token assignment context.", "Security Rejection", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class