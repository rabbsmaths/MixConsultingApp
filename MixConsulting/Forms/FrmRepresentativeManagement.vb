Imports System.Windows.Forms
Imports Krypton.Toolkit
Imports MiX_Consulting.Domain.Interfaces
Imports MiX_Consulting.Domain.Models
Imports MiX_Consulting.Domain.Repositories

Public Class FrmRepresentativeManagement
    Inherits Form

    Private ReadOnly _repRepo As IRepresentativeRepository
    Private _selectedRepId As Integer = 0

    Public Sub New(repRepo As IRepresentativeRepository)
        MyBase.New()
        InitializeComponent()
        _repRepo = repRepo
    End Sub

    Private Sub FrmRepresentativeManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCompanyDropdown()
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            If _repRepo IsNot Nothing Then
                Dim dataRows = _repRepo.SearchRepresentatives(txtSearch.Text.Trim())
                gridReps.DataSource = dataRows.ToList()
                FormatGridHeaders()
            End If
        Catch ex As Exception
            KryptonMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RefreshCompanyDropdown()
        Try
            If _repRepo IsNot Nothing Then
                Dim corporations = _repRepo.GetCompaniesLookup().ToList()
                cmbCompanies.DataSource = Nothing

                ' Explicit binding sequence configuration mechanics
                cmbCompanies.ValueMember = "Key"
                cmbCompanies.DisplayMember = "Value"
                cmbCompanies.DataSource = corporations
                cmbCompanies.SelectedIndex = -1
            End If
        Catch ex As Exception
            KryptonMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadData()
    End Sub

    Private Sub GridReps_SelectionChanged(sender As Object, e As EventArgs) Handles gridReps.SelectionChanged
        If gridReps.SelectedRows.Count > 0 Then
            Dim row = gridReps.SelectedRows(0)
            _selectedRepId = Convert.ToInt32(row.Cells("RepresentativeID").Value)
            txtFullName.Text = Convert.ToString(row.Cells("FullName").Value)
            txtCell.Text = Convert.ToString(row.Cells("CellNumber").Value)
            txtEmail.Text = Convert.ToString(row.Cells("EmailAddress").Value)
            cmbCompanies.SelectedValue = Convert.ToInt32(row.Cells("CompanyID").Value)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbCompanies.SelectedValue Is Nothing Then
            KryptonMessageBox.Show("Please select a company.", "Missing Information", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtFullName.Text) Then
            KryptonMessageBox.Show("Please enter the representative's full name.", "Missing Information", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim companyId As Integer = Convert.ToInt32(cmbCompanies.SelectedValue)

        Try
            If _selectedRepId = 0 Then
                _repRepo.AddRepresentative(companyId, txtFullName.Text.Trim(), txtCell.Text.Trim(), txtEmail.Text.Trim())
                KryptonMessageBox.Show("The representative has been saved.", "Saved", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            Else
                _repRepo.UpdateRepresentative(_selectedRepId, companyId, txtFullName.Text.Trim(), txtCell.Text.Trim(), txtEmail.Text.Trim())
                KryptonMessageBox.Show("The representative has been updated.", "Updated", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End If
            ResetFormState()
            LoadData()
        Catch ex As Exception
            KryptonMessageBox.Show("An error occurred while saving. Please try again.", "Save Failed", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If _selectedRepId = 0 Then Exit Sub

        Dim check As DialogResult = KryptonMessageBox.Show("Are you sure you want to delete this representative?", "Confirm Delete", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question)
        If check = DialogResult.Yes Then
            Try
                _repRepo.DeleteRepresentative(_selectedRepId)
                ResetFormState()
                LoadData()
            Catch ex As Exception
                KryptonMessageBox.Show("The representative could not be deleted. Please try again.", "Delete Failed", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ResetFormState()
    End Sub

    Private Sub ResetFormState()
        _selectedRepId = 0
        txtFullName.Text = String.Empty
        txtCell.Text = String.Empty
        txtEmail.Text = String.Empty
        cmbCompanies.SelectedIndex = -1
        gridReps.ClearSelection()
    End Sub

    Private Sub FormatGridHeaders()
        If gridReps.Columns.Count > 0 Then
            ' Hide IDs
            If gridReps.Columns("RepresentativeID") IsNot Nothing Then gridReps.Columns("RepresentativeID").Visible = False
            If gridReps.Columns("CompanyID") IsNot Nothing Then gridReps.Columns("CompanyID").Visible = False

            ' Display new column
            If gridReps.Columns("CompanyName") IsNot Nothing Then
                gridReps.Columns("CompanyName").HeaderText = "Company"
                gridReps.Columns("CompanyName").DisplayIndex = 0
            End If

            ' Existing headers
            If gridReps.Columns("FullName") IsNot Nothing Then gridReps.Columns("FullName").HeaderText = "Contact Full Name"
            If gridReps.Columns("CellNumber") IsNot Nothing Then gridReps.Columns("CellNumber").HeaderText = "Mobile Line"
            If gridReps.Columns("EmailAddress") IsNot Nothing Then gridReps.Columns("EmailAddress").HeaderText = "Email Target Address"
        End If
    End Sub
End Class