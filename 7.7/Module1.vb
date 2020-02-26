Module Module1

    Sub Main()
        Dim longueur, largeur As Integer

        Console.Write("Entrez la longueur: ")
        longueur = Console.ReadLine()
        Console.Write("Entrez la largeur: ")
        largeur = Console.ReadLine()

        Console.Write("Surface = " & surface(longueur, largeur))
        Console.ReadKey()

    End Sub

    Function surface(ByVal lon As Double, ByVal lar As Double) As Integer
        Return lon * lar
    End Function

End Module
