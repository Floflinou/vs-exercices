Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 3.6
    Sub Main()

        'Variables
        Dim client As Char, nb As Integer

        'Saisie
        Console.WriteLine("Entrez votre code client et le montant HT: ")
        client = Console.ReadLine()
        nb = Console.ReadLine()


        'Conditions
        If (client = "A") Then
            Console.WriteLine("Le montant reste inchangé")
        ElseIf (client = "B") Then
            Console.WriteLine("Le montant est de " & nb * 0.98)
        ElseIf (client = "C") Then
            Console.WriteLine("Le montant est de " & nb * 0.96)
        ElseIf (client = "D") Then
            Console.WriteLine("Le montant est de " & nb * 0.93)
        Else
            Console.WriteLine("Le code client est erroné")
        End If

        'Pause
        Console.ReadKey()


    End Sub

End Module
