Imports System.ComponentModel

Public Class Form1

#Region "Private members"
    Private _RowErrors As Integer

    Private Property RowErrors() As Integer
        Get
            Return _RowErrors
        End Get
        Set(ByVal value As Integer)
            _RowErrors = value
            Me.LinkLabel_RowErrors.Text = value.ToString & " Errors"
        End Set
    End Property

    Private _ColumnErrors As Integer

    Private Property ColumnErrors() As Integer
        Get
            Return _ColumnErrors
        End Get
        Set(ByVal value As Integer)
            _ColumnErrors = value
            Me.LinkLabel_ColumnErrors.Text = value.ToString & " Errors"
        End Set
    End Property

    Private _QuadrantErrors As Integer
    Private Property QuadrantErrors() As Integer
        Get
            Return _QuadrantErrors
        End Get
        Set(ByVal value As Integer)
            _QuadrantErrors = value
            Me.LinkLabel_QuarterErrors.Text = value.ToString & " Errors"
        End Set
    End Property

#End Region

#Region "Menu handling"
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SaveGridToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveGridToolStripMenuItem.Click

        If Me.SaveFileDialog_HexcellGrid.ShowDialog = Windows.Forms.DialogResult.OK Then
            '\\ A filename was selected
            Call SaveGrid(Me.SaveFileDialog_HexcellGrid.FileName)
        End If
    End Sub

    Private Sub LoadGridToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LoadGridToolStripMenuItem.Click

        If Me.OpenFileDialog_HexcellGrid.ShowDialog = Windows.Forms.DialogResult.OK Then
            '\\ A file was selected to load
            Call LoadGrid(Me.OpenFileDialog_HexcellGrid.FileName)
        End If

    End Sub

#End Region

#Region "Grid control events"
    Private Sub HexGrid1_SelectedCellChanged(ByVal Sender As Object, ByVal e As CellSelectedEventArgs) Handles HexGrid1.SelectedCellChanged

        With e.SelectedCell
            Me.LinkLabel_Column.Text = .Column.ToString
            Me.LinkLabel_Row.Text = .Row.ToString
        End With
        Me.HexGridCellCtrl1.CellValue = e.SelectedCell.CellValue

        '\\ Re-calculate the feedback cells
        Call RefreshFeedback()

    End Sub
#End Region

    Private Sub HexGridCellCtrl1_ValueChanged(ByVal Sender As Object, ByVal e As HexGridValueChangedEventArgs) Handles HexGridCellCtrl1.ValueChanged

        Me.HexGrid1.SelectedCell.CellValue = e.Value
        Me.Refresh()

        If HexGrid1.SelectedCell.SingleValueSelected Then
            Call RefreshFeedback()
        End If

    End Sub

#Region "Hex Cell Context Menu"

    Private Sub ToolStripContextMenuItem_Cell1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripContextMenuItem_Cell1.Click
        Me.HexGridCellCtrl1.CellValue = CInt(HexGridCellCtrl.CellPossibleValues.CellValue_0)
    End Sub

    Private Sub ToolStripContextMenuItem_Cell2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripContextMenuItem_Cell2.Click
        Me.HexGridCellCtrl1.CellValue = CInt(HexGridCellCtrl.CellPossibleValues.CellValue_1)
    End Sub

    Private Sub ToolStripContextMenuItem_Cell3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripContextMenuItem_Cell3.Click
        Me.HexGridCellCtrl1.CellValue = CInt(HexGridCellCtrl.CellPossibleValues.CellValue_2)
    End Sub
    Private Sub ToolStripContextMenuItem_Cell4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripContextMenuItem_Cell4.Click
        Me.HexGridCellCtrl1.CellValue = CInt(HexGridCellCtrl.CellPossibleValues.CellValue_3)
    End Sub
    Private Sub ToolStripContextMenuItem_Cell5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripContextMenuItem_Cell5.Click
        Me.HexGridCellCtrl1.CellValue = CInt(HexGridCellCtrl.CellPossibleValues.CellValue_4)
    End Sub
    Private Sub ToolStripContextMenuItem_Cell6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripContextMenuItem_Cell6.Click
        Me.HexGridCellCtrl1.CellValue = CInt(HexGridCellCtrl.CellPossibleValues.CellValue_5)
    End Sub
    Private Sub ToolStripContextMenuItem_Cell7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripContextMenuItem_Cell7.Click
        Me.HexGridCellCtrl1.CellValue = CInt(HexGridCellCtrl.CellPossibleValues.CellValue_6)
    End Sub
    Private Sub ToolStripContextMenuItem_Cell8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripContextMenuItem_Cell8.Click
        Me.HexGridCellCtrl1.CellValue = CInt(HexGridCellCtrl.CellPossibleValues.CellValue_7)
    End Sub
    Private Sub ToolStripContextMenuItem_Cell9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripContextMenuItem_Cell9.Click
        Me.HexGridCellCtrl1.CellValue = CInt(HexGridCellCtrl.CellPossibleValues.CellValue_8)
    End Sub
    Private Sub ToolStripContextMenuItem_Cell10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripContextMenuItem_Cell10.Click
        Me.HexGridCellCtrl1.CellValue = CInt(HexGridCellCtrl.CellPossibleValues.CellValue_9)
    End Sub
    Private Sub ToolStripContextMenuItem_Cell11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripContextMenuItem_Cell11.Click
        Me.HexGridCellCtrl1.CellValue = CInt(HexGridCellCtrl.CellPossibleValues.CellValue_A)
    End Sub
    Private Sub ToolStripContextMenuItem_Cell12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripContextMenuItem_Cell12.Click
        Me.HexGridCellCtrl1.CellValue = CInt(HexGridCellCtrl.CellPossibleValues.CellValue_B)
    End Sub
    Private Sub ToolStripContextMenuItem_Cell13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripContextMenuItem_Cell13.Click
        Me.HexGridCellCtrl1.CellValue = CInt(HexGridCellCtrl.CellPossibleValues.CellValue_C)
    End Sub
    Private Sub ToolStripContextMenuItem_Cell14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripContextMenuItem_Cell14.Click
        Me.HexGridCellCtrl1.CellValue = CInt(HexGridCellCtrl.CellPossibleValues.CellValue_D)
    End Sub
    Private Sub ToolStripContextMenuItem_Cell15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripContextMenuItem_Cell15.Click
        Me.HexGridCellCtrl1.CellValue = CInt(HexGridCellCtrl.CellPossibleValues.CellValue_E)
    End Sub
    Private Sub ToolStripContextMenuItem_Cell16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripContextMenuItem_Cell16.Click
        Me.HexGridCellCtrl1.CellValue = CInt(HexGridCellCtrl.CellPossibleValues.CellValue_F)
    End Sub

    Private Sub ResetCellToolStripContextMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ResetCellToolStripContextMenuItem.Click
        Me.HexGridCellCtrl1.CellValue = HexGridCellCtrl.AllPossibleValues
    End Sub

