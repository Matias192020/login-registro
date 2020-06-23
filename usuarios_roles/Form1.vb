Imports MySql.Data.MySqlClient



Public Class frmlogin

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim conexion As New MySqlConnection
        Dim cmd As New MySqlCommand
        conexion = New MySqlConnection
        Try
            conexion.ConnectionString = "server=localhost;database=usuarios_roles;uid=root;Pwd=;"
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandText = "SELECT nombre FROM usuarios WHERE nombre=@nombre AND pass=@pass AND activo=1"
            cmd.Prepare()
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nombre", txtusuario.Text)
            cmd.Parameters.AddWithValue("@pass", txtpass.Text)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                Me.Hide()
                frmmain.Show()
            Else
                MsgBox("error")
            End If
            reader.Close()
            conexion.Close()









        Catch ex As Exception


        End Try
    End Sub

    Private Sub btnneu_Click(sender As Object, e As EventArgs) Handles btnneu.Click
        Me.Hide()
        frmregistar.Show()

    End Sub
End Class
