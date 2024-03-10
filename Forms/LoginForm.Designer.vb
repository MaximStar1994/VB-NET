<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UserIdLabel = New System.Windows.Forms.Label()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.User = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.LoginPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UserNameTextBoxPanel = New System.Windows.Forms.Panel()
        Me.LoginTitleLable = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LoginPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.UserNameTextBoxPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.PasswordLabel.Location = New System.Drawing.Point(-1, 165)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(79, 19)
        Me.PasswordLabel.TabIndex = 4
        Me.PasswordLabel.Text = "Password"
        '
        'UserIdLabel
        '
        Me.UserIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UserIdLabel.AutoSize = True
        Me.UserIdLabel.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.UserIdLabel.Location = New System.Drawing.Point(-4, 60)
        Me.UserIdLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.UserIdLabel.Name = "UserIdLabel"
        Me.UserIdLabel.Size = New System.Drawing.Size(80, 19)
        Me.UserIdLabel.TabIndex = 2
        Me.UserIdLabel.Text = "Username"
        '
        'ConnectButton
        '
        Me.ConnectButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ConnectButton.FlatAppearance.BorderSize = 0
        Me.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConnectButton.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ConnectButton.ForeColor = System.Drawing.Color.White
        Me.ConnectButton.Location = New System.Drawing.Point(48, 327)
        Me.ConnectButton.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(89, 40)
        Me.ConnectButton.TabIndex = 3
        Me.ConnectButton.Text = "Login"
        Me.ConnectButton.UseVisualStyleBackColor = False
        '
        'User
        '
        Me.User.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.User.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.User.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User.Location = New System.Drawing.Point(16, 12)
        Me.User.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(322, 20)
        Me.User.TabIndex = 1
        '
        'Password
        '
        Me.Password.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Password.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(16, 12)
        Me.Password.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(322, 20)
        Me.Password.TabIndex = 2
        '
        'LoginPanel
        '
        Me.LoginPanel.Controls.Add(Me.Panel1)
        Me.LoginPanel.Controls.Add(Me.UserNameTextBoxPanel)
        Me.LoginPanel.Controls.Add(Me.LoginTitleLable)
        Me.LoginPanel.Controls.Add(Me.PasswordLabel)
        Me.LoginPanel.Controls.Add(Me.UserIdLabel)
        Me.LoginPanel.Location = New System.Drawing.Point(46, 45)
        Me.LoginPanel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LoginPanel.Name = "LoginPanel"
        Me.LoginPanel.Size = New System.Drawing.Size(404, 248)
        Me.LoginPanel.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.User)
        Me.Panel1.Location = New System.Drawing.Point(0, 87)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 48)
        Me.Panel1.TabIndex = 7
        '
        'UserNameTextBoxPanel
        '
        Me.UserNameTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserNameTextBoxPanel.Controls.Add(Me.Password)
        Me.UserNameTextBoxPanel.Location = New System.Drawing.Point(0, 197)
        Me.UserNameTextBoxPanel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UserNameTextBoxPanel.Name = "UserNameTextBoxPanel"
        Me.UserNameTextBoxPanel.Size = New System.Drawing.Size(404, 48)
        Me.UserNameTextBoxPanel.TabIndex = 1
        '
        'LoginTitleLable
        '
        Me.LoginTitleLable.Font = New System.Drawing.Font("Roboto", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LoginTitleLable.Location = New System.Drawing.Point(-4, 0)
        Me.LoginTitleLable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LoginTitleLable.Name = "LoginTitleLable"
        Me.LoginTitleLable.Size = New System.Drawing.Size(164, 30)
        Me.LoginTitleLable.TabIndex = 0
        Me.LoginTitleLable.Text = "Eclipse Login"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.SpecialPricing.My.Resources.Resources.CloseIcon_Small
        Me.Button1.Location = New System.Drawing.Point(466, -1)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(503, 31)
        Me.Panel2.TabIndex = 7
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(503, 393)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LoginPanel)
        Me.Controls.Add(Me.ConnectButton)
        Me.Font = New System.Drawing.Font("Roboto", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Name = "LoginForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.LoginPanel.ResumeLayout(False)
        Me.LoginPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.UserNameTextBoxPanel.ResumeLayout(False)
        Me.UserNameTextBoxPanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UserIdLabel As Label
    Friend WithEvents ConnectButton As Button
    Friend WithEvents User As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents LoginPanel As Panel
    Friend WithEvents LoginTitleLable As Label
    Friend WithEvents UserNameTextBoxPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
End Class
