Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 4.4
    Sub Main()
        Dim nb, i As Integer

        Console.WriteLine("Entrez un nombre de départ: ")
        nb = Console.ReadLine()

        i = 0

        For i = 1 To 10
            nb = nb + 1
            Console.WriteLine("" & nb)
        Next

        Console.ReadKey()

    End Sub

End Module
