Imports System.ComponentModel
Imports SpecialPricing.UVObjects

Namespace UVObjects
    Public Class SpecialPricingInfo
        Public Property RowID As Integer
        Public Property CustomerId As String
        Public Property ProductId As Object
        Public Property Description As Object
        Public Property CurrentSpecial As Object
        Public Property CMP As Double
        Public Property ReplacementCost As Double
        Public Property TotalPrice As Object
        Public Property TotalCost As Object
        'Public Property LastChangeDate As Object
        Public Property CustomerSalesQTY As Object
        Public Property CustomerProfitOpp As Double
        Public Property TradeRatePrice As Double
        Public Property TradeRatePercentage As Double
        Public Property Margin As Double = -20.3
        Public Property NextPrice As Object
        Public Property PriceOrigin As Char = "B"
        Public Property EffectiveDate As Object
        Public Property RateCard As Object = 4.6
        Public Property Recommended As Object
        Public Property Salesperson As String = "DB6001"
        Public Property RateCardPercentage As Double = 20.3
        Public Property RateCardName As String = "P3213"
        Public Property Territory As String
        Public Property LastPurchaseDate As String
        Public Property Action As List(Of ActionItem) = GetDefaultActionItem()
        Public Property ButtonText As String = "Submit"
        Public Property HomeBranch As Object
        Public Property PriceLine As Object
        Public Property StandardCost As Object
        Public Property DiscontinueDate As Object
        Public Property TypicalPrice As Object
        Public Property CustomerSalesValue As Object
        Public Property SpecialPriceMatrixId As String
        Public Property HasSpecialPricing As Boolean
        Public Property MABIS As Boolean = False

        Private Function GetDefaultActionItem() As List(Of ActionItem)
            Dim listOfActions = New List(Of ActionItem)

            Dim action As New ActionItem()
            action.ID = -1
            action.DisplayValue = "Select an action.."
            action.Value = "selectAction"
            listOfActions.Add(action)

            Dim action0 As New ActionItem()
            action0.ID = 0
            action0.DisplayValue = "Expire Special Now"
            action0.Value = "ExpireSpecialNow"
            listOfActions.Add(action0)

            Dim action1 As New ActionItem()
            action1.ID = 1
            action1.DisplayValue = "Set Special Future Date"
            action1.Value = "SetSpecialFutureDate"
            listOfActions.Add(action1)

            Dim action2 As New ActionItem()
            action2.ID = 2
            action2.DisplayValue = "Remove Special Future Date"
            action2.Value = "RemoveSpecialFutureDate"
            listOfActions.Add(action2)

            Dim action3 As New ActionItem()
            action3.ID = 3
            action3.DisplayValue = "Clear Futue Change"
            action3.Value = "ClearFutueChange"
            listOfActions.Add(action3)

            GetDefaultActionItem = listOfActions
        End Function
    End Class

    Public Class ActionItem
        Public Property ID As Integer
        Public Property DisplayValue As String
        Public Property Value As String

        Sub New()

        End Sub

    End Class


End Namespace


