Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.Form

Public Class Form1
    Dim p As New Pen(Brushes.Black, 2) : Dim im As New Bitmap(770, 770) : Dim K As New SolidBrush(Color.Teal)
    Dim a As Boolean = True : Dim b As Boolean = True : Dim ns1, nm1, nh1, ns2, nm2, nh2, n1a, n2b, m, h As Double
    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        tr1.Enabled = True : tr2.Enabled = False
        rb1.Checked = True : b1.BackColor = Color.Aqua : b3.BackColor = Color.Honeydew             'Start Black
        If rb1.Checked = True Then
            a = False : b = True
        End If
    End Sub
    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        rb2.Checked = True : b3.BackColor = Color.Aqua : b1.BackColor = Color.Honeydew
        tr2.Enabled = True : tr1.Enabled = False : a = True                                                                             'Stop White
    End Sub
    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        tr2.Enabled = True : tr1.Enabled = False
        rb2.Checked = True : b2.BackColor = Color.Aqua : b4.BackColor = Color.Honeydew             'Start Black
        If rb2.Checked = True Then
            b = False : a = True
        End If
    End Sub
    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        rb1.Checked = True : b4.BackColor = Color.Aqua : b2.BackColor = Color.Honeydew
        tr1.Enabled = True : tr2.Enabled = False : b = True                                                                           'Stop Black
    End Sub
    Private Sub p1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p1.MouseDoubleClick
        If b = True Then p1.Visible = False
    End Sub
    Private Sub p1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p1.MouseMove
        WndProc(Message.Create(p1.Handle, &HA1, CType(2, IntPtr), 0)) : p1.Capture = b
    End Sub
    Private Sub p3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p3.MouseDoubleClick
        If b = True Then p3.Visible = False
    End Sub
    Private Sub p3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p3.MouseMove
        WndProc(Message.Create(p3.Handle, &HA1, CType(2, IntPtr), 0)) : p3.Capture = b
    End Sub
    Private Sub p2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p2.MouseDoubleClick
        If b = True Then p2.Visible = False
    End Sub
    Private Sub p2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p2.MouseMove
        WndProc(Message.Create(p2.Handle, &HA1, CType(2, IntPtr), 0)) : p2.Capture = b
    End Sub
    Private Sub p4_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p4.MouseDoubleClick
        If b = True Then p4.Visible = False
    End Sub
    Private Sub p4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p4.MouseMove
        WndProc(Message.Create(p4.Handle, &HA1, CType(2, IntPtr), 0)) : p4.Capture = b
    End Sub
    Private Sub p5_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p5.MouseDoubleClick
        If b = True Then p5.Visible = False
    End Sub
    Private Sub p5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p5.MouseMove
        WndProc(Message.Create(p5.Handle, &HA1, CType(2, IntPtr), 0)) : p5.Capture = b
    End Sub
    Private Sub p6_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p6.MouseDoubleClick
        If b = True Then p6.Visible = False
    End Sub
    Private Sub p6_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p6.MouseMove
        WndProc(Message.Create(p6.Handle, &HA1, CType(2, IntPtr), 0)) : p6.Capture = b
    End Sub
    Private Sub p7_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p7.MouseDoubleClick
        If b = True Then p7.Visible = False
    End Sub
    Private Sub p7_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p7.MouseMove
        WndProc(Message.Create(p7.Handle, &HA1, CType(2, IntPtr), 0)) : p7.Capture = b
    End Sub
    Private Sub p8_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p8.MouseDoubleClick
        If b = True Then p8.Visible = False
    End Sub
    Private Sub p8_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p8.MouseMove
        WndProc(Message.Create(p8.Handle, &HA1, CType(2, IntPtr), 0)) : p8.Capture = b
    End Sub
    Private Sub p9_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p9.MouseDoubleClick
        If b = True Then p9.Visible = False
    End Sub
    Private Sub p9_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p9.MouseMove
        WndProc(Message.Create(p9.Handle, &HA1, CType(2, IntPtr), 0)) : p9.Capture = b
    End Sub
    Private Sub p10_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p10.MouseDoubleClick
        If b = True Then p10.Visible = False
    End Sub
    Private Sub p10_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p10.MouseMove
        WndProc(Message.Create(p10.Handle, &HA1, CType(2, IntPtr), 0)) : p10.Capture = b
    End Sub
    Private Sub p11_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p11.MouseDoubleClick
        If b = True Then p11.Visible = False
    End Sub
    Private Sub p11_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p11.MouseMove
        WndProc(Message.Create(p11.Handle, &HA1, CType(2, IntPtr), 0)) : p11.Capture = b
    End Sub
    Private Sub p12_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p12.MouseDoubleClick
        If b = True Then p12.Visible = False
    End Sub
    Private Sub p12_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p12.MouseMove
        WndProc(Message.Create(p12.Handle, &HA1, CType(2, IntPtr), 0)) : p12.Capture = b
    End Sub
    Private Sub p13_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p13.MouseDoubleClick
        If b = True Then p13.Visible = False
    End Sub
    Private Sub p13_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p13.MouseMove
        WndProc(Message.Create(p13.Handle, &HA1, CType(2, IntPtr), 0)) : p13.Capture = b
    End Sub
    Private Sub p14_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p14.MouseDoubleClick
        If b = True Then p14.Visible = False
    End Sub
    Private Sub p14_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p14.MouseMove
        WndProc(Message.Create(p14.Handle, &HA1, CType(2, IntPtr), 0)) : p14.Capture = b
    End Sub
    Private Sub p15_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p15.MouseDoubleClick
        If b = True Then p15.Visible = False
    End Sub
    Private Sub p15_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p15.MouseMove
        WndProc(Message.Create(p15.Handle, &HA1, CType(2, IntPtr), 0)) : p15.Capture = b
    End Sub
    Private Sub p16_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p16.MouseDoubleClick
        If b = True Then p16.Visible = False
    End Sub
    Private Sub p16_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p16.MouseMove
        WndProc(Message.Create(p16.Handle, &HA1, CType(2, IntPtr), 0)) : p16.Capture = b
    End Sub
    Private Sub p49_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p49.MouseDoubleClick
        If a = True Then p49.Visible = False
    End Sub
    Private Sub p49_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p49.MouseMove
        WndProc(Message.Create(p49.Handle, &HA1, CType(2, IntPtr), 0)) : p49.Capture = a
    End Sub
    Private Sub p50_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p50.MouseDoubleClick
        If a = True Then p50.Visible = False
    End Sub
    Private Sub p50_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p50.MouseMove
        WndProc(Message.Create(p50.Handle, &HA1, CType(2, IntPtr), 0)) : p50.Capture = a
    End Sub
    Private Sub p51_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p51.MouseDoubleClick
        If a = True Then p51.Visible = False
    End Sub
    Private Sub p51_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p51.MouseMove
        WndProc(Message.Create(p51.Handle, &HA1, CType(2, IntPtr), 0)) : p51.Capture = a
    End Sub
    Private Sub p52_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p52.MouseDoubleClick
        If a = True Then p52.Visible = False
    End Sub
    Private Sub p52_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p52.MouseMove
        WndProc(Message.Create(p52.Handle, &HA1, CType(2, IntPtr), 0)) : p52.Capture = a
    End Sub
    Private Sub p53_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p53.MouseDoubleClick
        If a = True Then p53.Visible = False
    End Sub
    Private Sub p53_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p53.MouseMove
        WndProc(Message.Create(p53.Handle, &HA1, CType(2, IntPtr), 0)) : p53.Capture = a
    End Sub
    Private Sub p54_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p54.MouseDoubleClick
        If a = True Then p54.Visible = False
    End Sub
    Private Sub p54_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p54.MouseMove
        WndProc(Message.Create(p54.Handle, &HA1, CType(2, IntPtr), 0)) : p54.Capture = a
    End Sub
    Private Sub p55_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p55.MouseDoubleClick
        If a = True Then p55.Visible = False
    End Sub
    Private Sub p55_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p55.MouseMove
        WndProc(Message.Create(p55.Handle, &HA1, CType(2, IntPtr), 0)) : p55.Capture = a
    End Sub
    Private Sub p56_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p56.MouseDoubleClick
        If a = True Then p56.Visible = False
    End Sub
    Private Sub p56_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p56.MouseMove
        WndProc(Message.Create(p56.Handle, &HA1, CType(2, IntPtr), 0)) : p56.Capture = a
    End Sub
    Private Sub p57_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p57.MouseDoubleClick
        If a = True Then p57.Visible = False
    End Sub
    Private Sub p57_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p57.MouseMove
        WndProc(Message.Create(p57.Handle, &HA1, CType(2, IntPtr), 0)) : p57.Capture = a
    End Sub
    Private Sub p58_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p58.MouseDoubleClick
        If a = True Then p58.Visible = False
    End Sub
    Private Sub p58_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p58.MouseMove
        WndProc(Message.Create(p58.Handle, &HA1, CType(2, IntPtr), 0)) : p58.Capture = a
    End Sub
    Private Sub p59_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p59.MouseDoubleClick
        If a = True Then p59.Visible = False
    End Sub
    Private Sub p59_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p59.MouseMove
        WndProc(Message.Create(p59.Handle, &HA1, CType(2, IntPtr), 0)) : p59.Capture = a
    End Sub
    Private Sub p60_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p60.MouseDoubleClick
        If a = True Then p60.Visible = False
    End Sub
    Private Sub p60_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p60.MouseMove
        WndProc(Message.Create(p60.Handle, &HA1, CType(2, IntPtr), 0)) : p60.Capture = a
    End Sub
    Private Sub p61_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p61.MouseDoubleClick
        If a = True Then p61.Visible = False
    End Sub
    Private Sub p61_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p61.MouseMove
        WndProc(Message.Create(p61.Handle, &HA1, CType(2, IntPtr), 0)) : p61.Capture = a
    End Sub
    Private Sub p62_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p62.MouseDoubleClick
        If a = True Then p62.Visible = False
    End Sub
    Private Sub p62_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p62.MouseMove
        WndProc(Message.Create(p62.Handle, &HA1, CType(2, IntPtr), 0)) : p62.Capture = a
    End Sub
    Private Sub p63_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p63.MouseDoubleClick
        If a = True Then p63.Visible = False
    End Sub
    Private Sub p63_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p63.MouseMove
        WndProc(Message.Create(p63.Handle, &HA1, CType(2, IntPtr), 0)) : p63.Capture = a
    End Sub
    Private Sub p64_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles p64.MouseDoubleClick
        If a = True Then p64.Visible = False
    End Sub
    Private Sub p64_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p64.MouseMove
        WndProc(Message.Create(p64.Handle, &HA1, CType(2, IntPtr), 0)) : p64.Capture = a ' : p64.BackColor = Color.Transparent
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        '  lx.Text = (e.X) : ly.Text = Val(e.Y)
    End Sub
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i, j As Integer : Dim g As Graphics = CreateGraphics()
        For i = 1 To 9
            g.DrawLine(p, 85, 85 * (i), 764, 85 * (i))
        Next i
        For j = 1 To 9
            g.DrawLine(p, (85 * (j)), 85, (85 * (j)), 764)
        Next j
        g.FillRectangle(K, 171, 86, 83, 83) : g.FillRectangle(K, 341, 86, 83, 83) : g.FillRectangle(K, 511, 86, 83, 83)
        g.FillRectangle(K, 680, 86, 83, 83) : g.FillRectangle(K, 256, 171, 83, 83) : g.FillRectangle(K, 86, 171, 83, 83)
        g.FillRectangle(K, 426, 171, 83, 83) : g.FillRectangle(K, 596, 171, 83, 83) : g.FillRectangle(K, 171, 256, 83, 83)
        g.FillRectangle(K, 341, 256, 83, 83) : g.FillRectangle(K, 511, 256, 83, 83) : g.FillRectangle(K, 681, 256, 83, 83)
        g.FillRectangle(K, 86, 341, 83, 83) : g.FillRectangle(K, 256, 341, 83, 83) : g.FillRectangle(K, 426, 341, 83, 83)
        g.FillRectangle(K, 596, 341, 83, 83) : g.FillRectangle(K, 171, 426, 83, 83) : g.FillRectangle(K, 341, 426, 83, 83)
        g.FillRectangle(K, 511, 426, 83, 83) : g.FillRectangle(K, 681, 426, 83, 83) : g.FillRectangle(K, 86, 511, 83, 83)
        g.FillRectangle(K, 256, 511, 83, 83) : g.FillRectangle(K, 426, 511, 83, 83) : g.FillRectangle(K, 596, 511, 83, 83)
        g.FillRectangle(K, 171, 596, 83, 83) : g.FillRectangle(K, 341, 596, 83, 83) : g.FillRectangle(K, 511, 596, 83, 83)
        g.FillRectangle(K, 681, 596, 83, 83) : g.FillRectangle(K, 86, 681, 83, 83) : g.FillRectangle(K, 256, 681, 83, 83)
        g.FillRectangle(K, 426, 681, 83, 83) : g.FillRectangle(K, 596, 681, 83, 83)


    End Sub
    Private Sub tr1_Tick(sender As Object, e As EventArgs) Handles tr1.Tick
        ns1 += 1
        If nm1 >= 60 Then
            ns1 = 0 : nm1 = 0 : nh1 += 1
        End If
        If ns1 >= 60 Then
            ns1 = 0 : nm1 += 1
        End If
        la.Text = Format(nh1, "00:") & Format(nm1, "00:") & Format(ns1, "00")
        If nm1 >= m And nh1 >= h Then
            l3.Visible = True : tr1.Enabled = False : tr2.Enabled = False
        End If
    End Sub
    Private Sub tr2_Tick(sender As Object, e As EventArgs) Handles tr2.Tick
        ns2 += 1
        If nm2 >= 60 Then
            ns2 = 0 : nm2 = 0 : nh2 += 1
        End If
        If ns2 >= 60 Then
            ns2 = 0 : nm2 += 1
        End If
        lb.Text = Format(nh2, "00:") & Format(nm2, "00:") & Format(ns2, "00")
        If nm2 >= m And nh2 >= h Then
            l4.Visible = True : tr2.Enabled = False : tr1.Enabled = False
        End If
    End Sub
    Private Sub n1_ValueChanged(sender As Object, e As EventArgs) Handles n1.ValueChanged
        m = n1.Value                                                              'do
    End Sub
    Private Sub n2_ValueChanged(sender As Object, e As EventArgs) Handles n2.ValueChanged
        h = n2.Value
    End Sub
    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        n1.Value = 1 : n2.Value = 0 : l3.Visible = False : l4.Visible = False
        tr1.Enabled = False : tr2.Enabled = False : la.Text = "00:00:00" : lb.Text = "00:00:00"
    End Sub
    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        If t1.Visible = False Then
            t1.Visible = True
        Else
            t1.Visible = False
        End If
    End Sub
End Class
