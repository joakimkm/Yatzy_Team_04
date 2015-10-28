Public Class ScoreBoardControll

    Dim isMaxi As Boolean
    Public table As TableLayoutPanel
    Dim labels As Label(,)

    Public Event MouseEnterLabel As EventHandler
    Public Event MouseLeaveLabel As EventHandler
    Public Event MouseClickLabel As EventHandler

    Public Sub New(ByVal isMaxi As Boolean)

        'To reduce flickr
        Me.DoubleBuffered = True

        InitializeComponent()

        Me.isMaxi = isMaxi

        If isMaxi Then
            TableLayoutPanel.Dispose()
            Dim maxiControl As ScoreBoardControllMaxi = New ScoreBoardControllMaxi()
            Dim maxiTableLayout As TableLayoutPanel = maxiControl.TableLayoutPanelMaxi
            Me.Controls.Add(maxiTableLayout)
            maxiTableLayout.Location = New Point(10, 10)
            table = maxiTableLayout
        Else
            table = TableLayoutPanel
        End If

        initLabels()
    End Sub

    Public Sub setPlayerNames(ByVal names As String())

        Dim arrayLength As Integer = names.Length - 1

        For i As Integer = 0 To arrayLength
            labels(i, 0).Text = names(i)
        Next

    End Sub

    Public Sub initLabels()
        ' - 2 because we dont want to target rows with scorenames
        Dim columns As Integer = table.ColumnCount - 2
        Dim rows As Integer = table.RowCount - 1

        ReDim labels(columns, rows)

        For c As Integer = 0 To columns
            For r As Integer = 0 To rows

                'Trick to stop Visual Studio from giving labels wrong position
                Dim cellContent = table.GetControlFromPosition(c + 1, r)
                If cellContent IsNot Nothing Then
                    cellContent.Dispose()
                End If

                'Populate cell with label
                Dim label As New Label()
                label.TextAlign = ContentAlignment.MiddleCenter
                label.Dock = DockStyle.Fill
                table.Controls.Add(label, c + 1, r)
                labels(c, r) = label

            Next
        Next

        initLabelEvents()
        Me.Size = New Size(table.Width + 10, table.Height + 10)

    End Sub

    Private Sub initLabelEvents()

        Dim rows As Integer = table.RowCount - 1
        For r As Integer = 1 To rows
            Dim thisLabel As Label = table.GetControlFromPosition(0, r)
            'Dont add eventhandler if label is sum, bonus or total.
            Dim labelName As String = thisLabel.Tag
            If Not labelName.Equals("7") And Not labelName.Equals("8") And Not labelName.Equals("18") Then
                AddHandler thisLabel.MouseEnter, AddressOf Me.Label_MouseEnter
                AddHandler thisLabel.MouseLeave, AddressOf Me.Label_MouseLeave
                AddHandler thisLabel.MouseClick, AddressOf Me.Label_MouseClick
            End If
        Next

    End Sub

    Private Sub Label_MouseEnter(sender As Object, e As EventArgs)
        RaiseEvent MouseEnterLabel(sender, e)
    End Sub

    Private Sub Label_MouseLeave(sender As Object, e As EventArgs)
        RaiseEvent MouseLeaveLabel(sender, e)
    End Sub

    Private Sub Label_MouseClick(sender As Object, e As EventArgs)
        RaiseEvent MouseClickLabel(sender, e)
    End Sub

    Public Sub MarkCurrentPlayer(ByVal currentPlayer As Integer)

        'Reset all colors back to normal before adding new
        For i As Integer = 0 To table.ColumnCount - 2
            labels(i, 0).BackColor = Color.Transparent
        Next
        'Mark current player yellow
        labels(currentPlayer, 0).BackColor = Color.Yellow
    End Sub

    Public Sub upDatePlayersScore(ByVal currentPlayer As Integer, ByVal playersScore As Integer(,))

        Dim firstDimensionLength As Integer = ((playersScore.Length) / 2) - 1
        'Console.WriteLine("ss" & firstDimensionLength)
        For r As Integer = 0 To firstDimensionLength
            If playersScore(r, 0) > 0 Then
                labels(currentPlayer, r).Text = playersScore(r, 0)
                'playersScore(r, 1) = 1 means stroked
            ElseIf playersScore(r, 1) = 1 Then
                labels(currentPlayer, r).Text = "X"
            End If


        Next
    End Sub

End Class
