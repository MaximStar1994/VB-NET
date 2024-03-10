<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueryForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.customerSearchTextbox = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Top100Checkbox = New System.Windows.Forms.CheckBox()
        Me.Top10Checkbox = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.mabisCheckbox = New System.Windows.Forms.CheckBox()
        Me.includeNonSpecialCheckbox = New System.Windows.Forms.CheckBox()
        Me.searchCustAccountBtn = New System.Windows.Forms.Button()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CustomerSearchPanel = New System.Windows.Forms.Panel()
        Me.FindCustButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProductSerchPanel = New System.Windows.Forms.Panel()
        Me.ClearProductLable = New System.Windows.Forms.LinkLabel()
        Me.ProductSearchListBox = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ProductSearchBtn = New System.Windows.Forms.Button()
        Me.productSearchTextbox = New System.Windows.Forms.TextBox()
        Me.ProductIDRadiobtn = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.KeywordRadiobtn = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CustomerSearchPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ProductSerchPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(38, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Search customer/ product"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(42, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(417, 47)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Search by customer bill to ID/ product ID and use filters to retrieve the relevan" &
    "t pricing information."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(42, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customer Bill To ID*"
        '
        'customerSearchTextbox
        '
        Me.customerSearchTextbox.BackColor = System.Drawing.SystemColors.Control
        Me.customerSearchTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.customerSearchTextbox.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.customerSearchTextbox.ForeColor = System.Drawing.Color.Black
        Me.customerSearchTextbox.Location = New System.Drawing.Point(16, 12)
        Me.customerSearchTextbox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.customerSearchTextbox.Name = "customerSearchTextbox"
        Me.customerSearchTextbox.Size = New System.Drawing.Size(322, 20)
        Me.customerSearchTextbox.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(16, 12)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(322, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(2, 106)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Search By:"
        '
        'Top100Checkbox
        '
        Me.Top100Checkbox.AutoSize = True
        Me.Top100Checkbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Top100Checkbox.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Top100Checkbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Top100Checkbox.Location = New System.Drawing.Point(98, 268)
        Me.Top100Checkbox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Top100Checkbox.Name = "Top100Checkbox"
        Me.Top100Checkbox.Size = New System.Drawing.Size(68, 19)
        Me.Top100Checkbox.TabIndex = 12
        Me.Top100Checkbox.Text = "Top 100"
        Me.Top100Checkbox.UseVisualStyleBackColor = True
        '
        'Top10Checkbox
        '
        Me.Top10Checkbox.AutoSize = True
        Me.Top10Checkbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Top10Checkbox.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Top10Checkbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Top10Checkbox.Location = New System.Drawing.Point(6, 268)
        Me.Top10Checkbox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Top10Checkbox.Name = "Top10Checkbox"
        Me.Top10Checkbox.Size = New System.Drawing.Size(61, 19)
        Me.Top10Checkbox.TabIndex = 11
        Me.Top10Checkbox.Text = "Top 10"
        Me.Top10Checkbox.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(2, 241)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Filter by:"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox5.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.CheckBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.CheckBox5.Location = New System.Drawing.Point(100, 325)
        Me.CheckBox5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(58, 19)
        Me.CheckBox5.TabIndex = 14
        Me.CheckBox5.Text = "AMAA"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'mabisCheckbox
        '
        Me.mabisCheckbox.AutoSize = True
        Me.mabisCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mabisCheckbox.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.mabisCheckbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.mabisCheckbox.Location = New System.Drawing.Point(2, 325)
        Me.mabisCheckbox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.mabisCheckbox.Name = "mabisCheckbox"
        Me.mabisCheckbox.Size = New System.Drawing.Size(62, 19)
        Me.mabisCheckbox.TabIndex = 13
        Me.mabisCheckbox.Text = "MABIS"
        Me.mabisCheckbox.UseVisualStyleBackColor = True
        '
        'includeNonSpecialCheckbox
        '
        Me.includeNonSpecialCheckbox.AutoSize = True
        Me.includeNonSpecialCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.includeNonSpecialCheckbox.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.includeNonSpecialCheckbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.includeNonSpecialCheckbox.Location = New System.Drawing.Point(2, 382)
        Me.includeNonSpecialCheckbox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.includeNonSpecialCheckbox.Name = "includeNonSpecialCheckbox"
        Me.includeNonSpecialCheckbox.Size = New System.Drawing.Size(200, 19)
        Me.includeNonSpecialCheckbox.TabIndex = 15
        Me.includeNonSpecialCheckbox.Text = "Include products not on special"
        Me.includeNonSpecialCheckbox.UseVisualStyleBackColor = True
        '
        'searchCustAccountBtn
        '
        Me.searchCustAccountBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.searchCustAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchCustAccountBtn.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.searchCustAccountBtn.ForeColor = System.Drawing.Color.White
        Me.searchCustAccountBtn.Location = New System.Drawing.Point(0, 437)
        Me.searchCustAccountBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.searchCustAccountBtn.Name = "searchCustAccountBtn"
        Me.searchCustAccountBtn.Size = New System.Drawing.Size(91, 40)
        Me.searchCustAccountBtn.TabIndex = 16
        Me.searchCustAccountBtn.Text = "Search"
        Me.searchCustAccountBtn.UseVisualStyleBackColor = False
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox8.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.CheckBox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.CheckBox8.Location = New System.Drawing.Point(177, 241)
        Me.CheckBox8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(91, 19)
        Me.CheckBox8.TabIndex = 10
        Me.CheckBox8.Text = "Transaction"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox9.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.CheckBox9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.CheckBox9.Location = New System.Drawing.Point(73, 241)
        Me.CheckBox9.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(90, 19)
        Me.CheckBox9.TabIndex = 9
        Me.CheckBox9.Text = "Sales Value"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CustomerSearchPanel
        '
        Me.CustomerSearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerSearchPanel.Controls.Add(Me.FindCustButton)
        Me.CustomerSearchPanel.Controls.Add(Me.customerSearchTextbox)
        Me.CustomerSearchPanel.Location = New System.Drawing.Point(45, 130)
        Me.CustomerSearchPanel.Name = "CustomerSearchPanel"
        Me.CustomerSearchPanel.Size = New System.Drawing.Size(404, 40)
        Me.CustomerSearchPanel.TabIndex = 24
        '
        'FindCustButton
        '
        Me.FindCustButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.FindCustButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.FindCustButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FindCustButton.Image = Global.SpecialPricing.My.Resources.Resources.smallLense1
        Me.FindCustButton.Location = New System.Drawing.Point(346, 0)
        Me.FindCustButton.Name = "FindCustButton"
        Me.FindCustButton.Size = New System.Drawing.Size(56, 38)
        Me.FindCustButton.TabIndex = 2
        Me.FindCustButton.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(0, 1)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 24)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Customer name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Location = New System.Drawing.Point(3, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 40)
        Me.Panel1.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(0, 81)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 24)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Product"
        '
        'ProductSerchPanel
        '
        Me.ProductSerchPanel.Controls.Add(Me.Panel1)
        Me.ProductSerchPanel.Controls.Add(Me.ClearProductLable)
        Me.ProductSerchPanel.Controls.Add(Me.Label8)
        Me.ProductSerchPanel.Controls.Add(Me.ProductSearchListBox)
        Me.ProductSerchPanel.Controls.Add(Me.Label10)
        Me.ProductSerchPanel.Controls.Add(Me.Panel2)
        Me.ProductSerchPanel.Controls.Add(Me.ProductIDRadiobtn)
        Me.ProductSerchPanel.Controls.Add(Me.Label9)
        Me.ProductSerchPanel.Controls.Add(Me.Label5)
        Me.ProductSerchPanel.Controls.Add(Me.KeywordRadiobtn)
        Me.ProductSerchPanel.Controls.Add(Me.Label4)
        Me.ProductSerchPanel.Controls.Add(Me.CheckBox9)
        Me.ProductSerchPanel.Controls.Add(Me.Label7)
        Me.ProductSerchPanel.Controls.Add(Me.searchCustAccountBtn)
        Me.ProductSerchPanel.Controls.Add(Me.Label6)
        Me.ProductSerchPanel.Controls.Add(Me.CheckBox8)
        Me.ProductSerchPanel.Controls.Add(Me.includeNonSpecialCheckbox)
        Me.ProductSerchPanel.Controls.Add(Me.CheckBox5)
        Me.ProductSerchPanel.Controls.Add(Me.Top10Checkbox)
        Me.ProductSerchPanel.Controls.Add(Me.mabisCheckbox)
        Me.ProductSerchPanel.Controls.Add(Me.Top100Checkbox)
        Me.ProductSerchPanel.Location = New System.Drawing.Point(45, 195)
        Me.ProductSerchPanel.Name = "ProductSerchPanel"
        Me.ProductSerchPanel.Size = New System.Drawing.Size(415, 478)
        Me.ProductSerchPanel.TabIndex = 28
        Me.ProductSerchPanel.Visible = False
        '
        'ClearProductLable
        '
        Me.ClearProductLable.AutoSize = True
        Me.ClearProductLable.Location = New System.Drawing.Point(318, 111)
        Me.ClearProductLable.Name = "ClearProductLable"
        Me.ClearProductLable.Size = New System.Drawing.Size(33, 13)
        Me.ClearProductLable.TabIndex = 6
        Me.ClearProductLable.TabStop = True
        Me.ClearProductLable.Text = "Clear"
        Me.ClearProductLable.Visible = False
        '
        'ProductSearchListBox
        '
        Me.ProductSearchListBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ProductSearchListBox.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ProductSearchListBox.FormattingEnabled = True
        Me.ProductSearchListBox.ItemHeight = 19
        Me.ProductSearchListBox.Location = New System.Drawing.Point(5, 184)
        Me.ProductSearchListBox.Name = "ProductSearchListBox"
        Me.ProductSearchListBox.ScrollAlwaysVisible = True
        Me.ProductSearchListBox.Size = New System.Drawing.Size(404, 4)
        Me.ProductSearchListBox.TabIndex = 8
        Me.ProductSearchListBox.Visible = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(1, 354)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 24)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "New special:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ProductSearchBtn)
        Me.Panel2.Controls.Add(Me.productSearchTextbox)
        Me.Panel2.Location = New System.Drawing.Point(3, 133)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(404, 40)
        Me.Panel2.TabIndex = 29
        '
        'ProductSearchBtn
        '
        Me.ProductSearchBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ProductSearchBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.ProductSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProductSearchBtn.Image = Global.SpecialPricing.My.Resources.Resources.smallLense1
        Me.ProductSearchBtn.Location = New System.Drawing.Point(346, 0)
        Me.ProductSearchBtn.Name = "ProductSearchBtn"
        Me.ProductSearchBtn.Size = New System.Drawing.Size(56, 38)
        Me.ProductSearchBtn.TabIndex = 25
        Me.ProductSearchBtn.UseVisualStyleBackColor = False
        '
        'productSearchTextbox
        '
        Me.productSearchTextbox.BackColor = System.Drawing.SystemColors.Control
        Me.productSearchTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.productSearchTextbox.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.productSearchTextbox.Location = New System.Drawing.Point(16, 12)
        Me.productSearchTextbox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.productSearchTextbox.Name = "productSearchTextbox"
        Me.productSearchTextbox.Size = New System.Drawing.Size(322, 20)
        Me.productSearchTextbox.TabIndex = 7
        '
        'ProductIDRadiobtn
        '
        Me.ProductIDRadiobtn.AutoSize = True
        Me.ProductIDRadiobtn.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ProductIDRadiobtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ProductIDRadiobtn.Location = New System.Drawing.Point(169, 106)
        Me.ProductIDRadiobtn.Name = "ProductIDRadiobtn"
        Me.ProductIDRadiobtn.Size = New System.Drawing.Size(85, 19)
        Me.ProductIDRadiobtn.TabIndex = 5
        Me.ProductIDRadiobtn.TabStop = True
        Me.ProductIDRadiobtn.Text = "Product ID"
        Me.ProductIDRadiobtn.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(0, 218)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 24)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Top performers filter:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(1, 300)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 24)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Stock and sales filter:"
        '
        'KeywordRadiobtn
        '
        Me.KeywordRadiobtn.AutoSize = True
        Me.KeywordRadiobtn.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.KeywordRadiobtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.KeywordRadiobtn.Location = New System.Drawing.Point(81, 106)
        Me.KeywordRadiobtn.Name = "KeywordRadiobtn"
        Me.KeywordRadiobtn.Size = New System.Drawing.Size(74, 19)
        Me.KeywordRadiobtn.TabIndex = 4
        Me.KeywordRadiobtn.TabStop = True
        Me.KeywordRadiobtn.Text = "Keyword"
        Me.KeywordRadiobtn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(503, 31)
        Me.Panel3.TabIndex = 30
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
        'QueryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(503, 712)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.CustomerSearchPanel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProductSerchPanel)
        Me.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QueryForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.CustomerSearchPanel.ResumeLayout(False)
        Me.CustomerSearchPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ProductSerchPanel.ResumeLayout(False)
        Me.ProductSerchPanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents customerSearchTextbox As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Top100Checkbox As CheckBox
    Friend WithEvents Top10Checkbox As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents mabisCheckbox As CheckBox
    Friend WithEvents includeNonSpecialCheckbox As CheckBox
    Friend WithEvents searchCustAccountBtn As Button
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CustomerSearchPanel As Panel
    Friend WithEvents FindCustButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents ProductSerchPanel As Panel
    Friend WithEvents ProductIDRadiobtn As RadioButton
    Friend WithEvents KeywordRadiobtn As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ProductSearchBtn As Button
    Friend WithEvents productSearchTextbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ProductSearchListBox As ListBox
    Friend WithEvents ClearProductLable As LinkLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
End Class
