<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcuentascliente
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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn = New System.Windows.Forms.Button()
        Me.btncomando = New System.Windows.Forms.Button()
        Me.lbltitpan2 = New System.Windows.Forms.Label()
        Me.lbldespan2 = New System.Windows.Forms.Label()
        Me.txtnommodi = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(38, 108)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(347, 17)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Teclea el nombre del cliente para ver su estado de cuenta"
        '
        'btn
        '
        Me.btn.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn.ForeColor = System.Drawing.Color.White
        Me.btn.Location = New System.Drawing.Point(845, 462)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(131, 55)
        Me.btn.TabIndex = 34
        Me.btn.Text = "&Cancelar"
        Me.btn.UseVisualStyleBackColor = False
        '
        'btncomando
        '
        Me.btncomando.BackColor = System.Drawing.Color.OliveDrab
        Me.btncomando.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btncomando.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncomando.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncomando.ForeColor = System.Drawing.Color.White
        Me.btncomando.Location = New System.Drawing.Point(692, 462)
        Me.btncomando.Name = "btncomando"
        Me.btncomando.Size = New System.Drawing.Size(137, 55)
        Me.btncomando.TabIndex = 33
        Me.btncomando.Text = "&Aceptar"
        Me.btncomando.UseVisualStyleBackColor = False
        '
        'lbltitpan2
        '
        Me.lbltitpan2.AutoSize = True
        Me.lbltitpan2.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitpan2.ForeColor = System.Drawing.Color.Navy
        Me.lbltitpan2.Location = New System.Drawing.Point(25, 13)
        Me.lbltitpan2.Name = "lbltitpan2"
        Me.lbltitpan2.Size = New System.Drawing.Size(388, 65)
        Me.lbltitpan2.TabIndex = 35
        Me.lbltitpan2.Text = "Estado de cuenta"
        '
        'lbldespan2
        '
        Me.lbldespan2.AutoSize = True
        Me.lbldespan2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldespan2.ForeColor = System.Drawing.Color.Gray
        Me.lbldespan2.Location = New System.Drawing.Point(36, 78)
        Me.lbldespan2.Name = "lbldespan2"
        Me.lbldespan2.Size = New System.Drawing.Size(442, 17)
        Me.lbldespan2.TabIndex = 36
        Me.lbldespan2.Text = "Antes de realizar una acción por favor ingrese los datos correspondientes"
        '
        'txtnommodi
        '
        Me.txtnommodi.BackColor = System.Drawing.Color.Lavender
        Me.txtnommodi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnommodi.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnommodi.ForeColor = System.Drawing.Color.Black
        Me.txtnommodi.Location = New System.Drawing.Point(159, 140)
        Me.txtnommodi.Name = "txtnommodi"
        Me.txtnommodi.Size = New System.Drawing.Size(282, 28)
        Me.txtnommodi.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(37, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 30)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Nombre:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(41, 188)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(935, 253)
        Me.DataGridView1.TabIndex = 38
        '
        'frmcuentascliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1007, 538)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.btncomando)
        Me.Controls.Add(Me.lbltitpan2)
        Me.Controls.Add(Me.lbldespan2)
        Me.Controls.Add(Me.txtnommodi)
        Me.Controls.Add(Me.Label14)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmcuentascliente"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado de cuenta de clientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents btncomando As System.Windows.Forms.Button
    Friend WithEvents lbltitpan2 As System.Windows.Forms.Label
    Friend WithEvents lbldespan2 As System.Windows.Forms.Label
    Friend WithEvents txtnommodi As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
