VERSION 5.00
Begin VB.Form FrmTools 
   Caption         =   "Настройки"
   ClientHeight    =   3105
   ClientLeft      =   1845
   ClientTop       =   1905
   ClientWidth     =   6720
   Icon            =   "FrmTools.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   3105
   ScaleWidth      =   6720
   Begin VB.Frame Frame1 
      Caption         =   "Выбор камикадзе"
      Height          =   2175
      Left            =   3120
      TabIndex        =   5
      Top             =   300
      Width           =   3495
      Begin VB.Image Image8 
         Height          =   480
         Left            =   2700
         Picture         =   "FrmTools.frx":0442
         Top             =   1440
         Width           =   480
      End
      Begin VB.Image Image7 
         Height          =   480
         Left            =   1860
         Picture         =   "FrmTools.frx":0D0C
         Top             =   1500
         Width           =   480
      End
      Begin VB.Image Image6 
         Height          =   480
         Left            =   1020
         Picture         =   "FrmTools.frx":15D6
         Top             =   1500
         Width           =   480
      End
      Begin VB.Image Image5 
         Height          =   480
         Left            =   240
         Picture         =   "FrmTools.frx":1EA0
         Top             =   1440
         Width           =   480
      End
      Begin VB.Image Image4 
         Height          =   480
         Left            =   2640
         Picture         =   "FrmTools.frx":22E2
         Top             =   540
         Width           =   480
      End
      Begin VB.Image Image3 
         Height          =   480
         Left            =   1800
         Picture         =   "FrmTools.frx":25EC
         Top             =   540
         Width           =   480
      End
      Begin VB.Image Image2 
         Height          =   480
         Left            =   1020
         Picture         =   "FrmTools.frx":28F6
         Top             =   480
         Width           =   480
      End
      Begin VB.Image Image1 
         Height          =   480
         Left            =   240
         Picture         =   "FrmTools.frx":31C0
         Top             =   540
         Width           =   480
      End
   End
   Begin VB.CommandButton CmdCancel 
      Caption         =   "cancel"
      Height          =   375
      Left            =   4440
      TabIndex        =   4
      Top             =   2700
      Width           =   1035
   End
   Begin VB.CommandButton cmdOk 
      Caption         =   "ok"
      Height          =   375
      Left            =   3000
      TabIndex        =   3
      Top             =   2700
      Width           =   1155
   End
   Begin VB.TextBox txtTime 
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   204
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Left            =   1500
      TabIndex        =   1
      Text            =   "30"
      Top             =   300
      Width           =   795
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "сек."
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   204
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Left            =   2400
      TabIndex        =   2
      Top             =   300
      Width           =   555
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Время игры:"
      BeginProperty Font 
         Name            =   "Comic Sans MS"
         Size            =   9.75
         Charset         =   204
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   180
      TabIndex        =   0
      Top             =   300
      Width           =   1335
   End
End
Attribute VB_Name = "FrmTools"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub CmdCancel_Click()
End
End Sub

Private Sub cmdOk_Click()
Unload Me
frmTarget.Show

End Sub

Private Sub Image1_Click()

frmTarget.ImgTarget.Picture = FrmTools.Image1.Picture

End Sub

Private Sub Image2_Click()
frmTarget.ImgTarget.Picture = FrmTools.Image2.Picture
End Sub
Private Sub Image3_Click()
frmTarget.ImgTarget.Picture = FrmTools.Image3.Picture
End Sub
Private Sub Image4_Click()
frmTarget.ImgTarget.Picture = FrmTools.Image4.Picture
End Sub
Private Sub Image5_Click()
frmTarget.ImgTarget.Picture = FrmTools.Image5.Picture
End Sub
Private Sub Image6_Click()
frmTarget.ImgTarget.Picture = FrmTools.Image6.Picture
End Sub
Private Sub Image7_Click()
frmTarget.ImgTarget.Picture = FrmTools.Image7.Picture
End Sub
Private Sub Image8_Click()
frmTarget.ImgTarget.Picture = FrmTools.Image8.Picture
End Sub
