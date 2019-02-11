VERSION 5.00
Begin VB.Form Dialog 
   BorderStyle     =   1  'Единственный Фиксированный
   ClientHeight    =   1605
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4935
   Icon            =   "dialog.frx":0000
   LinkTopic       =   "Форма1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1605
   ScaleWidth      =   4935
   StartUpPosition =   1  'Центральный Владелец
   Begin VB.Frame Рамка1 
      Height          =   1695
      Left            =   0
      TabIndex        =   0
      Top             =   -90
      Width           =   4935
      Begin VB.CommandButton CmdOk 
         Caption         =   "&Да"
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
         Left            =   2280
         TabIndex        =   3
         Top             =   1200
         Width           =   1215
      End
      Begin VB.CommandButton CmdNo 
         Caption         =   "&Нет"
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
         TabIndex        =   2
         Top             =   1200
         Width           =   1215
      End
      Begin VB.Label Lbl 
         Height          =   975
         Left            =   960
         TabIndex        =   1
         Top             =   280
         Width           =   3855
      End
      Begin VB.Image Изображение1 
         Height          =   480
         Left            =   240
         Picture         =   "dialog.frx":0E42
         Top             =   300
         Width           =   480
      End
   End
End
Attribute VB_Name = "Dialog"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub CmdNo_Click()
   Dialog.Tag = "no"
   Dialog.Hide
End Sub
Private Sub CmdOk_Click()
   Dialog.Tag = "ok"
   Dialog.Hide
End Sub
