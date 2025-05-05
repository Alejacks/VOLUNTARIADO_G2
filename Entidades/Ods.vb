Public Class Ods
    Inherits EntidadBD
    Implements IEquatable(Of Ods)
    Implements IComparable(Of Ods)

    Public Overrides ReadOnly Property NombreTabla As String = "ODS"

    Public Property Id As Integer
    Public Property Descripcion As String

    Public Sub New(id As Integer, descripcion As String)
        Me.Id = id
        Me.Descripcion = descripcion
    End Sub

    Public Overrides Function Clonar() As EntidadBD
        Return New Ods(Me.Id, Me.Descripcion)
    End Function

    Public Overrides Function toString() As String
        Return $"{Me.Id} - {Me.Descripcion}"
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Ods))
    End Function

    Public Overloads Function Equals(other As Ods) As Boolean Implements IEquatable(Of Ods).Equals
        If ReferenceEquals(Me, other) Then Return True
        Return other IsNot Nothing AndAlso other.Id.Equals(Id)
    End Function

    Public Function CompareTo(other As Ods) As Integer Implements IComparable(Of Ods).CompareTo
        If Me.Equals(other) Then Return 0
        Return Me.Id.CompareTo(other.Id)
    End Function

    Public Overrides Function CamposConValores(Optional aptoParaInsert As Boolean = False) As Dictionary(Of String, String)
        Return New Dictionary(Of String, String) From {
             {"ID", Me.Id},
            {"DESCRIPCION", $"'{Me.Descripcion}'"}
        }
    End Function

    Public Overrides Function ClavePrimaria() As String()
        Return New String() {Id}
    End Function

    Public Overrides Function ClaveConCampo() As String
        Return $"ID = {Id}"
    End Function
End Class
