Imports System.Web.Services
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.ComponentModel
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Imports System.Text
Imports System
Imports System.IO
Imports System.Web.Script.Serialization



Public Class AlmiPlay

    Public response As HttpResponseMessage
    Public ServerUrl As String
    Public cliente As HttpClient
    Public contLblPreg As Integer
    Private Sub AlmiPLay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        cambioColoresAP()
        timerLabel.Start()
        contLblPreg = 1
        ServerUrl = "http://62.117.137.221:8181/api/preguntas"
        cliente = New HttpClient()
        cliente.BaseAddress = New Uri(ServerUrl)
        cliente.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))
        data()

    End Sub

    Public Async Sub data()
        'Campos JSON: respuestas, pregunta, imagen, pista
        Try
            'VARIABLES
            Dim contId As Integer
            Dim contPregunta As Integer
            Dim responseBody As String
            Dim jsonWeb As String
            Dim url As String
            Dim foto As String
            contId = Int((26 * Rnd()) + 1)
            contPregunta = 1
            'URL CON POSICION DE CAMPO ALEATORIA
            url = "http://62.117.137.221:8181/api/preguntas/" & contId
            ' foto = "http://62.117.137.221:8181/api/preguntas/imagen/" & contId & ".jpg"
            foto = "http://62.117.137.221:8181/api/preguntas/imagen/45.jpg"

            'SE OBITENE EL JSON EN LA VARIABLE RESPONSEBODY
            Dim response = Await cliente.GetAsync(url)
            response.EnsureSuccessStatusCode()
            responseBody = Await response.Content.ReadAsStringAsync()
            'CREAMOS EL JSON PASANDOLE COMO PARAMETRO EL STRING RESPONSEBODY
            Dim json As JObject = JObject.Parse(responseBody)
            jsonWeb = JsonConvert.SerializeObject(json, Formatting.Indented, New JsonSerializerSettings()) 'STRING DEL JSON CORRESPONDIENTE
            '28 MAYUS y 40 MINUS
            'AÑADIMOS LOS LAS PREGUNTAS Y RESPUESTAS A CADA CAMPO CORRESPONDIENTE
            'MsgBox(jsonWeb)
            lblPregunta.Text = json.SelectToken("data.pregunta")
            lblPista.Text = json.SelectToken("data.pista")
            lblA.Text = json.SelectToken("data.respuestas[0].[0]")
            lblB.Text = json.SelectToken("data.respuestas[1].[0]")
            lblC.Text = json.SelectToken("data.respuestas[2].[0]")
            lblD.Text = json.SelectToken("data.respuestas[3].[0]")
            'AÑADIMOS LA RESPUESTA CORRECTA A UNOS LABEL OCULTOS PARA COMPARAR
            lblAOculto.Text = json.SelectToken("data.respuestas[0].[1]")
            lblBOculto.Text = json.SelectToken("data.respuestas[1].[1]")
            lblCOculto.Text = json.SelectToken("data.respuestas[2].[1]")
            lblDOculto.Text = json.SelectToken("data.respuestas[3].[1]")
            'MsgBox(jsonWeb)

            pbFoto.Load(foto)

            'CAMBIAMOS EL TAMAÑO DE LA LETRA EN EL CASO DE QUE TENGA DEMASIADOS CARACTERES (PARA QUE QUEPA)
            If Len(lblA.Text) > 55 Then
                lblA.Font = New System.Drawing.Font("Arial Rounded MT", 7, FontStyle.Bold)
            End If
            If Len(lblB.Text) > 55 Then
                lblB.Font = New System.Drawing.Font("Arial Rounded MT", 7, FontStyle.Bold)
            End If
            If Len(lblC.Text) > 55 Then
                lblC.Font = New System.Drawing.Font("Arial Rounded MT", 7, FontStyle.Bold)
            End If
            If Len(lblD.Text) > 55 Then
                lblD.Font = New System.Drawing.Font("Arial Rounded MT", 7, FontStyle.Bold)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub lblA_Click(sender As Object, e As EventArgs) Handles lblA.Click
        num1Score = 10 + lblTiempo.Text
        num2Score = lblScore.Text
        num3Score = num1Score + num2Score
        lblA.Enabled = False
        lblB.Enabled = False
        lblC.Enabled = False
        lblD.Enabled = False
        If lblAOculto.Text = 1 Then
            lblA.BackColor = Color.FromArgb(83, 187, 97)
            lblAcertar.Show()
            lblSig.Show()
            timerLabel.Stop()
            pbVerdeA.Show()
            lblScore.Text = num3Score
            disabledComodines()
        Else lblA.BackColor = Color.FromArgb(191, 83, 83)
            pbRojoA.Show()
            lblFallo.Show()
            timerLabel.Stop()
            disabledComodines()
        End If

        If lblBOculto.Text = 1 Then
            lblB.BackColor = Color.FromArgb(83, 187, 97)
            pbVerdeB.Show()
            timerLabel.Stop()
            lblSig.Show()
            disabledComodines()

        End If

        If lblCOculto.Text = 1 Then
            lblC.BackColor = Color.FromArgb(83, 187, 97)
            pbVerdeC.Show()
            timerLabel.Stop()
            lblSig.Show()
            disabledComodines()

        End If

        If lblDOculto.Text = 1 Then
            lblD.BackColor = Color.FromArgb(83, 187, 97)
            pbVerdeD.Show()
            timerLabel.Stop()
            lblSig.Show()
            disabledComodines()
        End If

    End Sub

    Private Sub lblB_Click(sender As Object, e As EventArgs) Handles lblB.Click
        num1Score = 10 + lblTiempo.Text
        num2Score = lblScore.Text
        num3Score = num1Score + num2Score
        lblA.Enabled = False
        lblB.Enabled = False
        lblC.Enabled = False
        lblD.Enabled = False
        If lblBOculto.Text = 1 Then
            lblB.BackColor = Color.FromArgb(83, 187, 97)
            lblAcertar.Show()
            lblSig.Show()
            timerLabel.Stop()
            pbVerdeB.Show()
            lblScore.Text = num3Score
            disabledComodines()
        Else lblB.BackColor = Color.FromArgb(191, 83, 83)
            pbRojoB.Show()
            lblFallo.Show()
            timerLabel.Stop()
            disabledComodines()
        End If

        If lblAOculto.Text = 1 Then
            lblA.BackColor = Color.FromArgb(83, 187, 97)
            pbVerdeA.Show()
            timerLabel.Stop()
            lblSig.Show()
            disabledComodines()

        End If

        If lblCOculto.Text = 1 Then
            lblC.BackColor = Color.FromArgb(83, 187, 97)
            pbVerdeC.Show()
            timerLabel.Stop()
            lblSig.Show()
            disabledComodines()

        End If

        If lblDOculto.Text = 1 Then
            lblD.BackColor = Color.FromArgb(83, 187, 97)
            pbVerdeD.Show()
            timerLabel.Stop()
            lblSig.Show()
            disabledComodines()
        End If


    End Sub

    Private Sub lblC_Click(sender As Object, e As EventArgs) Handles lblC.Click
        num1Score = 10 + lblTiempo.Text
        num2Score = lblScore.Text
        num3Score = num1Score + num2Score
        lblA.Enabled = False
        lblB.Enabled = False
        lblC.Enabled = False
        lblD.Enabled = False
        If lblCOculto.Text = 1 Then
            lblC.BackColor = Color.FromArgb(83, 187, 97)
            lblAcertar.Show()
            lblSig.Show()
            timerLabel.Stop()
            pbVerdeC.Show()
            lblScore.Text = num3Score
            disabledComodines()
        Else lblC.BackColor = Color.FromArgb(191, 83, 83)
            pbRojoC.Show()
            lblFallo.Show()
            timerLabel.Stop()
            disabledComodines()
        End If

        If lblBOculto.Text = 1 Then
            lblB.BackColor = Color.FromArgb(83, 187, 97)
            pbVerdeB.Show()
            timerLabel.Stop()
            lblSig.Show()
            disabledComodines()

        End If

        If lblAOculto.Text = 1 Then
            lblA.BackColor = Color.FromArgb(83, 187, 97)
            pbVerdeA.Show()
            timerLabel.Stop()
            lblSig.Show()
            disabledComodines()

        End If

        If lblDOculto.Text = 1 Then
            lblD.BackColor = Color.FromArgb(83, 187, 97)
            pbVerdeD.Show()
            timerLabel.Stop()
            lblSig.Show()
            disabledComodines()
        End If


    End Sub

    Private Sub lblD_Click(sender As Object, e As EventArgs) Handles lblD.Click
        num1Score = 10 + lblTiempo.Text
        num2Score = lblScore.Text
        num3Score = num1Score + num2Score
        lblA.Enabled = False
        lblB.Enabled = False
        lblC.Enabled = False
        lblD.Enabled = False
        If lblDOculto.Text = 1 Then
            lblD.BackColor = Color.FromArgb(83, 187, 97)
            lblAcertar.Show()
            lblSig.Show()
            timerLabel.Stop()
            pbVerdeD.Show()
            lblScore.Text = num3Score
            disabledComodines()
        Else lblD.BackColor = Color.FromArgb(191, 83, 83)
            pbRojoD.Show()
            lblFallo.Show()
            timerLabel.Stop()
            disabledComodines()
        End If

        If lblBOculto.Text = 1 Then
            lblB.BackColor = Color.FromArgb(83, 187, 97)
            pbVerdeB.Show()
            timerLabel.Stop()
            lblSig.Show()
            disabledComodines()

        End If

        If lblCOculto.Text = 1 Then
            lblC.BackColor = Color.FromArgb(83, 187, 97)
            pbVerdeC.Show()
            timerLabel.Stop()
            lblSig.Show()
            disabledComodines()

        End If

        If lblAOculto.Text = 1 Then
            lblA.BackColor = Color.FromArgb(83, 187, 97)
            pbVerdeA.Show()
            timerLabel.Stop()
            lblSig.Show()
            disabledComodines()
        End If

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
        If num2 < 50 And num2 > 20 Then
            pbFoto.Show()
        End If
        If num2 < 22 Then
            pbFoto.Hide()
        End If

        If num2 <= 10 Then
            lblTiempo.Left = 319
            'lblTiempo.Text = "0" & num2 - 1 'para poner 0 delante en vez de solo un caracter
        End If
        If num2 = 1 Then
            timerLabel.Stop()
            pbLlamada.Enabled = False
            pbPublico.Enabled = False
            pbMitad.Enabled = False
            'cont = cont + 1
            'imagen.lblContPreg.Text = (cont & "/10")
            lblSig.Show()
            lblFallo.Show()

        End If

        If num2 = 20 Then
            timerFotoStop.Start()
        End If

    End Sub

    Private Sub lblSig_Click(sender As Object, e As EventArgs) Handles lblSig.Click
        'Me.Close()
        'imagen.Show()
        contLblPreg = contLblPreg + 1
        If contLblPreg < 10 Then
            lblContPreg.Text = "0" & contLblPreg
        Else lblContPreg.Text = contLblPreg
        End If
        ocultarPorcentajes()
        ocultarRespuestasRDY()
        lblTiempo.Left = 303
        data()
        timerFotoStart.Start()
        timerLabel.Start()
        lblTiempo.Text = 30
        timerLabel.Start()
        lblFallo.Hide()
        lblPista.Hide()
        lblNomPista.Hide()
        lblSig.Hide()
        enabledPreguntas()
        enabledComodines()
        lblAcertar.Hide()
        pbNaranjaA.Hide()
        pbNaranjaB.Hide()
        pbNaranjaD.Hide()
        pbNaranjaC.Hide()
        lblA.BackColor = Color.FromArgb(35, 31, 32)
        lblB.BackColor = Color.FromArgb(35, 31, 32)
        lblC.BackColor = Color.FromArgb(35, 31, 32)
        lblD.BackColor = Color.FromArgb(35, 31, 32)
    End Sub

    Private Sub pbLlamada_Click(sender As Object, e As EventArgs) Handles pbLlamada.Click
        lblPista.Show()
        lblNomPista.Show()
        disabledComodines()
        pbLlamada.Hide()
        pbLlamadaRed.Show()

    End Sub

    Private Sub pbPublico_Click(sender As Object, e As EventArgs) Handles pbPublico.Click
        'pbPublico.Hide()
        pbPublicoRed.Show()
        disabledComodines()
        mostrarPorcentajes()
        If lblAOculto.Text = 1 Then
            pb40.Location = New Point(8, 541)
            pb15.Location = New Point(933, 541)
            pb25.Location = New Point(933, 632)
            pb20.Location = New Point(8, 632)
        End If

        If lblBOculto.Text = 1 Then
            pb40.Location = New Point(933, 541)
            pb15.Location = New Point(933, 632)
            pb25.Location = New Point(8, 541)
            pb20.Location = New Point(8, 632)
        End If

        If lblCOculto.Text = 1 Then
            pb40.Location = New Point(8, 632)
            pb15.Location = New Point(8, 541)
            pb25.Location = New Point(933, 541)
            pb20.Location = New Point(933, 632)
        End If

        If lblDOculto.Text = 1 Then
            pb40.Location = New Point(933, 632)
            pb15.Location = New Point(933, 541)
            pb25.Location = New Point(8, 541)
            pb20.Location = New Point(8, 632)
        End If

    End Sub

    Private Sub pbMitad_Click(sender As Object, e As EventArgs) Handles pbMitad.Click
        'pbMitad.Hide()
        pbMitadRed.Show()
        disabledComodines()

        Dim contQues As Integer
        If lblAOculto.Text = 1 Then
            pbNaranjaA.Show()
            contQues = 1
            lblA.BackColor = Color.FromArgb(248, 155, 28)
            pbNaranjaB.Show()
            lblB.BackColor = Color.FromArgb(248, 155, 28)
        End If
        If lblBOculto.Text = 1 Then
            pbNaranjaB.Show()
            contQues = 2
            lblB.BackColor = Color.FromArgb(248, 155, 28)
            pbNaranjaC.Show()
            lblC.BackColor = Color.FromArgb(248, 155, 28)
        End If
        If lblCOculto.Text = 1 Then
            pbNaranjaC.Show()
            contQues = 3
            lblC.BackColor = Color.FromArgb(248, 155, 28)
            pbNaranjaD.Show()
            lblD.BackColor = Color.FromArgb(248, 155, 28)
        End If
        If lblDOculto.Text = 1 Then
            pbNaranjaD.Show()
            contQues = 4
            lblD.BackColor = Color.FromArgb(248, 155, 28)
            pbNaranjaA.Show()
            lblA.BackColor = Color.FromArgb(248, 155, 28)
        End If


    End Sub

    Public Function disabledPreguntas()
        lblA.Enabled = False
        lblB.Enabled = False
        lblC.Enabled = False
        lblD.Enabled = False
    End Function
    Public Function enabledPreguntas()
        lblA.Enabled = True
        lblB.Enabled = True
        lblC.Enabled = True
        lblD.Enabled = True
    End Function

    Public Function disabledComodines()
        pbLlamada.Enabled = False
        pbPublico.Enabled = False
        pbMitad.Enabled = False
    End Function

    Public Function enabledComodines()
        pbLlamada.Enabled = True
        pbPublico.Enabled = True
        pbMitad.Enabled = True
    End Function

    Public Function ocultarRespuestasRDY()
        pbVerdeA.Hide()
        pbVerdeB.Hide()
        pbVerdeC.Hide()
        pbVerdeD.Hide()
        pbRojoA.Hide()
        pbRojoB.Hide()
        pbRojoC.Hide()
        pbRojoD.Hide()
    End Function

    Public Function ocultarPorcentajes()
        pb40.Hide()
        pb15.Hide()
        pb25.Hide()
        pb20.Hide()
    End Function
    Public Function mostrarPorcentajes()
        pb40.Show()
        pb15.Show()
        pb25.Show()
        pb20.Show()
    End Function

    Private Function cambioColoresAP()
        pbRespuestas.BackColor = Color.Transparent
        pbMitad.BackColor = Color.Transparent
        pbLlamada.BackColor = Color.Transparent
        pbPublico.BackColor = Color.Transparent
        pbPregunta.BackColor = Color.Transparent
        pbLlamadaRed.BackColor = Color.Transparent
        pbPublicoRed.BackColor = Color.Transparent
        pbMitadRed.BackColor = Color.Transparent
        pbLlamadaRed.Hide()
        pbPublicoRed.Hide()
        pbMitadRed.Hide()
        lblPregunta.BackColor = Color.FromArgb(35, 31, 32)
        lblA.BackColor = Color.FromArgb(35, 31, 32)
        lblB.BackColor = Color.FromArgb(35, 31, 32)
        lblC.BackColor = Color.FromArgb(35, 31, 32)
        lblD.BackColor = Color.FromArgb(35, 31, 32)
        lblPregunta.ForeColor = Color.White
        lblA.ForeColor = Color.White
        lblB.ForeColor = Color.White
        lblC.ForeColor = Color.White
        lblD.ForeColor = Color.White
        lblScore.ForeColor = Color.White
        lblScoreNom.ForeColor = Color.White
        lblScore.BackColor = Color.Transparent
        lblScoreNom.BackColor = Color.Transparent
        lblTiempo.ForeColor = Color.White
        lblTiempo.BackColor = Color.Transparent
        pbSalir.BackColor = Color.Transparent
        pbVolver.BackColor = Color.Transparent
        lblSig.BackColor = Color.Transparent
        lblSig.ForeColor = Color.White
        lblAcertar.BackColor = Color.Transparent
        lblAcertar.ForeColor = Color.White
        lblFallo.BackColor = Color.Transparent
        lblFallo.ForeColor = Color.White
        lblSig.Hide()
        lblAcertar.Hide()
        lblFallo.Hide()
        lblPista.Hide()
        lblPista.BackColor = Color.Transparent
        lblPista.ForeColor = Color.White
        lblNomPista.Hide()
        lblNomPista.BackColor = Color.Transparent
        lblNomPista.ForeColor = Color.White
        lblAOculto.Hide()
        lblBOculto.Hide()
        lblCOculto.Hide()
        lblDOculto.Hide()
        pbVerdeA.BackColor = Color.Transparent
        pbVerdeB.BackColor = Color.Transparent
        pbVerdeC.BackColor = Color.Transparent
        pbVerdeD.BackColor = Color.Transparent
        pbRojoA.BackColor = Color.Transparent
        pbRojoB.BackColor = Color.Transparent
        pbRojoC.BackColor = Color.Transparent
        pbRojoD.BackColor = Color.Transparent
        ocultarRespuestasRDY()
        pbNaranjaA.Hide()
        pbNaranjaB.Hide()
        pbNaranjaD.Hide()
        pbNaranjaC.Hide()
        pbNaranjaA.BackColor = Color.Transparent
        pbNaranjaB.BackColor = Color.Transparent
        pbNaranjaC.BackColor = Color.Transparent
        pbNaranjaD.BackColor = Color.Transparent
        lblContPreg.BackColor = Color.Transparent
        lblVeinte.BackColor = Color.Transparent
        lblContPreg.ForeColor = Color.White
        lblVeinte.ForeColor = Color.White
        pb15.BackColor = Color.Transparent
        pb20.BackColor = Color.Transparent
        pb25.BackColor = Color.Transparent
        pb40.BackColor = Color.Transparent
        ocultarPorcentajes()
    End Function




End Class
