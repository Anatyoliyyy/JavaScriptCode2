VERSION 5.00
Begin VB.Form Sapyor 
   AutoRedraw      =   -1  'True
   BackColor       =   &H00800000&
   BorderStyle     =   1  '������������ �������������
   Caption         =   "����"
   ClientHeight    =   3450
   ClientLeft      =   5535
   ClientTop       =   2445
   ClientWidth     =   3075
   Icon            =   "Sapyor.frx":0000
   LinkTopic       =   "�����1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3450
   ScaleWidth      =   3075
   Begin VB.Timer ����2 
      Interval        =   1000
      Left            =   630
      Top             =   2190
   End
   Begin VB.PictureBox Happy 
      AutoSize        =   -1  'True
      BorderStyle     =   0  '������
      ForeColor       =   &H8000000D&
      Height          =   435
      Left            =   1440
      Picture         =   "Sapyor.frx":1CFA
      ScaleHeight     =   435
      ScaleWidth      =   375
      TabIndex        =   5
      Top             =   0
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.PictureBox Strah 
      AutoSize        =   -1  'True
      BorderStyle     =   0  '������
      Height          =   435
      Left            =   1800
      Picture         =   "Sapyor.frx":1F4C
      ScaleHeight     =   435
      ScaleWidth      =   375
      TabIndex        =   4
      Top             =   0
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.PictureBox Dead 
      AutoSize        =   -1  'True
      BorderStyle     =   0  '������
      Height          =   435
      Left            =   2160
      Picture         =   "Sapyor.frx":219E
      ScaleHeight     =   435
      ScaleWidth      =   375
      TabIndex        =   3
      Top             =   0
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.CommandButton ��������1 
      Height          =   315
      Left            =   2550
      TabIndex        =   2
      ToolTipText     =   "���������"
      Top             =   3120
      Width           =   315
   End
   Begin VB.Timer ����1 
      Interval        =   1000
      Left            =   630
      Top             =   1800
   End
   Begin VB.Line ������5 
      DrawMode        =   16  'Merge Pen
      X1              =   2820
      X2              =   2820
      Y1              =   480
      Y2              =   3090
   End
   Begin VB.Line ������4 
      DrawMode        =   16  'Merge Pen
      X1              =   210
      X2              =   2840
      Y1              =   480
      Y2              =   480
   End
   Begin VB.Line ������3 
      DrawMode        =   16  'Merge Pen
      X1              =   210
      X2              =   210
      Y1              =   3090
      Y2              =   480
   End
   Begin VB.Line ������2 
      DrawMode        =   16  'Merge Pen
      X1              =   210
      X2              =   2840
      Y1              =   3090
      Y2              =   3090
   End
   Begin VB.Line ������1 
      BorderStyle     =   0  '�������
      X1              =   2790
      X2              =   2790
      Y1              =   3150
      Y2              =   510
   End
   Begin VB.Label �����3 
      Height          =   345
      Left            =   1500
      TabIndex        =   6
      Top             =   2520
      Visible         =   0   'False
      Width           =   255
   End
   Begin VB.Label �����2 
      BackColor       =   &H00800000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   204
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000C000&
      Height          =   345
      Left            =   210
      TabIndex        =   1
      Top             =   3090
      Width           =   2565
   End
   Begin VB.Label �����1 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   204
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      Index           =   1
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   285
   End
   Begin VB.Menu Menu 
      Caption         =   "&����"
      WindowList      =   -1  'True
      Begin VB.Menu NewGame 
         Caption         =   "&����� ����"
      End
      Begin VB.Menu Line1 
         Caption         =   "-"
      End
      Begin VB.Menu Option 
         Caption         =   "&���������"
      End
      Begin VB.Menu Record 
         Caption         =   "&�������"
      End
      Begin VB.Menu Line2 
         Caption         =   "-"
      End
      Begin VB.Menu Exit 
         Caption         =   "&�����"
      End
   End
   Begin VB.Menu Spravka 
      Caption         =   "&�������"
      Begin VB.Menu Help 
         Caption         =   "&������"
      End
      Begin VB.Menu About 
         Caption         =   "&About"
      End
   End
End
Attribute VB_Name = "Sapyor"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'
Dim s As Integer, Mina As Integer
Dim n As Byte, Numb As Byte, r As Byte
Dim p As Integer
Dim Konets As Boolean, Hlp As Boolean, Sto_p As Boolean, Mozno As Boolean
Dim Hou As Integer, Min As Integer, Sec As Integer
Dim M(11, 11) As Integer, M1(100) As Integer, M2(100) As Integer

