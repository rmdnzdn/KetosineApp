Public Class loading

    Private Sub loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        animaten(Me, True)
        Timer1.Start()
        ProgressBar1.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value < 5 Then
            ProgressBar1.Value += 2
            Label9.Visible = True
            Label10.Visible = False
            Label11.Visible = False
        ElseIf ProgressBar1.Value < 10 Then
            ProgressBar1.Value += 2
            Label9.Visible = True
            Label10.Visible = True
            Label11.Visible = False
        ElseIf ProgressBar1.Value < 20 Then
            ProgressBar1.Value += 2
            Label9.Visible = True
            Label10.Visible = True
            Label11.Visible = True
        ElseIf ProgressBar1.Value < 30 Then
            ProgressBar1.Value += 2
            Label9.Visible = False
            Label10.Visible = False
            Label11.Visible = False
        ElseIf ProgressBar1.Value < 40 Then
            ProgressBar1.Value += 2
            Label9.Visible = True
            Label10.Visible = False
            Label11.Visible = False
        ElseIf ProgressBar1.Value < 50 Then
            ProgressBar1.Value += 2
            Label9.Visible = True
            Label10.Visible = True
            Label11.Visible = False
        ElseIf ProgressBar1.Value < 60 Then
            ProgressBar1.Value += 2
            Label9.Visible = True
            Label10.Visible = True
            Label11.Visible = True
        ElseIf ProgressBar1.Value < 70 Then
            ProgressBar1.Value += 2
            Label9.Visible = False
            Label10.Visible = False
            Label11.Visible = False
        ElseIf ProgressBar1.Value < 80 Then
            ProgressBar1.Value += 2
            Label9.Visible = True
            Label10.Visible = False
            Label11.Visible = False
        ElseIf ProgressBar1.Value < 90 Then
            ProgressBar1.Value += 2
            Label9.Visible = True
            Label10.Visible = True
            Label11.Visible = False
        ElseIf ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 2
            Label9.Visible = True
            Label10.Visible = True
            Label11.Visible = True
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            beranda.Show()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class