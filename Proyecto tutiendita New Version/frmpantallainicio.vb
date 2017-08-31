Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frmpantallainicio

    Dim evento As New KeyEventArgs(Keys.Enter) 'para ejecutar un evento sin tener que dar clic
    Dim fecha As Date = Now
    Dim consulta As String
    Public Conexion As MySqlConnection
    Dim com As MySqlCommand
    Public resp As Integer = 0
    Dim primero As Boolean
    Dim ancho As Integer
    Dim alto As Integer


    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.F5
                'pantalla.Show()
                frmbusqueda.ShowDialog()
            Case Keys.F2
                frmventas.Show()
            Case Keys.Control + Keys.I
                PictureBox1_Click(Nothing, evento)
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        frmproducto.Show()
        freememoria.ClearMemory()
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.ImageLocation = Application.StartupPath + "\Imagenes\1-02.png"
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        PictureBox1.ImageLocation = Application.StartupPath + "\Imagenes\1-01.png"
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmventas.Show()
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.ImageLocation = Application.StartupPath + "\Imagenes\2-02.png"
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub PictureBox3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseMove
        PictureBox3.ImageLocation = Application.StartupPath + "\Imagenes\2-01.png"
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom

    End Sub

    Private Sub PictureBox6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.ImageLocation = Application.StartupPath + "\Imagenes\3-02.png"
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
    End Sub


    Private Sub PictureBox6_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox6.MouseMove
        PictureBox6.ImageLocation = Application.StartupPath + "\Imagenes\3-01.png"
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub PictureBox8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseLeave
        PictureBox8.ImageLocation = Application.StartupPath + "\Imagenes\5-02.png"
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
    End Sub


    Private Sub PictureBox8_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox8.MouseMove
        PictureBox8.ImageLocation = Application.StartupPath + "\Imagenes\5-01.png"
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
    End Sub


    Private Sub frmpantallainicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BackgroundImage = System.Drawing.Bitmap.FromFile(Application.StartupPath + "\Imagenes\principal.jpg")
        Me.BackgroundImageLayout = ImageLayout.Zoom
        freememoria.ClearMemory()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        frmventas.Show()
    End Sub

    Private Sub frmpantallainicio_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim consulta As String
        'ancho = Me.Width
        'alto = Me.Height


        SetResolution(1280, 1024, 32)


        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.BackgroundImage = System.Drawing.Bitmap.FromFile(Application.StartupPath + "\Imagenes\principal.jpg")
        Me.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.ImageLocation = Application.StartupPath + "\Imagenes\close1-05.png"
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        If mst = 0 Then
            PictureBox8.Visible = False
            frmalmacen.Button4.Enabled = False
            frmalmacen.btnmodificar.Enabled = False
            frmalmacen.Label3.Visible = False
            frmalmacen.Label2.Visible = False
            frmproducto.lblmodi.Enabled = False
            frmproducto.lblelimina.Enabled = False
        End If
        Timer1.Start()
        'consulta = "Exec pa_cortecaja '" & fecha.ToString("dd/MM/yy") & "', 0 ,0"
        'conectar()
        'com = New MySqlCommand(consulta, Conexion)
        'resp = com.ExecuteNonQuery
        'Conexion.Close()

    End Sub
    Sub conectar()
        Dim dire As String = Application.StartupPath + "\config.ini"
        Dim sr As New System.IO.StreamReader(dire)
        Conexion = New MySqlConnection
        Conexion.ConnectionString = (sr.ReadToEnd)
        sr.Close()
        Conexion.Open()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click

        frmconfigurar.ShowDialog()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        frmcliente.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        freememoria.ClearMemory()
        Application.Exit()
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.ImageLocation = Application.StartupPath + "\Imagenes\close1-05.png"
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub

    Private Sub PictureBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        PictureBox2.ImageLocation = Application.StartupPath + "\Imagenes\closeon-05.png"
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub PictureBox4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        'pantalla.Show()
        If mst = 1 Then
            frmctas.Show()
        Else
            frmctaabon1.Show()
        End If

    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.ImageLocation = Application.StartupPath + "\Imagenes\4-02.png"
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub PictureBox4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox4.MouseMove
        PictureBox4.ImageLocation = Application.StartupPath + "\Imagenes\4-01.png"
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        mensajes.Label1.Text = "Bienvenido"
        mensajes.RichTextBox1.Text = "Escoge una opción en los botones de abajo"
        mensajes.Show()
        aviso.Show()
        Timer1.Enabled = False
    End Sub


    Private Sub frmpantallainicio_Resize(sender As Object, e As EventArgs) Handles Me.Resize

    End Sub
End Class

