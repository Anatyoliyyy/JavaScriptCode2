VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   8640
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8625
   LinkTopic       =   "Form1"
   ScaleHeight     =   8640
   ScaleWidth      =   8625
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer Timer1 
      Interval        =   1000
      Left            =   240
      Top             =   7920
   End
   Begin VB.Image Image1 
      Height          =   750
      Index           =   4
      Left            =   0
      Picture         =   "сокебан.frx":0000
      Top             =   0
      Width           =   750
   End
   Begin VB.Image Image1 
      Height          =   750
      Index           =   3
      Left            =   0
      Picture         =   "сокебан.frx":1DF2
      Top             =   0
      Width           =   750
   End
   Begin VB.Image Image1 
      Height          =   750
      Index           =   2
      Left            =   0
      Picture         =   "сокебан.frx":3BE4
      Top             =   0
      Width           =   750
   End
   Begin VB.Image Image1 
      Height          =   750
      Index           =   1
      Left            =   0
      Picture         =   "сокебан.frx":59D6
      Top             =   0
      Width           =   750
   End
   Begin VB.Label Label2 
      Caption         =   "Label2"
      Height          =   255
      Left            =   8040
      TabIndex        =   1
      Top             =   240
      Width           =   375
   End
   Begin VB.Label Label1 
      Caption         =   "Label1"
      Height          =   255
      Left            =   7320
      TabIndex        =   0
      Top             =   240
      Width           =   375
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   20
      Left            =   5760
      Picture         =   "сокебан.frx":77C8
      Top             =   5040
      Width           =   750
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   19
      Left            =   5760
      Picture         =   "сокебан.frx":95BA
      Top             =   5760
      Width           =   750
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   18
      Left            =   5040
      Picture         =   "сокебан.frx":B3AC
      Top             =   5760
      Width           =   750
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   17
      Left            =   5040
      Picture         =   "сокебан.frx":D19E
      Top             =   6480
      Width           =   750
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   16
      Left            =   4320
      Picture         =   "сокебан.frx":EF90
      Top             =   6480
      Width           =   750
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   15
      Left            =   3600
      Picture         =   "сокебан.frx":10D82
      Top             =   6480
      Width           =   750
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   14
      Left            =   4320
      Picture         =   "сокебан.frx":12B74
      Top             =   4320
      Width           =   750
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   13
      Left            =   4320
      Picture         =   "сокебан.frx":14966
      Top             =   3600
      Width           =   750
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   12
      Left            =   2880
      Picture         =   "сокебан.frx":16758
      Top             =   6480
      Width           =   750
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   11
      Left            =   2880
      Picture         =   "сокебан.frx":1854A
      Top             =   5760
      Width           =   750
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   10
      Left            =   2880
      Picture         =   "сокебан.frx":1A33C
      Top             =   5040
      Width           =   750
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   9
      Left            =   2160
      Picture         =   "сокебан.frx":1C12E
      Top             =   4320
      Width           =   750
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   8
      Left            =   7200
      Picture         =   "сокебан.frx":1DF20
      Top             =   2880
      Width           =   750
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   7
      Left            =   4320
      Picture         =   "сокебан.frx":1FD12
      Top             =   2880
      Width           =   750
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   6
      Left            =   2160
      Picture         =   "сокебан.frx":21B04
      Top             =   5040
      Width           =   750
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   5
      Left            =   2160
      Picture         =   "сокебан.frx":238F6
      Top             =   3600
      Width           =   750
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   4
      Left            =   7200
      Picture         =   "сокебан.frx":256E8
      Top             =   4440
      Width           =   750
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   3
      Left            =   7200
      Picture         =   "сокебан.frx":274DA
      Top             =   3720
      Width           =   750
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   2
      Left            =   7200
      Picture         =   "сокебан.frx":292CC
      Top             =   1440
      Width           =   750
   End
   Begin VB.Image Image5 
      Height          =   750
      Index           =   1
      Left            =   3600
      Picture         =   "сокебан.frx":2B0BE
      Top             =   0
      Width           =   750
   End
   Begin VB.Image Image4 
      Height          =   750
      Left            =   3600
      Picture         =   "сокебан.frx":2CEB0
      Top             =   3600
      Width           =   750
   End
   Begin VB.Image Image3 
      Height          =   750
      Index           =   3
      Left            =   5400
      Picture         =   "сокебан.frx":2ECA2
      Top             =   1800
      Width           =   750
   End
   Begin VB.Image Image3 
      Height          =   750
      Index           =   2
      Left            =   6480
      Picture         =   "сокебан.frx":30A94
      Top             =   2160
      Width           =   750
   End
   Begin VB.Image Image3 
      Height          =   750
      Index           =   1
      Left            =   2880
      Picture         =   "сокебан.frx":32886
      Top             =   1440
      Width           =   750
   End
   Begin VB.Image Image2 
      Height          =   750
      Index           =   3
      Left            =   2880
      Picture         =   "сокебан.frx":34678
      Top             =   2880
      Width           =   750
   End
   Begin VB.Image Image2 
      Height          =   750
      Index           =   2
      Left            =   2880
      Picture         =   "сокебан.frx":3646A
      Top             =   3600
      Width           =   750
   End
   Begin VB.Image Image2 
      Height          =   750
      Index           =   1
      Left            =   3600
      Picture         =   "сокебан.frx":3825C
      Top             =   2880
      Width           =   750
   End
   Begin VB.Line Line24 
      X1              =   0
      X2              =   10080
      Y1              =   7920
      Y2              =   7920
   End
   Begin VB.Line Line23 
      X1              =   0
      X2              =   10080
      Y1              =   7200
      Y2              =   7200
   End
   Begin VB.Line Line22 
      X1              =   0
      X2              =   10080
      Y1              =   6480
      Y2              =   6480
   End
   Begin VB.Line Line21 
      X1              =   0
      X2              =   10080
      Y1              =   5760
      Y2              =   5760
   End
   Begin VB.Line Line20 
      X1              =   0
      X2              =   10080
      Y1              =   5040
      Y2              =   5040
   End
   Begin VB.Line Line19 
      X1              =   0
      X2              =   10080
      Y1              =   4320
      Y2              =   4320
   End
   Begin VB.Line Line18 
      X1              =   0
      X2              =   10080
      Y1              =   3600
      Y2              =   3600
   End
   Begin VB.Line Line17 
      X1              =   0
      X2              =   10080
      Y1              =   2880
      Y2              =   2880
   End
   Begin VB.Line Line16 
      X1              =   0
      X2              =   10080
      Y1              =   2160
      Y2              =   2160
   End
   Begin VB.Line Line15 
      X1              =   0
      X2              =   10080
      Y1              =   1440
      Y2              =   1440
   End
   Begin VB.Line Line13 
      X1              =   8640
      X2              =   8640
      Y1              =   0
      Y2              =   8640
   End
   Begin VB.Line Line12 
      X1              =   7920
      X2              =   7920
      Y1              =   0
      Y2              =   8640
   End
   Begin VB.Line Line11 
      X1              =   7200
      X2              =   7200
      Y1              =   0
      Y2              =   8640
   End
   Begin VB.Line Line10 
      X1              =   6480
      X2              =   6480
      Y1              =   0
      Y2              =   8640
   End
   Begin VB.Line Line9 
      X1              =   5760
      X2              =   5760
      Y1              =   0
      Y2              =   8640
   End
   Begin VB.Line Line8 
      X1              =   5040
      X2              =   5040
      Y1              =   0
      Y2              =   8640
   End
   Begin VB.Line Line7 
      X1              =   4320
      X2              =   4320
      Y1              =   0
      Y2              =   8640
   End
   Begin VB.Line Line6 
      X1              =   3600
      X2              =   3600
      Y1              =   0
      Y2              =   8640
   End
   Begin VB.Line Line5 
      X1              =   2880
      X2              =   2880
      Y1              =   0
      Y2              =   8640
   End
   Begin VB.Line Line4 
      X1              =   2160
      X2              =   2160
      Y1              =   0
      Y2              =   8640
   End
   Begin VB.Line Line3 
      X1              =   0
      X2              =   10080
      Y1              =   720
      Y2              =   720
   End
   Begin VB.Line Line2 
      X1              =   720
      X2              =   720
      Y1              =   0
      Y2              =   8640
   End
   Begin VB.Line Line1 
      X1              =   1440
      X2              =   1440
      Y1              =   0
      Y2              =   8640
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim i As Integer
Dim j As Integer
Dim k As Integer
Dim t As Integer
Dim st As String
Dim s As Integer
Dim X As Integer
Dim Y As Integer
Dim Pobeda As Integer

