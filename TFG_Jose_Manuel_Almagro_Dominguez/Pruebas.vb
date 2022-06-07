Imports System.Data.SqlClient

Public Class Pruebas
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexiónBD()
    End Sub

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
        consulta = "Select * from Player"
        commando = New SqlCommand(consulta, conexion)

        conexion.Open()

        da.SelectCommand = commando

        conexion.Close()


        Dim dt = New DataTable()
        da.Fill(dt)
        Tabla1.AutoGenerateColumns = True
        Tabla1.DataSource = dt
        Tabla1.AllowUserToAddRows = False
        Tabla1.AllowUserToDeleteRows = False
        Tabla1.AllowUserToResizeRows = False
        Tabla1.AllowUserToResizeColumns = False
        Tabla1.ReadOnly = True
        Tabla1.EditMode = False

        Dim dt2 = New DataTable()


        Tabla2.AutoGenerateColumns = True
        Tabla2.AllowUserToAddRows = False
        Tabla2.AllowUserToDeleteRows = False
        Tabla2.AllowUserToResizeRows = False
        Tabla2.AllowUserToResizeColumns = False
        Tabla2.ReadOnly = True
        Tabla2.EditMode = False


        Tabla2.Refresh()
        Tabla1.Refresh()
        commando = Nothing
        commando = New SqlCommand(consulta2, conexion)
        conexion.Open()
        da.SelectCommand = commando
        da.Fill(ds)

        conexion.Close()
        Label1.Text = ds.Tables(0).Rows.Count.ToString
    End Function


    Private Sub Tabla1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla1.CellClick
        Label1.Text = Tabla1.CurrentRow.Cells(0).Value.ToString
        Label1.Refresh()
    End Sub


    Private Sub Tabla1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla1.CellDoubleClick
        Dim dt2 = New DataTable()
        dt2 = Tabla2.DataSource



        dt2.Rows.Add(Tabla1.CurrentRow)

        Tabla2.DataSource = dt2

        Tabla2.Refresh()

    End Sub


    Private Sub Tabla2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla2.CellDoubleClick


        Tabla2.Rows.Remove(Tabla2.CurrentRow)

        Tabla2.Refresh()
    End Sub




End Class

