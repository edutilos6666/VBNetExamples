Module OOPModule
    Public Sub Example1()
        Dim p1 As New Person(1, "foo", 10)
        Console.WriteLine(p1.ToString())

        Dim w1 As New Worker(2, "edu", 20, 200.0)
        Console.WriteLine(w1.ToString())
    End Sub

    Public Class Person
        Public Property Id() As Long
        Public Property Name() As String
        Public Property Age() As Integer


        Public Sub New()

        End Sub

        Public Sub New(ByVal _id As Long,
                       ByVal _name As String,
                       ByVal _age As Integer)
            Id = _id
            Name = _name
            Age = _age
        End Sub

        Protected Overrides Sub Finalize()
            Console.WriteLine("Person instance was destroyed.")
        End Sub


        Public Overrides Function ToString() As String
            Return String.Format("Person({0},{1},{2})", Id, Name, Age)
        End Function


    End Class


    Public Class Worker : Inherits Person
        Public Property Wage() As Double
        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal _id As Long,
                       ByVal _name As String,
                       ByVal _age As Integer,
                       ByVal _wage As Double)
            MyBase.New(_id, _name, _age)
            Wage = _wage
        End Sub

        Protected Overrides Sub Finalize()
            Console.WriteLine("Worker Instance was destroyed.")
        End Sub

        Public Overrides Function ToString() As String
            Return String.Format("Worker({0},{1},{2},{3})", Id, Name, Age, Wage)
        End Function
    End Class

End Module
