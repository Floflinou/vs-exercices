using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb;
            int[] valeur = new int[1];

            Console.WriteLine("Nombre de valeurs voulues : ");
            nb = Convert.ToInt32(Console.ReadLine());

            Array.Resize(ref valeur, nb);

            for (int i = 0; i < nb; i++)
            {
                Console.WriteLine("Saisir une valeur : ");
                valeur[i] = Convert.ToInt32(Console.ReadLine());
                valeur[i] = valeur[i] + 1;
            }

            Console.WriteLine();

            for (int i = 0; i < nb; i++)
            {
                Console.WriteLine("Valeur majorée = " + valeur[i]);
            }

            Console.ReadKey();
        }
    }
}
