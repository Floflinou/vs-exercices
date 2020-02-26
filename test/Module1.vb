Module Module1
    'Le but: Additionner deux matrices
    Sub Main()
        Dim matrice1(,), matrice2(,), matrice3(,), ligne, colonne As Integer

        Console.WriteLine("Entrez le nombre de lignes voulues : ")
        ligne = Console.ReadLine()
        Console.WriteLine("Entrez le nombre de colonnes voulues : ")
        colonne = Console.ReadLine()


        ReDim Preserve matrice1(ligne, colonne)
        ReDim Preserve matrice2(ligne, colonne)
        ReDim Preserve matrice3(ligne, colonne)

        Console.WriteLine("Pour la première matrice : ")

        For i As Integer = 1 To ligne
            For j As Integer = 1 To colonne
                Console.WriteLine("Entrez la valeur " & (j) & " de la ligne " & (i))
                matrice1(i, j) = Console.ReadLine()
            Next
        Next

        Console.WriteLine("Pour la deuxième matrice : ")

        For i As Integer = 1 To ligne
            For j As Integer = 1 To colonne
                Console.WriteLine("Entrez la valeur " & (j) & " de la ligne " & (i))
                matrice2(i, j) = Console.ReadLine()
            Next
        Next

        Console.WriteLine("Calcul de la troisième...")
        Console.ReadKey()

        For i As Integer = 1 To ligne
            For j As Integer = 1 To colonne
                Console.Write(matrice2(i, j) + matrice1(i, j) & "  ")
                If (j = colonne) Then
                    Console.WriteLine()
                End If
            Next
        Next

        Console.ReadKey()


    End Sub

End Module
