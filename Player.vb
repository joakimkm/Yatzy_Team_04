'Each player has its own object from player class
Public Class Player
    ' Players username
    Private name As String
    ' Is player computer or not
    Private isComputer As Boolean

    ' Constructor for player class
    Public Sub New(ByVal name As String, ByVal isComputer As Boolean)
        Me.name = name
        Me.isComputer = isComputer
    End Sub
End Class
