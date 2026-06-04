<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        txtUsername = New Krypton.Toolkit.KryptonTextBox()
        txtPassword = New Krypton.Toolkit.KryptonTextBox()
        btnLogin = New Krypton.Toolkit.KryptonButton()
        lblUserHeader = New Krypton.Toolkit.KryptonLabel()
        lblPassHeader = New Krypton.Toolkit.KryptonLabel()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(54, 57)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(265, 31)
        txtUsername.StateCommon.Border.Rounding = 5F
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(54, 124)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(265, 31)
        txtPassword.StateCommon.Border.Rounding = 5F
        txtPassword.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(54, 178)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(265, 32)
        btnLogin.TabIndex = 2
        btnLogin.Values.DropDownArrowColor = Color.Empty
        btnLogin.Values.Text = "Login"
        ' 
        ' lblUserHeader
        ' 
        lblUserHeader.Location = New Point(54, 27)
        lblUserHeader.Name = "lblUserHeader"
        lblUserHeader.Size = New Size(110, 24)
        lblUserHeader.TabIndex = 0
        lblUserHeader.Values.Text = "Username:"
        ' 
        ' lblPassHeader
        ' 
        lblPassHeader.Location = New Point(54, 94)
        lblPassHeader.Name = "lblPassHeader"
        lblPassHeader.Size = New Size(108, 24)
        lblPassHeader.TabIndex = 1
        lblPassHeader.Values.Text = "Password:"
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(382, 253)
        Controls.Add(lblUserHeader)
        Controls.Add(txtUsername)
        Controls.Add(lblPassHeader)
        Controls.Add(txtPassword)
        Controls.Add(btnLogin)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "POPIA Verification Gateway"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtPassword As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnLogin As Krypton.Toolkit.KryptonButton
    Friend WithEvents lblUserHeader As Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPassHeader As Krypton.Toolkit.KryptonLabel
End Class