'���������� ��������
Dim Re(10) As String, Re1(10) As String, Re2(10) As String
Dim Ra1 As String, Ra2 As String
Dim Rec As Integer, Rec2 As String
Dim nomer As Integer, q As Integer
Dim Msg As String, Skoka As String
'
Private Sub About_Click()
'�������� About
Sapyor4.Show
End Sub
Private Sub Exit_Click()
'�����
End
End Sub
Private Sub Form_Initialize()
'�������� ������������� �����
dr = Dir(App.Path & "Records.rec")
'
'���� ���� �� ������, �������� �� ���������
If dr = "" Then
Open App.Path & "\Records.rec" For Output As #2
Print #2, "10"
Print #2, "10000     �����                                10000"
Print #2, "7500      �����                                7500"
Print #2, "5000      �����                                5000"
Print #2, "4000      �����                                4000"
Print #2, "3000      �����                                3000"
Print #2, "2000      �����                                2000"
Print #2, "1000      �����                                1000"
Print #2, "500       �����                                500"
Print #2, "250       �����                                250"
Print #2, "1         �����                                1"
Close #2
End If
'
Call Ne_w
End Sub
Private Sub Form_Load()
��������1.Caption = r
Mina = 10
st = Mina
n = 10
AH = 255
AW = 255
'����������� ������ ������
With �����1(1)
.Top = 530
.Left = 250
.Height = AH - 20
.Width = AW - 20
End With
'���������� ��������� ����� �
'����������� �� ��������� � �������
For i = 2 To n * n
Load �����1(i)
With �����1(i)
.Top = AW * ((i - 1) Mod n) + 530
.Left = AH * ((i - 1) \ n) + 250
.Visible = True
.Width = AW - 20
.Height = AH - 20
End With
Next i
End Sub
Private Sub Happy_Click()
MsgBox "�� ������ ����, � �����", vbExclamation, "����"
End Sub
Private Sub Help_Click()
Sapyor3.Show
End Sub
Private Sub NewGame_Click()
Call Ne_w
End Sub
Private Sub Option_Click()
Sapyor2.Show
End Sub
Private Sub Record_Click()
Sapyor5.Show
End Sub
Private Sub ��������1_Click()
'������� ���-�� �������������� ���������
If r = 3 Then MsgBox "�� ��� ������������ 3 ���������", vbInformation, "����": Exit Sub
If Mozno = False Then MsgBox "� ��� ��� ���� �� �������������� ���������", vbInformation, "����": Exit Sub
Mozno = False
r = r + 1
��������1.Caption = r
Hlp = True
End Sub
Private Sub �����1_MouseDown(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
If Sto_p = True Then Exit Sub
'���� ������ ������ ������ �����
If Button = 2 Then
With �����1(Index)
For i = 1 To 100
If M2(i) = 11 Then
MsgBox M2(i)
End If
Next i
If �����1(Index).BorderStyle = 1 Then Exit Sub
.Caption = " !"
.ForeColor = vbYellow
.BackColor = vbGreen
.FontSize = 12
End With
End If

'���� ������ ����� ������ �����
If Button = 1 Then
Happy.Visible = False
With Strah
.Left = 1330
.Top = 50
.Visible = True
End With
If Sto_p = True Then Exit Sub

With �����1(Index)
.Alignment = 1
.FontSize = 8
.BackColor = &H8000000F
.Caption = ""
'���� ��� ����,�� ��-�����
If �����1(Index).Tag = 11 Then
'���� ����� ���������, �� �� �����
If Hlp = True Then MsgBox "�� ��������, ��� �����", vbInformation, "����": Hlp = False: Exit Sub
�����1(Index).BackColor = vbRed
Strah.Visible = False

With Dead
.Left = 1330
.Top = 50
.Visible = True
End With
MsgBox "����� ��������� ���� �������", vbInformation, "�����": Sto_p = True: Exit Sub
End If
If �����1(Index).Caption <> "" Then GoTo Z
g = �����1(Index).Tag
.ForeColor = vbBlack
.BorderStyle = 1
.Caption = g
End With
Z:
If Hlp = True Then Hlp = False
End If
Mozno = True
End Sub

Private Sub �����1_MouseUp(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
If Sto_p = True Then Exit Sub
Strah.Visible = False
With Happy
.Left = 1330
.Top = 50
.Visible = True
End With
End Sub

Private Sub ����1_Timer()
If Sto_p = True Then Exit Sub
If �����3.Caption <> "" Then
st = �����3.Caption
Mina = st
�����3.Caption = ""
Call Ne_w
End If
'����������� ����, ��� �� ���� �����������
For i = 1 To 100
If M1(i) = 11 And �����1(i).BackColor = vbGreen Then Numb = Numb + 1
Next i
'��������� ���-�� ������������� � ���-�� ���
If Numb = Mina Then
For i = 1 To 100
If �����1(i).Tag = 11 Then �����1(i).BackColor = vbGreen: Sto_p = True
Next i
MsgBox "���������� �� ��������!!!", vbInformation, "����"
Call Records
End If
Numb = 0
End Sub
Function Ne_w()
'��������� ��������
'� ���������� �������� �� ���������
p = 0
Sec = 0
Min = 0
Hou = 0
r = 0
��������1.Caption = r
Mozno = True
For i = 1 To 10
For j = 1 To 10
M(i, j) = 0
Next j, i
For i = 1 To 100
With �����1(i)
.BorderStyle = 0
.Caption = ""
.BackColor = &H8000000F
End With
Next i
Sto_p = False
Dead.Visible = False
Strah.Visible = False
With Happy
.Left = 1330
.Top = 50
.Visible = True
 End With
Call New_Game1
End Function

Function New_Game1()
'����������� ��������� ���
Randomize Timer
For i = 1 To Mina
k:
t1 = Int(Rnd * 10) + 1
t2 = Int(Rnd * 10) + 1
If t1 = 0 Then GoTo k
If M(t1, t2) = 11 Then GoTo k
M(t1, t2) = 11
Next i
Call New_Game2
End Function
Function New_Game2()
'����������� ����� ��� ����������� ����� � ������ �������
p = 0
For i = 1 To 10
For j = 1 To 10
p = p + 1
s = 0
For i1 = -1 To 1
For j1 = -1 To 1
If M(i, j) = 11 Then �����1(p).Tag = 11: M1(p) = 11: GoTo l
If M(i + i1, j + j1) = 11 Then s = s + 1
Next j1
Next i1
�����1(p).Tag = s
If �����1(p).BorderStyle = 1 Then �����1(p).Caption = s
l:
Next j, i
For i = 1 To 10
For j = 1 To 10
M(i, j) = 0
Next j, i
End Function
Function Records()
'������� �����
Rec = (((Mina * 10 - Hou * 3600 - Min * 60 - Sec) + 5000) / (r + 1)) + Mina * 100
Rec2 = Rec
Open App.Path & "\Records.rec" For Input As #1
Line Input #1, Skoka
For i = 1 To Skoka
Line Input #1, Re(i)
Re1(i) = Mid(Re(i), 1, 10)
Next i
Close #1
'���� ��������� ���� ������ �������, �� ������������ � �������
For i = 1 To Skoka
If Re1(i) < Rec Then
nomer = i
q = 1
Msg = InputBox("������� ��� ���", "����", "�����")
If Msg = "" Then
Msg = "Ananimus"
End If
If Skoka < 10 Then Skoka = Skoka + 1
Call Proverka
GoTo E_n
End If
Next i
E_n: End Function
Function Proverka()
'�������� ����� ����� ������ �� �����
For i = 1 To Skoka
If i = nomer And Skoka <> 10 Then
Ra1 = Rec2 + Space(10)
Ra2 = Msg + Space(10)
Re2(i) = Mid(Ra1, 1, 10) + (Mid(Ra2, 1, 20)) + Space(16) + (Rec2)
g = 1
End If
If i = nomer And Skoka = 10 Then
Ra1 = Rec2 + Space(10)
Ra2 = Msg + Space(10)
Re2(i) = Mid(Ra1, 1, 10) + (Mid(Ra2, 1, 20)) + Space(21) + (Rec2)
u = -1
GoTo k
End If
Re2(i + g) = Re(i + u)
k:
Next i
'������ ����� ���������� � ����
Open App.Path & "\Records.rec" For Output As #2
Print #2, Skoka
For j = 1 To Skoka
Print #2, Re2(j)
Next j
Close #2
End Function

Private Sub ����2_Timer()
'���� ���� ���������, �� ����� ���������������
If Sto_p = True Then Exit Sub
'������� ����, ������� ������� ������
Sec = Sec + 1
If Sec = 60 Then Min = Min + 1: Sec = 0
If Min = 60 Then Hou = Hou + 1: Min = 0
�����2.Caption = "������:" & Hou & " : " & Min & " : " & Sec
End Sub