Dim DuxMonitorX As Integer
Dim DuxMonitorY As Integer
Dim DuxKlavaX As Integer
Dim DuxKlavaY As Integer
Dim DuxBlokX As Integer
Dim DuxBlokY As Integer
Dim Nedvigimocti(1 To 12, 1 To 12) As Integer
Dim XNed(1 To 20) As Integer
Dim YNed(1 To 20) As Integer

Dim Obgektimonitor(1 To 12, 1 To 12) As Integer
Dim Xmonitor  As Integer
Dim Ymonitor   As Integer

Dim ObgektiKlava(1 To 12, 1 To 12) As Integer
Dim XKlava  As Integer
Dim YKlava  As Integer

Dim ObgektiBlok(1 To 12, 1 To 12) As Integer
Dim XBlok  As Integer
Dim YBlok  As Integer


Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = 38 Then ' что будет если нажать на клавишу ВВЕРХ
'а будет следующее
Image1(1).Visible = True ' станет видемой картинка мышки где она смотрит вверх
Image1(1).Top = Image1(1).Top - 720: X = X: Y = Y - 1 ' сам двигатель    : )
'х и Y нужны чтобы знать где мы находимся на игровом поле
'далее объясню для чего зто надо.
'720 нужно чтобы точно передвигать нашу мышку
' можно написать и Image1(1).Width вместо 720 но будет
'погрешность и с каждым шагом все заметнее
'
'++++++++++++++++++++++++++проверка не вышел ли я выше нашей формы+++++++++
If Image1(1).Top < 0 Then Image1(1).Top = Image1(1).Top + 720: X = X: Y = Y + 1
'если вышел,то незабудь обратно войти : )
' как?
'просто обратно прибавь 720 и не забудь про Y
'
'
'++++++++++++++++++++ОЧЕНЬ ВАЖНО НАДО ПОНЯТЬ+++++++++++++++++++++++++++++++++
'Тут проверяется А НЕ СТОИТ ЛИ ПЕРЕДОМНОЙ ПРЕДМЕТ КОТОРЫЙ МЕНЯ ЗАТАРМОЗИТ
'всмысле не даст двинуться дальше
' вот смотри, ты в KeyCode = 38 двигаештся только вверх
'значит Х у тебя константа- неменяется
'надомной может быть только та недвижимость,каторая находится на том же Х-е
'а вот какая по Y я и комп не знаем... Пока незнаем : )
'Чтобы узнать надо перебрать все Y
' Тут пока все должно быть понятно
' самое сложное для понятия начинается тут
'Под недвижимостью надо понимать элемент ячейки сетки с координатами х и у
'для меня ближе элемент матрицы : )
'ну так вот, если он равен 1 то значит он занят туда входа нет
'я проверяю А НЕ ЗАНЯТ ЛИ ВОТ ЭТОТ ВОТ ИЛИ ВОТ ЭТОТ ИЛИ...
'ЕСЛИ ЗАНЯТ ТО СМОТРЮ ЕЩЕ ОДИН ПАРАМЕТР А НЕ НАХОЖУСЬ ЛИ Я УЖЕ ВНЕМ
'ВООБЩЕ-ТО Я НЕ НАХОЖУСЬ В КАКОЙ-ТО СТЕНКЕ
'ПРОСТО СМОТРИ ВЫШЕ ГДЕ ТРЕТЬЯ СТРОКА, ТАМ КОМЕНТАРИЙ   _САМ ДВИГАТЕЛЬ_
'ТАМ Я ОТ Y ОТНЯЛ 1
'И ПОЛУЧАЕТСЯ ЧТО Я СЕЙЧАС НАХОЖУСЬ В НЕДВИЖИМОСТИ
' Y=i это и есть тот параметр
'ИТАК ЕСЛИ Я ВНЕМ ЗНАЧИТ НАДО ОБРАТНО ВСЕ ВЕРНУТЬ
'постарайся уж понять
For i = 1 To 12
 If Nedvigimocti(X, i) = 1 And Y = i Then Image1(1).Top = Image1(1).Top + 720: X = X: Y = Y + 1
