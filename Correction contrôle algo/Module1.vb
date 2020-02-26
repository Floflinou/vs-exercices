Module Module1
    Structure SEleve
        Dim classe As String
        Dim prenom As String
        Dim nom As String
    End Structure
    Sub Main()
        Dim i, nb, totalGeneral, totalClasse As Integer
        Dim rep, refClasse As String
        Dim premiereFois As Boolean
        Dim tabEleve() As SEleve

        nb = i
        rep = "O"

        While rep <> "N"
            ReDim Preserve tabEleve(i + 1)
            Console.WriteLine("Saisir classe: ")
            tabEleve(i).classe = Console.ReadLine()
            Console.WriteLine("Saisir nom: ")
            tabEleve(i).nom = Console.ReadLine()
            Console.WriteLine("Saisir prénom: ")
            tabEleve(i).prenom = Console.ReadLine()

            Console.WriteLine("Autre saisie ? O/N")
            rep = Console.ReadLine()
            i = i + 1
        End While

        nb = i
        Console.WriteLine("Liste des élèves du lycée")
        Console.WriteLine("CLASSE   NOM    PRENOM")
        totalGeneral = 0
        i = 0

        While i < nb
            refClasse = tabEleve(i).classe
            premiereFois = True
            totalClasse = 0

            While refClasse = tabEleve(i).classe And i < nb
                If premiereFois = True Then
                    Console.WriteLine(tabEleve(i).classe, tabEleve(i).nom, tabEleve(i).prenom)
                    premiereFois = False
                Else
                    Console.WriteLine(tabEleve(i).nom, tabEleve(i).prenom)
                End If
                i = i + 1
            End While
            Console.WriteLine(totalClasse, " élèves")
            totalGeneral = totalGeneral + totalClasse
        End While

        Console.WriteLine("Soit un total de ", totalGeneral, " élèves")

        Console.ReadKey()

    End Sub

End Module
