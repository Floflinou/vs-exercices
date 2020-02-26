Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 6.10
    Sub Main()
        Dim valeur(,), nbLignes, nbColonnes, max, positionI, positionJ As Integer

        Console.Write("Entrez le nombre de lignes: ")
        nbLignes = Console.ReadLine()
        Console.Write("Entrez le nombre de colonnes: ")
        nbColonnes = Console.ReadLine()
        ReDim valeur(nbLignes, nbColonnes)
        Console.WriteLine()

        For i As Integer = 1 To nbLignes
            For j As Integer = 1 To nbColonnes
                If (j = 1) And (i = 1) Then
                    Console.Write("Entrez le premier numéro : ")
                    max = Console.ReadLine()
                Else
                    Console.Write("Entrez le numéro " & j & " de la série " & i & " : ")
                    valeur(i, j) = Console.ReadLine()
                    Console.WriteLine()
                    If (valeur(i, j) > max) Then
                        max = valeur(i, j)
                        positionI = i
                        positionJ = j
                    End If
                End If

            Next
        Next

        Console.WriteLine()
        Console.WriteLine("Elément le plus grand : " & max)
        Console.WriteLine("Position de cet élément ====> " & positionI & " : " & positionJ)

        Console.ReadKey()


    End Sub

End Module
