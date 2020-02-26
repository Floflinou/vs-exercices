using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = 0;

            Console.WriteLine("Entrez un nombre entre 10 et 20");
            
            while (n < 10 || n > 20)
            {
                n = Convert.ToInt32(Console.ReadLine());

                if (n < 10)
                {
                    Console.WriteLine("Plus grand !");
                }
                else
                {
                    Console.WriteLine("Plus petit !");
                }
            }

            Console.ReadKey();
        }
    }
}
