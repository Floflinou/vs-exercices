Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 3.4
    Sub Main()
        Dim nb As Integer
        Console.WriteLine("Entrez un age: ")
        nb = Console.ReadLine()

        If (nb > 12) Then
            Console.WriteLine("Catégorie cadet")
        ElseIf (nb > 9) Then
            Console.WriteLine("Catégorie minime")
        ElseIf (nb > 7) Then
            Console.WriteLine("Catégorie pupille")
        ElseIf (nb > 5) Then
            Console.WriteLine("Catégorie poussin")
        End If

        Console.ReadKey()

    End Sub

End Module
