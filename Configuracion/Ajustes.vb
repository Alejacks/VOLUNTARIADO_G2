Imports System.IO

Public Class Ajustes

    Public ReadOnly Property AjustesAplicacion As New Dictionary(Of String, String)

    Private Const _RutaFicheroConfiguracion As String = "./conf.txt"
    Private ReadOnly _ContenidoBaseFichero As String = $"origenBaseDatos = 127.0.0.1{ControlChars.NewLine}catalogoBaseDatos = VOLUNTARIADO_G2{ControlChars.NewLine}credencialesWindows = True"

    Public Sub New()
        Try
            If Not File.Exists(_RutaFicheroConfiguracion) Then
                File.CreateText(_RutaFicheroConfiguracion).Dispose()
                Using fichero As New StreamWriter(_RutaFicheroConfiguracion)
                    fichero.WriteLine(_ContenidoBaseFichero)
                End Using
            End If
            For Each ajuste As String In File.ReadAllLines(_RutaFicheroConfiguracion) 'HERE
                If ajuste.Contains("=") Then
                    Dim ajusteActual() As String = ajuste.Split("=")
                    AjustesAplicacion.Add(ajusteActual(0).Trim, ajusteActual(1).Trim)
                End If
            Next
        Catch ex As Exception
            For Each ajuste As String In _ContenidoBaseFichero.Split(ControlChars.NewLine)
                If ajuste.Contains("=") Then
                    Dim ajusteActual() As String = ajuste.Split("=")
                    AjustesAplicacion.Add(ajusteActual(0).Trim, ajusteActual(1).Trim)
                End If
            Next
        End Try
    End Sub

    Public Function ObtenerAjuste(ajusteBuscado As String) As String
        Try
            Return AjustesAplicacion(ajusteBuscado.Trim())
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ActualizarAjuste(ajusteBuscado As String, nuevoValor As String) As Boolean
        AjustesAplicacion(ajusteBuscado) = nuevoValor
        If CrearSiNoExiste(_RutaFicheroConfiguracion, True) Then
            Using fichero As New StreamWriter(_RutaFicheroConfiguracion)
                For Each ajuste As KeyValuePair(Of String, String) In AjustesAplicacion
                    fichero.WriteLine($"{ajuste.Key} = {ajuste.Value}")
                Next
            End Using
            Return True
        Else
            Return False
        End If
    End Function

    Private Shared Function CrearSiNoExiste(ruta As String, Optional limpiar As Boolean = False) As Boolean
        If limpiar Then
            Try
                File.CreateText(ruta).Dispose()
            Catch ex As Exception
                Return False
            End Try
        End If
        If File.Exists(ruta) Then
            Return True
        Else
            Try
                File.CreateText(ruta).Dispose()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End If

    End Function

    Private Function AgregarContenidoBase(ruta As String) As Boolean
        Try
            If CrearSiNoExiste(ruta) Then
                Using ficheroVacio As New FileStream(ruta, FileMode.Truncate)
                    Using fichero As New StreamWriter(ruta)
                        fichero.WriteLine(_ContenidoBaseFichero)
                    End Using
                End Using
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
