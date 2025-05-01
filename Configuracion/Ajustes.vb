Imports System.IO
Imports Microsoft.Win32

Public Class Ajustes

    Public ReadOnly Property AjustesAplicacion As New Dictionary(Of String, String)

    Public ReadOnly Property RutaFicheroConfiguracion As String = "./conf.txt"
    Private ReadOnly _ContenidoBaseFichero As String = $"origenBaseDatos = {Environment.MachineName}{ControlChars.NewLine}instanciaSQLServer = {NombreInstancia()}{ControlChars.NewLine}catalogoBaseDatos = VOLUNTARIADO_G2{ControlChars.NewLine}credencialesWindows = True"

    Public Sub New()
        Try
            If Not File.Exists(RutaFicheroConfiguracion) Then
                File.CreateText(RutaFicheroConfiguracion).Dispose()
                Using fichero As New StreamWriter(RutaFicheroConfiguracion)
                    fichero.WriteLine(_ContenidoBaseFichero)
                End Using
            End If
            For Each ajuste As String In File.ReadAllLines(RutaFicheroConfiguracion)
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
        If CrearSiNoExiste(RutaFicheroConfiguracion, True) Then
            Using fichero As New StreamWriter(RutaFicheroConfiguracion)
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

    Private Function NombreInstancia() As String
        Dim instancias = New List(Of String)
        Try
            Using registro As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL")
                If registro IsNot Nothing Then
                    For Each instancia In registro.GetValueNames()
                        If instancia IsNot Nothing Then
                            instancias.Add(instancia)
                        End If
                    Next
                End If
            End Using
        Catch ex As Exception
        End Try

        Return If(instancias.Count > 0, instancias(0), String.Empty)
    End Function

End Class
