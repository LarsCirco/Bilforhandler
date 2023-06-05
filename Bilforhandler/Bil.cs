using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandler
{
    internal class Bil
    {
        public string Merke { get; set; }
        public string Regnummer { get; set; }
        public int Year { get; set; }
        public int Kilometers { get; set; }

        public Bil( string merke, string reg, int year, int km )
        {
            Merke = merke;
            Regnummer = reg;
            Year = year;
            Kilometers = km;
        }
    }
}
