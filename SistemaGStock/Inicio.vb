Imports System.Data.SqlClient
Imports CapaDatos
Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        conexion()
    End Sub

    Sub conexion()
        Try
            Dim fn As New Conexion
            fn.Conectado()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim ino As New Inicio

        ino.Close()
        Panel.Show()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        tbUsuario.Clear()
        tbPass.Clear()
        tbUsuario.Focus()

    End Sub


End Class
