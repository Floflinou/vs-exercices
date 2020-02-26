using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb1, nb2;

            Console.WriteLine("Entrez deux nombres: ");
            nb1 = Convert.ToInt32(Console.ReadLine());
            nb2 = Convert.ToInt32(Console.ReadLine());

            if (nb1 == 0 || nb2 == 0)
            {
                Console.WriteLine("Le produit est nul");
            }
            else if (nb1 < 0 && nb2 < 0 || nb1 > 0 && nb2 > 0)
            {
                Console.WriteLine("Le produit est positif");
            }
            else
            {
                Console.WriteLine("Le produit est négatif");
            }

            Console.ReadKey();
        }
    }
}
