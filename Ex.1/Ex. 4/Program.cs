using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i;

            Console.WriteLine("Entrez un nombre : ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Les 10 nombres suivants sont : ");

            for (i = 1; i < 10; i++)
            {
                Console.WriteLine(N + i);
            }

            Console.ReadKey();
        }
    }
}
