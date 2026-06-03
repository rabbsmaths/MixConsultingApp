Imports System.Windows.Forms
Imports Krypton.Toolkit
Imports Microsoft.Extensions.DependencyInjection
Imports MiX_Consulting.Domain.MiX_Consulting.Domain.Security
Imports MiX_Consulting.Infrastructure.Repositories

Public Class FrmMain
    Inherits KryptonForm

    Private ReadOnly _companyRepo As CompanyRepository
    Private _selectedCompanyId As Integer = 0

    ''' <summary>
    ''' Parameterless constructor explicitly required for visual engine designer rendering stability.
    ''' </summary>
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        If Program.ServiceProvider IsNot Nothing Then
            _companyRepo = Program.ServiceProvider.GetRequiredService(Of CompanyRepository)()
        End If
        ConfigureWorkspaceLayout()
    End Sub

    ''' <summary>
    ''' Modern Dependency Injection constructor used seamlessly by the Program Module runtime pipeline.
    ''' </summary>
    Public Sub New(companyRepo As CompanyRepository)
        MyBase.New()
        InitializeComponent()
        _companyRepo = companyRepo
        ConfigureWorkspaceLayout()
    End Sub

    Private Sub ConfigureWorkspaceLayout()
        Me.Text = "MiX Consulting - Enterprise Registry Monitor"
        Me.StartPosition = FormStartPosition.CenterScreen

        gridCompanies.AllowUserToAddRows = False
        gridCompanies.ReadOnly = True
        gridCompanies.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        sysTimer.Start()

        RefreshAddressDropdown()
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            If _companyRepo IsNot Nothing Then
                Dim results = _companyRepo.SearchCompanies(txtSearch.Text.Trim())
                gridCompanies.DataSource = results.ToList()
                FormatGridHeaders()
            End If
        Catch ex As Exception
            KryptonMessageBox.Show(ex.Message, "System Sync Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RefreshAddressDropdown()
        Try
            If _companyRepo IsNot Nothing Then
                Dim addressList = _companyRepo.GetAllAddresses().ToList()

                cmbAddresses.DataSource = addressList
                cmbAddresses.DisplayMember = "InlineDisplay"
                cmbAddresses.ValueMember = "AddressID"
                cmbAddresses.SelectedIndex = -1
            End If
        Catch ex As Exception
            KryptonMessageBox.Show("Could not initialize relational address lookup lists.", "Data Dictionary Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
        End Try
    End Sub

    ' Explicitly capitalized naming structure to pass code analysis criteria rule compliance
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadData()
    End Sub

    Private Sub GridCompanies_SelectionChanged(sender As Object, e As EventArgs) Handles gridCompanies.SelectionChanged
        If gridCompanies.SelectedRows.Count > 0 Then
            Dim row = gridCompanies.SelectedRows(0)

            _selectedCompanyId = Convert.ToInt32(row.Cells("CompanyID").Value)
            txtCompanyName.Text = Convert.ToString(row.Cells("CompanyName").Value)
            txtVatNumber.Text = Convert.ToString(row.Cells("VatNumber").Value)
            txtRegNumber.Text = Convert.ToString(row.Cells("RegistrationNumber").Value)

            cmbAddresses.SelectedIndex = -1
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtCompanyName.Text) Then
            KryptonMessageBox.Show("Company Name is an absolute structural prerequisite record layer.", "Validation Fault", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim assignedAddressId As Integer = 0
        If cmbAddresses.SelectedValue IsNot Nothing Then
            assignedAddressId = Convert.ToInt32(cmbAddresses.SelectedValue)
        End If

        Try
            If _selectedCompanyId = 0 Then
                _companyRepo.AddCompany(txtCompanyName.Text.Trim(), txtVatNumber.Text.Trim(), txtRegNumber.Text.Trim(), assignedAddressId)
                KryptonMessageBox.Show("Corporate profile identity written to ledger successfully.", "Execution Complete", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            Else
                _companyRepo.UpdateCompany(_selectedCompanyId, txtCompanyName.Text.Trim(), txtVatNumber.Text.Trim(), txtRegNumber.Text.Trim(), assignedAddressId)
                KryptonMessageBox.Show("Profile modifications updated across storage frameworks.", "Execution Complete", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End If

            ResetFormState()
            LoadData()
        Catch ex As Exception
            KryptonMessageBox.Show(ex.Message, "Transaction Failure", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If _selectedCompanyId = 0 Then
            KryptonMessageBox.Show("Please select an active grid record matrix row before triggering removal loops.", "Action Aborted", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirm As DialogResult = KryptonMessageBox.Show("Are you completely certain you wish to irreversibly remove this corporate profile context entry?", "POPIA Boundary Warning", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            Try
                _companyRepo.DeleteCompany(_selectedCompanyId)
                ResetFormState()
                LoadData()
            Catch ex As Exception
                KryptonMessageBox.Show(ex.Message, "Data Purge Failure", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ResetFormState()
    End Sub

    Private Sub ResetFormState()
        _selectedCompanyId = 0
        txtCompanyName.Text = String.Empty
        txtVatNumber.Text = String.Empty
        txtRegNumber.Text = String.Empty
        cmbAddresses.SelectedIndex = -1
        If gridCompanies.DataSource IsNot Nothing Then
            gridCompanies.ClearSelection()
        End If
    End Sub

    Private Sub MenuItemManageAddresses_Click(sender As Object, e As EventArgs) Handles menuItemManageAddresses.Click
        KryptonMessageBox.Show("Redirecting context window to Address Management Panel Matrix...", "Navigation Intercept", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
        RefreshAddressDropdown()
    End Sub

    Private Sub FormatGridHeaders()
        If gridCompanies.Columns.Count > 0 Then
            If gridCompanies.Columns("CompanyID") IsNot Nothing Then gridCompanies.Columns("CompanyID").Visible = False
            If gridCompanies.Columns("CompanyName") IsNot Nothing Then gridCompanies.Columns("CompanyName").HeaderText = "Company Title"
            If gridCompanies.Columns("VatNumber") IsNot Nothing Then gridCompanies.Columns("VatNumber").HeaderText = "VAT Identifier"
            If gridCompanies.Columns("RegistrationNumber") IsNot Nothing Then gridCompanies.Columns("RegistrationNumber").HeaderText = "Corporate Reg No."
            If gridCompanies.Columns("SharedAddress") IsNot Nothing Then gridCompanies.Columns("SharedAddress").HeaderText = "Shared Physical Location"
        End If
    End Sub

    Private Sub SysTimer_Tick(sender As Object, e As EventArgs) Handles sysTimer.Tick
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