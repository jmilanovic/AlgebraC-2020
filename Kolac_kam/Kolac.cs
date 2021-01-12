using System;
using System.Collections.Generic;
using System.Linq;

namespace Kolac_kam
{
    public class Kolac
    {
        public List<Sastojak> listaSastojaka = new List<Sastojak>();

        public Kolac(string imeKolaca)
        {
            ImeKolaca = imeKolaca;
        }

        public string ImeKolaca { get; set; }

        private static int brojRecepata = 1;

        public Kolac()
        {
            brojRecepata++;
        }

        public static int BrojRecepata
        {
            get { return brojRecepata; }
        }

        public bool Pecenost = false;

        /// <summary>
        /// Dodavanje sastojka u listu unutar novog objekta Kolač.
        /// </summary>
        internal void DodajSastojak(string imeSastojka, int gramaza)
        {
            if (Pecenost == false)
            {
                Sastojak sastojak = new Sastojak(imeSastojka, gramaza);
                listaSastojaka.Add(sastojak);
            }
            else
            {
                Console.WriteLine("Ne možete dodati sastojak već ispečenom kolaču!");
            }

        }

        public decimal MasaKolaca { get; internal set; }

        /// <summary>
        /// Popis sastojaka kolača.
        /// </summary>
        public string PopisSastojaka
        {
            get
            {
                string popisSastojaka = "";
                foreach (Sastojak sastojak in listaSastojaka)
                {
                    popisSastojaka += sastojak.ImeSastojka + " - " + sastojak.Gramaza + " g\n";
                }
                return popisSastojaka;
            }
        }

        /// <summary>
        /// Izračun mase kolača.
        /// </summary>
        internal decimal IzracunMaseKolaca => MasaKolaca = Math.Round((decimal)listaSastojaka.Sum(sastojak => sastojak.Gramaza) / 1000, 2);

        /// <summary>
        /// Ispis podataka o kolaču.
        /// </summary>
        public override string ToString()
        {
            if (Pecenost == true)
            {
                return "Kolač '" + ImeKolaca + "' je pečen. Sastojci su:\n"
                + PopisSastojaka
                + "Ukupna masa kolača iznosi " + IzracunMaseKolaca + " kg.";
            }
            else
            {
                return "Kolač nije gotov!";
            }
        }
    }
}