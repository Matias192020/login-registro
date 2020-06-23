
Imports MySql.Data.MySqlClient

Public Class frmmain
    Dim conexion As MySqlConnection

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarSelect()

    End Sub

    Sub ActualizarSelect()   'Actualiza el dataset donde esta almacenado la tabla

        Dim ds As DataSet = New DataSet
        Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter
        conexion = New MySqlConnection
        Dim cmd As New MySqlCommand

        conexion.ConnectionString = "server=localhost;database=usuarios_roles;uid=root;Pwd=;"
        Try
            conexion.Open()




            cmd.Connection = conexion
            cmd.CommandText = "SELECT * FROM usuarios ORDER BY nombre ASC"
            adaptador.SelectCommand = cmd



            adaptador.Fill(ds, "Tabla")
            DataGridView1.DataSource = ds

            DataGridView1.DataMember = "Tabla"



            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If (DataGridView1.SelectedRows.Count > 0) Then
            txtcontactual.Text = DataGridView1.Item("pass", DataGridView1.SelectedRows(0).Index).Value
            txtnombre.Text = DataGridView1.Item("nombre", DataGridView1.SelectedRows(0).Index).Value



        End If




    End Sub

    Private Sub btncambiarclave_Click(sender As Object, e As EventArgs) Handles btncambiarclave.Click
        'POR ALGUN MOTIVO HAY QUE DARLE DOS VECES AL BOTON CAMBIAR CLAVE PARA CAMBIAR LA PASS
        ActualizarSelect()
        Dim conexion As New MySqlConnection
        Dim cmd As New MySqlCommand
        conexion = New MySqlConnection
        Try
            conexion.ConnectionString = "server=localhost;database=usuarios_roles;uid=root;Pwd=;"
            conexion.Open()
            cmd.Connection = conexion


            cmd.CommandText = "UPDATE usuarios SET pass=@pass WHERE nombre=@nombre;"
            cmd.Prepare()
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@pass", txtcontnueva.Text)
            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)






            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()



            If reader.HasRows Then
                MsgBox("Error")
            Else


            End If
            reader.Close()
            conexion.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnactivar_Click(sender As Object, e As EventArgs) Handles btnactivar.Click
        ActualizarSelect()


        Dim conexion As New MySqlConnection
        Dim cmd As New MySqlCommand
        conexion = New MySqlConnection
        Try
            conexion.ConnectionString = "server=localhost;database=usuarios_roles;uid=root;Pwd=;"
            conexion.Open()
            cmd.Connection = conexion



            cmd.CommandText = "UPDATE usuarios SET activo=@activo WHERE idusuario=@idusuario;"
            cmd.Prepare()

            cmd.Parameters.AddWithValue("@activo", txtactivo.Text)
            cmd.Parameters.AddWithValue("@idusuario", txtidusuario.Text)





            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()



            If reader.HasRows Then
                MsgBox("Error")
            Else



            End If
            reader.Close()
            conexion.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btndesactivar.Click
        ActualizarSelect()


        Dim conexion As New MySqlConnection
        Dim cmd As New MySqlCommand
        conexion = New MySqlConnection
        Try
            conexion.ConnectionString = "server=localhost;database=usuarios_roles;uid=root;Pwd=;"
            conexion.Open()
            cmd.Connection = conexion



            cmd.CommandText = "UPDATE usuarios SET activo=@activo WHERE idusuario=@idusuario;"
            cmd.Prepare()

            cmd.Parameters.AddWithValue("@activo", 0)
            cmd.Parameters.AddWithValue("@idusuario", txtidusuario.Text)





            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()



            If reader.HasRows Then
                MsgBox("Error")
            Else



            End If
            reader.Close()
            conexion.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class

Friend Class MySqlAdapter
End Class
