Public Class Dice

    ' Is this dice hold or not
    Private isHold As Boolean
    ' Value of dice
    Private value As Integer
    ' PictureBox with dice image
    Private graphic As PictureBox

    ' Constructor for dice class
    Public Sub New(ByVal graphic As PictureBox)
        Me.graphic = graphic
        isHold = False
        ' Roll when dice object is constructed
        Roll()
    End Sub

    ' Function for reading value of dice
    Public ReadOnly Property DiceValue() As Integer
        Get
            ' Gets the property value.
            Return value
        End Get
    End Property

    ' Function for changing image when mouse enter or leave dice
    Public Sub ChangeColor(ByVal change As Boolean)
        If change = True Then
            'All dice images in resources are named dice_01, dice_02, dice_03...
            graphic.Image = My.Resources.ResourceManager.GetObject("dice_0" & value)
        Else
            'All darker dice images in resources are named dice_01_hover, dice_02_hover, dice_03_hover...
            graphic.Image = My.Resources.ResourceManager.GetObject("dice_0" & value & "_hover")
        End If
    End Sub

    ' Function for rolling dices
    Public Sub Roll()
        If isHold = False Then
            ' Gives random value to dice
            value = CInt(Int((5 * Rnd()) + 1))
            ' Graphic is updated when new value is made. TODO: Add statement if value == value than do not update graphic. 
            UpdateGraphic()
        End If
    End Sub

    ' Function for updating graphic to correct image after roll
    Public Sub UpdateGraphic()
        'All dice images in resources are named dice_01, dice_02, dice_03...
        graphic.Image = My.Resources.ResourceManager.GetObject("dice_0" & value)
    End Sub

    ' Function to change between hold dice image and normal image
    Public Sub ToggleHold()
        If isHold = True Then
            isHold = False
            'All dice images in resources are named dice_01, dice_02, dice_03...
            graphic.Image = My.Resources.ResourceManager.GetObject("dice_0" & value)
        Else
            isHold = True
            'All darker dice images in resources are named dice_01_hover, dice_02_hover, dice_03_hover...
            graphic.Image = My.Resources.ResourceManager.GetObject("dice_0" & value & "_hover")
        End If
    End Sub

    ' Function to change if dice is hold or not
    Public Property DiceHold() As Boolean
        Get
            ' Gets the property value.
            Return isHold
        End Get
        Set(ByVal Value As Boolean)
            ' Sets the property value.
            isHold = Value
        End Set
    End Property
End Class
