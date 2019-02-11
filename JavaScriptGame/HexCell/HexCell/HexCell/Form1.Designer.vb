<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripProgressBar_Rows = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolStripProgressBar_Columns = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolStripProgressBar_Quarters = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolStripStatusLabel_Information = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip_HexCell = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoadGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel_CurrentCell = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.HexGridCellCtrl_QuadrantFeedback = New HexCell.HexGridCellCtrl
        Me.HexGridCellCtrl_ColumnFeedback = New HexCell.HexGridCellCtrl
        Me.HexGridCellCtrl_RowFeedback = New HexCell.HexGridCellCtrl
        Me.LinkLabel_QuarterErrors = New System.Windows.Forms.LinkLabel
        Me.Label5 = New System.Windows.Forms.Label
        Me.LinkLabel_ColumnErrors = New System.Windows.Forms.LinkLabel
        Me.Label4 = New System.Windows.Forms.Label
        Me.LinkLabel_RowErrors = New System.Windows.Forms.LinkLabel
        Me.Label3 = New System.Windows.Forms.Label
        Me.LinkLabel_Column = New System.Windows.Forms.LinkLabel
        Me.LinkLabel_Row = New System.Windows.Forms.LinkLabel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.HexGridCellCtrl1 = New HexCell.HexGridCellCtrl
        Me.ContextMenuStrip_CellGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ResetCellToolStripContextMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SetToToolStripContextMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContextMenuItem_Cell1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContextMenuItem_Cell2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContextMenuItem_Cell3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContextMenuItem_Cell4 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContextMenuItem_Cell5 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContextMenuItem_Cell6 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContextMenuItem_Cell7 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContextMenuItem_Cell8 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContextMenuItem_Cell9 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContextMenuItem_Cell10 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContextMenuItem_Cell11 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContextMenuItem_Cell12 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContextMenuItem_Cell13 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContextMenuItem_Cell14 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContextMenuItem_Cell15 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContextMenuItem_Cell16 = New System.Windows.Forms.ToolStripMenuItem
        Me.BackgroundWorker_ValidateRows = New System.ComponentModel.BackgroundWorker
        Me.BackgroundWorker_ValidateColumns = New System.ComponentModel.BackgroundWorker
        Me.BackgroundWorker_ValidateQuarters = New System.ComponentModel.BackgroundWorker
        Me.HexGrid1 = New HexCell.HexGrid
        Me.SaveFileDialog_HexcellGrid = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog_HexcellGrid = New System.Windows.Forms.OpenFileDialog
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip_HexCell.SuspendLayout()
        Me.Panel_CurrentCell.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip_CellGrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar_Rows, Me.ToolStripProgressBar_Columns, Me.ToolStripProgressBar_Quarters, Me.ToolStripStatusLabel_Information})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 489)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(728, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar_Rows
        '
        Me.ToolStripProgressBar_Rows.Name = "ToolStripProgressBar_Rows"
        Me.ToolStripProgressBar_Rows.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar_Rows.Step = 1
        '
        'ToolStripProgressBar_Columns
        '
        Me.ToolStripProgressBar_Columns.Name = "ToolStripProgressBar_Columns"
        Me.ToolStripProgressBar_Columns.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar_Columns.Step = 1
        '
        'ToolStripProgressBar_Quarters
        '
        Me.ToolStripProgressBar_Quarters.Name = "ToolStripProgressBar_Quarters"
        Me.ToolStripProgressBar_Quarters.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar_Quarters.Step = 1
        '
        'ToolStripStatusLabel_Information
        '
        Me.ToolStripStatusLabel_Information.Name = "ToolStripStatusLabel_Information"
        Me.ToolStripStatusLabel_Information.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel_Information.Text = "Ready"
        '
        'MenuStrip_HexCell
        '
        Me.MenuStrip_HexCell.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip_HexCell.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip_HexCell.Name = "MenuStrip_HexCell"
        Me.MenuStrip_HexCell.Size = New System.Drawing.Size(728, 24)
        Me.MenuStrip_HexCell.TabIndex = 2
        Me.MenuStrip_HexCell.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadGridToolStripMenuItem, Me.SaveGridToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LoadGridToolStripMenuItem
        '
        Me.LoadGridToolStripMenuItem.Name = "LoadGridToolStripMenuItem"
        Me.LoadGridToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.LoadGridToolStripMenuItem.Text = "&Load Grid"
        '
        'SaveGridToolStripMenuItem
        '
        Me.SaveGridToolStripMenuItem.Name = "SaveGridToolStripMenuItem"
        Me.SaveGridToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.SaveGridToolStripMenuItem.Text = "&Save Grid"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(117, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Panel_CurrentCell
        '
        Me.Panel_CurrentCell.BackColor = System.Drawing.Color.White
        Me.Panel_CurrentCell.Controls.Add(Me.GroupBox1)
        Me.Panel_CurrentCell.Controls.Add(Me.LinkLabel_Column)
        Me.Panel_CurrentCell.Controls.Add(Me.LinkLabel_Row)
        Me.Panel_CurrentCell.Controls.Add(Me.Label2)
        Me.Panel_CurrentCell.Controls.Add(Me.Label1)
        Me.Panel_CurrentCell.Controls.Add(Me.HexGridCellCtrl1)
        Me.Panel_CurrentCell.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_CurrentCell.Location = New System.Drawing.Point(528, 24)
        Me.Panel_CurrentCell.Name = "Panel_CurrentCell"
        Me.Panel_CurrentCell.Size = New System.Drawing.Size(200, 465)
        Me.Panel_CurrentCell.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HexGridCellCtrl_QuadrantFeedback)
        Me.GroupBox1.Controls.Add(Me.HexGridCellCtrl_ColumnFeedback)
        Me.GroupBox1.Controls.Add(Me.HexGridCellCtrl_RowFeedback)
        Me.GroupBox1.Controls.Add(Me.LinkLabel_QuarterErrors)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LinkLabel_ColumnErrors)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LinkLabel_RowErrors)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 222)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 159)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Validation"
        '
        'HexGridCellCtrl_QuadrantFeedback
        '
        Me.HexGridCellCtrl_QuadrantFeedback.CausesValidation = False
        Me.HexGridCellCtrl_QuadrantFeedback.CellValue = 65535
        Me.HexGridCellCtrl_QuadrantFeedback.Enabled = False
        Me.HexGridCellCtrl_QuadrantFeedback.Location = New System.Drawing.Point(136, 116)
        Me.HexGridCellCtrl_QuadrantFeedback.Name = "HexGridCellCtrl_QuadrantFeedback"
        Me.HexGridCellCtrl_QuadrantFeedback.Size = New System.Drawing.Size(34, 34)
        Me.HexGridCellCtrl_QuadrantFeedback.TabIndex = 11
        '
        'HexGridCellCtrl_ColumnFeedback
        '
        Me.HexGridCellCtrl_ColumnFeedback.CausesValidation = False
        Me.HexGridCellCtrl_ColumnFeedback.CellValue = 65535
        Me.HexGridCellCtrl_ColumnFeedback.Enabled = False
        Me.HexGridCellCtrl_ColumnFeedback.Location = New System.Drawing.Point(136, 68)
        Me.HexGridCellCtrl_ColumnFeedback.Name = "HexGridCellCtrl_ColumnFeedback"
        Me.HexGridCellCtrl_ColumnFeedback.Size = New System.Drawing.Size(34, 34)
        Me.HexGridCellCtrl_ColumnFeedback.TabIndex = 10
        '
        'HexGridCellCtrl_RowFeedback
        '
        Me.HexGridCellCtrl_RowFeedback.CausesValidation = False
        Me.HexGridCellCtrl_RowFeedback.CellValue = 65535
        Me.HexGridCellCtrl_RowFeedback.Enabled = False
        Me.HexGridCellCtrl_RowFeedback.Location = New System.Drawing.Point(136, 18)
        Me.HexGridCellCtrl_RowFeedback.Name = "HexGridCellCtrl_RowFeedback"
        Me.HexGridCellCtrl_RowFeedback.Size = New System.Drawing.Size(34, 34)
        Me.HexGridCellCtrl_RowFeedback.TabIndex = 9
        '
        'LinkLabel_QuarterErrors
        '
        Me.LinkLabel_QuarterErrors.AutoSize = True
        Me.LinkLabel_QuarterErrors.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel_QuarterErrors.Location = New System.Drawing.Point(10, 135)
        Me.LinkLabel_QuarterErrors.Name = "LinkLabel_QuarterErrors"
        Me.LinkLabel_QuarterErrors.Size = New System.Drawing.Size(43, 13)
        Me.LinkLabel_QuarterErrors.TabIndex = 8
        Me.LinkLabel_QuarterErrors.TabStop = True
        Me.LinkLabel_QuarterErrors.Text = "0 Errors"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Current Quadrant Values"
        '
        'LinkLabel_ColumnErrors
        '
        Me.LinkLabel_ColumnErrors.AutoSize = True
        Me.LinkLabel_ColumnErrors.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel_ColumnErrors.Location = New System.Drawing.Point(10, 87)
        Me.LinkLabel_ColumnErrors.Name = "LinkLabel_ColumnErrors"
        Me.LinkLabel_ColumnErrors.Size = New System.Drawing.Size(43, 13)
        Me.LinkLabel_ColumnErrors.TabIndex = 5
        Me.LinkLabel_ColumnErrors.TabStop = True
        Me.LinkLabel_ColumnErrors.Text = "0 Errors"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Current Column Values"
        '
        'LinkLabel_RowErrors
        '
        Me.LinkLabel_RowErrors.AutoSize = True
        Me.LinkLabel_RowErrors.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel_RowErrors.Location = New System.Drawing.Point(10, 37)
        Me.LinkLabel_RowErrors.Name = "LinkLabel_RowErrors"
        Me.LinkLabel_RowErrors.Size = New System.Drawing.Size(43, 13)
        Me.LinkLabel_RowErrors.TabIndex = 2
        Me.LinkLabel_RowErrors.TabStop = True
        Me.LinkLabel_RowErrors.Text = "0 Errors"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Current Row Values"
        '
        'LinkLabel_Column
        '
        Me.LinkLabel_Column.AutoSize = True
        Me.LinkLabel_Column.Location = New System.Drawing.Point(89, 205)
        Me.LinkLabel_Column.Name = "LinkLabel_Column"
        Me.LinkLabel_Column.Size = New System.Drawing.Size(13, 13)
        Me.LinkLabel_Column.TabIndex = 4
        Me.LinkLabel_Column.TabStop = True
        Me.LinkLabel_Column.Text = "5"
        '
        'LinkLabel_Row
        '
        Me.LinkLabel_Row.AutoSize = True
        Me.LinkLabel_Row.Location = New System.Drawing.Point(89, 188)
        Me.LinkLabel_Row.Name = "LinkLabel_Row"
        Me.LinkLabel_Row.Size = New System.Drawing.Size(13, 13)
        Me.LinkLabel_Row.TabIndex = 3
        Me.LinkLabel_Row.TabStop = True
        Me.LinkLabel_Row.Text = "5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Column:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Row:"
        '
        'HexGridCellCtrl1
        '
        Me.HexGridCellCtrl1.CellValue = 65535
        Me.HexGridCellCtrl1.ContextMenuStrip = Me.ContextMenuStrip_CellGrid
        Me.HexGridCellCtrl1.Location = New System.Drawing.Point(7, 4)
        Me.HexGridCellCtrl1.Name = "HexGridCellCtrl1"
        Me.HexGridCellCtrl1.Size = New System.Drawing.Size(181, 177)
        Me.HexGridCellCtrl1.TabIndex = 0
        '
        'ContextMenuStrip_CellGrid
        '
        Me.ContextMenuStrip_CellGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetCellToolStripContextMenuItem, Me.SetToToolStripContextMenuItem})
        Me.ContextMenuStrip_CellGrid.Name = "ContextMenuStrip_CellGrid"
        Me.ContextMenuStrip_CellGrid.Size = New System.Drawing.Size(104, 48)
        '
        'ResetCellToolStripContextMenuItem
        '
        Me.ResetCellToolStripContextMenuItem.Name = "ResetCellToolStripContextMenuItem"
        Me.ResetCellToolStripContextMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ResetCellToolStripContextMenuItem.Text = "&Reset"
        '
        'SetToToolStripContextMenuItem
        '
        Me.SetToToolStripContextMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripContextMenuItem_Cell1, Me.ToolStripContextMenuItem_Cell2, Me.ToolStripContextMenuItem_Cell3, Me.ToolStripContextMenuItem_Cell4, Me.ToolStripContextMenuItem_Cell5, Me.ToolStripContextMenuItem_Cell6, Me.ToolStripContextMenuItem_Cell7, Me.ToolStripContextMenuItem_Cell8, Me.ToolStripContextMenuItem_Cell9, Me.ToolStripContextMenuItem_Cell10, Me.ToolStripContextMenuItem_Cell11, Me.ToolStripContextMenuItem_Cell12, Me.ToolStripContextMenuItem_Cell13, Me.ToolStripContextMenuItem_Cell14, Me.ToolStripContextMenuItem_Cell15, Me.ToolStripContextMenuItem_Cell16})
        Me.SetToToolStripContextMenuItem.Name = "SetToToolStripContextMenuItem"
        Me.SetToToolStripContextMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SetToToolStripContextMenuItem.Text = "&Set to"
        '
        'ToolStripContextMenuItem_Cell1
        '
        Me.ToolStripContextMenuItem_Cell1.BackColor = System.Drawing.Color.Aqua
        Me.ToolStripContextMenuItem_Cell1.Name = "ToolStripContextMenuItem_Cell1"
        Me.ToolStripContextMenuItem_Cell1.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripContextMenuItem_Cell1.Text = "Aqua"
        '
        'ToolStripContextMenuItem_Cell2
        '
        Me.ToolStripContextMenuItem_Cell2.BackColor = System.Drawing.Color.Coral
        Me.ToolStripContextMenuItem_Cell2.Name = "ToolStripContextMenuItem_Cell2"
        Me.ToolStripContextMenuItem_Cell2.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripContextMenuItem_Cell2.Text = "Coral"
        '
        'ToolStripContextMenuItem_Cell3
        '
        Me.ToolStripContextMenuItem_Cell3.BackColor = System.Drawing.Color.Crimson
        Me.ToolStripContextMenuItem_Cell3.Name = "ToolStripContextMenuItem_Cell3"
        Me.ToolStripContextMenuItem_Cell3.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripContextMenuItem_Cell3.Text = "Crimson"
        '
        'ToolStripContextMenuItem_Cell4
        '
        Me.ToolStripContextMenuItem_Cell4.BackColor = System.Drawing.Color.DarkKhaki
        Me.ToolStripContextMenuItem_Cell4.Name = "ToolStripContextMenuItem_Cell4"
        Me.ToolStripContextMenuItem_Cell4.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripContextMenuItem_Cell4.Text = "Dark Khaki"
        '
        'ToolStripContextMenuItem_Cell5
        '
        Me.ToolStripContextMenuItem_Cell5.BackColor = System.Drawing.Color.Firebrick
        Me.ToolStripContextMenuItem_Cell5.Name = "ToolStripContextMenuItem_Cell5"
        Me.ToolStripContextMenuItem_Cell5.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripContextMenuItem_Cell5.Text = "Firebrick"
        '
        'ToolStripContextMenuItem_Cell6
        '
        Me.ToolStripContextMenuItem_Cell6.BackColor = System.Drawing.Color.DarkGreen
        Me.ToolStripContextMenuItem_Cell6.Name = "ToolStripContextMenuItem_Cell6"
        Me.ToolStripContextMenuItem_Cell6.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripContextMenuItem_Cell6.Text = "Dark Green"
        '
        'ToolStripContextMenuItem_Cell7
        '
        Me.ToolStripContextMenuItem_Cell7.BackColor = System.Drawing.Color.Blue
        Me.ToolStripContextMenuItem_Cell7.Name = "ToolStripContextMenuItem_Cell7"
        Me.ToolStripContextMenuItem_Cell7.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripContextMenuItem_Cell7.Text = "Blue"
        '
        'ToolStripContextMenuItem_Cell8
        '
        Me.ToolStripContextMenuItem_Cell8.BackColor = System.Drawing.Color.Fuchsia
        Me.ToolStripContextMenuItem_Cell8.Name = "ToolStripContextMenuItem_Cell8"
        Me.ToolStripContextMenuItem_Cell8.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripContextMenuItem_Cell8.Text = "Fuchsia"
        '
        'ToolStripContextMenuItem_Cell9
        '
        Me.ToolStripContextMenuItem_Cell9.BackColor = System.Drawing.Color.Green
        Me.ToolStripContextMenuItem_Cell9.Name = "ToolStripContextMenuItem_Cell9"
        Me.ToolStripContextMenuItem_Cell9.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripContextMenuItem_Cell9.Text = "Green"
        '
        'ToolStripContextMenuItem_Cell10
        '
        Me.ToolStripContextMenuItem_Cell10.BackColor = System.Drawing.Color.Yellow
        Me.ToolStripContextMenuItem_Cell10.Name = "ToolStripContextMenuItem_Cell10"
        Me.ToolStripContextMenuItem_Cell10.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripContextMenuItem_Cell10.Text = "Yellow"
        '
        'ToolStripContextMenuItem_Cell11
        '
        Me.ToolStripContextMenuItem_Cell11.BackColor = System.Drawing.Color.HotPink
        Me.ToolStripContextMenuItem_Cell11.Name = "ToolStripContextMenuItem_Cell11"
        Me.ToolStripContextMenuItem_Cell11.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripContextMenuItem_Cell11.Text = "Hot Pink"
        '
        'ToolStripContextMenuItem_Cell12
        '
        Me.ToolStripContextMenuItem_Cell12.BackColor = System.Drawing.Color.Gold
        Me.ToolStripContextMenuItem_Cell12.Name = "ToolStripContextMenuItem_Cell12"
        Me.ToolStripContextMenuItem_Cell12.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripContextMenuItem_Cell12.Text = "Gold"
        '
        'ToolStripContextMenuItem_Cell13
        '
        Me.ToolStripContextMenuItem_Cell13.BackColor = System.Drawing.Color.Khaki
        Me.ToolStripContextMenuItem_Cell13.Name = "ToolStripContextMenuItem_Cell13"
        Me.ToolStripContextMenuItem_Cell13.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripContextMenuItem_Cell13.Text = "Khaki"
        '
        'ToolStripContextMenuItem_Cell14
        '
        Me.ToolStripContextMenuItem_Cell14.BackColor = System.Drawing.Color.DarkBlue
        Me.ToolStripContextMenuItem_Cell14.Name = "ToolStripContextMenuItem_Cell14"
        Me.ToolStripContextMenuItem_Cell14.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripContextMenuItem_Cell14.Text = "Dark Blue"
        '
        'ToolStripContextMenuItem_Cell15
        '
        Me.ToolStripContextMenuItem_Cell15.BackColor = System.Drawing.Color.LightBlue
        Me.ToolStripContextMenuItem_Cell15.Name = "ToolStripContextMenuItem_Cell15"
        Me.ToolStripContextMenuItem_Cell15.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripContextMenuItem_Cell15.Text = "Light Blue"
        '
        'ToolStripContextMenuItem_Cell16
        '
        Me.ToolStripContextMenuItem_Cell16.BackColor = System.Drawing.Color.LightSalmon
        Me.ToolStripContextMenuItem_Cell16.Name = "ToolStripContextMenuItem_Cell16"
        Me.ToolStripContextMenuItem_Cell16.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripContextMenuItem_Cell16.Text = "Light Salmon"
        '
        'BackgroundWorker_ValidateRows
        '
        Me.BackgroundWorker_ValidateRows.WorkerReportsProgress = True
        Me.BackgroundWorker_ValidateRows.WorkerSupportsCancellation = True
        '
        'BackgroundWorker_ValidateColumns
        '
        Me.BackgroundWorker_ValidateColumns.WorkerReportsProgress = True
        Me.BackgroundWorker_ValidateColumns.WorkerSupportsCancellation = True
        '
        'BackgroundWorker_ValidateQuarters
        '
        Me.BackgroundWorker_ValidateQuarters.WorkerReportsProgress = True
        Me.BackgroundWorker_ValidateQuarters.WorkerSupportsCancellation = True
        '
        'HexGrid1
        '
        Me.HexGrid1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.HexGrid1.ContextMenuStrip = Me.ContextMenuStrip_CellGrid
        Me.HexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HexGrid1.GridMajorLineColour = System.Drawing.Color.Black
        Me.HexGrid1.GridMinorLineColour = System.Drawing.Color.DimGray
        Me.HexGrid1.Location = New System.Drawing.Point(0, 24)
        Me.HexGrid1.Name = "HexGrid1"
        Me.HexGrid1.Padding = New System.Windows.Forms.Padding(3)
        Me.HexGrid1.SelectedCellColour = System.Drawing.Color.Black
        Me.HexGrid1.SelectedCellLocation = New System.Drawing.Point(5, 5)
        Me.HexGrid1.Size = New System.Drawing.Size(528, 465)
        Me.HexGrid1.TabIndex = 0
        '
        'SaveFileDialog_HexcellGrid
        '
        Me.SaveFileDialog_HexcellGrid.Filter = "Hexcel grids|*.xhx"
        Me.SaveFileDialog_HexcellGrid.Title = "Save current hexcell grid"
        '
        'OpenFileDialog_HexcellGrid
        '
        Me.OpenFileDialog_HexcellGrid.Filter = "Hexcel grids|*.xhx"
        Me.OpenFileDialog_HexcellGrid.Title = "Load existing hexcell grid"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 511)
        Me.Controls.Add(Me.HexGrid1)
        Me.Controls.Add(Me.Panel_CurrentCell)
        Me.Controls.Add(Me.MenuStrip_HexCell)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip_HexCell
        Me.Name = "Form1"
        Me.Text = "HexCell"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip_HexCell.ResumeLayout(False)
        Me.MenuStrip_HexCell.PerformLayout()
        Me.Panel_CurrentCell.ResumeLayout(False)
        Me.Panel_CurrentCell.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip_CellGrid.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HexGrid1 As HexCell.HexGrid
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar_Rows As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel_Information As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip_HexCell As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel_CurrentCell As System.Windows.Forms.Panel
    Friend WithEvents HexGridCellCtrl1 As HexCell.HexGridCellCtrl
    Friend WithEvents LinkLabel_Row As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_Column As System.Windows.Forms.LinkLabel
    Friend WithEvents BackgroundWorker_ValidateRows As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker_ValidateColumns As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker_ValidateQuarters As System.ComponentModel.BackgroundWorker
    Friend WithEvents ContextMenuStrip_CellGrid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ResetCellToolStripContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_QuarterErrors As System.Windows.Forms.LinkLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_ColumnErrors As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_RowErrors As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolStripProgressBar_Columns As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripProgressBar_Quarters As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents SetToToolStripContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContextMenuItem_Cell1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContextMenuItem_Cell2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContextMenuItem_Cell3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContextMenuItem_Cell4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContextMenuItem_Cell5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContextMenuItem_Cell6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContextMenuItem_Cell7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContextMenuItem_Cell8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContextMenuItem_Cell9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContextMenuItem_Cell10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContextMenuItem_Cell11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContextMenuItem_Cell12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContextMenuItem_Cell13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContextMenuItem_Cell14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContextMenuItem_Cell15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContextMenuItem_Cell16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HexGridCellCtrl_RowFeedback As HexCell.HexGridCellCtrl
    Friend WithEvents HexGridCellCtrl_QuadrantFeedback As HexCell.HexGridCellCtrl
    Friend WithEvents HexGridCellCtrl_ColumnFeedback As HexCell.HexGridCellCtrl
    Friend WithEvents SaveFileDialog_HexcellGrid As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog_HexcellGrid As System.Windows.Forms.OpenFileDialog

End Class
