﻿Imports System.Data.SqlClient
Imports Configuracion

Public Class Conector

    Private ReadOnly _CadenaConexion As New SqlConnectionStringBuilder()
    Public ReadOnly Conexion As SqlConnection

    Public Sub New(origenDatos As String, catalogoDatos As String, credencialesWindows As Boolean)
        _CadenaConexion.Add("Data Source", origenDatos)
        _CadenaConexion.Add("Initial Catalog", catalogoDatos)
        _CadenaConexion.Add("Integrated Security", credencialesWindows)
        Conexion = New SqlConnection(_CadenaConexion.ToString())
    End Sub

    Public Sub New(ajustes As Ajustes)
        _CadenaConexion.Add("Data Source", $"{ajustes.ObtenerAjuste("origenBaseDatos")}\{ajustes.ObtenerAjuste("instanciaSQLServer")}")
        _CadenaConexion.Add("Initial Catalog", ajustes.ObtenerAjuste("catalogoBaseDatos"))
        _CadenaConexion.Add("Integrated Security", ajustes.ObtenerAjuste("credencialesWindows"))
        Conexion = New SqlConnection(_CadenaConexion.ToString())
    End Sub

    Public Overrides Function ToString() As String
        Return _CadenaConexion.ToString()
    End Function

    Public Function Abrir() As Boolean
        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Cerrar() As Boolean
        Try
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function EjecutarModificacion(codigoSQL As String) As Integer
        Dim comando As New SqlCommand(codigoSQL, Conexion)
        Try
            Return comando.ExecuteNonQuery()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function EjecutarConsultaSimple(codigoSQL As String) As Object
        Try
            Return New SqlCommand(codigoSQL, Conexion).ExecuteScalar()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function EjecutarConsultaMutilple(codigoSQL As String) As SqlDataReader
        Try
            Return New SqlCommand(codigoSQL, Conexion).ExecuteReader
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
