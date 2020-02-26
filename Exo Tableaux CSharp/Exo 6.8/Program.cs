using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_6._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb, premiere;
            premiere = 0;

            Console.WriteLine("Entrez le nombre de valeurs dans une série : ");
            nb = Convert.ToInt32(Console.ReadLine());
            int[,] series = new int[4, nb];
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < nb; j++)
                {
                    Console.WriteLine("Saisie de la série {0}: ", i+1);
                    series[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (series[i,j] == series[i,0])
                    {
                        premiere = premiere + 1;
                    }
                    if (j == nb - 1)
                    {
                        Console.WriteLine("**************************Résultat***************************");
                        Console.WriteLine("La première valeur de la série {0} est {1}, elle apparaît {2} fois", i + 1, series[i, 0], premiere);
                        Console.WriteLine();
                        premiere = 0;
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
