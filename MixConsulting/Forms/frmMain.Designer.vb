<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.lblSearchTitle = New Krypton.Toolkit.KryptonLabel()
        CType(Me.gridCompanies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'sysTimer
        '
        Me.sysTimer.Interval = 1000
        '
        'panelTop
        '
        Me.panelTop.Controls.Add(Me.lblSearchTitle)
        Me.panelTop.Controls.Add(Me.txtSearch)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(934, 55)
        Me.panelTop.TabIndex = 0
        '
        'lblSearchTitle
        '
        Me.lblSearchTitle.Location = New System.Drawing.Point(12, 18)
        Me.lblSearchTitle.Name = "lblSearchTitle"
        Me.lblSearchTitle.Size = New System.Drawing.Size(155, 20)
        Me.lblSearchTitle.Text = "Search Corporate Matrix:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(175, 16)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(380, 23)
        Me.txtSearch.StateCommon.Border.Rounding = 4
        Me.txtSearch.TabIndex = 1
        '
        'gridCompanies
        '
        Me.gridCompanies.AllowUserToAddRows = False
        Me.gridCompanies.AllowUserToDeleteRows = False
        Me.gridCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCompanies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridCompanies.Location = New System.Drawing.Point(0, 55)
        Me.gridCompanies.Name = "gridCompanies"
        Me.gridCompanies.ReadOnly = True
        Me.gridCompanies.RowHeadersWidth = 51
        Me.gridCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridCompanies.Size = New System.Drawing.Size(934, 426)
        Me.gridCompanies.TabIndex = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 481)
        Me.Controls.Add(Me.gridCompanies)
        Me.Controls.Add(Me.panelTop)
        Me.MinimumSize = New System.Drawing.Size(500, 400)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MiX Consulting - Enterprise Registry Monitor"
        CType(Me.gridCompanies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents sysTimer As System.Windows.Forms.Timer
    Friend WithEvents txtSearch As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents gridCompanies As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents panelTop As Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblSearchTitle As Krypton.Toolkit.KryptonLabel
End Class