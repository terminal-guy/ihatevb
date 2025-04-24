Public Class Form1


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        Dim currentime As String = ""
        Dim alarmtime As String = ""

        lblTime.Text = Format(TimeValue(Now), "hh:mm")
        'lblDate.Text = TimeValue(Now)


        currentime = lblTime.Text
        alarmtime = txtSetTime.Text

        If (currentime = alarmtime) Then
            Beep()
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


End Class
