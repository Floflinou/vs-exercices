Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  27/09/2019
    'Nom du programme: TP SI4
    Sub Main()

        Dim choix, notes(), eleve, nbNotes, total(), moyenne(), moyenneG, moyenneGen As Integer

        Console.WriteLine("1. Gestion Notes")
        Console.WriteLine("2. Transposition matrice")
        Console.WriteLine("3. Quitter")
        Console.WriteLine("Votre choix ===>")
        choix = Console.ReadLine()

        If (choix = 1) Then

            Console.Write("Combien y a t'il d'eleves ? (Entrer un nombre positif) : ")
            eleve = Console.ReadLine()
            ReDim notes(eleve)
            ReDim total(eleve)
            ReDim moyenne(eleve)

            For i As Integer = 1 To eleve
                Do Until (notes(i) = -1)
                    Console.WriteLine("Entrez la note de l'élève numéro " & i & " : ")
                    notes(i) = Console.ReadLine()
                    If (notes(i) > 20) Or (notes(i) < -1) Then
                        Console.WriteLine("Ce n'est pas compris entre 0 et 20, saisir à nouveau")
                    End If

                    If (notes(i) > -1) Then
                        total(i) = total(i) + notes(i)
                        nbNotes = nbNotes + 1
                    End If

                Loop

            Next


            For i As Integer = 1 To eleve
                moyenne(i) = total(i) / eleve
                Console.WriteLine("La moyenne de l'élève numéro " & i & " est : " & moyenne(i))
            Next

            For i As Integer = 1 To eleve
                moyenneG = moyenneG + moyenne(i)
            Next

            moyenneGen = moyenneG / eleve

            Console.WriteLine("La moyenne de la classe est de " & moyenneGen)


            Console.ReadKey()

        ElseIf (choix = 2) Then

            Dim tab(,), n, m As Integer

            Console.Write("Saisir la valeur de N : ")
            n = Console.ReadLine()
            Console.Write("Saisir la valeur de M : ")
            m = Console.ReadLine()
            ReDim tab(n, m)
            Console.WriteLine()

            For i As Integer = 1 To n
                For j As Integer = 1 To m
                    Console.Write("tA(" & i & " ; " & j & ") = ")
                    tab(i, j) = Console.ReadLine()
                Next
            Next



            Console.WriteLine("Affichage de la matrice transposée: ")
            Console.WriteLine()

            For i As Integer = 1 To n
                For j As Integer = 1 To m
                    Console.Write("" & tab(i, j) & "  ")
                    If (j = m) Then
                        Console.WriteLine()
                    End If
                Next
            Next

            Console.WriteLine()
            Console.WriteLine()

            For i As Integer = 1 To n
                For j As Integer = 1 To m
                    Console.Write("" & tab(j, i) & " ")
                    If (j = m) Then
                        Console.WriteLine()
                    End If
                Next
            Next

            Console.ReadKey()

        ElseIf (choix = 3) Then

            Console.ReadKey()

        End If

    End Sub

End Module
