<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Me.kryptonSplitContainer1 = New Krypton.Toolkit.KryptonSplitContainer()
        Me.panelLeftMenu = New Krypton.Toolkit.KryptonPanel()
        Me.btnManageAddresses = New Krypton.Toolkit.KryptonButton()
        Me.btnManageCompanies = New Krypton.Toolkit.KryptonButton()
        Me.lblMenuTitle = New Krypton.Toolkit.KryptonLabel()
        Me.panelMainWorkspace = New Krypton.Toolkit.KryptonPanel()
        CType(Me.kryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.kryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonSplitContainer1.Panel2.SuspendLayout()
        Me.kryptonSplitContainer1.SuspendLayout()
        CType(Me.panelLeftMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLeftMenu.SuspendLayout()
        CType(Me.panelMainWorkspace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sysTimer
        '
        Me.sysTimer.Interval = 1000
        '
        'kryptonSplitContainer1
        '
        Me.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonSplitContainer1.Name = "kryptonSplitContainer1"
        '
        'kryptonSplitContainer1.Panel1
        '
        Me.kryptonSplitContainer1.Panel1.Controls.Add(Me.panelLeftMenu)
        '
        'kryptonSplitContainer1.Panel2
        '
        Me.kryptonSplitContainer1.Panel2.Controls.Add(Me.panelMainWorkspace)
        Me.kryptonSplitContainer1.Size = New System.Drawing.Size(1264, 681)
        Me.kryptonSplitContainer1.SplitterDistance = 240
        Me.kryptonSplitContainer1.TabIndex = 0
        '
        'panelLeftMenu
        '
        Me.panelLeftMenu.Controls.Add(Me.btnManageAddresses)
        Me.panelLeftMenu.Controls.Add(Me.btnManageCompanies)
        Me.panelLeftMenu.Controls.Add(Me.lblMenuTitle)
        Me.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLeftMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelLeftMenu.Name = "panelLeftMenu"
        Me.panelLeftMenu.Size = New System.Drawing.Size(240, 681)
        Me.panelLeftMenu.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(23, Byte), CType(34, Byte), CType(59, Byte))
        Me.panelLeftMenu.TabIndex = 0
        '
        'btnManageAddresses
        '
        Me.btnManageAddresses.Location = New System.Drawing.Point(12, 130)
        Me.btnManageAddresses.Name = "btnManageAddresses"
        Me.btnManageAddresses.Size = New System.Drawing.Size(216, 45)
        Me.btnManageAddresses.StateCommon.Border.Rounding = 6
        Me.btnManageAddresses.TabIndex = 2
        Me.btnManageAddresses.Values.Text = "Manage Addresses"
        '
        'btnManageCompanies
        '
        Me.btnManageCompanies.Location = New System.Drawing.Point(12, 70)
        Me.btnManageCompanies.Name = "btnManageCompanies"
        Me.btnManageCompanies.Size = New System.Drawing.Size(216, 45)
        Me.btnManageCompanies.StateCommon.Border.Rounding = 6
        Me.btnManageCompanies.TabIndex = 1
        Me.btnManageCompanies.Values.Text = "Manage Companies"
        '
        'lblMenuTitle
        '
        Me.lblMenuTitle.Location = New System.Drawing.Point(12, 20)
        Me.lblMenuTitle.Name = "lblMenuTitle"
        Me.lblMenuTitle.Size = New System.Drawing.Size(180, 24)
        Me.lblMenuTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.lblMenuTitle.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblMenuTitle.Text = "NAVIGATION CORE"
        '
        'panelMainWorkspace
        '
        Me.panelMainWorkspace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMainWorkspace.Location = New System.Drawing.Point(0, 0)
        Me.panelMainWorkspace.Name = "panelMainWorkspace"
        Me.panelMainWorkspace.Size = New System.Drawing.Size(1019, 681)
        Me.panelMainWorkspace.TabIndex = 0
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.kryptonSplitContainer1)
        Me.MinimumSize = New System.Drawing.Size(1024, 600)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MiX Consulting - Enterprise Registry Monitor"
        CType(Me.kryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.kryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.kryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainer1.ResumeLayout(False)
        CType(Me.panelLeftMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLeftMenu.ResumeLayout(False)
        Me.panelLeftMenu.PerformLayout()
        CType(Me.panelMainWorkspace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents sysTimer As System.Windows.Forms.Timer
    Friend WithEvents kryptonSplitContainer1 As Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents panelLeftMenu As Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblMenuTitle As Krypton.Toolkit.KryptonLabel
    Public WithEvents btnManageAddresses As Krypton.Toolkit.KryptonButton
    Public WithEvents btnManageCompanies As Krypton.Toolkit.KryptonButton
    Friend WithEvents panelMainWorkspace As Krypton.Toolkit.KryptonPanel
End Class