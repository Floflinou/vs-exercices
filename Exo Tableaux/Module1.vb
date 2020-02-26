Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 6.1
    Sub Main()
        Dim tableau(6) As Char

        For i As Integer = 0 To 5
            Console.WriteLine("Entrez une voyelle: ")
            tableau(i) = Console.ReadLine()
        Next

        Console.WriteLine("Affichage du tableau")

        For i As Integer = 0 To 5
            Console.WriteLine("" & tableau(i))
        Next

        Console.ReadKey()


    End Sub

End Module
