using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1, N2;
            int choix;

            Console.WriteLine("Donnez deux nombres : ");
            N1 = float.Parse(Console.ReadLine());
            N2 = float.Parse(Console.ReadLine());

            Console.WriteLine("1 - Somme");
            Console.WriteLine("2 - Produit");
            Console.WriteLine("3 - Moyenne");
            Console.WriteLine("Saisissez votre choix : ");
            choix = Convert.ToInt32(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    Console.WriteLine("La somme est de " + N1+N2);
                    break;
                case 2:
                    Console.WriteLine("Le produit est de " + N1 * N2);
                    break;
                case 3:
                    Console.WriteLine("La moyenne est de " + (N1 + N2) / 2);
                    break;
                default:
                    Console.WriteLine("Erreur de saisie");
                    break;
            }

            Console.ReadKey();
        }
    }
}
