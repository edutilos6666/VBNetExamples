Module ExceptionModule

    Public Sub Example1()
        Dim n1, n2, res As Double
        n1 = 10
        n2 = 3
        Try
            res = SafeDivide(n1, n2)
            Console.WriteLine("res = " & res)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.WriteLine("first invokation ended.")
        End Try

        n2 = 0
        Try
            res = SafeDivide(n1, n2)
            Console.WriteLine("res = " & res)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.WriteLine("second invokation ended.")
        End Try

    End Sub


    Private Function SafeDivide(ByVal n1 As Double, ByVal n2 As Double) As Double
        If n2 = 0 Then
            Throw New CustomDivisionByZeroException("n2 is 0")
        Else
            Return n1 / n2
        End If
    End Function

    Private Class CustomDivisionByZeroException : Inherits ApplicationException
        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class



End Module
