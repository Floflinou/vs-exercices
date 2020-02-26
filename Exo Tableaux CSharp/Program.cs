using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Tableaux_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tableau = new string[6];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Entrez une voyelle : ");
                tableau[i] = Console.ReadLine();
            }

            Console.WriteLine("Affichage du tableau");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}", tableau[i]);
            }

            Console.ReadKey();
        }
    }
}
