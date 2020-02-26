using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Ce programme affiche le cube des nombres que vous entrez. Pour arrêtez tapez 0");
            Console.WriteLine("Entrez un nombre");
            x = Convert.ToInt32(Console.ReadLine());

            while (x != 0)
            {
                Console.WriteLine("Le cube de {0} est {1}", x, x * x * x);
                Console.WriteLine("Entrez un nombre ou 0 pour arrêter");
                x = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Fin");
            Console.ReadKey();
        }
    }
}
