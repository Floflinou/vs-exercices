Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 3.1
    Sub Main()

        ' Variables
        Dim Lettre1, Lettre2, Lettre3 As Char

        ' Affichage
        Console.WriteLine("Entrez successivement trois lettres: ")

        ' Sasie
        Lettre1 = Console.ReadLine()
        Lettre2 = Console.ReadLine()
        Lettre3 = Console.ReadLine()

        If (Lettre1 < Lettre2) And (Lettre2 < Lettre3) Then
            Console.WriteLine("Ces lettres sont classées alphabétiquement")
        Else
            Console.WriteLine("Ces lettres ne sont pas classées alphabétiquement")
        End If

        Console.ReadKey()

    End Sub

End Module