Next i
'ВОТ ВСЕ И ВЕРНУЛИ И 720 ПРИБАВИЛИ И ПРО Y НЕЗАБЫЛИ


'++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
'++++++++++++++++++++++++++++++++++Распознает верхнюю стенку
'++++++++++++++++++++++++++++++++++Недвижимость и другие объекты
'------------------------Ты хочешь разные картинки двигать прийдется для каждой писать


'---------------- Для  ObgektiBlok
For i = 1 To 12
If ObgektiBlok(X, i) = 1 And Y = i Then
If i = 1 Then Y = Y + 1: Image1(1).Top = Image1(1).Top + 720: GoTo 1
If Nedvigimocti(X, i - 1) = 1 Then Y = Y + 1: Image1(1).Top = Image1(1).Top + 720: GoTo 1 ' нет ли недвижимости
If Obgektimonitor(X, i - 1) = 1 Then Y = Y + 1: Image1(1).Top = Image1(1).Top + 720: GoTo 1 'нет ли монитора
If ObgektiKlava(X, i - 1) = 1 Then Y = Y + 1: Image1(1).Top = Image1(1).Top + 720: GoTo 1 'нет ли клавы
Image3(1).Top = Image3(1).Top - 720:
ObgektiBlok(X, i - 1) = 1
ObgektiBlok(X, i) = 0:
XBlok = XBlok:
YBlok = YBlok - 720
GoTo 1
End If
Next i
1


