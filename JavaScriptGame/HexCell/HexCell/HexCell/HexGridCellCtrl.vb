Imports System.ComponentModel
Public Class HexGridCellCtrl

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
    Private _CellValue As Integer = AllPossibleValues()
    Private _Column As Int16
    Private _Row As Int16
    Private _Locked As Boolean

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
    ''' Returns an integer which defines the remaining possible colour(s) in this cell
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Individual <see cref="CellPossibleValues">possible values</see> are combined with 
    ''' a boolean OR operation to generate this value
    ''' </remarks>
    Public Property CellValue() As Integer
        Get
            Return _CellValue
        End Get
        Set(ByVal value As Integer)
            If _CellValue <> value And Not _Locked Then
                _CellValue = value
                RaiseEvent ValueChanged(Me, New HexCell.HexGridValueChangedEventArgs(_CellValue))
                Me.Refresh()
            End If
        End Set
    End Property

    ''' <summary>
    ''' Returns true if only one of the 16 possible values is left
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SingleValueSelected() As Boolean
        Get
            Return (_CellValue = CellPossibleValues.CellValue_0) OrElse (_CellValue = CellPossibleValues.CellValue_1) _
                OrElse (_CellValue = CellPossibleValues.CellValue_2) OrElse (_CellValue = CellPossibleValues.CellValue_3) _
                OrElse (_CellValue = CellPossibleValues.CellValue_4) OrElse (_CellValue = CellPossibleValues.CellValue_5) _
                OrElse (_CellValue = CellPossibleValues.CellValue_6) OrElse (_CellValue = CellPossibleValues.CellValue_7) _
                OrElse (_CellValue = CellPossibleValues.CellValue_8) OrElse (_CellValue = CellPossibleValues.CellValue_9) _
                OrElse (_CellValue = CellPossibleValues.CellValue_A) OrElse (_CellValue = CellPossibleValues.CellValue_B) _
                OrElse (_CellValue = CellPossibleValues.CellValue_C) OrElse (_CellValue = CellPossibleValues.CellValue_D) _
                OrElse (_CellValue = CellPossibleValues.CellValue_E) OrElse (_CellValue = CellPossibleValues.CellValue_F)
        End Get
    End Property

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

                If SingleValueSelected Then
                    rcItem = rcBounds
                Else
                    rcItem = New Rectangle(rcBounds.Left + (_Column * _WidthFactor), rcBounds.Top + (_Row * _HeightFactor), _WidthFactor, _HeightFactor)
                End If
                g.DrawRectangle(Pens.DimGray, rcItem)

                'If the value n is not possible, mark it with an x...
                rcItem.Inflate(-1, -1)
                If .Item(n) Then
                    g.FillEllipse(_ValueBrushes(n - 1), rcItem)
                End If
            Next
        End With

    End Sub

    ''' <summary>
    ''' Returns true if the colour is one of the remaining possible colours
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsValuePossible(ByVal Value As CellPossibleValues) As Boolean

        If (_CellValue And Value) > 0 Then
            Return True
        End If

    End Function

    ''' <summary>
    ''' Whether this value can be changed by the user
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Locked() As Boolean
        Get
            Return _Locked
        End Get
        Set(ByVal value As Boolean)
            _Locked = value
        End Set
    End Property

#Region "Methods"
    ''' <summary>
    ''' Adds the value to the possible values for this cell
    ''' </summary>
    ''' <param name="value"></param>
    ''' <remarks></remarks>
    Public Sub SetValue(ByVal value As CellPossibleValues)
        CellValue = _CellValue Or value
    End Sub

    ''' <summary>
    ''' Removes the value from the possible colour values held by this hex cell
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <remarks></remarks>
    Public Sub UnsetValue(ByVal Value As CellPossibleValues)
        CellValue = _CellValue And (&HFFFF - Value)
    End Sub
#End Region

