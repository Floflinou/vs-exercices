using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, nb, min;

            Console.WriteLine("Entrez un nombre :");
            nb = Convert.ToInt32(Console.ReadLine());
            min = nb;

            for (i = 2; i < 100; i++)
            {
                Console.WriteLine("Entrez un nombre: ");
                nb = Convert.ToInt32(Console.ReadLine());

                if (nb < min)
                {
                    min = nb;
                }
            }

            Console.WriteLine("Le minimum des nombres saisis est {0}", min);

            Console.ReadKey();
        }
    }
}
