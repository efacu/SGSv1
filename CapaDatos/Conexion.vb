Imports System.Data.SqlClient
Public Class Conexion
    Dim coman As New SqlCommand
    Public Shared bcx As New SqlConnection
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Function Conectado()
        Try
            bcx = New SqlConnection("Data Source=MUNI-PC;Initial Catalog=SGSv1;Integrated Security=True")
            bcx.Open()
            MsgBox("Conectado bd")
            Return True
        Catch ex As Exception
            MsgBox("error en la conexion bd" + ex.Message)
            Return False
        End Try
    End Function

    Public Function Desconectado()
        Try
            If bcx.State = ConnectionState.Open Then
                bcx.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("error en la conexion bd" + ex.Message)
            Return False
        End Try

    End Function


End Class
