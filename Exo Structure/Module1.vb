Module Module1
    Structure TPersonne
        Dim prenom As String
        Dim nom As String
        Dim age As Integer
    End Structure
    Sub Main()
        Dim Pers1, Pers2 As TPersonne

        Console.WriteLine("Saisissez le prénom de la première personne : ")
        Pers1.nom = Console.ReadLine()
        Console.WriteLine("Saisissez le nom de la première personne : ")
        Pers1.prenom = Console.ReadLine()
        Console.WriteLine("Saisissez l'âge de la première personne : ")
        Pers1.age = Console.ReadLine()

        Console.WriteLine()

        Console.WriteLine("Saisissez le prénom de la deuxième personne : ")
        Pers2.nom = Console.ReadLine()
        Console.WriteLine("Saisissez le nom de la deuxième personne : ")
        Pers2.prenom = Console.ReadLine()
        Console.WriteLine("Saisissez l'âge de la deuxième personne : ")
        Pers2.age = Console.ReadLine()

        Console.WriteLine()

        If (Pers1.age > Pers2.age) Then
            Console.WriteLine("La première personne est plus agée de " & (Pers1.age - Pers2.age))
        ElseIf (Pers1.age = Pers2.age) Then
            Console.WriteLine("Les deux personnes ont le même âge")
        Else
            Console.WriteLine("La deuxième personne est plus agée de " & (Pers2.age - Pers1.age) & " ans")
        End If

        Console.ReadKey()

    End Sub

End Module
