using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_CS
{
    class Program
    {
        public struct Personne
        {
            public string nom;
            public string prenom;
            public int age;
        }
        static void Main(string[] args)
        {
            Personne pers1 = new Personne();
            Personne pers2 = new Personne();

            Console.WriteLine("Entrez le prénom, le nom et l'âge de la première personne : ");
            pers1.prenom = Console.ReadLine();
            pers1.nom = Console.ReadLine();
            pers1.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrez le prénom, le nom et l'âge de la deuxième personne : ");
            pers2.prenom = Console.ReadLine();
            pers2.nom = Console.ReadLine();
            pers2.age = Convert.ToInt32(Console.ReadLine());

            if (pers1.age < pers2.age)
            {
                Console.Write("La première personne est plus jeune que la deuxième");
            }
            else if (pers1.age > pers2.age)
            {
                Console.Write("La première personne est plus vieille que la deuxième personne");
            }
            else
            {
                Console.Write("Les deux personnes ont le même âge");
            }

            Console.ReadKey();

        }
    }
}
