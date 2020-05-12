<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class imagen
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
        Me.components = New System.ComponentModel.Container()
        Me.timeImagen = New System.Windows.Forms.Timer(Me.components)
        Me.lblUsu = New System.Windows.Forms.Label()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.lblContPreg = New System.Windows.Forms.Label()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timeImagen
        '
        Me.timeImagen.Interval = 2000
        '
        'lblUsu
        '
        Me.lblUsu.AutoSize = True
        Me.lblUsu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsu.ForeColor = System.Drawing.Color.White
        Me.lblUsu.Location = New System.Drawing.Point(36, 697)
        Me.lblUsu.Name = "lblUsu"
        Me.lblUsu.Size = New System.Drawing.Size(126, 22)
        Me.lblUsu.TabIndex = 1
        Me.lblUsu.Text = "Hola Usuario"
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPregunta.ForeColor = System.Drawing.Color.White
        Me.lblPregunta.Location = New System.Drawing.Point(193, 697)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(676, 22)
        Me.lblPregunta.TabIndex = 2
        Me.lblPregunta.Text = "En 8 segundos podrás ver tu pregunta... Observa la imagen atentamente."
        '
        'pbImagen
        '
        Me.pbImagen.Image = Global.AlmiPlay.My.Resources.Resources.p19worm
        Me.pbImagen.Location = New System.Drawing.Point(-1, 0)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(1002, 678)
        Me.pbImagen.TabIndex = 0
        Me.pbImagen.TabStop = False
        '
        'lblContPreg
        '
        Me.lblContPreg.AutoSize = True
        Me.lblContPreg.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContPreg.ForeColor = System.Drawing.Color.White
        Me.lblContPreg.Location = New System.Drawing.Point(910, 697)
        Me.lblContPreg.Name = "lblContPreg"
        Me.lblContPreg.Size = New System.Drawing.Size(48, 22)
        Me.lblContPreg.TabIndex = 3
        Me.lblContPreg.Text = "1/10"
        '
        'imagen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(999, 741)
        Me.Controls.Add(Me.lblContPreg)
        Me.Controls.Add(Me.lblPregunta)
        Me.Controls.Add(Me.lblUsu)
        Me.Controls.Add(Me.pbImagen)
        Me.Name = "imagen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "La imagen dice que..."
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents timeImagen As Timer
    Friend WithEvents lblUsu As Label
    Friend WithEvents lblPregunta As Label
    Friend WithEvents lblContPreg As Label
End Class
