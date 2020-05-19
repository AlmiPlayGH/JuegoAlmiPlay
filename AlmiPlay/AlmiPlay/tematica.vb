Public Class tematica
    Private Sub tematica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnIngles.BackColor = Color.FromArgb(213, 177, 67)
        btnFol.BackColor = Color.FromArgb(213, 177, 67)
        btnFol.ForeColor = Color.White
        btnIngles.ForeColor = Color.White
    End Sub

    Private Sub btnFol_Click(sender As Object, e As EventArgs) Handles btnFol.Click
        selecTema = 0
        AlmiPlay.Show()
        Me.Hide()
    End Sub

    Private Sub btnIngles_Click(sender As Object, e As EventArgs) Handles btnIngles.Click
        selecTema = 1
        AlmiPlay.Show()
        Me.Hide()
    End Sub
End Class