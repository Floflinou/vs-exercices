Module Module1

    Sub Main()

        Dim choix, a, b As Integer

        Console.Write("Entrez le premier nombre : ")
        a = Console.ReadLine()
        Console.Write("Entrez le deuxième nombre : ")
        b = Console.ReadLine()

        Console.WriteLine("Choisissez une opération")
        Console.WriteLine()
        Console.WriteLine("1. Somme")
        Console.WriteLine("2. Produit")
        Console.WriteLine("3. Moyenne")
        Console.WriteLine("4. Quitter")

        choix = 0

        Do While choix < 1 Or choix > 4
            choix = Console.ReadLine()
            If choix = 1 Then
                Console.Write(somme(a, b))
            ElseIf choix = 2 Then
                Console.Write(Produit(a, b))
            ElseIf choix = 3 Then
                Console.Write(Moyenne(a, b))
            ElseIf choix = 4 Then
                Console.ReadKey()
            End If
        Loop

        Console.WriteLine()
        Console.ReadKey()

    End Sub

    Function somme(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a + b
    End Function

    Function produit(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a * b
    End Function

    Function moyenne(ByVal a As Integer, ByVal b As Integer) As Integer
        Return (a + b) / 2
    End Function

End Module
