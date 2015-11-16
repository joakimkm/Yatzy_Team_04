' YatzyForm controls GUI for the game
Public Class YatzyForm

    'Main object for gameplay
    Private gameObj As Gameplay
    'Object to scoreboard controller
    Private scoreControll As ScoreBoardControll

    Private Sub YatzyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set DiceBox hidden when YatzyForm loads
        DiceBox.Visible = False
        ' Load and set new form icon 
        Dim ico As Icon = My.Resources.ResourceManager.GetObject("favicon")
        Me.Icon = ico
    End Sub

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
        Else
            'If its not maxi we should remove dice 6
            Dice6.Dispose()
            'Init array with five Pictureboxes
            dicePicBoxes = {Dice1, Dice2, Dice3, Dice4, Dice5}

        End If
        'Scoreboard controls are made in seperate file and we need to call for objects.
        scoreControll = New ScoreBoardControll(isMaxi)

        If Not isForced Then
            'If not forced we adds ScoreBoardControll events to this class. See ScoreBoardControll class for more reading.
            AddHandler scoreControll.MouseEnterLabel, AddressOf MouseEnterLabel
            AddHandler scoreControll.MouseLeaveLabel, AddressOf MouseLeaveLabel
            AddHandler scoreControll.MouseClickLabel, AddressOf MouseClickLabel
        Else
            submitBtn.Visible = True
        End If

        'Add Scoreboard object to YatzyForm.
        Controls.Add(scoreControll)
        'Change position for scoreboard to x = 10 and y = 60
        scoreControll.Location = New Point(10, 60)
        'Make height of dicebox same as scoreboard height.
        DiceBox.Height = scoreControll.Height
        ' Create new object of gameplay
        gameObj = New Gameplay(dicePicBoxes, playersName, isForced, isMaxi, scoreControll)
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

        Dim rollsLeftInt As Integer = gameObj.rollsLeftValue
        'Update roll left text
        rollsLeft.Text = rollsLeftInt

        'Disable rollbtn if there are no rolls left
        If rollsLeftInt = 0 Then
            RollBtn.Enabled = False
        End If
        'If yatzy game is forced submitbtn should be enabled
        If gameObj.isGameForced Then
            submitBtn.Enabled = True
        End If

    End Sub

    ' Event for changing dice color when mouse enter.
    Private Sub Dice1_MouseEnter(sender As Object, e As EventArgs) Handles Dice1.MouseEnter, Dice2.MouseEnter, Dice3.MouseEnter, Dice4.MouseEnter, Dice5.MouseEnter, Dice6.MouseEnter

        If gameObj.isDicesActive Then
            'Set cursor to hand
            Cursor = Cursors.Hand
            ' Call function in gameObj with this dice as argument
            gameObj.ChangeDiceColor(sender, True)
        End If

    End Sub

    ' Event for changing dice back to normal color when mouse leave
    Private Sub Dice1_MouseLeave(sender As Object, e As EventArgs) Handles Dice1.MouseLeave, Dice2.MouseLeave, Dice3.MouseLeave, Dice4.MouseLeave, Dice5.MouseLeave, Dice6.MouseLeave

        If gameObj.isDicesActive Then
            'Set cursor back to default
            Cursor = Cursors.Default
            ' Call function in gameObj with this dice as argument
            gameObj.ChangeDiceColor(sender, False)
        End If

    End Sub
    ' Event when dices is clicked
    Private Sub Dice1_Click(sender As Object, e As EventArgs) Handles Dice1.Click, Dice2.Click, Dice3.Click, Dice4.Click, Dice5.Click, Dice6.Click

        If gameObj.isDicesActive Then
            ' Call function in gameObj with this dice as argument
            gameObj.ToggleDiceHold(sender)
        End If

    End Sub

    'Event for changing label color on scoreboard when mouse enter
    Private Sub MouseEnterLabel(sender As Object, e As EventArgs)
        If gameObj.isScoreboardActive Then
            Dim thisCellLabel As Label = CType(sender, Label)
            thisCellLabel.BackColor = Color.Coral
            Cursor = Cursors.Hand
        End If
    End Sub

    'Event for changing back label color on scoreboard when mouse leave
    Private Sub MouseLeaveLabel(sender As Object, e As EventArgs)
        If gameObj.isScoreboardActive Then
            Dim thisCellLabel As Label = CType(sender, Label)
            thisCellLabel.BackColor = Color.Transparent
            Cursor = Cursors.Default
        End If
    End Sub

    'Event when label in scoreboard is clicked
    Private Sub MouseClickLabel(sender As Object, e As EventArgs)

        If gameObj.isScoreboardActive Then
            MouseLeaveLabel(sender, e)
            Dim thisCellLabel As Label = CType(sender, Label)
            'Tagname is string and we need to convert to 32 bit integer
            Dim tagName As Integer = Convert.ToInt32(thisCellLabel.Tag)
            'Get position label is located in tablelayout
            Dim tablePos As TableLayoutPanelCellPosition = scoreControll.table.GetPositionFromControl(thisCellLabel)
            ' Returns true if score was valid
            If gameObj.checkScore(tagName, tablePos.Row) Then
                nextTurn()
            End If

            If gameObj.isGameFinishedValue Then
                rollsLeft.Text = 0
                RollBtn.Enabled = False
            End If

        End If

    End Sub

    'Set next turn
    Private Sub nextTurn()

        Dim rollsLeftInt As Integer = gameObj.rollsLeftValue
        RollBtn.Enabled = True
        rollsLeft.Text = rollsLeftInt

    End Sub

    'Event when submit button is clicked in forced yatzy
    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        gameObj.forcedChoose()
        Dim rollsLeftInt As Integer = gameObj.rollsLeftValue
        rollsLeft.Text = rollsLeftInt
        submitBtn.Enabled = False
    End Sub

    'Event for highscore button is clicked
    Private Sub HighScoreBtn_Click(sender As Object, e As EventArgs) Handles HighScoreBtn.Click
        Dim highScoreForm As New Highscore()
        highScoreForm.ShowDialog(Me)
        highScoreForm.Dispose()
    End Sub
End Class
