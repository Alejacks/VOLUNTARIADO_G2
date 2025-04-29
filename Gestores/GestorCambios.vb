Imports Entidades
Imports Cambios

Public Class GestorCambios(Of T As EntidadBD)

    Private ReadOnly _GestorOriginal As GestorEntidad(Of T)
    Private ReadOnly _GestorNuevo As GestorEntidad(Of T)
    Public ReadOnly Property CambiosRealizados As New List(Of CambioBD)
    Public ReadOnly Property Sentencias As List(Of String)
        Get
            Dim sentenciasAProcesar As New List(Of String)
            For Each cambio As CambioBD In CambiosRealizados
                sentenciasAProcesar.Add(cambio.CodigoSQL)
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
                    CambiosRealizados.Add(New Update(elementoAntiguo, elementoNuevo))
                End If
            Else
                CambiosRealizados.Add(New Delete(elemento))
            End If
        Next

        For Each elemento As T In _GestorNuevo.Elementos
            If Not _GestorOriginal.Elementos.Contains(elemento) Then
                CambiosRealizados.Add(New Insert(elemento))
            End If
        Next
    End Sub

End Class