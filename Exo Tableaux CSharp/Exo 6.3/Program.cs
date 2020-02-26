using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valeur = new int[10];

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Entrez la valeur n°" + (i+1));
                valeur[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(valeur[i]);
            }

            Console.ReadKey();
        }
    }
}
