Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 6.9
    Sub Main()
        Dim valeurs(), nb, total, moyenne, supMoy As Integer
        Console.WriteLine("Entrez le nombre de notes à saisir: ")
        nb = Console.ReadLine()
        ReDim valeurs(nb)

        For i As Integer = 1 To nb
            Console.WriteLine("Entrez la note numéro " & i)
            valeurs(i) = Console.ReadLine()
            total = total + valeurs(i)
        Next

        moyenne = total / nb

        For i As Integer = 1 To nb
            If (valeurs(i) > moyenne) Then
                supMoy = supMoy + 1
            End If
        Next

        Console.WriteLine("La moyenne de classe est de " & moyenne)
        Console.WriteLine("Il y a " & supMoy & " notes supérieures à la moyenne")
        Console.ReadKey()


    End Sub

End Module
