Module Module1
    Structure TPersonne
        Dim nom, prenom As String
        Dim maths, francais, anglais As Integer
    End Structure
    Sub Main()
        Dim tabEleve() As TPersonne
        Dim choix, moyenne, nb, moyenneGG, eleve As Integer
        Dim nom, prenom As String
        Dim continuer As Char

        ReDim tabEleve(1)

        While continuer <> "n"
            For i As Integer = 0 To nb
                Console.WriteLine("Entrez le nom: ")
                tabEleve(i).nom = Console.ReadLine()
                Console.WriteLine("Entrez le prénom: ")
                tabEleve(i).prenom = Console.ReadLine()
                Console.WriteLine("Entrez la moyenne de maths: ")
                tabEleve(i).maths = Console.ReadLine()
                Console.WriteLine("Entrez la moyenne de français: ")
                tabEleve(i).francais = Console.ReadLine()
                Console.WriteLine("Entrez la moyenne d'anglais: ")
                tabEleve(i).anglais = Console.ReadLine()
                Console.WriteLine()
                Console.WriteLine("Saisir une autre personne ? O/N")
                continuer = Console.ReadLine()
                nb = nb + 1
            Next
        End While

        Console.WriteLine("1. Calculer la moyenne générale de tous les élèves")
            Console.WriteLine("2. Calculer la moyenne générale d'un seul élève")
            Console.WriteLine("3. Quitter")
            choix = Console.ReadLine()

        If choix = "1" Then
            For i = 0 To nb
                moyenneGG = (tabEleve(i).maths + tabEleve(i).francais + tabEleve(i).anglais) / nb
            Next
            Console.WriteLine("La moyenne générale est de ", moyenneGG)

        ElseIf choix = "2" Then
            Console.WriteLine("Saisir le nom et le prénom de l'élève: ")
            nom = Console.ReadLine()
            prenom = Console.ReadLine()

            For i = 0 To nb
                If tabEleve(i).nom = nom Then
                    If tabEleve(i).prenom = prenom Then
                        eleve = i
                    End If
                End If
            Next

            moyenne = (tabEleve(eleve).francais + tabEleve(eleve).maths + tabEleve(eleve).anglais) / 3
            Console.WriteLine("La moyenne générale de l'élève ", tabEleve(eleve).prenom, tabEleve(eleve).nom, " est de ", moyenne)

        Else
            Console.ReadKey()
        End If

        Console.ReadKey()

    End Sub

End Module
