Public Class Curso
    Inherits EntidadBD
    Implements IEquatable(Of Curso)
    Implements IComparable(Of Curso)

    Public Overrides ReadOnly Property NombreTabla As String = "CURSO"

    Public Property Id As Integer
    Public Property Descripcion As String

    Public Sub New(id As Integer, descripcion As String)
        Me.Id = id
        Me.Descripcion = descripcion
    End Sub

    Public Overrides Function ToString() As String
        Return Descripcion
    End Function

    Public Overloads Function Equals(other As Curso) As Boolean Implements IEquatable(Of Curso).Equals
        If ReferenceEquals(Me, other) Then Return True
        Return other IsNot Nothing AndAlso other.Id.Equals(Id)
    End Function

    Public Function CompareTo(other As Curso) As Integer Implements IComparable(Of Curso).CompareTo
        If Me.Equals(other) Then Return 0
        Return Me.Id.CompareTo(other.Id)
    End Function

    Public Overrides Function CamposConValores() As Dictionary(Of String, String)
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
