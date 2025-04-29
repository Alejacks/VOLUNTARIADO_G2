Imports Entidades

Public Class Update
    Inherits CambioBD
    Public ReadOnly Property Cambios As Dictionary(Of String, String)

    Public ReadOnly Property Antiguo As EntidadBD
    Public ReadOnly Property Nuevo As EntidadBD

    Public Sub New(objetoAntiguo As EntidadBD, objetoNuevo As EntidadBD)
        MyBase.New(objetoAntiguo)
        Antiguo = objetoAntiguo
        Nuevo = objetoNuevo
        Dim camposConValoresAntiguos As Dictionary(Of String, String) = objetoAntiguo.CamposConValores()
        Dim camposConValoresNuevos As Dictionary(Of String, String) = objetoNuevo.CamposConValores()
        If camposConValoresAntiguos.Equals(camposConValoresNuevos) Then
            Cambios = Nothing
            Exit Sub
        End If

        Dim antiguoEnumerable As IEnumerable(Of KeyValuePair(Of String, String)) = camposConValoresAntiguos.AsEnumerable()
        Dim nuevoEnumerable As IEnumerable(Of KeyValuePair(Of String, String)) = camposConValoresNuevos.AsEnumerable()

        Dim cambiosARealizar As New Dictionary(Of String, String)
        For i As Integer = 0 To antiguoEnumerable.Count
            If Not antiguoEnumerable(i).Equals(nuevoEnumerable(i)) Then
                cambiosARealizar.Add(nuevoEnumerable(i).Key, nuevoEnumerable(i).Value)
            End If
        Next
        Cambios = If(cambiosARealizar.Count = 0, Nothing, cambiosARealizar)
    End Sub


End Class
