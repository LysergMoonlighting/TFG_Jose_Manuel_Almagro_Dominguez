Imports System.Data.SqlClient

Public Class Inventario
    Public Property idCharacter As Integer
    Public Property idPlayer As Integer
    Public idItem As Integer

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConexionBD()
    End Sub

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
        consulta = "Select * from InventoryView where Id_Character = " & idCharacter & " and Id_Item > 4"
        commando = New SqlCommand(consulta, conexion)

        conexion.Open()

        da.SelectCommand = commando

        conexion.Close()


        Dim dt = New DataTable()
        da.Fill(dt)
        dgvInventario.AutoGenerateColumns = True
        dgvInventario.DataSource = dt
        dgvInventario.AllowUserToAddRows = False
        dgvInventario.AllowUserToDeleteRows = False
        dgvInventario.AllowUserToResizeRows = False
        dgvInventario.AllowUserToResizeColumns = False
        dgvInventario.RowHeadersVisible = False
        dgvInventario.ReadOnly = True
        dgvInventario.EditMode = False
        dgvInventario.Columns(0).Visible = False
        dgvInventario.Columns(1).Visible = False

        dgvInventario.Refresh()
        commando = Nothing
        commando = New SqlCommand(consulta2, conexion)
        conexion.Open()
        da.SelectCommand = commando
        da.Fill(ds)

        conexion.Close()
        Cobredbb()
        Platadbb()
        Orodbb()
        Adamantinodbb()


    End Function
    Public Function Cobredbb()
        Dim consulta As String = "Select * from InventoryView where Id_Character = " & idCharacter & " and Id_Item = 1"
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

        Cobre.Text = ds.Tables(0).Rows(0)("Cantidad")

    End Function
    Public Function Platadbb()
        Dim consulta As String = "Select * from InventoryView where Id_Character = " & idCharacter & " and Id_Item = 2"
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

        Plata.Text = ds.Tables(0).Rows(0)("Cantidad")

    End Function
    Public Function Orodbb()
        Dim consulta As String = "Select * from InventoryView where Id_Character = " & idCharacter & " and Id_Item = 3"
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

        Oro.Text = ds.Tables(0).Rows(0)("Cantidad")

    End Function

    Public Function Adamantinodbb()
        Dim consulta As String = "Select * from InventoryView where Id_Character = " & idCharacter & " and Id_Item = 4"
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

        Adamantino.Text = ds.Tables(0).Rows(0)("Cantidad")

    End Function
    Public Function EliminarObjeto()

        Dim cadenaConexion As SqlConnectionStringBuilder = New SqlConnectionStringBuilder
        Dim conexion As SqlConnection
        Dim commando As SqlCommand
        Dim consulta As String


        cadenaConexion.DataSource = "localhost\SQLEXPRESS"
        cadenaConexion.UserID = "sa"
        cadenaConexion.Password = "Otto13311331."
        cadenaConexion.InitialCatalog = "TFG_Jose_Manuel_Almagro_Dominguez_Juego"

        conexion = New SqlConnection(cadenaConexion.ConnectionString)
        consulta = "Delete from Inventory where character_Id = " & idCharacter & " and item_Id = " & idItem & ""
        commando = New SqlCommand(consulta, conexion)


        conexion.Open()

        commando.ExecuteNonQuery()

        conexion.Close()



    End Function


    Private Sub dgvInventario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventario.CellClick
        idItem = CInt(dgvInventario.CurrentRow.Cells(1).Value.ToString)


    End Sub

    Private Sub BorrarItem_Click(sender As Object, e As EventArgs) Handles BorrarItem.Click

        EliminarObjeto()

        ConexionBD()

    End Sub

    Private Sub Desconectar_Click(sender As Object, e As EventArgs) Handles Desconectar.Click
        MenuPersonaje.idCharacter = idCharacter
        MenuPersonaje.idPlayer = idPlayer
        MenuPersonaje.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class