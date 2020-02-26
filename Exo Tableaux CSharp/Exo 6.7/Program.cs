using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb, plusGrand;
            int[] valeur = new int[1];

            Console.WriteLine("Entrez le nombre de valeurs voulues : ");
            nb = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref valeur, nb);

            Console.WriteLine("Entrez une première valeur : ");
            plusGrand = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < nb; i++)
            {
                Console.WriteLine("Entrez une valeur: ");
                valeur[i] = Convert.ToInt32(Console.ReadLine());
                if (valeur[i] > plusGrand)
                {
                    plusGrand = valeur[i];
                }
            }

            Console.WriteLine("L'élément le plus grand est " + plusGrand);

            Console.ReadKey();
        }
    }
}
