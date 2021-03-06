﻿Module Module1

    Sub Main()
        TestFileHandlingModule()
    End Sub


    Private Sub TestFileHandlingModule()
        'FileHandlingModule.Example1()
        'FileHandlingModule.Example2()
        'FileHandlingModule.Example3()
        FileHandlingModule.Example4()
    End Sub


    Private Sub TestExceptionModule()
        ExceptionModule.Example1()
    End Sub

    Private Sub TestOOPModule()
        OOPModule.Example1()
    End Sub

    Private Sub TestFunctionAndSubModule()
        'FunctionAndSubModule.Example1()
        FunctionAndSubModule.Example2()
    End Sub



    Private Sub TestCollectionsModule()
        'CollectionsModule.Example1()
        'CollectionsModule.Example2()
        'CollectionsModule.Example3()
        'CollectionsModule.Example4()
        'CollectionsModule.Example5()
        CollectionsModule.Example6()
    End Sub

    Private Sub TestArrayModule()
        'ArrayModule.Example1()
        'ArrayModule.Example2()
        'ArrayModule.Example3()
        'ArrayModule.Example4()
        ArrayModule.Example5()
    End Sub


    Private Sub TestDateTimeModule()
        'DateTimeModule.Example1()
        'DateTimeModule.Example2()
        DateTimeModule.Example3()
    End Sub


    Private Sub TestStringModule()
        'StringModule.Example1()
        StringModule.Example2()
    End Sub

    Private Sub TestLoopModule()
        'LoopModule.Example1()
        'LoopModule.Example2()
        'LoopModule.Example3()
        'LoopModule.Example4()
        'LoopModule.Example5()
        'LoopModule.Example6()
        LoopModule.Example7()
    End Sub


    Private Sub TestDecisionMakingModule()
        'DecisionMakingModule.Example1()
        DecisionMakingModule.Example2()
    End Sub

    Private Sub TestOperatorsModule()
        'OperatorsModule.ExampleArithmeticOps()
        'OperatorsModule.ExampleComparisonOps()
        'OperatorsModule.ExampleLogicalOps()
        OperatorsModule.ExampleMiscellaneousOps()
    End Sub


    Private Sub TestModuleExample()
        'ModuleExample.Example1()
        'ModuleExample.ExampleDelegate()
        'ModuleExample.ExampleWorker()
        'ModuleExample.ExampleProgrammer()
        'ModuleExample.ExampleCustomFile()
        ModuleExample.ExampleOperatorOverloading()
    End Sub

    Private Sub TestUserInputExample()
        'UserInputExample.Example1()
        'UserInputExample.Example2()
        UserInputExample.Example3()
    End Sub

    Private Sub TestComplexNumber()
        Dim c1, c2 As ComplexNumber
        c1 = New ComplexNumber(3, 3)
        c2 = New ComplexNumber(2, 2)
        Console.WriteLine(String.Format("c1 = {0}", c1))
        Console.WriteLine(String.Format("c2 = {0}", c2))
        Dim cAdd = c1.Add(c2)
        Dim cSubtract = c1.Subtract(c2)
        Dim cMultiply = c1.Multiply(c2)
        Dim cMultiplyWith2 = c1.Multiply(2)
        Dim cDivide = c1.Divide(c2)
        Dim cDivideWith2 = c1.Divide(2)
        Console.WriteLine(String.Format("cAdd = {0}", cAdd))
        Console.WriteLine(String.Format("cSubtract = {0}", cSubtract))
        Console.WriteLine(String.Format("cMultiply = {0}", cMultiply))
        Console.WriteLine(String.Format("cDivide = {0}", cDivide))
        Console.WriteLine(String.Format("cMultiplyWith2 = {0}", cMultiplyWith2))
        Console.WriteLine(String.Format("cDivideWith2 = {0}", cDivideWith2))
    End Sub

    Private Sub TestSimpleMath()
        Dim n1, n2 As Double
        n1 = 10D
        n2 = 3D
        Dim resAdd = SimpleMath.Add(n1, n2)
        Dim resSubtract = SimpleMath.Subtract(n1, n2)
        Dim resMultiply = SimpleMath.Multiply(n1, n2)
        Dim resDivide = SimpleMath.Divide(n1, n2)
        Dim resModulo = SimpleMath.Modulo(n1, n2)
        Console.WriteLine(String.Format("{0} + {1} = {2}", n1, n2, resAdd))
        Console.WriteLine(String.Format("{0} - {1} = {2}", n1, n2, resSubtract))
        Console.WriteLine(String.Format("{0} * {1} = {2}", n1, n2, resMultiply))
        Console.WriteLine(String.Format("{0} / {1} = {2}", n1, n2, resDivide))
        Console.WriteLine(String.Format("{0} mod {1} = {2}", n1, n2, resModulo))
    End Sub


    'actually PersonDAOImpl class , which implements PersonDAO interface
    Private Sub TestPersonDAO()
        Dim dao As New PersonDAOImpl()
        dao.Save(New Person(1, "foo", 10, 100.0, True))
        dao.Save(New Person(2, "bar", 20, 200.0, False))
        dao.Save(New Person(3, "bim", 30, 300.0, True))
        Console.WriteLine("<<all people>>")
        Dim all As List(Of Person) = dao.FindAll()
        For Each person In all
            Console.WriteLine(person)
        Next
        dao.Update(1, New Person(1, "new_foo", 66, 666.6, False))
        Dim one As Person = dao.FindById(1)
        Console.WriteLine(String.Format("one = {0}", one.ToString()))
        dao.Remove(1)
        all = dao.FindAll()
        Console.WriteLine("<<all people after remove person with id = 1>>")
        For Each person In all
            Console.WriteLine(person)
        Next
    End Sub

    Private Sub TestDictionary()
        Dim dict As New Dictionary(Of String, Integer)
        dict.Add("foo", 10)
        dict.Add("bar", 20)
        dict.Add("bim", 30)
        Dim keys = dict.Keys
        For Each key In keys
            Console.WriteLine(String.Format("{0} => {1}", key, dict.Item(key)))
        Next key

        Console.WriteLine()
        For Each pair In dict
            Console.WriteLine(String.Format("{0} => {1}", pair.Key, pair.Value))
        Next pair


        Console.WriteLine()
        Dim pair2 As KeyValuePair(Of String, Integer)
        For Each pair2 In dict
            Console.WriteLine(String.Format("{0} => {1}", pair2.Key, pair2.Value))
        Next


        Console.WriteLine()
        Dim list As New List(Of String)(dict.Keys)
        Dim str As String
        For Each str In list
            Console.WriteLine(String.Format("{0} => {1}", str, dict.Item(str)))
        Next
        Console.WriteLine()

        'containsKey 
        If dict.ContainsKey("foo") Then
            Dim item As Integer = dict.Item("foo")
            Console.WriteLine(String.Format("foo => {0}", item))
        End If

        If dict.ContainsKey("edutilos") Then
            Console.WriteLine("dict contains key edutilos")
        Else
            Console.WriteLine("dict doesn't contain key edutilos")
        End If

        'containsValue 
        If dict.ContainsValue(10) Then
            Console.WriteLine("dict contains value 10")
        Else
            Console.WriteLine("dict doesn't contain value 10")
        End If

        If dict.ContainsValue(100) Then
            Console.WriteLine("dict contains value 100")
        Else
            Console.WriteLine("dict doesn't contain value 100")
        End If

        'TryGetValue 
        Dim value As Integer
        If dict.TryGetValue("foo", value) Then
            dict("foo") = value + 1
            Console.WriteLine(String.Format("foo => {0}", dict("foo")))
        Else
            Console.WriteLine("dict does not contain key foo")
        End If


        'Remove 
        dict.Remove("foo")
        Console.WriteLine(String.Format("dict count = {0}", dict.Count))
        Console.WriteLine(String.Format("keys count = {0}", dict.Keys.Count))
        Console.WriteLine(String.Format("values count = {0}", dict.Values.Count))
        For Each pair In dict
            Console.WriteLine(String.Format("{0} => {1}", pair.Key, pair.Value))
        Next


        'array to Dictionary 
        Dim array() As String = {"foo", "bar", "edutilos", "messi"}
        Dim dictNames As Dictionary(Of String, Integer) =
        array.ToDictionary(Function(value2 As String)
                               Return value2
                           End Function,
                           Function(value2 As String)
                               Return value2.Length
                           End Function)

        Console.WriteLine("<<dictNames>>")
        For Each pair In dictNames
            Console.WriteLine(String.Format("{0} => {1}", pair.Key, pair.Value))
        Next


    End Sub

    Private Sub TestPerson2()
        Dim p1, p2 As Person2
        p1 = New Person2(1, "foo", 10, 100.0, True)
        p2 = New Person2(2, "bar", 20, 200.0, False)
        Console.WriteLine("<<before change>>")
        Console.WriteLine(p1)
        Console.WriteLine(p2)
        p1.Id = 3
        p1.Name = "edutilos"
        p1.Age = 66
        p1.Wage = 666.666
        p1.Active = False
        Console.WriteLine("<<after change>>")
        Console.WriteLine(p1)
        Console.WriteLine(p2)
        Dim id As Long
        Dim name As String
        Dim age As Integer
        Dim wage As Double
        Dim active As Boolean
        id = p1.Id
        name = p1.Name
        age = p1.Age
        wage = p1.Wage
        active = p1.Active
        Console.WriteLine("<<p1 properties after change>>")
        Console.WriteLine(String.Format("id = {0}", id))
        Console.WriteLine(String.Format("name = {0}", name))
        Console.WriteLine(String.Format("age = {0}", age))
        Console.WriteLine(String.Format("wage = {0}", wage))
        Console.WriteLine(String.Format("active = {0}", active))

    End Sub

    Private Sub TestPerson()
        Dim p1, p2 As Person
        p1 = New Person(1, "foo", 10, 100.0, True)
        p2 = New Person(2, "bar", 20, 200.0, False)
        Console.WriteLine(p1.ToString())
        Console.WriteLine(p2.ToString())
        p1.Name = "new_foo"
        Console.WriteLine(String.Format("p1 new name = {0}", p1.Name))
    End Sub

    Private Sub HelloWorld()
        Console.WriteLine("Hello World")
    End Sub

    Private Sub TestBox()
        Dim b1, b2 As Box
        b1 = New Box(1, 2, 3)
        b2 = New Box(10, 20, 30)
        Console.WriteLine(b1.ToString())
        Console.WriteLine(b2.ToString())
        Console.WriteLine(String.Format("box1 volume = {0}", b1.Volume()))
        Console.WriteLine(String.Format("box2 volume = {0}", b2.Volume()))

    End Sub


    Class Box
        Private Width As Double
        Private Length As Double
        Private Height As Double

        Public Sub New()

        End Sub

        Public Sub New(ByVal _width As Double, ByVal _length As Double, ByVal _height As Double)
            Width = _width
            Length = _length
            Height = _height
        End Sub


        Public Sub SetWidth(_width As Double)
            Width = _width
        End Sub

        Public Function GetWidth() As Double
            Return Width
        End Function

        Public Sub SetLength(_length As Double)
            Length = _length
        End Sub

        Public Function GetLength() As Double
            Return Length
        End Function

        Public Sub SetHeight(_height As Double)
            Height = _height
        End Sub

        Public Function GetHeight() As Double
            Return Height
        End Function

        Public Function Volume() As Double
            Return Width * Length * Height
        End Function

        Public Overrides Function ToString() As String
            Return String.Format("Box({0},{1},{2})", Width, Length, Height)
        End Function



    End Class

End Module
