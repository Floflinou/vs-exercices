Module Module1

    Sub Main()
        Dim nom As String

        Console.Write("Saisir un nom : ")
        nom = Console.ReadLine()

        Console.WriteLine("Première lettre du nom : " & nom(0))

        Console.WriteLine("Nombre de lettres dans le nom : " & nom.Length)

        For i As Integer = 0 To nom.Length - 1
            Console.WriteLine("Lettre numéro " & i & " : " & nom(i))
        Next

        Console.ReadKey()

    End Sub

End Module
