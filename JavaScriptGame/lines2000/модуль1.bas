Attribute VB_Name = "Модуль1"
Global Seeked(1 To 100) As Boolean
Global Selected As Integer
Global DestroyLine As String
Global PrgPath As String
Global nBalls As Integer
Sub main()
    If Len(App.Path) = 3 Then PrgPath = App.Path Else PrgPath = App.Path & "\"
    If Trim(Command$) = "" Then nBalls = 5 Else nBalls = Trim(Command$)
    Form1.Show
End Sub
Function Destroy(sLine As String)
    Dim mas(1 To 100) As Boolean
    For i = 1 To 100
        mas(i) = False
    Next i
    sLine = sLine & " "
    tmp = ""
    For i = 1 To Len(sLine)
        Select Case Mid(sLine, i, 1)
               Case " "
                    If tmp <> "" Then
                       mas(tmp) = True
                       tmp = ""
                    End If
               Case Else
                    tmp = tmp & Mid(sLine, i, 1)
        End Select
    Next i
    n = 0
    For i = 1 To 100
        If mas(i) = True Then
           Form1.P(i).Picture = LoadPicture()
           Form1.P(i).Tag = 0
           n = n + 1
        End If
    Next i
    Destroy = n
End Function
Sub Reset()
    For i = 1 To 100
        Seeked(i) = False
    Next i
