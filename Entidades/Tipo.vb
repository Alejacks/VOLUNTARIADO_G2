Public Class Tipo
    Inherits EntidadBD
    Implements IEquatable(Of Tipo)
    Implements IComparable(Of Tipo)

    Public Overrides ReadOnly Property NombreTabla As String
        Get
            Return "TIPO"
        End Get
    End Property

    Public Property Id As Integer
    Public Property Descripcion As String

    Public Sub New(id As Integer, descripcion As String)
        Me.Id = id
        Me.Descripcion = descripcion
    End Sub

    Public Overrides Function ToString() As String
        Return Descripcion
    End Function

    Public Overrides Function Clonar() As EntidadBD
        Return New Tipo(Me.Id, Me.Descripcion)
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Me.Equals(TryCast(obj, Tipo))
    End Function

    Public Overloads Function Equals(other As Tipo) As Boolean Implements IEquatable(Of Tipo).Equals
        If ReferenceEquals(Me, other) Then Return True
        Return other IsNot Nothing AndAlso other.Id.Equals(Id)
    End Function

    Public Function CompareTo(other As Tipo) As Integer Implements IComparable(Of Tipo).CompareTo
        Return Me.Id.CompareTo(other.Id)
    End Function

    Public Overrides Function CamposConValores(Optional aptoParaInsert As Boolean = False) As Dictionary(Of String, String)
        If aptoParaInsert Then
            Return New Dictionary(Of String, String) From {
               {"DESCRIPCION", $"'{Me.Descripcion}'"}
            }
        Else
            Return New Dictionary(Of String, String) From {
               {"ID", Me.Id},
               {"DESCRIPCION", $"'{Me.Descripcion}'"}
            }
        End If
    End Function

    Public Overrides Function ClavePrimaria() As String()
        Return New String() {Id}
    End Function

    Public Overrides Function ClaveConCampo() As String
        Return $"ID = {Id}"
    End Function

End Class
