Imports System.Windows.Forms
Imports Krypton.Toolkit
Imports MiX_Consulting.Infrastructure.Repositories

Public Class FrmCompanyManagement
    Inherits Form

    Private ReadOnly _companyRepo As CompanyRepository
    Private _selectedCompanyId As Integer = 0

    Public Sub New(companyRepo As CompanyRepository)
        MyBase.New()
        InitializeComponent()
        _companyRepo = companyRepo
    End Sub

    Private Sub FrmCompanyManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            KryptonMessageBox.Show(ex.Message, "Sync Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RefreshAddressDropdown()
        Try
            If _companyRepo IsNot Nothing Then
                cmbAddresses.DataSource = _companyRepo.GetAllAddresses().ToList()
                cmbAddresses.DisplayMember = "InlineDisplay"
                cmbAddresses.ValueMember = "AddressID"
                cmbAddresses.SelectedIndex = -1
            End If
        Catch ex As Exception
            KryptonMessageBox.Show("Could not initialize dictionary layout lists.", "Lookup Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
        End Try
    End Sub

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
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtCompanyName.Text) Then
            KryptonMessageBox.Show("Company Name is a required structural parameter.", "Validation Rule", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim targetAddrId As Integer = 0
        If cmbAddresses.SelectedValue IsNot Nothing Then
            targetAddrId = Convert.ToInt32(cmbAddresses.SelectedValue)
        End If

        Try
            If _selectedCompanyId = 0 Then
                _companyRepo.AddCompany(txtCompanyName.Text.Trim(), txtVatNumber.Text.Trim(), txtRegNumber.Text.Trim(), targetAddrId)
                KryptonMessageBox.Show("Corporate profile recorded successfully.", "Execution Complete", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            Else
                _companyRepo.UpdateCompany(_selectedCompanyId, txtCompanyName.Text.Trim(), txtVatNumber.Text.Trim(), txtRegNumber.Text.Trim(), targetAddrId)
                KryptonMessageBox.Show("Profile adjustments updated.", "Execution Complete", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End If
            ResetFormState()
            LoadData()
        Catch ex As Exception
            KryptonMessageBox.Show(ex.Message, "Transaction Fault", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If _selectedCompanyId = 0 Then Exit Sub

        Dim confirm As DialogResult = KryptonMessageBox.Show("Are you sure you want to delete this profile context?", "POPIA Boundary Check", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Try
                _companyRepo.DeleteCompany(_selectedCompanyId)
                ResetFormState()
                LoadData()
            Catch ex As Exception
                KryptonMessageBox.Show(ex.Message, "Purge Failure", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
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
        gridCompanies.ClearSelection()
    End Sub

    Private Sub FormatGridHeaders()
        If gridCompanies.Columns.Count > 0 Then
            If gridCompanies.Columns("CompanyID") IsNot Nothing Then gridCompanies.Columns("CompanyID").Visible = False
            If gridCompanies.Columns("CompanyName") IsNot Nothing Then gridCompanies.Columns("CompanyName").HeaderText = "Company Title"
            If gridCompanies.Columns("VatNumber") IsNot Nothing Then gridCompanies.Columns("VatNumber").HeaderText = "VAT Identifier"
            If gridCompanies.Columns("RegistrationNumber") IsNot Nothing Then gridCompanies.Columns("RegistrationNumber").HeaderText = "Corporate Reg No."
            If gridCompanies.Columns("SharedAddress") IsNot Nothing Then gridCompanies.Columns("SharedAddress").HeaderText = "Linked Location"
        End If
    End Sub
End Class