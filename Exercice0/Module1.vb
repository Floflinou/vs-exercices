Module Module1

    Sub Main()
        Dim nom As String
        Console.Write("Saisir votre nom : ")
        nom = Console.ReadLine()

        Console.WriteLine()

        Console.WriteLine("Bonjour " & nom)

        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("Appuyez sur n'importe quelle touche pour continuer...")
        Console.ReadKey()


    End Sub

End Module
