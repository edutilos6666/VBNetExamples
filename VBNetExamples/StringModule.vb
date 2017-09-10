Module StringModule

    Public Sub Example2()
        Dim str As String = "fooedutilosbar"
        Dim startsWith As Boolean = str.StartsWith("foo")
        Dim endsWith As Boolean = str.EndsWith("bar")
        Dim contains As Boolean = str.Contains("edu")
        Dim str1, str2 As String
        str1 = "foo"
        str2 = "Foo"
        Dim compare As Integer = String.Compare(str1, str2)
        Dim indexOf As Integer = str.IndexOf("o")
        Dim lastIndexOf As Integer = str.LastIndexOf("o")
        Dim names As String() = {"foo", "bar", "bim"}
        Dim namesCombiend As String = String.Join(" ; ", names)
        Dim strRemoved As String = str.Remove(3)
        Dim strReplaced As String = str.Replace("foo", "FOO")
        Dim namesSplitted As String() = namesCombiend.Split(" ; ")
        Dim strChars As Char() = str.ToCharArray()
        Dim strUpper As String = str.ToUpper
        Dim strLower As String = strUpper.ToLower
        Dim strUpperInvariant As String = str.ToUpperInvariant
        Dim strLowerInvariant As String = strUpperInvariant.ToLowerInvariant
        Dim strSubstring As String = str.Substring(0, 6)
        str = " foo "
        Dim l1 As Integer = str.Count
        str = str.Trim
        Dim l2 As Integer = str.Count

        Console.WriteLine(str)
        Console.WriteLine("startsWith = " & startsWith)
        Console.WriteLine("endsWith = " & endsWith)
        Console.WriteLine("contains = " & contains)
        Console.WriteLine("compare (" & str1 & " , " & str2 & ") = " & compare)
        Console.WriteLine("indexOf o = " & indexOf)
        Console.WriteLine("lastIndexOf o = " & lastIndexOf)
        Console.WriteLine("namesCombined = " & namesCombiend)
        Console.WriteLine("strRemoved = " & strRemoved)
        Console.WriteLine("strReplaced = " & strReplaced)
        Console.Write("namesSplitted = ")
        For Each s In namesSplitted
            Console.Write(s & " # ")
        Next
        Console.WriteLine()
        Console.Write("strChars = ")
        For Each c In strChars
            Console.Write(c & " # ")
        Next
        Console.WriteLine()
        Console.WriteLine("strUppper = " & strUpper)
        Console.WriteLine("strUpperInvariant = " & strUpperInvariant)
        Console.WriteLine("strLower = " & strLower)
        Console.WriteLine("strLowerInvariant = " & strLowerInvariant)
        Console.WriteLine("strSubstring = " & strSubstring)
        Console.WriteLine("l1 and l2(after trim) = " & l1 & " and " & l2)
    End Sub


    Public Sub Example1()
        Dim str1, str2 As String
        str1 = "foo"
        Dim letters As Char() = {"a", "b", "c"}
        str2 = New String(letters)
        Dim str3 As String = "bar"
        Dim combined = str1 + " " + str3
        Dim names As String() = {"foo", "bar", "bim"}
        Dim namesCombined = String.Join(" ; ", names)
        Dim cdt As DateTime = New DateTime(2010, 10, 10, 10, 10, 10)
        Dim datePart As String = String.Format("{0:d}", cdt)
        Dim timePart As String = String.Format("{0:t}", cdt)
        Dim myDate = New Date(2010, 10, 10)


        Console.WriteLine("str1 = " & str1)
        Console.WriteLine("str2 = " & str2)
        Console.WriteLine("str3 = " & str3)
        Console.WriteLine("combined = " & combined)
        Console.WriteLine("namesCombined = " & namesCombined)
        Console.WriteLine("datePart = " & datePart)
        Console.WriteLine("timePart = " & timePart)
        Console.WriteLine("myDate = " & myDate.ToString())
    End Sub
End Module
