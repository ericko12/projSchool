Imports MySql.Data.MySqlClient

Public Class frmcuentaprov

    Private Sub cbomclientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmcuentaprov_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub frmcuentaprov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargagrid()

    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        Me.Close()

    End Sub
    Sub cargagrid()
        Dim instruccion As String = "SELECT * FROM vistaproveedor"

        Dim da As New MySqlDataAdapter(instruccion, conectar.enlaceBD)
        Dim ds As New DataSet


        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).HeaderCell.Value = "Nombre"
        DataGridView1.Columns(1).HeaderCell.Value = "Dirección"
        DataGridView1.Columns(2).HeaderCell.Value = "Telefono"
        DataGridView1.Columns(3).HeaderCell.Value = "RFC"
        DataGridView1.Columns(4).HeaderCell.Value = "Correo electrónico"

        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.DisplayMember = "NomProv"
        ComboBox1.ValueMember = "NomProv"
        enlaceBD.Close()
    
    End Sub

    Private Sub lbldescribe_Click(sender As Object, e As EventArgs) Handles lbldescribe.Click

    End Sub
End Class