Imports VBNetExamples

Public Class Person
    Private _id As Long
    Private _name As String
    Private _age As Integer
    Private _wage As Double
    Private _active As Boolean

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Long,
                   ByVal name As String,
                   ByVal age As Integer,
                   ByVal wage As Double,
                   ByVal active As Boolean)
        _id = id
        _name = name
        _age = age
        _wage = wage
        _active = active
    End Sub


    Public Property Id() As Long
        Get
            Return _id
        End Get
        Set(value As Long)
            _id = value
        End Set
    End Property


    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property


    Public Property Age() As Integer
        Get
            Return _age
        End Get
        Set(value As Integer)
            _age = value
        End Set
    End Property

    Public Property Wage() As Double
        Get
            Return _wage
        End Get
        Set(value As Double)
            _wage = value
        End Set
    End Property


    Public Property Active() As Boolean
        Get
            Return _active
        End Get
        Set(value As Boolean)
            _active = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return String.Format("[{0},{1},{2},{3},{4}]",
                             _id, _name, _age, _wage, _active)
    End Function

End Class

Public Class Person2
    Public Property Id As Long
    Public Property Name As String
    Public Property Age As Integer
    Public Property Wage As Double
    Public Property Active As Boolean

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
        Return String.Format("{0},{1},{2},{3},{4}",
                             Id, Name, Age, Wage, Active)
    End Function
End Class

Public Interface PersonDAO
    Sub Save(ByRef person As Person)
    Sub Update(ByVal id As Long, ByRef newPerson As Person)
    Sub Remove(ByVal id As Long)
    Function FindById(ByVal id As Long) As Person
    Function FindAll() As List(Of Person)
End Interface


Public Class PersonDAOImpl : Implements PersonDAO
    Public Property Container As Dictionary(Of Long, Person)
    Public Sub New()
        Container = New Dictionary(Of Long, Person)()
    End Sub

    Public Sub Remove(id As Long) Implements PersonDAO.Remove
        Container.Remove(id)
    End Sub

    Public Sub Save(ByRef person As Person) Implements PersonDAO.Save
        Container.Add(person.Id, person)
    End Sub

    Public Sub Update(id As Long, ByRef newPerson As Person) Implements PersonDAO.Update
        Dim value As Person = Nothing
        If Container.TryGetValue(id, value) Then
            Container.Remove(id)
            Container.Add(id, newPerson)
        Else
            Console.WriteLine(String.Format("There was not any person with id = {0}", id))

        End If
    End Sub

    Public Function FindAll() As List(Of Person) Implements PersonDAO.FindAll
        Dim ret As New List(Of Person)
        For Each pair In Container
            ret.Add(pair.Value)
        Next
        Return ret
    End Function

    Public Function FindById(id As Long) As Person Implements PersonDAO.FindById
        Dim value As Person = Nothing
        If Container.TryGetValue(id, value) Then

        Else
            Console.WriteLine(String.Format("Could not find Person with id = {0}", id))
        End If
        Return value
    End Function
End Class
