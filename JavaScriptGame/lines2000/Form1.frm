VERSION 5.00
Begin VB.Form Form1 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Lines2K"
   ClientHeight    =   6090
   ClientLeft      =   1905
   ClientTop       =   3675
   ClientWidth     =   5280
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "Форма1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6090
   ScaleWidth      =   5280
   ShowInTaskbar   =   0   'False
   Begin VB.Frame Рамка3 
      Height          =   615
      Left            =   0
      TabIndex        =   2
      Top             =   -90
      Width           =   5280
      Begin VB.Timer Blink 
         Interval        =   300
         Left            =   3480
         Top             =   120
      End
      Begin VB.Image Изображение1 
         Height          =   405
         Left            =   4800
         Picture         =   "Form1.frx":0E42
         Top             =   150
         Width           =   405
      End
      Begin VB.Label RecLbl 
         AutoSize        =   -1  'True
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   204
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   3000
         TabIndex        =   9
         Top             =   130
         Width           =   90
      End
      Begin VB.Label Метка2 
         AutoSize        =   -1  'True
         Caption         =   "Score:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   204
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   2400
         TabIndex        =   8
         Top             =   360
         Width           =   465
      End
      Begin VB.Label Метка1 
         AutoSize        =   -1  'True
         Caption         =   "Record:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   204
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   2400
         TabIndex        =   7
         Top             =   130
         Width           =   570
      End
      Begin VB.Line Строка2 
         BorderColor     =   &H00FFFFFF&
         X1              =   2260
         X2              =   2260
         Y1              =   120
         Y2              =   590
      End
      Begin VB.Line Строка1 
         BorderColor     =   &H00808080&
         X1              =   2250
         X2              =   2250
         Y1              =   120
         Y2              =   600
      End
      Begin VB.Image M1 
         Height          =   405
         Index           =   5
         Left            =   1800
         Top             =   150
         Width           =   405
      End
      Begin VB.Image M1 
         Height          =   405
         Index           =   4
         Left            =   1360
         Top             =   150
         Width           =   405
      End
      Begin VB.Image M1 
         Height          =   405
         Index           =   3
         Left            =   930
         Top             =   150
         Width           =   405
      End
      Begin VB.Image M1 
         Height          =   405
         Index           =   2
         Left            =   500
         Top             =   150
         Width           =   405
      End
      Begin VB.Image M1 
         Height          =   405
         Index           =   1
         Left            =   60
         Top             =   150
         Width           =   405
      End
      Begin VB.Label ScoreLbl 
         AutoSize        =   -1  'True
         Caption         =   "0"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   204
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   3000
         TabIndex        =   5
         Top             =   360
         Width           =   90
      End
   End
   Begin VB.Frame Рамка2 
      Height          =   5370
      Left            =   0
      TabIndex        =   1
      Top             =   440
      Width           =   5280
      Begin VB.PictureBox Container 
         BackColor       =   &H00FFFFFF&
         Height          =   5220
         Left            =   30
         ScaleHeight     =   5160
         ScaleWidth      =   5145
         TabIndex        =   3
         Top             =   120
         Width           =   5200
         Begin VB.PictureBox OpenSave 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            BorderStyle     =   0  'None
            ForeColor       =   &H80000008&
            Height          =   5175
            Left            =   0
            ScaleHeight     =   5175
            ScaleWidth      =   5175
            TabIndex        =   21
            Top             =   16000
            Width           =   5175
            Begin VB.CommandButton ExitBtn 
               Caption         =   "&Close"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   204
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   3840
               TabIndex        =   26
               Top             =   4680
               Width           =   1215
            End
            Begin VB.CommandButton Cmd 
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   204
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   2640
               TabIndex        =   25
               Top             =   4680
               Width           =   1125
            End
            Begin VB.TextBox Path 
               Appearance      =   0  'Flat
               Height          =   285
               Left            =   600
               TabIndex        =   24
               Top             =   4320
               Width           =   4455
            End
            Begin VB.FileListBox File1 
               Appearance      =   0  'Flat
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   204
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   3735
               Left            =   120
               TabIndex        =   23
               Top             =   480
               Width           =   4935
            End
            Begin VB.Label Метка5 
               AutoSize        =   -1  'True
               BackStyle       =   0  'Transparent
               Caption         =   "Файл:"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   204
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   195
               Left            =   120
               TabIndex        =   27
               Top             =   4350
               Width           =   450
            End
            Begin VB.Line Строка4 
               X1              =   120
               X2              =   5040
               Y1              =   360
               Y2              =   360
            End
            Begin VB.Label OpenSaveLbl 
               AutoSize        =   -1  'True
               BackStyle       =   0  'Transparent
               Height          =   195
               Left            =   120
               TabIndex        =   22
               Top             =   120
               Width           =   45
            End
         End
         Begin VB.PictureBox AboutPic 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            BorderStyle     =   0  'None
            ForeColor       =   &H80000008&
            Height          =   5175
            Left            =   0
            ScaleHeight     =   5175
            ScaleWidth      =   5175
            TabIndex        =   16
            Top             =   16000
            Width           =   5175
            Begin VB.CommandButton Комманда2 
               Caption         =   "&Close"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   204
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   3600
               TabIndex        =   17
               Top             =   4680
               Width           =   1455
            End
            Begin VB.Label Info2 
               BackStyle       =   0  'Transparent
               Caption         =   "Info2"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   204
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   1335
               Left            =   1080
               TabIndex        =   20
               Top             =   3240
               Width           =   3975
            End
            Begin VB.Label Info1 
               BackStyle       =   0  'Transparent
               Caption         =   "Метка5"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   204
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   2415
               Left            =   1080
               TabIndex        =   19
               Top             =   720
               Width           =   3975
            End
            Begin VB.Label Метка3 
               BackStyle       =   0  'Transparent
               Caption         =   "Lines2K Help And About"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   15.75
                  Charset         =   204
                  Weight          =   700
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   375
               Left            =   1080
               TabIndex        =   18
               Top             =   240
               Width           =   3975
            End
            Begin VB.Image Изображение2 
               Height          =   405
               Left            =   360
               Picture         =   "Form1.frx":1760
               Top             =   360
               Width           =   405
            End
         End
         Begin VB.PictureBox RecordsPic 
            BackColor       =   &H00FFFFFF&
            BorderStyle     =   0  'None
            Height          =   5175
            Left            =   0
            ScaleHeight     =   5175
            ScaleWidth      =   5175
            TabIndex        =   10
            Top             =   16000
            Width           =   5175
            Begin VB.CommandButton Комманда1 
               Caption         =   "&Close"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   204
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   300
               Left            =   3840
               TabIndex        =   11
               Top             =   4780
               Width           =   1215
            End
            Begin VB.Label RecordLbl 
               AutoSize        =   -1  'True
               BackStyle       =   0  'Transparent
               Caption         =   "Очки"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   204
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   195
               Index           =   0
               Left            =   4640
               TabIndex        =   15
               Top             =   480
               Width           =   390
            End
            Begin VB.Label NameLbl 
               AutoSize        =   -1  'True
               BackStyle       =   0  'Transparent
               Caption         =   "Имя рекордсмена"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   204
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   195
               Index           =   0
               Left            =   450
               TabIndex        =   14
               Top             =   480
               Width           =   1320
            End
            Begin VB.Label NumLbl 
               AutoSize        =   -1  'True
               BackStyle       =   0  'Transparent
               Caption         =   "№"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   204
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   195
               Index           =   0
               Left            =   120
               TabIndex        =   13
               Top             =   480
               Width           =   195
            End
            Begin VB.Label Метка4 
               AutoSize        =   -1  'True
               BackStyle       =   0  'Transparent
               Caption         =   "Records"
               BeginProperty Font 
                  Name            =   "Tahoma"
                  Size            =   8.25
                  Charset         =   204
                  Weight          =   400
                  Underline       =   0   'False
                  Italic          =   0   'False
                  Strikethrough   =   0   'False
               EndProperty
               Height          =   195
               Left            =   120
               TabIndex        =   12
               Top             =   120
               Width           =   585
            End
            Begin VB.Line Строка3 
               X1              =   120
               X2              =   5040
               Y1              =   360
               Y2              =   360
            End
         End
         Begin VB.PictureBox P 
            Appearance      =   0  'Flat
            BackColor       =   &H80000005&
            ForeColor       =   &H80000008&
            Height          =   495
            Index           =   0
            Left            =   120
            ScaleHeight     =   465
            ScaleWidth      =   465
            TabIndex        =   4
            Top             =   10000
            Visible         =   0   'False
            Width           =   495
         End
      End
   End
   Begin VB.Frame Рамка1 
      Height          =   375
      Left            =   0
      TabIndex        =   0
      Top             =   5710
      Width           =   5280
      Begin VB.Label InfoLbl 
         AutoSize        =   -1  'True
         Caption         =   "Lines 2000 Edition by Larin Alexsandr Alexsandrovich"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   204
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   120
         TabIndex        =   6
         Top             =   130
         Width           =   3810
      End
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Sub AddNewRecord(Nam As String, rec As Integer)
    On Error Resume Next
    Open PrgPath & "data\records.txt" For Input As #1
    Open PrgPath & "data\records.tmp" For Output As #2
         For i = 1 To 20
             Input #1, cName, crec
             If rec < crec Then
                Write #2, cName, crec
             Else
                Write #2, Nam, rec
                Exit For
             End If
         Next i
         For j = i To 20
             Input #1, cName, crec
             Write #2, cName, crec
         Next j
    Close #1
    Close #2
    Kill PrgPath & "data\records.txt"
    Name PrgPath & "data\records.tmp" As PrgPath & "data\records.txt"