#End Region

#Region "Background worker events"

    Private Sub BackgroundWorker_ValidateColumns_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker_ValidateColumns.ProgressChanged
        '\\ Update the progress bar
        Me.ToolStripProgressBar_Columns.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker_ValidateQuarters_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker_ValidateQuarters.ProgressChanged
        '\\ Update the progress bar
        Me.ToolStripProgressBar_Quarters.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker_ValidateRows_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker_ValidateRows.ProgressChanged
        '\\ Update the progress bar
        Me.ToolStripProgressBar_Rows.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker_ValidateColumns_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_ValidateColumns.DoWork
        'todo: Validate the columns ...
        Dim bw As BackgroundWorker = CType(sender, BackgroundWorker)

        ' Extract the argument.
        Dim arg As Integer = CType(e.Argument, Integer)

        ' Start the column validation
        'e.Result = '''

        ' If the operation was canceled by the user, 
        ' set the DoWorkEventArgs.Cancel property to true.
        If bw.CancellationPending Then
            e.Cancel = True
        End If

    End Sub

    Private Sub BackgroundWorker_ValidateQuarters_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_ValidateQuarters.DoWork
        'todo: validate the quarters...
    End Sub

    Private Sub BackgroundWorker_ValidateRows_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_ValidateRows.DoWork
        'todo: validate the rows...
    End Sub

    Private Sub BackgroundWorker_ValidateColumns_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker_ValidateColumns.RunWorkerCompleted
        '\\ Update with the number of errors found
        If Not e.Cancelled Then
            Me.LinkLabel_ColumnErrors.Text = CType(e.Result, Integer).ToString & " Errors"
        End If
    End Sub

    Private Sub BackgroundWorker_ValidateQuarters_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker_ValidateQuarters.RunWorkerCompleted
        '\\ Update with the number of errors found
        If Not e.Cancelled Then
            Me.LinkLabel_QuarterErrors.Text = CType(e.Result, Integer).ToString & " Errors"
        End If
    End Sub

    Private Sub BackgroundWorker_ValidateRows_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker_ValidateRows.RunWorkerCompleted
        '\\ Update with the number of errors found
        If Not e.Cancelled Then
            Me.LinkLabel_RowErrors.Text = CType(e.Result, Integer).ToString & " Errors"
        End If
    End Sub

#End Region

