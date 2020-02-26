using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb;

            Console.WriteLine("Entrez un nombre : ");
            nb = Convert.ToInt32(Console.ReadLine());

            if (nb < 0)
            {
                Console.WriteLine("Nombre négatif");
            }
            else if (nb == 0)
            {
                Console.WriteLine("Nombre nul");
            }
            else
            {
                Console.WriteLine("Nombre positif");
            }

            Console.ReadKey();

        }
    }
}
