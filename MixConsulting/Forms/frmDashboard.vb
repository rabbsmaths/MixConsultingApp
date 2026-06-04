Imports System.Windows.Forms
Imports Krypton.Toolkit
Imports Microsoft.Extensions.DependencyInjection
Imports MiX_Consulting.Domain.MiX_Consulting.Domain.Security

Public Class frmDashboard
    Inherits KryptonForm

    Private _activeForm As Form = Nothing

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sysTimer IsNot Nothing Then
            sysTimer.Start()
        End If
        ' Load your company database management view as the default startup panel
        NavigateToWorkspace(Of FrmCompanyManagement)()
    End Sub

    Private Sub BtnManageCompanies_Click(sender As Object, e As EventArgs) Handles btnManageCompanies.Click
        NavigateToWorkspace(Of FrmCompanyManagement)()
    End Sub

    Private Sub BtnManageAddresses_Click(sender As Object, e As EventArgs) Handles btnManageAddresses.Click
        NavigateToWorkspace(Of FrmAddressManagement)()
    End Sub
    Private Sub BtnManageReps_Click(sender As Object, e As EventArgs) Handles btnManageReps.Click
        NavigateToWorkspace(Of FrmRepresentativeManagement)()
    End Sub
    Private Sub NavigateToWorkspace(Of T As Form)()
        If _activeForm IsNot Nothing Then
            _activeForm.Close()
            _activeForm.Dispose()
        End If

        If Program.ServiceProvider IsNot Nothing Then
            _activeForm = Program.ServiceProvider.GetRequiredService(Of T)()
            _activeForm.TopLevel = False
            _activeForm.FormBorderStyle = FormBorderStyle.None
            _activeForm.Dock = DockStyle.Fill

            panelMainWorkspace.Controls.Add(_activeForm)
            panelMainWorkspace.Tag = _activeForm
            _activeForm.Show()
        End If
    End Sub

    Private Sub SysTimer_Tick(sender As Object, e As EventArgs) Handles sysTimer.Tick
        ' Check if the session has expired
        If SessionManager.IsExpired Then
            ' Stop timer to prevent multiple triggers
            sysTimer.Stop()

            ' Notify the user
            KryptonMessageBox.Show("Your session has expired due to inactivity. Please log in again.",
                                   "Session Expired",
                                   KryptonMessageBoxButtons.OK,
                                   KryptonMessageBoxIcon.Information)

            ' Terminate session context
            SessionManager.TerminateSession()

            ' Close the dashboard to return to the login screen
            Me.DialogResult = DialogResult.Abort ' Or use a custom status
            Me.Close()
        End If
    End Sub

    Private Sub frmDashboard_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        SessionManager.RefreshSession()
    End Sub

End Class