#Region "Private methods"
    ''' <summary>
    ''' Restarts the process of checking through the grid to see if any cells are in error 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RestartGridChecking()

        Me.LinkLabel_ColumnErrors.Text = "0 Errors"
        Me.LinkLabel_QuarterErrors.Text = "0 Errors"
        Me.LinkLabel_RowErrors.Text = "0 Errors"

        '\\ Kick off the background thread workers
        If Me.BackgroundWorker_ValidateColumns.IsBusy Then
            Me.BackgroundWorker_ValidateColumns.CancelAsync()
        End If
        If Me.BackgroundWorker_ValidateRows.IsBusy Then
            Me.BackgroundWorker_ValidateRows.CancelAsync()
        End If
        If Me.BackgroundWorker_ValidateQuarters.IsBusy Then
            Me.BackgroundWorker_ValidateQuarters.CancelAsync()
        End If

        Me.BackgroundWorker_ValidateColumns.RunWorkerAsync()
        Me.BackgroundWorker_ValidateQuarters.RunWorkerAsync()
        Me.BackgroundWorker_ValidateRows.RunWorkerAsync()

    End Sub

    ''' <summary>
    ''' Refresh the three feedback cells to show the current state of the grid column, row and quadrant
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RefreshFeedback()

        ColumnErrors = 0
        Me.HexGridCellCtrl_ColumnFeedback.CellValue = HexGridCellCtrl.AllPossibleValues
        For Each c As HexGridCellCtrl In HexGrid1.Column(HexGrid1.SelectedCellLocation.X)
            If c.SingleValueSelected Then
                If HexGridCellCtrl_ColumnFeedback.IsValuePossible(CType(c.CellValue, HexGridCellCtrl.CellPossibleValues)) Then
                    Me.HexGridCellCtrl_ColumnFeedback.UnsetValue(CType(c.CellValue, HexGridCellCtrl.CellPossibleValues))
                Else
                    '\\ There are two of the same colour in this quadrant...
                    ColumnErrors += 1
                End If
            End If
        Next

        RowErrors = 0
        Me.HexGridCellCtrl_RowFeedback.CellValue = HexGridCellCtrl.AllPossibleValues
        For Each c As HexGridCellCtrl In HexGrid1.Row(HexGrid1.SelectedCellLocation.Y)
            If c.SingleValueSelected Then
                If HexGridCellCtrl_RowFeedback.IsValuePossible(CType(c.CellValue, HexGridCellCtrl.CellPossibleValues)) Then
                    Me.HexGridCellCtrl_RowFeedback.UnsetValue(CType(c.CellValue, HexGridCellCtrl.CellPossibleValues))
                Else
                    '\\ There are two of the same colour in this quadrant...
                    RowErrors += 1
                End If
            End If
        Next

        QuadrantErrors = 0
        Me.HexGridCellCtrl_QuadrantFeedback.CellValue = HexGridCellCtrl.AllPossibleValues
        For Each c As HexGridCellCtrl In HexGrid1.Quadrant(1 + ((HexGrid1.SelectedCellLocation.Y - 1) \ 4), 1 + ((HexGrid1.SelectedCellLocation.X - 1) \ 4))
            If c.SingleValueSelected Then
                If HexGridCellCtrl_QuadrantFeedback.IsValuePossible(CType(c.CellValue, HexGridCellCtrl.CellPossibleValues)) Then
                    Me.HexGridCellCtrl_QuadrantFeedback.UnsetValue(CType(c.CellValue, HexGridCellCtrl.CellPossibleValues))
                Else
                    '\\ There are two of the same colour in this quadrant...
                    QuadrantErrors += 1
                End If
            End If
        Next
    End Sub

    Private Sub SaveGrid(ByVal Filename As String)

        Dim fs As New System.IO.FileStream(Filename, System.IO.FileMode.Create)
        Dim writer As New System.Xml.XmlTextWriter(fs, New System.Text.UTF8Encoding())
        With writer
            .WriteStartDocument()
            .WriteComment("HexGrid cell collection - Serialised " & Date.Now.ToShortDateString)
            .WriteStartElement("GridValues")
            For nRow As Integer = 1 To 16
                For ncolumn As Integer = 1 To 16
                    .WriteStartElement("GridCell")
                    .WriteAttributeString("Column", ncolumn.ToString)
                    .WriteAttributeString("Row", nRow.ToString)
                    .WriteAttributeString("Value", Me.HexGrid1.CellValue(nRow, ncolumn).ToString)
                    .WriteEndElement() 'GridCell
                Next
            Next
            .WriteEndElement() 'GridValues
            .WriteComment("(c) 2006 - Merrion Computing Ltd")
        End With
        writer.Close()

    End Sub

    Private Sub LoadGrid(ByVal Filename As String)

        Dim fs As New System.IO.FileStream(Filename, System.IO.FileMode.Open)
        Dim reader As New System.Xml.XmlTextReader(fs)
        With reader
            .ReadStartElement("GridValues")
            For nrow As Integer = 1 To 16
                For ncolumn As Integer = 1 To 16
                    Dim value As Integer = Integer.Parse(.GetAttribute("Value"))
                    Me.HexGrid1.CellValue(nrow, ncolumn) = value
                    .ReadStartElement("GridCell")
                Next
            Next
            .ReadEndElement()
        End With
        reader.Close()
        Me.HexGrid1.Refresh()

    End Sub
#End Region

End Class
