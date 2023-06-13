using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI4___UML_Opdracht
{
    internal class Maaltijd
    {
        private int Tafelnummer { get; set; }

        public Maaltijd(int tafelnummer)
        {
            Tafelnummer = tafelnummer;
        }
        public int getTafelnummer()
        {
            return Tafelnummer;
        }
        public String toString()
        {
            return $"voor tafel {Tafelnummer}";
        }
    }
}
