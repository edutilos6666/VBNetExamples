Imports VBNetExamples

Public Module ModuleExample

    Enum CustomWeekDays
        Sunday
        Monday
        Tuesday
        Wednesday
        Thursday
        Friday
        Saturday
    End Enum
    Public Sub Example1()
        Console.WriteLine("value of Sunday = " & CustomWeekDays.Sunday)
        Console.WriteLine("value of Monday = " & CustomWeekDays.Monday)
        Console.WriteLine("value of Tuesday = " & CustomWeekDays.Tuesday)
        Console.WriteLine("value of Wednesday = " & CustomWeekDays.Wednesday)
        Console.WriteLine("value of Thursday = " & CustomWeekDays.Thursday)
        Console.WriteLine("value of Friday = " & CustomWeekDays.Friday)
        Console.WriteLine("value of Saturday = " & CustomWeekDays.Saturday)
    End Sub



    Public Sub ExampleDelegate()
        Dim n1 = 10.0
        Dim n2 = 3.0
        Dim delUser As New CustomDelegateUser(n1, n2)
        Dim resAdd = delUser.RunArithmeticDelegate(AddressOf Add)
        Dim resSubtract = delUser.RunArithmeticDelegate(AddressOf Subtract)
        Dim resMultiply = delUser.RunArithmeticDelegate(AddressOf Multiply)
        Dim resDivide = delUser.RunArithmeticDelegate(AddressOf Divide)

        Dim resEq = delUser.RunComparisonDelegate(AddressOf eq)
        Dim resNe = delUser.RunComparisonDelegate(AddressOf ne)
        Dim resLt = delUser.RunComparisonDelegate(AddressOf lt)
        Dim resLe = delUser.RunComparisonDelegate(AddressOf le)
        Dim resGt = delUser.RunComparisonDelegate(AddressOf gt)
        Dim resGe = delUser.RunComparisonDelegate(AddressOf ge)

        Console.WriteLine("resAdd = " & resAdd)
        Console.WriteLine("resSubtract = " & resSubtract)
        Console.WriteLine("resMultiply = " & resMultiply)
        Console.WriteLine("resDivide = " & resDivide)
        Console.WriteLine("resEq = " & resEq)
        Console.WriteLine("resNe = " & resNe)
        Console.WriteLine("resLt = " & resLt)
        Console.WriteLine("resLe = " & resLe)
        Console.WriteLine("resGt = " & resGt)
        Console.WriteLine("resGe = " & resGe)
    End Sub


    Public Sub ExampleWorker()
        Dim w As New Worker(1, "foo", 10, 100.0, True)
        Console.WriteLine(w)
        Console.WriteLine()
        Console.WriteLine("id = " & w.Id)
        Console.WriteLine("name = " & w.Name)
        Console.WriteLine("age = " & w.Age)
        Console.WriteLine("wage = " & w.Wage)
        Console.WriteLine("active = " & w.Active)
    End Sub


    Public Sub ExampleProgrammer()
        Dim p As New Programmer(2, "edu", 20, 200.0, False)
        Console.WriteLine(p)
        Console.WriteLine()
        Console.WriteLine(String.Format("id = {0}", p.Id))
        Console.WriteLine(String.Format("name = {0}", p.Name))
        Console.WriteLine(String.Format("age = {0}", p.Age))
        Console.WriteLine(String.Format("wage = {0}", p.Wage))
        Console.WriteLine(String.Format("active = {0}", p.Active))
    End Sub


    Public Sub ExampleCustomFile()
        Dim cf1, cf2, cf3, cf4 As CustomFile
        cf1 = New CustomFile("foo.write")
        cf2 = New CustomFile("foo.read")
        cf3 = New CustomFile("foo.exe")
        cf4 = New CustomFile("foo.write.read.exe")
        Console.WriteLine("infos about " & cf1.FileName)
        Console.WriteLine("isWritable = " & cf1.IsWritable())
        Console.WriteLine("isReadable = " & cf1.IsReadable)
        Console.WriteLine("isExecutable = " & cf1.IsExecutable)
        cf1.Write()
        cf1.Read()
        cf1.Execute()
        Console.WriteLine()

        Console.WriteLine("infos about " & cf2.FileName)
        Console.WriteLine("isWritable = " & cf2.IsWritable())
        Console.WriteLine("isReadable = " & cf2.IsReadable)
        Console.WriteLine("isExecutable = " & cf2.IsExecutable)
        cf2.Write()
        cf2.Read()
        cf2.Execute()
        Console.WriteLine()

        Console.WriteLine("infos about " & cf3.FileName)
        Console.WriteLine("isWritable = " & cf3.IsWritable())
        Console.WriteLine("isReadable = " & cf3.IsReadable)
        Console.WriteLine("isExecutable = " & cf3.IsExecutable)
        cf3.Write()
        cf3.Read()
        cf3.Execute()
        Console.WriteLine()

        Console.WriteLine("infos about " & cf4.FileName)
        Console.WriteLine("isWritable = " & cf4.IsWritable())
        Console.WriteLine("isReadable = " & cf4.IsReadable)
        Console.WriteLine("isExecutable = " & cf4.IsExecutable)
        cf4.Write()
        cf4.Read()
        cf4.Execute()
        Console.WriteLine()

    End Sub


    Public Sub ExampleOperatorOverloading()
        Dim b1, b2 As Box
        b1 = New Box(1, 1, 1)
        b2 = New Box(2, 2, 2)
        Dim bAdd As Box = b1 + b2
        Dim bSubtract As Box = b1 - b2
        Dim bMultiply As Box = b1 * b2
        Dim bDivide As Box = b1 / b2
        Dim bMultiplyWith2 As Box = b1 * 2
        Dim bDivideWith2 As Box = b1 / 2
        Dim eq As Boolean = b1 = b2
        Dim ne As Boolean = b1 <> b2
        Dim lt As Boolean = b1 < b2
        Dim le As Boolean = b1 <= b2
        Dim gt As Boolean = b1 > b2
        Dim ge As Boolean = b1 >= b2
        Console.WriteLine("b1 = " & b1.ToString)
        Console.WriteLine("b2 = " & b2.ToString)
        Console.WriteLine("b1 + b2 = " & bAdd.ToString)
        Console.WriteLine("b1 - b2 = " & bSubtract.ToString)
        Console.WriteLine("b1 * b2 = " & bMultiply.ToString)
        Console.WriteLine("b1 / b2 = " & bDivide.ToString)
        Console.WriteLine("b1 * 2 = " & bMultiplyWith2.ToString)
        Console.WriteLine("b1 /2 = " & bDivideWith2.ToString)
        Console.WriteLine("b1 = b2 = " & eq)
        Console.WriteLine("b1 <> b2 = " & ne)
        Console.WriteLine("b1 < b2 = " & lt)
        Console.WriteLine("b1 <= b2 = " & le)
        Console.WriteLine("b1 > b2 = " & gt)
        Console.WriteLine("b1 >= b2 = " & ge)

    End Sub


    Public Function Add(ByVal n1 As Double, ByVal n2 As Double) As Double
        Return n1 + n2
    End Function

    Public Function Subtract(ByVal n1 As Double, ByVal n2 As Double) As Double
        Return n1 - n2
    End Function

    Public Function Multiply(ByVal n1 As Double, ByVal n2 As Double) As Double
        Return n1 * n2
    End Function

    Public Function Divide(ByVal n1 As Double, ByVal n2 As Double) As Double
        Return n1 / n2
    End Function


    Public Function eq(ByVal n1 As Double, ByVal n2 As Double) As Boolean
        Return n1 = n2
    End Function

    Public Function ne(ByVal n1 As Double, ByVal n2 As Double) As Boolean
        Return n1 <> n2
    End Function

    Public Function lt(ByVal n1 As Double, ByVal n2 As Double) As Boolean
        Return n1 < n2
    End Function

    Public Function le(ByVal n1 As Double, ByVal n2 As Double) As Boolean
        Return n1 <= n2
    End Function

    Public Function gt(ByVal n1 As Double, ByVal n2 As Double) As Boolean
        Return n1 > n2
    End Function

    Public Function ge(ByVal n1 As Double, ByVal n2 As Double) As Boolean
        Return n1 >= n2
    End Function


    Public Class Worker
        Public Property Id() As Long
        Public Property Name() As String
        Public Property Age() As Integer
        Public Property Wage() As Double
        Public Property Active() As Boolean
        Public Sub New()

        End Sub
        Public Sub New(ByVal _id As Long,
                       ByVal _name As String,
                       ByVal _age As Integer,
                       ByVal _wage As Double,
                       ByVal _active As Boolean)
            Id = _id
            Name = _name
            Age = _age
            Wage = _wage
            Active = _active
        End Sub


        Public Overrides Function ToString() As String
            Return String.Format("Worker({0},{1},{2},{3},{4})",
                                 Id, Name, Age, Wage, Active)
        End Function

    End Class

    Public Structure Programmer
        Public Property Id() As Long
        Public Property Name() As String
        Public Property Age() As Integer
        Public Property Wage() As Double
        Public Property Active() As Boolean
        Public Sub New(ByVal _id As Long,
                       ByVal _name As String,
                       ByVal _age As Integer,
                       ByVal _wage As Double,
                       ByVal _active As Boolean)
            Id = _id
            Name = _name
            Age = _age
            Wage = _wage
            Active = _active
        End Sub


        Public Overrides Function ToString() As String
            Return String.Format("Programmer({0},{1},{2},{3},{4})",
                          Id, Name, Age, Wage, Active)
        End Function
    End Structure


    Public Interface Writable
        Function IsWritable() As Boolean
        Sub Write()
    End Interface

    Public Interface Readable
        Function IsReadable() As Boolean
        Sub Read()
    End Interface

    Public Interface Executable
        Function IsExecutable() As Boolean
        Sub Execute()
    End Interface

    Public Class CustomFile : Implements Writable, Readable, Executable
        Public Property FileName() As String
        Public Sub New()

        End Sub
        Public Sub New(ByVal _fileName As String)
            FileName = _fileName
        End Sub

        Public Sub Execute() Implements Executable.Execute
            If IsExecutable() Then
                Console.WriteLine(FileName & " was executed.")
            Else
                Console.WriteLine(FileName & " is not executable.")
            End If
        End Sub

        Public Sub Read() Implements Readable.Read
            If IsReadable() Then
                Console.WriteLine(FileName & " was read.")
            Else
                Console.WriteLine(FileName & " is not readable.")
            End If
        End Sub

        Public Sub Write() Implements Writable.Write
            If IsWritable() Then
                Console.WriteLine(FileName & " was written.")
            Else
                Console.WriteLine(FileName & " is not writable.")
            End If
        End Sub

        Public Function IsExecutable() As Boolean Implements Executable.IsExecutable
            If FileName.Contains(".exe") Then
                Return True
            End If
            Return False
        End Function

        Public Function IsReadable() As Boolean Implements Readable.IsReadable
            If FileName.Contains(".read") Then
                Return True
            End If
            Return False
        End Function

        Public Function IsWritable() As Boolean Implements Writable.IsWritable
            If FileName.Contains(".write") Then
                Return True
            End If
            Return False
        End Function
    End Class


    'Delegate Example
    Public Class CustomDelegateUser
        Delegate Function ArithmeticDelegate(ByVal n1 As Double,
                                             ByVal n2 As Double) As Double
        Delegate Function ComparisonDelegate(ByVal n1 As Double,
                                             ByVal n2 As Double) As Boolean
        Public Property N1() As Double
        Public Property N2() As Double
        Public Sub New()

        End Sub
        Public Sub New(ByVal _n1 As Double, ByVal _n2 As Double)
            N1 = _n1
            N2 = _n2
        End Sub

        Public Function RunArithmeticDelegate(ByVal myDelegate As ArithmeticDelegate) As Double
            Dim res As Double = myDelegate(N1, N2)
            Return res
        End Function

        Public Function RunComparisonDelegate(ByVal myDelegate As ComparisonDelegate) As Boolean
            Dim res As Boolean = myDelegate(N1, N2)
            Return res
        End Function

    End Class


    'Operator overloading example 
    Public Class Box
        Public Property Width() As Double
        Public Property Height() As Double
        Public Property Depth() As Double

        Public Sub New()

        End Sub

        Public Sub New(ByVal _width As Double,
                       ByVal _height As Double,
                       ByVal _depth As Double)
            Width = _width
            Height = _height
            Depth = _depth
        End Sub

        Public Function Volume() As Double
            Return Width * Height * Depth
        End Function


        Public Shared Operator +(b1 As Box, b2 As Box) As Box
            Dim ret As New Box()
            ret.Width = b1.Width + b2.Width
            ret.Height = b1.Height + b2.Height
            ret.Depth = b1.Depth + b2.Depth
            Return ret
        End Operator


        Public Shared Operator -(b1 As Box, b2 As Box) As Box
            Dim ret As New Box()
            ret.Width = b1.Width - b2.Width
            ret.Height = b1.Height - b2.Height
            ret.Depth = b1.Depth - b2.Depth
            Return ret
        End Operator

        Public Shared Operator *(b1 As Box, b2 As Box) As Box
            Dim ret As New Box()
            ret.Width = b1.Width * b2.Width
            ret.Height = b1.Height * b2.Height
            ret.Depth = b1.Depth * b2.Depth
            Return ret
        End Operator

        Public Shared Operator /(b1 As Box, b2 As Box) As Box
            Dim ret As New Box()
            ret.Width = b1.Width / b2.Width
            ret.Height = b1.Height / b2.Height
            ret.Depth = b1.Depth / b2.Depth
            Return ret
        End Operator


        Public Shared Operator *(b As Box, factor As Double) As Box
            Dim ret As New Box()
            ret.Width = b.Width * factor
            ret.Height = b.Height * factor
            ret.Depth = b.Depth * factor
            Return ret
        End Operator

        Public Shared Operator /(b As Box, factor As Double) As Box
            Dim ret As New Box()
            ret.Width = b.Width / factor
            ret.Height = b.Height / factor
            ret.Depth = b.Depth / factor
            Return ret
        End Operator

        Public Shared Operator =(b1 As Box, b2 As Box) As Boolean
            Return b1.Volume() = b2.Volume()
        End Operator

        Public Shared Operator <>(b1 As Box, b2 As Box) As Boolean
            Return b1.Volume() <> b2.Volume()
        End Operator

        Public Shared Operator <(b1 As Box, b2 As Box) As Boolean
            Return b1.Volume() < b2.Volume()
        End Operator

        Public Shared Operator >(b1 As Box, b2 As Box) As Boolean
            Return b1.Volume() > b2.Volume()
        End Operator

        Public Shared Operator <=(b1 As Box, b2 As Box) As Boolean
            Return b1.Volume() <= b2.Volume()
        End Operator

        Public Shared Operator >=(b1 As Box, b2 As Box) As Boolean
            Return b1.Volume() >= b2.Volume()
        End Operator


        Public Overrides Function ToString() As String
            Return String.Format("[{0},{1},{2}]", Width, Height, Depth)
        End Function

    End Class

End Module
