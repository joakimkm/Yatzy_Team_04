'Gameplay is the main class for the game.
Public Class Gameplay
    ' Array of dice objects
    Private diceArray() As Dice
    ' Array of player objects
    Private players() As Player
    ' Is game forced or not
    Private isForced As Boolean
    ' Is game maxi or normal
    Private isMaxi As Boolean

    ' Constructor with important arguments for new game.
    Public Sub New(ByVal dicePicBoxes As PictureBox(), ByVal playersName As String(), ByVal isForced As Boolean, ByVal isMaxi As Boolean)

        'Init dice objects and store Pictureboxes for dices in them.
        initDices(dicePicBoxes)
        'Init player objects and store name for players in them.
        initPlayers(playersName)

        Me.isForced = isForced
        Me.isMaxi = isMaxi

    End Sub

    ' Function for initialize player objects
    Public Sub initPlayers(ByVal playersName As String())

        ' If array contain more than one name, we dont need a computer playing.
        If playersName.Length > 1 Then

            ReDim players(playersName.Length - 1)
            'Loop through players name and use them for arguments for player objects.
            For i = 0 To playersName.Length - 1
                players(i) = New Player(playersName(i), False)
            Next i

            ' If array contain only one name, we  need a computer playing.
        Else
            ReDim players(1)
            Dim Computername As String = "Computer"
            players(0) = New Player(playersName(0), False)
            players(1) = New Player(Computername, True)

        End If


    End Sub

    ' Function for init dices
    Public Sub initDices(ByVal dicePicBoxes As PictureBox())

        ReDim diceArray(dicePicBoxes.Length - 1)

        'Loop through Pictureboxes for dices and use them as arguments for dice objects.
        For i = 0 To dicePicBoxes.Length - 1
            diceArray(i) = New Dice(dicePicBoxes(i))
        Next i

    End Sub
    ' This functions is called from YatzyForm when mouse leave Picturebox
    Public Sub DiceMouseLeave(sender As Object)
        'Cast sender object to PictureBox
        Dim thisPictureBox As PictureBox = CType(sender, PictureBox)
        'Get tagName from PictureBox. Tagnames are 1,2,3,4,5 and 6
        Dim tagName As String = thisPictureBox.Tag
        'Tagname is string and we need to convert to 32 bit integer
        Dim tagNameTwo As Integer = Convert.ToInt32(thisPictureBox.Tag)
        'Check if current dice is at hold or not.
        If GetDiceHold(tagNameTwo - 1) = False Then
            'If its not at hold we change color back to normal.
            diceArray(tagNameTwo - 1).ChangeColor(True)
        End If
    End Sub
    ' This functions is called from YatzyForm when mouse enter Picturebox
    Public Sub DiceMouseEnter(sender As Object)
        'Cast sender object to PictureBox
        Dim thisPictureBox As PictureBox = CType(sender, PictureBox)
        'Get tagName from PictureBox. Tagnames are 1,2,3,4,5 and 6
        Dim tagName As String = thisPictureBox.Tag
        'Tagname is string and we need to convert to 32 bit integer
        Dim tagNameTwo As Integer = Convert.ToInt32(thisPictureBox.Tag)
        'Check if current dice is at hold or not.
        If GetDiceHold(tagNameTwo - 1) = False Then
            'If its not at hold we change color.
            diceArray(tagNameTwo - 1).ChangeColor(False)
        End If
    End Sub

    'This function is called from YatzyForm when Roll button are clicked
    Public Sub Roll()
        'Loop through all dice objects and roll them!
        For i = 0 To diceArray.Length - 1
            diceArray(i).Roll()
        Next i
    End Sub

    'This function is used when dice Pictureboxes are clicked. Toggle between hold and unhold.
    Public Sub ToggleDiceHold(sender As Object)
        'Cast sender object to PictureBox
        Dim thisPictureBox As PictureBox = CType(sender, PictureBox)
        'Tagname is string and we need to convert to 32 bit integer
        Dim tagName As Integer = Convert.ToInt32(thisPictureBox.Tag)
        diceArray(tagName - 1).ToggleHold()
    End Sub

    ' Function to read if dice are at hold
    Public Function GetDiceHold(ByVal diceIndex As Integer)
        Return diceArray(diceIndex).DiceHold
    End Function

End Class
