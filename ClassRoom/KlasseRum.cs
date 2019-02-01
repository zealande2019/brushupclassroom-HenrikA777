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
    }
}