'---------------- Для  Obgektimonitor
For i = 1 To 12
If Obgektimonitor(X, i) = 1 And Y = i Then
If i = 1 Then Y = Y + 1: Image1(1).Top = Image1(1).Top + 720: GoTo 2
If Nedvigimocti(X, i - 1) = 1 Then Y = Y + 1: Image1(1).Top = Image1(1).Top + 720: GoTo 2
If ObgektiBlok(X, i - 1) = 1 Then Y = Y + 1: Image1(1).Top = Image1(1).Top + 720: GoTo 2
If ObgektiKlava(X, i - 1) = 1 Then Y = Y + 1: Image1(1).Top = Image1(1).Top + 720: GoTo 2
Image3(3).Top = Image3(3).Top - 720:
Obgektimonitor(X, i - 1) = 1
Obgektimonitor(X, i) = 0:
Xmonitor = Xmonitor:
Ymonitor = Ymonitor - 720
GoTo 2
End If
Next i
2

'---------------- Для  Obgektiklava
For i = 1 To 12
If ObgektiKlava(X, i) = 1 And Y = i Then
If i = 1 Then Y = Y + 1: Image1(1).Top = Image1(1).Top + 720: GoTo 3
If Nedvigimocti(X, i - 1) = 1 Then Y = Y + 1: Image1(1).Top = Image1(1).Top + 720: GoTo 3
If ObgektiBlok(X, i - 1) = 1 Then Y = Y + 1: Image1(1).Top = Image1(1).Top + 720: GoTo 3
If Obgektimonitor(X, i - 1) = 1 Then Y = Y + 1: Image1(1).Top = Image1(1).Top + 720: GoTo 3
Image3(2).Top = Image3(2).Top - 720:
ObgektiKlava(X, i - 1) = 1
ObgektiKlava(X, i) = 0:
XKlava = XKlava:
YKlava = YKlava - 720
GoTo 3
End If
Next i
3
Label1.Caption = X 'это чисто от меня для тебя просто чтобы знала где находишься
Label2.Caption = Y ' ну а это по Y
Image1(2).Visible = False: Image1(3).Visible = False: Image1(4).Visible = False
'тут мы все остальные рисунки кроме который смотрит вверх делаем невидимыми
' этот цикл нужен чтобы присвоить всем рисункам нашей мышки один и те же координаты
For i = 1 To 4
Image1(i).Left = Image1(1).Left
Image1(i).Top = Image1(1).Top
Next i
' пусть вместе гуляют : )
End If ' Конец блока, всмысле все. : )
' ОСТАЛЬНОЕ ПО АНАЛОГИИ
'ТЕБЕ ПРОСТО НАДО РАЗОБРАТЬСЯ С ТЕМИ СТРОЧКАМИ ГДЕ ПРОВЕРЯЕТСЯ СТЕНКИ
' ТИПА НЕ ВЫШЕЛ ЛИ Я ЗА ФОРМУ
'ПОСУТИ НАДО ПОНЯТЬ ПОЧЕМУ Image1(4).Left > Form1.Width - 720
'И В ОДНОМ СЛУЧАЕ Image1(3).Top > Form1.Height - 720
'Image1(4).Left это положение рисунка по Х
'Form1.Width это ширина формы
'значит если Х стал больше чем ширина формы минус ширина мышки значит
' стой!!! куда???!!!!    : )
'Image1(4).Top это положение рисунка по Y
'Form1.Height это высота формы
' остальное Думайте сами


