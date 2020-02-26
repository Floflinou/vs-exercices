using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notes = new int[12];
            int total;

            for (int i = 0; i <= 11; i++)
            {
                Console.WriteLine("Entrez la note n°" + i);
                notes[i] = Convert.ToInt32(Console.ReadLine());
            }

            total = 0;

            for (int i = 0; i <= 11; i++)
            {
                total = total + notes[i];
            }

            Console.WriteLine("La moyenne est de : " + total / 12);
            Console.ReadKey();

        }
    }
}
