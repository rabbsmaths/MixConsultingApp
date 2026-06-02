Imports System.Windows.Forms
Imports Krypton.Toolkit
Imports Microsoft.Extensions.DependencyInjection
Imports MiX_Consulting.Domain.Security
Imports MiX_Consulting.Infrastructure.Repositories

''' <summary>
''' Central administration cockpit managing high-performance table lookups with scrolling session filters active.
''' </summary>
Public Class frmMain
    Inherits KryptonForm

    Private WithEvents sysTimer As New Timer() With {.Interval = 1000}
    Private WithEvents txtSearch As New KryptonTextBox() With {.Dock = DockStyle.Top}
    Private gridCompanies As New KryptonDataGridView() With {.Dock = DockStyle.Fill}
    Private ReadOnly _companyRepo As CompanyRepository

    ''' <summary>
    ''' Parameterless Constructor required by the Visual Studio Form Designer.
    ''' </summary>
    Public Sub New()
        MyBase.New()
        InitializeComponent()

        If Program.ServiceProvider IsNot Nothing Then
            _companyRepo = Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService(Of CompanyRepository)(Program.ServiceProvider)
        End If

        InitializeCustomUI()
    End Sub

    ''' <summary>
    ''' Primary Runtime Constructor utilized by the Dependency Injection Engine.
    ''' </summary>
    Public Sub New(companyRepo As CompanyRepository)
        MyBase.New()
        InitializeComponent()
        _companyRepo = companyRepo
        InitializeCustomUI()
    End Sub

    Private Sub InitializeCustomUI()
        Me.Text = "MiX Consulting - Enterprise Registry Monitor"
        Me.Size = New Drawing.Size(950, 520)
        Me.StartPosition = FormStartPosition.CenterScreen

        gridCompanies.AllowUserToAddRows = False
        gridCompanies.ReadOnly = True
        gridCompanies.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Me.Controls.Add(gridCompanies)
        Me.Controls.Add(txtSearch)

        sysTimer.Start()
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            If _companyRepo IsNot Nothing Then
                gridCompanies.DataSource = _companyRepo.SearchCompanies(txtSearch.Text.Trim()).ToList()
                FormatGridHeaders()
            End If
        Catch ex As Exception
            KryptonMessageBox.Show(ex.Message, "System Sync Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadData()
    End Sub

    Private Sub FormatGridHeaders()
        If gridCompanies.Columns.Count > 0 Then
            If gridCompanies.Columns("CompanyID") IsNot Nothing Then gridCompanies.Columns("CompanyID").Visible = False
            If gridCompanies.Columns("CompanyName") IsNot Nothing Then gridCompanies.Columns("CompanyName").HeaderText = "Company Title"
            If gridCompanies.Columns("VatNumber") IsNot Nothing Then gridCompanies.Columns("VatNumber").HeaderText = "VAT Identifier"
            If gridCompanies.Columns("RegistrationNumber") IsNot Nothing Then gridCompanies.Columns("RegistrationNumber").HeaderText = "Corporate Reg No."
            If gridCompanies.Columns("SharedAddress") IsNot Nothing Then gridCompanies.Columns("SharedAddress").HeaderText = "Shared Physical Location (3NF)"
        End If
    End Sub

    Private Sub sysTimer_Tick(sender As Object, e As EventArgs) Handles sysTimer.Tick
        If SessionManager.IsExpired Then
            sysTimer.Stop()
            SessionManager.TerminateSession()

            KryptonMessageBox.Show("Security boundary time ceiling reached. Desktop access context locked.", "POPIA Compliance Gate", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
            Me.Hide()

            Using relogin = Program.ServiceProvider.GetRequiredService(Of frmLogin)()
                If relogin.ShowDialog() = DialogResult.OK Then
                    sysTimer.Start()
                    Me.Show()
                    LoadData()
                Else
                    Application.Exit()
                End If
            End Using
        End If
    End Sub
End Class