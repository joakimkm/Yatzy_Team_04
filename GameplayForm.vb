Public Class GameplayForm

    Private gameObj As Gameplay
    Private dicePictureBoxes(5) As PictureBox

    Private Sub GameplayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create new object of gameplay
        gameObj = New Gameplay()
        ' Assign picturebox objects to array
        dicePictureBoxes = {Dice1, Dice2, Dice3, Dice4, Dice5}
    End Sub

    ' Event when Roll is clicked
    Private Sub RollBtn_Click(sender As Object, e As EventArgs) Handles RollBtn.Click
        'Roll dices
        gameObj.Roll()
        'Show new dices in form
        ReDrawDices()
    End Sub

    ' Event for changing dice color when mouse enter.
    Private Sub Dice1_MouseEnter(sender As Object, e As EventArgs) Handles Dice1.MouseEnter, Dice2.MouseEnter, Dice3.MouseEnter, Dice4.MouseEnter, Dice5.MouseEnter
        'Set cursor to hand
        Me.Cursor = Cursors.Hand
        'Cast sender object to PictureBox
        Dim thisPictureBox As PictureBox = CType(sender, PictureBox)
        'Get tagName from PictureBox. Tagname equals to dice value.
        Dim tagName As String = thisPictureBox.Tag
        'Find and set new image in PictureBox. If current dice is 4 than Resourcemanager use dice_04_hover as argument.
        thisPictureBox.Image = My.Resources.ResourceManager.GetObject("dice_0" & tagName & "_hover")
    End Sub

    ' Event for changing dice back to normal color when mouse leave
    Private Sub Dice1_MouseLeave(sender As Object, e As EventArgs) Handles Dice1.MouseLeave, Dice2.MouseLeave, Dice3.MouseLeave, Dice4.MouseLeave, Dice5.MouseLeave
        'Set cursor back to normal
        Me.Cursor = Cursors.Default
        'Cast sender object to PictureBox
        Dim thisPictureBox As PictureBox = CType(sender, PictureBox)
        'Get tagName from PictureBox. Tagname equals to dice value.
        Dim tagName As String = thisPictureBox.Tag
        'Find default dice image and initialize PictureBox with that
        thisPictureBox.Image = My.Resources.ResourceManager.GetObject("dice_0" & tagName)
    End Sub

    Public Sub ReDrawDices()
        'Loop through pictureboxes and assign which dice to show
        For i = 0 To 4
            Dim value As Integer = gameObj.Dices(i)
            Dim dicePicturebox As PictureBox = dicePictureBoxes(i)
            dicePictureBoxes(i).Image = My.Resources.ResourceManager.GetObject("dice_0" & value)
            dicePictureBoxes(i).Tag = value
        Next i
    End Sub

End Class