using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Studerende
    {
        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            Navn = navn;
            Fødselsdag = fødselsdag;
            Fødselsmåned = fødselsmåned;
        }

        public string Navn { get; private set; }

        public int Fødselsmåned { get; private set; }

        public int Fødselsdag { get; private set; }
    }
}
