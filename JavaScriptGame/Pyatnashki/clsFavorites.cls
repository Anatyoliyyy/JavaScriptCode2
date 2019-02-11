VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "clsFavorites"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit
'''''''''''''''''''''''''''''''''''''''''''''''''''''
' clsFavorites.cls
'
' Description:
'
' This class encapsulates access to a favorites file.
' It allows a user to add a favorite, delete a favorite,
' update the date of the favorite, and retrieve a specified
' number of favorites.
'
'''''''''''''''''''''''''''''''''''''''''''''''''''''
' Lets not let write strings of more than 256 characters
' to the file
Const lMaxCharacters = 256
Private Type FavoriteItem
    strName As String * lMaxCharacters
    strScore As String * lMaxCharacters
    strTime As String * lMaxCharacters
    dateLastNavigated As Date
End Type
Public Names As New Collection
Public Dates As New Collection
Public URLs As New Collection
Private m_lFavoriteCount As Long
'''''''''''''''''''''''''''''''''''''''''''''''''''''
' AddFavorite
'
' Description:
'
' This method adds a favorite to the specified
' favorites file.
'''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Sub AddFavorite(strFavoritesPath As String, _
                                    strName As String, _
                                    strScore As String, strTime As String)
    On Error Resume Next
    ' Add a favorite to the list, and give it a date of NOW
    Dim strTemp As Variant                  'String   VB  arrrgghhhh
    Dim strTempString As String
    Dim udtFavoriteItem As FavoriteItem
    Dim lRecordLength As Long, iFileNum As Integer, lFileLength As Long
    Dim lIndex As Long
        Err.Clear
    CheckFavoritesFile strFavoritesPath
    ' File doesn't exist? Well, you are hosed.
    If Err.Number <> 0 Then Exit Sub
    ' Enumerate through the names collection. If this favorite
    ' already exists, exit the sub.
    For Each strTemp In Names
        strTempString = strTemp
        strTemp = strTempString
        If strTemp = strName Then Exit Sub
    Next
    If strName = "Sheridan Software Systems, Inc." Then
        ' Let's not add ourselves.
        Exit Sub
    End If
    ' This is a new favorite. Lets add it to the internal collections.
    Names.add strName
    Dates.add strTime
    URLs.add strScore
    ' Get the length of the user defined type.
    lRecordLength = Len(udtFavoriteItem)
    ' Now lets add the favorite to the Favorites file.
    udtFavoriteItem.dateLastNavigated = Date
    udtFavoriteItem.strName = EncodeString(strName)
    udtFavoriteItem.strScore = EncodeString(strScore)
    udtFavoriteItem.strTime = EncodeString(strTime)
    ' Now lets get the next free file number.
    iFileNum = FreeFile
    ' Open the favorites file for random access.
    Open strFavoritesPath For Random As iFileNum Len = lRecordLength
    lFileLength = FileLen(strFavoritesPath)
    lIndex = lFileLength / lRecordLength
    lIndex = lIndex + 1
    ' Write the favorite to the file at position lIndex
    Put #iFileNum, lIndex, udtFavoriteItem
    Close #iFileNum
