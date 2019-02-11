VERSION 5.00
Begin VB.Form Dialog 
   AutoRedraw      =   -1  'True
   BorderStyle     =   3  'Fixed Dialog
   ClientHeight    =   3780
   ClientLeft      =   2760
   ClientTop       =   3465
   ClientWidth     =   6000
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3780
   ScaleWidth      =   6000
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox Picture1 
      BorderStyle     =   0  'None
      Height          =   3165
      Left            =   0
      ScaleHeight     =   3165
      ScaleWidth      =   6000
      TabIndex        =   0
      Top             =   0
      Width           =   6000
      Begin VB.ListBox time 
         Height          =   1620
         Left            =   3885
         TabIndex        =   15
         Top             =   1050
         Width           =   1590
      End
      Begin VB.ListBox lstscore 
         Height          =   1620
         Left            =   2100
         TabIndex        =   14
         Top             =   1050
         Width           =   1590
      End
      Begin VB.ListBox lstname 
         Height          =   1620
         Left            =   315
         TabIndex        =   1
         Top             =   1050
         Width           =   1590
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "Время:"
         BeginProperty Font 
            Name            =   "System"
            Size            =   9.75
            Charset         =   204
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   240
         Index           =   3
         Left            =   3885
         TabIndex        =   16
         Top             =   735
         Width           =   795
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "ПОБЕДИТЕЛИ:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   15.75
            Charset         =   204
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   2
         Left            =   1785
         TabIndex        =   12
         Top             =   315
         Width           =   2355
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "Очки:"
         BeginProperty Font 
            Name            =   "System"
            Size            =   9.75
            Charset         =   204
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   240
         Index           =   1
         Left            =   2100
         TabIndex        =   11
         Top             =   735
         Width           =   660
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "Имена:"
         BeginProperty Font 
            Name            =   "System"
            Size            =   9.75
            Charset         =   204
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   240
         Index           =   0
         Left            =   315
         TabIndex        =   2
         Top             =   735
         Width           =   810
      End
   End
   Begin VB.PictureBox Picture2 
      BorderStyle     =   0  'None
      Height          =   3270
      Left            =   0
      ScaleHeight     =   3270
      ScaleWidth      =   6000
      TabIndex        =   5
      Top             =   0
      Width           =   6000
      Begin VB.Frame Frame2 
         Caption         =   "Ваши очки:"
         Height          =   645
         Left            =   3255
         TabIndex        =   8
         Top             =   525
         Width           =   2640
         Begin VB.TextBox txtscore 
            Height          =   285
            Left            =   105
            Locked          =   -1  'True
            TabIndex        =   9
            Top             =   210
            Width           =   2430
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "Ваше Имя:"
         Height          =   645
         Left            =   105
         TabIndex        =   6
         Top             =   525
         Width           =   2640
         Begin VB.TextBox txtname 
            Height          =   285
            Left            =   105
            TabIndex        =   7
            Top             =   210
            Width           =   2430
         End
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "Поздравляю Вас!!!"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   15.75
            Charset         =   204
            Weight          =   700
            Underline       =   0   'False
            Italic          =   -1  'True
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   4
         Left            =   1155
         TabIndex        =   17
         Top             =   0
         Width           =   3375
      End
   End
   Begin VB.CommandButton Command2 
      Caption         =   "&Удалить"
      Height          =   330
      Left            =   2310
      TabIndex        =   13
      Top             =   3360
      Width           =   1170
   End
   Begin VB.TextBox comm 
      Height          =   285
      Left            =   315
      TabIndex        =   10
      Top             =   3780
      Visible         =   0   'False
      Width           =   1170
   End
   Begin VB.CommandButton Command3 
      Cancel          =   -1  'True
      Caption         =   "&Отмена"
      Height          =   330
      Left            =   105
      TabIndex        =   4
      Top             =   3360
      Width           =   1170
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Ok"
      Default         =   -1  'True
      Height          =   330
      Left            =   4725
      TabIndex        =   3
      Top             =   3360
      Width           =   1170
   End
End
Attribute VB_Name = "Dialog"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Public add As New clsFavorites
Dim Filename As String
Dim varItem As Variant

Private Sub Command1_Click()
If comm.Text = "scores" Then
Unload Me
ElseIf comm.Text = "add" Then
If txtname.Text <> "" And txtscore.Text <> "" Then
For Each varItem In add.Names
    If txtname.Text = varItem Then
        If MsgBox("Запись с данным именем уже существует." & vbCrLf & "Заменить данную запись", vbYesNo) = vbYes Then
            add.DeleteFavorite Filename, 100, txtname.Text
            Picture1.ZOrder
            SavePlayers txtname.Text, txtscore.Text
        Else
            Exit Sub
        End If
    End If
    Next
Picture1.ZOrder
SavePlayers txtname.Text, txtscore.Text
Unload Me
End If
End If
End Sub

Private Sub Command2_Click()
Dim strName As String
strName = lstname.List(lstname.ListIndex)
If MsgBox("Вы уверены что хотите удалить запись " & strName & " из списка", vbQuestion & vbYesNo, "Пирамида") = vbYes Then
add.DeleteFavorite Filename, 100, strName
lstname.Clear
lstscore.Clear
time.Clear
add.RetrieveFavorites Filename, 100
For Each varItem In add.Names
lstname.AddItem varItem
Next
For Each varItem In add.URLs
lstscore.AddItem varItem
Next
For Each varItem In add.Dates
time.AddItem varItem
Next
Else
Exit Sub
End If
End Sub

Private Sub Command3_Click()
Unload Me
End Sub

Private Sub Form_Load()
Filename = App.Path & "\Scores.dat"
Commands
    add.RetrieveFavorites Filename, 100
    For Each varItem In add.Names
    lstname.AddItem varItem
    Next
    For Each varItem In add.URLs
    lstscore.AddItem varItem
    Next
    For Each varItem In add.Dates
    time.AddItem varItem
    Next
End Sub

Private Sub Commands()
Select Case comm.Text
    Case "scores"
        Picture1.ZOrder
    Case "add"
        Picture2.ZOrder
    End Select
End Sub

Private Sub Form_Unload(Cancel As Integer)
comm.Text = ""
End Sub

Private Function SavePlayers(ByVal NameP As String, ByVal ScoreP As String) As String
add.AddFavorite Filename, txtname.Text, txtscore.Text, Form1.tim.Caption
End Function

Private Sub lstname_Click()
lstscore.ListIndex = lstname.ListIndex
time.ListIndex = lstname.ListIndex
End Sub

Private Sub lstscore_Click()
lstname.ListIndex = lstscore.ListIndex
time.ListIndex = lstscore.ListIndex
End Sub

Private Sub time_Click()
lstname.ListIndex = time.ListIndex
lstscore.ListIndex = time.ListIndex
End Sub
