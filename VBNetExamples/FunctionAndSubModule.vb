Module FunctionAndSubModule

    Public Sub Example2()
        Dim n1, n2 As Double
        n1 = 10
        n2 = 3
        SwapByValue(n1, n2)
        Console.WriteLine("<<after SwapByValue>>")
        Console.WriteLine("n1 = " & n1 & " , n2 = " & n2)
        SwapByRef(n1, n2)
        Console.WriteLine("<<after SwapByRef>>")
        Console.WriteLine("n1 = " & n1 & " , n2 = " & n2)
    End Sub

    Public Sub Example1()
        Dim max = FindMax(10, 20, 30)
        Dim fac10 = Faculty(10)
        Console.WriteLine("max = " & max)
        Console.WriteLine("10! = " & fac10)

        Dim nums(9) As Integer
        Dim rand As Random = New Random()
        For i = 0 To (nums.GetLength(0) - 1)
            nums(i) = rand.Next() Mod 100
        Next
        NumberStatistics(nums)
        Console.WriteLine()
        NumberStatistics2(nums)
    End Sub


    'Passing doubles by value
    Private Sub SwapByValue(ByVal n1 As Double,
                            ByVal n2 As Double)
        Dim temp As Double = n1
        n1 = n2
        n2 = temp
    End Sub
    'Passing doubles by ref 
    Private Sub SwapByRef(ByRef n1 As Double,
                          ByRef n2 As Double)
        Dim temp As Double = n1
        n1 = n2
        n2 = temp
    End Sub


    'Passing Array as Parameter 
    Private Sub NumberStatistics2(nums As Integer())
        Dim sum As Integer = 0
        Dim avg As Double = 0
        Dim min, max As Integer
        Dim count As Integer = 0
        count = nums.Count

        min = nums(0)
        max = nums(0)

        For Each number In nums
            sum += number
            If number > max Then
                max = number
            End If

            If number < min Then
                min = number
            End If
        Next
        avg = sum / count

        Console.WriteLine("<<Numbers Statistics>>")
        Console.Write("numbers = ")
        For Each number In nums
            Console.Write(number & " ; ")
        Next
        Console.WriteLine()
        Console.WriteLine("count = " & count)
        Console.WriteLine("min = " & min)
        Console.WriteLine("max = " & max)
        Console.WriteLine("sum = " & sum)
        Console.WriteLine("avg = " & avg)

    End Sub


    'ParamArray 
    Private Sub NumberStatistics(ParamArray nums As Integer())
        Dim sum As Integer = 0
        Dim avg As Double = 0
        Dim min, max As Integer
        Dim count As Integer = 0
        count = nums.Count

        min = nums(0)
        max = nums(0)

        For Each number In nums
            sum += number
            If number > max Then
                max = number
            End If

            If number < min Then
                min = number
            End If
        Next
        avg = sum / count

        Console.WriteLine("<<Numbers Statistics>>")
        Console.Write("numbers = ")
        For Each number In nums
            Console.Write(number & " ; ")
        Next
        Console.WriteLine()
        Console.WriteLine("count = " & count)
        Console.WriteLine("min = " & min)
        Console.WriteLine("max = " & max)
        Console.WriteLine("sum = " & sum)
        Console.WriteLine("avg = " & avg)

    End Sub

    'Simple Function 
    Private Function FindMax(ByVal n1 As Integer,
                             ByVal n2 As Integer,
                             ByVal n3 As Integer) As Integer
        Dim res As Integer = n1
        If res < n2 Then
            res = n2
        End If

        If res < n3 Then
            res = n3
        End If

        Return res
    End Function


    'Recursive Function 
    Private Function Faculty(ByVal n As Long) As Long
        If n <= 0 Then
            Return 1
        Else
            Return n * Faculty(n - 1)
        End If
    End Function

End Module
