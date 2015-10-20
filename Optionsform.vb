Public Class Optionsform
    '  Array with Textboxes
    Dim textBoxes As TextBox()
    ' Array with Labels
    Dim labels As Label()
    ' Array with players name
    Dim players As String()

    ' This function are called when Optionsform load
    Private Sub Optionsform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Init arrays with controls from form. 
        textBoxes = {PlayerText1, PlayerText2, PlayerText3, PlayerText4}
        labels = {PlayerLabel1, PlayerLabel2, PlayerLabel3, PlayerLabel4}
        ' Dropdown menu PlayerNumb should use first position as default
        PlayerNumb.SelectedIndex = 0
        ' Update with right amount of textboxes.
        UpdatePlayers()
    End Sub

    ' This function are called when user change value on dropdown menu
    Private Sub PlayerNumb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PlayerNumb.SelectedIndexChanged
        UpdatePlayers()
    End Sub

    'Function for updating with right amount of textboxes.
    Public Sub UpdatePlayers()
        Dim value As Integer = 0
        ' Index value of selected item.
        value = PlayerNumb.SelectedIndex
        ' Loop through all textboes.
        For i = 0 To textBoxes.Length - 1
            ' Hide textbox if index number in array are larger than index value in PlayerNumb dropdown
            If i > value Then
                textBoxes(i).Visible = False
                labels(i).Visible = False
                'Show textbox if index number in array is not smaller than index value in PlayerNumb dropdown
            Else
                textBoxes(i).Visible = True
                labels(i).Visible = True
            End If
        Next i
    End Sub

    'This function are called when StartGameBtn are clicked
    Private Sub StartGameBtn_Click(sender As Object, e As EventArgs) Handles StartGameBtn.Click
        'Gameplay class need easy access to all players name so we create and array with them.
        Dim playerCount As Integer = PlayerNumb.SelectedIndex + 1

        ReDim players(playerCount - 1)

        For i = 0 To playerCount - 1
            players(i) = textBoxes(i).Text
        Next i


    End Sub
    'This function is used from Gameplay class to access array of players.
    Public ReadOnly Property PlayersValue As String()
        Get
            Return Me.players
        End Get
    End Property

End Class