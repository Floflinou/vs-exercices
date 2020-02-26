Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 6.12
    Sub Main()
        Dim tabA(3, 3), tabB(3, 3), tabC(3, 3) As Integer

        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                Console.WriteLine("Entrez un nombre: ")
                tabA(i, j) = Console.ReadLine()
                Console.WriteLine("Entrez un nombre: ")
                tabB(i, j) = Console.ReadLine()
                tabC(i, j) = tabB(i, j) + tabA(i, j)
            Next
        Next

        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                Console.WriteLine(tabC(i, j))
            Next
        Next

        Console.ReadKey()

    End Sub

End Module
