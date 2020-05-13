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

    Private Sub AlmiPLay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Randomize()
        cambioColoresAP()
        timerLabel.Start()
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
            Dim responseBody As String
            Dim jsonWeb As String
            Dim url As String
            contId = Int((26 * Rnd()) + 1)
            'URL CON POSICION DE CAMPO ALEATORIA
            url = "http://62.117.137.221:8181/api/preguntas/" & contId
            'SE OBITENE EL JSON EN LA VARIABLE RESPONSEBODY
            Dim response = Await cliente.GetAsync(url)
            response.EnsureSuccessStatusCode()
            responseBody = Await response.Content.ReadAsStringAsync()

            Dim exampleJson As String = "{ 'no':'123', 'name':'Some Name', 'com':'This is a comment'}"
            Dim json As JObject = JObject.Parse(responseBody)
            jsonWeb = JsonConvert.SerializeObject(json, Formatting.Indented, New JsonSerializerSettings()) 'STRING DEL JSON CORRESPONDIENTE
            lblPregunta.Text = json.SelectToken("data.pregunta")
            lblPista.Text = json.SelectToken("data.pista")
            'MsgBox(json.SelectToken("data.respuesta[2][1]"))
            'MsgBox(jsonWeb)
            'MsgBox(json.SelectToken("data[0].respuestas[1]"))


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Function bd()

    End Function

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
            lblPerdido.Show()

        End If

        If num2 = 20 Then
            timerFotoStop.Start()
        End If

    End Sub

    Private Function cambioColoresAP()

        pbRespuestas.BackColor = Color.Transparent
        pbMitad.BackColor = Color.Transparent
        pbLlamada.BackColor = Color.Transparent
        pbPublico.BackColor = Color.Transparent
        pbPregunta.BackColor = Color.Transparent
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
        lblPista.Hide()
        lblPista.BackColor = Color.Transparent
        lblPista.ForeColor = Color.White
        lblNomPista.Hide()
        lblNomPista.BackColor = Color.Transparent
        lblNomPista.ForeColor = Color.White

    End Function

    Private Sub lblSig_Click(sender As Object, e As EventArgs) Handles lblSig.Click
        'Me.Close()
        'imagen.Show()
        lblTiempo.Left = 303
        data()
        timerFotoStart.Start()
        timerLabel.Start()
        lblTiempo.Text = 30
        pbLlamada.Enabled = True
        pbPublico.Enabled = True
        pbMitad.Enabled = True
        timerLabel.Start()
        lblPerdido.Hide()
        lblPista.Hide()
        lblNomPista.Hide()
        lblSig.Hide()
    End Sub

    Private Sub pbLlamada_Click(sender As Object, e As EventArgs) Handles pbLlamada.Click
        lblPista.Show()
        lblNomPista.Show()
    End Sub


End Class
