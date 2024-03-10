Imports System.ComponentModel
Imports System.Diagnostics.Eventing.Reader
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.Logging
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Text


Namespace UVObjects

    Module Program
        Private _billToCustomerID As String
        Private _customerName As String = "Awesome customenr"
        Private _userName As String
        Private _userIdInput As String
        Friend _productId As String
        Friend _productName As String
        Private _mabis As Boolean
        ' **********************************************************************
        ' * app properties                                                     *
        ' **********************************************************************

        ' declare the uniVerse data connection object.  this object should be
        ' global to the application so that it's always resident and available
        ' throughout the application
        Public Property DataConnection As UVServer

        ' declare eclipse objects.  creating objects takes a little bit of time
        ' so it's best to declare and create them globally at the start of the
        ' application and reuse them throughout the application
        '
        ' objects can be created locally in the application routines but this may
        ' be a bit slow.  if an object is created locally the object must be
        ' destroyed in the same application routine by invoking the objects
        ' "Destroy" method.  otherwise the object will continue to exist on the
        ' eclipse side until the application session ends
        Public Property UserInitials As Initials
        Public Property Product As Product
        Public Property customer As Customer
        Public Property custAccount As CustAccount
        Public Property _matrix As Matrix
        Public Property _spInfo As List(Of SpecialPricingInfo)
        Public Property _maxEntry As Integer = 0
        Public Property _customerSearchText As String = "123456"
        Public Property _includeNonSpecial As Boolean
        Public Property _productSearchText As String
        Private Property _attHashMap As Dictionary(Of String, String)
        Private Property _attSortHashMap As Dictionary(Of String, Boolean)
        Public Property _sortAttr As String
        Public Property _sortDesc As Boolean
        Public Property _justify As String
        Public Property _homeTerritory As String = "Houston"
        Public Property _outsideSales As String = ""
        Public Property _homeBranch As String = "H23uen"
        Public Property _userHomeBranch As String = "jwojpe"
        Public Property _queryForm As QueryForm
        Public Property _queryResultForm As QueryResult
        Public Property _reviewForm As ReviewForm
        Public Property _parentForm As ParentForm
        Public Property _loginForm As LoginForm



        ' **********************************************************************
        ' **********************************************************************
        ' ** main                                                             **
        ' **********************************************************************
        ' **********************************************************************
        'Public Sub Main()

        '    Initialize()
        '    LaunchLoginForm()

        'End Sub


        Private Sub LaunchLoginForm()

            _loginForm = New LoginForm
            '_loginForm.MdiParent = _parentForm
            _loginForm.User.Text = "dr05171"
            _loginForm.Password.Text = "dr05171p"
            _loginForm.Visible = True
        End Sub

        Public Function Initialize() As Boolean
            ' **********************************************************************
            ' * initialize some things at the beginning of the application         *
            ' **********************************************************************
            Dim ServerName As String
            Initialize = False

            'ServerName = "eclipse-dev.morsco.com"
            ServerName = "eclipse-test.morsco.com"
            'ServerName = "eclipse-prod-db.morsco.com"
            InitializePrimitives()

            ' if we need more initialization add it here.  if anything fails set
            ' initialize false
            DataConnection = New UVServer("", "", ServerName)
            Initialize = True


        End Function
        Public Function ConnectToEclipse(UserId As String, Password As String) As Boolean
            Dim LoginSuccessful As Boolean
            Dim ServerName As String


            ConnectToEclipse = False

            ' connection properties
            '   UserId = "dr05171"
            '   Password = "dr05171p"

            ServerName = DataConnection.ServerName

            Debug.Print("")
            Debug.Print("")
            Debug.Print("")
            Debug.Print("")
            Debug.Print("")
            Debug.Print("")
            Debug.Print("Connect Test Demo, Version 1.0")
            Debug.Print("")
            Debug.Print("Server Name: " & ServerName)
            Debug.Print("User id: " & UserId)
            Debug.Print("Password: " & Password)
            Debug.Print("")
            With DataConnection

                Debug.Print("Connection Status: " & .GetConnectionStatus)
                Debug.Print("")

                ' configure UVServer for the connection
                .AppName = "SpecialPricing Demo"
                .AppVersion = "1.0"

                .ServerName = ServerName
                .UserId = UserId
                .Password = Password

                Debug.Print("Connecting . . .")

                LoginSuccessful = .DoLogin

                Debug.Print("")

                If LoginSuccessful Then
                    Debug.Print("Connected")
                    ConnectToEclipse = True
                    _userIdInput = UserId
                Else
                    Debug.Print("Connection failed")
                    MessageBox.Show("Connection to eclipse failed. Please try again later")
                End If

                Debug.Print("")
                Debug.Print("Connection Status: " & .GetConnectionStatus)
                Debug.Print("")

            End With

        End Function

        Public Sub CreateEclipseObjects()

            'Debug.Print("Creating Eclipse Objects")
            'Debug.Print("")
            'DataConnection.ErrorDisplay = True
            'DataConnection.InternalErrorDisplay = True
            'DataConnection.HideErrorSubroutine = False 'change it to true when pushing to production

            'Dim itemOnFile As Boolean = False
            'UserInitials = New Initials(DataConnection)
            'With UserInitials
            '    .SetId(_userIdInput, itemOnFile)
            'End With

            'Product = New Product(DataConnection)

            'custAccount = New CustAccount(DataConnection)
            ''custAccount.SetMergeByProductId()
            'customer = New Customer(DataConnection)
            '_matrix = New Matrix(DataConnection)
            '_matrix.SetPriceDate()
            '_attHashMap = SetAttributeHashMap()
            '_attSortHashMap = SetAttrSortDescFlagHashMap()
            'Debug.Print("Eclipse Objects have been created")
            'Debug.Print("")


        End Sub

        Private Function GetDummyData() As List(Of SpecialPricingInfo)
            Dim spList As List(Of SpecialPricingInfo) = New List(Of SpecialPricingInfo)
            For Index = 1 To 20
                Dim sp As New SpecialPricingInfo
                sp.CMP = Index.ToString() * 1.2
                sp.RateCard = Index.ToString() * 2.5
                sp.DiscontinueDate = DateTime.Now.AddYears(2)
                sp.EffectiveDate = DateTime.Now.AddYears(-1)
                sp.RowID = Index.ToString()
                sp.StandardCost = 5.34 * Index.ToString()
                sp.Recommended = 5.5 * Index.ToString()
                sp.Salesperson = Index.ToString().ToString() + "_SP"
                sp.ButtonText = "Submit"
                sp.CurrentSpecial = 3.25 * Index.ToString()
                sp.MABIS = False
                sp.CustomerId = "12345"
                sp.ProductId = Index.ToString() * 123
                sp.CustomerSalesQTY = Index.ToString() * 16.6
                sp.CustomerSalesValue = Index.ToString()
                sp.Description = Index.ToString() + "_ this is a desc"
                sp.RateCard = 3.4 * Index.ToString()
                sp.PriceOrigin = "OLP"
                sp.HasSpecialPricing = True
                sp.HomeBranch = "0001"
                sp.LastPurchaseDate = DateTime.Now.AddDays(-Index.ToString())
                sp.Margin = 50
                sp.PriceLine = "ABCD"
                sp.PriceOrigin = "B"
                sp.RateCardName = "B"
                sp.RateCardPercentage = 6.66
                sp.Territory = "Oxaca"


                spList.Add(sp)




            Next
            Return spList

        End Function

        Public Function StartApplication() As Boolean
            StartApplication = False
            'CreateEclipseObjects()
            StartApplication = True
            LaunchMDIForm()

            'Dim test = New Form
            'test.Show()

        End Function


        Private Sub LaunchMDIForm()
            ' _spInfo = New List(Of SpecialPricingInfo)
            _parentForm = New ParentForm
            _parentForm.IsMdiContainer = True

            _queryForm = New QueryForm
            _queryForm.MdiParent = _parentForm

            _queryResultForm = New QueryResult
            _queryResultForm.MdiParent = _parentForm

            _reviewForm = New ReviewForm
            _reviewForm.MdiParent = _parentForm

            LaunchParentForm()
            ShowQueryResultForm()
            'ShowQueryForm()

            Application.DoEvents()
        End Sub
        Public Sub SetReviewReadUnRead()

            If _reviewForm.finalGridView.Rows.Count > 0 Then
                _parentForm.asterisLabel.Visible = True
                _parentForm.asterisLabel.Text = _reviewForm.finalGridView.Rows.Count()
            Else
                _parentForm.asterisLabel.Visible = False
            End If
        End Sub

        Public Sub LaunchParentForm()
            _userName = ""
            'With UserInitials
            '    .GetHomeBranch(_userHomeBranch)
            '    .GetName(_userName)
            'End With
            _userHomeBranch = "1003"
            _userName = "John Doe"
            _parentForm.UserNameLabel.Text = _userName
            _parentForm.BranchLabel.Text = _userHomeBranch
            _parentForm.LogOutButton.Visible = True
            '_parentForm.LogOutButton.Text = GetInitials(_userName)
            _parentForm.Show()
        End Sub



        Friend Sub ShowNewQueryForm()
            _queryForm._productSelected = False
            _queryForm.customerSearchTextbox.Text = ""
            _queryForm.KeywordRadiobtn.Checked = False
            _queryForm.ProductIDRadiobtn.Checked = False
            _queryForm.productSearchTextbox.Text = ""
            _queryForm.ProductSerchPanel.Visible = False

            ShowQueryForm()

        End Sub
        Public Sub ShowQueryForm()
            '_queryResultForm.Hide()
            '_reviewForm.Hide()
            '_parentForm.MainPanel.SendToBack()

            _queryForm.searchCustAccountBtn.Width = 91
            _queryForm.searchCustAccountBtn.BackColor = Color.FromArgb(0, 55, 102)
            _queryForm.searchCustAccountBtn.Text = "Search"
            _queryForm.searchCustAccountBtn.Enabled = True

            HighlightMenu("Search")
            _queryForm.MdiParent = _parentForm
            '_queryForm.Location = New Point(519, 4)
            '_queryForm.Size = New Size(503, 712)
            '_queryForm.BringToFront()
            '_queryForm.Visible = True


            _parentForm.LayoutMdi(MdiLayout.Cascade)
            _queryForm.Show()


        End Sub

        Public Sub HighlightMenu(item As String)
            Dim highlight As Color = Color.DarkBlue 'Color.FromArgb(1, 0, 55, 102)
            Dim dflt As Color = Color.LightGray 'Color.FromArgb(1, 203, 203, 203)
            If item = "Search" Then
                _parentForm.bar3.BackColor = highlight
                _parentForm.SearchButton.ForeColor = highlight

                _parentForm.bar1.BackColor = dflt
                _parentForm.CreateModifyButton.ForeColor = dflt

                _parentForm.bar2.BackColor = dflt
                _parentForm.ReviewButton.ForeColor = dflt
            End If
            If item = "CreateModify" Then
                _parentForm.bar1.BackColor = highlight
                _parentForm.CreateModifyButton.ForeColor = highlight

                _parentForm.bar3.BackColor = dflt
                _parentForm.SearchButton.ForeColor = dflt

                _parentForm.bar2.BackColor = dflt
                _parentForm.ReviewButton.ForeColor = dflt
            End If
            If item = "Review" Then
                _parentForm.bar2.BackColor = highlight
                _parentForm.ReviewButton.ForeColor = highlight

                _parentForm.bar1.BackColor = dflt
                _parentForm.CreateModifyButton.ForeColor = dflt

                _parentForm.bar3.BackColor = dflt
                _parentForm.SearchButton.ForeColor = dflt
            End If

        End Sub


        Public Sub ShowQueryResultForm()

            _reviewForm.Hide()
            _queryForm.Hide()

            '_queryForm.SendToBack()

            If _maxEntry = 10 Then
                _queryResultForm.Top10Chkbx.Checked = True
            End If
            If _maxEntry = 100 Then
                _queryResultForm.Top100ChkBx.Checked = True
            End If

            If _mabis Then
                _queryResultForm.MABISChkBx.Checked = True
            End If
            _queryResultForm.TwelveMonthChkBx.Checked = True

            HighlightMenu("CreateModify")

            _queryResultForm.CustomerLable.Text = _customerName
            _queryResultForm.BillToCustomerIDLable.Text = _customerSearchText
            _queryResultForm.ProductInfoPanel.Visible = False
            If Not _productName = "" Then
                _queryResultForm.productNameLable.Text = _productName
                _queryResultForm.ProductIdLabel.Text = _productId
                _queryResultForm.ProductInfoPanel.Visible = True
            End If

            ReLoadCustAccountGrid()

            _queryResultForm.Anchor = AnchorStyles.Top
            _queryResultForm.FormBorderStyle = FormBorderStyle.None
            _queryResultForm.Dock = DockStyle.Fill
            '_parentForm.MainPanel.Controls.Add(_queryResultForm)
            '_parentForm.MainPanel.Tag = _queryForm
            '_parentForm.MainPanel.Visible = True
            ' _queryResultForm.BringToFront()
            _queryResultForm.Show()

        End Sub

        Public Sub ReLoadCustAccountGrid()
            If _queryResultForm Is Nothing Then
                Return
            End If
            _queryResultForm.CustAccountGrid.DataBindings.Clear()
            _spInfo = GetDummyData()
            _queryResultForm.CustAccountGrid.DataSource = _spInfo
            If _spInfo IsNot Nothing Then
                _queryResultForm.GridRowCount.Text = _spInfo.Count.ToString() + " Items"

            End If
        End Sub


        'Private Sub SetCheckBoxLabel(custAccountGrid As DataGridView) Handles _queryResultForm.CustAccountGrid.

        'End Sub
        'Private Sub grid1_DataBindingComplete(ByVal sender As Object, ByVal e As DataGridViewBindingCompleteEventArgs) Handles _queryResultForm.CustAccountGrid.
        '    Dim ctCell As DataGridViewCheckAndTextCell = Nothing
        '    Dim row As DataGridViewRow
        '    For Each row In grid1.Rows
        '        If Not row Is Nothing Then
        '            ctCell = row.Cells("CheckAndText") As DataGridViewCheckAndTextCell    
        '      If Not ctCell Is Nothing Then
        '                ctCell.Enabled = True
        '                ctCell.Text = "Hello!"
        '                ctCell.Color = Color.Blue
        '            End If
        '        End If
        '    Next
        'End Sub

        Public Sub ShowQueryResultFormx()

            '_reviewForm.Hide()
            '_queryForm.Hide()

            ''_queryForm.SendToBack()

            'HighlightMenu("CreateModify")

            '_queryResultForm.CustomerLable.Text = _queryForm.TextBox2.Text
            '_queryResultForm.BillToCustomerIDLable.Text = _queryForm.TextBox1.Text
            '_queryResultForm.CustAccountGrid.DataSource = Program._spInfo
            '_queryResultForm.TopLevel = False
            '_queryResultForm.FormBorderStyle = FormBorderStyle.None
            '_queryResultForm.Dock = DockStyle.Fill
            '_parentForm.MainPanel.Controls.Add(_queryResultForm)
            '_parentForm.MainPanel.Tag = _queryForm
            '_parentForm.MainPanel.Visible = True
            '_queryResultForm.BringToFront()
            '_queryResultForm.Show()

        End Sub

        Public Sub ShowReviewForm()
            _queryResultForm.Hide()
            _queryForm.Hide()
            HighlightMenu("Review")
            _reviewForm.FormBorderStyle = FormBorderStyle.None
            _reviewForm.Dock = DockStyle.Fill
            '_reviewForm.TopLevel = False
            '_parentForm.MainPanel.Controls.Add(_reviewForm)
            '_parentForm.MainPanel.Tag = _queryForm
            '_parentForm.MainPanel.Visible = True
            _reviewForm.GridRowCount.Text = _reviewForm.finalGridView.Rows.Count.ToString() + " Items"
            _reviewForm.BringToFront()
            _reviewForm.Show()

        End Sub





        Public Function SearchProduct(searchText As String, idSearch As Boolean) As List(Of ProductInfo)

            Dim ProductName As String = ""
            Dim ProductList As New Dynamic
            Dim ProductNameList As New Dynamic
            Dim ProductCount As Integer
            Dim ProductLoop As Integer
            Dim specialIdList As New Dynamic
            Dim specialValueList As New Dynamic
            Dim singleLineDisplay As New Dynamic
            'Dim specialcount As Integer
            'Dim LatencyTime As Single

            'ProductId = "1711593"
            'searchText = "RED WIRE"
            Dim lstProductInfo As List(Of ProductInfo) = New List(Of ProductInfo)
            If idSearch Then
                searchText = "." + searchText
            End If

            With Product
                .SearchByName(ProductList, ProductNameList, ProductCount, searchText,,, True)
                For ProductLoop = 1 To ProductCount

                    Dim prodInfo = New ProductInfo()
                    prodInfo.Id = ProductList.GetAttr(ProductLoop)
                    prodInfo.Name = ProductNameList.GetAttr(ProductLoop)

                    lstProductInfo.Add(prodInfo)
                    '  HomeForm.SearchListBox.Items.Add(prodInfo)

                Next
            End With


            If _billToCustomerID = "" Then
                Return lstProductInfo
            End If


            Dim billToCustProducts = GetCustAccountProducts(searchText, _billToCustomerID)
            For Each prod In lstProductInfo
                If billToCustProducts.Contains(prod) Then
                    prod.Name = "~" + prod.Name
                End If
            Next



            Application.DoEvents()
            SearchProduct = lstProductInfo

        End Function




        Public Function SearchCustomer(searchText As String) As List(Of CustomerInfo)
            SearchCustomer = New List(Of CustomerInfo)
            Dim customerList As New Dynamic
            Dim CustomerNameList As New Dynamic
            Dim singleLineDisplay As New Dynamic
            Dim count As Integer


            With customer
                .SearchByBillTo(customerList, CustomerNameList, count, searchText,,, True)
                For index = 1 To count
                    Dim cInfo As New CustomerInfo
                    cInfo.Name = CustomerNameList.GetAttr(index)
                    cInfo.id = customerList.GetAttr(index)
                    SearchCustomer.Add(cInfo)
                Next
            End With
        End Function

        Friend Function GetCustAccountProducts(productSearchText As String, customerSearchText As String) As List(Of ProductInfo)


            Dim lstProductInfo As New List(Of ProductInfo)


            Dim ProductList As New Dynamic
            Dim ProductNameList As New Dynamic
            Dim productQuantityList As New Dynamic
            Dim productOccuranceList As New Dynamic
            Dim productPriceList As New Dynamic
            Dim productCostList As New Dynamic
            Dim ProductCount As Integer



            With custAccount
                '.AddExcludePriceLine()
                .SetCustomer(customerSearchText) ' customer number from the text box
                .GetProductLists(ProductList, ProductNameList, productQuantityList, productOccuranceList, productPriceList, productCostList, ProductCount)
                ''.setdateRange()--12-6-3
                '.SetListType("customer.history")
                ''.SetBranch()
                '.FilterOnlyMustStock(onlyMABIS)
                '.SetProductSortBy("price", "decending")
                '.BuildOrderList()
                '.BuildProductList()
                '.BuildSpecialPricingLists(_maxEntry)
                '.GetSpecialPricingLists(specialIdList, specialValueList, specialcount)
                '.SortSpecialPricingList("6")

                '.SetProductSortBy("price") ' or  quantity?? for top 10 and 100 based on price


                For i = 1 To ProductCount
                    Dim prodInfo = New ProductInfo()
                    prodInfo.Id = ProductList.GetAttr(i)
                    prodInfo.Name = ProductNameList.GetAttr(i)

                    lstProductInfo.Add(prodInfo)
                Next
            End With
            ' SearchCustAccount = spInfoList
            Return lstProductInfo
        End Function
        'Friend Function SearchCustAccountx(productSearchText As String, customerSearchText As String)

        'customer                  | get from search box
        'Product Name              | <1,n> product description 
        'Product number            | ID
        'Current Special           | <17,n> special price from pricing matrix
        'Margin % --WF             | <48, n>  special margin percent, iconverted            '                              md1                                
        'Standard Cost             | <35, n>  standard cost, iconverted md2       *
        'Next Price --WF           | <25, n>  normal pricing from pricing matrix
        'Price Origin --WF         | <19, n>  special price cell description
        'Action --WF               | N/A
        'Effective Date --WF       | <23, n>  effective date, iconverted          *
        'Discontinye Date                 <24, n>  expiration date, iconverted
        'Typical Price             |  TBD - need more work on the backend  <4,n> total extended price, from history ??

        'Rate Card                 | <25, n>  normal pricing from pricing matrix
        'Recommended               | TBD - half way b/w current and typical - need sales history data
        'Custom Special --WF       | user input
        'Salesperson               | customer.OutsideSalesPerson
        'Priceline                 | <6,n>  price line 
        'CMP                       | TBD - backend work
        'Rate Card %               | need to clarify
        'Rate Card Name            | Price class - customer price class - backend work needed
        'Territory                 | Backend work needed
        'Last Purchase Date -- WF  | <36, n>  product last purchase date, iconverted
        'Customer sales QTY        | <2, n>  total quantity -12-6-3 months
        'customer Sales Value      | <4, n>  total extended price, from history




        'need to return Customer id, product id, product desc, unit, CMP, CustProfitopp, trade rate, trade rate price, current special, gp%, price origin
        'Dim spInfoList As New List(Of SpecialPricingInfo)


        'Dim ProductList As New Dynamic
        'Dim ProductNameList As New Dynamic
        'Dim productQuantityList As New Dynamic
        'Dim productOccuranceList As New Dynamic
        'Dim productPriceList As New Dynamic
        'Dim productCostList As New Dynamic
        ''Dim ProductCount As Integer
        'Dim specialIdList As New Dynamic
        'Dim specialValueList As New Dynamic
        'Dim specialcount As Integer
        'Dim customerOnFile As Boolean = False
        'Dim homeTerritory As String = ""
        'Dim outsideSales As String = ""
        'Dim homeBranch As String = ""

        '_maxEntry = maxEntryCount

        'With customer
        '    .SetId(customerSearchText, customerOnFile)
        '    .GetOutsideSales(outsideSales)
        '    .GetHomeBranch(homeBranch)
        '    .GetHomeTerritory(homeTerritory)

        'End With


        'With custAccount

        '    .SetCustomer(customerSearchText) ' customer number from the text box
        '    '.GetProductLists(ProductList, ProductNameList, productQuantityList, productOccuranceList, productPriceList, productCostList, ProductCount)
        '    '.setdateRange()--12-6-3
        '    .SetListType("customer.history")
        '    '.SetBranch()
        '    .FilterOnlyMustStock(onlyMABIS)
        '    .SetProductSortBy("price", "decending")
        '    .BuildOrderList()
        '    .BuildProductList()
        '    .BuildSpecialPricingLists(_maxEntry)
        '    .GetSpecialPricingLists(specialIdList, specialValueList, specialcount)
        '    .SortSpecialPricingList("6")

        '    '.SetProductSortBy("price") ' or  quantity?? for top 10 and 100 based on price


        '    For ptr = 1 To specialcount

        '        If specialIdList.GetAttr(ptr) = "" Then
        '            Continue For
        '        End If
        '        If productSearchText IsNot "" And specialIdList.GetAttr(ptr) IsNot productSearchText Then
        '            Continue For
        '        End If

        '        Dim hasSpecialPricing As Boolean = True

        '        If specialValueList.GetVal(7, ptr) IsNot "" Then
        '            hasSpecialPricing = specialValueList.GetVal(7, ptr)
        '        End If




        '        If includeNonSpecial = False And hasSpecialPricing = False Then
        '            Continue For
        '        End If

        '        Dim spInfo = New SpecialPricingInfo()
        '        spInfo.RowID = ptr
        '        spInfo.HasSpecialPricing = hasSpecialPricing
        '        spInfo.CustomerId = customerSearchText
        '        spInfo.ProductId = specialIdList.GetAttr(ptr)
        '        spInfo.Description = specialValueList.GetVal(1, ptr)
        '        spInfo.CurrentSpecial = Oconv(specialValueList.GetVal(17, ptr), "md2")
        '        spInfo.Margin = Oconv(specialValueList.GetVal(48, ptr), "md1")
        '        spInfo.StandardCost = Oconv(specialValueList.GetVal(35, ptr), "md2")
        '        spInfo.NextPrice = Oconv(specialValueList.GetVal(25, ptr), "md2")
        '        spInfo.PriceOrigin = specialValueList.GetVal(19, ptr)
        '        spInfo.EffectiveDate = Oconv(specialValueList.GetVal(23, ptr), "d2/")
        '        spInfo.DiscontinueDate = Oconv(specialValueList.GetVal(24, ptr), "d2/")
        '        spInfo.TypicalPrice = Oconv(specialValueList.GetVal(4, ptr), "md2") 'Not final - need more discussions
        '        spInfo.RateCard = Oconv(specialValueList.GetVal(25, ptr), "md2")
        '        spInfo.Recommended = Oconv(specialValueList.GetVal(25, ptr), "md2") ' not final need sales history data
        '        spInfo.TotalPrice = Oconv(specialValueList.GetVal(4, ptr), "md2")
        '        spInfo.TotalCost = Oconv(specialValueList.GetVal(5, ptr), "md2")
        '        spInfo.Salesperson = outsideSales
        '        spInfo.PriceLine = specialValueList.GetVal(6, ptr)
        '        spInfo.CMP = Oconv(specialValueList.GetVal(25, ptr), "md2")
        '        spInfo.RateCardPercentage = 10.25
        '        spInfo.RateCardName = "PriceClass" 'backend work needed
        '        spInfo.Territory = homeTerritory ' backend work needed
        '        spInfo.LastPurchaseDate = Oconv(specialValueList.GetVal(36, ptr), "d2/")
        '        spInfo.CustomerSalesQTY = specialValueList.GetVal(2, ptr) 'need clarification
        '        spInfo.CustomerSalesValue = specialValueList.GetVal(2, ptr) 'need clarification
        '        spInfo.SpecialPriceMatrixId = specialValueList.GetVal(18, ptr)
        '        spInfo.HomeBranch = homeBranch

        '        'spInfo.ReplacementCost = Oconv(specialValueList.GetVal(33, ptr), "md2")
        '        'spInfo.CustomerProfitOpp = spInfo.CMP - spInfo.ReplacementCost
        '        'spInfo.TradeRatePercentage = (spInfo.CMP / spInfo.CustomerProfitOpp) * 100


        '        Try

        '            Dim specialPricingReturned As Boolean = specialValueList.GetVal(8, ptr)
        '            If includeNonSpecial Then
        '                If hasSpecialPricing = True And specialPricingReturned = True Then
        '                    spInfo.TradeRatePrice = Oconv(specialValueList.GetVal(17, ptr), "md2")
        '                Else
        '                    spInfo.TradeRatePrice = Oconv(specialValueList.GetVal(25, ptr), "md2")
        '                End If
        '            End If
        '            ''add static info
        '            spInfoList.Add(spInfo)
        '            ' HomeForm.SearchListBox.Items.Add(spInfo)
        '        Catch ex As Exception
        '            Continue For
        '        End Try
        '    Next
        'End With
        '' SearchCustAccount = spInfoList
        '_spInfo = spInfoList
        'End Function
        Friend Sub ReloadQueryResultGrid()

            Dim spInfoList As New List(Of SpecialPricingInfo)


            Dim ProductList As New Dynamic
            Dim ProductNameList As New Dynamic
            Dim productQuantityList As New Dynamic
            Dim productOccuranceList As New Dynamic
            Dim productPriceList As New Dynamic
            Dim productCostList As New Dynamic
            'Dim ProductCount As Integer
            Dim specialIdList As New Dynamic
            Dim specialValueList As New Dynamic
            Dim specialcount As Integer
            Dim customerOnFile As Boolean = False
            Dim homeTerritory As String = ""
            Dim outsideSales As String = ""
            Dim homeBranch As String = ""
            Dim customerSearchText As Object = ""

            With customer
                ' .SetId(customerSearchText, customerOnFile)
                .GetOutsideSales(outsideSales)
                .GetHomeBranch(homeBranch)
                .GetHomeTerritory(homeTerritory)
                .GetBillTo(customerSearchText)

            End With


            With custAccount
                .BuildSpecialPricingLists(_maxEntry)
                .GetSpecialPricingLists(specialIdList, specialValueList, specialcount)

                For ptr = 1 To specialcount


                    Dim hasSpecialPricing As Boolean = True

                    If specialValueList.GetVal(7, ptr) = "" Then
                        hasSpecialPricing = False
                    Else
                        hasSpecialPricing = specialValueList.GetVal(7, ptr)
                    End If

                    Dim spInfo = New SpecialPricingInfo()
                    spInfo.RowID = ptr
                    spInfo.HasSpecialPricing = hasSpecialPricing
                    spInfo.CustomerId = customerSearchText
                    spInfo.ProductId = specialIdList.GetAttr(ptr)
                    spInfo.Description = specialValueList.GetVal(1, ptr)
                    spInfo.CurrentSpecial = Oconv(specialValueList.GetVal(17, ptr), "md2")
                    spInfo.Margin = Oconv(specialValueList.GetVal(48, ptr) * 0.01, "md1")
                    spInfo.StandardCost = Oconv(specialValueList.GetVal(35, ptr), "md2")
                    spInfo.NextPrice = Oconv(specialValueList.GetVal(25, ptr), "md2")
                    spInfo.PriceOrigin = specialValueList.GetVal(19, ptr)
                    spInfo.EffectiveDate = Oconv(specialValueList.GetVal(23, ptr), "d2/")
                    spInfo.DiscontinueDate = Oconv(specialValueList.GetVal(24, ptr), "d2/")
                    spInfo.TypicalPrice = Oconv(specialValueList.GetVal(4, ptr), "md2") 'Not final - need more discussions
                    spInfo.Recommended = Oconv(specialValueList.GetVal(25, ptr), "md2") ' not final need sales history data
                    spInfo.TotalPrice = Oconv(specialValueList.GetVal(4, ptr), "md2")
                    spInfo.TotalCost = Oconv(specialValueList.GetVal(5, ptr), "md2")
                    spInfo.Salesperson = outsideSales
                    spInfo.PriceLine = specialValueList.GetVal(6, ptr)
                    spInfo.CMP = Oconv(specialValueList.GetVal(37, ptr), "md2")
                    spInfo.RateCard = Oconv(specialValueList.GetVal(25, ptr), "md2")
                    spInfo.RateCardPercentage = 10.25
                    spInfo.RateCardName = specialValueList.GetVal(19, ptr)
                    spInfo.Territory = homeTerritory ' backend work needed
                    spInfo.LastPurchaseDate = Oconv(specialValueList.GetVal(36, ptr), "d2/")
                    spInfo.CustomerSalesQTY = specialValueList.GetVal(2, ptr) 'need clarification
                    spInfo.CustomerSalesValue = specialValueList.GetVal(2, ptr) 'need clarification
                    spInfo.SpecialPriceMatrixId = specialValueList.GetVal(18, ptr)
                    spInfo.HomeBranch = homeBranch

                    Try

                        Dim specialPricingReturned As Boolean = specialValueList.GetVal(8, ptr)
                        'If includeNonSpecial Then
                        If hasSpecialPricing = True And specialPricingReturned = True Then
                            spInfo.TradeRatePrice = Oconv(specialValueList.GetVal(17, ptr), "md2")
                        Else
                            spInfo.TradeRatePrice = Oconv(specialValueList.GetVal(25, ptr), "md2")
                        End If
                        'End If
                        ''add static info
                        spInfoList.Add(spInfo)
                        ' HomeForm.SearchListBox.Items.Add(spInfo)
                    Catch ex As Exception
                        Continue For
                    End Try
                Next
            End With
            ' SearchCustAccount = spInfoList
            _spInfo = spInfoList

        End Sub
        Friend Sub UpdatePricing()
            Dim Successful As Boolean
            Dim CreatedNewCell As Boolean
            Dim NewMatrixId As String = ""
            Dim NewPrice As Double
            Dim ErrorMessage As String
            Dim EffectiveDate As String
            Dim DiscontinueDate As String
            Dim expireSuccessFul As Boolean
            For Each row As DataGridViewRow In _reviewForm.finalGridView.Rows
                Dim rowId = row.Cells.Item("RowID").Value
                Dim action = row.Cells.Item("Action").Value

                Dim custInf As New SpecialPricingInfo
                custInf = _spInfo.FirstOrDefault(Function(x) _
                                                            (x.RowID = rowId))

                Debug.Print($"updating SP for product #{custInf.ProductId}")
                Debug.Print("")

                If row.Cells.Item("UpdatedPrice").Value IsNot "" Then
                    NewPrice = row.Cells.Item("UpdatedPrice").Value
                End If
                EffectiveDate = Iconv(row.Cells.Item("EffectiveDate").Value, "D/")

                If custInf.HasSpecialPricing Then
                    Dim found As Boolean = False
                    With _matrix
                        Debug.Print($"Expiring existing SP for product #{custInf.ProductId}")
                        .SetId(custInf.SpecialPriceMatrixId, found)
                        If Not found Then
                            MessageBox.Show("Matrix cell not found", "Update Failed!")
                            Debug.Print($"Expiring SP for product #{custInf.ProductId} Failed, reason: cell not found")
                            Continue For
                        End If
                        If found Then

                            DiscontinueDate = Iconv(custInf.DiscontinueDate, "D")
                            Debug.Print($"Expiring SP for product #{custInf.ProductId} DiscontinueDate {custInf.DiscontinueDate}")
                            Debug.Print($"Expiring SP for product #{custInf.ProductId} Iconverted discontinue date {DiscontinueDate}")
                            .SetExpirationDate(DiscontinueDate)
                            .ExpireCell(expireSuccessFul, "")
                            If Not expireSuccessFul Then
                                MessageBox.Show("Unable to expire existing matrix cell", "Update Failed!")
                                Debug.Print($"Expiring SP for product #{custInf.ProductId} Iconverted discontinue date {DiscontinueDate}")
                                Continue For
                            End If
                        End If
                    End With
                    Debug.Print($"Expiring SP for product #{custInf.ProductId} successful")
                End If

                If action = "Set special future date" Or action = "" Then

                    With _matrix
                        Debug.Print($"Adding SP for product #{custInf.ProductId} new price {NewPrice} effective {EffectiveDate}")
                        .SetIdFields("*", custInf.CustomerId, custInf.ProductId)
                        .CreateFixedPriceCell(Successful, CreatedNewCell, NewMatrixId, Iconv(NewPrice, "md2"), EffectiveDate)
                        ErrorMessage = .ErrorMessage
                        If Not Successful Then
                            Debug.Print($"Adding SP for product #{custInf.ProductId} Failed, reason: {ErrorMessage}")
                            MessageBox.Show(ErrorMessage)
                            Continue For
                        End If
                        Debug.Print($"Adding SP for product #{custInf.ProductId} successful")
                    End With
                End If

            Next
            'Return True
        End Sub





        Public Sub WrapUp()
            ' **********************************************************************
            ' * clean up and end.  always call this subroutine when ending the     *
            ' * app session:                                                       *
            ' *                                                                    *
            ' * 1. objects on the uniVerse / eclipse side are destroyed            *
            ' *                                                                    *
            ' * 2. this user / app is unregistered from application tracking on    *
            ' *    the eclipse side                                                *
            ' *                                                                    *
            ' * 3. the uniVerse / eclipse data service for this user / app         *
            ' *    terminates                                                      *
            ' **********************************************************************
            _queryForm.Dispose()
            _queryResultForm.Dispose()
            _reviewForm.Dispose()
            _parentForm.Dispose()

            If DataConnection IsNot Nothing Then

                Debug.Print("Closing connection . . .")
                Debug.Print("")

                DataConnection.Close()

                Debug.Print("Closed")
                Debug.Print("")

            End If

            End

        End Sub

        Friend Function SearchCustomerByID(searchText As String) As String
            Dim SearchCustomer = New List(Of CustomerInfo)
            Dim customerList As New Dynamic
            Dim CustomerNameList As New Dynamic
            Dim singleLineDisplay As New Dynamic
            Dim count As Integer
            With customer
                .SearchByBillTo(customerList, CustomerNameList, count, "." + searchText,,, True)
                If count = 0 Then
                    MessageBox.Show("Bill to customer Id not found", "Not Found")
                    Return ""
                End If
                For index = 1 To count
                    Dim cInfo As New CustomerInfo
                    cInfo.Name = CustomerNameList.GetAttr(index)
                    cInfo.id = customerList.GetAttr(index)
                    SearchCustomer.Add(cInfo)
                Next
            End With

            _billToCustomerID = SearchCustomer.FirstOrDefault().id
            _customerName = SearchCustomer.FirstOrDefault().Name
            SearchCustomerByID = SearchCustomer.FirstOrDefault().Name


        End Function


        Public Sub SetCustomer(customerSearchText As String)

            Dim customerOnFile As Boolean = False
            With customer
                .SetId(customerSearchText, customerOnFile)
                .GetOutsideSales(_outsideSales)
                .GetHomeBranch(_homeBranch)
                .GetHomeTerritory(_homeTerritory)
            End With

        End Sub

        Public Sub SetCustAccount(customerSearchText As String)

            With custAccount
                .SetCustomer(customerSearchText)
            End With

        End Sub
        Public Sub SetCustAccountListType()

            With custAccount
                .SetListType("customer.history")
            End With

        End Sub
        Public Sub SetCustAccountListMABISFilter(OnlyMABIS As Boolean)
            _mabis = OnlyMABIS
            With custAccount
                .FilterOnlyMustStock(OnlyMABIS)
            End With

        End Sub
        Public Sub SetDateRangeFilter(startDate As Object)

            'Dim dt As Object = Iconv(startDate, "D")
            'With custAccount
            '    .SetStartDate(dt)
            '    ' .SetDateRange(dt)
            'End With

        End Sub

        Friend Function SortAndRebuild(columnName As String) As Boolean

            If columnName = "ProductName" Then
                _justify = "L"
            Else
                _justify = "R"
            End If

            GetAttrIndex(columnName)
            GetAttrDescFlag(columnName)
            BuildCustAccountData()
            Dim sortDesc As Boolean = GetAttrDescFlag(columnName)
            SetAttrDescFlag(columnName)
            Return sortDesc
        End Function
        Friend Function GetAttrIndex(columnName As String) As String

            Dim attrIndex As String = Nothing
            If _attHashMap.TryGetValue(columnName, attrIndex) Then
                GetAttrIndex = attrIndex
                _sortAttr = attrIndex
            Else
                GetAttrIndex = "0"
                _sortAttr = "0"
            End If

        End Function
        Friend Function GetAttrDescFlag(columnName As String) As Boolean

            Dim flag As Boolean = Nothing
            If _attSortHashMap.TryGetValue(columnName, flag) Then
                GetAttrDescFlag = flag
                _sortDesc = flag
            Else
                flag = False
                _sortDesc = False
            End If
            Return flag
        End Function
        Friend Sub SetAttrDescFlag(columnName As String)

            Dim flag As Boolean = Nothing
            If _attSortHashMap.TryGetValue(columnName, flag) Then
                _attSortHashMap(columnName) = Not flag
            Else
                _attSortHashMap(columnName) = False

            End If


        End Sub



        Public Sub BuildCustAccountData()

            _spInfo = New List(Of SpecialPricingInfo)

            If _sortAttr = "" Then
                _sortAttr = "4"
            End If

            Dim specialIdList As New Dynamic
            Dim specialValueList As New Dynamic
            Dim specialcount As Integer
            Dim prodCount As Integer
            Dim orderCount As Integer



            If _includeNonSpecial = False Then

                _spInfo = _spInfo.Where(Function(x) _
                                                            (x.HasSpecialPricing = True)).ToList()
            End If

        End Sub

        Private Sub BuildProductSpecificCustAccountDate() ' As List(Of SpecialPricingInfo)
            _spInfo = New List(Of SpecialPricingInfo)
            Dim specialIdList As New Dynamic
            Dim specialValueList As New Dynamic
            Dim specialcount As Integer

            Dim homeTerritory As String = ""
            Dim outsideSales As String = ""
            Dim homeBranch As String = ""



            With custAccount
                .BuildOrderList()
                .BuildProductList()
                .BuildSpecialPricingLists()
                '.SortSpecialPricingList(_sortAttr, _sortDesc, _justify)
                .GetSpecialPricingLists(specialIdList, specialValueList, specialcount)

                For ptr = 1 To specialcount

                    If specialIdList.GetAttr(ptr) = "" Then
                        Continue For
                    End If

                    Dim hasSpecialPricing As Boolean = True

                    If specialValueList.GetVal(7, ptr) IsNot "" Then
                        hasSpecialPricing = specialValueList.GetVal(7, ptr)
                    End If

                    'If _includeNonSpecial = False And hasSpecialPricing = False Then
                    '    Continue For
                    'End If

                    If Not specialIdList.GetAttr(ptr) = _productSearchText Then
                        Continue For
                    End If
                    Dim spInfo = New SpecialPricingInfo()
                    spInfo.RowID = ptr
                    spInfo.HasSpecialPricing = hasSpecialPricing
                    spInfo.CustomerId = _customerSearchText
                    spInfo.ProductId = specialIdList.GetAttr(ptr)
                    spInfo.Description = specialValueList.GetVal(1, ptr)

                    spInfo.CurrentSpecial = GetCurrentSpecialValue(Oconv(specialValueList.GetVal(17, ptr), "md2"))


                    spInfo.Margin = Oconv(specialValueList.GetVal(48, ptr) * 0.01, "md1")
                    spInfo.StandardCost = Oconv(specialValueList.GetVal(35, ptr), "md2")
                    spInfo.NextPrice = Oconv(specialValueList.GetVal(25, ptr), "md2")
                    spInfo.PriceOrigin = specialValueList.GetVal(19, ptr)
                    spInfo.EffectiveDate = Oconv(specialValueList.GetVal(23, ptr), "d2/")
                    spInfo.DiscontinueDate = Oconv(specialValueList.GetVal(24, ptr), "d4/")
                    spInfo.TypicalPrice = Oconv(specialValueList.GetVal(4, ptr), "md2") 'Not final - need more discussions
                    spInfo.Recommended = Oconv(specialValueList.GetVal(25, ptr), "md2") ' not final need sales history data
                    spInfo.TotalPrice = Oconv(specialValueList.GetVal(4, ptr), "md2")
                    spInfo.TotalCost = Oconv(specialValueList.GetVal(5, ptr), "md2")
                    spInfo.Salesperson = _outsideSales
                    spInfo.PriceLine = specialValueList.GetVal(6, ptr)
                    spInfo.CMP = Oconv(specialValueList.GetVal(37, ptr), "md2")
                    spInfo.RateCard = Oconv(specialValueList.GetVal(25, ptr), "md2")
                    spInfo.RateCardPercentage = 10.25
                    spInfo.RateCardName = specialValueList.GetVal(27, ptr) 'backend work needed
                    spInfo.Territory = _homeTerritory ' backend work needed
                    spInfo.LastPurchaseDate = Oconv(specialValueList.GetVal(36, ptr), "d2/")
                    spInfo.CustomerSalesQTY = specialValueList.GetVal(2, ptr) 'need clarification
                    spInfo.CustomerSalesValue = specialValueList.GetVal(2, ptr) 'need clarification
                    spInfo.SpecialPriceMatrixId = specialValueList.GetVal(18, ptr)
                    spInfo.HomeBranch = _homeBranch
                    spInfo.MABIS = specialValueList.GetVal(43, ptr)

                    Try
                        Dim specialPricingReturned As Boolean = specialValueList.GetVal(8, ptr)
                        If _includeNonSpecial Then
                            If hasSpecialPricing = True And specialPricingReturned = True Then
                                spInfo.TradeRatePrice = Oconv(specialValueList.GetVal(17, ptr), "md2")
                            Else
                                spInfo.TradeRatePrice = Oconv(specialValueList.GetVal(25, ptr), "md2")
                            End If
                        End If

                        _spInfo.Add(spInfo)

                    Catch ex As Exception
                        Continue For
                    End Try
                Next
            End With

        End Sub

        Private Function GetCurrentSpecialValue(val As Object) As Object


            If IsNumeric(val) AndAlso val > 0 Then
                Return val


            End If
            Return "None"


        End Function

        Friend Sub SearchCustAccount(productSearchText As String, customerSearchText As String, maxEntryCount As Integer, includeNonSpecial As Boolean, onlyMABIS As Boolean, columnName As String)

            _customerSearchText = customerSearchText
            SetCustomer(customerSearchText)
            SetCustAccount(customerSearchText)
            SetCustAccountListType()

            _productSearchText = productSearchText

            If _productSearchText IsNot "" Then
                BuildProductSpecificCustAccountDate()
                Return
            End If

            _maxEntry = maxEntryCount
            _includeNonSpecial = includeNonSpecial


            If columnName = "ProductName" Then
                _justify = "L"
            Else
                _justify = "R"
            End If

            GetAttrIndex(columnName)
            GetAttrDescFlag(columnName)
            SetCustAccountListMABISFilter(onlyMABIS)
            BuildCustAccountData()
            SetAttrDescFlag(columnName)

        End Sub

        Public Function SetAttributeHashMap() As Dictionary(Of String, String)

            Dim dictionary As New Dictionary(Of String, String)
            dictionary.Add("ProductId", "0")
            dictionary.Add("Description", "1")
            dictionary.Add("CurrentSpecial", "17")
            dictionary.Add("Margin", "48")
            dictionary.Add("StandardCost", "35")
            dictionary.Add("NextPrice", "25")
            dictionary.Add("PriceOrigin", "19")
            dictionary.Add("EffectiveDate", "23")
            dictionary.Add("DiscontinueDate", "24")
            dictionary.Add("TypicalPrice", "4")
            dictionary.Add("RateCard", "25")
            dictionary.Add("Recommended", "25")
            dictionary.Add("TotalPrice", "4")
            dictionary.Add("TotalCost", "5")
            dictionary.Add("PriceLine", "6")
            dictionary.Add("CMP", "25")
            dictionary.Add("SalesValue", "4") ' *<4, n>  total extended price, from history  *
            dictionary.Add("Transaction", "3") '  <3, n>  occurence count



            SetAttributeHashMap = dictionary
        End Function

        Public Function SetAttrSortDescFlagHashMap() As Dictionary(Of String, Boolean)

            Dim dictionary As New Dictionary(Of String, Boolean)
            dictionary.Add("ProductId", False)
            dictionary.Add("Description", False)
            dictionary.Add("CurrentSpecial", False)
            dictionary.Add("Margin", False)
            dictionary.Add("StandardCost", False)
            dictionary.Add("NextPrice", False)
            dictionary.Add("PriceOrigin", False)
            dictionary.Add("EffectiveDate", False)
            dictionary.Add("DiscontinueDate", False)
            dictionary.Add("TypicalPrice", False)
            dictionary.Add("RateCard", False)
            dictionary.Add("Recommended", False)
            dictionary.Add("TotalPrice", False)
            dictionary.Add("TotalCost", False)
            dictionary.Add("PriceLine", False)
            dictionary.Add("CMP", False)
            SetAttrSortDescFlagHashMap = dictionary

        End Function

        Friend Sub SelectCreateReview()
            _parentForm.bar2.Visible = False
            _parentForm.bar1.Visible = True
        End Sub

        Friend Sub AddRowToFinalGrid(dataRow As DataGridViewCellCollection, CustomerLable As String, custInf As SpecialPricingInfo, rowId As Integer, newPrice As Object)
            Dim index = _reviewForm.finalGridView.Rows.Add()
            Dim newRow = _reviewForm.finalGridView.Rows(index)
            'Dim newRow = SellingDGView.Rows(SellingDGView.Rows.Add())

            newRow.Cells(0).Value = dataRow.Item(1).Value
            newRow.Cells(1).Value = CustomerLable
            newRow.Cells(2).Value = dataRow.Item(2).Value
            newRow.Cells(3).Value = dataRow.Item(3).Value
            newRow.Cells(4).Value = custInf.HomeBranch
            newRow.Cells(5).Value = custInf.Territory
            newRow.Cells(6).Value = custInf.StandardCost
            newRow.Cells(7).Value = custInf.CurrentSpecial
            newRow.Cells(8).Value = newPrice
            newRow.Cells(9).Value = DateTime.Parse(dataRow.Item(10).Value).ToString("MM/dd/yyyy")
            If dataRow.Item(9).Value IsNot "Select an action.." Then
                newRow.Cells(10).Value = dataRow.Item(9).Value
            End If
            newRow.Cells(11).Value = "Remove"
            ' newRow.Cells(10).Value.Style.ForeColor = Color.Red
            newRow.Cells(12).Value = rowId

        End Sub

        Friend Sub RemoveRowFromFinalGrid(rowId As Integer)
            For Each item As DataGridViewRow In _reviewForm.finalGridView.Rows
                If item.Cells.Item("RowID").Value = rowId Then
                    _reviewForm.finalGridView.Rows.RemoveAt(item.Index)
                End If
            Next
        End Sub
        Friend Sub UnsubmitRowFromCustAccountGrid(rowId As Integer)
            For Each item As DataGridViewRow In _queryResultForm.CustAccountGrid.Rows
                If item.Cells.Item("RowID").Value = rowId Then
                    item.Cells.Item("AddItem").Value = "Submit"
                    item.Cells.Item("AddItem").Style.ForeColor = Color.FromName("ControlText")
                End If
            Next
        End Sub

        Friend Sub SetCustAccountListAMAAFilter(IsAmaa As Boolean)
            Return
        End Sub

        Friend Sub SetCloseToTradeFilter()
            'Close to Trade Rate (<10% gap) – In pricing model we have a Trade Rate = Rate Card as well as % change to recommended price

        End Sub

        Friend Sub SetNoRecentSalesFilter()
            'No recent sales (>6 months) – items that didn't sell in the past 6 months
            Dim startDate As Object = DateTime.Now.AddMonths(-12).ToString("MM/dd/yyyy")
            Program.SetDateRangeFilter(startDate)
            Program.BuildCustAccountData()
            _spInfo = _spInfo.Where(Function(x) _
                                                            (x.CustomerSalesQTY < 1)).ToList()
            ReLoadCustAccountGrid()
        End Sub

        Friend Sub SetLowGPFilter()
            'Low GP (<15% PGP) – Low GP = Low Gross Profit under 15%
            _spInfo = _spInfo.Where(Function(x) _
                                                            (x.Margin < 15)).ToList()
            ReLoadCustAccountGrid()
        End Sub

        Friend Sub SetLowSalesFilter()
            'Low Sales (<5 in the last 6 months) – low sales defined as less that 5 units in the past 6 months
            Dim startDate As Object = DateTime.Now.AddMonths(-12).ToString("MM/dd/yyyy")
            Program.SetDateRangeFilter(startDate)
            Program.BuildCustAccountData()
            _spInfo = _spInfo.Where(Function(x) _
                                                            (x.CustomerSalesQTY < 5)).ToList()
            ReLoadCustAccountGrid()
        End Sub

        Friend Sub ClearFilter()
            Program.SetCustAccountListMABISFilter(False)
            Program.SetCustAccountListAMAAFilter(False)
            _maxEntry = 0
            'Program.BuildCustAccountData() ' this rebuilds the grid
            'Program.ReLoadCustAccountGrid()

        End Sub
    End Module

End Namespace


