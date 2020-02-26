Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 4.8
    Sub Main()
        Dim nb, valeurs(), max As Integer

        Console.Write("Entrez le nombre de valeurs à saisir: ")
        nb = Console.ReadLine()
        ReDim valeurs(nb)
        max = 0

        Console.WriteLine()

        For i As Integer = 1 To nb
            Console.WriteLine("Veuillez saisir le nombre " & i & " : ")
            valeurs(i) = Console.ReadLine()
            If (valeurs(i) > max) Then
                max = valeurs(i)
            End If
        Next

        Console.WriteLine()
        Console.WriteLine("La plus grande valeur est ===> " & max)
        Console.ReadKey()

    End Sub

End Module
