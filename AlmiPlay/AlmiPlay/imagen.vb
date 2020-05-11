Public Class imagen
    Private Sub timeImagen_Tick(sender As Object, e As EventArgs) Handles timeImagen.Tick
        Me.Close()
        AlmiPlay.Show()

    End Sub

    Private Sub imagen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(9, 16, 62)
        timeImagen.Start()
        lblUsu.Text = ("Hola " & login.txtUsuLog.Text & ".")

    End Sub

    Private Sub imagen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        timeImagen.Stop()
    End Sub
End Class