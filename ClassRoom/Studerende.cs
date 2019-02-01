using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    using System.Diagnostics;

    public class Studerende
    {
        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            Navn = navn;
            Fødselsdag = fødselsdag;
            if (0 >= fødselsmåned || fødselsmåned >= 13)
            {
                throw new ArgumentException();
            }
            Fødselsmåned = fødselsmåned;
        }

        public string Navn { get; private set; }

        public int Fødselsmåned { get; private set; }

        public int Fødselsdag { get; private set; }
        
        public string Årstid
        {
            get
            {
                int caseSwitch = Fødselsmåned;
                switch (caseSwitch)
                {
                    case 1:
                    case 2:
                    case 12:
                        return "Vinter";
                    case 3:
                    case 4:
                    case 5:
                        return "Forår";
                    case 6:
                    case 7:
                    case 8:
                        return "Sommer";
                    case 9:
                    case 10:
                    case 11:
                        return "Efterår";
                    default:
                        return "Invalid";
                }
            }
        }
    }
}
