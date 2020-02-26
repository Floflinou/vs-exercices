Module Module1

    Sub Main()
        Dim ligne, etoile As Integer

        Console.WriteLine("Entrez le nombre de lignes souhaitées: ")
        ligne = Console.ReadLine()
        Console.WriteLine("Entrez le nombre d'étoiles souhaitées: ")
        etoile = Console.ReadLine()

        ligneEtoile(ligne, etoile)

        Console.ReadKey()

    End Sub

    Sub ligneEtoile(ByVal ligne As Integer, etoile As Integer)
        Dim star As String

        For i As Integer = 1 To ligne
            Console.WriteLine()
            For j As Integer = 1 To etoile
                star = ""
                Console.Write(star & "*")
            Next
        Next
    End Sub

End Module