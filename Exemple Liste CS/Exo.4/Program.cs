using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo._4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listNoms = new List<string>();

            listNoms.Add("Gilles");
            listNoms.Add("Claude");
            listNoms.Add("Laurent");
            listNoms.Add("Pierre");
            listNoms.Add("Alain");

            listNoms.Sort();

            listNoms.Insert(0, "Aurélie");

            foreach (string nom in listNoms)
            {
                Console.WriteLine(nom);
            }

            int pos = listNoms.IndexOf("Gilles");

            Console.WriteLine("La position de Gilles est : " + pos);

            Console.ReadKey();
        }
    }
}
