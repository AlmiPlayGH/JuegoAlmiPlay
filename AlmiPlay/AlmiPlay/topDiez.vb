Public Class topDiez
    Private Sub topDiez_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambioInicioScore()
        llamadaBBDDScore()


    End Sub


    Private Function topDiez()
        Dim consult As String
        ' consult = "SELECT Usuarios.usuario, puntuacion, fecha FROM Puntuaciones INNER JOIN Usuarios ON Usuarios.id_usuario=Puntuaciones.id_usuario ORDER BY Puntuaciones.puntuacion desc LIMIT 10"
    End Function

    Private Function cambioInicioScore()
        btnSalirScore.BackColor = Color.FromArgb(213, 177, 67)
        btnVolverScore.BackColor = Color.FromArgb(213, 177, 67)
        colorLabel()


    End Function

    Private Sub btnVolverScore_Click(sender As Object, e As EventArgs) Handles btnVolverScore.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub btnSalirScore_Click(sender As Object, e As EventArgs) Handles btnSalirScore.Click
        End
    End Sub

    Private Function colorLabel()
        lblFecha1.BackColor = Color.FromArgb(1, 17, 77)
        lblFecha2.BackColor = Color.FromArgb(1, 17, 77)
        lblFecha3.BackColor = Color.FromArgb(1, 17, 77)
        lblFecha4.BackColor = Color.FromArgb(1, 17, 77)
        lblFecha5.BackColor = Color.FromArgb(1, 17, 77)
        lblFecha6.BackColor = Color.FromArgb(1, 17, 77)
        lblFecha7.BackColor = Color.FromArgb(1, 17, 77)
        lblFecha8.BackColor = Color.FromArgb(1, 17, 77)
        lblFecha9.BackColor = Color.FromArgb(1, 17, 77)
        lblFecha10.BackColor = Color.FromArgb(1, 17, 77)
        lblTop1.BackColor = Color.FromArgb(1, 17, 77)
        lblTop2.BackColor = Color.FromArgb(1, 17, 77)
        lblTop3.BackColor = Color.FromArgb(1, 17, 77)
        lblTop4.BackColor = Color.FromArgb(1, 17, 77)
        lblTop5.BackColor = Color.FromArgb(1, 17, 77)
        lblTop6.BackColor = Color.FromArgb(1, 17, 77)
        lblTop7.BackColor = Color.FromArgb(1, 17, 77)
        lblTop8.BackColor = Color.FromArgb(1, 17, 77)
        lblTop9.BackColor = Color.FromArgb(1, 17, 77)
        lblTop10.BackColor = Color.FromArgb(1, 17, 77)
        lblPunt1.BackColor = Color.FromArgb(1, 17, 77)
        lblPunt2.BackColor = Color.FromArgb(1, 17, 77)
        lblPunt3.BackColor = Color.FromArgb(1, 17, 77)
        lblPunt4.BackColor = Color.FromArgb(1, 17, 77)
        lblPunt5.BackColor = Color.FromArgb(1, 17, 77)
        lblPunt6.BackColor = Color.FromArgb(1, 17, 77)
        lblPunt7.BackColor = Color.FromArgb(1, 17, 77)
        lblPunt8.BackColor = Color.FromArgb(1, 17, 77)
        lblPunt9.BackColor = Color.FromArgb(1, 17, 77)
        lblPunt10.BackColor = Color.FromArgb(1, 17, 77)

    End Function


End Class