Imports FechaSencilla

Public Class Organizacion
    Inherits EntidadBD

    Implements IEquatable(Of Organizacion)
    Implements IComparable(Of Organizacion)

    Public Overrides ReadOnly Property NombreTabla As String = "ORGANIZACION"

    Public Property Id As Integer
    Public Property Nombre As String
    Public Property NombreResponsable As String
    Public Property Apellido1Responsable As String
    Public Property Apellido2Responsable As String
    Public Property FechaRegistro As Fecha
    Public ReadOnly Property NombreResponsableCompleto As String
        Get
            Return $"{Me.NombreResponsable} {Me.Apellido1Responsable} {If(Me.Apellido2Responsable IsNot Nothing, Me.Apellido2Responsable, "")}"
        End Get
    End Property

    Public Sub New(id As Integer, nombre As String, nombreResponsable As String, apellido1responsable As String, fechaRegistro As Fecha)
        Me.Id = id
        Me.Nombre = nombre
        Me.NombreResponsable = nombreResponsable
        Me.Apellido1Responsable = apellido1responsable
        Me.Apellido2Responsable = Nothing
        Me.FechaRegistro = fechaRegistro
    End Sub

    Public Sub New(id As Integer, nombre As String, nombreResponsable As String, apellido1responsable As String, apellido2responsable As String, fechaRegistro As Fecha)
        Me.Id = id
        Me.Nombre = nombre
        Me.NombreResponsable = nombreResponsable
        Me.Apellido1Responsable = apellido1responsable
        Me.Apellido2Responsable = apellido2responsable
        Me.FechaRegistro = fechaRegistro
    End Sub

    Public Overrides Function Clonar() As EntidadBD
        Return New Organizacion(Me.Id, Me.Nombre, Me.NombreResponsable, Me.Apellido1Responsable, Me.Apellido2Responsable, Me.FechaRegistro)
    End Function

    Public Overrides Function ToString() As String
        Return If(Me.Nombre Is Nothing, "", Me.Nombre)
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Me.Equals(TryCast(obj, Organizacion))
    End Function

    Public Overloads Function Equals(other As Organizacion) As Boolean Implements IEquatable(Of Organizacion).Equals
        If ReferenceEquals(Me, other) Then Return True
        Return other IsNot Nothing AndAlso other.Id.Equals(Id)
    End Function

    Public Overloads Function Equals(id As Integer) As Boolean
        Return Me.Id.Equals(id)
    End Function

    Public Function CompareTo(other As Organizacion) As Integer Implements IComparable(Of Organizacion).CompareTo
        If Me.Equals(other) OrElse other Is Nothing Then Return 0
        Return Id.CompareTo(other.Id)
    End Function

    Public Overrides Function CamposConValores(Optional aptoParaInsert As Boolean = False) As Dictionary(Of String, String)
        If aptoParaInsert Then
            Return New Dictionary(Of String, String) From {
                {"NOMBRE", $"'{Me.Nombre}'"},
                {"NOMBRE_RESPONSABLE", $"'{Me.NombreResponsable}'"},
                {"APELLIDO1_RESPONSABLE", $"'{Me.Apellido1Responsable}'"},
                {"APELLIDO2_RESPONSABLE", If(Me.Apellido2Responsable IsNot Nothing AndAlso Not String.IsNullOrEmpty(Me.Apellido2Responsable), $"'{Me.Apellido2Responsable}'", "NULL")},
                {"FECHA_REGISTRO", $"'{Me.FechaRegistro:a-m-d}'"}
            }
        Else
            Return New Dictionary(Of String, String) From {
                {"ID", Me.Id},
                {"NOMBRE", $"'{Me.Nombre}'"},
                {"NOMBRE_RESPONSABLE", $"'{Me.NombreResponsable}'"},
                {"APELLIDO1_RESPONSABLE", $"'{Me.Apellido1Responsable}'"},
                {"APELLIDO2_RESPONSABLE", If(Me.Apellido2Responsable IsNot Nothing AndAlso Not String.IsNullOrEmpty(Me.Apellido2Responsable), $"'{Me.Apellido2Responsable}'", "NULL")},
                {"FECHA_REGISTRO", $"'{Me.FechaRegistro:a-m-d}'"}
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
