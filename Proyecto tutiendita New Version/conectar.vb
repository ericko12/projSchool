Imports System.Data.SqlClient
Imports System.Data
Imports MySql.Data.MySqlClient

Module conectar
    Public Conexion As MySqlConnection
    Public p1 As Byte
    Public Function enlaceBD() As MySqlConnection
        Dim dire As String = Application.StartupPath + "\config.ini"
        Dim sr As New System.IO.StreamReader(dire)
        Conexion = New MySqlConnection
        Conexion.ConnectionString = (sr.ReadToEnd)
        sr.Close()
        Conexion.Open()
        Return conexion
    End Function
    Public Function stblcpmt() As Byte
        Try
            Dim qry As String = "SELECT * FROM cfgrcn"
            Dim comando As New MySqlCommand(qry, conectar.enlaceBD)
            Dim lector As MySqlDataReader

            lector = comando.ExecuteReader()
            lector.Read()
            enlaceBD.Close()

            If Not lector.HasRows Then
                frmprimeravez.ShowDialog()
                p1 = 0
            Else
                rep1 = lector(1).ToString
                rep2 = lector(2).ToString
                impresora = lector(3).ToString
                HC = lector(4).ToString
                HA = lector(5).ToString
                If lector(6) = 1 Then
                    edoC = True
                Else
                    edoC = False
                End If
                p1 = 1
            End If
        Catch er As Exception
            MsgBox("Error de datos en la BD, verifique los tipos de datos de la BD con el fabricante del producto ", MsgBoxStyle.Critical)
        End Try
        Return p1
    End Function
End Module
