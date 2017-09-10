Imports System
Imports System.Text
Imports System.IO

Module FileHandlingModule


    'BinaryWriter And BinaryReader
    Public Sub Example4()
        Dim p As Person = New Person(1, "foo", 10, 100.0, True)
        Dim path As String = "example4.dat"
        Using bw As BinaryWriter = New BinaryWriter(New FileStream(path, FileMode.Create))
            bw.Write(p.Id)
            bw.Write(p.Name)
            bw.Write(p.Age)
            bw.Write(p.Wage)
            bw.Write(p.Active)
        End Using

        Dim ptemp As Person = New Person(0, "", 0, 0, False)
        Console.WriteLine(ptemp.ToString())
        Using br As BinaryReader = New BinaryReader(New FileStream(path, FileMode.Open))
            ptemp.Id = br.ReadInt64()
            ptemp.Name = br.ReadString()
            ptemp.Age = br.ReadInt32()
            ptemp.Wage = br.ReadDouble()
            ptemp.Active = br.ReadBoolean()
        End Using

        Console.WriteLine(ptemp.ToString())

    End Sub

    Private Structure Person
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
            Return String.Format("Person({0},{1},{2},{3},{4})",
                                 Id, Name, Age, Wage, Active)
        End Function
    End Structure

    'StreamWriter And StreamReader
    Public Sub Example3()
        Dim names() As String = {
            "foo", "bar", "bim", "pako", "edu"}

        Dim path As String = "example3.dat"
        Using sw As StreamWriter = New StreamWriter(path)
            For Each name In names
                sw.WriteLine(name)
            Next
        End Using

        Console.WriteLine("<<all names>>")
        Using sr As StreamReader = New StreamReader(path)
            Dim line As String
            line = sr.ReadLine()
            While line <> Nothing
                Console.WriteLine(line)
                line = sr.ReadLine()
            End While
        End Using

    End Sub

    'FileStream 
    Public Sub Example2()
        Dim path As String = "example2.dat"
        Dim NewLine As String = Environment.NewLine
        Dim names() As String = {
          "new foo" & NewLine,
          "new bar" & NewLine,
          "new bim" & NewLine
        }

        Dim fs As FileStream = File.Create(path)
        For Each name In names
            WriteText2(fs, name)
        Next

        For i = 1 To 120
            Dim str As String = Convert.ToChar(i).ToString()
            WriteText2(fs, str)
        Next
        fs.Close()


        fs = File.OpenRead(path)
        Dim encoding As UTF8Encoding = New UTF8Encoding(True)
        Dim b(1024) As Byte
        While fs.Read(b, 0, b.Length) > 0
            Console.WriteLine(encoding.GetString(b))
        End While

        fs.Close()

    End Sub

    Private Sub WriteText2(ByVal fs As FileStream, ByVal data As String)
        Dim encoding As UTF8Encoding = New UTF8Encoding(True)
        Dim temp() As Byte = encoding.GetBytes(data)
        fs.Write(temp, 0, temp.Length)
    End Sub




    'FileStream 
    Public Sub Example1()
        Dim NewLine As String = Environment.NewLine
        Dim strings() As String = {
            "foo" + NewLine,
            "bar" + NewLine,
            "bim" + NewLine
        }

        Dim path As String = "example1.dat"
        Dim fs As FileStream = File.Create(path)

        For Each str As String In strings
            WriteText(fs, str)
        Next

        For i = 1 To 120
            Dim temp As String = Convert.ToChar(i).ToString()
            WriteText(fs, temp)
        Next

        fs.Close()

        fs = File.OpenRead(path)
        Dim b(1024) As Byte
        Dim encoding As UTF8Encoding = New UTF8Encoding(True)
        While fs.Read(b, 0, b.Length) > 0
            Console.WriteLine(encoding.GetString(b))
        End While

        fs.Close()

    End Sub

    Private Sub WriteText(fs As FileStream, text As String)
        Dim bs() As Byte = New UTF8Encoding(True).GetBytes(text)
        fs.Write(bs, 0, bs.Length)
    End Sub
End Module
