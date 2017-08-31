Public Class frmctaabon1

    Private Sub lbltitulo_Click(sender As Object, e As EventArgs) Handles lbltitulo.Click
        frmalmacen.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        frmcuentaprov.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        frmreportegral.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        frmcuentascliente.Show()
    End Sub

    Private Sub frmctas_Load(sender As Object, e As EventArgs) Handles Me.Load
        '        Me.SetDesktopLocation(1000, 0)
        'desvanecido.EffectIn(Me)
        'Call TimerOn(10)
        EfectoExplosion(Me)
    End Sub
    Public Sub TimerOn(ByRef Interval As Short)
        If Interval > 0 Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        desvanecido.EffectOut(Me)
        Me.Close()
    End Sub

    Private Sub lbltitulo_MouseHover(sender As Object, e As EventArgs) Handles lbltitulo.MouseHover

    End Sub

    Private Sub lbltitulo_MouseLeave(sender As Object, e As EventArgs) Handles lbltitulo.MouseLeave
        efectos.cambiacolorysize()
    End Sub

    Private Sub lbltitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles lbltitulo.MouseMove
        efectos.seleccion1()
    End Sub

    Private Sub frmctas_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        desvanecido.EffectOut(Me)
        Me.Close()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        frmprovee.Show()
        Me.Close()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click_1(sender As Object, e As EventArgs) Handles Label11.Click
        frmcompras.Show()
        Me.Close()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class