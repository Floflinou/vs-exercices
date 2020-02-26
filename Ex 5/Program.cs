using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Entrez l'âge de l'enfant : ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 12)
            {
                Console.WriteLine("Catégorie cadet");
            }
            else if (age >= 10)
            {
                Console.WriteLine("Catégorie minime");
            }
            else if (age >= 8)
            {
                Console.WriteLine("Catégorie pupille");
            }
            else if (age >= 6)
            {
                Console.WriteLine("Catégorie poussin");
            }
            else
            {
                Console.WriteLine("Erreur de saisie !");
            }

            Console.ReadKey();
        }
    }
}
