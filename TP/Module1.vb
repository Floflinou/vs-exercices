Module Module1

    Sub Main()
        Dim N, Notes() As Integer

        Console.Write("Bonjour, veuillez entrer le nombre de notes à entrer : ")
        N = Console.ReadLine()
        ReDim Preserve Notes(N)

        Remplir(N, Notes)

        Console.WriteLine()

        Synthese(N, Notes)

        Console.WriteLine()

        Effectif(N, Notes)

        Console.ReadKey()



    End Sub
    Sub Remplir(ByRef N As Integer, ByRef notes() As Integer)

        Console.WriteLine("**** Procédure Remplir tableau ****")
        For i As Integer = 1 To N
            Console.Write("Veuillez entrer la note " & i & " (entre 0 et 20) : ")
            notes(i) = Console.ReadLine()
            While notes(i) < 0 Or notes(i) > 20
                Console.WriteLine("Erreur de saisie, recommencez : ")
                notes(i) = Console.ReadLine()
            End While
        Next
    End Sub

    Sub Synthese(ByRef N As Integer, ByRef notes() As Integer)

        Console.WriteLine("**** Procédure Affichage de synthèse ****")
        Console.WriteLine("Les notes entrées sont : ")
        For i As Integer = 1 To N
            Console.WriteLine(notes(i) & "  ")
        Next

    End Sub

    Sub Effectif(ByRef N As Integer, ByRef notes() As Integer)
        Dim refNote, nbFois As Integer
        Dim TEffectif(N) As Integer
        nbFois = 0

        Console.WriteLine("**** Procédure Effectif ****")
        Console.WriteLine()
        Console.WriteLine("Les effectifs sont : ")

        'For i As Integer = 1 To N
        'refNote = notes(i)
        'While refNote = notes(i) And i < N
        'nbFois = nbFois + 1
        'TEffectif(i) = nbFois
        'i = i + 1
        'End While
        'nbFois = 0
        'Next

        For i As Integer = 1 To N
            For j As Integer = 1 To N
                If notes(j) = notes(i) Then
                    TEffectif(i) = TEffectif(i) + 1
                End If
            Next

            If notes(i) <> notes(i - 1) Then
                Console.WriteLine(notes(i) & ": " & TEffectif(i) & " fois")
            End If
        Next



    End Sub

End Module
