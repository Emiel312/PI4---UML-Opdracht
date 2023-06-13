using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI4___UML_Opdracht
{
    internal class Kok
    {
        public Balie Balie { get; set; }
        public Medewerker Medewerker { get; set; }

        public Kok(Balie balie)
        {
            Balie = balie;
            Medewerker = new Medewerker();
        }

        // Bereiden maaltijd voor een bestelling
        public Maaltijd BereidMaaltijd(Bestelling b)
        {
            Console.WriteLine($"Kok {Medewerker.Naam} bereidt de bestelling voor met een bereidingstijd van {b.Bereidingstijd} seconden voor tafel {b.Tafelnummer}.");
            return new Maaltijd(b.Tafelnummer);
        }

        // Bereiden meerdere maaltijden zolang er bestellingen zijn
        public void BereidMaaltijden()
        {
            while (Balie.ErZijnNogBestellingen())
            {
                Console.WriteLine($"Aantal bestellingen: {Balie.ToonAantalBestellingen()}");
                Maaltijd nieuweMaaltijd = BereidMaaltijd(Balie.PakBestelling());
                Balie.PlaatsMaaltijd(nieuweMaaltijd);
            }
        }
    }
}
