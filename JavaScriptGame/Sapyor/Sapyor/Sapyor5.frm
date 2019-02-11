VERSION 5.00
Begin VB.Form Sapyor5 
   BorderStyle     =   1  'Единственный Фиксированный
   Caption         =   "Сапёр:Рекорды"
   ClientHeight    =   3870
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   3735
   Icon            =   "Sapyor5.frx":0000
   LinkTopic       =   "Форма1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3870
   ScaleWidth      =   3735
   StartUpPosition =   3  'Окна По Умолчанию
   Begin VB.Line Строка2 
      X1              =   2670
      X2              =   2670
      Y1              =   300
      Y2              =   3570
   End
   Begin VB.Line Строка1 
      X1              =   690
      X2              =   690
      Y1              =   3540
      Y2              =   300
   End
   Begin VB.Label Метка1 
      BorderStyle     =   1  'Единственный Фиксированный
      Height          =   315
      Index           =   10
      Left            =   390
      TabIndex        =   9
      Top             =   3270
      Width           =   2895
   End
   Begin VB.Label Метка1 
      BorderStyle     =   1  'Единственный Фиксированный
      Height          =   315
      Index           =   9
      Left            =   390
      TabIndex        =   8
      Top             =   2940
      Width           =   2895
   End
   Begin VB.Label Метка1 
      BorderStyle     =   1  'Единственный Фиксированный
      Height          =   315
      Index           =   8
      Left            =   390
      TabIndex        =   7
      Top             =   2610
      Width           =   2895
   End
   Begin VB.Label Метка1 
      BorderStyle     =   1  'Единственный Фиксированный
      Height          =   315
      Index           =   7
      Left            =   390
      TabIndex        =   6
      Top             =   2280
      Width           =   2895
   End
   Begin VB.Label Метка1 
      BorderStyle     =   1  'Единственный Фиксированный
      Height          =   315
      Index           =   6
      Left            =   390
      TabIndex        =   5
      Top             =   1950
      Width           =   2895
   End
   Begin VB.Label Метка1 
      BorderStyle     =   1  'Единственный Фиксированный
      Height          =   315
      Index           =   5
      Left            =   390
      TabIndex        =   4
      Top             =   1620
      Width           =   2895
   End
   Begin VB.Label Метка1 
      BorderStyle     =   1  'Единственный Фиксированный
      Height          =   315
      Index           =   4
      Left            =   390
      TabIndex        =   3
      Top             =   1290
      Width           =   2895
   End
   Begin VB.Label Метка1 
      BorderStyle     =   1  'Единственный Фиксированный
      Height          =   315
      Index           =   3
      Left            =   390
      TabIndex        =   2
      Top             =   960
      Width           =   2895
   End
   Begin VB.Label Метка1 
      BorderStyle     =   1  'Единственный Фиксированный
      Height          =   315
      Index           =   2
      Left            =   390
      TabIndex        =   1
      Top             =   630
      Width           =   2895
   End
   Begin VB.Label Метка1 
      BorderStyle     =   1  'Единственный Фиксированный
      Height          =   315
      Index           =   1
      Left            =   390
      TabIndex        =   0
      Top             =   300
      Width           =   2895
   End
End
Attribute VB_Name = "Sapyor5"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim a(10) As String
Dim a1(10) As String
Private Sub Form_Load()
Open App.Path & "Records.rec" For Input As #1
Line Input #1, w
For i = 1 To w
Line Input #1, a(i)
Next i
Close #1
For i = 1 To 10
k = 5
If i = 10 Then k = 3
a1(i) = Mid(a(i), 10, 50)
Метка1(i).Caption = i & Space(k) & a1(i)
Next i
End Sub

