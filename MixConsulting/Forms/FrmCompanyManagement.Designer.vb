<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCompanyManagement
    Inherits System.Windows.Forms.Form

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        panelTop = New Krypton.Toolkit.KryptonPanel()
        btnSearch = New Krypton.Toolkit.KryptonButton()
        lblSearchTitle = New Krypton.Toolkit.KryptonLabel()
        txtSearch = New Krypton.Toolkit.KryptonTextBox()
        gridCompanies = New Krypton.Toolkit.KryptonDataGridView()
        panelCrud = New Krypton.Toolkit.KryptonPanel()
        lblAddressSelect = New Krypton.Toolkit.KryptonLabel()
        cmbAddresses = New Krypton.Toolkit.KryptonComboBox()
        btnDelete = New Krypton.Toolkit.KryptonButton()
        btnSave = New Krypton.Toolkit.KryptonButton()
        btnClear = New Krypton.Toolkit.KryptonButton()
        txtRegNumber = New Krypton.Toolkit.KryptonTextBox()
        lblRegNumber = New Krypton.Toolkit.KryptonLabel()
        txtVatNumber = New Krypton.Toolkit.KryptonTextBox()
        lblVatNumber = New Krypton.Toolkit.KryptonLabel()
        txtCompanyName = New Krypton.Toolkit.KryptonTextBox()
        lblCompanyName = New Krypton.Toolkit.KryptonLabel()
        CType(panelTop, ComponentModel.ISupportInitialize).BeginInit()
        panelTop.SuspendLayout()
        CType(gridCompanies, ComponentModel.ISupportInitialize).BeginInit()
        CType(panelCrud, ComponentModel.ISupportInitialize).BeginInit()
        panelCrud.SuspendLayout()
        CType(cmbAddresses, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelTop
        ' 
        panelTop.Controls.Add(btnSearch)
        panelTop.Controls.Add(lblSearchTitle)
        panelTop.Controls.Add(txtSearch)
        panelTop.Dock = DockStyle.Top
        panelTop.Location = New Point(0, 0)
        panelTop.Name = "panelTop"
        panelTop.Size = New Size(1019, 60)
        panelTop.TabIndex = 0
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(602, 16)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(120, 30)
        btnSearch.TabIndex = 1
        btnSearch.Values.DropDownArrowColor = Color.Empty
        btnSearch.Values.Text = "Execute Search"
        ' 
        ' lblSearchTitle
        ' 
        lblSearchTitle.Location = New Point(12, 18)
        lblSearchTitle.Name = "lblSearchTitle"
        lblSearchTitle.Size = New Size(176, 24)
        lblSearchTitle.TabIndex = 2
        lblSearchTitle.Values.Text = "Search Corporate Client:"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(207, 16)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(380, 27)
        txtSearch.TabIndex = 0
        ' 
        ' gridCompanies
        ' 
        gridCompanies.AllowUserToAddRows = False
        gridCompanies.AllowUserToDeleteRows = False
        gridCompanies.BorderStyle = BorderStyle.None
        gridCompanies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gridCompanies.Dock = DockStyle.Fill
        gridCompanies.Location = New Point(0, 60)
        gridCompanies.Name = "gridCompanies"
        gridCompanies.ReadOnly = True
        gridCompanies.RowHeadersWidth = 51
        gridCompanies.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        gridCompanies.Size = New Size(1019, 461)
        gridCompanies.TabIndex = 1
        ' 
        ' panelCrud
        ' 
        panelCrud.Controls.Add(lblAddressSelect)
        panelCrud.Controls.Add(cmbAddresses)
        panelCrud.Controls.Add(btnDelete)
        panelCrud.Controls.Add(btnSave)
        panelCrud.Controls.Add(btnClear)
        panelCrud.Controls.Add(txtRegNumber)
        panelCrud.Controls.Add(lblRegNumber)
        panelCrud.Controls.Add(txtVatNumber)
        panelCrud.Controls.Add(lblVatNumber)
        panelCrud.Controls.Add(txtCompanyName)
        panelCrud.Controls.Add(lblCompanyName)
        panelCrud.Dock = DockStyle.Bottom
        panelCrud.Location = New Point(0, 521)
        panelCrud.Name = "panelCrud"
        panelCrud.Size = New Size(1019, 160)
        panelCrud.TabIndex = 2
        ' 
        ' lblAddressSelect
        ' 
        lblAddressSelect.Location = New Point(366, 20)
        lblAddressSelect.Name = "lblAddressSelect"
        lblAddressSelect.Size = New Size(128, 24)
        lblAddressSelect.TabIndex = 0
        lblAddressSelect.Values.Text = "Physical Address:"
        ' 
        ' cmbAddresses
        ' 
        cmbAddresses.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAddresses.DropDownWidth = 350
        cmbAddresses.Location = New Point(500, 20)
        cmbAddresses.Name = "cmbAddresses"
        cmbAddresses.Size = New Size(350, 26)
        cmbAddresses.TabIndex = 3
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(640, 65)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(120, 35)
        btnDelete.TabIndex = 5
        btnDelete.Values.DropDownArrowColor = Color.Empty
        btnDelete.Values.Text = "Delete Select"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(500, 65)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(134, 35)
        btnSave.TabIndex = 4
        btnSave.Values.DropDownArrowColor = Color.Empty
        btnSave.Values.Text = "Save Profile"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(766, 65)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(84, 35)
        btnClear.TabIndex = 6
        btnClear.Values.DropDownArrowColor = Color.Empty
        btnClear.Values.Text = "Reset"
        ' 
        ' txtRegNumber
        ' 
        txtRegNumber.Location = New Point(140, 88)
        txtRegNumber.Name = "txtRegNumber"
        txtRegNumber.Size = New Size(220, 27)
        txtRegNumber.TabIndex = 2
        ' 
        ' lblRegNumber
        ' 
        lblRegNumber.Location = New Point(15, 90)
        lblRegNumber.Name = "lblRegNumber"
        lblRegNumber.Size = New Size(102, 24)
        lblRegNumber.TabIndex = 7
        lblRegNumber.Values.Text = "Reg Number:"
        ' 
        ' txtVatNumber
        ' 
        txtVatNumber.Location = New Point(140, 53)
        txtVatNumber.Name = "txtVatNumber"
        txtVatNumber.Size = New Size(220, 27)
        txtVatNumber.TabIndex = 1
        ' 
        ' lblVatNumber
        ' 
        lblVatNumber.Location = New Point(15, 55)
        lblVatNumber.Name = "lblVatNumber"
        lblVatNumber.Size = New Size(103, 24)
        lblVatNumber.TabIndex = 8
        lblVatNumber.Values.Text = "VAT Number:"
        ' 
        ' txtCompanyName
        ' 
        txtCompanyName.Location = New Point(140, 18)
        txtCompanyName.Name = "txtCompanyName"
        txtCompanyName.Size = New Size(220, 27)
        txtCompanyName.TabIndex = 0
        ' 
        ' lblCompanyName
        ' 
        lblCompanyName.Location = New Point(15, 20)
        lblCompanyName.Name = "lblCompanyName"
        lblCompanyName.Size = New Size(125, 24)
        lblCompanyName.TabIndex = 9
        lblCompanyName.Values.Text = "Company Name:"
        ' 
        ' FrmCompanyManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1019, 681)
        Controls.Add(gridCompanies)
        Controls.Add(panelCrud)
        Controls.Add(panelTop)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmCompanyManagement"
        Text = "Company Management"
        CType(panelTop, ComponentModel.ISupportInitialize).EndInit()
        panelTop.ResumeLayout(False)
        panelTop.PerformLayout()
        CType(gridCompanies, ComponentModel.ISupportInitialize).EndInit()
        CType(panelCrud, ComponentModel.ISupportInitialize).EndInit()
        panelCrud.ResumeLayout(False)
        panelCrud.PerformLayout()
        CType(cmbAddresses, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Public WithEvents panelTop As Krypton.Toolkit.KryptonPanel
    Public WithEvents btnSearch As Krypton.Toolkit.KryptonButton
    Public WithEvents lblSearchTitle As Krypton.Toolkit.KryptonLabel
    Public WithEvents txtSearch As Krypton.Toolkit.KryptonTextBox
    Public WithEvents gridCompanies As Krypton.Toolkit.KryptonDataGridView
    Public WithEvents panelCrud As Krypton.Toolkit.KryptonPanel
    Public WithEvents lblAddressSelect As Krypton.Toolkit.KryptonLabel
    Public WithEvents cmbAddresses As Krypton.Toolkit.KryptonComboBox
    Public WithEvents btnDelete As Krypton.Toolkit.KryptonButton
    Public WithEvents btnSave As Krypton.Toolkit.KryptonButton
    Public WithEvents btnClear As Krypton.Toolkit.KryptonButton
    Public WithEvents txtRegNumber As Krypton.Toolkit.KryptonTextBox
    Public WithEvents lblRegNumber As Krypton.Toolkit.KryptonLabel
    Public WithEvents txtVatNumber As Krypton.Toolkit.KryptonTextBox
    Public WithEvents lblVatNumber As Krypton.Toolkit.KryptonLabel
    Public WithEvents txtCompanyName As Krypton.Toolkit.KryptonTextBox
    Public WithEvents lblCompanyName As Krypton.Toolkit.KryptonLabel
End Class