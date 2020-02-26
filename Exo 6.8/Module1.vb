Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 6.8
    Sub Main()
        Dim nb, series(4, nb), premiere As Integer

        Console.WriteLine("Saisir le nombre de valeurs dans une série: ")
        nb = Console.ReadLine()
        ReDim series(4, nb)
        For i As Integer = 0 To 3
            For j As Integer = 1 To nb
                Console.WriteLine("Entrez une valeur: ")
                series(i, j) = Console.ReadLine()
                If (series(i, j) = series(0, 0)) Then
                    premiere = premiere + 1
                End If
            Next
        Next



        Console.ReadKey()




    End Sub

End Module
