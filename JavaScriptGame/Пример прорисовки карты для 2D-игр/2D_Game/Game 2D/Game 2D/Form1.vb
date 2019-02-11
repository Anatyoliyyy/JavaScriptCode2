Imports System.Drawing.Drawing2D
Public Class Form1
#Region " [Variables] "
    Public Const iTileWidth As Integer = 100
    Public Const iTileHeight As Integer = 100
    Public Const iTilesX As Integer = 12 - 1, iTilesY As Integer = 21 - 1
    Public Const iTilesScreenX As Integer = 8 - 1, iTilesScreenY As Integer = 10 - 1
    Public Const iViewX As Integer = 6 - 1, iViewY As Integer = 8 - 1
    Public Const iViewXBeginPan As Integer = (iViewX + 1) \ 2, iViewYBeginPan As Integer = (iViewY + 1) \ 2
    Public iPlayerX As Integer = 0, iPlayerY As Integer = 0
    Public iPlayerXPixels As Integer = 0, iPlayerYPixels As Integer = 0
    Public iPlayerFacing As Integer = 0
    Public iMapX As Integer = 0, iMapY As Integer = 0
    Public iMapXPixels As Integer = 0, iMapYPixels As Integer = 0
    Public iDiffX As Integer = 0, iDiffY As Integer = 0
    Public bDisableMovement As Boolean = False
    Public iDiffWidth As Integer = (iViewX - iViewXBeginPan) + 1
    Public iDiffHeight As Integer = (iViewY - iViewYBeginPan) + 1
    'The map grid has the first left & top rows blank, as they are not used, that is why iDiffWidth & Height have a +1
    Public iMap(,) As Integer = {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                                {0, 1, 2, 1, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3}, _
                                {0, 1, 1, 1, 1, 1, 1, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3}, _
                                {0, 1, 1, 1, 1, 1, 1, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3}, _
                                {0, 1, 1, 1, 1, 1, 1, 2, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3}, _
                                {0, 3, 3, 3, 2, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1}, _
                                {0, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 1}, _
                                {0, 3, 3, 3, 1, 1, 1, 1, 2, 2, 3, 3, 3, 1, 1, 1, 1, 1, 3, 1, 1}, _
                                {0, 3, 3, 3, 1, 3, 3, 1, 2, 2, 3, 3, 3, 1, 3, 3, 3, 1, 3, 1, 3}, _
                                {0, 3, 3, 3, 1, 3, 3, 1, 2, 2, 3, 3, 3, 1, 1, 3, 3, 1, 1, 1, 3}, _
                                {0, 3, 3, 3, 1, 3, 3, 3, 3, 2, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3}, _
                                {0, 3, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, 3, 3, 3, 3, 3}}

    Public sPlayerPrevPos As New Size(0, 0)
    Public sMapPrevPos As New Size(0, 0)
    Public sDiffPrevPos As New Size(0, 0)

    Public iMoveX As Integer = 10
    Public iMoveY As Integer = 10

    Public iMap_CantWalk() As Integer = {0, 3}
    Public bPlayer As Brush = New HatchBrush(HatchStyle.SolidDiamond, Color.Blue, Color.Red)
    Public bTerrain() As Brush = {New SolidBrush(Color.Black), New HatchBrush(HatchStyle.LargeConfetti, Color.Green, Color.DarkGreen), New HatchBrush(HatchStyle.Weave, Color.Brown, Color.Chocolate), New HatchBrush(HatchStyle.Wave, Color.LightBlue, Color.Blue)}
    Public dMoveDirection As eMoveDirection = eMoveDirection.none
#End Region
#Region " [Enums] "
#Region " [eMoveDirection] "
    Public Enum eMoveDirection
        left = 0
        right = 1
        up = 2
        down = 3
        none = 4
    End Enum
#End Region
#Region " [eMovementType] "
    Public Enum eMovementType
        p = 0
        m = 1
        d = 2
    End Enum
#End Region
#End Region
#Region " [Subs] "
#Region " [MoveUp] "
    Public Sub MoveUp()
        iPlayerX -= 1
        If iPlayerX < 0 Then
            iPlayerX = 0
        End If
        If iMapX > 0 Then
            iMapX -= 1
            iPlayerX += 1
        End If
        If iDiffX > 0 Then
            iDiffX -= 1
            iMapX += 1
        End If
        dMoveDirection = eMoveDirection.up
    End Sub
#End Region
#Region " [MoveDown] "
    Public Sub MoveDown()
        iPlayerX += 1
        If iPlayerX > iViewXBeginPan Then
            iPlayerX = iViewXBeginPan
            iMapX += 1
            If iMapX > (iTilesX - iPlayerX) - iDiffWidth Then
                iMapX = (iTilesX - iPlayerX) - iDiffWidth
                iDiffX += 1
                If iDiffX > (iTilesX - iPlayerX) - iMapX Then
                    iDiffX = (iTilesX - iPlayerX) - iMapX
                End If
            End If
        End If
        dMoveDirection = eMoveDirection.down
    End Sub
