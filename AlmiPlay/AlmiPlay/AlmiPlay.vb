﻿Imports System.Web.Services
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.ComponentModel
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Imports System.Text
Imports System
Imports System.IO
Imports System.Web.Script.Serialization
Imports System.Threading

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
        If contSonido = 0 Then
            musicaPreguntaUno()
            pbMusicYes.Show()
            pbMusicNou.Hide()
        End If
        If contSonido = 1 Then
            pbMusicYes.Hide()
            pbMusicNou.Show()
        End If

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
            Dim contAux As Integer

            If selecTema = 0 Then
               
                contId = Int((29 * Rnd()) + 1)
                contAux = 1
                Do
                    For i = 0 To 19 Step 1
                        If contId = randomRep(i) Then
                            contAux = contAux + 1
                        End If
                    Next
                    If contAux = 1 Then
                        'MsgBox("Todo bien")
                        Exit Do
                    End If
                    If contAux > 1 Then
                        contId = Int((29 * Rnd()) + 1)
                        contAux = 1
                        'MsgBox("Repetida")
                    End If
                Loop While contAux > 0


            Else 
                contId = Int((29 * Rnd()) + 31)
                contAux = 1
                Do
                    For i = 0 To 19 Step 1
                        If contId = randomRep(i) Then
                            contAux = contAux + 1
                        End If
                    Next
                    If contAux = 1 Then
                        'MsgBox("Todo bien")
                        Exit Do
                    End If
                    If contAux > 1 Then
                        contId = Int((29 * Rnd()) + 31)
                        contAux = 1
                        'MsgBox("Repetida")
                    End If
                Loop While contAux > 0

            End If
            randomRep(contRepe) = contId
            contPregunta = 1
            'URL CON POSICION DE CAMPO ALEATORIA
            url = "http://62.117.137.221:8181/api/preguntas/" & contId
            foto = "http://62.117.137.221:8181/api/preguntas/imagen/" & contId & ".jpg"
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
            txtExplicacion.Text = json.SelectToken("data.texto")
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
            If Len(lblA.Text) > 50 Then
                lblA.Font = New System.Drawing.Font("Arial Rounded MT", 7, FontStyle.Bold)
            End If
            If Len(lblB.Text) > 50 Then
                lblB.Font = New System.Drawing.Font("Arial Rounded MT", 7, FontStyle.Bold)
            End If
            If Len(lblC.Text) > 50 Then
                lblC.Font = New System.Drawing.Font("Arial Rounded MT", 7, FontStyle.Bold)
            End If
            If Len(lblD.Text) > 50 Then
                lblD.Font = New System.Drawing.Font("Arial Rounded MT", 7, FontStyle.Bold)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function sumaScore()
        num1Score = 10 + lblTiempo.Text
        num2Score = lblScore.Text
        num3Score = num1Score + num2Score
    End Function
    Private Sub lblA_Click(sender As Object, e As EventArgs) Handles lblA.Click
        pbCirculoTime.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
        pbCirculoTime.Refresh()
        musicaStop()
        lblA.Enabled = False
        lblB.Enabled = False
        lblC.Enabled = False
        lblD.Enabled = False
        mostrarExpli()
        If lblAOculto.Text = 1 Then
            If contSonido = 0 Then
                musicaAcierto()
            End If
            lblA.BackColor = Color.FromArgb(83, 187, 97)
                lblAcertar.Show()
                lblSig.Show()
                timerLabel.Stop()
                pbVerdeA.Show()
                sumaScore()
                lblScore.Text = num3Score
                disabledComodines()
                contCorrectas = contCorrectas + 1
            Else lblA.BackColor = Color.FromArgb(191, 83, 83)
            If contSonido = 0 Then
                musicaError()
            End If
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
        pbCirculoTime.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
        pbCirculoTime.Refresh()
        musicaStop()
        lblA.Enabled = False
        lblB.Enabled = False
        lblC.Enabled = False
        lblD.Enabled = False
        mostrarExpli()
        If lblBOculto.Text = 1 Then
            If contSonido = 0 Then
                musicaAcierto()
            End If
            lblB.BackColor = Color.FromArgb(83, 187, 97)
            lblAcertar.Show()
            lblSig.Show()
            timerLabel.Stop()
            pbVerdeB.Show()
            sumaScore()
            lblScore.Text = num3Score
            disabledComodines()
            contCorrectas = contCorrectas + 1
        Else lblB.BackColor = Color.FromArgb(191, 83, 83)
            If contSonido = 0 Then
                musicaError()
            End If
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
        pbCirculoTime.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
        pbCirculoTime.Refresh()
        musicaStop()
        lblA.Enabled = False
        lblB.Enabled = False
        lblC.Enabled = False
        lblD.Enabled = False
        mostrarExpli()
        If lblCOculto.Text = 1 Then
            If contSonido = 0 Then
                musicaAcierto()
            End If
            lblC.BackColor = Color.FromArgb(83, 187, 97)
            lblAcertar.Show()
            lblSig.Show()
            timerLabel.Stop()
            pbVerdeC.Show()
            sumaScore()
            lblScore.Text = num3Score
            disabledComodines()
            contCorrectas = contCorrectas + 1
        Else lblC.BackColor = Color.FromArgb(191, 83, 83)
            If contSonido = 0 Then
                musicaError()
            End If
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
        pbCirculoTime.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
        pbCirculoTime.Refresh()
        musicaStop()
        lblA.Enabled = False
        lblB.Enabled = False
        lblC.Enabled = False
        lblD.Enabled = False
        mostrarExpli()
        If lblDOculto.Text = 1 Then
            If contSonido = 0 Then
                musicaAcierto()
            End If
            lblD.BackColor = Color.FromArgb(83, 187, 97)
            lblAcertar.Show()
            lblSig.Show()
            timerLabel.Stop()
            pbVerdeD.Show()
            sumaScore()
            lblScore.Text = num3Score
            disabledComodines()
            contCorrectas = contCorrectas + 1
        Else lblD.BackColor = Color.FromArgb(191, 83, 83)
            If contSonido = 0 Then
                musicaError()
            End If
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
        If contSonido = 0 Then
            musicaInicio()
        End If
        Me.Close()
        login.Show()
    End Sub

    Private Sub pbSalir_Click(sender As Object, e As EventArgs) Handles pbSalir.Click
        End
    End Sub

    Private Sub timerLabel_Tick(sender As Object, e As EventArgs) Handles timerLabel.Tick

        Dim num1, num2 As Integer
        num1 = 1
        num2 = lblTiempo.Text
        lblTiempo.Text = num2 - 1
        tiempoTardado = tiempoTardado + 1
        If num2 < 50 And num2 > 20 Then
            pbFoto.Show()
        End If
        If num2 < 22 Then
            lblTiempo.Show()
            pbFoto.Hide()
        End If

        If num2 <= 10 Then
            lblTiempo.Left = 319
            'lblTiempo.Text = "0" & num2 - 1 'para poner 0 delante en vez de solo un caracter
        End If
        If num2 = 1 Then
            musicaStop()
            musicaError()
            timerLabel.Stop()
            mostrarExpli()
            pbLlamada.Enabled = False
            pbPublico.Enabled = False
            pbMitad.Enabled = False
            disabledPreguntas()
            'cont = cont + 1
            'imagen.lblContPreg.Text = (cont & "/10")
            lblSig.Show()
            lblSeAcabo.Show()
            If lblAOculto.Text = 1 Then
                pbNaranjaA.Show()
                lblA.BackColor = Color.FromArgb(248, 155, 28)
            ElseIf lblBOculto.Text = 1 Then
                pbNaranjaB.Show()
                lblB.BackColor = Color.FromArgb(248, 155, 28)
            ElseIf lblCOculto.Text = 1 Then
                pbNaranjaC.Show()
                lblC.BackColor = Color.FromArgb(248, 155, 28)
            ElseIf lblDOculto.Text = 1 Then
                pbNaranjaD.Show()
                lblD.BackColor = Color.FromArgb(248, 155, 28)
            End If
        End If

        If num2 = 20 Then
            timerFotoStop.Start()
        End If

    End Sub

    Private Sub lblSig_Click(sender As Object, e As EventArgs) Handles lblSig.Click
        'Me.Close()
        'imagen.Show()
        lblTiempo.Hide()
        contLblPreg = contLblPreg + 1
        If contLblPreg < 10 Then
            lblContPreg.Text = "0" & contLblPreg
            If contSonido = 0 Then
                musicaPreguntaUno()
            End If
        Else lblContPreg.Text = contLblPreg
            If contSonido = 0 Then
                musicaPreguntaDos()
            End If
            'If contLblPreg > 19 Then
            '    lblSig.Text = "Finalizar"
            'End If
            If contLblPreg > 20 Then
                musicaStop()
                fin.Show()
                Me.Hide()
            End If
        End If
            tiempoTardado = tiempoTardado - 10
        totalScore = lblScore.Text
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
        lblA.Font = New System.Drawing.Font("Arial Rounded MT", 10, FontStyle.Bold)
        lblB.Font = New System.Drawing.Font("Arial Rounded MT", 10, FontStyle.Bold)
        lblC.Font = New System.Drawing.Font("Arial Rounded MT", 10, FontStyle.Bold)
        lblD.Font = New System.Drawing.Font("Arial Rounded MT", 10, FontStyle.Bold)
        txtExplicacion.Hide()
        contRepe=contRepe+1
        lblSeAcabo.Hide()
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

    Public Function mostrarExpli()
        If selecTema = 1 Then
            txtExplicacion.Show()
        End If

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
        contCorrectas = 0
        fechaActual = Date.Now
        txtExplicacion.BackColor = Color.FromArgb(35, 31, 32)
        txtExplicacion.ForeColor = Color.White
        txtExplicacion.Hide()
        calcularFecha()
        lblSeAcabo.Hide()
        lblSeAcabo.BackColor = Color.Transparent
        lblSeAcabo.ForeColor = Color.White
        pbCirculoTime.BackColor = Color.Transparent
        pbMusicNou.Hide()
        pbMusicYes.BackColor = Color.Transparent
        pbMusicNou.BackColor = Color.Transparent


    End Function

    Private Sub pbMusic_Click(sender As Object, e As EventArgs) Handles pbMusicYes.Click
        pbMusicNou.Show()
        pbMusicYes.Hide()
        musicaStop()
        contSonido = contSonido + 1
    End Sub

    Private Sub pbMusicNO_Click(sender As Object, e As EventArgs) Handles pbMusicNou.Click
        pbMusicNou.Hide()
        pbMusicYes.Show()
        musicaPreguntaUno()
        contSonido = contSonido - 1
    End Sub
End Class
