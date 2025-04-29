Imports System.ComponentModel

Public Class Voluntario
    Inherits EntidadBD
    Implements IEquatable(Of Voluntario)
    Implements IComparable(Of Voluntario)

    Public Overrides ReadOnly Property NombreTabla As String = "VOLUNTARIO"

    Public Property Nif As String
    Public Property Nombre As String
    Public Property Apellido1 As String
    Public Property Apellido2 As String
    Public Property Telefono As String
    Public Property Correo As String
    Public Property Experiencia As String
    Public Property Estudia As Curso

    Public ReadOnly Property NombreCompleto As String
        Get
            Return $"{Nombre} {Apellido1} {Apellido2}"
        End Get
    End Property

    Public ReadOnly Property ApellidoNombre As String
        Get
            If Apellido2 Is Nothing Then
                Return $"{Apellido1}, {Nombre}"
            Else
                Return $"{Apellido1} {Apellido2}, {Nombre}"
            End If
        End Get
    End Property

    Public Sub New(nif As String, nombre As String, apellido1 As String, correo As String, estudia As Curso, Optional telefono As String = Nothing, Optional experiencia As String = Nothing)
        Me.Nif = nif
        Me.Nombre = nombre
        Me.Apellido1 = apellido1
        Me.Apellido2 = Nothing
        Me.Telefono = telefono
        Me.Correo = correo
        Me.Experiencia = experiencia
        Me.Estudia = estudia
    End Sub

    Public Sub New(nif As String, nombre As String, apellido1 As String, apellido2 As String, correo As String, estudia As Curso, Optional telefono As String = Nothing, Optional experiencia As String = Nothing)
        Me.Nif = nif
        Me.Nombre = nombre
        Me.Apellido1 = apellido1
        Me.Apellido2 = apellido2
        Me.Telefono = telefono
        Me.Correo = correo
        Me.Experiencia = experiencia
        Me.Estudia = estudia
    End Sub

    Public Overrides Function ToString() As String
        Return ApellidoNombre
    End Function

    Private Function DigitosNif() As Integer
        Dim nifLimpio As String = ""
        For Each digito As Char In Nif
            If Char.IsDigit(digito) Then
                nifLimpio &= digito
            End If
        Next
        Return nifLimpio
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Me.Equals(TryCast(obj, Voluntario))
    End Function

    Public Overloads Function Equals(other As Voluntario) As Boolean Implements IEquatable(Of Voluntario).Equals
        If ReferenceEquals(Me, other) Then Return True
        Return other IsNot Nothing AndAlso other.Nif.Equals(Nif)
    End Function

    Public Function CompareTo(other As Voluntario) As Integer Implements IComparable(Of Voluntario).CompareTo
        If Me.Equals(other) Then Return 0
        Return Me.DigitosNif.CompareTo(other.DigitosNif)
    End Function

    Public Overrides Function CamposConValores() As Dictionary(Of String, String)
        Return New Dictionary(Of String, String) From {
            {"NIF", $"'{Me.Nif}'"},
            {"NOMBRE", $"'{Me.Nombre}'"},
            {"APELLIDO1", $"'{Me.Apellido1}'"},
            {"APELLIDO2", If(Me.Apellido2 IsNot Nothing AndAlso Not String.IsNullOrEmpty(Me.Apellido2), $"'{Me.Apellido2}'", "NULL")},
            {"TELEFONO", If(Me.Telefono IsNot Nothing AndAlso Not String.IsNullOrEmpty(Me.Telefono), $"'{Telefono}'", "NULL")},
            {"CORREO", $"'{Me.Correo}'"},
            {"EXPERIENCIA", If(Me.Experiencia IsNot Nothing AndAlso Not String.IsNullOrEmpty(Me.Experiencia), $"'{Experiencia}'", "NULL")},
            {"ESTUDIA", Me.Estudia.ClavePrimaria(0)}
        }
    End Function

    Public Overrides Function ClavePrimaria() As String()
        Return New String() {Nif}
    End Function

    Public Overrides Function ClaveConCampo() As String
        Return $"NIF = '{Nif}'"
    End Function
End Class
