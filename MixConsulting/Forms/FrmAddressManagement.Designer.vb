<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAddressManagement
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
        Me.gridAddresses = New Krypton.Toolkit.KryptonDataGridView()
        Me.panelCrud = New Krypton.Toolkit.KryptonPanel()
        Me.txtPostalCode = New Krypton.Toolkit.KryptonTextBox()
        Me.lblPostalCode = New Krypton.Toolkit.KryptonLabel()
        Me.txtCity = New Krypton.Toolkit.KryptonTextBox()
        Me.lblCity = New Krypton.Toolkit.KryptonLabel()
        Me.btnDelete = New Krypton.Toolkit.KryptonButton()
        Me.btnSave = New Krypton.Toolkit.KryptonButton()
        Me.btnClear = New Krypton.Toolkit.KryptonButton()
        Me.txtLine2 = New Krypton.Toolkit.KryptonTextBox()
        Me.lblLine2 = New Krypton.Toolkit.KryptonLabel()
        Me.txtLine1 = New Krypton.Toolkit.KryptonTextBox()
        Me.lblLine1 = New Krypton.Toolkit.KryptonLabel()
        CType(Me.gridAddresses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelCrud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCrud.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridAddresses
        '
        Me.gridAddresses.AllowUserToAddRows = False
        Me.gridAddresses.AllowUserToDeleteRows = False
        Me.gridAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAddresses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridAddresses.Location = New System.Drawing.Point(0, 0)
        Me.gridAddresses.Name = "gridAddresses"
        Me.gridAddresses.ReadOnly = True
        Me.gridAddresses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridAddresses.Size = New System.Drawing.Size(1019, 531)
        Me.gridAddresses.TabIndex = 0
        '
        'panelCrud
        '
        Me.panelCrud.Controls.Add(Me.txtPostalCode)
        Me.panelCrud.Controls.Add(Me.lblPostalCode)
        Me.panelCrud.Controls.Add(Me.txtCity)
        Me.panelCrud.Controls.Add(Me.lblCity)
        Me.panelCrud.Controls.Add(Me.btnDelete)
        Me.panelCrud.Controls.Add(Me.btnSave)
        Me.panelCrud.Controls.Add(Me.btnClear)
        Me.panelCrud.Controls.Add(Me.txtLine2)
        Me.panelCrud.Controls.Add(Me.lblLine2)
        Me.panelCrud.Controls.Add(Me.txtLine1)
        Me.panelCrud.Controls.Add(Me.lblLine1)
        Me.panelCrud.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelCrud.Location = New System.Drawing.Point(0, 531)
        Me.panelCrud.Name = "panelCrud"
        Me.panelCrud.Size = New System.Drawing.Size(1019, 150)
        Me.panelCrud.TabIndex = 1
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Location = New System.Drawing.Point(130, 107)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(110, 23)
        Me.txtPostalCode.TabIndex = 3
        '
        'lblPostalCode
        '
        Me.lblPostalCode.Location = New System.Drawing.Point(15, 109)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(79, 20)
        Me.lblPostalCode.Text = "Postal Code:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(130, 74)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(250, 23)
        Me.txtCity.TabIndex = 2
        '
        'lblCity
        '
        Me.lblCity.Location = New System.Drawing.Point(15, 76)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(34, 20)
        Me.lblCity.Text = "City:"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(550, 55)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 35)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Values.Text = "Delete Address"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(410, 55)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(134, 35)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Values.Text = "Save Location"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(676, 55)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 35)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Values.Text = "Reset"
        '
        'txtLine2
        '
        Me.txtLine2.Location = New System.Drawing.Point(130, 43)
        Me.txtLine2.Name = "txtLine2"
        Me.txtLine2.Size = New System.Drawing.Size(250, 23)
        Me.txtLine2.TabIndex = 1
        '
        'lblLine2
        '
        Me.lblLine2.Location = New System.Drawing.Point(15, 45)
        Me.lblLine2.Name = "lblLine2"
        Me.lblLine2.Size = New System.Drawing.Size(91, 20)
        Me.lblLine2.Text = "Address Line 2:"
        '
        'txtLine1
        '
        Me.txtLine1.Location = New System.Drawing.Point(130, 11)
        Me.txtLine1.Name = "txtLine1"
        Me.txtLine1.Size = New System.Drawing.Size(250, 23)
        Me.txtLine1.TabIndex = 0
        '
        'lblLine1
        '
        Me.lblLine1.Location = New System.Drawing.Point(15, 13)
        Me.lblLine1.Name = "lblLine1"
        Me.lblLine1.Size = New System.Drawing.Size(91, 20)
        Me.lblLine1.Text = "Address Line 1:"
        '
        'FrmAddressManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 681)
        Me.Controls.Add(Me.gridAddresses)
        Me.Controls.Add(Me.panelCrud)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAddressManagement"
        Me.Text = "Address Management"
        CType(Me.gridAddresses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelCrud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCrud.ResumeLayout(False)
        Me.panelCrud.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents gridAddresses As Krypton.Toolkit.KryptonDataGridView
    Public WithEvents panelCrud As Krypton.Toolkit.KryptonPanel
    Public WithEvents txtPostalCode As Krypton.Toolkit.KryptonTextBox
    Public WithEvents lblPostalCode As Krypton.Toolkit.KryptonLabel
    Public WithEvents txtCity As Krypton.Toolkit.KryptonTextBox
    Public WithEvents lblCity As Krypton.Toolkit.KryptonLabel
    Public WithEvents btnDelete As Krypton.Toolkit.KryptonButton
    Public WithEvents btnSave As Krypton.Toolkit.KryptonButton
    Public WithEvents btnClear As Krypton.Toolkit.KryptonButton
    Public WithEvents txtLine2 As Krypton.Toolkit.KryptonTextBox
    Public WithEvents lblLine2 As Krypton.Toolkit.KryptonLabel
    Public WithEvents txtLine1 As Krypton.Toolkit.KryptonTextBox
    Public WithEvents lblLine1 As Krypton.Toolkit.KryptonLabel
End Class