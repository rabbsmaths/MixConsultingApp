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
        Me.txtUsername = New Krypton.Toolkit.KryptonTextBox()
        Me.txtPassword = New Krypton.Toolkit.KryptonTextBox()
        Me.btnLogin = New Krypton.Toolkit.KryptonButton()
        Me.lblUserHeader = New Krypton.Toolkit.KryptonLabel()
        Me.lblPassHeader = New Krypton.Toolkit.KryptonLabel()
        Me.SuspendLayout()
        '
        'lblUserHeader
        '
        Me.lblUserHeader.Location = New System.Drawing.Point(20, 15)
        Me.lblUserHeader.Name = "lblUserHeader"
        Me.lblUserHeader.Size = New System.Drawing.Size(110, 20)
        Me.lblUserHeader.Text = "Identity Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(20, 38)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(265, 23)
        Me.txtUsername.StateCommon.Border.Rounding = 5
        Me.txtUsername.TabIndex = 0
        '
        'lblPassHeader
        '
        Me.lblPassHeader.Location = New System.Drawing.Point(20, 70)
        Me.lblPassHeader.Name = "lblPassHeader"
        Me.lblPassHeader.Size = New System.Drawing.Size(108, 20)
        Me.lblPassHeader.Text = "Security Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(20, 93)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = "*"c
        Me.txtPassword.Size = New System.Drawing.Size(265, 23)
        Me.txtPassword.StateCommon.Border.Rounding = 5
        Me.txtPassword.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(20, 135)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(265, 32)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Values.Text = "Authenticate Security Token"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 186)
        Me.Controls.Add(Me.lblUserHeader)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassHeader)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POPIA Verification Gateway"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents txtUsername As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtPassword As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnLogin As Krypton.Toolkit.KryptonButton
    Friend WithEvents lblUserHeader As Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPassHeader As Krypton.Toolkit.KryptonLabel
End Class