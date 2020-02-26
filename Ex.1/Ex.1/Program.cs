using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Entrez un nombre compris entre 1 et 3");
            n = Convert.ToInt32(Console.ReadLine());

            while (n < 1 || n > 3)
            {
                Console.WriteLine("Saisie erronée, veuillez recommencer : ");
                n = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Saisie acceptée");
            Console.ReadKey();
        }
    }
}
