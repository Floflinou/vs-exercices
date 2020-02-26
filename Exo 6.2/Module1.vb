Module Module1

    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 6.2

    Sub Main()
        Dim Tnotes(12), total As Integer

        For i As Integer = 0 To 11
            Console.WriteLine("Entrez la note n°" & i)
            Tnotes(i) = Console.ReadLine()
        Next

        total = 0

        For i As Integer = 0 To 11
            total = total + Tnotes(i)
        Next

        Console.WriteLine("La moyenne est de: " & total / 12)

        Console.ReadKey()

    End Sub

End Module