'+++++++++++++++++++++++++++++++++++++++++++ВЛЕВО+++++++++++++++++++++++++++++
If KeyCode = 37 Then
Image1(2).Visible = True
Image1(2).Left = Image1(2).Left - 720:   X = X - 1: Y = Y
If Image1(2).Left < 0 Then Image1(2).Left = Image1(2).Left + 720: X = X + 1: Y = Y
For i = 1 To 12
 If Nedvigimocti(i, Y) = 1 And X = i Then Image1(2).Left = Image1(2).Left + 720: X = X + 1: Y = Y
Next i
'++++++++++++++++++++++++++++++++++++ObgektiBlok
For i = 1 To 12
If ObgektiBlok(i, Y) = 1 And X = i Then
If i = 1 Then X = X + 1: Image1(2).Left = Image1(2).Left + 720:   GoTo 4
If Nedvigimocti(i - 1, Y) = 1 Then X = X + 1: Image1(2).Left = Image1(2).Left + 720: GoTo 4
If Obgektimonitor(i - 1, Y) = 1 Then X = X + 1: Image1(2).Left = Image1(2).Left + 720: GoTo 4
If ObgektiKlava(i - 1, Y) = 1 Then X = X + 1: Image1(2).Left = Image1(2).Left + 720: GoTo 4
Image3(1).Left = Image3(1).Left - 720:
ObgektiBlok(i - 1, Y) = 1
ObgektiBlok(i, Y) = 0:
XBlok = XBlok:
YBlok = YBlok - 720
GoTo 4
End If
Next i
4
'++++++++++++++++++++++++++++++++++++Obgektimonitor
For i = 1 To 12
If Obgektimonitor(i, Y) = 1 And X = i Then
If i = 1 Then X = X + 1: Image1(2).Left = Image1(2).Left + 720:   GoTo 5
If Nedvigimocti(i - 1, Y) = 1 Then X = X + 1: Image1(2).Left = Image1(2).Left + 720: GoTo 5
If ObgektiBlok(i - 1, Y) = 1 Then X = X + 1: Image1(2).Left = Image1(2).Left + 720: GoTo 5
If ObgektiKlava(i - 1, Y) = 1 Then X = X + 1: Image1(2).Left = Image1(2).Left + 720: GoTo 5
Image3(3).Left = Image3(3).Left - 720:
Obgektimonitor(i - 1, Y) = 1
Obgektimonitor(i, Y) = 0:
Xmonitor = Xmonitor:
Ymonitor = Ymonitor - 720
GoTo 5
End If
Next i
5
'++++++++++++++++++++++++++++++++++++Obgektiklava
For i = 1 To 12
If ObgektiKlava(i, Y) = 1 And X = i Then
If i = 1 Then X = X + 1: Image1(2).Left = Image1(2).Left + 720:   GoTo 6
If Nedvigimocti(i - 1, Y) = 1 Then X = X + 1: Image1(2).Left = Image1(2).Left + 720: GoTo 6
If ObgektiBlok(i - 1, Y) = 1 Then X = X + 1: Image1(2).Left = Image1(2).Left + 720: GoTo 6
If Obgektimonitor(i - 1, Y) = 1 Then X = X + 1: Image1(2).Left = Image1(2).Left + 720: GoTo 6
Image3(2).Left = Image3(2).Left - 720:
ObgektiKlava(i - 1, Y) = 1
ObgektiKlava(i, Y) = 0:
XKlava = XKlava:
YKlava = YKlava - 720
GoTo 6
End If
Next i
6
Label1.Caption = X
Label2.Caption = Y
Image1(1).Visible = False: Image1(3).Visible = False: Image1(4).Visible = False
For i = 1 To 4
Image1(i).Left = Image1(2).Left
Image1(i).Top = Image1(2).Top
Next i
End If
'+++++++++++++++++++++++++++++++++++++++++++ВНИЗ+++++++++++++++++++++++++++++
If KeyCode = 40 Then
Image1(3).Visible = True
Image1(3).Top = Image1(3).Top + 720: X = X: Y = Y + 1
If Image1(3).Top > Form1.Height - 720 Then Image1(3).Top = Image1(3).Top - 720: X = X: Y = Y - 1
For i = 1 To 12
 If Nedvigimocti(X, i) = 1 And Y = i Then Image1(3).Top = Image1(3).Top - 720: X = X: Y = Y - 1
