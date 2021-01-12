using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQUpiti
{
    /// <summary>
    /// Repository je klasa koja će glumiti bazu podataka
    /// </summary>
    class Repository
    {
        public List<Polaznik> SviPolaznici()
        {
            List<Polaznik> polaznici = new List<Polaznik>();
            for (int i = 0; i < 1000; i++)
            {
                Polaznik polo = new Polaznik
                {
                    DatumRodenja = DateTime.Now.AddYears(-i),
                    Ime = "Ime_" + i,
                    Prezime = "Prezime_" + i,
                    UpisaniSeminar = (from s in SviSeminari()
                                      where s.Id == 1
                                      select s).Single()
                };
                polaznici.Add(polo);
            }

            return polaznici;
        }

        public List<Seminar> SviSeminari()
        {
            List<Seminar> seminari = new List<Seminar>();

            Seminar semi1 = new Seminar()
            {
                Cijena = 1234,
                Id = 1,
                Naziv = "C# osnove"
            };

            seminari.Add(semi1);

            Seminar semi2 = new Seminar
            {
                Cijena = 2300,
                Id = 2,
                Naziv = "SQL osnove"
            };
            seminari.Add(semi2);

            Seminar semi3 = new Seminar
            {
                Cijena = 4500,
                Id = 3,
                Naziv = "ASP.NET MVC"
            };
            seminari.Add(semi3);

            return seminari;
        }
    }
}
