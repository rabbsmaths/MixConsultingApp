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
        Me.panelTop = New Krypton.Toolkit.KryptonPanel()
        Me.btnSearch = New Krypton.Toolkit.KryptonButton()
        Me.lblSearchTitle = New Krypton.Toolkit.KryptonLabel()
        Me.txtSearch = New Krypton.Toolkit.KryptonTextBox()
        Me.gridCompanies = New Krypton.Toolkit.KryptonDataGridView()
        Me.panelCrud = New Krypton.Toolkit.KryptonPanel()
        Me.lblAddressSelect = New Krypton.Toolkit.KryptonLabel()
        Me.cmbAddresses = New Krypton.Toolkit.KryptonComboBox()
        Me.btnDelete = New Krypton.Toolkit.KryptonButton()
        Me.btnSave = New Krypton.Toolkit.KryptonButton()
        Me.btnClear = New Krypton.Toolkit.KryptonButton()
        Me.txtRegNumber = New Krypton.Toolkit.KryptonTextBox()
        Me.lblRegNumber = New Krypton.Toolkit.KryptonLabel()
        Me.txtVatNumber = New Krypton.Toolkit.KryptonTextBox()
        Me.lblVatNumber = New Krypton.Toolkit.KryptonLabel()
        Me.txtCompanyName = New Krypton.Toolkit.KryptonTextBox()
        Me.lblCompanyName = New Krypton.Toolkit.KryptonLabel()
        CType(Me.panelTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTop.SuspendLayout()
        CType(Me.gridCompanies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelCrud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCrud.SuspendLayout()
        CType(Me.cmbAddresses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.Controls.Add(Me.btnSearch)
        Me.panelTop.Controls.Add(Me.lblSearchTitle)
        Me.panelTop.Controls.Add(Me.txtSearch)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1019, 60)
        Me.panelTop.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(555, 14)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(120, 30)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Values.Text = "Execute Search"
        '
        'lblSearchTitle
        '
        Me.lblSearchTitle.Location = New System.Drawing.Point(12, 18)
        Me.lblSearchTitle.Name = "lblSearchTitle"
        Me.lblSearchTitle.Size = New System.Drawing.Size(146, 20)
        Me.lblSearchTitle.Text = "Search Corporate Client:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(165, 16)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(380, 23)
        Me.txtSearch.TabIndex = 0
        '
        'gridCompanies
        '
        Me.gridCompanies.AllowUserToAddRows = False
        Me.gridCompanies.AllowUserToDeleteRows = False
        Me.gridCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCompanies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridCompanies.Location = New System.Drawing.Point(0, 60)
        Me.gridCompanies.Name = "gridCompanies"
        Me.gridCompanies.ReadOnly = True
        Me.gridCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridCompanies.Size = New System.Drawing.Size(1019, 461)
        Me.gridCompanies.TabIndex = 1
        '
        'panelCrud
        '
        Me.panelCrud.Controls.Add(Me.lblAddressSelect)
        Me.panelCrud.Controls.Add(Me.cmbAddresses)
        Me.panelCrud.Controls.Add(Me.btnDelete)
        Me.panelCrud.Controls.Add(Me.btnSave)
        Me.panelCrud.Controls.Add(Me.btnClear)
        Me.panelCrud.Controls.Add(Me.txtRegNumber)
        Me.panelCrud.Controls.Add(Me.lblRegNumber)
        Me.panelCrud.Controls.Add(Me.txtVatNumber)
        Me.panelCrud.Controls.Add(Me.lblVatNumber)
        Me.panelCrud.Controls.Add(Me.txtCompanyName)
        Me.panelCrud.Controls.Add(Me.lblCompanyName)
        Me.panelCrud.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelCrud.Location = New System.Drawing.Point(0, 521)
        Me.panelCrud.Name = "panelCrud"
        Me.panelCrud.Size = New System.Drawing.Size(1019, 160)
        Me.panelCrud.TabIndex = 2
        '
        'lblAddressSelect
        '
        Me.lblAddressSelect.Location = New System.Drawing.Point(385, 22)
        Me.lblAddressSelect.Name = "lblAddressSelect"
        Me.lblAddressSelect.Size = New System.Drawing.Size(104, 20)
        Me.lblAddressSelect.Text = "Physical Address:"
        '
        'cmbAddresses
        '
        Me.cmbAddresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAddresses.DropDownWidth = 350
        Me.cmbAddresses.Location = New System.Drawing.Point(500, 20)
        Me.cmbAddresses.Name = "cmbAddresses"
        Me.cmbAddresses.Size = New System.Drawing.Size(350, 21)
        Me.cmbAddresses.TabIndex = 3
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(640, 65)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 35)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Values.Text = "Delete Select"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(500, 65)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(134, 35)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Values.Text = "Save Profile"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(766, 65)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 35)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Values.Text = "Reset"
        '
        'txtRegNumber
        '
        Me.txtRegNumber.Location = New System.Drawing.Point(140, 88)
        Me.txtRegNumber.Name = "txtRegNumber"
        Me.txtRegNumber.Size = New System.Drawing.Size(220, 23)
        Me.txtRegNumber.TabIndex = 2
        '
        'lblRegNumber
        '
        Me.lblRegNumber.Location = New System.Drawing.Point(15, 90)
        Me.lblRegNumber.Name = "lblRegNumber"
        Me.lblRegNumber.Size = New System.Drawing.Size(84, 20)
        Me.lblRegNumber.Text = "Reg Number:"
        '
        'txtVatNumber
        '
        Me.txtVatNumber.Location = New System.Drawing.Point(140, 53)
        Me.txtVatNumber.Name = "txtVatNumber"
        Me.txtVatNumber.Size = New System.Drawing.Size(220, 23)
        Me.txtVatNumber.TabIndex = 1
        '
        'lblVatNumber
        '
        Me.lblVatNumber.Location = New System.Drawing.Point(15, 55)
        Me.lblVatNumber.Name = "lblVatNumber"
        Me.lblVatNumber.Size = New System.Drawing.Size(84, 20)
        Me.lblVatNumber.Text = "VAT Number:"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(140, 18)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(220, 23)
        Me.txtCompanyName.TabIndex = 0
        '
        'lblCompanyName
        '
        Me.lblCompanyName.Location = New System.Drawing.Point(15, 20)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(102, 20)
        Me.lblCompanyName.Text = "Company Name:"
        '
        'FrmCompanyManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 681)
        Me.Controls.Add(Me.gridCompanies)
        Me.Controls.Add(Me.panelCrud)
        Me.Controls.Add(Me.panelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCompanyManagement"
        Me.Text = "Company Management"
        CType(Me.panelTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.gridCompanies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelCrud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCrud.ResumeLayout(False)
        Me.panelCrud.PerformLayout()
        CType(Me.cmbAddresses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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