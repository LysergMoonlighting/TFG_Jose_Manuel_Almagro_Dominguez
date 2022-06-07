Imports System.Data.SqlClient

Public Class CrearPJ

    Public Property idPlayer As Integer
    Dim characterName As String
    Dim idRace As Integer

    Public Function ConexiónBD()

        Dim cadenaConexion As SqlConnectionStringBuilder = New SqlConnectionStringBuilder
        Dim conexion As SqlConnection
        Dim consulta2 As String
        Dim consulta As String
        Dim commando As SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet

        consulta2 = "select * from Player"

        cadenaConexion.DataSource = "localhost\SQLEXPRESS"
        cadenaConexion.UserID = "sa"
        cadenaConexion.Password = "Otto13311331."
        cadenaConexion.InitialCatalog = "TFG_Jose_Manuel_Almagro_Dominguez_Juego"

        conexion = New SqlConnection(cadenaConexion.ConnectionString)
        consulta = "Select * from Race"
        commando = New SqlCommand(consulta, conexion)


        conexion.Open()

        da.SelectCommand = commando
        da.Fill(dt)
        cbRace.DataSource = dt
        cbRace.DisplayMember = "name"
        cbRace.ValueMember = "id"
        conexion.Close()



    End Function

    Public Function CrearPersonaje()

        Dim cadenaConexion As SqlConnectionStringBuilder = New SqlConnectionStringBuilder
        Dim conexion As SqlConnection
        Dim commando As SqlCommand
        Dim consulta As String


        cadenaConexion.DataSource = "localhost\SQLEXPRESS"
        cadenaConexion.UserID = "sa"
        cadenaConexion.Password = "Otto13311331."
        cadenaConexion.InitialCatalog = "TFG_Jose_Manuel_Almagro_Dominguez_Juego"

        conexion = New SqlConnection(cadenaConexion.ConnectionString)
        consulta = "exec CreateCharacter @playerId = " & idPlayer & ",@name = '" + characterName + "' , @raceId =" & idRace
        commando = New SqlCommand(consulta, conexion)


        conexion.Open()

        commando.ExecuteNonQuery()

        conexion.Close()



    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        characterName = tbcharacterName.Text
        idRace = cbRace.SelectedIndex + 1
        CrearPersonaje()
        Me.Hide()


    End Sub

    Private Sub CrearPJ_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConexiónBD()
    End Sub


    Private Sub tbcharacterName_LostFocus(sender As Object, e As EventArgs) Handles tbcharacterName.LostFocus
        characterName = tbcharacterName.Text
    End Sub

    Private Sub cbRace_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRace.SelectedIndexChanged

        idRace = cbRace.SelectedIndex + 1


    End Sub
End Class