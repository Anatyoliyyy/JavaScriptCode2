Attribute VB_Name = "Модуль1"
Public Const SND_ASYNC = &H1
Public Const SND_FILENAME = &H20000
Public Const SRCCOPY = &HCC0020 ' (DWORD) dest = source
Public Declare Function PlaySound Lib "winmm.dll" _
    Alias "PlaySoundA" _
    (ByVal lpszName As String, _
    ByVal hModule As Long, _
    ByVal dwFlags As Long) _
    As Long


