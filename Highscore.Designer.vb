<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Highscore
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
        Me.highScoreList = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.resetHighScore = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.listMaxiForced3 = New System.Windows.Forms.ListBox()
        Me.listMaxiForced2 = New System.Windows.Forms.ListBox()
        Me.listMaxiForced1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.listMaxiFree3 = New System.Windows.Forms.ListBox()
        Me.listMaxiFree2 = New System.Windows.Forms.ListBox()
        Me.listMaxiFree1 = New System.Windows.Forms.ListBox()
        Me.listYatzyFree2 = New System.Windows.Forms.ListBox()
        Me.listYatzyFree3 = New System.Windows.Forms.ListBox()
        Me.listYatzyFree1 = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.listYatzyForced2 = New System.Windows.Forms.ListBox()
        Me.listYatzyForced3 = New System.Windows.Forms.ListBox()
        Me.listYatzyForced1 = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.highScoreList.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'highScoreList
        '
        Me.highScoreList.Controls.Add(Me.TabPage1)
        Me.highScoreList.Controls.Add(Me.TabPage2)
        Me.highScoreList.Location = New System.Drawing.Point(12, 21)
        Me.highScoreList.Name = "highScoreList"
        Me.highScoreList.SelectedIndex = 0
        Me.highScoreList.Size = New System.Drawing.Size(476, 233)
        Me.highScoreList.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(468, 207)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Yatzy"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'resetHighScore
        '
        Me.resetHighScore.Location = New System.Drawing.Point(295, 260)
        Me.resetHighScore.Name = "resetHighScore"
        Me.resetHighScore.Size = New System.Drawing.Size(79, 23)
        Me.resetHighScore.TabIndex = 1
        Me.resetHighScore.Text = "Reset scores"
        Me.resetHighScore.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(468, 207)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Maxi yatzy"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(69, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.listMaxiForced2)
        Me.GroupBox2.Controls.Add(Me.listMaxiForced3)
        Me.GroupBox2.Controls.Add(Me.listMaxiForced1)
        Me.GroupBox2.Location = New System.Drawing.Point(242, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(206, 195)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Forced"
        '
        'listMaxiForced3
        '
        Me.listMaxiForced3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listMaxiForced3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.listMaxiForced3.FormattingEnabled = True
        Me.listMaxiForced3.ItemHeight = 16
        Me.listMaxiForced3.Location = New System.Drawing.Point(145, 23)
        Me.listMaxiForced3.Name = "listMaxiForced3"
        Me.listMaxiForced3.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listMaxiForced3.Size = New System.Drawing.Size(55, 160)
        Me.listMaxiForced3.TabIndex = 19
        '
        'listMaxiForced2
        '
        Me.listMaxiForced2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listMaxiForced2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.listMaxiForced2.FormattingEnabled = True
        Me.listMaxiForced2.ItemHeight = 16
        Me.listMaxiForced2.Location = New System.Drawing.Point(92, 23)
        Me.listMaxiForced2.Name = "listMaxiForced2"
        Me.listMaxiForced2.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listMaxiForced2.Size = New System.Drawing.Size(30, 160)
        Me.listMaxiForced2.TabIndex = 18
        '
        'listMaxiForced1
        '
        Me.listMaxiForced1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listMaxiForced1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.listMaxiForced1.FormattingEnabled = True
        Me.listMaxiForced1.ItemHeight = 16
        Me.listMaxiForced1.Location = New System.Drawing.Point(6, 23)
        Me.listMaxiForced1.Name = "listMaxiForced1"
        Me.listMaxiForced1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listMaxiForced1.Size = New System.Drawing.Size(80, 160)
        Me.listMaxiForced1.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.listMaxiFree2)
        Me.GroupBox1.Controls.Add(Me.listMaxiFree3)
        Me.GroupBox1.Controls.Add(Me.listMaxiFree1)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 195)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Free"
        '
        'listMaxiFree3
        '
        Me.listMaxiFree3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listMaxiFree3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.listMaxiFree3.FormattingEnabled = True
        Me.listMaxiFree3.ItemHeight = 16
        Me.listMaxiFree3.Location = New System.Drawing.Point(145, 23)
        Me.listMaxiFree3.Name = "listMaxiFree3"
        Me.listMaxiFree3.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listMaxiFree3.Size = New System.Drawing.Size(55, 160)
        Me.listMaxiFree3.TabIndex = 19
        '
        'listMaxiFree2
        '
        Me.listMaxiFree2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listMaxiFree2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.listMaxiFree2.FormattingEnabled = True
        Me.listMaxiFree2.ItemHeight = 16
        Me.listMaxiFree2.Location = New System.Drawing.Point(92, 23)
        Me.listMaxiFree2.Name = "listMaxiFree2"
        Me.listMaxiFree2.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listMaxiFree2.Size = New System.Drawing.Size(30, 160)
        Me.listMaxiFree2.TabIndex = 18
        '
        'listMaxiFree1
        '
        Me.listMaxiFree1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listMaxiFree1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.listMaxiFree1.FormattingEnabled = True
        Me.listMaxiFree1.ItemHeight = 16
        Me.listMaxiFree1.Location = New System.Drawing.Point(6, 23)
        Me.listMaxiFree1.Name = "listMaxiFree1"
        Me.listMaxiFree1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listMaxiFree1.Size = New System.Drawing.Size(80, 160)
        Me.listMaxiFree1.TabIndex = 17
        '
        'listYatzyFree2
        '
        Me.listYatzyFree2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listYatzyFree2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.listYatzyFree2.FormattingEnabled = True
        Me.listYatzyFree2.ItemHeight = 16
        Me.listYatzyFree2.Location = New System.Drawing.Point(92, 23)
        Me.listYatzyFree2.Name = "listYatzyFree2"
        Me.listYatzyFree2.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listYatzyFree2.Size = New System.Drawing.Size(30, 160)
        Me.listYatzyFree2.TabIndex = 18
        '
        'listYatzyFree3
        '
        Me.listYatzyFree3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listYatzyFree3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.listYatzyFree3.FormattingEnabled = True
        Me.listYatzyFree3.ItemHeight = 16
        Me.listYatzyFree3.Location = New System.Drawing.Point(145, 23)
        Me.listYatzyFree3.Name = "listYatzyFree3"
        Me.listYatzyFree3.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listYatzyFree3.Size = New System.Drawing.Size(55, 160)
        Me.listYatzyFree3.TabIndex = 19
        '
        'listYatzyFree1
        '
        Me.listYatzyFree1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listYatzyFree1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.listYatzyFree1.FormattingEnabled = True
        Me.listYatzyFree1.ItemHeight = 16
        Me.listYatzyFree1.Location = New System.Drawing.Point(6, 23)
        Me.listYatzyFree1.Name = "listYatzyFree1"
        Me.listYatzyFree1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listYatzyFree1.Size = New System.Drawing.Size(80, 160)
        Me.listYatzyFree1.TabIndex = 17
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.listYatzyFree2)
        Me.GroupBox3.Controls.Add(Me.listYatzyFree3)
        Me.GroupBox3.Controls.Add(Me.listYatzyFree1)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(206, 195)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Free"
        '
        'listYatzyForced2
        '
        Me.listYatzyForced2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listYatzyForced2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.listYatzyForced2.FormattingEnabled = True
        Me.listYatzyForced2.ItemHeight = 16
        Me.listYatzyForced2.Location = New System.Drawing.Point(92, 23)
        Me.listYatzyForced2.Name = "listYatzyForced2"
        Me.listYatzyForced2.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listYatzyForced2.Size = New System.Drawing.Size(30, 160)
        Me.listYatzyForced2.TabIndex = 18
        '
        'listYatzyForced3
        '
        Me.listYatzyForced3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listYatzyForced3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.listYatzyForced3.FormattingEnabled = True
        Me.listYatzyForced3.ItemHeight = 16
        Me.listYatzyForced3.Location = New System.Drawing.Point(145, 23)
        Me.listYatzyForced3.Name = "listYatzyForced3"
        Me.listYatzyForced3.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listYatzyForced3.Size = New System.Drawing.Size(55, 160)
        Me.listYatzyForced3.TabIndex = 19
        '
        'listYatzyForced1
        '
        Me.listYatzyForced1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listYatzyForced1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.listYatzyForced1.FormattingEnabled = True
        Me.listYatzyForced1.ItemHeight = 16
        Me.listYatzyForced1.Location = New System.Drawing.Point(6, 23)
        Me.listYatzyForced1.Name = "listYatzyForced1"
        Me.listYatzyForced1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listYatzyForced1.Size = New System.Drawing.Size(80, 160)
        Me.listYatzyForced1.TabIndex = 17
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.listYatzyForced2)
        Me.GroupBox4.Controls.Add(Me.listYatzyForced3)
        Me.GroupBox4.Controls.Add(Me.listYatzyForced1)
        Me.GroupBox4.Location = New System.Drawing.Point(244, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(206, 195)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Forced"
        '
        'Highscore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 297)
        Me.Controls.Add(Me.resetHighScore)
        Me.Controls.Add(Me.highScoreList)
        Me.Name = "Highscore"
        Me.Text = "Highscore"
        Me.highScoreList.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents highScoreList As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents resetHighScore As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents listYatzyFree2 As ListBox
    Friend WithEvents listYatzyFree3 As ListBox
    Friend WithEvents listYatzyFree1 As ListBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents listYatzyForced2 As ListBox
    Friend WithEvents listYatzyForced3 As ListBox
    Friend WithEvents listYatzyForced1 As ListBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents listMaxiForced2 As ListBox
    Friend WithEvents listMaxiForced3 As ListBox
    Friend WithEvents listMaxiForced1 As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents listMaxiFree2 As ListBox
    Friend WithEvents listMaxiFree3 As ListBox
    Friend WithEvents listMaxiFree1 As ListBox
    Friend WithEvents Label1 As Label
End Class
