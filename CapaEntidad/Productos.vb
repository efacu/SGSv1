Imports CapaDatos
Public Class Productos
    Private Shared _IdProducto As Int64
    Private Shared _CodigoBarra As String
    Private Shared _Descripcion As String

    Public Shared Property ID() As Int64
        Get
            Return _IdProducto
        End Get
        Set(ByVal value As Int64)
            _IdProducto = value
        End Set
    End Property

    Public Shared Property CodigoBarra() As String
        Get
            Return _CodigoBarra
        End Get
        Set(ByVal value As String)
            _CodigoBarra = value
        End Set
    End Property
    Public Shared Property Descripcion() As String
        Get
            Return _IdProducto
        End Get
        Set(ByVal value As String)
            _IdProducto = value
        End Set
    End Property



End Class
