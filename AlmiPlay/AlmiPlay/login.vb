Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Windows.Forms
Public Class login


    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambioColoresLogin()
        regAct = 0
        'INSTANCIAMOS DEL DATASET
        dataSetAP = New DataSet() 
        'CREAMOS LA CONEXION
        conexionAP = New MySqlConnection("server=62.117.137.221;database=almi;user id=almi;password=Almi123;port=3306;characterset=UTF8")
        'CREAMOS EL DATA ADAPTER
        dataAdapterAP = New MySqlDataAdapter("select * from Usuarios", conexionAP)
        'GENERAMOS LOS COMANDOS DE ACTUALIZACIÓN DEL DATA ADAPTER (INSERT, UPDATE, DELETE)
        cmBuild = New MySqlCommandBuilder(dataAdapterAP)
        'EJECUTAR EL SELECTCOMMAND DEL DATAADAPTER
        regTotal = dataAdapterAP.Fill(dataSetAP, "Usuarios") 'EJECUTA EL SELECT
        'CARGAR LOS DATOS EN EL FORMULARIO
        If dataSetAP.Tables("Usuarios").Rows().Count() > 0 Then
            MsgBox("Conexion exitosa")
        End If

        
    End Sub

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click

        Dim consulta As String
        Dim lista As Byte
        'SI USU Y PASS NO ESTAN VACIOS, SE LE PASA LA CONSULTA AL DATADAPTER. DE AHI SE LE PASA EL DATASET A USUARIOS..    
        If txtUsuLog.Text <> "" And txtPass.Text <> "" Then
            consulta = "select * from Usuarios where usuario='" & txtUsuLog.Text & "' and pass='" & txtPass.Text & "'"
            dataAdapterAP = New MySqlDataAdapter(consulta, conexionAP)
            dataSetAP = New DataSet
            dataAdapterAP.Fill(dataSetAP, "Usuarios")
            lista = dataSetAP.Tables("Usuarios").Rows().Count()
        Else MsgBox("Rellene los campos correspondientes por favor.")
        End If

        If lista <> 0 Then
            MsgBox("¡Hola " & txtUsuLog.Text & "!" & " Pulsa en Aceptar para empezar tu partida.")
            AlmiPlay.Show()
            Me.Hide()
            conexionAP.Close()
        Else MsgBox("Intentelo de nuevo")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        AlmiPlay.Close()
        conexionAP.Close()
    End Sub

    Private Function cambioColoresLogin()
        txtPass.BackColor = Color.FromArgb(1, 8, 54)
        txtUsuLog.BackColor = Color.FromArgb(1, 8, 54)
        txtUsuLog.ForeColor = Color.White
        txtPass.ForeColor = Color.White
        btnJugar.BackColor = Color.FromArgb(213, 177, 67)
        btnSalir.BackColor = Color.FromArgb(0, 7, 71)
        btnSalir.ForeColor = Color.White
        btnOjo.BackColor = Color.FromArgb(1, 8, 54)

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
End Class