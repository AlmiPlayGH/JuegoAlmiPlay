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
        Me.pbFin = New System.Windows.Forms.PictureBox()
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
        Me.lblResultado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(245, 646)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(177, 50)
        Me.lblResultado.TabIndex = 3
        Me.lblResultado.Text = "SCORE"
        '
        'pbFin
        '
        Me.pbFin.BackgroundImage = Global.AlmiPlay.My.Resources.Resources.fondoFin1
        Me.pbFin.Image = Global.AlmiPlay.My.Resources.Resources.fondoFin1
        Me.pbFin.Location = New System.Drawing.Point(-3, -35)
        Me.pbFin.Name = "pbFin"
        Me.pbFin.Size = New System.Drawing.Size(991, 789)
        Me.pbFin.TabIndex = 0
        Me.pbFin.TabStop = False
        '
        'fin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 741)
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
End Class
