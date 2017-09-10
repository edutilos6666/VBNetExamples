'Public keyword here is optional
Public Module OperatorsModule


    Public Sub ExampleMiscellaneousOps()
        'GetType 
        Console.WriteLine("GetType(Integer) = " & GetType(Integer).ToString)
        Console.WriteLine("GetType(Long) = " & GetType(Long).ToString)
        Console.WriteLine("GetType(Single) = " & GetType(Single).ToString)
        Console.WriteLine("GetType(Double) = " & GetType(Double).ToString)
        Console.WriteLine("GetType(Boolean) = " & GetType(Boolean).ToString)
        Console.WriteLine("GetType(String) = " & GetType(String).ToString)
        Console.WriteLine()
        'Function aka Lambda expression
        Dim add = Function(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
                      Return (n1 + n2)
                  End Function

        Dim subtract = Function(ByVal n1 As Integer, ByVal n2 As Integer) n1 - n2
        Dim multiply = Function(n1 As Integer, n2 As Integer) n1 * n2
        Dim divide = Function(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
                         Return n1 \ n2
                     End Function

        Console.WriteLine("add(10, 3) = " & add(10, 3))
        Console.WriteLine("subtract(10, 3) = " & subtract(10, 3))
        Console.WriteLine("multiply(10, 3) = " & multiply(10, 3))
        Console.WriteLine("divide(10, 3) = " & divide(10, 3))


        'If 
        Dim n As Integer = 5
        Console.WriteLine("n is " & If(n > 0, "positive", "negative"))
        '^
        Console.WriteLine("3 ^ 4 = " & (3 ^ 4))

    End Sub

    Public Sub ExampleLogicalOps()
        Dim n1, n2 As Boolean
        n1 = True
        n2 = False
        Dim _and = n1 And n2
        Dim _or = n1 Or n2
        Dim _xor = n1 Xor n2
        Dim _andAlso = n1 AndAlso n2
        Dim _orElse = n1 OrElse n2
        Dim _notN1 = Not n1
        Dim _notN2 = Not n2

        Console.WriteLine("n1 = " & n1 & " n2 = " & n2)
        Console.WriteLine("and = " & _and)
        Console.WriteLine("or = " & _or)
        Console.WriteLine("xor = " & _xor)
        Console.WriteLine("andAlso = " & _andAlso)
        Console.WriteLine("orElse = " & _orElse)
        Console.WriteLine("not n1 = " & _notN1)
        Console.WriteLine("not n2 = " & _notN2)
    End Sub

    Public Sub ExampleComparisonOps()
        Dim n1, n2 As Double
        n1 = 10.0
        n2 = 3
        Dim resEq = n1 = n2
        Dim resNe = n1 <> n2
        Dim resLt = n1 < n2
        Dim resLe = n1 <= n2
        Dim resGt = n1 > n2
        Dim resGe = n1 >= n2
        Console.WriteLine("n1 = " & n1 & " n2 = " & n2)
        Console.WriteLine("n1 = n2 = " & resEq)
        Console.WriteLine("n1 <> n2 = " & resNe)
        Console.WriteLine("n1 < n2 = " & resLt)
        Console.WriteLine("n1 <= n2 = " & resLe)
        Console.WriteLine("n1 > n2 = " & resGt)
        Console.WriteLine("n1 >= n2 = " & resGe)
    End Sub

    Public Sub ExampleArithmeticOps()
        Dim n1, n2 As Double
        n1 = 10.0
        n2 = 3
        Dim resAdd = n1 + n2
        Dim resSubtract = n1 - n2
        Dim resMultiply = n1 * n2
        Dim resDivide = n1 / n2
        Dim resDivideInt = n1 \ n2
        Dim resModulo = n1 Mod n2

        Console.WriteLine("n1 + n2 = " & resAdd)
        Console.WriteLine("n1 - n2 = " & resSubtract)
        Console.WriteLine("n1 * n2 = " & resMultiply)
        Console.WriteLine("n1 / n2 = " & resDivide)
        Console.WriteLine("n1 \ n2 = " & resDivideInt)
        Console.WriteLine("n1 % n2 = " & resModulo)
    End Sub
End Module
