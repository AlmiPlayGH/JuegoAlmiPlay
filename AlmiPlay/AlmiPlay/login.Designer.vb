<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Me.txtUsuLog = New System.Windows.Forms.TextBox()
        Me.btnJugar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnOjo = New System.Windows.Forms.Button()
        Me.timePass = New System.Windows.Forms.Timer(Me.components)
        Me.timePass1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtUsuLog
        '
        Me.txtUsuLog.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuLog.Location = New System.Drawing.Point(386, 454)
        Me.txtUsuLog.Multiline = True
        Me.txtUsuLog.Name = "txtUsuLog"
        Me.txtUsuLog.Size = New System.Drawing.Size(230, 31)
        Me.txtUsuLog.TabIndex = 1
        '
        'btnJugar
        '
        Me.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJugar.Location = New System.Drawing.Point(453, 624)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(93, 36)
        Me.btnJugar.TabIndex = 2
        Me.btnJugar.Text = "Jugar"
        Me.btnJugar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(840, 669)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 34)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(386, 550)
        Me.txtPass.Multiline = True
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(230, 31)
        Me.txtPass.TabIndex = 4
        '
        'btnOjo
        '
        Me.btnOjo.BackgroundImage = Global.AlmiPlay.My.Resources.Resources.eyeC
        Me.btnOjo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOjo.Location = New System.Drawing.Point(641, 552)
        Me.btnOjo.Name = "btnOjo"
        Me.btnOjo.Size = New System.Drawing.Size(27, 27)
        Me.btnOjo.TabIndex = 5
        Me.btnOjo.UseVisualStyleBackColor = True
        '
        'timePass
        '
        Me.timePass.Interval = 10
        '
        'timePass1
        '
        Me.timePass1.Interval = 2000
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AlmiPlay.My.Resources.Resources.fondoLogin1
        Me.ClientSize = New System.Drawing.Size(984, 741)
        Me.Controls.Add(Me.btnOjo)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnJugar)
        Me.Controls.Add(Me.txtUsuLog)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsuLog As TextBox
    Friend WithEvents btnJugar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnOjo As Button
    Friend WithEvents timePass As Timer
    Friend WithEvents timePass1 As Timer
End Class
