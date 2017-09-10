Public Module DecisionMakingModule

    Public Sub Example2()
        Dim grade As String = "C"
        Select Case grade
            Case "A"
                Console.WriteLine("excellent")
            Case "B"
                Console.WriteLine("very good")
            Case "C", "D"
                Console.WriteLine("good")
            Case "E"
                Console.WriteLine("satisfactory")
            Case Else
                Console.WriteLine("failed")
        End Select
    End Sub

    Public Sub Example1()
        Dim name As String = "pako"

        If name = "foo" Then
            Console.WriteLine("name is foo")
        ElseIf name = "bar" Then
            Console.WriteLine("name is bar")
        ElseIf name = "bim" Then
            Console.WriteLine("name is bim")
        ElseIf name = "pako" Then
            Console.WriteLine("name is pako")
        Else
            Console.WriteLine("name is unknown to the System")
        End If
    End Sub
End Module
