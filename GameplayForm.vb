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
        'Loop through pictureboxes and assign which dice to show
        For i = 0 To 4
            Dim value As Integer = gameObj.Dices(i)
            Dim dicePicturebox As PictureBox = dicePictureBoxes(i)
            dicePictureBoxes(i).Image = My.Resources.ResourceManager.GetObject("dice_0" & value)
        Next i
    End Sub

End Class