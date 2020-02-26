Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 4.3
    Sub Main()
        Dim nb As Integer
        Console.WriteLine("Entrez un nombre compris entre 10 et 20: ")
        nb = Console.ReadLine()

        While (nb < 10)
            Console.WriteLine("Plus grand !")
            nb = Console.ReadLine()
        End While

        While (nb > 20)
            Console.WriteLine("Plus petit !")
            nb = Console.ReadLine()
        End While

        Console.WriteLine("Saisie acceptée")
        Console.ReadKey()

    End Sub

End Module
