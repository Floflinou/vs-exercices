Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 6.5
    Sub Main()
        Dim nb, valeur(), positif, negatif As Integer

        Console.WriteLine("Entrez le nombre de valeurs voulues: ")
        nb = Console.ReadLine()
        ReDim valeur(nb)

        For i As Integer = 1 To nb
            Console.WriteLine("Saisir une valeur: ")
            valeur(i) = Console.ReadLine()
        Next

        Console.WriteLine()

        For i As Integer = 1 To nb
            Console.WriteLine("" & valeur(i))
        Next

        For i As Integer = 1 To nb
            If (valeur(i) > 0) Then
                positif = positif + 1
            Else
                negatif = negatif + 1
            End If
        Next
        Console.WriteLine()

        Console.WriteLine("Le nombre de valeurs positives est de " & positif)
        Console.WriteLine("Le nombre de valeurs négatives est de " & negatif)

        Console.ReadKey()

    End Sub

End Module
