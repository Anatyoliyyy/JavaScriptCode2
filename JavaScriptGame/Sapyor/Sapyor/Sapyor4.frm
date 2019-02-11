VERSION 5.00
Begin VB.Form Sapyor4 
   BackColor       =   &H00800000&
   BorderStyle     =   1  'Единственный Фиксированный
   Caption         =   "Сфпер:about"
   ClientHeight    =   2775
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4830
   ForeColor       =   &H00808000&
   Icon            =   "Sapyor4.frx":0000
   LinkTopic       =   "Форма2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2775
   ScaleWidth      =   4830
   StartUpPosition =   3  'Окна По Умолчанию
   Begin VB.Timer Часы1 
      Interval        =   50
      Left            =   2370
      Top             =   750
   End
   Begin VB.Line Строка4 
      X1              =   4680
      X2              =   4680
      Y1              =   135
      Y2              =   2610
   End
   Begin VB.Line Строка3 
      X1              =   135
      X2              =   4680
      Y1              =   2610
      Y2              =   2610
   End
   Begin VB.Line Строка2 
      X1              =   150
      X2              =   150
      Y1              =   2595
      Y2              =   120
   End
   Begin VB.Line Строка1 
      X1              =   135
      X2              =   4680
      Y1              =   135
      Y2              =   135
   End
   Begin VB.Label Метка4 
      BackColor       =   &H00800000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   204
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000C0C0&
      Height          =   735
      Left            =   315
      TabIndex        =   3
      Top             =   1770
      Width           =   4200
   End
   Begin VB.Label Метка3 
      BackColor       =   &H00800000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   204
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000C0C0&
      Height          =   690
      Left            =   315
      TabIndex        =   2
      Top             =   1080
      Width           =   4200
   End
   Begin VB.Label Метка2 
      BackColor       =   &H00800000&
      ForeColor       =   &H0000C0C0&
      Height          =   420
      Left            =   315
      TabIndex        =   1
      Top             =   675
      Width           =   4200
   End
   Begin VB.Label Метка1 
      BackColor       =   &H00800000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   204
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000C0C0&
      Height          =   375
      Left            =   315
      TabIndex        =   0
      Top             =   315
      Width           =   4200
   End
End
Attribute VB_Name = "Sapyor4"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Const st = "Эту программу сделал"
Const SName = "Рахимов"
Const Na_me = "Рафис"
Const St1 = "Все вопросы и пожелания,а так же о             найденных ошибках пишите  на e-mail :        Rafis@hotmail.ru"
Const St2 = "Эта программа является Beta версией и    большая просьба о найденных багах             сообщать автору на e-mail:Rafis@hotmail.ru"
Dim F As String
Dim Strin As String
Dim r As Byte, n As Byte, l As Byte
Dim Number As Byte, No As Byte
Private Sub Form_Load()
Number = 1
l = 1
n = 1
Strin = st
Show
End Sub

Private Sub Часы1_Timer()
If No = 1 Then Exit Sub
If Number = 1 Then Call Anim
If Number = 2 Then Call N_ame
If Number = 3 Then Strin = St1: Call Anim
If Number = 4 Then Strin = St2: l = 3: Call Anim
End Sub
Function Anim()

E = Len(Strin)
r = r + 1
F = Left(Strin, E + r - E)
If l = 1 Then Метка1.Caption = F
If l = 2 Then Метка3.Caption = F
If l = 3 Then Метка4.Caption = F
If r > E Then
r = 0
If l = 1 Then Number = 2
If l = 2 Then Number = 4
If l = 3 Then No = 1
End If
End Function
Function N_ame()
With Метка2
.FontSize = n
.FontBold = True
.Caption = SName & Space(1) & Na_me
End With
n = n + 1
If n = 16 Then Number = 3: l = 2
End Function
