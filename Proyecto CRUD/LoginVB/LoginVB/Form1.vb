Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class Form1
    Public conexion As SqlConnection = New SqlConnection(My.Settings.conexion)
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public cmd As SqlCommand

    Function verificacion(ByVal sql)
        conexion.Open()
        cmd = New SqlCommand(sql, conexion)
        Dim i As Integer = cmd.ExecuteNonQuery
        conexion.Close()

        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim verificar As String = "update login set rol=rol where nombre = '" + txtUsuario.Text + "' and contraseña = '" + txtContraseña.Text + "' and rol = 'ADMINISTRADOR'"
        Dim verificar1 As String = "update login set rol=rol where nombre = '" + txtUsuario.Text + "' and contraseña = '" + txtContraseña.Text + "' and rol = 'CLIENTE'"
        Dim verificar2 As String = "update login set rol=rol where nombre = '" + txtUsuario.Text + "' and contraseña = '" + txtContraseña.Text + "' and rol = 'SECRETARIA'"

        If verificacion(verificar) Then
            CRUD.Show()
            Me.Hide()
        Else
            MessageBox.Show("USUARIO NO VALIDO")
        End If
        If verificacion(verificar1) Then
            CRUD.Show()
            Me.Hide()
        Else
            MessageBox.Show("USUARIO NO VALIDO")
        End If
        If verificacion(verificar2) Then
            CRUD.Show()
            Me.Hide()
        Else
            MessageBox.Show("USUARIO NO VALIDO")
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
