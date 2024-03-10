Imports SpecialPricing.UVObjects

Public Class ReviewForm
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        'Dim success As Boolean = Program.UpdatePricing
        'QueryForm.MdiParent = MdiParent
        'QueryForm.StartPosition = FormStartPosition.CenterParent
        'QueryForm.Visible = True

        Program.UpdatePricing()

        Program.BuildCustAccountData()
        Program.SetReviewReadUnRead()

        finalGridView.Rows.Clear()
        QueryResult.CustAccountGrid.Refresh()
        QueryResult.CustAccountGrid.DataBindings.Clear()
        QueryResult.CustAccountGrid.DataSource = Program._spInfo
        'Program.HideReviewForm()
        Program.ShowQueryResultForm()

        'Me.Visible = False
        ' Program.ShowCreateModifySelected()
        'QueryResult.Visible = True

    End Sub

    Private Sub finalGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles finalGridView.CellClick

        If e.RowIndex < 0 Then
            Return
        End If

        Dim columnIndex = e.ColumnIndex

        Dim columnName = ""
        If columnIndex > -1 Then
            columnName = finalGridView.Columns.Item(columnIndex).Name
        End If

        Dim rowId As Integer = 0
        rowId = finalGridView.Rows.Item(e.RowIndex).Cells.Item("RowID").Value

        If columnName = "RemoveRow" Then

            Program.RemoveRowFromFinalGrid(rowId)
            Program.UnsubmitRowFromCustAccountGrid(rowId)
            Program.SetReviewReadUnRead()

        End If

    End Sub

End Class