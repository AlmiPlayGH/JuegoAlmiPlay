Public Class fin
    Private Sub fin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llamadaBBDDScore()
        insertarScore()
        cambioInicio()
    End Sub
    Private Sub lblVolverLogin_Click(sender As Object, e As EventArgs) Handles lblVolverLogin.Click
        Me.Close()
        login.Show()
        AlmiPlay.Close()
        topDiez.Close()
        tematica.Close()
    End Sub

    Private Sub lblSalirFin_Click(sender As Object, e As EventArgs) Handles lblSalirFin.Click
        End
    End Sub

    Private Function insertarScore()
        dia = DateTime.Now.ToString("dd")
        mes = DateTime.Now.ToString("MM")
        año = DateTime.Now.ToString("yyyy")
        fecha = año & "-" & mes & "-" & dia
        dataRowAP = dataSetAP.Tables("Puntuaciones").NewRow
        dataRowAP.Item("id_usuario") = idUsu
        dataRowAP.Item("puntuacion") = num3Score
        dataRowAP.Item("tiempo") = tiempoTardado
        dataRowAP.Item("correctas") = contCorrectas
        dataRowAP.Item("fecha") = fecha
        dataSetAP.Tables("Puntuaciones").Rows.Add(dataRowAP)
        Try
            If dataAdapterAP.Update(dataSetAP, "Puntuaciones") = 0 Then
                MsgBox("Error al actualizar con la BD. Intentalo más tarde")
                'Else MsgBox("bien")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

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

    Private Sub fin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        conexionAP.Close()
    End Sub
End Class