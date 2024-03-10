Imports SpecialPricing.UVObjects

Public Class QueryResult
    'Public _custInfo As List(Of SpecialPricingInfo)
    Private yax As Integer = 0

    Private Sub QueryButton_Click(sender As Object, e As EventArgs) Handles QueryButton.Click
        CollapseDetailView()
        Program.ShowQueryForm()
    End Sub

    Private Sub CustAccountGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustAccountGrid.CellClick

        If e.RowIndex < 0 Then
            Return
        End If
        Dim columnIndex = e.ColumnIndex

        Dim rowId As Integer = 0
        rowId = CustAccountGrid.Rows.Item(e.RowIndex).Cells.Item("RowID").Value

        Dim custInf As New SpecialPricingInfo
        If rowId > 0 Then
            custInf = Program._spInfo.FirstOrDefault(Function(x) _
                                                            (x.RowID = rowId))
        End If



        If columnIndex = 0 Then
            Dim row = CustAccountGrid.Rows.Item(e.RowIndex)
            If row.Cells.Item(0).Value = Nothing Then
                row.Cells.Item(0).Value = "+"
            End If

            If row.Cells.Item(0).Value = "+" Then


                Dim rowIndexes = GetExpandedRowsBelow(e.RowIndex) ' get expanded rows index>e.rowindex
                'dispose all detail view panel of rows below
                For Each idx In rowIndexes
                    RemoveDetailsRow(idx)
                    CollapseDetailViewRow(CustAccountGrid.Rows.Item(idx))
                Next

                AddDetailsRow(row, custInf)
                DetailViewAlignment(e.RowIndex)

                For Each br In rowIndexes
                    Dim rd = CustAccountGrid.Rows.Item(br).Cells.Item("RowID").Value

                    Dim cuf As New SpecialPricingInfo
                    If rd > 0 Then
                        cuf = Program._spInfo.FirstOrDefault(Function(x) _
                                                            (x.RowID = rd))
                    End If

                    AddDetailsRow(CustAccountGrid.Rows.Item(br), cuf)
                    DetailViewAlignment(br)
                Next
            Else
                CollapseDetailViewX(e)
            End If

        End If


        'Dim columnIndex = e.ColumnIndex
        Dim columnName = ""
        If columnIndex > -1 Then
            columnName = CustAccountGrid.Columns.Item(columnIndex).Name
        End If
        If columnName = "TypicalPriceCheckbox" Then
            CustAccountGrid.Rows.Item(e.RowIndex).Cells.Item(e.ColumnIndex + 2).Value = False
            CustAccountGrid.Rows.Item(e.RowIndex).Cells.Item(e.ColumnIndex + 4).Value = False
        End If

        If columnName = "RateCardCheckBox" Then
            CustAccountGrid.Rows.Item(e.RowIndex).Cells.Item(e.ColumnIndex - 2).Value = False
            CustAccountGrid.Rows.Item(e.RowIndex).Cells.Item(e.ColumnIndex + 2).Value = False
        End If

        If columnName = "recommendedCheckBox" Then
            CustAccountGrid.Rows.Item(e.RowIndex).Cells.Item(e.ColumnIndex - 2).Value = False
            CustAccountGrid.Rows.Item(e.RowIndex).Cells.Item(e.ColumnIndex - 4).Value = False
        End If

        Dim dataRow = CustAccountGrid.Rows.Item(e.RowIndex).Cells
        If columnName = "Action" Then
            Dim action As String
            action = CustAccountGrid.Rows.Item(e.RowIndex).Cells.Item("Action").Value
            If action = "Expire special now" Then
                uncheckAllOptions(dataRow)
                disableAllOptions(dataRow)
            End If

        End If

        If columnName = "AddItem" Then
            'if (dataGridView1.Columns[e.ColumnIndex].Name == "Buttons")
            ' Print("hurray")

            If CustAccountGrid.Rows.Item(e.RowIndex).Cells.Item(e.ColumnIndex).Value = "Submit" Then

                Dim updated As Boolean = checkIfUpdated(dataRow)
                If Not updated Then
                    Return
                End If
                'custInf.EffectiveDate = dataRow.Item(10).Value
                Dim val As Object = GetCheckedValue(dataRow)

                Dim action As String = dataRow.Item(9).Value
                If action = "Set special future date" Or action = "" Then


                    If val < 0.001 Then
                        val = GetCustomSpecial(dataRow)
                        If val > 0 Then
                            CustAccountGrid.Rows.Item(e.RowIndex).Cells.Item("CustomSpecial").Value = val
                        End If
                    End If

                    If val > 0 Then
                        If Difference25Percent(val, custInf.CurrentSpecial) = False Then
                            Return
                        End If
                    End If
                End If

                CustAccountGrid.Rows.Item(e.RowIndex).Cells.Item(e.ColumnIndex).Value = "Submitted" '64, 122, 38
                CustAccountGrid.Rows.Item(e.RowIndex).Cells.Item(e.ColumnIndex).Style.ForeColor = Color.FromArgb(64, 122, 38)

                Program.AddRowToFinalGrid(dataRow, CustomerLable.Text, custInf, rowId, val)
                SuccessMessagePanel.Visible = True


            Else CustAccountGrid.Rows.Item(e.RowIndex).Cells.Item(e.ColumnIndex).Value = "Submit"
                CustAccountGrid.Rows.Item(e.RowIndex).Cells.Item(e.ColumnIndex).Style.ForeColor = Color.FromName("ControlText")
                uncheckAllOptions(dataRow)
                Program.RemoveRowFromFinalGrid(rowId)
            End If
        End If

        Program.SetReviewReadUnRead() ' the green bubble next to review tab

        'Dim specialIdList As New Dynamic
        'Dim specialValueList As New Dynamic
        'Dim specialcount As Integer
        'Dim OnlyMABIS As Boolean = False
        'Dim customerSearchText As String = "844518"
        'With CustAccount
        '    .SetCustomer(customerSearchText)
        '    .SetListType("customer.history")
        '    .FilterOnlyMustStock(OnlyMABIS)

        '    .BuildOrderList()
        '    .BuildProductList()
        '    .BuildSpecialPricingLists(_maxEntry)
        '    .SortSpecialPricingList(_sortAttr, _sortDesc, _justify)
        '    .GetSpecialPricingLists(specialIdList, specialValueList, specialcount)
        'End With

    End Sub

    Private Function GetExpandedRowsBelow(idx As Integer) As List(Of Integer)
        Dim indexList As List(Of Integer)
        indexList = New List(Of Integer)
        If idx >= CustAccountGrid.Rows.Count - 1 Then
            Return indexList
        End If
        For index = idx To CustAccountGrid.Rows.Count - 1
            If CustAccountGrid.Rows.Item(index).Cells.Item(0).Value = "-" Then
                indexList.Add(index)
            End If
        Next
        Return indexList
    End Function

    Private Sub RemoveDetailsRow(idx As Integer)

        Dim pnl = Me.Controls.Find("grdRowPnl" & idx, True)
        If pnl.Count > 0 Then
            For Each element In pnl
                element.Visible = False
                element.Dispose()
            Next

        End If
        '.First()
        'pnl.Visible = False
        'pnl.Dispose()

    End Sub
    Private Sub AddDetailsRow(row As DataGridViewRow, custInf As SpecialPricingInfo)
        ' CollapseDetailView()

        Dim cellBounds = CustAccountGrid.GetCellDisplayRectangle(0, row.Index, False)
        Dim offsetLocation = New Point(cellBounds.X, cellBounds.Y + cellBounds.Height)
        offsetLocation.Offset(CustAccountGrid.Location)

        row.Cells.Item(0).Value = "-"
        row.Height = row.Height + 53
        CustAccountGrid.ScrollBars = ScrollBars.None

        Dim moreInfoPanel As Panel
        Dim LabelCustSalesQTYValue As Label
        Dim LabelCustomerSalesVvalue As Label
        Dim LabelRateCardValue As Label
        Dim LabelCMPValue As Label
        Dim LabelTerritoryValue As Label
        Dim LabelPriceLineValue As Label
        Dim LabelRateCardNameValue As Label
        Dim LabelLastPurchaseDateValue As Label
        Dim LabelCustSalesQTYHeader As Label
        Dim LabelCustomerSalesVHeader As Label
        Dim LabelRateCardHeader As Label
        Dim LabelCMPHeader As Label
        Dim LabelTerritoryHeader As Label
        Dim LabelPriceLineHeader As Label
        Dim LabelRateCardNameHeader As Label
        Dim LabelLastPurchaseDateHeader As Label

        'Dim startpointx As Integer = 573
        'Dim startpointy As Integer = 200

        Dim textFont = New System.Drawing.Font("roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Dim textFontBold = New System.Drawing.Font("roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        'machinepanel = me.moreinfopanel
        moreInfoPanel = New Panel()
        With moreInfoPanel
            .Name = "grdRowPnl" & row.Index
            .BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
            .BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            .Font = textFont
            .Location = offsetLocation 'new system.drawing.point(24, 711)
            .Size = New System.Drawing.Size(1472, 53)
            .TabIndex = 21
            .Visible = False
        End With

        LabelCustSalesQTYValue = New Label()
        LabelCustomerSalesVvalue = New Label()
        LabelRateCardValue = New Label()
        LabelCMPValue = New Label()
        LabelTerritoryValue = New Label()
        LabelPriceLineValue = New Label()
        LabelRateCardNameValue = New Label()
        LabelLastPurchaseDateValue = New Label()
        LabelCustSalesQTYHeader = New Label()
        LabelCustomerSalesVHeader = New Label()
        LabelRateCardHeader = New Label()
        LabelCMPHeader = New Label()
        LabelTerritoryHeader = New Label()
        LabelPriceLineHeader = New Label()
        LabelRateCardNameHeader = New Label()
        LabelLastPurchaseDateHeader = New Label()

        With LabelCustSalesQTYHeader
            .Name = "LabelCustSalesQTYHeader" & row.Index
            .Text = "Customer Sales QTY:"
            .Font = textFontBold
            .Location = New Point(47, 1) '<- in relation to machinepanel.clientrectangle
            .AutoSize = True
        End With

        With LabelCustomerSalesVHeader
            .Name = "LabelCustomerSalesVHeader" & row.Index
            .Text = "Customer Sales Value:"
            .Font = textFontBold
            .Location = New Point(225, 1)
            .AutoSize = True
            .Enabled = True
            .Visible = True
        End With

        With LabelRateCardHeader
            .Name = "LabelRateCardHeader" & row.Index
            .Text = "Rate Card %:"
            .Font = textFontBold
            .Location = New Point(402, 1)
            .AutoSize = True
        End With

        With LabelCMPHeader
            .Name = "LabelCMPHeader" & row.Index
            .Text = "CMP:"
            .Font = textFontBold
            .Location = New Point(530, 1)
            .AutoSize = True
        End With

        With LabelTerritoryHeader
            .Name = "LabelTerritoryHeader" & row.Index
            .Text = "Territory:"
            .Font = textFontBold
            .Parent = moreInfoPanel
            .Location = New Point(662, 1)
            .AutoSize = True
        End With
        With LabelPriceLineHeader
            .Name = "LabelPriceLineHeader" & row.Index
            .Text = "Priceline:"
            .Font = textFontBold
            .Parent = moreInfoPanel
            .Location = New Point(810, 1)
            .AutoSize = True
        End With

        With LabelRateCardHeader
            .Name = "LabelRateCardHeader" & row.Index
            .Text = "Rate Card Name:"
            .Font = textFontBold
            .Location = New Point(944, 1)
            .AutoSize = True
        End With

        'With LabelRateCardNameHeader
        '    .Name = "LabelRateCardNameHeader" & row.Index
        '    .Text = "RateCardName"
        '    .Font = textFontBold
        '    .Location = New Point(0, 1)
        '    .AutoSize = True
        'End With

        With LabelLastPurchaseDateHeader
            .Name = "LabelRateCardNameHeader" & row.Index
            .Text = "Last Purchase Date:"
            .Font = textFont
            .Parent = moreInfoPanel
            .Location = New Point(1103, 1)
            .AutoSize = True
        End With


        With LabelCustSalesQTYValue
            .Name = "LabelCustSalesQTYValue" & row.Index
            .Text = custInf.CustomerSalesQTY
            .Font = textFontBold
            .Location = New Point(47, 24) '<- in relation to machinepanel.clientrectangle
            .AutoSize = True
        End With

        With LabelCustomerSalesVvalue
            .Name = "LabelCustomerSalesVvalue" & row.Index
            .Text = custInf.CustomerSalesValue
            .Font = textFont
            .Location = New Point(225, 24)
            .AutoSize = True
            .Enabled = True
            .Visible = True
        End With

        With LabelRateCardValue
            .Name = "LabelRateCardValue" & row.Index
            .Text = custInf.RateCard
            .Font = textFont
            .Location = New Point(402, 24)
            .AutoSize = True
        End With

        With LabelCMPValue
            .Name = "LabelCMPValue" & row.Index
            .Text = custInf.CMP
            .Font = textFont
            .Location = New Point(530, 24)
            .AutoSize = True
        End With

        With LabelTerritoryValue
            .Name = "LabelTerritoryValue" & row.Index
            .Text = custInf.Territory
            .Font = textFont
            .Parent = moreInfoPanel
            .Location = New Point(662, 24)
            .AutoSize = True
        End With
        With LabelPriceLineValue
            .Name = "LabelPriceLineValue" & row.Index
            .Text = custInf.PriceLine
            .Font = textFont
            .Parent = moreInfoPanel
            .Location = New Point(810, 24)
            .AutoSize = True
        End With

        With LabelRateCardValue
            .Name = "LabelRateCardValue" & row.Index
            .Text = custInf.RateCard
            .Font = textFont
            .Location = New Point(944, 24)
            .AutoSize = True
        End With

        'With LabelRateCardNameValue
        '    .Name = "LabelRateCardNameValue" & row.Index
        '    .Text = custInf.RateCardName
        '    .Font = textFont
        '    .Location = New Point(0, 24)
        '    .AutoSize = True
        'End With

        With LabelLastPurchaseDateValue
            .Name = "LabelRateCardNameValue" & row.Index
            .Text = custInf.LastPurchaseDate
            .Font = textFont
            .Parent = moreInfoPanel
            .Location = New Point(1103, 24)
            .AutoSize = True
        End With

        moreInfoPanel.Controls.AddRange(New Control() {LabelCustSalesQTYHeader, LabelCustomerSalesVHeader, LabelRateCardHeader, LabelRateCardHeader, LabelCMPHeader, LabelTerritoryHeader, LabelPriceLineHeader, LabelRateCardHeader, LabelRateCardNameHeader, LabelLastPurchaseDateHeader, LabelCustSalesQTYValue, LabelCustomerSalesVvalue, LabelRateCardValue, LabelRateCardValue, LabelCMPValue, LabelTerritoryValue, LabelPriceLineValue, LabelRateCardValue, LabelRateCardNameValue, LabelLastPurchaseDateValue})
        moreInfoPanel.Visible = True
        GridPanel.Controls.Add(moreInfoPanel)
        moreInfoPanel.BringToFront()

    End Sub

    Private Sub setGrid(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles CustAccountGrid.DataBindingComplete

        Dim ctCell As CustomCheckBoxCell = Nothing
        Dim row As DataGridViewRow

        'Dim actionCBColumn As New DataGridViewComboBoxColumn =  CustAccountGrid.Columns("Action") 
        'actionCBColumn.DataSource = _spInfo.FirstOrDefault().Action
        'actionCBColumn.DisplayMember = "DisplayValue"
        'actionCBColumn.ValueMember = "ID"

        'CustAccountGrid.Columns("Action") = actionCBColumn
        SetDefaultComumnAlignment()



        For Each row In CustAccountGrid.Rows
            If row Is Nothing Then
                Continue For
            End If



            DefaultAlignmentAndValue(row)

            'Dim rowID As Integer = row.Cells("rowID").Value
            '    ctCell = row.Cells("Recommended")
            'If Not ctCell Is Nothing Then
            '    Dim custInf As New SpecialPricingInfo
            '    custInf = _spInfo.FirstOrDefault(Function(x) _
            '                                            (x.RowID = rowID))
            '    ctCell.Label = custInf.Recommended
            '    'ctCell.Enabled = True

            'End If
        Next

    End Sub

    Private Sub SetDefaultComumnAlignment()

        For Each col As DataGridViewColumn In CustAccountGrid.Columns
            Select Case col.Index
                Case 1 To 3
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                Case 4 To 7
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                Case 11 To 17
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                Case Else
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            End Select
        Next


    End Sub

    Private Sub CollapseDetailViewX(e As DataGridViewCellEventArgs)


        Dim pnl = GridPanel.Controls.Find("grdRowPnl" & e.RowIndex, False).First()
        pnl.Visible = False

        Dim row As DataGridViewRow = CustAccountGrid.Rows(e.RowIndex)

        'For Each row In CustAccountGrid.Rows

        '    If row.Cells.Item(0).Value = "+" Then
        '    End If
        '    Continue For

        If row.Height > 53 Then
            row.Height = row.Height - 53
        End If
        DefaultAlignmentAndValue(row)

        ' Next
        ' CustAccountGrid.ScrollBars = ScrollBars.Vertical
    End Sub
    Private Sub CollapseDetailViewRow(row As DataGridViewRow)

        If row.Cells.Item(0).Value = "+" Then
            Return
        End If

        If row.Height > 53 Then
            row.Height = row.Height - 53
        End If
        DefaultAlignmentAndValue(row)


        'CustAccountGrid.ScrollBars = ScrollBars.Vertical
    End Sub
    Private Sub CollapseDetailView()


        Dim row As DataGridViewRow
        For Each row In CustAccountGrid.Rows

            If row.Cells.Item(0).Value = "+" Then
                Continue For
            End If

            If row.Height > 53 Then
                row.Height = row.Height - 53
            End If
            DefaultAlignmentAndValue(row)

        Next
        CustAccountGrid.ScrollBars = ScrollBars.Vertical
    End Sub
    Private Sub ExpandDetailView()
        moreInfoPanel.Visible = False

        Dim row As DataGridViewRow
        For Each row In CustAccountGrid.Rows

            If row.Cells.Item(0).Value = "+" Then
                Continue For
            End If

            If row.Height > 53 Then
                row.Height = row.Height - 53
            End If
            DefaultAlignmentAndValue(row)

        Next
        CustAccountGrid.ScrollBars = ScrollBars.Vertical
    End Sub
    Private Sub DetailViewAlignment(rowIndex As Integer)
        For Each cell As DataGridViewCell In CustAccountGrid.Rows.Item(rowIndex).Cells

            Select Case cell.ColumnIndex
                Case 1 To 3
                    cell.Style.Alignment = DataGridViewContentAlignment.TopLeft
                Case 4 To 7
                    cell.Style.Alignment = DataGridViewContentAlignment.TopRight
                'Case 9
                '    cell.Style.Alignment = DataGridViewContentAlignment.TopCenter
                Case 11 To 17
                    cell.Style.Alignment = DataGridViewContentAlignment.TopRight
                Case Else
                    cell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            End Select

        Next
    End Sub

    Private Shared Sub DefaultAlignmentAndValue(row As DataGridViewRow)

        For Each cell As DataGridViewCell In row.Cells
            If cell.ColumnIndex = 0 Then
                cell.Value = "+"
            End If

            If cell.ColumnIndex = 9 Then
                Dim cbCell As New DataGridViewComboBoxCell
                Dim acds = _spInfo.FirstOrDefault().Action
                cbCell.DataSource = acds
                cbCell.ValueMember = "ID"
                cbCell.DisplayMember = "DisplayValue"
                cbCell.Value = -1
                ' cbCell.Visible = True

                cell = cbCell
                'cell.Visible = True

            End If

            Select Case cell.ColumnIndex
                Case 1 To 3
                    cell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                Case 4 To 7
                    cell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                Case 9
                    cell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                Case 11 To 17
                    cell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                Case Else
                    cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            End Select
        Next

        row.Cells("Action").Value = "Select an action.."


    End Sub

    Private Function Difference25Percent(val As Double, currentSpecial As Object) As Boolean
        If currentSpecial = "None" Then
            Return True
        End If
        Dim percent As Double
        Dim point As Double = val / currentSpecial
        percent = ((val / currentSpecial) * 100) - 100

        Dim diagRes As DialogResult
        If percent <= -25 Then
            diagRes = MessageBox.Show("Your modifed special price is 25% less than or equal to the current special price.", "Are you sure you want to add?", MessageBoxButtons.YesNo)
            If diagRes = DialogResult.Yes Then
                Return True
            End If

            Return False
        End If

        If percent >= 25 Then
            diagRes = MessageBox.Show("Your modifed special price is 25% greater than or equal to the current special price.", "Are you sure you want to add?", MessageBoxButtons.YesNo)
            If diagRes = DialogResult.Yes Then
                Return True
            End If
            Return False
        End If

        Return True

    End Function

    Private Function checkIfUpdated(dataRow As DataGridViewCellCollection) As Boolean

        If dataRow.Item("Action").Value = "Select an action.." Or dataRow.Item("Action").Value = "Set special future date" Then

            If dataRow.Item(10).Value.ToString() = "" Then
                MessageBox.Show("Enter a valid date under column Effective Date", "Validate!")
                Return False
            End If

            Dim newPrice = GetCheckedValue(dataRow)

            If newPrice = Nothing Or newPrice = "" Then
                MessageBox.Show("Please choose or enter a new special price", "Validate!")
                Return False
            End If

        Else
            If dataRow.Item("CurrentSpecial").Value.ToString() = "None" Then
                MessageBox.Show("No special price to expire", "Validate!")
                Return False
            End If

        End If



        Return True


    End Function

    Private Sub uncheckAllOptions(dataRow As DataGridViewCellCollection)
        dataRow.Item(11).Value = False
        dataRow.Item(13).Value = False
        dataRow.Item(15).Value = False
    End Sub
    Private Sub disableAllOptions(dataRow As DataGridViewCellCollection)
        Dim chkCell_11 As DataGridViewCheckBoxCell = dataRow.Item(11)
        chkCell_11.Value = False
        chkCell_11.FlatStyle = FlatStyle.Flat
        chkCell_11.Style.ForeColor = Color.DarkGray
        chkCell_11.ReadOnly = True

        Dim chkCell_13 As DataGridViewCheckBoxCell = dataRow.Item(13)
        chkCell_13.Value = False
        chkCell_13.FlatStyle = FlatStyle.Flat
        chkCell_13.Style.ForeColor = Color.DarkGray
        chkCell_13.ReadOnly = True

        Dim chkCell_15 As DataGridViewCheckBoxCell = dataRow.Item(15)
        chkCell_15.Value = False
        chkCell_15.FlatStyle = FlatStyle.Flat
        chkCell_15.Style.ForeColor = Color.DarkGray
        chkCell_15.ReadOnly = True

        'dataRow.Item(13).Value = False
        'dataRow.Item(15).Value = False
    End Sub

    Private Function GetCheckedValue(dataRow As DataGridViewCellCollection) As Object



        If dataRow.Item(11).Value = True Then
            Return dataRow.Item(12).Value
        End If
        If dataRow.Item(13).Value = True Then
            Return dataRow.Item(14).Value
        End If
        If dataRow.Item(15).Value = True Then
            Return dataRow.Item(16).Value
        End If

        If dataRow.Item(17).Value IsNot Nothing And dataRow.Item(17).Value > 0 Then
            Dim customVal As Decimal = 22.22
            customVal = dataRow.Item(17).Value
            Return customVal.ToString("F2")
        End If
        Return ""
    End Function
    Private Function GetCustomSpecial(dataRow As DataGridViewCellCollection) As Object

        If dataRow.Item(17).Value IsNot Nothing And dataRow.Item(17).Value > 0 Then
            Dim customVal As Decimal = 22.22
            customVal = dataRow.Item(17).Value
            Return customVal.ToString("F2")
        End If
        Return ""
    End Function






    Private Sub CustAccountGrid_CellContentClick_1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CustAccountGrid.ColumnHeaderMouseClick
        If CustAccountGrid.Columns.Item(e.ColumnIndex).SortMode = DataGridViewColumnSortMode.NotSortable Then
            Return
        End If
        Dim ColumnName As String
        ColumnName = CustAccountGrid.Columns.Item(e.ColumnIndex).Name
        'CustAccountGrid.so
        Dim sortDesc = Program.SortAndRebuild(ColumnName)
        CustAccountGrid.Refresh()
        CustAccountGrid.DataBindings.Clear()
        CustAccountGrid.DataSource = Program._spInfo
        If sortDesc Then
            CustAccountGrid.Columns.Item(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending
        Else
            CustAccountGrid.Columns.Item(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Ascending
        End If

    End Sub

    Private Sub CustSalesButton_Click(sender As Object, e As EventArgs) Handles CustSalesButton.Click
        CollapseDetailView()
        FilterPanel.Visible = False
        SalesFilterPanel.Visible = Not SalesFilterPanel.Visible
        SalesFilterPanel.BringToFront()


    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ExpandRowsBtn.Click
        FilterPanel.Visible = False
        SalesFilterPanel.Visible = False
        Dim rowId As Integer = 0
        Dim custInf As New SpecialPricingInfo

        'dispose all detail view panel
        For Each row As DataGridViewRow In CustAccountGrid.Rows
            RemoveDetailsRow(row.Index)
        Next
        'collapse all eapanded rows first
        CollapseDetailView()
        Dim rowCnt = CustAccountGrid.Rows.Count
        If ExpandRowsBtn.Text = "Expand Rows" Then

            'increase the hight of datagrid by number of rows * 53

            CustAccountGrid.Height = CustAccountGrid.Height + rowCnt * 53 + rowCnt * 50

            For Each row As DataGridViewRow In CustAccountGrid.Rows
                rowId = row.Cells.Item("RowID").Value

                If rowId < 1 Then
                    Continue For
                End If
                custInf = Program._spInfo.FirstOrDefault(Function(x) _
                                                            (x.RowID = rowId))
                AddDetailsRow(row, custInf)
                DetailViewAlignment(row.Index)
            Next
            ExpandRowsBtn.Text = "Collapse Rows"
        Else
            CustAccountGrid.Height = CustAccountGrid.Height - CustAccountGrid.Rows.Count * 53 - rowCnt * 50
            For Each row As DataGridViewRow In CustAccountGrid.Rows
                rowId = row.Cells.Item("RowID").Value

                If rowId < 1 Then
                    Continue For
                End If
                custInf = Program._spInfo.FirstOrDefault(Function(x) _
                                                            (x.RowID = rowId))
                'AddDetailsRow(row, custInf)
                RemoveDetailsRow(row.Index)
                'DetailViewAlignment(row.Index)
            Next
            ExpandRowsBtn.Text = "Expand Rows"
            CollapseDetailView()
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SuccessMessagePanel.Visible = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        CollapseDetailView()
        SuccessMessagePanel.Visible = False
        Program.ShowReviewForm()
    End Sub
    Private Sub ToolsGroupBoc_Enter(sender As Object, e As EventArgs)
    End Sub


    'Private Sub CustAccountGrid_MouseLeave(sender As Object, e As EventArgs) Handles CustAccountGrid.MouseLeave
    '    CollapseDetailView()
    'End Sub
    Private Sub CustAccountGrid_CellPaint(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles CustAccountGrid.CellPainting
        If e.ColumnIndex = 11 Or e.ColumnIndex = 13 Or e.ColumnIndex = 15 Then
            e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None
        End If
    End Sub

    Private Sub ThreeMonthChkBx_CheckedChanged(sender As Object, e As EventArgs) Handles ThreeMonthChkBx.CheckedChanged
        If ThreeMonthChkBx.Checked Then
            uncheckRestSalesCheckBox(NameOf(ThreeMonthChkBx))
            filterSalesDuration(3)
        Else

        End If
    End Sub

    Private Shared Sub filterSalesDuration(month As Integer)
        Dim startDate As Object = DateTime.Now.AddMonths(-month).ToString("MM/dd/yyyy")
        Program.SetDateRangeFilter(startDate)
        Program.BuildCustAccountData()
        Program.ReLoadCustAccountGrid()
    End Sub

    Private Sub SixMonthChkBx_CheckedChanged(sender As Object, e As EventArgs) Handles SixMonthChkBx.CheckedChanged
        If SixMonthChkBx.Checked Then
            uncheckRestSalesCheckBox(NameOf(SixMonthChkBx))
            filterSalesDuration(6)
        Else

        End If
    End Sub

    Private Sub NineMonthChkBx_CheckedChanged(sender As Object, e As EventArgs) Handles NineMonthChkBx.CheckedChanged
        If NineMonthChkBx.Checked Then
            uncheckRestSalesCheckBox(NameOf(NineMonthChkBx))
            filterSalesDuration(9)
        Else

        End If
    End Sub

    Private Sub TwelveMonthChkBx_CheckedChanged(sender As Object, e As EventArgs) Handles TwelveMonthChkBx.CheckedChanged
        If TwelveMonthChkBx.Checked Then
            uncheckRestSalesCheckBox(NameOf(TwelveMonthChkBx))
            filterSalesDuration(9)
        Else

        End If
    End Sub

    Private Sub uncheckRestSalesCheckBox(v As String)
        For Each item As Control In SalesFilterPanel.Controls
            Dim temp As CheckBox

            If TypeOf (item) IsNot CheckBox Then
                Continue For
            End If
            temp = item
            If temp.Name = v Then
                Continue For
            End If
            temp.Checked = False
        Next
    End Sub

    Private Sub CloseToTrade_CheckedChanged(sender As Object, e As EventArgs) Handles CloseToTrade.CheckedChanged

        If CloseToTrade.Checked Then
            uncheckRestCheckBox(NameOf(CloseToTrade))
            ClearFilter()
            SetCloseToTradeFilter()
        Else

        End If

    End Sub

    Private Sub uncheckRestCheckBox(v As String)

        For Each item As Control In FilterPanel.Controls
            Dim temp As CheckBox

            If TypeOf (item) IsNot CheckBox Then
                Continue For
            End If
            temp = item
            If temp.Name = v Then
                Continue For
            End If
            temp.Checked = False

        Next
    End Sub

    Private Sub LowGPChkBx_CheckedChanged(sender As Object, e As EventArgs) Handles LowGPChkBx.CheckedChanged
        If LowGPChkBx.Checked Then
            uncheckRestCheckBox(NameOf(LowGPChkBx))
            SetLowGPFilter()
        Else
            ClearFilter()
        End If
    End Sub

    Private Sub NoSalesChkBx_CheckedChanged(sender As Object, e As EventArgs) Handles NoSalesChkBx.CheckedChanged
        If NoSalesChkBx.Checked Then
            uncheckRestCheckBox(NameOf(NoSalesChkBx))
            SetNoRecentSalesFilter()
        Else
            ClearFilter()
        End If
    End Sub

    Private Sub LowSalesChkBx_CheckedChanged(sender As Object, e As EventArgs) Handles LowSalesChkBx.CheckedChanged
        If LowSalesChkBx.Checked Then
            uncheckRestCheckBox(NameOf(LowSalesChkBx))
            SetLowSalesFilter()
        Else
            ClearFilter()
        End If
    End Sub

    Private Sub Top10Chkbx_CheckedChanged(sender As Object, e As EventArgs) Handles Top10Chkbx.CheckedChanged
        If Top10Chkbx.Checked Then
            uncheckRestCheckBox(NameOf(Top10Chkbx))
            _maxEntry = 10
            Program.BuildCustAccountData() ' this rebuilds the grid
            Program.ReLoadCustAccountGrid()
        Else
            _maxEntry = 0
        End If
    End Sub

    Private Sub Top100ChkBx_CheckedChanged(sender As Object, e As EventArgs) Handles Top100ChkBx.CheckedChanged
        If Top100ChkBx.Checked Then
            uncheckRestCheckBox(NameOf(Top100ChkBx))
            _maxEntry = 100
            Program.BuildCustAccountData() ' this rebuilds the grid
            Program.ReLoadCustAccountGrid()
        Else
            _maxEntry = 0

        End If
    End Sub

    Private Sub MABISChkBx_CheckedChanged(sender As Object, e As EventArgs) Handles MABISChkBx.CheckedChanged
        If MABISChkBx.Checked Then
            uncheckRestCheckBox(NameOf(MABISChkBx))
            Program.SetCustAccountListMABISFilter(True)
            Program.BuildCustAccountData() ' this rebuilds the grid
            Program.ReLoadCustAccountGrid()
        Else
            Program.SetCustAccountListMABISFilter(False)
        End If

    End Sub

    Private Sub AMAAChkBx_CheckedChanged(sender As Object, e As EventArgs) Handles AMAAChkBx.CheckedChanged
        If AMAAChkBx.Checked Then
            uncheckRestCheckBox(NameOf(AMAAChkBx))
            Program.SetCustAccountListAMAAFilter(True)
            Program.BuildCustAccountData() ' this rebuilds the grid
            Program.ReLoadCustAccountGrid()
        Else
            Program.SetCustAccountListAMAAFilter(False)
        End If
    End Sub

    Private Sub FilterButton_Click_1(sender As Object, e As EventArgs) Handles FilterButton.Click
        CollapseDetailView()
        SalesFilterPanel.Visible = False
        FilterPanel.Visible = Not FilterPanel.Visible
        FilterPanel.BringToFront()

    End Sub

    Private Sub ClearFilterBtn_Click(sender As Object, e As EventArgs) Handles ClearFilterBtn.Click
        ClearFilter()
        Program.BuildCustAccountData() ' this rebuilds the grid
        Program.ReLoadCustAccountGrid()
        FilterPanel.Visible = False
    End Sub

    Private Sub FilterPanel_Paint(sender As Object, e As PaintEventArgs) Handles FilterPanel.Paint

    End Sub

    Private Sub closeFiletePanelBtn_Click(sender As Object, e As EventArgs) Handles closeFiletePanelBtn.Click
        FilterPanel.Visible = False
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles CloseSalesFilterBtn.Click
        SalesFilterPanel.Visible = False
    End Sub

    Private Sub QueryResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CustAccountGrid_AllowUserToAddRowsChanged(sender As Object, e As EventArgs) Handles CustAccountGrid.AllowUserToAddRowsChanged

    End Sub

    Private Sub CustAccountGrid_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles CustAccountGrid.CellValueChanged
        ' My combobox column Is the second one so I hard coded a 1, flavor to taste
        If e.RowIndex < 0 Then
            Return
        End If
        Dim cb As DataGridViewComboBoxCell = CustAccountGrid.Rows.Item(e.RowIndex).Cells.Item("Action")

        If cb.Value Is Nothing Then
            Return
        End If

        If cb.Value = "Select an action.." Then
            Return
        End If

        If cb.Value = "Expire special now" Or cb.Value = "Remove special future date" Or cb.Value = "Clear future change" Then

            Dim dataRow = CustAccountGrid.Rows.Item(e.RowIndex).Cells
            Dim chkCell_11 As DataGridViewCheckBoxCell = dataRow.Item(11)
            chkCell_11.Value = False
            chkCell_11.FlatStyle = FlatStyle.Flat
            chkCell_11.Style.ForeColor = Color.DarkGray
            chkCell_11.ReadOnly = True

            Dim chkCell_13 As DataGridViewCheckBoxCell = dataRow.Item(13)
            chkCell_13.Value = False
            chkCell_13.FlatStyle = FlatStyle.Flat
            chkCell_13.Style.ForeColor = Color.DarkGray
            chkCell_13.ReadOnly = True

            Dim chkCell_15 As DataGridViewCheckBoxCell = dataRow.Item(15)
            chkCell_15.Value = False
            chkCell_15.FlatStyle = FlatStyle.Flat
            chkCell_15.Style.ForeColor = Color.DarkGray
            chkCell_15.ReadOnly = True
        End If

        If cb.Value = "Set special future date" Then

            Dim dataRow = CustAccountGrid.Rows.Item(e.RowIndex).Cells
            Dim chkCell_11 As DataGridViewCheckBoxCell = dataRow.Item(11)
            '  chkCell_11.Value = False
            chkCell_11.FlatStyle = FlatStyle.Flat
            'chkCell_11.Style.ForeColor = Color.DarkGray
            chkCell_11.ReadOnly = False

            Dim chkCell_13 As DataGridViewCheckBoxCell = dataRow.Item(13)
            ' chkCell_13.Value = False
            chkCell_13.FlatStyle = FlatStyle.Flat
            'chkCell_13.Style.ForeColor = Color.DarkGray
            chkCell_13.ReadOnly = False

            Dim chkCell_15 As DataGridViewCheckBoxCell = dataRow.Item(15)
            ' chkCell_15.Value = False
            chkCell_15.FlatStyle = FlatStyle.Flat
            'chkCell_15.Style.ForeColor = Color.DarkGray
            chkCell_15.ReadOnly = False

        End If

        'do stuff
        'dataGridView1.Invalidate();

    End Sub

    Private Sub CustAccountGrid_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles CustAccountGrid.CurrentCellDirtyStateChanged
        If CustAccountGrid.IsCurrentCellDirty Then
            ' This fires the cell value changed handler below
            CustAccountGrid.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If

    End Sub

    Private Sub CustAccountGrid_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub


End Class