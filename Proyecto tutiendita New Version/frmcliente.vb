Option Explicit On
Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class frmcliente
    Public Conexion As MySqlConnection
    Dim evento As New KeyEventArgs(Keys.Enter)
    Dim consulta As String
    Dim com As MySqlCommand
    Dim resp, suc As Integer
    Dim dataset As DataSet
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.F5
                querys.asignaquery(Me.Name)
                frmbusqueda.Show()
            Case Keys.F2
                frmventas.Show()
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Public Sub lblmodi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmodi.Click
        lblmodi.Font = New System.Drawing.Font("", 21)
        lblmodi.ForeColor = Color.White
        lblnew.Font = New System.Drawing.Font("", 16)
        lblnew.ForeColor = Color.MistyRose
        lblelimina.Font = New System.Drawing.Font("", 16)
        lblelimina.ForeColor = Color.MistyRose
        lblclasif.Font = New System.Drawing.Font("", 16)
        lblclasif.ForeColor = Color.MistyRose
        lbltitulo.Text = "Modificar cuenta de Cliente"
        lbldescribe.Text = "Actualiza datos de un cliente existente"
        Panelbusca.Visible = True
        PanelProducto.Visible = False
        btnaceptar.Text = "&Modificar"
        txtcodmodi.Clear()
        txtnommodi.Clear()
        querys.asignaquery(Me.Name)
    End Sub

    Private Sub lblnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblnew.Click
        lblnew.Font = New System.Drawing.Font("", 21)
        lblnew.ForeColor = Color.White
        lblmodi.Font = New System.Drawing.Font("", 16)
        lblmodi.ForeColor = Color.MistyRose
        lblelimina.Font = New System.Drawing.Font("", 16)
        lblelimina.ForeColor = Color.MistyRose
        lblclasif.Font = New System.Drawing.Font("", 16)
        lblclasif.ForeColor = Color.MistyRose
        lbltitulo.Text = "Nuevo Cliente"
        lbldescribe.Text = "Alta de nuevo producto"
        btnaceptar.Text = "&Guardar"
        PanelProducto.Visible = True
        Panelbusca.Visible = False
        limpiar()
        cargaid()
    End Sub

    Public Sub lblelimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblelimina.Click
        lblelimina.Font = New System.Drawing.Font("", 21)
        lblelimina.ForeColor = Color.White
        lblmodi.Font = New System.Drawing.Font("", 16)
        lblmodi.ForeColor = Color.MistyRose
        lblnew.Font = New System.Drawing.Font("", 16)
        lblnew.ForeColor = Color.MistyRose
        lblclasif.Font = New System.Drawing.Font("", 16)
        lblclasif.ForeColor = Color.MistyRose
        lbltitulo.Text = "Eliminar Cliente"
        lbldescribe.Text = "Borra del registro un cliente existente"
        btncomando.Text = "&Aceptar"
        btnaceptar.Text = "&Eliminar"
        Panelbusca.Visible = True
        PanelProducto.Visible = False
    End Sub

    Private Sub lblclasif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblclasif.Click
        lblclasif.Font = New System.Drawing.Font("", 21)
        lblclasif.ForeColor = Color.White
        lblmodi.Font = New System.Drawing.Font("", 16)
        lblmodi.ForeColor = Color.MistyRose
        lblnew.Font = New System.Drawing.Font("", 16)
        lblnew.ForeColor = Color.MistyRose
        lblelimina.Font = New System.Drawing.Font("", 16)
        lblelimina.ForeColor = Color.MistyRose
        pantalla.Show()
    End Sub

    Private Sub lblnew_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblnew.MouseLeave
        efectos1.cambiacolorysize()
    End Sub

    Private Sub lblnew_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblnew.MouseMove
        efectos1.seleccion1()
    End Sub

    Private Sub lblelimina_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblelimina.MouseLeave
        efectos1.cambiacolorysize()
    End Sub

    Private Sub lblelimina_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblelimina.MouseMove
        efectos1.seleccion3()
    End Sub

    Private Sub lblmodi_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblmodi.MouseLeave
        efectos1.cambiacolorysize()
    End Sub

    Private Sub lblmodi_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblmodi.MouseMove
        efectos1.seleccion2()
    End Sub

    Private Sub lblclasif_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblclasif.MouseLeave
        efectos1.cambiacolorysize()
    End Sub

    Private Sub lblclasif_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblclasif.MouseMove
        efectos1.seleccion4()
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncomando.Click
        'En este boton se busca el producto con el codigo de barras preciso o la descripción
        '1. Si se encuentra mandar los datos de la búsqueda al panel para modificar/insertar/eliminar....
        '2. Si no mandar error
        '3. Linkear también con la ventana de busqueda rapida..
        If txtcodmodi.Text <> "" Then
            consulta = "Select * from ClienteS where idCte=" + txtcodmodi.Text
        Else
            consulta = "Select * from ClienteS where NomCte like '" + txtnommodi.Text + "'"
        End If
        Try

            com = New MySqlCommand(consulta, conectar.enlaceBD)
            Dim lector As MySqlDataReader

            lector = com.ExecuteReader()
            lector.Read()
            T1.Text = lector(0)
            T8.Text = lector(1)
            T2.Text = lector(2)
            T3.Text = lector(3)
            T4.Text = lector(6)
            T5.Text = lector(7)
            T6.Text = lector(8)
            T7.Text = lector(4)
            T9.Text = lector(9)
            enlaceBD.Close()

            Panelbusca.Visible = False
            PanelProducto.Visible = True
            Panelbusca.Visible = False
            PanelProducto.Visible = True
        Catch ex As Exception
            MsgBox("Cliente no encontrado, comprueba la escritura", MsgBoxStyle.Information, "Cliente no encontrado")
        End Try
    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        Panelbusca.Visible = False
        PanelProducto.Visible = False
    End Sub
    Private Sub PanelNew_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PanelProducto.VisibleChanged
        Me.AcceptButton = btnaceptar
    End Sub

    Private Sub Panelmodifica_HandleDestroyed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panelbusca.HandleDestroyed
        Me.AcceptButton = btncomando
    End Sub

    Public Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        'aqui poner un case segùn la leyenda del boton. Si es nuevo=guardar si es modificar=actualizar si es borrar=eliminar
        Select Case btnaceptar.Text
            Case "&Guardar"
                Try
                    consulta = "Insert into clientes values (null,'" & T8.Text & "','" & T2.Text & "','" & T3.Text & "','" & T7.Text & "', now(), '" & T4.Text & "', '" & T5.Text & "','" & T6.Text & "','" & T9.Text & "', " & suc & ");"
                    com = New MySqlCommand(consulta, conectar.enlaceBD)
                    resp = com.ExecuteNonQuery
                    enlaceBD.Close()
                    Dialogo.Label3.Text = "GUARDANDO " & T2.Text & " " & T3.Text
                    Dialogo.Show()
                    limpiar()
                    cargaid()
                Catch ex As Exception
                    MsgBox("¡Que vergüenza!... tenemos un problema", vbCritical)
                    limpiar()
                    cargaid()
                End Try
            Case "&Modificar"
                consulta = "UPDATE `clientes` SET `RFCCte`='" & T8.Text & "',`NomCte`='" & T2.Text & "',`DirCte`='" & T3.Text & "',`TelCte`='" & T7.Text & "',`ColCte`='" & T4.Text & "',`Poblacion`='" & T5.Text & "',`CPCte`='" & T6.Text & "',`email`='" & T9.Text & "',`idSuc`=" & suc & " WHERE idcte=" & T1.Text
                com = New MySqlCommand(consulta, conectar.enlaceBD)
                resp = com.ExecuteNonQuery
                enlaceBD.Close()
                Dialogo.Label3.Text = "ACTUALIZANDO " & T2.Text & " " & T3.Text
                limpiar()
                Dialogo.Show()
                cargaid()
                lblnew_Click(Nothing, evento)
            Case "&Eliminar"
                consulta = "Delete from Clientes where idCte='" & T1.Text & "'"
                com = New MySqlCommand(consulta, conectar.enlaceBD)
                resp = com.ExecuteNonQuery
                enlaceBD.Close()
                MsgBox("Cliente Eliminado", MsgBoxStyle.Information, "Cliente eliminado")
                limpiar()
                lblnew_Click(Nothing, evento)
        End Select
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcerrar.Click
        PictureBox2_Click(Nothing, evento)
    End Sub

    Private Sub lblcerrar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblcerrar.MouseLeave
        efectos1.cambiacolorysize()
    End Sub

    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblcerrar.MouseMove
        efectos1.seleccion5()
    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        frmbusqueda.ShowDialog()
        frmbusqueda.lblventana.Text = "Cliente"
        frmbusqueda.lbldescribe.Text = "Escriba las primeras letras del nombre del cliente"
    End Sub

    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles T2.GotFocus
        mensajes.Show()
    End Sub

    Private Sub lbldescribe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbldescribe.Click
        mensajes.Show()
    End Sub

    Private Sub frmcliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Public Function AutoCompletar(ByVal Control As TextBox, ByVal columna As Byte) As AutoCompleteStringCollection
        Dim Coleccion As New AutoCompleteStringCollection
        Dim Comando As String
        Comando = "SELECT * FROM clientes"
        com = New MySqlCommand(Comando, conectar.enlaceBD)
        Dim lector As MySqlDataReader
        lector = com.ExecuteReader()
        While lector.Read()
            'Coleccion.AddRange(New String() {lector(1)})
            Coleccion.Add(lector(columna).ToString)
        End While
        lector.Close()
        enlaceBD.Close()
        With Control
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = Coleccion
            .Multiline = False
        End With
        Return Coleccion
    End Function

    Private Sub frmcliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargaid()
        PictureBox1.ImageLocation = Application.StartupPath + "\Imagenes\v3-08.png"
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.ImageLocation = Application.StartupPath + "\Imagenes\close1-05.png"
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        suc = 1
    End Sub
    Sub cargaid()
        consulta = "Select idCte from clientes order by idCte DESC"
        com = New MySqlCommand(consulta, conectar.enlaceBD)
        Dim lector As MySqlDataReader

        Try
            lector = com.ExecuteReader()
            lector.Read()
            T1.Text = String.Format("{0:0000}", lector(0) + 2)
        Catch ms As Exception
            T1.Text = String.Format("{0:0000}", 1)
        End Try
        enlaceBD.Close()

        AutoCompletar(Me.T8, 1)
        AutoCompletar(Me.T2, 2)
        AutoCompletar(Me.T3, 3)
        AutoCompletar(Me.T4, 6)
        AutoCompletar(Me.T5, 7)
        AutoCompletar(Me.T6, 8)
        AutoCompletar(Me.T7, 4)
        AutoCompletar(Me.T9, 9)
        
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim ventana As New ventanactiva
        If ventana.activa(frmsaldos) = True Then
            frmsaldos.cargagrid()
            Me.Close()
        Else
            Me.Close()
        End If

        freememoria.ClearMemory()
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.ImageLocation = Application.StartupPath + "\Imagenes\close1-05.png"
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub

    Private Sub PictureBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        PictureBox2.ImageLocation = Application.StartupPath + "\Imagenes\closeon-05.png"
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub
    Sub limpiar()
        T1.Clear()
        T2.Clear()
        T3.Clear()
        T5.Clear()
        T6.Clear()
    End Sub

    Private Sub txtcodmodi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodmodi.TextChanged
        txtnommodi.Clear()
    End Sub

    Private Sub txtnommodi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnommodi.TextChanged
        txtcodmodi.Clear()
    End Sub

    Private Sub btncancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Panelbusca.Visible = False
        PanelProducto.Visible = False
        Me.Close()
    End Sub

    Private Sub T6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T6.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            tips.balon(txtcodmodi, "Espera...", "Este campo solo acepta números")
        End If
    End Sub

    Private Sub T7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T7.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            tips.balon(txtcodmodi, "Espera...", "Este campo solo acepta números")
        End If
    End Sub

    Private Sub T9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T9.KeyPress
        Dim funcion As New LibValidateEmail
        funcion.LibValidateEmail(T9.Text)
    End Sub

End Class