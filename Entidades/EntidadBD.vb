Public MustInherit Class EntidadBD
    Overridable ReadOnly Property NombreTabla As String

    Public Function ExactamenteIgual(other As EntidadBD) As Boolean
        If ReferenceEquals(Me, other) Then Return True
        If other Is Nothing Then Return False
        Return Me.CamposConValores.Equals(other.CamposConValores)
    End Function


    Public MustOverride Function CamposConValores(Optional aptoParaInsert As Boolean = False) As Dictionary(Of String, String)

    Public MustOverride Function ClavePrimaria() As String()

    Public MustOverride Function ClaveConCampo() As String

    Public MustOverride Function Clonar() As EntidadBD
End Class
