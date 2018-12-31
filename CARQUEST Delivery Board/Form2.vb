Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'This will decrement the opacity.
        Me.Opacity -= 0.06
        'Now that the form is at zero opacity we must 'dispose' of the form.
        If Me.Opacity = 0 Then Me.Dispose()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim opacityFade As Single
        'from minimum transparency to maximum transparency with increment .
        For opacityFade = 0 To 1 Step 0.01
            Me.Opacity = opacityFade
            Me.Refresh()
            'This tells the program to pause for a certain number of milliseconds.
            System.Threading.Thread.Sleep(10)
        Next opacityFade
        Me.Opacity = 1
        'Now the fade in has finished we need it to stop.
        Timer2.Enabled = False
    End Sub
End Class