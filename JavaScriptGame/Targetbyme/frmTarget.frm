VERSION 5.00
Begin VB.Form frmTarget 
   BackColor       =   &H00008080&
   Caption         =   "Мишень"
   ClientHeight    =   5715
   ClientLeft      =   1740
   ClientTop       =   1545
   ClientWidth     =   6825
   Icon            =   "frmTarget.frx":0000
   LinkTopic       =   "Form1"
   MouseIcon       =   "frmTarget.frx":0442
   MousePointer    =   99  'Custom
   ScaleHeight     =   5715
   ScaleWidth      =   6825
   Begin VB.Timer tmrTrup 
      Enabled         =   0   'False
      Interval        =   10
      Left            =   1980
      Top             =   2640
   End
   Begin VB.Timer trmGo 
      Interval        =   800
      Left            =   960
      Top             =   2640
   End
   Begin VB.Timer trmTime 
      Interval        =   1000
      Left            =   1440
      Top             =   2640
   End
   Begin VB.Image imgKil 
      Height          =   600
      Left            =   1560
      Picture         =   "frmTarget.frx":074C
      Top             =   960
      Visible         =   0   'False
      Width           =   720
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Осталось"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   204
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Left            =   60
      TabIndex        =   3
      Top             =   180
      Width           =   1335
   End
   Begin VB.Label lblNumber 
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   11.25
         Charset         =   204
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   315
      Left            =   4500
      TabIndex        =   2
      Top             =   180
      Width           =   1215
   End
   Begin VB.Label lblName 
      BackStyle       =   0  'Transparent
      Caption         =   "Количество"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   11.25
         Charset         =   204
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Left            =   2880
      TabIndex        =   1
      Top             =   180
      Width           =   1515
   End
   Begin VB.Label lblTime 
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   11.25
         Charset         =   204
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   315
      Left            =   1500
      TabIndex        =   0
      Top             =   180
      Width           =   1035
   End
   Begin VB.Image ImgTarget 
      Height          =   480
      Left            =   3900
      Picture         =   "frmTarget.frx":1F56
      Top             =   3060
      Width           =   480
   End
End
Attribute VB_Name = "frmTarget"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim ClickNumber As Integer
Dim CurrentTime As Integer





Private Sub Form_Click()

PlayMusic "mimo.WAV"
End Sub

Private Sub Form_Load()
Call Init
If App.PrevInstance Then
MsgBox "Приложение уже запущено!", vbExclamation, "Visual Basic 6.0"
End
End If
End Sub

Private Sub PlayMusic(NameMusic As String)
    PlaySound App.Path & "\Sounds\" & NameMusic, ByVal 0&, SND_FILENAME Or SND_ASYNC
End Sub

Private Sub Init()
ClickNumber = 0
CurrentTime = FrmTools.txtTime.Text

lblNumber = 0
lblTime.Caption = CurrentTime
Call ShowTarget
End Sub

Private Sub ShowTarget()
Dim CurrentX As Integer
Dim CurrentY As Integer
Randomize
CurrentX = Int(Rnd * (ScaleWidth - ImgTarget.Width))
CurrentY = Int(Rnd * (ScaleHeight - ImgTarget.Height - 500)) + 500
ImgTarget.Move CurrentX, CurrentY
End Sub



Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)

MsgBox "Неужели Вы хотите выйти из этой замечательной программы?", vbYesNo + vbQuestion, "Мишень 2.1 by Mike"

Cancel = True
End Sub

Private Sub ImgTarget_Click()
PlayMusic "yes.WAV"

tmrTrup.Enabled = True




ClickNumber = ClickNumber + 1
lblNumber = ClickNumber
Call ShowTarget
End Sub



Private Sub Timer1_Timer()
ImgTarget.Picture = imgKil.Picture
End Sub

Private Sub trmGo_Timer()
Call ShowTarget
End Sub

Private Sub trmTime_Timer()
Dim Res
  With lblTime
  CurrentTime = CurrentTime - 1
  lblTime.Caption = CurrentTime
  If CurrentTime = 0 Then
  Res = "Результат:" & CStr(ClickNumber)
  Res = Res & Chr(13) & Chr(10)
  Res = Res & "Начать заново?"
  Res = MsgBox(Res, vbQuestion + vbYesNo, "Мишень")
  If Res = vbNo Then
  End
  Else
    Call Init
    End If
    End If
    End With
End Sub
