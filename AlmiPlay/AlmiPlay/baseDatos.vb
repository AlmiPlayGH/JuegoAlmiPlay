Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Windows.Forms
Module baseDatos
    Public cont As Integer
    Public conexionAP As MySqlConnection
    Public dataAdapterAP As MySqlDataAdapter
    Public comando As MySqlCommand
    Public cmBuild As MySqlCommandBuilder
    Public dataSetAP As DataSet
    Public regAct As Integer
    Public regTotal As Integer
    Public dataReaderAP As MySqlDataReader
    Public dataRowAP As DataRow
    Public num1Score, num2Score, num3Score As Integer
    Public contCorrectas As Integer
    Public fechaActual As Date
    Public dia As String
    Public mes As String
    Public año As String
    Public fecha As String
    Public idUsu As Integer
    Public usuLog As String
    Public totalScore As String
    Public tiempoTardado As Integer
    Public selecTema As Integer
    Public randomRep (19) As Integer
    Public contRepe As Integer

    Public Function llamadaBBDDLogin()
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
    End Function

    Public Function llamadaBBDDScore()
        regAct = 0
        'INSTANCIAMOS DEL DATASET
        dataSetAP = New DataSet()
        'CREAMOS LA CONEXION
        conexionAP = New MySqlConnection("server=62.117.137.221;database=almi;user id=almi;password=Almi123;port=3306;characterset=UTF8")
        'CREAMOS EL DATA ADAPTER
        dataAdapterAP = New MySqlDataAdapter("select * from Puntuaciones", conexionAP)
        'GENERAMOS LOS COMANDOS DE ACTUALIZACIÓN DEL DATA ADAPTER (INSERT, UPDATE, DELETE)
        cmBuild = New MySqlCommandBuilder(dataAdapterAP)
        'EJECUTAR EL SELECTCOMMAND DEL DATAADAPTER
        regTotal = dataAdapterAP.Fill(dataSetAP, "Puntuaciones") 'EJECUTA EL SELECT
        'CARGAR LOS DATOS EN EL FORMULARIO
        If dataSetAP.Tables("Puntuaciones").Rows().Count() > 0 Then
            MsgBox("Conexion exitosa")
        End If
    End Function

    Public Function calcularFecha()
        dia = DateTime.Now.ToString("dd")
        mes = DateTime.Now.ToString("MM")
        año = DateTime.Now.ToString("yyyy")
        fecha = año & "-" & mes & "-" & dia
    End Function

End Module


