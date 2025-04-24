Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTIme.Text = Format(TimeValue(Now), "hh時　mm分　ss秒 tt")
        lblDate.Text = TimeValue(Now)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
