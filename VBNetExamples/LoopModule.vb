Public Module LoopModule


    'Continue keyword
    Public Sub Example7()
        Dim n As Integer = 0
        While n < 10
            n += 1
            If n = 5 Then
                Continue While
            End If
            Console.WriteLine("number = " & n)
        End While
    End Sub

    'Exit keyword
    Public Sub Example6()
        Dim n As Integer = 0
        While n < 10
            Console.WriteLine("number = " & n)
            n += 1
            If n = 5 Then
                Exit While
            End If
        End While
    End Sub

    'with ...  end with 
    Public Sub Example5()
        Dim p As New Person()
        With p
            .Id = 1
            .Name = "foo"
            .Age = 10
            .Wage = 100.0
            .Active = True
        End With

        Console.WriteLine("<<p properties>>")
        With p
            Console.WriteLine("id = " & .Id)
            Console.WriteLine("name = " & .Name)
            Console.WriteLine("age = " & .Age)
            Console.WriteLine("wage = " & .Wage)
            Console.WriteLine("active = " & .Active)
        End With
    End Sub

    Private Class Person
        Public Property Id() As Long
        Public Property Name() As String
        Public Property Age() As Integer
        Public Property Wage() As Double
        Public Property Active() As Boolean
    End Class


    'while ... end while 
    Public Sub Example4()
        Dim n As Integer = 0
        While n < 10
            Console.WriteLine("number = " & n)
            n += 1
        End While
        Console.WriteLine()
    End Sub

    'for each ... next 
    Public Sub Example3()
        Dim numbers() As Integer = {10, 20, 30, 40, 50}
        Dim names As New List(Of String)
        names.Add("foo")
        names.Add("bar")
        names.Add("bim")
        names.Add("pako")

        Dim dict As New Dictionary(Of String, Integer)
        dict.Add("foo", 10)
        dict.Add("bar", 20)
        dict.Add("bim", 30)
        dict.Add("pako", 40)

        Console.WriteLine("<<numbers>>")
        For Each number In numbers
            Console.WriteLine("number = " & number)
        Next

        Console.WriteLine()
        Console.WriteLine("<<names>>")
        For Each name In names
            Console.WriteLine("name = " & name)
        Next

        Console.WriteLine()
        Console.WriteLine("<<dict>>")
        For Each pair In dict
            Console.WriteLine(pair.Key & " => " & pair.Value)
        Next
        Console.WriteLine()
    End Sub

    'for ... next 
    Public Sub Example2()
        For i = 0 To 10
            Console.WriteLine("number = " & i)
        Next
        Console.WriteLine()
        For i = 0 To 10 Step 2
            Console.WriteLine("number = " & i)
        Next
        Console.WriteLine()
    End Sub

    'do ... loop
    Public Sub Example1()
        Dim a As Integer = 0
        Do
            Console.WriteLine("number = " & a)
            a += 1
        Loop While (a < 10)

        Console.WriteLine()
    End Sub
End Module
