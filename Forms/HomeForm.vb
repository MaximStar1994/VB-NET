Imports SpecialPricing.UVObjects

Public Class HomeForm
    Private searchType As String = "product"
    Public _custInfo As List(Of SpecialPricingInfo)
    Private Sub QueryButton_Click(sender As Object, e As EventArgs) Handles CustomerLookUpButton.Click
        If CustomerSearchTextBox.Text = "" Then
            MessageBox.Show("Please enter a keyword in the search box", "Validation failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CustomerSearchTextBox.Focus()
            Return
        End If
        SearchListBox.DataBindings.Clear()
        searchType = "customer"
        Dim clist As List(Of CustomerInfo) = UVObjects.Program.SearchCustomer(CustomerSearchTextBox.Text)
        SearchListBox.DataSource = clist
        SearchListBox.DisplayMember = "Name"
        SearchListBox.ValueMember = "Id"
        'For Each item In plist
        '    SearchListBox.Items.Add(item)
        '    SearchListBox.DisplayMember()
        '    'SearchListBox.Items.Add("this is the second row")
        'Next

    End Sub

    Private Sub ProductLookupButton_Click(sender As Object, e As EventArgs) Handles ProductLookupButton.Click

        searchType = "product"
        If ProductSearchTextBox.Text = "" Then
            MessageBox.Show("Please enter a keyword in the search box", "Validation failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ProductSearchTextBox.Focus()
            Return
        End If
        Dim plist As List(Of ProductInfo) = UVObjects.Program.SearchProduct(ProductSearchTextBox.Text, True)
        SearchListBox.DataSource = plist
        SearchListBox.DisplayMember = "Name"
        SearchListBox.ValueMember = "Id"
    End Sub

    Private Sub SearchListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchListBox.SelectedIndexChanged
        If searchType = "product" Then
            ProductSearchTextBox.Text = SearchListBox.SelectedValue.ToString()
        Else
            CustomerSearchTextBox.Text = SearchListBox.SelectedValue.ToString()
        End If
    End Sub

    Private Sub SerchSelectOKButton_Click(sender As Object, e As EventArgs) Handles SerchSelectOKButton.Click
        connStatusLable.Visible = True
        'use selection box ID field instead of text box
        'QueryResult.CustomerLable.Text = SearchListBox.Text
        'QueryResult.BillToCustomerIDLable.Text = CustomerSearchTextBox.Text

        Dim recordCount As Integer = 0

        If Top10ProductCheckbox.Checked Then
            recordCount = 10
        ElseIf Top100ProductCheckbox.Checked Then
            recordCount = 100
        End If

        UVObjects.Program.SearchCustAccount(ProductSearchTextBox.Text, CustomerSearchTextBox.Text, recordCount, IncludeNonSpecialCheckBox.Checked, CoreProductsMyBranchLabel.Checked, "")
        'QueryResult.CustAccountGrid.DataSource = Program._spInfo
        'QueryResult.Visible = True
        'ParentForm.CreateModifyButton.Visible = True


    End Sub

    Private Sub HomeFormClearSearchButton_Click(sender As Object, e As EventArgs) Handles HomeFormClearSearchButton.Click
        SearchListBox.DataBindings.Clear()
        'SearchListBox.Items.Clear()
        ProductSearchTextBox.Clear()
        CustomerSearchTextBox.Clear()
    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Top10ProductCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles Top10ProductCheckbox.CheckedChanged
        If Top100ProductCheckbox.Checked Then
            Top100ProductCheckbox.Checked = False
        End If
    End Sub

    Private Sub Top100ProductCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles Top100ProductCheckbox.CheckedChanged
        If Top10ProductCheckbox.Checked Then
            Top10ProductCheckbox.Checked = False
        End If
    End Sub
End Class