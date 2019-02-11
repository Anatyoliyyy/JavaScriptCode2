''' <summary>
''' Represents a single cell in a HexCell grid, with the current possible values it holds....
''' </summary>
''' <remarks>
''' Internally the possible values are held using bit flags so that the comparisons can be done using
''' boolean operations
''' </remarks>
Public Class HexGridCell2

#Region "Public enumerations"
    <Flags()> _
    Public Enum CellPossibleValues
        CellValue_0 = &H1 'Cell could contain the digit '0'
        CellValue_1 = &H2
        CellValue_2 = &H4
        CellValue_3 = &H8
        CellValue_4 = &H10
        CellValue_5 = &H20
        CellValue_6 = &H40
        CellValue_7 = &H80
        CellValue_8 = &H100
        CellValue_9 = &H200
        CellValue_A = &H400
        CellValue_B = &H800
        CellValue_C = &H1000
        CellValue_D = &H2000
        CellValue_E = &H4000
        CellValue_F = &H8000 'Cell could contain the digit 'F'
    End Enum
#End Region

#Region "Private members"
    Private _CellValue As CellPossibleValues = AllPossibleValues()
    Private _Column As Int16
    Private _Row As Int16

    Private _ValueBrushes(15) As Brush
#End Region

#Region "Public interface"

    ''' <summary>
    ''' The column (1-16) that contains this cell
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>This value is read left to right
    ''' </remarks>
    Public ReadOnly Property Column() As Int16
        Get
            Return _Column
        End Get
    End Property

    ''' <summary>
    ''' The row (1-16) that contains this cell
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>This value is read from top to bottom
    ''' </remarks>
    Public ReadOnly Property Row() As Int16
        Get
            Return _Row
        End Get
    End Property

    ''' <summary>
    ''' Removes a cell value from the set of possibilities for this grid cell
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <remarks></remarks>
    Public Sub EliminatePossibleValue(ByVal Value As CellPossibleValues)
        _CellValue = _CellValue And Not (Value)
    End Sub

    ''' <summary>
    ''' Sets this cell to only contain one possible value....
    ''' </summary>
    ''' <param name="Value">The particluar value to set this cell to</param>
    ''' <remarks>
    ''' Although this can be set to multiple possibilities (i.e. CellValue_2 OR CellValue_6 ) to do so is 
    ''' confusing to the human operator.  Use <see cref="EliminatePossiblevalue">EliminatePossiblevalue</see> to 
    ''' narrow down the possible values in the cell
    ''' </remarks>
    Public Sub SetToValue(ByVal Value As CellPossibleValues)
        _CellValue = Value
    End Sub

    ''' <summary>
    ''' Returns row,column
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Return _Row.ToString & "," & _Column.ToString
    End Function

    ''' <summary>
    ''' Draws this cell onto the graphics object passed in, with a 4x4 grid of possible values
    ''' </summary>
    ''' <param name="g"></param>
    ''' <param name="rcBounds"></param>
    ''' <remarks></remarks>
    Public Sub Drawcell(ByVal g As Graphics, ByVal rcBounds As Rectangle)

        Dim _WidthFactor As Integer = CInt(rcBounds.Width / 4)
        Dim _HeightFactor As Integer = CInt(rcBounds.Height / 4)

        Dim _Row As Integer
        Dim _Column As Integer

        With HexGridCellPossibleValuesDecoder.ToBooleanList(_CellValue)
            Dim rcItem As Rectangle
            For n As Integer = 1 To 16
                _Column = ((n - 1) Mod 4)
                _Row = (n - 1) \ 4
                rcItem = New Rectangle(rcBounds.Left + (_Column * _WidthFactor), rcBounds.Top + (_Row * _HeightFactor), _WidthFactor, _HeightFactor)
                g.DrawRectangle(Pens.DimGray, rcItem)

                'If the value n is not possible, mark it with an x...
                rcItem.Inflate(-1, -1)
                If Not .Item(n) Then
                    g.DrawLine(Pens.DimGray, rcItem.Left, rcItem.Top, rcItem.Right, rcItem.Bottom)
                    g.DrawLine(Pens.DimGray, rcItem.Right, rcItem.Top, rcItem.Left, rcItem.Bottom)
                Else
                    g.FillEllipse(_ValueBrushes(n - 1), rcItem)
                End If
            Next
        End With

    End Sub
#End Region