End Sub
Function CanBeMovedHere(From, Where As Integer) As Boolean
    Dim res As Boolean: Dim Dw, Lf, Rt, Up As Integer: Dw = From + 10: Lf = From - 1: Rt = From + 1: Up = From - 10
    If From = Where Then CanBeMovedHere = True Else CanBeMovedHere = False
    With Form1
    Select Case From
           Case 1
                If .P(Rt).Tag = 0 And Seeked(Rt) = False Then
                   Seeked(Rt) = True
                   res = CanBeMovedHere(Rt, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
                If .P(Dw).Tag = 0 And Seeked(Dw) = False Then
                   Seeked(Dw) = True
                   res = CanBeMovedHere(Dw, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
           Case 10
                If .P(Dw).Tag = 0 And Seeked(Dw) = False Then
                   Seeked(Dw) = True
                   res = CanBeMovedHere(Dw, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
                If .P(Lf).Tag = 0 And Seeked(Lf) = False Then
                   Seeked(Lf) = True
                   res = CanBeMovedHere(Lf, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
           Case 91
                If .P(Rt).Tag = 0 And Seeked(Rt) = False Then
                   Seeked(Rt) = True
                   res = CanBeMovedHere(Rt, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
                If .P(Up).Tag = 0 And Seeked(Up) = False Then
                   Seeked(Up) = True
                   res = CanBeMovedHere(Up, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
           Case 100
                If .P(Lf).Tag = 0 And Seeked(Lf) = False Then
                   Seeked(Lf) = True
                   res = CanBeMovedHere(Lf, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
                If .P(Up).Tag = 0 And Seeked(Up) = False Then
                   Seeked(Up) = True
                   res = CanBeMovedHere(Up, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
           Case 2 To 9
                If .P(Rt).Tag = 0 And Seeked(Rt) = False Then
                   Seeked(Rt) = True
                   res = CanBeMovedHere(Rt, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
                If .P(Dw).Tag = 0 And Seeked(Dw) = False Then
                   Seeked(Dw) = True
                   res = CanBeMovedHere(Dw, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
                If .P(Lf).Tag = 0 And Seeked(Lf) = False Then
                   Seeked(Lf) = True
                   res = CanBeMovedHere(Lf, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
           Case 92 To 99
                If .P(Rt).Tag = 0 And Seeked(Rt) = False Then
                   Seeked(Rt) = True
                   res = CanBeMovedHere(Rt, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
                If .P(Lf).Tag = 0 And Seeked(Lf) = False Then
                   Seeked(Lf) = True
                   res = CanBeMovedHere(Lf, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
                If .P(Up).Tag = 0 And Seeked(Up) = False Then
                   Seeked(Up) = True
                   res = CanBeMovedHere(Up, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
           Case 11, 21, 31, 41, 51, 61, 71, 81
                If .P(Rt).Tag = 0 And Seeked(Rt) = False Then
                   Seeked(Rt) = True
                   res = CanBeMovedHere(Rt, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
                If .P(Dw).Tag = 0 And Seeked(Dw) = False Then
                   Seeked(Dw) = True
                   res = CanBeMovedHere(Dw, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
                If .P(Up).Tag = 0 And Seeked(Up) = False Then
                   Seeked(Up) = True
                   res = CanBeMovedHere(Up, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
           Case 20, 30, 40, 50, 60, 70, 80, 90
                If .P(Dw).Tag = 0 And Seeked(Dw) = False Then
                   Seeked(Dw) = True
                   res = CanBeMovedHere(Dw, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
                If .P(Lf).Tag = 0 And Seeked(Lf) = False Then
                   Seeked(Lf) = True
                   res = CanBeMovedHere(Lf, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
                If .P(Up).Tag = 0 And Seeked(Up) = False Then
                   Seeked(Up) = True
                   res = CanBeMovedHere(Up, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
           Case Else
                If .P(Rt).Tag = 0 And Seeked(Rt) = False Then
                   Seeked(Rt) = True
                   res = CanBeMovedHere(Rt, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
                If .P(Dw).Tag = 0 And Seeked(Dw) = False Then
                   Seeked(Dw) = True
                   res = CanBeMovedHere(Dw, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
                If .P(Lf).Tag = 0 And Seeked(Lf) = False Then
                   Seeked(Lf) = True
                   res = CanBeMovedHere(Lf, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
                If .P(Up).Tag = 0 And Seeked(Up) = False Then
                   Seeked(Up) = True
                   res = CanBeMovedHere(Up, Where)
                   If res = True Then
                      CanBeMovedHere = True
                      Exit Function
                   End If
                End If
    End Select
    End With
End Function
Function DeleteBlox() As Integer
    Dim tY1 As String
    Dim i As Integer
    DestroyLine = ""
    With Form1
    For j = 0 To 9
    For i = 1 To 6
        If IsLineEqual(.P(j * 10 + i).Tag & .P(j * 10 + i + 1).Tag & .P(j * 10 + i + 2).Tag & .P(j * 10 + i + 3).Tag & .P(j * 10 + i + 4).Tag) = True Then
           DestroyLine = DestroyLine & " " & j * 10 + i & " " & j * 10 + i + 1 & " " & j * 10 + i + 2 & " " & j * 10 + i + 3 & " " & j * 10 + i + 4
        End If
    Next i
    Next j
    For i = 1 To 60
        If IsLineEqual(.P(i).Tag & .P(i + 10).Tag & .P(i + 20).Tag & .P(i + 30).Tag & .P(i + 40).Tag) = True Then
           DestroyLine = DestroyLine & " " & i & " " & i + 10 & " " & i + 20 & " " & i + 30 & " " & i + 40
        End If
    Next i
    For i = 1 To 6
    X = GetFiveFromDiag1(i)
    tY1 = Mid(X, 1, 5)
    ty2 = Mid(X, 6, Len(X) - 5)
    If IsLineEqual(tY1) = True Then DestroyLine = DestroyLine & ty2
    Next i
    For i = 11 To 16
    X = GetFiveFromDiag1(i)
    tY1 = Mid(X, 1, 5)
    ty2 = Mid(X, 6, Len(X) - 5)
    If IsLineEqual(tY1) = True Then DestroyLine = DestroyLine & ty2
    Next i
    For i = 21 To 26
    X = GetFiveFromDiag1(i)
    tY1 = Mid(X, 1, 5)
    ty2 = Mid(X, 6, Len(X) - 5)
    If IsLineEqual(tY1) = True Then DestroyLine = DestroyLine & ty2
    Next i
    For i = 31 To 36
    X = GetFiveFromDiag1(i)
    tY1 = Mid(X, 1, 5)
    ty2 = Mid(X, 6, Len(X) - 5)
    If IsLineEqual(tY1) = True Then DestroyLine = DestroyLine & ty2
    Next i
    For i = 41 To 46
    X = GetFiveFromDiag1(i)
    tY1 = Mid(X, 1, 5)
    ty2 = Mid(X, 6, Len(X) - 5)
    If IsLineEqual(tY1) = True Then DestroyLine = DestroyLine & ty2
    Next i
    For i = 51 To 56
    X = GetFiveFromDiag1(i)
    tY1 = Mid(X, 1, 5)
    ty2 = Mid(X, 6, Len(X) - 5)
    If IsLineEqual(tY1) = True Then DestroyLine = DestroyLine & ty2
    Next i
    For i = 41 To 46
    X = GetFiveFromDiag2(i)
    tY1 = Mid(X, 1, 5)
    ty2 = Mid(X, 6, Len(X) - 5)
    If IsLineEqual(tY1) = True Then DestroyLine = DestroyLine & ty2
    Next i
    For i = 51 To 56
    X = GetFiveFromDiag2(i)
    tY1 = Mid(X, 1, 5)
    ty2 = Mid(X, 6, Len(X) - 5)
    If IsLineEqual(tY1) = True Then DestroyLine = DestroyLine & ty2
    Next i
    For i = 61 To 66
    X = GetFiveFromDiag2(i)
    tY1 = Mid(X, 1, 5)
    ty2 = Mid(X, 6, Len(X) - 5)
    If IsLineEqual(tY1) = True Then DestroyLine = DestroyLine & ty2
    Next i
    For i = 71 To 76
    X = GetFiveFromDiag2(i)
    tY1 = Mid(X, 1, 5)
    ty2 = Mid(X, 6, Len(X) - 5)
    If IsLineEqual(tY1) = True Then DestroyLine = DestroyLine & ty2
    Next i
    For i = 81 To 86
    X = GetFiveFromDiag2(i)
    tY1 = Mid(X, 1, 5)
    ty2 = Mid(X, 6, Len(X) - 5)
    If IsLineEqual(tY1) = True Then DestroyLine = DestroyLine & ty2
    Next i
    For i = 91 To 96
    X = GetFiveFromDiag2(i)
    tY1 = Mid(X, 1, 5)
    ty2 = Mid(X, 6, Len(X) - 5)
    If IsLineEqual(tY1) = True Then DestroyLine = DestroyLine & ty2
    Next i
    DeleteBlox = Destroy(DestroyLine)
    DestroyLine = ""
    End With
End Function
Function IsLineEqual(sLine As String) As Boolean
    IsLineEqual = True
    sym = Mid(sLine, 1, 1)
    If sym = 0 Then
       IsLineEqual = False
       Exit Function
    End If
    For i = 2 To Len(sLine)
        If Mid(sLine, i, 1) <> sym Then IsLineEqual = False
    Next i
End Function
Function GetFiveFromDiag1(FromPoint As Integer)
    GetFiveFromDiag1 = ""
    tmp = " "
    For i = 0 To 4
        GetFiveFromDiag1 = GetFiveFromDiag1 & Form1.P(FromPoint + 11 * i).Tag
        tmp = tmp & " " & FromPoint + 11 * i
    Next i
    GetFiveFromDiag1 = GetFiveFromDiag1 & tmp
End Function
Function GetFiveFromDiag2(FromPoint As Integer)
    GetFiveFromDiag2 = ""
    tmp = " "
    For i = 0 To 4
        GetFiveFromDiag2 = GetFiveFromDiag2 & Form1.P(FromPoint - 9 * i).Tag
        tmp = tmp & " " & FromPoint - 9 * i
    Next i
    GetFiveFromDiag2 = GetFiveFromDiag2 & tmp
End Function
