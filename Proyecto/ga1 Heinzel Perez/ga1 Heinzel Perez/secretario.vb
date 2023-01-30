Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms


Public Class secretario

    Dim con As New SqlConnection(My.Settings.Setting)
    Dim mensaje, sentencia As String
    Sub Ejecutarsql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim da As New SqlDataAdapter("select *from crud where nombre = '" + txt_nombre.Text + "' ", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        sentencia = "update crud set nombre = '" + txt_nombre.Text + "',apellido = '" + txt_apellido.Text + "',edad = '" + txt_edad.Text + "' where id = '" + txt_id.Text + "'"
        mensaje = "Datos actualizados"
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select *from crud ", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_regresar3_Click(sender As Object, e As EventArgs) Handles btn_regresar3.Click
        Dim secretario As New Form1
        secretario.Show()
        Me.Hide()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Close()
    End Sub

    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        Dim da As New SqlDataAdapter("select *from crud ", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)

    End Sub
End Class