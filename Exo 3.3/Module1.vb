Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 3.3
    Sub Main()
        Dim nb1, nb2 As Integer

        Console.WriteLine("Entrez deux nombres: ")
        nb1 = Console.ReadLine()
        nb2 = Console.ReadLine()
        If (nb1 > 0) And (nb2 > 0) Then
            Console.WriteLine("Ce nombre est positif")
        ElseIf (nb1 < 0) And (nb2 < 0) Then
            Console.WriteLine("Ce nombre est positif")
        Else
            Console.WriteLine("Ce nombre est négatif")
        End If

        Console.ReadKey()

    End Sub

End Module
