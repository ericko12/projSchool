Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class frmclasifica
    Dim evento As New KeyEventArgs(Keys.Enter) 'para ejecutar un evento sin tener que dar clic
    Public Conexion As New MySqlConnection
    Dim com As MySqlCommand
    Dim consulta As String
    Dim resp As Integer
    Dim dataset As DataSet

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancela.Click
        pantalla.Close()
        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguarda.Click
        consulta = "Insert into clasificacion (nomClasif) values('" + TextBox8.Text + "')"
        enlaceBD()
        Dim com As New MySqlCommand(consulta, enlaceBD)
        resp = com.ExecuteNonQuery
        enlaceBD.Close()
        Dialogo.Label3.Text = "GUARDANDO " & TextBox8.Text
        Dialogo.ShowDialog()

        If Label2.Visible = True Then
            frmproducto.Close()
            frmproducto.Show()
        End If
        Me.Close()

    End Sub

    Private Sub frmclasifica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta = "Select * from clasificacion"
        com = New MySqlCommand(consulta, conectar.enlaceBD)
        Dim lector As MySqlDataReader
        lector = com.ExecuteReader()
        lector.Read()
        If Not lector.HasRows Then
            Label2.Visible = True
            Label3.Visible = True
            Label1.Visible = False
            Label9.Visible = False
        End If
        enlaceBD.Close()
    End Sub
End Class