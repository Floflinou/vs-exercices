Module Module1

    Sub Main()
        Dim nb As Integer

        Console.Write("Entrez une valeur en cm : ")
        nb = Console.ReadLine()

        Console.Write(nb & "cm = " & pouce(nb) & " pouces")
        Console.ReadKey()

    End Sub

    Function pouce(ByVal cm As Integer) As Double

        Return cm / 2.54

    End Function

End Module
