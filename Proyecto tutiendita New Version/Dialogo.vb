Imports System.Windows.Forms

Public Class Dialogo


    Private Sub Dialogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label3.TextAlign = ContentAlignment.TopCenter
        Timer2.Start()
        'pantalla.Show()
        Timer1.Start()

    End Sub

    Private Sub Timer1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Disposed
        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'pantalla.Close()
        Me.Close()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        For i = 0 To 2
            Label2.Text = Label2.Text + "█"
        Next
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
