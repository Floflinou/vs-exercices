using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int qte, max, nb, i;

            Console.WriteLine("Saisissez la quantité de nombre que vous voulez saisir: ");
            qte = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Saisir le premier nombre: ");
            max = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= qte; i++)
            {
                Console.WriteLine("Saisir le nombre {0}", i);
                nb = Convert.ToInt32(Console.ReadLine());

                if (nb > max)
                {
                    max = nb;
                }
            }

            Console.WriteLine("Le nombre maximum est {0}", max);

            Console.ReadKey();
        }
    }
}