#Region "Shared Interface"
    ''' <summary>
    ''' Returns a value indicating that the cell can hold all possible values
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function AllPossibleValues() As CellPossibleValues
        Return CellPossibleValues.CellValue_0 Or CellPossibleValues.CellValue_1 _
            Or CellPossibleValues.CellValue_2 Or CellPossibleValues.CellValue_3 _
            Or CellPossibleValues.CellValue_4 Or CellPossibleValues.CellValue_5 _
            Or CellPossibleValues.CellValue_6 Or CellPossibleValues.CellValue_7 _
            Or CellPossibleValues.CellValue_8 Or CellPossibleValues.CellValue_9 _
            Or CellPossibleValues.CellValue_A Or CellPossibleValues.CellValue_B _
            Or CellPossibleValues.CellValue_C Or CellPossibleValues.CellValue_D _
            Or CellPossibleValues.CellValue_E Or CellPossibleValues.CellValue_F
    End Function
#End Region

#Region "Public constructor"
    ''' <summary>
    ''' Creates a new empty cell at the position specified
    ''' </summary>
    ''' <param name="RowIn">The row that this cell is in</param>
    ''' <param name="ColumnIn">The column that this cell is in</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal RowIn As Int16, ByVal ColumnIn As Int16)
        If RowIn < 1 OrElse RowIn > 16 Then
            Throw New ArgumentException("Row must be between 1 and 16", "RowIn")
        End If

        If ColumnIn < 1 OrElse ColumnIn > 16 Then
            Throw New ArgumentException("Column must be between 1 and 16", "ColumnIn")
        End If

        _Row = RowIn
        _Column = ColumnIn

        _ValueBrushes(0) = Brushes.Aqua
        _ValueBrushes(1) = Brushes.Coral
        _ValueBrushes(2) = Brushes.Crimson
        _ValueBrushes(3) = Brushes.DarkKhaki
        _ValueBrushes(4) = Brushes.Firebrick
        _ValueBrushes(5) = Brushes.DarkGreen
        _ValueBrushes(6) = Brushes.Blue
        _ValueBrushes(7) = Brushes.Fuchsia
        _ValueBrushes(8) = Brushes.Green
        _ValueBrushes(9) = Brushes.Yellow
        _ValueBrushes(10) = Brushes.HotPink
        _ValueBrushes(11) = Brushes.Gold
        _ValueBrushes(12) = Brushes.Lavender
        _ValueBrushes(13) = Brushes.LemonChiffon
        _ValueBrushes(14) = Brushes.LightBlue
        _ValueBrushes(15) = Brushes.LightSalmon

    End Sub
#End Region

End Class

Public Class HexGridCellPossibleValuesDecoder

    ''' <summary>
    ''' Returns a list of integer (0-15) and whether or not they are a possible value in the values passed in
    ''' </summary>
    ''' <param name="Possiblevalues"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ToBooleanList(ByVal PossibleValues As HexGridCell2.CellPossibleValues) As Generic.Dictionary(Of Integer, Boolean)

        Dim Ret As New Dictionary(Of Integer, Boolean)
        For n As Integer = 1 To 16
            Ret.Add(n, (PossibleValues And CInt(n ^ 2)) > 0)
        Next
        Return Ret
    End Function

End Class

''' <summary>
''' Represents the 64 cells that make up a hex grid
''' </summary>
''' <remarks>
''' </remarks>
Public Class HexGridCellCollection

#Region "Private members"
    Private _Cells As New Generic.List(Of HexGridCell2)
#End Region

#Region "Public interface"
    Public ReadOnly Property Cell(ByVal Row As Integer, ByVal Column As Integer) As HexGridCell2
        Get
            If Row < 1 OrElse Row > 16 Then
                Throw New ArgumentOutOfRangeException("Row", "Row must be between 1 and 16")
            End If
            If Column < 1 OrElse Column > 16 Then
                Throw New ArgumentOutOfRangeException("Column", "Column must be between 1 and 16")
            End If
            Return _Cells.Item(GridPositionToListIndex(Row, Column))
        End Get
    End Property
#End Region

#Region "Public constructor"
    ''' <summary>
    ''' Creates a new empty 16x16 grid of HexGridCell objects
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        For _Row As Int16 = 1 To 16
            For _Column As Int16 = 1 To 16
                _Cells.Add(New HexGridCell2(_Row, _Column))
            Next
        Next
    End Sub
#End Region

#Region "Private methods"

    Private Function GridPositionToListIndex(ByVal Row As Integer, ByVal Column As Integer) As Integer
        Return ((Column - 1) * 16) + (Row - 1)
    End Function

#End Region

End Class