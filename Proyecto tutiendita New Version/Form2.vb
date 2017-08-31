Imports MySql.Data.MySqlClient

Public Class aviso

    Private Sub aviso_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        lbldescribe.Text = "Los siguientes productos se encuentran al borde del agotamiento, es necesario " & vbCrLf & "comunicarse con el proveedor de productos para evitar un desabastecimiento " & vbCrLf & "en el almacen."
        Dim instruccion As String = "SELECT NomProd, Marca, descrip, existencia FROM productos where existencia<mini;"
        Dim da As New MySqlDataAdapter(instruccion, conectar.enlaceBD)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Columns(0).HeaderCell.Value = "Producto"
            DataGridView1.Columns(1).HeaderCell.Value = "Marca"
            DataGridView1.Columns(2).HeaderCell.Value = "Descripción"
            DataGridView1.Columns(3).HeaderCell.Value = "Existencia en almacen"

        Else
            Me.Close()
        End If
        enlaceBD.Close()
    End Sub

    Private Sub aviso_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus

    End Sub

    Private Sub aviso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetEmp.Productos' table. You can move, or remove it, as needed.

        lbldescribe.Text = "Los siguientes productos se encuentran al borde del agotamiento, es necesario " & vbCrLf & "comunicarse con el proveedor de productos para evitar un desabastecimiento " & vbCrLf & "en el almacen."
        Dim instruccion As String = "SELECT NomProd, Marca, descrip, existencia FROM productos where existencia<mini;"
        Dim da As New MySqlDataAdapter(instruccion, conectar.enlaceBD)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.Columns(0).HeaderCell.Value = "Producto"
            DataGridView1.Columns(1).HeaderCell.Value = "Marca"
            DataGridView1.Columns(2).HeaderCell.Value = "Descripción"
            DataGridView1.Columns(3).HeaderCell.Value = "Existencia en almacen"

        Else
            Me.Close()
        End If
        enlaceBD.Close()
        PictureBox1.ImageLocation = Application.StartupPath + "\Imagenes\agt.png"
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim impreso As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Try
            vistaprev.Show()
            vistaprev.CrystalReportViewer1.ReportSource = (Application.StartupPath + "\AGOTADOS.rpt")
            
        Catch exc As Exception
            MsgBox("No hay conexión con la impresora, revisa tu configuración. Error:" & exc.ToString, MsgBoxStyle.Critical, "Error de impresión")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
    End Sub
End Class