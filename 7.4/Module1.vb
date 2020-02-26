Module Module1

    Sub Main()
        Dim a, b, c, d, e As Integer

        Console.WriteLine("Entrez cinq valeurs: ")
        a = Console.ReadLine()
        b = Console.ReadLine()
        c = Console.ReadLine()
        d = Console.ReadLine()
        e = Console.ReadLine()

        Console.WriteLine()
        Console.WriteLine("Somme = " & somme(a, b, c, d, e))

        Console.ReadKey()

    End Sub

    Function somme(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer, ByVal e As Integer) As Integer

        Return a + b + c + d + e

    End Function

End Module