#Region "Events"
    Public Delegate Sub HexGridCellValueChangedEvent(ByVal Sender As Object, ByVal e As HexGridValueChangedEventArgs)

    Public Event ValueChanged As HexGridCellValueChangedEvent

#End Region

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

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
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
        _ValueBrushes(12) = Brushes.Khaki
        _ValueBrushes(13) = Brushes.DarkBlue
        _ValueBrushes(14) = Brushes.LightBlue
        _ValueBrushes(15) = Brushes.LightSalmon

    End Sub

    ''' <summary>
    ''' Creates a new empty cell at the position specified
    ''' </summary>
    ''' <param name="RowIn">The row that this cell is in</param>
    ''' <param name="ColumnIn">The column that this cell is in</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal RowIn As Int16, ByVal ColumnIn As Int16)

        Me.New()

        If RowIn < 1 OrElse RowIn > 16 Then
            Throw New ArgumentException("Row must be between 1 and 16", "RowIn")
        End If

        If ColumnIn < 1 OrElse ColumnIn > 16 Then
            Throw New ArgumentException("Column must be between 1 and 16", "ColumnIn")
        End If

        _Row = RowIn
        _Column = ColumnIn

    End Sub
#End Region

#Region "Custom drawing code"
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        Drawcell(e.Graphics, Me.ClientRectangle)

    End Sub
#End Region

#Region "Mouse events"
    Protected Overrides Sub OnMouseClick(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseClick(e)

        If Not SingleValueSelected And Not Locked Then
            '\\ If over a hex cell item, raise the cell item clicked event
            Dim _column As Integer, _row As Integer, _index As Integer

            _column = (1 + CInt(e.X \ CInt(Me.Width / 4)))
            _row = (1 + CInt(e.Y \ CInt(Me.Height / 4)))

            _index = (((_row - 1) * 4) + _column) - 1

            '\\ Convert the position into the appropriate possible value flag for that position
            Dim value As CellPossibleValues = CType((2 ^ _index), CellPossibleValues)

            My.Application.Log.WriteEntry("Column : " & _column.ToString & ", Row : " & _row.ToString & " Value:" & value.ToString)

            If e.Button = Windows.Forms.MouseButtons.Left Then
                If IsValuePossible(value) Then
                    If _CellValue = value Then
                        Beep()
                        Exit Sub
                    End If
                    UnsetValue(value)
                Else
                    SetValue(value)
                End If
                Me.Refresh()
            End If
        End If

    End Sub
#End Region

End Class

''' <summary>
''' Event argument for when a mouse click occurs on one of the coloured counters.
''' </summary>
''' <remarks>
''' </remarks>
Public Class HexGridValueChangedEventArgs
    Inherits EventArgs

#Region "Private members"
    Private _Value As Integer
#End Region

#Region "Public interface"
    ''' <summary>
    ''' Which of the possible values it was clicked over
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Value() As Integer
        Get
            Return _Value
        End Get
    End Property
#End Region

#Region "Public constructor"
    Public Sub New(ByVal ValueIn As Integer)

        _Value = ValueIn
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
    Public Shared Function ToBooleanList(ByVal PossibleValues As Integer) As Generic.Dictionary(Of Integer, Boolean)

        Dim Ret As New Dictionary(Of Integer, Boolean)
        For n As Integer = 1 To 16
            Ret.Add(n, (PossibleValues And CInt(2 ^ (n - 1))) > 0)
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
    Private _Cells As New Generic.List(Of HexGridCellCtrl)
#End Region

#Region "Public interface"
    Public ReadOnly Property Cell(ByVal Row As Integer, ByVal Column As Integer) As HexGridCellCtrl
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
                _Cells.Add(New HexGridCellCtrl(_Row, _Column))
            Next
        Next
    End Sub
#End Region

#Region "Private methods"

    Private Function GridPositionToListIndex(ByVal Row As Integer, ByVal Column As Integer) As Integer
        Return ((Row - 1) * 16) + (Column - 1)
    End Function

#End Region

End Class
