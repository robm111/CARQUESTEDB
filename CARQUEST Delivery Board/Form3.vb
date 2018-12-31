Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For i = 0 To ProgressBar1.Maximum - 1
            System.Threading.Thread.Sleep(50) 'wait for 50ms
            ProgressBar1.Value += 1
        Next
    End Sub

End Class