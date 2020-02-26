using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, F;

            Console.WriteLine("Entrez un nombre : ");
            N = Convert.ToInt32(Console.ReadLine());
            F = 1;

            for (i = 2; i <= N; i++)
            {
                F = F * i;
            }

            Console.WriteLine("La factorielle de {0} est {1}", N, F);
            Console.ReadKey();
        }
    }
}
