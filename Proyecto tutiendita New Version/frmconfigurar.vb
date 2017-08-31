Imports MySql.Data.MySqlClient

Public Class frmconfigurar

    Dim evento As New KeyEventArgs(Keys.Enter) 'para ejecutar un evento sin tener que dar clic
    Dim bandera As Integer
    Dim consulta As String
    Private Sub frmconfigurar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarData()
      
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ventana As New ventanactiva

        

        HA = DateTimePicker3.Text & ":00"
        HC = DateTimePicker1.Text & ":00"
        rep1 = tckvta.Text.Replace("\", "\\")
        rep2 = tckcrd.Text.Replace("\", "\\")
        Dim com As MySqlCommand

        If tckcrd.Text = "" Or tckvta.Text = "" Then
            MsgBox("Es necesario completar todos los campos para ingresar o modificar los datos", vbCritical, "Error de configuración")
        Else
            If ventana.activa(frmprimeravez) = True Then
                consulta = "INSERT INTO `cfgrcn`( `TCK_VT`, `TCK_CT`, `PRINT`, `HC`, `HA`, `HABCAJ`) VALUES ('" & rep1 & "','" & rep2 & "','" & impresora & "', '" & HC & "', '" & HA & "', " & If(CheckBox1.Checked = True, "1", "0") & ")"
            Else
                consulta = "Update cfgrcn set TCK_VT='" & rep1 & "', TCK_CT='" & rep2 & "', PRINT='" & impresora & "', HC='" & HC & "',  HA='" & HA & "', HABCAJ=" & If(CheckBox1.Checked = True, "1", "0") & " where idCF=" & 1
            End If
            com = New MySqlCommand(consulta, conectar.enlaceBD)
            com.ExecuteNonQuery()
            enlaceBD.Close()
            Dialogo.Label3.Text = "GUARDANDO CONFIGURACIONES " & TextBox1.Text & " "
            Dialogo.Show()

        End If


        Button2_Click(Nothing, evento)
    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        tips.balon(TextBox1, "Recuerda...", "Este campo no puede estar vacío, elije una opción")
    End Sub

    Private Sub TextBox2_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        tips.balon(TextBox2, "Recuerda...", "Este campo no puede estar vacío, elije una opción")
    End Sub
    Private Sub TextBox3_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        tips.balon(TextBox3, "Recuerda...", "Este campo no puede estar vacío, elije una opción")
    End Sub
    Private Sub TextBox4_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        tips.balon(TextBox4, "Recuerda...", "Este campo no puede estar vacío, elije una opción")
    End Sub
    Private Sub TextBox5_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        tips.balon(TextBox5, "Recuerda...", "Este campo no puede estar vacío, elije una opción")
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Label10.Text = "Escriba el nombre de usuario con el que entrará al programa " & TextBox1.Text & " y una contraseña."
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).FormattedValue.ToString
        TextBox2.Text = DataGridView1.CurrentRow.Cells(2).FormattedValue.ToString
        TextBox3.Text = DataGridView1.CurrentRow.Cells(3).FormattedValue.ToString
        TextBox4.Text = DataGridView1.CurrentRow.Cells(4).FormattedValue.ToString
        With TextBox5
            .Text = "Haz click para cambiar la contraseña"
            .Font = New Font(TextBox5.Font, FontStyle.Italic)
            .ForeColor = Color.DarkGray
            .PasswordChar = ""
        End With

        Button4.Enabled = False
        bandera = 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim com As MySqlCommand
        If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" And TextBox5.Text = "" Then
            MsgBox("Es necesario completar todos los campos para ingresar o modificar los datos", vbCritical, "Error al ingresar usuario")
        Else
            Button3.Enabled = True
            If bandera <> 1 Then
                consulta = "insert into empleados (`nomEmp`, `fecIngreso`, `domEmpl`, `telEmpe`, `idSuc`, `user`, `pwd`) values ('" & TextBox1.Text & "', now(), '" & TextBox2.Text & "','" & TextBox3.Text & "'," & suc & ",'" & TextBox4.Text & "',SHA('" & TextBox5.Text & "'));"
                com = New MySqlCommand(consulta, conectar.enlaceBD)
                com.ExecuteNonQuery()
                enlaceBD.Close()
                Dialogo.Label3.Text = "GUARDANDO " & TextBox1.Text & " "
                Dialogo.Show()
                limpiar()
                cargarData()

            Else
                If TextBox5.Text = "Haz click para cambiar la contraseña" Then
                    consulta = "Update empleados set nomEmp='" & TextBox1.Text & "', domEmpl='" & TextBox2.Text & "', telEmpe='" & TextBox3.Text & "', user='" & TextBox4.Text & "' where idEmp=" & DataGridView1.CurrentRow.Cells(6).FormattedValue.ToString
                Else
                    consulta = "Update empleados set nomEmp='" & TextBox1.Text & "', domEmpl='" & TextBox2.Text & "', telEmpe='" & TextBox3.Text & "', user='" & TextBox4.Text & "',pwd=SHA('" & TextBox5.Text & "') where idEmp=" & DataGridView1.CurrentRow.Cells(6).FormattedValue.ToString
                End If
                com = New MySqlCommand(consulta, conectar.enlaceBD)
                com.ExecuteNonQuery()
                enlaceBD.Close()
                Dialogo.Label3.Text = "MODIFICANDO " & TextBox1.Text & " "
                Dialogo.Show()
                limpiar()
                cargarData()
                bandera = 0

            End If
        End If

    End Sub


    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        If DataGridView1.CurrentRow.Selected = True Then
            Button4.Enabled = True
            Button5.Enabled = True
        Else
            Button4.Enabled = False
            Button5.Enabled = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim consulta As String
        Dim com As MySqlCommand
        consulta = "Delete from empleados where idEmp='" + DataGridView1.CurrentRow.Cells(6).FormattedValue.ToString + "'"
        com = New MySqlCommand(consulta, conectar.enlaceBD)
        com.ExecuteNonQuery()
        enlaceBD.Close()
        MsgBox("Empleado Eliminado", MsgBoxStyle.Information, "Empleado eliminado")
        Button5.Enabled = False
        limpiar()
        cargarData()

    End Sub

    Private Sub limpiar()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        With TextBox5
            .Text = ""
            .Font = New Font(TextBox5.Font, FontStyle.Regular)
            .ForeColor = Color.Black
            .PasswordChar = "●"
        End With
    End Sub

    Sub cargarData()
        Dim ds As New DataSet
        Dim instruccion As String = "select nomEmp, fecIngreso, domempl, telEmpe, user, pwd, idEmp from empleados;"
        Dim da As New MySqlDataAdapter(instruccion, conectar.enlaceBD)
        Dim com As MySqlCommand
        Dim resp As Integer


        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns("nomEmp").HeaderCell.Value = "Nombre"
        DataGridView1.Columns("FecIngreso").HeaderCell.Value = "Fecha de Alta"
        DataGridView1.Columns("domempl").HeaderCell.Value = "Domicilio"
        DataGridView1.Columns("telEmpe").HeaderCell.Value = "Teléfono"
        DataGridView1.Columns("user").HeaderCell.Value = "Usuario"
        DataGridView1.Columns("pwd").Visible = False
        DataGridView1.Columns("idEmp").Visible = False

        Try
            consulta = "Select * from cfgrcn"
            com = New MySqlCommand(consulta, conectar.enlaceBD)
            Dim lector As MySqlDataReader
            lector = com.ExecuteReader()
            lector.Read()
            
            If lector.HasRows = True Then
                Dim hr As New String(lector(5).ToString)
                hr = hr.Remove(5, 3)
                DateTimePicker3.Text = hr
                hr = New String(lector(4).ToString)
                hr = hr.Remove(5, 3)
                DateTimePicker1.Text = hr
                If lector(6) = 1 Then CheckBox1.Checked = True
                tckvta.Text = lector(1).ToString
                tckcrd.Text = lector(2).ToString
                impresora = lector(3).ToString
            End If

        Catch men As Exception
            MsgBox("Vaya!! al parecer uno de los formatos de la Base de datos se ha corrompido...", MsgBoxStyle.Exclamation, "Mi Negocio")
        End Try
        enlaceBD.Close()
    End Sub

    Private Sub TextBox5_GotFocus(sender As Object, e As EventArgs) Handles TextBox5.GotFocus
        With TextBox5
            .Text = ""
            .Font = New Font(TextBox5.Font, FontStyle.Regular)
            .ForeColor = Color.Black
            .PasswordChar = "●"
        End With
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        frmcompras.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox1.CheckState = True Then
            edoC = True
        Else
            edoC = False
        End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dim dialogoprint As DialogResult = PrintDialog1.ShowDialog
        impresora = PrintDialog1.PrinterSettings.PrinterName
    End Sub

    Private Sub tckvta_Click(sender As Object, e As EventArgs) Handles tckvta.Click
        bscrpt()
        tckvta.Text = OpenFileDialog1.FileName
        rep1 = tckvta.Text
    End Sub

    Sub bscrpt()
        OpenFileDialog1.Filter = "Reportes de Crystal Reports (*.rpt)|*.rpt"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub tckcrd_Click(sender As Object, e As EventArgs) Handles tckcrd.Click
        bscrpt()
        tckcrd.Text = OpenFileDialog1.FileName
        rep2 = tckcrd.Text
    End Sub

  
    
    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = 1 Then
            edoC = True
        Else
            edoC = False
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub tckvta_TextChanged(sender As Object, e As EventArgs) Handles tckvta.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If DateTimePicker1.Text < DateTimePicker3.Text Then
            MsgBox("La hora de cierre es menor a la hora de apertura. Proporcione un horario valido por ejemplo: Si su negocio abre a las 9:00 a.m. y cierra a las 5:00 p.m. teclee 'Hora de apertura: 9:00 - Hora de cierre: 17:00'", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            DateTimePicker1.Focus()
        End If
    End Sub
End Class