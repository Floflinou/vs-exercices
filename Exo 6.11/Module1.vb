Module Module1
    'Nom Prénom :  CHAN-THU
    'Classe: SLAM1
    'Date :  25/09/2019
    'Nom du programme: Exo 6.11
    Sub Main()
        Dim tab(30) As String, ed, maudRep As Integer

        For i As Integer = 0 To 29
            Console.WriteLine("Saisir un prénom: ")
            tab(i) = Console.ReadLine()
            If tab(i) = "Edouard" Then
                ed = ed + 1
            End If
            If tab(i) = "Maud" Then
                maudRep = maudRep + 1
            End If
        Next

        If ed > 0 Then
            Console.WriteLine("Le prénom Edouard apparaît dans ce tableau")
        Else
            Console.WriteLine("Le prénom Edouard n'apparaît pas dans ce tableau")
        End If

        If maudRep > 0 Then
            Console.WriteLine("Le prénom Maud apparait " & maudRep & " fois dans le tableau")
        Else
            Console.WriteLine("Le prénom Maud n'apparait pas dans ce tableau")
        End If

        Console.ReadKey()



    End Sub

End Module
