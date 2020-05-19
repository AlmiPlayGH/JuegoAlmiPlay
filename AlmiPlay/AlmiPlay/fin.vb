Public Class fin
    Private Sub fin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambioInicio()

    End Sub

    Private Sub lblVolverLogin_Click(sender As Object, e As EventArgs) Handles lblVolverLogin.Click
        Me.Hide()
        login.Show()
        AlmiPlay.Close()
    End Sub


    Private Sub lblSalirFin_Click(sender As Object, e As EventArgs) Handles lblSalirFin.Click
        Me.Close()
        login.Close()
        AlmiPlay.Close()
    End Sub

    Private Function cambioInicio()
        lblSalirFin.BackColor = Color.FromArgb(0, 9, 43)
        lblSalirFin.ForeColor = Color.FromArgb(213, 177, 67)
        lblVolverLogin.BackColor = Color.FromArgb(0, 10, 49)
        lblVolverLogin.ForeColor = Color.FromArgb(213, 177, 67)
        lblResultado.BackColor = Color.FromArgb(0, 10, 49)
        lblResultado.ForeColor = Color.White
        lblAfiliado.BackColor = Color.FromArgb(0, 13, 61)
        lblResultado.BackColor = Color.FromArgb(0, 13, 61)
        lblCorrectas.BackColor = Color.FromArgb(0, 13, 61)
        lblUsuario.BackColor = Color.FromArgb(0, 10, 49)
        lblTiempo.BackColor = Color.FromArgb(0, 10, 49)
        lblFecha.BackColor = Color.FromArgb(0, 10, 49)
        lblAfiliado.ForeColor = Color.White
        lblFecha.ForeColor = Color.White
        lblCorrectas.ForeColor = Color.White
        lblUsuario.ForeColor = Color.White
        lblTiempo.ForeColor = Color.White

        lblAfiliado.Text = idUsu
        lblUsuario.Text = usuLog
        lblResultado.Text = num3Score
        lblTiempo.Text = tiempoTardado
        lblCorrectas.Text = contCorrectas
        lblFecha.Text = fecha



        'num3score, contCorrectas, fecha, idUsu
    End Function


End Class