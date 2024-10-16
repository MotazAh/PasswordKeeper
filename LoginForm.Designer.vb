<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.lblPwd = New System.Windows.Forms.Label()
        Me.lblConfirmPwd = New System.Windows.Forms.Label()
        Me.txtConfirmPwd = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(183, 121)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(30, 3, 30, 3)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Register"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(115, 56)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(221, 20)
        Me.txtPwd.TabIndex = 1
        '
        'lblPwd
        '
        Me.lblPwd.AutoSize = True
        Me.lblPwd.Location = New System.Drawing.Point(197, 40)
        Me.lblPwd.Name = "lblPwd"
        Me.lblPwd.Size = New System.Drawing.Size(53, 13)
        Me.lblPwd.TabIndex = 2
        Me.lblPwd.Text = "Password"
        '
        'lblConfirmPwd
        '
        Me.lblConfirmPwd.AutoSize = True
        Me.lblConfirmPwd.Location = New System.Drawing.Point(180, 79)
        Me.lblConfirmPwd.Name = "lblConfirmPwd"
        Me.lblConfirmPwd.Size = New System.Drawing.Size(91, 13)
        Me.lblConfirmPwd.TabIndex = 4
        Me.lblConfirmPwd.Text = "Confirm Password"
        '
        'txtConfirmPwd
        '
        Me.txtConfirmPwd.Location = New System.Drawing.Point(115, 95)
        Me.txtConfirmPwd.Name = "txtConfirmPwd"
        Me.txtConfirmPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPwd.Size = New System.Drawing.Size(221, 20)
        Me.txtConfirmPwd.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblTitle.Location = New System.Drawing.Point(186, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(79, 24)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Register"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 156)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblConfirmPwd)
        Me.Controls.Add(Me.txtConfirmPwd)
        Me.Controls.Add(Me.lblPwd)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPwd As TextBox
    Friend WithEvents lblPwd As Label
    Friend WithEvents lblConfirmPwd As Label
    Friend WithEvents txtConfirmPwd As TextBox
    Friend WithEvents lblTitle As Label
End Class
