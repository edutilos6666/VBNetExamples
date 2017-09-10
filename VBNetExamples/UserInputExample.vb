Imports VBNetExamples
Public Class UserInputExample

    Enum Colors
        red = 1
        green = 2
        blue = 3
        yellow = 4
        orange = 5
    End Enum

    Public Shared Sub Example3()
        Console.WriteLine("value of red = " & Colors.red)
        Console.WriteLine("value of green = " & Colors.green)
        Console.WriteLine("value of blue = " & Colors.blue)
        Console.WriteLine("value of yellow = " & Colors.yellow)
        Console.WriteLine("value of orange = " & Colors.orange)
    End Sub


    Public Shared Sub Example2()
        Const ID As Long = 1
        Const NAME As String = "foo"
        Const AGE As Integer = 10
        Const WAGE As Double = 100.0
        Const ACTIVE As Boolean = False
        Const DELIM As String = " ; "
        Console.WriteLine(ID & DELIM & NAME & DELIM & AGE & DELIM & WAGE & DELIM & ACTIVE)
    End Sub

    Public Shared Sub Example1()
        Dim id As Long
        Dim name As String
        Dim age As Integer
        Dim wage As Double
        Dim active As Boolean
        Console.WriteLine("enter id: ")
        id = Convert.ToInt64(Console.ReadLine())
        Console.WriteLine("enter name: ")
        name = Console.ReadLine()
        Console.WriteLine("enter age: ")
        age = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("enter wage: ")
        wage = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("enter whether you are active:")
        active = Convert.ToBoolean(Console.ReadLine())
        Console.WriteLine("<<your inputs>>")
        Console.WriteLine(String.Format("id = {0}", id))
        Console.WriteLine(String.Format("name = {0}", name))
        Console.WriteLine(String.Format("age = {0}", age))
        Console.WriteLine(String.Format("wage = {0}", wage))
        Console.WriteLine(String.Format("active = {0}", active))
        Dim delim As String = " ; "
        Console.WriteLine(id & delim & name & delim & age & delim & wage & delim & active)
    End Sub
End Class

