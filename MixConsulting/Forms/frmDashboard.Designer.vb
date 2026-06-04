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
        components = New ComponentModel.Container()
        sysTimer = New Timer(components)
        kryptonSplitContainer1 = New Krypton.Toolkit.KryptonSplitContainer()
        panelLeftMenu = New Krypton.Toolkit.KryptonPanel()
        btnManageAddresses = New Krypton.Toolkit.KryptonButton()
        btnManageCompanies = New Krypton.Toolkit.KryptonButton()
        btnManageReps = New Krypton.Toolkit.KryptonButton()
        lblMenuTitle = New Krypton.Toolkit.KryptonLabel()
        panelMainWorkspace = New Krypton.Toolkit.KryptonPanel()
        CType(kryptonSplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        CType(kryptonSplitContainer1.Panel1, ComponentModel.ISupportInitialize).BeginInit()
        kryptonSplitContainer1.Panel1.SuspendLayout()
        CType(kryptonSplitContainer1.Panel2, ComponentModel.ISupportInitialize).BeginInit()
        kryptonSplitContainer1.Panel2.SuspendLayout()
        CType(panelLeftMenu, ComponentModel.ISupportInitialize).BeginInit()
        panelLeftMenu.SuspendLayout()
        CType(panelMainWorkspace, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' sysTimer
        ' 
        sysTimer.Interval = 1000
        ' 
        ' kryptonSplitContainer1
        ' 
        kryptonSplitContainer1.Dock = DockStyle.Fill
        kryptonSplitContainer1.Location = New Point(0, 0)
        ' 
        ' 
        ' 
        kryptonSplitContainer1.Panel1.Controls.Add(panelLeftMenu)
        ' 
        ' 
        ' 
        kryptonSplitContainer1.Panel2.Controls.Add(panelMainWorkspace)
        kryptonSplitContainer1.Size = New Size(1264, 681)
        kryptonSplitContainer1.SplitterDistance = 240
        kryptonSplitContainer1.TabIndex = 0
        ' 
        ' panelLeftMenu
        ' 
        panelLeftMenu.Controls.Add(btnManageAddresses)
        panelLeftMenu.Controls.Add(btnManageCompanies)
        panelLeftMenu.Controls.Add(btnManageReps)
        panelLeftMenu.Controls.Add(lblMenuTitle)
        panelLeftMenu.Dock = DockStyle.Fill
        panelLeftMenu.Location = New Point(0, 0)
        panelLeftMenu.Name = "panelLeftMenu"
        panelLeftMenu.Size = New Size(240, 681)
        panelLeftMenu.StateCommon.Color1 = Color.FromArgb(CByte(23), CByte(34), CByte(59))
        panelLeftMenu.TabIndex = 0
        ' 
        ' btnManageAddresses
        ' 
        btnManageAddresses.Location = New Point(12, 207)
        btnManageAddresses.Name = "btnManageAddresses"
        btnManageAddresses.Size = New Size(216, 45)
        btnManageAddresses.StateCommon.Border.Rounding = 6F
        btnManageAddresses.TabIndex = 1
        btnManageAddresses.Values.DropDownArrowColor = Color.Empty
        btnManageAddresses.Values.Text = "Manage Addresses"
        ' 
        ' btnManageCompanies
        ' 
        btnManageCompanies.Location = New Point(12, 70)
        btnManageCompanies.Name = "btnManageCompanies"
        btnManageCompanies.Size = New Size(216, 45)
        btnManageCompanies.StateCommon.Border.Rounding = 6F
        btnManageCompanies.TabIndex = 2
        btnManageCompanies.Values.DropDownArrowColor = Color.Empty
        btnManageCompanies.Values.Text = "Manage Companies"
        ' 
        ' btnManageReps
        ' 
        btnManageReps.Location = New Point(12, 138)
        btnManageReps.Name = "btnManageReps"
        btnManageReps.Size = New Size(216, 45)
        btnManageReps.StateCommon.Border.Rounding = 6F
        btnManageReps.TabIndex = 3
        btnManageReps.Values.DropDownArrowColor = Color.Empty
        btnManageReps.Values.Text = "Manage Representatives"
        ' 
        ' lblMenuTitle
        ' 
        lblMenuTitle.Location = New Point(12, 20)
        lblMenuTitle.Name = "lblMenuTitle"
        lblMenuTitle.Size = New Size(190, 30)
        lblMenuTitle.StateCommon.ShortText.Color1 = Color.White
        lblMenuTitle.StateCommon.ShortText.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblMenuTitle.TabIndex = 3
        lblMenuTitle.Values.Text = "NAVIGATION CORE"
        ' 
        ' panelMainWorkspace
        ' 
        panelMainWorkspace.Dock = DockStyle.Fill
        panelMainWorkspace.Location = New Point(0, 0)
        panelMainWorkspace.Name = "panelMainWorkspace"
        panelMainWorkspace.Size = New Size(1019, 681)
        panelMainWorkspace.TabIndex = 0
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 681)
        Controls.Add(kryptonSplitContainer1)
        MinimumSize = New Size(1024, 600)
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MiX Consulting - Enterprise Registry Monitor"
        CType(kryptonSplitContainer1.Panel1, ComponentModel.ISupportInitialize).EndInit()
        kryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(kryptonSplitContainer1.Panel2, ComponentModel.ISupportInitialize).EndInit()
        kryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(kryptonSplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        CType(panelLeftMenu, ComponentModel.ISupportInitialize).EndInit()
        panelLeftMenu.ResumeLayout(False)
        panelLeftMenu.PerformLayout()
        CType(panelMainWorkspace, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Public WithEvents sysTimer As System.Windows.Forms.Timer
    Friend WithEvents kryptonSplitContainer1 As Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents panelLeftMenu As Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblMenuTitle As Krypton.Toolkit.KryptonLabel
    Public WithEvents btnManageAddresses As Krypton.Toolkit.KryptonButton
    Public WithEvents btnManageCompanies As Krypton.Toolkit.KryptonButton
    Friend WithEvents panelMainWorkspace As Krypton.Toolkit.KryptonPanel
    Public WithEvents btnManageReps As Krypton.Toolkit.KryptonButton
End Class