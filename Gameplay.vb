Public Class Gameplay
    ' Class that controls the whole game.
    Private diceArray(5) As Integer

    Public Sub New()
        ' Constructor
    End Sub

    Public ReadOnly Property Dices() As Integer()
        Get
            ' Gets the property value.
            Return diceArray
        End Get
    End Property

    Public Sub Roll()

        For i = 0 To 4
            diceArray(i) = CInt(Int((6 * Rnd()) + 1))
        Next i

    End Sub

End Class
