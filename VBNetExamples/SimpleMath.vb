Public Class SimpleMath
    Public Shared Function Add(ByVal n1 As Double,
                               ByVal n2 As Double) As Double
        Return n1 + n2
    End Function

    Public Shared Function Subtract(ByVal n1 As Double,
                                    ByVal n2 As Double) As Double
        Return n1 - n2
    End Function

    Public Shared Function Multiply(ByVal n1 As Double,
                                    ByVal n2 As Double) As Double
        Return n1 * n2
    End Function

    Public Shared Function Divide(ByVal n1 As Double,
                                  ByVal n2 As Double) As Double
        Return n1 / n2
    End Function

    Public Shared Function Modulo(ByVal n1 As Double,
                                  ByVal n2 As Double) As Double
        Return n1 Mod n2
    End Function

End Class