#End Region
#Region " [MoveLeft] "
    Public Sub MoveLeft()
        iPlayerY -= 1
        If iPlayerY < 0 Then
            iPlayerY = 0
        End If
        If iMapY > 0 Then
            iMapY -= 1
            iPlayerY += 1
        End If
        If iDiffY > 0 Then
            iDiffY -= 1
            iMapY += 1
        End If
        dMoveDirection = eMoveDirection.left
    End Sub
#End Region
#Region " [MoveRight] "
    Public Sub MoveRight()
        iPlayerY += 1
        If iPlayerY > iViewYBeginPan Then
            iPlayerY = iViewYBeginPan
            iMapY += 1
            If iMapY > (iTilesY - iPlayerY) - iDiffHeight Then
                iMapY = (iTilesY - iPlayerY) - iDiffHeight
                iDiffY += 1
                If iDiffY > (iTilesY - iPlayerY) - iMapY Then
                    iDiffY = (iTilesY - iPlayerY) - iMapY
                End If
            End If
        End If
        dMoveDirection = eMoveDirection.right
    End Sub
#End Region
#Region " [EndMovement] "
    Public Sub EndMovement()
        iMapYPixels = 0
        iMapXPixels = 0
        iPlayerXPixels = 0
        iPlayerYPixels = 0
        bDisableMovement = False
        tMove.Enabled = False
    End Sub
#End Region
#Region " [CheckMap] "
    Public Function CheckMap(ByVal iX As Integer, ByVal iY As Integer) As Boolean
        'iX and iY were normally < 0, but since the first left & top rows of the map are blank, it's now < 1
        If iX < 1 OrElse iY < 1 OrElse iX > iTilesX OrElse iY > iTilesY Then
            bDisableMovement = False
            Return False
        End If
        If Array.IndexOf(iMap_CantWalk, iMap(iX, iY)) <> -1 Then
            iPlayerX = sPlayerPrevPos.Width
            iPlayerY = sPlayerPrevPos.Height
            iMapX = sMapPrevPos.Width
            iMapY = sMapPrevPos.Height
            iDiffX = sDiffPrevPos.Width
            iDiffY = sDiffPrevPos.Height
            bDisableMovement = False
            Return False
        End If
        Return True
    End Function
#End Region

#Region " [NextRightType] "
    Public Function NextRightType() As eMovementType
        Dim mtMovementType As eMovementType = eMovementType.p
        If iPlayerY + 1 > iViewYBeginPan Then
            mtMovementType = eMovementType.m
            If iMapY + 1 > (iTilesY - iPlayerY) - iDiffHeight Then
                mtMovementType = eMovementType.d
            End If
        End If
        Return mtMovementType
    End Function
#End Region
#Region " [NextLeftType] "
    Public Function NextLeftType() As eMovementType
        Dim mtMovementType As eMovementType = eMovementType.p
        If iMapY > 0 Then
            mtMovementType = eMovementType.m
        End If
        If iDiffY > 0 Then
            mtMovementType = eMovementType.d
        End If
        Return mtMovementType
    End Function
#End Region
#Region " [NextUpType] "
    Public Function NextUpType() As eMovementType
        Dim mtMovementType As eMovementType = eMovementType.p
        If iMapX > 0 Then
            mtMovementType = eMovementType.m
        End If
        If iDiffX > 0 Then
            mtMovementType = eMovementType.d
        End If
        Return mtMovementType
    End Function
#End Region
#Region " [NextDownType] "
    Public Function NextDownType() As eMovementType
        Dim mtMovementType As eMovementType = eMovementType.p
        If iPlayerX + 1 > iViewXBeginPan Then
            mtMovementType = eMovementType.m
            If iMapX + 1 > (iTilesX - iPlayerX) - iDiffWidth Then
                mtMovementType = eMovementType.d
            End If
        End If
        Return mtMovementType
    End Function
