using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, som;
            string resultat;

            Console.WriteLine("Entrez un nombre : ");
            N = Convert.ToInt32(Console.ReadLine());

            som = 0;

            for (i = 1; i <= N; i++)
            {
                som = som + i;
            }

            Console.WriteLine("La somme est {0}", som);
            Console.ReadKey();
        }
    }
}
