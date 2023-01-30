Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class CRUD
    Dim con As New SqlConnection(My.Settings.conexion)
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

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        sentencia = "INSERT INTO PERSONA VLAUES"
    End Sub

    Private Sub CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class