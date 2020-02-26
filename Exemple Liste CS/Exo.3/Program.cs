using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> valeurs = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Saisissez la " + (i + 1) + "e valeur : ");
                valeurs.Add(Convert.ToInt32(Console.ReadLine()));
            }

            valeurs.Reverse();

            Console.WriteLine();

            foreach (int valeur in valeurs)
            {
                Console.WriteLine(valeur);
            }

            Console.ReadKey();
        }
    }
}
