Module CollectionsModule

    'BitArray
    Public Sub Example6()
        Dim ba1, ba2 As New BitArray(8)
        Dim size1() As Byte = {60}
        Dim size2() As Byte = {13}
        ba1 = New BitArray(size1)  '0011 1100
        ba2 = New BitArray(size2)  '0000 1101 
        PrintBitArray(ba1)
        PrintBitArray(ba2)

        Dim baTemp As New BitArray(8)
        baTemp = ba1.Clone
        baTemp.And(ba2)
        Console.WriteLine("<<ba1 and ba2>>")
        PrintBitArray(baTemp)

        baTemp = ba1.Clone
        baTemp.Or(ba2)
        Console.WriteLine("<<ba1 or ba2>>")
        PrintBitArray(baTemp)

        baTemp = ba1.Clone
        baTemp.Xor(ba2)
        Console.WriteLine("<<ba1 xor ba2>>")
        PrintBitArray(baTemp)

        baTemp = ba1.Clone
        baTemp.Not()
        Console.WriteLine("<<ba1 Not>>")
        PrintBitArray(baTemp)


        baTemp.SetAll(True)
        Console.WriteLine("<<setAll = true>>")
        PrintBitArray(baTemp)
        baTemp.SetAll(False)
        Console.WriteLine("<<setAll = false>>")
        PrintBitArray(baTemp)

    End Sub

    Private Sub PrintBitArray(ByRef ba As BitArray)
        Dim st As New Stack()
        For Each b In ba
            st.Push(b)
        Next
        For Each b In st
            Console.Write(b.ToString() & "; ")
        Next

        Console.WriteLine()
    End Sub

    'Queue
    Public Sub Example5()
        Dim names As New Queue()
        names.Enqueue("foo")
        names.Enqueue("bar")
        names.Enqueue("bim")
        Console.WriteLine("names Count = " & names.Count)
        Console.WriteLine("<<all names>>")
        For Each name In names
            Console.Write(name & " ; ")
        Next
        Console.WriteLine()
        Console.WriteLine("names dequeue = " & names.Dequeue())
        Console.WriteLine("names dequeue = " & names.Dequeue())
        Console.WriteLine("names dequeue = " & names.Dequeue())
    End Sub

    'Stack 
    Public Sub Example4()
        Dim names As New Stack()
        names.Push("foo")
        names.Push("bar")
        names.Push("bim")
        Console.WriteLine("names count = " & names.Count)
        Console.WriteLine("names contains foo = " & names.Contains("foo"))
        Console.WriteLine("names contains edutilos = " & names.Contains("edutilos"))
        Console.WriteLine("names peek = " & names.Peek())
        Console.WriteLine("names pop = " & names.Pop())
        Console.WriteLine("names peek = " & names.Peek())
        Console.WriteLine("<<all names>>")
        For Each name In names
            Console.Write(name & " ; ")
        Next
        Console.WriteLine()
    End Sub

    'SortedList 
    Public Sub Example3()
        Dim people As New SortedList()
        people.Add("foo", 10)
        people.Add("bar", 20)
        people.Add("bim", 30)
        people.Add("pako", 40)
        Dim count As Integer = people.Count
        Dim capacity As Integer = people.Capacity
        Dim keys As ICollection = people.Keys
        Dim values As ICollection = people.Values
        Console.WriteLine("people count = " & count)
        Console.WriteLine("people capacity = " & capacity)
        Console.WriteLine("<<people keys>>")
        For Each key In keys
            Console.Write(key & " ; ")
        Next
        Console.WriteLine()
        Console.WriteLine("<<people values>>")
        For Each value In values
            Console.Write(value & " ; ")
        Next
        Console.WriteLine()
        Console.WriteLine("<<people>>")
        For Each pair As DictionaryEntry In people
            Console.WriteLine(pair.Key & " => " & pair.Value)
        Next
        Console.WriteLine()
        Dim val As Integer = people.GetByIndex(0)
        Console.WriteLine("val at 0 = " & val)

        Console.WriteLine("<<people with IDictionaryEnumerator>>")
        Dim peopleEnumerator As IDictionaryEnumerator = people.GetEnumerator()
        While peopleEnumerator.MoveNext()
            Console.WriteLine(peopleEnumerator.Key & " => " & peopleEnumerator.Value)
        End While
        Console.WriteLine()
        Dim keyList As IList = people.GetKeyList()
        Dim valueList As IList = people.GetValueList()
        Console.WriteLine("<<people keyList>>")
        For Each key In keyList
            Console.Write(key & " ; ")
        Next
        Console.WriteLine()
        Console.WriteLine("<<people valueList>>")
        For Each value In valueList
            Console.Write(value & " ; ")
        Next
        Console.WriteLine()
        people.Remove("foo")
        people.RemoveAt(0)
        Console.WriteLine("<<people after remove>>")
        For Each pair As DictionaryEntry In people
            Console.WriteLine(pair.Key & " => " & pair.Value)
        Next
        Console.WriteLine()

        Console.WriteLine("people containsKey pako = " & people.ContainsKey("pako"))
        Console.WriteLine("people containsValue 40 = " & people.ContainsValue(40))
    End Sub

    'Hashtable 
    Public Sub Example2()
        Dim people As New Hashtable()
        people.Add("foo", 10)
        people.Add("bar", 20)
        people.Add("bim", 30)
        people.Add("pako", 40)
        Dim count As Integer = people.Count
        Console.WriteLine("people count = " & count)
        Dim keys As ICollection = people.Keys
        Console.WriteLine("<<keys>>")
        For Each key In keys
            Console.Write(key & " ; ")
        Next
        Console.WriteLine()
        Dim values As ICollection = people.Values
        Console.WriteLine("<<values>>")
        For Each value In values
            Console.Write(value & " ; ")
        Next
        Console.WriteLine()
        Console.WriteLine("<<people>>")
        For Each pair As DictionaryEntry In people
            Console.WriteLine(pair.Key & " => " & pair.Value)
        Next

        Dim res As Boolean = people.ContainsKey("foo")
        Console.WriteLine("people containsKey foo = " & res)
        res = people.ContainsKey("edutilos")
        Console.WriteLine("people containsKey edutilos = " & res)
        res = people.ContainsValue(30)
        Console.WriteLine("people containsValue 30  = " & res)
        res = people.ContainsValue(1000)
        Console.WriteLine("people containsValue 1000 = " & res)

        people.Remove("foo")
        res = people.ContainsKey("foo")
        Console.WriteLine("people containsKey foo = " & res)

    End Sub

    'ArrayList
    Public Sub Example1()
        Dim names As ArrayList = New ArrayList()
        names.Add("foo")
        names.Add("bar")
        names.Add("bim")
        names.Add("pako")

        Console.WriteLine("names Count = " & names.Count)
        Console.WriteLine("names Capacity = " & names.Capacity)
        Console.WriteLine("<<names>>")
        For Each name In names
            Console.Write(name & " ; ")
        Next
        Console.WriteLine()
        Console.WriteLine("<<names>>")
        For i = 0 To (names.Count - 1)
            Console.Write(names(i) & " ; ")
        Next
        Console.WriteLine()
        Dim indexOf As Integer = names.IndexOf("foo")
        Console.WriteLine("indexOf foo = " & indexOf)
        indexOf = names.LastIndexOf("foo")
        Console.WriteLine("last index of foo = " & indexOf)
        names.Sort()
        Console.WriteLine("<<sorted names>>")
        For Each name In names
            Console.Write(name & " ; ")
        Next
        Console.WriteLine()
        names.Reverse()
        Console.WriteLine("<<sorted and reversed names>>")
        For Each name In names
            Console.Write(name & " ; ")
        Next
        Console.WriteLine()
        Dim contains As Boolean = names.Contains("foo")
        Console.WriteLine("names contains foo = " & contains)
        contains = names.Contains("edutilos")
        Console.WriteLine("names contains edutilos = " & contains)
        names.Remove("foo")
        Console.WriteLine("<<names after removing foo>>")
        For Each name In names
            Console.Write(name & " ; ")
        Next
        Console.WriteLine()
    End Sub
End Module