End Sub
Function GetRecord(Place As Integer)
    Open PrgPath & "data\records.txt" For Input As #1
         For i = 1 To Place
         Input #1, Nam, sc
         Next i
    Close #1
    GetRecord = sc
End Function
Sub DestroyPole()
    For i = 1 To 100
        Unload P(i)
    Next i
End Sub
Function GetFree() As Integer
    n = 0
    For i = 1 To 100
        If P(i).Tag = 0 Then n = n + 1
    Next i
    GetFree = n
End Function
Sub AddFigures(Number As Integer)
    Dim A As Integer
    Randomize Timer
    For i = 1 To Number
30:     A = Int(Rnd(1) * 100 + 1)
        B = Int(Rnd(1) * nBalls + 1)
        If P(A).Tag <> 0 Then GoTo 30
        P(A).Tag = B
        P(A).Picture = LoadPicture(PrgPath & "data\balls\" & B & ".jpg")
        ScoreLbl.Caption = ScoreLbl.Caption + DeleteBlox()
    Next i
End Sub
Sub ClearPole()
    For i = 1 To 100
        P(i).Tag = 0
        P(i).Picture = LoadPicture()
    Next i
End Sub
Sub CreatePole()
On Error Resume Next
    Dim L, T As Integer
    L = 100
    T = 100
    For i = 1 To 100
        Load P(i)
        P(i).Tag = 0
        P(i).Top = T
        P(i).Left = L
        P(i).Visible = True
        T = 100 + P(0).Height * Int(i / 10)
        L = 100 + P(0).Width * (i Mod 10)
    Next i
End Sub

Private Sub Blink_Timer()
    For i = 1 To 100
        If i <> Selected Then P(i).Visible = True
    Next i
    If P(Selected).Visible = True Then
       P(Selected).Visible = False
       Exit Sub
    Else
       P(Selected).Visible = True
       Exit Sub
    End If
End Sub
Private Sub Cmd_Click()
Select Case Cmd.Caption
       Case "Сохранить"
            tmp = ""
            For i = 1 To 100
                tmp = tmp & P(i).Tag
            Next i
            Open PrgPath & "data\saves\" & Path.Text For Output As #1
                 Print #1, tmp
            Close #1
            OpenSave.Top = 16000
            File1.Refresh
       Case "Открыть"
            Open PrgPath & "data\saves\" & Path.Text For Input As #1
                 Line Input #1, lin
            Close #1
            For i = 1 To 100
                P(i).Tag = Mid(lin, i, 1)
                If P(i).Tag = 0 Then P(i).Picture = LoadPicture() Else P(i).Picture = LoadPicture(PrgPath & "data\balls\" & P(i).Tag & ".jpg")
            Next i
            OpenSave.Top = 16000
End Select
End Sub
Private Sub Container_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
RefreshMenu
End Sub
Private Sub ExitBtn_Click()
OpenSave.Top = 16000
End Sub
Private Sub File1_Click()
Path.Text = File1.FileName
End Sub
Private Sub Form_Load()
File1.Path = PrgPath & "data\saves\"
    RefreshMenu
    CreatePole
    AddFigures (5)
    Selected = 0
    FillRecords
    RecLbl.Caption = GetRecord(1)
    Info1.Caption = "Цель игры набрать как можно больше очков, которые даются если исчезает линия длины 5-9 шариков одного цвета по горизонтали, вертикали или диагонали. За каждый исчезнувший шарик вы получаете 1 очко. Игра кончается, когда всё поле будет заполнено шариками. При запуске игры можно указать количество разных цветов шариков, например 'lines2k 7' - оптимальный вариант по критерию сложность/очки. Удачи!"
    Info2.Caption = "Программа написана на Visual Basic`е 6.0. Автор и разработчик - Ларин Александр Александрович." & vbCrLf & "www.crosswinds.net/~extremus" & vbCrLf & "www.sdr2k.newmail.ru (скоро)" & vbCrLf & "E-mail: cyberpunk3d@mail.ru" & vbCrLf & "ICQ: 64979765"
End Sub
Private Sub M1_Click(Index As Integer)
    Select Case Index
           Case 1
                AboutPic.Top = 16000
                RecordsPic.Top = 16000
                OpenSave.Top = 16000
                Dialog.Tag = "no"
                Dialog.Caption = "Lines2K..."
                Dialog.Lbl.Caption = "Вы действительно желаете начать новую игру?"
                Dialog.Show vbModal, Me
                If Dialog.Tag = "ok" Then
                   ClearPole
                   Call Form_Load
                   ScoreLbl.Caption = 0
                End If
           Case 4
                OpenSave.Top = 16000
                AboutPic.Top = 16000
                RecordsPic.Top = 0
           Case 5
                OpenSave.Top = 16000
                RecordsPic.Top = 16000
                AboutPic.Top = 0
           Case 2
                AboutPic.Top = 16000
                RecordsPic.Top = 16000
                OpenSave.Top = 0
                OpenSaveLbl.Caption = "Открыть игру..."
                Cmd.Caption = "Открыть"
                Path.Text = ""
           Case 3
                AboutPic.Top = 16000
                RecordsPic.Top = 16000
                OpenSave.Top = 0
                OpenSaveLbl.Caption = "Сохранить игру..."
                Cmd.Caption = "Сохранить"
                Path.Text = ""
    End Select
End Sub
Private Sub M1_MouseMove(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
RefreshMenu
M1(Index).Picture = LoadPicture(PrgPath & "data\menu\" & Index & "a.jpg")
End Sub
Private Sub P_Click(Index As Integer)
    Dim score As Integer
    Dim Nam As String
    If Selected <> 0 Then
       If P(Index).Tag = 0 Then
          Reset
          If CanBeMovedHere(Selected, Index) = True Then
             P(Index).Tag = P(Selected).Tag
             P(Index).Picture = P(Selected).Picture
             P(Selected).Picture = LoadPicture()
             score = DeleteBlox()
             P(Selected).Tag = 0
             Selected = 0
             If score = 0 Then
                X = GetFree()
                If X >= 3 Then X = 3
                AddFigures (X)
                If GetFree = 0 Then
                   score = DeleteBlox()
                   If score = 0 Then
                      If ScoreLbl >= GetRecord(20) Then
                         Nam = InputBox("Вы попали в Top20! Введите ваше имя:")
                         If Trim(Nam) = "" Then Nam = "anonymouse"
                         Nam = Mid(Nam, 1, 20)
                         AddNewRecord Nam, ScoreLbl.Caption
                      End If
                      ScoreLbl.Caption = 0
                      FillRecords
                      RecLbl.Caption = GetRecord(1)
                      DestroyPole
                      Call Form_Load
                   End If
                End If
             End If
             ScoreLbl.Caption = ScoreLbl.Caption + score
          End If
       Else
          Selected = Index
       End If
    Else
       If P(Index).Tag <> 0 Then Selected = Index
    End If
End Sub
Private Sub RecordsPic_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
RefreshMenu
End Sub
Private Sub Изображение1_Click()
On Error Resume Next
X = Shell("start www.crosswinds.net/~extremus", vbHide)
End Sub
Private Sub Комманда1_Click()
RecordsPic.Top = 16000
End Sub
Sub FillRecords()
On Error Resume Next
ctop = 700
Open PrgPath & "data\records.txt" For Input As #1
For i = 1 To 20
    Input #1, Nam, sc
    Load NumLbl(i)
    Load NameLbl(i)
    Load RecordLbl(i)
    NumLbl(i).Caption = i & "."
    NameLbl(i).Caption = Nam
    RecordLbl(i).Caption = sc
    NumLbl(i).Top = ctop
    NameLbl(i).Top = ctop
    RecordLbl(i).Top = ctop
    NumLbl(i).Visible = True
    NameLbl(i).Visible = True
    RecordLbl(i).Visible = True
    ctop = ctop + 200
Next i
Close #1
End Sub
Private Sub Комманда2_Click()
AboutPic.Top = 16000
End Sub
Private Sub Рамка3_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
RefreshMenu
End Sub
Sub RefreshMenu()
For i = 1 To 5
    M1(i).Picture = LoadPicture(PrgPath & "data\menu\" & i & ".jpg")
Next i
End Sub
