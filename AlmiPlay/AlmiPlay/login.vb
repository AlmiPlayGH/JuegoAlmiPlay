Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Windows.Forms
Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambioColoresLogin()
        llamadaBBDDLogin()
        musicaInicio()


    End Sub

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click, btnJugar.Enter, MyBase.Enter

        Dim consulta As String
        Dim lista As Byte
        Dim idUsuCon As String
        'SI USU Y PASS NO ESTAN VACIOS, SE LE PASA LA CONSULTA AL DATADAPTER. DE AHI SE LE PASA EL DATASET A USUARIOS..    
        If txtUsuLog.Text <> "" And txtPass.Text <> "" Then
            consulta = "select * from Usuarios where usuario='" & txtUsuLog.Text & "' and pass='" & txtPass.Text & "'"
            dataAdapterAP = New MySqlDataAdapter(consulta, conexionAP)
            dataSetAP = New DataSet
            dataAdapterAP.Fill(dataSetAP, "Usuarios")
            lista = dataSetAP.Tables("Usuarios").Rows().Count()
        Else MsgBox("Rellene los campos correspondientes por favor.")
            txtUsuLog.Focus()
        End If

        If lista <> 0 Then
            idUsu = dataSetAP.Tables("Usuarios").Rows(0).Item("id_usuario")
            usuLog = txtUsuLog.Text
            MsgBox("¡Hola " & txtUsuLog.Text & "!" & " Pulsa en Aceptar para empezar tu partida.")
            tematica.Show()
            Me.Hide()
            conexionAP.Close()
        Else MsgBox("Intentelo de nuevo")
            txtUsuLog.Focus()
        End If
        conexionAP.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Function cambioColoresLogin()
        txtPass.BackColor = Color.FromArgb(1, 8, 54)
        txtUsuLog.BackColor = Color.FromArgb(1, 8, 54)
        txtUsuLog.ForeColor = Color.White
        txtPass.ForeColor = Color.White
        btnJugar.BackColor = Color.FromArgb(213, 177, 67)
        btnScore.BackColor = Color.FromArgb(0, 7, 71)
        btnSalir.BackColor = Color.FromArgb(0, 7, 71)
        btnSalir.ForeColor = Color.White
        btnScore.ForeColor = Color.White
        btnOjo.BackColor = Color.FromArgb(1, 8, 54)
        lblIdUsuario.Hide()

    End Function

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        ' txtPass.CharacterCasing = CharacterCasing.Upper
        txtPass.PasswordChar = "*"
    End Sub

    Private Sub btnOjo_Click(sender As Object, e As EventArgs) Handles btnOjo.Click
        timePass.Start()
        If btnOjo.BackgroundImage IsNot Image.FromFile("eyeC.png") Then
            timePass1.Start()
        End If
    End Sub

    Private Sub timePass_Tick(sender As Object, e As EventArgs) Handles timePass.Tick
        btnOjo.BackgroundImage = Image.FromFile("eyeA.png")
        txtPass.PasswordChar = ""
        timePass.Stop()
    End Sub

    Private Sub timePass1_Tick(sender As Object, e As EventArgs) Handles timePass1.Tick
        btnOjo.BackgroundImage = Image.FromFile("eyeC.png")
        txtPass.PasswordChar = "*"
        timePass.Stop()
    End Sub

    Private Sub txtUsuLog_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuLog.KeyPress
        If Asc(e.KeyChar) = 32 Then
            txtPass.Focus()
        End If
    End Sub

    Private Sub login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        conexionAP.Close()
    End Sub

    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click
        Me.Hide()
        topDiez.Show()
    End Sub
End Class