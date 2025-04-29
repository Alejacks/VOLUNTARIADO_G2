Imports Entidades
Public MustInherit Class CambioBD
    Implements IEquatable(Of CambioBD)

    Private ReadOnly _Objeto As EntidadBD

    Public Sub New(objeto As EntidadBD)
        _Objeto = objeto
    End Sub

    ReadOnly Property CodigoSQL As String
        Get
            Return Consulta()
        End Get
    End Property

    Private Function Consulta() As String

        If Me.GetType Is GetType(Insert) Then
            Return $"INSERT INTO {_Objeto.NombreTabla} ({String.Join(", ", _Objeto.CamposConValores.Keys)}) VALUES ({String.Join(", ", _Objeto.CamposConValores.Values)})"
        ElseIf Me.GetType Is GetType(Delete) Then
            Return $"DELETE {_Objeto.NombreTabla} WHERE {_Objeto.ClaveConCampo}"
        ElseIf Me.GetType Is GetType(Update) Then
            Dim update As Update = CType(Me, Update)
            If update.Cambios Is Nothing Then Return Nothing
            Return $"UPDATE {_Objeto.NombreTabla} SET {String.Join(", ", update.Cambios.Select(Function(kvp) $"{kvp.Key} = {kvp.Value}"))} WHERE {_Objeto.ClaveConCampo}"
        ElseIf _Objeto.GetType().IsAssignableFrom(GetType(CambioBD)) Then
            Throw New CambioNoValido($"Este tipo de objetos (tipo: {_Objeto.GetType().Name}) no es válido para esta operación.")
        ElseIf _Objeto Is Nothing Then
            Throw New NullReferenceException("No existe referencia alguna al objeto al que se trata de acceder")
        ElseIf _Objeto IsNot Nothing Then
            Throw New CambioNoValido(_Objeto, $"El cambio que se trata de realizar con el registro correspondiente a la tabla {_Objeto.NombreTabla} no es válido.{ControlChars.NewLine}
                Clave del objeto: {_Objeto.ClaveConCampo}.{ControlChars.NewLine}
                Nombre del objeto: {_Objeto}")
        Else
            Throw New Exception("Ha ocurrido un error desconocido")
        End If
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If ReferenceEquals(Me, obj) Then Return True
        If obj Is Nothing OrElse Not GetType(CambioBD).IsAssignableFrom(obj.GetType()) Then Return False
        Return Me.Equals(TryCast(obj, CambioBD))
    End Function

    Public Overloads Function Equals(other As CambioBD) As Boolean Implements IEquatable(Of CambioBD).Equals
        If ReferenceEquals(Me, other) Then Return True
        Return other IsNot Nothing AndAlso Me.Consulta.Equals(other.Consulta)
    End Function
End Class
