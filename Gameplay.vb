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
    ' Scoreboard for game
    Public ScoreBoardTable As ScoreBoardControll
    ' Index to current player having turn
    Private currentPlayer As Integer
    ' Each dice have their own index. Example: If two dices with value two exist than currentDiceScore(1) has value 2.
    Private currentDiceScore As Integer()
    ' Rolls left in turn
    Private rollsLeft As Integer
    ' Are scoreboard active
    Private scoreBoardActive As Boolean
    ' Are event for holding dice active
    Private dicesActive As Boolean
    ' Amount of rows in scoreboard
    Private rows As Integer
    ' Bonus limit
    Private bonusLimit As Integer
    ' Bonus score
    Private bonusScore As Integer
    ' Amount of round played
    Private roundPlayed As Integer
    ' Counts each scorecategory
    Private forcedCount As Integer
    ' True if game is finished
    Private gameIsFinished As Boolean

    ' Constructor with important arguments for new game.
    Public Sub New(ByVal dicePicBoxes As PictureBox(), ByVal playersName As String(), ByVal isForced As Boolean, ByVal isMaxi As Boolean, ByVal ScoreBoardControll As ScoreBoardControll)

        Me.isForced = isForced
        Me.isMaxi = isMaxi
        Me.ScoreBoardTable = ScoreBoardControll
        gameIsFinished = False
        rows = ScoreBoardTable.table.RowCount - 1

        bonusLimit = 63
        If isMaxi Then
            bonusScore = 100
            If Not isForced Then
                bonusLimit = 84
            End If
        Else
            bonusScore = 50
        End If

        'Init dice objects and store Pictureboxes for dices in them.
        initDices(dicePicBoxes)
        'Init player objects and store players name in them.
        initPlayers(playersName)
        'Choose next turn. True as arugement means its first turn in game.
        nextTurn(True)

    End Sub

    Public Sub nextTurn(ByRef isFirstTurn As Boolean)

        If isFirstTurn Then
            'First player in players(0) starts playing. If we use -1 as currentplayer next player will be 0.
            currentPlayer = 0
            roundPlayed += 1
            forcedCount += 1

        ElseIf currentPlayer + 1 < players.Length
            currentPlayer = currentPlayer + 1
        Else
            ' Check if game is finished
            isGameFinished()

            currentPlayer = 0
            roundPlayed += 1
            forcedCount += 1

        End If

        If Not gameIsFinished Then

            'Remove hold from all dices
            resetDiceHold()
            'Highlight current player 
            ScoreBoardTable.MarkCurrentPlayer(currentPlayer)
            'Deactivate scoreboard before first roll
            scoreBoardActive = False
            'Deactivate dices before first roll
            dicesActive = False
            rollsLeft = 3
        End If
    End Sub

    ' Function for initialize player objects
    Public Sub initPlayers(ByVal playersName As String())

        ReDim players(playersName.Length - 1)
            'Loop through players name and use them for arguments for new player objects.
            For i = 0 To playersName.Length - 1
                Dim scoreBoard(rows, 1) As Integer
                players(i) = New Player(playersName(i), scoreBoard)
            Next i

        ScoreBoardTable.setPlayerNames(playersName)

    End Sub


    ' Function for init dices
    Public Sub initDices(ByVal dicePicBoxes As PictureBox())

        ReDim diceArray(dicePicBoxes.Length - 1)
        ' Redim with 5 because both normal and maxi have highest possible dice score as 6
        ReDim currentDiceScore(5)
        'Loop through Pictureboxes for dices and use them as arguments for dice objects.
        For i = 0 To dicePicBoxes.Length - 1
            diceArray(i) = New Dice(dicePicBoxes(i))
        Next i

    End Sub

    Public Sub ChangeDiceColor(ByVal sender As Object, ByVal shouldChange As Boolean)
        'Cast sender object to PictureBox
        Dim thisPictureBox As PictureBox = CType(sender, PictureBox)
        'Get tagName from PictureBox. Tagnames are 1,2,3,4,5 and 6
        Dim tagName As String = thisPictureBox.Tag
        'Tagname is string and we need to convert to 32 bit integer
        Dim tagNameTwo As Integer = Convert.ToInt32(thisPictureBox.Tag)
        'Check if current dice is at hold or not.
        If GetDiceHold(tagNameTwo - 1) = False Then
            'If its not at hold we change color.
            diceArray(tagNameTwo - 1).ChangeColor(shouldChange)
        End If
    End Sub

    'This function is called from YatzyForm when Roll button are clicked
    Public Sub Roll()
        'Set currentDiceScore values back to default value 0
        Array.Clear(currentDiceScore, 0, currentDiceScore.Length)
        'Scoreboard is active after first roll
        scoreBoardActive = True
        rollsLeft -= 1
        'Loop through all dice objects and roll them!
        For i = 0 To diceArray.Length - 1

            diceArray(i).Roll()

            Dim diceValue As Integer = diceArray(i).DiceValue
            currentDiceScore(diceValue - 1) += 1

        Next i

        'Change hold dices back to normal color if its last roll
        ' If rollsLeft = 0 Then
        ' resetDiceHold()
        'End If

        If rollsLeft < 1 Then
            dicesActive = False

            If isForced Then
                forcedChoose()
            End If

        Else
            dicesActive = True
        End If


    End Sub

    Private Sub resetDiceHold()
        For i = 0 To diceArray.Length - 1
            diceArray(i).DiceHold = False
            diceArray(i).ChangeColor(False)
        Next i
    End Sub

    Public Sub forcedChoose()
        'Skip sum and bonus
        If forcedCount = 7 Then
            forcedCount = 9
        End If
        Dim textLabel As Label = ScoreBoardTable.table.GetControlFromPosition(0, forcedCount)
        Dim tagNameTwo As Integer = Convert.ToInt32(textLabel.Tag)
        checkScore(tagNameTwo, forcedCount)
    End Sub

    'This function is used when dice Pictureboxes are clicked. Toggle between hold and unhold.
    Public Sub ToggleDiceHold(sender As Object)
        'Cast sender object to PictureBox
        Dim thisPictureBox As PictureBox = CType(sender, PictureBox)
        'Tagname is string and we need to convert to 32 bit integer
        Dim tagName As Integer = Convert.ToInt32(thisPictureBox.Tag)
        diceArray(tagName - 1).ToggleHold()
    End Sub

    Function checkScore(ByVal scoreTag As Integer, ByVal scoreIndexRow As Integer)

        ' Return false if score combination was invalid
        Dim isAllowed As Boolean = False

        Dim currentP As Player = players(currentPlayer)
        ' Test if its allowed to set current score
        If currentP.isScoreValid(scoreIndexRow) Then
            Dim calcScore As Integer = calculateScore(scoreTag)

            currentP.updateScore(scoreIndexRow, calcScore)
            ScoreBoardTable.upDatePlayersScore(currentPlayer, currentP.playersScore)

            ' Check if its bonustime
            checkBonus()
            ' Next players turn
            nextTurn(False)
            isAllowed = True
        End If

        Return isAllowed

    End Function

    Private Sub isGameFinished()

        ' 3 is because sum, bonus and total
        Dim scoreCombis As Integer = rows - 3

        If roundPlayed = scoreCombis Then

            gameIsFinished = True
            'Deactivate scoreboard
            scoreBoardActive = False
            'Deactivate dices
            dicesActive = False

            Dim winner(,) As Integer = findWinner()
            Dim highscoreText As String = getHighScoreText(winner)

            Dim winText As String = ""
            Dim pos As Integer = 1
            For i = 0 To winner.GetLength(0) - 1
                Dim name As String = players(winner(i, 1)).getName
                winText &= pos & ". " & name & "  " & winner(i, 0) & Environment.NewLine
                pos += 1
            Next

            MessageBox.Show(winText & Environment.NewLine & highscoreText)

        End If


    End Sub

    Private Function getHighScoreText(ByVal sortedPlayers As Integer(,))

        Dim highScoreText As String = ""
        Dim highScoreObj As Highscore = New Highscore()
        Dim yatzyType As Integer = 0

        If isMaxi And Not isForced Then yatzyType = 1
        If Not isMaxi And isForced Then yatzyType = 2
        If Not isMaxi And Not isForced Then yatzyType = 3

        For i = 0 To sortedPlayers.GetLength(0) - 1
            Dim name As String = players(sortedPlayers(i, 1)).getName
            Dim totalScore As String = sortedPlayers(i, 0)
            Dim currentDate As String = DateTime.Now.ToString("dd/MM/yy")

            Dim hSArgument = New String() {name, totalScore, currentDate}

            Dim position As Integer = highScoreObj.writeScore(hSArgument, yatzyType)

            If position > 0 Then highScoreText = highScoreText & name & " got " & position & ".place" & Environment.NewLine
        Next

        If Not String.IsNullOrEmpty(highScoreText) Then

            highScoreText = "New highscore!" & Environment.NewLine & highScoreText

        End If

        Return highScoreText

    End Function

    ' Function to calculate and write oute winners
    Private Function findWinner()

        Dim winner(players.Length - 1, 2) As Integer

        For i = 0 To players.Length - 1
            Dim currentP As Player = players(i)
            Dim totalScore As Integer = currentP.getTotalScore()

            winner(i, 0) = totalScore
            winner(i, 1) = i

            'Console.WriteLine(i)
            'Console.WriteLine(totalScore)

            currentP.updateScore(currentP.playersScore.GetLength(0) - 1, totalScore)
            ScoreBoardTable.upDatePlayersScore(i, currentP.playersScore)
        Next i

        Return sort2d(winner)

    End Function

    'Selection Sorting of winners
    Private Function sort2d(ByVal intArray As Integer(,))

        Dim scoreArray(intArray.GetLength(0)) As Integer
        Dim indexArray(intArray.GetLength(0)) As Integer

        For i = 0 To intArray.GetLength(0) - 1
            scoreArray(i) = intArray(i, 0)
            indexArray(i) = intArray(i, 1)
        Next
        Array.Sort(scoreArray, indexArray)
        Array.Reverse(scoreArray)
        Array.Reverse(indexArray)
        For i = 0 To intArray.GetLength(0) - 1
            intArray(i, 0) = scoreArray(i)
            intArray(i, 1) = indexArray(i)
        Next

        Return intArray

    End Function

    Private Sub checkBonus()

        Dim currentP As Player = players(currentPlayer)

        If (currentP.leftForBonusCalc = 0) Then
            ' Index 7 equals to sum field
            currentP.updateScore(7, currentP.bonusPoints)
            ' Index 8 equals to bonus field
            If (currentP.bonusPoints >= bonusLimit) Then
                currentP.updateScore(8, bonusScore)
            Else
                currentP.stroke(8)
            End If
            ScoreBoardTable.upDatePlayersScore(currentPlayer, currentP.playersScore)

            ' To avoid double bonus calculation
            currentP.leftForBonusCalc = -1
        End If

    End Sub
    ' Function to calculate score. Argument are an choosen dice combination
    ' Return value is best possible score from current dice position.
    ' Example: If caclulateScore(8) are called and dice values
    ' are  1, 2, 2, 4, 4 return value would be 8. 
    ' Argument 8 equals to pair and best score from combination are 4 + 4 = 8
    Private Function calculateScore(ByVal scoreIndex As Integer)

        Dim bestScore As Integer = 0

        Select Case scoreIndex
            ' NORMAL AND MAXI YATZY COMBINATIONS
            ' Ones
            Case 1
                bestScore = currentDiceScore(0)
            ' Twos
            Case 2
                bestScore = currentDiceScore(1) * 2
            ' Threes
            Case 3
                bestScore = currentDiceScore(2) * 3
            ' Fours
            Case 4
                bestScore = currentDiceScore(3) * 4
            ' Fives
            Case 5
                bestScore = currentDiceScore(4) * 5
            ' Sixes
            Case 6
                bestScore = currentDiceScore(5) * 6
            ' Skipping some indexes because 7 are Sum and 8 are bonus
            ' 1 Pair
            Case 9
                For i = 0 To currentDiceScore.Length - 1
                    If currentDiceScore(i) >= 2 Then
                        'Highest value is allways the last one
                        bestScore = 2 * (i + 1)
                    End If
                Next
            ' 2 Pairs
            Case 10
                'Lets loop backword from heighst value to lowest.
                'Stop when to pairs are found. Thats the heigest possible score.
                Dim limit As Integer = 0
                For i = currentDiceScore.Length - 1 To 0 Step -1
                    If currentDiceScore(i) >= 2 Then
                        bestScore += 2 * (i + 1)
                        limit += 1
                    End If
                    If limit = 2 Then
                        Exit For
                    End If
                Next
                ' If one or no pairs was found we have to set it back to 0
                If limit < 2 Then
                    bestScore = 0
                End If
            ' 3 of a kind
            Case 11
                For i = 0 To currentDiceScore.Length - 1
                    If currentDiceScore(i) >= 3 Then
                        'Highest value is allways the last one
                        bestScore = 3 * (i + 1)
                    End If
                Next
            ' 4 of a kind
            Case 12
                For i = 0 To currentDiceScore.Length - 1
                    If currentDiceScore(i) >= 4 Then
                        bestScore = 4 * (i + 1)
                    End If
                Next
            ' Small straight
            Case 13
                Dim limit As Integer = 0
                For i = 0 To 4
                    If currentDiceScore(i) > 0 Then
                        bestScore += (i + 1)
                        limit += 1
                    End If
                Next
                If Not limit = 5 Then
                    bestScore = 0
                End If
            ' Large straight
            Case 14
                Dim limit As Integer = 0
                For i = 1 To 5
                    If currentDiceScore(i) > 0 Then
                        bestScore += i + 1
                        limit += 1
                    End If
                Next
                If Not limit = 5 Then
                    bestScore = 0
                End If
            ' House (Maxi Yatzy also use this as Cabin)
            Case 15
                Dim foundPair As Boolean
                Dim foundThreeOfAKind As Boolean
                For i = 0 To currentDiceScore.Length - 1
                    If currentDiceScore(i) = 2 Then
                        bestScore += 2 * (i + 1)
                        foundPair = True
                    ElseIf currentDiceScore(i) = 3 Then
                        bestScore += 3 * (i + 1)
                        foundThreeOfAKind = True
                    End If
                Next
                If Not foundPair Or Not foundThreeOfAKind Then
                    bestScore = 0
                End If
            ' Chance
            Case 16
                For i = 0 To currentDiceScore.Length - 1
                    bestScore += (currentDiceScore(i) * (i + 1))
                Next
            ' Yatzy
            Case 17
                For i = 0 To currentDiceScore.Length - 1
                    If currentDiceScore(i) = currentDiceScore.Length Then
                        If isMaxi Then
                            bestScore = 100

                        Else
                            bestScore = 50
                        End If
                    End If

                Next

            ' Skipping 18 because thats Total
            ' MAXI YATZY SCORE COMBINATIONS
            ' Three pairs
            Case 19
                'Lets loop backword from heighst value to lowest.
                'Stop when to pairs are found. Thats the heigest possible score.
                Dim limit As Integer = 0
                For i = currentDiceScore.Length - 1 To 0 Step -1
                    If currentDiceScore(i) >= 2 Then
                        bestScore += 2 * (i + 1)
                        limit += 1
                    End If
                    If limit = 3 Then
                        Exit For
                    End If
                Next
                ' If one or no pairs was found we have to set it back to 0
                If limit < 3 Then
                    bestScore = 0
                End If
            ' 5 of a kind
            Case 20
                For i = 0 To currentDiceScore.Length - 1
                    If currentDiceScore(i) >= 5 Then
                        bestScore = 5 * (i + 1)
                    End If
                Next
            ' Full straight
            Case 21
                Dim limit As Integer = 0
                For i = 0 To currentDiceScore.Length - 1
                    If currentDiceScore(i) > 0 Then
                        bestScore += i + 1
                        limit += 1
                    End If
                Next
                If Not limit = 6 Then
                    bestScore = 0
                End If
            ' House in maxi yatzy
            Case 22
                Dim limit As Integer = 0
                For i = 0 To currentDiceScore.Length - 1
                    If currentDiceScore(i) = 3 Then
                        bestScore += 3 * (i + 1)
                        limit += 1
                    End If
                Next
                If Not limit = 2 Then
                    bestScore = 0
                End If
            ' Tower
            Case 23
                Dim foundPair As Boolean
                Dim foundThreeOfAKind As Boolean
                For i = 0 To currentDiceScore.Length - 1
                    If currentDiceScore(i) = 2 Then
                        bestScore += 2 * (i + 1)
                        foundPair = True
                    ElseIf currentDiceScore(i) = 4 Then
                        bestScore += 4 * (i + 1)
                        foundThreeOfAKind = True
                    End If
                Next
                If Not foundPair Or Not foundThreeOfAKind Then
                    bestScore = 0
                End If

        End Select

        Return bestScore

    End Function


    ' Function to read if dice are at hold
    Public Function GetDiceHold(ByVal diceIndex As Integer)
        Return diceArray(diceIndex).DiceHold
    End Function
    ' Function for reading rolls left
    Public ReadOnly Property rollsLeftValue() As Integer
        Get
            ' Gets the property value.
            Return rollsLeft
        End Get
    End Property
    ' Function for reading if scoreboard is active
    Public ReadOnly Property isScoreboardActive() As Integer
        Get
            ' Gets the property value.
            Return scoreBoardActive
        End Get
    End Property
    ' Function for reading if scoreboard is active
    Public ReadOnly Property isDicesActive() As Integer
        Get
            ' Gets the property value.
            Return dicesActive

        End Get
    End Property

    Public ReadOnly Property isGameFinishedValue() As Integer
        Get
            ' Gets the property value.
            Return gameIsFinished

        End Get
    End Property

    Public ReadOnly Property isGameForced() As Boolean
        Get
            ' Gets the property value.
            Return isForced

        End Get
    End Property
End Class
