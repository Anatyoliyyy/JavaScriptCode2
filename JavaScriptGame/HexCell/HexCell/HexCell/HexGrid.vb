Imports System.ComponentModel

Public Class HexGrid

#Region "Private Properties"
    Private _GridMajorPenColour As Color = Color.Aquamarine
    Private _GridMinorPenColour As Color = Color.LightBlue

    '\\ Pens to use to draw the grid lines
    Private _GridmajorPen As Pen = Pens.Aquamarine
    Private _GridMinorPen As Pen = Pens.LightBlue

    '\\ Size of the grid steps
    Private _WidthStep As Integer = 1
    Private _HeightStep As Integer = 1

    Private _HexGridCellCollection As New HexGridCellCollection
    Private _TextFont As New Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular)

    Private _SelectedRow As Integer
    Private _SelectedColumn As Integer

    Private _CellHighlightPenColour As Color = Color.Firebrick
    Private _CellHighlightPen As Pen = Pens.Firebrick

#End Region

#Region "Public interface"

    <Category("Appearance"), _
     Description("The colour of the quarter grid lines")> _
    Public Property GridMajorLineColour() As Color
        Get
            Return _GridMajorPenColour
        End Get
        Set(ByVal value As Color)
            _GridMajorPenColour = value
            _GridmajorPen = New Pen(_GridMajorPenColour, 3)
            Me.Refresh()
        End Set
    End Property

    <Category("Appearance"), _
     Description("The colour of the cell grid lines")> _
    Public Property GridMinorLineColour() As Color
        Get
            Return _GridMinorPenColour
        End Get
        Set(ByVal value As Color)
            _GridMinorPenColour = value
            _GridMinorPen = New Pen(_GridMinorPenColour, 1)
            Me.Refresh()
        End Set
    End Property

    <Category("Appearance"), _
 Description("The colour of the quarter grid lines")> _
 Public Property SelectedCellColour() As Color
        Get
            Return _CellHighlightPenColour
        End Get
        Set(ByVal value As Color)
            If _CellHighlightPenColour <> value Then
                _CellHighlightPenColour = value
                _CellHighlightPen = New Pen(value)
                Me.Refresh()
            End If
        End Set
    End Property

    Public Property SelectedCellLocation() As Point
        Get
            Return New Point(_SelectedColumn, _SelectedRow)
        End Get
        Set(ByVal value As Point)
            If value.X <> _SelectedColumn OrElse value.Y <> _SelectedRow Then
                SelectedColumn = value.X
                SelectedRow = value.Y
                'Raise a selection changed event
                RaiseEvent SelectedCellChanged(Me, New CellSelectedEventArgs(_HexGridCellCollection.Cell(_SelectedRow, _SelectedColumn)))
                Me.Refresh()
            End If
        End Set
    End Property

    ''' <summary>
    ''' The currently selected cell in the grid
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SelectedCell() As HexGridCellCtrl
        Get
            Return _HexGridCellCollection.Cell(_SelectedRow, _SelectedColumn)
        End Get
    End Property

    <Category("Data"), _
    Description("The currently selected row")> _
    Private Property SelectedRow() As Integer
        Get
            Return _SelectedRow
        End Get
        Set(ByVal value As Integer)
            If value < 1 OrElse value > 16 Then
                Throw New ArgumentException("Value must be between 1 - 16", "SelectedRow")
            End If
            If _SelectedRow <> value Then
                _SelectedRow = value
            End If
        End Set
    End Property

    <Category("Data"), _
