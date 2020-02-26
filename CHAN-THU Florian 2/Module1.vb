Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  24/10/2019
    'Nom du programme: SI4 - Miss SIO
    Sub Main()
        Dim somme, noteMax, noteMin As Integer
        Dim moyenne, moyenneG As Decimal
        Dim tabNotes(10) As Integer
        Dim candidate As Integer
        Dim epreuve As String

        Console.Write("Numéro de la candidate : ")
        candidate = Console.ReadLine()

        noteMin = 0
        noteMax = 0
        moyenneG = 0
        somme = 0

        For i As Integer = 0 To 3
            somme = 0
            noteMin = 0
            noteMax = 0
            Console.Write("Intitulé de l'épreuve : ")
            epreuve = Console.ReadLine()
            Do While epreuve = ""
                Console.WriteLine("Erreur de saisie, recommencez : ")
                epreuve = Console.ReadLine()
            Loop
            For j As Integer = 1 To 10
                Console.Write("Note du juge n° " & j & " : ")
                tabNotes(i) = Console.ReadLine()

                Do While IsNumeric(tabNotes(i)) = False
                    Console.WriteLine("Erreur de saisie, recommencez : ")
                    tabNotes(i) = Console.ReadLine
                Loop

                Do While tabNotes(i) < 0 Or tabNotes(i) > 20
                    Console.WriteLine("Erreur de saisie, recommencez : ")
                    tabNotes(i) = Console.ReadLine
                Loop

                If j = 1 Then
                    noteMin = tabNotes(i)
                End If

                noteMax = noteMaxi(tabNotes(i))
                noteMin = noteMini(tabNotes(i))
                

                somme = somme + tabNotes(i)
            Next
            moyenne = (somme - noteMax - noteMin) / 8
            Console.WriteLine()
            Console.WriteLine("La candidate numéro " & candidate & " a obtenu " & Format(moyenne, "0.000") & " à l'épreuve " & epreuve)
            moyenneG = moyenneG + moyenne
        Next

        Console.WriteLine()
        Console.Write("La candidate N° " & candidate & " a obtenu une moyenne générale de " & moyenneG / 4)
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("Appuyez sur une touche pour continuer...")
        Console.ReadKey()



    End Sub

    'Fonction pour trouver la note minimale, à placer dans le programme
    Function noteMini(ByVal nb As Integer) As Integer
        Dim mini As Integer

        mini = 0

        If nb < mini Then
            mini = nb
        End If

        Return mini

    End Function

    'Fonction pour trouver la note maximale, à placer dans le programme
    Function noteMaxi(ByVal nb As Integer) As Integer
        Dim maxi As Integer

        maxi = 0

        If nb > maxi Then
            maxi = nb
        End If

        Return maxi


    End Function

End Module
