Imports System.Data.SqlClient

Public Class Registrar
    Dim chek As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usertext As String
        Dim paswtext As String
        Dim emailtext As String
        Dim consulta As String
        usertext = user.Text
        paswtext = pasw.Text
        emailtext = email.Text

        consulta = "Insert into Player values ('" + usertext + "','" + paswtext + "','" + emailtext + "');"

        Comprobante()
        If String.IsNullOrEmpty(user.Text) Then
            Errorlabel.Text = "El usuario no puede estar vacio"
        Else
            If chek = True Then
                If String.IsNullOrEmpty(pasw.Text) Then
                    Errorlabel.Text = "La contraseña no puede estar vacia"
                Else
                    If passwchek.Text = pasw.Text Then
                        If String.IsNullOrEmpty(email.Text) Then
                            Errorlabel.Text = "El email no puede estar vacia"
                        Else
                            If emailchek.Text = email.Text Then
                                ConexiónBD(consulta)
                                MsgBox("Usuario Creado")

                                user.Text = Nothing
                                pasw.Text = Nothing
                                passwchek.Text = Nothing
                                email.Text = Nothing
                                emailchek.Text = Nothing

                                usererror.Text = ""
                                Me.Hide()

                            Else
                                Errorlabel.Text = "El email no coincide"
                            End If
                        End If

                    Else
                        Errorlabel.Text = "La contraseña no coincide"
                    End If
                End If
            Else
                Errorlabel.Text = "El usuario ya existe"
            End If
        End If


    End Sub



    Private Sub user_Leave(sender As Object, e As EventArgs) Handles user.Leave
        Comprobante()
    End Sub

    Public Function ConexiónBD(consulta As String)

        Dim cadenaConexion As SqlConnectionStringBuilder = New SqlConnectionStringBuilder
        Dim conexion As SqlConnection
        Dim commando As SqlCommand



        cadenaConexion.DataSource = "localhost\SQLEXPRESS"
        cadenaConexion.UserID = "sa"
        cadenaConexion.Password = "Otto13311331."
        cadenaConexion.InitialCatalog = "TFG_Jose_Manuel_Almagro_Dominguez_Juego"

        conexion = New SqlConnection(cadenaConexion.ConnectionString)


        commando = New SqlCommand(consulta, conexion)

        conexion.Open()
        commando.ExecuteNonQuery()

        conexion.Close()


    End Function
    Public Function Comprobante()
        Dim consulta As String = "Select * from Player where username ='" + user.Text + "'"
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
        If String.IsNullOrEmpty(user.Text) Then
            usererror.Text = ""
        Else
            If ds.Tables(0).Rows.Count.ToString = "0" Then
                usererror.Text = "El usuario está disponible"
                chek = True
            Else
                chek = False
                usererror.Text = "El usuario ya existe"
            End If

        End If



    End Function

End Class