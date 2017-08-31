

Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmalmacen


    Private Sub frmalmacen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        pantalla.Close()
    End Sub

    Private Sub frmalmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cuenta_almacen()
        ' cargagrid()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmproducto.Show()
        frmproducto.WindowState = FormWindowState.Normal
        frmproducto.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim evento As New KeyEventArgs(Keys.Enter) 'para ejecutar un evento sin tener que dar clic
        frmproducto.Show()
        frmproducto.WindowState = FormWindowState.Normal
        frmproducto.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        frmproducto.lblelimina_Click(Nothing, evento)
        frmproducto.txtcodmodi.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        frmproducto.Button2_Click(Nothing, evento)
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim evento As New KeyEventArgs(Keys.Enter) 'para ejecutar un evento sin tener que dar clic
        frmproducto.Show()
        frmproducto.WindowState = FormWindowState.Normal
        frmproducto.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        frmproducto.lblmodi_Click(Nothing, evento)
        'frmproducto.Panelbusca.Visible = False
        ' frmproducto.PanelProducto.Visible = True
        frmproducto.txtcodmodi.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        frmproducto.Button2_Click(Nothing, evento)

    End Sub

    Private Sub btnmodifiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        Dim productonew As Double
        Dim consulta As String
        Dim com As MySqlCommand
        Try
            productonew = InputBox("Ingrese el número de unidades del producto seleccionado", "Nueva cantidad de unidades")
            DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value += productonew

            For i = 0 To DataGridView1.Rows.Count - 1
                Label3.Text = CDec(Label3.Text) + (DataGridView1.Item(5, i).Value * DataGridView1.Item(6, i).Value)
                Label4.Text = Label4.Text + DataGridView1.Item(5, i).Value
            Next i

            consulta = "Update productos set Existencia=" & DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value & " where Barcode='" & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value & "'"
            com = New MySqlCommand(consulta, conectar.enlaceBD)
            com.ExecuteNonQuery()
            enlaceBD.Close()

            Call cargagrid()

        Catch x As Exception
            MsgBox("No ingreso número", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Dim path As String = Directory.GetCurrentDirectory()
        'path = InputBox("Ingresa el directorio donde quieres exportar tu reporte. Ejemplo. 'C:/Mis documentos/escritorio'", "Directorio")
        Try
            SaveFileDialog1.Filter = "Libro de Excel 97-2003 (*.xls)|*.xls"
            SaveFileDialog1.FilterIndex = 1
            SaveFileDialog1.ShowDialog()
            path = SaveFileDialog1.FileName
            cadena = "SELECT * into outfile  '" & path.Replace("\", "/") & "' from vistainventario;"
            Dim insertar As New MySqlCommand(cadena, enlaceBD)
            enlaceBD()
            insertar.ExecuteNonQuery()
            enlaceBD.Close()
            MsgBox("Documento creado en: " & path, MsgBoxStyle.Information)
        Catch er As Exception
            MsgBox("No se ha definido una ruta valida ", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If InStr(1, "'%" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged


    End Sub
    Sub cuenta_almacen()
        Dim consulta As String
        Dim com As MySqlCommand
        consulta = "Select sum(costo*existencia) as suma From productos"
        com = New MySqlCommand(consulta, conectar.enlaceBD)

        Dim lector As MySqlDataReader
        lector = com.ExecuteReader()
        Try
            lector.Read()
            Label3.Text = Val(lector(0)).ToString("#,##0")
            Label3.Text = Format(CDbl(Label3.Text), "C")
        Catch ms As Exception
            Label3.Text = 0
        End Try
        lector.Close()
        enlaceBD.Close()

        consulta = "SELECT sum(existencia) as total FROM productos"
        com = New MySqlCommand(consulta, conectar.enlaceBD)
        lector = com.ExecuteReader()
        Try
            lector.Read()
            Label4.Text = lector(0).ToString

        Catch ms As Exception
            Label4.Text = 0
        End Try
        lector.Close()
        enlaceBD.Close()
    End Sub
    Sub cargagrid()
        Dim instruccion As String = "SELECT * FROM vistainventario;"
        Dim mensaje As Byte
        If TextBox2.Text <> "" Then

            If buscar.Checked = True Then
                instruccion = "SELECT * FROM vistainventario where Barcode like '%" & TextBox2.Text & "%'"
            Else
                instruccion = "SELECT * FROM vistainventario where NomProd like '%" & TextBox2.Text & "%'"
            End If
        Else
            mensaje = MsgBox("La consulta está vacía, se cargarán todos los productos. ¿Deseas cargar todos los productos? Si haces click en 'Sí' tardaremos un poco en cargar los productos. Sé paciente", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Espera...")
            If mensaje <> 6 Then
                Exit Sub
            End If
        End If
        Dim da As New MySqlDataAdapter(instruccion, conectar.enlaceBD)
        Dim ds As New DataSet


        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).HeaderCell.Value = "Código de Barras"
        DataGridView1.Columns(1).HeaderCell.Value = "Producto"
        DataGridView1.Columns(2).HeaderCell.Value = "Marca"
        DataGridView1.Columns(3).HeaderCell.Value = "Descripción"
        DataGridView1.Columns(4).HeaderCell.Value = "Ubicación"
        DataGridView1.Columns(5).HeaderCell.Value = "Existencia"
        DataGridView1.Columns(6).HeaderCell.Value = "Costo"
        DataGridView1.Columns(7).HeaderCell.Value = "% De Descuento"


    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Try
            If DataGridView1.CurrentRow.Selected = True Then
                btnmodificar.Enabled = True
                btneliminar.Enabled = True
                Button1.Enabled = True
                Button4.Enabled = True
            Else
                btnmodificar.Enabled = False
                btneliminar.Enabled = False
                Button1.Enabled = False
                Button4.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Parece que aun no hay productos en lista",MsgBoxStyle.Exclamation+vbOKOnly)

        End Try
       End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        aviso.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim productonew As Integer
        Dim consulta As String
        Dim com As MySqlCommand

        Try
            productonew = InputBox("Ingrese el descuento que se efectuará al producto seleccionado (5%, 10%, 15% o 0%)", "Nuevo descuento")
            If productonew <= 0 Then
                productonew = 0
            ElseIf productonew > 100 Then
                MsgBox("El dato ingresado no es válido, el valor debe de estar entre el 0% y 100%", MsgBoxStyle.Critical, "Error de datos")
            End If
            DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value = productonew

        Catch exception As Exception
            MsgBox("El dato ingresado no es válido, verifica que cumpla con los rangos establecidos", MsgBoxStyle.Critical, "Error de datos")
        End Try

        For i = 0 To DataGridView1.Rows.Count - 1
            Label3.Text = CDec(Label3.Text) + (DataGridView1.Item(5, i).Value * DataGridView1.Item(6, i).Value)
            Label4.Text = Label4.Text + DataGridView1.Item(5, i).Value
        Next i

        consulta = "Update productos set Descuent=" & DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value & " where Barcode='" & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value & "'"
        com = New MySqlCommand(consulta, conectar.enlaceBD)
        com.ExecuteNonQuery()
        enlaceBD.Close()

        Call cargagrid()


    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cargagrid()
    End Sub
End Class