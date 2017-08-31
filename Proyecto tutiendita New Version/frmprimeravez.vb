Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class frmprimeravez
   
    Private Sub frmprimeravez_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnguarda_Click(sender As Object, e As EventArgs) Handles btnguarda.Click
        frmconfigurar.ShowDialog()
        Me.Close()
    End Sub
End Class