Imports MySql.Data.MySqlClient

Public Class frmregistar


    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        Dim conexion As New MySqlConnection
        Dim cmd As New MySqlCommand
        conexion = New MySqlConnection
        Try
            conexion.ConnectionString = "server=localhost;database=usuarios_roles;uid=root;Pwd=;"
            conexion.Open()
            cmd.Connection = conexion



            cmd.CommandText = "SELECT nombre FROM usuarios WHERE nombre=@nombre"
            cmd.Prepare()

            cmd.Parameters.AddWithValue("@nombre", txtnuevousuario.Text)



            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()



            If reader.HasRows Then
                MsgBox("Error")
            Else

                reader.Close()
                Dim cmd2 As New MySqlCommand
                cmd2.Connection = conexion


                cmd2.CommandText = "INSERT INTO usuarios(nombre,pass,idrol,activo) VALUES(@nombre,@pass,@idrol,@activo)"
                cmd2.Prepare()
                cmd2.Parameters.AddWithValue("@nombre", txtnuevousuario.Text)
                cmd2.Parameters.AddWithValue("@pass", txtnuevopass.Text)
                cmd2.Parameters.AddWithValue("@idrol", 3)
                cmd2.Parameters.AddWithValue("@activo", 0)




                cmd2.ExecuteNonQuery()
                MsgBox("Registrado correctamente")
                Me.Hide()
                frmlogin.Show()

            End If
            reader.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Private Sub frmregistar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class