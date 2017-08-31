Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class frmcuentascliente
    Dim instru As String
    Dim ban1 As Byte

    Private Sub frmcuentascliente_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frmcuentascliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenaGrid()

    End Sub

    Sub LlenaGrid()
        Dim ds As New DataSet
        If ban1 = 0 Then
            instru = "SELECT * FROM vistareportecredito;"
        Else
            instru = "Select * FROM vistareportecredito where NomCte like'%" & txtnommodi.Text & "%'"
            ban1 = 0
        End If

        Dim da As New MySqlDataAdapter(instru, conectar.enlaceBD)
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        enlaceBD.Close()
    End Sub

    Private Sub txtnommodi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnommodi.TextChanged
        DataGridView1.Refresh()
        LlenaGrid()
        ban1 = 1
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Me.Close()
    End Sub
End Class