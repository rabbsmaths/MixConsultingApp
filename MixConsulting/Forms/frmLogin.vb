Imports System.Windows.Forms
Imports Krypton.Toolkit
Imports MiX_Consulting.Domain.Security
Imports MiX_Consulting.Infrastructure.Repositories

''' <summary>
''' Front-end security portal requiring credentials verification via BCrypt before mounting administration workspaces.
''' </summary>
Public Class frmLogin
    Inherits KryptonForm

    Private WithEvents txtUsername As New KryptonTextBox() With {.Dock = DockStyle.Top}
    Private WithEvents txtPassword As New KryptonTextBox() With {.Dock = DockStyle.Top, .PasswordChar = "*"c}
    Private WithEvents btnLogin As New KryptonButton() With {.Text = "Authenticate Security Token", .Dock = DockStyle.Bottom}
    Private ReadOnly _userRepo As UserRepository

    ''' <summary>
    ''' Parameterless Constructor required by the Visual Studio Form Designer.
    ''' </summary>
    Public Sub New()
        MyBase.New()
        InitializeComponent()

        If Program.ServiceProvider IsNot Nothing Then
            _userRepo = Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService(Of UserRepository)(Program.ServiceProvider)
        End If

        InitializeCustomUI()
    End Sub

    ''' <summary>
    ''' Primary Runtime Constructor utilized by the Dependency Injection Engine.
    ''' </summary>
    Public Sub New(userRepo As UserRepository)
        MyBase.New()
        InitializeComponent()
        _userRepo = userRepo
        InitializeCustomUI()
    End Sub

    Private Sub InitializeCustomUI()
        Me.Text = "POPIA Verification Gateway"
        Me.Size = New Drawing.Size(320, 160)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False

        Me.Controls.Add(txtPassword)
        Me.Controls.Add(txtUsername)
        Me.Controls.Add(btnLogin)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            KryptonMessageBox.Show("Please populate all credential input vectors.", "Validation Fault", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
            Exit Sub
        End If

        If _userRepo IsNot Nothing Then
            Dim user = _userRepo.GetByUsername(txtUsername.Text.Trim())

            If user IsNot Nothing AndAlso BCrypt.Net.BCrypt.Verify(txtPassword.Text, user.PasswordHash) Then
                SessionManager.StartSession(user.Username)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                KryptonMessageBox.Show("Access Denied: Invalid privilege token assignment context.", "Security Rejection", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class