Public Class Actividad
    Inherits EntidadBD
    Implements IEquatable(Of Actividad)
    Implements IComparable(Of Actividad)

    Public Shared ReadOnly Property EstadosValidos As String()
        Get
            Return New String() {"Activa", "Finalizada", "Pendiente", "Cancelada", "Rechazada"}
        End Get
    End Property

    Public Overrides ReadOnly Property NombreTabla As String
        Get
            Return "ACTIVIDAD"
        End Get
    End Property

    Private _Estado As Char
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Estado As String
        Get
            If _Estado = "a" Then
                Return "Activa"
            ElseIf _Estado = "f" Then
                Return "Finalizada"
            ElseIf _Estado = "p" Then
                Return "Pendiente"
            ElseIf _Estado = "c" Then
                Return "Cancelada"
            ElseIf _Estado = "r" Then
                Return "Rechazada"
            End If
            Return "Desconocido"
        End Get
        Set(value As String)
            If value Is Nothing Then
                _Estado = "p"
                Exit Property
            End If
            Dim valor As String = value.ToLower()
            If valor.Length = 1 Then
                Dim valorChar As Char = valor.Chars(0)
                If valorChar = "a" Then
                    _Estado = "a"
                ElseIf valorChar = "f" Then
                    _Estado = "f"
                ElseIf valorChar = "p" Then
                    _Estado = "p"
                ElseIf valorChar = "c" Then
                    _Estado = "c"
                ElseIf valorChar = "r" Then
                    _Estado = "r"
                End If
            Else
                If valor = "activa" Then
                    _Estado = "a"
                ElseIf valor = "finalizada" Then
                    _Estado = "f"
                ElseIf valor = "pendiente" Then
                    _Estado = "p"
                ElseIf valor = "cancelada" Then
                    _Estado = "c"
                ElseIf valor = "rechazada" Then
                    _Estado = "r"
                Else
                    Throw New ArgumentException("Estado no válido")
                End If
            End If
        End Set
    End Property
    Public Property ConvocadaPor As Organizacion
    Public Property FechaHoraInicio As DateTime
    Public Property FechaHoraFin As DateTime
    Public Property TecnicoDe As Curso

    Public Sub New(id As Integer, nombre As String, descripcion As String, estado As Char, convocadaPor As Organizacion, fechaHoraInicio As DateTime, fechaHoraFin As DateTime, tecnicoDe As Curso)
        Me.Id = id
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me._Estado = estado
        Me.ConvocadaPor = convocadaPor
        Me.FechaHoraInicio = fechaHoraInicio
        Me.FechaHoraFin = fechaHoraFin
        Me.TecnicoDe = tecnicoDe
    End Sub
    Public Overrides Function Clonar() As EntidadBD
        Dim actividadClonada As New Actividad(Me.Id, Me.Nombre, Me.Descripcion, Me._Estado, Me.ConvocadaPor, Me.FechaHoraInicio, Me.FechaHoraFin, Me.TecnicoDe)
        Return actividadClonada
    End Function

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

    Public Overrides Function CamposConValores(Optional aptoParaInsert As Boolean = False) As Dictionary(Of String, String)
        If aptoParaInsert Then
            Return New Dictionary(Of String, String) From {
            {"NOMBRE", $"'{Me.Nombre}'"},
            {"DESCRIPCION", $"'{Me.Descripcion}'"},
            {"ESTADO", $"'{Me._Estado}'"},
            {"CONVOCADA_POR", Me.ConvocadaPor.ClavePrimaria(0)},
            {"TECNICO_DE", If(Me.TecnicoDe IsNot Nothing, Me.TecnicoDe.ClavePrimaria(0), "NULL")},
            {"FECHA_INICIO", $"'{Me.FechaHoraInicio.Date:yyyy-MM-dd}'"},
            {"HORA_INICIO", $"'{Me.FechaHoraInicio.TimeOfDay:hh\:mm\:ss}'"},
            {"FECHA_FIN", $"'{Me.FechaHoraFin.Date:yyyy-MM-dd}'"},
            {"HORA_FIN", $"'{Me.FechaHoraFin.TimeOfDay:hh\:mm\:ss}'"}
            }
        Else
            Return New Dictionary(Of String, String) From {
            {"ID", Me.Id},
            {"NOMBRE", $"'{Me.Nombre}'"},
            {"DESCRIPCION", $"'{Me.Descripcion}'"},
            {"ESTADO", $"'{Me._Estado}'"},
            {"CONVOCADA_POR", Me.ConvocadaPor.ClavePrimaria(0)},
            {"TECNICO_DE", If(Me.TecnicoDe IsNot Nothing, Me.TecnicoDe.ClavePrimaria(0), "NULL")},
            {"FECHA_INICIO", $"'{Me.FechaHoraInicio.Date:yyyy-MM-dd}'"},
            {"HORA_INICIO", $"'{Me.FechaHoraInicio.TimeOfDay:hh\:mm\:ss}'"},
            {"FECHA_FIN", $"'{Me.FechaHoraFin.Date:yyyy-MM-dd}'"},
            {"HORA_FIN", $"'{Me.FechaHoraFin.TimeOfDay:hh\:mm\:ss}'"}
            }
        End If
    End Function

    Public Overrides Function ClavePrimaria() As String()
        Return New String() {Id}
    End Function

    Public Overrides Function ClaveConCampo() As String
        Return $"ID = {Id}"
    End Function

    Public Shared Function UnirFechaYHora(fechaAUnir As DateTime, horaAUnir As TimeSpan) As DateTime
        Return New DateTime(fechaAUnir.Year, fechaAUnir.Month, fechaAUnir.Day, horaAUnir.Hours, horaAUnir.Minutes, horaAUnir.Seconds)
    End Function
End Class
