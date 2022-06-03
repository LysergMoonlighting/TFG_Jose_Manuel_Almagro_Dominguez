Imports System.Data.SqlClient

Public Class Loging
    Dim chek As Boolean
    Dim idPlayer As Integer
    Private Sub ButtonRegistrar_Click(sender As Object, e As EventArgs) Handles ButtonRegistrar.Click
        Registrar.Show()
    End Sub

    Private Sub ButtonEntrar_Click(sender As Object, e As EventArgs) Handles ButtonEntrar.Click
        Comprobante()
        If chek Then
            Dim DatosJugadorView As New DatosJugador
            DatosJugadorView.idPlayer = idPlayer
            DatosJugadorView.Show()
            Me.Hide()
        End If
    End Sub
    Public Function Comprobante()
        Dim consulta As String = "Select * from Player where username ='" + user.Text + "' and pasword = '" + pasw.Text + "' or email ='" + user.Text + "' and pasword = '" + pasw.Text + "'"
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
        If String.IsNullOrEmpty(user.Text) Or String.IsNullOrEmpty(pasw.Text) Then
            logingerrorText.Text = "Usuario o Contraseña no introducido"
            chek = False
        Else
            If ds.Tables(0).Rows.Count.ToString = "0" Then
                logingerrorText.Text = "Usuario o contraseña mal escritos"
                chek = False
            Else
                idPlayer = ds.Tables(0).Rows(0)("id")
                chek = True
            End If

        End If



    End Function

End Class