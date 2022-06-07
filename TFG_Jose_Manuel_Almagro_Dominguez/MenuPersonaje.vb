Imports System.Data.SqlClient

Public Class MenuPersonaje
    Public Property idCharacter As Integer
    Public Property idPlayer As Integer
    Dim nameCharacter As String
    Dim idRace As Integer
    Dim nameRace As String


    Public Function DatosPersonaje()
        Dim consulta As String = "Select * from Character where id = " & idCharacter & " "
        Dim cadenaConexion As SqlConnectionStringBuilder = New SqlConnectionStringBuilder
        Dim conexion As SqlConnection
        Dim commando As SqlCommand
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter


        cadenaConexion.DataSource = "localhost\SQLEXPRESS"
        cadenaConexion.UserID = "sa"
        cadenaConexion.Password = "Otto13311331."
        cadenaConexion.InitialCatalog = "TFG_Jose_Manuel_Almagro_Dominguez_Juego"

        conexion = New SqlConnection(cadenaConexion.ConnectionString)


        commando = New SqlCommand(consulta, conexion)

        conexion.Open()
        da.SelectCommand = commando
        da.Fill(ds)
        conexion.Close()

        nameCharacter = ds.Tables(0).Rows(0)("name")
        idRace = CInt(ds.Tables(0).Rows(0)("race_id"))
    End Function
    Public Function DatosRaza()
        Dim consulta As String = "Select * from Race where id = " & idRace & " "
        Dim cadenaConexion As SqlConnectionStringBuilder = New SqlConnectionStringBuilder
        Dim conexion As SqlConnection
        Dim commando As SqlCommand
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter


        cadenaConexion.DataSource = "localhost\SQLEXPRESS"
        cadenaConexion.UserID = "sa"
        cadenaConexion.Password = "Otto13311331."
        cadenaConexion.InitialCatalog = "TFG_Jose_Manuel_Almagro_Dominguez_Juego"

        conexion = New SqlConnection(cadenaConexion.ConnectionString)


        commando = New SqlCommand(consulta, conexion)

        conexion.Open()
        da.SelectCommand = commando
        da.Fill(ds)
        conexion.Close()

        nameRace = ds.Tables(0).Rows(0)("name")

    End Function

    Private Sub MenuPersonaje_Load(sender As Object, e As EventArgs) Handles Me.Load
        DatosPersonaje()
        DatosRaza()
        Label1.Text = nameCharacter + " el " + nameRace
    End Sub

    Private Sub Desconectar_Click(sender As Object, e As EventArgs) Handles Desconectar.Click
        DatosJugador.idPlayer = idPlayer
        DatosJugador.Show()

        Me.Hide()
    End Sub
End Class