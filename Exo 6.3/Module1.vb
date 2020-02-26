Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 6.3
    Sub Main()
        Dim valeur(10) As Integer

        For i As Integer = 0 To 9
            Console.WriteLine("Entrez la valeur n°" & i)
            valeur(i) = Console.ReadLine()
        Next

        For i As Integer = 9 To 0 Step -1
            Console.WriteLine("" & valeur(i))
        Next

        Console.ReadKey()


    End Sub

End Module
