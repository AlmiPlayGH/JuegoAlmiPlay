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
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.timerLabel = New System.Windows.Forms.Timer(Me.components)
        Me.pbVolver = New System.Windows.Forms.PictureBox()
        Me.pbSalir = New System.Windows.Forms.PictureBox()
        Me.lblSig = New System.Windows.Forms.Label()
        Me.lblFallo = New System.Windows.Forms.Label()
        Me.lblAcertar = New System.Windows.Forms.Label()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblPista = New System.Windows.Forms.Label()
        Me.lblNomPista = New System.Windows.Forms.Label()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.timerFotoStart = New System.Windows.Forms.Timer(Me.components)
        Me.timerFotoStop = New System.Windows.Forms.Timer(Me.components)
        Me.timerEspera = New System.Windows.Forms.Timer(Me.components)
        Me.pbLlamadaRed = New System.Windows.Forms.PictureBox()
        Me.pbPublicoRed = New System.Windows.Forms.PictureBox()
        Me.pbMitadRed = New System.Windows.Forms.PictureBox()
        Me.lblAOculto = New System.Windows.Forms.Label()
        Me.lblBOculto = New System.Windows.Forms.Label()
        Me.lblCOculto = New System.Windows.Forms.Label()
        Me.lblDOculto = New System.Windows.Forms.Label()
        Me.lblScoreNom = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.pbRojoA = New System.Windows.Forms.PictureBox()
        Me.pbRojoC = New System.Windows.Forms.PictureBox()
        Me.pbRojoB = New System.Windows.Forms.PictureBox()
        Me.pbRojoD = New System.Windows.Forms.PictureBox()
        Me.pbVerdeA = New System.Windows.Forms.PictureBox()
        Me.pbVerdeC = New System.Windows.Forms.PictureBox()
        Me.pbVerdeB = New System.Windows.Forms.PictureBox()
        Me.pbVerdeD = New System.Windows.Forms.PictureBox()
        CType(Me.pbRespuestas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPregunta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLlamada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPublico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMitad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLlamadaRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPublicoRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMitadRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRojoA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRojoC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRojoB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRojoD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVerdeA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVerdeC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVerdeB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVerdeD, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.lblTiempo.Location = New System.Drawing.Point(303, 105)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(87, 63)
        Me.lblTiempo.TabIndex = 10
        Me.lblTiempo.Text = "30"
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
        'lblFallo
        '
        Me.lblFallo.AutoSize = True
        Me.lblFallo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFallo.Location = New System.Drawing.Point(112, 108)
        Me.lblFallo.Name = "lblFallo"
        Me.lblFallo.Size = New System.Drawing.Size(87, 15)
        Me.lblFallo.TabIndex = 14
        Me.lblFallo.Text = "¡Has fallado!"
        '
        'lblAcertar
        '
        Me.lblAcertar.AutoSize = True
        Me.lblAcertar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcertar.Location = New System.Drawing.Point(108, 108)
        Me.lblAcertar.Name = "lblAcertar"
        Me.lblAcertar.Size = New System.Drawing.Size(102, 15)
        Me.lblAcertar.TabIndex = 15
        Me.lblAcertar.Text = "¡Has acertado!"
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPregunta.Location = New System.Drawing.Point(66, 445)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(0, 20)
        Me.lblPregunta.TabIndex = 16
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Location = New System.Drawing.Point(107, 570)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(0, 15)
        Me.lblA.TabIndex = 17
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(565, 570)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(0, 15)
        Me.lblB.TabIndex = 18
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.Location = New System.Drawing.Point(107, 663)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(0, 15)
        Me.lblC.TabIndex = 19
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD.Location = New System.Drawing.Point(565, 663)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(0, 15)
        Me.lblD.TabIndex = 20
        '
        'lblPista
        '
        Me.lblPista.AutoSize = True
        Me.lblPista.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPista.Location = New System.Drawing.Point(157, 522)
        Me.lblPista.Name = "lblPista"
        Me.lblPista.Size = New System.Drawing.Size(0, 17)
        Me.lblPista.TabIndex = 21
        '
        'lblNomPista
        '
        Me.lblNomPista.AutoSize = True
        Me.lblNomPista.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomPista.Location = New System.Drawing.Point(91, 522)
        Me.lblNomPista.Name = "lblNomPista"
        Me.lblNomPista.Size = New System.Drawing.Size(49, 17)
        Me.lblNomPista.TabIndex = 22
        Me.lblNomPista.Text = "Pista:"
        '
        'pbFoto
        '
        Me.pbFoto.BackgroundImage = Global.AlmiPlay.My.Resources.Resources.p19worm
        Me.pbFoto.Location = New System.Drawing.Point(0, -432)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(988, 742)
        Me.pbFoto.TabIndex = 23
        Me.pbFoto.TabStop = False
        '
        'timerFotoStart
        '
        Me.timerFotoStart.Interval = 10000
        '
        'timerFotoStop
        '
        Me.timerFotoStop.Interval = 10000
        '
        'pbLlamadaRed
        '
        Me.pbLlamadaRed.Image = Global.AlmiPlay.My.Resources.Resources.llamadaRed
        Me.pbLlamadaRed.Location = New System.Drawing.Point(49, 258)
        Me.pbLlamadaRed.Name = "pbLlamadaRed"
        Me.pbLlamadaRed.Size = New System.Drawing.Size(176, 127)
        Me.pbLlamadaRed.TabIndex = 24
        Me.pbLlamadaRed.TabStop = False
        '
        'pbPublicoRed
        '
        Me.pbPublicoRed.Image = Global.AlmiPlay.My.Resources.Resources.publicoRed
        Me.pbPublicoRed.Location = New System.Drawing.Point(250, 258)
        Me.pbPublicoRed.Name = "pbPublicoRed"
        Me.pbPublicoRed.Size = New System.Drawing.Size(176, 127)
        Me.pbPublicoRed.TabIndex = 25
        Me.pbPublicoRed.TabStop = False
        '
        'pbMitadRed
        '
        Me.pbMitadRed.Image = Global.AlmiPlay.My.Resources.Resources.mitadRed
        Me.pbMitadRed.Location = New System.Drawing.Point(449, 258)
        Me.pbMitadRed.Name = "pbMitadRed"
        Me.pbMitadRed.Size = New System.Drawing.Size(176, 127)
        Me.pbMitadRed.TabIndex = 26
        Me.pbMitadRed.TabStop = False
        '
        'lblAOculto
        '
        Me.lblAOculto.AutoSize = True
        Me.lblAOculto.Location = New System.Drawing.Point(898, 713)
        Me.lblAOculto.Name = "lblAOculto"
        Me.lblAOculto.Size = New System.Drawing.Size(10, 13)
        Me.lblAOculto.TabIndex = 27
        Me.lblAOculto.Text = "."
        '
        'lblBOculto
        '
        Me.lblBOculto.AutoSize = True
        Me.lblBOculto.Location = New System.Drawing.Point(914, 713)
        Me.lblBOculto.Name = "lblBOculto"
        Me.lblBOculto.Size = New System.Drawing.Size(10, 13)
        Me.lblBOculto.TabIndex = 28
        Me.lblBOculto.Text = "."
        '
        'lblCOculto
        '
        Me.lblCOculto.AutoSize = True
        Me.lblCOculto.Location = New System.Drawing.Point(930, 713)
        Me.lblCOculto.Name = "lblCOculto"
        Me.lblCOculto.Size = New System.Drawing.Size(10, 13)
        Me.lblCOculto.TabIndex = 29
        Me.lblCOculto.Text = "."
        '
        'lblDOculto
        '
        Me.lblDOculto.AutoSize = True
        Me.lblDOculto.Location = New System.Drawing.Point(946, 713)
        Me.lblDOculto.Name = "lblDOculto"
        Me.lblDOculto.Size = New System.Drawing.Size(10, 13)
        Me.lblDOculto.TabIndex = 30
        Me.lblDOculto.Text = "."
        '
        'lblScoreNom
        '
        Me.lblScoreNom.AutoSize = True
        Me.lblScoreNom.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreNom.Location = New System.Drawing.Point(667, 373)
        Me.lblScoreNom.Name = "lblScoreNom"
        Me.lblScoreNom.Size = New System.Drawing.Size(89, 28)
        Me.lblScoreNom.TabIndex = 31
        Me.lblScoreNom.Text = "Score:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(762, 373)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(26, 28)
        Me.lblScore.TabIndex = 32
        Me.lblScore.Text = "0"
        '
        'pbRojoA
        '
        Me.pbRojoA.Image = Global.AlmiPlay.My.Resources.Resources.incorrectoDer
        Me.pbRojoA.Location = New System.Drawing.Point(1, 551)
        Me.pbRojoA.Name = "pbRojoA"
        Me.pbRojoA.Size = New System.Drawing.Size(514, 73)
        Me.pbRojoA.TabIndex = 33
        Me.pbRojoA.TabStop = False
        '
        'pbRojoC
        '
        Me.pbRojoC.Image = Global.AlmiPlay.My.Resources.Resources.incorrectoDer
        Me.pbRojoC.Location = New System.Drawing.Point(2, 643)
        Me.pbRojoC.Name = "pbRojoC"
        Me.pbRojoC.Size = New System.Drawing.Size(514, 73)
        Me.pbRojoC.TabIndex = 34
        Me.pbRojoC.TabStop = False
        '
        'pbRojoB
        '
        Me.pbRojoB.Image = Global.AlmiPlay.My.Resources.Resources.incorrectoIzq
        Me.pbRojoB.Location = New System.Drawing.Point(486, 551)
        Me.pbRojoB.Name = "pbRojoB"
        Me.pbRojoB.Size = New System.Drawing.Size(498, 73)
        Me.pbRojoB.TabIndex = 35
        Me.pbRojoB.TabStop = False
        '
        'pbRojoD
        '
        Me.pbRojoD.Image = Global.AlmiPlay.My.Resources.Resources.incorrectoIzq
        Me.pbRojoD.Location = New System.Drawing.Point(486, 643)
        Me.pbRojoD.Name = "pbRojoD"
        Me.pbRojoD.Size = New System.Drawing.Size(498, 73)
        Me.pbRojoD.TabIndex = 36
        Me.pbRojoD.TabStop = False
        '
        'pbVerdeA
        '
        Me.pbVerdeA.Image = Global.AlmiPlay.My.Resources.Resources.correctoIzq
        Me.pbVerdeA.Location = New System.Drawing.Point(1, 550)
        Me.pbVerdeA.Name = "pbVerdeA"
        Me.pbVerdeA.Size = New System.Drawing.Size(514, 73)
        Me.pbVerdeA.TabIndex = 37
        Me.pbVerdeA.TabStop = False
        '
        'pbVerdeC
        '
        Me.pbVerdeC.Image = Global.AlmiPlay.My.Resources.Resources.correctoIzq
        Me.pbVerdeC.Location = New System.Drawing.Point(1, 642)
        Me.pbVerdeC.Name = "pbVerdeC"
        Me.pbVerdeC.Size = New System.Drawing.Size(514, 73)
        Me.pbVerdeC.TabIndex = 38
        Me.pbVerdeC.TabStop = False
        '
        'pbVerdeB
        '
        Me.pbVerdeB.Image = Global.AlmiPlay.My.Resources.Resources.correctoDer
        Me.pbVerdeB.Location = New System.Drawing.Point(485, 551)
        Me.pbVerdeB.Name = "pbVerdeB"
        Me.pbVerdeB.Size = New System.Drawing.Size(502, 73)
        Me.pbVerdeB.TabIndex = 39
        Me.pbVerdeB.TabStop = False
        '
        'pbVerdeD
        '
        Me.pbVerdeD.Image = Global.AlmiPlay.My.Resources.Resources.correctoDer
        Me.pbVerdeD.Location = New System.Drawing.Point(482, 642)
        Me.pbVerdeD.Name = "pbVerdeD"
        Me.pbVerdeD.Size = New System.Drawing.Size(502, 73)
        Me.pbVerdeD.TabIndex = 40
        Me.pbVerdeD.TabStop = False
        '
        'AlmiPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AlmiPlay.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(984, 741)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblScoreNom)
        Me.Controls.Add(Me.lblDOculto)
        Me.Controls.Add(Me.lblCOculto)
        Me.Controls.Add(Me.lblBOculto)
        Me.Controls.Add(Me.lblAOculto)
        Me.Controls.Add(Me.pbFoto)
        Me.Controls.Add(Me.pbMitadRed)
        Me.Controls.Add(Me.pbPublicoRed)
        Me.Controls.Add(Me.pbLlamadaRed)
        Me.Controls.Add(Me.lblNomPista)
        Me.Controls.Add(Me.lblPista)
        Me.Controls.Add(Me.lblPregunta)
        Me.Controls.Add(Me.lblAcertar)
        Me.Controls.Add(Me.lblFallo)
        Me.Controls.Add(Me.lblSig)
        Me.Controls.Add(Me.pbSalir)
        Me.Controls.Add(Me.pbVolver)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.pbMitad)
        Me.Controls.Add(Me.pbPublico)
        Me.Controls.Add(Me.pbLlamada)
        Me.Controls.Add(Me.pbPregunta)
        Me.Controls.Add(Me.pbVerdeB)
        Me.Controls.Add(Me.pbVerdeA)
        Me.Controls.Add(Me.pbVerdeC)
        Me.Controls.Add(Me.pbVerdeD)
        Me.Controls.Add(Me.pbRojoA)
        Me.Controls.Add(Me.pbRojoB)
        Me.Controls.Add(Me.pbRojoC)
        Me.Controls.Add(Me.pbRojoD)
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
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLlamadaRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPublicoRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMitadRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRojoA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRojoC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRojoB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRojoD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVerdeA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVerdeC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVerdeB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVerdeD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbRespuestas As PictureBox
    Friend WithEvents pbPregunta As PictureBox
    Friend WithEvents pbLlamada As PictureBox
    Friend WithEvents pbPublico As PictureBox
    Friend WithEvents pbMitad As PictureBox
    Friend WithEvents lblTiempo As Label
    Friend WithEvents timerLabel As Timer
    Friend WithEvents pbVolver As PictureBox
    Friend WithEvents pbSalir As PictureBox
    Friend WithEvents lblSig As Label
    Friend WithEvents lblFallo As Label
    Friend WithEvents lblAcertar As Label
    Friend WithEvents lblPregunta As Label
    Friend WithEvents lblA As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblC As Label
    Friend WithEvents lblD As Label
    Friend WithEvents lblPista As Label
    Friend WithEvents lblNomPista As Label
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents timerFotoStart As Timer
    Friend WithEvents timerFotoStop As Timer
    Friend WithEvents timerEspera As Timer
    Friend WithEvents pbLlamadaRed As PictureBox
    Friend WithEvents pbPublicoRed As PictureBox
    Friend WithEvents pbMitadRed As PictureBox
    Friend WithEvents lblAOculto As Label
    Friend WithEvents lblBOculto As Label
    Friend WithEvents lblCOculto As Label
    Friend WithEvents lblDOculto As Label
    Friend WithEvents lblScoreNom As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents pbRojoA As PictureBox
    Friend WithEvents pbRojoC As PictureBox
    Friend WithEvents pbRojoB As PictureBox
    Friend WithEvents pbRojoD As PictureBox
    Friend WithEvents pbVerdeA As PictureBox
    Friend WithEvents pbVerdeC As PictureBox
    Friend WithEvents pbVerdeB As PictureBox
    Friend WithEvents pbVerdeD As PictureBox
End Class
