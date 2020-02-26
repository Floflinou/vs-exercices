Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 3.5
    Sub Main()
        Dim nb1, nb2, nb3, max As Integer
        Console.WriteLine("Entrez trois nombres: ")
        nb1 = Console.ReadLine()
        nb2 = Console.ReadLine()
        nb3 = Console.ReadLine()

        max = 0

        If (nb1 > max) Then
            max = nb1
        End If

        If (nb2 > max) Then
            max = nb2
        End If

        If (nb3 > max) Then
            max = nb3
        End If

        Console.WriteLine("Le plus grand nombre est " & max)

        Console.ReadKey()

    End Sub

End Module
