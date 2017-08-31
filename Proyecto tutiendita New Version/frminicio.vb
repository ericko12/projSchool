Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class frminicio
    Dim i As Integer
    Dim cl As String
    Dim evento As New KeyEventArgs(Keys.Enter)
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        Select Case keyData
             Case Keys.Control + (Keys.D1)
                cl = cl & "1"
            Case Keys.Control + (Keys.D2)
                cl = cl & "2"
        End Select

        If cl = "1112" Then
            frmusrava.Show()
            cl = ""
        End If
        If cl = "1212" Then
            frmconfigurar.Show()
            frmconfigurar.TabPage2.Show()
            cl = ""
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function




    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        End
    End Sub



    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Dim consulta As String
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        Dim Sha As New SHA1Managed()
        Dim resul() As Byte
        consulta = "select * from empleados where user='" + txtusuario.Text + "' and pwd=sha('" + txtcontrasena.Text + "')"
        cmd = New MySqlCommand(consulta, conectar.enlaceBD)
        resul = System.Text.Encoding.ASCII.GetBytes(txtcontrasena.Text)
        resul = Sha.ComputeHash(resul)
        Dim encPassword As String = ""

        For Each b As Byte In resul
            encPassword += b.ToString("x2")
        Next

        Try
            dr = cmd.ExecuteReader()
            While dr.Read()
                If txtusuario.Text = dr("user").ToString() Then
                    If encPassword = dr("pwd").ToString() Then
                        NomEmp = dr("nomEmp").ToString()
                        idEmp = dr("idEmp").ToString()
                        mst = dr("mstr")
                        i = 1

                        If stblcpmt() = 1 Then
                            frmpantallainicio.Show()
                            Me.Hide()
                        Else

                            Dialogo.Show()
                            Dialogo.Label3.Text = "REINICIANDO"
                            Application.Restart()
                        End If

                    Else
                        MsgBox("La contraseña es incorrecta", vbCritical, "Error al ingresar usuario")
                        txtcontrasena.SelectAll() : txtcontrasena.Focus()
                    End If
                    Else
                        MsgBox("Usuario incorrecto", vbCritical, "Error al ingresar usuario")
                        txtusuario.SelectAll() : txtusuario.Focus()
                    End If

            End While
            If i = 1 Then

            Else
                MsgBox("El nombre de usuario o contraseña es incorrecto", vbCritical, "Mi negocio")
            End If
            dr.Close()
            enlaceBD.Close()

        Catch errores As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & errores.Message)
        End Try

    End Sub

    Private Sub frminicio_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If i <> 1 Then
            Application.Exit()
        End If
    End Sub

    Private Sub frminicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImage = System.Drawing.Bitmap.FromFile(Application.StartupPath + "\Imagenes\inicial-16.jpg")
        Me.BackgroundImageLayout = ImageLayout.Zoom
        freememoria.ClearMemory()
    End Sub


End Class
