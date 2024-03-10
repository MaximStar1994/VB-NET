Public Class CustSalesQuantityFilter

    Private _monthFilter As Dictionary(Of String, Integer)
    Public Property MonthFilter() As Dictionary(Of String, Integer)
        Get
            Return _monthFilter
        End Get
        Set(ByVal value As Dictionary(Of String, Integer))
            _monthFilter = value
        End Set
    End Property


    Public Sub New()
        _monthFilter = New Dictionary(Of String, Integer)
        _monthFilter.Add("3 months", 3)
        _monthFilter.Add("6 months", 6)
        _monthFilter.Add("9 months", 9)
        _monthFilter.Add("12 months", 12)
    End Sub

    Friend Function GetMonth(searchText As Object) As Integer
        Dim mon As Integer = 0
        If _monthFilter.TryGetValue(searchText, mon) Then
        Else
            mon = 0
        End If

        Return mon
    End Function
End Class
