

Module asignaciones
    Dim dat1, dat2, dat3, dat4, dat7, dat8, dat9 As String
    Dim dat6, dat5 As VariantType
    Sub busqueda_client(ByVal datosgrid As DataGridView)
        dat1 = datosgrid.CurrentRow.Cells(0).FormattedValue.ToString 'clave cliente
        dat2 = datosgrid.CurrentRow.Cells(1).FormattedValue.ToString 'nombre
        dat3 = datosgrid.CurrentRow.Cells(2).FormattedValue.ToString 'alias
        dat4 = datosgrid.CurrentRow.Cells(3).FormattedValue.ToString 'direccion
        dat7 = datosgrid.CurrentRow.Cells(4).FormattedValue.ToString 'telefono

        If frmcliente.Visible Then
            'frmcliente.T1.Text = dat1
            ' frmcliente.T2.Text = dat2
            'frmcliente.T3.Text = dat3
            'frmcliente.T5.Text = dat4
            'frmcliente.T6.Text = dat5
        End If

    End Sub
    Sub busqueda_provee(ByVal datosgrid As DataGridView)
        dat1 = datosgrid.CurrentRow.Cells(0).FormattedValue.ToString 'nombre
        dat2 = datosgrid.CurrentRow.Cells(1).FormattedValue.ToString 'dir
        dat3 = datosgrid.CurrentRow.Cells(2).FormattedValue.ToString 'telefono
        dat4 = datosgrid.CurrentRow.Cells(3).FormattedValue.ToString 'rfc
        dat7 = datosgrid.CurrentRow.Cells(4).FormattedValue.ToString 'correo

        If frmprovee.Visible Then
            'frmprovee.txtnom.Text = dat1
            'frmprovee.txtdir.Text = dat2
            'frmprovee.txtel.Text = dat3
            'frmprovee.txtrfc.Text = dat4
            'frmprovee.Txtcorreo.Text = dat5
        End If

    End Sub

    Sub busca_A_producto(ByVal namedata As DataGridView)
        'se asignan los datos a la ventana correspondiente
        dat1 = namedata.CurrentRow.Cells(0).FormattedValue.ToString 'codigo
        dat2 = namedata.CurrentRow.Cells(1).FormattedValue.ToString 'productto
        ' dat3 = namedata.CurrentRow.Cells(2).FormattedValue.ToString 'des
        ' dat4 = namedata.CurrentRow.Cells(3).FormattedValue.ToString 'marca
        ' dat5 = namedata.CurrentRow.Cells(4).FormattedValue 'Precio
        ' dat6 = namedata.CurrentRow.Cells(5).FormattedValue 'existencia
        '  dat7 = namedata.CurrentRow.Cells(6).FormattedValue.ToString 'unidad
        '  dat8 = namedata.CurrentRow.Cells(7).FormattedValue.ToString 'ubicacion

        If frmproducto.Visible = True Then

            '    frmproducto.txtcod.Text = dat1
            '   frmproducto.txtnom.Text = dat2
            frmproducto.txtmarca.Text = dat4
            frmproducto.txtdes.Text = dat3
            frmproducto.numcantidad.Text = dat6

            frmproducto.cbomedida.Text = dat7
            frmproducto.txtsecompra.Text = dat5
            frmproducto.txtsevende.Text = dat7

        ElseIf frmventas.Visible = True Then
            frmventas.txtcod.Text = dat1
        End If



    End Sub
End Module
