Public Class SSD

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click
        If Btn.Text = "S T A R T" Then
            Timer.Start()
            Btn.Text = "S T O P"
            Btn.BackColor = Color.Black
        Else
            Timer.Stop()
            Btn.Text = "S T A R T"
            Btn.BackColor = Color.Maroon
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        num.Text += 1

        If num.Text = 1 Then
            segA.BackColor = Color.Gray
            segB.BackColor = Color.Red
            segC.BackColor = Color.Red
            segD.BackColor = Color.Gray
            segE.BackColor = Color.Gray
            segF.BackColor = Color.Gray
            segG.BackColor = Color.Gray

        ElseIf num.Text = 2 Then
            segA.BackColor = Color.Red
            segB.BackColor = Color.Red
            segC.BackColor = Color.Gray
            segD.BackColor = Color.Red
            segE.BackColor = Color.Red
            segF.BackColor = Color.Gray
            segG.BackColor = Color.Red

        ElseIf num.Text = 3 Then
            segA.BackColor = Color.Red
            segB.BackColor = Color.Red
            segC.BackColor = Color.Red
            segD.BackColor = Color.Red
            segE.BackColor = Color.Gray
            segF.BackColor = Color.Gray
            segG.BackColor = Color.Red

        ElseIf num.Text = 4 Then
            segA.BackColor = Color.Gray
            segB.BackColor = Color.Red
            segC.BackColor = Color.Red
            segD.BackColor = Color.Gray
            segE.BackColor = Color.Gray
            segF.BackColor = Color.Red
            segG.BackColor = Color.Red

        ElseIf num.Text = 5 Then
            segA.BackColor = Color.Red
            segB.BackColor = Color.Gray
            segC.BackColor = Color.Red
            segD.BackColor = Color.Red
            segE.BackColor = Color.Gray
            segF.BackColor = Color.Red
            segG.BackColor = Color.Red

        ElseIf num.Text = 6 Then
            segA.BackColor = Color.Red
            segB.BackColor = Color.Gray
            segC.BackColor = Color.Red
            segD.BackColor = Color.Red
            segE.BackColor = Color.Red
            segF.BackColor = Color.Red
            segG.BackColor = Color.Red

        ElseIf num.Text = 7 Then
            segA.BackColor = Color.Red
            segB.BackColor = Color.Red
            segC.BackColor = Color.Red
            segD.BackColor = Color.Gray
            segE.BackColor = Color.Gray
            segF.BackColor = Color.Gray
            segG.BackColor = Color.Gray

        ElseIf num.Text = 8 Then
            segA.BackColor = Color.Red
            segB.BackColor = Color.Red
            segC.BackColor = Color.Red
            segD.BackColor = Color.Red
            segE.BackColor = Color.Red
            segF.BackColor = Color.Red
            segG.BackColor = Color.Red

        ElseIf num.Text = 9 Then
            segA.BackColor = Color.Red
            segB.BackColor = Color.Red
            segC.BackColor = Color.Red
            segD.BackColor = Color.Red
            segE.BackColor = Color.Gray
            segF.BackColor = Color.Red
            segG.BackColor = Color.Red

        Else
            num.Text = 0
            segA.BackColor = Color.Red
            segB.BackColor = Color.Red
            segC.BackColor = Color.Red
            segD.BackColor = Color.Red
            segE.BackColor = Color.Red
            segF.BackColor = Color.Red
            segG.BackColor = Color.Gray

            Timer.Stop()
            Btn.Text = "S T A R T"
            Btn.BackColor = Color.Maroon
        End If
    End Sub
End Class
