using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            string chaineM, chaineN;

            Console.WriteLine("Entrez deux nombres : ");
            chaineM = Console.ReadLine();
            m = Convert.ToInt32(chaineM);
            chaineN = Console.ReadLine();
            n = Convert.ToInt32(chaineN);

            if (m > 0 && n > 0 || m < 0 & n < 0)
            {
                Console.WriteLine("Le produit est positif");
            }
            else
            {
                Console.WriteLine("Le produit est négatif");
            }

            Console.WriteLine("\n\nAppuyez sur une touche pour continuer...");
            Console.ReadKey();
        }
    }
}
