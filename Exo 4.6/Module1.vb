Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 4.6
    Sub Main()
        Dim nb, nbcalc, total As Integer
        Console.WriteLine("Entrez un nombre: ")
        nb = Console.ReadLine()
        nbcalc = nb - nb

        For I As Integer = 1 To nb
            nbcalc = nbcalc + 1
            total = total + nbcalc
            If (I = 1) Then
                Console.Write("" & nbcalc)
            ElseIf (I < nb) Then
                Console.Write(" + " & nbcalc & "")
            Else
                Console.Write(" = " & total)
            End If

        Next

        Console.ReadKey()

    End Sub

End Module
