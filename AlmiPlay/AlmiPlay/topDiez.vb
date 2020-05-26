Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Windows.Forms

Public Class topDiez
    Private Sub topDiez_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambioInicioScore()
        llamadaBBDDScore()
        topDiez()

    End Sub


    Private Function topDiez()
        Dim consult As String
        Dim punt As String
        Dim usu As String
        Dim fechaJuego As Date
        Dim lista As Byte
        'consult = "select puntuacion from Puntuaciones"
        consult = "select Usuarios.usuario, puntuacion, fecha FROM Puntuaciones INNER JOIN Usuarios ON Usuarios.id_usuario=Puntuaciones.id_usuario WHERE habilitado=1 ORDER BY Puntuaciones.puntuacion desc LIMIT 10"
        dataAdapterAP = New MySqlDataAdapter(consult, conexionAP)
        dataSetAP = New DataSet
        dataAdapterAP.Fill(dataSetAP, "Puntuaciones")
        lista = dataSetAP.Tables("Puntuaciones").Rows().Count()
        If lista <> 0 Then
            For a = 0 To dataSetAP.Tables("Puntuaciones").Rows().Count() Step 1
                If a = 10 Then
                    Exit For
                End If
                punt = dataSetAP.Tables("Puntuaciones").Rows(a).Item("puntuacion")
                fechaJuego = dataSetAP.Tables("Puntuaciones").Rows(a).Item("fecha")
                usu = dataSetAP.Tables("Puntuaciones").Rows(a).Item("usuario")
                If a = 0 Then
                    lblPunt1.Text = punt
                    lblFecha1.Text = fechaJuego
                    lblTop1.Text = usu
                ElseIf a = 1 Then
                    lblPunt2.Text = punt
                    lblFecha2.Text = fechaJuego
                    lblTop2.Text = usu
                ElseIf a = 2 Then
                    lblPunt3.Text = punt
                    lblFecha3.Text = fechaJuego
                    lblTop3.Text = usu
                ElseIf a = 3 Then
                    lblPunt4.Text = punt
                    lblFecha4.Text = fechaJuego
                    lblTop4.Text = usu
                ElseIf a = 4 Then
                    lblPunt5.Text = punt
                    lblFecha5.Text = fechaJuego
                    lblTop5.Text = usu
                ElseIf a = 5 Then
                    lblPunt6.Text = punt
                    lblFecha6.Text = fechaJuego
                    lblTop6.Text = usu
                ElseIf a = 6 Then
                    lblPunt7.Text = punt
                    lblFecha7.Text = fechaJuego
                    lblTop7.Text = usu
                ElseIf a = 7 Then
                    lblPunt8.Text = punt
                    lblFecha8.Text = fechaJuego
                    lblTop8.Text = usu
                ElseIf a = 8 Then
                    lblPunt9.Text = punt
                    lblFecha9.Text = fechaJuego
                    lblTop9.Text = usu
                ElseIf a = 9 Then
                    lblPunt10.Text = punt
                    lblFecha10.Text = fechaJuego
                    lblTop10.Text = usu
                End If

            Next
        End If



        'Usuarios.usuario, puntuacion, fecha FROM Puntuaciones INNER JOIN Usuarios ON Usuarios.id_usuario=Puntuaciones.id_usuario ORDER BY Puntuaciones.puntuacion desc LIMIT 10
    End Function

    Private Function cambioInicioScore()
        btnSalirScore.BackColor = Color.FromArgb(213, 177, 67)
        btnVolverScore.BackColor = Color.FromArgb(213, 177, 67)
        colorLabel()


    End Function

    Private Sub btnVolverScore_Click(sender As Object, e As EventArgs) Handles btnVolverScore.Click
        Me.Close()
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