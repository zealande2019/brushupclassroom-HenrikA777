using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum klasse3r = new KlasseRum("3R", new List<Studerende>() {new Studerende("Henrik", 4, 5), new Studerende("Mads", 11, 26), new Studerende("Simon", 12, 23), new Studerende("Marcel", 6, 12) }, new DateTime(2018, 9, 4));
            Console.WriteLine(klasse3r.ToString());
            foreach (var studerende in klasse3r.StuderendeListe)
            {
                Console.WriteLine(studerende.Navn + "   ||  " + studerende.Årstid);
            }

            Console.WriteLine();
            klasse3r.PrintÅrstider();

            Console.ReadLine();
        }
    }
}
