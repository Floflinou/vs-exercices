using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string V1, V2, V3;

            Console.WriteLine("Entrez trois noms : ");
            V1 = Console.ReadLine();
            V2 = Console.ReadLine();
            V3 = Console.ReadLine();

            if (V1.CompareTo(V2) == 0 && V2.CompareTo(V3) == 0)
            {
                Console.WriteLine("Ces noms sont classés");
            }
            else
            {
                Console.WriteLine("Ces noms ne sont pas classés");
            }

            Console.ReadKey();
        }
    }
}
