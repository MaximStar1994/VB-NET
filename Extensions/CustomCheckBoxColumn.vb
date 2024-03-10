Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Windows.Forms.VisualStyles

'Public Class CustomCheckBoxColumn
'    Inherits DataGridViewCheckBoxColumn
'    Private _label As String

'    Public Property Label() As String
'        Get
'            Return _label
'        End Get
'        Set(ByVal Value As String)
'            _label = Value
'        End Set
'    End Property
'    Public Sub New()
'        Me.CellTemplate = New CustomCheckBoxCell()
'    End Sub
'End Class

'Public Class CustomCheckBoxCell
'    Inherits DataGridViewCheckBoxCell
'    Private _label As String

'    Public Property Label() As String
'        Get
'            Return _label
'        End Get
'        Set(ByVal Value As String)
'            _label = Value
'        End Set
'    End Property

'    Protected Overrides Sub Paint(ByVal graphics As Graphics, ByVal clipBounds As Rectangle, ByVal cellBounds As Rectangle, ByVal rowIndex As Integer, ByVal elementState As DataGridViewElementStates, ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, ByVal paintParts As DataGridViewPaintParts)

'        ' the base Paint implementation paints the check box
'        MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)

'        ' Get the check box bounds: they are the content bounds
'        Dim contentBounds As Rectangle = Me.GetContentBounds(rowIndex)

'        ' Compute the location where we want to paint the string.
'        Dim stringLocation As Point = New Point()

'        ' Compute the Y.
'        ' NOTE: the current logic does not take into account padding.
'        stringLocation.Y = cellBounds.Y + contentBounds.Top


'        ' Compute the X.
'        ' Content bounds are computed relative to the cell bounds
'        ' - not relative to the DataGridView control.
'        stringLocation.X = cellBounds.X + contentBounds.Right + 2


'        ' Paint the string.
'        If Me.Label Is Nothing Then
'            Dim col As CustomCheckBoxColumn = CType(Me.OwningColumn, CustomCheckBoxColumn)
'            Me.Label = col.Label
'        End If

'        graphics.DrawString(Me.Label, Control.DefaultFont, New SolidBrush(cellStyle.ForeColor), stringLocation)

'    End Sub

'End Class



Public Class CustomCheckBoxColumn
    Inherits DataGridViewCheckBoxColumn
    Public Sub New()
        CellTemplate = New CustomCheckBoxCell
    End Sub
End Class
Public Class CustomCheckBoxCell
    Inherits DataGridViewCheckBoxCell
    Public Sub New()
        Me.Enabled = True
    End Sub
    Private _enabled As Boolean
    Public Property Enabled() As Boolean
        Get
            Return _enabled
        End Get
        Set(ByVal Value As Boolean)
            _enabled = Value
            Me.ReadOnly = False
        End Set
    End Property
    Private _text As String
    Public Property Label() As String
        Get
            Return _text
        End Get
        Set(ByVal Value As String)
            _text = Value
        End Set
    End Property
    Private _color As System.Drawing.Color
    Public Property Color() As System.Drawing.Color
        Get
            Return _color
        End Get
        Set(ByVal Value As System.Drawing.Color)
            _color = Value
        End Set
    End Property
    Private _font As System.Drawing.Font
    Public Property Font() As System.Drawing.Font
        Get
            Return _font
        End Get
        Set(ByVal Value As System.Drawing.Font)
            _font = Value
        End Set
    End Property


    Protected Overrides Sub Paint(ByVal graphics As Graphics, ByVal clipBounds As Rectangle, ByVal cellBounds As Rectangle, ByVal rowIndex As Integer, ByVal elementState As DataGridViewElementStates, ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, ByVal paintParts As DataGridViewPaintParts)
        MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)

        If Me.Font Is Nothing Then
            Me.Font = cellStyle.Font
        End If

        If Not Me.Enabled Then
            Me.Color = Color.Gray
        ElseIf Me.Color.IsEmpty Then
            Me.Color = cellStyle.ForeColor
        End If

        Dim state As CheckBoxState

        'Dim val As Boolean = Me.Value '= Nothing Or Not Convert.ToBoolean(Me.Value) ? False : Convert.ToBoolean(Me.Value)

        'If Me.Enabled And val Then
        state = CheckBoxState.UncheckedHot

        'ElseIf Me.Enabled And Not val Then
        '    state = CheckBoxState.UncheckedDisabled

        'End If

        Dim contentBounds As Rectangle = Me.GetContentBounds(rowIndex)

        Dim loc As Point = New Point(cellBounds.X + 2, cellBounds.Y + contentBounds.Top)
        CheckBoxRenderer.DrawCheckBox(graphics, loc, state)


        Dim stringLocation As Point = New Point()
        stringLocation.Y = cellBounds.Y + contentBounds.Top
        stringLocation.X = cellBounds.X + contentBounds.Right + 2
        graphics.DrawString(Me.Label, cellStyle.Font, New SolidBrush(Me.Color), stringLocation)
        ' Dim symbol = Globalization.NumberFormatInfo.CurrentInfo.CurrencySymbol
        ' Dim _text = symbol '+ " " + Me.Text
        'graphics.DrawString(_text, Me.Font, New SolidBrush(Me.Color), stringLocation)

        'Dim symbol = Globalization.NumberFormatInfo.CurrentInfo.CurrencySymbol

        'Dim fcolor = If(Selected, cellStyle.SelectionForeColor, cellStyle.ForeColor)
        'Using brush As New SolidBrush(fcolor), format As New StringFormat With {.LineAlignment = StringAlignment.Center}

        '    graphics.DrawString(cellStyle.Font, brush, cellBounds, format)
        'End Using
    End Sub

End Class

