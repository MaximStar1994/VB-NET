Public Class AccountingColumn
    Inherits DataGridViewTextBoxColumn

    Public Sub New()
        CellTemplate = New AccountingCell
        DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub
End Class

Public Class AccountingCell
    Inherits DataGridViewTextBoxCell

    Protected Overrides Sub Paint(graphics As Graphics, clipBounds As Rectangle, cellBounds As Rectangle, rowIndex As Integer,
                                  cellState As DataGridViewElementStates, value As Object, formattedValue As Object, errorText As String,
                                  cellStyle As DataGridViewCellStyle, advancedBorderStyle As DataGridViewAdvancedBorderStyle,
                                  paintParts As DataGridViewPaintParts)
        'String.Format("{0: C2}", value)
        MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)

        If value IsNot Nothing Then
            Dim symbol = Globalization.NumberFormatInfo.CurrentInfo.CurrencySymbol

            Dim fcolor = If(Selected, cellStyle.SelectionForeColor, cellStyle.ForeColor)
            Using brush As New SolidBrush(fcolor), format As New StringFormat With {.LineAlignment = StringAlignment.Center}

                graphics.DrawString(symbol, cellStyle.Font, brush, cellBounds, format)
            End Using
        End If
    End Sub

End Class
