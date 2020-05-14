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
    Public num1Score, num2Score, num3Score As Integer

End Module
