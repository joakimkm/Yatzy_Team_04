' YatzyForm controls GUI for the game
Public Class YatzyForm

    'This is where game adress to game object are stored
    Private gameObj As Gameplay

    'All necessary variables to start new game is passed as arguments to function
    Public Sub initGame(ByVal playersName As String(), ByVal isForced As Boolean, ByVal isMaxi As Boolean)

        ' Before we init a new game we need to clear all old controls
        Me.Controls.Clear()
        InitializeComponent()

        'For standard yatzy we need five PictureBoxes stored in array
        Dim dicePicBoxes(5) As PictureBox
        'If new game are maxi yatzi or normal
        If isMaxi = True Then
            'For maxi yatzy we need six PictureBoxes
            ReDim dicePicBoxes(6)
            'Init array with six Pictureboxes
            dicePicBoxes = {Dice1, Dice2, Dice3, Dice4, Dice5, Dice6}
            'Scoreboard controls are made in seperate file and we need to call for objects.
            Dim ScoreCotrollMaxi As New ScoreBoardControllMaxi()
            'Add Scoreboard object to YatzyForm.
            Me.Controls.Add(ScoreCotrollMaxi)
            'Change position for scoreboard to x = 10 and y = 60
            ScoreCotrollMaxi.Location = New Point(10, 60)
            'Make height of dicebox same as scoreboard height.
            DiceBox.Height = ScoreCotrollMaxi.Height

        Else
            'If its not maxi we should remove dice 6
            Dice6.Dispose()
            'Init array with five Pictureboxes
            dicePicBoxes = {Dice1, Dice2, Dice3, Dice4, Dice5}
            'Scoreboard controls are made in seperate file and we need to call for objects.
            Dim ScoreCotroll As New ScoreBoardControll()
            'Add Scoreboard object to YatzyForm.
            Controls.Add(ScoreCotroll)
            'Change position for scoreboard to x = 10 and y = 60
            ScoreCotroll.Location = New Point(10, 60)
            'Make height of dicebox same as scoreboard height.
            DiceBox.Height = ScoreCotroll.Height

        End If
        ' Create new object of gameplay
        gameObj = New Gameplay(dicePicBoxes, playersName, isForced, isMaxi)
        ' Make DiceBox visible.
        DiceBox.Visible = True
    End Sub

    'Click event for File > New Game
    Private Sub NewGame_Click(sender As Object, e As EventArgs) Handles NewGame.Click
        'Create new object of Optionsform
        Dim FormOptions As New Optionsform()

        ' Show testDialog as a modal dialog and determine if DialogResult = OK.
        If FormOptions.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            ' Read the contents of FormOptions TextBoxes.
            Dim playersName As String() = FormOptions.PlayersValue
            ' Read the contents of FormOptions forced textbox.
            Dim isForced As Boolean = FormOptions.Forced.Checked
            ' Read the contents of FormOptions Maxi checkbox.
            Dim isMaxi As Boolean = FormOptions.Maxi.Checked
            'Init new game with values from Optionsform
            initGame(playersName, isForced, isMaxi)
        End If
        ' We have to be sure that FormOptions are removed.
        FormOptions.Dispose()

    End Sub

    ' Event when Roll is clicked
    Private Sub RollBtn_Click(sender As Object, e As EventArgs) Handles RollBtn.Click
        'Roll dices
        gameObj.Roll()
    End Sub

    ' Event for changing dice color when mouse enter.
    Private Sub Dice1_MouseEnter(sender As Object, e As EventArgs) Handles Dice1.MouseEnter, Dice2.MouseEnter, Dice3.MouseEnter, Dice4.MouseEnter, Dice5.MouseEnter, Dice6.MouseEnter
        ' Change cursor to hand
        Cursor = Cursors.Hand
        ' Call function in gameObj with this dice as argument
        gameObj.DiceMouseEnter(sender)
    End Sub

    ' Event for changing dice back to normal color when mouse leave
    Private Sub Dice1_MouseLeave(sender As Object, e As EventArgs) Handles Dice1.MouseLeave, Dice2.MouseLeave, Dice3.MouseLeave, Dice4.MouseLeave, Dice5.MouseLeave, Dice6.MouseLeave
        'Set cursor back to normal
        Cursor = Cursors.Default
        ' Call function in gameObj with this dice as argument
        gameObj.DiceMouseLeave(sender)
    End Sub
    ' Event when dices is clicked
    Private Sub Dice1_Click(sender As Object, e As EventArgs) Handles Dice1.Click, Dice2.Click, Dice3.Click, Dice4.Click, Dice5.Click, Dice6.Click
        ' Call function in gameObj with this dice as argument
        gameObj.ToggleDiceHold(sender)
    End Sub

    Private Sub YatzyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set DiceBox hidden when YatzyForm loads
        DiceBox.Visible = False
    End Sub
End Class
