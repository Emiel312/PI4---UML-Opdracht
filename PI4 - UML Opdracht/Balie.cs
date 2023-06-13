using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI4___UML_Opdracht
{
    internal class Balie
    {
        public String BalieLocatie { get; set; }
        public List<Bestelling> Bestellingen { get; set; }
        public List<Maaltijd> Maaltijden { get; set; }

        public Balie(string balieLocatie)
        {
            BalieLocatie = balieLocatie;
            Bestellingen = new List<Bestelling>();
            Maaltijden = new List<Maaltijd>();
        }

        // Controleer of er nog bestellingen zijn
        public bool ErZijnNogBestellingen()
        {
            if (Bestellingen.Count > 0)
                return true;
            else
                return false;
        }

        // Controleer of er nog maaltijden zijn
        public bool ErZijnNogMaaltijden()
        {
            if (Maaltijden.Count > 0)
                return true;
            else
                return false;
        }

        // Genereer willekeurige bestellingen
        public void GenereerBestellingen()
        {
            Random willekeurig = new Random();

            for (int i = 0; i < Restaurant.AANTALBESTELLINGEN; i++)
            {
                // Genereer een willekeurige bereidingstijd en tafelnummer
                int bereidingstijd = willekeurig.Next(Restaurant.MINIMALE_BEREIDINGSTIJD, Restaurant.MAXIMALE_BEREIDINGSTIJD);
                int tafelnummer = willekeurig.Next(1, Restaurant.AANTALBESTELLINGEN);

                Bestelling b = new Bestelling(bereidingstijd, tafelnummer);
                PlaatsBestelling(b);
            }
        }

        // Pak de laatste bestelling uit de lijst
        public Bestelling PakBestelling()
        {
            Bestelling b = Bestellingen.Last();
            Bestellingen.Remove(Bestellingen.Last());
            return b;
        }

        // Pak de laatste maaltijd uit de lijst
        public Maaltijd PakMaaltijd()
        {
            Maaltijd m = Maaltijden.Last();
            Maaltijden.Remove(Maaltijden.Last());
            return m;
        }

        // Plaats een bestelling in de lijst
        public void PlaatsBestelling(Bestelling b)
        {
            Bestellingen.Add(b);
        }

        // Plaats een maaltijd in de lijst
        public void PlaatsMaaltijd(Maaltijd m)
        {
            Maaltijden.Add(m);
        }

        // Geeft het aantal bestellingen terug
        public int ToonAantalBestellingen()
        {
            return Bestellingen.Count;
        }

        // Geeft het aantal maaltijden terug
        public int ToonAantalMaaltijden()
        {
            return Maaltijden.Count;
        }
    }
}
