using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI4___UML_Opdracht
{
    internal class Restaurant
    {
        public const int AANTALBESTELLINGEN = 50;
        public const int AANTALTAFELS = 20;
        public const int MAXIMALE_BEREIDINGSTIJD = 1500;
        public const int MINIMALE_BEREIDINGSTIJD = 750;

        public Balie Balie { get; set; }
        public Kok Kok { get; set; }

        public Restaurant() 
        {
            // Maak een nieuwe Balie en genereer bestellingen
            Balie = new Balie("Centrale hal");
            Balie.GenereerBestellingen();

            // Maak een nieuwe Kok en geef de Balie door
            Kok = new Kok(Balie);
        }

        public void start()
        {
            // Kok bereidt maaltijden
            Kok.BereidMaaltijden();
        }
    }
}
