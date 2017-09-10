Module ArrayModule

    'Array methods 
    Public Sub Example5()
        Dim numbers(9) As Integer
        Dim rand As Random = New Random()

        For i = 0 To (numbers.GetLength(0) - 1)
            numbers(i) = rand.Next()
        Next

        Console.WriteLine("<<original numbers>>")
        For Each n In numbers
            Console.Write(n & " ; ")
        Next
        Console.WriteLine()
        Dim temp() As Integer = numbers.Clone
        Array.Sort(temp)
        Console.WriteLine("<<sorted numbers>>")
        For Each n In temp
            Console.Write(n & " ; ")
        Next
        Console.WriteLine()
        Array.Reverse(temp)
        Console.WriteLine("<<reversed numbers>>")
        For Each n In temp
            Console.Write(n & " ; ")
        Next
        Console.WriteLine()
    End Sub

    'Jagged array
    Public Sub Example4()
        Dim matrix As Integer()() = New Integer(9)() {}

        'matrix(0) = New Integer() {1, 2, 3}
        'matrix(1) = New Integer() {4, 5, 6}
        Dim length1, length2 As Integer
        length1 = matrix.GetLength(0)
        'length2 = matrix(0).GetLength(0)
        Console.WriteLine("length1 = " & length1)
        'Console.WriteLine("length2 = " & length2)

        Dim dummy() As Integer = New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        For i = 0 To 9
            'Array.Copy(dummy, matrix(i), 10)  -> does not work
            matrix(i) = dummy.Clone
        Next

        For i = 0 To 9
            For j = 0 To 9
                matrix(i)(j) = i * j
            Next j
        Next i

        Console.WriteLine("<<matrix>>")
        For i = 0 To (matrix.GetLength(0) - 1)
            For j = 0 To (matrix(0).GetLength(0) - 1)
                Console.Write(matrix(i)(j) & " ; ")
            Next j
            Console.WriteLine()
        Next i

        Console.WriteLine()
        'Const delim As String = " ; "
        'Console.WriteLine(matrix(0)(3) & delim & matrix(0)(4) & delim & matrix(3)(0))



        Dim doubleMatrix As Double()() = New Double(4)() {}
        Dim rand As Random = New Random()
        doubleMatrix(0) = New Double() {rand.NextDouble(), rand.NextDouble()}
        doubleMatrix(1) = New Double() {rand.NextDouble(), rand.NextDouble()}
        doubleMatrix(2) = New Double() {rand.NextDouble(), rand.NextDouble()}
        doubleMatrix(3) = New Double() {rand.NextDouble(), rand.NextDouble()}
        doubleMatrix(4) = New Double() {rand.NextDouble(), rand.NextDouble()}

        Console.WriteLine("<<doubleMatrix>>")
        For Each r In doubleMatrix
            For Each n In r
                Console.Write(n & " ; ")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()
        Console.WriteLine("<<doubleMatrix>>")
        For i = 0 To (doubleMatrix.GetLength(0) - 1)
            For j = 0 To (doubleMatrix(0).GetLength(0) - 1)
                Console.Write(doubleMatrix(i)(j) & " ; ")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()

    End Sub

    'Dynamic array 
    Public Sub Example3()
        Dim numbers() As Integer
        ReDim numbers(2)
        numbers(0) = 10
        numbers(1) = 20
        numbers(2) = 30

        ReDim Preserve numbers(10)
        numbers(3) = 40
        numbers(4) = 50
        numbers(5) = 60
        numbers(6) = 70
        numbers(7) = 80
        numbers(8) = 90

        Console.WriteLine("<<numbers>>")
        For Each n In numbers
            Console.Write(n & " ; ")
        Next
        Console.WriteLine()
        Console.WriteLine("<<numbers>>")
        For i = 0 To (numbers.GetLength(0) - 1)
            Console.Write(numbers(i) & " ; ")
        Next
        Console.WriteLine()

    End Sub


    'multi-dimensional array s
    Public Sub Example2()
        Dim matrix(9, 9) As Integer '10x10
        Dim length1, length2 As Integer
        length1 = matrix.GetLength(0)
        length2 = matrix.GetLength(1)
        Console.WriteLine("length1 = " & length1)
        Console.WriteLine("length2 = " & length2)
        Dim rand As Random = New Random()
        For i = 0 To (length1 - 1)
            For j = 0 To (length2 - 1)
                matrix(i, j) = rand.Next()
            Next
        Next

        Console.WriteLine("<<matrix>>")
        For i = 0 To (length1 - 1)
            For j = 0 To (length2 - 1)
                Console.Write(matrix(i, j) & " ; ")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()


    End Sub


    'one-dimensional array s 
    Public Sub Example1()
        Dim numbers(10) As Integer  ' 11 elements 
        Dim length As Integer = numbers.GetLength(0)
        Console.WriteLine("length = " & length)

        For i = 0 To 10
            numbers(i) = i + 100
        Next

        Dim names() As String = {"foo", "bar", "bim", "pako", "deko"}

        Dim doubleNumbers(10) As Double
        Dim rand = New Random()
        For i = 0 To 10
            doubleNumbers(i) = rand.NextDouble()
        Next

        Console.WriteLine("<<numbers>>")
        For Each n In numbers
            Console.Write(n & " ; ")
        Next
        Console.WriteLine()
        Console.WriteLine("<<names>>")
        For i = 0 To (names.GetLength(0) - 1)
            Console.Write(names(i) & " ; ")
        Next

        Console.WriteLine()
        Console.WriteLine("<<doubleNumbers>>")
        For i = 0 To (doubleNumbers.GetLength(0) - 1)
            Console.Write(doubleNumbers(i) & " ; ")
        Next
        Console.WriteLine()

        Dim byteNumbers(10) As Byte
        rand.NextBytes(byteNumbers)
        Console.WriteLine("<<byteNumbers>>")
        For Each b In byteNumbers
            Console.Write(b & " ; ")
        Next
        Console.WriteLine()

    End Sub
End Module
