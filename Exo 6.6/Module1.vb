Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 6.6
    Sub Main()
        Dim nb, valeur() As Integer
        Console.WriteLine("Entrez le nombre de valeurs voulues")
        nb = Console.ReadLine
        ReDim valeur(nb)

        For i As Integer = 1 To nb
            Console.WriteLine("Saisir une valeur: ")
            valeur(i) = Console.ReadLine()
            valeur(i) = valeur(i) + 1
        Next

        Console.WriteLine()

        For i As Integer = 1 To nb
            Console.WriteLine("Valeur majorée de 1 = " & valeur(i))
        Next

        Console.ReadKey()


    End Sub

End Module