Description("The currently selected column")> _
Private Property SelectedColumn() As Integer
        Get
            Return _SelectedColumn
        End Get
        Set(ByVal value As Integer)
            If value < 1 OrElse value > 16 Then
                Throw New ArgumentException("Value must be between 1 - 16", "SelectedColumn")
            End If
            If _SelectedColumn <> value Then
                _SelectedColumn = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' Returns all the grid cells in the selected row
    ''' </summary>
    ''' <param name="RowIndex">The index of the row (1-16) to get</param>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Row(ByVal RowIndex As Integer) As Generic.List(Of HexGridCellCtrl)
        Get
            If RowIndex < 1 OrElse RowIndex > 16 Then
                Throw New ArgumentException("Invalid row (1-16)", "RowIndex")
            End If
            Dim lstRet As New Generic.List(Of HexGridCellCtrl)
            For ncolumn As Integer = 1 To 16
                lstRet.Add(_HexGridCellCollection.Cell(RowIndex, ncolumn))
            Next
            Return lstRet
        End Get
    End Property

    ''' <summary>
    ''' Returns all the grid cells in the selected column
    ''' </summary>
    ''' <param name="ColumnIndex">The index of the column (1-16) to get</param>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Column(ByVal ColumnIndex As Integer) As Generic.List(Of HexGridCellCtrl)
        Get
            If ColumnIndex < 1 OrElse ColumnIndex > 16 Then
                Throw New ArgumentException("Invalid column (1-16)", "ColumnIndex")
            End If
            Dim lstRet As New Generic.List(Of HexGridCellCtrl)
            For nRow As Integer = 1 To 16
                lstRet.Add(_HexGridCellCollection.Cell(nRow, ColumnIndex))
            Next
            Return lstRet
        End Get
    End Property

    ''' <summary>
    ''' Returns the selected quadrant (4 x 4 cells)
    ''' </summary>
    ''' <param name="QuadrantRow">The row (1-4) of the quadrant</param>
    ''' <param name="QuadrantColumn">The column (1-4) of the quadrant</param>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Quadrant(ByVal QuadrantRow As Integer, ByVal QuadrantColumn As Integer) As Generic.List(Of HexGridCellCtrl)
        Get
            If QuadrantRow < 1 OrElse QuadrantRow > 4 Then
                Throw New ArgumentException("Invalid row (1-4)", "QuadrantRow")
            End If
            If QuadrantColumn < 1 OrElse QuadrantColumn > 4 Then
                Throw New ArgumentException("Invalid column (1-4)", "QuadrantColumn")
            End If
            Dim lstRet As New Generic.List(Of HexGridCellCtrl)
            For nRow As Integer = ((QuadrantRow - 1) * 4) + 1 To ((QuadrantRow - 1) * 4) + 4
                For nColumn As Integer = ((QuadrantColumn - 1) * 4) + 1 To ((QuadrantColumn - 1) * 4) + 4
                    lstRet.Add(_HexGridCellCollection.Cell(nRow, nColumn))
                Next
            Next
            Return lstRet
        End Get
    End Property

    ''' <summary>
    ''' The value of the cell at the given location
    ''' </summary>
    ''' <param name="Row"></param>
    ''' <param name="Column"></param>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CellValue(ByVal Row As Integer, ByVal Column As Integer) As Integer
        Get
            Return _HexGridCellCollection.Cell(Row, Column).CellValue
        End Get
        Set(ByVal value As Integer)
            _HexGridCellCollection.Cell(Row, Column).CellValue = value
        End Set

    End Property

#Region "Events"
    Public Delegate Sub CellSelectedEvent(ByVal Sender As Object, ByVal e As CellSelectedEventArgs)

    Public Event SelectedCellChanged As CellSelectedEvent

#End Region
#Region "Methods"
    ''' <summary>
    ''' Clears the grid cell collection to an empty (unsolved) grid
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ResetGridCellCollection()
        _HexGridCellCollection = New HexGridCellCollection
        Me.Refresh()
    End Sub
#End Region
#End Region

#Region "Custom control drawing code"
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        e.Graphics.Clear(Color.LightBlue)
        e.Graphics.FillRectangle(Brushes.White, GridCellLocationRectangle(_SelectedRow, _SelectedColumn))

        '\\ Draw the cell grid
        Dim rcnext As Rectangle
        For _column As Integer = 1 To 16
            For _row As Integer = 1 To 16
                rcnext = GridCellLocationRectangle(_row, _column)
                e.Graphics.DrawRectangle(_GridMinorPen, rcnext)
                _HexGridCellCollection.Cell(_row, _column).Drawcell(e.Graphics, rcnext)
            Next
        Next

        '\\ Draw the quarter lines
        For _quartercolumn As Integer = 1 To 4
            For _quarterrow As Integer = 1 To 4
                rcnext = GridQuarterRectangle(_quarterrow, _quartercolumn)
                e.Graphics.DrawRectangle(_GridmajorPen, rcnext)
            Next
        Next

        '\\ Draw the selected row and column...
        e.Graphics.DrawRectangle(_CellHighlightPen, GridCellLocationRectangle(_SelectedRow, _SelectedColumn))

    End Sub

    ''' <summary>
    ''' Returns a rectangle representing the boundary of a given grid cell position
    ''' </summary>
    ''' <param name="Row"></param>
    ''' <param name="Column"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GridCellLocationRectangle(ByVal Row As Integer, ByVal Column As Integer) As Rectangle

        Return New Rectangle((Column - 1) * _WidthStep, (Row - 1) * _HeightStep, _WidthStep, _HeightStep)

    End Function

    Private Function GridQuarterRectangle(ByVal Row As Integer, ByVal Column As Integer) As Rectangle

        Return New Rectangle((Column - 1) * (_WidthStep * 4), (Row - 1) * (_HeightStep * 4), (_WidthStep * 4), (_HeightStep * 4))

    End Function

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)

        _WidthStep = CInt(Me.Width / 16)
        _HeightStep = CInt(Me.Height / 16)

        Me.Refresh()

    End Sub
#End Region

#Region "Mouse events"
    Protected Overrides Sub OnMouseClick(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseClick(e)

        Me.SelectedCellLocation = New Point(1 + CInt(e.X \ _WidthStep), 1 + CInt(e.Y \ _HeightStep))

    End Sub
#End Region

End Class

''' <summary>
''' Event argument extra data for the cell selected event
''' </summary>
''' <remarks></remarks>
Public Class CellSelectedEventArgs
    Inherits EventArgs

#Region "Private memebers"
    Private _Cell As HexGridCellCtrl
#End Region

#Region "Public interface"
    Public ReadOnly Property SelectedCell() As HexGridCellCtrl
        Get
            Return _Cell
        End Get
    End Property
#End Region

#Region "Public cosntructors"
    Public Sub New(ByVal GridCell As HexGridCellCtrl)
        _Cell = GridCell
    End Sub
#End Region

End Class