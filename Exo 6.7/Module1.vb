Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 6.7
    Sub Main()
        Dim nb, valeur(), plusGrand As Integer
        Console.WriteLine("Entrez le nombre de valeurs voulues: ")
        nb = Console.ReadLine()
        ReDim valeur(nb)

        Console.WriteLine("Entrez une première valeur: ")
        plusGrand = Console.ReadLine()

        For i As Integer = 2 To nb
            Console.WriteLine("Entrez une valeur: ")
            valeur(i) = Console.ReadLine()
            If (valeur(i) > plusGrand) Then
                plusGrand = valeur(i)
            End If
        Next


        Console.WriteLine("L'élément le plus grand est: " & plusGrand)

        Console.ReadKey()




    End Sub

End Module
