using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb, positif, negatif;
            int[] valeur = new int[1];

            positif = 0;
            negatif = 0;

            Console.WriteLine("Entrez le nombre de valeurs voulues : ");
            nb = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref valeur, nb);

            for (int i = 0; i < nb; i++)
            {
                Console.WriteLine("Saisir une valeur: ");
                valeur[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < nb; i++)
            {
                Console.WriteLine(valeur[i]);
            }

            for (int i = 0; i < nb; i++)
            {
                if (valeur[i] > 0)
                {
                    positif = positif + 1;
                }
                else
                {
                    negatif = negatif + 1;
                }
            }

            Console.WriteLine("{0} valeurs positives", positif);
            Console.WriteLine("{0} valeurs négatives", negatif);

            Console.ReadKey();
        }
    }
}
