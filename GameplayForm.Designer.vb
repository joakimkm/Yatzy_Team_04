<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameplayForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameplayForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RollBtn = New System.Windows.Forms.Button()
        Me.Dice5 = New System.Windows.Forms.PictureBox()
        Me.Dice4 = New System.Windows.Forms.PictureBox()
        Me.Dice3 = New System.Windows.Forms.PictureBox()
        Me.Dice2 = New System.Windows.Forms.PictureBox()
        Me.Dice1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dice5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dice1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RollBtn)
        Me.GroupBox1.Controls.Add(Me.Dice5)
        Me.GroupBox1.Controls.Add(Me.Dice4)
        Me.GroupBox1.Controls.Add(Me.Dice3)
        Me.GroupBox1.Controls.Add(Me.Dice2)
        Me.GroupBox1.Controls.Add(Me.Dice1)
        Me.GroupBox1.Location = New System.Drawing.Point(345, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 248)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dices"
        '
        'RollBtn
        '
        Me.RollBtn.Location = New System.Drawing.Point(28, 219)
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
        Me.Dice5.Location = New System.Drawing.Point(6, 150)
        Me.Dice5.Name = "Dice5"
        Me.Dice5.Size = New System.Drawing.Size(50, 50)
        Me.Dice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice5.TabIndex = 4
        Me.Dice5.TabStop = False
        '
        'Dice4
        '
        Me.Dice4.Image = Global.Yatzy.My.Resources.Resources.dice_01
        Me.Dice4.InitialImage = CType(resources.GetObject("Dice4.InitialImage"), System.Drawing.Image)
        Me.Dice4.Location = New System.Drawing.Point(72, 84)
        Me.Dice4.Name = "Dice4"
        Me.Dice4.Size = New System.Drawing.Size(50, 50)
        Me.Dice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice4.TabIndex = 3
        Me.Dice4.TabStop = False
        '
        'Dice3
        '
        Me.Dice3.Image = Global.Yatzy.My.Resources.Resources.dice_01
        Me.Dice3.InitialImage = CType(resources.GetObject("Dice3.InitialImage"), System.Drawing.Image)
        Me.Dice3.Location = New System.Drawing.Point(6, 84)
        Me.Dice3.Name = "Dice3"
        Me.Dice3.Size = New System.Drawing.Size(50, 50)
        Me.Dice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice3.TabIndex = 2
        Me.Dice3.TabStop = False
        '
        'Dice2
        '
        Me.Dice2.Image = Global.Yatzy.My.Resources.Resources.dice_01
        Me.Dice2.InitialImage = CType(resources.GetObject("Dice2.InitialImage"), System.Drawing.Image)
        Me.Dice2.Location = New System.Drawing.Point(72, 19)
        Me.Dice2.Name = "Dice2"
        Me.Dice2.Size = New System.Drawing.Size(50, 50)
        Me.Dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice2.TabIndex = 1
        Me.Dice2.TabStop = False
        '
        'Dice1
        '
        Me.Dice1.AccessibleName = ""
        Me.Dice1.Image = Global.Yatzy.My.Resources.Resources.dice_01
        Me.Dice1.InitialImage = CType(resources.GetObject("Dice1.InitialImage"), System.Drawing.Image)
        Me.Dice1.Location = New System.Drawing.Point(6, 19)
        Me.Dice1.Name = "Dice1"
        Me.Dice1.Size = New System.Drawing.Size(50, 50)
        Me.Dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dice1.TabIndex = 0
        Me.Dice1.TabStop = False
        '
        'GameplayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 291)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GameplayForm"
        Me.Text = "Active Yatzy game"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Dice5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dice1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Dice1 As PictureBox
    Friend WithEvents RollBtn As Button
    Friend WithEvents Dice5 As PictureBox
    Friend WithEvents Dice4 As PictureBox
    Friend WithEvents Dice3 As PictureBox
    Friend WithEvents Dice2 As PictureBox
End Class
