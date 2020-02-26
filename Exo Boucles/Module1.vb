Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 4.1
    Sub Main()
        Dim nb As Integer

        Console.WriteLine("Entrez un nombre compris en 1 et 3 :")
        nb = Console.ReadLine()

        While (nb < 1) Or (nb > 3)
            Console.Write("Saisie erronée, veuillez recommencer: ")
            nb = Console.ReadLine()
        End While

        Console.WriteLine("Saisie acceptée !")
        Console.ReadKey()

    End Sub

End Module
