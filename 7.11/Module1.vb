Module Module1

    Sub Main()
        Dim note1, note2, note3, note4, moyenneMod1, moyenneMod2, moyenneG As Integer

        Console.WriteLine("Entrez la première note : ")
        note1 = Console.ReadLine()
        Console.WriteLine("Entrez la deuxième note : ")
        note2 = Console.ReadLine()
        Console.WriteLine("Entrez la troisième note : ")
        note3 = Console.ReadLine()
        Console.WriteLine("Entrez la quatrième note : ")
        note4 = Console.ReadLine()

        moyenneMod1 = moyenneModule(note1, note2)
        moyenneMod2 = moyenneModule(note3, note4)
        moyenneG = moyenne(moyenneMod1, moyenneMod2)

        If moyenneMod1 < 8 Or moyenneMod2 < 8 Then
            Console.WriteLine("Refusé !")
            Console.ReadKey()
            End
        End If

        If moyenneG >= 10 Then
            Console.WriteLine("Diplôme obtenu !")
        End If

        Console.ReadKey()

    End Sub

    Function moyenneModule(ByVal a As Integer, ByVal b As Integer) As Integer
        Dim moyenneMod As Integer

        If a > b Then
            moyenneMod = ((2 * a) + b) / 3
        ElseIf a < b Then
            moyenneMod = (a + (2 * b)) / 3
        Else
            moyenneMod = (a + (2 * b)) / 3
        End If

        Return moyenneMod

    End Function

    Function moyenne(ByVal a As Integer, ByVal b As Integer) As Integer

        Return ((a * 2) + b) / 3

    End Function

End Module
