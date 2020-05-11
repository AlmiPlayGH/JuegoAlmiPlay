<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AlmiPlay
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pbRespuestas = New System.Windows.Forms.PictureBox()
        Me.pbPregunta = New System.Windows.Forms.PictureBox()
        Me.pbLlamada = New System.Windows.Forms.PictureBox()
        Me.pbPublico = New System.Windows.Forms.PictureBox()
        Me.pbMitad = New System.Windows.Forms.PictureBox()
        Me.txtPregunta = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.timerLabel = New System.Windows.Forms.Timer(Me.components)
        Me.pbVolver = New System.Windows.Forms.PictureBox()
        Me.pbSalir = New System.Windows.Forms.PictureBox()
        Me.lblSig = New System.Windows.Forms.Label()
        Me.lblPerdido = New System.Windows.Forms.Label()
        Me.lblGanado = New System.Windows.Forms.Label()
        CType(Me.pbRespuestas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPregunta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLlamada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPublico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMitad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbRespuestas
        '
        Me.pbRespuestas.Image = Global.AlmiPlay.My.Resources.Resources.camposRespuesta
        Me.pbRespuestas.Location = New System.Drawing.Point(0, 551)
        Me.pbRespuestas.Name = "pbRespuestas"
        Me.pbRespuestas.Size = New System.Drawing.Size(988, 148)
        Me.pbRespuestas.TabIndex = 0
        Me.pbRespuestas.TabStop = False
        '
        'pbPregunta
        '
        Me.pbPregunta.Image = Global.AlmiPlay.My.Resources.Resources.campoPregunta
        Me.pbPregunta.Location = New System.Drawing.Point(-8, 404)
        Me.pbPregunta.Name = "pbPregunta"
        Me.pbPregunta.Size = New System.Drawing.Size(996, 108)
        Me.pbPregunta.TabIndex = 1
        Me.pbPregunta.TabStop = False
        '
        'pbLlamada
        '
        Me.pbLlamada.Image = Global.AlmiPlay.My.Resources.Resources.llamada
        Me.pbLlamada.Location = New System.Drawing.Point(49, 258)
        Me.pbLlamada.Name = "pbLlamada"
        Me.pbLlamada.Size = New System.Drawing.Size(176, 127)
        Me.pbLlamada.TabIndex = 2
        Me.pbLlamada.TabStop = False
        '
        'pbPublico
        '
        Me.pbPublico.Image = Global.AlmiPlay.My.Resources.Resources.publico
        Me.pbPublico.Location = New System.Drawing.Point(250, 258)
        Me.pbPublico.Name = "pbPublico"
        Me.pbPublico.Size = New System.Drawing.Size(176, 127)
        Me.pbPublico.TabIndex = 3
        Me.pbPublico.TabStop = False
        '
        'pbMitad
        '
        Me.pbMitad.Image = Global.AlmiPlay.My.Resources.Resources.mitad
        Me.pbMitad.Location = New System.Drawing.Point(449, 258)
        Me.pbMitad.Name = "pbMitad"
        Me.pbMitad.Size = New System.Drawing.Size(176, 127)
        Me.pbMitad.TabIndex = 4
        Me.pbMitad.TabStop = False
        '
        'txtPregunta
        '
        Me.txtPregunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPregunta.Location = New System.Drawing.Point(87, 418)
        Me.txtPregunta.Multiline = True
        Me.txtPregunta.Name = "txtPregunta"
        Me.txtPregunta.Size = New System.Drawing.Size(810, 75)
        Me.txtPregunta.TabIndex = 5
        '
        'txtA
        '
        Me.txtA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(117, 562)
        Me.txtA.Multiline = True
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(335, 33)
        Me.txtA.TabIndex = 6
        '
        'txtC
        '
        Me.txtC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC.Location = New System.Drawing.Point(117, 654)
        Me.txtC.Multiline = True
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(335, 33)
        Me.txtC.TabIndex = 7
        '
        'txtB
        '
        Me.txtB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(573, 562)
        Me.txtB.Multiline = True
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(335, 33)
        Me.txtB.TabIndex = 8
        '
        'txtD
        '
        Me.txtD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtD.Location = New System.Drawing.Point(573, 654)
        Me.txtD.Multiline = True
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(335, 33)
        Me.txtD.TabIndex = 9
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.lblTiempo.Location = New System.Drawing.Point(303, 105)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(87, 63)
        Me.lblTiempo.TabIndex = 10
        Me.lblTiempo.Text = "20"
        '
        'timerLabel
        '
        Me.timerLabel.Interval = 1000
        '
        'pbVolver
        '
        Me.pbVolver.Image = Global.AlmiPlay.My.Resources.Resources.botonVolver2
        Me.pbVolver.Location = New System.Drawing.Point(877, 32)
        Me.pbVolver.Name = "pbVolver"
        Me.pbVolver.Size = New System.Drawing.Size(31, 29)
        Me.pbVolver.TabIndex = 11
        Me.pbVolver.TabStop = False
        '
        'pbSalir
        '
        Me.pbSalir.Image = Global.AlmiPlay.My.Resources.Resources.botonSalir
        Me.pbSalir.Location = New System.Drawing.Point(924, 32)
        Me.pbSalir.Name = "pbSalir"
        Me.pbSalir.Size = New System.Drawing.Size(31, 29)
        Me.pbSalir.TabIndex = 12
        Me.pbSalir.TabStop = False
        '
        'lblSig
        '
        Me.lblSig.AutoSize = True
        Me.lblSig.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSig.Location = New System.Drawing.Point(465, 108)
        Me.lblSig.Name = "lblSig"
        Me.lblSig.Size = New System.Drawing.Size(132, 15)
        Me.lblSig.TabIndex = 13
        Me.lblSig.Text = "Siguiente Pregunta"
        '
        'lblPerdido
        '
        Me.lblPerdido.AutoSize = True
        Me.lblPerdido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerdido.Location = New System.Drawing.Point(112, 108)
        Me.lblPerdido.Name = "lblPerdido"
        Me.lblPerdido.Size = New System.Drawing.Size(93, 15)
        Me.lblPerdido.TabIndex = 14
        Me.lblPerdido.Text = "¡Has perdido!"
        '
        'lblGanado
        '
        Me.lblGanado.AutoSize = True
        Me.lblGanado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGanado.Location = New System.Drawing.Point(114, 107)
        Me.lblGanado.Name = "lblGanado"
        Me.lblGanado.Size = New System.Drawing.Size(91, 15)
        Me.lblGanado.TabIndex = 15
        Me.lblGanado.Text = "¡Has ganado!"
        '
        'AlmiPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AlmiPlay.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(984, 741)
        Me.Controls.Add(Me.lblGanado)
        Me.Controls.Add(Me.lblPerdido)
        Me.Controls.Add(Me.lblSig)
        Me.Controls.Add(Me.pbSalir)
        Me.Controls.Add(Me.pbVolver)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.txtPregunta)
        Me.Controls.Add(Me.pbMitad)
        Me.Controls.Add(Me.pbPublico)
        Me.Controls.Add(Me.pbLlamada)
        Me.Controls.Add(Me.pbPregunta)
        Me.Controls.Add(Me.pbRespuestas)
        Me.Name = "AlmiPlay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quien Quiere Ser Un Buen Empleado"
        CType(Me.pbRespuestas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPregunta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLlamada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPublico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMitad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVolver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbRespuestas As PictureBox
    Friend WithEvents pbPregunta As PictureBox
    Friend WithEvents pbLlamada As PictureBox
    Friend WithEvents pbPublico As PictureBox
    Friend WithEvents pbMitad As PictureBox
    Friend WithEvents txtPregunta As TextBox
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtD As TextBox
    Friend WithEvents lblTiempo As Label
    Friend WithEvents timerLabel As Timer
    Friend WithEvents pbVolver As PictureBox
    Friend WithEvents pbSalir As PictureBox
    Friend WithEvents lblSig As Label
    Friend WithEvents lblPerdido As Label
    Friend WithEvents lblGanado As Label
End Class