End Sub
'''''''''''''''''''''''''''''''''''''''''''''''''''''
' DeleteFavorite
'
' Description:
'
' This method deletes a favorite from a
' favorites file.
'''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Sub DeleteFavorite(strFavoritesPath As String, _
                                    lFavoriteCount As Long, _
                                    strName As String)

    ' delete a specified favorite
    
    ' steps:
    ' 1. copy all of the records of the favorites file to a temp file. If we find the record
    ' that the caller wants to delete, DON'T copy it over.
    ' 2. Delete the favorites file.
    ' 3. Rename the temp file to be the favorites file.
    ' 4. Call Retrieve favorites with the favorite count
    
    On Error Resume Next
    
    Dim lIndex As Long, lItemToBeDeleted As Long
    Dim iFavFile As Integer, iTempFile As Integer
    Dim udtFavoriteItem As FavoriteItem
    Dim lRecordLength As Long
    Dim lFileLength As Long
    Dim varItem As Variant
    Dim lPosition As Long
    Dim attr As VbFileAttribute
    
    lItemToBeDeleted = 0
    
    CheckFavoritesFile strFavoritesPath
    
    ' Lets first check if the item that is going to be deleted exists
    For lIndex = 1 To Names.Count
        
        If Names.Item(lIndex) = strName Then
            
            lItemToBeDeleted = lIndex
            Exit For
        
        End If
    
    Next
    
    If lItemToBeDeleted = 0 Then Exit Sub
    
    
    lRecordLength = Len(udtFavoriteItem)
    
    ' Now lets copy all of the favorites except the deleted guy to a temp file
    iFavFile = FreeFile
    Open strFavoritesPath For Random As iFavFile Len = lRecordLength
    iTempFile = FreeFile
    Open App.Path & "\temp.txt" For Random As iTempFile Len = lRecordLength
    
    lPosition = 1
    
    ' Lets iterate through the records and copy them to the temp file.
    For lIndex = 1 To Names.Count
    
        If lIndex <> lItemToBeDeleted Then
        
            Get iFavFile, lIndex, udtFavoriteItem
            Put #iTempFile, lPosition, udtFavoriteItem
            lPosition = lPosition + 1
        
        End If
    
    Next
    
    Close #iFavFile
    Close #iTempFile
    
    ' Lets update the collections
    Names.Remove lItemToBeDeleted
    URLs.Remove lItemToBeDeleted
    Dates.Remove lItemToBeDeleted
    
    ' Now lets kill the favorites file.
    Kill strFavoritesPath
    
    ' Rename the temp file to the name of the favorites file.
    FileCopy App.Path & "\temp.txt", strFavoritesPath
    
    ' Kill the temp file.
    Kill App.Path & "\temp.txt"

    
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''
' UpdateFavorite
'
' Description:
'
' This method updates the date of a favorite in
' the favorites file.
'''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Sub UpdateFavorite(strFavoritesPath As String, _
                                        strName As String, _
                                        dateLastNavigated As Date)

    On Error Resume Next

    Dim lItemToBeUpdated As Long
    Dim iFavFile As Integer, lRecordLength As Long
    Dim udtFavoriteItem As FavoriteItem
    Dim lIndex As Long
    
    
    ' Check the favorites file
    CheckFavoritesFile strFavoritesPath
    
    If Err.Number <> 0 Then Exit Sub
    
    
    ' update the date of the favorite
    
    lRecordLength = Len(udtFavoriteItem)
    
    lItemToBeUpdated = 0
    
    ' Lets find the position of the item to be updated
    For lIndex = 1 To Names.Count
    
        If Names(lIndex) = strName Then
        
            lItemToBeUpdated = lIndex
            Exit For
        
        End If
    
    Next

    If lItemToBeUpdated = 0 Then Exit Sub
    
    iFavFile = FreeFile
    
    
    ' Now lets open the file, and update the record
    Open strFavoritesPath For Random As iFavFile Len = lRecordLength
    
        Get iFavFile, lItemToBeUpdated, udtFavoriteItem
        udtFavoriteItem.dateLastNavigated = dateLastNavigated
        Put #iFavFile, lItemToBeUpdated, udtFavoriteItem
    
    Close #iFavFile
    
    ' Now lets update the collections
    RetrieveFavorites strFavoritesPath, m_lFavoriteCount

End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''
' RetrieveFavorites
'
' Description:
'
' This method retrieves favorites from a favorites
' file, and puts them in our collections.
'''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Sub RetrieveFavorites(strFavoritesPath As String, _
                                                lFavoriteCount As Long)

    ' Get a specified number of favorites
    
    On Error Resume Next
    
    Dim lCount As Long
    Dim lIndex As Long
    Dim lFileLength As Long, lRecordLength As Long, iFavFile As Integer
    Dim udtFavoriteItem As FavoriteItem
    Dim lRecordCount As Long, lRecordIndex As Long
    Dim lRecordIndexStart As Long
    
    CheckFavoritesFile strFavoritesPath
    
    If Err.Number <> 0 Then Exit Sub
    
    m_lFavoriteCount = lFavoriteCount
    
    ' Clear the collections first
    lCount = Names.Count
    For lIndex = 1 To lCount
    
        Names.Remove 1
    
    Next
    
    lCount = URLs.Count
    For lIndex = 1 To lCount
    
        URLs.Remove 1
    
    Next
    
    lCount = Dates.Count
    For lIndex = 1 To lCount
    
        Dates.Remove 1
    
    Next
    
    ' Get the next free file number
    iFavFile = FreeFile
    
    lRecordLength = Len(udtFavoriteItem)
    lFileLength = FileLen(strFavoritesPath)
    
    If lRecordLength <> 0 Then
        
        lRecordCount = lFileLength / lRecordLength
    
    Else
    
        Exit Sub
    
    End If
    
    ' We only want a specified number of history items.
    If lRecordCount > lFavoriteCount Then
    
        lRecordIndexStart = lRecordCount - lFavoriteCount + 1
    
    Else
    
        lRecordIndexStart = 1
    
    End If
    
    ' Now lets open the file and get our items
    Open strFavoritesPath For Random As iFavFile Len = lRecordLength
    
        For lRecordIndex = lRecordIndexStart To lRecordCount
        
            Get iFavFile, lRecordIndex, udtFavoriteItem
            Names.add DecodeString(udtFavoriteItem.strName)
            URLs.add DecodeString(udtFavoriteItem.strScore)
            Dates.add udtFavoriteItem.strTime
        
        Next
    
    Close #iFavFile
    
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''
' DecodeString
'
' Description:
'
' This method chops everything after the first null
' character found in the string. The null character
' is put there by the EncodeString method.
'''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Function DecodeString(strString As String) As String

    If (InStr(strString, Chr(0)) > 0) Then
    
        strString = Left(strString, InStr(strString, Chr(0)) - 1)
        
    End If
    
    DecodeString = strString
    
End Function

'''''''''''''''''''''''''''''''''''''''''''''''''''''
' EncodeString
'
' Description:
'
' This method sticks a null character at the end of
' the string.
'''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Function EncodeString(strString As String) As String
    
    EncodeString = strString & Chr(0)

End Function

'''''''''''''''''''''''''''''''''''''''''''''''''''''
' CheckFavoritesFile
'
' Description:
'
' This method checks to see that the specified
' file is valid. If it isn't, the method looks
' for the file at the location where it should
' really be.
'''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Sub CheckFavoritesFile(strFavoritesPath As String)

    On Error Resume Next

    Dim attr As VbFileAttribute
    
    ' Lets see if the file exists
    attr = GetAttr(strFavoritesPath)
    
    ' File doesn't exist? Let's check the location it SHOULD be in.
    If Err.Number <> 0 Then
    
        strFavoritesPath = App.Path & "\State\Favorites.txt"
        Err.Clear
        attr = GetAttr(strFavoritesPath)
    
    End If
    
End Sub
