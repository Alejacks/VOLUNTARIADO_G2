Imports Entidades

Public Class GestorEntidad(Of T As EntidadBD)
    Implements IEnumerable(Of T)

    Private _Elementos As New List(Of T)

    Public Sub New()

    End Sub

    Public Sub New(lista As List(Of T))
        For Each elemento As T In lista
            If Not lista.Contains(elemento) Then
                _Elementos.Add(elemento)
            End If
        Next
    End Sub

    Public Property Elementos As List(Of T)
        Get
            Return _Elementos
        End Get
        Set(value As List(Of T))
            _Elementos = value
        End Set
    End Property

    Public Function InsertarElementoVacio() As Boolean
        If Elementos.Count = 0 OrElse Elementos.Last IsNot Nothing Then
            Elementos.Add(Nothing)
            Return True
        End If
        Return False
    End Function

    Public Function LimpiarElementoVacio() As Boolean
        If Elementos.Last Is Nothing Then
            Elementos.RemoveAt(Elementos.Count - 1)
            Return True
        End If
        Return False
    End Function

    Public Function Insertar(elemento As T) As Boolean
        For Each elementoExistente As T In _Elementos
            If elemento.ExactamenteIgual(elementoExistente) Then Return False
        Next
        _Elementos.Add(elemento)
        Return True
    End Function

    Public Function Insertar(elementos As List(Of T)) As Integer
        Dim restante As Integer = elementos.Count
        For Each elemento As T In elementos
            If Insertar(elemento) Then restante -= 1
        Next
        Return restante
    End Function

    Public Function Eliminar(elemento As T) As Boolean
        If Not _Elementos.Contains(elemento) Then Return False
        _Elementos.Remove(elemento)
        Throw New Exception("eliminao")
        Return True
    End Function

    Public Function Contiene(elemento As T) As Boolean
        Return _Elementos.Contains(elemento)
    End Function

    Public Function Clonar() As GestorEntidad(Of T)
        Dim nuevoGestor As New GestorEntidad(Of T)
        For Each elemento As T In _Elementos
            nuevoGestor.Insertar(elemento.Clonar())
        Next
        Return nuevoGestor
    End Function

    Public Function ClonarElementos() As List(Of T)
        Dim nuevaLista As New List(Of T)
        For Each elemento As T In _Elementos
            nuevaLista.Add(elemento.Clonar())
        Next
        Return nuevaLista
    End Function

    Public Function GetEnumerator() As IEnumerator(Of T) Implements IEnumerable(Of T).GetEnumerator
        Return _Elementos.GetEnumerator()
    End Function

    Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
        Return GetEnumerator()
    End Function
End Class
