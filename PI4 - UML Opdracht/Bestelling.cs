using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI4___UML_Opdracht
{
    internal class Bestelling
    {
        public int Bereidingstijd { get; set; }
        public int Tafelnummer { get; set; }

        public Bestelling(int bereidingstijd, int tafelnummer)
        {
            Bereidingstijd = bereidingstijd;
            Tafelnummer = tafelnummer;
        }
    }
}
