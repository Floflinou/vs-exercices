Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 4.7
    Sub Main()
        Dim nb, note(), moyenne As Integer

        Console.WriteLine("Entrez le nombre de notes à saisir: ")
        nb = Console.ReadLine()
        ReDim note(nb)

        For i As Integer = 1 To nb
            Console.WriteLine("Entrez la note numéro " & i)
            note(i) = Console.ReadLine()
            moyenne = moyenne + note(i)
        Next

        moyenne = moyenne / nb

        Console.WriteLine("La moyenne est de " & Format(moyenne, "0.00"))
        Console.ReadKey()

    End Sub

End Module
