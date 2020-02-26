Module Module1

    Sub Main()
        Dim PrixHT, TauxTVA, MontantHT, MontantTVA As Double
        Dim nb As Integer

        Console.Write("Entrez le prix hors taxes: ")
        PrixHT = Console.ReadLine()
        Console.Write("Entrez le nombre d'articles: ")
        nb = Console.ReadLine()
        Console.Write("Entrez le taux de TVA (sous la forme 0,...): ")
        TauxTVA = Console.ReadLine()

        MontantHT = PrixHT * nb
        MontantTVA = MontantHT * TauxTVA

        Console.WriteLine("Montant HT = " & MontantHT)
        Console.WriteLine("Montant TVA = " & MontantTVA)
        Console.WriteLine("Montant TTC = " & MontantHT + MontantTVA)

        Console.ReadKey()

    End Sub

End Module
