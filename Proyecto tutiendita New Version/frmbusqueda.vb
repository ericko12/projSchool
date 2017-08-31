Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class frmbusqueda
    Public instru As String 'es la consulta que recibe de otros formularios
    Dim evento As New KeyEventArgs(Keys.Enter) 'para ejecutar un evento sin tener que dar clic


    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Escape
                matabusca()
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub frmbusqueda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ventana As New ventanactiva 'se hereda una funcion
        'se ejecuta la función para ver qué ventana está activa, según la ventana
        'se cambia la consulta para buscar por nombre o por codigo
        If ventana.activa(frmpantallainicio) = True And ventana.activa(frmcliente) = False And ventana.activa(frmprovee) = False Then
            instru = "Select Barcode, NomProd, descrip, Marca, Precio, Existencia, Unidad, Ubicacion from Productos"
            casos(0)
            indicaciones(1)
            LlenaGrid(instru)
        ElseIf ventana.activa(frmproducto) Then
            instru = "Select Barcode, NomProd, descrip, Marca, Precio, Existencia, Unidad, Ubicacion from Productos"
            If frmproducto.lbltitulo.Text = "Modificar Producto" Then
                casos(1)
            Else
                casos(0)
            End If
            indicaciones(1)
            LlenaGrid(instru)
        ElseIf ventana.activa(frmcliente) Then
            instru = "SELECT * FROM vistaclientes"
            If frmcliente.lbltitulo.Text = "Modificar cuenta de Cliente" Then
                casos(0)
            Else
                casos(0)
            End If
            indicaciones(2)
            LlenaGrid(instru)
        ElseIf ventana.activa(frmprovee) Then
            instru = "SELECT * FROM vistaproveedor"
            If frmprovee.lbltitulo.Text = "Modificar Proveedor" Then
                casos(0)
            Else
                casos(0)
            End If
            indicaciones(3)
            LlenaGrid(instru)
        Else
            btneliminar.Visible = False
            btnmodificar.Visible = False
            btnAceptar.Visible = True
            instru = "Select * from Productos"
            LlenaGrid(instru)
        End If

        freememoria.ClearMemory()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        matabusca()
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        'según el origen de ventana habilita objetos
        matabusca()
        Select Case lblventana.Text
            Case "Producto"
                ' frmproducto.MdiParent = MDIInicial
                frmproducto.Show()

                frmproducto.lblelimina_Click(Nothing, evento)
                frmproducto.Panelbusca.Visible = False
                frmproducto.PanelProducto.Visible = True
            Case "Cliente"
                ' frmcliente.MdiParent = MDIInicial
                frmcliente.Show()
                frmcliente.lblelimina_Click(Nothing, evento)
                frmcliente.Panelbusca.Visible = False
                frmcliente.PanelProducto.Visible = True
            Case "Proveedor"
                'frmprovee.MdiParent = MDIInicial
        End Select
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        Dim ventana As New ventanactiva
        If ventana.activa(frmpantallainicio) = True And ventana.activa(frmcliente) = False Then
            instru = "Select Barcode, NomProd, descrip, Marca, Precio, Existencia, Unidad, Ubicacion from Productos"
        ElseIf ventana.activa(frmproducto) Then
            frmproducto.Show()
            frmproducto.lblmodi_Click(Nothing, evento)
            frmproducto.Panelbusca.Visible = False
            frmproducto.PanelProducto.Visible = True
        ElseIf ventana.activa(frmcliente) Then
            frmcliente.Show()
            frmcliente.lblmodi_Click(Nothing, evento)
            frmcliente.txtcodmodi.Text = DataGridView1.CurrentRow.Cells(0).FormattedValue.ToString
            frmcliente.Button2_Click(Nothing, evento)
            frmcliente.Panelbusca.Visible = False
            frmcliente.PanelProducto.Visible = True
        End If
        matabusca()
    End Sub

    Private Sub txtnom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnom.TextChanged

        asignaquery(Me.Name)
        instru = devquery() + txtnom.Text + "%'"
        LlenaGrid(instru)
        freememoria.ClearMemory()
    End Sub

    Private Sub txtnom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnom.KeyPress
        'no permite que en la busqueda se filtren caracteres ' y % ya que la consulta arrojaria error
        If InStr(1, "'%" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub

    Public Sub LlenaGrid(ByVal instruccion As String)
        'procedimiento que llena el datagridview1
        Dim da As New MySqlDataAdapter(instruccion, conectar.enlaceBD)
        Dim ventana As New ventanactiva
        Dim ds As New DataSet
        da.Fill(ds)

        If ventana.activa(frmpantallainicio) = True And ventana.activa(frmcliente) = False And ventana.activa(frmprovee) = False Then
            titulosgrid(1, ds)
        ElseIf ventana.activa(frmproducto) = True Then
            titulosgrid(1, ds)
        ElseIf ventana.activa(frmventas) Then
            titulosgrid(1, ds)
        ElseIf ventana.activa(frmcliente) Then
            titulosgrid(2, ds)
        ElseIf ventana.activa(frmprovee) Then
            titulosgrid(3, ds)
        End If

    End Sub

    Sub titulosgrid(ByVal parametro As SByte, ByVal ds As DataSet)

        Select Case parametro
            Case 1
                DataGridView1.DataSource = ds.Tables(0)
                DataGridView1.Columns(0).HeaderCell.Value = "Código de Barras"
                DataGridView1.Columns(1).HeaderCell.Value = "Producto"
                DataGridView1.Columns(2).HeaderCell.Value = "Descripción"
                DataGridView1.Columns(3).HeaderCell.Value = "Marca"
                DataGridView1.Columns(4).HeaderCell.Value = "Precio"
                DataGridView1.Columns(5).HeaderCell.Value = "Existencia"
                DataGridView1.Columns(6).HeaderCell.Value = "Unidad"
                DataGridView1.Columns(7).HeaderCell.Value = "Ubicación"
            Case 2
                DataGridView1.DataSource = ds.Tables(0)
                DataGridView1.Columns(0).HeaderCell.Value = "idCte"
                DataGridView1.Columns(1).HeaderCell.Value = "RFC"
                DataGridView1.Columns(2).HeaderCell.Value = "Nombre"
                DataGridView1.Columns(3).HeaderCell.Value = "Domicilio"
                DataGridView1.Columns(4).HeaderCell.Value = "Colonia"
                DataGridView1.Columns(5).HeaderCell.Value = "CP"
                DataGridView1.Columns(6).HeaderCell.Value = "Población"
                DataGridView1.Columns(7).HeaderCell.Value = "Teléfono"
                DataGridView1.Columns(8).HeaderCell.Value = "Afiliación"
                DataGridView1.Columns(9).HeaderCell.Value = "Email"
            Case 3
                DataGridView1.DataSource = ds.Tables(0)
                DataGridView1.Columns(0).HeaderCell.Value = "Nombre"
                DataGridView1.Columns(1).HeaderCell.Value = "Direccion"
                DataGridView1.Columns(2).HeaderCell.Value = "Teléfono"
                DataGridView1.Columns(3).HeaderCell.Value = "RFC"
                DataGridView1.Columns(4).HeaderCell.Value = "Correo electrónico"
        End Select
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
       
    End Sub

   
    Sub indicaciones(ByVal caso As SByte)
        Select Case caso
            Case 1
                lbldescribe.Text = "Escriba las primeras letras o el código de barras del producto"
            Case 2
                lbldescribe.Text = "Escriba las primeras letras o el id del cliente"
            Case 3
                lbldescribe.Text = "Escriba las primeras letras o el id del proveedor"
        End Select
    End Sub

    Sub casos(ByVal opciones As SByte)
        Select Case opciones
            Case 0 'Boton aceptar y cancelar
                btneliminar.Visible = False
                btnmodificar.Visible = False
                btnAceptar.Visible = True
            Case 1 'Boton modificar y cancelar
                btneliminar.Visible = False
                btnmodificar.Visible = True
                btnAceptar.Visible = False
            Case 2 'Boton eliminar y cancelar
                btneliminar.Visible = False
                btnmodificar.Visible = True
                btnAceptar.Visible = False
        End Select
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim vtn As New ventanactiva
        querys.asignaquery(Me.Name)
        If vtn.activa(frmpantallainicio) = True And vtn.activa(frmcliente) = False And vtn.activa(frmprovee) = False Then
            busca_A_producto(DataGridView1)
        ElseIf vtn.activa(frmproducto) Then
            busca_A_producto(DataGridView1)
        ElseIf vtn.activa(frmcliente) Then
            busqueda_client(DataGridView1)
        End If
        If btnmodificar.Visible = True And frmproducto.lbltitulo.Text <> "Nuevo Producto" Then
            asignaciones.busca_A_producto(DataGridView1)
            btnmodificar_Click(Nothing, evento)
            matabusca()
        ElseIf btneliminar.Visible = True And frmproducto.lbltitulo.Text <> "Nuevo Producto" Then
            asignaciones.busca_A_producto(DataGridView1)
            btneliminar_Click(Nothing, evento)
            matabusca()
        ElseIf btnAceptar.Visible = True And frmventas.Visible = True Then
            asignaciones.busca_A_producto(DataGridView1)
            frmventas.agregar_Click(Nothing, evento)
            matabusca()
        End If

        If frmproducto.Visible = True And frmproducto.Panelbusca.Visible = True Then
            frmproducto.txtcodmodi.Text = DataGridView1.CurrentRow.Cells(0).FormattedValue.ToString
            matabusca()

        End If

        If frmcliente.Visible = True And frmcliente.Panelbusca.Visible = True Then
            frmcliente.txtcodmodi.Text = DataGridView1.CurrentRow.Cells(0).FormattedValue.ToString
            matabusca()

        End If

        If frmprovee.Visible = True And frmprovee.Panelbusca.Visible = True Then
            'frmprovee.txtcodmodi.Text = DataGridView1.CurrentRow.Cells(0).FormattedValue.ToString
            matabusca()

        End If

        freememoria.ClearMemory()
        matabusca()
    End Sub

  

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        Dim ventana As New ventanactiva
        querys.asignaquery(Me.Name)
        ' este toma del data grid y envia al formulario
        ' hay que hacer otro caso de asignación al formulario y nuevamente usar nuestro codigo chingón de ventanas activas...
        If ventana.activa(frmpantallainicio) = True And ventana.activa(frmcliente) = False And ventana.activa(frmprovee) = False Then
            busca_A_producto(DataGridView1)
        ElseIf ventana.activa(frmproducto) Then
            busca_A_producto(DataGridView1)
        ElseIf ventana.activa(frmcliente) Then
            busqueda_client(DataGridView1)
        ElseIf ventana.activa(frmprovee) Then
            busqueda_provee(DataGridView1)
        End If




        If btnmodificar.Visible = True And frmproducto.lbltitulo.Text <> "Nuevo Producto" Then
            asignaciones.busca_A_producto(DataGridView1)
            btnmodificar_Click(Nothing, evento)
            matabusca()
        ElseIf btneliminar.Visible = True And frmproducto.lbltitulo.Text <> "Nuevo Producto" Then
            asignaciones.busca_A_producto(DataGridView1)
            btneliminar_Click(Nothing, evento)
            matabusca()
        ElseIf btnAceptar.Visible = True And frmventas.Visible = True Then
            asignaciones.busca_A_producto(DataGridView1)
            frmventas.agregar_Click(Nothing, evento)
            matabusca()
        End If

        If frmproducto.Visible = True And frmproducto.Panelbusca.Visible = True Then
            frmproducto.txtcodmodi.Text = DataGridView1.CurrentRow.Cells(0).FormattedValue.ToString
            matabusca()

        End If

        If frmcliente.Visible = True And frmcliente.Panelbusca.Visible = True Then
            frmcliente.txtcodmodi.Text = DataGridView1.CurrentRow.Cells(0).FormattedValue.ToString
            matabusca()
        End If

        If frmprovee.Visible = True And frmprovee.Panelbusca.Visible = True Then
            frmprovee.txtnommodi.Text = DataGridView1.CurrentRow.Cells(0).FormattedValue.ToString
            matabusca()
        End If

        freememoria.ClearMemory()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class