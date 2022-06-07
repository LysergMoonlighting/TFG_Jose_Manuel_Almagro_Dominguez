Imports System.Data.SqlClient

Public Class DatosJugador

    Public Property idPlayer As Integer
    Public Property namePlayer As String
    Dim characterToUse As Integer
    Private Sub DatosJugador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosJugador()
        ConexionBD()
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

    Public Function ConexionBD()

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
    Public Function EliminarPersonaje()

        Dim cadenaConexion As SqlConnectionStringBuilder = New SqlConnectionStringBuilder
        Dim conexion As SqlConnection
        Dim commando As SqlCommand
        Dim consulta As String


        cadenaConexion.DataSource = "localhost\SQLEXPRESS"
        cadenaConexion.UserID = "sa"
        cadenaConexion.Password = "Otto13311331."
        cadenaConexion.InitialCatalog = "TFG_Jose_Manuel_Almagro_Dominguez_Juego"

        conexion = New SqlConnection(cadenaConexion.ConnectionString)
        consulta = "delete From Character where id = " & characterToUse
        commando = New SqlCommand(consulta, conexion)


        conexion.Open()

        commando.ExecuteNonQuery()

        conexion.Close()



    End Function
    Public Function EliminarJugador()

        Dim cadenaConexion As SqlConnectionStringBuilder = New SqlConnectionStringBuilder
        Dim conexion As SqlConnection
        Dim commando As SqlCommand
        Dim consulta As String


        cadenaConexion.DataSource = "localhost\SQLEXPRESS"
        cadenaConexion.UserID = "sa"
        cadenaConexion.Password = "Otto13311331."
        cadenaConexion.InitialCatalog = "TFG_Jose_Manuel_Almagro_Dominguez_Juego"

        conexion = New SqlConnection(cadenaConexion.ConnectionString)
        consulta = "delete From Player where id = " & idPlayer
        commando = New SqlCommand(consulta, conexion)


        conexion.Open()

        commando.ExecuteNonQuery()

        conexion.Close()



    End Function

    Private Sub recargar_Click(sender As Object, e As EventArgs) Handles recargar.Click
        ConexionBD()
    End Sub

    Private Sub Desconectar_Click(sender As Object, e As EventArgs) Handles Desconectar.Click

        Loging.Show()
        Me.Hide()

    End Sub

    Private Sub btCrear_Click(sender As Object, e As EventArgs) Handles btCrear.Click
        Dim CrearPJview = New CrearPJ
        CrearPJview.idPlayer = idPlayer
        CrearPJview.Show()

    End Sub

    Private Sub BttEliminarCharacter_Click(sender As Object, e As EventArgs) Handles BttEliminarCharacter.Click
        EliminarPersonaje()
        ConexionBD()
    End Sub

    Private Sub dgvPersonajes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPersonajes.CellClick
        characterToUse = CInt(dgvPersonajes.CurrentRow.Cells(0).Value.ToString)
    End Sub

    Private Sub dgvPersonajes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPersonajes.CellDoubleClick
        characterToUse = CInt(dgvPersonajes.CurrentRow.Cells(0).Value.ToString)

        MenuPersonaje.idPlayer = idPlayer
        MenuPersonaje.idCharacter = characterToUse
        MenuPersonaje.Show()
        Me.Hide()

    End Sub

    Private Sub Entrar_Click(sender As Object, e As EventArgs) Handles Entrar.Click
        MenuPersonaje.idPlayer = idPlayer
        MenuPersonaje.idCharacter = characterToUse
        MenuPersonaje.Show()
        Me.Hide()
    End Sub

    Private Sub EliminarCuenta_Click(sender As Object, e As EventArgs) Handles EliminarCuenta.Click
        EliminarJugador()
        Loging.Show()
        Me.Hide()
    End Sub
End Class