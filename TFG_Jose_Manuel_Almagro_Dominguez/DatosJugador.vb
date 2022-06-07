Imports System.Data.SqlClient

Public Class DatosJugador

    Public Property idPlayer As Integer
    Public Property namePlayer As String
    Private Sub DatosJugador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosJugador()
        ConexiónBD()
    End Sub
    Public Function DatosJugador()
        Dim consulta As String = "Select * from Player where id = " & idPlayer & " "
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

        namePlayer = ds.Tables(0).Rows(0)("username")
        Label1.Text = "Bienvenido " + namePlayer


    End Function

    Public Function ConexiónBD()

        Dim cadenaConexion As SqlConnectionStringBuilder = New SqlConnectionStringBuilder
        Dim conexion As SqlConnection
        Dim consulta2 As String
        Dim consulta As String
        Dim commando As SqlCommand
        Dim da As New SqlDataAdapter

        Dim ds As New DataSet

        consulta2 = "select * from Player"

        cadenaConexion.DataSource = "localhost\SQLEXPRESS"
        cadenaConexion.UserID = "sa"
        cadenaConexion.Password = "Otto13311331."
        cadenaConexion.InitialCatalog = "TFG_Jose_Manuel_Almagro_Dominguez_Juego"

        conexion = New SqlConnection(cadenaConexion.ConnectionString)
        consulta = "Select * from Players_Characters where IdJugador = " & idPlayer
        commando = New SqlCommand(consulta, conexion)

        conexion.Open()

        da.SelectCommand = commando

        conexion.Close()


        Dim dt = New DataTable()
        da.Fill(dt)
        dgvPersonajes.AutoGenerateColumns = True
        dgvPersonajes.DataSource = dt
        dgvPersonajes.AllowUserToAddRows = False
        dgvPersonajes.AllowUserToDeleteRows = False
        dgvPersonajes.AllowUserToResizeRows = False
        dgvPersonajes.AllowUserToResizeColumns = False
        dgvPersonajes.RowHeadersVisible = False
        dgvPersonajes.ReadOnly = True
        dgvPersonajes.EditMode = False
        dgvPersonajes.Columns(0).Visible = False
        dgvPersonajes.Columns(1).Visible = False

        dgvPersonajes.Refresh()
        commando = Nothing
        commando = New SqlCommand(consulta2, conexion)
        conexion.Open()
        da.SelectCommand = commando
        da.Fill(ds)

        conexion.Close()

    End Function
End Class