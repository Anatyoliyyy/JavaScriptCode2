VERSION 5.00
Begin VB.Form Sapyor2 
   BackColor       =   &H00800000&
   BorderStyle     =   1  '������������ �������������
   Caption         =   "���������"
   ClientHeight    =   915
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   1965
   Icon            =   "Sapyor2.frx":0000
   LinkTopic       =   "�����3"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   915
   ScaleWidth      =   1965
   StartUpPosition =   3  '���� �� ���������
   Begin VB.CommandButton ��������1 
      Caption         =   "OK"
      Height          =   405
      Left            =   1200
      TabIndex        =   3
      Top             =   420
      Width           =   525
   End
   Begin VB.HScrollBar ���������1 
      Height          =   285
      Left            =   0
      TabIndex        =   1
      Top             =   630
      Width           =   1035
   End
   Begin VB.TextBox �����1 
      Height          =   315
      Left            =   0
      TabIndex        =   0
      Top             =   300
      Width           =   1005
   End
   Begin VB.Label �����1 
      BackColor       =   &H00FF0000&
      Caption         =   "������� ���������� ���"
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
With ���������1
.Min = 1
.Max = 99
End With
End Sub

Private Sub ���������1_Change()
�����1.Text = ���������1.Value
�����1.Enabled = False
End Sub

Private Sub ��������1_Click()
Mi = ���������1.Value
Sapyor.�����3.Caption = Mi
Unload Me
End Sub

