using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> moyennes = new List<int>();

            for (int i = 0; i < 12; i++)
            {
                Console.Write("Saisir la " + (i+1) + "e note : ");
                moyennes.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("La moyenne est de : ");
            Console.WriteLine(moyennes.Average());
            Console.ReadKey();
        }
    }
}
