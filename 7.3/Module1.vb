Module Module1

    Sub Main()
        Dim nb, puissance As Integer

        Console.WriteLine("Entrez la valeur à mettre en puissance: ")
        nb = Console.ReadLine()
        Console.WriteLine("Entrez la puissance: ")
        puissance = Console.ReadLine()

        puissanceProc(nb, puissance)

        Console.ReadKey()

    End Sub

    Sub puissanceProc(ByVal nb As Integer, ByVal puissance As Integer)
        Dim resultat, i As Integer

        resultat = 1

        For i = 1 To puissance
            resultat = resultat * nb
            Console.WriteLine(nb & " puissance " & i & "= " & resultat)
        Next

    End Sub

End Module
