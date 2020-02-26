Module Module1

    Sub Main()
        Dim nb, eleves(), moyenne(), notes(), moyenneG, nbNotes, nbNotesE(), totalNotesE(), totalNotesC(), nbNotesTotal As Integer

        Console.Write("Combien y a t'il d'eleves ? (Entrer un nombre positif) : ")
        nb = Console.ReadLine()
        ReDim eleves(nb)
        ReDim moyenne(nb)
        ReDim notes(1)
        ReDim totalNotesE(1)
        ReDim totalNotesC(1)
        ReDim nbNotesE(1)


        For i As Integer = 1 To nb
            Do
                Console.Write("Entrez la note de l'élève numéro " & i & " : ")
                notes(i) = Console.ReadLine()

                If (notes(i) > 20) Or (notes(i) < -1) Then
                    Console.WriteLine("Ce n'est pas compris entre 0 et 20, saisir à nouveau")
                End If

                nbNotes = nbNotes + 1
                totalNotesE(i) = totalNotesE(i) + notes(i)
                ReDim Preserve notes(nbNotes)
                ReDim Preserve totalNotesE(nbNotes)
                ReDim Preserve nbNotesE(i + 1)

            Loop Until (notes(i) = -1)

            nbNotesTotal = nbNotesTotal + 1
            ReDim Preserve totalNotesC(nbNotesTotal)
            ReDim Preserve moyenne(totalNotesE(i) + totalNotesE(i - 1))
            Console.WriteLine()
            eleves(i) = eleves(i) + 1
        Next


        For i As Integer = 1 To nb
            Console.WriteLine("La moyenne d'élève numéro " & eleves(i) & " est : " & moyenne(i))
        Next


        Console.WriteLine("La moyenne de la classe est : " & moyenneG / nbNotes)

        Console.ReadKey()

    End Sub

End Module
