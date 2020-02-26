using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo._5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listValeurs = new List<int>();

            listValeurs.Add(7);
            listValeurs.Add(3);
            listValeurs.Add(5);
            listValeurs.Add(9);
            listValeurs.Add(12);

            Console.WriteLine("Affichage de la liste : ");
            foreach (int valeur in listValeurs)
            {
                Console.WriteLine(valeur);
            }

            int indice = listValeurs.IndexOf(3);
            listValeurs.RemoveAt(indice);
            listValeurs.Insert(indice, 10);

            Console.WriteLine();
            Console.WriteLine("Affichage de la liste modifiée : ");
            Console.WriteLine();
            foreach (int valeur in listValeurs)
            {
                Console.WriteLine(valeur);
            }

            Console.WriteLine();

            Console.WriteLine("Nb d'éléments dans la liste : " + listValeurs.Count);
            Console.WriteLine("L'indice de la valeur 9 est : " + listValeurs.IndexOf(9));
            Console.WriteLine("La valeur de l'indice 3 est : " + listValeurs.ElementAt(3));
            Console.WriteLine();


            listValeurs.Sort();

            foreach (int valeur in listValeurs)
            {
                Console.WriteLine(valeur);
            }

            Console.WriteLine();

            Console.WriteLine("Somme des valeurs de la liste : " + listValeurs.Sum());
            Console.WriteLine("Moyenne des valeurs de la liste : "+ listValeurs.Average());

            Console.ReadKey();
        }
    }
}
