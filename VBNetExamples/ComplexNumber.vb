Public Class ComplexNumber
    Public Property Re() As Double
    Public Property Im() As Double
    Public Sub New(_re As Double, _im As Double)
        Re = _re
        Im = _im
    End Sub

    Public Sub New()

    End Sub

    Public Function Add(ByRef other As ComplexNumber) As ComplexNumber
        Dim ret As New ComplexNumber()
        ret.Re = Me.Re + other.Re
        ret.Im = Me.Im + other.Im
        Return ret
    End Function

    Public Function Subtract(ByRef other As ComplexNumber) As ComplexNumber
        Dim ret As New ComplexNumber()
        ret.Re = Me.Re - other.Re
        ret.Im = Me.Im - other.Im
        Return ret
    End Function

    Public Function Multiply(ByRef other As ComplexNumber) As ComplexNumber
        Dim ret As New ComplexNumber()
        ret.Re = Me.Re * other.Re - Me.Im * other.Im
        ret.Im = Me.Re * other.Im + Me.Im * other.Re
        Return ret
    End Function


    Public Function Multiply(ByVal factor As Double) As ComplexNumber
        Dim ret As New ComplexNumber()
        ret.Re = Me.Re * factor
        ret.Im = Me.Im * factor
        Return ret
    End Function


    Public Function Divide(ByRef other As ComplexNumber) As ComplexNumber
        Dim temp As New ComplexNumber(other.Re, -other.Im)
        Dim ret As ComplexNumber = Me.Multiply(temp)
        Dim factor = Math.Pow(other.Re, 2) + Math.Pow(other.Im, 2)
        ret = ret.Divide(factor)
        Return ret
    End Function

    Public Function Divide(ByVal factor As Double) As ComplexNumber
        Dim ret As New ComplexNumber()
        ret.Re = Me.Re / factor
        ret.Im = Me.Im / factor
        Return ret
    End Function


    Public Overrides Function ToString() As String
        Return String.Format("{0} + i*({1})", Me.Re, Me.Im)
    End Function



End Class
