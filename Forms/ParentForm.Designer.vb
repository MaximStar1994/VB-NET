<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ParentForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParentForm))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.TopLeftPanel = New System.Windows.Forms.Panel()
        Me.BranchLabel = New System.Windows.Forms.Label()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.bar3 = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ReviewButton = New System.Windows.Forms.Button()
        Me.CreateModifyButton = New System.Windows.Forms.Button()
        Me.bar1 = New System.Windows.Forms.Label()
        Me.bar2 = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.HelpBtn = New System.Windows.Forms.Button()
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.asterisLabel = New System.Windows.Forms.Label()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        Me.TopLeftPanel.SuspendLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 822)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 15, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1539, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'TopPanel
        '
        Me.TopPanel.AutoSize = True
        Me.TopPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TopPanel.BackColor = System.Drawing.SystemColors.Window
        Me.TopPanel.Controls.Add(Me.TopLeftPanel)
        Me.TopPanel.Controls.Add(Me.bar3)
        Me.TopPanel.Controls.Add(Me.SearchButton)
        Me.TopPanel.Controls.Add(Me.ReviewButton)
        Me.TopPanel.Controls.Add(Me.CreateModifyButton)
        Me.TopPanel.Controls.Add(Me.asterisLabel)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1539, 44)
        Me.TopPanel.TabIndex = 11
        '
        'TopLeftPanel
        '
        Me.TopLeftPanel.Controls.Add(Me.HelpBtn)
        Me.TopLeftPanel.Controls.Add(Me.BranchLabel)
        Me.TopLeftPanel.Controls.Add(Me.LogOutButton)
        Me.TopLeftPanel.Controls.Add(Me.UserNameLabel)
        Me.TopLeftPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.TopLeftPanel.Location = New System.Drawing.Point(1366, 0)
        Me.TopLeftPanel.Name = "TopLeftPanel"
        Me.TopLeftPanel.Size = New System.Drawing.Size(173, 44)
        Me.TopLeftPanel.TabIndex = 18
        '
        'BranchLabel
        '
        Me.BranchLabel.AutoSize = True
        Me.BranchLabel.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.BranchLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.BranchLabel.Location = New System.Drawing.Point(101, 23)
        Me.BranchLabel.Name = "BranchLabel"
        Me.BranchLabel.Size = New System.Drawing.Size(35, 14)
        Me.BranchLabel.TabIndex = 19
        Me.BranchLabel.Text = "1003"
        '
        'UserNameLabel
        '
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.UserNameLabel.Location = New System.Drawing.Point(101, 10)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(64, 14)
        Me.UserNameLabel.TabIndex = 18
        Me.UserNameLabel.Text = "UserName"
        '
        'bar3
        '
        Me.bar3.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.bar3.Location = New System.Drawing.Point(69, 37)
        Me.bar3.Name = "bar3"
        Me.bar3.Size = New System.Drawing.Size(81, 4)
        Me.bar3.TabIndex = 18
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.SystemColors.Window
        Me.SearchButton.FlatAppearance.BorderSize = 0
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.SearchButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.SearchButton.Location = New System.Drawing.Point(69, 12)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(81, 27)
        Me.SearchButton.TabIndex = 8
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'ReviewButton
        '
        Me.ReviewButton.BackColor = System.Drawing.SystemColors.Window
        Me.ReviewButton.FlatAppearance.BorderSize = 0
        Me.ReviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReviewButton.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ReviewButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ReviewButton.Location = New System.Drawing.Point(287, 12)
        Me.ReviewButton.Name = "ReviewButton"
        Me.ReviewButton.Size = New System.Drawing.Size(85, 27)
        Me.ReviewButton.TabIndex = 4
        Me.ReviewButton.Text = "Review"
        Me.ReviewButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ReviewButton.UseVisualStyleBackColor = False
        '
        'CreateModifyButton
        '
        Me.CreateModifyButton.BackColor = System.Drawing.SystemColors.Window
        Me.CreateModifyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CreateModifyButton.FlatAppearance.BorderSize = 0
        Me.CreateModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateModifyButton.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.CreateModifyButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CreateModifyButton.Location = New System.Drawing.Point(150, 12)
        Me.CreateModifyButton.Name = "CreateModifyButton"
        Me.CreateModifyButton.Size = New System.Drawing.Size(137, 27)
        Me.CreateModifyButton.TabIndex = 3
        Me.CreateModifyButton.Text = "Create/Modify"
        Me.CreateModifyButton.UseVisualStyleBackColor = False
        '
        'bar1
        '
        Me.bar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.bar1.Location = New System.Drawing.Point(150, 37)
        Me.bar1.Name = "bar1"
        Me.bar1.Size = New System.Drawing.Size(137, 4)
        Me.bar1.TabIndex = 13
        '
        'bar2
        '
        Me.bar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.bar2.Location = New System.Drawing.Point(287, 37)
        Me.bar2.Name = "bar2"
        Me.bar2.Size = New System.Drawing.Size(85, 4)
        Me.bar2.TabIndex = 14
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnLogOut.BackgroundImage = Global.SpecialPricing.My.Resources.Resources.LogoutButton1
        Me.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(1419, 50)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(99, 35)
        Me.btnLogOut.TabIndex = 16
        Me.btnLogOut.Text = "Logout"
        Me.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogOut.UseVisualStyleBackColor = False
        Me.btnLogOut.Visible = False
        '
        'HelpButton
        '
        Me.HelpBtn.BackColor = System.Drawing.SystemColors.Window
        Me.HelpBtn.FlatAppearance.BorderSize = 0
        Me.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpBtn.Font = New System.Drawing.Font("Roboto", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.HelpBtn.Image = Global.SpecialPricing.My.Resources.Resources.smallHelpIcom1
        Me.HelpBtn.Location = New System.Drawing.Point(3, 6)
        Me.HelpBtn.Name = "HelpButton"
        Me.HelpBtn.Size = New System.Drawing.Size(32, 33)
        Me.HelpBtn.TabIndex = 7
        Me.HelpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.HelpBtn.UseVisualStyleBackColor = False
        '
        'LogOutButton
        '
        Me.LogOutButton.BackColor = System.Drawing.SystemColors.Window
        Me.LogOutButton.BackgroundImage = Global.SpecialPricing.My.Resources.Resources.PersonaLogo
        Me.LogOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LogOutButton.FlatAppearance.BorderSize = 0
        Me.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOutButton.Font = New System.Drawing.Font("Roboto", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LogOutButton.ForeColor = System.Drawing.Color.Black
        Me.LogOutButton.Location = New System.Drawing.Point(41, 3)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(49, 36)
        Me.LogOutButton.TabIndex = 5
        Me.LogOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.LogOutButton.UseVisualStyleBackColor = False
        '
        'asterisLabel
        '
        Me.asterisLabel.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.asterisLabel.ForeColor = System.Drawing.Color.White
        Me.asterisLabel.Image = Global.SpecialPricing.My.Resources.Resources.smallergreenbubble
        Me.asterisLabel.Location = New System.Drawing.Point(371, 11)
        Me.asterisLabel.Name = "asterisLabel"
        Me.asterisLabel.Size = New System.Drawing.Size(40, 33)
        Me.asterisLabel.TabIndex = 2
        Me.asterisLabel.Text = "1"
        Me.asterisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.asterisLabel.Visible = False
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataSource = GetType(SpecialPricing.UVObjects.Product)
        '
        'ParentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(1539, 844)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.bar2)
        Me.Controls.Add(Me.bar1)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.StatusStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(1538, 830)
        Me.Name = "ParentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Pricing Search"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.TopPanel.ResumeLayout(False)
        Me.TopLeftPanel.ResumeLayout(False)
        Me.TopLeftPanel.PerformLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents StatusLabel As ToolStripStatusLabel
    Friend WithEvents TopPanel As Panel
    Friend WithEvents LogOutButton As Button
    Friend WithEvents ReviewButton As Button
    Friend WithEvents CreateModifyButton As Button
    Friend WithEvents HelpBtn As Button
    Friend WithEvents asterisLabel As Label
    Friend WithEvents bar1 As Label
    Friend WithEvents bar2 As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents bar3 As Label
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents BranchLabel As Label
    Friend WithEvents TopLeftPanel As Panel
    Friend WithEvents btnLogOut As Button
End Class
