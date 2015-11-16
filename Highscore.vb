Public Class Highscore

    Private listBoxes As ListBox()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        listBoxes = New ListBox() {listMaxiForced1, listMaxiForced2, listMaxiForced3, listMaxiFree1, listMaxiFree2, listMaxiFree3, listYatzyForced1, listYatzyForced2, listYatzyForced3, listYatzyFree1, listYatzyFree2, listYatzyFree3}
    End Sub

    ' Show scores when form is loaded
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load and set new form icon 
        Dim ico As Icon = My.Resources.ResourceManager.GetObject("favicon")
        Me.Icon = ico
        ' Display scores
        showScores()
    End Sub

    ' Load scores from Setting object and display them
    Private Sub showScores()

        Dim scores() As String = getScoreSetting(False)
        Dim interval As Integer = 0

        For i As Integer = 0 To scores.Length - 1

            'Console.WriteLine(i)
            Dim currentScore() As String = scores(i).Split("|"c)

            For x As Integer = 0 To currentScore.Length - 1 Step +3
                If Not currentScore(x).Equals("0") Then
                    Dim name As String = (x / 3) + 1
                    listBoxes(interval).Items.Add(name.PadLeft(3) & ". " & currentScore(x))
                    listBoxes(interval + 1).Items.Add(currentScore(x + 1))
                    listBoxes(interval + 2).Items.Add(currentScore(x + 2))
                End If
            Next
            interval += 3
        Next


    End Sub

    ' Loop through | seperated score in settings object and write current score.
    Public Function writeScore(ByVal newScore As String(), ByVal scoreType As Integer)

        ' Split with | and create array
        Dim currentScore() As String = getScoreSetting(True, scoreType).Split("|"c)
        Dim thisScore As Integer = 0
        Dim position As Integer = 0

        ' Loop through all values stored in Settings in choosed game type
        For i As Integer = 1 To currentScore.Length - 1 Step +3

            If currentScore.Length - 1 > i Then

                thisScore = Convert.ToInt32(currentScore(i))
                Dim usersScore As Integer = Convert.ToInt32(newScore(1))

                ' If this is true we have a new highscore
                If thisScore < usersScore Then

                    ' Push all old scores backward and insert new score.
                    For x As Integer = currentScore.Length - 1 To i - 1 Step -1
                        If currentScore.Length - 1 >= x + 3 Then
                            currentScore(x + 3) = currentScore(x)
                        End If

                    Next

                    position = (i / 3) + 1

                    currentScore(i - 1) = newScore(0)
                    currentScore(i) = newScore(1)
                    currentScore(i + 1) = newScore(2)

                    Dim score As String = String.Join("|", currentScore)

                    Select Case scoreType
                        Case 0
                            My.Settings.maxi_forced = score
                        Case 1
                            My.Settings.maxi_free = score
                        Case 2
                            My.Settings.normal_forced = score
                        Case 3
                            My.Settings.normal_free = score
                    End Select

                    My.Settings.Save()

                    GoTo end_of_for

                End If

            End If
        Next i
end_of_for:

        Return position
    End Function

    ' Get score values from settings
    Public Function getScoreSetting(ByVal isSingle As Boolean, Optional ByVal scoreType As Integer = 0)

        Dim scoreArray(3) As String

        Dim maxi_forced As String = My.Settings.maxi_forced
        Dim maxi_free As String = My.Settings.maxi_free
        Dim normal_free As String = My.Settings.normal_free
        Dim normal_forced As String = My.Settings.normal_forced

        scoreArray(0) = maxi_forced
        scoreArray(1) = maxi_free
        scoreArray(2) = normal_forced
        scoreArray(3) = normal_free

        If isSingle Then
            Return scoreArray(scoreType)
        Else
            Return scoreArray
        End If


    End Function

    Private Sub resetHighScore_Click(sender As Object, e As EventArgs) Handles resetHighScore.Click
        My.Settings.Reset()
        My.Settings.Save()

        For i As Integer = 0 To listBoxes.Length - 1
            listBoxes(i).Dispose()
        Next

    End Sub

End Class
