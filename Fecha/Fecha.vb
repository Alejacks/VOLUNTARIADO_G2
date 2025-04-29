Public Class Fecha
    Implements IEquatable(Of Fecha)
    Implements IComparable(Of Fecha)

    Private Shared Function FechaValida(dia As Integer, mes As Integer, año As Integer) As Boolean
        If mes < 1 OrElse mes > 12 Then Return False
        Select Case mes
            Case 2
                Return dia >= 1 AndAlso dia <= If(EsBisiesto(año), 29, 28)
            Case 1, 3, 5, 7, 8, 10, 12
                Return dia >= 1 AndAlso dia <= 31
            Case 4, 6, 9, 11
                Return dia >= 1 AndAlso dia <= 30
            Case Else
                Return False
        End Select
    End Function

    Private Shared Function EsBisiesto(año As Integer) As Boolean
        Return (año Mod 4 = 0 AndAlso (año Mod 100 <> 0 OrElse año Mod 400 = 0))
    End Function

    Private Shared Function DiasPorMes(mes As Integer, año As Integer) As Integer
        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                Return 31
            Case 4, 6, 9, 11
                Return 30
            Case 2
                Return If(EsBisiesto(año), 29, 28)
            Case Else
                Return 0
        End Select
    End Function

    Private Shared Function DiferenciaEnDias(inicio As Fecha, fin As Fecha) As Integer
        Dim dias As Integer = 0
        For año As Integer = inicio.Año To fin.Año
            If año = fin.Año Then
                dias += fin.DiasHastaFin()
            ElseIf año = inicio.Año Then
                dias += inicio.DiasDesdeInicio()
            Else
                dias += 365
                If EsBisiesto(año) Then
                    dias += 1
                End If
            End If
        Next

        Return dias
    End Function

    Private Function DiasDesdeInicio() As Integer
        Dim dias As Integer = 0
        For mes As Integer = 1 To mes - 1
            dias += DiasPorMes(mes, Año)
        Next
        dias += Dia
        Return dias
    End Function

    Private Function DiasHastaFin() As Integer
        Dim dias As Integer = 0
        For mes As Integer = mes + 1 To 12
            dias += DiasPorMes(mes, Año)
        Next
        dias += DiasPorMes(Mes, Año) - Dia
        Return dias
    End Function

    Public Shared Function DeDiasAFecha(dias As UInteger) As Fecha
        Dim añoActual As Integer = 1
        Dim mesActual As Integer = 1
        While dias > DiasPorMes(mesActual, añoActual)
            dias -= DiasPorMes(mesActual, añoActual)
            mesActual += 1
            If mesActual > 12 Then
                mesActual = 1
                añoActual += 1
            End If
        End While
        Return New Fecha(dias, mesActual, añoActual)
    End Function

    Public Shared Function DeFechaADias(fecha As Fecha) As UInteger
        Dim dias As Integer = 0
        For año As Integer = 1 To fecha.Año - 1
            dias += 365 + If(EsBisiesto(año), 1, 0)
        Next
        For mes As Integer = 1 To fecha.Mes - 1
            dias += DiasPorMes(mes, fecha.Año)
        Next
        dias += fecha.Dia
        Return dias
    End Function

    Private _Dia As Byte
    Private _Mes As Byte
    Private _Año As Integer

    Public Property Dia As Integer
        Get
            Return _Dia
        End Get
        Set(value As Integer)
            If Not FechaValida(value, _Mes, _Año) Then
                Throw New ArgumentOutOfRangeException("Día no válido para el mes y año recibidos")
            End If
            _Dia = value
        End Set
    End Property

    Public Property Mes As Integer
        Get
            Return _Mes
        End Get
        Set(value As Integer)
            If Not FechaValida(_Dia, value, _Año) Then
                Throw New ArgumentOutOfRangeException("Mes no válido para el día y año recibidos")
            End If
            _Mes = value
        End Set
    End Property

    Public Property Año As Integer
        Get
            Return _Año
        End Get
        Set(value As Integer)
            If Not FechaValida(_Dia, _Mes, value) Then
                Throw New ArgumentOutOfRangeException("Año no válido para el día y mes recibidos")
            End If
            _Año = value
        End Set
    End Property

    Public Sub New(dia As Integer, mes As Integer, año As Integer)
        If Not FechaValida(dia, mes, año) Then
            Throw New ArgumentOutOfRangeException("Día no válido para el mes y año recibidos")
        End If
        _Dia = dia
        _Mes = mes
        _Año = año
    End Sub

    Public Sub New(fecha As String, Optional formato As String = "a-m-d")
        Dim partesFecha As String() = fecha.Split(If(fecha.Contains("/"), "/", "-"))
        Dim partesFormato As String() = formato.Split(If(formato.Contains("/"), "/", "-"))
        If partesFecha.Length <> 3 OrElse partesFormato.Length <> 3 Then
            Throw New ArgumentException("La fecha y el formato deben contener exactamente 3 partes")
        End If
        For i As Integer = 0 To 2
            Dim formatoActual = partesFormato(i).Trim().ToLower()
            Select Case formatoActual
                Case "d"
                    _Dia = Integer.Parse(partesFecha(i))
                Case "m"
                    _Mes = Integer.Parse(partesFecha(i))
                Case "a"
                    _Año = Integer.Parse(partesFecha(i))
                Case Else
                    Throw New ArgumentException($"Formato de fecha no válido, el formato {formatoActual}")
            End Select
        Next
        If Not FechaValida(_Dia, _Mes, _Año) Then
            Throw New ArgumentOutOfRangeException("Fecha no válida")
        End If
    End Sub

    Public ReadOnly Property Dias As Integer
        Get
            Return DeFechaADias(Me)
        End Get
    End Property

    Public Shared Operator =(Left As Fecha, Right As Fecha) As Boolean
        If Left Is Nothing OrElse Right Is Nothing Then Return False
        Return Left.Equals(Right)
    End Operator

    Public Shared Operator <>(Left As Fecha, Right As Fecha) As Boolean
        Return Not Left = Right
    End Operator

    Public Shared Operator <(Left As Fecha, Right As Fecha) As Boolean
        If Left Is Nothing OrElse Right Is Nothing Then Return False
        Return Left.CompareTo(Right) < 0
    End Operator

    Public Shared Operator >(Left As Fecha, Right As Fecha) As Boolean
        If Left Is Nothing OrElse Right Is Nothing Then Return False
        Return Left.CompareTo(Right) > 0
    End Operator

    Public Shared Operator +(Left As Fecha, Right As Fecha) As Fecha
        Return DeDiasAFecha(DeFechaADias(Left) + DeFechaADias(Right))
    End Operator

    Public Shared Operator -(Left As Fecha, Right As Fecha) As Fecha
        Return DeDiasAFecha(DeFechaADias(Left) - DeFechaADias(Right))
    End Operator

    Public Overloads Function Equals(other As Fecha) As Boolean Implements IEquatable(Of Fecha).Equals
        If other Is Nothing Then Return False
        Return _Dia = other.Dia AndAlso _Mes = other.Mes AndAlso _Año = other.Año
    End Function

    Public Function CompareTo(other As Fecha) As Integer Implements IComparable(Of Fecha).CompareTo
        If other Is Nothing Then Return 1
        If Equals(other) Then Return 0
        If _Año <> other.Año Then
            Return _Año.CompareTo(other.Año)
        ElseIf _Mes <> other.Mes Then
            Return _Mes.CompareTo(other.Mes)
        Else
            Return _Dia.CompareTo(other.Dia)
        End If
    End Function

    Public Overrides Function ToString() As String
        Return $"{_Año:D4}/{_Mes:D2}/{_Dia:D2}"
    End Function

    Public Overloads Function ToString(formato As String) As String
        Dim separador As Char = If(formato.Contains("/"), "/", "-")
        Dim resultado As String = ""
        For Each parte In formato.Split(separador)
            Select Case parte.Trim().ToLower()
                Case "d"
                    resultado += _Dia.ToString("D2")
                Case "m"
                    resultado += _Mes.ToString("D2")
                Case "a"
                    resultado += _Año.ToString("D4")
            End Select
            resultado += separador
        Next
        Return resultado.TrimEnd(separador)
    End Function
End Class
