<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fin
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
        Me.lblVolverLogin = New System.Windows.Forms.Label()
        Me.lblSalirFin = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.lblCorrectas = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblAfiliado = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.pbFin = New System.Windows.Forms.PictureBox()
        Me.lblPts = New System.Windows.Forms.Label()
        Me.lblSeg = New System.Windows.Forms.Label()
        CType(Me.pbFin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVolverLogin
        '
        Me.lblVolverLogin.AutoSize = True
        Me.lblVolverLogin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolverLogin.Location = New System.Drawing.Point(607, 639)
        Me.lblVolverLogin.Name = "lblVolverLogin"
        Me.lblVolverLogin.Size = New System.Drawing.Size(76, 28)
        Me.lblVolverLogin.TabIndex = 1
        Me.lblVolverLogin.Text = "Login"
        '
        'lblSalirFin
        '
        Me.lblSalirFin.AutoSize = True
        Me.lblSalirFin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalirFin.Location = New System.Drawing.Point(812, 639)
        Me.lblSalirFin.Name = "lblSalirFin"
        Me.lblSalirFin.Size = New System.Drawing.Size(67, 28)
        Me.lblSalirFin.TabIndex = 2
        Me.lblSalirFin.Text = "Salir"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(256, 463)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(79, 22)
        Me.lblResultado.TabIndex = 3
        Me.lblResultado.Text = "SCORE"
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempo.Location = New System.Drawing.Point(256, 516)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(85, 22)
        Me.lblTiempo.TabIndex = 4
        Me.lblTiempo.Text = "TIEMPO"
        '
        'lblCorrectas
        '
        Me.lblCorrectas.AutoSize = True
        Me.lblCorrectas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectas.Location = New System.Drawing.Point(256, 565)
        Me.lblCorrectas.Name = "lblCorrectas"
        Me.lblCorrectas.Size = New System.Drawing.Size(133, 22)
        Me.lblCorrectas.TabIndex = 5
        Me.lblCorrectas.Text = "CORRECTAS"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(256, 412)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(100, 22)
        Me.lblUsuario.TabIndex = 6
        Me.lblUsuario.Text = "USUARIO"
        '
        'lblAfiliado
        '
        Me.lblAfiliado.AutoSize = True
        Me.lblAfiliado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAfiliado.Location = New System.Drawing.Point(256, 363)
        Me.lblAfiliado.Name = "lblAfiliado"
        Me.lblAfiliado.Size = New System.Drawing.Size(101, 22)
        Me.lblAfiliado.TabIndex = 7
        Me.lblAfiliado.Text = "AFILIADO"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(256, 618)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(76, 22)
        Me.lblFecha.TabIndex = 8
        Me.lblFecha.Text = "FECHA"
        '
        'pbFin
        '
        Me.pbFin.BackgroundImage = Global.AlmiPlay.My.Resources.Resources.fondoFin2
        Me.pbFin.Image = Global.AlmiPlay.My.Resources.Resources.fondoFin2
        Me.pbFin.Location = New System.Drawing.Point(-3, -35)
        Me.pbFin.Name = "pbFin"
        Me.pbFin.Size = New System.Drawing.Size(991, 789)
        Me.pbFin.TabIndex = 0
        Me.pbFin.TabStop = False
        '
        'lblPts
        '
        Me.lblPts.AutoSize = True
        Me.lblPts.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPts.Location = New System.Drawing.Point(312, 463)
        Me.lblPts.Name = "lblPts"
        Me.lblPts.Size = New System.Drawing.Size(39, 22)
        Me.lblPts.TabIndex = 9
        Me.lblPts.Text = "pts"
        '
        'lblSeg
        '
        Me.lblSeg.AutoSize = True
        Me.lblSeg.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeg.Location = New System.Drawing.Point(312, 516)
        Me.lblSeg.Name = "lblSeg"
        Me.lblSeg.Size = New System.Drawing.Size(43, 22)
        Me.lblSeg.TabIndex = 10
        Me.lblSeg.Text = "seg"
        '
        'fin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 741)
        Me.Controls.Add(Me.lblSeg)
        Me.Controls.Add(Me.lblPts)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblAfiliado)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblCorrectas)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblSalirFin)
        Me.Controls.Add(Me.lblVolverLogin)
        Me.Controls.Add(Me.pbFin)
        Me.Name = "fin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fin del Juego"
        CType(Me.pbFin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbFin As PictureBox
    Friend WithEvents lblVolverLogin As Label
    Friend WithEvents lblSalirFin As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents lblTiempo As Label
    Friend WithEvents lblCorrectas As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblAfiliado As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblPts As Label
    Friend WithEvents lblSeg As Label
End Class
