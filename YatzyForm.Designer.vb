<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class YatzyForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YatzyForm))
        Me.NewGame = New System.Windows.Forms.Button()
        Me.Dice6 = New System.Windows.Forms.PictureBox()
        Me.RollBtn = New System.Windows.Forms.Button()
        Me.Dice5 = New System.Windows.Forms.PictureBox()
        Me.Dice4 = New System.Windows.Forms.PictureBox()
        Me.Dice3 = New System.Windows.Forms.PictureBox()
        Me.Dice2 = New System.Windows.Forms.PictureBox()
        Me.Dice1 = New System.Windows.Forms.PictureBox()
        Me.DiceBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rollsLeft = New System.Windows.Forms.Label()
        Me.submitBtn = New System.Windows.Forms.Button()
        Me.HighScoreBtn = New System.Windows.Forms.Button()
        CType(Me.Dice6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DiceBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NewGame
        '
        Me.NewGame.Location = New System.Drawing.Point(93, 12)
        Me.NewGame.Name = "NewGame"
        Me.NewGame.Size = New System.Drawing.Size(75, 23)
        Me.NewGame.TabIndex = 2
        Me.NewGame.Text = "New game"
        Me.NewGame.UseVisualStyleBackColor = True
        '
        'Dice6
        '
        Me.Dice6.Image = Global.Yatzy.My.Resources.Resources.dice_01
        Me.Dice6.InitialImage = CType(resources.GetObject("Dice6.InitialImage"), System.Drawing.Image)
        Me.Dice6.Location = New System.Drawing.Point(18, 299)
        Me.Dice6.Name = "Dice6"
        Me.Dice6.Size = New System.Drawing.Size(50, 50)
        Me.Dice6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice6.TabIndex = 6
        Me.Dice6.TabStop = False
        Me.Dice6.Tag = "6"
        '
        'RollBtn
        '
        Me.RollBtn.Location = New System.Drawing.Point(6, 395)
        Me.RollBtn.Name = "RollBtn"
        Me.RollBtn.Size = New System.Drawing.Size(75, 23)
        Me.RollBtn.TabIndex = 5
        Me.RollBtn.Text = "Roll"
        Me.RollBtn.UseVisualStyleBackColor = True
        '
        'Dice5
        '
        Me.Dice5.Image = Global.Yatzy.My.Resources.Resources.dice_01
        Me.Dice5.InitialImage = CType(resources.GetObject("Dice5.InitialImage"), System.Drawing.Image)
        Me.Dice5.Location = New System.Drawing.Point(18, 243)
        Me.Dice5.Name = "Dice5"
        Me.Dice5.Size = New System.Drawing.Size(50, 50)
        Me.Dice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice5.TabIndex = 4
        Me.Dice5.TabStop = False
        Me.Dice5.Tag = "5"
        '
        'Dice4
        '
        Me.Dice4.Image = Global.Yatzy.My.Resources.Resources.dice_01
        Me.Dice4.InitialImage = CType(resources.GetObject("Dice4.InitialImage"), System.Drawing.Image)
        Me.Dice4.Location = New System.Drawing.Point(18, 187)
        Me.Dice4.Name = "Dice4"
        Me.Dice4.Size = New System.Drawing.Size(50, 50)
        Me.Dice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice4.TabIndex = 3
        Me.Dice4.TabStop = False
        Me.Dice4.Tag = "4"
        '
        'Dice3
        '
        Me.Dice3.Image = Global.Yatzy.My.Resources.Resources.dice_01
        Me.Dice3.InitialImage = CType(resources.GetObject("Dice3.InitialImage"), System.Drawing.Image)
        Me.Dice3.Location = New System.Drawing.Point(18, 131)
        Me.Dice3.Name = "Dice3"
        Me.Dice3.Size = New System.Drawing.Size(50, 50)
        Me.Dice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice3.TabIndex = 2
        Me.Dice3.TabStop = False
        Me.Dice3.Tag = "3"
        '
        'Dice2
        '
        Me.Dice2.Image = Global.Yatzy.My.Resources.Resources.dice_01
        Me.Dice2.InitialImage = CType(resources.GetObject("Dice2.InitialImage"), System.Drawing.Image)
        Me.Dice2.Location = New System.Drawing.Point(18, 75)
        Me.Dice2.Name = "Dice2"
        Me.Dice2.Size = New System.Drawing.Size(50, 50)
        Me.Dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice2.TabIndex = 1
        Me.Dice2.TabStop = False
        Me.Dice2.Tag = "2"
        '
        'Dice1
        '
        Me.Dice1.AccessibleName = ""
        Me.Dice1.Image = Global.Yatzy.My.Resources.Resources.dice_01
        Me.Dice1.InitialImage = CType(resources.GetObject("Dice1.InitialImage"), System.Drawing.Image)
        Me.Dice1.Location = New System.Drawing.Point(18, 19)
        Me.Dice1.Name = "Dice1"
        Me.Dice1.Size = New System.Drawing.Size(50, 50)
        Me.Dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice1.TabIndex = 0
        Me.Dice1.TabStop = False
        Me.Dice1.Tag = "1"
        '
        'DiceBox
        '
        Me.DiceBox.Controls.Add(Me.Label1)
        Me.DiceBox.Controls.Add(Me.rollsLeft)
        Me.DiceBox.Controls.Add(Me.Dice6)
        Me.DiceBox.Controls.Add(Me.RollBtn)
        Me.DiceBox.Controls.Add(Me.Dice5)
        Me.DiceBox.Controls.Add(Me.Dice4)
        Me.DiceBox.Controls.Add(Me.Dice3)
        Me.DiceBox.Controls.Add(Me.Dice2)
        Me.DiceBox.Controls.Add(Me.Dice1)
        Me.DiceBox.Location = New System.Drawing.Point(408, 60)
        Me.DiceBox.Name = "DiceBox"
        Me.DiceBox.Size = New System.Drawing.Size(90, 433)
        Me.DiceBox.TabIndex = 5
        Me.DiceBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "roll(s) left!"
        '
        'rollsLeft
        '
        Me.rollsLeft.AutoSize = True
        Me.rollsLeft.Location = New System.Drawing.Point(15, 376)
        Me.rollsLeft.Name = "rollsLeft"
        Me.rollsLeft.Size = New System.Drawing.Size(13, 13)
        Me.rollsLeft.TabIndex = 7
        Me.rollsLeft.Text = "3"
        '
        'submitBtn
        '
        Me.submitBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.submitBtn.Enabled = False
        Me.submitBtn.Location = New System.Drawing.Point(414, 511)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(75, 23)
        Me.submitBtn.TabIndex = 6
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.UseVisualStyleBackColor = False
        Me.submitBtn.Visible = False
        '
        'HighScoreBtn
        '
        Me.HighScoreBtn.Location = New System.Drawing.Point(193, 12)
        Me.HighScoreBtn.Name = "HighScoreBtn"
        Me.HighScoreBtn.Size = New System.Drawing.Size(75, 23)
        Me.HighScoreBtn.TabIndex = 7
        Me.HighScoreBtn.Text = "Highscore"
        Me.HighScoreBtn.UseVisualStyleBackColor = True
        '
        'YatzyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 611)
        Me.Controls.Add(Me.HighScoreBtn)
        Me.Controls.Add(Me.submitBtn)
        Me.Controls.Add(Me.DiceBox)
        Me.Controls.Add(Me.NewGame)
        Me.Name = "YatzyForm"
        Me.Text = "Yatzy"
        CType(Me.Dice6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DiceBox.ResumeLayout(False)
        Me.DiceBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NewGame As Button
    Friend WithEvents Dice6 As PictureBox
    Friend WithEvents RollBtn As Button
    Friend WithEvents Dice5 As PictureBox
    Friend WithEvents Dice4 As PictureBox
    Friend WithEvents Dice3 As PictureBox
    Friend WithEvents Dice2 As PictureBox
    Friend WithEvents Dice1 As PictureBox
    Friend WithEvents DiceBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rollsLeft As Label
    Friend WithEvents submitBtn As Button
    Friend WithEvents HighScoreBtn As Button
End Class
