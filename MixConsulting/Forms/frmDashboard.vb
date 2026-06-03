Imports System.Windows.Forms
Imports Krypton.Toolkit
Imports Microsoft.Extensions.DependencyInjection

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
        ' Session token timeouts go here if required
    End Sub
End Class