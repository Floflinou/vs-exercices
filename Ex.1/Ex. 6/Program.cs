using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i;

            Console.WriteLine("Entrez un nombre : ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La table de multiplication de ce nombre : ");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", N, i, N * i);
            }

            Console.ReadKey();
        }
    }
}
