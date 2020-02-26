Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 3.2
    Sub Main()
        Dim nb As Integer

        Console.WriteLine("Entrez un nombre: ")
        nb = Console.ReadLine()

        If (nb > 0) Then
            Console.WriteLine("Le nombre est positif")
        ElseIf (nb < 0) Then
            Console.WriteLine("Le nombre est négatif")
        Else
            Console.WriteLine("Le nombre est nul")
        End If

        Console.ReadKey()

    End Sub

End Module
