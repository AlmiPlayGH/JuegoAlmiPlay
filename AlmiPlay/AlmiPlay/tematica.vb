Public Class tematica
    Private Sub tematica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambioIniciar()
    End Sub

    Private Sub btnFol_Click(sender As Object, e As EventArgs) Handles btnFol.Click
        selecTema = 1
        AlmiPlay.Show()
        Me.Hide()
    End Sub

    Private Sub btnIngles_Click(sender As Object, e As EventArgs) Handles btnIngles.Click
        selecTema = 0
        AlmiPlay.Show()
        Me.Hide()
    End Sub

    Private Sub btnVolverTEM_Click(sender As Object, e As EventArgs) Handles btnVolverTEM.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub btnSalirTEM_Click(sender As Object, e As EventArgs) Handles btnSalirTEM.Click
        Me.Close()
        AlmiPlay.Close()
        login.Close()
        fin.Close()
    End Sub

    Private Function cambioIniciar()
        btnIngles.BackColor = Color.FromArgb(213, 177, 67)
        btnFol.BackColor = Color.FromArgb(213, 177, 67)
        btnFol.ForeColor = Color.White
        btnIngles.ForeColor = Color.White
        btnSalirTEM.BackColor = Color.FromArgb(213, 177, 67)
        btnVolverTEM.BackColor = Color.FromArgb(213, 177, 67)
        btnSalirTEM.ForeColor = Color.White
        btnVolverTEM.ForeColor = Color.White
    End Function
End Class