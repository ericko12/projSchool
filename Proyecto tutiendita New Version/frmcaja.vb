Imports MySql.Data.MySqlClient

Public Class frmcaja
    Public Conexion As New MySqlConnection
    Dim consulta As String
    Dim com As MySqlCommand
    Dim resp As Integer
    Dim dataset As DataSet
    Private Sub frmcaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consulta = "SELECT SUM(v.totalVta) FROM ventas v where (v.Tipopago='Efectivo' or v.Tipopago='Abono') and DATE(v.fecVta)=DATE(NOW()) "
        com = New MySqlCommand(consulta, conectar.enlaceBD)
        Dim lector As MySqlDataReader

        Try
            lector = com.ExecuteReader()
            lector.Read()
            txtcaja.Text = lector(0).ToString
            If Now.Hour >= Convert.ToDouble(HC.Remove(2, 6)) Then btnmodificar.Enabled = True
        Catch err As Exception
            MsgBox("Ups!! " & err.Message, vbCritical, "Ups!!")
        End Try
        Conexion.Close()


    End Sub
    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Me.Close()
        'pantalla.Close()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        consulta = "INSERT INTO `caja`( `fechcorte`, `cantidad`, `estado`) VALUES'" & Now() & "', " & txtcaja.Text & "',1);"
        com = New MySqlCommand(consulta, conectar.enlaceBD)
        com.ExecuteNonQuery()
        enlaceBD.Close()
        Dialogo.Label3.Text = "GUARDANDO " & txtcaja.Text & " "
    End Sub
End Class