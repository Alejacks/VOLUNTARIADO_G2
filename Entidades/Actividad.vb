Public Class Actividad
    Inherits EntidadBD
    Implements IEquatable(Of Actividad)
    Implements IComparable(Of Actividad)

    Public Overrides ReadOnly Property NombreTabla As String
        Get
            Return "ACTIVIDAD"
        End Get
    End Property

    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Estado As Char
    Public Property ConvocadaPor As Organizacion
    Public Property FechaHoraInicio As DateTime
    Public Property FechaHoraFin As DateTime
    Public Property TecnicoDe As Curso

    Public Sub New(id As Integer, nombre As String, descripcion As String, estado As Char, convocadaPor As Organizacion, fechaHoraInicio As DateTime, fechaHoraFin As DateTime, Optional tecnicoDe As Curso = Nothing)
        Me.Id = id
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Estado = estado
        Me.ConvocadaPor = convocadaPor
        Me.FechaHoraInicio = fechaHoraInicio
        Me.FechaHoraFin = fechaHoraFin
        Me.TecnicoDe = tecnicoDe
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Actividad))
    End Function

    Public Overloads Function Equals(other As Actividad) As Boolean Implements IEquatable(Of Actividad).Equals
        If ReferenceEquals(Me, other) Then Return True
        Return other IsNot Nothing AndAlso other.Id.Equals(Id)
    End Function

    Public Function CompareTo(other As Actividad) As Integer Implements IComparable(Of Actividad).CompareTo
        If Me.Equals(other) Then Return 0
        Return Id.CompareTo(other.Id)
    End Function

    Public Overrides Function CamposConValores() As Dictionary(Of String, String)
        Return New Dictionary(Of String, String) From {
        {"ID", Me.Id},
        {"NOMBRE", $"'{Me.Nombre}'"},
        {"DESCRIPCION", $"'{Me.Descripcion}'"},
        {"ESTADO", $"'{Me.Estado}'"},
        {"CONVOCADAPOR", Me.ConvocadaPor.ClavePrimaria(0)},
        {"TECNICO_DE", If(Me.TecnicoDe IsNot Nothing, Me.TecnicoDe.ClavePrimaria(0), "NULL")},
        {"FECHA_INICIO", $"'{Me.FechaHoraInicio.Date:yyyy-MM-dd}'"},
        {"HORA_INICIO", $"'{Me.FechaHoraInicio.TimeOfDay:hh\:mm\:ss}'"},
        {"FECHA_FIN", $"'{Me.FechaHoraFin.Date:yyyy-MM-dd}'"},
        {"HORA_FIN", $"'{Me.FechaHoraFin.TimeOfDay:hh\:mm\:ss}'"}
        }
    End Function

    Public Overrides Function ClavePrimaria() As String()
        Return New String() {Id}
    End Function

    Public Overrides Function ClaveConCampo() As String
        Return $"ID = {Id}"
    End Function
End Class
