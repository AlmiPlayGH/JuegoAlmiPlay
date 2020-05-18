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
        lblResultado.Text = num3Score
        'num3score, contCorrectas, fecha, lblIdUsuario
    End Function
End Class