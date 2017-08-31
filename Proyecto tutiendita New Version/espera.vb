Public Class espera

    Private Sub espera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pantalla.Show()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        pantalla.Close()
        Me.Close()

    End Sub
End Class