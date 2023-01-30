Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class cliente

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
        Dim da As New SqlDataAdapter("select *from crud ", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btn_regresar2_Click(sender As Object, e As EventArgs) Handles btn_regresar2.Click
        Dim cliente As New Form1
        cliente.Show()
        Me.Hide()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Close()
    End Sub

    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        Dim da As New SqlDataAdapter("select *from crud where nombre = '" + txt_nombre.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class