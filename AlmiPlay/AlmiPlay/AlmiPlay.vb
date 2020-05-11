Public Class AlmiPlay

    Private Sub AlmiPLay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambioColoresAP()
        timerLabel.Start()
    End Sub

    Private Sub pbVolver_Click(sender As Object, e As EventArgs) Handles pbVolver.Click
        Me.Close()
        imagen.Close()
        login.Show()
    End Sub

    Private Sub pbSalir_Click(sender As Object, e As EventArgs) Handles pbSalir.Click
        Me.Close()
        login.Close()
        imagen.Close()
    End Sub

    Private Sub timerLabel_Tick(sender As Object, e As EventArgs) Handles timerLabel.Tick

        Dim num1, num2 As Integer

        num1 = 1
        num2 = lblTiempo.Text
        lblTiempo.Text = num2 - 1

        If num2 <= 10 Then
            lblTiempo.Left = 319
            'lblTiempo.Text = "0" & num2 - 1 'para poner 0 delante en vez de solo un caracter
        End If
        If num2 = 1 Then
            timerLabel.Stop()
            'cont = cont + 1
            'imagen.lblContPreg.Text = (cont & "/10")
            lblSig.Show()
            lblPerdido.Show()

        End If

    End Sub

    Private Function cambioColoresAP()
        pbRespuestas.BackColor = Color.Transparent
        pbMitad.BackColor = Color.Transparent
        pbLlamada.BackColor = Color.Transparent
        pbPublico.BackColor = Color.Transparent
        pbPregunta.BackColor = Color.Transparent
        txtPregunta.BackColor = Color.FromArgb(35, 31, 31)
        txtA.BackColor = Color.FromArgb(35, 31, 31)
        txtB.BackColor = Color.FromArgb(35, 31, 31)
        txtC.BackColor = Color.FromArgb(35, 31, 31)
        txtD.BackColor = Color.FromArgb(35, 31, 31)
        txtPregunta.ForeColor = Color.White
        txtPregunta.ForeColor = Color.White
        txtA.ForeColor = Color.White
        txtB.ForeColor = Color.White
        txtC.ForeColor = Color.White
        txtD.ForeColor = Color.White
        lblTiempo.ForeColor = Color.White
        lblTiempo.BackColor = Color.Transparent
        pbSalir.BackColor = Color.Transparent
        pbVolver.BackColor = Color.Transparent
        lblSig.BackColor = Color.Transparent
        lblSig.ForeColor = Color.White
        lblGanado.BackColor = Color.Transparent
        lblGanado.ForeColor = Color.White
        lblPerdido.BackColor = Color.Transparent
        lblPerdido.ForeColor = Color.White
        lblSig.Hide()
        lblGanado.Hide()
        lblPerdido.Hide()
    End Function

    Private Sub lblSig_Click(sender As Object, e As EventArgs) Handles lblSig.Click
        Me.Close()
        imagen.Show()
    End Sub
End Class
