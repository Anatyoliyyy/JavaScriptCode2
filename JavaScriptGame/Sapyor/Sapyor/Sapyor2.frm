VERSION 5.00
Begin VB.Form Sapyor2 
   BackColor       =   &H00800000&
   BorderStyle     =   1  'Единственный Фиксированный
   Caption         =   "Параметры"
   ClientHeight    =   915
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   1965
   Icon            =   "Sapyor2.frx":0000
   LinkTopic       =   "Форма3"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   915
   ScaleWidth      =   1965
   StartUpPosition =   3  'Окна По Умолчанию
   Begin VB.CommandButton Комманда1 
      Caption         =   "OK"
      Height          =   405
      Left            =   1200
      TabIndex        =   3
      Top             =   420
      Width           =   525
   End
   Begin VB.HScrollBar ГСкролинг1 
      Height          =   285
      Left            =   0
      TabIndex        =   1
      Top             =   630
      Width           =   1035
   End
   Begin VB.TextBox Текст1 
      Height          =   315
      Left            =   0
      TabIndex        =   0
      Top             =   300
      Width           =   1005
   End
   Begin VB.Label Метка1 
      BackColor       =   &H00FF0000&
      Caption         =   "Задайте количество мин"
      Height          =   255
      Left            =   30
      TabIndex        =   2
      Top             =   30
      Width           =   1965
   End
End
Attribute VB_Name = "Sapyor2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
With ГСкролинг1
.Min = 1
.Max = 99
End With
End Sub

Private Sub ГСкролинг1_Change()
Текст1.Text = ГСкролинг1.Value
Текст1.Enabled = False
End Sub

Private Sub Комманда1_Click()
Mi = ГСкролинг1.Value
Sapyor.Метка3.Caption = Mi
Unload Me
End Sub

