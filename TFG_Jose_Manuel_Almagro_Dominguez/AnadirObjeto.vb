

Imports System.Data.SqlClient

Public Class AnadirObjeto

    Public Property idCharacter As Integer
    Public cantidad As Integer
    Public itemid As Integer

    Public Function ConexiónBD()

        Dim cadenaConexion As SqlConnectionStringBuilder = New SqlConnectionStringBuilder
        Dim conexion As SqlConnection
        Dim consulta As String
        Dim commando As SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim ds As New DataSet


        cadenaConexion.DataSource = "localhost\SQLEXPRESS"
        cadenaConexion.UserID = "sa"
        cadenaConexion.Password = "Otto13311331."
        cadenaConexion.InitialCatalog = "TFG_Jose_Manuel_Almagro_Dominguez_Juego"

        conexion = New SqlConnection(cadenaConexion.ConnectionString)
        consulta = "Select * from Item"
        commando = New SqlCommand(consulta, conexion)


        conexion.Open()

        da.SelectCommand = commando
        da.Fill(dt)
        cbObjetos.DataSource = dt
        cbObjetos.DisplayMember = "name"
        cbObjetos.ValueMember = "id"
        conexion.Close()



    End Function
    Public Function AnadirObjeto()

        Dim cadenaConexion As SqlConnectionStringBuilder = New SqlConnectionStringBuilder
        Dim conexion As SqlConnection
        Dim commando As SqlCommand
        Dim consulta As String


        cadenaConexion.DataSource = "localhost\SQLEXPRESS"
        cadenaConexion.UserID = "sa"
        cadenaConexion.Password = "Otto13311331."
        cadenaConexion.InitialCatalog = "TFG_Jose_Manuel_Almagro_Dominguez_Juego"

        conexion = New SqlConnection(cadenaConexion.ConnectionString)
        consulta = "exec AddItem @idItem = " & itemid & ", @idCharacter =" & idCharacter & " ,@cantidad =" & cantidad
        commando = New SqlCommand(consulta, conexion)


        conexion.Open()

        commando.ExecuteNonQuery()

        conexion.Close()



    End Function
    Private Sub cbObjetos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbObjetos.SelectedIndexChanged
        Try
            itemid = cbObjetos.SelectedValue.ToString
        Catch ex As Exception
            itemid = 0
        End Try



    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        cantidad = CInt(NumericUpDown1.Value.ToString)
    End Sub

    Private Sub AnadirObjeto_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConexiónBD()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AnadirObjeto()
    End Sub
End Class