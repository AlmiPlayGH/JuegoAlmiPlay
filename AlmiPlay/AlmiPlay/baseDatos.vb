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

'If lblAOculto.Text = 0 Or lblBOculto.Text = 0 Or lblCOculto.Text = 0 Or lblDOculto.Text = 0 Then
'    Dim contQuiza As Integer
'    Dim auxQuiza As Integer
'    auxQuiza = 0
'    Do
'        contQuiza = Int((4 * Rnd()) + 1)
'        For contPreg As Integer = 1 To 4 Step 1
'            If contPreg = contQuiza And contQuiza = 1 And contQues <> 1 Then
'                pbNaranjaA.Show()
'                auxQuiza = 1
'                Exit For
'            ElseIf contPreg = contQuiza And contQuiza = 2 And contQues <> 2 Then
'                pbNaranjaB.Show()
'                auxQuiza = 1
'                Exit For
'            ElseIf contPreg = contQuiza And contQuiza = 3 And contQues <> 3 Then
'                pbNaranjaC.Show()
'                auxQuiza = 1
'                Exit For
'            ElseIf contPreg = contQuiza And contQuiza = 4 And contQues <> 4 Then
'                pbNaranjaD.Show()
'                auxQuiza = 1
'                Exit For
'            End If
'        Next
'    Loop Until auxQuiza = 0
'End If

'op.InitialDirectory = foto
'If op.ShowDialog = Windows.Forms.DialogResult.OK Then
'pbFoto.Image = Image.FromFile(op.FileName)
'End If