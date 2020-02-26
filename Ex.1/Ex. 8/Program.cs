using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i;
            float note, somme;

            somme = 0;
            Console.WriteLine("Saisir le nombre d'élève : ");
            x = Convert.ToInt32(Console.ReadLine());

            for (i=1; i <= x; i++)
            {
                Console.WriteLine("Saisir notes: ");
                note = float.Parse(Console.ReadLine());
                somme = somme + note;
            }

            Console.WriteLine("La moyenne est de {0}", somme / x);
            Console.ReadKey();
        }
    }
}
