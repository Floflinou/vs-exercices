using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_6._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb, total, moyenne, supMoy;

            total = 0;
            supMoy = 0;
            Console.WriteLine("Entrez le nombre de notes à saisir : ");
            nb = Convert.ToInt32(Console.ReadLine());
            int[] valeur = new int[nb];

            for (int i = 0; i < nb; i++)
            {
                Console.WriteLine("Entrez la note numéro " + (i+1));
                valeur[i] = Convert.ToInt32(Console.ReadLine());
                total = total + valeur[i];
            }

            moyenne = total / nb;

            for (int i = 0; i < nb; i++)
            {
                if (valeur[i] > moyenne)
                {
                    supMoy = supMoy + 1;
                }
            }

            Console.WriteLine("La moyenne de classe est de " + moyenne);
            Console.WriteLine("Il y a " + supMoy + " notes supérieures à la moyenne");
            Console.ReadKey();
        }
    }
}
