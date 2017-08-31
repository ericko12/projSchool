Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class frmdescuentos
    Dim i As Integer
    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
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
                        MsgBox("APROBADO!!", vbExclamation, "Procede descuento")
                        Me.Close()
                        descu = txtpago.Text
                        frmventas.lblventa.Text = Label7.Text
                        i = 1
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
                MsgBox("El nombre de gerente o contraseña es incorrecto", vbCritical, "Mi negocio")
            End If
            enlaceBD.Close()
            dr.Close()
        Catch errores As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & errores.Message)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub frmdescu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toventa.Text = Val(frmventas.lblventa.Text)
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub txtpago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpago.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
            tips.balon(txtpago, "Espera...", "Este campo solo acepta números")
        End If
    End Sub

    Private Sub txtpago_TextChanged(sender As Object, e As EventArgs) Handles txtpago.TextChanged
        If Val(txtpago.Text) <= 100 And Val(txtpago.Text) > 0 Then
            Label7.Text = toventa.Text - (Val(toventa.Text) * Val(txtpago.Text / 100))
        Else
            Label7.Text = 0
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class