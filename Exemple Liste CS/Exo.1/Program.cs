using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> voyelles = new List<string>();

            voyelles.Add("a");
            voyelles.Add("e");
            voyelles.Add("i");
            voyelles.Add("o");
            voyelles.Add("u");
            voyelles.Add("y");

            voyelles.Sort();

            foreach (string voyelle in voyelles)
            {
                Console.WriteLine(voyelle);
            }

            Console.ReadKey();
        }
    }
}
