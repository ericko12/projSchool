<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcliente))
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btn = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.lbldescribe = New System.Windows.Forms.Label()
        Me.lblcerrar = New System.Windows.Forms.Label()
        Me.btncomando = New System.Windows.Forms.Button()
        Me.PanelProducto = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.T9 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.T8 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.T7 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.T4 = New System.Windows.Forms.TextBox()
        Me.T3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.T6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.T5 = New System.Windows.Forms.TextBox()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.T2 = New System.Windows.Forms.TextBox()
        Me.T1 = New System.Windows.Forms.TextBox()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Panelbusca = New System.Windows.Forms.Panel()
        Me.lbltitpan2 = New System.Windows.Forms.Label()
        Me.lbldespan2 = New System.Windows.Forms.Label()
        Me.txtnommodi = New System.Windows.Forms.TextBox()
        Me.txtcodmodi = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblclasif = New System.Windows.Forms.Label()
        Me.lblnew = New System.Windows.Forms.Label()
        Me.lblmodi = New System.Windows.Forms.Label()
        Me.lblelimina = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelProducto.SuspendLayout()
        Me.Panelbusca.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(27, 131)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(427, 17)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Por favor, inserta el Id. cliente para la busqueda o el nombre del cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 21)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "¿No encuentra al cliente?"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(25, 287)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(280, 21)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Haga Clic aquí para la búsqueda rápida"
        '
        'btn
        '
        Me.btn.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn.ForeColor = System.Drawing.Color.White
        Me.btn.Location = New System.Drawing.Point(472, 381)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(131, 55)
        Me.btn.TabIndex = 9
        Me.btn.Text = "&Cancelar"
        Me.btn.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Location = New System.Drawing.Point(472, 467)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(131, 55)
        Me.btncancel.TabIndex = 13
        Me.btncancel.Text = "&Cancelar"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.OliveDrab
        Me.btnaceptar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.White
        Me.btnaceptar.Location = New System.Drawing.Point(321, 467)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(137, 55)
        Me.btnaceptar.TabIndex = 12
        Me.btnaceptar.Text = "&Guardar"
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'lbldescribe
        '
        Me.lbldescribe.AutoSize = True
        Me.lbldescribe.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescribe.ForeColor = System.Drawing.Color.MistyRose
        Me.lbldescribe.Location = New System.Drawing.Point(26, 69)
        Me.lbldescribe.Name = "lbldescribe"
        Me.lbldescribe.Size = New System.Drawing.Size(159, 17)
        Me.lbldescribe.TabIndex = 14
        Me.lbldescribe.Text = "Nuevo registro de cliente."
        '
        'lblcerrar
        '
        Me.lblcerrar.AutoSize = True
        Me.lblcerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblcerrar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcerrar.ForeColor = System.Drawing.Color.MistyRose
        Me.lblcerrar.Location = New System.Drawing.Point(44, 434)
        Me.lblcerrar.Name = "lblcerrar"
        Me.lblcerrar.Size = New System.Drawing.Size(69, 30)
        Me.lblcerrar.TabIndex = 4
        Me.lblcerrar.Text = "Cerrar"
        '
        'btncomando
        '
        Me.btncomando.BackColor = System.Drawing.Color.OliveDrab
        Me.btncomando.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btncomando.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncomando.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncomando.ForeColor = System.Drawing.Color.White
        Me.btncomando.Location = New System.Drawing.Point(317, 381)
        Me.btncomando.Name = "btncomando"
        Me.btncomando.Size = New System.Drawing.Size(137, 55)
        Me.btncomando.TabIndex = 8
        Me.btncomando.Text = "&Aceptar"
        Me.btncomando.UseVisualStyleBackColor = False
        '
        'PanelProducto
        '
        Me.PanelProducto.Controls.Add(Me.Label9)
        Me.PanelProducto.Controls.Add(Me.T9)
        Me.PanelProducto.Controls.Add(Me.Label8)
        Me.PanelProducto.Controls.Add(Me.T8)
        Me.PanelProducto.Controls.Add(Me.Label4)
        Me.PanelProducto.Controls.Add(Me.T7)
        Me.PanelProducto.Controls.Add(Me.Label3)
        Me.PanelProducto.Controls.Add(Me.T4)
        Me.PanelProducto.Controls.Add(Me.T3)
        Me.PanelProducto.Controls.Add(Me.Label1)
        Me.PanelProducto.Controls.Add(Me.btncancel)
        Me.PanelProducto.Controls.Add(Me.btnaceptar)
        Me.PanelProducto.Controls.Add(Me.Label7)
        Me.PanelProducto.Controls.Add(Me.T6)
        Me.PanelProducto.Controls.Add(Me.Label6)
        Me.PanelProducto.Controls.Add(Me.T5)
        Me.PanelProducto.Controls.Add(Me.lbltitulo)
        Me.PanelProducto.Controls.Add(Me.lbldescribe)
        Me.PanelProducto.Controls.Add(Me.T2)
        Me.PanelProducto.Controls.Add(Me.T1)
        Me.PanelProducto.Controls.Add(Me.lblpass)
        Me.PanelProducto.Controls.Add(Me.lbl1)
        Me.PanelProducto.Location = New System.Drawing.Point(427, 229)
        Me.PanelProducto.Name = "PanelProducto"
        Me.PanelProducto.Size = New System.Drawing.Size(623, 566)
        Me.PanelProducto.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(23, 383)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(188, 30)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Correo Electrónico:"
        '
        'T9
        '
        Me.T9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.T9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.T9.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T9.ForeColor = System.Drawing.Color.Black
        Me.T9.Location = New System.Drawing.Point(217, 383)
        Me.T9.Name = "T9"
        Me.T9.Size = New System.Drawing.Size(211, 28)
        Me.T9.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(20, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 30)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "RFC:"
        '
        'T8
        '
        Me.T8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.T8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.T8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T8.ForeColor = System.Drawing.Color.Black
        Me.T8.Location = New System.Drawing.Point(143, 145)
        Me.T8.Name = "T8"
        Me.T8.Size = New System.Drawing.Size(282, 28)
        Me.T8.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 30)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "*Teléfonos:"
        '
        'T7
        '
        Me.T7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.T7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.T7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T7.ForeColor = System.Drawing.Color.Black
        Me.T7.Location = New System.Drawing.Point(144, 349)
        Me.T7.Name = "T7"
        Me.T7.Size = New System.Drawing.Size(136, 28)
        Me.T7.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 30)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Colonia:"
        '
        'T4
        '
        Me.T4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.T4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.T4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T4.ForeColor = System.Drawing.Color.Black
        Me.T4.Location = New System.Drawing.Point(143, 248)
        Me.T4.Name = "T4"
        Me.T4.Size = New System.Drawing.Size(283, 28)
        Me.T4.TabIndex = 7
        '
        'T3
        '
        Me.T3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.T3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.T3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T3.ForeColor = System.Drawing.Color.Black
        Me.T3.Location = New System.Drawing.Point(143, 213)
        Me.T3.Name = "T3"
        Me.T3.Size = New System.Drawing.Size(282, 28)
        Me.T3.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 30)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Dirección:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(20, 317)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 30)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "*Código Postal:"
        '
        'T6
        '
        Me.T6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.T6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.T6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T6.ForeColor = System.Drawing.Color.Black
        Me.T6.Location = New System.Drawing.Point(181, 316)
        Me.T6.Name = "T6"
        Me.T6.Size = New System.Drawing.Size(136, 28)
        Me.T6.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(21, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 30)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Población:"
        '
        'T5
        '
        Me.T5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.T5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.T5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T5.ForeColor = System.Drawing.Color.Black
        Me.T5.Location = New System.Drawing.Point(143, 283)
        Me.T5.Name = "T5"
        Me.T5.Size = New System.Drawing.Size(282, 28)
        Me.T5.TabIndex = 8
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.White
        Me.lbltitulo.Location = New System.Drawing.Point(18, 4)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(535, 65)
        Me.lbltitulo.TabIndex = 13
        Me.lbltitulo.Text = "Nueva cuenta de cliente"
        '
        'T2
        '
        Me.T2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.T2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.T2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T2.ForeColor = System.Drawing.Color.Black
        Me.T2.Location = New System.Drawing.Point(144, 179)
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(282, 28)
        Me.T2.TabIndex = 5
        '
        'T1
        '
        Me.T1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.T1.Enabled = False
        Me.T1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T1.ForeColor = System.Drawing.Color.Black
        Me.T1.Location = New System.Drawing.Point(144, 107)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(168, 28)
        Me.T1.TabIndex = 5
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpass.ForeColor = System.Drawing.Color.White
        Me.lblpass.Location = New System.Drawing.Point(21, 178)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(94, 30)
        Me.lblpass.TabIndex = 7
        Me.lblpass.Text = "Nombre:"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(22, 106)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(111, 30)
        Me.lbl1.TabIndex = 8
        Me.lbl1.Text = "Id. Cliente:"
        '
        'Panelbusca
        '
        Me.Panelbusca.Controls.Add(Me.lbltitpan2)
        Me.Panelbusca.Controls.Add(Me.LinkLabel1)
        Me.Panelbusca.Controls.Add(Me.Label2)
        Me.Panelbusca.Controls.Add(Me.Label16)
        Me.Panelbusca.Controls.Add(Me.btn)
        Me.Panelbusca.Controls.Add(Me.btncomando)
        Me.Panelbusca.Controls.Add(Me.lbldespan2)
        Me.Panelbusca.Controls.Add(Me.txtnommodi)
        Me.Panelbusca.Controls.Add(Me.txtcodmodi)
        Me.Panelbusca.Controls.Add(Me.Label14)
        Me.Panelbusca.Controls.Add(Me.Label15)
        Me.Panelbusca.Location = New System.Drawing.Point(424, 249)
        Me.Panelbusca.Name = "Panelbusca"
        Me.Panelbusca.Size = New System.Drawing.Size(623, 455)
        Me.Panelbusca.TabIndex = 33
        Me.Panelbusca.Visible = False
        '
        'lbltitpan2
        '
        Me.lbltitpan2.AutoSize = True
        Me.lbltitpan2.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitpan2.ForeColor = System.Drawing.Color.White
        Me.lbltitpan2.Location = New System.Drawing.Point(15, 4)
        Me.lbltitpan2.Name = "lbltitpan2"
        Me.lbltitpan2.Size = New System.Drawing.Size(411, 65)
        Me.lbltitpan2.TabIndex = 13
        Me.lbltitpan2.Text = "Búsqueda exacta..."
        '
        'lbldespan2
        '
        Me.lbldespan2.AutoSize = True
        Me.lbldespan2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldespan2.ForeColor = System.Drawing.Color.MistyRose
        Me.lbldespan2.Location = New System.Drawing.Point(26, 69)
        Me.lbldespan2.Name = "lbldespan2"
        Me.lbldespan2.Size = New System.Drawing.Size(442, 17)
        Me.lbldespan2.TabIndex = 14
        Me.lbldespan2.Text = "Antes de realizar una acción por favor ingresa los datos correspondientes"
        '
        'txtnommodi
        '
        Me.txtnommodi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnommodi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnommodi.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnommodi.ForeColor = System.Drawing.Color.Black
        Me.txtnommodi.Location = New System.Drawing.Point(148, 204)
        Me.txtnommodi.Name = "txtnommodi"
        Me.txtnommodi.Size = New System.Drawing.Size(282, 28)
        Me.txtnommodi.TabIndex = 6
        '
        'txtcodmodi
        '
        Me.txtcodmodi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcodmodi.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodmodi.ForeColor = System.Drawing.Color.Black
        Me.txtcodmodi.Location = New System.Drawing.Point(148, 170)
        Me.txtcodmodi.Name = "txtcodmodi"
        Me.txtcodmodi.Size = New System.Drawing.Size(282, 28)
        Me.txtcodmodi.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(25, 195)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 30)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Nombre:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(26, 168)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 30)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Id. Cliente:"
        '
        'lblclasif
        '
        Me.lblclasif.AutoSize = True
        Me.lblclasif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblclasif.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclasif.ForeColor = System.Drawing.Color.LightSalmon
        Me.lblclasif.Location = New System.Drawing.Point(44, 282)
        Me.lblclasif.Name = "lblclasif"
        Me.lblclasif.Size = New System.Drawing.Size(0, 30)
        Me.lblclasif.TabIndex = 31
        '
        'lblnew
        '
        Me.lblnew.AutoSize = True
        Me.lblnew.BackColor = System.Drawing.Color.Transparent
        Me.lblnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblnew.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnew.ForeColor = System.Drawing.Color.MistyRose
        Me.lblnew.Location = New System.Drawing.Point(44, 310)
        Me.lblnew.Name = "lblnew"
        Me.lblnew.Size = New System.Drawing.Size(145, 30)
        Me.lblnew.TabIndex = 1
        Me.lblnew.Text = "Nueva Cuenta"
        '
        'lblmodi
        '
        Me.lblmodi.AutoSize = True
        Me.lblmodi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblmodi.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodi.ForeColor = System.Drawing.Color.MistyRose
        Me.lblmodi.Location = New System.Drawing.Point(44, 349)
        Me.lblmodi.Name = "lblmodi"
        Me.lblmodi.Size = New System.Drawing.Size(256, 30)
        Me.lblmodi.TabIndex = 2
        Me.lblmodi.Text = "Modificar datos de cuenta"
        '
        'lblelimina
        '
        Me.lblelimina.AutoSize = True
        Me.lblelimina.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblelimina.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblelimina.ForeColor = System.Drawing.Color.MistyRose
        Me.lblelimina.Location = New System.Drawing.Point(44, 391)
        Me.lblelimina.Name = "lblelimina"
        Me.lblelimina.Size = New System.Drawing.Size(138, 30)
        Me.lblelimina.TabIndex = 3
        Me.lblelimina.Text = "Borrar cuenta"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(1161, -21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(206, 223)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(576, 682)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'frmcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1325, 772)
        Me.Controls.Add(Me.Panelbusca)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblcerrar)
        Me.Controls.Add(Me.lblclasif)
        Me.Controls.Add(Me.lblnew)
        Me.Controls.Add(Me.lblmodi)
        Me.Controls.Add(Me.lblelimina)
        Me.Controls.Add(Me.PanelProducto)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmcliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmcliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelProducto.ResumeLayout(False)
        Me.PanelProducto.PerformLayout()
        Me.Panelbusca.ResumeLayout(False)
        Me.Panelbusca.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents lbldescribe As System.Windows.Forms.Label
    Friend WithEvents lblcerrar As System.Windows.Forms.Label
    Friend WithEvents btncomando As System.Windows.Forms.Button
    Friend WithEvents PanelProducto As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents T6 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents T5 As System.Windows.Forms.TextBox
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbltitpan2 As System.Windows.Forms.Label
    Friend WithEvents lbldespan2 As System.Windows.Forms.Label
    Friend WithEvents txtnommodi As System.Windows.Forms.TextBox
    Friend WithEvents txtcodmodi As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblclasif As System.Windows.Forms.Label
    Friend WithEvents Panelbusca As System.Windows.Forms.Panel
    Friend WithEvents lblnew As System.Windows.Forms.Label
    Friend WithEvents lblmodi As System.Windows.Forms.Label
    Friend WithEvents lblelimina As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents T3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents T4 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents T9 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents T8 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents T7 As System.Windows.Forms.TextBox
End Class
