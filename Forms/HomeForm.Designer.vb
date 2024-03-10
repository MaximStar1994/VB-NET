<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HomeFormClearSearchButton = New System.Windows.Forms.Button()
        Me.SerchSelectOKButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductSearchTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerSearchTextBox = New System.Windows.Forms.TextBox()
        Me.Product = New System.Windows.Forms.Label()
        Me.CustomerLabel = New System.Windows.Forms.Label()
        Me.SearchListBox = New System.Windows.Forms.ListBox()
        Me.Top100ProductCheckbox = New System.Windows.Forms.CheckBox()
        Me.Top10ProductCheckbox = New System.Windows.Forms.CheckBox()
        Me.IncludeNonSpecialCheckBox = New System.Windows.Forms.CheckBox()
        Me.CoreProductsMyBranchLabel = New System.Windows.Forms.CheckBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.connStatusLable = New System.Windows.Forms.Label()
        Me.ProductLookupButton = New System.Windows.Forms.Button()
        Me.CustomerLookUpButton = New System.Windows.Forms.Button()
        Me.ProductInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.ProductInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.HomeFormClearSearchButton)
        Me.Panel1.Controls.Add(Me.SerchSelectOKButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(4, 12)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(979, 72)
        Me.Panel1.TabIndex = 11
        '
        'HomeFormClearSearchButton
        '
        Me.HomeFormClearSearchButton.Location = New System.Drawing.Point(824, 35)
        Me.HomeFormClearSearchButton.Margin = New System.Windows.Forms.Padding(4)
        Me.HomeFormClearSearchButton.Name = "HomeFormClearSearchButton"
        Me.HomeFormClearSearchButton.Size = New System.Drawing.Size(129, 28)
        Me.HomeFormClearSearchButton.TabIndex = 2
        Me.HomeFormClearSearchButton.Text = "Clear Search"
        Me.HomeFormClearSearchButton.UseVisualStyleBackColor = True
        '
        'SerchSelectOKButton
        '
        Me.SerchSelectOKButton.Location = New System.Drawing.Point(703, 34)
        Me.SerchSelectOKButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SerchSelectOKButton.Name = "SerchSelectOKButton"
        Me.SerchSelectOKButton.Size = New System.Drawing.Size(100, 28)
        Me.SerchSelectOKButton.TabIndex = 1
        Me.SerchSelectOKButton.Text = "OK"
        Me.SerchSelectOKButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Pricing Search"
        '
        'ProductSearchTextBox
        '
        Me.ProductSearchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductSearchTextBox.Location = New System.Drawing.Point(164, 145)
        Me.ProductSearchTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductSearchTextBox.Name = "ProductSearchTextBox"
        Me.ProductSearchTextBox.Size = New System.Drawing.Size(269, 26)
        Me.ProductSearchTextBox.TabIndex = 21
        '
        'CustomerSearchTextBox
        '
        Me.CustomerSearchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerSearchTextBox.Location = New System.Drawing.Point(163, 102)
        Me.CustomerSearchTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerSearchTextBox.Name = "CustomerSearchTextBox"
        Me.CustomerSearchTextBox.Size = New System.Drawing.Size(271, 26)
        Me.CustomerSearchTextBox.TabIndex = 19
        '
        'Product
        '
        Me.Product.AutoSize = True
        Me.Product.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Product.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product.Location = New System.Drawing.Point(21, 150)
        Me.Product.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Product.Name = "Product"
        Me.Product.Size = New System.Drawing.Size(71, 20)
        Me.Product.TabIndex = 18
        Me.Product.Text = "Product"
        '
        'CustomerLabel
        '
        Me.CustomerLabel.AutoSize = True
        Me.CustomerLabel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CustomerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerLabel.Location = New System.Drawing.Point(21, 109)
        Me.CustomerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CustomerLabel.Name = "CustomerLabel"
        Me.CustomerLabel.Size = New System.Drawing.Size(86, 20)
        Me.CustomerLabel.TabIndex = 17
        Me.CustomerLabel.Text = "Customer"
        '
        'SearchListBox
        '
        Me.SearchListBox.FormattingEnabled = True
        Me.SearchListBox.Location = New System.Drawing.Point(456, 108)
        Me.SearchListBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchListBox.Name = "SearchListBox"
        Me.SearchListBox.ScrollAlwaysVisible = True
        Me.SearchListBox.Size = New System.Drawing.Size(516, 251)
        Me.SearchListBox.TabIndex = 23
        '
        'Top100ProductCheckbox
        '
        Me.Top100ProductCheckbox.AutoSize = True
        Me.Top100ProductCheckbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Top100ProductCheckbox.Location = New System.Drawing.Point(21, 236)
        Me.Top100ProductCheckbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Top100ProductCheckbox.Name = "Top100ProductCheckbox"
        Me.Top100ProductCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Top100ProductCheckbox.Size = New System.Drawing.Size(169, 24)
        Me.Top100ProductCheckbox.TabIndex = 25
        Me.Top100ProductCheckbox.Text = "Top 100 Products"
        Me.Top100ProductCheckbox.UseVisualStyleBackColor = True
        '
        'Top10ProductCheckbox
        '
        Me.Top10ProductCheckbox.AutoSize = True
        Me.Top10ProductCheckbox.Checked = True
        Me.Top10ProductCheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Top10ProductCheckbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Top10ProductCheckbox.Location = New System.Drawing.Point(21, 190)
        Me.Top10ProductCheckbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Top10ProductCheckbox.Name = "Top10ProductCheckbox"
        Me.Top10ProductCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Top10ProductCheckbox.Size = New System.Drawing.Size(159, 24)
        Me.Top10ProductCheckbox.TabIndex = 37
        Me.Top10ProductCheckbox.Text = "Top 10 Products"
        Me.Top10ProductCheckbox.UseVisualStyleBackColor = True
        '
        'IncludeNonSpecialCheckBox
        '
        Me.IncludeNonSpecialCheckBox.AutoSize = True
        Me.IncludeNonSpecialCheckBox.Checked = True
        Me.IncludeNonSpecialCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.IncludeNonSpecialCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncludeNonSpecialCheckBox.Location = New System.Drawing.Point(21, 327)
        Me.IncludeNonSpecialCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IncludeNonSpecialCheckBox.Name = "IncludeNonSpecialCheckBox"
        Me.IncludeNonSpecialCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.IncludeNonSpecialCheckBox.Size = New System.Drawing.Size(282, 24)
        Me.IncludeNonSpecialCheckBox.TabIndex = 32
        Me.IncludeNonSpecialCheckBox.Text = "Include products not on Special"
        Me.IncludeNonSpecialCheckBox.UseVisualStyleBackColor = True
        '
        'CoreProductsMyBranchLabel
        '
        Me.CoreProductsMyBranchLabel.AutoSize = True
        Me.CoreProductsMyBranchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoreProductsMyBranchLabel.Location = New System.Drawing.Point(21, 281)
        Me.CoreProductsMyBranchLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.CoreProductsMyBranchLabel.Name = "CoreProductsMyBranchLabel"
        Me.CoreProductsMyBranchLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CoreProductsMyBranchLabel.Size = New System.Drawing.Size(336, 24)
        Me.CoreProductsMyBranchLabel.TabIndex = 33
        Me.CoreProductsMyBranchLabel.Text = "Add core products (MABIS) by dividion"
        Me.CoreProductsMyBranchLabel.UseVisualStyleBackColor = True
        '
        'connStatusLable
        '
        Me.connStatusLable.AutoSize = True
        Me.connStatusLable.Font = New System.Drawing.Font("Lucida Sans", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connStatusLable.Location = New System.Drawing.Point(861, 387)
        Me.connStatusLable.Name = "connStatusLable"
        Me.connStatusLable.Size = New System.Drawing.Size(96, 15)
        Me.connStatusLable.TabIndex = 38
        Me.connStatusLable.Text = "Loading data.."
        Me.connStatusLable.UseWaitCursor = True
        Me.connStatusLable.Visible = False
        '
        'ProductLookupButton
        '
        Me.ProductLookupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductLookupButton.Image = CType(resources.GetObject("ProductLookupButton.Image"), System.Drawing.Image)
        Me.ProductLookupButton.Location = New System.Drawing.Point(400, 146)
        Me.ProductLookupButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductLookupButton.Name = "ProductLookupButton"
        Me.ProductLookupButton.Size = New System.Drawing.Size(35, 25)
        Me.ProductLookupButton.TabIndex = 22
        Me.ProductLookupButton.UseVisualStyleBackColor = True
        '
        'CustomerLookUpButton
        '
        Me.CustomerLookUpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerLookUpButton.Image = CType(resources.GetObject("CustomerLookUpButton.Image"), System.Drawing.Image)
        Me.CustomerLookUpButton.Location = New System.Drawing.Point(400, 102)
        Me.CustomerLookUpButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerLookUpButton.Name = "CustomerLookUpButton"
        Me.CustomerLookUpButton.Size = New System.Drawing.Size(35, 27)
        Me.CustomerLookUpButton.TabIndex = 20
        Me.CustomerLookUpButton.UseVisualStyleBackColor = True
        '
        'ProductInfoBindingSource
        '
        Me.ProductInfoBindingSource.DataSource = GetType(SpecialPricing.UVObjects.ProductInfo)
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataSource = GetType(SpecialPricing.UVObjects.Product)
        '
        'HomeForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(985, 490)
        Me.ControlBox = False
        Me.Controls.Add(Me.connStatusLable)
        Me.Controls.Add(Me.Top10ProductCheckbox)
        Me.Controls.Add(Me.CoreProductsMyBranchLabel)
        Me.Controls.Add(Me.IncludeNonSpecialCheckBox)
        Me.Controls.Add(Me.Top100ProductCheckbox)
        Me.Controls.Add(Me.SearchListBox)
        Me.Controls.Add(Me.ProductLookupButton)
        Me.Controls.Add(Me.ProductSearchTextBox)
        Me.Controls.Add(Me.CustomerLookUpButton)
        Me.Controls.Add(Me.CustomerSearchTextBox)
        Me.Controls.Add(Me.Product)
        Me.Controls.Add(Me.CustomerLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Query"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProductInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents HomeFormClearSearchButton As Button
    Friend WithEvents SerchSelectOKButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ProductLookupButton As Button
    Friend WithEvents ProductSearchTextBox As TextBox
    Friend WithEvents CustomerLookUpButton As Button
    Friend WithEvents CustomerSearchTextBox As TextBox
    Friend WithEvents Product As Label
    Friend WithEvents CustomerLabel As Label
    Friend WithEvents SearchListBox As ListBox
    Friend WithEvents ProductInfoBindingSource As BindingSource
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents Top100ProductCheckbox As CheckBox
    Friend WithEvents Top10ProductCheckbox As CheckBox
    Friend WithEvents IncludeNonSpecialCheckBox As CheckBox
    Friend WithEvents CoreProductsMyBranchLabel As CheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents connStatusLable As Label
End Class