Next i
'++++++++++++++++++++++++++++++++++++ObgektiBlok
For i = 1 To 12
If ObgektiBlok(X, i) = 1 And Y = i Then
If i = 12 Then Y = Y - 1: Image1(3).Top = Image1(3).Top - 720:   GoTo 7
If Nedvigimocti(X, i + 1) = 1 Then Y = Y - 1: Image1(3).Top = Image1(3).Top - 720: GoTo 7
If Obgektimonitor(X, i + 1) = 1 Then Y = Y - 1: Image1(3).Top = Image1(3).Top - 720: GoTo 7
If ObgektiKlava(X, i + 1) = 1 Then Y = Y - 1: Image1(3).Top = Image1(3).Top - 720: GoTo 7
Image3(1).Top = Image3(1).Top + 720:
ObgektiBlok(X, i + 1) = 1
ObgektiBlok(X, i) = 0:
XBlok = XBlok:
YBlok = YBlok + 720
GoTo 7
End If
Next i
7
'++++++++++++++++++++++++++++++++++++Obgektimonitor
For i = 1 To 12
If Obgektimonitor(X, i) = 1 And Y = i Then
If i = 12 Then Y = Y - 1: Image1(3).Top = Image1(3).Top - 720:   GoTo 8
If Nedvigimocti(X, i + 1) = 1 Then Y = Y - 1: Image1(3).Top = Image1(3).Top - 720: GoTo 8
If ObgektiBlok(X, i + 1) = 1 Then Y = Y - 1: Image1(3).Top = Image1(3).Top - 720: GoTo 8
If ObgektiKlava(X, i + 1) = 1 Then Y = Y - 1: Image1(3).Top = Image1(3).Top - 720: GoTo 8
Image3(3).Top = Image3(3).Top + 720:
Obgektimonitor(X, i + 1) = 1
Obgektimonitor(X, i) = 0:
Xmonitor = Xmonitor:
Ymonitor = Ymonitor + 720
GoTo 8
End If
Next i
8
'++++++++++++++++++++++++++++++++++++Obgektiklava
For i = 1 To 12
If ObgektiKlava(X, i) = 1 And Y = i Then
If i = 12 Then Y = Y - 1: Image1(3).Top = Image1(3).Top - 720:   GoTo 9
If Nedvigimocti(X, i + 1) = 1 Then Y = Y - 1: Image1(3).Top = Image1(3).Top - 720: GoTo 9
If ObgektiBlok(X, i + 1) = 1 Then Y = Y - 1: Image1(3).Top = Image1(3).Top - 720: GoTo 9
If Obgektimonitor(X, i + 1) = 1 Then Y = Y - 1: Image1(3).Top = Image1(3).Top - 720: GoTo 9
Image3(2).Top = Image3(2).Top + 720:
ObgektiKlava(X, i + 1) = 1
ObgektiKlava(X, i) = 0:
XKlava = XKlava:
YKlava = YKlava + 720
GoTo 9
End If
Next i
9
Label1.Caption = X
Label2.Caption = Y
Image1(1).Visible = False: Image1(2).Visible = False: Image1(4).Visible = False
For i = 1 To 4
Image1(i).Left = Image1(3).Left
Image1(i).Top = Image1(3).Top
Next i
End If
'+++++++++++++++++++++++++++++++++++++++++++ВПРАВО+++++++++++++++++++++++++++++
If KeyCode = 39 Then
Image1(4).Visible = True
Image1(4).Left = Image1(4).Left + 720: X = X + 1: Y = Y
If Image1(4).Left > Form1.Width - 720 Then Image1(4).Left = Image1(4).Left - 720: X = X - 1: Y = Y
For i = 1 To 12
If Nedvigimocti(i, Y) = 1 And X = i Then Image1(4).Left = Image1(4).Left - 720: X = X - 1: Y = Y
Next i
Label1.Caption = X
Label2.Caption = Y
'++++++++++++++++++++++++++++++++++++ObgektiBlok
For i = 1 To 12
If ObgektiBlok(i, Y) = 1 And X = i Then
If i = 12 Then X = X - 1: Image1(4).Left = Image1(4).Left - 720:   GoTo 10
If Nedvigimocti(i + 1, Y) = 1 Then X = X - 1: Image1(4).Left = Image1(4).Left - 720: GoTo 10
If Obgektimonitor(i + 1, Y) = 1 Then X = X - 1: Image1(4).Left = Image1(4).Left - 720: GoTo 10
If ObgektiKlava(i + 1, Y) = 1 Then X = X - 1: Image1(4).Left = Image1(4).Left - 720: GoTo 10
Image3(1).Left = Image3(1).Left + 720:
ObgektiBlok(i + 1, Y) = 1
ObgektiBlok(i, Y) = 0:
XBlok = XBlok:
YBlok = YBlok + 720
GoTo 10
End If
Next i
10
'++++++++++++++++++++++++++++++++++++Obgektimonitor
For i = 1 To 12
If Obgektimonitor(i, Y) = 1 And X = i Then
If i = 12 Then X = X - 1: Image1(4).Left = Image1(4).Left - 720:   GoTo 11
If Nedvigimocti(i + 1, Y) = 1 Then X = X - 1: Image1(4).Left = Image1(4).Left - 720: GoTo 11
If ObgektiBlok(i + 1, Y) = 1 Then X = X - 1: Image1(4).Left = Image1(4).Left - 720: GoTo 11
If ObgektiKlava(i + 1, Y) = 1 Then X = X - 1: Image1(4).Left = Image1(4).Left - 720: GoTo 11
Image3(3).Left = Image3(3).Left + 720:
Obgektimonitor(i + 1, Y) = 1
Obgektimonitor(i, Y) = 0:
Xmonitor = Xmonitor:
Ymonitor = Ymonitor + 720
GoTo 11
End If
Next i
11
'++++++++++++++++++++++++++++++++++++Obgektiklava
For i = 1 To 12
If ObgektiKlava(i, Y) = 1 And X = i Then
If i = 12 Then X = X - 1: Image1(4).Left = Image1(4).Left - 720:   GoTo 12
If Nedvigimocti(i + 1, Y) = 1 Then X = X - 1: Image1(4).Left = Image1(4).Left - 720: GoTo 12
If ObgektiBlok(i + 1, Y) = 1 Then X = X - 1: Image1(4).Left = Image1(4).Left - 720: GoTo 12
If Obgektimonitor(i + 1, Y) = 1 Then X = X - 1: Image1(4).Left = Image1(4).Left - 720: GoTo 12
Image3(2).Left = Image3(2).Left + 720:
ObgektiKlava(i + 1, Y) = 1
ObgektiKlava(i, Y) = 0:
XKlava = XKlava:
YKlava = YKlava + 720
GoTo 12
End If
Next i
12
Image1(1).Visible = False: Image1(2).Visible = False: Image1(3).Visible = False
For i = 1 To 4
Image1(i).Left = Image1(4).Left
Image1(i).Top = Image1(4).Top
Next i
End If
End Sub
Private Sub Form_Load()
X = 1
Y = 1
t = 1
'тут пошагово можешь проследить можешь на потом оставить
' тут не сложно просто координаты задаем с блокнота
'Form_Load оставт на потом снасало разбери основной код который  выше


