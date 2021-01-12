using System;
using System.Collections.Generic;

namespace _14_Osoba_Zivotinja
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klasični način kreiranja objekata
            //i popunjavanja svojstava
            Osoba partner = new Osoba();

            partner.Ime = "Ava";
            partner.Prezime = "Karabatić";


            Osoba oso = new Osoba();
            oso.Ime = "Mirko";
            oso.Prezime = "Spirko";

            oso.Partner = partner;

            Osoba clon = (Osoba)oso.Clone();


            //Skraćeni
            Zivotinja medvjed = new Zivotinja()
            {
                LatinskiNaziv = "Ursus arctos",
                NarodniNaziv = "Mrki medvjed"
            };

            Zivotinja medo = new Zivotinja();
            medo.LatinskiNaziv = "Ursus...";
            medo.NarodniNaziv = "medvjed";



            // Na isti nacin ispisujemo dva razlicita objekta, koja djele isti IF
            Ispis(medo);
            Ispis(medvjed);
            Ispis(oso);
            Ispis(partner);
            Ispis(clon);

            Console.WriteLine("Ispis comperable");
            List<Osoba> poredakPoPlaci = new List<Osoba>();
            
            poredakPoPlaci.Add(partner);
            poredakPoPlaci.Add(clon);

            Console.WriteLine("Ispis comperable prije sort");
            foreach (var item in poredakPoPlaci)
            {
                Ispis(item);
            }

            poredakPoPlaci.Sort();

            Console.WriteLine("Ispis comperable nakon sort");
            foreach (var item in poredakPoPlaci)
            {
                Ispis(item);
            }
        

            Console.ReadKey();

        }

        static void Ispis(IMojInterface klasaZaIspis)
        {
            Console.WriteLine(klasaZaIspis.PunoIme());

        }
    }
}
