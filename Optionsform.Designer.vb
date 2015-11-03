<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Optionsform
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
        Me.StartGameBtn = New System.Windows.Forms.Button()
        Me.PlayerText1 = New System.Windows.Forms.TextBox()
        Me.PlayerText2 = New System.Windows.Forms.TextBox()
        Me.PlayerText3 = New System.Windows.Forms.TextBox()
        Me.PlayerText4 = New System.Windows.Forms.TextBox()
        Me.PlayerNumb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlayerLabel1 = New System.Windows.Forms.Label()
        Me.PlayerLabel2 = New System.Windows.Forms.Label()
        Me.PlayerLabel3 = New System.Windows.Forms.Label()
        Me.PlayerLabel4 = New System.Windows.Forms.Label()
        Me.Forced = New System.Windows.Forms.CheckBox()
        Me.Maxi = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'StartGameBtn
        '
        Me.StartGameBtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.StartGameBtn.Location = New System.Drawing.Point(125, 226)
        Me.StartGameBtn.Name = "StartGameBtn"
        Me.StartGameBtn.Size = New System.Drawing.Size(75, 23)
        Me.StartGameBtn.TabIndex = 0
        Me.StartGameBtn.Text = "Start game"
        Me.StartGameBtn.UseVisualStyleBackColor = True
        '
        'PlayerText1
        '
        Me.PlayerText1.Location = New System.Drawing.Point(75, 69)
        Me.PlayerText1.Name = "PlayerText1"
        Me.PlayerText1.Size = New System.Drawing.Size(125, 20)
        Me.PlayerText1.TabIndex = 1
        Me.PlayerText1.Tag = ""
        Me.PlayerText1.Text = "Player1"
        '
        'PlayerText2
        '
        Me.PlayerText2.Location = New System.Drawing.Point(75, 95)
        Me.PlayerText2.Name = "PlayerText2"
        Me.PlayerText2.Size = New System.Drawing.Size(125, 20)
        Me.PlayerText2.TabIndex = 2
        Me.PlayerText2.Tag = ""
        Me.PlayerText2.Text = "Player2"
        '
        'PlayerText3
        '
        Me.PlayerText3.Location = New System.Drawing.Point(75, 121)
        Me.PlayerText3.Name = "PlayerText3"
        Me.PlayerText3.Size = New System.Drawing.Size(125, 20)
        Me.PlayerText3.TabIndex = 3
        Me.PlayerText3.Tag = ""
        Me.PlayerText3.Text = "Player3"
        '
        'PlayerText4
        '
        Me.PlayerText4.Location = New System.Drawing.Point(75, 147)
        Me.PlayerText4.Name = "PlayerText4"
        Me.PlayerText4.Size = New System.Drawing.Size(125, 20)
        Me.PlayerText4.TabIndex = 4
        Me.PlayerText4.Tag = ""
        Me.PlayerText4.Text = "Player4"
        '
        'PlayerNumb
        '
        Me.PlayerNumb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PlayerNumb.FormattingEnabled = True
        Me.PlayerNumb.Items.AddRange(New Object() {"1 (vs PC)", "2", "3", "4"})
        Me.PlayerNumb.Location = New System.Drawing.Point(125, 26)
        Me.PlayerNumb.Name = "PlayerNumb"
        Me.PlayerNumb.Size = New System.Drawing.Size(75, 21)
        Me.PlayerNumb.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Number of players:"
        '
        'PlayerLabel1
        '
        Me.PlayerLabel1.AutoSize = True
        Me.PlayerLabel1.Location = New System.Drawing.Point(34, 72)
        Me.PlayerLabel1.Name = "PlayerLabel1"
        Me.PlayerLabel1.Size = New System.Drawing.Size(16, 13)
        Me.PlayerLabel1.TabIndex = 7
        Me.PlayerLabel1.Tag = "1"
        Me.PlayerLabel1.Text = "1."
        '
        'PlayerLabel2
        '
        Me.PlayerLabel2.AutoSize = True
        Me.PlayerLabel2.Location = New System.Drawing.Point(34, 98)
        Me.PlayerLabel2.Name = "PlayerLabel2"
        Me.PlayerLabel2.Size = New System.Drawing.Size(16, 13)
        Me.PlayerLabel2.TabIndex = 8
        Me.PlayerLabel2.Tag = "2"
        Me.PlayerLabel2.Text = "2."
        '
        'PlayerLabel3
        '
        Me.PlayerLabel3.AutoSize = True
        Me.PlayerLabel3.Location = New System.Drawing.Point(34, 124)
        Me.PlayerLabel3.Name = "PlayerLabel3"
        Me.PlayerLabel3.Size = New System.Drawing.Size(16, 13)
        Me.PlayerLabel3.TabIndex = 9
        Me.PlayerLabel3.Tag = "3"
        Me.PlayerLabel3.Text = "3."
        '
        'PlayerLabel4
        '
        Me.PlayerLabel4.AutoSize = True
        Me.PlayerLabel4.Location = New System.Drawing.Point(34, 150)
        Me.PlayerLabel4.Name = "PlayerLabel4"
        Me.PlayerLabel4.Size = New System.Drawing.Size(16, 13)
        Me.PlayerLabel4.TabIndex = 10
        Me.PlayerLabel4.Tag = "4"
        Me.PlayerLabel4.Text = "4."
        '
        'Forced
        '
        Me.Forced.AutoSize = True
        Me.Forced.Location = New System.Drawing.Point(60, 192)
        Me.Forced.Name = "Forced"
        Me.Forced.Size = New System.Drawing.Size(59, 17)
        Me.Forced.TabIndex = 0
        Me.Forced.Text = "Forced"
        Me.Forced.UseVisualStyleBackColor = True
        '
        'Maxi
        '
        Me.Maxi.AutoSize = True
        Me.Maxi.Location = New System.Drawing.Point(125, 192)
        Me.Maxi.Name = "Maxi"
        Me.Maxi.Size = New System.Drawing.Size(77, 17)
        Me.Maxi.TabIndex = 1
        Me.Maxi.Text = "Maxi Yatzy"
        Me.Maxi.UseVisualStyleBackColor = True
        '
        'Optionsform
        '
        Me.AcceptButton = Me.StartGameBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 271)
        Me.Controls.Add(Me.Forced)
        Me.Controls.Add(Me.Maxi)
        Me.Controls.Add(Me.PlayerLabel4)
        Me.Controls.Add(Me.PlayerLabel3)
        Me.Controls.Add(Me.PlayerLabel2)
        Me.Controls.Add(Me.PlayerLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PlayerNumb)
        Me.Controls.Add(Me.PlayerText4)
        Me.Controls.Add(Me.PlayerText3)
        Me.Controls.Add(Me.PlayerText2)
        Me.Controls.Add(Me.PlayerText1)
        Me.Controls.Add(Me.StartGameBtn)
        Me.Name = "Optionsform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartGameBtn As Button
    Friend WithEvents PlayerText1 As TextBox
    Friend WithEvents PlayerText2 As TextBox
    Friend WithEvents PlayerText3 As TextBox
    Friend WithEvents PlayerText4 As TextBox
    Friend WithEvents PlayerNumb As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PlayerLabel1 As Label
    Friend WithEvents PlayerLabel2 As Label
    Friend WithEvents PlayerLabel3 As Label
    Friend WithEvents PlayerLabel4 As Label
    Friend WithEvents Forced As CheckBox
    Friend WithEvents Maxi As CheckBox
End Class