Open "c:\Cokoban\Nedvigimocti.txt" For Input As #1
Do While Not EOF(1) 'Начинаем цикл -делать пока нет конца файла номер 1
Input #1, st 'Считываем из очередной строки переменую st
If t = 0 Then GoTo 1111
j = j + 1
If t = 1 Then XNed(j) = st: k = 0:
1111
t = 0
If k = 0 Then GoTo 2222
If k = 1 Then YNed(j) = st: t = 1
2222
k = 1
Loop
Close #1
For i = 1 To 20
Image5(i).Left = XNed(i) * 720 - 720
Image5(i).Top = YNed(i) * 720 - 720
Nedvigimocti(XNed(i), YNed(i)) = 1
Next i


j = 0
Open "c:\Cokoban\Obgekti.txt" For Input As #1
Do While Not EOF(1) 'Начинаем цикл -делать пока нет конца файла номер 1
Input #1, st 'Считываем из очередной строки переменую st
If t = 0 Then GoTo 11111
j = j + 1
If t = 1 Then XNed(j) = st: k = 0:
11111
t = 0
If k = 0 Then GoTo 22222

If k = 1 Then YNed(j) = st: t = 1
22222
k = 1
Loop
Close #1

For i = 1 To 3
If i = 1 Then
XBlok = XNed(i): YBlok = YNed(i): ObgektiBlok(XBlok, YBlok) = 1
XBlok = XBlok * 720 - 720
YBlok = YBlok * 720 - 720
Image3(1).Left = XBlok
Image3(1).Top = YBlok
End If
If i = 2 Then
Xmonitor = XNed(i): Ymonitor = YNed(i): Obgektimonitor(Xmonitor, Ymonitor) = 1
Xmonitor = Xmonitor * 720 - 720
Ymonitor = Ymonitor * 720 - 720
Image3(3).Left = Xmonitor
Image3(3).Top = Ymonitor
End If
If i = 3 Then
XKlava = XNed(i): YKlava = YNed(i): ObgektiKlava(XKlava, YKlava) = 1
XKlava = XKlava * 720 - 720
YKlava = YKlava * 720 - 720
Image3(2).Left = XKlava
Image3(2).Top = YKlava
End If
Next i


