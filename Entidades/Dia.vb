Public Class Dia
    Inherits EntidadBD
    Implements IEquatable(Of Dia)

    Public Overrides ReadOnly Property NombreTabla As String
        Get
            Return "DIA"
        End Get
    End Property

    Public Property Descripcion As String

    Public Sub New(descripcion As String)
        Me.Descripcion = descripcion
    End Sub

    Public Overrides Function Clonar() As EntidadBD
        Return New Dia(Me.Descripcion)
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Me.Equals(TryCast(obj, Dia))
    End Function

    Public Overloads Function Equals(other As Dia) As Boolean Implements IEquatable(Of Dia).Equals
        If ReferenceEquals(Me, other) Then Return True
        Return other IsNot Nothing AndAlso other.Descripcion.Equals(Descripcion)
    End Function

    Public Overrides Function CamposConValores(Optional aptoParaInsert As Boolean = False) As Dictionary(Of String, String)
        Return New Dictionary(Of String, String) From {
             {"DESCRIPCION", $"'{Me.Descripcion}'"}}
    End Function

    Public Overrides Function ClavePrimaria() As String()
        Return New String() {Descripcion}
    End Function

    Public Overrides Function ClaveConCampo() As String
        Return $"DESCRIPCION = '{Descripcion}'"
    End Function
End Class
