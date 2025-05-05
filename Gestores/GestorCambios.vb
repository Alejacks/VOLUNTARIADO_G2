Imports Entidades
Imports Cambios

Public Class GestorCambios(Of T As EntidadBD)

    Private ReadOnly _GestorOriginal As GestorEntidad(Of T)
    Private ReadOnly _GestorNuevo As GestorEntidad(Of T)
    Private ReadOnly Property _CambiosRealizados As New List(Of CambioBD)
    Public ReadOnly Property Sentencias As List(Of String)
        Get
            Dim sentenciasAProcesar As New List(Of String)
            For Each cambio As CambioBD In _CambiosRealizados
                Dim codigo As String = cambio.CodigoSQL
                If codigo IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(codigo) Then sentenciasAProcesar.Add(codigo)
            Next
            Return sentenciasAProcesar
        End Get
    End Property

    Public Sub New(gestorOriginal As GestorEntidad(Of T), gestorNuevo As GestorEntidad(Of T))
        _GestorOriginal = gestorOriginal
        _GestorNuevo = gestorNuevo
    End Sub

    Public Sub ProcesarCambios()
        For Each elemento As T In _GestorOriginal.Elementos
            If _GestorNuevo.Elementos.Contains(elemento) Then
                Dim elementoAntiguo As T = elemento
                Dim elementoNuevo As T = _GestorNuevo.Elementos(_GestorNuevo.Elementos.IndexOf(elemento))
                If Not elementoAntiguo.ExactamenteIgual(elementoNuevo) Then
                    _CambiosRealizados.Add(New Update(elementoAntiguo, elementoNuevo))
                End If
            Else
                _CambiosRealizados.Add(New Delete(elemento))
            End If
        Next

        For Each elemento As T In _GestorNuevo.Elementos
            If Not _GestorOriginal.Elementos.Contains(elemento) Then
                _CambiosRealizados.Add(New Insert(elemento))
            End If
        Next
    End Sub

End Class