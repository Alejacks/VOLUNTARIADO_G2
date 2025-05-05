Public Class Hora
    Inherits EntidadBD

    Public Overrides ReadOnly Property NombreTabla As String
        Get
            Return "HORA"
        End Get
    End Property

    Public Property Dia As Dia
    Public Property HoraInicio As DateTime
    Public Property HoraFin As DateTime

    Public Sub New(dia As Dia, horaInicio As DateTime, horaFin As DateTime)
        Me.Dia = dia
        Me.HoraInicio = horaInicio
        Me.HoraFin = horaFin
    End Sub

    Public Overrides Function Clonar() As EntidadBD
        Return New Hora(Me.Dia, Me.HoraInicio, Me.HoraFin)
    End Function

    Public Overrides Function CamposConValores(Optional aptoParaInsert As Boolean = False) As Dictionary(Of String, String)
        Return New Dictionary(Of String, String) From {
            {"DIA", $"'{Me.Dia.ClavePrimaria(0)}'"},
            {"HORA_INICIO", $"'{Me.HoraInicio:hh\:mm\:ss}'"},
            {"HORA_FIN", $"'{Me.HoraFin:hh\:mm\:ss}'"}
        }
    End Function

    Public Overrides Function ClavePrimaria() As String()
        Return New String() {Me.Dia.ClavePrimaria(0), $"'{Me.HoraInicio:hh\:mm\:ss}'", $"'{Me.HoraFin:hh\:mm\:ss}'"}
    End Function

    Public Overrides Function ClaveConCampo() As String
        Return $"DIA = {Me.Dia.ClavePrimaria(0)} AND HORA_INICIO = '{Me.HoraInicio:hh\:mm\:ss}' AND HORA_FIN = '{Me.HoraFin:hh\:mm\:ss}'"
    End Function
End Class