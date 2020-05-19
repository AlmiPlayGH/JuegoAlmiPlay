<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tematica
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
        Me.btnFol = New System.Windows.Forms.Button()
        Me.btnIngles = New System.Windows.Forms.Button()
        Me.pbTematica = New System.Windows.Forms.PictureBox()
        CType(Me.pbTematica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFol
        '
        Me.btnFol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFol.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFol.Location = New System.Drawing.Point(242, 265)
        Me.btnFol.Name = "btnFol"
        Me.btnFol.Size = New System.Drawing.Size(107, 35)
        Me.btnFol.TabIndex = 1
        Me.btnFol.Text = "FOL"
        Me.btnFol.UseVisualStyleBackColor = True
        '
        'btnIngles
        '
        Me.btnIngles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngles.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngles.Location = New System.Drawing.Point(649, 265)
        Me.btnIngles.Name = "btnIngles"
        Me.btnIngles.Size = New System.Drawing.Size(107, 35)
        Me.btnIngles.TabIndex = 2
        Me.btnIngles.Text = "INGLES"
        Me.btnIngles.UseVisualStyleBackColor = True
        '
        'pbTematica
        '
        Me.pbTematica.BackgroundImage = Global.AlmiPlay.My.Resources.Resources.tematica2
        Me.pbTematica.Image = Global.AlmiPlay.My.Resources.Resources.tematica2
        Me.pbTematica.Location = New System.Drawing.Point(-8, -20)
        Me.pbTematica.Name = "pbTematica"
        Me.pbTematica.Size = New System.Drawing.Size(1015, 776)
        Me.pbTematica.TabIndex = 0
        Me.pbTematica.TabStop = False
        '
        'tematica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 741)
        Me.Controls.Add(Me.btnIngles)
        Me.Controls.Add(Me.btnFol)
        Me.Controls.Add(Me.pbTematica)
        Me.Name = "tematica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecciona una temática"
        CType(Me.pbTematica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbTematica As PictureBox
    Friend WithEvents btnFol As Button
    Friend WithEvents btnIngles As Button
End Class
