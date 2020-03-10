Module Module1

    Sub Main()
        Dim a, b, i, c, number As Integer
        Randomize()
        i = 0 : number = 0
        'Console.WriteLine("幾個數字")
        'number = Console.ReadLine
        '========================================================================================
        Do Until i = 5
            c = Int(Rnd() * 100) + 1
            a = Int(Rnd() * 100) + 1
            b = Int(Rnd() * 100) + 1
            If a = b Or a = c Or b = c Then
                i = i
            ElseIf a < b And b < c Then
                i += 1
                Console.WriteLine(a & "," & b & "," & c)
            ElseIf a < c And c < b Then
                i += 1
                Console.WriteLine(a & "," & c & "," & b)
            ElseIf b < a And a < c Then
                i += 1
                Console.WriteLine(b & "," & a & "," & c)
            ElseIf b < c And c < a Then
                i += 1
                Console.WriteLine(b & "," & c & "," & a)
            ElseIf c < b And b < a Then
                i += 1
                Console.WriteLine(c & "," & b & "," & a)
            ElseIf c < a And a < b Then
                i += 1
                Console.WriteLine(c & "," & a & "," & b)
            End If
        Loop
        Console.Read()
    End Sub

End Module
