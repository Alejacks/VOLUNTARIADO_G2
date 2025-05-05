Public Class Hora
    Inherits EntidadBD
    Implements IEquatable(Of Hora)
    Implements IComparable(Of Hora)

    Public Overrides ReadOnly Property NombreTabla As String = "HORA"

    Public Property Dia As Dia
    Public Property HoraInicio As DateTime
    Public Property HoraFin As DateTime

    Public Sub New(dia As Dia, horaInicio As DateTime, horaFin As DateTime)
        Me.Dia = dia
        Me.HoraInicio = horaInicio
        Me.HoraFin = horaFin
    End Sub

    Public ReadOnly Property DescripcionCompleta As String
        Get
            If Me.Dia Is Nothing Then Return "Día inválido"
            Return $"[{Me.Dia.Descripcion}] {Me.HoraInicio:HH:mm} - {Me.HoraFin:HH:mm}"
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return Me.DescripcionCompleta
    End Function

    Public Overrides Function Clonar() As EntidadBD
        Return New Hora(Me.Dia, Me.HoraInicio, Me.HoraFin)
    End Function

    Public Overrides Function CamposConValores(Optional aptoParaInsert As Boolean = False) As Dictionary(Of String, String)
        Return New Dictionary(Of String, String) From {
            {"DIA", $"'{Me.Dia.ClavePrimaria(0)}'"},
            {"HORA_INICIO", $"'{Me.HoraInicio:HH\:mm\:ss}'"},
            {"HORA_FIN", $"'{Me.HoraFin:HH\:mm\:ss}'"}
        }
    End Function

    Public Overrides Function ClavePrimaria() As String()
        Return New String() {$"'{Me.Dia.ClavePrimaria(0)}'", $"'{Me.HoraInicio:HH\:mm\:ss}'", $"'{Me.HoraFin:HH\:mm\:ss}'"}
    End Function

    Public Overrides Function ClaveConCampo() As String
        Return $"DIA = '{Me.Dia.ClavePrimaria(0)}' AND HORA_INICIO = '{Me.HoraInicio:HH\:mm\:ss}' AND HORA_FIN = '{Me.HoraFin:HH\:mm\:ss}'"
    End Function

    Public Overloads Function Equals(other As Hora) As Boolean Implements IEquatable(Of Hora).Equals
        If other Is Nothing Then Return False
        If ReferenceEquals(Me, other) Then Return True
        Return Me.Dia.Equals(other.Dia) AndAlso
               Me.HoraInicio.TimeOfDay.Equals(other.HoraInicio.TimeOfDay) AndAlso
               Me.HoraFin.TimeOfDay.Equals(other.HoraFin.TimeOfDay)
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Me.Equals(TryCast(obj, Hora))
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hash As Integer = 17
        hash = hash * 23 + If(Dia IsNot Nothing, Dia.GetHashCode(), 0)
        hash = hash * 23 + HoraInicio.TimeOfDay.GetHashCode()
        hash = hash * 23 + HoraFin.TimeOfDay.GetHashCode()
        Return hash
    End Function

    Public Function CompareTo(other As Hora) As Integer Implements IComparable(Of Hora).CompareTo
        If other Is Nothing Then Return 1
        Dim diaCompare As Integer = String.Compare(Me.Dia.Descripcion, other.Dia.Descripcion, StringComparison.CurrentCultureIgnoreCase)
        If diaCompare <> 0 Then Return diaCompare
        Dim horaInicioCompare As Integer = Me.HoraInicio.TimeOfDay.CompareTo(other.HoraInicio.TimeOfDay)
        If horaInicioCompare <> 0 Then Return horaInicioCompare
        Return Me.HoraFin.TimeOfDay.CompareTo(other.HoraFin.TimeOfDay)
    End Function

End Class