using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6._4b
{
    class Program
    {
        static void Main(string[] args)
        {
            int posligne = 0;
            int poscolonne = 0;
            int max = -99;
            Console.Write("Entrez le nombre de lignes à saisir : ");
            int ligne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez le nombre de colonnes à saisir : ");
            int colonne = Convert.ToInt32(Console.ReadLine());

            int[,] Tab = new int[ligne, colonne];

            for (int i = 0; i < ligne; i++)
            {
                for (int j = 0; j < colonne; j++)
                {
                    Console.Write("Saisir une valeur pour la ligne {0} colonne {1} : ", i + 1, j + 1);
                    Tab[i, j] = Convert.ToInt32(Console.ReadLine());

                    if (i == 0 && j == 0)
                    {
                        max = Tab[i, j];
                        posligne = i;
                        poscolonne = j;
                    }

                    if (Tab[i,j] > max)
                    {
                        max = Tab[i, j];
                        posligne = i;
                        poscolonne = j;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Le plus grand élément est " + max);
            Console.WriteLine("Il se trouve aux indices "+ (posligne+1) + " : " + (poscolonne+1));
            Console.ReadKey();


        }
    }
}
