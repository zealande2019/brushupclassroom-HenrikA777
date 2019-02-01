using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class KlasseRum
    {
        public KlasseRum(string klasseNavn, List<Studerende> studerendeListe, DateTime semesterStart)
        {
            KlasseNavn = klasseNavn;
            StuderendeListe = studerendeListe;
            SemesterStart = semesterStart;
        }

        public string KlasseNavn { get; set; }

        public List<Studerende> StuderendeListe { get; set; }

        public DateTime SemesterStart { get; set; }

        public void PrintÅrstider()
        {
            Dictionary<string, int> årstider = new Dictionary<string, int>();
            årstider.Add("Forår", 0);
            årstider.Add("Efterår", 0);
            årstider.Add("Sommer", 0);
            årstider.Add("Vinter", 0);
            foreach (var studerende in StuderendeListe)
            {
                string caseSwitch = studerende.Årstid;
                switch (caseSwitch)
                {
                    case "Forår":
                        årstider["Forår"]++;
                        break;
                    case "Sommer":
                        årstider["Sommer"]++;
                        break;
                    case "Efterår":
                        årstider["Efterår"]++;
                        break;
                    case "Vinter":
                        årstider["Vinter"]++;
                        break;
                }
            }

            foreach (var årstid in årstider)
            {
                Console.WriteLine($"{årstid.Key}: {årstid.Value}");
            }
        }

        public override string ToString()
        {
            string output = "Klasse navn: " + KlasseNavn + "\n" + "Semester start: " + SemesterStart.ToString() + "\n" + "Studerende: \n";
            foreach (var studerende in StuderendeListe)
            {
                output +=
                    $"Navn: {studerende.Navn}       Fødselsdato: {studerende.Fødselsdag}/{studerende.Fødselsmåned} \n";
            }

            return output;
        }
    }
}