#End Region
#End Region
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bExit.Location = New Point(Me.Width - bExit.Width - 2, 0)
        tMove.Interval = 10
    End Sub

    Private Sub Form1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim iTempInteger As Integer = 0
        Dim rRectangle As Rectangle = Nothing
        Dim iY As Integer = 0
        Dim iX As Integer = 0
        For x As Integer = 0 To iTilesScreenX
            For y As Integer = 0 To iTilesScreenY 'this controls vertical drawing
                rRectangle = New Rectangle((y * iTileWidth) + iMapYPixels - iTileHeight, (x * iTileHeight) + iMapXPixels - iTileWidth, iTileWidth, iTileHeight)
                iY = y + iMapY
                If iY > iTilesY Then
                    iY = iTilesY
                End If
                iX = x + iMapX
                If iX > iTilesX Then
                    iX = iTilesX
                End If
                e.Graphics.FillRectangle(bTerrain(iMap(iX, iY)), rRectangle)
            Next y
        Next x
        rRectangle = New Rectangle(((iPlayerY + iDiffY) * iTileWidth) + iPlayerYPixels, ((iPlayerX + iDiffX) * iTileHeight) + iPlayerXPixels, iTileWidth, iTileHeight)
        e.Graphics.FillEllipse(bPlayer, rRectangle)
        ControlPaint.DrawBorder3D(e.Graphics, e.ClipRectangle, Border3DStyle.Etched)
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not bDisableMovement Then
            bDisableMovement = True
            sPlayerPrevPos = New Size(iPlayerX, iPlayerY)
            sMapPrevPos = New Size(iMapX, iMapY) 'might not even need these
            sDiffPrevPos = New Size(iDiffX, iDiffY)
            Dim iX As Integer = (iPlayerX + iMapX + iDiffX) + 1
            Dim iY As Integer = (iPlayerY + iMapY + iDiffY) + 1
            'The map grid has the first left & top rows blank, as they are not used, that is why iX and iY have a +1
            If e.KeyCode = Keys.Up Then
                If Not CheckMap(iX - 1, iY) Then
                    Return
                End If
                dMoveDirection = eMoveDirection.up
            ElseIf e.KeyCode = Keys.Down Then
                If Not CheckMap(iX + 1, iY) Then
                    Return
                End If
                dMoveDirection = eMoveDirection.down
            ElseIf e.KeyCode = Keys.Left Then
                If Not CheckMap(iX, iY - 1) Then
                    Return
                End If
                dMoveDirection = eMoveDirection.left
            ElseIf e.KeyCode = Keys.Right Then
                If Not CheckMap(iX, iY + 1) Then
                    Return
                End If
                dMoveDirection = eMoveDirection.right
            End If
            tMove.Enabled = True
        End If
    End Sub
    Private Sub tMove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tMove.Tick
        Select Case dMoveDirection
            Case eMoveDirection.up
                Dim mtMovementType As eMovementType = NextUpType()
                If mtMovementType = eMovementType.p OrElse mtMovementType = eMovementType.d Then
                    iPlayerXPixels -= iMoveX
                    If iPlayerXPixels = -iTileWidth Then
                        EndMovement()
                        MoveUp()
                    End If
                Else
                    iMapXPixels += iMoveX
                    If iMapXPixels = iTileWidth Then
                        EndMovement()
                        MoveUp()
                    End If
                End If
            Case eMoveDirection.down
                Dim mtMovementType As eMovementType = NextDownType()
                If mtMovementType = eMovementType.p OrElse mtMovementType = eMovementType.d Then
                    iPlayerXPixels += iMoveX
                    If iPlayerXPixels = iTileWidth Then
                        EndMovement()
                        MoveDown()
                    End If
                Else
                    iMapXPixels -= iMoveX
                    If iMapXPixels = -iTileWidth Then
                        EndMovement()
                        MoveDown()
                    End If
                End If
            Case eMoveDirection.left
                Dim mtMovementType As eMovementType = NextLeftType()
                If mtMovementType = eMovementType.p OrElse mtMovementType = eMovementType.d Then
                    iPlayerYPixels -= iMoveY
                    If iPlayerYPixels = -iTileHeight Then
                        EndMovement()
                        MoveLeft()
                    End If
                Else
                    iMapYPixels += iMoveY
                    If iMapYPixels = iTileHeight Then
                        EndMovement()
                        MoveLeft()
                    End If
                End If
            Case eMoveDirection.right
                Dim mtMovementType As eMovementType = NextRightType()
                If mtMovementType = eMovementType.p OrElse mtMovementType = eMovementType.d Then
                    iPlayerYPixels += iMoveY
                    If iPlayerYPixels = iTileHeight Then
                        EndMovement()
                        MoveRight()
                    End If
                Else
                    iMapYPixels -= iMoveY
                    If iMapYPixels = -iTileHeight Then
                        EndMovement()
                        MoveRight()
                    End If
                End If
        End Select
        Me.Refresh()
    End Sub

    Private Sub bExit_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles bExit.Paint
        Dim bButton As Button = CType(sender, Button)
        Dim lgbBrush1 As New LinearGradientBrush(e.ClipRectangle, Color.Red, Color.Maroon, LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(lgbBrush1, e.ClipRectangle)
        ControlPaint.DrawBorder3D(e.Graphics, e.ClipRectangle, Border3DStyle.Etched)
        Dim sMeasure As Size = TextRenderer.MeasureText(bButton.Text, bButton.Font)
        Dim iX As Integer = sMeasure.Width \ 2
        Dim iY As Integer = sMeasure.Height \ 2
        e.Graphics.DrawString(bButton.Text, bButton.Font, New HatchBrush(HatchStyle.Cross, Color.Black, Color.White), iX, iY)
    End Sub

    Private Sub bExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bExit.Click
        Me.Close()
    End Sub
End Class
