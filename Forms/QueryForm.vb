Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports SpecialPricing.UVObjects

Public Class QueryForm
    Public _productSelected As Boolean = False

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles customerSearchTextbox.Leave
        'If TextBox1.Text = "" Then
        '    Return
        'End If

        'TextBox2.Text = UVObjects.Program.SearchCustomerByID(TextBox1.Text)

    End Sub


    Private Sub searchCustAccountBtn_Click(sender As Object, e As EventArgs) Handles searchCustAccountBtn.Click

        If customerSearchTextbox.Text = "" Then
            MessageBox.Show("Plese enter a bill to customer id", "Required!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim cust As String = Program.SearchCustomerByID(customerSearchTextbox.Text)

        If cust = "" Then
            MessageBox.Show("Plese enter a valid Bill to customer ID", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim recordCount As Integer

        If Top10Checkbox.Checked Then
            recordCount = 10
        ElseIf Top100Checkbox.Checked Then
            recordCount = 100
        End If

        Program._includeNonSpecial = includeNonSpecialCheckbox.Checked
        Program._productSearchText = productSearchTextbox.Text.Trim()
        Program._customerSearchText = customerSearchTextbox.Text.Trim()
        Dim colname As String = ""
        If CheckBox9.Checked Then
            colname = "salesvalue"
        End If

        If CheckBox8.Checked Then
            colname = "transaction"
        End If

        Dim productId As String = ""
        'ProductSearchListBox.SelectedValue.ToString()
        If _productSelected Then
            productId = ProductSearchListBox.SelectedValue.ToString()
            Program._productId = ProductSearchListBox.SelectedValue.ToString()
            Program._productName = ProductSearchListBox.Text.ToString()
        End If

        'searchCustAccountBtn.Text = "Loading. Please wait.."
        searchCustAccountBtn.Width = 195
        searchCustAccountBtn.BackColor = Color.FromKnownColor(KnownColor.ButtonFace)
        searchCustAccountBtn.Text = "Loading. Please wait.."
        searchCustAccountBtn.Enabled = False

        UVObjects.Program.SearchCustAccount(productId, customerSearchTextbox.Text, recordCount, includeNonSpecialCheckbox.Checked, mabisCheckbox.Checked, colname)

        If Program._spInfo.Count = 0 Then
            MessageBox.Show("Data not found in customer account", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Program.ShowQueryResultForm()

        End If
        searchCustAccountBtn.Width = 91
        searchCustAccountBtn.BackColor = Color.FromArgb(0, 55, 102)
        searchCustAccountBtn.Text = "Search"
        searchCustAccountBtn.Enabled = True
    End Sub





    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox8.Checked Then
            CheckBox8.Checked = False
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox9.Checked Then
            CheckBox9.Checked = False
        End If
    End Sub



    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged

    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles includeNonSpecialCheckbox.CheckedChanged

    End Sub

    Private Sub FindCustButton_Click(sender As Object, e As EventArgs) Handles FindCustButton.Click
        If customerSearchTextbox.Text = "" Then
            MessageBox.Show("Plese enter a bill to customer id", "Required!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim cust As String = ""

        cust = Program.SearchCustomerByID(customerSearchTextbox.Text)

        If cust = "" Then
            MessageBox.Show("Plese enter a valid Bill to customer ID", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            customerSearchTextbox.Focus()
            Return
        End If

        Panel1.BackColor = Color.FromArgb(214, 215, 217)
        TextBox2.BackColor = Color.FromArgb(214, 215, 217)
        TextBox2.Text = cust
        TextBox2.Enabled = False

        ' ProductIDRadiobtn.Checked = True
        ProductSerchPanel.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ProductSearchBtn.Click
        Dim plist As List(Of ProductInfo) = New List(Of ProductInfo)
        If productSearchTextbox.Text = "" Then
            MessageBox.Show("Plese enter a product ID or keyword in search text box", "Required!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If ProductIDRadiobtn.Checked Then
            If Not Regex.IsMatch(productSearchTextbox.Text, "^[0-9 ]+$") Then
                MessageBox.Show("Not valid number")
                Return
            End If
            plist = SearchProduct(productSearchTextbox.Text, True)
        ElseIf KeywordRadiobtn.Checked Then
            plist = SearchProduct(productSearchTextbox.Text, False)
        Else

        End If

        If plist.Count < 1 Then
            MessageBox.Show("Product search did not return any matching products, please use different product ID or Keyword", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ProductSearchListBox.DataSource = plist
        ProductSearchListBox.DisplayMember = "Name"
        ProductSearchListBox.ValueMember = "Id"
        ProductSearchListBox.Height = 313
        ProductSearchListBox.Visible = True
    End Sub

    Private Sub ProductSearchListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProductSearchListBox.SelectedIndexChanged

        Dim str As String
        str = ProductSearchListBox.Text.ToString()
        If str.Length > 34 Then
            Panel2.Height = 60
            ProductSearchBtn.Height = 60
            productSearchTextbox.Height = 43
            productSearchTextbox.Multiline = True
            productSearchTextbox.WordWrap = True
        Else
            Panel2.Height = 40
            ProductSearchBtn.Height = 40
            productSearchTextbox.Height = 27
        End If
        productSearchTextbox.Text = ProductSearchListBox.Text.ToString()
        ProductSearchListBox.Height = 23
        ProductSearchListBox.Visible = False
        _productSelected = True
    End Sub

    Private Sub TextBox3_TextChanged_1(sender As Object, e As EventArgs) Handles productSearchTextbox.DoubleClick
        ProductSearchListBox.Height = 313
        ProductSearchListBox.Visible = True
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles customerSearchTextbox.DoubleClick
        customerSearchTextbox.Text = ""
        _productSelected = False
        KeywordRadiobtn.Checked = False
        ProductIDRadiobtn.Checked = False
        productSearchTextbox.Text = ""
        ProductSerchPanel.Visible = False

    End Sub

    Private Sub ClearProductLable_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ClearProductLable.LinkClicked
        productSearchTextbox.Text = ""
        _productSelected = False
        ClearProductLable.Visible = False
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles productSearchTextbox.TextChanged
        ClearProductLable.Visible = True
    End Sub



    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs)

        Button1.BackColor = Color.OrangeRed

    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs)

        Button1.BackColor = Color.FromKnownColor(KnownColor.ButtonFace)

    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub
    Private _moveForm As Boolean
    Private _moveForm_MousePosition As Point

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        If e.Button = MouseButtons.Left Then
            _moveForm = True
            Me.Cursor = Cursors.Default
            _moveForm_MousePosition = e.Location
        End If
    End Sub

    Private Sub Panel3_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel3.MouseUp
        If e.Button = MouseButtons.Left Then
            _moveForm = False
            Me.Cursor = Cursors.Default

        End If
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        If _moveForm Then
            Me.Location = Me.Location + (e.Location - _moveForm_MousePosition)

        End If
    End Sub


End Class