<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRepresentativeManagement
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
        gridReps = New Krypton.Toolkit.KryptonDataGridView()
        panelCrud = New Krypton.Toolkit.KryptonPanel()
        cmbCompanies = New Krypton.Toolkit.KryptonComboBox()
        lblCompany = New Krypton.Toolkit.KryptonLabel()
        txtEmail = New Krypton.Toolkit.KryptonTextBox()
        lblEmail = New Krypton.Toolkit.KryptonLabel()
        txtCell = New Krypton.Toolkit.KryptonTextBox()
        lblCell = New Krypton.Toolkit.KryptonLabel()
        txtFullName = New Krypton.Toolkit.KryptonTextBox()
        lblFullName = New Krypton.Toolkit.KryptonLabel()
        btnDelete = New Krypton.Toolkit.KryptonButton()
        btnSave = New Krypton.Toolkit.KryptonButton()
        btnClear = New Krypton.Toolkit.KryptonButton()
        btnSearch = New Krypton.Toolkit.KryptonButton()
        topPanel = New Krypton.Toolkit.KryptonPanel()
        lblSearchByName = New Krypton.Toolkit.KryptonLabel()
        txtSearch = New Krypton.Toolkit.KryptonTextBox()
        CType(gridReps, ComponentModel.ISupportInitialize).BeginInit()
        CType(panelCrud, ComponentModel.ISupportInitialize).BeginInit()
        panelCrud.SuspendLayout()
        CType(cmbCompanies, ComponentModel.ISupportInitialize).BeginInit()
        CType(topPanel, ComponentModel.ISupportInitialize).BeginInit()
        topPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' gridReps
        ' 
        gridReps.AllowUserToAddRows = False
        gridReps.AllowUserToDeleteRows = False
        gridReps.BorderStyle = BorderStyle.None
        gridReps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gridReps.Dock = DockStyle.Fill
        gridReps.Location = New Point(0, 45)
        gridReps.Name = "gridReps"
        gridReps.ReadOnly = True
        gridReps.RowHeadersWidth = 51
        gridReps.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        gridReps.Size = New Size(1019, 486)
        gridReps.TabIndex = 0
        ' 
        ' panelCrud
        ' 
        panelCrud.Controls.Add(cmbCompanies)
        panelCrud.Controls.Add(lblCompany)
        panelCrud.Controls.Add(txtEmail)
        panelCrud.Controls.Add(lblEmail)
        panelCrud.Controls.Add(txtCell)
        panelCrud.Controls.Add(lblCell)
        panelCrud.Controls.Add(txtFullName)
        panelCrud.Controls.Add(lblFullName)
        panelCrud.Controls.Add(btnDelete)
        panelCrud.Controls.Add(btnSave)
        panelCrud.Controls.Add(btnClear)
        panelCrud.Dock = DockStyle.Bottom
        panelCrud.Location = New Point(0, 531)
        panelCrud.Name = "panelCrud"
        panelCrud.Size = New Size(1019, 150)
        panelCrud.TabIndex = 1
        ' 
        ' cmbCompanies
        ' 
        cmbCompanies.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCompanies.Location = New Point(174, 11)
        cmbCompanies.Name = "cmbCompanies"
        cmbCompanies.Size = New Size(250, 26)
        cmbCompanies.TabIndex = 0
        ' 
        ' lblCompany
        ' 
        lblCompany.Location = New Point(15, 13)
        lblCompany.Name = "lblCompany"
        lblCompany.Size = New Size(132, 25)
        lblCompany.TabIndex = 1
        lblCompany.Values.Text = "Linked Corporate:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(174, 109)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(250, 27)
        txtEmail.TabIndex = 3
        ' 
        ' lblEmail
        ' 
        lblEmail.Location = New Point(15, 109)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(110, 25)
        lblEmail.TabIndex = 4
        lblEmail.Values.Text = "Email Address:"
        ' 
        ' txtCell
        ' 
        txtCell.Location = New Point(174, 76)
        txtCell.Name = "txtCell"
        txtCell.Size = New Size(250, 27)
        txtCell.TabIndex = 2
        ' 
        ' lblCell
        ' 
        lblCell.Location = New Point(15, 76)
        lblCell.Name = "lblCell"
        lblCell.Size = New Size(123, 25)
        lblCell.TabIndex = 5
        lblCell.Values.Text = "Mobile Number:"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(174, 43)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(250, 27)
        txtFullName.TabIndex = 1
        ' 
        ' lblFullName
        ' 
        lblFullName.Location = New Point(15, 45)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(161, 25)
        lblFullName.TabIndex = 6
        lblFullName.Values.Text = "Representative Name:"
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(595, 55)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(120, 35)
        btnDelete.TabIndex = 5
        btnDelete.Values.DropDownArrowColor = Color.Empty
        btnDelete.Values.Text = "Delete Rep"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(437, 55)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(130, 35)
        btnSave.TabIndex = 4
        btnSave.Values.DropDownArrowColor = Color.Empty
        btnSave.Values.Text = "Save Rep"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(742, 55)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(85, 35)
        btnClear.TabIndex = 6
        btnClear.Values.DropDownArrowColor = Color.Empty
        btnClear.Values.Text = "Reset"
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(398, 0)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(100, 39)
        btnSearch.TabIndex = 1
        btnSearch.Values.DropDownArrowColor = Color.Empty
        btnSearch.Values.Text = "Filter Data"
        ' 
        ' topPanel
        ' 
        topPanel.Controls.Add(lblSearchByName)
        topPanel.Controls.Add(txtSearch)
        topPanel.Controls.Add(btnSearch)
        topPanel.Dock = DockStyle.Top
        topPanel.Location = New Point(0, 0)
        topPanel.Name = "topPanel"
        topPanel.Size = New Size(1019, 45)
        topPanel.TabIndex = 1
        ' 
        ' lblSearchByName
        ' 
        lblSearchByName.Location = New Point(3, 0)
        lblSearchByName.Name = "lblSearchByName"
        lblSearchByName.Size = New Size(107, 24)
        lblSearchByName.TabIndex = 3
        lblSearchByName.Values.Text = "Search Name"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(116, 0)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(265, 27)
        txtSearch.TabIndex = 2
        ' 
        ' FrmRepresentativeManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1019, 681)
        Controls.Add(gridReps)
        Controls.Add(topPanel)
        Controls.Add(panelCrud)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmRepresentativeManagement"
        Text = "Representative Management"
        CType(gridReps, ComponentModel.ISupportInitialize).EndInit()
        CType(panelCrud, ComponentModel.ISupportInitialize).EndInit()
        panelCrud.ResumeLayout(False)
        panelCrud.PerformLayout()
        CType(cmbCompanies, ComponentModel.ISupportInitialize).EndInit()
        CType(topPanel, ComponentModel.ISupportInitialize).EndInit()
        topPanel.ResumeLayout(False)
        topPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Public WithEvents gridReps As Krypton.Toolkit.KryptonDataGridView
    Public WithEvents panelCrud As Krypton.Toolkit.KryptonPanel
    Public WithEvents btnSearch As Krypton.Toolkit.KryptonButton
    Public WithEvents cmbCompanies As Krypton.Toolkit.KryptonComboBox
    Public WithEvents lblCompany As Krypton.Toolkit.KryptonLabel
    Public WithEvents txtEmail As Krypton.Toolkit.KryptonTextBox
    Public WithEvents lblEmail As Krypton.Toolkit.KryptonLabel
    Public WithEvents txtCell As Krypton.Toolkit.KryptonTextBox
    Public WithEvents lblCell As Krypton.Toolkit.KryptonLabel
    Public WithEvents txtFullName As Krypton.Toolkit.KryptonTextBox
    Public WithEvents lblFullName As Krypton.Toolkit.KryptonLabel
    Public WithEvents btnDelete As Krypton.Toolkit.KryptonButton
    Public WithEvents btnSave As Krypton.Toolkit.KryptonButton
    Public WithEvents btnClear As Krypton.Toolkit.KryptonButton
    Friend WithEvents topPanel As Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblSearchByName As Krypton.Toolkit.KryptonLabel
    Public WithEvents txtSearch As Krypton.Toolkit.KryptonTextBox
End Class