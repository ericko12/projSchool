<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcodigo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.lbldescribe = New System.Windows.Forms.Label()
        Me.txtdatatoencode = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtbarcode = New System.Windows.Forms.TextBox()
        Me.txtencodetext = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(518, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 55)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "&Crear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.Navy
        Me.lbltitulo.Location = New System.Drawing.Point(13, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(581, 47)
        Me.lbltitulo.TabIndex = 76
        Me.lbltitulo.Text = "Creando un nuevo código de barras"
        '
        'lbldescribe
        '
        Me.lbldescribe.AutoSize = True
        Me.lbldescribe.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescribe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbldescribe.Location = New System.Drawing.Point(21, 77)
        Me.lbldescribe.Name = "lbldescribe"
        Me.lbldescribe.Size = New System.Drawing.Size(384, 17)
        Me.lbldescribe.TabIndex = 77
        Me.lbldescribe.Text = "Ingrese la clave nueva para el código de barras de su producto."
        '
        'txtdatatoencode
        '
        Me.txtdatatoencode.BackColor = System.Drawing.Color.Lavender
        Me.txtdatatoencode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdatatoencode.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdatatoencode.ForeColor = System.Drawing.Color.Black
        Me.txtdatatoencode.Location = New System.Drawing.Point(212, 102)
        Me.txtdatatoencode.Name = "txtdatatoencode"
        Me.txtdatatoencode.Size = New System.Drawing.Size(282, 28)
        Me.txtdatatoencode.TabIndex = 78
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(23, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(192, 30)
        Me.Label14.TabIndex = 79
        Me.Label14.Text = "Número de código:"
        '
        'txtbarcode
        '
        Me.txtbarcode.BackColor = System.Drawing.Color.Lavender
        Me.txtbarcode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbarcode.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbarcode.ForeColor = System.Drawing.Color.Black
        Me.txtbarcode.Location = New System.Drawing.Point(212, 170)
        Me.txtbarcode.Multiline = True
        Me.txtbarcode.Name = "txtbarcode"
        Me.txtbarcode.Size = New System.Drawing.Size(282, 101)
        Me.txtbarcode.TabIndex = 80
        '
        'txtencodetext
        '
        Me.txtencodetext.BackColor = System.Drawing.Color.Lavender
        Me.txtencodetext.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtencodetext.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtencodetext.ForeColor = System.Drawing.Color.Black
        Me.txtencodetext.Location = New System.Drawing.Point(212, 136)
        Me.txtencodetext.Name = "txtencodetext"
        Me.txtencodetext.Size = New System.Drawing.Size(282, 28)
        Me.txtencodetext.TabIndex = 81
        Me.txtencodetext.Visible = False
        '
        'frmcodigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 308)
        Me.Controls.Add(Me.txtencodetext)
        Me.Controls.Add(Me.txtbarcode)
        Me.Controls.Add(Me.txtdatatoencode)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.lbldescribe)
        Me.Name = "frmcodigo"
        Me.Text = "frmcodigo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lbldescribe As System.Windows.Forms.Label
    Friend WithEvents txtdatatoencode As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtbarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtencodetext As System.Windows.Forms.TextBox
End Class
