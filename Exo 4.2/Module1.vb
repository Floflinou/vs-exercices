Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 4.2
    Sub Main()

        Dim nb As Integer

        Console.WriteLine("Entrez un nombre pour obtenir son cube, entrez 0 pour arrêter: ")
        nb = Console.ReadLine()

        While (nb < 0) Or (nb > 0)
            Console.WriteLine("Le cube de " & nb & " est: " & nb * nb * nb)
            nb = Console.ReadLine()
        End While


    End Sub

End Module
