Imports System.Windows.Forms
Imports Krypton.Toolkit
Imports MiX_Consulting.Infrastructure.Repositories

Public Class FrmAddressManagement
    Inherits Form

    Private ReadOnly _addressRepo As AddressRepository
    Private _selectedAddressId As Integer = 0

    Public Sub New(addressRepo As AddressRepository)
        MyBase.New()
        InitializeComponent()
        _addressRepo = addressRepo
    End Sub

    Private Sub FrmAddressManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAddresses()
    End Sub

    Private Sub LoadAddresses()
        Try
            If _addressRepo IsNot Nothing Then
                gridAddresses.DataSource = _addressRepo.GetAllAddresses().ToList()
                FormatGridHeaders()
            End If
        Catch ex As Exception
            KryptonMessageBox.Show(ex.Message, "Data Access Failure", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridAddresses_SelectionChanged(sender As Object, e As EventArgs) Handles gridAddresses.SelectionChanged
        If gridAddresses.SelectedRows.Count > 0 Then
            Dim row = gridAddresses.SelectedRows(0)
            _selectedAddressId = Convert.ToInt32(row.Cells("AddressID").Value)
            txtLine1.Text = Convert.ToString(row.Cells("Line1").Value)
            txtLine2.Text = Convert.ToString(row.Cells("Line2").Value)
            txtCity.Text = Convert.ToString(row.Cells("City").Value)
            txtPostalCode.Text = Convert.ToString(row.Cells("PostalCode").Value)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtLine1.Text) OrElse String.IsNullOrWhiteSpace(txtCity.Text) Then
            KryptonMessageBox.Show("Line 1 and City are required elements.", "Validation Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            If _selectedAddressId = 0 Then
                _addressRepo.AddAddress(txtLine1.Text.Trim(), txtLine2.Text.Trim(), txtCity.Text.Trim(), txtPostalCode.Text.Trim())
                KryptonMessageBox.Show("Physical address index registered.", "Success", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            Else
                _addressRepo.UpdateAddress(_selectedAddressId, txtLine1.Text.Trim(), txtLine2.Text.Trim(), txtCity.Text.Trim(), txtPostalCode.Text.Trim())
                KryptonMessageBox.Show("Address modifications saved.", "Success", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End If
            ResetFormState()
            LoadAddresses()
        Catch ex As Exception
            KryptonMessageBox.Show(ex.Message, "Execution Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If _selectedAddressId = 0 Then Exit Sub

        Dim confirm As DialogResult = KryptonMessageBox.Show("Are you sure you want to remove this address?", "Foreign key Rule Warning", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Try
                _addressRepo.DeleteAddress(_selectedAddressId)
                ResetFormState()
                LoadAddresses()
            Catch ex As Exception
                KryptonMessageBox.Show(ex.Message, "Constraint Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ResetFormState()
    End Sub

    Private Sub ResetFormState()
        _selectedAddressId = 0
        txtLine1.Text = String.Empty
        txtLine2.Text = String.Empty
        txtCity.Text = String.Empty
        txtPostalCode.Text = String.Empty
        gridAddresses.ClearSelection()
    End Sub

    Private Sub FormatGridHeaders()
        If gridAddresses.Columns("AddressID") IsNot Nothing Then gridAddresses.Columns("AddressID").Visible = False
        If gridAddresses.Columns("Line1") IsNot Nothing Then gridAddresses.Columns("Line1").HeaderText = "Address Line 1"
        If gridAddresses.Columns("Line2") IsNot Nothing Then gridAddresses.Columns("Line2").HeaderText = "Address Line 2"
        If gridAddresses.Columns("City") IsNot Nothing Then gridAddresses.Columns("City").HeaderText = "City"
        If gridAddresses.Columns("PostalCode") IsNot Nothing Then gridAddresses.Columns("PostalCode").HeaderText = "Postal Code"
    End Sub
End Class