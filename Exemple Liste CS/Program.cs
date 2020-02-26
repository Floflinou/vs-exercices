using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_Liste_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> liste = new List<string>();
            //Ajouter des personnes
            liste.Add("Gilles");
            liste.Add("Claude");
            liste.Add("Laurent");
            // Trier la liste
            liste.Sort();
            //Insérer 'Aurélie' en première position
            liste.Insert(0, "Aurélie");

            // Afficher le contenu de la liste
            foreach (string ligne in liste)
            {
                Console.WriteLine(ligne);
            }

            // Rechercher la position de la chaîne "Gilles"
            int index = liste.IndexOf("Gilles");
            Console.WriteLine("Position de Gilles : " + index);

            Console.ReadKey();
        }
    }
}
