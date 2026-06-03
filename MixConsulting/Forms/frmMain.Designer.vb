<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits Krypton.Toolkit.KryptonForm

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
        Me.components = New System.ComponentModel.Container()
        Me.sysTimer = New System.Windows.Forms.Timer(Me.components)
        Me.txtSearch = New Krypton.Toolkit.KryptonTextBox()
        Me.gridCompanies = New Krypton.Toolkit.KryptonDataGridView()
        Me.panelTop = New Krypton.Toolkit.KryptonPanel()
        Me.btnSearch = New Krypton.Toolkit.KryptonButton()
        Me.lblSearchTitle = New Krypton.Toolkit.KryptonLabel()
        Me.mainAppMenu = New System.Windows.Forms.MenuStrip()
        Me.menuNavigation = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemManageAddresses = New System.Windows.Forms.ToolStripMenuItem()
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
        CType(Me.gridCompanies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTop.SuspendLayout()
        Me.mainAppMenu.SuspendLayout()
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
        Me.panelTop.Location = New System.Drawing.Point(0, 24)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1008, 55)
        Me.panelTop.TabIndex = 1
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
        Me.txtSearch.StateCommon.Border.Rounding = 4
        Me.txtSearch.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(555, 14)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(110, 27)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Values.Text = "Execute Search"
        '
        'mainAppMenu
        '
        Me.mainAppMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuNavigation})
        Me.mainAppMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainAppMenu.Name = "mainAppMenu"
        Me.mainAppMenu.Size = New System.Drawing.Size(1008, 24)
        Me.mainAppMenu.TabIndex = 0
        Me.mainAppMenu.Text = "MenuStrip"
        '
        'menuNavigation
        '
        Me.menuNavigation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemManageAddresses})
        Me.menuNavigation.Name = "menuNavigation"
        Me.menuNavigation.Size = New System.Drawing.Size(111, 20)
        Me.menuNavigation.Text = "System Navigation"
        '
        'menuItemManageAddresses
        '
        Me.menuItemManageAddresses.Name = "menuItemManageAddresses"
        Me.menuItemManageAddresses.Size = New System.Drawing.Size(186, 22)
        Me.menuItemManageAddresses.Text = "Manage Address Profiles"
        '
        'gridCompanies
        '
        Me.gridCompanies.AllowUserToAddRows = False
        Me.gridCompanies.AllowUserToDeleteRows = False
        Me.gridCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCompanies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridCompanies.Location = New System.Drawing.Point(0, 79)
        Me.gridCompanies.Name = "gridCompanies"
        Me.gridCompanies.ReadOnly = True
        Me.gridCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridCompanies.Size = New System.Drawing.Size(1008, 302)
        Me.gridCompanies.TabIndex = 2
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
        Me.panelCrud.Location = New System.Drawing.Point(0, 381)
        Me.panelCrud.Name = "panelCrud"
        Me.panelCrud.Size = New System.Drawing.Size(1008, 150)
        Me.panelCrud.TabIndex = 3
        '
        'lblCompanyName
        '
        Me.lblCompanyName.Location = New System.Drawing.Point(12, 19)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(102, 20)
        Me.lblCompanyName.Text = "Company Name:"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(120, 17)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(220, 23)
        Me.txtCompanyName.TabIndex = 0
        '
        'lblVatNumber
        '
        Me.lblVatNumber.Location = New System.Drawing.Point(12, 53)
        Me.lblVatNumber.Name = "lblVatNumber"
        Me.lblVatNumber.Size = New System.Drawing.Size(84, 20)
        Me.lblVatNumber.Text = "VAT Number:"
        '
        'txtVatNumber
        '
        Me.txtVatNumber.Location = New System.Drawing.Point(120, 51)
        Me.txtVatNumber.Name = "txtVatNumber"
        Me.txtVatNumber.Size = New System.Drawing.Size(220, 23)
        Me.txtVatNumber.TabIndex = 1
        '
        'lblRegNumber
        '
        Me.lblRegNumber.Location = New System.Drawing.Point(12, 87)
        Me.lblRegNumber.Name = "lblRegNumber"
        Me.lblRegNumber.Size = New System.Drawing.Size(84, 20)
        Me.lblRegNumber.Text = "Reg Number:"
        '
        'txtRegNumber
        '
        Me.txtRegNumber.Location = New System.Drawing.Point(120, 85)
        Me.txtRegNumber.Name = "txtRegNumber"
        Me.txtRegNumber.Size = New System.Drawing.Size(220, 23)
        Me.txtRegNumber.TabIndex = 2
        '
        'lblAddressSelect
        '
        Me.lblAddressSelect.Location = New System.Drawing.Point(365, 19)
        Me.lblAddressSelect.Name = "lblAddressSelect"
        Me.lblAddressSelect.Size = New System.Drawing.Size(104, 20)
        Me.lblAddressSelect.Text = "Physical Address:"
        '
        'cmbAddresses
        '
        Me.cmbAddresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAddresses.DropDownWidth = 350
        Me.cmbAddresses.Location = New System.Drawing.Point(475, 17)
        Me.cmbAddresses.Name = "cmbAddresses"
        Me.cmbAddresses.Size = New System.Drawing.Size(350, 21)
        Me.cmbAddresses.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(475, 60)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(140, 35)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Values.Text = "Save Profile"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(625, 60)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(110, 35)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Values.Text = "Delete Select"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(741, 60)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 35)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Values.Text = "Reset"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 531)
        Me.Controls.Add(Me.gridCompanies)
        Me.Controls.Add(Me.panelCrud)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.mainAppMenu)
        Me.MainMenuStrip = Me.mainAppMenu
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MiX Consulting - Enterprise Registry Monitor"
        CType(Me.gridCompanies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.mainAppMenu.ResumeLayout(False)
        Me.mainAppMenu.PerformLayout()
        CType(Me.panelCrud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCrud.ResumeLayout(False)
        Me.panelCrud.PerformLayout()
        CType(Me.cmbAddresses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sysTimer As System.Windows.Forms.Timer
    Friend WithEvents txtSearch As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnSearch As Krypton.Toolkit.KryptonButton
    Friend WithEvents gridCompanies As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents panelTop As Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblSearchTitle As Krypton.Toolkit.KryptonLabel
    Friend WithEvents mainAppMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents menuNavigation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemManageAddresses As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents panelCrud As Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblCompanyName As Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCompanyName As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblVatNumber As Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtVatNumber As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblRegNumber As Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRegNumber As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblAddressSelect As Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbAddresses As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnSave As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnDelete As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnClear As Krypton.Toolkit.KryptonButton
End Class