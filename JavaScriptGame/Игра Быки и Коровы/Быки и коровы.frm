VERSION 5.00
Begin VB.Form Form1 
 Caption = "Быки и коровы"
 ClientHeight = 3120
 ClientLeft = 120
 ClientTop = 450
 ClientWidth = 4920
 LinkTopic = "Form1"
 ScaleHeight = 3120
 ScaleWidth = 4920
 StartUpPosition = 3 'Windows Default
 Begin VB.Frame Frame1 
 Caption = "Правила игры"
 Height = 1935
 Left = 2160
 TabIndex = 7
 Top = 0
 Width = 2655
 Begin VB.TextBox Text1 
 Height = 1575
 Left = 120
 Locked = -1 'True
 MultiLine = -1 'True
 ScrollBars = 2 'Vertical
 TabIndex = 8
 Text = "Bulls&Cows.frx":0000
 Top = 240
 Width = 2415
 End
 End
 Begin VB.CommandButton restart 
 Caption = "Перезагадать"
 Height = 495
 Left = 0
 TabIndex = 6
 Top = 1560
 Width = 2055
 End
 Begin VB.CommandButton show 
 Caption = "Показать"
 Height = 255
 Left = 0
 TabIndex = 5
 Top = 480
 Width = 2055
 End
 Begin VB.TextBox Text2go 
 Height = 405
 Left = 0
 MaxLength = 5
 TabIndex = 2
 Top = 720
 Width = 2055
 End
 Begin VB.TextBox log 
 Height = 975
 Left = 0
 Locked = -1 'True
 MultiLine = -1 'True
 ScrollBars = 2 'Vertical
 TabIndex = 1
 Top = 2040
 Width = 4815
 End
 Begin VB.CommandButton BtnGo 
 Caption = "Проверить"
 Height = 495
 Left = 0
 TabIndex = 0
 Top = 1080
 Width = 2055
 End
 Begin VB.Label complabel 
 AutoSize = -1 'True
 Caption = "*****"
 Height = 195
 Left = 600
 TabIndex = 4
 Top = 240
 Width = 300
 End
 Begin VB.Label Label1 
 AutoSize = -1 'True
 Caption = "Компьютер загадал число"
 Height = 195
 Left = 0
 TabIndex = 3
 Top = 0
 Width = 2010
 End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim doo As Integer 'до скольки
Dim ot As Integer 'от скольки

Dim compstr As String 'строка содержит в себе задуманное компом число
Dim Bull As Integer ' кол-во быков
Dim Cow As Integer 'кол-во коров
Dim CowName As String 'для красоты отображения
Dim BullName As String 'тоже самое
Dim current As String 'текущая цифра
Dim curpos As Integer 'текущая позиция
Dim curcomppos As Integer 'позиция у компа
Public Sub Random()
Randomize 'рандом
ot = 1111
doo = 9999
Randstr = Int((doo - ot + 1) * Rnd + ot) 'генирирует 4-х значное число тк 5-ти уже слишком много ему
compstr = Randstr & Int(Rnd() * 9) 'совмещаем randstr и случайное число от 0 до 9
complabel.Caption = "*****" 'скрываем число
End Sub

Private Sub FindBullCow(ByVal UserString As String)
'ищем
' MsgBox InStr(1, "где ищем", "что ищем") 'вернет 0 если строка не найдена если >0 значит найдена


Cow = 0
Bull = 0
For i = 1 To 5
current = Mid(UserString, i, 1)
curpos = InStr(1, UserString, current)
curcomppos = InStr(1, compstr, current)

 If curpos = curcomppos Then ' если номер позиции совпадает с позицией у компа значит это бык
 Bull = Bull + 1
 End If

 If curpos <> curcomppos And curcomppos <> 0 Then ' иначе это корова
 Cow = Cow + 1
 End If

Next i
' для грамотности делаем обработку чисел
If Cow = 1 Then
CowName = " Корова"
ElseIf Cow = 0 Or Cow = 5 Then
CowName = " Коров"
ElseIf Cow > 1 < 5 Then
CowName = " Коровы"
End If

If Bull = 1 Then
BullName = " Бык"
ElseIf Bull = 0 Or Bull = 5 Then
BullName = " Быков"
ElseIf Bull > 1 < 5 Then
BullName = " Быка"
End If
'конечный результат при выйгрыше
If Bull = 5 Then
result = "Вы угадали число компьютера " & compstr & vbCrLf
MsgBox result, vbExclamation, "Win"
Else
result = ""
End If
log.Text = UserString & " -- " & Cow & CowName & " " & Bull & BullName & vbCrLf & result & log.Text & vbCrLf
End Sub




Private Sub BtnGo_Click()
If Len(Text2go.Text) = 5 Then ' не даем проверять если число меньше 5-ти
Call FindBullCow(Text2go.Text)
Else
MsgBox "Введите 5-ти значное число!", vbCritical, "Ошибка"
End If
End Sub

Private Sub Form_Load()
Call Random ' "придумываем число"

End Sub

Private Sub restart_Click()
Call Random ' "придумываем число"
End Sub

Private Sub show_Click()
complabel.Caption = compstr 'открываем число загаданное компьютером
End Sub

Private Sub Text2go_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = 13 Then BtnGo_Click 'если в текстовом поле нажмут Enter то эмулируем нажатие кнопки "проверить"
End Sub

