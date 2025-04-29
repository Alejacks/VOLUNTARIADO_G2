Imports System.Data.SqlClient
Imports Configuracion

Public Class Conector

    Private ReadOnly _CadenaConexion As New SqlConnectionStringBuilder()
    Private ReadOnly _Conexion As SqlConnection

    Public Sub New(origenDatos As String, catalogoDatos As String, credencialesWindows As Boolean)
        _CadenaConexion.Add("Data Source", origenDatos)
        _CadenaConexion.Add("Initial Catalog", catalogoDatos)
        _CadenaConexion.Add("Integrated Security", credencialesWindows)
        _Conexion = New SqlConnection(_CadenaConexion.ToString())
    End Sub

    Public Sub New(ajustes As Ajustes)
        _CadenaConexion.Add("Data Source", ajustes.ObtenerAjuste("origenBaseDatos"))
        _CadenaConexion.Add("Initial Catalog", ajustes.ObtenerAjuste("catalogoBaseDatos"))
        _CadenaConexion.Add("Integrated Security", ajustes.ObtenerAjuste("credencialesWindows"))
    End Sub

    Public Overrides Function ToString() As String
        Return _CadenaConexion.ToString()
    End Function

    Private Function Abrir() As Boolean
        Try
            If _Conexion.State = ConnectionState.Closed Then
                _Conexion.Open()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function Cerrar() As Boolean
        Try
            If _Conexion.State = ConnectionState.Open Then
                _Conexion.Close()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function EjecutarModificacion(codigoSQL As String) As Integer
        Dim comando As New SqlCommand(codigoSQL, _Conexion)
        Try
            Abrir()
            Return comando.ExecuteNonQuery()
        Finally
            Cerrar()
        End Try
    End Function

    Public Function EjecutarConsultaSimple(codigoSQL As String) As Object
        Dim comando As New SqlCommand(codigoSQL, _Conexion)
        Abrir()
        Return comando.ExecuteScalar(CommandBehavior.CloseConnection)
    End Function

    Public Function EjecutarConsultaMutilple(codigoSQL As String) As SqlDataReader
        Dim comando As New SqlCommand(codigoSQL, _Conexion)
        Abrir()
        Return comando.ExecuteReader(CommandBehavior.CloseConnection)
    End Function
End Class
