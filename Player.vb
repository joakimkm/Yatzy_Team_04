﻿'Each player has its own object from player class
Public Class Player
    ' Players username
    Private name As String
    ' Array with score
    Private scoreBoard As Integer(,)
    ' Stores rolls left before bonus should be calculated
    Public leftForBonusCalc As Integer
    ' Bonus points are continuelsy added to this
    Public bonusPoints As Integer

    ' Constructor for player class
    Public Sub New(ByVal name As String, ByVal scoreBoard As Integer(,))
        Me.name = name
        Me.scoreBoard = scoreBoard
        leftForBonusCalc = 6
    End Sub

    ' Calculate total score
    Public Function getTotalScore()
        Dim totalSum As Integer
        Dim length As Integer = scoreBoard.GetLength(0) - 1
        For r As Integer = 7 To length
            totalSum += playersScore(r, 0)
        Next r

        Return totalSum
    End Function

    ' Function to test if its possible to set new score value
    Public Function isScoreValid(ByVal scoreIndex As Integer)
        Dim isValid As Boolean = False
        If scoreBoard(scoreIndex, 0) = 0 And scoreBoard(scoreIndex, 1) = 0 Then
            isValid = True
        End If
        Return isValid
    End Function

    ' Update players score
    Sub updateScore(ByVal scoreIndex As Integer, ByVal scoreValue As Integer)

        If scoreValue > 0 Then
            scoreBoard(scoreIndex, 0) = scoreValue
        Else
            ' To stroke a score we store 1 in second dimension
            stroke(scoreIndex)
        End If

        If scoreIndex <= 6 Then
            bonusPoints += scoreValue
            leftForBonusCalc -= 1
        End If


    End Sub

    ' Stroke score combination
    Public Sub stroke(ByVal strokeIndex As Integer)
        scoreBoard(strokeIndex, 1) = 1
    End Sub

    ' This checks if score have been sumited before
    Public Function isScoreAllowed()
        Dim isAllowed As Boolean = True
        Return isAllowed
    End Function

    Public ReadOnly Property playersBonusPoints() As Integer
        Get
            ' Gets the property value.
            Return bonusPoints
        End Get
    End Property

    Public ReadOnly Property playersScore() As Integer(,)
        Get
            ' Gets the property value.
            Return scoreBoard
        End Get
    End Property

    Public ReadOnly Property getName() As String
        Get
            ' Gets the property value.
            Return name
        End Get
    End Property

    Public Property pointsLeftForBonus() As Integer
        Get
            Return leftForBonusCalc
        End Get
        Set(ByVal value As Integer)
            leftForBonusCalc = value
        End Set
    End Property
End Class