j = 0
Open "c:\Cokoban\duxi.txt" For Input As #1
Do While Not EOF(1) 'Начинаем цикл -делать пока нет конца файла номер 1
Input #1, st 'Считываем из очередной строки переменую st
If t = 0 Then GoTo 111111
j = j + 1
If t = 1 Then XNed(j) = st: k = 0:
111111
t = 0
If k = 0 Then GoTo 222222

If k = 1 Then YNed(j) = st: t = 1
222222
k = 1
Loop
Close #1

For i = 1 To 3
If i = 1 Then
DuxBlokX = XNed(i):
DuxBlokY = YNed(i)
DuxBlokX = DuxBlokX * 720 - 720
DuxBlokY = DuxBlokY * 720 - 720
Image2(1).Left = DuxBlokX
Image2(1).Top = DuxBlokY
End If
If i = 2 Then
DuxMonitorX = XNed(i):
DuxMonitorY = YNed(i)
DuxMonitorX = DuxMonitorX * 720 - 720
DuxMonitorY = DuxMonitorY * 720 - 720
Image2(3).Left = DuxMonitorX
Image2(3).Top = DuxMonitorY
End If
If i = 3 Then
DuxKlavaX = XNed(i):
DuxKlavaY = YNed(i)
DuxKlavaX = DuxKlavaX * 720 - 720
DuxKlavaY = DuxKlavaY * 720 - 720
Image2(2).Left = DuxKlavaX
Image2(2).Top = DuxKlavaY
End If
If i = 4 Then
Image4.Left = XNed(i):
Image4.Top = YNed(i)
Image4.Left = Image4.Left * 720 - 720
Image4.Top = Image4.Top * 720 - 720
End If

If i = 5 Then
Image1(4).Left = XNed(i):
Image1(4).Top = YNed(i)
Image1(4).Left = Image1(4).Left * 720 - 720
Image1(4).Top = Image1(4).Top * 720 - 720
End If


Next i

End Sub

Private Sub Timer1_Timer()
If Pobeda = 1 Then Exit Sub
If Image2(1).Left = Image3(1).Left And Image2(1).Top = Image3(1).Top And Image2(2).Left = Image3(2).Left And Image2(2).Top = Image3(2).Top And Image2(3).Left = Image3(3).Left And Image2(3).Top = Image3(3).Top And Image4.Top = Image1(1).Top And Image4.Left = Image1(1).Left Then
Pobeda = 1
MsgBox "Поздравляем", , "Ура!!!"
End If
End Sub
