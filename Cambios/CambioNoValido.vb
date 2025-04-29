Imports Entidades

Public Class CambioNoValido
    Inherits Exception

    Public Sub New(mensaje As String)
        MyBase.New(mensaje)
    End Sub

    Public Sub New(objeto As EntidadBD, mensaje As String)
        MyBase.New(mensaje.Replace("\\objeto", objeto.ToString()))
    End Sub

End Class
