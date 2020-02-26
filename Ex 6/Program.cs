using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, max;

            Console.WriteLine("Entrez 3 nombres : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());

            max = n1;

            if (n2 > max)
            {
                max = n2;
            }
            if (n3 > max)
            {
                max = n3;
            }

            Console.WriteLine("Le nombre maximum est {0}", max);

            Console.ReadKey();
        }
    }
}
