Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 4.5
    Sub Main()
        Dim nb, nbMax As Integer
        Console.WriteLine("Entrez le premier nombre")
        nb = Console.ReadLine()

        For i As Integer = 1 To 100
            If (nb > nbMax) Then
                nbMax = nb
            End If
            Console.ReadLine()
        Next

        Console.WriteLine("Le plus grand nombre est " & nbMax)


        Console.ReadKey()


    End Sub

End Module
